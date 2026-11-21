using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020027A9 RID: 10153
[NullableContext(1)]
[Nullable(0)]
public class RoleBuffComponent : CharacterBuffComponent
{
	// Token: 0x06019763 RID: 104291 RVA: 0x007CC160 File Offset: 0x007CA360
	protected override bool OnStart()
	{
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Add(EEventName.DoLeaveLevel, new Action(this.ClearCurrentRoleId));
		EventSystem.Instance.Add(EEventName.OnEnterOnlineWorld, new Action(this.ClearCurrentRoleId));
		EventSystem.Instance.Add(EEventName.OnLeaveOnlineWorld, new Action(this.ClearCurrentRoleId));
		EventSystem.Instance.Add(EEventName.EnterInstanceDungeon, new Action(this.ClearCurrentRoleId));
		EventSystem.Instance.Add(EEventName.LeaveInstanceDungeon, new Action(this.ClearCurrentRoleId));
		return true;
	}

	// Token: 0x06019764 RID: 104292 RVA: 0x007CC218 File Offset: 0x007CA418
	protected override bool OnEnd()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Remove(EEventName.DoLeaveLevel, new Action(this.ClearCurrentRoleId));
		EventSystem.Instance.Remove(EEventName.OnEnterOnlineWorld, new Action(this.ClearCurrentRoleId));
		EventSystem.Instance.Remove(EEventName.OnLeaveOnlineWorld, new Action(this.ClearCurrentRoleId));
		EventSystem.Instance.Remove(EEventName.EnterInstanceDungeon, new Action(this.ClearCurrentRoleId));
		EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeon, new Action(this.ClearCurrentRoleId));
		return true;
	}

	// Token: 0x06019765 RID: 104293 RVA: 0x007CC2D0 File Offset: 0x007CA4D0
	[NullableContext(2)]
	public PlayerBuffComponent GetFormationBuffComp()
	{
		if (!this.HasBuffAuthority())
		{
			CombatLog.Instance.Warn(CombatLog.EDebugModule.Buff, base.Entity, "暂不支持对其它玩家操作编队buff", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(CreatureModel.Instance.GetPlayerId());
		if (playerEntity == null)
		{
			return null;
		}
		return playerEntity.GetComponent<PlayerBuffComponent>();
	}

	// Token: 0x06019766 RID: 104294 RVA: 0x007CC325 File Offset: 0x007CA525
	protected override bool OnInit()
	{
		base.OnInit();
		base.SetBuffComponentType(EBuffComponentType.RoleBuffComponent);
		return true;
	}

	// Token: 0x06019767 RID: 104295 RVA: 0x007CC338 File Offset: 0x007CA538
	[NullableContext(2)]
	public override int AddBuffInner(long buffId, BuffDefinition config, long? instigatorId, int level, int? outerStackCount, ApplyGEType? applyType, long? preMessageId, long? messageId, float? duration, bool? isActive, int serverId, string reason, bool fromServer, bool isIterable, bool isServerOrder, int? handle, long? bulletMessageId = null, bool? bornBuff = null)
	{
		bool flag = false;
		long[] abnormalBuffIds = AbnormalBuffIds.abnormalBuffIds;
		for (int i = 0; i < abnormalBuffIds.Length; i++)
		{
			if (abnormalBuffIds[i] == buffId)
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null || !tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台"]))
			{
				return -1;
			}
		}
		if (config == null || config.FormationPolicy != EBuffFormationPolicy.FormationBuff)
		{
			return base.AddBuffInner(buffId, config, instigatorId, level, outerStackCount, applyType, preMessageId, messageId, duration, isActive, serverId, reason, fromServer, isIterable, isServerOrder, handle, bulletMessageId, bornBuff);
		}
		PlayerBuffComponent formationBuffComp = this.GetFormationBuffComp();
		if (formationBuffComp == null)
		{
			return -1;
		}
		return formationBuffComp.AddBuffInner(buffId, config, instigatorId, level, outerStackCount, applyType, preMessageId, messageId, duration, isActive, serverId, reason, fromServer, isIterable, isServerOrder, handle, bulletMessageId, bornBuff);
	}

	// Token: 0x06019768 RID: 104296 RVA: 0x007CC3F8 File Offset: 0x007CA5F8
	public unsafe override int RemoveBuffLocal(long buffId, int stackCount, string reason, long? preMessageId = null, bool? isServerRequest = null, long? instigatorId = null)
	{
		BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(buffId, reason);
		if (buffDefinition == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = base.Entity;
			string message = "[buffComp] 尝试本地移除buff时找不到合法配置";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("持有者", this.GetDebugName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("原因", reason);
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return 0;
		}
		if (buffDefinition.FormationPolicy != EBuffFormationPolicy.FormationBuff)
		{
			return base.RemoveBuffLocal(buffId, stackCount, reason, preMessageId, isServerRequest, instigatorId);
		}
		PlayerBuffComponent formationBuffComp = this.GetFormationBuffComp();
		if (formationBuffComp == null)
		{
			return 0;
		}
		return formationBuffComp.RemoveBuffLocal(buffId, stackCount, reason, preMessageId, isServerRequest, instigatorId);
	}

	// Token: 0x06019769 RID: 104297 RVA: 0x007CC4C4 File Offset: 0x007CA6C4
	[NullableContext(2)]
	protected unsafe override void RemoveBuffOrder(long buffId, int stackCount, string reason, long? instigatorId = null)
	{
		BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(buffId, reason);
		if (buffDefinition != null && buffDefinition.FormationPolicy == EBuffFormationPolicy.FormationBuff)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = base.Entity;
			string message = "暂不支持移除远端编队buff";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("原因", reason);
			instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		base.RemoveBuffOrder(buffId, stackCount, reason, instigatorId);
	}

	// Token: 0x0601976A RID: 104298 RVA: 0x007CC558 File Offset: 0x007CA758
	public unsafe override void RefreshBuffDuration(long[] buffIds, [Nullable(2)] string reason)
	{
		List<long> list = new List<long>();
		List<long> list2 = new List<long>();
		foreach (long num in buffIds)
		{
			BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(num, reason);
			if (buffDefinition == null)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
				Entity entity = base.Entity;
				string message = "找不到buff配置，跳过刷新";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("原因", reason ?? "");
				instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else if (buffDefinition.FormationPolicy == EBuffFormationPolicy.FormationBuff)
			{
				list.Add(num);
			}
			else
			{
				list2.Add(num);
			}
		}
		if (list.Count > 0)
		{
			PlayerBuffComponent formationBuffComp = this.GetFormationBuffComp();
			if (formationBuffComp != null)
			{
				formationBuffComp.RefreshBuffDuration(list.ToArray(), reason);
			}
		}
		if (list2.Count > 0)
		{
			base.RefreshBuffDuration(list2.ToArray(), reason);
		}
	}

	// Token: 0x0601976B RID: 104299 RVA: 0x007CC65E File Offset: 0x007CA85E
	public override void RemoveBuffByServerId(int serverId, int stackCount, long preMessageId, string reason, long? instigatorId = null)
	{
		base.RemoveBuffByServerId(serverId, stackCount, preMessageId, reason, instigatorId);
		PlayerBuffComponent formationBuffComp = this.GetFormationBuffComp();
		if (formationBuffComp == null)
		{
			return;
		}
		formationBuffComp.RemoveBuffByServerId(serverId, stackCount, preMessageId, reason, instigatorId);
	}

	// Token: 0x0601976C RID: 104300 RVA: 0x007CC684 File Offset: 0x007CA884
	[NullableContext(2)]
	public override void RemoveBuffByTagLocal(int tagId, string reason, long? instigatorId = null)
	{
		if (this.HasBuffAuthority())
		{
			PlayerBuffComponent formationBuffComp = this.GetFormationBuffComp();
			if (formationBuffComp != null)
			{
				formationBuffComp.RemoveBuffByTagLocal(tagId, reason, instigatorId);
			}
		}
		base.RemoveBuffByTagLocal(tagId, reason, instigatorId);
	}

	// Token: 0x0601976D RID: 104301 RVA: 0x007CC6AC File Offset: 0x007CA8AC
	[NullableContext(2)]
	public override int RemoveBuffInner(int handle, int removeStackCount, bool isPrematureRemoval, string reason, long? preMessageId = null, bool? isServerRequest = null, long? instigatorId = null)
	{
		PlayerBuffComponent formationBuffComp = this.GetFormationBuffComp();
		return ((formationBuffComp != null) ? formationBuffComp.RemoveBuffInner(handle, removeStackCount, isPrematureRemoval, reason, preMessageId, isServerRequest, instigatorId) : 0) + base.RemoveBuffInner(handle, removeStackCount, isPrematureRemoval, reason, preMessageId, isServerRequest, instigatorId);
	}

	// Token: 0x0601976E RID: 104302 RVA: 0x007CC6E8 File Offset: 0x007CA8E8
	public override bool HasBuffAuthority()
	{
		CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
		int? num = (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPlayerId()) : null;
		CreatureModel instance = CreatureModel.Instance;
		int? num2 = (instance != null) ? new int?(instance.GetPlayerId()) : null;
		return num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null);
	}

	// Token: 0x0601976F RID: 104303 RVA: 0x007CC758 File Offset: 0x007CA958
	protected override void ShareApplyBuffInner(ActiveBuffInternal newBuff, int? outerStackCount, ApplyGEType applyType, long? preMessageId, float? duration, int serverId)
	{
		if (!this.HasBuffAuthority())
		{
			return;
		}
		BuffDefinition config = newBuff.Config;
		if (config != null && config.FormationPolicy == EBuffFormationPolicy.SharedByFormation)
		{
			List<CharacterBuffComponent> list = new List<CharacterBuffComponent>();
			List<EntityHandle> teamEntities = SceneTeamModel.Instance.GetTeamEntities(true);
			bool flag = false;
			using (List<EntityHandle>.Enumerator enumerator = teamEntities.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Entity == base.Entity)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				foreach (EntityHandle entityHandle in teamEntities)
				{
					WorldEntity entity = entityHandle.Entity;
					CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
					if (entityHandle.Entity != base.Entity && characterBuffComponent != null)
					{
						list.Add(characterBuffComponent);
					}
				}
			}
			long id = newBuff.Id;
			int handle = newBuff.Handle;
			using (List<CharacterBuffComponent>.Enumerator enumerator2 = list.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					BaseBuffComponent baseBuffComponent = enumerator2.Current;
					long buffId = id;
					AddBuffParam addBuffParam = new AddBuffParam();
					addBuffParam.InstigatorId = newBuff.InstigatorId.GetValueOrDefault();
					addBuffParam.Level = new int?(newBuff.Level);
					addBuffParam.OuterStackCount = outerStackCount;
					addBuffParam.ApplyType = new ApplyGEType?(applyType);
					addBuffParam.PreMessageId = newBuff.MessageId;
					addBuffParam.Duration = duration;
					addBuffParam.ServerId = new int?(serverId);
					addBuffParam.IsIterable = new bool?(false);
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
					defaultInterpolatedStringHandler.AppendLiteral("因为buff");
					defaultInterpolatedStringHandler.AppendFormatted<long>(id);
					defaultInterpolatedStringHandler.AppendLiteral("(handle=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(handle);
					defaultInterpolatedStringHandler.AppendLiteral(")的队伍共享机制导致的buff添加");
					addBuffParam.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
					baseBuffComponent.AddBuffLocal(buffId, addBuffParam);
				}
				return;
			}
		}
		base.ShareApplyBuffInner(newBuff, outerStackCount, applyType, newBuff.MessageId, duration, serverId);
	}

	// Token: 0x06019770 RID: 104304 RVA: 0x007CC96C File Offset: 0x007CAB6C
	public override bool CheckImmune(BuffDefinition config)
	{
		PlayerBuffComponent formationBuffComp = this.GetFormationBuffComp();
		if (formationBuffComp != null && formationBuffComp.CheckImmune(config))
		{
			return true;
		}
		bool flag = false;
		ExtraEffectParameters[] effectInfos = config.EffectInfos;
		for (int i = 0; i < effectInfos.Length; i++)
		{
			if (effectInfos[i].ExtraEffectId == EExtraEffectId.Frozen)
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null && tagComponent.HasAnyTag(RoleBuffComponent.FrozenImmuneTags))
			{
				return true;
			}
		}
		return base.CheckImmune(config);
	}

	// Token: 0x06019771 RID: 104305 RVA: 0x007CC9DA File Offset: 0x007CABDA
	public override bool HasBuffRoutineExpirationLock(long buffId)
	{
		if (this.BuffRoutineExpirationLock.GetValueOrDefault(buffId, 0) <= 0)
		{
			PlayerBuffComponent formationBuffComp = this.GetFormationBuffComp();
			return formationBuffComp != null && formationBuffComp.BuffRoutineExpirationLock.GetValueOrDefault(buffId, 0) > 0;
		}
		return true;
	}

	// Token: 0x06019772 RID: 104306 RVA: 0x007CCA09 File Offset: 0x007CAC09
	public override void TriggerEvents(EBuffTriggerType passiveEffectType, [Nullable(2)] BaseBuffComponent opponentBuffComp, Partial_RequirementPayload payload)
	{
		base.TriggerEvents(passiveEffectType, opponentBuffComp, payload);
		PlayerBuffComponent formationBuffComp = this.GetFormationBuffComp();
		if (formationBuffComp == null)
		{
			return;
		}
		formationBuffComp.TriggerEvents(passiveEffectType, opponentBuffComp, payload);
	}

	// Token: 0x06019773 RID: 104307 RVA: 0x007CCA27 File Offset: 0x007CAC27
	public override void AddPauseLock(string key, float timeScale = 0f)
	{
		base.AddPauseLock(key, timeScale);
		PlayerBuffComponent formationBuffComp = this.GetFormationBuffComp();
		if (formationBuffComp == null)
		{
			return;
		}
		formationBuffComp.RefreshTimeScale();
	}

	// Token: 0x06019774 RID: 104308 RVA: 0x007CCA41 File Offset: 0x007CAC41
	public override void RemovePauseLock(string key)
	{
		base.RemovePauseLock(key);
		PlayerBuffComponent formationBuffComp = this.GetFormationBuffComp();
		if (formationBuffComp == null)
		{
			return;
		}
		formationBuffComp.RefreshTimeScale();
	}

	// Token: 0x06019775 RID: 104309 RVA: 0x007CCA5A File Offset: 0x007CAC5A
	[NullableContext(2)]
	protected override bool NeedBroadcastBuff(ActiveBuffInternal buff, bool fromServer = false)
	{
		return (buff == null || !NoBroadCastBuff.Values.Contains(buff.Id)) && base.NeedBroadcastBuff(buff, fromServer);
	}

	// Token: 0x06019776 RID: 104310 RVA: 0x007CCA7C File Offset: 0x007CAC7C
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		if (newEntity.Entity != null && CurrentRoleIdHolder.currentRoleId != newEntity.Entity.Id && base.Entity.Id == newEntity.Entity.Id)
		{
			if (CurrentRoleIdHolder.currentRoleId != 0)
			{
				this.TriggerEvents(EBuffTriggerType.ForOnStage, this, new Partial_RequirementPayload());
			}
			CurrentRoleIdHolder.currentRoleId = newEntity.Entity.Id;
		}
	}

	// Token: 0x06019777 RID: 104311 RVA: 0x007CCAE0 File Offset: 0x007CACE0
	private void ClearCurrentRoleId()
	{
		CurrentRoleIdHolder.currentRoleId = 0;
	}

	// Token: 0x06019778 RID: 104312 RVA: 0x007CCAE8 File Offset: 0x007CACE8
	public override float CalculateDurationExtraRate(long buffId, bool asInstigator)
	{
		float num = base.CalculateDurationExtraRate(buffId, asInstigator);
		PlayerBuffComponent formationBuffComp = this.GetFormationBuffComp();
		if (formationBuffComp != null)
		{
			Dictionary<int, ValueTuple<float, float>> dictionary;
			(asInstigator ? formationBuffComp.InstigatorBuffTimeModifiers : formationBuffComp.OwnerBuffTimeModifiers).TryGetValue(buffId, out dictionary);
			if (dictionary != null)
			{
				foreach (KeyValuePair<int, ValueTuple<float, float>> keyValuePair in dictionary)
				{
					float item = keyValuePair.Value.Item2;
					num += item;
				}
			}
		}
		return num;
	}

	// Token: 0x06019779 RID: 104313 RVA: 0x007CCB74 File Offset: 0x007CAD74
	public override float CalculatePeriodExtraRate(long buffId, bool asInstigator)
	{
		float num = base.CalculatePeriodExtraRate(buffId, asInstigator);
		PlayerBuffComponent formationBuffComp = this.GetFormationBuffComp();
		if (formationBuffComp != null)
		{
			Dictionary<int, ValueTuple<float, float>> dictionary;
			(asInstigator ? formationBuffComp.InstigatorBuffTimeModifiers : formationBuffComp.OwnerBuffTimeModifiers).TryGetValue(buffId, out dictionary);
			if (dictionary != null)
			{
				foreach (KeyValuePair<int, ValueTuple<float, float>> keyValuePair in dictionary)
				{
					float item = keyValuePair.Value.Item1;
					num += item;
				}
			}
		}
		return num;
	}

	// Token: 0x0601977A RID: 104314 RVA: 0x007CCC00 File Offset: 0x007CAE00
	[NullableContext(2)]
	public override BaseBuffComponent GetBuffApplyTarget(long buffId, long instigatorId)
	{
		BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(buffId, null);
		if (buffDefinition != null && buffDefinition.FormationPolicy == EBuffFormationPolicy.FormationBuff)
		{
			return this.GetFormationBuffComp();
		}
		return this;
	}

	// Token: 0x0601977B RID: 104315 RVA: 0x007CCC27 File Offset: 0x007CAE27
	protected override bool NeedAddBuffOrder(long buffId)
	{
		return true;
	}

	// Token: 0x0601977C RID: 104316 RVA: 0x007CCC2C File Offset: 0x007CAE2C
	protected new bool SeamlessTravelBuffRetain(IActiveBuff buff)
	{
		if (NoBroadCastBuff.Values.Contains(buff.Id))
		{
			return true;
		}
		if (this.SeamlessTravelRetainBuffPreMessage != 0L)
		{
			long? preMessageId = buff.PreMessageId;
			long seamlessTravelRetainBuffPreMessage = this.SeamlessTravelRetainBuffPreMessage;
			if (preMessageId.GetValueOrDefault() == seamlessTravelRetainBuffPreMessage & preMessageId != null)
			{
				return true;
			}
		}
		return base.SeamlessTravelBuffRetain(buff);
	}

	// Token: 0x0601977D RID: 104317 RVA: 0x007CCC80 File Offset: 0x007CAE80
	public void SetSeamlessTravelBuffPreMessageId(long preMessageId)
	{
		this.SeamlessTravelRetainBuffPreMessage = preMessageId;
	}

	// Token: 0x0601977E RID: 104318 RVA: 0x007CCC89 File Offset: 0x007CAE89
	protected override void OnSeamlessTravelingRefreshEnd()
	{
		this.SeamlessTravelRetainBuffPreMessage = 0L;
	}

	// Token: 0x0601977F RID: 104319 RVA: 0x007CCC94 File Offset: 0x007CAE94
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleBuffComponent roleBuffComponent = (RoleBuffComponent)componentTemplate;
		this.SeamlessTravelRetainBuffPreMessage = roleBuffComponent.SeamlessTravelRetainBuffPreMessage;
		return true;
	}

	// Token: 0x17002891 RID: 10385
	// (get) Token: 0x06019780 RID: 104320 RVA: 0x007CCCC0 File Offset: 0x007CAEC0
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002892 RID: 10386
	// (get) Token: 0x06019781 RID: 104321 RVA: 0x007CCCC3 File Offset: 0x007CAEC3
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002893 RID: 10387
	// (get) Token: 0x06019782 RID: 104322 RVA: 0x007CCCC6 File Offset: 0x007CAEC6
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002894 RID: 10388
	// (get) Token: 0x06019783 RID: 104323 RVA: 0x007CCCC9 File Offset: 0x007CAEC9
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002895 RID: 10389
	// (get) Token: 0x06019784 RID: 104324 RVA: 0x007CCCCC File Offset: 0x007CAECC
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002896 RID: 10390
	// (get) Token: 0x06019785 RID: 104325 RVA: 0x007CCCCF File Offset: 0x007CAECF
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002897 RID: 10391
	// (get) Token: 0x06019786 RID: 104326 RVA: 0x007CCCD2 File Offset: 0x007CAED2
	public override bool NeedChangeTimeDilationInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DF30 RID: 57136
	[StaticVariableRuleIgnore]
	protected static readonly int[] FrozenImmuneTags = new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.钩锁"],
		GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.幻象变身中"],
		GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.定点钩索"],
		GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.极限闪避"],
		GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.大招"],
		GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"],
		GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.无敌"],
		GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.无敌"]
	};

	// Token: 0x0400DF31 RID: 57137
	protected long SeamlessTravelRetainBuffPreMessage;
}
