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
	// Token: 0x02004085 RID: 16517
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_ScreenShot.GA_Motor_ScreenShot_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Motor_ScreenShot_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A83E RID: 174142 RVA: 0x009E2E34 File Offset: 0x009E1034
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_ScreenShot_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_ScreenShot.GA_Motor_ScreenShot_C");
			}
			return GA_Motor_ScreenShot_C._ClassPtr;
		}

		// Token: 0x0602A83F RID: 174143 RVA: 0x009E2E58 File Offset: 0x009E1058
		public GA_Motor_ScreenShot_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_ScreenShot_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A840 RID: 174144 RVA: 0x009E2E80 File Offset: 0x009E1080
		[NullableContext(1)]
		public GA_Motor_ScreenShot_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_ScreenShot_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006840 RID: 26688
		// (get) Token: 0x0602A841 RID: 174145 RVA: 0x009E2EB3 File Offset: 0x009E10B3
		// (set) Token: 0x0602A842 RID: 174146 RVA: 0x009E2EC7 File Offset: 0x009E10C7
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_ScreenShot_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_ScreenShot_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602A843 RID: 174147 RVA: 0x009E2EDC File Offset: 0x009E10DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_ScreenShot_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A844 RID: 174148 RVA: 0x009E2EF0 File Offset: 0x009E10F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_ScreenShot_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A845 RID: 174149 RVA: 0x009E2F08 File Offset: 0x009E1108
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_ScreenShot_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_ScreenShot_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_ScreenShot_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_ScreenShot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_ScreenShot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A846 RID: 174150 RVA: 0x009E2F50 File Offset: 0x009E1150
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_ScreenShot_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_ScreenShot_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_ScreenShot_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_ScreenShot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_ScreenShot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A847 RID: 174151 RVA: 0x009E2F97 File Offset: 0x009E1197
		protected GA_Motor_ScreenShot_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F90 RID: 90000
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_ScreenShot.GA_Motor_ScreenShot_C";

		// Token: 0x04015F91 RID: 90001
		private static IntPtr _ClassPtr;

		// Token: 0x04015F92 RID: 90002
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015F93 RID: 90003
		internal new static int __PropertyOffset_1;

		// Token: 0x04015F94 RID: 90004
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015F95 RID: 90005
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3BE RID: 41918
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321AB RID: 205227
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
