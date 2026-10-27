using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common
{
	// Token: 0x0200409F RID: 16543
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_PhysicsClothBlendAlpha_Template.ABP_PhysicsClothBlendAlpha_Template_C")]
	[UnrealStructLayout(3040, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3032)]
	public class ABP_PhysicsClothBlendAlpha_Template_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AB48 RID: 174920 RVA: 0x009E9531 File Offset: 0x009E7731
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_PhysicsClothBlendAlpha_Template_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_PhysicsClothBlendAlpha_Template.ABP_PhysicsClothBlendAlpha_Template_C");
			}
			return ABP_PhysicsClothBlendAlpha_Template_C._ClassPtr;
		}

		// Token: 0x0602AB49 RID: 174921 RVA: 0x009E9558 File Offset: 0x009E7758
		public ABP_PhysicsClothBlendAlpha_Template_C() : this(BuiltinUtils.AllocNativeUObject(ABP_PhysicsClothBlendAlpha_Template_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AB4A RID: 174922 RVA: 0x009E9580 File Offset: 0x009E7780
		[NullableContext(1)]
		public ABP_PhysicsClothBlendAlpha_Template_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_PhysicsClothBlendAlpha_Template_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700690F RID: 26895
		// (get) Token: 0x0602AB4B RID: 174923 RVA: 0x009E95B3 File Offset: 0x009E77B3
		// (set) Token: 0x0602AB4C RID: 174924 RVA: 0x009E95C3 File Offset: 0x009E77C3
		public unsafe bool PhysicsClothSimulateEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PhysicsClothBlendAlpha_Template_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PhysicsClothBlendAlpha_Template_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006910 RID: 26896
		// (get) Token: 0x0602AB4D RID: 174925 RVA: 0x009E95D4 File Offset: 0x009E77D4
		// (set) Token: 0x0602AB4E RID: 174926 RVA: 0x009E95E4 File Offset: 0x009E77E4
		public unsafe float PhysicsClothSimulateScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PhysicsClothBlendAlpha_Template_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PhysicsClothBlendAlpha_Template_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x0602AB4F RID: 174927 RVA: 0x009E95F8 File Offset: 0x009E77F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PhyCloth(FPoseLink InPose, ref FPoseLink PhyCloth)
		{
			ABP_PhysicsClothBlendAlpha_Template_C.__PhyCloth_FunctionParams* ptr = stackalloc ABP_PhysicsClothBlendAlpha_Template_C.__PhyCloth_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_PhysicsClothBlendAlpha_Template_C.__PhyCloth_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PhysicsClothBlendAlpha_Template_C.__PhyCloth_NativeFunctionPtr, (void*)ptr, 1);
			if (InPose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->InPose, InPose.NativePtr, 1, false);
			}
			if (PhyCloth != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->PhyCloth, PhyCloth.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PhysicsClothBlendAlpha_Template_C.__PhyCloth_NativeFunctionPtr, (void*)ptr);
			if (PhyCloth != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), PhyCloth.NativePtr, &ptr->PhyCloth, 1, false);
			}
		}

		// Token: 0x0602AB50 RID: 174928 RVA: 0x009E96A4 File Offset: 0x009E78A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_PhysicsClothBlendAlpha_Template_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_PhysicsClothBlendAlpha_Template_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_PhysicsClothBlendAlpha_Template_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PhysicsClothBlendAlpha_Template_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PhysicsClothBlendAlpha_Template_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AB51 RID: 174929 RVA: 0x009E972C File Offset: 0x009E792C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdatePhysicsClothSimulateEnable(float DeltaTIme)
		{
			ABP_PhysicsClothBlendAlpha_Template_C.__UpdatePhysicsClothSimulateEnable_FunctionParams* ptr = stackalloc ABP_PhysicsClothBlendAlpha_Template_C.__UpdatePhysicsClothSimulateEnable_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ABP_PhysicsClothBlendAlpha_Template_C.__UpdatePhysicsClothSimulateEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PhysicsClothBlendAlpha_Template_C.__UpdatePhysicsClothSimulateEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTIme = DeltaTIme;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PhysicsClothBlendAlpha_Template_C.__UpdatePhysicsClothSimulateEnable_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AB52 RID: 174930 RVA: 0x009E9774 File Offset: 0x009E7974
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_PhysicsClothBlendAlpha_Template_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_PhysicsClothBlendAlpha_Template_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PhysicsClothBlendAlpha_Template_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PhysicsClothBlendAlpha_Template_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PhysicsClothBlendAlpha_Template_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AB53 RID: 174931 RVA: 0x009E97BC File Offset: 0x009E79BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_PhysicsClothBlendAlpha_Template_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_PhysicsClothBlendAlpha_Template_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PhysicsClothBlendAlpha_Template_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PhysicsClothBlendAlpha_Template_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_PhysicsClothBlendAlpha_Template_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AB54 RID: 174932 RVA: 0x009E9803 File Offset: 0x009E7A03
		protected ABP_PhysicsClothBlendAlpha_Template_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401619D RID: 90525
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_PhysicsClothBlendAlpha_Template.ABP_PhysicsClothBlendAlpha_Template_C";

		// Token: 0x0401619E RID: 90526
		private static IntPtr _ClassPtr;

		// Token: 0x0401619F RID: 90527
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040161A0 RID: 90528
		internal static int __PropertyOffset_6;

		// Token: 0x040161A1 RID: 90529
		internal static int __PropertyOffset_7;

		// Token: 0x040161A2 RID: 90530
		private static IntPtr __PhyCloth_NativeFunctionPtr;

		// Token: 0x040161A3 RID: 90531
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x040161A4 RID: 90532
		private static IntPtr __UpdatePhysicsClothSimulateEnable_NativeFunctionPtr;

		// Token: 0x040161A5 RID: 90533
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x0200A414 RID: 42004
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __PhyCloth_FunctionParams
		{
			// Token: 0x0403224C RID: 205388
			[FieldOffset(0)]
			public byte InPose;

			// Token: 0x0403224D RID: 205389
			[FieldOffset(24)]
			public byte PhyCloth;
		}

		// Token: 0x0200A415 RID: 42005
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x0403224E RID: 205390
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A416 RID: 42006
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UpdatePhysicsClothSimulateEnable_FunctionParams
		{
			// Token: 0x0403224F RID: 205391
			[FieldOffset(0)]
			public float DeltaTIme;
		}

		// Token: 0x0200A417 RID: 42007
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x04032250 RID: 205392
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
