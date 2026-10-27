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
	// Token: 0x02004089 RID: 16521
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Stunt.GA_Motor_Stunt_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class GA_Motor_Stunt_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A86D RID: 174189 RVA: 0x009E34A4 File Offset: 0x009E16A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Stunt_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Stunt.GA_Motor_Stunt_C");
			}
			return GA_Motor_Stunt_C._ClassPtr;
		}

		// Token: 0x0602A86E RID: 174190 RVA: 0x009E34C8 File Offset: 0x009E16C8
		public GA_Motor_Stunt_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Stunt_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A86F RID: 174191 RVA: 0x009E34F0 File Offset: 0x009E16F0
		public GA_Motor_Stunt_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Stunt_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006844 RID: 26692
		// (get) Token: 0x0602A870 RID: 174192 RVA: 0x009E3523 File Offset: 0x009E1723
		// (set) Token: 0x0602A871 RID: 174193 RVA: 0x009E3537 File Offset: 0x009E1737
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Stunt_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Stunt_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006845 RID: 26693
		// (get) Token: 0x0602A872 RID: 174194 RVA: 0x009E354C File Offset: 0x009E174C
		// (set) Token: 0x0602A873 RID: 174195 RVA: 0x009E3585 File Offset: 0x009E1785
		public FMotorBoostConfig 摩托_喷射与超速配置
		{
			get
			{
				base.FastCheckIsValid();
				FMotorBoostConfig result;
				if ((result = this._摩托_喷射与超速配置) == null)
				{
					result = (this._摩托_喷射与超速配置 = new FMotorBoostConfig(base.NativePtr + (IntPtr)GA_Motor_Stunt_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBoostConfig.StaticStruct(), base.NativePtr + (IntPtr)GA_Motor_Stunt_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602A874 RID: 174196 RVA: 0x009E35A6 File Offset: 0x009E17A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B0E974C3D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_C.__OnTick_CF946D5D4EFE5E5564EFF09B0E974C3D_NativeFunctionPtr, null);
		}

		// Token: 0x0602A875 RID: 174197 RVA: 0x009E35BA File Offset: 0x009E17BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B0E974C3D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B0E974C3D_NativeFunctionPtr, null);
		}

		// Token: 0x0602A876 RID: 174198 RVA: 0x009E35CE File Offset: 0x009E17CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B0E974C3D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B0E974C3D_NativeFunctionPtr, null);
		}

		// Token: 0x0602A877 RID: 174199 RVA: 0x009E35E2 File Offset: 0x009E17E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B0E974C3D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B0E974C3D_NativeFunctionPtr, null);
		}

		// Token: 0x0602A878 RID: 174200 RVA: 0x009E35F6 File Offset: 0x009E17F6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B0E974C3D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B0E974C3D_NativeFunctionPtr, null);
		}

		// Token: 0x0602A879 RID: 174201 RVA: 0x009E360A File Offset: 0x009E180A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09BC3CB17CC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_C.__OnTick_CF946D5D4EFE5E5564EFF09BC3CB17CC_NativeFunctionPtr, null);
		}

		// Token: 0x0602A87A RID: 174202 RVA: 0x009E361E File Offset: 0x009E181E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09BC3CB17CC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_C.__OnCancelled_CF946D5D4EFE5E5564EFF09BC3CB17CC_NativeFunctionPtr, null);
		}

		// Token: 0x0602A87B RID: 174203 RVA: 0x009E3632 File Offset: 0x009E1832
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09BC3CB17CC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09BC3CB17CC_NativeFunctionPtr, null);
		}

		// Token: 0x0602A87C RID: 174204 RVA: 0x009E3646 File Offset: 0x009E1846
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09BC3CB17CC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09BC3CB17CC_NativeFunctionPtr, null);
		}

		// Token: 0x0602A87D RID: 174205 RVA: 0x009E365A File Offset: 0x009E185A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09BC3CB17CC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_C.__OnCompleted_CF946D5D4EFE5E5564EFF09BC3CB17CC_NativeFunctionPtr, null);
		}

		// Token: 0x0602A87E RID: 174206 RVA: 0x009E366E File Offset: 0x009E186E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A87F RID: 174207 RVA: 0x009E3682 File Offset: 0x009E1882
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Stunt_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A880 RID: 174208 RVA: 0x009E3698 File Offset: 0x009E1898
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Stunt_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Stunt_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Stunt_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Stunt_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A881 RID: 174209 RVA: 0x009E36E0 File Offset: 0x009E18E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Stunt_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Stunt_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Stunt_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Stunt_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Stunt_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A882 RID: 174210 RVA: 0x009E3727 File Offset: 0x009E1927
		protected GA_Motor_Stunt_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015FAF RID: 90031
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Stunt.GA_Motor_Stunt_C";

		// Token: 0x04015FB0 RID: 90032
		private static IntPtr _ClassPtr;

		// Token: 0x04015FB1 RID: 90033
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015FB2 RID: 90034
		internal new static int __PropertyOffset_1;

		// Token: 0x04015FB3 RID: 90035
		internal new static int __PropertyOffset_2;

		// Token: 0x04015FB4 RID: 90036
		[Nullable(2)]
		private FMotorBoostConfig _摩托_喷射与超速配置;

		// Token: 0x04015FB5 RID: 90037
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B0E974C3D_NativeFunctionPtr;

		// Token: 0x04015FB6 RID: 90038
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B0E974C3D_NativeFunctionPtr;

		// Token: 0x04015FB7 RID: 90039
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B0E974C3D_NativeFunctionPtr;

		// Token: 0x04015FB8 RID: 90040
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B0E974C3D_NativeFunctionPtr;

		// Token: 0x04015FB9 RID: 90041
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B0E974C3D_NativeFunctionPtr;

		// Token: 0x04015FBA RID: 90042
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09BC3CB17CC_NativeFunctionPtr;

		// Token: 0x04015FBB RID: 90043
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09BC3CB17CC_NativeFunctionPtr;

		// Token: 0x04015FBC RID: 90044
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09BC3CB17CC_NativeFunctionPtr;

		// Token: 0x04015FBD RID: 90045
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09BC3CB17CC_NativeFunctionPtr;

		// Token: 0x04015FBE RID: 90046
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09BC3CB17CC_NativeFunctionPtr;

		// Token: 0x04015FBF RID: 90047
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015FC0 RID: 90048
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3C3 RID: 41923
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321B0 RID: 205232
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
