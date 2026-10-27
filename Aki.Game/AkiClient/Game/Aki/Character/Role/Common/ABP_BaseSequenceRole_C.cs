using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common
{
	// Token: 0x0200409C RID: 16540
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_BaseSequenceRole.ABP_BaseSequenceRole_C")]
	[UnrealStructLayout(4432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4421)]
	public class ABP_BaseSequenceRole_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AABA RID: 174778 RVA: 0x009E82C1 File Offset: 0x009E64C1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseSequenceRole_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_BaseSequenceRole.ABP_BaseSequenceRole_C");
			}
			return ABP_BaseSequenceRole_C._ClassPtr;
		}

		// Token: 0x0602AABB RID: 174779 RVA: 0x009E82E8 File Offset: 0x009E64E8
		public ABP_BaseSequenceRole_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseSequenceRole_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AABC RID: 174780 RVA: 0x009E8310 File Offset: 0x009E6510
		[NullableContext(1)]
		public ABP_BaseSequenceRole_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseSequenceRole_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170068DE RID: 26846
		// (get) Token: 0x0602AABD RID: 174781 RVA: 0x009E8343 File Offset: 0x009E6543
		// (set) Token: 0x0602AABE RID: 174782 RVA: 0x009E8357 File Offset: 0x009E6557
		[Nullable(2)]
		public unsafe UPoseAsset SeqMouthPoseAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPoseAsset>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseSequenceRole_C.__PropertyOffset_17);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseSequenceRole_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x170068DF RID: 26847
		// (get) Token: 0x0602AABF RID: 174783 RVA: 0x009E836C File Offset: 0x009E656C
		// (set) Token: 0x0602AAC0 RID: 174784 RVA: 0x009E837C File Offset: 0x009E657C
		public unsafe float SeqMouthAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseSequenceRole_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseSequenceRole_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170068E0 RID: 26848
		// (get) Token: 0x0602AAC1 RID: 174785 RVA: 0x009E838D File Offset: 0x009E658D
		// (set) Token: 0x0602AAC2 RID: 174786 RVA: 0x009E839D File Offset: 0x009E659D
		public unsafe bool UseOverrideLayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseSequenceRole_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseSequenceRole_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602AAC3 RID: 174787 RVA: 0x009E83B0 File Offset: 0x009E65B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MouthAddLayer(ref FPoseLink MouthAddLayer)
		{
			ABP_BaseSequenceRole_C.__MouthAddLayer_FunctionParams* ptr = stackalloc ABP_BaseSequenceRole_C.__MouthAddLayer_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseSequenceRole_C.__MouthAddLayer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseSequenceRole_C.__MouthAddLayer_NativeFunctionPtr, (void*)ptr, 1);
			if (MouthAddLayer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->MouthAddLayer, MouthAddLayer.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseSequenceRole_C.__MouthAddLayer_NativeFunctionPtr, (void*)ptr);
			if (MouthAddLayer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), MouthAddLayer.NativePtr, &ptr->MouthAddLayer, 1, false);
			}
		}

		// Token: 0x0602AAC4 RID: 174788 RVA: 0x009E8438 File Offset: 0x009E6638
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MouthOverrideLayer(ref FPoseLink MouthOverrideLayer)
		{
			ABP_BaseSequenceRole_C.__MouthOverrideLayer_FunctionParams* ptr = stackalloc ABP_BaseSequenceRole_C.__MouthOverrideLayer_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseSequenceRole_C.__MouthOverrideLayer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseSequenceRole_C.__MouthOverrideLayer_NativeFunctionPtr, (void*)ptr, 1);
			if (MouthOverrideLayer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->MouthOverrideLayer, MouthOverrideLayer.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseSequenceRole_C.__MouthOverrideLayer_NativeFunctionPtr, (void*)ptr);
			if (MouthOverrideLayer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), MouthOverrideLayer.NativePtr, &ptr->MouthOverrideLayer, 1, false);
			}
		}

		// Token: 0x0602AAC5 RID: 174789 RVA: 0x009E84C0 File Offset: 0x009E66C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseSequenceRole_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseSequenceRole_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseSequenceRole_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseSequenceRole_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseSequenceRole_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AAC6 RID: 174790 RVA: 0x009E8548 File Offset: 0x009E6748
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseSequenceRole_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseSequenceRole_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseSequenceRole_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseSequenceRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseSequenceRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AAC7 RID: 174791 RVA: 0x009E8590 File Offset: 0x009E6790
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseSequenceRole_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseSequenceRole_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseSequenceRole_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseSequenceRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseSequenceRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AAC8 RID: 174792 RVA: 0x009E85D7 File Offset: 0x009E67D7
		protected ABP_BaseSequenceRole_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016141 RID: 90433
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_BaseSequenceRole.ABP_BaseSequenceRole_C";

		// Token: 0x04016142 RID: 90434
		private static IntPtr _ClassPtr;

		// Token: 0x04016143 RID: 90435
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016144 RID: 90436
		internal static int __PropertyOffset_17;

		// Token: 0x04016145 RID: 90437
		internal static int __PropertyOffset_18;

		// Token: 0x04016146 RID: 90438
		internal static int __PropertyOffset_19;

		// Token: 0x04016147 RID: 90439
		private static IntPtr __MouthAddLayer_NativeFunctionPtr;

		// Token: 0x04016148 RID: 90440
		private static IntPtr __MouthOverrideLayer_NativeFunctionPtr;

		// Token: 0x04016149 RID: 90441
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x0401614A RID: 90442
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x0200A401 RID: 41985
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __MouthAddLayer_FunctionParams
		{
			// Token: 0x04032231 RID: 205361
			[FieldOffset(0)]
			public byte MouthAddLayer;
		}

		// Token: 0x0200A402 RID: 41986
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __MouthOverrideLayer_FunctionParams
		{
			// Token: 0x04032232 RID: 205362
			[FieldOffset(0)]
			public byte MouthOverrideLayer;
		}

		// Token: 0x0200A403 RID: 41987
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032233 RID: 205363
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A404 RID: 41988
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x04032234 RID: 205364
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
