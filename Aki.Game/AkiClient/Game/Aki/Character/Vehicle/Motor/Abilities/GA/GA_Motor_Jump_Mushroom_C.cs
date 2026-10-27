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
	// Token: 0x02004079 RID: 16505
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump_Mushroom.GA_Motor_Jump_Mushroom_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Motor_Jump_Mushroom_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A737 RID: 173879 RVA: 0x009E1100 File Offset: 0x009DF300
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Jump_Mushroom_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump_Mushroom.GA_Motor_Jump_Mushroom_C");
			}
			return GA_Motor_Jump_Mushroom_C._ClassPtr;
		}

		// Token: 0x0602A738 RID: 173880 RVA: 0x009E1124 File Offset: 0x009DF324
		public GA_Motor_Jump_Mushroom_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Jump_Mushroom_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A739 RID: 173881 RVA: 0x009E114C File Offset: 0x009DF34C
		[NullableContext(1)]
		public GA_Motor_Jump_Mushroom_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Jump_Mushroom_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006823 RID: 26659
		// (get) Token: 0x0602A73A RID: 173882 RVA: 0x009E117F File Offset: 0x009DF37F
		// (set) Token: 0x0602A73B RID: 173883 RVA: 0x009E1193 File Offset: 0x009DF393
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Jump_Mushroom_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Jump_Mushroom_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602A73C RID: 173884 RVA: 0x009E11A8 File Offset: 0x009DF3A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetMontageTimeScale(ref float TimeScale)
		{
			GA_Motor_Jump_Mushroom_C.__GetMontageTimeScale_FunctionParams* ptr = stackalloc GA_Motor_Jump_Mushroom_C.__GetMontageTimeScale_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GA_Motor_Jump_Mushroom_C.__GetMontageTimeScale_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Jump_Mushroom_C.__GetMontageTimeScale_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TimeScale = TimeScale;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Mushroom_C.__GetMontageTimeScale_NativeFunctionPtr, (void*)ptr);
			TimeScale = ptr->TimeScale;
		}

		// Token: 0x0602A73D RID: 173885 RVA: 0x009E11F7 File Offset: 0x009DF3F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B3563EE78()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Mushroom_C.__OnTick_CF946D5D4EFE5E5564EFF09B3563EE78_NativeFunctionPtr, null);
		}

		// Token: 0x0602A73E RID: 173886 RVA: 0x009E120B File Offset: 0x009DF40B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B3563EE78()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Mushroom_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B3563EE78_NativeFunctionPtr, null);
		}

		// Token: 0x0602A73F RID: 173887 RVA: 0x009E121F File Offset: 0x009DF41F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B3563EE78()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Mushroom_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B3563EE78_NativeFunctionPtr, null);
		}

		// Token: 0x0602A740 RID: 173888 RVA: 0x009E1233 File Offset: 0x009DF433
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B3563EE78()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Mushroom_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B3563EE78_NativeFunctionPtr, null);
		}

		// Token: 0x0602A741 RID: 173889 RVA: 0x009E1247 File Offset: 0x009DF447
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B3563EE78()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Mushroom_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B3563EE78_NativeFunctionPtr, null);
		}

		// Token: 0x0602A742 RID: 173890 RVA: 0x009E125B File Offset: 0x009DF45B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Mushroom_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A743 RID: 173891 RVA: 0x009E126F File Offset: 0x009DF46F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Jump_Mushroom_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A744 RID: 173892 RVA: 0x009E1284 File Offset: 0x009DF484
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Jump_Mushroom_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Jump_Mushroom_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Jump_Mushroom_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Jump_Mushroom_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_Mushroom_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A745 RID: 173893 RVA: 0x009E12CC File Offset: 0x009DF4CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Jump_Mushroom_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Jump_Mushroom_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Jump_Mushroom_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Jump_Mushroom_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Jump_Mushroom_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A746 RID: 173894 RVA: 0x009E1313 File Offset: 0x009DF513
		protected GA_Motor_Jump_Mushroom_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015EC8 RID: 89800
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump_Mushroom.GA_Motor_Jump_Mushroom_C";

		// Token: 0x04015EC9 RID: 89801
		private static IntPtr _ClassPtr;

		// Token: 0x04015ECA RID: 89802
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015ECB RID: 89803
		internal new static int __PropertyOffset_1;

		// Token: 0x04015ECC RID: 89804
		private static IntPtr __GetMontageTimeScale_NativeFunctionPtr;

		// Token: 0x04015ECD RID: 89805
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B3563EE78_NativeFunctionPtr;

		// Token: 0x04015ECE RID: 89806
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B3563EE78_NativeFunctionPtr;

		// Token: 0x04015ECF RID: 89807
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B3563EE78_NativeFunctionPtr;

		// Token: 0x04015ED0 RID: 89808
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B3563EE78_NativeFunctionPtr;

		// Token: 0x04015ED1 RID: 89809
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B3563EE78_NativeFunctionPtr;

		// Token: 0x04015ED2 RID: 89810
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015ED3 RID: 89811
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3AC RID: 41900
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetMontageTimeScale_FunctionParams
		{
			// Token: 0x04032199 RID: 205209
			[FieldOffset(0)]
			public float TimeScale;
		}

		// Token: 0x0200A3AD RID: 41901
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403219A RID: 205210
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
