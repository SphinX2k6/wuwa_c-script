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
	// Token: 0x02004074 RID: 16500
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FP_End.GA_Motor_FP_End_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class GA_Motor_FP_End_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A6E1 RID: 173793 RVA: 0x009E06BC File Offset: 0x009DE8BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_FP_End_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FP_End.GA_Motor_FP_End_C");
			}
			return GA_Motor_FP_End_C._ClassPtr;
		}

		// Token: 0x0602A6E2 RID: 173794 RVA: 0x009E06E0 File Offset: 0x009DE8E0
		public GA_Motor_FP_End_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_FP_End_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A6E3 RID: 173795 RVA: 0x009E0708 File Offset: 0x009DE908
		public GA_Motor_FP_End_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_FP_End_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700681B RID: 26651
		// (get) Token: 0x0602A6E4 RID: 173796 RVA: 0x009E073B File Offset: 0x009DE93B
		// (set) Token: 0x0602A6E5 RID: 173797 RVA: 0x009E074F File Offset: 0x009DE94F
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FP_End_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FP_End_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700681C RID: 26652
		// (get) Token: 0x0602A6E6 RID: 173798 RVA: 0x009E0764 File Offset: 0x009DE964
		// (set) Token: 0x0602A6E7 RID: 173799 RVA: 0x009E079D File Offset: 0x009DE99D
		public FMotorBoostConfig 摩托_喷射与超速配置
		{
			get
			{
				base.FastCheckIsValid();
				FMotorBoostConfig result;
				if ((result = this._摩托_喷射与超速配置) == null)
				{
					result = (this._摩托_喷射与超速配置 = new FMotorBoostConfig(base.NativePtr + (IntPtr)GA_Motor_FP_End_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBoostConfig.StaticStruct(), base.NativePtr + (IntPtr)GA_Motor_FP_End_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602A6E8 RID: 173800 RVA: 0x009E07BE File Offset: 0x009DE9BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FP_End_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6E9 RID: 173801 RVA: 0x009E07D2 File Offset: 0x009DE9D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_FP_End_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A6EA RID: 173802 RVA: 0x009E07E8 File Offset: 0x009DE9E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_FP_End_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_FP_End_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_FP_End_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FP_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FP_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A6EB RID: 173803 RVA: 0x009E0830 File Offset: 0x009DEA30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_FP_End_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_FP_End_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_FP_End_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FP_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_FP_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A6EC RID: 173804 RVA: 0x009E0877 File Offset: 0x009DEA77
		protected GA_Motor_FP_End_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015E87 RID: 89735
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FP_End.GA_Motor_FP_End_C";

		// Token: 0x04015E88 RID: 89736
		private static IntPtr _ClassPtr;

		// Token: 0x04015E89 RID: 89737
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015E8A RID: 89738
		internal new static int __PropertyOffset_1;

		// Token: 0x04015E8B RID: 89739
		internal new static int __PropertyOffset_2;

		// Token: 0x04015E8C RID: 89740
		[Nullable(2)]
		private FMotorBoostConfig _摩托_喷射与超速配置;

		// Token: 0x04015E8D RID: 89741
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015E8E RID: 89742
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3A7 RID: 41895
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032194 RID: 205204
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
