using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Seq.ABP
{
	// Token: 0x0200403E RID: 16446
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Seq/ABP/ABP_Motor_BaseVehicle_Seq_V2.ABP_Motor_BaseVehicle_Seq_V2_C")]
	[UnrealStructLayout(2672, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2664)]
	public class ABP_Motor_BaseVehicle_Seq_V2_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A361 RID: 172897 RVA: 0x009D9504 File Offset: 0x009D7704
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_Motor_BaseVehicle_Seq_V2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Seq/ABP/ABP_Motor_BaseVehicle_Seq_V2.ABP_Motor_BaseVehicle_Seq_V2_C");
			}
			return ABP_Motor_BaseVehicle_Seq_V2_C._ClassPtr;
		}

		// Token: 0x0602A362 RID: 172898 RVA: 0x009D9528 File Offset: 0x009D7728
		public ABP_Motor_BaseVehicle_Seq_V2_C() : this(BuiltinUtils.AllocNativeUObject(ABP_Motor_BaseVehicle_Seq_V2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A363 RID: 172899 RVA: 0x009D9550 File Offset: 0x009D7750
		[NullableContext(1)]
		public ABP_Motor_BaseVehicle_Seq_V2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_Motor_BaseVehicle_Seq_V2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A364 RID: 172900 RVA: 0x009D9584 File Offset: 0x009D7784
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(FPoseLink InPose, ref FPoseLink AnimGraph)
		{
			ABP_Motor_BaseVehicle_Seq_V2_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_Motor_BaseVehicle_Seq_V2_C.__AnimGraph_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_Motor_BaseVehicle_Seq_V2_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Motor_BaseVehicle_Seq_V2_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (InPose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->InPose, InPose.NativePtr, 1, false);
			}
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Motor_BaseVehicle_Seq_V2_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602A365 RID: 172901 RVA: 0x009D962D File Offset: 0x009D782D
		protected ABP_Motor_BaseVehicle_Seq_V2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C33 RID: 89139
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Seq/ABP/ABP_Motor_BaseVehicle_Seq_V2.ABP_Motor_BaseVehicle_Seq_V2_C";

		// Token: 0x04015C34 RID: 89140
		private static IntPtr _ClassPtr;

		// Token: 0x04015C35 RID: 89141
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015C36 RID: 89142
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x0200A34E RID: 41806
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032115 RID: 205077
			[FieldOffset(0)]
			public byte InPose;

			// Token: 0x04032116 RID: 205078
			[FieldOffset(24)]
			public byte AnimGraph;
		}
	}
}
