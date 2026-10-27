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
	// Token: 0x0200408D RID: 16525
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_SupperStunt.GA_Motor_SupperStunt_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class GA_Motor_SupperStunt_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A8B6 RID: 174262 RVA: 0x009E3DA8 File Offset: 0x009E1FA8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_SupperStunt_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_SupperStunt.GA_Motor_SupperStunt_C");
			}
			return GA_Motor_SupperStunt_C._ClassPtr;
		}

		// Token: 0x0602A8B7 RID: 174263 RVA: 0x009E3DCC File Offset: 0x009E1FCC
		public GA_Motor_SupperStunt_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_SupperStunt_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A8B8 RID: 174264 RVA: 0x009E3DF4 File Offset: 0x009E1FF4
		public GA_Motor_SupperStunt_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_SupperStunt_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700684C RID: 26700
		// (get) Token: 0x0602A8B9 RID: 174265 RVA: 0x009E3E27 File Offset: 0x009E2027
		// (set) Token: 0x0602A8BA RID: 174266 RVA: 0x009E3E3B File Offset: 0x009E203B
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_SupperStunt_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_SupperStunt_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700684D RID: 26701
		// (get) Token: 0x0602A8BB RID: 174267 RVA: 0x009E3E50 File Offset: 0x009E2050
		// (set) Token: 0x0602A8BC RID: 174268 RVA: 0x009E3E89 File Offset: 0x009E2089
		public FMotorBoostConfig 摩托_喷射与超速配置
		{
			get
			{
				base.FastCheckIsValid();
				FMotorBoostConfig result;
				if ((result = this._摩托_喷射与超速配置) == null)
				{
					result = (this._摩托_喷射与超速配置 = new FMotorBoostConfig(base.NativePtr + (IntPtr)GA_Motor_SupperStunt_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBoostConfig.StaticStruct(), base.NativePtr + (IntPtr)GA_Motor_SupperStunt_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602A8BD RID: 174269 RVA: 0x009E3EAA File Offset: 0x009E20AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09BA965C662()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_SupperStunt_C.__OnTick_CF946D5D4EFE5E5564EFF09BA965C662_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8BE RID: 174270 RVA: 0x009E3EBE File Offset: 0x009E20BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09BA965C662()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_SupperStunt_C.__OnCancelled_CF946D5D4EFE5E5564EFF09BA965C662_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8BF RID: 174271 RVA: 0x009E3ED2 File Offset: 0x009E20D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09BA965C662()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_SupperStunt_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09BA965C662_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8C0 RID: 174272 RVA: 0x009E3EE6 File Offset: 0x009E20E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09BA965C662()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_SupperStunt_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09BA965C662_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8C1 RID: 174273 RVA: 0x009E3EFA File Offset: 0x009E20FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09BA965C662()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_SupperStunt_C.__OnCompleted_CF946D5D4EFE5E5564EFF09BA965C662_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8C2 RID: 174274 RVA: 0x009E3F0E File Offset: 0x009E210E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_SupperStunt_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8C3 RID: 174275 RVA: 0x009E3F22 File Offset: 0x009E2122
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_SupperStunt_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A8C4 RID: 174276 RVA: 0x009E3F38 File Offset: 0x009E2138
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_SupperStunt_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_SupperStunt_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_SupperStunt_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_SupperStunt_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_SupperStunt_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A8C5 RID: 174277 RVA: 0x009E3F80 File Offset: 0x009E2180
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_SupperStunt_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_SupperStunt_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_SupperStunt_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_SupperStunt_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_SupperStunt_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A8C6 RID: 174278 RVA: 0x009E3FC7 File Offset: 0x009E21C7
		protected GA_Motor_SupperStunt_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015FE8 RID: 90088
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_SupperStunt.GA_Motor_SupperStunt_C";

		// Token: 0x04015FE9 RID: 90089
		private static IntPtr _ClassPtr;

		// Token: 0x04015FEA RID: 90090
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015FEB RID: 90091
		internal new static int __PropertyOffset_1;

		// Token: 0x04015FEC RID: 90092
		internal new static int __PropertyOffset_2;

		// Token: 0x04015FED RID: 90093
		[Nullable(2)]
		private FMotorBoostConfig _摩托_喷射与超速配置;

		// Token: 0x04015FEE RID: 90094
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09BA965C662_NativeFunctionPtr;

		// Token: 0x04015FEF RID: 90095
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09BA965C662_NativeFunctionPtr;

		// Token: 0x04015FF0 RID: 90096
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09BA965C662_NativeFunctionPtr;

		// Token: 0x04015FF1 RID: 90097
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09BA965C662_NativeFunctionPtr;

		// Token: 0x04015FF2 RID: 90098
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09BA965C662_NativeFunctionPtr;

		// Token: 0x04015FF3 RID: 90099
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015FF4 RID: 90100
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3C7 RID: 41927
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321B4 RID: 205236
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
