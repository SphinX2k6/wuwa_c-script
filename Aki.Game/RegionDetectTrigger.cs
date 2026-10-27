using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;
using UnrealEngine;

// Token: 0x02002FFA RID: 12282
[NullableContext(1)]
[Nullable(0)]
public class RegionDetectTrigger : Trigger
{
	// Token: 0x170023BF RID: 9151
	// (get) Token: 0x0601A05B RID: 106587 RVA: 0x006D0820 File Offset: 0x006CEA20
	[Nullable(2)]
	private UKuroRegionDetectComponent RegionDetect
	{
		[NullableContext(2)]
		get
		{
			if (this.regionDetectInner != null)
			{
				return this.regionDetectInner;
			}
			CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
			TsBaseCharacter tsBaseCharacter;
			if (ownerTriggerComp == null)
			{
				tsBaseCharacter = null;
			}
			else
			{
				Entity entity = ownerTriggerComp.Entity;
				if (entity == null)
				{
					tsBaseCharacter = null;
				}
				else
				{
					BaseCharacterComponent component = entity.GetComponent<BaseCharacterComponent>();
					tsBaseCharacter = ((component != null) ? component.Actor : null);
				}
			}
			TsBaseCharacter tsBaseCharacter2 = tsBaseCharacter;
			this.regionDetectInner = (((tsBaseCharacter2 != null) ? tsBaseCharacter2.GetComponentByClass(UKuroRegionDetectComponent.StaticClass()) : null) as UKuroRegionDetectComponent);
			return this.regionDetectInner;
		}
	}

	// Token: 0x0601A05C RID: 106588 RVA: 0x006D088E File Offset: 0x006CEA8E
	[NullableContext(2)]
	public RegionDetectTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A05D RID: 106589 RVA: 0x006D08B5 File Offset: 0x006CEAB5
	public override void OnInitParams(string[] triggerParams)
	{
		this.RegionNameSet = new HashSet<string>(((triggerParams.Length != 0) ? triggerParams[0] : string.Empty).Split('#', StringSplitOptions.None));
	}

