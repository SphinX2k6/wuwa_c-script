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
	// Token: 0x0200413C RID: 16700
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Catapult_Passive.GA_Interaction_Catapult_Passive_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class GA_Interaction_Catapult_Passive_C : Ga_Passive_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B0D5 RID: 176341 RVA: 0x009F449D File Offset: 0x009F269D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Interaction_Catapult_Passive_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Catapult_Passive.GA_Interaction_Catapult_Passive_C");
			}
			return GA_Interaction_Catapult_Passive_C._ClassPtr;
		}

		// Token: 0x0602B0D6 RID: 176342 RVA: 0x009F44C4 File Offset: 0x009F26C4
		public GA_Interaction_Catapult_Passive_C() : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_Catapult_Passive_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B0D7 RID: 176343 RVA: 0x009F44EC File Offset: 0x009F26EC
		[NullableContext(1)]
		public GA_Interaction_Catapult_Passive_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_Catapult_Passive_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B0D8 RID: 176344 RVA: 0x009F451F File Offset: 0x009F271F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0D9 RID: 176345 RVA: 0x009F4533 File Offset: 0x009F2733
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_Catapult_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B0DA RID: 176346 RVA: 0x009F4548 File Offset: 0x009F2748
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Interaction_Catapult_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_Catapult_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_Catapult_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_Catapult_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B0DB RID: 176347 RVA: 0x009F4590 File Offset: 0x009F2790
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Interaction_Catapult_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_Catapult_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_Catapult_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_Catapult_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_Catapult_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B0DC RID: 176348 RVA: 0x009F45D7 File Offset: 0x009F27D7
		protected GA_Interaction_Catapult_Passive_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016565 RID: 91493
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Catapult_Passive.GA_Interaction_Catapult_Passive_C";

		// Token: 0x04016566 RID: 91494
		private static IntPtr _ClassPtr;

		// Token: 0x04016567 RID: 91495
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016568 RID: 91496
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016569 RID: 91497
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A46F RID: 42095
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322BA RID: 205498
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
