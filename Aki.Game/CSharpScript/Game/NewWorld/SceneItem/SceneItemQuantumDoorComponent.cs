using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200718C RID: 29068
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemQuantumDoorComponent : EntityComponent
	{
		// Token: 0x06047181 RID: 291201 RVA: 0x0120923C File Offset: 0x0120743C
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

		// Token: 0x06047182 RID: 291202 RVA: 0x012092F8 File Offset: 0x012074F8
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

		// Token: 0x06047183 RID: 291203 RVA: 0x012093C4 File Offset: 0x012075C4
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

		// Token: 0x06047184 RID: 291204 RVA: 0x012094D4 File Offset: 0x012076D4
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

		// Token: 0x06047185 RID: 291205 RVA: 0x012095AC File Offset: 0x012077AC
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

		// Token: 0x06047186 RID: 291206 RVA: 0x01209654 File Offset: 0x01207854
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

		// Token: 0x06047187 RID: 291207 RVA: 0x01209700 File Offset: 0x01207900
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

		// Token: 0x06047188 RID: 291208 RVA: 0x01209760 File Offset: 0x01207960
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemQuantumDoorComponent sceneItemQuantumDoorComponent = (SceneItemQuantumDoorComponent)componentTemplate;
			if (base.CanResetComponentProperty("RangeComp"))
			{
				if (sceneItemQuantumDoorComponent.RangeComp == null)
				{
					this.RangeComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<RangeComponent>(this.RangeComp), "RangeComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemQuantumDoorComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CollisionActor"))
			{
				if (sceneItemQuantumDoorComponent.CollisionActor == null)
				{
					this.CollisionActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.CollisionActor), "CollisionActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("QuantumDoorStaticMeshComp"))
			{
				if (sceneItemQuantumDoorComponent.QuantumDoorStaticMeshComp == null)
				{
					this.QuantumDoorStaticMeshComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UStaticMeshComponent>(this.QuantumDoorStaticMeshComp), "QuantumDoorStaticMeshComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ProgressTimer"))
			{
				if (sceneItemQuantumDoorComponent.ProgressTimer == null)
				{
					this.ProgressTimer = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.ProgressTimer), "ProgressTimer"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("Progress"))
			{
				this.Progress = sceneItemQuantumDoorComponent.Progress;
			}
			if (base.CanResetComponentProperty("PassableParamName"))
			{
				this.PassableParamName = sceneItemQuantumDoorComponent.PassableParamName;
			}
			if (base.CanResetComponentProperty("HitPositionParamName"))
			{
				this.HitPositionParamName = sceneItemQuantumDoorComponent.HitPositionParamName;
			}
			if (base.CanResetComponentProperty("DiffusionProgressParamName"))
			{
				this.DiffusionProgressParamName = sceneItemQuantumDoorComponent.DiffusionProgressParamName;
			}
			return true;
		}

		// Token: 0x040255EC RID: 153068
		private const float HIT_CD = 1600f;

		// Token: 0x040255ED RID: 153069
		private const int FOLLOW_SHOOTER_ID = 24000039;

		// Token: 0x040255EE RID: 153070
		[Nullable(1)]
		private const string DOOR_HIT_AK_EVENT_NAME = "play_interact_space_station_role_dead";

		// Token: 0x040255EF RID: 153071
		private RangeComponent RangeComp;

		// Token: 0x040255F0 RID: 153072
		private SceneItemActorComponent ActorComp;

		// Token: 0x040255F1 RID: 153073
		private AActor CollisionActor;

		// Token: 0x040255F2 RID: 153074
		private UStaticMeshComponent QuantumDoorStaticMeshComp;

		// Token: 0x040255F3 RID: 153075
		private TimerHandle ProgressTimer;

		// Token: 0x040255F4 RID: 153076
		private float Progress;

		// Token: 0x040255F5 RID: 153077
		private FName? PassableParamName;

		// Token: 0x040255F6 RID: 153078
		private FName? HitPositionParamName;

		// Token: 0x040255F7 RID: 153079
		private FName? DiffusionProgressParamName;
	}
}
