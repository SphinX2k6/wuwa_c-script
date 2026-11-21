using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.Character.Role.Component;

// Token: 0x02000C78 RID: 3192
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RoleSceneInteractController : ControllerBase
{
	// Token: 0x06008568 RID: 34152 RVA: 0x0028D180 File Offset: 0x0028B380
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.EntityStaticHookMoveNotify, false, false)]
	public static void OnHookMoveNotify(Entity entity, EntityStaticHookMoveNotify notify, CombatCommon combatCommon = null)
	{
		RoleSceneInteractComponent roleSceneInteractComponent = (entity != null) ? entity.GetComponent<RoleSceneInteractComponent>() : null;
		if (roleSceneInteractComponent == null || !roleSceneInteractComponent.Valid)
		{
			BaseExploreComponent baseExploreComponent = (entity != null) ? entity.GetComponent<BaseExploreComponent>() : null;
			if (baseExploreComponent != null && baseExploreComponent.Valid)
			{
				if (notify.TargetCase == EntityStaticHookMoveNotify.TargetOneofCase.TargetPos)
				{
					baseExploreComponent.SimulateInteractingTarget = null;
					if (baseExploreComponent.SimulateInteractingTargetLocation == null)
					{
						baseExploreComponent.SimulateInteractingTargetLocation = global::Vector.Create();
					}
					baseExploreComponent.SimulateInteractingTargetLocation.X = (double)notify.TargetPos.X;
					baseExploreComponent.SimulateInteractingTargetLocation.Y = (double)notify.TargetPos.Y;
					baseExploreComponent.SimulateInteractingTargetLocation.Z = (double)notify.TargetPos.Z;
					return;
				}
				if (notify.TargetCase == EntityStaticHookMoveNotify.TargetOneofCase.TargetEntityId)
				{
					if (notify.HookMoveType == StaticHookMoveType.Pull)
					{
						MotorcycleExploreComponent motorcycleExploreComponent = (MotorcycleExploreComponent)baseExploreComponent;
						EntityHandle entity2 = CreatureModel.Instance.GetEntity(notify.TargetEntityId);
						GrapplingHookPointComponent simulatePullingTarget;
						if (entity2 == null)
						{
							simulatePullingTarget = null;
						}
						else
						{
							WorldEntity entity3 = entity2.Entity;
							simulatePullingTarget = ((entity3 != null) ? entity3.GetComponent<GrapplingHookPointComponent>() : null);
						}
						motorcycleExploreComponent.SimulatePullingTarget = simulatePullingTarget;
						return;
					}
					baseExploreComponent.SimulateInteractingTargetLocation = null;
					EntityHandle entity4 = CreatureModel.Instance.GetEntity(notify.TargetEntityId);
					BaseExploreComponent baseExploreComponent2 = baseExploreComponent;
					GrapplingHookPointComponent simulateInteractingTarget;
					if (entity4 == null)
					{
						simulateInteractingTarget = null;
					}
					else
					{
						WorldEntity entity5 = entity4.Entity;
						simulateInteractingTarget = ((entity5 != null) ? entity5.GetComponent<GrapplingHookPointComponent>() : null);
					}
					baseExploreComponent2.SimulateInteractingTarget = simulateInteractingTarget;
				}
			}
			return;
		}
		if (notify.TargetCase == EntityStaticHookMoveNotify.TargetOneofCase.TargetPos)
		{
			roleSceneInteractComponent.SimulateHookTargetEntity = null;
			if (roleSceneInteractComponent.SimulateHookTargetLocation == null)
			{
				roleSceneInteractComponent.SimulateHookTargetLocation = global::Vector.Create();
			}
			roleSceneInteractComponent.SimulateHookTargetLocation.X = (double)notify.TargetPos.X;
			roleSceneInteractComponent.SimulateHookTargetLocation.Y = (double)notify.TargetPos.Y;
			roleSceneInteractComponent.SimulateHookTargetLocation.Z = (double)notify.TargetPos.Z;
			return;
		}
		if (notify.TargetCase == EntityStaticHookMoveNotify.TargetOneofCase.TargetEntityId)
		{
			roleSceneInteractComponent.SimulateHookTargetLocation = null;
			EntityHandle entity6 = CreatureModel.Instance.GetEntity(notify.TargetEntityId);
			roleSceneInteractComponent.SimulateHookTargetEntity = entity6;
		}
	}

	// Token: 0x06008569 RID: 34153 RVA: 0x0028D348 File Offset: 0x0028B548
	public static void SendHookMovePush(Entity entity, GrapplingHookPointComponent targetPoint)
	{
		bool flag;
		if (entity == null)
		{
			flag = true;
		}
		else
		{
			BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
			flag = !((component != null) ? new bool?(component.IsAutonomousProxy) : null).GetValueOrDefault();
		}
		if (flag)
		{
			return;
		}
		EntityStaticHookMovePush entityStaticHookMovePush = EntityStaticHookMovePush.Create();
		entityStaticHookMovePush.EntityId = entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
		if (targetPoint.IsMovable())
		{
			entityStaticHookMovePush.TargetEntityId = targetPoint.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
		}
		else
		{
			entityStaticHookMovePush.TargetPos = Aki.Protocol.Vector.Create();
			entityStaticHookMovePush.TargetPos.X = (float)targetPoint.HookLocation.X;
			entityStaticHookMovePush.TargetPos.Y = (float)targetPoint.HookLocation.Y;
			entityStaticHookMovePush.TargetPos.Z = (float)targetPoint.HookLocation.Z;
		}
		CombatNet.Instance.Send(EPushMessageId.EntityStaticHookMovePush, entity, entityStaticHookMovePush, null, null, null);
	}

	// Token: 0x0600856A RID: 34154 RVA: 0x0028D43C File Offset: 0x0028B63C
	public static void SendPullCollectionPush(Entity entity, GrapplingHookPointComponent targetPoint)
	{
		bool flag;
		if (entity == null)
		{
			flag = true;
		}
		else
		{
			BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
			flag = !((component != null) ? new bool?(component.IsAutonomousProxy) : null).GetValueOrDefault();
		}
		if (flag)
		{
			return;
		}
		EntityStaticHookMovePush entityStaticHookMovePush = EntityStaticHookMovePush.Create();
		entityStaticHookMovePush.EntityId = entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
		entityStaticHookMovePush.HookMoveType = StaticHookMoveType.Pull;
		entityStaticHookMovePush.TargetEntityId = targetPoint.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
		CombatNet.Instance.Send(EPushMessageId.EntityStaticHookMovePush, entity, entityStaticHookMovePush, null, null, null);
	}

	// Token: 0x17000EDF RID: 3807
	// (get) Token: 0x0600856B RID: 34155 RVA: 0x0028D4DD File Offset: 0x0028B6DD
	public static RoleSceneInteractController Instance
	{
		get
		{
			return RoleSceneInteractController._Instance;
		}
	}

	// Token: 0x0600856C RID: 34156 RVA: 0x0028D4E4 File Offset: 0x0028B6E4
	public static RoleSceneInteractController GetOrCreateInstance()
	{
		if (RoleSceneInteractController._Instance == null)
		{
			RoleSceneInteractController.CreateInstance();
		}
		return RoleSceneInteractController._Instance;
	}

	// Token: 0x0600856D RID: 34157 RVA: 0x0028D4F8 File Offset: 0x0028B6F8
	public static bool CreateInstance()
	{
		if (RoleSceneInteractController._Instance != null)
		{
			return true;
		}
		RoleSceneInteractController._Instance = new RoleSceneInteractController();
		return true;
	}

	// Token: 0x0600856E RID: 34158 RVA: 0x0028D50E File Offset: 0x0028B70E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600856F RID: 34159 RVA: 0x0028D510 File Offset: 0x0028B710
	public static void ResetStaticDefaultValue()
	{
		RoleSceneInteractController._Instance = null;
	}

	// Token: 0x06008570 RID: 34160 RVA: 0x0028D518 File Offset: 0x0028B718
	static RoleSceneInteractController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSceneInteractController.CreateStaticDefaultValue), new Action(RoleSceneInteractController.ResetStaticDefaultValue));
	}

	// Token: 0x04005134 RID: 20788
	[Nullable(2)]
	private static RoleSceneInteractController _Instance;
}
