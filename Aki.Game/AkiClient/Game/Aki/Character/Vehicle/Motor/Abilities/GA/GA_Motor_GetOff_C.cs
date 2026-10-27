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
	// Token: 0x02004075 RID: 16501
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_GetOff.GA_Motor_GetOff_C")]
	[UnrealStructLayout(1560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1556)]
	public class GA_Motor_GetOff_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A6ED RID: 173805 RVA: 0x009E0880 File Offset: 0x009DEA80
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_GetOff_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_GetOff.GA_Motor_GetOff_C");
			}
			return GA_Motor_GetOff_C._ClassPtr;
		}

		// Token: 0x0602A6EE RID: 173806 RVA: 0x009E08A4 File Offset: 0x009DEAA4
		public GA_Motor_GetOff_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_GetOff_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A6EF RID: 173807 RVA: 0x009E08CC File Offset: 0x009DEACC
		public GA_Motor_GetOff_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_GetOff_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700681D RID: 26653
		// (get) Token: 0x0602A6F0 RID: 173808 RVA: 0x009E08FF File Offset: 0x009DEAFF
		// (set) Token: 0x0602A6F1 RID: 173809 RVA: 0x009E0913 File Offset: 0x009DEB13
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_GetOff_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_GetOff_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700681E RID: 26654
		// (get) Token: 0x0602A6F2 RID: 173810 RVA: 0x009E0928 File Offset: 0x009DEB28
		// (set) Token: 0x0602A6F3 RID: 173811 RVA: 0x009E0961 File Offset: 0x009DEB61
		public FMotorBoostConfig 摩托_喷射与超速配置
		{
			get
			{
				base.FastCheckIsValid();
				FMotorBoostConfig result;
				if ((result = this._摩托_喷射与超速配置) == null)
				{
					result = (this._摩托_喷射与超速配置 = new FMotorBoostConfig(base.NativePtr + (IntPtr)GA_Motor_GetOff_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBoostConfig.StaticStruct(), base.NativePtr + (IntPtr)GA_Motor_GetOff_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700681F RID: 26655
		// (get) Token: 0x0602A6F4 RID: 173812 RVA: 0x009E0982 File Offset: 0x009DEB82
		// (set) Token: 0x0602A6F5 RID: 173813 RVA: 0x009E0992 File Offset: 0x009DEB92
		public unsafe float 起始时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_GetOff_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_GetOff_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602A6F6 RID: 173814 RVA: 0x009E09A3 File Offset: 0x009DEBA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B6AA7AB49()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_GetOff_C.__OnTick_CF946D5D4EFE5E5564EFF09B6AA7AB49_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6F7 RID: 173815 RVA: 0x009E09B7 File Offset: 0x009DEBB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B6AA7AB49()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_GetOff_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B6AA7AB49_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6F8 RID: 173816 RVA: 0x009E09CB File Offset: 0x009DEBCB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B6AA7AB49()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_GetOff_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B6AA7AB49_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6F9 RID: 173817 RVA: 0x009E09DF File Offset: 0x009DEBDF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B6AA7AB49()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_GetOff_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B6AA7AB49_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6FA RID: 173818 RVA: 0x009E09F3 File Offset: 0x009DEBF3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B6AA7AB49()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_GetOff_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B6AA7AB49_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6FB RID: 173819 RVA: 0x009E0A07 File Offset: 0x009DEC07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_GetOff_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6FC RID: 173820 RVA: 0x009E0A1B File Offset: 0x009DEC1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_GetOff_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A6FD RID: 173821 RVA: 0x009E0A30 File Offset: 0x009DEC30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_GetOff_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_GetOff_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_GetOff_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_GetOff_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_GetOff_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A6FE RID: 173822 RVA: 0x009E0A78 File Offset: 0x009DEC78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_GetOff_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_GetOff_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_GetOff_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_GetOff_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_GetOff_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A6FF RID: 173823 RVA: 0x009E0ABF File Offset: 0x009DECBF
		protected GA_Motor_GetOff_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015E8F RID: 89743
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_GetOff.GA_Motor_GetOff_C";

		// Token: 0x04015E90 RID: 89744
		private static IntPtr _ClassPtr;

		// Token: 0x04015E91 RID: 89745
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015E92 RID: 89746
		internal new static int __PropertyOffset_1;

		// Token: 0x04015E93 RID: 89747
		internal new static int __PropertyOffset_2;

		// Token: 0x04015E94 RID: 89748
		[Nullable(2)]
		private FMotorBoostConfig _摩托_喷射与超速配置;

		// Token: 0x04015E95 RID: 89749
		internal new static int __PropertyOffset_3;

		// Token: 0x04015E96 RID: 89750
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B6AA7AB49_NativeFunctionPtr;

		// Token: 0x04015E97 RID: 89751
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B6AA7AB49_NativeFunctionPtr;

		// Token: 0x04015E98 RID: 89752
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B6AA7AB49_NativeFunctionPtr;

		// Token: 0x04015E99 RID: 89753
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B6AA7AB49_NativeFunctionPtr;

		// Token: 0x04015E9A RID: 89754
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B6AA7AB49_NativeFunctionPtr;

		// Token: 0x04015E9B RID: 89755
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015E9C RID: 89756
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3A8 RID: 41896
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032195 RID: 205205
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
