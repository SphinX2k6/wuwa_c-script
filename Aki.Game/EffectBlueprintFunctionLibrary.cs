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

// Token: 0x02003481 RID: 13441
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/EffectBlueprintFunctionLibrary.EffectBlueprintFunctionLibrary_C")]
public class EffectBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D218 RID: 119320 RVA: 0x0081EB20 File Offset: 0x0081CD20
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

	// Token: 0x0601D219 RID: 119321 RVA: 0x0081EC7D File Offset: 0x0081CE7D
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void RecycleEffect(EffectViewComponent view)
	{
	}

	// Token: 0x0601D21A RID: 119322 RVA: 0x0081EC7F File Offset: 0x0081CE7F
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float AddDebugLineFromPlayer(FVector location, FLinearColor color, float width)
	{
		return (float)DebugDrawManager.AddDebugLineFromPlayer(global::Vector.Create(location), color, width);
	}

	// Token: 0x0601D21B RID: 119323 RVA: 0x0081EC94 File Offset: 0x0081CE94
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ClearDebugDraw()
	{
		DebugDrawManager.ClearDebugDraw();
	}

	// Token: 0x0601D21C RID: 119324 RVA: 0x0081EC9B File Offset: 0x0081CE9B
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool ValidateKuroAnimNotify(UKuroAnimNotify asset)
	{
		return asset.K2_ValidateAssets();
	}

	// Token: 0x0601D21D RID: 119325 RVA: 0x0081ECA3 File Offset: 0x0081CEA3
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool ValidateKuroAnimNotifyState(UKuroAnimNotifyState asset)
	{
		return asset.K2_ValidateAssets();
	}

	// Token: 0x0601D21E RID: 119326 RVA: 0x0081ECAB File Offset: 0x0081CEAB
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetVisualizeCharacterWaterEffectTrace(bool enable)
	{
		SceneCharacterInteraction.SetTraceDebug(enable);
	}

	// Token: 0x0601D21F RID: 119327 RVA: 0x0081ECB3 File Offset: 0x0081CEB3
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEffectSpawnLogEnabled(bool enabled)
	{
		EffectGlobal.Instance.EnableSpawnLog = enabled;
	}

	// Token: 0x0601D220 RID: 119328 RVA: 0x0081ECC0 File Offset: 0x0081CEC0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void BeginDebugDrawFoliageDetect(FLinearColor color, float width)
	{
		FoliageClusteredEffectManager.Instance.BeginDebugDraw(color, width);
	}

	// Token: 0x0601D221 RID: 119329 RVA: 0x0081ECCE File Offset: 0x0081CECE
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EndDebugDrawFoliageDetect()
	{
		FoliageClusteredEffectManager.Instance.EndDebugDraw();
	}

	// Token: 0x0601D222 RID: 119330 RVA: 0x0081ECDA File Offset: 0x0081CEDA
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void RefreshFoliageDetectConfig()
	{
		FoliageClusteredEffectManager.Instance.CacheFromConfig();
	}

	// Token: 0x0601D223 RID: 119331 RVA: 0x0081ECE6 File Offset: 0x0081CEE6
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEffectInPoolEnabled(bool enable)
	{
		EffectGlobal.Instance.AllowEffectInPool = enable;
	}

	// Token: 0x0601D224 RID: 119332 RVA: 0x0081ECF3 File Offset: 0x0081CEF3
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEffectOutPoolEnabled(bool enable)
	{
		EffectGlobal.Instance.AllowEffectOutPool = enable;
	}

	// Token: 0x0601D225 RID: 119333 RVA: 0x0081ED00 File Offset: 0x0081CF00
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EnableSceneObjectWaterEffectShowDebugTrace(bool enable)
	{
		EffectGlobal.Instance.SceneObjectWaterEffectShowDebugTrace = enable;
	}

	// Token: 0x0601D226 RID: 119334 RVA: 0x0081ED0D File Offset: 0x0081CF0D
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetTsWriteTimeToCollectionEnabled(bool enable)
	{
		if (Info.Instance.IsGameRunning())
		{
			RenderDataManager.Instance.SetWriteTime(enable);
		}
	}

	// Token: 0x0601D227 RID: 119335 RVA: 0x0081ED26 File Offset: 0x0081CF26
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EffectCgMode(bool enable)
	{
		EffectGlobal.Instance.CgMode = enable;
	}

	// Token: 0x0601D228 RID: 119336 RVA: 0x0081ED33 File Offset: 0x0081CF33
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static BP_ScreenEffectSystem_C GetScreenEffectSystem()
	{
		return ScreenEffectSystem.GetInstance();
	}

	// Token: 0x0601D229 RID: 119337 RVA: 0x0081ED3C File Offset: 0x0081CF3C
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

	// Token: 0x0601D22A RID: 119338 RVA: 0x0081ED8A File Offset: 0x0081CF8A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/EffectBlueprintFunctionLibrary.EffectBlueprintFunctionLibrary_C");
		}
		return EffectBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x0601D22B RID: 119339 RVA: 0x0081EDB0 File Offset: 0x0081CFB0
	public EffectBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(EffectBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D22C RID: 119340 RVA: 0x0081EDD8 File Offset: 0x0081CFD8
	[NullableContext(1)]
	public EffectBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D22D RID: 119341 RVA: 0x0081EE0B File Offset: 0x0081D00B
	protected EffectBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601D22E RID: 119342 RVA: 0x0081EE14 File Offset: 0x0081D014
	protected unsafe static void __CPPCALL_SetMaterialControllerDataSync_Implementation(EffectBlueprintFunctionLibrary.__SetMaterialControllerDataSync_FunctionParams* __Params)
	{
		string materialDataPath = FString.ToString((void*)(&__Params->materialDataPath));
		EffectBlueprintFunctionLibrary.SetMaterialControllerDataSync(__Params->entityId, materialDataPath, __Params->isGroup);
	}

	// Token: 0x0601D22F RID: 119343 RVA: 0x0081EE40 File Offset: 0x0081D040
	protected unsafe static void __CPPCALL_RecycleEffect_Implementation(EffectBlueprintFunctionLibrary.__RecycleEffect_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.RecycleEffect(BuiltinUtils.GetOrCreateUObjectByNativePointer<EffectViewComponent>(__Params->view));
	}

	// Token: 0x0601D230 RID: 119344 RVA: 0x0081EE52 File Offset: 0x0081D052
	protected unsafe static void __CPPCALL_AddDebugLineFromPlayer_Implementation(EffectBlueprintFunctionLibrary.__AddDebugLineFromPlayer_FunctionParams* __Params)
	{
		__Params->__Result = EffectBlueprintFunctionLibrary.AddDebugLineFromPlayer(__Params->location, __Params->color, __Params->width);
	}

	// Token: 0x0601D231 RID: 119345 RVA: 0x0081EE71 File Offset: 0x0081D071
	protected unsafe static void __CPPCALL_ClearDebugDraw_Implementation(EffectBlueprintFunctionLibrary.__ClearDebugDraw_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.ClearDebugDraw();
	}

	// Token: 0x0601D232 RID: 119346 RVA: 0x0081EE78 File Offset: 0x0081D078
	protected unsafe static void __CPPCALL_ValidateKuroAnimNotify_Implementation(EffectBlueprintFunctionLibrary.__ValidateKuroAnimNotify_FunctionParams* __Params)
	{
		UKuroAnimNotify orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroAnimNotify>(__Params->asset);
		__Params->__Result = EffectBlueprintFunctionLibrary.ValidateKuroAnimNotify(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601D233 RID: 119347 RVA: 0x0081EEA0 File Offset: 0x0081D0A0
	protected unsafe static void __CPPCALL_ValidateKuroAnimNotifyState_Implementation(EffectBlueprintFunctionLibrary.__ValidateKuroAnimNotifyState_FunctionParams* __Params)
	{
		UKuroAnimNotifyState orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroAnimNotifyState>(__Params->asset);
		__Params->__Result = EffectBlueprintFunctionLibrary.ValidateKuroAnimNotifyState(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601D234 RID: 119348 RVA: 0x0081EEC5 File Offset: 0x0081D0C5
	protected unsafe static void __CPPCALL_SetVisualizeCharacterWaterEffectTrace_Implementation(EffectBlueprintFunctionLibrary.__SetVisualizeCharacterWaterEffectTrace_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.SetVisualizeCharacterWaterEffectTrace(__Params->enable);
	}

	// Token: 0x0601D235 RID: 119349 RVA: 0x0081EED2 File Offset: 0x0081D0D2
	protected unsafe static void __CPPCALL_SetEffectSpawnLogEnabled_Implementation(EffectBlueprintFunctionLibrary.__SetEffectSpawnLogEnabled_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.SetEffectSpawnLogEnabled(__Params->enabled);
	}

	// Token: 0x0601D236 RID: 119350 RVA: 0x0081EEDF File Offset: 0x0081D0DF
	protected unsafe static void __CPPCALL_BeginDebugDrawFoliageDetect_Implementation(EffectBlueprintFunctionLibrary.__BeginDebugDrawFoliageDetect_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.BeginDebugDrawFoliageDetect(__Params->color, __Params->width);
	}

	// Token: 0x0601D237 RID: 119351 RVA: 0x0081EEF2 File Offset: 0x0081D0F2
	protected unsafe static void __CPPCALL_EndDebugDrawFoliageDetect_Implementation(EffectBlueprintFunctionLibrary.__EndDebugDrawFoliageDetect_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.EndDebugDrawFoliageDetect();
	}

	// Token: 0x0601D238 RID: 119352 RVA: 0x0081EEF9 File Offset: 0x0081D0F9
	protected unsafe static void __CPPCALL_RefreshFoliageDetectConfig_Implementation(EffectBlueprintFunctionLibrary.__RefreshFoliageDetectConfig_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.RefreshFoliageDetectConfig();
	}

	// Token: 0x0601D239 RID: 119353 RVA: 0x0081EF00 File Offset: 0x0081D100
	protected unsafe static void __CPPCALL_SetEffectInPoolEnabled_Implementation(EffectBlueprintFunctionLibrary.__SetEffectInPoolEnabled_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.SetEffectInPoolEnabled(__Params->enable);
	}

	// Token: 0x0601D23A RID: 119354 RVA: 0x0081EF0D File Offset: 0x0081D10D
	protected unsafe static void __CPPCALL_SetEffectOutPoolEnabled_Implementation(EffectBlueprintFunctionLibrary.__SetEffectOutPoolEnabled_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.SetEffectOutPoolEnabled(__Params->enable);
	}

	// Token: 0x0601D23B RID: 119355 RVA: 0x0081EF1A File Offset: 0x0081D11A
	protected unsafe static void __CPPCALL_EnableSceneObjectWaterEffectShowDebugTrace_Implementation(EffectBlueprintFunctionLibrary.__EnableSceneObjectWaterEffectShowDebugTrace_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.EnableSceneObjectWaterEffectShowDebugTrace(__Params->enable);
	}

	// Token: 0x0601D23C RID: 119356 RVA: 0x0081EF27 File Offset: 0x0081D127
	protected unsafe static void __CPPCALL_SetTsWriteTimeToCollectionEnabled_Implementation(EffectBlueprintFunctionLibrary.__SetTsWriteTimeToCollectionEnabled_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.SetTsWriteTimeToCollectionEnabled(__Params->enable);
	}

	// Token: 0x0601D23D RID: 119357 RVA: 0x0081EF34 File Offset: 0x0081D134
	protected unsafe static void __CPPCALL_EffectCgMode_Implementation(EffectBlueprintFunctionLibrary.__EffectCgMode_FunctionParams* __Params)
	{
		EffectBlueprintFunctionLibrary.EffectCgMode(__Params->enable);
	}

	// Token: 0x0601D23E RID: 119358 RVA: 0x0081EF41 File Offset: 0x0081D141
	protected unsafe static void __CPPCALL_GetScreenEffectSystem_Implementation(EffectBlueprintFunctionLibrary.__GetScreenEffectSystem_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		BP_ScreenEffectSystem_C screenEffectSystem = EffectBlueprintFunctionLibrary.GetScreenEffectSystem();
		ptr = ((screenEffectSystem != null) ? screenEffectSystem.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601D23F RID: 119359 RVA: 0x0081EF60 File Offset: 0x0081D160
	protected unsafe static void __CPPCALL_ChangeMaterialTextures_Implementation(EffectBlueprintFunctionLibrary.__ChangeMaterialTextures_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		string assetPath = FString.ToString((void*)(&__Params->assetPath));
		EffectBlueprintFunctionLibrary.ChangeMaterialTextures(orCreateUObjectByNativePointer, assetPath);
	}

	// Token: 0x0400E572 RID: 58738
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/EffectBlueprintFunctionLibrary.EffectBlueprintFunctionLibrary_C";

	// Token: 0x0400E573 RID: 58739
	private static IntPtr _ClassPtr;

	// Token: 0x0400E574 RID: 58740
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020097F7 RID: 38903
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetMaterialControllerDataSync_FunctionParams
	{
		// Token: 0x040307E9 RID: 198633
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040307EA RID: 198634
		[FieldOffset(8)]
		public FString materialDataPath;

		// Token: 0x040307EB RID: 198635
		[FieldOffset(24)]
		public bool isGroup;

		// Token: 0x040307EC RID: 198636
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020097F8 RID: 38904
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RecycleEffect_FunctionParams
	{
		// Token: 0x040307ED RID: 198637
		[FieldOffset(0)]
		public IntPtr view;

		// Token: 0x040307EE RID: 198638
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020097F9 RID: 38905
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __AddDebugLineFromPlayer_FunctionParams
	{
		// Token: 0x040307EF RID: 198639
		[FieldOffset(0)]
		public FVector location;

		// Token: 0x040307F0 RID: 198640
		[FieldOffset(12)]
		public FLinearColor color;

		// Token: 0x040307F1 RID: 198641
		[FieldOffset(28)]
		public float width;

		// Token: 0x040307F2 RID: 198642
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x040307F3 RID: 198643
		[FieldOffset(40)]
		public float __Result;
	}

	// Token: 0x020097FA RID: 38906
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ClearDebugDraw_FunctionParams
	{
		// Token: 0x040307F4 RID: 198644
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020097FB RID: 38907
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ValidateKuroAnimNotify_FunctionParams
	{
		// Token: 0x040307F5 RID: 198645
		[FieldOffset(0)]
		public IntPtr asset;

		// Token: 0x040307F6 RID: 198646
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040307F7 RID: 198647
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020097FC RID: 38908
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ValidateKuroAnimNotifyState_FunctionParams
	{
		// Token: 0x040307F8 RID: 198648
		[FieldOffset(0)]
		public IntPtr asset;

		// Token: 0x040307F9 RID: 198649
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040307FA RID: 198650
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020097FD RID: 38909
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetVisualizeCharacterWaterEffectTrace_FunctionParams
	{
		// Token: 0x040307FB RID: 198651
		[FieldOffset(0)]
		public bool enable;

		// Token: 0x040307FC RID: 198652
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020097FE RID: 38910
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEffectSpawnLogEnabled_FunctionParams
	{
		// Token: 0x040307FD RID: 198653
		[FieldOffset(0)]
		public bool enabled;

		// Token: 0x040307FE RID: 198654
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020097FF RID: 38911
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __BeginDebugDrawFoliageDetect_FunctionParams
	{
		// Token: 0x040307FF RID: 198655
		[FieldOffset(0)]
		public FLinearColor color;

		// Token: 0x04030800 RID: 198656
		[FieldOffset(16)]
		public float width;

		// Token: 0x04030801 RID: 198657
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009800 RID: 38912
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __EndDebugDrawFoliageDetect_FunctionParams
	{
		// Token: 0x04030802 RID: 198658
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009801 RID: 38913
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __RefreshFoliageDetectConfig_FunctionParams
	{
		// Token: 0x04030803 RID: 198659
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009802 RID: 38914
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEffectInPoolEnabled_FunctionParams
	{
		// Token: 0x04030804 RID: 198660
		[FieldOffset(0)]
		public bool enable;

		// Token: 0x04030805 RID: 198661
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009803 RID: 38915
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEffectOutPoolEnabled_FunctionParams
	{
		// Token: 0x04030806 RID: 198662
		[FieldOffset(0)]
		public bool enable;

		// Token: 0x04030807 RID: 198663
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009804 RID: 38916
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnableSceneObjectWaterEffectShowDebugTrace_FunctionParams
	{
		// Token: 0x04030808 RID: 198664
		[FieldOffset(0)]
		public bool enable;

		// Token: 0x04030809 RID: 198665
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009805 RID: 38917
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetTsWriteTimeToCollectionEnabled_FunctionParams
	{
		// Token: 0x0403080A RID: 198666
		[FieldOffset(0)]
		public bool enable;

		// Token: 0x0403080B RID: 198667
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009806 RID: 38918
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EffectCgMode_FunctionParams
	{
		// Token: 0x0403080C RID: 198668
		[FieldOffset(0)]
		public bool enable;

		// Token: 0x0403080D RID: 198669
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009807 RID: 38919
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetScreenEffectSystem_FunctionParams
	{
		// Token: 0x0403080E RID: 198670
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0403080F RID: 198671
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x02009808 RID: 38920
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ChangeMaterialTextures_FunctionParams
	{
		// Token: 0x04030810 RID: 198672
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x04030811 RID: 198673
		[FieldOffset(8)]
		public FString assetPath;

		// Token: 0x04030812 RID: 198674
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}
}
