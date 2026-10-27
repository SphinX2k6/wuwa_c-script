using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.GamePlay.Portal;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using UnrealEngine;

// Token: 0x02002FBE RID: 12222
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueFixHook : GameplayCueBase
{
	// Token: 0x06019E99 RID: 106137 RVA: 0x006C6A35 File Offset: 0x006C4C35
	protected override void OnInit()
	{
	}

	// Token: 0x06019E9A RID: 106138 RVA: 0x006C6A38 File Offset: 0x006C4C38
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

	// Token: 0x06019E9B RID: 106139 RVA: 0x006C6A6C File Offset: 0x006C4C6C
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

	// Token: 0x06019E9C RID: 106140 RVA: 0x006C6AA0 File Offset: 0x006C4CA0
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

	// Token: 0x06019E9D RID: 106141 RVA: 0x006C6BCC File Offset: 0x006C4DCC
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

	// Token: 0x06019E9E RID: 106142 RVA: 0x006C6C1C File Offset: 0x006C4E1C
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

	// Token: 0x06019E9F RID: 106143 RVA: 0x006C6C5B File Offset: 0x006C4E5B
	private FVectorDouble GetCurrentPathwayEndLocation()
	{
		return this.GetSceneInteractComponent().GetCurrentPathwayEndLocation().ToUeVector(false);
	}

	// Token: 0x06019EA0 RID: 106144 RVA: 0x006C6C6E File Offset: 0x006C4E6E
	private bool GetIsInLastPathway()
	{
		return this.GetSceneInteractComponent().GetIsInLastPathway();
	}

	// Token: 0x06019EA1 RID: 106145 RVA: 0x006C6C7B File Offset: 0x006C4E7B
	private BP_KuroPortalCapture_C GetTargetEnterPortalCapture()
	{
		return this.GetSceneInteractComponent().GetCurrentTargetEnterPortalCapture();
	}

	// Token: 0x06019EA2 RID: 106146 RVA: 0x006C6C88 File Offset: 0x006C4E88
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

	// Token: 0x06019EA3 RID: 106147 RVA: 0x006C6D00 File Offset: 0x006C4F00
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

	// Token: 0x0400C403 RID: 50179
	private GameplayCueHookCommonItem HookItem;

	// Token: 0x0400C404 RID: 50180
	private BP_KuroPortalCapture_C EnterPortal;

	// Token: 0x0400C405 RID: 50181
	private bool IsMovableHookPoint;

	// Token: 0x0400C406 RID: 50182
	[Nullable(1)]
	private static readonly HashSet<EHookInteractType> MovableHookPointTypes = new HashSet<EHookInteractType>
	{
		EHookInteractType.KiteHook
	};
}
