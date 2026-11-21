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
	// Token: 0x020061DD RID: 25053
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerSearchSceneInteractPointAbility : LevelEntityAbilityBase
	{
		// Token: 0x0603C217 RID: 246295 RVA: 0x0111D5AC File Offset: 0x0111B7AC
		private bool IsInteractingPoint(ISceneInteractPoint point)
		{
			PlayerSceneInteractComponent currentRoleInteractComp = this.CurrentRoleInteractComp;
			return currentRoleInteractComp != null && currentRoleInteractComp.IsInteractingPoint(point);
		}

		// Token: 0x0603C218 RID: 246296 RVA: 0x0111D5C0 File Offset: 0x0111B7C0
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

		// Token: 0x0603C219 RID: 246297 RVA: 0x0111D64C File Offset: 0x0111B84C
		public override bool ShouldActivate(Entity entity)
		{
			return SceneInteractPointManager.Instance.PointSize > 0;
		}

		// Token: 0x0603C21A RID: 246298 RVA: 0x0111D65B File Offset: 0x0111B85B
		public override bool ShouldDeactivate(Entity entity)
		{
			return SceneInteractPointManager.Instance.PointSize == 0;
		}

		// Token: 0x0603C21B RID: 246299 RVA: 0x0111D66A File Offset: 0x0111B86A
		public override void OnActivated(Entity entity)
		{
			PlayerSceneInteractComponent component = entity.GetComponent<PlayerSceneInteractComponent>();
			if (component == null)
			{
				return;
			}
			component.SetBestInteractPoint(null);
		}

		// Token: 0x0603C21C RID: 246300 RVA: 0x0111D680 File Offset: 0x0111B880
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

		// Token: 0x0603C21D RID: 246301 RVA: 0x0111D6B7 File Offset: 0x0111B8B7
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

		// Token: 0x0603C21E RID: 246302 RVA: 0x0111D6DC File Offset: 0x0111B8DC
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

		// Token: 0x0603C21F RID: 246303 RVA: 0x0111D844 File Offset: 0x0111BA44
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

		// Token: 0x0603C220 RID: 246304 RVA: 0x0111D954 File Offset: 0x0111BB54
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

		// Token: 0x0603C221 RID: 246305 RVA: 0x0111DA06 File Offset: 0x0111BC06
		private void ClearCurrentRoleContext()
		{
			this.CurrentRoleEntityId = 0;
			this.CurrentRoleActorComponent = null;
			this.PlayerCapsule = null;
			this.CurrentRoleEntityHandle = null;
			this.CurrentRoleInteractComp = null;
		}

		// Token: 0x17007175 RID: 29045
		// (get) Token: 0x0603C222 RID: 246306 RVA: 0x0111DA2B File Offset: 0x0111BC2B
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FD1F RID: 130335
		[Nullable(2)]
		private UCapsuleComponent PlayerCapsule;

		// Token: 0x0401FD20 RID: 130336
		private int CurrentRoleEntityId;

		// Token: 0x0401FD21 RID: 130337
		[Nullable(2)]
		private CharacterActorComponent CurrentRoleActorComponent;

		// Token: 0x0401FD22 RID: 130338
		[Nullable(2)]
		private EntityHandle CurrentRoleEntityHandle;

		// Token: 0x0401FD23 RID: 130339
		private readonly Vector CameraLocation = Vector.Create();

		// Token: 0x0401FD24 RID: 130340
		private readonly Vector CameraForward = Vector.Create();

		// Token: 0x0401FD25 RID: 130341
		private readonly Vector CurrentRoleLocation = Vector.Create();

		// Token: 0x0401FD26 RID: 130342
		private readonly Dictionary<ESceneInteractSearchStrategyType, List<ISceneInteractPoint>> PointBuckets = new Dictionary<ESceneInteractSearchStrategyType, List<ISceneInteractPoint>>();

		// Token: 0x0401FD27 RID: 130343
		[Nullable(2)]
		private PlayerSceneInteractComponent CurrentRoleInteractComp;

		// Token: 0x0401FD28 RID: 130344
		private readonly ISceneInteractSearchParams SearchParams;
	}
}
