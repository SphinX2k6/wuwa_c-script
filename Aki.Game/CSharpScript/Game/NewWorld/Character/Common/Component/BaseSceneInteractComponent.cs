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
	// Token: 0x02006325 RID: 25381
	[NullableContext(2)]
	[Nullable(0)]
	public class BaseSceneInteractComponent : EntityComponent
	{
		// Token: 0x0603D70A RID: 251658 RVA: 0x011C5648 File Offset: 0x011C3848
		public bool GetIsHooking()
		{
			return this.IsHooking;
		}

		// Token: 0x0603D70B RID: 251659 RVA: 0x011C5650 File Offset: 0x011C3850
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
			this.ExploreComponent = base.Entity.GetComponent<BaseExploreComponent>();
			return true;
		}

		// Token: 0x17007484 RID: 29828
		// (get) Token: 0x0603D70C RID: 251660 RVA: 0x011C5678 File Offset: 0x011C3878
		// (set) Token: 0x0603D70D RID: 251661 RVA: 0x011C56DA File Offset: 0x011C38DA
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

		// Token: 0x0603D70E RID: 251662 RVA: 0x011C570B File Offset: 0x011C390B
		public GrapplingHookPointComponent GetCurrentTarget()
		{
			HookPointInfo currentInteractingTarget = this.CurrentInteractingTarget;
			if (currentInteractingTarget == null)
			{
				return null;
			}
			return currentInteractingTarget.Point;
		}

		// Token: 0x0603D70F RID: 251663 RVA: 0x011C571E File Offset: 0x011C391E
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

		// Token: 0x0603D710 RID: 251664 RVA: 0x011C5746 File Offset: 0x011C3946
		public bool GetInheritSpeed()
		{
			return this.CurrentInteractingTarget.Point.InheritSpeed;
		}

		// Token: 0x0603D711 RID: 251665 RVA: 0x011C5758 File Offset: 0x011C3958
		public bool GetIsClimb()
		{
			return this.CurrentInteractingTarget.Point.IsClimb;
		}

		// Token: 0x0603D712 RID: 251666 RVA: 0x011C576C File Offset: 0x011C396C
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

		// Token: 0x0603D713 RID: 251667 RVA: 0x011C57F4 File Offset: 0x011C39F4
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

		// Token: 0x0603D714 RID: 251668 RVA: 0x011C587A File Offset: 0x011C3A7A
		public void SetIsHookEndByInterrupt(bool isInterrupt)
		{
			BaseExploreComponent exploreComponent = this.ExploreComponent;
			if (exploreComponent == null)
			{
				return;
			}
			exploreComponent.SetIsHookEndByInterruptProxy(isInterrupt);
		}

		// Token: 0x17007485 RID: 29829
		// (get) Token: 0x0603D715 RID: 251669 RVA: 0x011C588D File Offset: 0x011C3A8D
		// (set) Token: 0x0603D716 RID: 251670 RVA: 0x011C589A File Offset: 0x011C3A9A
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

		// Token: 0x17007486 RID: 29830
		// (get) Token: 0x0603D717 RID: 251671 RVA: 0x011C58A8 File Offset: 0x011C3AA8
		// (set) Token: 0x0603D718 RID: 251672 RVA: 0x011C58B5 File Offset: 0x011C3AB5
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

		// Token: 0x17007487 RID: 29831
		// (get) Token: 0x0603D719 RID: 251673 RVA: 0x011C58C3 File Offset: 0x011C3AC3
		// (set) Token: 0x0603D71A RID: 251674 RVA: 0x011C58D0 File Offset: 0x011C3AD0
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

		// Token: 0x17007488 RID: 29832
		// (get) Token: 0x0603D71B RID: 251675 RVA: 0x011C58E0 File Offset: 0x011C3AE0
		// (set) Token: 0x0603D71C RID: 251676 RVA: 0x011C5929 File Offset: 0x011C3B29
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

		// Token: 0x0603D71D RID: 251677 RVA: 0x011C5943 File Offset: 0x011C3B43
		public FVectorDouble GetNextTargetLocation()
		{
			return this.NextTarget.Point.HookLocation.ToUeVector(false);
		}

		// Token: 0x0603D71E RID: 251678 RVA: 0x011C595B File Offset: 0x011C3B5B
		[NullableContext(1)]
		public Vector GetNextTargetVector()
		{
			return this.NextTarget.Point.HookLocation;
		}

		// Token: 0x0603D71F RID: 251679 RVA: 0x011C5970 File Offset: 0x011C3B70
		public bool CheckNextTargetCanInteract()
		{
			GrapplingHookPointComponent focusTarget = this.ExploreComponent.FocusTarget;
			return focusTarget != null && this.NextLegal && focusTarget.OnlineTypeCanInteract;
		}

		// Token: 0x0603D720 RID: 251680 RVA: 0x011C599C File Offset: 0x011C3B9C
		public bool GetNextTargetIsIgnorePlayerCollision()
		{
			GrapplingHookPointComponent focusTarget = this.ExploreComponent.FocusTarget;
			return focusTarget != null && focusTarget.IsIgnorePlayerCollision;
		}

		// Token: 0x0603D721 RID: 251681 RVA: 0x011C59C0 File Offset: 0x011C3BC0
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

		// Token: 0x0603D722 RID: 251682 RVA: 0x011C5A14 File Offset: 0x011C3C14
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

		// Token: 0x0603D723 RID: 251683 RVA: 0x011C5A9C File Offset: 0x011C3C9C
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

		// Token: 0x0603D724 RID: 251684 RVA: 0x011C5B20 File Offset: 0x011C3D20
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

		// Token: 0x0603D725 RID: 251685 RVA: 0x011C5B28 File Offset: 0x011C3D28
		public bool GetIsInLastPathway()
		{
			return this.CurrentPathwayIndex < 0 || this.CurrentPathwayIndex >= this.CurrentPathways.Count || this.CurrentPathwayIndex >= this.CurrentPathways.Count - 1;
		}

		// Token: 0x0603D726 RID: 251686 RVA: 0x011C5B60 File Offset: 0x011C3D60
		public FVectorDouble GetCurrentTargetForward()
		{
			CreatureDataComponent component = this.CurrentInteractingTarget.Point.Entity.GetComponent<CreatureDataComponent>();
			if (component != null && component.Valid)
			{
				return component.GetRotation().RotateVectorDouble(Vector.ForwardVectorDouble);
			}
			return this.ActorComp.ActorForward;
		}

		// Token: 0x0603D727 RID: 251687 RVA: 0x011C5BB0 File Offset: 0x011C3DB0
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

		// Token: 0x0603D728 RID: 251688 RVA: 0x011C5C04 File Offset: 0x011C3E04
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

		// Token: 0x0603D729 RID: 251689 RVA: 0x011C5CAF File Offset: 0x011C3EAF
		public bool CanActivateFixHook()
		{
			return this.NextLegal && this.NextTarget != null && this.CurrentInteractingTarget != this.NextTarget;
		}

		// Token: 0x0603D72A RID: 251690 RVA: 0x011C5CD4 File Offset: 0x011C3ED4
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			BaseSceneInteractComponent baseSceneInteractComponent = (BaseSceneInteractComponent)componentTemplate;
			if (baseSceneInteractComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (baseSceneInteractComponent.ExploreComponent == null)
			{
				this.ExploreComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ExploreComponent), "ExploreComponent"))
			{
				return false;
			}
			this.IsHooking = baseSceneInteractComponent.IsHooking;
			if (baseSceneInteractComponent.CurrentInteractingTargetWrapper == null)
			{
				this.CurrentInteractingTargetWrapper = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentInteractingTargetWrapper), "CurrentInteractingTargetWrapper"))
			{
				return false;
			}
			if (baseSceneInteractComponent.NextTargetWrapper == null)
			{
				this.NextTargetWrapper = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.NextTargetWrapper), "NextTargetWrapper"))
			{
				return false;
			}
			if (baseSceneInteractComponent.SimulateHookTargetEntity == null)
			{
				this.SimulateHookTargetEntity = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SimulateHookTargetEntity), "SimulateHookTargetEntity"))
			{
				return false;
			}
			if (baseSceneInteractComponent.SimulateHookTargetLocation == null)
			{
				this.SimulateHookTargetLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SimulateHookTargetLocation), "SimulateHookTargetLocation"))
			{
				return false;
			}
			if (baseSceneInteractComponent.CurrentPathways == null)
			{
				this.CurrentPathways = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentPathways), "CurrentPathways"))
			{
				return false;
			}
			this.CurrentPathwayIndex = baseSceneInteractComponent.CurrentPathwayIndex;
			return true;
		}

		// Token: 0x17007489 RID: 29833
		// (get) Token: 0x0603D72B RID: 251691 RVA: 0x011C5E39 File Offset: 0x011C4039
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020965 RID: 133477
		public BaseActorComponent ActorComp;

		// Token: 0x04020966 RID: 133478
		protected BaseExploreComponent ExploreComponent;

		// Token: 0x04020967 RID: 133479
		protected bool IsHooking;

		// Token: 0x04020968 RID: 133480
		protected HookPointInfo CurrentInteractingTargetWrapper;

		// Token: 0x04020969 RID: 133481
		protected HookPointInfo NextTargetWrapper;

		// Token: 0x0402096A RID: 133482
		public EntityHandle SimulateHookTargetEntity;

		// Token: 0x0402096B RID: 133483
		public Vector SimulateHookTargetLocation;

		// Token: 0x0402096C RID: 133484
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		protected List<ValueTuple<Vector, Vector>> CurrentPathways = new List<ValueTuple<Vector, Vector>>();

		// Token: 0x0402096D RID: 133485
		protected int CurrentPathwayIndex = -1;

		// Token: 0x0402096E RID: 133486
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
