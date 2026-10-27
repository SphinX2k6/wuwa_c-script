using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Core.World;
using AkiClient.Game.Aki.GamePlay.Portal;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070C1 RID: 28865
	[NullableContext(2)]
	[Nullable(0)]
	public class BaseSceneInteractComponent : EntityComponent
	{
		// Token: 0x0604662C RID: 288300 RVA: 0x011A5EB8 File Offset: 0x011A40B8
		public bool GetIsHooking()
		{
			return this.IsHooking;
		}

		// Token: 0x0604662D RID: 288301 RVA: 0x011A5EC0 File Offset: 0x011A40C0
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
			this.ExploreComponent = base.Entity.GetComponent<BaseExploreComponent>();
			return true;
		}

		// Token: 0x17009C87 RID: 40071
		// (get) Token: 0x0604662E RID: 288302 RVA: 0x011A5EE8 File Offset: 0x011A40E8
		// (set) Token: 0x0604662F RID: 288303 RVA: 0x011A5F4A File Offset: 0x011A414A
		protected HookPointInfo CurrentInteractingTarget
		{
			get
			{
				BaseExploreComponent exploreComponent = this.ExploreComponent;
				if (exploreComponent == null || !exploreComponent.Valid)
				{
					return null;
				}
				GrapplingHookPointComponent interactingTarget = this.ExploreComponent.InteractingTarget;
				if (interactingTarget == null)
				{
					return null;
				}
				if (this.CurrentInteractingTargetWrapper == null)
				{
					this.CurrentInteractingTargetWrapper = new HookPointInfo(interactingTarget, 0L, true);
				}
				else
				{
					this.CurrentInteractingTargetWrapper.Point = interactingTarget;
				}
				return this.CurrentInteractingTargetWrapper;
			}
			set
			{
				BaseExploreComponent exploreComponent = this.ExploreComponent;
				if (exploreComponent == null || !exploreComponent.Valid)
				{
					return;
				}
				this.ExploreComponent.InteractingTarget = ((value != null) ? value.Point : null);
			}
		}

		// Token: 0x06046630 RID: 288304 RVA: 0x011A5F7B File Offset: 0x011A417B
		public GrapplingHookPointComponent GetCurrentTarget()
		{
			HookPointInfo currentInteractingTarget = this.CurrentInteractingTarget;
			if (currentInteractingTarget == null)
			{
				return null;
			}
			return currentInteractingTarget.Point;
		}

		// Token: 0x06046631 RID: 288305 RVA: 0x011A5F8E File Offset: 0x011A418E
		public AActor GetCurrentTargetActor()
		{
			HookPointInfo currentInteractingTarget = this.CurrentInteractingTarget;
			if (currentInteractingTarget == null)
			{
				return null;
			}
			BaseActorComponent component = currentInteractingTarget.Point.Entity.GetComponent<BaseActorComponent>();
			if (component == null)
			{
				return null;
			}
			return component.Owner;
		}

		// Token: 0x06046632 RID: 288306 RVA: 0x011A5FB6 File Offset: 0x011A41B6
		public bool GetInheritSpeed()
		{
			return this.CurrentInteractingTarget.Point.InheritSpeed;
		}

		// Token: 0x06046633 RID: 288307 RVA: 0x011A5FC8 File Offset: 0x011A41C8
		public bool GetIsClimb()
		{
			return this.CurrentInteractingTarget.Point.IsClimb;
		}

		// Token: 0x06046634 RID: 288308 RVA: 0x011A5FDC File Offset: 0x011A41DC
		public BP_KuroPortalCapture_C GetCurrentTargetEnterPortalCapture()
		{
			HookPointInfo currentInteractingTarget = this.CurrentInteractingTarget;
			if (((currentInteractingTarget != null) ? currentInteractingTarget.Point : null) == null || currentInteractingTarget.PortalPairId == 0L)
			{
				return null;
			}
			CreatureModel instance = CreatureModel.Instance;
			SceneItemPortalComponent sceneItemPortalComponent;
			if (instance == null)
			{
				sceneItemPortalComponent = null;
			}
			else
			{
				EntityHandle entity = instance.GetEntity(currentInteractingTarget.PortalPairId);
				if (entity == null)
				{
					sceneItemPortalComponent = null;
				}
				else
				{
					WorldEntity entity2 = entity.Entity;
					sceneItemPortalComponent = ((entity2 != null) ? entity2.GetComponent<SceneItemPortalComponent>() : null);
				}
			}
			SceneItemPortalComponent sceneItemPortalComponent2 = sceneItemPortalComponent;
			if (sceneItemPortalComponent2 == null)
			{
				return null;
			}
			BP_KuroPortalCapture_C bp_KuroPortalCapture_C = (sceneItemPortalComponent2 != null) ? sceneItemPortalComponent2.PortalCapture : null;
			if (currentInteractingTarget.PortalA2B)
			{
				return bp_KuroPortalCapture_C;
			}
			BP_KuroPortalCapture_C result = null;
			if (bp_KuroPortalCapture_C != null)
			{
				bp_KuroPortalCapture_C.GetPair(ref result);
			}
			return result;
		}

		// Token: 0x06046635 RID: 288309 RVA: 0x011A6064 File Offset: 0x011A4264
		public BP_KuroPortalCapture_C GetCurrentTargetExitPortalCapture()
		{
			HookPointInfo currentInteractingTarget = this.CurrentInteractingTarget;
			if (((currentInteractingTarget != null) ? currentInteractingTarget.Point : null) == null || currentInteractingTarget.PortalPairId == 0L)
			{
				return null;
			}
			CreatureModel instance = CreatureModel.Instance;
			SceneItemPortalComponent sceneItemPortalComponent;
			if (instance == null)
			{
				sceneItemPortalComponent = null;
			}
			else
			{
				EntityHandle entity = instance.GetEntity(currentInteractingTarget.PortalPairId);
				if (entity == null)
				{
					sceneItemPortalComponent = null;
				}
				else
				{
					WorldEntity entity2 = entity.Entity;
					sceneItemPortalComponent = ((entity2 != null) ? entity2.GetComponent<SceneItemPortalComponent>() : null);
				}
			}
			SceneItemPortalComponent sceneItemPortalComponent2 = sceneItemPortalComponent;
			if (sceneItemPortalComponent2 == null)
			{
				return null;
			}
			BP_KuroPortalCapture_C bp_KuroPortalCapture_C = (sceneItemPortalComponent2 != null) ? sceneItemPortalComponent2.PortalCapture : null;
			if (currentInteractingTarget.PortalA2B)
			{
				return bp_KuroPortalCapture_C;
			}
			BP_KuroPortalCapture_C result = null;
			if (bp_KuroPortalCapture_C != null)
			{
				bp_KuroPortalCapture_C.GetPair(ref result);
			}
			return result;
		}

		// Token: 0x06046636 RID: 288310 RVA: 0x011A60EA File Offset: 0x011A42EA
		public void SetIsHookEndByInterrupt(bool isInterrupt)
		{
			BaseExploreComponent exploreComponent = this.ExploreComponent;
			if (exploreComponent == null)
			{
				return;
			}
			exploreComponent.SetIsHookEndByInterruptProxy(isInterrupt);
		}

		// Token: 0x17009C88 RID: 40072
		// (get) Token: 0x06046637 RID: 288311 RVA: 0x011A60FD File Offset: 0x011A42FD
		// (set) Token: 0x06046638 RID: 288312 RVA: 0x011A610A File Offset: 0x011A430A
		protected bool NextLegal
		{
			get
			{
				return this.ExploreComponent.FocusTargetLegal;
			}
			set
			{
				this.ExploreComponent.FocusTargetLegal = value;
			}
		}

		// Token: 0x17009C89 RID: 40073
		// (get) Token: 0x06046639 RID: 288313 RVA: 0x011A6118 File Offset: 0x011A4318
		// (set) Token: 0x0604663A RID: 288314 RVA: 0x011A6125 File Offset: 0x011A4325
		protected bool NextLegalExceptSkill
		{
			get
			{
				return this.ExploreComponent.FocusTargetLegalExceptSkill;
			}
			set
			{
				this.ExploreComponent.FocusTargetLegalExceptSkill = value;
			}
		}

		// Token: 0x17009C8A RID: 40074
		// (get) Token: 0x0604663B RID: 288315 RVA: 0x011A6133 File Offset: 0x011A4333
		// (set) Token: 0x0604663C RID: 288316 RVA: 0x011A6140 File Offset: 0x011A4340
		protected bool SyncEnabled
		{
			get
			{
				return this.ExploreComponent.SyncEnabled;
			}
			set
			{
				this.ExploreComponent.SyncEnabled = value;
			}
		}

		// Token: 0x17009C8B RID: 40075
		// (get) Token: 0x0604663D RID: 288317 RVA: 0x011A6150 File Offset: 0x011A4350
		// (set) Token: 0x0604663E RID: 288318 RVA: 0x011A6199 File Offset: 0x011A4399
		protected HookPointInfo NextTarget
		{
			get
			{
				GrapplingHookPointComponent focusTarget = this.ExploreComponent.FocusTarget;
				if (focusTarget == null)
				{
					return null;
				}
				if (this.NextTargetWrapper == null)
				{
					this.NextTargetWrapper = new HookPointInfo(focusTarget, 0L, true);
				}
				else
				{
					this.NextTargetWrapper.Point = focusTarget;
				}
				return this.NextTargetWrapper;
			}
			set
			{
				this.ExploreComponent.SetFocusTarget((value != null) ? value.Point : null, true);
			}
		}

		// Token: 0x0604663F RID: 288319 RVA: 0x011A61B3 File Offset: 0x011A43B3
		public FVectorDouble GetNextTargetLocation()
		{
			return this.NextTarget.Point.HookLocation.ToUeVector(false);
		}

		// Token: 0x06046640 RID: 288320 RVA: 0x011A61CB File Offset: 0x011A43CB
		[NullableContext(1)]
		public Vector GetNextTargetVector()
		{
			return this.NextTarget.Point.HookLocation;
		}

		// Token: 0x06046641 RID: 288321 RVA: 0x011A61E0 File Offset: 0x011A43E0
		public bool CheckNextTargetCanInteract()
		{
			GrapplingHookPointComponent focusTarget = this.ExploreComponent.FocusTarget;
			return focusTarget != null && this.NextLegal && focusTarget.OnlineTypeCanInteract;
		}

		// Token: 0x06046642 RID: 288322 RVA: 0x011A620C File Offset: 0x011A440C
		public bool GetNextTargetIsIgnorePlayerCollision()
		{
			GrapplingHookPointComponent focusTarget = this.ExploreComponent.FocusTarget;
			return focusTarget != null && focusTarget.IsIgnorePlayerCollision;
		}

		// Token: 0x06046643 RID: 288323 RVA: 0x011A6230 File Offset: 0x011A4430
		public EntityHandle GetCurrentTargetEntity()
		{
			BaseActorComponent actorComp = this.ActorComp;
			if (actorComp == null || !actorComp.IsAutonomousProxy)
			{
				return this.SimulateHookTargetEntity;
			}
			if (this.CurrentInteractingTarget == null)
			{
				return null;
			}
			return CreatureModel.Instance.GetEntityById(this.CurrentInteractingTarget.Point.Entity.Id);
		}

		// Token: 0x06046644 RID: 288324 RVA: 0x011A6284 File Offset: 0x011A4484
		[NullableContext(1)]
		public Vector GetCurrentTargetLocation()
		{
			BaseActorComponent actorComp = this.ActorComp;
			Vector vector2;
			if (actorComp == null || !actorComp.IsAutonomousProxy)
			{
				EntityHandle simulateHookTargetEntity = this.SimulateHookTargetEntity;
				Vector vector;
				if (simulateHookTargetEntity == null)
				{
					vector = null;
				}
				else
				{
					WorldEntity entity = simulateHookTargetEntity.Entity;
					if (entity == null)
					{
						vector = null;
					}
					else
					{
						GrapplingHookPointComponent component = entity.GetComponent<GrapplingHookPointComponent>();
						vector = ((component != null) ? component.HookLocation : null);
					}
				}
				vector2 = (vector ?? this.SimulateHookTargetLocation);
			}
			else
			{
				HookPointInfo currentInteractingTarget = this.CurrentInteractingTarget;
				vector2 = ((currentInteractingTarget != null) ? currentInteractingTarget.Point.HookLocation : null);
			}
			return vector2 ?? this.ActorComp.ActorLocationProxy;
		}

		// Token: 0x06046645 RID: 288325 RVA: 0x011A630C File Offset: 0x011A450C
		[NullableContext(1)]
		public Vector GetCurrentPathwayEndLocation()
		{
			Vector vector = null;
			BaseActorComponent actorComp = this.ActorComp;
			if (actorComp != null && actorComp.IsAutonomousProxy && this.CurrentPathwayIndex >= 0 && this.CurrentPathwayIndex < this.CurrentPathways.Count)
			{
				vector = this.CurrentPathways[this.CurrentPathwayIndex].Item2;
			}
			Vector result;
			if ((result = vector) == null)
			{
				HookPointInfo currentInteractingTarget = this.CurrentInteractingTarget;
				result = (((currentInteractingTarget != null) ? currentInteractingTarget.Point.HookLocation : null) ?? this.ActorComp.ActorLocationProxy);
			}
			return result;
		}

		// Token: 0x06046646 RID: 288326 RVA: 0x011A6390 File Offset: 0x011A4590
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public List<ValueTuple<Vector, Vector>> GetCurrentPathways()
		{
			return this.CurrentPathways;
		}

		// Token: 0x06046647 RID: 288327 RVA: 0x011A6398 File Offset: 0x011A4598
		public bool GetIsInLastPathway()
		{
			return this.CurrentPathwayIndex < 0 || this.CurrentPathwayIndex >= this.CurrentPathways.Count || this.CurrentPathwayIndex >= this.CurrentPathways.Count - 1;
		}

		// Token: 0x06046648 RID: 288328 RVA: 0x011A63D0 File Offset: 0x011A45D0
		public FVectorDouble GetCurrentTargetForward()
		{
			CreatureDataComponent component = this.CurrentInteractingTarget.Point.Entity.GetComponent<CreatureDataComponent>();
			if (component != null && component.Valid)
			{
				return component.GetRotation().RotateVectorDouble(Vector.ForwardVectorDouble);
			}
			return this.ActorComp.ActorForward;
		}

		// Token: 0x06046649 RID: 288329 RVA: 0x011A6420 File Offset: 0x011A4620
		public bool GetTargetIsSuiGuangType()
		{
			HookPointInfo currentInteractingTarget = this.CurrentInteractingTarget;
			int? num;
			if (currentInteractingTarget == null)
			{
				num = null;
			}
			else
			{
				GrapplingHookPointComponent point = currentInteractingTarget.Point;
				num = ((point != null) ? point.GetHookInteractType() : null);
			}
			return num == 2;
		}

		// Token: 0x0604664A RID: 288330 RVA: 0x011A6474 File Offset: 0x011A4674
		public EHookInteractTypeBp GetTargetType()
		{
			HookPointInfo currentInteractingTarget = this.CurrentInteractingTarget;
			EHookInteractType? ehookInteractType;
			if (currentInteractingTarget == null)
			{
				ehookInteractType = null;
			}
			else
			{
				GrapplingHookPointComponent point = currentInteractingTarget.Point;
				ehookInteractType = ((point != null) ? point.GetHookInteractType() : null);
			}
			EHookInteractType? ehookInteractType2 = ehookInteractType;
			if (ehookInteractType2 == null)
			{
				return EHookInteractTypeBp.FixedPointHook;
			}
			if (ehookInteractType2.GetValueOrDefault() == EHookInteractType.SlashHook)
			{
				HookPointInfo currentInteractingTarget2 = this.CurrentInteractingTarget;
				ESlashHitType? eslashHitType = (currentInteractingTarget2 != null) ? currentInteractingTarget2.Point.GetSlashHitType() : null;
				if (eslashHitType != null)
				{
					ESlashHitType valueOrDefault = eslashHitType.GetValueOrDefault();
					if (valueOrDefault == ESlashHitType.HeavySlash)
					{
						return EHookInteractTypeBp.SlashHook;
					}
					if (valueOrDefault == ESlashHitType.LightSlash)
					{
						return EHookInteractTypeBp.LightSlashHook;
					}
				}
			}
			EHookInteractTypeBp result;
			if (!BaseSceneInteractComponent.InteractTsType2BpType.TryGetValue(ehookInteractType2.Value, out result))
			{
				return EHookInteractTypeBp.FixedPointHook;
			}
			return result;
		}

		// Token: 0x0604664B RID: 288331 RVA: 0x011A651F File Offset: 0x011A471F
		public bool CanActivateFixHook()
		{
			return this.NextLegal && this.NextTarget != null && this.CurrentInteractingTarget != this.NextTarget;
		}

		// Token: 0x0604664C RID: 288332 RVA: 0x011A6544 File Offset: 0x011A4744
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			BaseSceneInteractComponent baseSceneInteractComponent = (BaseSceneInteractComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (baseSceneInteractComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ExploreComponent"))
			{
				if (baseSceneInteractComponent.ExploreComponent == null)
				{
					this.ExploreComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseExploreComponent>(this.ExploreComponent), "ExploreComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsHooking"))
			{
				this.IsHooking = baseSceneInteractComponent.IsHooking;
			}
			if (base.CanResetComponentProperty("CurrentInteractingTargetWrapper"))
			{
				if (baseSceneInteractComponent.CurrentInteractingTargetWrapper == null)
				{
					this.CurrentInteractingTargetWrapper = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<HookPointInfo>(this.CurrentInteractingTargetWrapper), "CurrentInteractingTargetWrapper"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("NextTargetWrapper"))
			{
				if (baseSceneInteractComponent.NextTargetWrapper == null)
				{
					this.NextTargetWrapper = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<HookPointInfo>(this.NextTargetWrapper), "NextTargetWrapper"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SimulateHookTargetEntity"))
			{
				if (baseSceneInteractComponent.SimulateHookTargetEntity == null)
				{
					this.SimulateHookTargetEntity = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<EntityHandle>(this.SimulateHookTargetEntity), "SimulateHookTargetEntity"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SimulateHookTargetLocation"))
			{
				if (baseSceneInteractComponent.SimulateHookTargetLocation == null)
				{
					this.SimulateHookTargetLocation = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.SimulateHookTargetLocation), "SimulateHookTargetLocation"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CurrentPathways"))
			{
				if (baseSceneInteractComponent.CurrentPathways == null)
				{
					this.CurrentPathways = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<ValueTuple<Vector, Vector>>>(this.CurrentPathways), "CurrentPathways"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CurrentPathwayIndex"))
			{
				this.CurrentPathwayIndex = baseSceneInteractComponent.CurrentPathwayIndex;
			}
			return true;
		}

		// Token: 0x04024E27 RID: 151079
		public BaseActorComponent ActorComp;

		// Token: 0x04024E28 RID: 151080
		protected BaseExploreComponent ExploreComponent;

		// Token: 0x04024E29 RID: 151081
		protected bool IsHooking;

		// Token: 0x04024E2A RID: 151082
		protected HookPointInfo CurrentInteractingTargetWrapper;

		// Token: 0x04024E2B RID: 151083
		protected HookPointInfo NextTargetWrapper;

		// Token: 0x04024E2C RID: 151084
		public EntityHandle SimulateHookTargetEntity;

		// Token: 0x04024E2D RID: 151085
		public Vector SimulateHookTargetLocation;

		// Token: 0x04024E2E RID: 151086
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		protected List<ValueTuple<Vector, Vector>> CurrentPathways = new List<ValueTuple<Vector, Vector>>();

		// Token: 0x04024E2F RID: 151087
		protected int CurrentPathwayIndex = -1;

		// Token: 0x04024E30 RID: 151088
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EHookInteractType, EHookInteractTypeBp> InteractTsType2BpType = new Dictionary<EHookInteractType, EHookInteractTypeBp>
		{
			{
				EHookInteractType.FixedPointHook,
				EHookInteractTypeBp.FixedPointHook
			},
			{
				EHookInteractType.SuiGuangHook,
				EHookInteractTypeBp.SuiGuangHook
			},
			{
				EHookInteractType.KiteHook,
				EHookInteractTypeBp.KiteHook
			},
			{
				EHookInteractType.RagDollJumpingPoint,
				EHookInteractTypeBp.RagDollJumpingPoint
			},
			{
				EHookInteractType.RagDollClimbingPoint,
				EHookInteractTypeBp.RagDollClimbingPoint
			},
			{
				EHookInteractType.MovementPointHook,
				EHookInteractTypeBp.MovementPointHook
			},
			{
				EHookInteractType.SlashHook,
				EHookInteractTypeBp.SlashHook
			},
			{
				EHookInteractType.ChargeSlashHook,
				EHookInteractTypeBp.ChargeSlashHook
			},
			{
				EHookInteractType.CableWay,
				EHookInteractTypeBp.CableWayHook
			}
		};
	}
}
