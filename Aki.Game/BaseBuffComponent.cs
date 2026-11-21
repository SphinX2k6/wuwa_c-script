using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using Aki.Protocol;
using Aki.Protocol.BattleDefine;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Typing;

// Token: 0x020023B4 RID: 9140
[NullableContext(1)]
[Nullable(0)]
public class BaseBuffComponent : EntityComponent, IBuffComponent, IStaticVariableResetter
{
	// Token: 0x06016DED RID: 93677 RVA: 0x006AAB7C File Offset: 0x006A8D7C
	static BaseBuffComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseBuffComponent.CreateStaticDefaultValue), new Action(BaseBuffComponent.ResetStaticDefaultValue));
	}

	// Token: 0x1700231A RID: 8986
	// (get) Token: 0x06016DEE RID: 93678 RVA: 0x006AAD0D File Offset: 0x006A8F0D
	public long CreatureDataId
	{
		get
		{
			return this.CreatureDataComponent.GetCreatureDataId();
		}
	}

	// Token: 0x1700231B RID: 8987
	// (get) Token: 0x06016DEF RID: 93679 RVA: 0x006AAD1A File Offset: 0x006A8F1A
	// (set) Token: 0x06016DF0 RID: 93680 RVA: 0x006AAD22 File Offset: 0x006A8F22
	[Nullable(2)]
	public ExtraEffectManager BuffEffectManager { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x06016DF1 RID: 93681 RVA: 0x006AAD2B File Offset: 0x006A8F2B
	public virtual string GetDebugName()
	{
		return "";
	}

	// Token: 0x06016DF2 RID: 93682 RVA: 0x006AAD34 File Offset: 0x006A8F34
	protected override bool OnInit()
	{
		base.OnInit();
		this.CreatureDataComponent = base.Entity.GetComponent<CreatureDataComponent>();
		this.DeathComponent = base.Entity.GetComponent<BaseDeathComponent>();
		EventSystem.Instance.Add<int>(EEventName.CharOnRoleDead, new Action<int>(this.OnAnyInstigatorDead));
		EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnAnyInstigatorRemoved));
		return true;
	}

	// Token: 0x06016DF3 RID: 93683 RVA: 0x006AADA4 File Offset: 0x006A8FA4
	protected override bool OnClear()
	{
		BuffController.Instance.UnregisterBuffComponent(this);
		ExtraEffectManager buffEffectManager = this.BuffEffectManager;
		if (buffEffectManager != null)
		{
			foreach (BuffEffect buffEffect in buffEffectManager.GetAllEffects())
			{
				if (buffEffect != null)
				{
					buffEffect.OnRemoved(true);
				}
			}
			buffEffectManager.Clear();
		}
		foreach (ActiveBuffInternal activeBuffInternal in this.BuffContainer.Values)
		{
			ExtraEffectParameters[] effectInfos = activeBuffInternal.Config.EffectInfos;
			for (int i = 0; i < effectInfos.Length; i++)
			{
				BuffExecution executionEffect = effectInfos[i].ExecutionEffect;
				if (executionEffect != null)
				{
					executionEffect.OnBuffRemovedCallback(activeBuffInternal);
				}
			}
		}
		this.BuffContainer.Clear();
		this.BuffGarbageSet.Clear();
		this.PendingAddBuff.Clear();
		this.EffectTimeoutMap.Clear();
		this.EffectTargetTimeoutMap.Clear();
		this.TagInChanged.Clear();
		this.ConfigOverrideConditionListener.Clear();
		this.SeamlessTravelBuffCue = null;
		if (EventSystem.Instance.Has<int>(EEventName.CharOnRoleDead, new Action<int>(this.OnAnyInstigatorDead)))
		{
			EventSystem.Instance.Remove<int>(EEventName.CharOnRoleDead, new Action<int>(this.OnAnyInstigatorDead));
		}
		if (EventSystem.Instance.Has<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnAnyInstigatorRemoved)))
		{
			EventSystem.Instance.Remove<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnAnyInstigatorRemoved));
		}
		this.InstigatorEventListenDict.Clear();
		return true;
	}

	// Token: 0x06016DF4 RID: 93684 RVA: 0x006AAF58 File Offset: 0x006A9158
	protected override void OnTick(float delta)
	{
		this.BuffLock = 0;
		this.TagInChanged.Clear();
	}

	// Token: 0x06016DF5 RID: 93685 RVA: 0x006AAF6C File Offset: 0x006A916C
	protected virtual void InitBornBuff()
	{
	}

	// Token: 0x06016DF6 RID: 93686 RVA: 0x006AAF6E File Offset: 0x006A916E
	[NullableContext(2)]
	protected virtual bool NeedBroadcastBuff(ActiveBuffInternal buff, bool fromServer = false)
	{
		return !fromServer && (buff == null || !buff.Config.OnlyLocalAdd) && this.HasBuffAuthority();
	}

	// Token: 0x06016DF7 RID: 93687 RVA: 0x006AAF8D File Offset: 0x006A918D
	public virtual bool HasBuffAuthority()
	{
		return false;
	}

	// Token: 0x06016DF8 RID: 93688 RVA: 0x006AAF90 File Offset: 0x006A9190
	protected virtual bool NeedAddBuffOrder(long buffId)
	{
		return true;
	}

	// Token: 0x06016DF9 RID: 93689 RVA: 0x006AAF93 File Offset: 0x006A9193
	[NullableContext(2)]
	public virtual Entity GetEntity()
	{
		return null;
	}

	// Token: 0x06016DFA RID: 93690 RVA: 0x006AAF96 File Offset: 0x006A9196
	[NullableContext(2)]
	public virtual Entity GetExactEntity()
	{
		return base.Entity;
	}

	// Token: 0x06016DFB RID: 93691 RVA: 0x006AAF9E File Offset: 0x006A919E
	[NullableContext(2)]
	public virtual BaseAttributeComponent GetAttributeComponent()
	{
		return null;
	}

	// Token: 0x06016DFC RID: 93692 RVA: 0x006AAFA1 File Offset: 0x006A91A1
	[NullableContext(2)]
	public virtual BaseTagComponent GetTagComponent()
	{
		return null;
	}

	// Token: 0x06016DFD RID: 93693 RVA: 0x006AAFA4 File Offset: 0x006A91A4
	[NullableContext(2)]
	public virtual BaseSkillComponent GetSkillComponent()
	{
		return null;
	}

	// Token: 0x06016DFE RID: 93694 RVA: 0x006AAFA7 File Offset: 0x006A91A7
	[NullableContext(2)]
	public virtual CharacterPassiveSkillComponent GetPassiveSkillComponent()
	{
		Entity entity = this.GetEntity();
		if (entity == null)
		{
			return null;
		}
		return entity.GetComponent<CharacterPassiveSkillComponent>();
	}

	// Token: 0x06016DFF RID: 93695 RVA: 0x006AAFBA File Offset: 0x006A91BA
	[NullableContext(2)]
	public virtual BaseActorComponent GetActorComponent()
	{
		return null;
	}

	// Token: 0x06016E00 RID: 93696 RVA: 0x006AAFBD File Offset: 0x006A91BD
	[NullableContext(2)]
	public virtual BaseGameplayCueComponent GetCueComponent()
	{
		return null;
	}

	// Token: 0x06016E01 RID: 93697 RVA: 0x006AAFC0 File Offset: 0x006A91C0
	public virtual float GetTimeScale()
	{
		return 0f;
	}

	// Token: 0x06016E02 RID: 93698 RVA: 0x006AAFC7 File Offset: 0x006A91C7
	public virtual float GetLogicTimeScale()
	{
		return 1f;
	}

	// Token: 0x06016E03 RID: 93699 RVA: 0x006AAFD0 File Offset: 0x006A91D0
	[NullableContext(2)]
	protected Entity ResolveBuffStackInstigator(long? instigatorId)
	{
		if (instigatorId != null)
		{
			long? num = instigatorId;
			long num2 = 0L;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(instigatorId.Value);
				WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
				if (worldEntity == null || !worldEntity.Valid || !worldEntity.IsInit)
				{
					return null;
				}
				return worldEntity;
			}
		}
		return null;
	}

	// Token: 0x06016E04 RID: 93700 RVA: 0x006AB038 File Offset: 0x006A9238
	protected void EmitBuffStackInstigatorChanged(long buffId, int oldStack, int newStack, long? instigatorId)
	{
		Entity entity = this.ResolveBuffStackInstigator(instigatorId);
		if (entity == null)
		{
			return;
		}
		SceneTeamController.Instance.EmitAbilityEvent<long, int, int, Entity, Entity>(entity, EAbilityEventName.BuffStackInstigatorChanged, buffId, buffId, oldStack, newStack, base.Entity, entity);
	}

	// Token: 0x06016E05 RID: 93701 RVA: 0x006AB069 File Offset: 0x006A9269
	protected static bool HasBuffStackMaxListener()
	{
		return AbilityEvent.Instance.HasListener(EAbilityEventName.BuffStackMaxChanged);
	}

	// Token: 0x06016E06 RID: 93702 RVA: 0x006AB078 File Offset: 0x006A9278
	protected void EmitBuffStackMaxChanged(long buffId, int oldMax, int newMax)
	{
		if (newMax >= 2147483647)
		{
			return;
		}
		int num = Math.Max(1, oldMax);
		int num2 = Math.Max(1, newMax);
		if (num == num2)
		{
			return;
		}
		SceneTeamController.Instance.EmitAbilityEvent<long, int, int, Entity>(base.Entity, EAbilityEventName.BuffStackMaxChanged, buffId, buffId, num, num2, base.Entity);
	}

	// Token: 0x06016E07 RID: 93703 RVA: 0x006AB0C0 File Offset: 0x006A92C0
	private void AddHandleMark<TKey>(Dictionary<TKey, HashSet<int>> dict, TKey key, int handle)
	{
		HashSet<int> hashSet;
		if (!dict.TryGetValue(key, out hashSet))
		{
			hashSet = new HashSet<int>();
			dict[key] = hashSet;
		}
		hashSet.Add(handle);
	}

	// Token: 0x06016E08 RID: 93704 RVA: 0x006AB0F0 File Offset: 0x006A92F0
	public void AddEntityMark<TKey>(Dictionary<TKey, Dictionary<long, HashSet<int>>> dict, TKey key, long creatureDataId, int handle)
	{
		Dictionary<long, HashSet<int>> dictionary;
		if (!dict.TryGetValue(key, out dictionary))
		{
			dictionary = new Dictionary<long, HashSet<int>>();
			dict[key] = dictionary;
		}
		HashSet<int> hashSet;
		if (!dictionary.TryGetValue(creatureDataId, out hashSet))
		{
			hashSet = new HashSet<int>();
			dictionary[creatureDataId] = hashSet;
		}
		hashSet.Add(handle);
	}

	// Token: 0x06016E09 RID: 93705 RVA: 0x006AB138 File Offset: 0x006A9338
	private void RemoveHandleMark<TKey>(Dictionary<TKey, HashSet<int>> dict, TKey key, int handle)
	{
		HashSet<int> hashSet;
		if (dict.TryGetValue(key, out hashSet))
		{
			hashSet.Remove(handle);
			if (hashSet.Count <= 0)
			{
				dict.Remove(key);
			}
		}
	}

	// Token: 0x06016E0A RID: 93706 RVA: 0x006AB16C File Offset: 0x006A936C
	public void RemoveEntityMark<TKey>(Dictionary<TKey, Dictionary<long, HashSet<int>>> dict, TKey key, long creatureDataId, int handle)
	{
		Dictionary<long, HashSet<int>> dictionary;
		HashSet<int> hashSet;
		if (dict.TryGetValue(key, out dictionary) && dictionary.TryGetValue(creatureDataId, out hashSet))
		{
			hashSet.Remove(handle);
			if (hashSet.Count <= 0)
			{
				dictionary.Remove(creatureDataId);
				if (dictionary.Count <= 0)
				{
					dict.Remove(key);
				}
			}
		}
	}

	// Token: 0x06016E0B RID: 93707 RVA: 0x006AB1BC File Offset: 0x006A93BC
	protected int[] GetInvolvedTags(BuffDefinition config)
	{
		List<int> list = new List<int>();
		if (config.ActivateTagRequirements != null)
		{
			list.AddRange(config.ActivateTagRequirements);
		}
		if (config.ActivateTagIgnores != null)
		{
			list.AddRange(config.ActivateTagIgnores);
		}
		if (config.RemoveTagExistAll != null)
		{
			list.AddRange(config.RemoveTagExistAll);
		}
		if (config.RemoveTagExistAny != null)
		{
			list.AddRange(config.RemoveTagExistAny);
		}
		if (config.RemoveTagIgnores != null)
		{
			list.AddRange(config.RemoveTagIgnores);
		}
		if (config.BuffAction != null)
		{
			foreach (TBuffAction tbuffAction in config.BuffAction)
			{
				EBuffActionType type = tbuffAction.Type;
				if (type - EBuffActionType.RemoveBuffWhenVictimHasSomeTag <= 7)
				{
					list.AddRange(tbuffAction.Tags);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06016E0C RID: 93708 RVA: 0x006AB278 File Offset: 0x006A9478
	protected long[] GetInvolvedBuffIds(BuffDefinition config)
	{
		List<long> list = new List<long>();
		if (config.BuffAction != null)
		{
			foreach (TBuffAction tbuffAction in config.BuffAction)
			{
				EBuffActionType type = tbuffAction.Type;
				if (type - EBuffActionType.RemoveBuffWhenVictimHasSomeBuff <= 7)
				{
					list.AddRange(tbuffAction.Buffs);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06016E0D RID: 93709 RVA: 0x006AB2D0 File Offset: 0x006A94D0
	protected int[] GetInvolvedInstigatorTags(BuffDefinition config)
	{
		List<int> list = new List<int>();
		if (config.BuffAction != null)
		{
			foreach (TBuffAction tbuffAction in config.BuffAction)
			{
				EBuffActionType type = tbuffAction.Type;
				if (type - EBuffActionType.RemoveBuffWhenInstigatorHasSomeTag <= 7)
				{
					list.AddRange(tbuffAction.Tags);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06016E0E RID: 93710 RVA: 0x006AB328 File Offset: 0x006A9528
	protected long[] GetInvolvedInstigatorBuffIds(BuffDefinition config)
	{
		List<long> list = new List<long>();
		if (config.BuffAction != null)
		{
			foreach (TBuffAction tbuffAction in config.BuffAction)
			{
				EBuffActionType type = tbuffAction.Type;
				if (type - EBuffActionType.RemoveBuffWhenInstigatorHasSomeBuff <= 7)
				{
					list.AddRange(tbuffAction.Buffs);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06016E0F RID: 93711 RVA: 0x006AB380 File Offset: 0x006A9580
	protected List<TBuffAction> GetInstigatorEventActions(BuffDefinition config)
	{
		List<TBuffAction> list = new List<TBuffAction>();
		if (config.BuffAction != null)
		{
			foreach (TBuffAction tbuffAction in config.BuffAction)
			{
				if (tbuffAction.Type == EBuffActionType.RemoveBuffWhenInstigatorDeadOrRemoved)
				{
					list.Add(tbuffAction);
				}
			}
		}
		return list;
	}

	// Token: 0x06016E10 RID: 93712 RVA: 0x006AB3C8 File Offset: 0x006A95C8
	protected void RegisterInstigatorEventListener(ActiveBuffInternal buff)
	{
		List<TBuffAction> instigatorEventActions = this.GetInstigatorEventActions(buff.Config);
		if (instigatorEventActions.Count == 0)
		{
			return;
		}
		Entity instigator = buff.GetInstigator();
		if (instigator == null)
		{
			return;
		}
		int id = instigator.Id;
		int handle = buff.Handle;
		foreach (TBuffAction tbuffAction in instigatorEventActions)
		{
			if (tbuffAction.CustomParams != null)
			{
				foreach (int key in tbuffAction.CustomParams)
				{
					Dictionary<int, List<int>> dictionary;
					if (!this.InstigatorEventListenDict.TryGetValue(id, out dictionary))
					{
						dictionary = new Dictionary<int, List<int>>();
						this.InstigatorEventListenDict[id] = dictionary;
					}
					List<int> list;
					if (!dictionary.TryGetValue(key, out list))
					{
						list = new List<int>();
						dictionary[key] = list;
					}
					list.Add(handle);
				}
			}
		}
	}

	// Token: 0x06016E11 RID: 93713 RVA: 0x006AB4C0 File Offset: 0x006A96C0
	protected void UnregisterInstigatorEventListener(ActiveBuffInternal buff)
	{
		Entity instigator = buff.GetInstigator();
		if (instigator == null)
		{
			return;
		}
		int id = instigator.Id;
		Dictionary<int, List<int>> dictionary;
		if (!this.InstigatorEventListenDict.TryGetValue(id, out dictionary))
		{
			return;
		}
		int handle = buff.Handle;
		foreach (int key in new List<int>(dictionary.Keys))
		{
			List<int> list = dictionary[key];
			list.Remove(handle);
			if (list.Count == 0)
			{
				dictionary.Remove(key);
			}
		}
		if (dictionary.Count == 0)
		{
			this.InstigatorEventListenDict.Remove(id);
		}
	}

	// Token: 0x06016E12 RID: 93714 RVA: 0x006AB574 File Offset: 0x006A9774
	private void OnAnyInstigatorDead(int charId)
	{
		Dictionary<int, List<int>> dictionary;
		if (!this.InstigatorEventListenDict.TryGetValue(charId, out dictionary) || dictionary.Count == 0)
		{
			return;
		}
		List<int> collection;
		if (dictionary.TryGetValue(0, out collection))
		{
			foreach (int handle in new List<int>(collection))
			{
				if (this.GetBuffByHandle(handle) != null && this.HasBuffAuthority())
				{
					this.RemoveBuffByHandle(handle, -1, "因为创建者死亡触发BuffAction", null, null, null);
				}
			}
		}
	}

	// Token: 0x06016E13 RID: 93715 RVA: 0x006AB628 File Offset: 0x006A9828
	private void OnAnyInstigatorRemoved(ERemoveEntityType removeType, EntityHandle handle)
	{
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(handle.Id);
		WorldEntity worldEntity = (entityById != null) ? entityById.Entity : null;
		if (worldEntity == null)
		{
			return;
		}
		int id = worldEntity.Id;
		Dictionary<int, List<int>> dictionary;
		if (!this.InstigatorEventListenDict.TryGetValue(id, out dictionary) || dictionary.Count == 0)
		{
			return;
		}
		List<int> collection;
		if (dictionary.TryGetValue(1, out collection))
		{
			foreach (int handle2 in new List<int>(collection))
			{
				if (this.GetBuffByHandle(handle2) != null && this.HasBuffAuthority())
				{
					this.RemoveBuffByHandle(handle2, -1, "因为创建者移出队伍触发BuffAction", null, null, null);
				}
			}
		}
	}

	// Token: 0x06016E14 RID: 93716 RVA: 0x006AB704 File Offset: 0x006A9904
	protected void MarkListenerBuff(ActiveBuffInternal buff)
	{
		if (!this.NeedCheck(buff.Config))
		{
			return;
		}
		BuffDefinition config = buff.Config;
		if (config == null)
		{
			return;
		}
		int handle = buff.Handle;
		foreach (int key in this.GetInvolvedTags(config))
		{
			this.AddHandleMark<int>(this.TagListenerDict, key, handle);
		}
		foreach (long key2 in this.GetInvolvedBuffIds(config))
		{
			this.AddHandleMark<long>(this.BuffListenerDict, key2, handle);
		}
		if (config.ImmuneTags != null)
		{
			foreach (int key3 in config.ImmuneTags)
			{
				this.AddHandleMark<int>(this.TagImmuneListenerDict, key3, handle);
			}
		}
		CharacterBuffComponent instigatorBuffComponent = buff.GetInstigatorBuffComponent();
		CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
		long? num = (creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null;
		if (instigatorBuffComponent != null && num != null)
		{
			foreach (int key4 in this.GetInvolvedInstigatorTags(config))
			{
				instigatorBuffComponent.AddEntityMark<int>(instigatorBuffComponent.VictimTagListenerDict, key4, num.Value, handle);
			}
			foreach (long key5 in this.GetInvolvedInstigatorBuffIds(config))
			{
				instigatorBuffComponent.AddEntityMark<long>(instigatorBuffComponent.VictimBuffListenerDict, key5, num.Value, handle);
			}
		}
		this.RegisterInstigatorEventListener(buff);
	}

	// Token: 0x06016E15 RID: 93717 RVA: 0x006AB87C File Offset: 0x006A9A7C
	protected void RemoveListenerBuff(ActiveBuffInternal buff)
	{
		if (!this.NeedCheck(buff.Config))
		{
			return;
		}
		BuffDefinition config = buff.Config;
		if (config == null)
		{
			return;
		}
		int handle = buff.Handle;
		foreach (int key in this.GetInvolvedTags(config))
		{
			this.RemoveHandleMark<int>(this.TagListenerDict, key, handle);
		}
		foreach (long key2 in this.GetInvolvedBuffIds(config))
		{
			this.RemoveHandleMark<long>(this.BuffListenerDict, key2, handle);
		}
		if (config.ImmuneTags != null)
		{
			foreach (int key3 in config.ImmuneTags)
			{
				this.RemoveHandleMark<int>(this.TagImmuneListenerDict, key3, handle);
			}
		}
		CharacterBuffComponent instigatorBuffComponent = buff.GetInstigatorBuffComponent();
		CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
		long? num = (creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null;
		if (instigatorBuffComponent != null && num != null)
		{
			foreach (int key4 in this.GetInvolvedInstigatorTags(config))
			{
				instigatorBuffComponent.RemoveEntityMark<int>(instigatorBuffComponent.VictimTagListenerDict, key4, num.Value, handle);
			}
			foreach (long key5 in this.GetInvolvedInstigatorBuffIds(config))
			{
				instigatorBuffComponent.RemoveEntityMark<long>(instigatorBuffComponent.VictimBuffListenerDict, key5, num.Value, handle);
			}
		}
		this.UnregisterInstigatorEventListener(buff);
	}

	// Token: 0x06016E16 RID: 93718 RVA: 0x006AB9F4 File Offset: 0x006A9BF4
	protected void CheckWhenTagChanged(int tagId)
	{
		int i = this.BuffLock;
		this.BuffLock = i + 1;
		HashSet<int> hashSet;
		if (this.TagListenerDict.TryGetValue(tagId, out hashSet))
		{
			string nameByTagId = GameplayTagUtils.GetNameByTagId(tagId);
			int[] array = new int[hashSet.Count];
			hashSet.CopyTo(array);
			foreach (int handle in array)
			{
				IActiveBuff buffByHandle = this.GetBuffByHandle(handle);
				if (buffByHandle != null && this.CheckRemove(buffByHandle.Config, buffByHandle.GetInstigator()))
				{
					this.RemoveBuffInner(handle, -1, true, "因为tag " + nameByTagId + "的变化触发", null, null, null);
				}
			}
			int[] array3 = new int[hashSet.Count];
			hashSet.CopyTo(array3);
			foreach (int handle2 in array3)
			{
				IActiveBuff buffByHandle2 = this.GetBuffByHandle(handle2);
				if (buffByHandle2 == null)
				{
					this.RemoveHandleMark<int>(this.TagListenerDict, tagId, handle2);
				}
				else
				{
					bool flag = this.CheckActivate(buffByHandle2.Config, buffByHandle2.GetInstigator());
					if (flag != buffByHandle2.IsActive())
					{
						this.OnBuffActiveChanged(buffByHandle2 as ActiveBuffInternal, flag, null);
					}
				}
			}
		}
		Dictionary<long, HashSet<int>> collection;
		if (this.VictimTagListenerDict.TryGetValue(tagId, out collection))
		{
			string nameByTagId2 = GameplayTagUtils.GetNameByTagId(tagId);
			foreach (KeyValuePair<long, HashSet<int>> keyValuePair in new List<KeyValuePair<long, HashSet<int>>>(collection))
			{
				long num;
				HashSet<int> hashSet2;
				keyValuePair.Deconstruct(out num, out hashSet2);
				long creatureDataId = num;
				HashSet<int> hashSet3 = hashSet2;
				int[] array4 = new int[hashSet3.Count];
				hashSet3.CopyTo(array4);
				foreach (int handle3 in array4)
				{
					EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
					BaseBuffComponent baseBuffComponent;
					if (entity == null)
					{
						baseBuffComponent = null;
					}
					else
					{
						WorldEntity entity2 = entity.Entity;
						baseBuffComponent = ((entity2 != null) ? entity2.GetComponent<BaseBuffComponent>() : null);
					}
					BaseBuffComponent baseBuffComponent2 = baseBuffComponent;
					IActiveBuff activeBuff = (baseBuffComponent2 != null) ? baseBuffComponent2.GetBuffByHandle(handle3) : null;
					if (baseBuffComponent2 != null && activeBuff != null && baseBuffComponent2.CheckRemove(activeBuff.Config, activeBuff.GetInstigator()))
					{
						baseBuffComponent2.RemoveBuffInner(handle3, -1, true, "因为施加者的tag " + nameByTagId2 + "的变化触发", null, null, null);
					}
				}
			}
			foreach (KeyValuePair<long, HashSet<int>> keyValuePair in new List<KeyValuePair<long, HashSet<int>>>(collection))
			{
				long num;
				HashSet<int> hashSet2;
				keyValuePair.Deconstruct(out num, out hashSet2);
				long creatureDataId2 = num;
				HashSet<int> hashSet4 = hashSet2;
				int[] array5 = new int[hashSet4.Count];
				hashSet4.CopyTo(array5);
				foreach (int handle4 in array5)
				{
					EntityHandle entity3 = CreatureModel.Instance.GetEntity(creatureDataId2);
					BaseBuffComponent baseBuffComponent3;
					if (entity3 == null)
					{
						baseBuffComponent3 = null;
					}
					else
					{
						WorldEntity entity4 = entity3.Entity;
						baseBuffComponent3 = ((entity4 != null) ? entity4.GetComponent<BaseBuffComponent>() : null);
					}
					BaseBuffComponent baseBuffComponent4 = baseBuffComponent3;
					IActiveBuff activeBuff2 = (baseBuffComponent4 != null) ? baseBuffComponent4.GetBuffByHandle(handle4) : null;
					if (baseBuffComponent4 == null || activeBuff2 == null)
					{
						this.RemoveEntityMark<int>(this.VictimTagListenerDict, tagId, creatureDataId2, handle4);
					}
					else
					{
						bool flag2 = baseBuffComponent4.CheckActivate(activeBuff2.Config, activeBuff2.GetInstigator());
						if (flag2 != activeBuff2.IsActive() && baseBuffComponent4 != null)
						{
							baseBuffComponent4.OnBuffActiveChanged(activeBuff2 as ActiveBuffInternal, flag2, null);
						}
					}
				}
			}
		}
		i = this.BuffLock;
		this.BuffLock = i - 1;
	}

	// Token: 0x06016E17 RID: 93719 RVA: 0x006ABDA0 File Offset: 0x006A9FA0
	protected void CheckWhenBuffChanged(long buffId)
	{
		HashSet<int> hashSet;
		if (this.BuffListenerDict.TryGetValue(buffId, out hashSet))
		{
			int i = this.BuffLock;
			this.BuffLock = i + 1;
			int[] array = new int[hashSet.Count];
			hashSet.CopyTo(array);
			foreach (int num in array)
			{
				IActiveBuff buffByHandle = this.GetBuffByHandle(num);
				if (buffByHandle != null && this.CheckRemove(buffByHandle.Config, buffByHandle.GetInstigator()))
				{
					int handle = num;
					int removeStackCount = -1;
					bool isPrematureRemoval = true;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral("因为buff ");
					defaultInterpolatedStringHandler.AppendFormatted<long>(buffId);
					defaultInterpolatedStringHandler.AppendLiteral("的变化触发");
					this.RemoveBuffInner(handle, removeStackCount, isPrematureRemoval, defaultInterpolatedStringHandler.ToStringAndClear(), null, null, null);
				}
			}
			int[] array3 = new int[hashSet.Count];
			hashSet.CopyTo(array3);
			foreach (int handle2 in array3)
			{
				IActiveBuff buffByHandle2 = this.GetBuffByHandle(handle2);
				if (buffByHandle2 == null)
				{
					this.RemoveHandleMark<long>(this.BuffListenerDict, buffId, handle2);
				}
				else
				{
					bool flag = this.CheckActivate(buffByHandle2.Config, buffByHandle2.GetInstigator());
					if (flag != buffByHandle2.IsActive())
					{
						this.OnBuffActiveChanged(buffByHandle2 as ActiveBuffInternal, flag, null);
					}
				}
			}
			i = this.BuffLock;
			this.BuffLock = i - 1;
		}
		Dictionary<long, HashSet<int>> collection;
		if (this.VictimBuffListenerDict.TryGetValue(buffId, out collection))
		{
			int i = this.BuffLock;
			this.BuffLock = i + 1;
			foreach (KeyValuePair<long, HashSet<int>> keyValuePair in new List<KeyValuePair<long, HashSet<int>>>(collection))
			{
				long num2;
				HashSet<int> hashSet2;
				keyValuePair.Deconstruct(out num2, out hashSet2);
				long creatureDataId = num2;
				HashSet<int> hashSet3 = hashSet2;
				int[] array4 = new int[hashSet3.Count];
				hashSet3.CopyTo(array4);
				foreach (int num3 in array4)
				{
					EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
					BaseBuffComponent baseBuffComponent;
					if (entity == null)
					{
						baseBuffComponent = null;
					}
					else
					{
						WorldEntity entity2 = entity.Entity;
						baseBuffComponent = ((entity2 != null) ? entity2.GetComponent<BaseBuffComponent>() : null);
					}
					BaseBuffComponent baseBuffComponent2 = baseBuffComponent;
					IActiveBuff activeBuff = (baseBuffComponent2 != null) ? baseBuffComponent2.GetBuffByHandle(num3) : null;
					if (baseBuffComponent2 != null && activeBuff != null && baseBuffComponent2.CheckRemove(activeBuff.Config, activeBuff.GetInstigator()))
					{
						BaseBuffComponent baseBuffComponent3 = baseBuffComponent2;
						int handle3 = num3;
						int removeStackCount2 = -1;
						bool isPrematureRemoval2 = true;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
						defaultInterpolatedStringHandler.AppendLiteral("因为施加者的buff ");
						defaultInterpolatedStringHandler.AppendFormatted<long>(buffId);
						defaultInterpolatedStringHandler.AppendLiteral("的变化触发");
						baseBuffComponent3.RemoveBuffInner(handle3, removeStackCount2, isPrematureRemoval2, defaultInterpolatedStringHandler.ToStringAndClear(), null, null, null);
					}
				}
			}
			foreach (KeyValuePair<long, HashSet<int>> keyValuePair in new List<KeyValuePair<long, HashSet<int>>>(collection))
			{
				long num2;
				HashSet<int> hashSet2;
				keyValuePair.Deconstruct(out num2, out hashSet2);
				long creatureDataId2 = num2;
				HashSet<int> hashSet4 = hashSet2;
				int[] array5 = new int[hashSet4.Count];
				hashSet4.CopyTo(array5);
				foreach (int handle4 in array5)
				{
					EntityHandle entity3 = CreatureModel.Instance.GetEntity(creatureDataId2);
					BaseBuffComponent baseBuffComponent4;
					if (entity3 == null)
					{
						baseBuffComponent4 = null;
					}
					else
					{
						WorldEntity entity4 = entity3.Entity;
						baseBuffComponent4 = ((entity4 != null) ? entity4.GetComponent<BaseBuffComponent>() : null);
					}
					BaseBuffComponent baseBuffComponent5 = baseBuffComponent4;
					IActiveBuff activeBuff2 = (baseBuffComponent5 != null) ? baseBuffComponent5.GetBuffByHandle(handle4) : null;
					if (baseBuffComponent5 == null || activeBuff2 == null)
					{
						this.RemoveEntityMark<long>(this.VictimBuffListenerDict, buffId, creatureDataId2, handle4);
					}
					else
					{
						bool flag2 = baseBuffComponent5.CheckActivate(activeBuff2.Config, activeBuff2.GetInstigator());
						if (flag2 != activeBuff2.IsActive() && baseBuffComponent5 != null)
						{
							baseBuffComponent5.OnBuffActiveChanged(activeBuff2 as ActiveBuffInternal, flag2, null);
						}
					}
				}
			}
			i = this.BuffLock;
			this.BuffLock = i - 1;
		}
	}

	// Token: 0x06016E18 RID: 93720 RVA: 0x006AC1D4 File Offset: 0x006AA3D4
	protected void UnregisterConfigOverrideListener(ActiveBuffInternal buff)
	{
		int? configOverrideListenerId = buff.GetConfigOverrideListenerId();
		if (configOverrideListenerId != null)
		{
			this.ConfigOverrideConditionListener.RemoveListener(configOverrideListenerId.Value);
		}
	}

	// Token: 0x06016E19 RID: 93721 RVA: 0x006AC204 File Offset: 0x006AA404
	public void AddBuffRoutineExpirationLock(long buffId)
	{
		int valueOrDefault = this.BuffRoutineExpirationLock.GetValueOrDefault(buffId, 0);
		this.BuffRoutineExpirationLock[buffId] = valueOrDefault + 1;
	}

	// Token: 0x06016E1A RID: 93722 RVA: 0x006AC230 File Offset: 0x006AA430
	public void RemoveBuffRoutineExpirationLock(long buffId)
	{
		int valueOrDefault = this.BuffRoutineExpirationLock.GetValueOrDefault(buffId, 0);
		if (valueOrDefault <= 1)
		{
			this.BuffRoutineExpirationLock.Remove(buffId);
			return;
		}
		this.BuffRoutineExpirationLock[buffId] = valueOrDefault - 1;
	}

	// Token: 0x06016E1B RID: 93723 RVA: 0x006AC26C File Offset: 0x006AA46C
	public virtual bool HasBuffRoutineExpirationLock(long buffId)
	{
		return this.BuffRoutineExpirationLock.GetValueOrDefault(buffId, 0) > 0;
	}

	// Token: 0x06016E1C RID: 93724 RVA: 0x006AC27E File Offset: 0x006AA47E
	public virtual bool IsPaused()
	{
		return false;
	}

	// Token: 0x06016E1D RID: 93725 RVA: 0x006AC284 File Offset: 0x006AA484
	public void RefreshTimeScale()
	{
		float timeScale = this.GetTimeScale();
		bool forcePaused = this.IsPaused();
		foreach (ActiveBuffInternal activeBuffInternal in this.BuffContainer.Values)
		{
			activeBuffInternal.OnTimeScaleChanged(timeScale, forcePaused);
		}
	}

	// Token: 0x06016E1E RID: 93726 RVA: 0x006AC2EC File Offset: 0x006AA4EC
	protected override void OnChangeTimeDilation(float timeDilation)
	{
		this.RefreshTimeScale();
	}

	// Token: 0x06016E1F RID: 93727 RVA: 0x006AC2F4 File Offset: 0x006AA4F4
	public bool NeedCheck(BuffDefinition config)
	{
		return config != null && (config.Id.GetValueOrDefault() == -3L || this.HasBuffAuthority());
	}

	// Token: 0x06016E20 RID: 93728 RVA: 0x006AC314 File Offset: 0x006AA514
	protected virtual bool CheckAdd(BuffDefinition config, long instigatorId, bool fromServer)
	{
		if (fromServer)
		{
			return true;
		}
		if (!fromServer && this.NeedCheck(config))
		{
			BaseDeathComponent deathComponent = this.DeathComponent;
			if (deathComponent != null && deathComponent.IsDead() && config.EffectInfos != null)
			{
				ExtraEffectParameters[] effectInfos = config.EffectInfos;
				for (int i = 0; i < effectInfos.Length; i++)
				{
					if (effectInfos[i].ExtraEffectId == EExtraEffectId.Frozen)
					{
						return false;
					}
				}
			}
			BaseTagComponent tagComponent = this.GetTagComponent();
			EntityHandle entity = CreatureModel.Instance.GetEntity(instigatorId);
			WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
			BaseTagComponent baseTagComponent = (worldEntity != null) ? worldEntity.GetComponent<BaseTagComponent>() : null;
			if (config.Probability < 10000 && RandomSystem.GetRandomPercent() > (float)config.Probability)
			{
				return false;
			}
			if (tagComponent == null)
			{
				return false;
			}
			if (config.AddTagIgnores != null)
			{
				foreach (int tagId in config.AddTagIgnores)
				{
					if (tagComponent.HasTag(tagId))
					{
						return false;
					}
				}
			}
			if (config.AddTagRequirements != null)
			{
				foreach (int tagId2 in config.AddTagRequirements)
				{
					if (!tagComponent.HasTag(tagId2))
					{
						return false;
					}
				}
			}
			if (this.CheckRemove(config, worldEntity))
			{
				return false;
			}
			if (config.RemoveTagIgnores != null && config.RemoveTagIgnores.Length != 0)
			{
				bool flag = false;
				foreach (int tagId3 in config.RemoveTagIgnores)
				{
					if (tagComponent.HasTag(tagId3))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			int[] array2 = config.RemoveTagExistAll ?? Array.Empty<int>();
			if (array2.Length != 0)
			{
				bool flag2 = true;
				foreach (int tagId4 in array2)
				{
					if (!tagComponent.HasTag(tagId4))
					{
						flag2 = false;
						break;
					}
				}
				if (flag2)
				{
					return false;
				}
			}
			int[] array3 = config.RemoveTagExistAny ?? Array.Empty<int>();
			if (array3.Length != 0)
			{
				foreach (int tagId5 in array3)
				{
					if (tagComponent.HasTag(tagId5))
					{
						return false;
					}
				}
			}
			if (baseTagComponent != null)
			{
				if (config.AddInstigatorTagIgnores != null)
				{
					foreach (int tagId6 in config.AddInstigatorTagIgnores)
					{
						if (baseTagComponent.HasTag(tagId6))
						{
							return false;
						}
					}
				}
				if (config.AddInstigatorTagRequirements != null)
				{
					foreach (int tagId7 in config.AddInstigatorTagRequirements)
					{
						if (!baseTagComponent.HasTag(tagId7))
						{
							return false;
						}
					}
				}
			}
		}
		return !this.CheckImmune(config);
	}

	// Token: 0x06016E21 RID: 93729 RVA: 0x006AC598 File Offset: 0x006AA798
	public virtual bool CheckImmune(BuffDefinition config)
	{
		foreach (int num in this.TagImmuneListenerDict.Keys)
		{
			bool flag = false;
			if (config.GrantedTags != null)
			{
				int[] grantedTags = config.GrantedTags;
				for (int i = 0; i < grantedTags.Length; i++)
				{
					if (GameplayTagUtils.IsChildTag(grantedTags[i], num))
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				foreach (int key in this.TagImmuneListenerDict[num])
				{
					ActiveBuffInternal valueOrDefault = this.BuffContainer.GetValueOrDefault(key);
					BuffDefinition buffDefinition = (valueOrDefault != null) ? valueOrDefault.Config : null;
					if (buffDefinition != null && valueOrDefault != null && valueOrDefault.IsValid() && valueOrDefault.IsActive() && config.GrantedTags != null)
					{
						bool flag2 = GameplayTagUtils.HasAll(config.GrantedTags, buffDefinition.ImmuneTags) && !GameplayTagUtils.HasAny(config.GrantedTags, buffDefinition.ImmuneTagIgnores);
						if (valueOrDefault != null && valueOrDefault.IsActive() && flag2)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06016E22 RID: 93730 RVA: 0x006AC714 File Offset: 0x006AA914
	protected bool HasTagRemoveCheck(BuffDefinition config)
	{
		int[] removeTagIgnores = config.RemoveTagIgnores;
		if (((removeTagIgnores != null) ? removeTagIgnores.Length : 0) <= 0)
		{
			int[] removeTagExistAll = config.RemoveTagExistAll;
			if (((removeTagExistAll != null) ? removeTagExistAll.Length : 0) <= 0)
			{
				int[] removeTagExistAny = config.RemoveTagExistAny;
				if (((removeTagExistAny != null) ? removeTagExistAny.Length : 0) <= 0)
				{
					if (config.BuffAction != null)
					{
						foreach (TBuffAction tbuffAction in config.BuffAction)
						{
							if (BuffTypesHelper.actionTagRemove.Contains(tbuffAction.Type))
							{
								return true;
							}
						}
					}
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06016E23 RID: 93731 RVA: 0x006AC790 File Offset: 0x006AA990
	protected bool CheckRemoveAction(BuffDefinition config, [Nullable(2)] Entity instigator)
	{
		if (config.BuffAction == null)
		{
			return false;
		}
		BaseTagComponent baseTagComponent = (instigator != null) ? instigator.GetComponent<BaseTagComponent>() : null;
		BaseBuffComponent baseBuffComponent = (instigator != null) ? instigator.GetComponent<BaseBuffComponent>() : null;
		BaseTagComponent tagComponent = this.GetTagComponent();
		foreach (TBuffAction tbuffAction in config.BuffAction)
		{
			EBuffActionType type = tbuffAction.Type;
			switch (type)
			{
			case EBuffActionType.RemoveBuffWhenInstigatorHasSomeTag:
				if (baseTagComponent != null)
				{
					foreach (int tagId in tbuffAction.Tags)
					{
						if (baseTagComponent.HasTag(tagId))
						{
							return true;
						}
					}
				}
				break;
			case EBuffActionType.RemoveBuffWhenInstigatorHasEveryTag:
				if (baseTagComponent != null)
				{
					bool flag = true;
					foreach (int tagId2 in tbuffAction.Tags)
					{
						if (!baseTagComponent.HasTag(tagId2))
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						return true;
					}
				}
				break;
			case EBuffActionType.RemoveBuffWhenInstigatorNotHasSomeTag:
				if (baseTagComponent != null)
				{
					foreach (int tagId3 in tbuffAction.Tags)
					{
						if (!baseTagComponent.HasTag(tagId3))
						{
							return true;
						}
					}
				}
				break;
			case EBuffActionType.RemoveBuffWhenInstigatorNotHasEveryTag:
				if (baseTagComponent != null)
				{
					bool flag2 = true;
					foreach (int tagId4 in tbuffAction.Tags)
					{
						if (baseTagComponent.HasTag(tagId4))
						{
							flag2 = false;
							break;
						}
					}
					if (flag2)
					{
						return true;
					}
				}
				break;
			case EBuffActionType.InactiveBuffWhenInstigatorHasSomeTag:
			case EBuffActionType.InactiveBuffWhenInstigatorHasEveryTag:
			case EBuffActionType.InactiveBuffWhenInstigatorNotHasSomeTag:
			case EBuffActionType.InactiveBuffWhenInstigatorNotHasEveryTag:
				break;
			case EBuffActionType.RemoveBuffWhenInstigatorHasSomeBuff:
				if (baseBuffComponent != null)
				{
					foreach (long buffId in tbuffAction.Buffs)
					{
						if (baseBuffComponent.HasActiveBuff(buffId))
						{
							return true;
						}
					}
				}
				break;
			case EBuffActionType.RemoveBuffWhenInstigatorHasEveryBuff:
				if (baseBuffComponent != null)
				{
					bool flag3 = true;
					foreach (long buffId2 in tbuffAction.Buffs)
					{
						if (!baseBuffComponent.HasActiveBuff(buffId2))
						{
							flag3 = false;
							break;
						}
					}
					if (flag3)
					{
						return true;
					}
				}
				break;
			case EBuffActionType.RemoveBuffWhenInstigatorNotHasSomeBuff:
				if (baseBuffComponent != null)
				{
					foreach (long buffId3 in tbuffAction.Buffs)
					{
						if (!baseBuffComponent.HasActiveBuff(buffId3))
						{
							return true;
						}
					}
				}
				break;
			case EBuffActionType.RemoveBuffWhenInstigatorNotHasEveryBuff:
				if (baseBuffComponent != null)
				{
					bool flag4 = true;
					foreach (long buffId4 in tbuffAction.Buffs)
					{
						if (baseBuffComponent.HasActiveBuff(buffId4))
						{
							flag4 = false;
							break;
						}
					}
					if (flag4)
					{
						return true;
					}
				}
				break;
			default:
				switch (type)
				{
				case EBuffActionType.RemoveBuffWhenVictimHasSomeTag:
					if (tagComponent != null)
					{
						foreach (int tagId5 in tbuffAction.Tags)
						{
							if (tagComponent.HasTag(tagId5))
							{
								return true;
							}
						}
					}
					break;
				case EBuffActionType.RemoveBuffWhenVictimHasEveryTag:
					if (tagComponent != null)
					{
						bool flag5 = true;
						foreach (int tagId6 in tbuffAction.Tags)
						{
							if (!tagComponent.HasTag(tagId6))
							{
								flag5 = false;
								break;
							}
						}
						if (flag5)
						{
							return true;
						}
					}
					break;
				case EBuffActionType.RemoveBuffWhenVictimNotHasSomeTag:
					if (tagComponent != null)
					{
						foreach (int tagId7 in tbuffAction.Tags)
						{
							if (!tagComponent.HasTag(tagId7))
							{
								return true;
							}
						}
					}
					break;
				case EBuffActionType.RemoveBuffWhenVictimNotHasEveryTag:
					if (tagComponent != null)
					{
						bool flag6 = true;
						foreach (int tagId8 in tbuffAction.Tags)
						{
							if (tagComponent.HasTag(tagId8))
							{
								flag6 = false;
								break;
							}
						}
						if (flag6)
						{
							return true;
						}
					}
					break;
				case EBuffActionType.RemoveBuffWhenVictimHasSomeBuff:
					foreach (long buffId5 in tbuffAction.Buffs)
					{
						if (this.HasActiveBuff(buffId5))
						{
							return true;
						}
					}
					break;
				case EBuffActionType.RemoveBuffWhenVictimHasEveryBuff:
				{
					bool flag7 = true;
					foreach (long buffId6 in tbuffAction.Buffs)
					{
						if (!this.HasActiveBuff(buffId6))
						{
							flag7 = false;
							break;
						}
					}
					if (flag7)
					{
						return true;
					}
					break;
				}
				case EBuffActionType.RemoveBuffWhenVictimNotHasSomeBuff:
					foreach (long buffId7 in tbuffAction.Buffs)
					{
						if (!this.HasActiveBuff(buffId7))
						{
							return true;
						}
					}
					break;
				case EBuffActionType.RemoveBuffWhenVictimNotHasEveryBuff:
				{
					bool flag8 = true;
					foreach (long buffId8 in tbuffAction.Buffs)
					{
						if (this.HasActiveBuff(buffId8))
						{
							flag8 = false;
							break;
						}
					}
					if (flag8)
					{
						return true;
					}
					break;
				}
				}
				break;
			}
		}
		return false;
	}

	// Token: 0x06016E24 RID: 93732 RVA: 0x006ACC3C File Offset: 0x006AAE3C
	protected bool CheckInactivateAction(BuffDefinition config, [Nullable(2)] Entity instigator)
	{
		if (config.BuffAction == null)
		{
			return false;
		}
		BaseTagComponent baseTagComponent = (instigator != null) ? instigator.GetComponent<BaseTagComponent>() : null;
		BaseBuffComponent baseBuffComponent = (instigator != null) ? instigator.GetComponent<BaseBuffComponent>() : null;
		BaseTagComponent tagComponent = this.GetTagComponent();
		foreach (TBuffAction tbuffAction in config.BuffAction)
		{
			EBuffActionType type = tbuffAction.Type;
			switch (type)
			{
			case EBuffActionType.InactiveBuffWhenInstigatorHasSomeTag:
				if (baseTagComponent != null)
				{
					foreach (int tagId in tbuffAction.Tags)
					{
						if (baseTagComponent.HasTag(tagId))
						{
							return true;
						}
					}
				}
				break;
			case EBuffActionType.InactiveBuffWhenInstigatorHasEveryTag:
				if (baseTagComponent != null)
				{
					bool flag = true;
					foreach (int tagId2 in tbuffAction.Tags)
					{
						if (!baseTagComponent.HasTag(tagId2))
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						return true;
					}
				}
				break;
			case EBuffActionType.InactiveBuffWhenInstigatorNotHasSomeTag:
				if (baseTagComponent != null)
				{
					foreach (int tagId3 in tbuffAction.Tags)
					{
						if (!baseTagComponent.HasTag(tagId3))
						{
							return true;
						}
					}
				}
				break;
			case EBuffActionType.InactiveBuffWhenInstigatorNotHasEveryTag:
				if (baseTagComponent != null)
				{
					bool flag2 = true;
					foreach (int tagId4 in tbuffAction.Tags)
					{
						if (baseTagComponent.HasTag(tagId4))
						{
							flag2 = false;
							break;
						}
					}
					if (flag2)
					{
						return true;
					}
				}
				break;
			case EBuffActionType.RemoveBuffWhenInstigatorHasSomeBuff:
			case EBuffActionType.RemoveBuffWhenInstigatorHasEveryBuff:
			case EBuffActionType.RemoveBuffWhenInstigatorNotHasSomeBuff:
			case EBuffActionType.RemoveBuffWhenInstigatorNotHasEveryBuff:
				break;
			case EBuffActionType.InactiveBuffWhenInstigatorHasSomeBuff:
				if (baseBuffComponent != null)
				{
					foreach (long buffId in tbuffAction.Buffs)
					{
						if (baseBuffComponent.HasActiveBuff(buffId))
						{
							return true;
						}
					}
				}
				break;
			case EBuffActionType.InactiveBuffWhenInstigatorHasEveryBuff:
				if (baseBuffComponent != null)
				{
					bool flag3 = true;
					foreach (long buffId2 in tbuffAction.Buffs)
					{
						if (!baseBuffComponent.HasActiveBuff(buffId2))
						{
							flag3 = false;
							break;
						}
					}
					if (flag3)
					{
						return true;
					}
				}
				break;
			case EBuffActionType.InactiveBuffWhenInstigatorNotHasSomeBuff:
				if (baseBuffComponent != null)
				{
					foreach (long buffId3 in tbuffAction.Buffs)
					{
						if (!baseBuffComponent.HasActiveBuff(buffId3))
						{
							return true;
						}
					}
				}
				break;
			case EBuffActionType.InactiveBuffWhenInstigatorNotHasEveryBuff:
				if (baseBuffComponent != null)
				{
					bool flag4 = true;
					foreach (long buffId4 in tbuffAction.Buffs)
					{
						if (baseBuffComponent.HasActiveBuff(buffId4))
						{
							flag4 = false;
							break;
						}
					}
					if (flag4)
					{
						return true;
					}
				}
				break;
			default:
				switch (type)
				{
				case EBuffActionType.InactiveBuffWhenVictimHasSomeTag:
					if (tagComponent != null)
					{
						foreach (int tagId5 in tbuffAction.Tags)
						{
							if (tagComponent.HasTag(tagId5))
							{
								return true;
							}
						}
					}
					break;
				case EBuffActionType.InactiveBuffWhenVictimHasEveryTag:
					if (tagComponent != null)
					{
						bool flag5 = true;
						foreach (int tagId6 in tbuffAction.Tags)
						{
							if (!tagComponent.HasTag(tagId6))
							{
								flag5 = false;
								break;
							}
						}
						if (flag5)
						{
							return true;
						}
					}
					break;
				case EBuffActionType.InactiveBuffWhenVictimNotHasSomeTag:
					if (tagComponent != null)
					{
						foreach (int tagId7 in tbuffAction.Tags)
						{
							if (!tagComponent.HasTag(tagId7))
							{
								return true;
							}
						}
					}
					break;
				case EBuffActionType.InactiveBuffWhenVictimNotHasEveryTag:
					if (tagComponent != null)
					{
						bool flag6 = true;
						foreach (int tagId8 in tbuffAction.Tags)
						{
							if (tagComponent.HasTag(tagId8))
							{
								flag6 = false;
								break;
							}
						}
						if (flag6)
						{
							return true;
						}
					}
					break;
				case EBuffActionType.InactiveBuffWhenVictimHasSomeBuff:
					foreach (long buffId5 in tbuffAction.Buffs)
					{
						if (this.HasActiveBuff(buffId5))
						{
							return true;
						}
					}
					break;
				case EBuffActionType.InactiveBuffWhenVictimHasEveryBuff:
				{
					bool flag7 = true;
					foreach (long buffId6 in tbuffAction.Buffs)
					{
						if (!this.HasActiveBuff(buffId6))
						{
							flag7 = false;
							break;
						}
					}
					if (flag7)
					{
						return true;
					}
					break;
				}
				case EBuffActionType.InactiveBuffWhenVictimNotHasSomeBuff:
					foreach (long buffId7 in tbuffAction.Buffs)
					{
						if (!this.HasActiveBuff(buffId7))
						{
							return true;
						}
					}
					break;
				case EBuffActionType.InactiveBuffWhenVictimNotHasEveryBuff:
				{
					bool flag8 = true;
					foreach (long buffId8 in tbuffAction.Buffs)
					{
						if (this.HasActiveBuff(buffId8))
						{
							flag8 = false;
							break;
						}
					}
					if (flag8)
					{
						return true;
					}
					break;
				}
				}
				break;
			}
		}
		return false;
	}

	// Token: 0x06016E25 RID: 93733 RVA: 0x006AD0E8 File Offset: 0x006AB2E8
	protected virtual bool CheckRemove(BuffDefinition config, [Nullable(2)] Entity instigator)
	{
		BaseTagComponent tagComponent = this.GetTagComponent();
		if (tagComponent == null)
		{
			if (!this.HasTagRemoveCheck(config))
			{
				return false;
			}
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = base.Entity;
			string message = "检查buff移除条件时找不到Tag组件，默认移除";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("buffId", config.Id);
			instance.Warn(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}
		else
		{
			if (this.CheckRemoveAction(config, instigator))
			{
				return true;
			}
			bool flag2 = false;
			int[] removeTagIgnores = config.RemoveTagIgnores;
			if (removeTagIgnores != null && removeTagIgnores.Length != 0)
			{
				flag2 = true;
				foreach (int tagId in config.RemoveTagIgnores)
				{
					if (tagComponent.HasTag(tagId))
					{
						flag2 = false;
						break;
					}
				}
			}
			bool flag3 = false;
			int[] removeTagExistAll = config.RemoveTagExistAll;
			if (removeTagExistAll != null && removeTagExistAll.Length != 0)
			{
				flag3 = true;
				foreach (int tagId2 in config.RemoveTagExistAll)
				{
					if (!tagComponent.HasTag(tagId2))
					{
						flag3 = false;
						break;
					}
				}
			}
			bool flag4 = false;
			int[] removeTagExistAny = config.RemoveTagExistAny;
			if (removeTagExistAny != null && removeTagExistAny.Length != 0)
			{
				foreach (int tagId3 in config.RemoveTagExistAny)
				{
					if (tagComponent.HasTag(tagId3))
					{
						flag4 = true;
						break;
					}
				}
			}
			return flag2 || flag3 || flag4;
		}
	}

	// Token: 0x06016E26 RID: 93734 RVA: 0x006AD224 File Offset: 0x006AB424
	protected virtual bool CheckActivate(BuffDefinition config, [Nullable(2)] Entity instigator)
	{
		BaseTagComponent tagComponent = this.GetTagComponent();
		if (tagComponent == null)
		{
			return false;
		}
		if (config.ActivateTagIgnores != null)
		{
			foreach (int tagId in config.ActivateTagIgnores)
			{
				if (tagComponent.HasTag(tagId))
				{
					return false;
				}
			}
		}
		if (config.ActivateTagRequirements != null)
		{
			foreach (int tagId2 in config.ActivateTagRequirements)
			{
				if (!tagComponent.HasTag(tagId2))
				{
					return false;
				}
			}
		}
		return !this.CheckInactivateAction(config, instigator);
	}

	// Token: 0x06016E27 RID: 93735 RVA: 0x006AD2A4 File Offset: 0x006AB4A4
	public virtual void SetBuffEffectCd(long buffId, int index, float remainCd)
	{
		Dictionary<int, double> dictionary;
		if (!this.EffectTimeoutMap.TryGetValue(buffId, out dictionary))
		{
			dictionary = new Dictionary<int, double>();
			this.EffectTimeoutMap[buffId] = dictionary;
		}
		if (remainCd <= 0f)
		{
			dictionary.Remove(index);
			return;
		}
		dictionary[index] = Time.Instance.ServerCombatStopTime + (double)remainCd;
	}

	// Token: 0x06016E28 RID: 93736 RVA: 0x006AD2FC File Offset: 0x006AB4FC
	public double GetBuffEffectCd(long buffId, int index)
	{
		Dictionary<int, double> dictionary;
		if (!this.EffectTimeoutMap.TryGetValue(buffId, out dictionary))
		{
			return 0.0;
		}
		double num;
		if (!dictionary.TryGetValue(index, out num))
		{
			return 0.0;
		}
		if (num <= Time.Instance.ServerCombatStopTime)
		{
			return 0.0;
		}
		return num - Time.Instance.ServerCombatStopTime;
	}

	// Token: 0x06016E29 RID: 93737 RVA: 0x006AD35C File Offset: 0x006AB55C
	private unsafe void RemoveInvalidTargetCd(Dictionary<int, double> targetMap)
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, double> keyValuePair in targetMap)
		{
			if (keyValuePair.Value <= Time.Instance.ServerCombatStopTime)
			{
				list.Add(keyValuePair.Key);
			}
		}
		foreach (int key in list)
		{
			targetMap.Remove(key);
		}
		if (targetMap.Count >= BaseBuffComponent.MaxTargetCdCount)
		{
			int? num = null;
			using (Dictionary<int, double>.KeyCollection.Enumerator enumerator3 = targetMap.Keys.GetEnumerator())
			{
				if (enumerator3.MoveNext())
				{
					int value = enumerator3.Current;
					num = new int?(value);
				}
			}
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = base.Entity;
			string message = "目标CD条目数量超上限，移除最早插入的目标CD";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("当前数量", targetMap.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("上限", BaseBuffComponent.MaxTargetCdCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("移除的entityId", num);
			instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (num != null)
			{
				targetMap.Remove(num.Value);
			}
		}
	}

	// Token: 0x06016E2A RID: 93738 RVA: 0x006AD508 File Offset: 0x006AB708
	public unsafe virtual void SetBuffEffectCdForTarget(long buffId, int index, int targetEntityId, float remainCd)
	{
		if (targetEntityId == 0)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = base.Entity;
			string message = "设置目标CD时目标实体无效(entityId=0)，跳过";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("effectIndex", index);
			instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		Dictionary<int, Dictionary<int, double>> dictionary;
		if (!this.EffectTargetTimeoutMap.TryGetValue(buffId, out dictionary))
		{
			dictionary = new Dictionary<int, Dictionary<int, double>>();
			this.EffectTargetTimeoutMap[buffId] = dictionary;
		}
		Dictionary<int, double> dictionary2;
		if (!dictionary.TryGetValue(index, out dictionary2))
		{
			dictionary2 = new Dictionary<int, double>();
			dictionary[index] = dictionary2;
		}
		if (remainCd <= 0f)
		{
			dictionary2.Remove(targetEntityId);
			return;
		}
		this.RemoveInvalidTargetCd(dictionary2);
		dictionary2.ContainsKey(targetEntityId);
		dictionary2.Remove(targetEntityId);
		dictionary2[targetEntityId] = Time.Instance.ServerCombatStopTime + (double)remainCd;
	}

	// Token: 0x06016E2B RID: 93739 RVA: 0x006AD5F4 File Offset: 0x006AB7F4
	public string GetTargetCdDebugStr(long buffId, int index)
	{
		Dictionary<int, Dictionary<int, double>> dictionary;
		if (!this.EffectTargetTimeoutMap.TryGetValue(buffId, out dictionary))
		{
			return "";
		}
		Dictionary<int, double> dictionary2;
		if (!dictionary.TryGetValue(index, out dictionary2) || dictionary2.Count == 0)
		{
			return "";
		}
		List<string> list = new List<string>();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		foreach (KeyValuePair<int, double> keyValuePair in dictionary2)
		{
			double num = keyValuePair.Value - Time.Instance.ServerCombatStopTime;
			if (num > 0.0)
			{
				List<string> list2 = list;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Key);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted<double>(num / 1000.0, "F1");
				defaultInterpolatedStringHandler.AppendLiteral("s");
				list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}
		if (list.Count == 0)
		{
			return "";
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
		defaultInterpolatedStringHandler.AppendLiteral(", targetCd(");
		defaultInterpolatedStringHandler.AppendFormatted<int>(list.Count);
		defaultInterpolatedStringHandler.AppendLiteral("): [");
		defaultInterpolatedStringHandler.AppendFormatted(string.Join(", ", list));
		defaultInterpolatedStringHandler.AppendLiteral("]");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06016E2C RID: 93740 RVA: 0x006AD74C File Offset: 0x006AB94C
	public double GetBuffEffectCdForTarget(long buffId, int index, int targetEntityId)
	{
		if (targetEntityId == 0)
		{
			return 0.0;
		}
		Dictionary<int, Dictionary<int, double>> dictionary;
		if (!this.EffectTargetTimeoutMap.TryGetValue(buffId, out dictionary))
		{
			return 0.0;
		}
		Dictionary<int, double> dictionary2;
		if (!dictionary.TryGetValue(index, out dictionary2))
		{
			return 0.0;
		}
		double num;
		if (!dictionary2.TryGetValue(targetEntityId, out num))
		{
			return 0.0;
		}
		if (num <= Time.Instance.ServerCombatStopTime)
		{
			return 0.0;
		}
		return num - Time.Instance.ServerCombatStopTime;
	}

	// Token: 0x06016E2D RID: 93741 RVA: 0x006AD7D0 File Offset: 0x006AB9D0
	public unsafe long? CreateAnimNotifyContentWithAnimBp(int anIndex, string animName)
	{
		BaseSkillComponent skillComponent = this.GetSkillComponent();
		global::Skill skill = (skillComponent != null) ? skillComponent.CurrentSkill : null;
		long? num = (skill != null) ? skill.CombatMessageId : null;
		if (anIndex == -1)
		{
			return null;
		}
		if (num != null)
		{
			long? num2 = num;
			long num3 = 0L;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				long value = CombatMessageModel.Instance.GenMessageId();
				SkillMessageController.Instance.AnimNotifyRequest(base.Entity, (skill != null) ? skill.SkillId : 0, -1, anIndex, new long?(num.Value), new long?(value));
				return new long?(value);
			}
		}
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
		Entity entity = base.Entity;
		string message = "CreateANCWithAnimBp Error";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("anIndex", anIndex);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("animName", animName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SkillId", (skill != null) ? new int?(skill.SkillId) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("contextId", num);
		instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		return null;
	}

	// Token: 0x06016E2E RID: 93742 RVA: 0x006AD938 File Offset: 0x006ABB38
	public unsafe long? CreateAnimNotifyContentWithoutSkill(MontageInfo montageInfo, int anIndex)
	{
		if (montageInfo.MontageTaskMessageId != null)
		{
			long? montageTaskMessageId = montageInfo.MontageTaskMessageId;
			long num = 0L;
			if (!(montageTaskMessageId.GetValueOrDefault() == num & montageTaskMessageId != null) && anIndex != -1)
			{
				long value = CombatMessageModel.Instance.GenMessageId();
				SkillMessageController.Instance.AnimNotifyRequest(base.Entity, -1, -1, anIndex, new long?(montageInfo.MontageTaskMessageId.Value), new long?(value));
				return new long?(value);
			}
		}
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
		Entity entity = base.Entity;
		string message = "CreateANCWithoutSkill Error";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ANIndex", anIndex);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("montageInfo", montageInfo);
		instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return null;
	}

	// Token: 0x06016E2F RID: 93743 RVA: 0x006ADA14 File Offset: 0x006ABC14
	public unsafe long? CreateAnimNotifyContentWithSkill(MontageInfo montageInfo, int anIndex)
	{
		BaseSkillComponent skillComponent = this.GetSkillComponent();
		global::Skill skill = (skillComponent != null) ? skillComponent.GetSkill(montageInfo.SkillId.GetValueOrDefault()) : null;
		if (skill != null && montageInfo.MontageIndex != null && montageInfo.MontageTaskMessageId != null)
		{
			long? montageTaskMessageId = montageInfo.MontageTaskMessageId;
			long num = 0L;
			if (!(montageTaskMessageId.GetValueOrDefault() == num & montageTaskMessageId != null) && anIndex != -1)
			{
				int skillId = skill.SkillId;
				long? montageTaskMessageId2 = montageInfo.MontageTaskMessageId;
				long value = CombatMessageModel.Instance.GenMessageId();
				SkillMessageController.Instance.AnimNotifyRequest(base.Entity, skillId, montageInfo.MontageIndex.Value, anIndex, new long?(montageTaskMessageId2.Value), new long?(value));
				return new long?(value);
			}
		}
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
		Entity entity = base.Entity;
		string message = "CreateANCWithSkill Error";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ANIndex", anIndex);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("montageInfo", montageInfo);
		instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return null;
	}

	// Token: 0x06016E30 RID: 93744 RVA: 0x006ADB38 File Offset: 0x006ABD38
	public long? CreateAnimNotifyContent(string montageName, int anIndex)
	{
		BaseMontageComponent component = base.Entity.GetComponent<BaseMontageComponent>();
		MontageInfo montageInfo = (component != null) ? component.GetMontageInfo(montageName) : null;
		if (montageInfo == null)
		{
			return this.CreateAnimNotifyContentWithAnimBp(anIndex, montageName);
		}
		BaseSkillComponent skillComponent = this.GetSkillComponent();
		if (((skillComponent != null) ? skillComponent.GetSkill(montageInfo.SkillId.GetValueOrDefault()) : null) == null)
		{
			return this.CreateAnimNotifyContentWithoutSkill(montageInfo, anIndex);
		}
		return this.CreateAnimNotifyContentWithSkill(montageInfo, anIndex);
	}

	// Token: 0x06016E31 RID: 93745 RVA: 0x006ADB9A File Offset: 0x006ABD9A
	public void AddBuffFromAi(long? contextId, long buffId, AddBuffParam buffParams)
	{
		bool flag = contextId != null;
		buffParams.PreMessageId = contextId;
		this.AddBuff(buffId, buffParams);
	}

	// Token: 0x06016E32 RID: 93746 RVA: 0x006ADBB3 File Offset: 0x006ABDB3
	public void AddBuffForDebug(long buffId, AddBuffParam buffParams)
	{
		buffParams.PreMessageId = new long?(-1L);
		this.AddBuff(buffId, buffParams);
	}

	// Token: 0x06016E33 RID: 93747 RVA: 0x006ADBCC File Offset: 0x006ABDCC
	public unsafe virtual void AddBuff(long buffId, AddBuffParam buffParams)
	{
		if (buffId <= 0L)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = base.Entity;
			string message = "尝试添加buff时传入了不合法的buffId";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("创建者", buffParams.InstigatorId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("持有者", this.GetDebugName());
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		EntityHandle entity2 = CreatureModel.Instance.GetEntity(buffParams.InstigatorId);
		BaseBuffComponent baseBuffComponent;
		if (entity2 == null)
		{
			baseBuffComponent = null;
		}
		else
		{
			WorldEntity entity3 = entity2.Entity;
			baseBuffComponent = ((entity3 != null) ? entity3.GetComponent<BaseBuffComponent>() : null);
		}
		BaseBuffComponent baseBuffComponent2 = baseBuffComponent;
		buffId = ((baseBuffComponent2 != null) ? baseBuffComponent2.GetReplaceBuffId(buffId, buffParams) : null).GetValueOrDefault(buffId);
		InstanceDungeon? instanceDungeon;
		int[] array = (GameModeModel.Instance.InstanceDungeon != null) ? instanceDungeon.GetValueOrDefault().GetCustomTypesArray() : null;
		bool flag2 = array != null && Array.IndexOf<int>(array, 5) >= 0;
		if (buffParams.PreMessageId != null)
		{
			long? preMessageId = buffParams.PreMessageId;
			long num = 0L;
			if (!(preMessageId.GetValueOrDefault() == num & preMessageId != null))
			{
				goto IL_1B2;
			}
		}
		if (!BuffIdUtils.CheckBuffInSpecialList(buffId) && !flag2)
		{
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag3 = CombatLog.EDebugModule.Buff;
			Entity entity4 = base.Entity;
			string message2 = "加Buff上文无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("原因", buffParams.Reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("buffId", buffId);
			instance2.Error(flag3, entity4, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		IL_1B2:
		int? level = buffParams.Level;
		buffParams.Level = ((level != null) ? level : ((baseBuffComponent2 != null) ? baseBuffComponent2.GetBuffLevel(buffId) : null));
		if (this.HasBuffAuthority())
		{
			this.AddBuffLocal(buffId, buffParams);
			return;
		}
		if (this.NeedAddBuffOrder(buffId))
		{
			this.AddBuffOrder(buffId, buffParams);
		}
	}

	// Token: 0x06016E34 RID: 93748 RVA: 0x006ADDE0 File Offset: 0x006ABFE0
	public unsafe virtual int AddBuffLocal(long buffId, AddBuffParam buffParams)
	{
		long instigatorId = buffParams.InstigatorId;
		int? level = buffParams.Level;
		int? outerStackCount = buffParams.OuterStackCount;
		ApplyGEType valueOrDefault = buffParams.ApplyType.GetValueOrDefault();
		long? preMessageId = buffParams.PreMessageId;
		long? messageId = buffParams.MessageId;
		float? duration = buffParams.Duration;
		float? duration2 = (duration != null) ? duration : ActiveBuffConfigs.USE_INTERNAL_DURATION;
		int valueOrDefault2 = buffParams.ServerId.GetValueOrDefault(-1);
		bool valueOrDefault3 = buffParams.IsIterable.GetValueOrDefault(true);
		bool valueOrDefault4 = buffParams.IsServerOrder.GetValueOrDefault();
		string reason = buffParams.Reason;
		long? bulletMessageId = buffParams.BulletMessageId;
		bool valueOrDefault5 = buffParams.BornBuff.GetValueOrDefault();
		if (!this.HasBuffAuthority())
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = base.Entity;
			string message = "[local] 模拟端不本地添加buff";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("施加者", instigatorId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("持有者", this.GetDebugName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("前置行为id", preMessageId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("原因", reason);
			instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			return -1;
		}
		BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(buffId, reason);
		if (buffDefinition == null)
		{
			return -1;
		}
		EntityHandle entity2 = CreatureModel.Instance.GetEntity(instigatorId);
		BaseBuffComponent baseBuffComponent;
		if (entity2 == null)
		{
			baseBuffComponent = null;
		}
		else
		{
			WorldEntity entity3 = entity2.Entity;
			baseBuffComponent = ((entity3 != null) ? entity3.GetComponent<BaseBuffComponent>() : null);
		}
		BaseBuffComponent baseBuffComponent2 = baseBuffComponent;
		level = new int?(level ?? ((baseBuffComponent2 != null) ? baseBuffComponent2.GetBuffLevel(buffId) : null).GetValueOrDefault(1));
		return this.AddBuffInner(buffId, buffDefinition, new long?(instigatorId), level.Value, outerStackCount, new ApplyGEType?(valueOrDefault), preMessageId, messageId, duration2, null, valueOrDefault2, reason, false, valueOrDefault3, valueOrDefault4, null, bulletMessageId, new bool?(valueOrDefault5));
	}

	// Token: 0x06016E35 RID: 93749 RVA: 0x006AE016 File Offset: 0x006AC216
	protected virtual void AddBuffOrder(long buffId, AddBuffParam buffParams)
	{
	}

	// Token: 0x06016E36 RID: 93750 RVA: 0x006AE018 File Offset: 0x006AC218
	protected void AddBuffRemote(long buffId, int handle, long overrideConfigId, AddBuffParam buffParams)
	{
		long instigatorId = buffParams.InstigatorId;
		int valueOrDefault = buffParams.Level.GetValueOrDefault(1);
		int? outerStackCount = buffParams.OuterStackCount;
		ApplyGEType valueOrDefault2 = buffParams.ApplyType.GetValueOrDefault();
		long? preMessageId = buffParams.PreMessageId;
		long? messageId = buffParams.MessageId;
		float? duration = buffParams.Duration;
		float? duration2 = (duration != null) ? duration : ActiveBuffConfigs.USE_INTERNAL_DURATION;
		float? remainDuration = buffParams.RemainDuration;
		int valueOrDefault3 = buffParams.ServerId.GetValueOrDefault(-1);
		bool? isActive = buffParams.IsActive;
		string reason = buffParams.Reason;
		bool valueOrDefault4 = buffParams.BornBuff.GetValueOrDefault();
		BuffDefinition config = BuffController.Instance.GetBuffDefinition(buffId, reason);
		if (overrideConfigId != 0L)
		{
			BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(overrideConfigId, null);
			if (buffDefinition != null)
			{
				config = buffDefinition;
			}
		}
		int key = this.AddBuffInner(buffId, config, new long?(instigatorId), valueOrDefault, outerStackCount, new ApplyGEType?(valueOrDefault2), preMessageId, messageId, duration2, isActive, valueOrDefault3, reason, true, true, false, new int?(handle), null, new bool?(valueOrDefault4));
		ActiveBuffInternal valueOrDefault5 = this.BuffContainer.GetValueOrDefault(key);
		if (valueOrDefault5 == null)
		{
			return;
		}
		if (remainDuration != null)
		{
			valueOrDefault5.SetRemainDuration(remainDuration.Value);
		}
	}

	// Token: 0x06016E37 RID: 93751 RVA: 0x006AE15C File Offset: 0x006AC35C
	[NullableContext(2)]
	public unsafe void AddIterativeBuff(long buffId, IActiveBuff preBuff, int? stackCount, bool isIterable, [Nullable(1)] string reason, long? bulletMessageId = null, IBuffComponent instigator = null)
	{
		if (preBuff == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = base.Entity;
			string message = "尝试添加迭代buff失败，未找到前置buff";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("持有者", this.GetDebugName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("原因", reason);
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		long num = preBuff.InstigatorId.GetValueOrDefault();
		if (instigator != null)
		{
			BaseBuffComponent baseBuffComponent = instigator as BaseBuffComponent;
			num = ((baseBuffComponent != null) ? baseBuffComponent.CreatureDataId : num);
		}
		this.AddBuff(buffId, new AddBuffParam
		{
			InstigatorId = num,
			Level = new int?(preBuff.Level),
			PreMessageId = preBuff.MessageId,
			ServerId = new int?(preBuff.ServerId),
			OuterStackCount = stackCount,
			IsIterable = new bool?(isIterable),
			Reason = reason,
			BulletMessageId = bulletMessageId
		});
	}

	// Token: 0x1700231C RID: 8988
	// (get) Token: 0x06016E38 RID: 93752 RVA: 0x006AE272 File Offset: 0x006AC472
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private static Dictionary<long, Stat> BuffStatMap
	{
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		get
		{
			return BaseBuffComponent._buffStatMap;
		}
	}

	// Token: 0x06016E39 RID: 93753 RVA: 0x006AE279 File Offset: 0x006AC479
	[NullableContext(2)]
	protected static Stat GetBuffStat(long buffId)
	{
		return null;
	}

	// Token: 0x06016E3A RID: 93754 RVA: 0x006AE27C File Offset: 0x006AC47C
	[NullableContext(2)]
	public unsafe virtual int AddBuffInner(long buffId, BuffDefinition config, long? instigatorId, int level, int? outerStackCount, ApplyGEType? applyType, long? preMessageId, long? messageId, float? duration, bool? isActive, int serverId, string reason, bool fromServer, bool isIterable, bool isServerOrder, int? handle, long? bulletMessageId = null, bool? bornBuff = null)
	{
		BaseBuffComponent.GetBuffStat(buffId);
		int i = this.BuffLock;
		this.BuffLock = i + 1;
		<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("创建者id", instigatorId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("持有者", this.GetDebugName());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("初始激活", isActive);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("原因", reason);
		ReadOnlySpan<ValueTuple<string, object>> pairs = <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5);
		if (config == null)
		{
			CombatLog.Instance.Error(CombatLog.EDebugModule.Buff, base.Entity, "[local] 添加buff时找不到配置", pairs);
			i = this.BuffLock;
			this.BuffLock = i - 1;
			return -1;
		}
		BuffDefinition buffDefinition = config;
		IConfigOverrideRule configOverrideRule = null;
		if (this.HasBuffAuthority() && !fromServer && buffDefinition.ConfigOverrides != null && buffDefinition.ConfigOverrides.Length != 0)
		{
			configOverrideRule = this.ConfigOverrideConditionListener.ResolveOverrideConfigRule(new List<IConfigOverrideRule>(buffDefinition.ConfigOverrides));
			if (configOverrideRule != null)
			{
				BuffDefinition buffDefinition2 = BuffController.Instance.GetBuffDefinition(configOverrideRule.OverrideConfigId, reason);
				if (buffDefinition2 != null)
				{
					buffDefinition = buffDefinition2;
				}
			}
		}
		applyType = new ApplyGEType?(applyType.GetValueOrDefault());
		WorldEntity worldEntity = null;
		if (instigatorId != null)
		{
			long? num = instigatorId;
			long num2 = 0L;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(instigatorId.Value);
				worldEntity = ((entity != null) ? entity.Entity : null);
				if (worldEntity == null)
				{
					CombatLog.Instance.Warn(CombatLog.EDebugModule.Buff, base.Entity, "[local] 添加buff时找不到施加者，将被丢弃", pairs);
					i = this.BuffLock;
					this.BuffLock = i - 1;
					return -1;
				}
			}
		}
		int num4;
		if (outerStackCount != null)
		{
			int? num3 = outerStackCount;
			i = 0;
			if (num3.GetValueOrDefault() > i & num3 != null)
			{
				num4 = outerStackCount.Value;
				goto IL_1F1;
			}
		}
		num4 = buffDefinition.DefaultStackCount;
		IL_1F1:
		int num5 = num4;
		if (!this.CheckAdd(buffDefinition, instigatorId.GetValueOrDefault(), fromServer))
		{
			if (worldEntity != null)
			{
				SceneTeamController.Instance.EmitAbilityEvent<long, Entity, Entity, int, long?>(worldEntity, EAbilityEventName.AddBuffFailure, buffId, buffId, base.Entity, worldEntity, num5, bulletMessageId);
			}
			i = this.BuffLock;
			this.BuffLock = i - 1;
			return -1;
		}
		if (worldEntity != null)
		{
			SceneTeamController.Instance.EmitAbilityEvent<long, Entity, Entity, bool?>(worldEntity, EAbilityEventName.AddBuffToOthers, buffId, buffId, base.Entity, worldEntity, bornBuff);
		}
		ActiveBuffInternal stackableBuff = this.GetStackableBuff(instigatorId.GetValueOrDefault(), buffId, buffDefinition.StackingType);
		int num6 = this.RefreshBuffStackMax(buffId);
		if (stackableBuff != null)
		{
			if (stackableBuff.Config != null && (num6 <= 0 || !stackableBuff.Config.DenyOverflowAdd || stackableBuff.StackCount < num6))
			{
				if (buffDefinition.StackAppendCount > 0)
				{
					num5 = buffDefinition.StackAppendCount;
				}
				int stackCount = stackableBuff.StackCount;
				int num7 = stackCount + num5;
				int newStack = Math.Min(num7, num6);
				try
				{
					this.OnBuffStackIncreased(stackableBuff, stackCount, newStack, new long?(instigatorId.GetValueOrDefault()), level, outerStackCount, applyType.Value, preMessageId, duration, serverId, isIterable, isServerOrder, reason, EBuffStackDurationOverride.Default, EBuffStackPeriodResetOverride.Default);
					ExtraEffectParameters[] effectInfos = stackableBuff.Config.EffectInfos;
					for (i = 0; i < effectInfos.Length; i++)
					{
						BuffExecution executionEffect = effectInfos[i].ExecutionEffect;
						if (executionEffect != null)
						{
							executionEffect.OnBuffAddedCallback(stackableBuff, isIterable);
						}
					}
					if (num7 > num6)
					{
						ExtraEffectManager buffEffectManager = this.BuffEffectManager;
						if (buffEffectManager != null)
						{
							buffEffectManager.OnBuffStackOverflow(stackableBuff, stackCount, num7, num6);
						}
					}
				}
				catch (Exception e)
				{
					CombatLog.Instance.ErrorWithStack(CombatLog.EDebugModule.Buff, base.Entity, "Buff层数改变中发生异常", e, pairs);
				}
			}
			SceneTeamController.Instance.EmitAbilityEvent<long, int>(base.Entity, EAbilityEventName.OnBuffAdd, buffId, buffId, stackableBuff.Handle);
			i = this.BuffLock;
			this.BuffLock = i - 1;
			return stackableBuff.Handle;
		}
		int num8 = num5;
		int? num9 = this.CalculateBuffStackMaxByConfig(buffDefinition, buffId);
		if (num9 != null && num9.GetValueOrDefault() != 2147483647)
		{
			num5 = Math.Min(num5, num9.Value);
		}
		ActiveBuffInternal newBuff = null;
		if (buffDefinition.DurationPolicy == EBuffDurationType.Instant)
		{
			handle = new int?(-2);
			duration = new float?((float)-1);
		}
		else
		{
			handle = new int?(handle ?? BuffController.Instance.GenerateHandle());
		}
		try
		{
			newBuff = ActiveBuffInternal.AllocBuff(buffDefinition, handle.Value, instigatorId, this, serverId, preMessageId, messageId, level, num5, duration, applyType.Value, buffId);
		}
		catch (Exception e2)
		{
			CombatLog.Instance.ErrorWithStack(CombatLog.EDebugModule.Buff, base.Entity, "Buff初始过程中发生异常", e2, pairs);
		}
		if (newBuff == null)
		{
			i = this.BuffLock;
			this.BuffLock = i - 1;
			return -1;
		}
		if (num8 > num5 && num9 != null && num9.GetValueOrDefault() != 2147483647)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity2 = base.Entity;
			string message = "[local] 新增buff层数超过最大层数限制，已自动截断";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("原始层数", num8);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("最大层数", num9);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("截断后层数", num5);
			instance.Warn(flag, entity2, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}
		if (this.HasBuffAuthority() && !fromServer && configOverrideRule != null && config.ConfigOverrides != null)
		{
			ConfigOverrideConditionListener.ConfigOverrideListenerRegistration configOverrideListenerRegistration = this.ConfigOverrideConditionListener.AddListener(new List<IConfigOverrideRule>(config.ConfigOverrides), delegate
			{
				ActiveBuffInternal newBuff = newBuff;
				if (newBuff == null)
				{
					return;
				}
				newBuff.OnConfigOverrideChanged();
			}, false, configOverrideRule.OverrideConfigId);
			if (configOverrideListenerRegistration != null)
			{
				newBuff.SetConfigOverrideListenerId(configOverrideListenerRegistration.ListenerId);
			}
		}
		if (!BaseBuffComponent.NoLogBuffSet.Contains(buffId))
		{
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Buff;
			Entity entity3 = base.Entity;
			string message2 = "本地添加buff";
			<>y__InlineArray11<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray11<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray11<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("buffId", buffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray11<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("创建者id", instigatorId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray11<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("持有者", this.GetDebugName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray11<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("初始激活", isActive);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray11<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("原因", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray11<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 5) = new ValueTuple<string, object>("handle", handle);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray11<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 6) = new ValueTuple<string, object>("前置行为id", preMessageId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray11<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 7) = new ValueTuple<string, object>("说明", buffDefinition.Desc);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray11<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 8) = new ValueTuple<string, object>("是否迭代", isIterable);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray11<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 9) = new ValueTuple<string, object>("层数", num5);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray11<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 10) = new ValueTuple<string, object>("bulletMessage", bulletMessageId);
			instance2.Info(flag2, entity3, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray11<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 11));
		}
		try
		{
			this.OnBuffAdded(newBuff, outerStackCount, applyType.Value, preMessageId, duration, isActive, serverId, fromServer, isIterable, isServerOrder, reason);
		}
		catch (Exception e3)
		{
			CombatLog.Instance.ErrorWithStack(CombatLog.EDebugModule.Buff, base.Entity, "Buff添加中发生异常", e3, pairs);
		}
		if (buffDefinition.DurationPolicy == EBuffDurationType.Instant)
		{
			this.UnregisterConfigOverrideListener(newBuff);
			ActiveBuffInternal.ReleaseBuff(newBuff);
		}
		SceneTeamController.Instance.EmitAbilityEvent<long, int>(base.Entity, EAbilityEventName.OnBuffAdd, buffId, buffId, handle.Value);
		i = this.BuffLock;
		this.BuffLock = i - 1;
		return handle.Value;
	}

	// Token: 0x06016E3B RID: 93755 RVA: 0x006AEA60 File Offset: 0x006ACC60
	public virtual void RemoveBuff(long buffId, int stackCount, string reason, long? preMessageId = null, bool? isServerRequest = null, long? instigatorId = null)
	{
		if (this.HasBuffAuthority())
		{
			this.RemoveBuffLocal(buffId, stackCount, reason, preMessageId, isServerRequest, instigatorId);
			return;
		}
		this.RemoveBuffOrder(buffId, stackCount, reason, instigatorId);
	}

	// Token: 0x06016E3C RID: 93756 RVA: 0x006AEA86 File Offset: 0x006ACC86
	protected virtual void RemoveBuffOrder(long buffId, int stackCount, string reason, long? instigatorId = null)
	{
	}

	// Token: 0x06016E3D RID: 93757 RVA: 0x006AEA88 File Offset: 0x006ACC88
	public unsafe virtual int RemoveBuffLocal(long buffId, int stackCount, string reason, long? preMessageId = null, bool? isServerRequest = null, long? instigatorId = null)
	{
		if (buffId <= 0L)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = base.Entity;
			string message = "尝试本地移除buff时传入了不合法的buffId";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("持有者", this.GetDebugName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("原因", reason);
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return 0;
		}
		if (!this.HasBuffAuthority())
		{
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Buff;
			Entity entity2 = base.Entity;
			string message2 = "无法直接移除非本端控制实体持有的buff，请换用RemoveBuff接口";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("buffId", buffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("持有者", this.GetDebugName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("原因", reason);
			instance2.Error(flag2, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return 0;
		}
		int result = 0;
		foreach (ActiveBuffInternal activeBuffInternal in new List<ActiveBuffInternal>(this.GetAllBuffById(buffId)))
		{
			result = this.RemoveBuffInner(activeBuffInternal.Handle, stackCount, true, reason, preMessageId, isServerRequest, instigatorId);
		}
		return result;
	}

	// Token: 0x06016E3E RID: 93758 RVA: 0x006AEBF8 File Offset: 0x006ACDF8
	public virtual void RemoveBuffByServerId(int serverId, int stackCount, long preMessageId, string reason, long? instigatorId = null)
	{
		foreach (IActiveBuff activeBuff in this.GetAllBuffs())
		{
			if (activeBuff.ServerId == serverId)
			{
				this.RemoveBuffInner(activeBuff.Handle, stackCount, true, reason, new long?(preMessageId), new bool?(true), instigatorId);
			}
		}
	}

	// Token: 0x06016E3F RID: 93759 RVA: 0x006AEC48 File Offset: 0x006ACE48
	[NullableContext(2)]
	public unsafe virtual void RemoveBuffByTagLocal(int tagId, string reason, long? instigatorId = null)
	{
		if (!this.HasBuffAuthority())
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = base.Entity;
			string message = "尝试根据tag移除非本地控制的实体的buff，移除操作将不被执行";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tagId", tagId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("tagName", GameplayTagUtils.GetNameByTagId(tagId));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("持有者", this.GetDebugName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("原因", reason);
			instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return;
		}
		string nameByTagId = GameplayTagUtils.GetNameByTagId(tagId);
		List<int> list = new List<int>();
		foreach (ActiveBuffInternal activeBuffInternal in this.BuffContainer.Values)
		{
			if (activeBuffInternal.Config.GrantedTags != null)
			{
				int[] grantedTags = activeBuffInternal.Config.GrantedTags;
				for (int i = 0; i < grantedTags.Length; i++)
				{
					if (GameplayTagUtils.IsChildTag(grantedTags[i], tagId))
					{
						list.Add(activeBuffInternal.Handle);
						break;
					}
				}
			}
		}
		foreach (int handle in list)
		{
			this.RemoveBuffInner(handle, -1, true, reason ?? ("移除tag " + nameByTagId), null, null, instigatorId);
		}
	}

	// Token: 0x06016E40 RID: 93760 RVA: 0x006AEDFC File Offset: 0x006ACFFC
	public void RemoveBuffByEffectType(EExtraEffectId effectId, string reason)
	{
		HashSet<long> hashSet = new HashSet<long>();
		Type buffEffectClass = ExtraEffectDefine.GetBuffEffectClass(effectId);
		if (buffEffectClass == null)
		{
			return;
		}
		foreach (BuffEffect buffEffect in this.BuffEffectManager.GetAllEffects())
		{
			if (buffEffectClass.IsInstanceOfType(buffEffect))
			{
				hashSet.Add(buffEffect.BuffId);
			}
		}
		foreach (long buffId in hashSet)
		{
			this.RemoveBuff(buffId, -1, reason, null, null, null);
		}
	}

	// Token: 0x06016E41 RID: 93761 RVA: 0x006AEED4 File Offset: 0x006AD0D4
	[NullableContext(2)]
	public unsafe virtual int RemoveBuffByHandle(int handle, int removeStackCount = -1, string reason = null, long? preMessageId = null, bool? isServerRequest = null, long? instigatorId = null)
	{
		if (!this.HasBuffAuthority())
		{
			IActiveBuff buffByHandle = this.GetBuffByHandle(handle);
			if (buffByHandle != null && buffByHandle.Id > 0L)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
				Entity entity = base.Entity;
				string message = "尝试直接通过handle移除非本端控制buff，后续需要新增协议";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", (buffByHandle != null) ? new long?(buffByHandle.Id) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("handle", handle);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("持有者", this.GetDebugName());
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
				string item = "说明";
				object item2;
				if (buffByHandle == null)
				{
					item2 = null;
				}
				else
				{
					BuffDefinition config = buffByHandle.Config;
					item2 = ((config != null) ? config.Desc : null);
				}
				ptr = new ValueTuple<string, object>(item, item2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("原因", reason);
				instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			}
		}
		return this.RemoveBuffByHandleLocal(handle, removeStackCount, reason, preMessageId, isServerRequest, instigatorId);
	}

	// Token: 0x06016E42 RID: 93762 RVA: 0x006AEFF2 File Offset: 0x006AD1F2
	[NullableContext(2)]
	protected int RemoveBuffByHandleLocal(int handle, int removeStackCount = -1, string reason = null, long? preMessageId = null, bool? isServerRequest = null, long? instigatorId = null)
	{
		return this.RemoveBuffInner(handle, removeStackCount, true, reason, preMessageId, isServerRequest, instigatorId);
	}

	// Token: 0x06016E43 RID: 93763 RVA: 0x006AF004 File Offset: 0x006AD204
	public void RemoveBuffWhenTimeout(ActiveBuffInternal buff)
	{
		int stackExpirationRemoveNumber = buff.Config.StackExpirationRemoveNumber;
		this.RemoveBuffInner(buff.Handle, stackExpirationRemoveNumber, false, "时间结束自然移除", null, null, null);
		if (stackExpirationRemoveNumber > 0 && buff.IsValid())
		{
			buff.SetDuration(null);
		}
	}

	// Token: 0x06016E44 RID: 93764 RVA: 0x006AF068 File Offset: 0x006AD268
	[NullableContext(2)]
	public unsafe virtual int RemoveBuffInner(int handle, int removeStackCount, bool isPrematureRemoval, string reason, long? preMessageId = null, bool? isServerRequest = null, long? instigatorId = null)
	{
		ActiveBuffInternal activeBuffInternal = this.GetBuffByHandle(handle) as ActiveBuffInternal;
		if (activeBuffInternal == null)
		{
			return 0;
		}
		int buffLock = this.BuffLock;
		this.BuffLock = buffLock + 1;
		<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", activeBuffInternal.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("持有者", this.GetDebugName());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("handle", (activeBuffInternal != null) ? new int?(activeBuffInternal.Handle) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("说明", (activeBuffInternal != null) ? activeBuffInternal.Config.Desc : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("原因", reason);
		ReadOnlySpan<ValueTuple<string, object>> pairs = <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5);
		if (!BaseBuffComponent.NoLogBuffSet.Contains(activeBuffInternal.Id))
		{
			CombatLog.Instance.Info(CombatLog.EDebugModule.Buff, base.Entity, "本地移除buff", pairs);
		}
		int stackCount = activeBuffInternal.StackCount;
		int num = (removeStackCount <= 0) ? 0 : Math.Max(0, stackCount - removeStackCount);
		if (num <= 0)
		{
			try
			{
				this.OnBuffRemoved(activeBuffInternal, isPrematureRemoval, reason, isServerRequest, preMessageId, instigatorId);
				goto IL_1A1;
			}
			catch (Exception e)
			{
				CombatLog.Instance.ErrorWithStack(CombatLog.EDebugModule.Buff, base.Entity, "Buff移除时发生异常", e, pairs);
				goto IL_1A1;
			}
		}
		if (!isPrematureRemoval && this.HasBuffRoutineExpirationLock(activeBuffInternal.Id))
		{
			num = stackCount;
		}
		try
		{
			this.OnBuffStackDecreased(activeBuffInternal, stackCount, num, isPrematureRemoval, reason, EBuffStackPeriodResetOverride.Default, instigatorId);
		}
		catch (Exception e2)
		{
			CombatLog.Instance.ErrorWithStack(CombatLog.EDebugModule.Buff, base.Entity, "Buff层数降低时发生异常", e2, pairs);
		}
		IL_1A1:
		buffLock = this.BuffLock;
		this.BuffLock = buffLock - 1;
		return stackCount - num;
	}

	// Token: 0x06016E45 RID: 93765 RVA: 0x006AF248 File Offset: 0x006AD448
	public IActiveBuff[] GetAllBuffs()
	{
		List<IActiveBuff> list = new List<IActiveBuff>();
		foreach (ActiveBuffInternal activeBuffInternal in this.BuffContainer.Values)
		{
			if (!this.BuffGarbageSet.Contains(activeBuffInternal.Handle))
			{
				list.Add(activeBuffInternal);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06016E46 RID: 93766 RVA: 0x006AF2C0 File Offset: 0x006AD4C0
	[NullableContext(2)]
	public IActiveBuff GetBuffByHandle(int handle)
	{
		if (this.BuffGarbageSet.Contains(handle))
		{
			return null;
		}
		return this.BuffContainer.GetValueOrDefault(handle);
	}

	// Token: 0x06016E47 RID: 93767 RVA: 0x006AF2DE File Offset: 0x006AD4DE
	[NullableContext(2)]
	public IActiveBuff GetPendingBuffByHandle(int handleId)
	{
		return this.BuffContainer.GetValueOrDefault(handleId);
	}

	// Token: 0x06016E48 RID: 93768 RVA: 0x006AF2EC File Offset: 0x006AD4EC
	public bool HasActiveBuff(long buffId)
	{
		return this.GetActiveBuffById(buffId) != null;
	}

	// Token: 0x06016E49 RID: 93769 RVA: 0x006AF2F8 File Offset: 0x006AD4F8
	public bool HasBuff(long buffId, bool excludeRequestRemove = false)
	{
		return (!excludeRequestRemove || !this.WaitRemoveBuffResponse.ContainsKey(buffId)) && this.GetBuffById(buffId) != null;
	}

	// Token: 0x06016E4A RID: 93770 RVA: 0x006AF318 File Offset: 0x006AD518
	public bool IsPendingAddBuff(long buffId, int checkInterval = 200)
	{
		double num;
		return this.PendingAddBuff.TryGetValue(buffId, out num) && Time.Instance.Now - num < (double)checkInterval;
	}

	// Token: 0x06016E4B RID: 93771 RVA: 0x006AF347 File Offset: 0x006AD547
	[NullableContext(2)]
	public virtual BaseBuffComponent GetBuffApplyTarget(long buffId, long instigatorId)
	{
		return this;
	}

	// Token: 0x06016E4C RID: 93772 RVA: 0x006AF34C File Offset: 0x006AD54C
	[NullableContext(2)]
	public ActiveBuffInternal GetActiveBuffById(long buffId)
	{
		HashSet<int> hashSet;
		if (!this.BuffIdToHandleMap.TryGetValue(buffId, out hashSet))
		{
			return null;
		}
		if (hashSet.Count == 0)
		{
			this.BuffIdToHandleMap.Remove(buffId);
			return null;
		}
		List<int> list = new List<int>();
		foreach (int num in hashSet)
		{
			ActiveBuffInternal valueOrDefault = this.BuffContainer.GetValueOrDefault(num);
			if (valueOrDefault == null)
			{
				list.Add(num);
			}
			else if (valueOrDefault.IsActive() && !this.BuffGarbageSet.Contains(valueOrDefault.Handle))
			{
				return valueOrDefault;
			}
		}
		foreach (int item in list)
		{
			hashSet.Remove(item);
		}
		return null;
	}

	// Token: 0x06016E4D RID: 93773 RVA: 0x006AF448 File Offset: 0x006AD648
	[NullableContext(2)]
	public ActiveBuffInternal GetBuffById(long buffId)
	{
		HashSet<int> hashSet;
		if (!this.BuffIdToHandleMap.TryGetValue(buffId, out hashSet))
		{
			return null;
		}
		if (hashSet.Count == 0)
		{
			this.BuffIdToHandleMap.Remove(buffId);
			return null;
		}
		List<int> list = new List<int>();
		foreach (int num in hashSet)
		{
			ActiveBuffInternal valueOrDefault = this.BuffContainer.GetValueOrDefault(num);
			if (valueOrDefault == null)
			{
				list.Add(num);
			}
			else if (!this.BuffGarbageSet.Contains(valueOrDefault.Handle))
			{
				return valueOrDefault;
			}
		}
		foreach (int item in list)
		{
			hashSet.Remove(item);
		}
		return null;
	}

	// Token: 0x06016E4E RID: 93774 RVA: 0x006AF538 File Offset: 0x006AD738
	public IEnumerable<ActiveBuffInternal> GetAllBuffById(long buffId)
	{
		BaseBuffComponent.<GetAllBuffById>d__123 <GetAllBuffById>d__ = new BaseBuffComponent.<GetAllBuffById>d__123(-2);
		<GetAllBuffById>d__.<>4__this = this;
		<GetAllBuffById>d__.<>3__buffId = buffId;
		return <GetAllBuffById>d__;
	}

	// Token: 0x06016E4F RID: 93775 RVA: 0x006AF550 File Offset: 0x006AD750
	public HashSet<int> GetBuffHandleByEffectId(int effectId)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (KeyValuePair<int, ActiveBuffInternal> keyValuePair in this.BuffContainer)
		{
			int i;
			ActiveBuffInternal activeBuffInternal;
			keyValuePair.Deconstruct(out i, out activeBuffInternal);
			int item = i;
			ActiveBuffInternal activeBuffInternal2 = activeBuffInternal;
			if (!this.BuffGarbageSet.Contains(item))
			{
				ExtraEffectParameters[] effectInfos = activeBuffInternal2.Config.EffectInfos;
				for (i = 0; i < effectInfos.Length; i++)
				{
					if (effectInfos[i].ExtraEffectId == (EExtraEffectId)effectId)
					{
						hashSet.Add(item);
						break;
					}
				}
			}
		}
		return hashSet;
	}

	// Token: 0x06016E50 RID: 93776 RVA: 0x006AF5FC File Offset: 0x006AD7FC
	public virtual int? GetBuffLevel(long buffId)
	{
		return null;
	}

	// Token: 0x06016E51 RID: 93777 RVA: 0x006AF614 File Offset: 0x006AD814
	[NullableContext(2)]
	protected ActiveBuffInternal GetStackableBuff(long instigatorId, long buffId, EBuffStackingType stackingType)
	{
		switch (stackingType)
		{
		case EBuffStackingType.ByInstigator:
		{
			HashSet<int> hashSet;
			if (!this.BuffIdToHandleMap.TryGetValue(buffId, out hashSet))
			{
				return null;
			}
			if (hashSet.Count == 0)
			{
				this.BuffIdToHandleMap.Remove(buffId);
				return null;
			}
			List<int> list = new List<int>();
			foreach (int num in hashSet)
			{
				ActiveBuffInternal valueOrDefault = this.BuffContainer.GetValueOrDefault(num);
				if (valueOrDefault == null)
				{
					list.Add(num);
				}
				else if (!this.BuffGarbageSet.Contains(valueOrDefault.Handle))
				{
					long? instigatorId2 = valueOrDefault.InstigatorId;
					if (instigatorId2.GetValueOrDefault() == instigatorId & instigatorId2 != null)
					{
						return valueOrDefault;
					}
				}
			}
			foreach (int item in list)
			{
				hashSet.Remove(item);
			}
			return null;
		}
		case EBuffStackingType.ByOwner:
			return this.GetBuffById(buffId);
		}
		return null;
	}

	// Token: 0x06016E52 RID: 93778 RVA: 0x006AF748 File Offset: 0x006AD948
	public virtual int GetBuffTotalStackById(long buffId, bool onlyActiveBuff = false)
	{
		HashSet<int> hashSet;
		if (!this.BuffIdToHandleMap.TryGetValue(buffId, out hashSet))
		{
			return 0;
		}
		if (hashSet.Count == 0)
		{
			this.BuffIdToHandleMap.Remove(buffId);
			return 0;
		}
		int num = 0;
		List<int> list = new List<int>();
		foreach (int num2 in hashSet)
		{
			ActiveBuffInternal valueOrDefault = this.BuffContainer.GetValueOrDefault(num2);
			if (valueOrDefault == null)
			{
				list.Add(num2);
			}
			else if (!this.BuffGarbageSet.Contains(valueOrDefault.Handle) && (!onlyActiveBuff || valueOrDefault.IsActive()))
			{
				num += valueOrDefault.StackCount;
			}
		}
		foreach (int item in list)
		{
			hashSet.Remove(item);
		}
		return num;
	}

	// Token: 0x06016E53 RID: 93779 RVA: 0x006AF84C File Offset: 0x006ADA4C
	protected unsafe virtual void OnBuffAdded(ActiveBuffInternal buff, int? stackCount, ApplyGEType applyType, long? preMessageId, float? duration, bool? isActive, int serverId, bool fromServer, bool isIterable, bool isServerOrder, [Nullable(2)] string reason)
	{
		if (buff == null)
		{
			return;
		}
		BuffDefinition config = buff.Config;
		if (buff.IsInstantBuff())
		{
			this.ApplyPeriodExecution(buff);
		}
		else
		{
			int handle = buff.Handle;
			this.BuffContainer[handle] = buff;
			HashSet<int> hashSet;
			if (!this.BuffIdToHandleMap.TryGetValue(buff.Id, out hashSet))
			{
				hashSet = new HashSet<int>();
				this.BuffIdToHandleMap[buff.Id] = hashSet;
			}
			hashSet.Add(handle);
			this.MarkListenerBuff(buff);
			ExtraEffectManager buffEffectManager = this.BuffEffectManager;
			if (buffEffectManager != null)
			{
				buffEffectManager.OnBuffAdded(buff);
			}
		}
		if (!this.NeedCheck(buff.Config))
		{
			if (isActive == null)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
				Entity entity = base.Entity;
				string message = "buff激活状态未知";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buff.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("handle", buff.Handle);
				instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else
			{
				this.OnBuffActiveChanged(buff, isActive.Value, null);
			}
		}
		else
		{
			bool isActive2 = this.CheckActivate(buff.Config, buff.GetInstigator());
			this.OnBuffActiveChanged(buff, isActive2, fromServer ? isActive : null);
		}
		if (buff.IsActive() && config != null && config.Period > 0f && config.ExecutePeriodicOnAdd)
		{
			buff.ResetPeriodTimer(0.020000001f);
		}
		this.CheckWhenBuffChanged(buff.Id);
		ExtraEffectParameters[] effectInfos = buff.Config.EffectInfos;
		for (int i = 0; i < effectInfos.Length; i++)
		{
			BuffExecution executionEffect = effectInfos[i].ExecutionEffect;
			if (executionEffect != null)
			{
				executionEffect.OnBuffAddedCallback(buff, isIterable);
			}
		}
		buff.OnTimeScaleChanged(this.GetTimeScale(), this.IsPaused());
		SceneTeamController.Instance.EmitAbilityEvent<long, int, int, Entity>(base.Entity, EAbilityEventName.BuffStackChanged, buff.Id, buff.Id, 0, buff.StackCount, base.Entity);
		this.EmitBuffStackInstigatorChanged(buff.Id, 0, buff.StackCount, buff.InstigatorId);
	}

	// Token: 0x06016E54 RID: 93780 RVA: 0x006AFA6C File Offset: 0x006ADC6C
	public unsafe void ApplyPeriodExecution(ActiveBuffInternal buff)
	{
		BuffDefinition config = buff.Config;
		BaseAttributeComponent instigatorAttributeSet = buff.GetInstigatorAttributeSet();
		if (config.Modifiers != null && config.Modifiers.Length != 0)
		{
			BaseAttributeComponent attributeComponent = this.GetAttributeComponent();
			if (attributeComponent == null)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
				Entity entity = base.Entity;
				string message = "周期buff尝试修改属性，但owner不存在";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buff.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("handle", buff.Handle);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item = "持有者";
				IBuffComponent ownerBuffComponent = buff.GetOwnerBuffComponent();
				ptr = new ValueTuple<string, object>(item, (ownerBuffComponent != null) ? ownerBuffComponent.GetDebugName() : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("施加者", buff.InstigatorId);
				instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
			else
			{
				float timeScale = this.GetTimeScale();
				for (int i = 0; i < buff.StateModifiers.Count; i++)
				{
					ValueTuple<IBuffModifierData, float?> valueTuple = buff.StateModifiers[i];
					if (this.HasBuffAuthority())
					{
						ActiveBuffInternal.ModifyStateAttribute(instigatorAttributeSet, attributeComponent, valueTuple.Item1, buff.Level, timeScale, buff.StackCount, valueTuple.Item2);
					}
				}
			}
		}
		ExtraEffectParameters[] effectInfos = config.EffectInfos;
		for (int j = 0; j < effectInfos.Length; j++)
		{
			BuffExecution executionEffect = effectInfos[j].ExecutionEffect;
			if (executionEffect != null)
			{
				executionEffect.OnPeriodCallback(buff);
			}
		}
		ExtraEffectManager buffEffectManager = this.BuffEffectManager;
		foreach (BuffEffect buffEffect in (((buffEffectManager != null) ? buffEffectManager.GetEffectsByHandle(buff.Handle) : null) ?? Array.Empty<BuffEffect>()))
		{
			buffEffect.OnPeriodCallback();
		}
	}

	// Token: 0x06016E55 RID: 93781 RVA: 0x006AFC4C File Offset: 0x006ADE4C
	protected virtual void OnBuffRemoved(ActiveBuffInternal buff, bool isPrematureRemoval, [Nullable(2)] string reason, bool? isServerRequest = null, long? preMessageId = null, long? instigatorId = null)
	{
		if (buff == null)
		{
			return;
		}
		int handle = buff.Handle;
		int stackCount = buff.StackCount;
		ExtraEffectParameters[] effectInfos = buff.Config.EffectInfos;
		for (int i = 0; i < effectInfos.Length; i++)
		{
			BuffExecution executionEffect = effectInfos[i].ExecutionEffect;
			if (executionEffect != null)
			{
				executionEffect.OnBuffRemovedCallback(buff);
			}
		}
		this.RemoveListenerBuff(buff);
		this.BuffGarbageSet.Add(handle);
		buff.Destroy();
		this.CheckWhenBuffChanged(buff.Id);
		this.BuffEffectManager.OnBuffRemoved(buff, isPrematureRemoval);
		CharacterBuffComponent instigatorBuffComponent = buff.GetInstigatorBuffComponent();
		if ((instigatorBuffComponent == null || instigatorBuffComponent.Valid) && this.HasBuffAuthority())
		{
			long[] array;
			if (!isPrematureRemoval)
			{
				BuffDefinition config = buff.Config;
				array = ((config != null) ? config.RoutineExpirationEffects : null);
			}
			else
			{
				BuffDefinition config2 = buff.Config;
				array = ((config2 != null) ? config2.PrematureExpirationEffects : null);
			}
			long[] array2 = array;
			if (array2 != null)
			{
				foreach (long num in array2)
				{
					long buffId = num;
					int? stackCount2 = null;
					bool isIterable = true;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler.AppendLiteral("因为Buff");
					defaultInterpolatedStringHandler.AppendFormatted<long>(buff.Id);
					defaultInterpolatedStringHandler.AppendLiteral("移除导致的添加");
					this.AddIterativeBuff(buffId, buff, stackCount2, isIterable, defaultInterpolatedStringHandler.ToStringAndClear(), null, null);
				}
			}
			long[] buffsAddedByStackCountOnRemoved = buff.Config.BuffsAddedByStackCountOnRemoved;
			if (isPrematureRemoval && buffsAddedByStackCountOnRemoved != null && stackCount - 1 >= 0 && stackCount - 1 < buffsAddedByStackCountOnRemoved.Length)
			{
				long num2 = buffsAddedByStackCountOnRemoved[stackCount - 1];
				if (num2 != 0L)
				{
					long buffId2 = num2;
					int? stackCount3 = null;
					bool isIterable2 = true;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
					defaultInterpolatedStringHandler.AppendLiteral("buff");
					defaultInterpolatedStringHandler.AppendFormatted<long>(buff.Id);
					defaultInterpolatedStringHandler.AppendLiteral("移除时根据buff层数获取指定buff");
					this.AddIterativeBuff(buffId2, buff, stackCount3, isIterable2, defaultInterpolatedStringHandler.ToStringAndClear(), null, null);
				}
			}
		}
		SceneTeamController.Instance.EmitAbilityEvent<long, int, int, Entity>(base.Entity, EAbilityEventName.BuffStackChanged, buff.Id, buff.Id, stackCount, 0, base.Entity);
		this.EmitBuffStackInstigatorChanged(buff.Id, stackCount, 0, instigatorId);
	}

	// Token: 0x06016E56 RID: 93782 RVA: 0x006AFE4C File Offset: 0x006AE04C
	protected virtual void OnBuffStackDecreased(ActiveBuffInternal buff, int oldStack, int newStack, bool isPrematureRemoval, [Nullable(2)] string reason, EBuffStackPeriodResetOverride stackPeriodResetPolicy = EBuffStackPeriodResetOverride.Default, long? instigatorId = null)
	{
		if (buff == null)
		{
			return;
		}
		buff.SetStackCount(newStack, stackPeriodResetPolicy);
		this.CheckWhenBuffChanged(buff.Id);
		this.BuffEffectManager.OnStackDecreased(buff, newStack, oldStack, isPrematureRemoval);
		SceneTeamController.Instance.EmitAbilityEvent<long, int, int, Entity>(base.Entity, EAbilityEventName.BuffStackChanged, buff.Id, buff.Id, oldStack, newStack, base.Entity);
		this.EmitBuffStackInstigatorChanged(buff.Id, oldStack, newStack, instigatorId);
	}

	// Token: 0x06016E57 RID: 93783 RVA: 0x006AFEB8 File Offset: 0x006AE0B8
	protected virtual void OnBuffStackIncreased(ActiveBuffInternal buff, int oldStack, int newStack, long? instigatorId, int level, int? outerStackCount, ApplyGEType applyType, long? preMessageId, float? duration, int serverId, bool isIterable, bool isServerOrder, [Nullable(2)] string reason, EBuffStackDurationOverride stackDurationRefreshPolicy = EBuffStackDurationOverride.Default, EBuffStackPeriodResetOverride stackPeriodResetPolicy = EBuffStackPeriodResetOverride.Default)
	{
		if (buff == null)
		{
			return;
		}
		buff.SetStackCount(newStack, stackPeriodResetPolicy);
		if (stackDurationRefreshPolicy == EBuffStackDurationOverride.Default && buff.Config.StackDurationRefreshPolicy == EBuffStackDurationRefreshPolicy.Refresh && (this.NeedCheck(buff.Config) || applyType != ApplyGEType.Common))
		{
			buff.SetDuration(duration);
		}
		BuffDefinition config = buff.Config;
		int handle = buff.Handle;
		if (config == null)
		{
			return;
		}
		long id = buff.Id;
		this.BuffEffectManager.OnStackIncreased(buff, newStack, oldStack, instigatorId);
		if (this.HasBuffAuthority())
		{
			int num = (buff.StackLimitCount > 0) ? buff.StackLimitCount : int.MaxValue;
			if (oldStack >= num && newStack >= num)
			{
				long[] overflowEffects = config.OverflowEffects;
				if (overflowEffects != null && overflowEffects.Length != 0)
				{
					foreach (long num2 in overflowEffects)
					{
						long buffId = num2;
						int? stackCount = null;
						bool isIterable2 = true;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 2);
						defaultInterpolatedStringHandler.AppendLiteral("Buff层数溢出时迭代添加新buff（前置buff Id=");
						defaultInterpolatedStringHandler.AppendFormatted<long>(buff.Id);
						defaultInterpolatedStringHandler.AppendLiteral(", handle=");
						defaultInterpolatedStringHandler.AppendFormatted<int>(handle);
						defaultInterpolatedStringHandler.AppendLiteral("）");
						this.AddIterativeBuff(buffId, buff, stackCount, isIterable2, defaultInterpolatedStringHandler.ToStringAndClear(), null, null);
					}
				}
				if (buff.Config.ClearStackOnOverflow)
				{
					this.RemoveBuffByHandle(handle, -1, "Buff层数溢出时清除", null, null, null);
				}
			}
		}
		SceneTeamController.Instance.EmitAbilityEvent<long, int, int, Entity>(base.Entity, EAbilityEventName.BuffStackChanged, buff.Id, buff.Id, oldStack, newStack, base.Entity);
		this.EmitBuffStackInstigatorChanged(buff.Id, oldStack, newStack, instigatorId);
	}

	// Token: 0x06016E58 RID: 93784 RVA: 0x006B0064 File Offset: 0x006AE264
	[NullableContext(2)]
	protected virtual void OnBuffActiveChanged(ActiveBuffInternal buff, bool isActive, bool? syncedActive = null)
	{
		if (buff == null)
		{
			return;
		}
		if ((syncedActive ?? buff.IsActive()) != isActive)
		{
			this.BroadcastActivateBuff(buff, isActive);
		}
		if (buff.IsActive() == isActive)
		{
			return;
		}
		buff.SetActivate(isActive);
		ExtraEffectParameters[] effectInfos = buff.Config.EffectInfos;
		for (int i = 0; i < effectInfos.Length; i++)
		{
			BuffExecution executionEffect = effectInfos[i].ExecutionEffect;
			if (executionEffect != null)
			{
				executionEffect.OnBuffActiveChangedCallback(buff, isActive);
			}
		}
		this.CheckWhenBuffChanged(buff.Id);
		this.BuffEffectManager.OnBuffInhibitedChanged(buff, !isActive);
		this.OnAnyBuffInhibitionChanged(buff);
	}

	// Token: 0x06016E59 RID: 93785 RVA: 0x006B00FE File Offset: 0x006AE2FE
	protected virtual void BroadcastActivateBuff(ActiveBuffInternal buff, bool isActive)
	{
	}

	// Token: 0x06016E5A RID: 93786 RVA: 0x006B0100 File Offset: 0x006AE300
	public void OnTagChanged(int tagId)
	{
		if (this.TagInChanged.Contains(tagId))
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = base.Entity;
			string message = "Tag变更循环派发";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tagId", tagId);
			instance.Warn(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.TagInChanged.Add(tagId);
		this.CheckWhenTagChanged(tagId);
		this.TagInChanged.Remove(tagId);
	}

	// Token: 0x1700231D RID: 8989
	// (get) Token: 0x06016E5B RID: 93787 RVA: 0x006B016C File Offset: 0x006AE36C
	// (set) Token: 0x06016E5C RID: 93788 RVA: 0x006B0174 File Offset: 0x006AE374
	protected int BuffLock
	{
		get
		{
			return this.BuffLockInternal;
		}
		set
		{
			this.BuffLockInternal = value;
			if (value <= 0 && this.BuffGarbageSet.Count > 0)
			{
				foreach (int num in this.BuffGarbageSet)
				{
					ActiveBuffInternal valueOrDefault = this.BuffContainer.GetValueOrDefault(num);
					this.BuffContainer.Remove(num);
					if (valueOrDefault != null)
					{
						HashSet<int> hashSet;
						if (this.BuffIdToHandleMap.TryGetValue(valueOrDefault.Id, out hashSet))
						{
							hashSet.Remove(num);
							if (hashSet.Count == 0)
							{
								this.BuffIdToHandleMap.Remove(valueOrDefault.Id);
							}
						}
						this.UnregisterConfigOverrideListener(valueOrDefault);
						ActiveBuffInternal.ReleaseBuff(valueOrDefault);
					}
				}
				this.BuffGarbageSet.Clear();
			}
		}
	}

	// Token: 0x06016E5D RID: 93789 RVA: 0x006B024C File Offset: 0x006AE44C
	public void AddTrigger(int handleId, EBuffTriggerType buffEffectEventType, IBuffTrigger passiveEffects)
	{
		List<IBuffTrigger> list;
		if (!this.TriggerMap.TryGetValue(buffEffectEventType, out list))
		{
			list = new List<IBuffTrigger>();
			this.TriggerMap[buffEffectEventType] = list;
		}
		list.Add(passiveEffects);
	}

	// Token: 0x06016E5E RID: 93790 RVA: 0x006B0284 File Offset: 0x006AE484
	public void RemoveTrigger(int handleId, EBuffTriggerType extraEffectType)
	{
		List<IBuffTrigger> list;
		if (!this.TriggerMap.TryGetValue(extraEffectType, out list))
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].ActiveHandleId == handleId)
			{
				num = i;
				break;
			}
		}
		if (num != -1)
		{
			list.RemoveAt(num);
		}
	}

	// Token: 0x06016E5F RID: 93791 RVA: 0x006B02D4 File Offset: 0x006AE4D4
	public virtual void TriggerEvents(EBuffTriggerType passiveEffectType, [Nullable(2)] BaseBuffComponent opponentBuffComp, Partial_RequirementPayload payload)
	{
		if (opponentBuffComp == null)
		{
			return;
		}
		EventSystem.Instance.EmitWithTarget<EBuffTriggerType, BaseBuffComponent, Partial_RequirementPayload>(base.Entity, EEventName.OnBuffTriggerEvent, passiveEffectType, opponentBuffComp, payload);
		List<IBuffTrigger> list;
		if (!this.TriggerMap.TryGetValue(passiveEffectType, out list))
		{
			return;
		}
		IBuffTrigger[] array = list.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].TryExecute(payload, opponentBuffComp);
		}
	}

	// Token: 0x06016E60 RID: 93792 RVA: 0x006B032C File Offset: 0x006AE52C
	[return: Nullable(2)]
	public static Entity ShouldForwardToFrontChar(Entity entity)
	{
		FollowShooterComponent component = entity.GetComponent<FollowShooterComponent>();
		if (!component.IsAutonomousProxy)
		{
			return null;
		}
		SceneTeamItem getCurrentTeamItem = SceneTeamModel.Instance.GetCurrentTeamItem;
		bool flag;
		if (getCurrentTeamItem == null)
		{
			flag = (null != null);
		}
		else
		{
			EntityHandle entityHandle = getCurrentTeamItem.EntityHandle;
			flag = (((entityHandle != null) ? entityHandle.Entity : null) != null);
		}
		if (!flag)
		{
			return null;
		}
		WorldEntity entity2 = getCurrentTeamItem.EntityHandle.Entity;
		CreatureDataComponent component2 = entity2.GetComponent<CreatureDataComponent>();
		if (component2 == null)
		{
			return null;
		}
		int roleId = component2.GetRoleId();
		if (Array.IndexOf<int>(component.GetApplyTriggerRoles(), roleId) >= 0)
		{
			return entity2;
		}
		return null;
	}

	// Token: 0x06016E61 RID: 93793 RVA: 0x006B03A4 File Offset: 0x006AE5A4
	public static bool IsFollowShooterByEntity(Entity entity)
	{
		return entity.GetComponent<FollowShooterComponent>() != null;
	}

	// Token: 0x06016E62 RID: 93794 RVA: 0x006B03B1 File Offset: 0x006AE5B1
	public bool HasBuffTrigger(EBuffTriggerType effectType)
	{
		return this.TriggerMap.ContainsKey(effectType);
	}

	// Token: 0x06016E63 RID: 93795 RVA: 0x006B03C0 File Offset: 0x006AE5C0
	public int AddGameplayCue(long[] cueIds, float duration, string reason)
	{
		if (cueIds == null || cueIds.Length == 0)
		{
			return -1;
		}
		BuffDefinition buffDefinition = BuffController.Instance.CreateDynamicBuffRef();
		buffDefinition.GameplayCueIds = cueIds;
		buffDefinition.Desc = reason;
		buffDefinition.DurationPolicy = ((duration == 0f) ? EBuffDurationType.Instant : ((duration < 0f) ? EBuffDurationType.Infinite : EBuffDurationType.HasDuration));
		if (duration > 0f)
		{
			buffDefinition.DurationCalculationPolicy = new int[1];
			buffDefinition.DurationMagnitude = new float[]
			{
				duration
			};
		}
		return this.AddBuffInner(-3L, buffDefinition, null, 1, null, new ApplyGEType?(ApplyGEType.Common), null, null, new float?(duration), null, -1, reason, false, true, false, null, null, null);
	}

	// Token: 0x06016E64 RID: 93796 RVA: 0x006B0494 File Offset: 0x006AE694
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.ApplyGameplayEffectNotify, false, false)]
	public static void BroadcastAddBuffNotify(Entity entity, [Nullable(1)] ApplyGameplayEffectNotify data, CombatCommon combatCommon = null)
	{
		int handle = data.Handle;
		long id = data.Id;
		long instigatorId = data.InstigatorId;
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		long value = MathUtils.Instance.LongToBigInt((combatCommon != null) ? combatCommon.PreMessageId : -1L);
		long value2 = MathUtils.Instance.LongToBigInt((combatCommon != null) ? combatCommon.MessageId : -1L);
		if (baseBuffComponent == null || !baseBuffComponent.Valid)
		{
			return;
		}
		BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(id, null);
		long num = 0L;
		if (data.ConfBuffId != 0L)
		{
			num = data.ConfBuffId;
			BuffDefinition buffDefinition2 = BuffController.Instance.GetBuffDefinition(num, null);
			if (buffDefinition2 != null)
			{
				buffDefinition = buffDefinition2;
			}
		}
		if (buffDefinition != null && handle != -1)
		{
			BaseTagComponent tagComponent = baseBuffComponent.GetTagComponent();
			if (tagComponent != null && buffDefinition.RemoveBuffWithTags != null)
			{
				foreach (int value3 in buffDefinition.RemoveBuffWithTags)
				{
					tagComponent.RemoveTag(new int?(value3));
				}
			}
			baseBuffComponent.AddBuffRemote(id, handle, num, new AddBuffParam
			{
				IsActive = new bool?(data.IsActive),
				InstigatorId = instigatorId,
				Level = new int?(data.Level),
				ApplyType = new ApplyGEType?(data.ApplyType),
				PreMessageId = new long?(value),
				MessageId = new long?(value2),
				ServerId = new int?(data.ServerId),
				Duration = (data.HasDuration ? new float?(data.Duration) : null),
				OuterStackCount = new int?(data.StackCount),
				RemainDuration = (data.HasLeftDuration ? new float?(data.LeftDuration) : null),
				Reason = "远端通知添加buff"
			});
		}
	}

	// Token: 0x06016E65 RID: 93797 RVA: 0x006B0670 File Offset: 0x006AE870
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.ApplyBuffFailedNotify, false, false)]
	public static void BroadcastAddBuffFailedNotify(Entity entity, [Nullable(1)] ApplyBuffFailedNotify data, CombatCommon combatCommon = null)
	{
		long instigatorId = data.InstigatorId;
		EntityHandle entity2 = CreatureModel.Instance.GetEntity(instigatorId);
		WorldEntity worldEntity = (entity2 != null) ? entity2.Entity : null;
		long buffId = data.BuffId;
		if (entity == null || worldEntity == null)
		{
			return;
		}
		SceneTeamController instance = SceneTeamController.Instance;
		Entity target = worldEntity;
		EAbilityEventName name = EAbilityEventName.AddBuffFailure;
		long key = buffId;
		long arg = buffId;
		Entity arg2 = worldEntity;
		int stackCount = data.StackCount;
		MathUtils instance2 = MathUtils.Instance;
		TransferContextId transferContextId = data.TransferContextId;
		instance.EmitAbilityEvent<long, Entity, Entity, int, long?>(target, name, key, arg, entity, arg2, stackCount, new long?(instance2.LongToBigInt((transferContextId != null) ? transferContextId.BulletContextId : 0L)));
	}

	// Token: 0x06016E66 RID: 93798 RVA: 0x006B06E4 File Offset: 0x006AE8E4
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.BuffStackCountNotify, false, false)]
	public static void BroadcastBuffStackChangedNotify(Entity entity, [Nullable(1)] BuffStackCountNotify data, CombatCommon combatCommon = null)
	{
		int handleId = data.HandleId;
		int newStackCount = data.NewStackCount;
		long instigatorId = data.InstigatorId;
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		ActiveBuffInternal activeBuffInternal = ((baseBuffComponent != null) ? baseBuffComponent.GetBuffByHandle(handleId) : null) as ActiveBuffInternal;
		if (baseBuffComponent != null && activeBuffInternal != null)
		{
			if (activeBuffInternal.StackCount > newStackCount)
			{
				baseBuffComponent.OnBuffStackDecreased(activeBuffInternal, activeBuffInternal.StackCount, newStackCount, true, "远端Buff层数变化通知", data.NotRefreshPeriod ? EBuffStackPeriodResetOverride.ForceNoRefresh : EBuffStackPeriodResetOverride.Default, new long?(instigatorId));
			}
			else if (activeBuffInternal.StackCount <= newStackCount)
			{
				EntityHandle entity2 = CreatureModel.Instance.GetEntity(instigatorId);
				WorldEntity worldEntity = (entity2 != null) ? entity2.Entity : null;
				if (worldEntity != null)
				{
					SceneTeamController.Instance.EmitAbilityEvent<long, Entity, Entity, bool?>(worldEntity, EAbilityEventName.AddBuffToOthers, activeBuffInternal.Id, activeBuffInternal.Id, baseBuffComponent.Entity, worldEntity, null);
				}
				SceneTeamController.Instance.EmitAbilityEvent<long, int>(entity, EAbilityEventName.OnBuffAdd, activeBuffInternal.Id, activeBuffInternal.Id, handleId);
				baseBuffComponent.OnBuffStackIncreased(activeBuffInternal, activeBuffInternal.StackCount, newStackCount, new long?(instigatorId), activeBuffInternal.Level, null, ApplyGEType.Common, null, null, activeBuffInternal.ServerId, false, false, "远端Buff层数变化通知", data.NotRefreshDuration ? EBuffStackDurationOverride.ForceNoRefresh : EBuffStackDurationOverride.Default, data.NotRefreshPeriod ? EBuffStackPeriodResetOverride.ForceNoRefresh : EBuffStackPeriodResetOverride.Default);
			}
			if (data.HasDuration)
			{
				activeBuffInternal.SetDuration(new float?(data.Duration));
			}
			if (data.HasLeftDuration)
			{
				activeBuffInternal.SetRemainDuration(data.LeftDuration);
			}
		}
	}

	// Token: 0x06016E67 RID: 93799 RVA: 0x006B0870 File Offset: 0x006AEA70
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.RemoveGameplayEffectNotify, false, false)]
	public unsafe static void BroadcastRemoveBuffNotify(Entity entity, [Nullable(1)] RemoveGameplayEffectNotify data, CombatCommon combatCommon = null)
	{
		int handle = data.Handle;
		long instigatorId = data.InstigatorId;
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		if (baseBuffComponent == null || !baseBuffComponent.Valid)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			string message = "Invalid entity when processing RemoveGameplayEffectNotify";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entity id", data.EntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("handle", data.Handle);
			instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		baseBuffComponent.RemoveBuffInner(handle, -1, true, "远端通知移除buff", null, null, new long?(instigatorId));
	}

	// Token: 0x06016E68 RID: 93800 RVA: 0x006B0938 File Offset: 0x006AEB38
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.BuffDurationNotify, false, false)]
	public static void BuffDurationNotify(Entity entity, [Nullable(1)] BuffDurationNotify data, CombatCommon combatCommon = null)
	{
		int handleId = data.HandleId;
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		ActiveBuffInternal activeBuffInternal = ((baseBuffComponent != null) ? baseBuffComponent.GetBuffByHandle(handleId) : null) as ActiveBuffInternal;
		if (baseBuffComponent == null || activeBuffInternal == null)
		{
			return;
		}
		if (data.HasDuration)
		{
			activeBuffInternal.SetDuration(new float?(data.Duration));
		}
		if (data.HasLeftDuration)
		{
			activeBuffInternal.SetRemainDuration(data.LeftDuration);
		}
	}

	// Token: 0x06016E69 RID: 93801 RVA: 0x006B09A0 File Offset: 0x006AEBA0
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.ApplyBuffS2cRequestNotify, false, true)]
	public static void OrderAddBuffS2cNotify(Entity entity, [Nullable(1)] ApplyBuffS2cRequestNotify data, CombatCommon combatCommon = null)
	{
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		long id = data.Id;
		long instigatorId = data.InstigatorId;
		long value = MathUtils.Instance.LongToBigInt((combatCommon != null) ? combatCommon.MessageId : -1L);
		BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(id, null);
		ApplyBuffS2cResponsePush applyBuffS2cResponsePush = new ApplyBuffS2cResponsePush();
		if (entity == null || (baseBuffComponent == null || !baseBuffComponent.Valid) || buffDefinition == null)
		{
			applyBuffS2cResponsePush.ErrorCode = Aki.Protocol.ErrorCode.UnKnownError;
			CombatNet.Instance.Send(EPushMessageId.ApplyBuffS2cResponsePush, entity, applyBuffS2cResponsePush, new long?(value), null, new bool?(true));
			return;
		}
		BaseTagComponent tagComponent = baseBuffComponent.GetTagComponent();
		if (tagComponent != null && buffDefinition.RemoveBuffWithTags != null)
		{
			foreach (int value2 in buffDefinition.RemoveBuffWithTags)
			{
				tagComponent.RemoveTag(new int?(value2));
			}
		}
		int num = baseBuffComponent.AddBuffInner(id, BuffController.Instance.GetBuffDefinition(id, null), new long?(instigatorId), data.Level, new int?(data.StackCount), new ApplyGEType?(data.ApplyType), new long?(value), null, data.HasDuration ? new float?(data.Duration) : null, null, data.ServerId, "远端请求添加玩家Buff(s2c)", false, data.IsIterable, true, null, null, null);
		ActiveBuffInternal valueOrDefault = baseBuffComponent.BuffContainer.GetValueOrDefault(num);
		applyBuffS2cResponsePush.Handle = num;
		applyBuffS2cResponsePush.IsActive = (valueOrDefault != null && valueOrDefault.IsActive());
		applyBuffS2cResponsePush.ErrorCode = Aki.Protocol.ErrorCode.Success;
		CombatNet.Instance.Send(EPushMessageId.ApplyBuffS2cResponsePush, entity, applyBuffS2cResponsePush, new long?(value), null, new bool?(true));
	}

	// Token: 0x06016E6A RID: 93802 RVA: 0x006B0B88 File Offset: 0x006AED88
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.RemoveBuffS2cRequestNotify, false, false)]
	public static void OrderRemoveBuffS2cNotify(Entity entity, [Nullable(1)] RemoveBuffS2cRequestNotify data, CombatCommon combatCommon = null)
	{
		object obj = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		long value = MathUtils.Instance.LongToBigInt((combatCommon != null) ? combatCommon.MessageId : -1L);
		long instigatorId = data.InstigatorId;
		object obj2 = obj;
		if (obj2 != null)
		{
			obj2.RemoveBuffByHandle(data.Handle, data.StackCount, "远端请求移除buff(s2c)", new long?(value), new bool?(true), new long?(instigatorId));
		}
		RemoveBuffS2cResponsePush removeBuffS2cResponsePush = new RemoveBuffS2cResponsePush();
		removeBuffS2cResponsePush.ErrorCode = Aki.Protocol.ErrorCode.Success;
		CombatNet.Instance.Send(EPushMessageId.RemoveBuffS2cResponsePush, entity, removeBuffS2cResponsePush, new long?(value), null, new bool?(true));
	}

	// Token: 0x06016E6B RID: 93803 RVA: 0x006B0C24 File Offset: 0x006AEE24
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.RemoveBuffByIdS2cRequestNotify, false, false)]
	public unsafe static void OrderRemoveBuffByIdS2cNotify(Entity entity, [Nullable(1)] RemoveBuffByIdS2cRequestNotify data, CombatCommon combatCommon = null)
	{
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		long buffId = data.BuffId;
		long value = MathUtils.Instance.LongToBigInt((combatCommon != null) ? combatCommon.MessageId : -1L);
		RemoveBuffByIdS2cResponsePush removeBuffByIdS2cResponsePush = new RemoveBuffByIdS2cResponsePush();
		long instigatorId = data.InstigatorId;
		if (baseBuffComponent == null || !baseBuffComponent.Valid)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			string message = "Invalid entity when processing RemoveBuffByIdS2cRequestNotify";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entity id", (entity != null) ? new int?(entity.Id) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buffId", buffId);
			instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			removeBuffByIdS2cResponsePush.ErrorCode = Aki.Protocol.ErrorCode.UnKnownError;
			CombatNet.Instance.Send(EPushMessageId.RemoveBuffByIdS2cResponsePush, entity, removeBuffByIdS2cResponsePush, new long?(value), null, new bool?(true));
			return;
		}
		BaseBuffComponent baseBuffComponent2 = baseBuffComponent;
		long buffId2 = buffId;
		int stackCount = data.StackCount;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
		defaultInterpolatedStringHandler.AppendLiteral("远端移除buff(s2c) reason=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(data.Reason);
		baseBuffComponent2.RemoveBuff(buffId2, stackCount, defaultInterpolatedStringHandler.ToStringAndClear(), new long?(value), new bool?(true), new long?(instigatorId));
		removeBuffByIdS2cResponsePush.ErrorCode = Aki.Protocol.ErrorCode.Success;
		CombatNet.Instance.Send(EPushMessageId.RemoveBuffByIdS2cResponsePush, entity, removeBuffByIdS2cResponsePush, new long?(value), null, new bool?(true));
	}

	// Token: 0x06016E6C RID: 93804 RVA: 0x006B0D9C File Offset: 0x006AEF9C
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.RemoveBuffByServerIdS2cRequestNotify, false, false)]
	public unsafe static void OrderRemoveBuffByServerIdNotify(Entity entity, [Nullable(1)] RemoveBuffByServerIdS2cRequestNotify data, CombatCommon combatCommon = null)
	{
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		if (baseBuffComponent == null || !baseBuffComponent.HasBuffAuthority())
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			string message = "[buffComp] 服务端通知移除非主控buff";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("serverId", data.ServerId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", data.Reason);
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		int serverId = data.ServerId;
		int reason = data.Reason;
		int stackCount = data.StackCount;
		long num = MathUtils.Instance.LongToBigInt((combatCommon != null) ? combatCommon.MessageId : -1L);
		long instigatorId = data.InstigatorId;
		BaseBuffComponent baseBuffComponent2 = baseBuffComponent;
		int serverId2 = serverId;
		int stackCount2 = stackCount;
		long preMessageId = num;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
		defaultInterpolatedStringHandler.AppendLiteral("远端移除buff(s2c):");
		defaultInterpolatedStringHandler.AppendFormatted<int>(reason);
		baseBuffComponent2.RemoveBuffByServerId(serverId2, stackCount2, preMessageId, defaultInterpolatedStringHandler.ToStringAndClear(), new long?(instigatorId));
	}

	// Token: 0x06016E6D RID: 93805 RVA: 0x006B0E94 File Offset: 0x006AF094
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.OrderApplyBuffNotify, false, false)]
	public unsafe static void OrderAddBuffNotify(Entity entity, [Nullable(1)] OrderApplyBuffNotify data, CombatCommon combatCommon = null)
	{
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		if (baseBuffComponent == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			string message = "收到服务端请求添加buff，但找不到对应的entity";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entity", entity);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buffId", data.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("InstigatorId", data.InstigatorId);
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		if (baseBuffComponent != null)
		{
			long id = data.Id;
			BaseBuffComponent baseBuffComponent2 = baseBuffComponent;
			long buffId = id;
			AddBuffParam addBuffParam = new AddBuffParam();
			addBuffParam.InstigatorId = data.InstigatorId;
			addBuffParam.Level = new int?(data.Level);
			addBuffParam.ApplyType = new ApplyGEType?(data.ApplyType);
			long? preMessageId;
			if (combatCommon != null)
			{
				long messageId = combatCommon.MessageId;
				if (combatCommon.MessageId != 0L)
				{
					preMessageId = new long?(combatCommon.MessageId);
					goto IL_F9;
				}
			}
			preMessageId = null;
			IL_F9:
			addBuffParam.PreMessageId = preMessageId;
			addBuffParam.Duration = (data.HasDuration ? new float?(data.Duration) : null);
			addBuffParam.IsIterable = new bool?(data.IsIterable);
			addBuffParam.OuterStackCount = new int?(data.StackCount);
			addBuffParam.ServerId = new int?(data.ServerId);
			addBuffParam.IsServerOrder = new bool?(true);
			addBuffParam.Reason = "服务端或其它客户端请求添加Buff";
			baseBuffComponent2.AddBuffLocal(buffId, addBuffParam);
		}
	}

	// Token: 0x06016E6E RID: 93806 RVA: 0x006B1014 File Offset: 0x006AF214
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.OrderRemoveBuffNotify, false, false)]
	public unsafe static void OrderRemoveBuffNotify(Entity entity, [Nullable(1)] OrderRemoveBuffNotify data, CombatCommon combatCommon = null)
	{
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		long id = data.Id;
		if (baseBuffComponent == null)
		{
			BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(id, null);
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			string message = "[order] 移除Buff请求找不到对应实体";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("持有者", (entity != null) ? entity.Id : 0);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("说明", ((buffDefinition != null) ? buffDefinition.Desc : null) ?? "");
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		baseBuffComponent.RemoveBuffLocal(id, data.StackCount, "服务端或其它客户端请求本端移除buff", null, null, null);
	}

	// Token: 0x06016E6F RID: 93807 RVA: 0x006B110C File Offset: 0x006AF30C
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.OrderRemoveBuffByTagsNotify, false, false)]
	public static void OrderRemoveBuffByTagsNotify(Entity entity, [Nullable(1)] OrderRemoveBuffByTagsNotify data, CombatCommon combatCommon = null)
	{
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		long instigatorId = data.InstigatorId;
		if (baseBuffComponent == null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (int tagId in data.TagIds)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(GameplayTagUtils.GetNameByTagId(tagId) ?? "");
			}
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			string message = "[order] 根据tag移除Buff请求找不到对应实体";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tagId", stringBuilder);
			instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		foreach (int tagId2 in data.TagIds)
		{
			string nameByTagId = GameplayTagUtils.GetNameByTagId(tagId2);
			baseBuffComponent.RemoveBuffByTagLocal(tagId2, "远端请求根据tag " + nameByTagId + " 移除buff", new long?(instigatorId));
		}
	}

	// Token: 0x06016E70 RID: 93808 RVA: 0x006B1230 File Offset: 0x006AF430
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.ActivateBuffNotify, false, false)]
	public unsafe static void BroadcastActivateBuffNotify(Entity entity, [Nullable(1)] ActivateBuffNotify data, CombatCommon combatCommon = null)
	{
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		int handle = data.Handle;
		bool on = data.On;
		ActiveBuffInternal activeBuffInternal = ((baseBuffComponent != null) ? baseBuffComponent.GetBuffByHandle(handle) : null) as ActiveBuffInternal;
		if (baseBuffComponent == null || baseBuffComponent.HasBuffAuthority())
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			string message = "主端收到了非主控端发来的buff激活状态变更请求，或找不到Buff持有者，将不做处理";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("handle", handle);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buffId", (activeBuffInternal != null) ? activeBuffInternal.Id : 0L);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("本地激活状态", on);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("远端激活状态", data.On);
			instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return;
		}
		baseBuffComponent.OnBuffActiveChanged(activeBuffInternal, on, null);
	}

	// Token: 0x06016E71 RID: 93809 RVA: 0x006B1334 File Offset: 0x006AF534
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.TransformBuffStackNotify, false, false)]
	public static void BroadcastTransformBuffStackNotify(Entity entity, [Nullable(1)] TransformBuffStackNotify data, CombatCommon combatCommon = null)
	{
		object obj = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		long buffId = data.BuffId;
		int handle = (int)data.BuffHandle;
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.AddBuffStackModifier(buffId, handle, data.StackLimit, EBuffStackModifierType.Incremental);
	}

	// Token: 0x06016E72 RID: 93810 RVA: 0x006B1370 File Offset: 0x006AF570
	public void AddBuffTimeModifier(long targetBuffId, int handle, float period, float duration, bool asInstigator)
	{
		if (period == 0f && duration == 0f)
		{
			return;
		}
		Dictionary<long, Dictionary<int, ValueTuple<float, float>>> dictionary = asInstigator ? this.InstigatorBuffTimeModifiers : this.OwnerBuffTimeModifiers;
		Dictionary<int, ValueTuple<float, float>> dictionary2;
		if (!dictionary.TryGetValue(targetBuffId, out dictionary2))
		{
			dictionary2 = new Dictionary<int, ValueTuple<float, float>>();
			dictionary[targetBuffId] = dictionary2;
		}
		dictionary2[handle] = new ValueTuple<float, float>(period, duration);
	}

	// Token: 0x06016E73 RID: 93811 RVA: 0x006B13CC File Offset: 0x006AF5CC
	public void RemoveBuffTimeModifier(long targetBuffId, int handle, bool asInstigator)
	{
		Dictionary<long, Dictionary<int, ValueTuple<float, float>>> dictionary = asInstigator ? this.InstigatorBuffTimeModifiers : this.OwnerBuffTimeModifiers;
		Dictionary<int, ValueTuple<float, float>> dictionary2;
		if (dictionary.TryGetValue(targetBuffId, out dictionary2))
		{
			dictionary2.Remove(handle);
			if (dictionary2.Count <= 0)
			{
				dictionary.Remove(targetBuffId);
			}
		}
	}

	// Token: 0x06016E74 RID: 93812 RVA: 0x006B1410 File Offset: 0x006AF610
	[NullableContext(2)]
	public float CalculateDurationRate(long buffId, BaseBuffComponent instigator)
	{
		float num = this.CalculateDurationExtraRate(buffId, false);
		if (instigator != null)
		{
			num += instigator.CalculateDurationExtraRate(buffId, true);
		}
		return Math.Max(1E-08f, 1f + num * 0.0001f);
	}

	// Token: 0x06016E75 RID: 93813 RVA: 0x006B144C File Offset: 0x006AF64C
	public virtual float CalculateDurationExtraRate(long buffId, bool asInstigator)
	{
		Dictionary<int, ValueTuple<float, float>> dictionary;
		if (!(asInstigator ? this.InstigatorBuffTimeModifiers : this.OwnerBuffTimeModifiers).TryGetValue(buffId, out dictionary) || dictionary.Count <= 0)
		{
			return 0f;
		}
		float num = 0f;
		foreach (ValueTuple<float, float> valueTuple in dictionary.Values)
		{
			float item = valueTuple.Item2;
			num += item;
		}
		return num;
	}

	// Token: 0x06016E76 RID: 93814 RVA: 0x006B14D4 File Offset: 0x006AF6D4
	[NullableContext(2)]
	public float CalculatePeriodRate(long buffId, BaseBuffComponent instigator)
	{
		float num = this.CalculatePeriodExtraRate(buffId, false);
		if (instigator != null)
		{
			num += instigator.CalculatePeriodExtraRate(buffId, true);
		}
		return Math.Max(1E-08f, 1f + num * 0.0001f);
	}

	// Token: 0x06016E77 RID: 93815 RVA: 0x006B1510 File Offset: 0x006AF710
	public virtual float CalculatePeriodExtraRate(long buffId, bool asInstigator)
	{
		Dictionary<int, ValueTuple<float, float>> dictionary;
		if (!(asInstigator ? this.InstigatorBuffTimeModifiers : this.OwnerBuffTimeModifiers).TryGetValue(buffId, out dictionary) || dictionary.Count <= 0)
		{
			return 1f;
		}
		float num = 0f;
		foreach (ValueTuple<float, float> valueTuple in dictionary.Values)
		{
			float item = valueTuple.Item1;
			num += item;
		}
		return num;
	}

	// Token: 0x06016E78 RID: 93816 RVA: 0x006B1598 File Offset: 0x006AF798
	protected void OnRefreshBuffDuration(long[] buffIds, [Nullable(2)] string reason)
	{
		RefreshBuffDurationPush refreshBuffDurationPush = RefreshBuffDurationPush.Create();
		refreshBuffDurationPush.BuffIds.AddRange(buffIds);
		CombatNet.Instance.Send(EPushMessageId.RefreshBuffDurationPush, base.Entity, refreshBuffDurationPush, null, null, null);
		foreach (long buffId in buffIds)
		{
			foreach (ActiveBuffInternal activeBuffInternal in this.GetAllBuffById(buffId))
			{
				activeBuffInternal.SetDuration(null);
			}
		}
	}

	// Token: 0x06016E79 RID: 93817 RVA: 0x006B1654 File Offset: 0x006AF854
	protected virtual void RefreshBuffDurationOrder(long[] buffIds, [Nullable(2)] string reason)
	{
	}

	// Token: 0x06016E7A RID: 93818 RVA: 0x006B1656 File Offset: 0x006AF856
	public virtual void RefreshBuffDuration(long[] buffIds, [Nullable(2)] string reason)
	{
		if (this.HasBuffAuthority())
		{
			this.OnRefreshBuffDuration(buffIds, reason);
			return;
		}
		this.RefreshBuffDurationOrder(buffIds, reason);
	}

	// Token: 0x06016E7B RID: 93819 RVA: 0x006B1674 File Offset: 0x006AF874
	public void AddBuffStackModifier(long targetBuffId, int handle, int value, EBuffStackModifierType modifierType = EBuffStackModifierType.Incremental)
	{
		if (!this.CheckBuffStackChangeable(targetBuffId))
		{
			return;
		}
		if (value == 0)
		{
			return;
		}
		Dictionary<int, BuffStackModifierValue> dictionary;
		if (!this.BuffStackModifiers.TryGetValue(targetBuffId, out dictionary))
		{
			dictionary = new Dictionary<int, BuffStackModifierValue>();
			this.BuffStackModifiers[targetBuffId] = dictionary;
		}
		bool flag = BaseBuffComponent.HasBuffStackMaxListener();
		int oldMax = flag ? this.CalculateBuffStackMax(targetBuffId).GetValueOrDefault() : 0;
		dictionary[handle] = new BuffStackModifierValue
		{
			Value = value,
			Type = modifierType
		};
		this.RefreshBuffStack(targetBuffId);
		if (flag)
		{
			this.EmitBuffStackMaxChanged(targetBuffId, oldMax, this.CalculateBuffStackMax(targetBuffId).GetValueOrDefault());
		}
		SceneTeamController.Instance.EmitAbilityEvent<long>(base.Entity, EAbilityEventName.OnBuffMaxStackModifier, targetBuffId, targetBuffId);
	}

	// Token: 0x06016E7C RID: 93820 RVA: 0x006B171C File Offset: 0x006AF91C
	public void RemoveBuffStackModifier(long targetBuffId, int handle)
	{
		if (!this.CheckBuffStackChangeable(targetBuffId))
		{
			return;
		}
		bool flag = BaseBuffComponent.HasBuffStackMaxListener();
		int oldMax = flag ? this.CalculateBuffStackMax(targetBuffId).GetValueOrDefault() : 0;
		Dictionary<int, BuffStackModifierValue> dictionary;
		if (this.BuffStackModifiers.TryGetValue(targetBuffId, out dictionary))
		{
			dictionary.Remove(handle);
			if (dictionary.Count <= 0)
			{
				this.BuffStackModifiers.Remove(targetBuffId);
			}
		}
		this.RefreshBuffStack(targetBuffId);
		if (flag)
		{
			this.EmitBuffStackMaxChanged(targetBuffId, oldMax, this.CalculateBuffStackMax(targetBuffId).GetValueOrDefault());
		}
		SceneTeamController.Instance.EmitAbilityEvent<long>(base.Entity, EAbilityEventName.OnBuffMaxStackModifier, targetBuffId, targetBuffId);
	}

	// Token: 0x06016E7D RID: 93821 RVA: 0x006B17B0 File Offset: 0x006AF9B0
	public int? CalculateBuffStackMaxByConfig(BuffDefinition config, long buffId)
	{
		if (config.StackLimitCount <= 0)
		{
			return new int?(int.MaxValue);
		}
		int num = 0;
		Dictionary<int, BuffStackModifierValue> dictionary;
		if (this.BuffStackModifiers.TryGetValue(buffId, out dictionary))
		{
			foreach (BuffStackModifierValue buffStackModifierValue in dictionary.Values)
			{
				if (buffStackModifierValue.Type == EBuffStackModifierType.Incremental)
				{
					num += buffStackModifierValue.Value;
				}
				else if (buffStackModifierValue.Type == EBuffStackModifierType.Override)
				{
					return new int?(buffStackModifierValue.Value);
				}
			}
		}
		return new int?(Math.Max(1, config.StackLimitCount + num));
	}

	// Token: 0x06016E7E RID: 93822 RVA: 0x006B1864 File Offset: 0x006AFA64
	public int? CalculateBuffStackMax(long buffId)
	{
		BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(buffId, null);
		if (buffDefinition == null)
		{
			return new int?(0);
		}
		if (buffDefinition.StackLimitCount <= 0)
		{
			return new int?(int.MaxValue);
		}
		int num = 0;
		Dictionary<int, BuffStackModifierValue> dictionary;
		if (this.BuffStackModifiers.TryGetValue(buffId, out dictionary))
		{
			foreach (BuffStackModifierValue buffStackModifierValue in dictionary.Values)
			{
				if (buffStackModifierValue.Type == EBuffStackModifierType.Incremental)
				{
					num += buffStackModifierValue.Value;
				}
				else if (buffStackModifierValue.Type == EBuffStackModifierType.Override)
				{
					return new int?(buffStackModifierValue.Value);
				}
			}
		}
		return new int?(Math.Max(1, buffDefinition.StackLimitCount + num));
	}

	// Token: 0x06016E7F RID: 93823 RVA: 0x006B1934 File Offset: 0x006AFB34
	public int RefreshBuffStackMax(long buffId)
	{
		ActiveBuffInternal buffById = this.GetBuffById(buffId);
		if (buffById == null)
		{
			return 0;
		}
		int? num = this.CalculateBuffStackMax(buffId);
		if (num == null)
		{
			return 0;
		}
		if (num.GetValueOrDefault() == 2147483647)
		{
			return int.MaxValue;
		}
		buffById.StackLimitCount = num.Value;
		return buffById.StackLimitCount;
	}

	// Token: 0x06016E80 RID: 93824 RVA: 0x006B1988 File Offset: 0x006AFB88
	public void RefreshBuffStack(long buffId)
	{
		ActiveBuffInternal buffById = this.GetBuffById(buffId);
		if (buffById == null)
		{
			return;
		}
		int stackCount = buffById.StackCount;
		int num = this.RefreshBuffStackMax(buffId);
		if (num < stackCount)
		{
			if (this.HasBuffAuthority())
			{
				ExtraEffectManager buffEffectManager = this.BuffEffectManager;
				if (buffEffectManager != null)
				{
					buffEffectManager.OnBuffStackOverflow(buffById, stackCount, stackCount, num);
				}
			}
			this.OnBuffStackDecreased(buffById, stackCount, num, true, "buff层数修改器导致", EBuffStackPeriodResetOverride.Default, null);
		}
	}

	// Token: 0x06016E81 RID: 93825 RVA: 0x006B19EC File Offset: 0x006AFBEC
	public bool CheckBuffStackChangeable(long buffId)
	{
		BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(buffId, null);
		return buffDefinition != null && buffDefinition.StackLimitCount > 0;
	}

	// Token: 0x06016E82 RID: 93826 RVA: 0x006B1A14 File Offset: 0x006AFC14
	public void ChangeBuffStack(long buffId, EBuffStackDurationOverride stackDurationRefreshPolicy, EBuffStackPeriodResetOverride stackPeriodResetPolicy, int stackChange, string reason, long? instigatorId = null)
	{
		if (!this.HasBuffAuthority())
		{
			return;
		}
		foreach (ActiveBuffInternal activeBuffInternal in this.GetAllBuffById(buffId))
		{
			int stackCount = activeBuffInternal.StackCount;
			int stackLimitCount = activeBuffInternal.StackLimitCount;
			int num = Math.Min(stackCount + stackChange, stackLimitCount);
			if (num <= 0)
			{
				this.RemoveBuffInner(activeBuffInternal.Handle, -1, true, reason, null, null, instigatorId);
			}
			else if (num < stackCount)
			{
				this.OnBuffStackDecreased(activeBuffInternal, stackCount, num, true, reason, stackPeriodResetPolicy, instigatorId);
			}
			else if (num > stackCount)
			{
				this.OnBuffStackIncreased(activeBuffInternal, stackCount, num, instigatorId, activeBuffInternal.Level, null, ApplyGEType.Common, null, null, activeBuffInternal.ServerId, false, false, reason, stackDurationRefreshPolicy, stackPeriodResetPolicy);
			}
		}
	}

	// Token: 0x06016E83 RID: 93827 RVA: 0x006B1B0C File Offset: 0x006AFD0C
	public void SetDeferredCueCreationEnable(bool enable)
	{
		this.EnableDeferredCueCreation = enable;
	}

	// Token: 0x06016E84 RID: 93828 RVA: 0x006B1B18 File Offset: 0x006AFD18
	public void ProcessPendingCues()
	{
		while (this.PendingInstantCues.Count > 0)
		{
			if (BuffController.Instance.CueTimeLimit.IsTimeLimitExceeded())
			{
				break;
			}
			double microseconds = KuroTime.GetMicroseconds64();
			BaseBuffComponent.PendingInstantCueItem pendingInstantCueItem = this.PendingInstantCues[0];
			this.PendingInstantCues.RemoveAt(0);
			BaseGameplayCueComponent cueComponent = this.GetCueComponent();
			if (cueComponent != null)
			{
				cueComponent.AddCue(pendingInstantCueItem.CueId, new GameplayCueParam?(pendingInstantCueItem.Param));
			}
			double microseconds2 = KuroTime.GetMicroseconds64();
			BuffController.Instance.CueTimeLimit.AddCost(microseconds2 - microseconds);
		}
		while (this.PendingDestroyCueBuffs.Count > 0)
		{
			if (BuffController.Instance.CueTimeLimit.IsTimeLimitExceeded())
			{
				break;
			}
			double microseconds3 = KuroTime.GetMicroseconds64();
			int? num = null;
			using (HashSet<int>.Enumerator enumerator = this.PendingDestroyCueBuffs.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					int value = enumerator.Current;
					num = new int?(value);
				}
			}
			if (num != null)
			{
				this.PendingDestroyCueBuffs.Remove(num.Value);
				this.DestroyGameplayCueByBuffImmediate(num.Value);
			}
			double microseconds4 = KuroTime.GetMicroseconds64();
			BuffController.Instance.CueTimeLimit.AddCost(microseconds4 - microseconds3);
		}
		while (this.PendingCreateCueBuffs.Count > 0 && !BuffController.Instance.CueTimeLimit.IsTimeLimitExceeded())
		{
			double microseconds5 = KuroTime.GetMicroseconds64();
			int? num2 = null;
			using (HashSet<int>.Enumerator enumerator = this.PendingCreateCueBuffs.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					int value2 = enumerator.Current;
					num2 = new int?(value2);
				}
			}
			if (num2 != null)
			{
				this.PendingCreateCueBuffs.Remove(num2.Value);
				IActiveBuff buffByHandle = this.GetBuffByHandle(num2.Value);
				if (buffByHandle != null && buffByHandle.IsActive() && !this.Buff2CueMap.ContainsKey(num2.Value))
				{
					this.CreateGameplayCueByBuffImmediate(buffByHandle);
				}
			}
			double microseconds6 = KuroTime.GetMicroseconds64();
			BuffController.Instance.CueTimeLimit.AddCost(microseconds6 - microseconds5);
		}
		if (this.PendingCreateCueBuffs.Count == 0 && this.PendingDestroyCueBuffs.Count == 0 && this.PendingInstantCues.Count == 0)
		{
			BuffController.Instance.UnregisterBuffComponent(this);
		}
	}

	// Token: 0x06016E85 RID: 93829 RVA: 0x006B1D8C File Offset: 0x006AFF8C
	protected void CreateGameplayCueByBuff(IActiveBuff buff)
	{
		if (buff.Config.GameplayCueIds == null || buff.Config.GameplayCueIds.Length == 0)
		{
			return;
		}
		if (this.PendingDestroyCueBuffs.Contains(buff.Handle))
		{
			this.PendingDestroyCueBuffs.Remove(buff.Handle);
			return;
		}
		if (!this.EnableDeferredCueCreation)
		{
			this.CreateGameplayCueByBuffImmediate(buff);
			return;
		}
		if (buff.IsInstantBuff())
		{
			Entity instigator = buff.GetInstigator();
			foreach (long cueId in buff.Config.GameplayCueIds)
			{
				long cueId2 = ReplaceAbnormalCueEffect.ApplyEffects(base.Entity, cueId);
				this.PendingInstantCues.Add(new BaseBuffComponent.PendingInstantCueItem
				{
					CueId = cueId2,
					Param = new GameplayCueParam
					{
						Instant = true,
						Instigator = CharacterModel.Instance.GetHandleByEntity(instigator)
					}
				});
			}
		}
		else
		{
			this.PendingCreateCueBuffs.Add(buff.Handle);
		}
		BuffController.Instance.RegisterBuffComponent(this);
	}

	// Token: 0x06016E86 RID: 93830 RVA: 0x006B1E90 File Offset: 0x006B0090
	protected void CreateGameplayCueByBuffImmediate(IActiveBuff buff)
	{
		BaseGameplayCueComponent cueComponent = this.GetCueComponent();
		if (cueComponent == null)
		{
			return;
		}
		if (!buff.IsActive())
		{
			return;
		}
		int handle = buff.Handle;
		if (this.Buff2CueMap.ContainsKey(handle))
		{
			return;
		}
		if (this.CreateSeamlessTravelCue(buff, cueComponent))
		{
			return;
		}
		if (buff.Config.GameplayCueIds != null)
		{
			foreach (long cueId in buff.Config.GameplayCueIds)
			{
				long cueId2 = ReplaceAbnormalCueEffect.ApplyEffects(base.Entity, cueId);
				int num = cueComponent.AddCue(cueId2, new GameplayCueParam?(new GameplayCueParam
				{
					Buff = buff,
					Instant = buff.IsInstantBuff(),
					Instigator = CharacterModel.Instance.GetHandleByEntity(buff.GetInstigator())
				}));
				if (num != -1 && num != 0)
				{
					List<int> list;
					if (!this.Buff2CueMap.TryGetValue(handle, out list))
					{
						list = new List<int>();
						this.Buff2CueMap[handle] = list;
					}
					list.Add(num);
				}
			}
		}
	}

	// Token: 0x06016E87 RID: 93831 RVA: 0x006B1F94 File Offset: 0x006B0194
	protected void DestroyGameplayCueByBuff(IActiveBuff buff)
	{
		int handle = buff.Handle;
		if (this.PendingCreateCueBuffs.Contains(handle))
		{
			this.PendingCreateCueBuffs.Remove(handle);
			return;
		}
		if (!this.EnableDeferredCueCreation)
		{
			this.DestroyGameplayCueByBuffImmediate(handle);
			return;
		}
		if (!this.Buff2CueMap.ContainsKey(handle))
		{
			return;
		}
		this.PendingDestroyCueBuffs.Add(handle);
		BuffController.Instance.RegisterBuffComponent(this);
	}

	// Token: 0x06016E88 RID: 93832 RVA: 0x006B1FFC File Offset: 0x006B01FC
	protected void DestroyGameplayCueByBuffImmediate(int buffHandle)
	{
		BaseGameplayCueComponent cueComponent = this.GetCueComponent();
		if (cueComponent == null)
		{
			return;
		}
		List<int> list;
		if (!this.Buff2CueMap.TryGetValue(buffHandle, out list))
		{
			return;
		}
		foreach (int num in list)
		{
			cueComponent.RemoveCueByHandle((long)num);
		}
		this.Buff2CueMap.Remove(buffHandle);
	}

	// Token: 0x06016E89 RID: 93833 RVA: 0x006B2074 File Offset: 0x006B0274
	protected virtual void OnAnyBuffInhibitionChanged(IActiveBuff buff)
	{
		if (buff.IsActive())
		{
			this.CreateGameplayCueByBuff(buff);
			return;
		}
		this.DestroyGameplayCueByBuff(buff);
	}

	// Token: 0x06016E8A RID: 93834 RVA: 0x006B2090 File Offset: 0x006B0290
	protected unsafe bool CreateSeamlessTravelCue(IActiveBuff buff, BaseGameplayCueComponent cueComp)
	{
		if (this.SeamlessTravelBuffCue == null)
		{
			return false;
		}
		List<List<int>> list;
		if (!this.SeamlessTravelBuffCue.TryGetValue(buff.Id, out list) || list.Count == 0)
		{
			return false;
		}
		List<int> list2 = list[list.Count - 1];
		list.RemoveAt(list.Count - 1);
		this.Buff2CueMap[buff.Handle] = list2;
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
		Entity entity = base.Entity;
		string message = "[无缝加载]buff特效复用";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buff.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buffHandle", buff.Handle);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("cueHandle", list2);
		instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		foreach (int num in list2)
		{
			cueComp.ChangeBuffHandle((long)num, buff);
		}
		return true;
	}

	// Token: 0x06016E8B RID: 93835 RVA: 0x006B21C0 File Offset: 0x006B03C0
	protected bool SeamlessTravelBuffRetain(IActiveBuff buff)
	{
		return buff.Id < 0L;
	}

	// Token: 0x06016E8C RID: 93836 RVA: 0x006B21CC File Offset: 0x006B03CC
	public void SeamlessTravelingRefresh()
	{
		CombatLog.Instance.Info(CombatLog.EDebugModule.Buff, base.Entity, "[无缝加载]buff刷新", default(ReadOnlySpan<ValueTuple<string, object>>));
		HashSet<IActiveBuff> hashSet = new HashSet<IActiveBuff>();
		foreach (IActiveBuff activeBuff in this.GetAllBuffs())
		{
			if (!this.SeamlessTravelBuffRetain(activeBuff))
			{
				hashSet.Add(activeBuff);
			}
		}
		if (this.SeamlessTravelBuffCue == null)
		{
			this.SeamlessTravelBuffCue = new Dictionary<long, List<List<int>>>();
		}
		foreach (IActiveBuff activeBuff2 in hashSet)
		{
			List<int> item;
			if (this.Buff2CueMap.TryGetValue(activeBuff2.Handle, out item))
			{
				List<List<int>> list;
				if (!this.SeamlessTravelBuffCue.TryGetValue(activeBuff2.Id, out list))
				{
					list = new List<List<int>>();
					this.SeamlessTravelBuffCue[activeBuff2.Id] = list;
				}
				list.Add(item);
				this.Buff2CueMap.Remove(activeBuff2.Handle);
			}
			this.RemoveBuffByHandle(activeBuff2.Handle, -1, "无缝加载移除旧buff", null, null, null);
		}
		this.InitBornBuff();
		BaseGameplayCueComponent cueComponent = this.GetCueComponent();
		if (cueComponent != null)
		{
			foreach (KeyValuePair<long, List<List<int>>> keyValuePair in this.SeamlessTravelBuffCue)
			{
				long num;
				List<List<int>> list2;
				keyValuePair.Deconstruct(out num, out list2);
				foreach (List<int> list3 in list2)
				{
					foreach (int num2 in list3)
					{
						cueComponent.RemoveCueByHandle((long)num2);
					}
				}
			}
		}
		this.SeamlessTravelBuffCue.Clear();
		this.OnSeamlessTravelingRefreshEnd();
	}

	// Token: 0x06016E8D RID: 93837 RVA: 0x006B2400 File Offset: 0x006B0600
	protected virtual void OnSeamlessTravelingRefreshEnd()
	{
	}

	// Token: 0x06016E8E RID: 93838 RVA: 0x006B2402 File Offset: 0x006B0602
	public static void CreateStaticDefaultValue()
	{
		BaseBuffComponent._buffStatMap = new Dictionary<long, Stat>();
	}

	// Token: 0x06016E8F RID: 93839 RVA: 0x006B240E File Offset: 0x006B060E
	public static void ResetStaticDefaultValue()
	{
		BaseBuffComponent._buffStatMap = null;
	}

	// Token: 0x06016E90 RID: 93840 RVA: 0x006B2416 File Offset: 0x006B0616
	protected void SetBuffComponentType(EBuffComponentType value)
	{
		this.BuffComponentType = value;
	}

	// Token: 0x06016E91 RID: 93841 RVA: 0x006B241F File Offset: 0x006B061F
	public EBuffComponentType GetBuffComponentType()
	{
		return this.BuffComponentType;
	}

	// Token: 0x06016E92 RID: 93842 RVA: 0x006B2427 File Offset: 0x006B0627
	public bool IsTeamBuffComponent()
	{
		return this.BuffComponentType == EBuffComponentType.TeamBuffComponent;
	}

	// Token: 0x06016E93 RID: 93843 RVA: 0x006B2432 File Offset: 0x006B0632
	public bool IsRoleBuffComponent()
	{
		return this.BuffComponentType == EBuffComponentType.RoleBuffComponent;
	}

	// Token: 0x06016E94 RID: 93844 RVA: 0x006B2440 File Offset: 0x006B0640
	public static List<int> GetCurrentEntityIds()
	{
		List<EntityHandle> teamEntities = SceneTeamModel.Instance.GetTeamEntities(true);
		List<int> list = new List<int>();
		foreach (EntityHandle entityHandle in teamEntities)
		{
			list.Add(entityHandle.Id);
		}
		return list;
	}

	// Token: 0x06016E95 RID: 93845 RVA: 0x006B24A4 File Offset: 0x006B06A4
	public static List<int> GetNewOrRemoveTeamEntityIds(List<int> oldTeamEntityIds, bool newEntity = true)
	{
		List<int> currentEntityIds = BaseBuffComponent.GetCurrentEntityIds();
		if (newEntity)
		{
			List<int> list = new List<int>();
			foreach (int item in currentEntityIds)
			{
				if (!oldTeamEntityIds.Contains(item))
				{
					list.Add(item);
				}
			}
			return list;
		}
		List<int> list2 = new List<int>();
		foreach (int item2 in oldTeamEntityIds)
		{
			if (!currentEntityIds.Contains(item2))
			{
				list2.Add(item2);
			}
		}
		return list2;
	}

	// Token: 0x06016E96 RID: 93846 RVA: 0x006B2560 File Offset: 0x006B0760
	public List<T> GetTargetComponents<[Nullable(0)] T>(EComponent componentType, long? buffId = null) where T : EntityComponent
	{
		List<T> list = new List<T>();
		if (this.IsTeamBuffComponent())
		{
			using (List<EntityHandle>.Enumerator enumerator = SceneTeamModel.Instance.GetTeamEntities(true).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					EntityHandle entityHandle = enumerator.Current;
					WorldEntity entity = entityHandle.Entity;
					T t = (entity != null) ? entity.GetComponent<T>() : default(T);
					if (t != null)
					{
						list.Add(t);
					}
					else if (buffId != null)
					{
						CombatLog instance = CombatLog.Instance;
						CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
						Entity entity2 = base.Entity;
						string message = "编队额外效果获取组件失败";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("buffId", buffId);
						instance.Error(flag, entity2, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
				}
				return list;
			}
		}
		Entity entity3 = this.GetEntity();
		T t2 = (entity3 != null) ? entity3.GetComponent<T>() : default(T);
		if (t2 != null)
		{
			list.Add(t2);
		}
		else if (buffId != null)
		{
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Buff;
			Entity entity4 = base.Entity;
			string message2 = "非编队额外效果获取组件失败";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("buffId", buffId);
			instance2.Error(flag2, entity4, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		return list;
	}

	// Token: 0x06016E97 RID: 93847 RVA: 0x006B2690 File Offset: 0x006B0890
	public unsafe bool AddReplaceBuff(long originBuffId, BuffReplace replaceBuffInfo)
	{
		if (this.ReplaceBuffMap.ContainsKey(originBuffId))
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = base.Entity;
			string message = "添加重复的buff替换关系";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("originBuffId", originBuffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("replaceBuffInfo", replaceBuffInfo);
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		CombatLog instance2 = CombatLog.Instance;
		CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Buff;
		Entity entity2 = base.Entity;
		string message2 = "添加buff替换";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("originBuffId", originBuffId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("replaceBuffInfo", replaceBuffInfo);
		instance2.Info(flag2, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		this.ReplaceBuffMap[originBuffId] = replaceBuffInfo;
		return true;
	}

	// Token: 0x06016E98 RID: 93848 RVA: 0x006B2774 File Offset: 0x006B0974
	public bool RemoveReplaceBuff(long originBuffId)
	{
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
		Entity entity = base.Entity;
		string message = "移除buff替换";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("originBuffId", originBuffId);
		instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.ReplaceBuffMap.Remove(originBuffId);
		return true;
	}

	// Token: 0x06016E99 RID: 93849 RVA: 0x006B27C0 File Offset: 0x006B09C0
	public long? GetReplaceBuffId(long originBuffId, AddBuffParam buffParams)
	{
		if (!this.ReplaceBuffMap.ContainsKey(originBuffId))
		{
			return null;
		}
		BuffReplace buffReplace = this.ReplaceBuffMap[originBuffId];
		buffParams.PreMessageId = buffReplace.PreMessageId;
		return new long?(buffReplace.ReplaceBuffId);
	}

	// Token: 0x06016E9A RID: 93850 RVA: 0x006B2809 File Offset: 0x006B0A09
	public virtual void AddBuffRefEntityId(long buffId, int entityId)
	{
	}

	// Token: 0x06016E9B RID: 93851 RVA: 0x006B280B File Offset: 0x006B0A0B
	public virtual void RemoveBuffRefEntityId(long buffId, int entityId)
	{
	}

	// Token: 0x06016E9C RID: 93852 RVA: 0x006B280D File Offset: 0x006B0A0D
	public virtual bool HasBuffRefEntityId(long buffId)
	{
		return false;
	}

	// Token: 0x06016E9D RID: 93853 RVA: 0x006B2810 File Offset: 0x006B0A10
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseBuffComponent baseBuffComponent = (BaseBuffComponent)componentTemplate;
		if (baseBuffComponent.CreatureDataComponent == null)
		{
			this.CreatureDataComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComponent), "CreatureDataComponent"))
		{
			return false;
		}
		if (baseBuffComponent.DeathComponent == null)
		{
			this.DeathComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DeathComponent), "DeathComponent"))
		{
			return false;
		}
		if (baseBuffComponent.BuffContainer != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffContainer), "BuffContainer"))
		{
			return false;
		}
		if (baseBuffComponent.BuffIdToHandleMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffIdToHandleMap), "BuffIdToHandleMap"))
		{
			return false;
		}
		if (baseBuffComponent.BuffGarbageSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.BuffGarbageSet), "BuffGarbageSet"))
		{
			return false;
		}
		if (baseBuffComponent.WaitRemoveBuffResponse != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.WaitRemoveBuffResponse), "WaitRemoveBuffResponse"))
		{
			return false;
		}
		if (baseBuffComponent.PendingAddBuff != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.PendingAddBuff), "PendingAddBuff"))
		{
			return false;
		}
		if (baseBuffComponent.BuffEffectManager == null)
		{
			this.BuffEffectManager = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffEffectManager), "BuffEffectManager"))
		{
			return false;
		}
		if (baseBuffComponent.TagListenerDict != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagListenerDict), "TagListenerDict"))
		{
			return false;
		}
		if (baseBuffComponent.BuffListenerDict != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffListenerDict), "BuffListenerDict"))
		{
			return false;
		}
		if (baseBuffComponent.TagImmuneListenerDict != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagImmuneListenerDict), "TagImmuneListenerDict"))
		{
			return false;
		}
		if (baseBuffComponent.VictimTagListenerDict != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.VictimTagListenerDict), "VictimTagListenerDict"))
		{
			return false;
		}
		if (baseBuffComponent.ConfigOverrideConditionListener != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ConfigOverrideConditionListener), "ConfigOverrideConditionListener"))
		{
			return false;
		}
		if (baseBuffComponent.VictimBuffListenerDict != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.VictimBuffListenerDict), "VictimBuffListenerDict"))
		{
			return false;
		}
		if (baseBuffComponent.InstigatorEventListenDict != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.InstigatorEventListenDict), "InstigatorEventListenDict"))
		{
			return false;
		}
		if (baseBuffComponent.BuffRoutineExpirationLock != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffRoutineExpirationLock), "BuffRoutineExpirationLock"))
		{
			return false;
		}
		if (baseBuffComponent.EffectTimeoutMap == null)
		{
			this.EffectTimeoutMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.EffectTimeoutMap), "EffectTimeoutMap"))
		{
			return false;
		}
		if (baseBuffComponent.EffectTargetTimeoutMap == null)
		{
			this.EffectTargetTimeoutMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.EffectTargetTimeoutMap), "EffectTargetTimeoutMap"))
		{
			return false;
		}
		if (baseBuffComponent.TagInChanged != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.TagInChanged), "TagInChanged"))
		{
			return false;
		}
		this.BuffLockInternal = baseBuffComponent.BuffLockInternal;
		if (baseBuffComponent.TriggerMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TriggerMap), "TriggerMap"))
		{
			return false;
		}
		if (baseBuffComponent.OwnerBuffTimeModifiers == null)
		{
			this.OwnerBuffTimeModifiers = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OwnerBuffTimeModifiers), "OwnerBuffTimeModifiers"))
		{
			return false;
		}
		if (baseBuffComponent.InstigatorBuffTimeModifiers == null)
		{
			this.InstigatorBuffTimeModifiers = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InstigatorBuffTimeModifiers), "InstigatorBuffTimeModifiers"))
		{
			return false;
		}
		if (baseBuffComponent.BuffStackModifiers == null)
		{
			this.BuffStackModifiers = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffStackModifiers), "BuffStackModifiers"))
		{
			return false;
		}
		this.EnableDeferredCueCreation = baseBuffComponent.EnableDeferredCueCreation;
		if (baseBuffComponent.Buff2CueMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.Buff2CueMap), "Buff2CueMap"))
		{
			return false;
		}
		if (baseBuffComponent.PendingCreateCueBuffs != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.PendingCreateCueBuffs), "PendingCreateCueBuffs"))
		{
			return false;
		}
		if (baseBuffComponent.PendingInstantCues != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.PendingInstantCues), "PendingInstantCues"))
		{
			return false;
		}
		if (baseBuffComponent.PendingDestroyCueBuffs != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.PendingDestroyCueBuffs), "PendingDestroyCueBuffs"))
		{
			return false;
		}
		if (baseBuffComponent.SeamlessTravelBuffCue == null)
		{
			this.SeamlessTravelBuffCue = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SeamlessTravelBuffCue), "SeamlessTravelBuffCue"))
		{
			return false;
		}
		this.BuffComponentType = baseBuffComponent.BuffComponentType;
		return baseBuffComponent.ReplaceBuffMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.ReplaceBuffMap), "ReplaceBuffMap");
	}

	// Token: 0x1700231E RID: 8990
	// (get) Token: 0x06016E9E RID: 93854 RVA: 0x006B2C7F File Offset: 0x006B0E7F
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700231F RID: 8991
	// (get) Token: 0x06016E9F RID: 93855 RVA: 0x006B2C82 File Offset: 0x006B0E82
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002320 RID: 8992
	// (get) Token: 0x06016EA0 RID: 93856 RVA: 0x006B2C85 File Offset: 0x006B0E85
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002321 RID: 8993
	// (get) Token: 0x06016EA1 RID: 93857 RVA: 0x006B2C88 File Offset: 0x006B0E88
	public override bool NeedChangeTimeDilationInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06016EA3 RID: 93859 RVA: 0x006B2DB2 File Offset: 0x006B0FB2
	bool IBuffComponent.get_Valid()
	{
		return base.Valid;
	}

	// Token: 0x0400BFDE RID: 49118
	[Nullable(2)]
	protected CreatureDataComponent CreatureDataComponent;

	// Token: 0x0400BFDF RID: 49119
	[Nullable(2)]
	protected BaseDeathComponent DeathComponent;

	// Token: 0x0400BFE0 RID: 49120
	protected readonly Dictionary<int, ActiveBuffInternal> BuffContainer = new Dictionary<int, ActiveBuffInternal>();

	// Token: 0x0400BFE1 RID: 49121
	protected readonly Dictionary<long, HashSet<int>> BuffIdToHandleMap = new Dictionary<long, HashSet<int>>();

	// Token: 0x0400BFE2 RID: 49122
	protected readonly HashSet<int> BuffGarbageSet = new HashSet<int>();

	// Token: 0x0400BFE3 RID: 49123
	protected readonly Dictionary<long, int> WaitRemoveBuffResponse = new Dictionary<long, int>();

	// Token: 0x0400BFE4 RID: 49124
	protected readonly Dictionary<long, double> PendingAddBuff = new Dictionary<long, double>();

	// Token: 0x0400BFE5 RID: 49125
	[StaticVariableRuleIgnore]
	protected static readonly HashSet<long> NoLogBuffSet = new HashSet<long>
	{
		-3L,
		1101003012L,
		800080191L,
		800100003081L,
		1302121034L,
		1304700001L,
		640007016L,
		1202803014L,
		1202002003L
	};

	// Token: 0x0400BFE7 RID: 49127
	protected readonly Dictionary<int, HashSet<int>> TagListenerDict = new Dictionary<int, HashSet<int>>();

	// Token: 0x0400BFE8 RID: 49128
	protected readonly Dictionary<long, HashSet<int>> BuffListenerDict = new Dictionary<long, HashSet<int>>();

	// Token: 0x0400BFE9 RID: 49129
	public readonly Dictionary<int, HashSet<int>> TagImmuneListenerDict = new Dictionary<int, HashSet<int>>();

	// Token: 0x0400BFEA RID: 49130
	public readonly Dictionary<int, Dictionary<long, HashSet<int>>> VictimTagListenerDict = new Dictionary<int, Dictionary<long, HashSet<int>>>();

	// Token: 0x0400BFEB RID: 49131
	protected readonly ConfigOverrideConditionListener ConfigOverrideConditionListener = new ConfigOverrideConditionListener();

	// Token: 0x0400BFEC RID: 49132
	public readonly Dictionary<long, Dictionary<long, HashSet<int>>> VictimBuffListenerDict = new Dictionary<long, Dictionary<long, HashSet<int>>>();

	// Token: 0x0400BFED RID: 49133
	protected readonly Dictionary<int, Dictionary<int, List<int>>> InstigatorEventListenDict = new Dictionary<int, Dictionary<int, List<int>>>();

	// Token: 0x0400BFEE RID: 49134
	[StaticVariableRuleIgnore]
	private static readonly Stat CheckWhenTagChangedStat = Stat.Create("BaseBuffComponent.CheckWhenTagChanged", "", "");

	// Token: 0x0400BFEF RID: 49135
	[StaticVariableRuleIgnore]
	private static readonly Stat CheckWhenBuffChangedStat = Stat.Create("BaseBuffComponent.CheckWhenBuffChanged", "", "");

	// Token: 0x0400BFF0 RID: 49136
	public readonly Dictionary<long, int> BuffRoutineExpirationLock = new Dictionary<long, int>();

	// Token: 0x0400BFF1 RID: 49137
	protected Dictionary<long, Dictionary<int, double>> EffectTimeoutMap = new Dictionary<long, Dictionary<int, double>>();

	// Token: 0x0400BFF2 RID: 49138
	protected Dictionary<long, Dictionary<int, Dictionary<int, double>>> EffectTargetTimeoutMap = new Dictionary<long, Dictionary<int, Dictionary<int, double>>>();

	// Token: 0x0400BFF3 RID: 49139
	private static readonly int MaxTargetCdCount = 50;

	// Token: 0x0400BFF4 RID: 49140
	[Nullable(2)]
	private static Dictionary<long, Stat> _buffStatMap;

	// Token: 0x0400BFF5 RID: 49141
	[StaticVariableRuleIgnore]
	private static readonly Stat GetStackableBuffStat = Stat.CreateNoFlameGraph("BaseBuffComponent.GetStackableBuff", "", "");

	// Token: 0x0400BFF6 RID: 49142
	[StaticVariableRuleIgnore]
	private static readonly Stat OnBuffStackDecreasedStat = Stat.Create("BaseBuffComponent.OnBuffStackDecreased", "", "");

	// Token: 0x0400BFF7 RID: 49143
	[StaticVariableRuleIgnore]
	private static readonly Stat OnBuffStackIncreasedStat = Stat.Create("BaseBuffComponent.OnBuffStackIncreased", "", "");

	// Token: 0x0400BFF8 RID: 49144
	private readonly HashSet<int> TagInChanged = new HashSet<int>();

	// Token: 0x0400BFF9 RID: 49145
	private int BuffLockInternal;

	// Token: 0x0400BFFA RID: 49146
	protected readonly Dictionary<EBuffTriggerType, List<IBuffTrigger>> TriggerMap = new Dictionary<EBuffTriggerType, List<IBuffTrigger>>();

	// Token: 0x0400BFFB RID: 49147
	[StaticVariableRuleIgnore]
	private static readonly Stat AddGameplayCueStat = Stat.Create("AddBuff_Cue", "", "");

	// Token: 0x0400BFFC RID: 49148
	[StaticVariableRuleIgnore]
	private static readonly Stat AddBuffBroadcastNotifyStat = Stat.Create("BaseBuffComponent.BroadcastAddBuffNotify", "", "");

	// Token: 0x0400BFFD RID: 49149
	[TupleElementNames(new string[]
	{
		"period",
		"duration"
	})]
	[Nullable(new byte[]
	{
		1,
		1,
		0
	})]
	public Dictionary<long, Dictionary<int, ValueTuple<float, float>>> OwnerBuffTimeModifiers = new Dictionary<long, Dictionary<int, ValueTuple<float, float>>>();

	// Token: 0x0400BFFE RID: 49150
	[TupleElementNames(new string[]
	{
		"period",
		"duration"
	})]
	[Nullable(new byte[]
	{
		1,
		1,
		0
	})]
	public Dictionary<long, Dictionary<int, ValueTuple<float, float>>> InstigatorBuffTimeModifiers = new Dictionary<long, Dictionary<int, ValueTuple<float, float>>>();

	// Token: 0x0400BFFF RID: 49151
	public Dictionary<long, Dictionary<int, BuffStackModifierValue>> BuffStackModifiers = new Dictionary<long, Dictionary<int, BuffStackModifierValue>>();

	// Token: 0x0400C000 RID: 49152
	private bool EnableDeferredCueCreation;

	// Token: 0x0400C001 RID: 49153
	protected readonly Dictionary<int, List<int>> Buff2CueMap = new Dictionary<int, List<int>>();

	// Token: 0x0400C002 RID: 49154
	private readonly HashSet<int> PendingCreateCueBuffs = new HashSet<int>();

	// Token: 0x0400C003 RID: 49155
	private readonly List<BaseBuffComponent.PendingInstantCueItem> PendingInstantCues = new List<BaseBuffComponent.PendingInstantCueItem>();

	// Token: 0x0400C004 RID: 49156
	private readonly HashSet<int> PendingDestroyCueBuffs = new HashSet<int>();

	// Token: 0x0400C005 RID: 49157
	[StaticVariableRuleIgnore]
	private static readonly Stat CreateGameplayCueByBuffStat = Stat.Create("CreateGameplayCueByBuff", "", "");

	// Token: 0x0400C006 RID: 49158
	[StaticVariableRuleIgnore]
	private static readonly Stat DestroyGameplayCueByBuffStat = Stat.Create("DestroyGameplayCueByBuff", "", "");

	// Token: 0x0400C007 RID: 49159
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected Dictionary<long, List<List<int>>> SeamlessTravelBuffCue;

	// Token: 0x0400C008 RID: 49160
	private EBuffComponentType BuffComponentType;

	// Token: 0x0400C009 RID: 49161
	protected readonly Dictionary<long, BuffReplace> ReplaceBuffMap = new Dictionary<long, BuffReplace>();

	// Token: 0x020087F9 RID: 34809
	[NullableContext(0)]
	private struct PendingInstantCueItem
	{
		// Token: 0x0402B816 RID: 178198
		public long CueId;

		// Token: 0x0402B817 RID: 178199
		public GameplayCueParam Param;
	}
}
