using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004126 RID: 16678
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Common_AimShoot.GA_Common_AimShoot_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Common_AimShoot_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AF8E RID: 176014 RVA: 0x009F1B04 File Offset: 0x009EFD04
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Common_AimShoot_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Common_AimShoot.GA_Common_AimShoot_C");
			}
			return GA_Common_AimShoot_C._ClassPtr;
		}

		// Token: 0x0602AF8F RID: 176015 RVA: 0x009F1B28 File Offset: 0x009EFD28
		public GA_Common_AimShoot_C() : this(BuiltinUtils.AllocNativeUObject(GA_Common_AimShoot_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AF90 RID: 176016 RVA: 0x009F1B50 File Offset: 0x009EFD50
		[NullableContext(1)]
		public GA_Common_AimShoot_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Common_AimShoot_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069E2 RID: 27106
		// (get) Token: 0x0602AF91 RID: 176017 RVA: 0x009F1B83 File Offset: 0x009EFD83
		// (set) Token: 0x0602AF92 RID: 176018 RVA: 0x009F1B97 File Offset: 0x009EFD97
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_AimShoot_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_AimShoot_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602AF93 RID: 176019 RVA: 0x009F1BAC File Offset: 0x009EFDAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Common_AimShoot_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF94 RID: 176020 RVA: 0x009F1BC0 File Offset: 0x009EFDC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Common_AimShoot_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AF95 RID: 176021 RVA: 0x009F1BD8 File Offset: 0x009EFDD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Common_AimShoot_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Common_AimShoot_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Common_AimShoot_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Common_AimShoot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Common_AimShoot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF96 RID: 176022 RVA: 0x009F1C20 File Offset: 0x009EFE20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Common_AimShoot_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Common_AimShoot_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Common_AimShoot_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Common_AimShoot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Common_AimShoot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AF97 RID: 176023 RVA: 0x009F1C67 File Offset: 0x009EFE67
		protected GA_Common_AimShoot_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016483 RID: 91267
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Common_AimShoot.GA_Common_AimShoot_C";

		// Token: 0x04016484 RID: 91268
		private static IntPtr _ClassPtr;

		// Token: 0x04016485 RID: 91269
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016486 RID: 91270
		internal new static int __PropertyOffset_1;

		// Token: 0x04016487 RID: 91271
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016488 RID: 91272
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A451 RID: 42065
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032290 RID: 205456
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
