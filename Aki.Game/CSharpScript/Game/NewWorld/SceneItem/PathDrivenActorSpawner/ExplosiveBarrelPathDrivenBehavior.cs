using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.GamePlay.PathDrivenActor;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071BC RID: 29116
	[NullableContext(1)]
	[Nullable(0)]
	public class ExplosiveBarrelPathDrivenBehavior : IPathDrivenActorTickBehavior, IPathDrivenActorBehavior
	{
		// Token: 0x06047401 RID: 291841 RVA: 0x0121E2BC File Offset: 0x0121C4BC
		public ExplosiveBarrelPathDrivenBehavior(int? ownerPbDataId)
		{
			this.OwnerPbDataId = ownerPbDataId;
		}

		// Token: 0x06047402 RID: 291842 RVA: 0x0121E2E4 File Offset: 0x0121C4E4
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

		// Token: 0x06047403 RID: 291843 RVA: 0x0121E588 File Offset: 0x0121C788
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

		// Token: 0x06047404 RID: 291844 RVA: 0x0121E5B0 File Offset: 0x0121C7B0
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

		// Token: 0x06047405 RID: 291845 RVA: 0x0121E5E4 File Offset: 0x0121C7E4
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

		// Token: 0x06047406 RID: 291846 RVA: 0x0121E609 File Offset: 0x0121C809
		public void OnStagnationChanged(IPathDrivenActorRuntimeData runtimeData, bool isStagnated)
		{
		}

		// Token: 0x06047407 RID: 291847 RVA: 0x0121E60B File Offset: 0x0121C80B
		public void OnSpawnerStagnationChanged(IPathDrivenActorRuntimeData runtimeData, bool isStagnated)
		{
		}

		// Token: 0x06047408 RID: 291848 RVA: 0x0121E60D File Offset: 0x0121C80D
		[NullableContext(0)]
		public UniTask<bool> OnTrackSwitched([Nullable(1)] IPathDrivenActorRuntimeData runtimeData, FTransformDouble fromTransform, FTransformDouble toTransform)
		{
			runtimeData.Actor.D_K2_SetActorTransform(toTransform, false, null, true);
			return UniTask.FromResult<bool>(true);
		}

		// Token: 0x06047409 RID: 291849 RVA: 0x0121E628 File Offset: 0x0121C828
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

		// Token: 0x0604740A RID: 291850 RVA: 0x0121E6D0 File Offset: 0x0121C8D0
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

		// Token: 0x0604740B RID: 291851 RVA: 0x0121E720 File Offset: 0x0121C920
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

		// Token: 0x0604740C RID: 291852 RVA: 0x0121E794 File Offset: 0x0121C994
		private void StartRollingAudio(AActor actor)
		{
			if (string.IsNullOrEmpty(this.AudioEvent) || this.AudioHandle != 0 || (actor == null || !actor.IsValid()))
			{
				return;
			}
			this.AudioHandle = AudioSystem.Instance.PostEvent(this.AudioEvent, actor, null);
		}

		// Token: 0x0604740D RID: 291853 RVA: 0x0121E7E8 File Offset: 0x0121C9E8
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

		// Token: 0x0604740E RID: 291854 RVA: 0x0121E838 File Offset: 0x0121CA38
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

		// Token: 0x0604740F RID: 291855 RVA: 0x0121E8FC File Offset: 0x0121CAFC
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

		// Token: 0x06047410 RID: 291856 RVA: 0x0121E9A0 File Offset: 0x0121CBA0
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

		// Token: 0x04025788 RID: 153480
		private const float MIN_BARREL_RADIUS = 0.01f;

		// Token: 0x04025789 RID: 153481
		private static readonly int EXPLOSIVE_BARREL_HIT_EVENT_TAG_ID = GameplayTagDefine.EGameplayTagId["关卡.事件.无限爆炸桶.爆炸桶命中"];

		// Token: 0x0402578A RID: 153482
		private float BarrelRadius;

		// Token: 0x0402578B RID: 153483
		private string ExplodeEffectPath = "";

		// Token: 0x0402578C RID: 153484
		private string AudioEvent = "";

		// Token: 0x0402578D RID: 153485
		private int AudioHandle;

		// Token: 0x0402578E RID: 153486
		[Nullable(2)]
		private UStaticMeshComponent StaticMeshComponent;

		// Token: 0x0402578F RID: 153487
		private float LastSplineDistance;

		// Token: 0x04025790 RID: 153488
		[Nullable(2)]
		private IPathDrivenActorRuntimeData RuntimeData;

		// Token: 0x04025791 RID: 153489
		private readonly int? OwnerPbDataId;
	}
}
