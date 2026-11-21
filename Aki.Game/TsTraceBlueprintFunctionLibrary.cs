using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020023A2 RID: 9122
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsTraceBlueprintFunctionLibrary.TsTraceBlueprintFunctionLibrary_C")]
public class TsTraceBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06016D13 RID: 93459 RVA: 0x006A5888 File Offset: 0x006A3A88
	static TsTraceBlueprintFunctionLibrary()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsTraceBlueprintFunctionLibrary.CreateStaticDefaultValue), new Action(TsTraceBlueprintFunctionLibrary.ResetStaticDefaultValue));
	}

	// Token: 0x06016D14 RID: 93460 RVA: 0x006A58F8 File Offset: 0x006A3AF8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool SphereDetect(float radius, FVectorDouble start, FVectorDouble end, [Nullable(new byte[]
	{
		1,
		0
	})] ref TArray<TEnumAsByte<EObjectTypeQuery>> objectTypes, bool isSingle = true, bool debugDraw = false)
	{
		if (TsTraceBlueprintFunctionLibrary.SphereElement == null)
		{
			TsTraceBlueprintFunctionLibrary.SphereElement = new UTraceSphereElement();
		}
		UTraceSphereElement sphereElement = TsTraceBlueprintFunctionLibrary.SphereElement;
		sphereElement.Radius = radius;
		sphereElement.WorldContextObject = GlobalData.World;
		sphereElement.SetStartLocation(start.X, start.Y, start.Z);
		sphereElement.SetEndLocation(end.X, end.Y, end.Z);
		sphereElement.SetObjectTypesQuery(ref objectTypes);
		sphereElement.bIsSingle = isSingle;
		if (debugDraw)
		{
			sphereElement.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
			sphereElement.DrawTime = 1f;
		}
		return TraceElementCommon.Instance.SphereTrace(sphereElement, "SphereDetect");
	}

	// Token: 0x06016D15 RID: 93461 RVA: 0x006A5994 File Offset: 0x006A3B94
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool BoxDetect(FVector halfSize, FVectorDouble start, FVectorDouble end, [Nullable(new byte[]
	{
		1,
		0
	})] ref TArray<TEnumAsByte<EObjectTypeQuery>> objectTypes, bool isSingle = true, bool debugDraw = false)
	{
		if (TsTraceBlueprintFunctionLibrary.BoxElement == null)
		{
			TsTraceBlueprintFunctionLibrary.BoxElement = new UTraceBoxElement();
		}
		UTraceBoxElement boxElement = TsTraceBlueprintFunctionLibrary.BoxElement;
		boxElement.WorldContextObject = GlobalData.World;
		boxElement.SetBoxHalfSize(halfSize.X, halfSize.Y, halfSize.Z);
		boxElement.SetStartLocation(start.X, start.Y, start.Z);
		boxElement.SetEndLocation(end.X, end.Y, end.Z);
		TsTraceBlueprintFunctionLibrary.LookVector.FromUeVector(end);
		TsTraceBlueprintFunctionLibrary.LookVector.X -= end.X;
		TsTraceBlueprintFunctionLibrary.LookVector.Y -= end.Y;
		TsTraceBlueprintFunctionLibrary.LookVector.Z -= end.Z;
		TsTraceBlueprintFunctionLibrary.LookVector.Normalize(9.99999993922529E-09);
		MathUtils.Instance.LookRotationUpFirst(TsTraceBlueprintFunctionLibrary.LookVector, Vector.UpVectorProxy, TsTraceBlueprintFunctionLibrary.LookQuat);
		Rotator rotator = TsTraceBlueprintFunctionLibrary.LookQuat.Rotator(null);
		boxElement.SetBoxOrientation(rotator.Pitch, rotator.Yaw, rotator.Roll);
		boxElement.SetObjectTypesQuery(ref objectTypes);
		boxElement.bIsSingle = isSingle;
		if (debugDraw)
		{
			boxElement.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
			boxElement.DrawTime = 1f;
		}
		return TraceElementCommon.Instance.BoxTrace(boxElement, "BoxDetect");
	}

	// Token: 0x06016D16 RID: 93462 RVA: 0x006A5AE2 File Offset: 0x006A3CE2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016D17 RID: 93463 RVA: 0x006A5AE4 File Offset: 0x006A3CE4
	public static void ResetStaticDefaultValue()
	{
		TsTraceBlueprintFunctionLibrary.SphereElement = null;
		TsTraceBlueprintFunctionLibrary.BoxElement = null;
	}

	// Token: 0x06016D18 RID: 93464 RVA: 0x006A5AF2 File Offset: 0x006A3CF2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTraceBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsTraceBlueprintFunctionLibrary.TsTraceBlueprintFunctionLibrary_C");
		}
		return TsTraceBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06016D19 RID: 93465 RVA: 0x006A5B18 File Offset: 0x006A3D18
	public TsTraceBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsTraceBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016D1A RID: 93466 RVA: 0x006A5B40 File Offset: 0x006A3D40
	[NullableContext(1)]
	public TsTraceBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTraceBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016D1B RID: 93467 RVA: 0x006A5B73 File Offset: 0x006A3D73
	protected TsTraceBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06016D1C RID: 93468 RVA: 0x006A5B7C File Offset: 0x006A3D7C
	protected unsafe static void __CPPCALL_SphereDetect_Implementation(TsTraceBlueprintFunctionLibrary.__SphereDetect_FunctionParams* __Params)
	{
		TArray<TEnumAsByte<EObjectTypeQuery>> tarray = new TArray<TEnumAsByte<EObjectTypeQuery>>(&__Params->objectTypes, true, true);
		__Params->__Result = TsTraceBlueprintFunctionLibrary.SphereDetect(__Params->radius, __Params->start, __Params->end, ref tarray, __Params->isSingle, __Params->debugDraw);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->objectTypes, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06016D1D RID: 93469 RVA: 0x006A5BDC File Offset: 0x006A3DDC
	protected unsafe static void __CPPCALL_BoxDetect_Implementation(TsTraceBlueprintFunctionLibrary.__BoxDetect_FunctionParams* __Params)
	{
		TArray<TEnumAsByte<EObjectTypeQuery>> tarray = new TArray<TEnumAsByte<EObjectTypeQuery>>(&__Params->objectTypes, true, true);
		__Params->__Result = TsTraceBlueprintFunctionLibrary.BoxDetect(__Params->halfSize, __Params->start, __Params->end, ref tarray, __Params->isSingle, __Params->debugDraw);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->objectTypes, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x0400BF40 RID: 48960
	[Nullable(2)]
	private static UTraceSphereElement SphereElement = null;

	// Token: 0x0400BF41 RID: 48961
	[Nullable(2)]
	private static UTraceBoxElement BoxElement = null;

	// Token: 0x0400BF42 RID: 48962
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Vector LookVector = Vector.Create();

	// Token: 0x0400BF43 RID: 48963
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Quat LookQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400BF44 RID: 48964
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsTraceBlueprintFunctionLibrary.TsTraceBlueprintFunctionLibrary_C";

	// Token: 0x0400BF45 RID: 48965
	private static IntPtr _ClassPtr;

	// Token: 0x0400BF46 RID: 48966
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020087D8 RID: 34776
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __SphereDetect_FunctionParams
	{
		// Token: 0x0402B78D RID: 178061
		[FieldOffset(0)]
		public float radius;

		// Token: 0x0402B78E RID: 178062
		[FieldOffset(8)]
		public FVectorDouble start;

		// Token: 0x0402B78F RID: 178063
		[FieldOffset(32)]
		public FVectorDouble end;

		// Token: 0x0402B790 RID: 178064
		[FieldOffset(56)]
		public byte objectTypes;

		// Token: 0x0402B791 RID: 178065
		[FieldOffset(72)]
		public bool isSingle;

		// Token: 0x0402B792 RID: 178066
		[FieldOffset(73)]
		public bool debugDraw;

		// Token: 0x0402B793 RID: 178067
		[FieldOffset(80)]
		public IntPtr __WorldContext;

		// Token: 0x0402B794 RID: 178068
		[FieldOffset(88)]
		public bool __Result;
	}

	// Token: 0x020087D9 RID: 34777
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 104)]
	protected ref struct __BoxDetect_FunctionParams
	{
		// Token: 0x0402B795 RID: 178069
		[FieldOffset(0)]
		public FVector halfSize;

		// Token: 0x0402B796 RID: 178070
		[FieldOffset(16)]
		public FVectorDouble start;

		// Token: 0x0402B797 RID: 178071
		[FieldOffset(40)]
		public FVectorDouble end;

		// Token: 0x0402B798 RID: 178072
		[FieldOffset(64)]
		public byte objectTypes;

		// Token: 0x0402B799 RID: 178073
		[FieldOffset(80)]
		public bool isSingle;

		// Token: 0x0402B79A RID: 178074
		[FieldOffset(81)]
		public bool debugDraw;

		// Token: 0x0402B79B RID: 178075
		[FieldOffset(88)]
		public IntPtr __WorldContext;

		// Token: 0x0402B79C RID: 178076
		[FieldOffset(96)]
		public bool __Result;
	}
}
