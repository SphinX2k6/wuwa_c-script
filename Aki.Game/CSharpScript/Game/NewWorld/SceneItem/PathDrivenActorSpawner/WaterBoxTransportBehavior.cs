using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.GamePlay.PathDrivenActor;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Render;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071D3 RID: 29139
	[NullableContext(1)]
	[Nullable(0)]
	public class WaterBoxTransportBehavior : IPathDrivenActorBehavior, IStaticVariableResetter
	{
		// Token: 0x060474F9 RID: 292089 RVA: 0x012227DF File Offset: 0x012209DF
		static WaterBoxTransportBehavior()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WaterBoxTransportBehavior.CreateStaticDefaultValue), new Action(WaterBoxTransportBehavior.ResetStaticDefaultValue));
		}

		// Token: 0x060474FA RID: 292090 RVA: 0x012227FE File Offset: 0x012209FE
		public static void CreateStaticDefaultValue()
		{
			WaterBoxTransportBehavior._stagnationMaterialDataCache = new Dictionary<string, ItemMaterialControllerActorData>();
		}

		// Token: 0x060474FB RID: 292091 RVA: 0x0122280A File Offset: 0x01220A0A
		public static void ResetStaticDefaultValue()
		{
			WaterBoxTransportBehavior.StagnatedTrailCount = 0;
			WaterBoxTransportBehavior._stagnationMaterialDataCache = null;
		}

		// Token: 0x17009DED RID: 40429
		// (get) Token: 0x060474FC RID: 292092 RVA: 0x01222818 File Offset: 0x01220A18
		private static Dictionary<string, ItemMaterialControllerActorData> StagnationMaterialDataCache
		{
			get
			{
				return WaterBoxTransportBehavior._stagnationMaterialDataCache;
			}
		}

		// Token: 0x060474FD RID: 292093 RVA: 0x0122281F File Offset: 0x01220A1F
		public WaterBoxTransportBehavior(int? ownerPbDataId)
		{
			this.OwnerPbDataId = ownerPbDataId;
		}

		// Token: 0x060474FE RID: 292094 RVA: 0x01222844 File Offset: 0x01220A44
		public unsafe bool Initialize(IPathDrivenActorRuntimeData runtimeData)
		{
			AActor actor = runtimeData.Actor;
			AActor aactor = (actor != null && actor.IsValid()) ? (UKuroStaticLibrary.GetDefaultObject(actor.GetClass()) as AActor) : null;
			if (actor == null || !actor.IsValid() || (aactor == null || !aactor.ActorHasTag(FNameUtil.GetDynamicFName("PathDrivenBehavior.WaterBoxTransport").Value)))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PathDrivenActor;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[WaterBoxTransportBehavior] Actor未配置水匣运输箱行为Tag";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActorClass", (actor != null) ? actor.GetClass().GetName() : null);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			BP_WaterBox_PhantomBox_C bp_WaterBox_PhantomBox_C = actor as BP_WaterBox_PhantomBox_C;
			TSoftObjectPtr<ItemMaterialControllerActorData> stagnationMaterialDataAsset = bp_WaterBox_PhantomBox_C.StagnationMaterialDataAsset;
			string text = (stagnationMaterialDataAsset != null) ? stagnationMaterialDataAsset.ToAssetPathName() : null;
			this.StagnationMaterialDataPath = ((!string.IsNullOrEmpty(text) && text != "None") ? text : "");
			TSoftObjectPtr<UEffectModelGroup> trailEffectAsset = bp_WaterBox_PhantomBox_C.TrailEffectAsset;
			string text2 = (trailEffectAsset != null) ? trailEffectAsset.ToAssetPathName() : null;
			this.TrailEffectPath = ((!string.IsNullOrEmpty(text2) && text2 != "None") ? text2 : "");
			this.CollisionTriggerComponent = bp_WaterBox_PhantomBox_C.Trigger;
			UBoxComponent collisionTriggerComponent = this.CollisionTriggerComponent;
			if (collisionTriggerComponent != null && collisionTriggerComponent.IsValid())
			{
				this.GenerateOverlapEventsBeforeSpawn = this.CollisionTriggerComponent.GetGenerateOverlapEvents();
			}
			this.StagnationMaterialActor = actor;
			this.AttachOwnerForHit(runtimeData);
			this.SpawnTrailEffect(runtimeData, bp_WaterBox_PhantomBox_C);
			return true;
		}

		// Token: 0x060474FF RID: 292095 RVA: 0x012229E1 File Offset: 0x01220BE1
		public void PrepareCollisionBeforeSpawn(IPathDrivenActorRuntimeData runtimeData)
		{
			UBoxComponent collisionTriggerComponent = this.CollisionTriggerComponent;
			if (collisionTriggerComponent == null)
			{
				return;
			}
			collisionTriggerComponent.SetGenerateOverlapEvents(false);
		}

		// Token: 0x06047500 RID: 292096 RVA: 0x012229F4 File Offset: 0x01220BF4
		public void RestoreCollisionAfterSpawn(IPathDrivenActorRuntimeData runtimeData)
		{
			UBoxComponent collisionTriggerComponent = this.CollisionTriggerComponent;
			if (collisionTriggerComponent == null || !collisionTriggerComponent.IsValid())
			{
				return;
			}
			collisionTriggerComponent.SetGenerateOverlapEvents(this.GenerateOverlapEventsBeforeSpawn);
		}

		// Token: 0x06047501 RID: 292097 RVA: 0x01222A26 File Offset: 0x01220C26
		public void ClearCollisionBeforeRecycle(IPathDrivenActorRuntimeData runtimeData)
		{
			UBoxComponent collisionTriggerComponent = this.CollisionTriggerComponent;
			if (collisionTriggerComponent == null)
			{
				return;
			}
			collisionTriggerComponent.SetGenerateOverlapEvents(false);
		}

		// Token: 0x06047502 RID: 292098 RVA: 0x01222A39 File Offset: 0x01220C39
		public void OnStagnationChanged(IPathDrivenActorRuntimeData runtimeData, bool isStagnated)
		{
			this.StagnationMaterialEnabled = isStagnated;
			if (isStagnated)
			{
				this.EnableStagnationMaterial();
				return;
			}
			this.DisableStagnationMaterial();
		}

		// Token: 0x06047503 RID: 292099 RVA: 0x01222A54 File Offset: 0x01220C54
		private void EnableStagnationMaterial()
		{
			string dataPath = this.StagnationMaterialDataPath;
			if (string.IsNullOrEmpty(dataPath))
			{
				return;
			}
			ItemMaterialControllerActorData itemMaterialControllerActorData;
			if (WaterBoxTransportBehavior.StagnationMaterialDataCache.TryGetValue(dataPath, out itemMaterialControllerActorData) && itemMaterialControllerActorData != null && itemMaterialControllerActorData.IsValid())
			{
				this.ApplyStagnationMaterial(itemMaterialControllerActorData);
				return;
			}
			ResourceSystem.Instance.LoadAsync<ItemMaterialControllerActorData>(dataPath, delegate([Nullable(2)] ItemMaterialControllerActorData asset, string _)
			{
				if (asset != null && asset.IsValid())
				{
					WaterBoxTransportBehavior.StagnationMaterialDataCache[dataPath] = asset;
				}
				if (!this.StagnationMaterialEnabled)
				{
					return;
				}
				this.ApplyStagnationMaterial(asset);
			}, 100, "js_undefined");
		}

		// Token: 0x06047504 RID: 292100 RVA: 0x01222AD4 File Offset: 0x01220CD4
		[NullableContext(2)]
		private void ApplyStagnationMaterial(ItemMaterialControllerActorData asset)
		{
			if (this.StagnationMaterialEnabled && this.StagnationMaterialHandle == null)
			{
				AActor stagnationMaterialActor = this.StagnationMaterialActor;
				if (stagnationMaterialActor != null && stagnationMaterialActor.IsValid() && (asset != null && asset.IsValid()))
				{
					int num = ItemMaterialManager.Instance.AddMaterialData(this.StagnationMaterialActor, asset);
					if (num < 0)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.PathDrivenActor;
						ELogAuthor author = ELogAuthor.WRY;
						string message = "[WaterBoxTransportBehavior] 凝滞材质控制器挂载失败";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
						instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return;
					}
					this.StagnationMaterialHandle = new int?(num);
					return;
				}
			}
		}

		// Token: 0x06047505 RID: 292101 RVA: 0x01222B76 File Offset: 0x01220D76
		private void DisableStagnationMaterial()
		{
			if (this.StagnationMaterialHandle == null)
			{
				return;
			}
			ItemMaterialManager.Instance.DisableActorData(this.StagnationMaterialHandle.Value);
			this.StagnationMaterialHandle = null;
		}

		// Token: 0x06047506 RID: 292102 RVA: 0x01222BA8 File Offset: 0x01220DA8
		public void OnFinishing(IPathDrivenActorRuntimeData runtimeData, EPathDrivenActorFinishReason reason)
		{
		}

		// Token: 0x06047507 RID: 292103 RVA: 0x01222BAC File Offset: 0x01220DAC
		[NullableContext(0)]
		public UniTask<bool> OnTrackSwitched([Nullable(1)] IPathDrivenActorRuntimeData runtimeData, FTransformDouble fromTransform, FTransformDouble toTransform)
		{
			WaterBoxTransportBehavior.<OnTrackSwitched>d__28 <OnTrackSwitched>d__;
			<OnTrackSwitched>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnTrackSwitched>d__.<>4__this = this;
			<OnTrackSwitched>d__.runtimeData = runtimeData;
			<OnTrackSwitched>d__.fromTransform = fromTransform;
			<OnTrackSwitched>d__.toTransform = toTransform;
			<OnTrackSwitched>d__.<>1__state = -1;
			<OnTrackSwitched>d__.<>t__builder.Start<WaterBoxTransportBehavior.<OnTrackSwitched>d__28>(ref <OnTrackSwitched>d__);
			return <OnTrackSwitched>d__.<>t__builder.Task;
		}

		// Token: 0x06047508 RID: 292104 RVA: 0x01222C08 File Offset: 0x01220E08
		public void Cleanup(IPathDrivenActorRuntimeData runtimeData)
		{
			this.StopTrailEffect();
			this.StagnationMaterialEnabled = false;
			this.DisableStagnationMaterial();
			AActor actor = runtimeData.Actor;
			if (actor != null && actor.IsValid())
			{
				runtimeData.Actor.SetOwner(null);
			}
			this.StagnationMaterialActor = null;
			this.StagnationMaterialDataPath = "";
			this.TrailEffectPath = "";
			this.CollisionTriggerComponent = null;
		}

		// Token: 0x06047509 RID: 292105 RVA: 0x01222C6C File Offset: 0x01220E6C
		public void OnSpawnerStagnationChanged(IPathDrivenActorRuntimeData runtimeData, bool isStagnated)
		{
			this.SetTrailStagnated(isStagnated);
		}

		// Token: 0x0604750A RID: 292106 RVA: 0x01222C78 File Offset: 0x01220E78
		private unsafe void SpawnTrailEffect(IPathDrivenActorRuntimeData runtimeData, BP_WaterBox_PhantomBox_C waterBoxActor)
		{
			if (this.TrailEffectHandle != null || string.IsNullOrEmpty(this.TrailEffectPath))
			{
				return;
			}
			USceneComponent rootComponent = waterBoxActor.RootComponent;
			if (rootComponent == null || !rootComponent.IsValid())
			{
				return;
			}
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FVectorDouble fvectorDouble = rootComponent.D_K2_GetComponentLocation();
			FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble(ref fvectorDouble));
			int num = instance.SpawnEffect(world, ftransformDouble, this.TrailEffectPath, "[WaterBoxTransportBehavior] 拖尾特效", new EffectContext(new int?(runtimeData.OwnerEntity.Id), waterBoxActor, false), EEffectType.Scene, null, null, null, false, false);
			if (!EffectSystem.Instance.IsValid(num))
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.PathDrivenActor;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[WaterBoxTransportBehavior] 拖尾特效生成失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Path", this.TrailEffectPath);
				instance2.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(num);
			effectActor.K2_AttachToComponent(rootComponent, null, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false);
			FTransformDouble trailEffectRelativeTransform = waterBoxActor.TrailEffectRelativeTransform;
			effectActor.D_K2_SetActorRelativeTransform(trailEffectRelativeTransform, false, ref WorldGlobal.SweepHitResult, false);
			this.TrailEffectHandle = new int?(num);
		}

		// Token: 0x0604750B RID: 292107 RVA: 0x01222DC0 File Offset: 0x01220FC0
		private void SetTrailStagnated(bool isStagnated)
		{
			if (this.TrailStagnated == isStagnated)
			{
				return;
			}
			this.TrailStagnated = isStagnated;
			WaterBoxTransportBehavior.StagnatedTrailCount += (isStagnated ? 1 : -1);
			EffectSystem.Instance.SetAdditionTimeScaleEnable(ETimeScaleSourceType.ElementalField, WaterBoxTransportBehavior.StagnatedTrailCount > 0);
			if (this.TrailEffectHandle != null && EffectSystem.Instance.IsValid(this.TrailEffectHandle.Value))
			{
				EffectSystem.Instance.SetAdditionTimeScale(ETimeScaleSourceType.ElementalField, this.TrailEffectHandle.Value, !isStagnated);
			}
		}

		// Token: 0x0604750C RID: 292108 RVA: 0x01222E44 File Offset: 0x01221044
		private void StopTrailEffect()
		{
			this.SetTrailStagnated(false);
			if (this.TrailEffectHandle == null)
			{
				return;
			}
			if (EffectSystem.Instance.IsValid(this.TrailEffectHandle.Value))
			{
				EffectSystem.Instance.StopEffectById(this.TrailEffectHandle.Value, "[WaterBoxTransportBehavior] Cleanup", true, null);
			}
			this.TrailEffectHandle = null;
		}

		// Token: 0x0604750D RID: 292109 RVA: 0x01222EB0 File Offset: 0x012210B0
		private void AttachOwnerForHit(IPathDrivenActorRuntimeData runtimeData)
		{
			BaseActorComponent component = runtimeData.OwnerEntity.GetComponent<BaseActorComponent>();
			AActor aactor = (component != null) ? component.Owner : null;
			if (aactor == null || !aactor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PathDrivenActor;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[WaterBoxTransportBehavior] 找不到spawner实体Actor，箱子受击无法归属";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.OwnerPbDataId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			runtimeData.Actor.SetOwner(aactor);
		}

		// Token: 0x040257F7 RID: 153591
		private const string TRACK_SWITCH_TELEPORT_REASON = "WaterBoxTransportBehavior.TrackSwitchCarry";

		// Token: 0x040257F8 RID: 153592
		private static int StagnatedTrailCount;

		// Token: 0x040257F9 RID: 153593
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<string, ItemMaterialControllerActorData> _stagnationMaterialDataCache;

		// Token: 0x040257FA RID: 153594
		[Nullable(2)]
		private AActor StagnationMaterialActor;

		// Token: 0x040257FB RID: 153595
		private string StagnationMaterialDataPath = "";

		// Token: 0x040257FC RID: 153596
		private int? StagnationMaterialHandle;

		// Token: 0x040257FD RID: 153597
		private bool StagnationMaterialEnabled;

		// Token: 0x040257FE RID: 153598
		private string TrailEffectPath = "";

		// Token: 0x040257FF RID: 153599
		private int? TrailEffectHandle;

		// Token: 0x04025800 RID: 153600
		private bool TrailStagnated;

		// Token: 0x04025801 RID: 153601
		[Nullable(2)]
		private UBoxComponent CollisionTriggerComponent;

		// Token: 0x04025802 RID: 153602
		private bool GenerateOverlapEventsBeforeSpawn;

		// Token: 0x04025803 RID: 153603
		private readonly int? OwnerPbDataId;
	}
}
