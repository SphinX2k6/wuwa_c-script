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
	// Token: 0x02004125 RID: 16677
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_CommonMaleXL_AimShoot.GA_CommonMaleXL_AimShoot_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_CommonMaleXL_AimShoot_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AF84 RID: 176004 RVA: 0x009F1998 File Offset: 0x009EFB98
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_CommonMaleXL_AimShoot_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_CommonMaleXL_AimShoot.GA_CommonMaleXL_AimShoot_C");
			}
			return GA_CommonMaleXL_AimShoot_C._ClassPtr;
		}

		// Token: 0x0602AF85 RID: 176005 RVA: 0x009F19BC File Offset: 0x009EFBBC
		public GA_CommonMaleXL_AimShoot_C() : this(BuiltinUtils.AllocNativeUObject(GA_CommonMaleXL_AimShoot_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AF86 RID: 176006 RVA: 0x009F19E4 File Offset: 0x009EFBE4
		[NullableContext(1)]
		public GA_CommonMaleXL_AimShoot_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_CommonMaleXL_AimShoot_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069E1 RID: 27105
		// (get) Token: 0x0602AF87 RID: 176007 RVA: 0x009F1A17 File Offset: 0x009EFC17
		// (set) Token: 0x0602AF88 RID: 176008 RVA: 0x009F1A2B File Offset: 0x009EFC2B
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_CommonMaleXL_AimShoot_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_CommonMaleXL_AimShoot_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602AF89 RID: 176009 RVA: 0x009F1A40 File Offset: 0x009EFC40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimShoot_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF8A RID: 176010 RVA: 0x009F1A54 File Offset: 0x009EFC54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_CommonMaleXL_AimShoot_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AF8B RID: 176011 RVA: 0x009F1A6C File Offset: 0x009EFC6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_CommonMaleXL_AimShoot_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimShoot_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_CommonMaleXL_AimShoot_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimShoot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimShoot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF8C RID: 176012 RVA: 0x009F1AB4 File Offset: 0x009EFCB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_CommonMaleXL_AimShoot_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimShoot_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_CommonMaleXL_AimShoot_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimShoot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_CommonMaleXL_AimShoot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AF8D RID: 176013 RVA: 0x009F1AFB File Offset: 0x009EFCFB
		protected GA_CommonMaleXL_AimShoot_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401647D RID: 91261
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_CommonMaleXL_AimShoot.GA_CommonMaleXL_AimShoot_C";

		// Token: 0x0401647E RID: 91262
		private static IntPtr _ClassPtr;

		// Token: 0x0401647F RID: 91263
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016480 RID: 91264
		internal new static int __PropertyOffset_1;

		// Token: 0x04016481 RID: 91265
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016482 RID: 91266
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A450 RID: 42064
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403228F RID: 205455
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
