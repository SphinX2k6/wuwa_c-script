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
	// Token: 0x02004077 RID: 16503
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump.GA_Motor_Jump_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Motor_Jump_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A70F RID: 173839 RVA: 0x009E0C98 File Offset: 0x009DEE98
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Jump_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump.GA_Motor_Jump_C");
			}
			return GA_Motor_Jump_C._ClassPtr;
		}

		// Token: 0x0602A710 RID: 173840 RVA: 0x009E0CBC File Offset: 0x009DEEBC
		public GA_Motor_Jump_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Jump_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A711 RID: 173841 RVA: 0x009E0CE4 File Offset: 0x009DEEE4
		[NullableContext(1)]
		public GA_Motor_Jump_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Jump_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006821 RID: 26657
		// (get) Token: 0x0602A712 RID: 173842 RVA: 0x009E0D17 File Offset: 0x009DEF17
		// (set) Token: 0x0602A713 RID: 173843 RVA: 0x009E0D2B File Offset: 0x009DEF2B
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Jump_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Jump_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602A714 RID: 173844 RVA: 0x009E0D40 File Offset: 0x009DEF40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B58A3A26E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_C.__OnTick_CF946D5D4EFE5E5564EFF09B58A3A26E_NativeFunctionPtr, null);
		}

		// Token: 0x0602A715 RID: 173845 RVA: 0x009E0D54 File Offset: 0x009DEF54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B58A3A26E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B58A3A26E_NativeFunctionPtr, null);
		}

		// Token: 0x0602A716 RID: 173846 RVA: 0x009E0D68 File Offset: 0x009DEF68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B58A3A26E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B58A3A26E_NativeFunctionPtr, null);
		}

		// Token: 0x0602A717 RID: 173847 RVA: 0x009E0D7C File Offset: 0x009DEF7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B58A3A26E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B58A3A26E_NativeFunctionPtr, null);
		}

		// Token: 0x0602A718 RID: 173848 RVA: 0x009E0D90 File Offset: 0x009DEF90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B58A3A26E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B58A3A26E_NativeFunctionPtr, null);
		}

		// Token: 0x0602A719 RID: 173849 RVA: 0x009E0DA4 File Offset: 0x009DEFA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09BA9486D1D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_C.__OnTick_CF946D5D4EFE5E5564EFF09BA9486D1D_NativeFunctionPtr, null);
		}

		// Token: 0x0602A71A RID: 173850 RVA: 0x009E0DB8 File Offset: 0x009DEFB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09BA9486D1D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_C.__OnCancelled_CF946D5D4EFE5E5564EFF09BA9486D1D_NativeFunctionPtr, null);
		}

		// Token: 0x0602A71B RID: 173851 RVA: 0x009E0DCC File Offset: 0x009DEFCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09BA9486D1D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09BA9486D1D_NativeFunctionPtr, null);
		}

		// Token: 0x0602A71C RID: 173852 RVA: 0x009E0DE0 File Offset: 0x009DEFE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09BA9486D1D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09BA9486D1D_NativeFunctionPtr, null);
		}

		// Token: 0x0602A71D RID: 173853 RVA: 0x009E0DF4 File Offset: 0x009DEFF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09BA9486D1D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_C.__OnCompleted_CF946D5D4EFE5E5564EFF09BA9486D1D_NativeFunctionPtr, null);
		}

		// Token: 0x0602A71E RID: 173854 RVA: 0x009E0E08 File Offset: 0x009DF008
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A71F RID: 173855 RVA: 0x009E0E1C File Offset: 0x009DF01C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Jump_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A720 RID: 173856 RVA: 0x009E0E34 File Offset: 0x009DF034
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Jump_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Jump_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Jump_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Jump_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A721 RID: 173857 RVA: 0x009E0E7C File Offset: 0x009DF07C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Jump_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Jump_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Jump_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Jump_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Jump_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A722 RID: 173858 RVA: 0x009E0EC3 File Offset: 0x009DF0C3
		protected GA_Motor_Jump_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015EA8 RID: 89768
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump.GA_Motor_Jump_C";

		// Token: 0x04015EA9 RID: 89769
		private static IntPtr _ClassPtr;

		// Token: 0x04015EAA RID: 89770
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015EAB RID: 89771
		internal new static int __PropertyOffset_1;

		// Token: 0x04015EAC RID: 89772
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B58A3A26E_NativeFunctionPtr;

		// Token: 0x04015EAD RID: 89773
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B58A3A26E_NativeFunctionPtr;

		// Token: 0x04015EAE RID: 89774
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B58A3A26E_NativeFunctionPtr;

		// Token: 0x04015EAF RID: 89775
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B58A3A26E_NativeFunctionPtr;

		// Token: 0x04015EB0 RID: 89776
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B58A3A26E_NativeFunctionPtr;

		// Token: 0x04015EB1 RID: 89777
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09BA9486D1D_NativeFunctionPtr;

		// Token: 0x04015EB2 RID: 89778
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09BA9486D1D_NativeFunctionPtr;

		// Token: 0x04015EB3 RID: 89779
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09BA9486D1D_NativeFunctionPtr;

		// Token: 0x04015EB4 RID: 89780
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09BA9486D1D_NativeFunctionPtr;

		// Token: 0x04015EB5 RID: 89781
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09BA9486D1D_NativeFunctionPtr;

		// Token: 0x04015EB6 RID: 89782
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015EB7 RID: 89783
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3AA RID: 41898
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032197 RID: 205207
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
