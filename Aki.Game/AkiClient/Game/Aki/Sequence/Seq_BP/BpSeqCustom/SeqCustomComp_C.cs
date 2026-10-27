using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Seq_BP.BpSeqCustom
{
	// Token: 0x02003A23 RID: 14883
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/BpSeqCustom/SeqCustomComp.SeqCustomComp_C")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class SeqCustomComp_C : UActorComponent, IUnrealUObject, IUnrealObject, ICurveSourceInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601F479 RID: 128121 RVA: 0x008B3EF9 File Offset: 0x008B20F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (SeqCustomComp_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Seq_BP/BpSeqCustom/SeqCustomComp.SeqCustomComp_C");
			}
			return SeqCustomComp_C._ClassPtr;
		}

		// Token: 0x0601F47A RID: 128122 RVA: 0x008B3F1D File Offset: 0x008B211D
		int ICurveSourceInterface.InterfaceOffset()
		{
			return SeqCustomComp_C.__InterfaceOffset_ICurveSourceInterface;
		}

		// Token: 0x0601F47B RID: 128123 RVA: 0x008B3F24 File Offset: 0x008B2124
		public SeqCustomComp_C() : this(BuiltinUtils.AllocNativeUObject(SeqCustomComp_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F47C RID: 128124 RVA: 0x008B3F4C File Offset: 0x008B214C
		[NullableContext(1)]
		public SeqCustomComp_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SeqCustomComp_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A8A RID: 10890
		// (get) Token: 0x0601F47D RID: 128125 RVA: 0x008B3F80 File Offset: 0x008B2180
		// (set) Token: 0x0601F47E RID: 128126 RVA: 0x008B3FB9 File Offset: 0x008B21B9
		[Nullable(1)]
		public TArray<FNamedCurveValue> CurveData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FNamedCurveValue> result;
				if ((result = this._CurveData) == null)
				{
					result = (this._CurveData = new TArray<FNamedCurveValue>(base.NativePtr + (IntPtr)SeqCustomComp_C.__PropertyOffset_0, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CurveData.CopyAssign(value);
			}
		}

		// Token: 0x17002A8B RID: 10891
		// (get) Token: 0x0601F47F RID: 128127 RVA: 0x008B3FC7 File Offset: 0x008B21C7
		// (set) Token: 0x0601F480 RID: 128128 RVA: 0x008B3FD7 File Offset: 0x008B21D7
		public unsafe float SeqLHandWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SeqCustomComp_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SeqCustomComp_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17002A8C RID: 10892
		// (get) Token: 0x0601F481 RID: 128129 RVA: 0x008B3FE8 File Offset: 0x008B21E8
		// (set) Token: 0x0601F482 RID: 128130 RVA: 0x008B3FF8 File Offset: 0x008B21F8
		public unsafe float SeqRHandWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SeqCustomComp_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SeqCustomComp_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0601F483 RID: 128131 RVA: 0x008B400C File Offset: 0x008B220C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FName GetBindingName()
		{
			SeqCustomComp_C.__GetBindingName_FunctionParams* ptr = stackalloc SeqCustomComp_C.__GetBindingName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(SeqCustomComp_C.__GetBindingName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SeqCustomComp_C.__GetBindingName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SeqCustomComp_C.__GetBindingName_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F484 RID: 128132 RVA: 0x008B4054 File Offset: 0x008B2254
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual FName GetBindingName_Implementation()
		{
			SeqCustomComp_C.__GetBindingName_FunctionParams* ptr = stackalloc SeqCustomComp_C.__GetBindingName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(SeqCustomComp_C.__GetBindingName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SeqCustomComp_C.__GetBindingName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, SeqCustomComp_C.__GetBindingName_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601F485 RID: 128133 RVA: 0x008B409C File Offset: 0x008B229C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCurves([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> OutValues)
		{
			SeqCustomComp_C.__GetCurves_FunctionParams* ptr = stackalloc SeqCustomComp_C.__GetCurves_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(SeqCustomComp_C.__GetCurves_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SeqCustomComp_C.__GetCurves_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = OutValues;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutValues);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SeqCustomComp_C.__GetCurves_NativeFunctionPtr, (void*)ptr);
			TArray<FNamedCurveValue> tarray2 = OutValues;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutValues);
			}
			UnrealReflectionUtils.DestroyStruct(SeqCustomComp_C.__GetCurves_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F486 RID: 128134 RVA: 0x008B4114 File Offset: 0x008B2314
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void GetCurves_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> OutValues)
		{
			SeqCustomComp_C.__GetCurves_FunctionParams* ptr = stackalloc SeqCustomComp_C.__GetCurves_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(SeqCustomComp_C.__GetCurves_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SeqCustomComp_C.__GetCurves_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = OutValues;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutValues);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, SeqCustomComp_C.__GetCurves_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FNamedCurveValue> tarray2 = OutValues;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutValues);
			}
			UnrealReflectionUtils.DestroyStruct(SeqCustomComp_C.__GetCurves_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F487 RID: 128135 RVA: 0x008B4190 File Offset: 0x008B2390
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual float GetCurveValue(FName CurveName)
		{
			SeqCustomComp_C.__GetCurveValue_FunctionParams* ptr = stackalloc SeqCustomComp_C.__GetCurveValue_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(SeqCustomComp_C.__GetCurveValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SeqCustomComp_C.__GetCurveValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurveName = CurveName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SeqCustomComp_C.__GetCurveValue_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F488 RID: 128136 RVA: 0x008B41DC File Offset: 0x008B23DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual float GetCurveValue_Implementation(FName CurveName)
		{
			SeqCustomComp_C.__GetCurveValue_FunctionParams* ptr = stackalloc SeqCustomComp_C.__GetCurveValue_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(SeqCustomComp_C.__GetCurveValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SeqCustomComp_C.__GetCurveValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurveName = CurveName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, SeqCustomComp_C.__GetCurveValue_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601F489 RID: 128137 RVA: 0x008B422C File Offset: 0x008B242C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Set_Vector_Data(TMap<FName, FVector> Name)
		{
			SeqCustomComp_C.__Set_Vector_Data_FunctionParams* ptr = stackalloc SeqCustomComp_C.__Set_Vector_Data_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(SeqCustomComp_C.__Set_Vector_Data_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SeqCustomComp_C.__Set_Vector_Data_NativeFunctionPtr, (void*)ptr, 1);
			if (Name != null)
			{
				Name.CopyTo(&ptr->Name, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SeqCustomComp_C.__Set_Vector_Data_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(SeqCustomComp_C.__Set_Vector_Data_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F48A RID: 128138 RVA: 0x008B4298 File Offset: 0x008B2498
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ProcessEye(FVector EyeLookAt, float AngleScale)
		{
			SeqCustomComp_C.__ProcessEye_FunctionParams* ptr = stackalloc SeqCustomComp_C.__ProcessEye_FunctionParams[(UIntPtr)235] + 15L / (long)sizeof(SeqCustomComp_C.__ProcessEye_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SeqCustomComp_C.__ProcessEye_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EyeLookAt = EyeLookAt;
			ptr->AngleScale = AngleScale;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SeqCustomComp_C.__ProcessEye_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F48B RID: 128139 RVA: 0x008B42E8 File Offset: 0x008B24E8
		protected SeqCustomComp_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F00A RID: 61450
		internal static int __InterfaceOffset_ICurveSourceInterface;

		// Token: 0x0400F00B RID: 61451
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Seq_BP/BpSeqCustom/SeqCustomComp.SeqCustomComp_C";

		// Token: 0x0400F00C RID: 61452
		private static IntPtr _ClassPtr;

		// Token: 0x0400F00D RID: 61453
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F00E RID: 61454
		internal static int __PropertyOffset_0;

		// Token: 0x0400F00F RID: 61455
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNamedCurveValue> _CurveData;

		// Token: 0x0400F010 RID: 61456
		internal static int __PropertyOffset_1;

		// Token: 0x0400F011 RID: 61457
		internal static int __PropertyOffset_2;

		// Token: 0x0400F012 RID: 61458
		private static IntPtr __GetBindingName_NativeFunctionPtr;

		// Token: 0x0400F013 RID: 61459
		private static IntPtr __GetCurves_NativeFunctionPtr;

		// Token: 0x0400F014 RID: 61460
		private static IntPtr __GetCurveValue_NativeFunctionPtr;

		// Token: 0x0400F015 RID: 61461
		private static IntPtr __Set_Vector_Data_NativeFunctionPtr;

		// Token: 0x0400F016 RID: 61462
		private static IntPtr __ProcessEye_NativeFunctionPtr;

		// Token: 0x02009AB1 RID: 39601
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetBindingName_FunctionParams
		{
			// Token: 0x0403103B RID: 200763
			[FieldOffset(0)]
			public FName __Result;
		}

		// Token: 0x02009AB2 RID: 39602
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCurves_FunctionParams
		{
			// Token: 0x0403103C RID: 200764
			[FieldOffset(0)]
			public byte OutValues;
		}

		// Token: 0x02009AB3 RID: 39603
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCurveValue_FunctionParams
		{
			// Token: 0x0403103D RID: 200765
			[FieldOffset(0)]
			public FName CurveName;

			// Token: 0x0403103E RID: 200766
			[FieldOffset(12)]
			public float __Result;
		}

		// Token: 0x02009AB4 RID: 39604
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __Set_Vector_Data_FunctionParams
		{
			// Token: 0x0403103F RID: 200767
			[FieldOffset(0)]
			public byte Name;
		}

		// Token: 0x02009AB5 RID: 39605
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 220)]
		protected ref struct __ProcessEye_FunctionParams
		{
			// Token: 0x04031040 RID: 200768
			[FieldOffset(0)]
			public FVector EyeLookAt;

			// Token: 0x04031041 RID: 200769
			[FieldOffset(12)]
			public float AngleScale;
		}
	}
}
