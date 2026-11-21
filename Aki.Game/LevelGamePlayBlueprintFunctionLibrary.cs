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

// Token: 0x02000396 RID: 918
[UClass("/Game/Aki/TypeScript/Game/LevelGamePlay/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGamePlayBlueprintFunctionLibrary.LevelGamePlayBlueprintFunctionLibrary_C")]
public class LevelGamePlayBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x060032AC RID: 12972 RVA: 0x00124892 File Offset: 0x00122A92
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool ApplyScanEffect(AActor inActor, int type)
	{
		return LevelGamePlayController.Instance.HandleScanResponse(inActor, type);
	}

	// Token: 0x060032AD RID: 12973 RVA: 0x001248A0 File Offset: 0x00122AA0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ClearAllScanEffects()
	{
		LevelGamePlayController.Instance.HandleClearAllScanEffect();
	}

	// Token: 0x060032AE RID: 12974 RVA: 0x001248AC File Offset: 0x00122AAC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SceneInteractionBind(AActor actor, string seqName, string eventName)
	{
		SceneInteractionManager.Get().EmitActor(actor, seqName, eventName);
	}

	// Token: 0x060032AF RID: 12975 RVA: 0x001248BB File Offset: 0x00122ABB
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

	// Token: 0x060032B0 RID: 12976 RVA: 0x001248CD File Offset: 0x00122ACD
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

	// Token: 0x060032B1 RID: 12977 RVA: 0x001248E0 File Offset: 0x00122AE0
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

	// Token: 0x060032B2 RID: 12978 RVA: 0x00124944 File Offset: 0x00122B44
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FKuroGeometryGeneralPolygonList PolygonsOpenPathsDifferenceViaSplines(ref TArray<USplineComponent> subjects, ref TArray<USplineComponent> openPaths, float strokeWidth, EJoinType joinType, EEndType endType)
	{
		FKuroGeometryGeneralPolygonList polygonListFromSplines = LevelGamePlayBlueprintFunctionLibrary.GetPolygonListFromSplines(subjects);
		FKuroGeometryGeneralPolygonList polygonListFromSplines2 = LevelGamePlayBlueprintFunctionLibrary.GetPolygonListFromSplines(openPaths);
		return UKuroPolygonListLibrary.PolygonsOpenPathsDifference(polygonListFromSplines, polygonListFromSplines2, (double)strokeWidth, joinType, endType);
	}

	// Token: 0x060032B3 RID: 12979 RVA: 0x0012496B File Offset: 0x00122B6B
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FKuroGeometryGeneralPolygonList DifferenceSelectedActorsSplines()
	{
		return new FKuroGeometryGeneralPolygonList();
	}

	// Token: 0x060032B4 RID: 12980 RVA: 0x00124972 File Offset: 0x00122B72
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool UseNewScanSystem()
	{
		return LevelGamePlayController.Instance.UseNewScanSystem;
	}

	// Token: 0x060032B5 RID: 12981 RVA: 0x0012497E File Offset: 0x00122B7E
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StartScan()
	{
		ScanController.Instance.StartScan();
	}

	// Token: 0x060032B6 RID: 12982 RVA: 0x0012498A File Offset: 0x00122B8A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LevelGamePlayBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGamePlayBlueprintFunctionLibrary.LevelGamePlayBlueprintFunctionLibrary_C");
		}
		return LevelGamePlayBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x060032B7 RID: 12983 RVA: 0x001249B0 File Offset: 0x00122BB0
	public LevelGamePlayBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(LevelGamePlayBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060032B8 RID: 12984 RVA: 0x001249D8 File Offset: 0x00122BD8
	[NullableContext(1)]
	public LevelGamePlayBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGamePlayBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060032B9 RID: 12985 RVA: 0x00124A0B File Offset: 0x00122C0B
	protected LevelGamePlayBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060032BA RID: 12986 RVA: 0x00124A14 File Offset: 0x00122C14
	protected unsafe static void __CPPCALL_ApplyScanEffect_Implementation(LevelGamePlayBlueprintFunctionLibrary.__ApplyScanEffect_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inActor);
		__Params->__Result = LevelGamePlayBlueprintFunctionLibrary.ApplyScanEffect(orCreateUObjectByNativePointer, __Params->type);
	}

	// Token: 0x060032BB RID: 12987 RVA: 0x00124A3F File Offset: 0x00122C3F
	protected unsafe static void __CPPCALL_ClearAllScanEffects_Implementation(LevelGamePlayBlueprintFunctionLibrary.__ClearAllScanEffects_FunctionParams* __Params)
	{
		LevelGamePlayBlueprintFunctionLibrary.ClearAllScanEffects();
	}

	// Token: 0x060032BC RID: 12988 RVA: 0x00124A48 File Offset: 0x00122C48
	protected unsafe static void __CPPCALL_SceneInteractionBind_Implementation(LevelGamePlayBlueprintFunctionLibrary.__SceneInteractionBind_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		string seqName = FString.ToString((void*)(&__Params->seqName));
		string eventName = FString.ToString((void*)(&__Params->eventName));
		LevelGamePlayBlueprintFunctionLibrary.SceneInteractionBind(orCreateUObjectByNativePointer, seqName, eventName);
	}

	// Token: 0x060032BD RID: 12989 RVA: 0x00124A81 File Offset: 0x00122C81
	protected unsafe static void __CPPCALL_GetScanMaxDistance_Implementation(LevelGamePlayBlueprintFunctionLibrary.__GetScanMaxDistance_FunctionParams* __Params)
	{
		__Params->__Result = LevelGamePlayBlueprintFunctionLibrary.GetScanMaxDistance();
	}

	// Token: 0x060032BE RID: 12990 RVA: 0x00124A8E File Offset: 0x00122C8E
	protected unsafe static void __CPPCALL_GetScanInteractionEffectMaxDistance_Implementation(LevelGamePlayBlueprintFunctionLibrary.__GetScanInteractionEffectMaxDistance_FunctionParams* __Params)
	{
		__Params->__Result = LevelGamePlayBlueprintFunctionLibrary.GetScanInteractionEffectMaxDistance();
	}

	// Token: 0x060032BF RID: 12991 RVA: 0x00124A9C File Offset: 0x00122C9C
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

	// Token: 0x060032C0 RID: 12992 RVA: 0x00124B3A File Offset: 0x00122D3A
	protected unsafe static void __CPPCALL_DifferenceSelectedActorsSplines_Implementation(LevelGamePlayBlueprintFunctionLibrary.__DifferenceSelectedActorsSplines_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = FKuroGeometryGeneralPolygonList.StaticStruct();
		IntPtr dest = &__Params->__Result;
		FKuroGeometryGeneralPolygonList fkuroGeometryGeneralPolygonList = LevelGamePlayBlueprintFunctionLibrary.DifferenceSelectedActorsSplines();
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (fkuroGeometryGeneralPolygonList != null) ? fkuroGeometryGeneralPolygonList.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060032C1 RID: 12993 RVA: 0x00124B61 File Offset: 0x00122D61
	protected unsafe static void __CPPCALL_UseNewScanSystem_Implementation(LevelGamePlayBlueprintFunctionLibrary.__UseNewScanSystem_FunctionParams* __Params)
	{
		__Params->__Result = LevelGamePlayBlueprintFunctionLibrary.UseNewScanSystem();
	}

	// Token: 0x060032C2 RID: 12994 RVA: 0x00124B6E File Offset: 0x00122D6E
	protected unsafe static void __CPPCALL_StartScan_Implementation(LevelGamePlayBlueprintFunctionLibrary.__StartScan_FunctionParams* __Params)
	{
		LevelGamePlayBlueprintFunctionLibrary.StartScan();
	}

	// Token: 0x04002BCC RID: 11212
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGamePlayBlueprintFunctionLibrary.LevelGamePlayBlueprintFunctionLibrary_C";

	// Token: 0x04002BCD RID: 11213
	private static IntPtr _ClassPtr;

	// Token: 0x04002BCE RID: 11214
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020066C4 RID: 26308
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ApplyScanEffect_FunctionParams
	{
		// Token: 0x04021F90 RID: 139152
		[FieldOffset(0)]
		public IntPtr inActor;

		// Token: 0x04021F91 RID: 139153
		[FieldOffset(8)]
		public int type;

		// Token: 0x04021F92 RID: 139154
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x04021F93 RID: 139155
		[FieldOffset(24)]
		public bool __Result;
	}

	// Token: 0x020066C5 RID: 26309
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ClearAllScanEffects_FunctionParams
	{
		// Token: 0x04021F94 RID: 139156
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020066C6 RID: 26310
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __SceneInteractionBind_FunctionParams
	{
		// Token: 0x04021F95 RID: 139157
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x04021F96 RID: 139158
		[FieldOffset(8)]
		public FString seqName;

		// Token: 0x04021F97 RID: 139159
		[FieldOffset(24)]
		public FString eventName;

		// Token: 0x04021F98 RID: 139160
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020066C7 RID: 26311
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetScanMaxDistance_FunctionParams
	{
		// Token: 0x04021F99 RID: 139161
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021F9A RID: 139162
		[FieldOffset(8)]
		public int __Result;
	}

	// Token: 0x020066C8 RID: 26312
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetScanInteractionEffectMaxDistance_FunctionParams
	{
		// Token: 0x04021F9B RID: 139163
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021F9C RID: 139164
		[FieldOffset(8)]
		public int __Result;
	}

	// Token: 0x020066C9 RID: 26313
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __PolygonsOpenPathsDifferenceViaSplines_FunctionParams
	{
		// Token: 0x04021F9D RID: 139165
		[FieldOffset(0)]
		public byte subjects;

		// Token: 0x04021F9E RID: 139166
		[FieldOffset(16)]
		public byte openPaths;

		// Token: 0x04021F9F RID: 139167
		[FieldOffset(32)]
		public float strokeWidth;

		// Token: 0x04021FA0 RID: 139168
		[FieldOffset(36)]
		public byte joinType;

		// Token: 0x04021FA1 RID: 139169
		[FieldOffset(37)]
		public byte endType;

		// Token: 0x04021FA2 RID: 139170
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x04021FA3 RID: 139171
		[FieldOffset(48)]
		public byte __Result;
	}

	// Token: 0x020066CA RID: 26314
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __DifferenceSelectedActorsSplines_FunctionParams
	{
		// Token: 0x04021FA4 RID: 139172
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021FA5 RID: 139173
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x020066CB RID: 26315
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __UseNewScanSystem_FunctionParams
	{
		// Token: 0x04021FA6 RID: 139174
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021FA7 RID: 139175
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x020066CC RID: 26316
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __StartScan_FunctionParams
	{
		// Token: 0x04021FA8 RID: 139176
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}
}
