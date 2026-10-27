using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x0200407A RID: 16506
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump_WindField.GA_Motor_Jump_WindField_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Motor_Jump_WindField_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A747 RID: 173895 RVA: 0x009E131C File Offset: 0x009DF51C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Jump_WindField_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump_WindField.GA_Motor_Jump_WindField_C");
			}
			return GA_Motor_Jump_WindField_C._ClassPtr;
		}

		// Token: 0x0602A748 RID: 173896 RVA: 0x009E1340 File Offset: 0x009DF540
		public GA_Motor_Jump_WindField_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Jump_WindField_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A749 RID: 173897 RVA: 0x009E1368 File Offset: 0x009DF568
		[NullableContext(1)]
		public GA_Motor_Jump_WindField_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Jump_WindField_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006824 RID: 26660
		// (get) Token: 0x0602A74A RID: 173898 RVA: 0x009E139B File Offset: 0x009DF59B
		// (set) Token: 0x0602A74B RID: 173899 RVA: 0x009E13AF File Offset: 0x009DF5AF
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Jump_WindField_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Jump_WindField_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602A74C RID: 173900 RVA: 0x009E13C4 File Offset: 0x009DF5C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetMontageTimeScale(ref float TimeScale)
		{
			GA_Motor_Jump_WindField_C.__GetMontageTimeScale_FunctionParams* ptr = stackalloc GA_Motor_Jump_WindField_C.__GetMontageTimeScale_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GA_Motor_Jump_WindField_C.__GetMontageTimeScale_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Jump_WindField_C.__GetMontageTimeScale_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TimeScale = TimeScale;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_WindField_C.__GetMontageTimeScale_NativeFunctionPtr, (void*)ptr);
			TimeScale = ptr->TimeScale;
		}

		// Token: 0x0602A74D RID: 173901 RVA: 0x009E1413 File Offset: 0x009DF613
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B8A496968()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_WindField_C.__OnTick_CF946D5D4EFE5E5564EFF09B8A496968_NativeFunctionPtr, null);
		}

		// Token: 0x0602A74E RID: 173902 RVA: 0x009E1427 File Offset: 0x009DF627
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B8A496968()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_WindField_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B8A496968_NativeFunctionPtr, null);
		}

		// Token: 0x0602A74F RID: 173903 RVA: 0x009E143B File Offset: 0x009DF63B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B8A496968()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_WindField_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B8A496968_NativeFunctionPtr, null);
		}

		// Token: 0x0602A750 RID: 173904 RVA: 0x009E144F File Offset: 0x009DF64F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B8A496968()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_WindField_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B8A496968_NativeFunctionPtr, null);
		}

		// Token: 0x0602A751 RID: 173905 RVA: 0x009E1463 File Offset: 0x009DF663
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B8A496968()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_WindField_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B8A496968_NativeFunctionPtr, null);
		}

		// Token: 0x0602A752 RID: 173906 RVA: 0x009E1477 File Offset: 0x009DF677
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09BAD82FE79()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_WindField_C.__OnTick_CF946D5D4EFE5E5564EFF09BAD82FE79_NativeFunctionPtr, null);
		}

		// Token: 0x0602A753 RID: 173907 RVA: 0x009E148B File Offset: 0x009DF68B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09BAD82FE79()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_WindField_C.__OnCancelled_CF946D5D4EFE5E5564EFF09BAD82FE79_NativeFunctionPtr, null);
		}

		// Token: 0x0602A754 RID: 173908 RVA: 0x009E149F File Offset: 0x009DF69F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09BAD82FE79()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_WindField_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09BAD82FE79_NativeFunctionPtr, null);
		}

		// Token: 0x0602A755 RID: 173909 RVA: 0x009E14B3 File Offset: 0x009DF6B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09BAD82FE79()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_WindField_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09BAD82FE79_NativeFunctionPtr, null);
		}

		// Token: 0x0602A756 RID: 173910 RVA: 0x009E14C7 File Offset: 0x009DF6C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09BAD82FE79()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_WindField_C.__OnCompleted_CF946D5D4EFE5E5564EFF09BAD82FE79_NativeFunctionPtr, null);
		}

		// Token: 0x0602A757 RID: 173911 RVA: 0x009E14DB File Offset: 0x009DF6DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_WindField_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A758 RID: 173912 RVA: 0x009E14EF File Offset: 0x009DF6EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Jump_WindField_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A759 RID: 173913 RVA: 0x009E1504 File Offset: 0x009DF704
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Jump_WindField_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Jump_WindField_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Jump_WindField_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Jump_WindField_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_WindField_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A75A RID: 173914 RVA: 0x009E154C File Offset: 0x009DF74C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Jump_WindField_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Jump_WindField_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Jump_WindField_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Jump_WindField_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Jump_WindField_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A75B RID: 173915 RVA: 0x009E1593 File Offset: 0x009DF793
		protected GA_Motor_Jump_WindField_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015ED4 RID: 89812
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump_WindField.GA_Motor_Jump_WindField_C";

		// Token: 0x04015ED5 RID: 89813
		private static IntPtr _ClassPtr;

		// Token: 0x04015ED6 RID: 89814
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015ED7 RID: 89815
		internal new static int __PropertyOffset_1;

		// Token: 0x04015ED8 RID: 89816
		private static IntPtr __GetMontageTimeScale_NativeFunctionPtr;

		// Token: 0x04015ED9 RID: 89817
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B8A496968_NativeFunctionPtr;

		// Token: 0x04015EDA RID: 89818
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B8A496968_NativeFunctionPtr;

		// Token: 0x04015EDB RID: 89819
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B8A496968_NativeFunctionPtr;

		// Token: 0x04015EDC RID: 89820
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B8A496968_NativeFunctionPtr;

		// Token: 0x04015EDD RID: 89821
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B8A496968_NativeFunctionPtr;

		// Token: 0x04015EDE RID: 89822
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09BAD82FE79_NativeFunctionPtr;

		// Token: 0x04015EDF RID: 89823
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09BAD82FE79_NativeFunctionPtr;

		// Token: 0x04015EE0 RID: 89824
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09BAD82FE79_NativeFunctionPtr;

		// Token: 0x04015EE1 RID: 89825
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09BAD82FE79_NativeFunctionPtr;

		// Token: 0x04015EE2 RID: 89826
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09BAD82FE79_NativeFunctionPtr;

		// Token: 0x04015EE3 RID: 89827
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015EE4 RID: 89828
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3AE RID: 41902
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetMontageTimeScale_FunctionParams
		{
			// Token: 0x0403219B RID: 205211
			[FieldOffset(0)]
			public float TimeScale;
		}

		// Token: 0x0200A3AF RID: 41903
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403219C RID: 205212
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
