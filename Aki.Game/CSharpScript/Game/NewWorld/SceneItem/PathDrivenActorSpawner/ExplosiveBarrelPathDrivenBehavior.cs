using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.GamePlay.PathDrivenActor;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x02006271 RID: 25201
	[NullableContext(1)]
	[Nullable(0)]
	public class ExplosiveBarrelPathDrivenBehavior : IPathDrivenActorTickBehavior, IPathDrivenActorBehavior
	{
		// Token: 0x0603CCFC RID: 249084 RVA: 0x011781C8 File Offset: 0x011763C8
		public ExplosiveBarrelPathDrivenBehavior(int? ownerPbDataId)
		{
			this.OwnerPbDataId = ownerPbDataId;
		}

		// Token: 0x0603CCFD RID: 249085 RVA: 0x011781F0 File Offset: 0x011763F0
		public unsafe bool Initialize(IPathDrivenActorRuntimeData runtimeData)
		{
			AActor actor = runtimeData.Actor;
			AActor aactor = (actor != null && actor.IsValid()) ? (UKuroStaticLibrary.GetDefaultObject(actor.GetClass()) as AActor) : null;
			if (actor == null || !actor.IsValid() || (aactor == null || !aactor.ActorHasTag(FNameUtil.GetDynamicFName("PathDrivenBehavior.ExplosiveBarrel").Value)))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PathDrivenActor;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[ExplosiveBarrelPathDrivenBehavior] Actor未配置爆炸桶行为Tag";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActorClass", (actor != null) ? actor.GetClass().GetName() : null);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			this.RuntimeData = runtimeData;
			BP_ExplosiveBarrel_C bp_ExplosiveBarrel_C = actor as BP_ExplosiveBarrel_C;
			UStaticMeshComponent staticMesh = bp_ExplosiveBarrel_C.StaticMesh;
			float barrelRadius = bp_ExplosiveBarrel_C.BarrelRadius;
			if (staticMesh == null || !staticMesh.IsValid())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PathDrivenActor;
				ELogAuthor author2 = ELogAuthor.WRY;
				string message2 = "[ExplosiveBarrelPathDrivenBehavior] 爆炸桶缺少ExplosiveBarrel组件";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ActorClass", actor.GetClass().GetName());
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			if (barrelRadius <= 0.01f)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.PathDrivenActor;
				ELogAuthor author3 = ELogAuthor.WRY;
				string message3 = "[ExplosiveBarrelPathDrivenBehavior] 爆炸桶BarrelRadius非法";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("ActorClass", actor.GetClass().GetName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("BarrelRadius", barrelRadius);
				instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
				return false;
			}
			this.BarrelRadius = barrelRadius;
			TSoftObjectPtr<UEffectModelBase> explodeEffectAsset = bp_ExplosiveBarrel_C.ExplodeEffectAsset;
			string text = (explodeEffectAsset != null) ? explodeEffectAsset.ToAssetPathName() : null;
			this.ExplodeEffectPath = ((!string.IsNullOrEmpty(text) && text != "None") ? text : "");
			this.AudioEvent = (bp_ExplosiveBarrel_C.AudioEvent ?? "");
			this.StaticMeshComponent = staticMesh;
			this.LastSplineDistance = runtimeData.MoveComponent.GetDistanceAlongSpline();
			actor.OnActorBeginOverlap.Add(new Action<AActor, AActor>(this.HandleActorBeginOverlap));
			this.StartRollingAudio(actor);
			return true;
		}

		// Token: 0x0603CCFE RID: 249086 RVA: 0x01178494 File Offset: 0x01176694
		public void PrepareCollisionBeforeSpawn(IPathDrivenActorRuntimeData runtimeData)
		{
			UStaticMeshComponent staticMeshComponent = this.StaticMeshComponent;
			if (staticMeshComponent != null)
			{
				staticMeshComponent.SetGenerateOverlapEvents(false);
			}
			UStaticMeshComponent staticMeshComponent2 = this.StaticMeshComponent;
			if (staticMeshComponent2 == null)
			{
				return;
			}
			staticMeshComponent2.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		}

		// Token: 0x0603CCFF RID: 249087 RVA: 0x011784BC File Offset: 0x011766BC
		public void RestoreCollisionAfterSpawn(IPathDrivenActorRuntimeData runtimeData)
		{
			UStaticMeshComponent staticMeshComponent = this.StaticMeshComponent;
			if (staticMeshComponent == null || !staticMeshComponent.IsValid())
			{
				return;
			}
			staticMeshComponent.SetCollisionEnabled(ECollisionEnabled.QueryOnly);
			staticMeshComponent.SetGenerateOverlapEvents(true);
		}

		// Token: 0x0603CD00 RID: 249088 RVA: 0x011784F0 File Offset: 0x011766F0
		public void ClearCollisionBeforeRecycle(IPathDrivenActorRuntimeData runtimeData)
		{
			UStaticMeshComponent staticMeshComponent = this.StaticMeshComponent;
			if (staticMeshComponent != null)
			{
				staticMeshComponent.SetGenerateOverlapEvents(false);
			}
			UStaticMeshComponent staticMeshComponent2 = this.StaticMeshComponent;
			if (staticMeshComponent2 == null)
			{
				return;
			}
			staticMeshComponent2.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		}

		// Token: 0x0603CD01 RID: 249089 RVA: 0x01178515 File Offset: 0x01176715
		public void OnStagnationChanged(IPathDrivenActorRuntimeData runtimeData, bool isStagnated)
		{
		}

		// Token: 0x0603CD02 RID: 249090 RVA: 0x01178517 File Offset: 0x01176717
		public void OnSpawnerStagnationChanged(IPathDrivenActorRuntimeData runtimeData, bool isStagnated)
		{
		}

		// Token: 0x0603CD03 RID: 249091 RVA: 0x01178519 File Offset: 0x01176719
		[NullableContext(0)]
		public UniTask<bool> OnTrackSwitched([Nullable(1)] IPathDrivenActorRuntimeData runtimeData, FTransformDouble fromTransform, FTransformDouble toTransform)
		{
			runtimeData.Actor.D_K2_SetActorTransform(toTransform, false, null, true);
			return UniTask.FromResult<bool>(true);
		}

		// Token: 0x0603CD04 RID: 249092 RVA: 0x01178534 File Offset: 0x01176734
		public void Tick(IPathDrivenActorRuntimeData runtimeData, float deltaSeconds)
		{
			if (!runtimeData.Finished)
			{
				UKuroSceneItemMoveComponent moveComponent = runtimeData.MoveComponent;
				if (moveComponent != null && moveComponent.IsValid())
				{
					UStaticMeshComponent staticMeshComponent = this.StaticMeshComponent;
					if (staticMeshComponent == null || !staticMeshComponent.IsValid())
					{
						return;
					}
					float distanceAlongSpline = runtimeData.MoveComponent.GetDistanceAlongSpline();
					float num = distanceAlongSpline - this.LastSplineDistance;
					this.LastSplineDistance = distanceAlongSpline;
					if (num == 0f)
					{
						return;
					}
					double num2 = (double)num / (6.283185307179586 * (double)this.BarrelRadius) * 360.0;
					FHitResult fhitResult = null;
					staticMeshComponent.K2_AddLocalRotation(new FRotator(0f, (float)num2, 0f), false, ref fhitResult, false);
					return;
				}
			}
		}

		// Token: 0x0603CD05 RID: 249093 RVA: 0x011785DC File Offset: 0x011767DC
		public void OnFinishing(IPathDrivenActorRuntimeData runtimeData, EPathDrivenActorFinishReason reason)
		{
			this.StopRollingAudio();
			AActor actor = runtimeData.Actor;
			FTransformDouble? actorTransform = (actor != null && actor.IsValid()) ? new FTransformDouble?(actor.D_GetTransform()) : null;
			this.TryPlayExplodeEffect(runtimeData, actorTransform);
			if (reason == EPathDrivenActorFinishReason.Overlap)
			{
				this.TryEmitOverlapHitEvent();
			}
		}

		// Token: 0x0603CD06 RID: 249094 RVA: 0x0117862C File Offset: 0x0117682C
		public void Cleanup(IPathDrivenActorRuntimeData runtimeData)
		{
			this.StopRollingAudio();
			AActor actor = runtimeData.Actor;
			if (actor != null && actor.IsValid())
			{
				runtimeData.Actor.OnActorBeginOverlap.Remove(new Action<AActor, AActor>(this.HandleActorBeginOverlap));
			}
			this.ExplodeEffectPath = "";
			this.AudioEvent = "";
			this.StaticMeshComponent = null;
			this.LastSplineDistance = 0f;
			this.RuntimeData = null;
		}

		// Token: 0x0603CD07 RID: 249095 RVA: 0x011786A0 File Offset: 0x011768A0
		private void StartRollingAudio(AActor actor)
		{
			if (string.IsNullOrEmpty(this.AudioEvent) || this.AudioHandle != 0 || (actor == null || !actor.IsValid()))
			{
				return;
			}
			this.AudioHandle = AudioSystem.Instance.PostEvent(this.AudioEvent, actor, null);
		}

		// Token: 0x0603CD08 RID: 249096 RVA: 0x011786F4 File Offset: 0x011768F4
		private void StopRollingAudio()
		{
			if (this.AudioHandle == 0)
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(this.AudioHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(700)
			}));
			this.AudioHandle = 0;
		}

		// Token: 0x0603CD09 RID: 249097 RVA: 0x01178744 File Offset: 0x01176944
		private unsafe void TryPlayExplodeEffect(IPathDrivenActorRuntimeData runtimeData, FTransformDouble? actorTransform)
		{
			if (actorTransform == null || string.IsNullOrEmpty(this.ExplodeEffectPath) || GlobalData.World == null)
			{
				return;
			}
			int id = EffectSystem.Instance.SpawnEffect(GlobalData.World, actorTransform, this.ExplodeEffectPath, "[ExplosiveBarrelPathDrivenBehavior] PlayExplodeEffect", null, EEffectType.Scene, null, null, null, false, false);
			if (!EffectSystem.Instance.IsValid(id))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PathDrivenActor;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[ExplosiveBarrelPathDrivenBehavior] 爆炸桶爆炸效果播放失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EffectPath", this.ExplodeEffectPath);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x0603CD0A RID: 249098 RVA: 0x01178808 File Offset: 0x01176A08
		private unsafe void TryEmitOverlapHitEvent()
		{
			FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(ExplosiveBarrelPathDrivenBehavior.EXPLOSIVE_BARREL_HIT_EVENT_TAG_ID);
			if (gameplayTagById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PathDrivenActor;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[ExplosiveBarrelPathDrivenBehavior] 爆炸桶命中事件Tag无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TagId", ExplosiveBarrelPathDrivenBehavior.EXPLOSIVE_BARREL_HIT_EVENT_TAG_ID);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			EventSystem.Instance.Emit<FGameplayTag>(EEventName.CheckClientEvent, gameplayTagById.Value);
		}

		// Token: 0x0603CD0B RID: 249099 RVA: 0x011788AC File Offset: 0x01176AAC
		[NullableContext(2)]
		private void HandleActorBeginOverlap(AActor overlappedActor, AActor otherActor)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			AActor aactor;
			if (baseCharacter == null)
			{
				aactor = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				aactor = ((characterActorComponent != null) ? characterActorComponent.Owner : null);
			}
			AActor aactor2 = aactor;
			TsBaseCharacter baseCharacter2 = Global.BaseCharacter;
			TsBaseVehicle tsBaseVehicle;
			if (baseCharacter2 == null)
			{
				tsBaseVehicle = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent2 = baseCharacter2.CharacterActorComponent;
				if (characterActorComponent2 == null)
				{
					tsBaseVehicle = null;
				}
				else
				{
					Entity entity = characterActorComponent2.Entity;
					if (entity == null)
					{
						tsBaseVehicle = null;
					}
					else
					{
						RoleDriveVehicleComponent component = entity.GetComponent<RoleDriveVehicleComponent>();
						if (component == null)
						{
							tsBaseVehicle = null;
						}
						else
						{
							Entity vehicleEntity = component.VehicleEntity;
							if (vehicleEntity == null)
							{
								tsBaseVehicle = null;
							}
							else
							{
								VehicleActorComponent component2 = vehicleEntity.GetComponent<VehicleActorComponent>();
								tsBaseVehicle = ((component2 != null) ? component2.Actor : null);
							}
						}
					}
				}
			}
			TsBaseVehicle tsBaseVehicle2 = tsBaseVehicle;
			if (overlappedActor == null || !overlappedActor.IsValid() || (otherActor == null || !otherActor.IsValid()) || otherActor == overlappedActor || (otherActor != aactor2 && otherActor != tsBaseVehicle2))
			{
				return;
			}
			IPathDrivenActorRuntimeData runtimeData = this.RuntimeData;
			if (runtimeData == null)
			{
				return;
			}
			runtimeData.RequestFinish(EPathDrivenActorFinishReason.Overlap);
		}

		// Token: 0x040203F7 RID: 132087
		private const float MIN_BARREL_RADIUS = 0.01f;

		// Token: 0x040203F8 RID: 132088
		private static readonly int EXPLOSIVE_BARREL_HIT_EVENT_TAG_ID = GameplayTagDefine.EGameplayTagId["关卡.事件.无限爆炸桶.爆炸桶命中"];

		// Token: 0x040203F9 RID: 132089
		private float BarrelRadius;

		// Token: 0x040203FA RID: 132090
		private string ExplodeEffectPath = "";

		// Token: 0x040203FB RID: 132091
		private string AudioEvent = "";

		// Token: 0x040203FC RID: 132092
		private int AudioHandle;

		// Token: 0x040203FD RID: 132093
		[Nullable(2)]
		private UStaticMeshComponent StaticMeshComponent;

		// Token: 0x040203FE RID: 132094
		private float LastSplineDistance;

		// Token: 0x040203FF RID: 132095
		[Nullable(2)]
		private IPathDrivenActorRuntimeData RuntimeData;

		// Token: 0x04020400 RID: 132096
		private readonly int? OwnerPbDataId;
	}
}
