using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common
{
	// Token: 0x0200409D RID: 16541
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_BaseSequenceRole_V2.ABP_BaseSequenceRole_V2_C")]
	[UnrealStructLayout(3520, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3520)]
	public class ABP_BaseSequenceRole_V2_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AAC9 RID: 174793 RVA: 0x009E85E0 File Offset: 0x009E67E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseSequenceRole_V2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_BaseSequenceRole_V2.ABP_BaseSequenceRole_V2_C");
			}
			return ABP_BaseSequenceRole_V2_C._ClassPtr;
		}

		// Token: 0x0602AACA RID: 174794 RVA: 0x009E8604 File Offset: 0x009E6804
		public ABP_BaseSequenceRole_V2_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseSequenceRole_V2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AACB RID: 174795 RVA: 0x009E862C File Offset: 0x009E682C
		[NullableContext(1)]
		public ABP_BaseSequenceRole_V2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseSequenceRole_V2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170068E1 RID: 26849
		// (get) Token: 0x0602AACC RID: 174796 RVA: 0x009E865F File Offset: 0x009E685F
		// (set) Token: 0x0602AACD RID: 174797 RVA: 0x009E866F File Offset: 0x009E686F
		public unsafe bool OverrideMouth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseSequenceRole_V2_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseSequenceRole_V2_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068E2 RID: 26850
		// (get) Token: 0x0602AACE RID: 174798 RVA: 0x009E8680 File Offset: 0x009E6880
		// (set) Token: 0x0602AACF RID: 174799 RVA: 0x009E8690 File Offset: 0x009E6890
		public unsafe float SeqMouthAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseSequenceRole_V2_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseSequenceRole_V2_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x0602AAD0 RID: 174800 RVA: 0x009E86A4 File Offset: 0x009E68A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseSequenceRole_V2_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseSequenceRole_V2_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseSequenceRole_V2_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseSequenceRole_V2_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseSequenceRole_V2_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AAD1 RID: 174801 RVA: 0x009E872C File Offset: 0x009E692C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseSequenceRole_V2_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseSequenceRole_V2_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseSequenceRole_V2_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseSequenceRole_V2_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseSequenceRole_V2_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AAD2 RID: 174802 RVA: 0x009E8774 File Offset: 0x009E6974
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseSequenceRole_V2_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseSequenceRole_V2_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseSequenceRole_V2_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseSequenceRole_V2_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseSequenceRole_V2_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AAD3 RID: 174803 RVA: 0x009E87BB File Offset: 0x009E69BB
		protected ABP_BaseSequenceRole_V2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401614B RID: 90443
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_BaseSequenceRole_V2.ABP_BaseSequenceRole_V2_C";

		// Token: 0x0401614C RID: 90444
		private static IntPtr _ClassPtr;

		// Token: 0x0401614D RID: 90445
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401614E RID: 90446
		internal static int __PropertyOffset_13;

		// Token: 0x0401614F RID: 90447
		internal static int __PropertyOffset_14;

		// Token: 0x04016150 RID: 90448
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016151 RID: 90449
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x0200A405 RID: 41989
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032235 RID: 205365
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A406 RID: 41990
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x04032236 RID: 205366
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
