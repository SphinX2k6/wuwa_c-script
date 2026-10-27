using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002FE5 RID: 12261
[NullableContext(1)]
[Nullable(0)]
public class TagTrigger : Trigger
{
	// Token: 0x06019FCF RID: 106447 RVA: 0x006CCFBD File Offset: 0x006CB1BD
	[NullableContext(2)]
	public TagTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06019FD0 RID: 106448 RVA: 0x006CCFE4 File Offset: 0x006CB1E4
	public override void OnInitParams(string[] triggerParams)
	{
		this.TagIds.Clear();
		string[] array = ((triggerParams.Length != 0) ? triggerParams[0] : "").Split('#', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim();
			if (text.Length != 0)
			{
				int tagIdByName = GameplayTagUtils.GetTagIdByName(text);
				this.TagIds.Add(tagIdByName);
			}
		}
		this.CheckRemove = (Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : "0") != 0);
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length > 2) ? triggerParams[2] : "0");
		this.InitBehavior = (TagTrigger.ETagTriggerInitBehavior)Convert.ToInt32((triggerParams.Length > 3) ? triggerParams[3] : "0");
		this.LogicRelation = Convert.ToInt32((triggerParams.Length > 4) ? triggerParams[4] : "0");
	}

	// Token: 0x06019FD1 RID: 106449 RVA: 0x006CD0B4 File Offset: 0x006CB2B4
	private bool IsFormationTarget()
	{
		return this.TargetType == ETriggerTargetType.LocalFormation || this.TargetType == ETriggerTargetType.AllFormation;
	}

	// Token: 0x06019FD2 RID: 106450 RVA: 0x006CD0CC File Offset: 0x006CB2CC
	[return: TupleElementNames(new string[]
	{
		"CreatureDataId",
		"EntityId",
		"Comp"
	})]
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	private List<ValueTuple<long, int, BaseTagComponent>> CollectTargetMembers()
	{
		List<ValueTuple<long, int, BaseTagComponent>> list = new List<ValueTuple<long, int, BaseTagComponent>>();
		switch (this.TargetType)
		{
		case ETriggerTargetType.Self:
		{
			CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
			Entity entity = (ownerTriggerComp != null) ? ownerTriggerComp.Entity : null;
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			long? num;
			if (entity == null)
			{
				num = null;
			}
			else
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				num = ((component != null) ? new long?(component.GetCreatureDataId()) : null);
			}
			long? num2 = num;
			long valueOrDefault = num2.GetValueOrDefault();
			if (baseTagComponent != null)
			{
				list.Add(new ValueTuple<long, int, BaseTagComponent>(valueOrDefault, entity.Id, baseTagComponent));
			}
			break;
		}
		case ETriggerTargetType.LocalFormation:
		case ETriggerTargetType.AllFormation:
		{
			bool onlyMyRole = this.TargetType == ETriggerTargetType.LocalFormation;
			foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(onlyMyRole))
			{
				WorldEntity entity2 = entityHandle.Entity;
				BaseTagComponent baseTagComponent2 = (entity2 != null) ? entity2.GetComponent<BaseTagComponent>() : null;
				if (baseTagComponent2 != null)
				{
					list.Add(new ValueTuple<long, int, BaseTagComponent>(entityHandle.CreatureDataId, entityHandle.Id, baseTagComponent2));
				}
			}
			break;
		}
		}
		return list;
	}

	// Token: 0x06019FD3 RID: 106451 RVA: 0x006CD200 File Offset: 0x006CB400
	private bool ShouldInitTrigger(BaseTagComponent tagComp)
	{
		switch (this.InitBehavior)
		{
		case TagTrigger.ETagTriggerInitBehavior.CheckWhenHasTag:
			if (this.LogicRelation != 1)
			{
				return tagComp.HasAllTag(this.TagIds.ToArray());
			}
			return tagComp.HasAnyTag(this.TagIds.ToArray());
		case TagTrigger.ETagTriggerInitBehavior.CheckWhenNotHasTag:
			if (this.LogicRelation != 1)
			{
				return !tagComp.HasAnyTag(this.TagIds.ToArray());
			}
			return !tagComp.HasAllTag(this.TagIds.ToArray());
		}
		return false;
	}

	// Token: 0x06019FD4 RID: 106452 RVA: 0x006CD28C File Offset: 0x006CB48C
	[NullableContext(2)]
	private void SubscribeMember(long creatureDataId, int entityId, BaseTagComponent tagComp, bool doInitCheck)
	{
		if (tagComp == null || this.ListeningEntries.ContainsKey(creatureDataId))
		{
			return;
		}
		if (doInitCheck && this.ShouldInitTrigger(tagComp) && (base.Checker == null || base.Checker()) && this.CheckTagCondition(tagComp, true))
		{
			base.EvaluateAndExecute(new Dictionary<string, TFormulaValue>());
		}
		BaseTagComponent comp = tagComp;
		BaseTagComponent.TTagSwitchedCallback ttagSwitchedCallback = delegate(int _, bool tagExist)
		{
			this.OnEvent(comp, tagExist);
		};
		for (int i = 0; i < this.TagIds.Count; i++)
		{
			comp.AddTagAddOrRemoveListener(this.TagIds[i], ttagSwitchedCallback, null);
		}
		this.ListeningEntries[creatureDataId] = new ValueTuple<int, BaseTagComponent, BaseTagComponent.TTagSwitchedCallback>(entityId, comp, ttagSwitchedCallback);
	}

	// Token: 0x06019FD5 RID: 106453 RVA: 0x006CD34C File Offset: 0x006CB54C
	private void UnsubscribeMember(long creatureDataId)
	{
		ValueTuple<int, BaseTagComponent, BaseTagComponent.TTagSwitchedCallback> valueTuple;
		if (!this.ListeningEntries.TryGetValue(creatureDataId, out valueTuple))
		{
			return;
		}
		for (int i = 0; i < this.TagIds.Count; i++)
		{
			valueTuple.Item2.RemoveTagAddOrRemoveListener(this.TagIds[i], valueTuple.Item3);
		}
		this.ListeningEntries.Remove(creatureDataId);
	}

	// Token: 0x06019FD6 RID: 106454 RVA: 0x006CD3AC File Offset: 0x006CB5AC
	protected override void OnActive()
	{
		foreach (ValueTuple<long, int, BaseTagComponent> valueTuple in this.CollectTargetMembers())
		{
			long item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			BaseTagComponent item3 = valueTuple.Item3;
			this.SubscribeMember(item, item2, item3, true);
		}
		if (this.IsFormationTarget())
		{
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnTeamChanged));
		}
	}

	// Token: 0x06019FD7 RID: 106455 RVA: 0x006CD43C File Offset: 0x006CB63C
	protected override void OnInactive()
	{
		if (this.IsFormationTarget())
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnTeamChanged));
		}
		foreach (long creatureDataId in this.ListeningEntries.Keys.ToArray<long>())
		{
			this.UnsubscribeMember(creatureDataId);
		}
		this.ListeningEntries.Clear();
	}

	// Token: 0x06019FD8 RID: 106456 RVA: 0x006CD4A4 File Offset: 0x006CB6A4
	private void OnTeamChanged()
	{
		bool onlyMyRole = this.TargetType == ETriggerTargetType.LocalFormation;
		List<EntityHandle> teamEntities = SceneTeamModel.Instance.GetTeamEntities(onlyMyRole);
		HashSet<long> hashSet = new HashSet<long>();
		foreach (EntityHandle entityHandle in teamEntities)
		{
			hashSet.Add(entityHandle.CreatureDataId);
		}
		foreach (long num in this.ListeningEntries.Keys.ToArray<long>())
		{
			if (!hashSet.Contains(num))
			{
				this.UnsubscribeMember(num);
			}
		}
		foreach (EntityHandle entityHandle2 in teamEntities)
		{
			WorldEntity entity = entityHandle2.Entity;
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null)
			{
				ValueTuple<int, BaseTagComponent, BaseTagComponent.TTagSwitchedCallback> valueTuple;
				if (this.ListeningEntries.TryGetValue(entityHandle2.CreatureDataId, out valueTuple))
				{
					if (valueTuple.Item1 != entityHandle2.Id || valueTuple.Item2 != baseTagComponent)
					{
						this.UnsubscribeMember(entityHandle2.CreatureDataId);
						this.SubscribeMember(entityHandle2.CreatureDataId, entityHandle2.Id, baseTagComponent, false);
					}
				}
				else
				{
					this.SubscribeMember(entityHandle2.CreatureDataId, entityHandle2.Id, baseTagComponent, true);
				}
			}
		}
	}

	// Token: 0x06019FD9 RID: 106457 RVA: 0x006CD618 File Offset: 0x006CB818
	private bool CheckTagCondition(BaseTagComponent tagComp, bool needCheckOrLogic = false)
	{
		if (this.TagIds.Count == 0)
		{
			return false;
		}
		if (this.LogicRelation != 1 && this.LogicRelation != 0)
		{
			return false;
		}
		if (this.LogicRelation == 1)
		{
			if (!needCheckOrLogic)
			{
				return true;
			}
			if (this.CheckRemove)
			{
				return !tagComp.HasAllTag(this.TagIds.ToArray());
			}
			return tagComp.HasAnyTag(this.TagIds.ToArray());
		}
		else
		{
			if (this.CheckRemove)
			{
				return !tagComp.HasAnyTag(this.TagIds.ToArray());
			}
			return tagComp.HasAllTag(this.TagIds.ToArray());
		}
	}

	// Token: 0x06019FDA RID: 106458 RVA: 0x006CD6B2 File Offset: 0x006CB8B2
	private void OnEvent(BaseTagComponent tagComp, bool tagExist)
	{
		if (this.CheckRemove == tagExist)
		{
			return;
		}
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		if (this.CheckTagCondition(tagComp, false))
		{
			base.EvaluateAndExecute(new Dictionary<string, TFormulaValue>());
		}
	}

	// Token: 0x06019FDB RID: 106459 RVA: 0x006CD6E9 File Offset: 0x006CB8E9
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4B7 RID: 50359
	protected bool CheckRemove;

	// Token: 0x0400C4B8 RID: 50360
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C4B9 RID: 50361
	protected TagTrigger.ETagTriggerInitBehavior InitBehavior;

	// Token: 0x0400C4BA RID: 50362
	protected readonly List<int> TagIds = new List<int>();

	// Token: 0x0400C4BB RID: 50363
	protected int LogicRelation;

	// Token: 0x0400C4BC RID: 50364
	[TupleElementNames(new string[]
	{
		"EntityId",
		"Comp",
		"Cb"
	})]
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	private readonly Dictionary<long, ValueTuple<int, BaseTagComponent, BaseTagComponent.TTagSwitchedCallback>> ListeningEntries = new Dictionary<long, ValueTuple<int, BaseTagComponent, BaseTagComponent.TTagSwitchedCallback>>();

	// Token: 0x02009622 RID: 38434
	[NullableContext(0)]
	public enum ETagTriggerInitBehavior
	{
		// Token: 0x040302BF RID: 197311
		None,
		// Token: 0x040302C0 RID: 197312
		CheckWhenHasTag,
		// Token: 0x040302C1 RID: 197313
		CheckWhenNotHasTag
	}
}
