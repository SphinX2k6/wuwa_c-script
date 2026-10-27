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
	// Token: 0x0200407D RID: 16509
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Lower1.GA_Motor_Lower1_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class GA_Motor_Lower1_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A78B RID: 173963 RVA: 0x009E1AB0 File Offset: 0x009DFCB0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Lower1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Lower1.GA_Motor_Lower1_C");
			}
			return GA_Motor_Lower1_C._ClassPtr;
		}

		// Token: 0x0602A78C RID: 173964 RVA: 0x009E1AD4 File Offset: 0x009DFCD4
		public GA_Motor_Lower1_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Lower1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A78D RID: 173965 RVA: 0x009E1AFC File Offset: 0x009DFCFC
		[NullableContext(1)]
		public GA_Motor_Lower1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Lower1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700682C RID: 26668
		// (get) Token: 0x0602A78E RID: 173966 RVA: 0x009E1B2F File Offset: 0x009DFD2F
		// (set) Token: 0x0602A78F RID: 173967 RVA: 0x009E1B3F File Offset: 0x009DFD3F
		public unsafe bool 是否主动结束
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Lower1_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Lower1_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700682D RID: 26669
		// (get) Token: 0x0602A790 RID: 173968 RVA: 0x009E1B50 File Offset: 0x009DFD50
		// (set) Token: 0x0602A791 RID: 173969 RVA: 0x009E1B64 File Offset: 0x009DFD64
		[Nullable(2)]
		public unsafe TsBaseCharacter 驾驶员
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Lower1_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Lower1_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602A792 RID: 173970 RVA: 0x009E1B79 File Offset: 0x009DFD79
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B94CC34F2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__OnTick_CF946D5D4EFE5E5564EFF09B94CC34F2_NativeFunctionPtr, null);
		}

		// Token: 0x0602A793 RID: 173971 RVA: 0x009E1B8D File Offset: 0x009DFD8D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B94CC34F2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B94CC34F2_NativeFunctionPtr, null);
		}

		// Token: 0x0602A794 RID: 173972 RVA: 0x009E1BA1 File Offset: 0x009DFDA1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B94CC34F2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B94CC34F2_NativeFunctionPtr, null);
		}

		// Token: 0x0602A795 RID: 173973 RVA: 0x009E1BB5 File Offset: 0x009DFDB5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B94CC34F2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B94CC34F2_NativeFunctionPtr, null);
		}

		// Token: 0x0602A796 RID: 173974 RVA: 0x009E1BC9 File Offset: 0x009DFDC9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B94CC34F2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B94CC34F2_NativeFunctionPtr, null);
		}

		// Token: 0x0602A797 RID: 173975 RVA: 0x009E1BDD File Offset: 0x009DFDDD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B38B41609()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__OnTick_CF946D5D4EFE5E5564EFF09B38B41609_NativeFunctionPtr, null);
		}

		// Token: 0x0602A798 RID: 173976 RVA: 0x009E1BF1 File Offset: 0x009DFDF1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B38B41609()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B38B41609_NativeFunctionPtr, null);
		}

		// Token: 0x0602A799 RID: 173977 RVA: 0x009E1C05 File Offset: 0x009DFE05
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B38B41609()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B38B41609_NativeFunctionPtr, null);
		}

		// Token: 0x0602A79A RID: 173978 RVA: 0x009E1C19 File Offset: 0x009DFE19
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B38B41609()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B38B41609_NativeFunctionPtr, null);
		}

		// Token: 0x0602A79B RID: 173979 RVA: 0x009E1C2D File Offset: 0x009DFE2D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B38B41609()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B38B41609_NativeFunctionPtr, null);
		}

		// Token: 0x0602A79C RID: 173980 RVA: 0x009E1C44 File Offset: 0x009DFE44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3064A6454(in FGameplayTag Tag)
		{
			GA_Motor_Lower1_C.__Added_21071CB943CD992BF8EFD6A3064A6454_FunctionParams* ptr = stackalloc GA_Motor_Lower1_C.__Added_21071CB943CD992BF8EFD6A3064A6454_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Motor_Lower1_C.__Added_21071CB943CD992BF8EFD6A3064A6454_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Lower1_C.__Added_21071CB943CD992BF8EFD6A3064A6454_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__Added_21071CB943CD992BF8EFD6A3064A6454_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A79D RID: 173981 RVA: 0x009E1C8F File Offset: 0x009DFE8F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09BBCE39CA3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__OnTick_CF946D5D4EFE5E5564EFF09BBCE39CA3_NativeFunctionPtr, null);
		}

		// Token: 0x0602A79E RID: 173982 RVA: 0x009E1CA3 File Offset: 0x009DFEA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09BBCE39CA3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__OnCancelled_CF946D5D4EFE5E5564EFF09BBCE39CA3_NativeFunctionPtr, null);
		}

		// Token: 0x0602A79F RID: 173983 RVA: 0x009E1CB7 File Offset: 0x009DFEB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09BBCE39CA3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09BBCE39CA3_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7A0 RID: 173984 RVA: 0x009E1CCB File Offset: 0x009DFECB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09BBCE39CA3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09BBCE39CA3_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7A1 RID: 173985 RVA: 0x009E1CDF File Offset: 0x009DFEDF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09BBCE39CA3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__OnCompleted_CF946D5D4EFE5E5564EFF09BBCE39CA3_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7A2 RID: 173986 RVA: 0x009E1CF3 File Offset: 0x009DFEF3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower1_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7A3 RID: 173987 RVA: 0x009E1D07 File Offset: 0x009DFF07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Lower1_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A7A4 RID: 173988 RVA: 0x009E1D1C File Offset: 0x009DFF1C
		protected GA_Motor_Lower1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F07 RID: 89863
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Lower1.GA_Motor_Lower1_C";

		// Token: 0x04015F08 RID: 89864
		private static IntPtr _ClassPtr;

		// Token: 0x04015F09 RID: 89865
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015F0A RID: 89866
		internal new static int __PropertyOffset_1;

		// Token: 0x04015F0B RID: 89867
		internal new static int __PropertyOffset_2;

		// Token: 0x04015F0C RID: 89868
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B94CC34F2_NativeFunctionPtr;

		// Token: 0x04015F0D RID: 89869
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B94CC34F2_NativeFunctionPtr;

		// Token: 0x04015F0E RID: 89870
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B94CC34F2_NativeFunctionPtr;

		// Token: 0x04015F0F RID: 89871
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B94CC34F2_NativeFunctionPtr;

		// Token: 0x04015F10 RID: 89872
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B94CC34F2_NativeFunctionPtr;

		// Token: 0x04015F11 RID: 89873
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B38B41609_NativeFunctionPtr;

		// Token: 0x04015F12 RID: 89874
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B38B41609_NativeFunctionPtr;

		// Token: 0x04015F13 RID: 89875
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B38B41609_NativeFunctionPtr;

		// Token: 0x04015F14 RID: 89876
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B38B41609_NativeFunctionPtr;

		// Token: 0x04015F15 RID: 89877
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B38B41609_NativeFunctionPtr;

		// Token: 0x04015F16 RID: 89878
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3064A6454_NativeFunctionPtr;

		// Token: 0x04015F17 RID: 89879
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09BBCE39CA3_NativeFunctionPtr;

		// Token: 0x04015F18 RID: 89880
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09BBCE39CA3_NativeFunctionPtr;

		// Token: 0x04015F19 RID: 89881
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09BBCE39CA3_NativeFunctionPtr;

		// Token: 0x04015F1A RID: 89882
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09BBCE39CA3_NativeFunctionPtr;

		// Token: 0x04015F1B RID: 89883
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09BBCE39CA3_NativeFunctionPtr;

		// Token: 0x04015F1C RID: 89884
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A3B3 RID: 41907
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3064A6454_FunctionParams
		{
			// Token: 0x040321A0 RID: 205216
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}
	}
}
