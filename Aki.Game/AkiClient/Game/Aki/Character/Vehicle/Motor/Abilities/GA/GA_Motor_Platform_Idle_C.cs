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
	// Token: 0x02004081 RID: 16513
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Platform_Idle.GA_Motor_Platform_Idle_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class GA_Motor_Platform_Idle_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A7FA RID: 174074 RVA: 0x009E263C File Offset: 0x009E083C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Platform_Idle_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Platform_Idle.GA_Motor_Platform_Idle_C");
			}
			return GA_Motor_Platform_Idle_C._ClassPtr;
		}

		// Token: 0x0602A7FB RID: 174075 RVA: 0x009E2660 File Offset: 0x009E0860
		public GA_Motor_Platform_Idle_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Platform_Idle_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A7FC RID: 174076 RVA: 0x009E2688 File Offset: 0x009E0888
		[NullableContext(1)]
		public GA_Motor_Platform_Idle_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Platform_Idle_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006837 RID: 26679
		// (get) Token: 0x0602A7FD RID: 174077 RVA: 0x009E26BB File Offset: 0x009E08BB
		// (set) Token: 0x0602A7FE RID: 174078 RVA: 0x009E26CB File Offset: 0x009E08CB
		public unsafe bool 是否主动结束
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Platform_Idle_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Platform_Idle_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006838 RID: 26680
		// (get) Token: 0x0602A7FF RID: 174079 RVA: 0x009E26DC File Offset: 0x009E08DC
		// (set) Token: 0x0602A800 RID: 174080 RVA: 0x009E26F0 File Offset: 0x009E08F0
		[Nullable(2)]
		public unsafe TsBaseCharacter 驾驶员
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Platform_Idle_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Platform_Idle_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602A801 RID: 174081 RVA: 0x009E2705 File Offset: 0x009E0905
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_941A88F849D9CDDABE04B6AC6BA3F7AD()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Idle_C.__OnFinish_941A88F849D9CDDABE04B6AC6BA3F7AD_NativeFunctionPtr, null);
		}

		// Token: 0x0602A802 RID: 174082 RVA: 0x009E2719 File Offset: 0x009E0919
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Idle_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A803 RID: 174083 RVA: 0x009E272D File Offset: 0x009E092D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Platform_Idle_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A804 RID: 174084 RVA: 0x009E2744 File Offset: 0x009E0944
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Platform_Idle_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Platform_Idle_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Platform_Idle_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Platform_Idle_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Idle_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A805 RID: 174085 RVA: 0x009E278C File Offset: 0x009E098C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Platform_Idle_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Platform_Idle_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Platform_Idle_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Platform_Idle_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Platform_Idle_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A806 RID: 174086 RVA: 0x009E27D3 File Offset: 0x009E09D3
		protected GA_Motor_Platform_Idle_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F61 RID: 89953
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Platform_Idle.GA_Motor_Platform_Idle_C";

		// Token: 0x04015F62 RID: 89954
		private static IntPtr _ClassPtr;

		// Token: 0x04015F63 RID: 89955
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015F64 RID: 89956
		internal new static int __PropertyOffset_1;

		// Token: 0x04015F65 RID: 89957
		internal new static int __PropertyOffset_2;

		// Token: 0x04015F66 RID: 89958
		private static IntPtr __OnFinish_941A88F849D9CDDABE04B6AC6BA3F7AD_NativeFunctionPtr;

		// Token: 0x04015F67 RID: 89959
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015F68 RID: 89960
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3B9 RID: 41913
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321A6 RID: 205222
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
