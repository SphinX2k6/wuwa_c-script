using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Sample.ApplicationRequirment
{
	// Token: 0x020043F7 RID: 17399
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/ApplicationRequirment/CustomRequirment.CustomRequirment_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class CustomRequirment_C : UGameplayEffectCustomApplicationRequirement, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0D6 RID: 184534 RVA: 0x00A2F910 File Offset: 0x00A2DB10
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CustomRequirment_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/ApplicationRequirment/CustomRequirment.CustomRequirment_C");
			}
			return CustomRequirment_C._ClassPtr;
		}

		// Token: 0x0602D0D7 RID: 184535 RVA: 0x00A2F934 File Offset: 0x00A2DB34
		public CustomRequirment_C() : this(BuiltinUtils.AllocNativeUObject(CustomRequirment_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0D8 RID: 184536 RVA: 0x00A2F95C File Offset: 0x00A2DB5C
		[NullableContext(1)]
		public CustomRequirment_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CustomRequirment_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0D9 RID: 184537 RVA: 0x00A2F990 File Offset: 0x00A2DB90
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool CanApplyGameplayEffect(UGameplayEffect GameplayEffect, in FGameplayEffectSpec Spec, UAbilitySystemComponent ASC)
		{
			CustomRequirment_C.__CanApplyGameplayEffect_FunctionParams* ptr = stackalloc CustomRequirment_C.__CanApplyGameplayEffect_FunctionParams[(UIntPtr)767] + 15L / (long)sizeof(CustomRequirment_C.__CanApplyGameplayEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(CustomRequirment_C.__CanApplyGameplayEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayEffect = ((GameplayEffect != null) ? GameplayEffect.NativePtr : IntPtr.Zero);
			if (Spec != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectSpec.StaticStruct(), &ptr->Spec, Spec.NativePtr, 1, false);
			}
			ptr->ASC = ((ASC != null) ? ASC.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, CustomRequirment_C.__CanApplyGameplayEffect_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(CustomRequirment_C.__CanApplyGameplayEffect_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602D0DA RID: 184538 RVA: 0x00A2FA3C File Offset: 0x00A2DC3C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override bool CanApplyGameplayEffect_Implementation(UGameplayEffect GameplayEffect, in FGameplayEffectSpec Spec, UAbilitySystemComponent ASC)
		{
			CustomRequirment_C.__CanApplyGameplayEffect_FunctionParams* ptr = stackalloc CustomRequirment_C.__CanApplyGameplayEffect_FunctionParams[(UIntPtr)767] + 15L / (long)sizeof(CustomRequirment_C.__CanApplyGameplayEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(CustomRequirment_C.__CanApplyGameplayEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayEffect = ((GameplayEffect != null) ? GameplayEffect.NativePtr : IntPtr.Zero);
			if (Spec != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectSpec.StaticStruct(), &ptr->Spec, Spec.NativePtr, 1, false);
			}
			ptr->ASC = ((ASC != null) ? ASC.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, CustomRequirment_C.__CanApplyGameplayEffect_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(CustomRequirment_C.__CanApplyGameplayEffect_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602D0DB RID: 184539 RVA: 0x00A2FAE6 File Offset: 0x00A2DCE6
		protected CustomRequirment_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E98 RID: 97944
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/ApplicationRequirment/CustomRequirment.CustomRequirment_C";

		// Token: 0x04017E99 RID: 97945
		private static IntPtr _ClassPtr;

		// Token: 0x04017E9A RID: 97946
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017E9B RID: 97947
		private static IntPtr __CanApplyGameplayEffect_NativeFunctionPtr;

		// Token: 0x0200A67B RID: 42619
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 752)]
		protected new ref struct __CanApplyGameplayEffect_FunctionParams
		{
			// Token: 0x040325C8 RID: 206280
			[FieldOffset(0)]
			public IntPtr GameplayEffect;

			// Token: 0x040325C9 RID: 206281
			[FieldOffset(8)]
			public byte Spec;

			// Token: 0x040325CA RID: 206282
			[FieldOffset(696)]
			public IntPtr ASC;

			// Token: 0x040325CB RID: 206283
			[FieldOffset(704)]
			public bool __Result;
		}
	}
}
