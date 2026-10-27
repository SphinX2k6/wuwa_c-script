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
	// Token: 0x02004078 RID: 16504
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump_Luxin.GA_Motor_Jump_Luxin_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Motor_Jump_Luxin_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A723 RID: 173859 RVA: 0x009E0ECC File Offset: 0x009DF0CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Jump_Luxin_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump_Luxin.GA_Motor_Jump_Luxin_C");
			}
			return GA_Motor_Jump_Luxin_C._ClassPtr;
		}

		// Token: 0x0602A724 RID: 173860 RVA: 0x009E0EF0 File Offset: 0x009DF0F0
		public GA_Motor_Jump_Luxin_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Jump_Luxin_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A725 RID: 173861 RVA: 0x009E0F18 File Offset: 0x009DF118
		[NullableContext(1)]
		public GA_Motor_Jump_Luxin_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Jump_Luxin_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006822 RID: 26658
		// (get) Token: 0x0602A726 RID: 173862 RVA: 0x009E0F4B File Offset: 0x009DF14B
		// (set) Token: 0x0602A727 RID: 173863 RVA: 0x009E0F5F File Offset: 0x009DF15F
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Jump_Luxin_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Jump_Luxin_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602A728 RID: 173864 RVA: 0x009E0F74 File Offset: 0x009DF174
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B34677F89()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Luxin_C.__OnTick_CF946D5D4EFE5E5564EFF09B34677F89_NativeFunctionPtr, null);
		}

		// Token: 0x0602A729 RID: 173865 RVA: 0x009E0F88 File Offset: 0x009DF188
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B34677F89()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Luxin_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B34677F89_NativeFunctionPtr, null);
		}

		// Token: 0x0602A72A RID: 173866 RVA: 0x009E0F9C File Offset: 0x009DF19C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B34677F89()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Luxin_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B34677F89_NativeFunctionPtr, null);
		}

		// Token: 0x0602A72B RID: 173867 RVA: 0x009E0FB0 File Offset: 0x009DF1B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B34677F89()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Luxin_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B34677F89_NativeFunctionPtr, null);
		}

		// Token: 0x0602A72C RID: 173868 RVA: 0x009E0FC4 File Offset: 0x009DF1C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B34677F89()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Luxin_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B34677F89_NativeFunctionPtr, null);
		}

		// Token: 0x0602A72D RID: 173869 RVA: 0x009E0FD8 File Offset: 0x009DF1D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B20248DFD()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Luxin_C.__OnTick_CF946D5D4EFE5E5564EFF09B20248DFD_NativeFunctionPtr, null);
		}

		// Token: 0x0602A72E RID: 173870 RVA: 0x009E0FEC File Offset: 0x009DF1EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B20248DFD()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Luxin_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B20248DFD_NativeFunctionPtr, null);
		}

		// Token: 0x0602A72F RID: 173871 RVA: 0x009E1000 File Offset: 0x009DF200
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B20248DFD()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Luxin_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B20248DFD_NativeFunctionPtr, null);
		}

		// Token: 0x0602A730 RID: 173872 RVA: 0x009E1014 File Offset: 0x009DF214
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B20248DFD()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Luxin_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B20248DFD_NativeFunctionPtr, null);
		}

		// Token: 0x0602A731 RID: 173873 RVA: 0x009E1028 File Offset: 0x009DF228
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B20248DFD()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Luxin_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B20248DFD_NativeFunctionPtr, null);
		}

		// Token: 0x0602A732 RID: 173874 RVA: 0x009E103C File Offset: 0x009DF23C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Luxin_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A733 RID: 173875 RVA: 0x009E1050 File Offset: 0x009DF250
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Jump_Luxin_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A734 RID: 173876 RVA: 0x009E1068 File Offset: 0x009DF268
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Jump_Luxin_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Jump_Luxin_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Jump_Luxin_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Jump_Luxin_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Luxin_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A735 RID: 173877 RVA: 0x009E10B0 File Offset: 0x009DF2B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Jump_Luxin_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Jump_Luxin_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Jump_Luxin_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Jump_Luxin_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Jump_Luxin_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A736 RID: 173878 RVA: 0x009E10F7 File Offset: 0x009DF2F7
		protected GA_Motor_Jump_Luxin_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015EB8 RID: 89784
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump_Luxin.GA_Motor_Jump_Luxin_C";

		// Token: 0x04015EB9 RID: 89785
		private static IntPtr _ClassPtr;

		// Token: 0x04015EBA RID: 89786
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015EBB RID: 89787
		internal new static int __PropertyOffset_1;

		// Token: 0x04015EBC RID: 89788
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B34677F89_NativeFunctionPtr;

		// Token: 0x04015EBD RID: 89789
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B34677F89_NativeFunctionPtr;

		// Token: 0x04015EBE RID: 89790
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B34677F89_NativeFunctionPtr;

		// Token: 0x04015EBF RID: 89791
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B34677F89_NativeFunctionPtr;

		// Token: 0x04015EC0 RID: 89792
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B34677F89_NativeFunctionPtr;

		// Token: 0x04015EC1 RID: 89793
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B20248DFD_NativeFunctionPtr;

		// Token: 0x04015EC2 RID: 89794
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B20248DFD_NativeFunctionPtr;

		// Token: 0x04015EC3 RID: 89795
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B20248DFD_NativeFunctionPtr;

		// Token: 0x04015EC4 RID: 89796
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B20248DFD_NativeFunctionPtr;

		// Token: 0x04015EC5 RID: 89797
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B20248DFD_NativeFunctionPtr;

		// Token: 0x04015EC6 RID: 89798
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015EC7 RID: 89799
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3AB RID: 41899
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032198 RID: 205208
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
