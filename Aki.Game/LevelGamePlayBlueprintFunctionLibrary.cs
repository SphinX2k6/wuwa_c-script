using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.Module.Scan;
using CSharpScript.Game.Render;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000EE1 RID: 3809
[UClass("/Game/Aki/TypeScript/Game/LevelGamePlay/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGamePlayBlueprintFunctionLibrary.LevelGamePlayBlueprintFunctionLibrary_C")]
public class LevelGamePlayBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06005F16 RID: 24342 RVA: 0x0011CB42 File Offset: 0x0011AD42
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool ApplyScanEffect(AActor inActor, int type)
	{
		return LevelGamePlayController.Instance.HandleScanResponse(inActor, type);
	}

	// Token: 0x06005F17 RID: 24343 RVA: 0x0011CB50 File Offset: 0x0011AD50
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ClearAllScanEffects()
	{
		LevelGamePlayController.Instance.HandleClearAllScanEffect();
	}

	// Token: 0x06005F18 RID: 24344 RVA: 0x0011CB5C File Offset: 0x0011AD5C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SceneInteractionBind(AActor actor, string seqName, string eventName)
	{
		SceneInteractionManager.Get().EmitActor(actor, seqName, eventName);
	}

	// Token: 0x06005F19 RID: 24345 RVA: 0x0011CB6B File Offset: 0x0011AD6B
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int GetScanMaxDistance()
	{
		LevelGamePlayConfig instance = LevelGamePlayConfig.Instance;
		if (instance == null)
		{
			return 0;
		}
		return instance.ScanMaxDistance;
	}

	// Token: 0x06005F1A RID: 24346 RVA: 0x0011CB7D File Offset: 0x0011AD7D
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int GetScanInteractionEffectMaxDistance()
	{
		LevelGamePlayConfig instance = LevelGamePlayConfig.Instance;
		if (instance == null)
		{
			return 0;
		}
		return instance.ScanShowInteractionEffectMaxDistance;
	}

	// Token: 0x06005F1B RID: 24347 RVA: 0x0011CB90 File Offset: 0x0011AD90
	[NullableContext(1)]
	private static FKuroGeometryGeneralPolygonList GetPolygonListFromSplines(TArray<USplineComponent> splines)
	{
		TArray<FKuroGeometrySimplePolygon> tarray = new TArray<FKuroGeometrySimplePolygon>();
		for (int i = 0; i < splines.Num(); i++)
		{
			USplineComponent usplineComponent = splines.Get(i);
			if (usplineComponent != null && usplineComponent.IsValid())
			{
				FKuroGeometrySimplePolygon value = new FKuroGeometrySimplePolygon();
				UKuroSimplePolygonLibrary.SampleSplineToPolygon(usplineComponent, ref value, new FKuroSplineSamplingOptions
				{
					SampleSpacing = EKuroMathSampleSpacing.OriginPoints
				});
				tarray.Add(value);
			}
		}
		return UKuroPolygonListLibrary.CreatePolygonListFromSimplePolygons(tarray);
	}

	// Token: 0x06005F1C RID: 24348 RVA: 0x0011CBF4 File Offset: 0x0011ADF4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FKuroGeometryGeneralPolygonList PolygonsOpenPathsDifferenceViaSplines(ref TArray<USplineComponent> subjects, ref TArray<USplineComponent> openPaths, float strokeWidth, EJoinType joinType, EEndType endType)
	{
		FKuroGeometryGeneralPolygonList polygonListFromSplines = LevelGamePlayBlueprintFunctionLibrary.GetPolygonListFromSplines(subjects);
		FKuroGeometryGeneralPolygonList polygonListFromSplines2 = LevelGamePlayBlueprintFunctionLibrary.GetPolygonListFromSplines(openPaths);
		return UKuroPolygonListLibrary.PolygonsOpenPathsDifference(polygonListFromSplines, polygonListFromSplines2, (double)strokeWidth, joinType, endType);
	}

	// Token: 0x06005F1D RID: 24349 RVA: 0x0011CC1B File Offset: 0x0011AE1B
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FKuroGeometryGeneralPolygonList DifferenceSelectedActorsSplines()
	{
		return new FKuroGeometryGeneralPolygonList();
	}

	// Token: 0x06005F1E RID: 24350 RVA: 0x0011CC22 File Offset: 0x0011AE22
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool UseNewScanSystem()
	{
		return LevelGamePlayController.Instance.UseNewScanSystem;
	}

	// Token: 0x06005F1F RID: 24351 RVA: 0x0011CC2E File Offset: 0x0011AE2E
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StartScan()
	{
		ScanController.Instance.StartScan();
	}

	// Token: 0x06005F20 RID: 24352 RVA: 0x0011CC3A File Offset: 0x0011AE3A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LevelGamePlayBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGamePlayBlueprintFunctionLibrary.LevelGamePlayBlueprintFunctionLibrary_C");
		}
		return LevelGamePlayBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06005F21 RID: 24353 RVA: 0x0011CC60 File Offset: 0x0011AE60
	public LevelGamePlayBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(LevelGamePlayBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06005F22 RID: 24354 RVA: 0x0011CC88 File Offset: 0x0011AE88
	[NullableContext(1)]
	public LevelGamePlayBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGamePlayBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06005F23 RID: 24355 RVA: 0x0011CCBB File Offset: 0x0011AEBB
	protected LevelGamePlayBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06005F24 RID: 24356 RVA: 0x0011CCC4 File Offset: 0x0011AEC4
	protected unsafe static void __CPPCALL_ApplyScanEffect_Implementation(LevelGamePlayBlueprintFunctionLibrary.__ApplyScanEffect_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inActor);
		__Params->__Result = LevelGamePlayBlueprintFunctionLibrary.ApplyScanEffect(orCreateUObjectByNativePointer, __Params->type);
	}

	// Token: 0x06005F25 RID: 24357 RVA: 0x0011CCEF File Offset: 0x0011AEEF
	protected unsafe static void __CPPCALL_ClearAllScanEffects_Implementation(LevelGamePlayBlueprintFunctionLibrary.__ClearAllScanEffects_FunctionParams* __Params)
	{
		LevelGamePlayBlueprintFunctionLibrary.ClearAllScanEffects();
	}

	// Token: 0x06005F26 RID: 24358 RVA: 0x0011CCF8 File Offset: 0x0011AEF8
	protected unsafe static void __CPPCALL_SceneInteractionBind_Implementation(LevelGamePlayBlueprintFunctionLibrary.__SceneInteractionBind_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		string seqName = FString.ToString((void*)(&__Params->seqName));
		string eventName = FString.ToString((void*)(&__Params->eventName));
		LevelGamePlayBlueprintFunctionLibrary.SceneInteractionBind(orCreateUObjectByNativePointer, seqName, eventName);
	}

	// Token: 0x06005F27 RID: 24359 RVA: 0x0011CD31 File Offset: 0x0011AF31
	protected unsafe static void __CPPCALL_GetScanMaxDistance_Implementation(LevelGamePlayBlueprintFunctionLibrary.__GetScanMaxDistance_FunctionParams* __Params)
	{
		__Params->__Result = LevelGamePlayBlueprintFunctionLibrary.GetScanMaxDistance();
	}

	// Token: 0x06005F28 RID: 24360 RVA: 0x0011CD3E File Offset: 0x0011AF3E
	protected unsafe static void __CPPCALL_GetScanInteractionEffectMaxDistance_Implementation(LevelGamePlayBlueprintFunctionLibrary.__GetScanInteractionEffectMaxDistance_FunctionParams* __Params)
	{
		__Params->__Result = LevelGamePlayBlueprintFunctionLibrary.GetScanInteractionEffectMaxDistance();
	}

	// Token: 0x06005F29 RID: 24361 RVA: 0x0011CD4C File Offset: 0x0011AF4C
	protected unsafe static void __CPPCALL_PolygonsOpenPathsDifferenceViaSplines_Implementation(LevelGamePlayBlueprintFunctionLibrary.__PolygonsOpenPathsDifferenceViaSplines_FunctionParams* __Params)
	{
		TArray<USplineComponent> tarray = new TArray<USplineComponent>(&__Params->subjects, true, true);
		TArray<USplineComponent> tarray2 = new TArray<USplineComponent>(&__Params->openPaths, true, true);
		EJoinType joinType = (EJoinType)__Params->joinType;
		EEndType endType = (EEndType)__Params->endType;
		UScriptStructStackOnlyPtr nativeUStructPtr = FKuroGeometryGeneralPolygonList.StaticStruct();
		IntPtr dest = &__Params->__Result;
		FKuroGeometryGeneralPolygonList fkuroGeometryGeneralPolygonList = LevelGamePlayBlueprintFunctionLibrary.PolygonsOpenPathsDifferenceViaSplines(ref tarray, ref tarray2, __Params->strokeWidth, joinType, endType);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (fkuroGeometryGeneralPolygonList != null) ? fkuroGeometryGeneralPolygonList.NativePtr : ((IntPtr)0), 1, false);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->subjects, default(UScriptStructStackOnlyPtr));
		}
		if (tarray2 != null)
		{
			tarray2.CopyTo(&__Params->openPaths, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06005F2A RID: 24362 RVA: 0x0011CDEA File Offset: 0x0011AFEA
	protected unsafe static void __CPPCALL_DifferenceSelectedActorsSplines_Implementation(LevelGamePlayBlueprintFunctionLibrary.__DifferenceSelectedActorsSplines_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = FKuroGeometryGeneralPolygonList.StaticStruct();
		IntPtr dest = &__Params->__Result;
		FKuroGeometryGeneralPolygonList fkuroGeometryGeneralPolygonList = LevelGamePlayBlueprintFunctionLibrary.DifferenceSelectedActorsSplines();
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (fkuroGeometryGeneralPolygonList != null) ? fkuroGeometryGeneralPolygonList.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06005F2B RID: 24363 RVA: 0x0011CE11 File Offset: 0x0011B011
	protected unsafe static void __CPPCALL_UseNewScanSystem_Implementation(LevelGamePlayBlueprintFunctionLibrary.__UseNewScanSystem_FunctionParams* __Params)
	{
		__Params->__Result = LevelGamePlayBlueprintFunctionLibrary.UseNewScanSystem();
	}

	// Token: 0x06005F2C RID: 24364 RVA: 0x0011CE1E File Offset: 0x0011B01E
	protected unsafe static void __CPPCALL_StartScan_Implementation(LevelGamePlayBlueprintFunctionLibrary.__StartScan_FunctionParams* __Params)
	{
		LevelGamePlayBlueprintFunctionLibrary.StartScan();
	}

	// Token: 0x04002B32 RID: 11058
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGamePlayBlueprintFunctionLibrary.LevelGamePlayBlueprintFunctionLibrary_C";

	// Token: 0x04002B33 RID: 11059
	private static IntPtr _ClassPtr;

	// Token: 0x04002B34 RID: 11060
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02007530 RID: 30000
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ApplyScanEffect_FunctionParams
	{
		// Token: 0x04026C45 RID: 158789
		[FieldOffset(0)]
		public IntPtr inActor;

		// Token: 0x04026C46 RID: 158790
		[FieldOffset(8)]
		public int type;

		// Token: 0x04026C47 RID: 158791
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x04026C48 RID: 158792
		[FieldOffset(24)]
		public bool __Result;
	}

	// Token: 0x02007531 RID: 30001
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ClearAllScanEffects_FunctionParams
	{
		// Token: 0x04026C49 RID: 158793
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007532 RID: 30002
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __SceneInteractionBind_FunctionParams
	{
		// Token: 0x04026C4A RID: 158794
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x04026C4B RID: 158795
		[FieldOffset(8)]
		public FString seqName;

		// Token: 0x04026C4C RID: 158796
		[FieldOffset(24)]
		public FString eventName;

		// Token: 0x04026C4D RID: 158797
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007533 RID: 30003
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetScanMaxDistance_FunctionParams
	{
		// Token: 0x04026C4E RID: 158798
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04026C4F RID: 158799
		[FieldOffset(8)]
		public int __Result;
	}

	// Token: 0x02007534 RID: 30004
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetScanInteractionEffectMaxDistance_FunctionParams
	{
		// Token: 0x04026C50 RID: 158800
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04026C51 RID: 158801
		[FieldOffset(8)]
		public int __Result;
	}

	// Token: 0x02007535 RID: 30005
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __PolygonsOpenPathsDifferenceViaSplines_FunctionParams
	{
		// Token: 0x04026C52 RID: 158802
		[FieldOffset(0)]
		public byte subjects;

		// Token: 0x04026C53 RID: 158803
		[FieldOffset(16)]
		public byte openPaths;

		// Token: 0x04026C54 RID: 158804
		[FieldOffset(32)]
		public float strokeWidth;

		// Token: 0x04026C55 RID: 158805
		[FieldOffset(36)]
		public byte joinType;

		// Token: 0x04026C56 RID: 158806
		[FieldOffset(37)]
		public byte endType;

		// Token: 0x04026C57 RID: 158807
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x04026C58 RID: 158808
		[FieldOffset(48)]
		public byte __Result;
	}

	// Token: 0x02007536 RID: 30006
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __DifferenceSelectedActorsSplines_FunctionParams
	{
		// Token: 0x04026C59 RID: 158809
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04026C5A RID: 158810
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x02007537 RID: 30007
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __UseNewScanSystem_FunctionParams
	{
		// Token: 0x04026C5B RID: 158811
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04026C5C RID: 158812
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02007538 RID: 30008
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __StartScan_FunctionParams
	{
		// Token: 0x04026C5D RID: 158813
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}
}
