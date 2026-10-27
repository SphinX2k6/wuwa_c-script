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
	// Token: 0x02004076 RID: 16502
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump02.GA_Motor_Jump02_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Motor_Jump02_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A700 RID: 173824 RVA: 0x009E0AC8 File Offset: 0x009DECC8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Jump02_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump02.GA_Motor_Jump02_C");
			}
			return GA_Motor_Jump02_C._ClassPtr;
		}

		// Token: 0x0602A701 RID: 173825 RVA: 0x009E0AEC File Offset: 0x009DECEC
		public GA_Motor_Jump02_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Jump02_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A702 RID: 173826 RVA: 0x009E0B14 File Offset: 0x009DED14
		[NullableContext(1)]
		public GA_Motor_Jump02_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Jump02_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006820 RID: 26656
		// (get) Token: 0x0602A703 RID: 173827 RVA: 0x009E0B47 File Offset: 0x009DED47
		// (set) Token: 0x0602A704 RID: 173828 RVA: 0x009E0B5B File Offset: 0x009DED5B
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Jump02_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Jump02_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602A705 RID: 173829 RVA: 0x009E0B70 File Offset: 0x009DED70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B3BD79CF4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump02_C.__OnTick_CF946D5D4EFE5E5564EFF09B3BD79CF4_NativeFunctionPtr, null);
		}

		// Token: 0x0602A706 RID: 173830 RVA: 0x009E0B84 File Offset: 0x009DED84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B3BD79CF4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump02_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B3BD79CF4_NativeFunctionPtr, null);
		}

		// Token: 0x0602A707 RID: 173831 RVA: 0x009E0B98 File Offset: 0x009DED98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B3BD79CF4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump02_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B3BD79CF4_NativeFunctionPtr, null);
		}

		// Token: 0x0602A708 RID: 173832 RVA: 0x009E0BAC File Offset: 0x009DEDAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B3BD79CF4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump02_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B3BD79CF4_NativeFunctionPtr, null);
		}

		// Token: 0x0602A709 RID: 173833 RVA: 0x009E0BC0 File Offset: 0x009DEDC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B3BD79CF4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump02_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B3BD79CF4_NativeFunctionPtr, null);
		}

		// Token: 0x0602A70A RID: 173834 RVA: 0x009E0BD4 File Offset: 0x009DEDD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump02_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A70B RID: 173835 RVA: 0x009E0BE8 File Offset: 0x009DEDE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Jump02_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A70C RID: 173836 RVA: 0x009E0C00 File Offset: 0x009DEE00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Jump02_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Jump02_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Jump02_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Jump02_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Jump02_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A70D RID: 173837 RVA: 0x009E0C48 File Offset: 0x009DEE48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Jump02_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Jump02_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Jump02_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Jump02_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Jump02_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A70E RID: 173838 RVA: 0x009E0C8F File Offset: 0x009DEE8F
		protected GA_Motor_Jump02_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015E9D RID: 89757
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Jump02.GA_Motor_Jump02_C";

		// Token: 0x04015E9E RID: 89758
		private static IntPtr _ClassPtr;

		// Token: 0x04015E9F RID: 89759
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015EA0 RID: 89760
		internal new static int __PropertyOffset_1;

		// Token: 0x04015EA1 RID: 89761
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B3BD79CF4_NativeFunctionPtr;

		// Token: 0x04015EA2 RID: 89762
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B3BD79CF4_NativeFunctionPtr;

		// Token: 0x04015EA3 RID: 89763
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B3BD79CF4_NativeFunctionPtr;

		// Token: 0x04015EA4 RID: 89764
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B3BD79CF4_NativeFunctionPtr;

		// Token: 0x04015EA5 RID: 89765
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B3BD79CF4_NativeFunctionPtr;

		// Token: 0x04015EA6 RID: 89766
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015EA7 RID: 89767
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3A9 RID: 41897
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032196 RID: 205206
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
