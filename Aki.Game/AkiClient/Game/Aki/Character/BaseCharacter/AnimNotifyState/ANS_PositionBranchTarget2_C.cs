using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.AnimNotifyState
{
	// Token: 0x020043E2 RID: 17378
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/AnimNotifyState/ANS_PositionBranchTarget2.ANS_PositionBranchTarget2_C")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 189)]
	public class ANS_PositionBranchTarget2_C : UKuroAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D052 RID: 184402 RVA: 0x00A2E870 File Offset: 0x00A2CA70
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ANS_PositionBranchTarget2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/AnimNotifyState/ANS_PositionBranchTarget2.ANS_PositionBranchTarget2_C");
			}
			return ANS_PositionBranchTarget2_C._ClassPtr;
		}

		// Token: 0x0602D053 RID: 184403 RVA: 0x00A2E894 File Offset: 0x00A2CA94
		public ANS_PositionBranchTarget2_C() : this(BuiltinUtils.AllocNativeUObject(ANS_PositionBranchTarget2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D054 RID: 184404 RVA: 0x00A2E8BC File Offset: 0x00A2CABC
		[NullableContext(1)]
		public ANS_PositionBranchTarget2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANS_PositionBranchTarget2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007212 RID: 29202
		// (get) Token: 0x0602D055 RID: 184405 RVA: 0x00A2E8EF File Offset: 0x00A2CAEF
		// (set) Token: 0x0602D056 RID: 184406 RVA: 0x00A2E903 File Offset: 0x00A2CB03
		public unsafe TsBaseCharacter BaseChar
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ANS_PositionBranchTarget2_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANS_PositionBranchTarget2_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17007213 RID: 29203
		// (get) Token: 0x0602D057 RID: 184407 RVA: 0x00A2E918 File Offset: 0x00A2CB18
		// (set) Token: 0x0602D058 RID: 184408 RVA: 0x00A2E92C File Offset: 0x00A2CB2C
		public unsafe AActor Target
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + ANS_PositionBranchTarget2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANS_PositionBranchTarget2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17007214 RID: 29204
		// (get) Token: 0x0602D059 RID: 184409 RVA: 0x00A2E941 File Offset: 0x00A2CB41
		// (set) Token: 0x0602D05A RID: 184410 RVA: 0x00A2E955 File Offset: 0x00A2CB55
		public unsafe UCurveFloat MoveCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ANS_PositionBranchTarget2_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANS_PositionBranchTarget2_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17007215 RID: 29205
		// (get) Token: 0x0602D05B RID: 184411 RVA: 0x00A2E96A File Offset: 0x00A2CB6A
		// (set) Token: 0x0602D05C RID: 184412 RVA: 0x00A2E97A File Offset: 0x00A2CB7A
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17007216 RID: 29206
		// (get) Token: 0x0602D05D RID: 184413 RVA: 0x00A2E98B File Offset: 0x00A2CB8B
		// (set) Token: 0x0602D05E RID: 184414 RVA: 0x00A2E99B File Offset: 0x00A2CB9B
		public unsafe float MaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17007217 RID: 29207
		// (get) Token: 0x0602D05F RID: 184415 RVA: 0x00A2E9AC File Offset: 0x00A2CBAC
		// (set) Token: 0x0602D060 RID: 184416 RVA: 0x00A2E9BC File Offset: 0x00A2CBBC
		public unsafe bool 是否永远面向目标
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007218 RID: 29208
		// (get) Token: 0x0602D061 RID: 184417 RVA: 0x00A2E9CD File Offset: 0x00A2CBCD
		// (set) Token: 0x0602D062 RID: 184418 RVA: 0x00A2E9DD File Offset: 0x00A2CBDD
		public unsafe bool 忽略Z轴方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007219 RID: 29209
		// (get) Token: 0x0602D063 RID: 184419 RVA: 0x00A2E9EE File Offset: 0x00A2CBEE
		// (set) Token: 0x0602D064 RID: 184420 RVA: 0x00A2E9FE File Offset: 0x00A2CBFE
		public unsafe bool 忽略双方半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700721A RID: 29210
		// (get) Token: 0x0602D065 RID: 184421 RVA: 0x00A2EA0F File Offset: 0x00A2CC0F
		// (set) Token: 0x0602D066 RID: 184422 RVA: 0x00A2EA1F File Offset: 0x00A2CC1F
		public unsafe float NowTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700721B RID: 29211
		// (get) Token: 0x0602D067 RID: 184423 RVA: 0x00A2EA30 File Offset: 0x00A2CC30
		// (set) Token: 0x0602D068 RID: 184424 RVA: 0x00A2EA40 File Offset: 0x00A2CC40
		public unsafe float TotalTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700721C RID: 29212
		// (get) Token: 0x0602D069 RID: 184425 RVA: 0x00A2EA51 File Offset: 0x00A2CC51
		// (set) Token: 0x0602D06A RID: 184426 RVA: 0x00A2EA65 File Offset: 0x00A2CC65
		[Nullable(1)]
		public unsafe string SocketName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_10)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_10)), value);
			}
		}

		// Token: 0x1700721D RID: 29213
		// (get) Token: 0x0602D06B RID: 184427 RVA: 0x00A2EA7A File Offset: 0x00A2CC7A
		// (set) Token: 0x0602D06C RID: 184428 RVA: 0x00A2EA8A File Offset: 0x00A2CC8A
		public unsafe bool IsShareTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700721E RID: 29214
		// (get) Token: 0x0602D06D RID: 184429 RVA: 0x00A2EA9B File Offset: 0x00A2CC9B
		// (set) Token: 0x0602D06E RID: 184430 RVA: 0x00A2EAAF File Offset: 0x00A2CCAF
		public unsafe FVectorDouble TargetOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700721F RID: 29215
		// (get) Token: 0x0602D06F RID: 184431 RVA: 0x00A2EAC4 File Offset: 0x00A2CCC4
		// (set) Token: 0x0602D070 RID: 184432 RVA: 0x00A2EAD8 File Offset: 0x00A2CCD8
		public unsafe FRotator TargetRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17007220 RID: 29216
		// (get) Token: 0x0602D071 RID: 184433 RVA: 0x00A2EAED File Offset: 0x00A2CCED
		// (set) Token: 0x0602D072 RID: 184434 RVA: 0x00A2EAFD File Offset: 0x00A2CCFD
		public unsafe bool 允许反向移动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANS_PositionBranchTarget2_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602D073 RID: 184435 RVA: 0x00A2EB10 File Offset: 0x00A2CD10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MoveToTarget(float Rate, float DeltaTime)
		{
			ANS_PositionBranchTarget2_C.__MoveToTarget_FunctionParams* ptr = stackalloc ANS_PositionBranchTarget2_C.__MoveToTarget_FunctionParams[(UIntPtr)959] + 15L / (long)sizeof(ANS_PositionBranchTarget2_C.__MoveToTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_PositionBranchTarget2_C.__MoveToTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Rate = Rate;
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ANS_PositionBranchTarget2_C.__MoveToTarget_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D074 RID: 184436 RVA: 0x00A2EB60 File Offset: 0x00A2CD60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool K2_NotifyTick(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			ANS_PositionBranchTarget2_C.__K2_NotifyTick_FunctionParams* ptr = stackalloc ANS_PositionBranchTarget2_C.__K2_NotifyTick_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(ANS_PositionBranchTarget2_C.__K2_NotifyTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_PositionBranchTarget2_C.__K2_NotifyTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->FrameDeltaTime = FrameDeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ANS_PositionBranchTarget2_C.__K2_NotifyTick_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602D075 RID: 184437 RVA: 0x00A2EBD8 File Offset: 0x00A2CDD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			ANS_PositionBranchTarget2_C.__K2_NotifyTick_FunctionParams* ptr = stackalloc ANS_PositionBranchTarget2_C.__K2_NotifyTick_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(ANS_PositionBranchTarget2_C.__K2_NotifyTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_PositionBranchTarget2_C.__K2_NotifyTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->FrameDeltaTime = FrameDeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ANS_PositionBranchTarget2_C.__K2_NotifyTick_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602D076 RID: 184438 RVA: 0x00A2EC54 File Offset: 0x00A2CE54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			ANS_PositionBranchTarget2_C.__K2_NotifyEnd_FunctionParams* ptr = stackalloc ANS_PositionBranchTarget2_C.__K2_NotifyEnd_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ANS_PositionBranchTarget2_C.__K2_NotifyEnd_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_PositionBranchTarget2_C.__K2_NotifyEnd_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ANS_PositionBranchTarget2_C.__K2_NotifyEnd_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602D077 RID: 184439 RVA: 0x00A2ECC8 File Offset: 0x00A2CEC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			ANS_PositionBranchTarget2_C.__K2_NotifyEnd_FunctionParams* ptr = stackalloc ANS_PositionBranchTarget2_C.__K2_NotifyEnd_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ANS_PositionBranchTarget2_C.__K2_NotifyEnd_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_PositionBranchTarget2_C.__K2_NotifyEnd_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ANS_PositionBranchTarget2_C.__K2_NotifyEnd_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602D078 RID: 184440 RVA: 0x00A2ED3C File Offset: 0x00A2CF3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			ANS_PositionBranchTarget2_C.__K2_NotifyBegin_FunctionParams* ptr = stackalloc ANS_PositionBranchTarget2_C.__K2_NotifyBegin_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(ANS_PositionBranchTarget2_C.__K2_NotifyBegin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_PositionBranchTarget2_C.__K2_NotifyBegin_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->TotalDuration = TotalDuration;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ANS_PositionBranchTarget2_C.__K2_NotifyBegin_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602D079 RID: 184441 RVA: 0x00A2EDB8 File Offset: 0x00A2CFB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			ANS_PositionBranchTarget2_C.__K2_NotifyBegin_FunctionParams* ptr = stackalloc ANS_PositionBranchTarget2_C.__K2_NotifyBegin_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(ANS_PositionBranchTarget2_C.__K2_NotifyBegin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_PositionBranchTarget2_C.__K2_NotifyBegin_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->TotalDuration = TotalDuration;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ANS_PositionBranchTarget2_C.__K2_NotifyBegin_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602D07A RID: 184442 RVA: 0x00A2EE34 File Offset: 0x00A2D034
		protected ANS_PositionBranchTarget2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E3E RID: 97854
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/AnimNotifyState/ANS_PositionBranchTarget2.ANS_PositionBranchTarget2_C";

		// Token: 0x04017E3F RID: 97855
		private static IntPtr _ClassPtr;

		// Token: 0x04017E40 RID: 97856
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017E41 RID: 97857
		internal static int __PropertyOffset_0;

		// Token: 0x04017E42 RID: 97858
		internal static int __PropertyOffset_1;

		// Token: 0x04017E43 RID: 97859
		internal static int __PropertyOffset_2;

		// Token: 0x04017E44 RID: 97860
		internal static int __PropertyOffset_3;

		// Token: 0x04017E45 RID: 97861
		internal static int __PropertyOffset_4;

		// Token: 0x04017E46 RID: 97862
		internal static int __PropertyOffset_5;

		// Token: 0x04017E47 RID: 97863
		internal static int __PropertyOffset_6;

		// Token: 0x04017E48 RID: 97864
		internal static int __PropertyOffset_7;

		// Token: 0x04017E49 RID: 97865
		internal static int __PropertyOffset_8;

		// Token: 0x04017E4A RID: 97866
		internal static int __PropertyOffset_9;

		// Token: 0x04017E4B RID: 97867
		internal static int __PropertyOffset_10;

		// Token: 0x04017E4C RID: 97868
		internal static int __PropertyOffset_11;

		// Token: 0x04017E4D RID: 97869
		internal static int __PropertyOffset_12;

		// Token: 0x04017E4E RID: 97870
		internal static int __PropertyOffset_13;

		// Token: 0x04017E4F RID: 97871
		internal static int __PropertyOffset_14;

		// Token: 0x04017E50 RID: 97872
		private static IntPtr __MoveToTarget_NativeFunctionPtr;

		// Token: 0x04017E51 RID: 97873
		private static IntPtr __K2_NotifyTick_NativeFunctionPtr;

		// Token: 0x04017E52 RID: 97874
		private static IntPtr __K2_NotifyEnd_NativeFunctionPtr;

		// Token: 0x04017E53 RID: 97875
		private static IntPtr __K2_NotifyBegin_NativeFunctionPtr;

		// Token: 0x0200A677 RID: 42615
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 944)]
		protected ref struct __MoveToTarget_FunctionParams
		{
			// Token: 0x040325BB RID: 206267
			[FieldOffset(0)]
			public float Rate;

			// Token: 0x040325BC RID: 206268
			[FieldOffset(4)]
			public float DeltaTime;
		}

		// Token: 0x0200A678 RID: 42616
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected new ref struct __K2_NotifyTick_FunctionParams
		{
			// Token: 0x040325BD RID: 206269
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x040325BE RID: 206270
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x040325BF RID: 206271
			[FieldOffset(16)]
			public float FrameDeltaTime;

			// Token: 0x040325C0 RID: 206272
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x0200A679 RID: 42617
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected new ref struct __K2_NotifyEnd_FunctionParams
		{
			// Token: 0x040325C1 RID: 206273
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x040325C2 RID: 206274
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x040325C3 RID: 206275
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x0200A67A RID: 42618
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected new ref struct __K2_NotifyBegin_FunctionParams
		{
			// Token: 0x040325C4 RID: 206276
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x040325C5 RID: 206277
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x040325C6 RID: 206278
			[FieldOffset(16)]
			public float TotalDuration;

			// Token: 0x040325C7 RID: 206279
			[FieldOffset(20)]
			public bool __Result;
		}
	}
}
