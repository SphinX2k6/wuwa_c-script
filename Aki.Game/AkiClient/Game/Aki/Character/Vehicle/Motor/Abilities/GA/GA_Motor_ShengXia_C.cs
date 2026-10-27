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
	// Token: 0x02004086 RID: 16518
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_ShengXia.GA_Motor_ShengXia_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Motor_ShengXia_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A848 RID: 174152 RVA: 0x009E2FA0 File Offset: 0x009E11A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_ShengXia_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_ShengXia.GA_Motor_ShengXia_C");
			}
			return GA_Motor_ShengXia_C._ClassPtr;
		}

		// Token: 0x0602A849 RID: 174153 RVA: 0x009E2FC4 File Offset: 0x009E11C4
		public GA_Motor_ShengXia_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_ShengXia_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A84A RID: 174154 RVA: 0x009E2FEC File Offset: 0x009E11EC
		[NullableContext(1)]
		public GA_Motor_ShengXia_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_ShengXia_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006841 RID: 26689
		// (get) Token: 0x0602A84B RID: 174155 RVA: 0x009E301F File Offset: 0x009E121F
		// (set) Token: 0x0602A84C RID: 174156 RVA: 0x009E3033 File Offset: 0x009E1233
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_ShengXia_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_ShengXia_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602A84D RID: 174157 RVA: 0x009E3048 File Offset: 0x009E1248
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_ShengXia_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A84E RID: 174158 RVA: 0x009E305C File Offset: 0x009E125C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_ShengXia_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A84F RID: 174159 RVA: 0x009E3074 File Offset: 0x009E1274
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_ShengXia_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_ShengXia_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_ShengXia_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_ShengXia_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_ShengXia_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A850 RID: 174160 RVA: 0x009E30BC File Offset: 0x009E12BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_ShengXia_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_ShengXia_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_ShengXia_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_ShengXia_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_ShengXia_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A851 RID: 174161 RVA: 0x009E3103 File Offset: 0x009E1303
		protected GA_Motor_ShengXia_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F96 RID: 90006
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_ShengXia.GA_Motor_ShengXia_C";

		// Token: 0x04015F97 RID: 90007
		private static IntPtr _ClassPtr;

		// Token: 0x04015F98 RID: 90008
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015F99 RID: 90009
		internal new static int __PropertyOffset_1;

		// Token: 0x04015F9A RID: 90010
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015F9B RID: 90011
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3BF RID: 41919
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321AC RID: 205228
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
