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
	// Token: 0x02006288 RID: 25224
	[NullableContext(1)]
	[Nullable(0)]
	public class WaterBoxTransportBehavior : IPathDrivenActorBehavior, IStaticVariableResetter
	{
		// Token: 0x0603CDFB RID: 249339 RVA: 0x0117C613 File Offset: 0x0117A813
		static WaterBoxTransportBehavior()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WaterBoxTransportBehavior.CreateStaticDefaultValue), new Action(WaterBoxTransportBehavior.ResetStaticDefaultValue));
		}

		// Token: 0x0603CDFC RID: 249340 RVA: 0x0117C632 File Offset: 0x0117A832
		public static void CreateStaticDefaultValue()
		{
			WaterBoxTransportBehavior._stagnationMaterialDataCache = new Dictionary<string, ItemMaterialControllerActorData>();
		}

		// Token: 0x0603CDFD RID: 249341 RVA: 0x0117C63E File Offset: 0x0117A83E
		public static void ResetStaticDefaultValue()
		{
			WaterBoxTransportBehavior.StagnatedTrailCount = 0;
			WaterBoxTransportBehavior._stagnationMaterialDataCache = null;
		}

		// Token: 0x17007344 RID: 29508
		// (get) Token: 0x0603CDFE RID: 249342 RVA: 0x0117C64C File Offset: 0x0117A84C
		private static Dictionary<string, ItemMaterialControllerActorData> StagnationMaterialDataCache
		{
			get
			{
				return WaterBoxTransportBehavior._stagnationMaterialDataCache;
			}
		}

		// Token: 0x0603CDFF RID: 249343 RVA: 0x0117C653 File Offset: 0x0117A853
		public WaterBoxTransportBehavior(int? ownerPbDataId)
		{
			this.OwnerPbDataId = ownerPbDataId;
		}

		// Token: 0x0603CE00 RID: 249344 RVA: 0x0117C678 File Offset: 0x0117A878
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

		// Token: 0x0603CE01 RID: 249345 RVA: 0x0117C815 File Offset: 0x0117AA15
		public void PrepareCollisionBeforeSpawn(IPathDrivenActorRuntimeData runtimeData)
		{
			UBoxComponent collisionTriggerComponent = this.CollisionTriggerComponent;
			if (collisionTriggerComponent == null)
			{
				return;
			}
			collisionTriggerComponent.SetGenerateOverlapEvents(false);
		}

		// Token: 0x0603CE02 RID: 249346 RVA: 0x0117C828 File Offset: 0x0117AA28
		public void RestoreCollisionAfterSpawn(IPathDrivenActorRuntimeData runtimeData)
		{
			UBoxComponent collisionTriggerComponent = this.CollisionTriggerComponent;
			if (collisionTriggerComponent == null || !collisionTriggerComponent.IsValid())
			{
				return;
			}
			collisionTriggerComponent.SetGenerateOverlapEvents(this.GenerateOverlapEventsBeforeSpawn);
		}

		// Token: 0x0603CE03 RID: 249347 RVA: 0x0117C85A File Offset: 0x0117AA5A
		public void ClearCollisionBeforeRecycle(IPathDrivenActorRuntimeData runtimeData)
		{
			UBoxComponent collisionTriggerComponent = this.CollisionTriggerComponent;
			if (collisionTriggerComponent == null)
			{
				return;
			}
			collisionTriggerComponent.SetGenerateOverlapEvents(false);
		}

		// Token: 0x0603CE04 RID: 249348 RVA: 0x0117C86D File Offset: 0x0117AA6D
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

		// Token: 0x0603CE05 RID: 249349 RVA: 0x0117C888 File Offset: 0x0117AA88
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

		// Token: 0x0603CE06 RID: 249350 RVA: 0x0117C908 File Offset: 0x0117AB08
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

		// Token: 0x0603CE07 RID: 249351 RVA: 0x0117C9AA File Offset: 0x0117ABAA
		private void DisableStagnationMaterial()
		{
			if (this.StagnationMaterialHandle == null)
			{
				return;
			}
			ItemMaterialManager.Instance.DisableActorData(this.StagnationMaterialHandle.Value);
			this.StagnationMaterialHandle = null;
		}

		// Token: 0x0603CE08 RID: 249352 RVA: 0x0117C9DC File Offset: 0x0117ABDC
		public void OnFinishing(IPathDrivenActorRuntimeData runtimeData, EPathDrivenActorFinishReason reason)
		{
		}

		// Token: 0x0603CE09 RID: 249353 RVA: 0x0117C9E0 File Offset: 0x0117ABE0
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

		// Token: 0x0603CE0A RID: 249354 RVA: 0x0117CA3C File Offset: 0x0117AC3C
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

		// Token: 0x0603CE0B RID: 249355 RVA: 0x0117CAA0 File Offset: 0x0117ACA0
		public void OnSpawnerStagnationChanged(IPathDrivenActorRuntimeData runtimeData, bool isStagnated)
		{
			this.SetTrailStagnated(isStagnated);
		}

		// Token: 0x0603CE0C RID: 249356 RVA: 0x0117CAAC File Offset: 0x0117ACAC
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

		// Token: 0x0603CE0D RID: 249357 RVA: 0x0117CBF4 File Offset: 0x0117ADF4
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

		// Token: 0x0603CE0E RID: 249358 RVA: 0x0117CC78 File Offset: 0x0117AE78
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

		// Token: 0x0603CE0F RID: 249359 RVA: 0x0117CCE4 File Offset: 0x0117AEE4
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

		// Token: 0x04020466 RID: 132198
		private const string TRACK_SWITCH_TELEPORT_REASON = "WaterBoxTransportBehavior.TrackSwitchCarry";

		// Token: 0x04020467 RID: 132199
		private static int StagnatedTrailCount;

		// Token: 0x04020468 RID: 132200
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<string, ItemMaterialControllerActorData> _stagnationMaterialDataCache;

		// Token: 0x04020469 RID: 132201
		[Nullable(2)]
		private AActor StagnationMaterialActor;

		// Token: 0x0402046A RID: 132202
		private string StagnationMaterialDataPath = "";

		// Token: 0x0402046B RID: 132203
		private int? StagnationMaterialHandle;

		// Token: 0x0402046C RID: 132204
		private bool StagnationMaterialEnabled;

		// Token: 0x0402046D RID: 132205
		private string TrailEffectPath = "";

		// Token: 0x0402046E RID: 132206
		private int? TrailEffectHandle;

		// Token: 0x0402046F RID: 132207
		private bool TrailStagnated;

		// Token: 0x04020470 RID: 132208
		[Nullable(2)]
		private UBoxComponent CollisionTriggerComponent;

		// Token: 0x04020471 RID: 132209
		private bool GenerateOverlapEventsBeforeSpawn;

		// Token: 0x04020472 RID: 132210
		private readonly int? OwnerPbDataId;
	}
}
