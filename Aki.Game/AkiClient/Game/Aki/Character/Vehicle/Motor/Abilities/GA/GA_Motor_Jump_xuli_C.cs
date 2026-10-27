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
	// Token: 0x0200407B RID: 16507
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump_xuli.GA_Motor_Jump_xuli_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Motor_Jump_xuli_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A75C RID: 173916 RVA: 0x009E159C File Offset: 0x009DF79C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Jump_xuli_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump_xuli.GA_Motor_Jump_xuli_C");
			}
			return GA_Motor_Jump_xuli_C._ClassPtr;
		}

		// Token: 0x0602A75D RID: 173917 RVA: 0x009E15C0 File Offset: 0x009DF7C0
		public GA_Motor_Jump_xuli_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Jump_xuli_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A75E RID: 173918 RVA: 0x009E15E8 File Offset: 0x009DF7E8
		[NullableContext(1)]
		public GA_Motor_Jump_xuli_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Jump_xuli_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006825 RID: 26661
		// (get) Token: 0x0602A75F RID: 173919 RVA: 0x009E161B File Offset: 0x009DF81B
		// (set) Token: 0x0602A760 RID: 173920 RVA: 0x009E162F File Offset: 0x009DF82F
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Jump_xuli_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Jump_xuli_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602A761 RID: 173921 RVA: 0x009E1644 File Offset: 0x009DF844
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09BF7333244()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_xuli_C.__OnTick_CF946D5D4EFE5E5564EFF09BF7333244_NativeFunctionPtr, null);
		}

		// Token: 0x0602A762 RID: 173922 RVA: 0x009E1658 File Offset: 0x009DF858
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09BF7333244()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_xuli_C.__OnCancelled_CF946D5D4EFE5E5564EFF09BF7333244_NativeFunctionPtr, null);
		}

		// Token: 0x0602A763 RID: 173923 RVA: 0x009E166C File Offset: 0x009DF86C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09BF7333244()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_xuli_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09BF7333244_NativeFunctionPtr, null);
		}

		// Token: 0x0602A764 RID: 173924 RVA: 0x009E1680 File Offset: 0x009DF880
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09BF7333244()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_xuli_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09BF7333244_NativeFunctionPtr, null);
		}

		// Token: 0x0602A765 RID: 173925 RVA: 0x009E1694 File Offset: 0x009DF894
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09BF7333244()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_xuli_C.__OnCompleted_CF946D5D4EFE5E5564EFF09BF7333244_NativeFunctionPtr, null);
		}

		// Token: 0x0602A766 RID: 173926 RVA: 0x009E16A8 File Offset: 0x009DF8A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B78B0D695()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_xuli_C.__OnTick_CF946D5D4EFE5E5564EFF09B78B0D695_NativeFunctionPtr, null);
		}

		// Token: 0x0602A767 RID: 173927 RVA: 0x009E16BC File Offset: 0x009DF8BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B78B0D695()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_xuli_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B78B0D695_NativeFunctionPtr, null);
		}

		// Token: 0x0602A768 RID: 173928 RVA: 0x009E16D0 File Offset: 0x009DF8D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B78B0D695()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_xuli_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B78B0D695_NativeFunctionPtr, null);
		}

		// Token: 0x0602A769 RID: 173929 RVA: 0x009E16E4 File Offset: 0x009DF8E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B78B0D695()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_xuli_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B78B0D695_NativeFunctionPtr, null);
		}

		// Token: 0x0602A76A RID: 173930 RVA: 0x009E16F8 File Offset: 0x009DF8F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B78B0D695()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_xuli_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B78B0D695_NativeFunctionPtr, null);
		}

		// Token: 0x0602A76B RID: 173931 RVA: 0x009E170C File Offset: 0x009DF90C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_xuli_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A76C RID: 173932 RVA: 0x009E1720 File Offset: 0x009DF920
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Jump_xuli_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A76D RID: 173933 RVA: 0x009E1738 File Offset: 0x009DF938
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Jump_xuli_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Jump_xuli_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Jump_xuli_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Jump_xuli_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_xuli_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A76E RID: 173934 RVA: 0x009E1780 File Offset: 0x009DF980
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Jump_xuli_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Jump_xuli_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Jump_xuli_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Jump_xuli_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Jump_xuli_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A76F RID: 173935 RVA: 0x009E17C7 File Offset: 0x009DF9C7
		protected GA_Motor_Jump_xuli_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015EE5 RID: 89829
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump_xuli.GA_Motor_Jump_xuli_C";

		// Token: 0x04015EE6 RID: 89830
		private static IntPtr _ClassPtr;

		// Token: 0x04015EE7 RID: 89831
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015EE8 RID: 89832
		internal new static int __PropertyOffset_1;

		// Token: 0x04015EE9 RID: 89833
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09BF7333244_NativeFunctionPtr;

		// Token: 0x04015EEA RID: 89834
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09BF7333244_NativeFunctionPtr;

		// Token: 0x04015EEB RID: 89835
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09BF7333244_NativeFunctionPtr;

		// Token: 0x04015EEC RID: 89836
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09BF7333244_NativeFunctionPtr;

		// Token: 0x04015EED RID: 89837
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09BF7333244_NativeFunctionPtr;

		// Token: 0x04015EEE RID: 89838
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B78B0D695_NativeFunctionPtr;

		// Token: 0x04015EEF RID: 89839
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B78B0D695_NativeFunctionPtr;

		// Token: 0x04015EF0 RID: 89840
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B78B0D695_NativeFunctionPtr;

		// Token: 0x04015EF1 RID: 89841
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B78B0D695_NativeFunctionPtr;

		// Token: 0x04015EF2 RID: 89842
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B78B0D695_NativeFunctionPtr;

		// Token: 0x04015EF3 RID: 89843
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015EF4 RID: 89844
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3B0 RID: 41904
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403219D RID: 205213
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
