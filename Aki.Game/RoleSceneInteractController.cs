using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.Character.Role.Component;

// Token: 0x020017BF RID: 6079
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RoleSceneInteractController : ControllerBase
{
	// Token: 0x0600B180 RID: 45440 RVA: 0x00282BE8 File Offset: 0x00280DE8
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

	// Token: 0x0600B181 RID: 45441 RVA: 0x00282DB0 File Offset: 0x00280FB0
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

	// Token: 0x0600B182 RID: 45442 RVA: 0x00282EA4 File Offset: 0x002810A4
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

	// Token: 0x17000EBC RID: 3772
	// (get) Token: 0x0600B183 RID: 45443 RVA: 0x00282F45 File Offset: 0x00281145
	public static RoleSceneInteractController Instance
	{
		get
		{
			return RoleSceneInteractController._Instance;
		}
	}

	// Token: 0x0600B184 RID: 45444 RVA: 0x00282F4C File Offset: 0x0028114C
	public static RoleSceneInteractController GetOrCreateInstance()
	{
		if (RoleSceneInteractController._Instance == null)
		{
			RoleSceneInteractController.CreateInstance();
		}
		return RoleSceneInteractController._Instance;
	}

	// Token: 0x0600B185 RID: 45445 RVA: 0x00282F60 File Offset: 0x00281160
	public static bool CreateInstance()
	{
		if (RoleSceneInteractController._Instance != null)
		{
			return true;
		}
		RoleSceneInteractController._Instance = new RoleSceneInteractController();
		return true;
	}

	// Token: 0x0600B186 RID: 45446 RVA: 0x00282F76 File Offset: 0x00281176
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B187 RID: 45447 RVA: 0x00282F78 File Offset: 0x00281178
	public static void ResetStaticDefaultValue()
	{
		RoleSceneInteractController._Instance = null;
	}

	// Token: 0x0600B188 RID: 45448 RVA: 0x00282F80 File Offset: 0x00281180
	static RoleSceneInteractController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSceneInteractController.CreateStaticDefaultValue), new Action(RoleSceneInteractController.ResetStaticDefaultValue));
	}

	// Token: 0x0400508A RID: 20618
	[Nullable(2)]
	private static RoleSceneInteractController _Instance;
}
