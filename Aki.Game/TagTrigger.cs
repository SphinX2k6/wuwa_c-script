using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x0200253A RID: 9530
[NullableContext(1)]
[Nullable(0)]
public class TagTrigger : Trigger
{
	// Token: 0x06017903 RID: 96515 RVA: 0x006F4E5D File Offset: 0x006F305D
	[NullableContext(2)]
	public TagTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06017904 RID: 96516 RVA: 0x006F4E84 File Offset: 0x006F3084
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

	// Token: 0x06017905 RID: 96517 RVA: 0x006F4F54 File Offset: 0x006F3154
	private bool IsFormationTarget()
	{
		return this.TargetType == ETriggerTargetType.LocalFormation || this.TargetType == ETriggerTargetType.AllFormation;
	}

	// Token: 0x06017906 RID: 96518 RVA: 0x006F4F6C File Offset: 0x006F316C
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

	// Token: 0x06017907 RID: 96519 RVA: 0x006F50A0 File Offset: 0x006F32A0
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

	// Token: 0x06017908 RID: 96520 RVA: 0x006F512C File Offset: 0x006F332C
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

	// Token: 0x06017909 RID: 96521 RVA: 0x006F51EC File Offset: 0x006F33EC
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

	// Token: 0x0601790A RID: 96522 RVA: 0x006F524C File Offset: 0x006F344C
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

	// Token: 0x0601790B RID: 96523 RVA: 0x006F52DC File Offset: 0x006F34DC
	protected override void OnInactive()
	{
		if (this.IsFormationTarget())
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnTeamChanged));
		}
		long[] array = new long[this.ListeningEntries.Count];
		this.ListeningEntries.Keys.CopyTo(array, 0);
		foreach (long creatureDataId in array)
		{
			this.UnsubscribeMember(creatureDataId);
		}
		this.ListeningEntries.Clear();
	}

	// Token: 0x0601790C RID: 96524 RVA: 0x006F5358 File Offset: 0x006F3558
	private void OnTeamChanged()
	{
		bool onlyMyRole = this.TargetType == ETriggerTargetType.LocalFormation;
		List<EntityHandle> teamEntities = SceneTeamModel.Instance.GetTeamEntities(onlyMyRole);
		HashSet<long> hashSet = new HashSet<long>();
		foreach (EntityHandle entityHandle in teamEntities)
		{
			hashSet.Add(entityHandle.CreatureDataId);
		}
		long[] array = new long[this.ListeningEntries.Count];
		this.ListeningEntries.Keys.CopyTo(array, 0);
		foreach (long num in array)
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

	// Token: 0x0601790D RID: 96525 RVA: 0x006F54E4 File Offset: 0x006F36E4
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

	// Token: 0x0601790E RID: 96526 RVA: 0x006F557E File Offset: 0x006F377E
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

	// Token: 0x0601790F RID: 96527 RVA: 0x006F55B5 File Offset: 0x006F37B5
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C87F RID: 51327
	protected bool CheckRemove;

	// Token: 0x0400C880 RID: 51328
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C881 RID: 51329
	protected TagTrigger.ETagTriggerInitBehavior InitBehavior;

	// Token: 0x0400C882 RID: 51330
	protected readonly List<int> TagIds = new List<int>();

	// Token: 0x0400C883 RID: 51331
	protected int LogicRelation;

	// Token: 0x0400C884 RID: 51332
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

	// Token: 0x02008843 RID: 34883
	[NullableContext(0)]
	public enum ETagTriggerInitBehavior
	{
		// Token: 0x0402B94C RID: 178508
		None,
		// Token: 0x0402B94D RID: 178509
		CheckWhenHasTag,
		// Token: 0x0402B94E RID: 178510
		CheckWhenNotHasTag
	}
}
