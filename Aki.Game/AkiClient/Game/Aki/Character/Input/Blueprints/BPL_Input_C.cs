using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Input.Blueprints
{
	// Token: 0x02004264 RID: 16996
	[UnrealObjectPath("/Game/Aki/Character/Input/Blueprints/BPL_Input.BPL_Input_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BPL_Input_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C0AA RID: 180394 RVA: 0x00A12754 File Offset: 0x00A10954
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BPL_Input_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Input/Blueprints/BPL_Input.BPL_Input_C");
			}
			return BPL_Input_C._ClassPtr;
		}

		// Token: 0x0602C0AB RID: 180395 RVA: 0x00A12778 File Offset: 0x00A10978
		public BPL_Input_C() : this(BuiltinUtils.AllocNativeUObject(BPL_Input_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C0AC RID: 180396 RVA: 0x00A127A0 File Offset: 0x00A109A0
		[NullableContext(1)]
		public BPL_Input_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BPL_Input_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602C0AD RID: 180397 RVA: 0x00A127D4 File Offset: 0x00A109D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetKeyDownTime(EInputAction Action, UObject __WorldContext, ref float Time)
		{
			BPL_Input_C.StaticClass();
			BPL_Input_C.__GetKeyDownTime_FunctionParams* ptr = stackalloc BPL_Input_C.__GetKeyDownTime_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BPL_Input_C.__GetKeyDownTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Input_C.__GetKeyDownTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Action = Action;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->Time = Time;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_Input_C._ClassDefaultObjectPtr, BPL_Input_C.__GetKeyDownTime_NativeFunctionPtr, (void*)ptr);
			Time = ptr->Time;
		}

		// Token: 0x0602C0AE RID: 180398 RVA: 0x00A1284C File Offset: 0x00A10A4C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsKeyDown(EInputAction NewParam, UObject __WorldContext)
		{
			BPL_Input_C.StaticClass();
			BPL_Input_C.__IsKeyDown_FunctionParams* ptr = stackalloc BPL_Input_C.__IsKeyDown_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BPL_Input_C.__IsKeyDown_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_Input_C.__IsKeyDown_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = NewParam;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BPL_Input_C._ClassDefaultObjectPtr, BPL_Input_C.__IsKeyDown_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602C0AF RID: 180399 RVA: 0x00A128B8 File Offset: 0x00A10AB8
		protected BPL_Input_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401704D RID: 94285
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Input/Blueprints/BPL_Input.BPL_Input_C";

		// Token: 0x0401704E RID: 94286
		private static IntPtr _ClassPtr;

		// Token: 0x0401704F RID: 94287
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017050 RID: 94288
		private static IntPtr __GetKeyDownTime_NativeFunctionPtr;

		// Token: 0x04017051 RID: 94289
		private static IntPtr __IsKeyDown_NativeFunctionPtr;

		// Token: 0x0200A5B4 RID: 42420
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetKeyDownTime_FunctionParams
		{
			// Token: 0x0403244C RID: 205900
			[FieldOffset(0)]
			public TEnumAsByte<EInputAction> Action;

			// Token: 0x0403244D RID: 205901
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x0403244E RID: 205902
			[FieldOffset(16)]
			public float Time;
		}

		// Token: 0x0200A5B5 RID: 42421
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __IsKeyDown_FunctionParams
		{
			// Token: 0x0403244F RID: 205903
			[FieldOffset(0)]
			public TEnumAsByte<EInputAction> NewParam;

			// Token: 0x04032450 RID: 205904
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x04032451 RID: 205905
			[FieldOffset(16)]
			public bool __Result;
		}
	}
}
