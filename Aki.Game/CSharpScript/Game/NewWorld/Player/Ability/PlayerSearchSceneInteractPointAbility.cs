using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.LevelEntityAbility;
using CSharpScript.Game.LevelGamePlay.SceneInteract;
using CSharpScript.Game.NewWorld.Player.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Player.Ability
{
	// Token: 0x0200705C RID: 28764
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerSearchSceneInteractPointAbility : LevelEntityAbilityBase
	{
		// Token: 0x0604601F RID: 286751 RVA: 0x011739AD File Offset: 0x01171BAD
		private bool IsInteractingPoint(ISceneInteractPoint point)
		{
			PlayerSceneInteractComponent currentRoleInteractComp = this.CurrentRoleInteractComp;
			return currentRoleInteractComp != null && currentRoleInteractComp.IsInteractingPoint(point);
		}

		// Token: 0x06046020 RID: 286752 RVA: 0x011739C4 File Offset: 0x01171BC4
		public PlayerSearchSceneInteractPointAbility(ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) : base(type, tickPhase, tickOrder, needTickActivate)
		{
			this.SearchParams = new <PlayerSearchSceneInteractPointAbility>F1A288CD6718D19573611C8AFEB07CD8B0525D222D3381BA0ED014CAAA637126E__SceneInteractSearchParams
			{
				CameraLocation = this.CameraLocation,
				CameraForward = this.CameraForward,
				CurrentRoleLocation = this.CurrentRoleLocation,
				CurrentRoleEntityHandle = null,
				IsInteractingPoint = new Func<ISceneInteractPoint, bool>(this.IsInteractingPoint)
			};
		}

		// Token: 0x06046021 RID: 286753 RVA: 0x01173A50 File Offset: 0x01171C50
		public override bool ShouldActivate(Entity entity)
		{
			return SceneInteractPointManager.Instance.PointSize > 0;
		}

		// Token: 0x06046022 RID: 286754 RVA: 0x01173A5F File Offset: 0x01171C5F
		public override bool ShouldDeactivate(Entity entity)
		{
			return SceneInteractPointManager.Instance.PointSize == 0;
		}

		// Token: 0x06046023 RID: 286755 RVA: 0x01173A6E File Offset: 0x01171C6E
		public override void OnActivated(Entity entity)
		{
			PlayerSceneInteractComponent component = entity.GetComponent<PlayerSceneInteractComponent>();
			if (component == null)
			{
				return;
			}
			component.SetBestInteractPoint(null);
		}

		// Token: 0x06046024 RID: 286756 RVA: 0x01173A84 File Offset: 0x01171C84
		public override void OnTick(Entity entity, float deltaMilliseconds)
		{
			PlayerSceneInteractComponent component = entity.GetComponent<PlayerSceneInteractComponent>();
			if (!this.TryRefreshCurrentRoleContext())
			{
				if (component != null)
				{
					component.SetBestInteractPoint(null);
				}
				return;
			}
			if (component != null)
			{
				component.SetBestInteractPoint(this.FindBestInteractPoint(entity));
			}
		}

		// Token: 0x06046025 RID: 286757 RVA: 0x01173ABB File Offset: 0x01171CBB
		public override void OnDeactivated(Entity entity)
		{
			PlayerSceneInteractComponent component = entity.GetComponent<PlayerSceneInteractComponent>();
			if (component != null)
			{
				component.SetBestInteractPoint(null);
			}
			this.ClearCurrentRoleContext();
			this.PointBuckets.Clear();
		}

		// Token: 0x06046026 RID: 286758 RVA: 0x01173AE0 File Offset: 0x01171CE0
		[return: Nullable(2)]
		private ISceneInteractPoint FindBestInteractPoint(Entity entity)
		{
			CharacterActorComponent currentRoleActorComponent = this.CurrentRoleActorComponent;
			CameraModel instance = CameraModel.Instance;
			ACameraActor acameraActor = ((instance != null) ? instance.MainModel.CurrentCameraActor : null) as ACameraActor;
			if (((currentRoleActorComponent != null) ? currentRoleActorComponent.Owner : null) == null || (acameraActor == null || !acameraActor.IsValid()) || this.PlayerCapsule == null)
			{
				return null;
			}
			Vector cameraLocation = this.CameraLocation;
			FVectorDouble fvectorDouble = acameraActor.D_K2_GetActorLocation();
			cameraLocation.FromUeVector(fvectorDouble);
			Vector cameraForward = this.CameraForward;
			FVector actorForwardVector = acameraActor.GetActorForwardVector();
			cameraForward.FromUeVector(actorForwardVector);
			this.CurrentRoleLocation.DeepCopy(currentRoleActorComponent.ActorLocationProxy);
			this.CurrentRoleInteractComp = entity.GetComponent<PlayerSceneInteractComponent>();
			this.RefreshPointBuckets();
			this.SearchParams.CurrentRoleEntityHandle = this.CurrentRoleEntityHandle;
			ISceneInteractPoint result = null;
			double num = double.NegativeInfinity;
			foreach (KeyValuePair<ESceneInteractSearchStrategyType, List<ISceneInteractPoint>> keyValuePair in this.PointBuckets)
			{
				ESceneInteractSearchStrategyType esceneInteractSearchStrategyType;
				List<ISceneInteractPoint> list;
				keyValuePair.Deconstruct(out esceneInteractSearchStrategyType, out list);
				ESceneInteractSearchStrategyType strategyType = esceneInteractSearchStrategyType;
				List<ISceneInteractPoint> list2 = list;
				if (list2.Count != 0)
				{
					SceneInteractSearchStrategy strategyByType = SceneInteractSearchStrategyRegistry.Instance.GetStrategyByType(strategyType);
					if ((double)strategyByType.Priority >= num)
					{
						ISceneInteractPoint sceneInteractPoint = strategyByType.SelectBest(list2, this.SearchParams);
						if (sceneInteractPoint != null && (double)strategyByType.Priority > num)
						{
							num = (double)strategyByType.Priority;
							result = sceneInteractPoint;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06046027 RID: 286759 RVA: 0x01173C48 File Offset: 0x01171E48
		private void RefreshPointBuckets()
		{
			foreach (List<ISceneInteractPoint> list in this.PointBuckets.Values)
			{
				list.Clear();
			}
			foreach (ISceneInteractPointSource sceneInteractPointSource in SceneInteractPointManager.Instance.GetSources())
			{
				foreach (ISceneInteractPoint sceneInteractPoint in sceneInteractPointSource.GetInteractPoints())
				{
					ESceneInteractSearchStrategyType? pointStrategyType = sceneInteractPoint.GetPointStrategyType();
					if (pointStrategyType != null)
					{
						List<ISceneInteractPoint> list2 = this.PointBuckets.GetValueOrDefault(pointStrategyType.Value);
						if (list2 == null)
						{
							list2 = new List<ISceneInteractPoint>();
							this.PointBuckets[pointStrategyType.Value] = list2;
						}
						list2.Add(sceneInteractPoint);
					}
				}
			}
		}

		// Token: 0x06046028 RID: 286760 RVA: 0x01173D58 File Offset: 0x01171F58
		private bool TryRefreshCurrentRoleContext()
		{
			SceneTeamModel instance = SceneTeamModel.Instance;
			EntityHandle entityHandle = (instance != null) ? instance.GetCurrentEntity : null;
			WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
			if (entityHandle == null || worldEntity == null)
			{
				this.ClearCurrentRoleContext();
				return false;
			}
			if (this.CurrentRoleEntityId == worldEntity.Id)
			{
				return this.CurrentRoleActorComponent != null && this.PlayerCapsule != null;
			}
			CharacterActorComponent component = worldEntity.GetComponent<CharacterActorComponent>();
			if (((component != null) ? component.Owner : null) == null || component.Actor.CapsuleComponent == null)
			{
				this.ClearCurrentRoleContext();
				return false;
			}
			this.CurrentRoleActorComponent = component;
			this.PlayerCapsule = component.Actor.CapsuleComponent;
			this.CurrentRoleEntityHandle = entityHandle;
			this.CurrentRoleEntityId = worldEntity.Id;
			return true;
		}

		// Token: 0x06046029 RID: 286761 RVA: 0x01173E0A File Offset: 0x0117200A
		private void ClearCurrentRoleContext()
		{
			this.CurrentRoleEntityId = 0;
			this.CurrentRoleActorComponent = null;
			this.PlayerCapsule = null;
			this.CurrentRoleEntityHandle = null;
			this.CurrentRoleInteractComp = null;
		}

		// Token: 0x04024A69 RID: 150121
		[Nullable(2)]
		private UCapsuleComponent PlayerCapsule;

		// Token: 0x04024A6A RID: 150122
		private int CurrentRoleEntityId;

		// Token: 0x04024A6B RID: 150123
		[Nullable(2)]
		private CharacterActorComponent CurrentRoleActorComponent;

		// Token: 0x04024A6C RID: 150124
		[Nullable(2)]
		private EntityHandle CurrentRoleEntityHandle;

		// Token: 0x04024A6D RID: 150125
		private readonly Vector CameraLocation = Vector.Create();

		// Token: 0x04024A6E RID: 150126
		private readonly Vector CameraForward = Vector.Create();

		// Token: 0x04024A6F RID: 150127
		private readonly Vector CurrentRoleLocation = Vector.Create();

		// Token: 0x04024A70 RID: 150128
		private readonly Dictionary<ESceneInteractSearchStrategyType, List<ISceneInteractPoint>> PointBuckets = new Dictionary<ESceneInteractSearchStrategyType, List<ISceneInteractPoint>>();

		// Token: 0x04024A71 RID: 150129
		[Nullable(2)]
		private PlayerSceneInteractComponent CurrentRoleInteractComp;

		// Token: 0x04024A72 RID: 150130
		private readonly ISceneInteractSearchParams SearchParams;
	}
}
