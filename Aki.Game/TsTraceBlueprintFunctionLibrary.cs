using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002E46 RID: 11846
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsTraceBlueprintFunctionLibrary.TsTraceBlueprintFunctionLibrary_C")]
public class TsTraceBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601943D RID: 103485 RVA: 0x0067F8F8 File Offset: 0x0067DAF8
	static TsTraceBlueprintFunctionLibrary()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsTraceBlueprintFunctionLibrary.CreateStaticDefaultValue), new Action(TsTraceBlueprintFunctionLibrary.ResetStaticDefaultValue));
	}

	// Token: 0x0601943E RID: 103486 RVA: 0x0067F968 File Offset: 0x0067DB68
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

	// Token: 0x0601943F RID: 103487 RVA: 0x0067FA04 File Offset: 0x0067DC04
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

	// Token: 0x06019440 RID: 103488 RVA: 0x0067FB52 File Offset: 0x0067DD52
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06019441 RID: 103489 RVA: 0x0067FB54 File Offset: 0x0067DD54
	public static void ResetStaticDefaultValue()
	{
		TsTraceBlueprintFunctionLibrary.SphereElement = null;
		TsTraceBlueprintFunctionLibrary.BoxElement = null;
	}

	// Token: 0x06019442 RID: 103490 RVA: 0x0067FB62 File Offset: 0x0067DD62
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTraceBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsTraceBlueprintFunctionLibrary.TsTraceBlueprintFunctionLibrary_C");
		}
		return TsTraceBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06019443 RID: 103491 RVA: 0x0067FB88 File Offset: 0x0067DD88
	public TsTraceBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsTraceBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06019444 RID: 103492 RVA: 0x0067FBB0 File Offset: 0x0067DDB0
	[NullableContext(1)]
	public TsTraceBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTraceBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019445 RID: 103493 RVA: 0x0067FBE3 File Offset: 0x0067DDE3
	protected TsTraceBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06019446 RID: 103494 RVA: 0x0067FBEC File Offset: 0x0067DDEC
	protected unsafe static void __CPPCALL_SphereDetect_Implementation(TsTraceBlueprintFunctionLibrary.__SphereDetect_FunctionParams* __Params)
	{
		TArray<TEnumAsByte<EObjectTypeQuery>> tarray = new TArray<TEnumAsByte<EObjectTypeQuery>>(&__Params->objectTypes, true, true);
		__Params->__Result = TsTraceBlueprintFunctionLibrary.SphereDetect(__Params->radius, __Params->start, __Params->end, ref tarray, __Params->isSingle, __Params->debugDraw);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->objectTypes, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06019447 RID: 103495 RVA: 0x0067FC4C File Offset: 0x0067DE4C
	protected unsafe static void __CPPCALL_BoxDetect_Implementation(TsTraceBlueprintFunctionLibrary.__BoxDetect_FunctionParams* __Params)
	{
		TArray<TEnumAsByte<EObjectTypeQuery>> tarray = new TArray<TEnumAsByte<EObjectTypeQuery>>(&__Params->objectTypes, true, true);
		__Params->__Result = TsTraceBlueprintFunctionLibrary.BoxDetect(__Params->halfSize, __Params->start, __Params->end, ref tarray, __Params->isSingle, __Params->debugDraw);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->objectTypes, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x0400BBB2 RID: 48050
	[Nullable(2)]
	private static UTraceSphereElement SphereElement = null;

	// Token: 0x0400BBB3 RID: 48051
	[Nullable(2)]
	private static UTraceBoxElement BoxElement = null;

	// Token: 0x0400BBB4 RID: 48052
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Vector LookVector = Vector.Create();

	// Token: 0x0400BBB5 RID: 48053
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Quat LookQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400BBB6 RID: 48054
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsTraceBlueprintFunctionLibrary.TsTraceBlueprintFunctionLibrary_C";

	// Token: 0x0400BBB7 RID: 48055
	private static IntPtr _ClassPtr;

	// Token: 0x0400BBB8 RID: 48056
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020095AE RID: 38318
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __SphereDetect_FunctionParams
	{
		// Token: 0x040300FA RID: 196858
		[FieldOffset(0)]
		public float radius;

		// Token: 0x040300FB RID: 196859
		[FieldOffset(8)]
		public FVectorDouble start;

		// Token: 0x040300FC RID: 196860
		[FieldOffset(32)]
		public FVectorDouble end;

		// Token: 0x040300FD RID: 196861
		[FieldOffset(56)]
		public byte objectTypes;

		// Token: 0x040300FE RID: 196862
		[FieldOffset(72)]
		public bool isSingle;

		// Token: 0x040300FF RID: 196863
		[FieldOffset(73)]
		public bool debugDraw;

		// Token: 0x04030100 RID: 196864
		[FieldOffset(80)]
		public IntPtr __WorldContext;

		// Token: 0x04030101 RID: 196865
		[FieldOffset(88)]
		public bool __Result;
	}

	// Token: 0x020095AF RID: 38319
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 104)]
	protected ref struct __BoxDetect_FunctionParams
	{
		// Token: 0x04030102 RID: 196866
		[FieldOffset(0)]
		public FVector halfSize;

		// Token: 0x04030103 RID: 196867
		[FieldOffset(16)]
		public FVectorDouble start;

		// Token: 0x04030104 RID: 196868
		[FieldOffset(40)]
		public FVectorDouble end;

		// Token: 0x04030105 RID: 196869
		[FieldOffset(64)]
		public byte objectTypes;

		// Token: 0x04030106 RID: 196870
		[FieldOffset(80)]
		public bool isSingle;

		// Token: 0x04030107 RID: 196871
		[FieldOffset(81)]
		public bool debugDraw;

		// Token: 0x04030108 RID: 196872
		[FieldOffset(88)]
		public IntPtr __WorldContext;

		// Token: 0x04030109 RID: 196873
		[FieldOffset(96)]
		public bool __Result;
	}
}
