using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006240 RID: 25152
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemQuantumDoorComponent : EntityComponent
	{
		// Token: 0x0603CA39 RID: 248377 RVA: 0x011631E0 File Offset: 0x011613E0
		protected override bool OnStart()
		{
			this.RangeComp = base.Entity.GetComponent<RangeComponent>();
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			if (!this.RangeComp || !this.ActorComp)
			{
				Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.FJH, "[QuantumDoorComp] 组件缺失", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.PassableParamName = FNameUtil.GetDynamicFName("Passable");
			this.HitPositionParamName = FNameUtil.GetDynamicFName("HitPositionWS");
			this.DiffusionProgressParamName = FNameUtil.GetDynamicFName("DiffusionProgress");
			EventSystem.Instance.AddWithTarget<bool, AActor>(base.Entity, EEventName.OnActorInOutRangeLocal, new Action<bool, AActor>(this.OnActorOverlapCallback));
			return true;
		}

		// Token: 0x0603CA3A RID: 248378 RVA: 0x0116329C File Offset: 0x0116149C
		protected override bool OnEnd()
		{
			if (EventSystem.Instance.HasWithTarget<bool, AActor>(base.Entity, EEventName.OnActorInOutRangeLocal, new Action<bool, AActor>(this.OnActorOverlapCallback)))
			{
				EventSystem.Instance.RemoveWithTarget<bool, AActor>(base.Entity, EEventName.OnActorInOutRangeLocal, new Action<bool, AActor>(this.OnActorOverlapCallback));
			}
			if (this.CollisionActor != null)
			{
				this.CollisionActor.OnActorHit.Clear();
				this.CollisionActor = null;
			}
			if (this.ProgressTimer != null)
			{
				TimerSystem.Instance.Remove(this.ProgressTimer);
				this.ProgressTimer = null;
			}
			if (EventSystem.Instance.Has<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.OnPlayerFollowerEnableChange)))
			{
				EventSystem.Instance.Remove<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.OnPlayerFollowerEnableChange));
			}
			return true;
		}

		// Token: 0x0603CA3B RID: 248379 RVA: 0x01163368 File Offset: 0x01161568
		[NullableContext(1)]
		private void OnActorOverlapCallback(bool isEnter, AActor actor)
		{
			if (actor == RoleTriggerController.Instance.GetMyRoleTrigger())
			{
				if (this.QuantumDoorStaticMeshComp == null)
				{
					this.GetStaticMeshComponent();
					if (this.QuantumDoorStaticMeshComp == null)
					{
						return;
					}
				}
				if (isEnter)
				{
					if (!EventSystem.Instance.Has<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.OnPlayerFollowerEnableChange)))
					{
						EventSystem.Instance.Add<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.OnPlayerFollowerEnableChange));
					}
					bool flag = this.CheckFollowShooterActive();
					this.QuantumDoorStaticMeshComp.SetScalarParameterValueOnMaterials(this.PassableParamName ?? FNameUtil.NONE, flag > false);
					return;
				}
				if (EventSystem.Instance.Has<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.OnPlayerFollowerEnableChange)))
				{
					EventSystem.Instance.Remove<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.OnPlayerFollowerEnableChange));
				}
				this.QuantumDoorStaticMeshComp.SetScalarParameterValueOnMaterials(this.PassableParamName ?? FNameUtil.NONE, 0f);
			}
		}

		// Token: 0x0603CA3C RID: 248380 RVA: 0x01163478 File Offset: 0x01161678
		private void OnActorHitCallback(AActor selfActor, AActor otherActor, FVector hitPos, [Nullable(1)] FHitResult hitResult)
		{
			if (otherActor == Global.BaseCharacter.CharacterActorComponent.Owner)
			{
				if (this.ProgressTimer != null)
				{
					return;
				}
				if (this.QuantumDoorStaticMeshComp == null)
				{
					this.GetStaticMeshComponent();
					if (this.QuantumDoorStaticMeshComp == null)
					{
						return;
					}
				}
				this.Progress = 0f;
				FVector parameterValue = Global.BaseCharacter.CharacterActorComponent.ActorLocation.ToVector();
				this.QuantumDoorStaticMeshComp.SetVectorParameterValueOnMaterials(this.HitPositionParamName ?? FNameUtil.NONE, parameterValue);
				AudioSystem.Instance.PostEvent("play_interact_space_station_role_dead", this.CollisionActor, null);
				this.ProgressTimer = TimerSystem.Instance.Forever(delegate(float delta)
				{
					if (this.Progress >= 1f)
					{
						TimerSystem.Instance.Remove(this.ProgressTimer);
						this.ProgressTimer = null;
						return;
					}
					this.Progress += delta / 1600f;
					this.Progress = Math.Min(this.Progress, 1f);
					this.QuantumDoorStaticMeshComp.SetScalarParameterValueOnMaterials(this.DiffusionProgressParamName ?? FNameUtil.NONE, this.Progress);
				}, 20f, 1f, null, null, true);
			}
		}

		// Token: 0x0603CA3D RID: 248381 RVA: 0x01163550 File Offset: 0x01161750
		private void GetStaticMeshComponent()
		{
			if (this.CollisionActor == null || !this.CollisionActor.IsValid())
			{
				AActor mainCollisionActor = this.ActorComp.GetMainCollisionActor();
				if (mainCollisionActor != null)
				{
					this.CollisionActor = mainCollisionActor;
					this.CollisionActor.OnActorHit.Add(new Action<AActor, AActor, FVector, FHitResult>(this.OnActorHitCallback));
					if (this.QuantumDoorStaticMeshComp == null)
					{
						AActor collisionActor = this.CollisionActor;
						UStaticMeshComponent ustaticMeshComponent = ((collisionActor != null) ? collisionActor.GetComponentByClass(UStaticMeshComponent.StaticClass()) : null) as UStaticMeshComponent;
						if (ustaticMeshComponent != null)
						{
							this.QuantumDoorStaticMeshComp = ustaticMeshComponent;
							return;
						}
					}
				}
			}
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.FJH, "[QuantumDoorComp] 静态网格体组件缺失", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603CA3E RID: 248382 RVA: 0x011635F8 File Offset: 0x011617F8
		private void OnPlayerFollowerEnableChange(bool isEnable)
		{
			if (this.QuantumDoorStaticMeshComp == null)
			{
				this.GetStaticMeshComponent();
				if (this.QuantumDoorStaticMeshComp == null)
				{
					return;
				}
			}
			EntityHandle playerFollowShooter = FollowUtils.GetPlayerFollowShooter(CreatureModel.Instance.GetPlayerId());
			if (!playerFollowShooter)
			{
				return;
			}
			WorldEntity entity = playerFollowShooter.Entity;
			bool flag;
			if (entity == null)
			{
				flag = false;
			}
			else
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				flag = (((component != null) ? new int?(component.SummonCfgId) : null).GetValueOrDefault() == 24000039);
			}
			bool flag2 = flag;
			this.QuantumDoorStaticMeshComp.SetScalarParameterValueOnMaterials(this.PassableParamName ?? FNameUtil.NONE, (float)((flag2 && isEnable) ? 1 : 0));
		}

		// Token: 0x0603CA3F RID: 248383 RVA: 0x011636A4 File Offset: 0x011618A4
		private bool CheckFollowShooterActive()
		{
			IPlayerFollowerFollowShooterHandler playerFollowerFollowShooterHandler = FollowUtils.GetPlayerFollowHandler(CreatureModel.Instance.GetPlayerId(), EPlayerFollowerHandlerType.FollowShooter) as IPlayerFollowerFollowShooterHandler;
			if (playerFollowerFollowShooterHandler != null && playerFollowerFollowShooterHandler.IsFollowShooterEnable())
			{
				EntityHandle followShooter = playerFollowerFollowShooterHandler.GetFollowShooter();
				object obj;
				if (followShooter == null)
				{
					obj = null;
				}
				else
				{
					WorldEntity entity = followShooter.Entity;
					obj = ((entity != null) ? entity.GetComponent<CreatureDataComponent>() : null);
				}
				object obj2 = obj;
				return obj2 != null && obj2.SummonCfgId == 24000039;
			}
			return false;
		}

		// Token: 0x0603CA40 RID: 248384 RVA: 0x01163704 File Offset: 0x01161904
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemQuantumDoorComponent sceneItemQuantumDoorComponent = (SceneItemQuantumDoorComponent)componentTemplate;
			if (sceneItemQuantumDoorComponent.RangeComp == null)
			{
				this.RangeComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RangeComp), "RangeComp"))
			{
				return false;
			}
			if (sceneItemQuantumDoorComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemQuantumDoorComponent.CollisionActor == null)
			{
				this.CollisionActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CollisionActor), "CollisionActor"))
			{
				return false;
			}
			if (sceneItemQuantumDoorComponent.QuantumDoorStaticMeshComp == null)
			{
				this.QuantumDoorStaticMeshComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.QuantumDoorStaticMeshComp), "QuantumDoorStaticMeshComp"))
			{
				return false;
			}
			if (sceneItemQuantumDoorComponent.ProgressTimer == null)
			{
				this.ProgressTimer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ProgressTimer), "ProgressTimer"))
			{
				return false;
			}
			this.Progress = sceneItemQuantumDoorComponent.Progress;
			this.PassableParamName = sceneItemQuantumDoorComponent.PassableParamName;
			this.HitPositionParamName = sceneItemQuantumDoorComponent.HitPositionParamName;
			this.DiffusionProgressParamName = sceneItemQuantumDoorComponent.DiffusionProgressParamName;
			return true;
		}

		// Token: 0x170072B1 RID: 29361
		// (get) Token: 0x0603CA41 RID: 248385 RVA: 0x0116382B File Offset: 0x01161A2B
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072B2 RID: 29362
		// (get) Token: 0x0603CA42 RID: 248386 RVA: 0x0116382E File Offset: 0x01161A2E
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020253 RID: 131667
		private const float HIT_CD = 1600f;

		// Token: 0x04020254 RID: 131668
		private const int FOLLOW_SHOOTER_ID = 24000039;

		// Token: 0x04020255 RID: 131669
		[Nullable(1)]
		private const string DOOR_HIT_AK_EVENT_NAME = "play_interact_space_station_role_dead";

		// Token: 0x04020256 RID: 131670
		private RangeComponent RangeComp;

		// Token: 0x04020257 RID: 131671
		private SceneItemActorComponent ActorComp;

		// Token: 0x04020258 RID: 131672
		private AActor CollisionActor;

		// Token: 0x04020259 RID: 131673
		private UStaticMeshComponent QuantumDoorStaticMeshComp;

		// Token: 0x0402025A RID: 131674
		private TimerHandle ProgressTimer;

		// Token: 0x0402025B RID: 131675
		private float Progress;

		// Token: 0x0402025C RID: 131676
		private FName? PassableParamName;

		// Token: 0x0402025D RID: 131677
		private FName? HitPositionParamName;

		// Token: 0x0402025E RID: 131678
		private FName? DiffusionProgressParamName;
	}
}
