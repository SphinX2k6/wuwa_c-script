using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;
using UnrealEngine;

// Token: 0x0200254F RID: 9551
[NullableContext(1)]
[Nullable(0)]
public class RegionDetectTrigger : Trigger
{
	// Token: 0x17002481 RID: 9345
	// (get) Token: 0x0601798F RID: 96655 RVA: 0x006F86BC File Offset: 0x006F68BC
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

	// Token: 0x06017990 RID: 96656 RVA: 0x006F872A File Offset: 0x006F692A
	[NullableContext(2)]
	public RegionDetectTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06017991 RID: 96657 RVA: 0x006F8751 File Offset: 0x006F6951
	public override void OnInitParams(string[] triggerParams)
	{
		this.RegionNameSet = new HashSet<string>(((triggerParams.Length != 0) ? triggerParams[0] : string.Empty).Split('#', StringSplitOptions.None));
	}

	// Token: 0x06017992 RID: 96658 RVA: 0x006F8774 File Offset: 0x006F6974
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

	// Token: 0x06017993 RID: 96659 RVA: 0x006F8854 File Offset: 0x006F6A54
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

	// Token: 0x06017994 RID: 96660 RVA: 0x006F88B4 File Offset: 0x006F6AB4
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

	// Token: 0x06017995 RID: 96661 RVA: 0x006F898C File Offset: 0x006F6B8C
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

	// Token: 0x06017996 RID: 96662 RVA: 0x006F8A61 File Offset: 0x006F6C61
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		this.RefreshDetectRoles();
	}

	// Token: 0x06017997 RID: 96663 RVA: 0x006F8A69 File Offset: 0x006F6C69
	private void OnOtherChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		this.RefreshDetectRoles();
	}

	// Token: 0x06017998 RID: 96664 RVA: 0x006F8A71 File Offset: 0x006F6C71
	private void OnUpdateSceneTeam()
	{
		this.RefreshDetectRoles();
	}

	// Token: 0x06017999 RID: 96665 RVA: 0x006F8A7C File Offset: 0x006F6C7C
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

	// Token: 0x0601799A RID: 96666 RVA: 0x006F8B2C File Offset: 0x006F6D2C
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

	// Token: 0x0601799B RID: 96667 RVA: 0x006F8B99 File Offset: 0x006F6D99
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C8B5 RID: 51381
	private HashSet<string> RegionNameSet = new HashSet<string>();

	// Token: 0x0400C8B6 RID: 51382
	private int DetectId;

	// Token: 0x0400C8B7 RID: 51383
	private readonly Dictionary<AActor, int> ActorToEntityId = new Dictionary<AActor, int>();

	// Token: 0x0400C8B8 RID: 51384
	[Nullable(2)]
	private UKuroRegionDetectComponent regionDetectInner;
}
