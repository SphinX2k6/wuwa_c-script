using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect;
using CSharpScript.Core.Common;
using CSharpScript.Game.Render;
using CSharpScript.Game.Render.DebugDraw;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029F5 RID: 10741
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/EffectBlueprintFunctionLibrary.EffectBlueprintFunctionLibrary_C")]
public class EffectBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AF20 RID: 110368 RVA: 0x00845E20 File Offset: 0x00844020
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetMaterialControllerDataSync(int entityId, string materialDataPath, bool isGroup)
	{
		EffectBlueprintFunctionLibrary.<>c__DisplayClass0_0 CS$<>8__locals1 = new EffectBlueprintFunctionLibrary.<>c__DisplayClass0_0();
		CS$<>8__locals1.materialDataPath = materialDataPath;
		if (CS$<>8__locals1.materialDataPath.Length <= 0 || CS$<>8__locals1.materialDataPath == "None")
		{
			return;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
		WorldEntity worldEntity = (entityById != null) ? entityById.Entity : null;
		EffectBlueprintFunctionLibrary.<>c__DisplayClass0_0 CS$<>8__locals2 = CS$<>8__locals1;
		CharRenderingComponent component;
		if (worldEntity == null)
		{
			component = null;
		}
		else
		{
			CharacterActorComponent component2 = worldEntity.GetComponent<CharacterActorComponent>();
			if (component2 == null)
			{
				component = null;
			}
			else
			{
				TsBaseCharacter actor = component2.Actor;
				component = ((actor != null) ? actor.CharRenderingComponent : null);
			}
		}
		CS$<>8__locals2.component = component;
		if (CS$<>8__locals1.component == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "无法找到角色渲染组件";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (isGroup)
		{
			ResourceSystem.Instance.LoadAsync<PD_CharacterControllerDataGroup_C>(CS$<>8__locals1.materialDataPath, delegate([Nullable(2)] PD_CharacterControllerDataGroup_C asset, string _)
			{
				if (asset == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Battle;
					ELogAuthor author2 = ELogAuthor.YZ;
					string message2 = "无法找到材质效果组";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("materialDataPath", CS$<>8__locals1.materialDataPath);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				CharRenderingComponent component3 = CS$<>8__locals1.component;
				if (component3 == null)
				{
					return;
				}
				component3.AddMaterialControllerDataGroup(asset);
			}, 100, "js_undefined");
		}
		else
		{
			ResourceSystem.Instance.LoadAsync<PD_CharacterControllerData_C>(CS$<>8__locals1.materialDataPath, delegate([Nullable(2)] PD_CharacterControllerData_C asset, string _)
			{
				if (asset == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Battle;
					ELogAuthor author2 = ELogAuthor.YZ;
					string message2 = "无法找到材质效果";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("materialDataPath", CS$<>8__locals1.materialDataPath);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				CharRenderingComponent component3 = CS$<>8__locals1.component;
				if (component3 == null)
				{
					return;
				}
				component3.AddMaterialControllerData(asset);
			}, 100, "js_undefined");
		}
		MaterialPush materialPush = MaterialPush.Create();
		materialPush.MaterialInfo = new MaterialInfo();
		materialPush.MaterialInfo.AssetName = CS$<>8__locals1.materialDataPath;
		materialPush.MaterialInfo.IsGroup = isGroup;
		CombatNet.Instance.Send(EPushMessageId.MaterialPush, worldEntity, materialPush, null, null, null);
	}

	// Token: 0x0601AF21 RID: 110369 RVA: 0x00845F7D File Offset: 0x0084417D
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void RecycleEffect(EffectViewComponent view)
	{
	}

	// Token: 0x0601AF22 RID: 110370 RVA: 0x00845F7F File Offset: 0x0084417F
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float AddDebugLineFromPlayer(FVector location, FLinearColor color, float width)
	{
		return (float)DebugDrawManager.AddDebugLineFromPlayer(global::Vector.Create(location), color, width);
	}

	// Token: 0x0601AF23 RID: 110371 RVA: 0x00845F94 File Offset: 0x00844194
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ClearDebugDraw()
	{
		DebugDrawManager.ClearDebugDraw();
	}

	// Token: 0x0601AF24 RID: 110372 RVA: 0x00845F9B File Offset: 0x0084419B
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool ValidateKuroAnimNotify(UKuroAnimNotify asset)
	{
		return asset.K2_ValidateAssets();
	}

	// Token: 0x0601AF25 RID: 110373 RVA: 0x00845FA3 File Offset: 0x008441A3
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool ValidateKuroAnimNotifyState(UKuroAnimNotifyState asset)
	{
		return asset.K2_ValidateAssets();
	}

	// Token: 0x0601AF26 RID: 110374 RVA: 0x00845FAB File Offset: 0x008441AB
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetVisualizeCharacterWaterEffectTrace(bool enable)
	{
		SceneCharacterInteraction.SetTraceDebug(enable);
	}

	// Token: 0x0601AF27 RID: 110375 RVA: 0x00845FB3 File Offset: 0x008441B3
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEffectSpawnLogEnabled(bool enabled)
	{
		EffectGlobal.Instance.EnableSpawnLog = enabled;
	}

	// Token: 0x0601AF28 RID: 110376 RVA: 0x00845FC0 File Offset: 0x008441C0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void BeginDebugDrawFoliageDetect(FLinearColor color, float width)
	{
		FoliageClusteredEffectManager.Instance.BeginDebugDraw(color, width);
	}

	// Token: 0x0601AF29 RID: 110377 RVA: 0x00845FCE File Offset: 0x008441CE
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EndDebugDrawFoliageDetect()
	{
		FoliageClusteredEffectManager.Instance.EndDebugDraw();
	}

	// Token: 0x0601AF2A RID: 110378 RVA: 0x00845FDA File Offset: 0x008441DA
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void RefreshFoliageDetectConfig()
	{
		FoliageClusteredEffectManager.Instance.CacheFromConfig();
	}

	// Token: 0x0601AF2B RID: 110379 RVA: 0x00845FE6 File Offset: 0x008441E6
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEffectInPoolEnabled(bool enable)
	{
		EffectGlobal.Instance.AllowEffectInPool = enable;
	}

	// Token: 0x0601AF2C RID: 110380 RVA: 0x00845FF3 File Offset: 0x008441F3
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEffectOutPoolEnabled(bool enable)
	{
		EffectGlobal.Instance.AllowEffectOutPool = enable;
	}

	// Token: 0x0601AF2D RID: 110381 RVA: 0x00846000 File Offset: 0x00844200
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EnableSceneObjectWaterEffectShowDebugTrace(bool enable)
	{
		EffectGlobal.Instance.SceneObjectWaterEffectShowDebugTrace = enable;
	}

	// Token: 0x0601AF2E RID: 110382 RVA: 0x0084600D File Offset: 0x0084420D
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetTsWriteTimeToCollectionEnabled(bool enable)
	{
		if (Info.Instance.IsGameRunning())
		{
			RenderDataManager.Instance.SetWriteTime(enable);
		}
	}

	// Token: 0x0601AF2F RID: 110383 RVA: 0x00846026 File Offset: 0x00844226
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EffectCgMode(bool enable)
	{
		EffectGlobal.Instance.CgMode = enable;
	}

	// Token: 0x0601AF30 RID: 110384 RVA: 0x00846033 File Offset: 0x00844233
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static BP_ScreenEffectSystem_C GetScreenEffectSystem()
	{
		return ScreenEffectSystem.GetInstance();
	}

	// Token: 0x0601AF31 RID: 110385 RVA: 0x0084603C File Offset: 0x0084423C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static void ChangeMaterialTextures([Nullable(2)] AActor actor, string assetPath)
	{
		if (actor == null)
		{
			return;
		}
		ResourceSystem.Instance.LoadAsync<UKuroChangeMaterialsTextures>(assetPath, delegate([Nullable(2)] UKuroChangeMaterialsTextures asset, string _)
		{
			if (asset == null || !asset.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.LSY;
				string message = "ChangeMaterialTextures失败，因为asset无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Path", assetPath);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("actor", actor);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			UKuroChangeSkeletalMaterialsComponent ukuroChangeSkeletalMaterialsComponent = actor.GetComponentByClass(UKuroChangeSkeletalMaterialsComponent.StaticClass()) as UKuroChangeSkeletalMaterialsComponent;
			if (ukuroChangeSkeletalMaterialsComponent == null)
			{
				AActor actor2 = actor;
				TSubclassOf<UActorComponent> @class = UKuroChangeSkeletalMaterialsComponent.StaticClass();
				bool bManualAttachment = false;
				FTransform ftransform = new FTransform();
				ukuroChangeSkeletalMaterialsComponent = (actor2.AddComponentByClass(@class, bManualAttachment, ftransform, false, default(FName)) as UKuroChangeSkeletalMaterialsComponent);
			}
			ukuroChangeSkeletalMaterialsComponent.ChangeMaterialsWithDataAsset(asset);
		}, 100, "js_undefined");
	}

	// Token: 0x0601AF32 RID: 110386 RVA: 0x0084608A File Offset: 0x0084428A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/EffectBlueprintFunctionLibrary.EffectBlueprintFunctionLibrary_C");
		}
		return EffectBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x0601AF33 RID: 110387 RVA: 0x008460B0 File Offset: 0x008442B0
	public EffectBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(EffectBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AF34 RID: 110388 RVA: 0x008460D8 File Offset: 0x008442D8
	[NullableContext(1)]
	public EffectBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AF35 RID: 110389 RVA: 0x0084610B File Offset: 0x0084430B
	protected EffectBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601AF36 RID: 110390 RVA: 0x00846114 File Offset: 0x00844314
	protected unsafe static void __CPPCALL_SetMaterialControllerDataSync_Implementation(EffectBlueprintFunctionLibrary.__SetMaterialControllerDataSync_FunctionParams* __Params)
	{
		string materialDataPath = FString.ToString((void*)(&__Params->materialDataPath));
		EffectBlueprintFunctionLibrary.SetMaterialControllerDataSync(__Params->entityId, materialDataPath, __Params->isGroup);
	}

	// Token: 0x0601AF37 RID: 110391 RVA: 0x00846140 File Offset: 0x00844340
	protected unsafe static void __CPPCALL_RecycleEffect_Implementation(EffectBlueprintFunctionLibrary.__RecycleEffect_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.RecycleEffect(BuiltinUtils.GetOrCreateUObjectByNativePointer<EffectViewComponent>(__Params->view));
	}

	// Token: 0x0601AF38 RID: 110392 RVA: 0x00846152 File Offset: 0x00844352
	protected unsafe static void __CPPCALL_AddDebugLineFromPlayer_Implementation(EffectBlueprintFunctionLibrary.__AddDebugLineFromPlayer_FunctionParams* __Params)
	{
		__Params->__Result = EffectBlueprintFunctionLibrary.AddDebugLineFromPlayer(__Params->location, __Params->color, __Params->width);
	}

	// Token: 0x0601AF39 RID: 110393 RVA: 0x00846171 File Offset: 0x00844371
	protected unsafe static void __CPPCALL_ClearDebugDraw_Implementation(EffectBlueprintFunctionLibrary.__ClearDebugDraw_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.ClearDebugDraw();
	}

	// Token: 0x0601AF3A RID: 110394 RVA: 0x00846178 File Offset: 0x00844378
	protected unsafe static void __CPPCALL_ValidateKuroAnimNotify_Implementation(EffectBlueprintFunctionLibrary.__ValidateKuroAnimNotify_FunctionParams* __Params)
	{
		UKuroAnimNotify orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroAnimNotify>(__Params->asset);
		__Params->__Result = EffectBlueprintFunctionLibrary.ValidateKuroAnimNotify(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601AF3B RID: 110395 RVA: 0x008461A0 File Offset: 0x008443A0
	protected unsafe static void __CPPCALL_ValidateKuroAnimNotifyState_Implementation(EffectBlueprintFunctionLibrary.__ValidateKuroAnimNotifyState_FunctionParams* __Params)
	{
		UKuroAnimNotifyState orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroAnimNotifyState>(__Params->asset);
		__Params->__Result = EffectBlueprintFunctionLibrary.ValidateKuroAnimNotifyState(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601AF3C RID: 110396 RVA: 0x008461C5 File Offset: 0x008443C5
	protected unsafe static void __CPPCALL_SetVisualizeCharacterWaterEffectTrace_Implementation(EffectBlueprintFunctionLibrary.__SetVisualizeCharacterWaterEffectTrace_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.SetVisualizeCharacterWaterEffectTrace(__Params->enable);
	}

	// Token: 0x0601AF3D RID: 110397 RVA: 0x008461D2 File Offset: 0x008443D2
	protected unsafe static void __CPPCALL_SetEffectSpawnLogEnabled_Implementation(EffectBlueprintFunctionLibrary.__SetEffectSpawnLogEnabled_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.SetEffectSpawnLogEnabled(__Params->enabled);
	}

	// Token: 0x0601AF3E RID: 110398 RVA: 0x008461DF File Offset: 0x008443DF
	protected unsafe static void __CPPCALL_BeginDebugDrawFoliageDetect_Implementation(EffectBlueprintFunctionLibrary.__BeginDebugDrawFoliageDetect_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.BeginDebugDrawFoliageDetect(__Params->color, __Params->width);
	}

	// Token: 0x0601AF3F RID: 110399 RVA: 0x008461F2 File Offset: 0x008443F2
	protected unsafe static void __CPPCALL_EndDebugDrawFoliageDetect_Implementation(EffectBlueprintFunctionLibrary.__EndDebugDrawFoliageDetect_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.EndDebugDrawFoliageDetect();
	}

	// Token: 0x0601AF40 RID: 110400 RVA: 0x008461F9 File Offset: 0x008443F9
	protected unsafe static void __CPPCALL_RefreshFoliageDetectConfig_Implementation(EffectBlueprintFunctionLibrary.__RefreshFoliageDetectConfig_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.RefreshFoliageDetectConfig();
	}

	// Token: 0x0601AF41 RID: 110401 RVA: 0x00846200 File Offset: 0x00844400
	protected unsafe static void __CPPCALL_SetEffectInPoolEnabled_Implementation(EffectBlueprintFunctionLibrary.__SetEffectInPoolEnabled_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.SetEffectInPoolEnabled(__Params->enable);
	}

	// Token: 0x0601AF42 RID: 110402 RVA: 0x0084620D File Offset: 0x0084440D
	protected unsafe static void __CPPCALL_SetEffectOutPoolEnabled_Implementation(EffectBlueprintFunctionLibrary.__SetEffectOutPoolEnabled_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.SetEffectOutPoolEnabled(__Params->enable);
	}

	// Token: 0x0601AF43 RID: 110403 RVA: 0x0084621A File Offset: 0x0084441A
	protected unsafe static void __CPPCALL_EnableSceneObjectWaterEffectShowDebugTrace_Implementation(EffectBlueprintFunctionLibrary.__EnableSceneObjectWaterEffectShowDebugTrace_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.EnableSceneObjectWaterEffectShowDebugTrace(__Params->enable);
	}

	// Token: 0x0601AF44 RID: 110404 RVA: 0x00846227 File Offset: 0x00844427
	protected unsafe static void __CPPCALL_SetTsWriteTimeToCollectionEnabled_Implementation(EffectBlueprintFunctionLibrary.__SetTsWriteTimeToCollectionEnabled_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.SetTsWriteTimeToCollectionEnabled(__Params->enable);
	}

	// Token: 0x0601AF45 RID: 110405 RVA: 0x00846234 File Offset: 0x00844434
	protected unsafe static void __CPPCALL_EffectCgMode_Implementation(EffectBlueprintFunctionLibrary.__EffectCgMode_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.EffectCgMode(__Params->enable);
	}

	// Token: 0x0601AF46 RID: 110406 RVA: 0x00846241 File Offset: 0x00844441
	protected unsafe static void __CPPCALL_GetScreenEffectSystem_Implementation(EffectBlueprintFunctionLibrary.__GetScreenEffectSystem_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		BP_ScreenEffectSystem_C screenEffectSystem = EffectBlueprintFunctionLibrary.GetScreenEffectSystem();
		ptr = ((screenEffectSystem != null) ? screenEffectSystem.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601AF47 RID: 110407 RVA: 0x00846260 File Offset: 0x00844460
	protected unsafe static void __CPPCALL_ChangeMaterialTextures_Implementation(EffectBlueprintFunctionLibrary.__ChangeMaterialTextures_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		string assetPath = FString.ToString((void*)(&__Params->assetPath));
		EffectBlueprintFunctionLibrary.ChangeMaterialTextures(orCreateUObjectByNativePointer, assetPath);
	}

	// Token: 0x0400EA2A RID: 59946
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/EffectBlueprintFunctionLibrary.EffectBlueprintFunctionLibrary_C";

	// Token: 0x0400EA2B RID: 59947
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA2C RID: 59948
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02008A1A RID: 35354
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetMaterialControllerDataSync_FunctionParams
	{
		// Token: 0x0402BE76 RID: 179830
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402BE77 RID: 179831
		[FieldOffset(8)]
		public FString materialDataPath;

		// Token: 0x0402BE78 RID: 179832
		[FieldOffset(24)]
		public bool isGroup;

		// Token: 0x0402BE79 RID: 179833
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A1B RID: 35355
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RecycleEffect_FunctionParams
	{
		// Token: 0x0402BE7A RID: 179834
		[FieldOffset(0)]
		public IntPtr view;

		// Token: 0x0402BE7B RID: 179835
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A1C RID: 35356
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __AddDebugLineFromPlayer_FunctionParams
	{
		// Token: 0x0402BE7C RID: 179836
		[FieldOffset(0)]
		public FVector location;

		// Token: 0x0402BE7D RID: 179837
		[FieldOffset(12)]
		public FLinearColor color;

		// Token: 0x0402BE7E RID: 179838
		[FieldOffset(28)]
		public float width;

		// Token: 0x0402BE7F RID: 179839
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x0402BE80 RID: 179840
		[FieldOffset(40)]
		public float __Result;
	}

	// Token: 0x02008A1D RID: 35357
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ClearDebugDraw_FunctionParams
	{
		// Token: 0x0402BE81 RID: 179841
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A1E RID: 35358
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ValidateKuroAnimNotify_FunctionParams
	{
		// Token: 0x0402BE82 RID: 179842
		[FieldOffset(0)]
		public IntPtr asset;

		// Token: 0x0402BE83 RID: 179843
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402BE84 RID: 179844
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008A1F RID: 35359
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ValidateKuroAnimNotifyState_FunctionParams
	{
		// Token: 0x0402BE85 RID: 179845
		[FieldOffset(0)]
		public IntPtr asset;

		// Token: 0x0402BE86 RID: 179846
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402BE87 RID: 179847
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008A20 RID: 35360
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetVisualizeCharacterWaterEffectTrace_FunctionParams
	{
		// Token: 0x0402BE88 RID: 179848
		[FieldOffset(0)]
		public bool enable;

		// Token: 0x0402BE89 RID: 179849
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A21 RID: 35361
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEffectSpawnLogEnabled_FunctionParams
	{
		// Token: 0x0402BE8A RID: 179850
		[FieldOffset(0)]
		public bool enabled;

		// Token: 0x0402BE8B RID: 179851
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A22 RID: 35362
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __BeginDebugDrawFoliageDetect_FunctionParams
	{
		// Token: 0x0402BE8C RID: 179852
		[FieldOffset(0)]
		public FLinearColor color;

		// Token: 0x0402BE8D RID: 179853
		[FieldOffset(16)]
		public float width;

		// Token: 0x0402BE8E RID: 179854
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A23 RID: 35363
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __EndDebugDrawFoliageDetect_FunctionParams
	{
		// Token: 0x0402BE8F RID: 179855
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A24 RID: 35364
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __RefreshFoliageDetectConfig_FunctionParams
	{
		// Token: 0x0402BE90 RID: 179856
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A25 RID: 35365
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEffectInPoolEnabled_FunctionParams
	{
		// Token: 0x0402BE91 RID: 179857
		[FieldOffset(0)]
		public bool enable;

		// Token: 0x0402BE92 RID: 179858
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A26 RID: 35366
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEffectOutPoolEnabled_FunctionParams
	{
		// Token: 0x0402BE93 RID: 179859
		[FieldOffset(0)]
		public bool enable;

		// Token: 0x0402BE94 RID: 179860
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A27 RID: 35367
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnableSceneObjectWaterEffectShowDebugTrace_FunctionParams
	{
		// Token: 0x0402BE95 RID: 179861
		[FieldOffset(0)]
		public bool enable;

		// Token: 0x0402BE96 RID: 179862
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A28 RID: 35368
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetTsWriteTimeToCollectionEnabled_FunctionParams
	{
		// Token: 0x0402BE97 RID: 179863
		[FieldOffset(0)]
		public bool enable;

		// Token: 0x0402BE98 RID: 179864
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A29 RID: 35369
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EffectCgMode_FunctionParams
	{
		// Token: 0x0402BE99 RID: 179865
		[FieldOffset(0)]
		public bool enable;

		// Token: 0x0402BE9A RID: 179866
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A2A RID: 35370
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetScreenEffectSystem_FunctionParams
	{
		// Token: 0x0402BE9B RID: 179867
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402BE9C RID: 179868
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x02008A2B RID: 35371
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ChangeMaterialTextures_FunctionParams
	{
		// Token: 0x0402BE9D RID: 179869
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x0402BE9E RID: 179870
		[FieldOffset(8)]
		public FString assetPath;

		// Token: 0x0402BE9F RID: 179871
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}
}
