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
	// Token: 0x0200413F RID: 16703
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Giant_Passive.GA_Interaction_Giant_Passive_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class GA_Interaction_Giant_Passive_C : Ga_Passive_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B0F7 RID: 176375 RVA: 0x009F485E File Offset: 0x009F2A5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Interaction_Giant_Passive_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Giant_Passive.GA_Interaction_Giant_Passive_C");
			}
			return GA_Interaction_Giant_Passive_C._ClassPtr;
		}

		// Token: 0x0602B0F8 RID: 176376 RVA: 0x009F4884 File Offset: 0x009F2A84
		public GA_Interaction_Giant_Passive_C() : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_Giant_Passive_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B0F9 RID: 176377 RVA: 0x009F48AC File Offset: 0x009F2AAC
		[NullableContext(1)]
		public GA_Interaction_Giant_Passive_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_Giant_Passive_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B0FA RID: 176378 RVA: 0x009F48DF File Offset: 0x009F2ADF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Giant_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0FB RID: 176379 RVA: 0x009F48F3 File Offset: 0x009F2AF3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_Giant_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B0FC RID: 176380 RVA: 0x009F4908 File Offset: 0x009F2B08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Interaction_Giant_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_Giant_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_Giant_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_Giant_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Giant_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B0FD RID: 176381 RVA: 0x009F4950 File Offset: 0x009F2B50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Interaction_Giant_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_Giant_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_Giant_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_Giant_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_Giant_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B0FE RID: 176382 RVA: 0x009F4997 File Offset: 0x009F2B97
		protected GA_Interaction_Giant_Passive_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401657E RID: 91518
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Giant_Passive.GA_Interaction_Giant_Passive_C";

		// Token: 0x0401657F RID: 91519
		private static IntPtr _ClassPtr;

		// Token: 0x04016580 RID: 91520
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016581 RID: 91521
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016582 RID: 91522
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A470 RID: 42096
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322BB RID: 205499
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
