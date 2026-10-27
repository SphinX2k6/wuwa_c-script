using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.YangYangBirds
{
	// Token: 0x02003A73 RID: 14963
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/YangYangBirds/ANS_YangyangBirds_Skill.ANS_YangyangBirds_Skill_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class ANS_YangyangBirds_Skill_C : UKuroAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FADD RID: 129757 RVA: 0x008BF53A File Offset: 0x008BD73A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ANS_YangyangBirds_Skill_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/YangYangBirds/ANS_YangyangBirds_Skill.ANS_YangyangBirds_Skill_C");
			}
			return ANS_YangyangBirds_Skill_C._ClassPtr;
		}

		// Token: 0x0601FADE RID: 129758 RVA: 0x008BF560 File Offset: 0x008BD760
		public ANS_YangyangBirds_Skill_C() : this(BuiltinUtils.AllocNativeUObject(ANS_YangyangBirds_Skill_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FADF RID: 129759 RVA: 0x008BF588 File Offset: 0x008BD788
		[NullableContext(1)]
		public ANS_YangyangBirds_Skill_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANS_YangyangBirds_Skill_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601FAE0 RID: 129760 RVA: 0x008BF5BC File Offset: 0x008BD7BC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			ANS_YangyangBirds_Skill_C.__K2_NotifyEnd_FunctionParams* ptr = stackalloc ANS_YangyangBirds_Skill_C.__K2_NotifyEnd_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ANS_YangyangBirds_Skill_C.__K2_NotifyEnd_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_YangyangBirds_Skill_C.__K2_NotifyEnd_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ANS_YangyangBirds_Skill_C.__K2_NotifyEnd_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601FAE1 RID: 129761 RVA: 0x008BF630 File Offset: 0x008BD830
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			ANS_YangyangBirds_Skill_C.__K2_NotifyEnd_FunctionParams* ptr = stackalloc ANS_YangyangBirds_Skill_C.__K2_NotifyEnd_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ANS_YangyangBirds_Skill_C.__K2_NotifyEnd_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_YangyangBirds_Skill_C.__K2_NotifyEnd_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ANS_YangyangBirds_Skill_C.__K2_NotifyEnd_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601FAE2 RID: 129762 RVA: 0x008BF6A4 File Offset: 0x008BD8A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			ANS_YangyangBirds_Skill_C.__K2_NotifyBegin_FunctionParams* ptr = stackalloc ANS_YangyangBirds_Skill_C.__K2_NotifyBegin_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ANS_YangyangBirds_Skill_C.__K2_NotifyBegin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_YangyangBirds_Skill_C.__K2_NotifyBegin_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->TotalDuration = TotalDuration;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ANS_YangyangBirds_Skill_C.__K2_NotifyBegin_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601FAE3 RID: 129763 RVA: 0x008BF71C File Offset: 0x008BD91C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			ANS_YangyangBirds_Skill_C.__K2_NotifyBegin_FunctionParams* ptr = stackalloc ANS_YangyangBirds_Skill_C.__K2_NotifyBegin_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ANS_YangyangBirds_Skill_C.__K2_NotifyBegin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_YangyangBirds_Skill_C.__K2_NotifyBegin_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->TotalDuration = TotalDuration;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ANS_YangyangBirds_Skill_C.__K2_NotifyBegin_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601FAE4 RID: 129764 RVA: 0x008BF798 File Offset: 0x008BD998
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool Received_NotifyTick(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			ANS_YangyangBirds_Skill_C.__Received_NotifyTick_FunctionParams* ptr = stackalloc ANS_YangyangBirds_Skill_C.__Received_NotifyTick_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ANS_YangyangBirds_Skill_C.__Received_NotifyTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_YangyangBirds_Skill_C.__Received_NotifyTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->FrameDeltaTime = FrameDeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ANS_YangyangBirds_Skill_C.__Received_NotifyTick_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601FAE5 RID: 129765 RVA: 0x008BF810 File Offset: 0x008BDA10
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool Received_NotifyTick_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			ANS_YangyangBirds_Skill_C.__Received_NotifyTick_FunctionParams* ptr = stackalloc ANS_YangyangBirds_Skill_C.__Received_NotifyTick_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ANS_YangyangBirds_Skill_C.__Received_NotifyTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_YangyangBirds_Skill_C.__Received_NotifyTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->FrameDeltaTime = FrameDeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ANS_YangyangBirds_Skill_C.__Received_NotifyTick_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601FAE6 RID: 129766 RVA: 0x008BF889 File Offset: 0x008BDA89
		protected ANS_YangyangBirds_Skill_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F40C RID: 62476
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/YangYangBirds/ANS_YangyangBirds_Skill.ANS_YangyangBirds_Skill_C";

		// Token: 0x0400F40D RID: 62477
		private static IntPtr _ClassPtr;

		// Token: 0x0400F40E RID: 62478
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F40F RID: 62479
		private static IntPtr __K2_NotifyEnd_NativeFunctionPtr;

		// Token: 0x0400F410 RID: 62480
		private static IntPtr __K2_NotifyBegin_NativeFunctionPtr;

		// Token: 0x0400F411 RID: 62481
		private static IntPtr __Received_NotifyTick_NativeFunctionPtr;

		// Token: 0x02009B32 RID: 39730
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected new ref struct __K2_NotifyEnd_FunctionParams
		{
			// Token: 0x0403113B RID: 201019
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x0403113C RID: 201020
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x0403113D RID: 201021
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02009B33 RID: 39731
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected new ref struct __K2_NotifyBegin_FunctionParams
		{
			// Token: 0x0403113E RID: 201022
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x0403113F RID: 201023
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04031140 RID: 201024
			[FieldOffset(16)]
			public float TotalDuration;

			// Token: 0x04031141 RID: 201025
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x02009B34 RID: 39732
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected new ref struct __Received_NotifyTick_FunctionParams
		{
			// Token: 0x04031142 RID: 201026
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04031143 RID: 201027
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04031144 RID: 201028
			[FieldOffset(16)]
			public float FrameDeltaTime;

			// Token: 0x04031145 RID: 201029
			[FieldOffset(20)]
			public bool __Result;
		}
	}
}
