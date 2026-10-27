using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.Accessory.Acc_HYtuanzi_xinyuehu
{
	// Token: 0x02004047 RID: 16455
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Diy/Accessory/Acc_HYtuanzi_xinyuehu/ABP_Acc_HYtuanzi_xinyuehu_PC.ABP_Acc_HYtuanzi_xinyuehu_PC_C")]
	[UnrealStructLayout(3968, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3968)]
	public class ABP_Acc_HYtuanzi_xinyuehu_PC_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A492 RID: 173202 RVA: 0x009DB66C File Offset: 0x009D986C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_Acc_HYtuanzi_xinyuehu_PC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Diy/Accessory/Acc_HYtuanzi_xinyuehu/ABP_Acc_HYtuanzi_xinyuehu_PC.ABP_Acc_HYtuanzi_xinyuehu_PC_C");
			}
			return ABP_Acc_HYtuanzi_xinyuehu_PC_C._ClassPtr;
		}

		// Token: 0x0602A493 RID: 173203 RVA: 0x009DB690 File Offset: 0x009D9890
		public ABP_Acc_HYtuanzi_xinyuehu_PC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_Acc_HYtuanzi_xinyuehu_PC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A494 RID: 173204 RVA: 0x009DB6B8 File Offset: 0x009D98B8
		[NullableContext(1)]
		public ABP_Acc_HYtuanzi_xinyuehu_PC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_Acc_HYtuanzi_xinyuehu_PC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A495 RID: 173205 RVA: 0x009DB6EC File Offset: 0x009D98EC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PhyCloth(FPoseLink InPose, ref FPoseLink PhyCloth)
		{
			ABP_Acc_HYtuanzi_xinyuehu_PC_C.__PhyCloth_FunctionParams* ptr = stackalloc ABP_Acc_HYtuanzi_xinyuehu_PC_C.__PhyCloth_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_Acc_HYtuanzi_xinyuehu_PC_C.__PhyCloth_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Acc_HYtuanzi_xinyuehu_PC_C.__PhyCloth_NativeFunctionPtr, (void*)ptr, 1);
			if (InPose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->InPose, InPose.NativePtr, 1, false);
			}
			if (PhyCloth != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->PhyCloth, PhyCloth.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Acc_HYtuanzi_xinyuehu_PC_C.__PhyCloth_NativeFunctionPtr, (void*)ptr);
			if (PhyCloth != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), PhyCloth.NativePtr, &ptr->PhyCloth, 1, false);
			}
		}

		// Token: 0x0602A496 RID: 173206 RVA: 0x009DB798 File Offset: 0x009D9998
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_Acc_HYtuanzi_xinyuehu_PC_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_Acc_HYtuanzi_xinyuehu_PC_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_Acc_HYtuanzi_xinyuehu_PC_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Acc_HYtuanzi_xinyuehu_PC_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Acc_HYtuanzi_xinyuehu_PC_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602A497 RID: 173207 RVA: 0x009DB81F File Offset: 0x009D9A1F
		protected ABP_Acc_HYtuanzi_xinyuehu_PC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015CE6 RID: 89318
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Diy/Accessory/Acc_HYtuanzi_xinyuehu/ABP_Acc_HYtuanzi_xinyuehu_PC.ABP_Acc_HYtuanzi_xinyuehu_PC_C";

		// Token: 0x04015CE7 RID: 89319
		private static IntPtr _ClassPtr;

		// Token: 0x04015CE8 RID: 89320
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015CE9 RID: 89321
		private static IntPtr __PhyCloth_NativeFunctionPtr;

		// Token: 0x04015CEA RID: 89322
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x0200A35E RID: 41822
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __PhyCloth_FunctionParams
		{
			// Token: 0x0403212D RID: 205101
			[FieldOffset(0)]
			public byte InPose;

			// Token: 0x0403212E RID: 205102
			[FieldOffset(24)]
			public byte PhyCloth;
		}

		// Token: 0x0200A35F RID: 41823
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x0403212F RID: 205103
			[FieldOffset(0)]
			public byte AnimGraph;
		}
	}
}
