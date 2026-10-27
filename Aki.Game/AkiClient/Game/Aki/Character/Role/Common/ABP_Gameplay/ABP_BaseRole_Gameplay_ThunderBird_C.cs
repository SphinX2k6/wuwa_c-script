using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay
{
	// Token: 0x0200411C RID: 16668
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_ThunderBird.ABP_BaseRole_Gameplay_ThunderBird_C")]
	[UnrealStructLayout(10432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 10417)]
	public class ABP_BaseRole_Gameplay_ThunderBird_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AEB9 RID: 175801 RVA: 0x009EFCEC File Offset: 0x009EDEEC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_Gameplay_ThunderBird_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_ThunderBird.ABP_BaseRole_Gameplay_ThunderBird_C");
			}
			return ABP_BaseRole_Gameplay_ThunderBird_C._ClassPtr;
		}

		// Token: 0x0602AEBA RID: 175802 RVA: 0x009EFD10 File Offset: 0x009EDF10
		public ABP_BaseRole_Gameplay_ThunderBird_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_ThunderBird_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AEBB RID: 175803 RVA: 0x009EFD38 File Offset: 0x009EDF38
		[NullableContext(1)]
		public ABP_BaseRole_Gameplay_ThunderBird_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_ThunderBird_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069B0 RID: 27056
		// (get) Token: 0x0602AEBC RID: 175804 RVA: 0x009EFD6B File Offset: 0x009EDF6B
		// (set) Token: 0x0602AEBD RID: 175805 RVA: 0x009EFD7B File Offset: 0x009EDF7B
		public unsafe float DeltaTimeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_ThunderBird_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_ThunderBird_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170069B1 RID: 27057
		// (get) Token: 0x0602AEBE RID: 175806 RVA: 0x009EFD8C File Offset: 0x009EDF8C
		// (set) Token: 0x0602AEBF RID: 175807 RVA: 0x009EFDA0 File Offset: 0x009EDFA0
		public unsafe TsBaseCharacter 角色蓝图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_ThunderBird_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_ThunderBird_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x170069B2 RID: 27058
		// (get) Token: 0x0602AEC0 RID: 175808 RVA: 0x009EFDB5 File Offset: 0x009EDFB5
		// (set) Token: 0x0602AEC1 RID: 175809 RVA: 0x009EFDC9 File Offset: 0x009EDFC9
		public unsafe UKuroAnimInstanceChar MainAnimInst
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAnimInstanceChar>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_ThunderBird_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_ThunderBird_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x170069B3 RID: 27059
		// (get) Token: 0x0602AEC2 RID: 175810 RVA: 0x009EFDDE File Offset: 0x009EDFDE
		// (set) Token: 0x0602AEC3 RID: 175811 RVA: 0x009EFDEE File Offset: 0x009EDFEE
		public unsafe bool IsMainAnimInstValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_ThunderBird_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_ThunderBird_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602AEC4 RID: 175812 RVA: 0x009EFE00 File Offset: 0x009EE000
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseRole_Gameplay_ThunderBird_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_ThunderBird_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_ThunderBird_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_ThunderBird_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_ThunderBird_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AEC5 RID: 175813 RVA: 0x009EFE88 File Offset: 0x009EE088
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_ThunderBird_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_ThunderBird_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_ThunderBird_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_ThunderBird_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_ThunderBird_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AEC6 RID: 175814 RVA: 0x009EFED0 File Offset: 0x009EE0D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_ThunderBird_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_ThunderBird_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_ThunderBird_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_ThunderBird_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_ThunderBird_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AEC7 RID: 175815 RVA: 0x009EFF17 File Offset: 0x009EE117
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_ThunderBird_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602AEC8 RID: 175816 RVA: 0x009EFF2B File Offset: 0x009EE12B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_ThunderBird_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AEC9 RID: 175817 RVA: 0x009EFF40 File Offset: 0x009EE140
		protected ABP_BaseRole_Gameplay_ThunderBird_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040163FA RID: 91130
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_ThunderBird.ABP_BaseRole_Gameplay_ThunderBird_C";

		// Token: 0x040163FB RID: 91131
		private static IntPtr _ClassPtr;

		// Token: 0x040163FC RID: 91132
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040163FD RID: 91133
		internal static int __PropertyOffset_12;

		// Token: 0x040163FE RID: 91134
		internal static int __PropertyOffset_13;

		// Token: 0x040163FF RID: 91135
		internal static int __PropertyOffset_14;

		// Token: 0x04016400 RID: 91136
		internal static int __PropertyOffset_15;

		// Token: 0x04016401 RID: 91137
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016402 RID: 91138
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04016403 RID: 91139
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0200A431 RID: 42033
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x0403226C RID: 205420
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A432 RID: 42034
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0403226D RID: 205421
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
