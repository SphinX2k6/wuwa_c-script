using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.GamePlay.Portal;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using UnrealEngine;

// Token: 0x02002512 RID: 9490
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueFixHook : GameplayCueBase
{
	// Token: 0x060177AB RID: 96171 RVA: 0x006ED301 File Offset: 0x006EB501
	protected override void OnInit()
	{
	}

	// Token: 0x060177AC RID: 96172 RVA: 0x006ED304 File Offset: 0x006EB504
	protected override void OnTick(float delta)
	{
		if (this.IsMovableHookPoint)
		{
			return;
		}
		if (this.HookItem != null)
		{
			FVectorDouble targetPosition = this.GetTargetPosition(false);
			this.HookItem.Tick(targetPosition);
		}
	}

	// Token: 0x060177AD RID: 96173 RVA: 0x006ED338 File Offset: 0x006EB538
	protected override void OnAfterTick(float delta)
	{
		if (!this.IsMovableHookPoint)
		{
			return;
		}
		if (this.HookItem != null)
		{
			FVectorDouble targetPosition = this.GetTargetPosition(true);
			this.HookItem.Tick(targetPosition);
		}
	}

	// Token: 0x060177AE RID: 96174 RVA: 0x006ED36C File Offset: 0x006EB56C
	protected override void OnCreate()
	{
		BaseSceneInteractComponent sceneInteractComponent = this.GetSceneInteractComponent();
		GrapplingHookPointComponent grapplingHookPointComponent = (sceneInteractComponent != null) ? sceneInteractComponent.GetCurrentTarget() : null;
		if (grapplingHookPointComponent == null || !grapplingHookPointComponent.Valid)
		{
			return;
		}
		EHookInteractType? hookInteractType = grapplingHookPointComponent.GetHookInteractType();
		this.IsMovableHookPoint = (hookInteractType != null && GameplayCueFixHook.MovableHookPointTypes.Contains(hookInteractType.Value));
		WorldEntity entity = this.EntityHandle.Entity;
		bool? flag;
		if (entity == null)
		{
			flag = null;
		}
		else
		{
			BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
			flag = ((component != null) ? new bool?(component.IsAutonomousProxy) : null);
		}
		bool? flag2 = flag;
		FVectorDouble targetPosition = flag2.GetValueOrDefault() ? this.GetCurrentPathwayEndLocation() : this.GetTargetPosition(false);
		this.HookItem = GameplayCueHookCommonItem.Spawn(this.ActorInternal, FNameUtil.GetDynamicFName(this.CueConfig.Socket).Value, targetPosition, this.CueConfig.Resources(), true);
		if (flag2.GetValueOrDefault() && !this.GetIsInLastPathway())
		{
			this.EnterPortal = this.GetTargetEnterPortalCapture();
			if (this.EnterPortal == null)
			{
				return;
			}
			this.EnterPortal.RoleTeleport.Add(new Action<FVector>(this.OnRoleTeleport));
		}
	}

	// Token: 0x060177AF RID: 96175 RVA: 0x006ED498 File Offset: 0x006EB698
	protected override void OnDestroy()
	{
		if (this.HookItem != null)
		{
			this.HookItem.Destroy();
			this.HookItem = null;
		}
		BP_KuroPortalCapture_C enterPortal = this.EnterPortal;
		if (enterPortal != null)
		{
			enterPortal.RoleTeleport.Remove(new Action<FVector>(this.OnRoleTeleport));
		}
		this.EnterPortal = null;
	}

	// Token: 0x060177B0 RID: 96176 RVA: 0x006ED4E8 File Offset: 0x006EB6E8
	private FVectorDouble GetTargetPosition(bool realtime = false)
	{
		BaseSceneInteractComponent sceneInteractComponent = this.GetSceneInteractComponent();
		if (realtime)
		{
			GrapplingHookPointComponent currentTarget = sceneInteractComponent.GetCurrentTarget();
			if (currentTarget != null)
			{
				SceneItemActorComponent actorComp = currentTarget.ActorComp;
				if (actorComp != null)
				{
					actorComp.ResetLocationCachedTime();
				}
			}
		}
		return sceneInteractComponent.GetCurrentTargetLocation().ToUeVector(false);
	}

	// Token: 0x060177B1 RID: 96177 RVA: 0x006ED527 File Offset: 0x006EB727
	private FVectorDouble GetCurrentPathwayEndLocation()
	{
		return this.GetSceneInteractComponent().GetCurrentPathwayEndLocation().ToUeVector(false);
	}

	// Token: 0x060177B2 RID: 96178 RVA: 0x006ED53A File Offset: 0x006EB73A
	private bool GetIsInLastPathway()
	{
		return this.GetSceneInteractComponent().GetIsInLastPathway();
	}

	// Token: 0x060177B3 RID: 96179 RVA: 0x006ED547 File Offset: 0x006EB747
	private BP_KuroPortalCapture_C GetTargetEnterPortalCapture()
	{
		return this.GetSceneInteractComponent().GetCurrentTargetEnterPortalCapture();
	}

	// Token: 0x060177B4 RID: 96180 RVA: 0x006ED554 File Offset: 0x006EB754
	private void OnRoleTeleport(FVector vector)
	{
		if (!this.IsActive || this.EnterPortal == null)
		{
			return;
		}
		if (this.HookItem != null)
		{
			this.HookItem.Destroy();
			this.HookItem = null;
		}
		FVectorDouble currentPathwayEndLocation = this.GetCurrentPathwayEndLocation();
		this.HookItem = GameplayCueHookCommonItem.Spawn(this.ActorInternal, FNameUtil.GetDynamicFName(this.CueConfig.Socket).Value, currentPathwayEndLocation, this.CueConfig.Resources(), true);
	}

	// Token: 0x060177B5 RID: 96181 RVA: 0x006ED5CC File Offset: 0x006EB7CC
	private BaseSceneInteractComponent GetSceneInteractComponent()
	{
		BaseSceneInteractComponent component = this.EntityHandle.Entity.GetComponent<BaseSceneInteractComponent>();
		if (component != null)
		{
			return component;
		}
		VehiclePerformComponent component2 = this.EntityHandle.Entity.GetComponent<VehiclePerformComponent>();
		if (component2 == null)
		{
			return null;
		}
		Entity driver = component2.Driver;
		if (driver == null)
		{
			return null;
		}
		return driver.GetComponent<BaseSceneInteractComponent>();
	}

	// Token: 0x0400C7AC RID: 51116
	private GameplayCueHookCommonItem HookItem;

	// Token: 0x0400C7AD RID: 51117
	private BP_KuroPortalCapture_C EnterPortal;

	// Token: 0x0400C7AE RID: 51118
	private bool IsMovableHookPoint;

	// Token: 0x0400C7AF RID: 51119
	[Nullable(1)]
	private static readonly HashSet<EHookInteractType> MovableHookPointTypes = new HashSet<EHookInteractType>
	{
		EHookInteractType.KiteHook
	};
}