	// Token: 0x0601A05E RID: 106590 RVA: 0x006D08D8 File Offset: 0x006CEAD8
	protected override void OnActive()
	{
		this.AddEvent();
		UKuroRegionDetectComponent regionDetect = this.RegionDetect;
		if (regionDetect == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.PassiveSkill;
			CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
			instance.Error(flag, (ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, "[被动]RegionDetectTrigger regionDetect为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.DetectId = regionDetect.GetRegionDetectId();
		this.RefreshDetectRoles();
		using (HashSet<string>.Enumerator enumerator = this.RegionNameSet.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				string regionName = enumerator.Current;
				UKuroRegionEventBinder regionEvent = regionDetect.GetRegionEvent(regionName, this.DetectId);
				if (regionEvent != null)
				{
					regionEvent.Callback.Add(delegate(bool isInRegion, AActor target)
					{
						int targetId;
						if (target != null && this.ActorToEntityId.TryGetValue(target, out targetId))
						{
							this.OnEvent(targetId, regionName, isInRegion);
						}
					});
				}
			}
		}
	}

	// Token: 0x0601A05F RID: 106591 RVA: 0x006D09B8 File Offset: 0x006CEBB8
	protected override void OnInactive()
	{
		this.RemoveEvent();
		UKuroRegionDetectComponent regionDetect = this.RegionDetect;
		if (regionDetect == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.PassiveSkill;
			CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
			instance.Error(flag, (ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, "[被动]RegionDetectTrigger regionDetect为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.DetectId > 0)
		{
			regionDetect.RemoveRegionDetect(this.DetectId);
		}
	}

	// Token: 0x0601A060 RID: 106592 RVA: 0x006D0A18 File Offset: 0x006CEC18
	private void AddEvent()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		Entity entity = (ownerTriggerComp != null) ? ownerTriggerComp.Entity : null;
		if (entity == null)
		{
			return;
		}
		if (!EventSystem.Instance.HasWithTarget(entity, EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole)))
		{
			EventSystem.Instance.AddWithTarget(entity, EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		}
		if (!EventSystem.Instance.HasWithTarget(entity, EEventName.OnOtherChangeRole, new Action<EntityHandle, EntityHandle>(this.OnOtherChangeRole)))
		{
			EventSystem.Instance.AddWithTarget(entity, EEventName.OnOtherChangeRole, new Action<EntityHandle, EntityHandle>(this.OnOtherChangeRole));
		}
		if (!EventSystem.Instance.HasWithTarget(entity, EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam)))
		{
			EventSystem.Instance.AddWithTarget(entity, EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		}
	}

	// Token: 0x0601A061 RID: 106593 RVA: 0x006D0AF0 File Offset: 0x006CECF0
	private void RemoveEvent()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		Entity entity = (ownerTriggerComp != null) ? ownerTriggerComp.Entity : null;
		if (entity == null)
		{
			return;
		}
		if (EventSystem.Instance.HasWithTarget(entity, EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole)))
		{
			EventSystem.Instance.RemoveWithTarget(entity, EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		}
		if (EventSystem.Instance.HasWithTarget(entity, EEventName.OnOtherChangeRole, new Action<EntityHandle, EntityHandle>(this.OnOtherChangeRole)))
		{
			EventSystem.Instance.RemoveWithTarget(entity, EEventName.OnOtherChangeRole, new Action<EntityHandle, EntityHandle>(this.OnOtherChangeRole));
		}
		if (EventSystem.Instance.HasWithTarget(entity, EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam)))
		{
			EventSystem.Instance.RemoveWithTarget(entity, EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		}
	}

	// Token: 0x0601A062 RID: 106594 RVA: 0x006D0BC5 File Offset: 0x006CEDC5
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		this.RefreshDetectRoles();
	}

	// Token: 0x0601A063 RID: 106595 RVA: 0x006D0BCD File Offset: 0x006CEDCD
	private void OnOtherChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		this.RefreshDetectRoles();
	}

	// Token: 0x0601A064 RID: 106596 RVA: 0x006D0BD5 File Offset: 0x006CEDD5
	private void OnUpdateSceneTeam()
	{
		this.RefreshDetectRoles();
	}

	// Token: 0x0601A065 RID: 106597 RVA: 0x006D0BE0 File Offset: 0x006CEDE0
	protected void RefreshDetectRoles()
	{
		if (this.RegionDetect == null)
		{
			return;
		}
		TArray<AActor> tarray = new TArray<AActor>();
		foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(false))
		{
			EntityHandle entityHandle = sceneTeamItem.EntityHandle;
			if (entityHandle != null && entityHandle.Valid)
			{
				AActor actor = CharacterController.Instance.GetActor(entityHandle);
				if (actor != null)
				{
					this.ActorToEntityId[actor] = entityHandle.Id;
					tarray.Add(actor);
				}
			}
		}
		this.RegionDetect.SetEventTargets(tarray, this.DetectId);
	}

	// Token: 0x0601A066 RID: 106598 RVA: 0x006D0C90 File Offset: 0x006CEE90
	protected void OnEvent(int targetId, string regionName, bool isInRegion)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		Entity value = EntitySystem.Instance.Get(targetId);
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["Target"] = value;
		dictionary["IsInRegion"] = isInRegion;
		dictionary["RegionName"] = regionName;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x0601A067 RID: 106599 RVA: 0x006D0CFD File Offset: 0x006CEEFD
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4ED RID: 50413
	private HashSet<string> RegionNameSet = new HashSet<string>();

	// Token: 0x0400C4EE RID: 50414
	private int DetectId;

	// Token: 0x0400C4EF RID: 50415
	private readonly Dictionary<AActor, int> ActorToEntityId = new Dictionary<AActor, int>();

	// Token: 0x0400C4F0 RID: 50416
	[Nullable(2)]
	private UKuroRegionDetectComponent regionDetectInner;
}
