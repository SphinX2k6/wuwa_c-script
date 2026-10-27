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
	// Token: 0x02004142 RID: 16706
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_StandControl_Passive.GA_Interaction_StandControl_Passive_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class GA_Interaction_StandControl_Passive_C : Ga_Passive_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B119 RID: 176409 RVA: 0x009F4C1E File Offset: 0x009F2E1E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Interaction_StandControl_Passive_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_StandControl_Passive.GA_Interaction_StandControl_Passive_C");
			}
			return GA_Interaction_StandControl_Passive_C._ClassPtr;
		}

		// Token: 0x0602B11A RID: 176410 RVA: 0x009F4C44 File Offset: 0x009F2E44
		public GA_Interaction_StandControl_Passive_C() : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_StandControl_Passive_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B11B RID: 176411 RVA: 0x009F4C6C File Offset: 0x009F2E6C
		[NullableContext(1)]
		public GA_Interaction_StandControl_Passive_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_StandControl_Passive_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B11C RID: 176412 RVA: 0x009F4C9F File Offset: 0x009F2E9F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_StandControl_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B11D RID: 176413 RVA: 0x009F4CB3 File Offset: 0x009F2EB3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_StandControl_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B11E RID: 176414 RVA: 0x009F4CC8 File Offset: 0x009F2EC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Interaction_StandControl_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_StandControl_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_StandControl_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_StandControl_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_StandControl_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B11F RID: 176415 RVA: 0x009F4D10 File Offset: 0x009F2F10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Interaction_StandControl_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_StandControl_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_StandControl_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_StandControl_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_StandControl_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B120 RID: 176416 RVA: 0x009F4D57 File Offset: 0x009F2F57
		protected GA_Interaction_StandControl_Passive_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016597 RID: 91543
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_StandControl_Passive.GA_Interaction_StandControl_Passive_C";

		// Token: 0x04016598 RID: 91544
		private static IntPtr _ClassPtr;

		// Token: 0x04016599 RID: 91545
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401659A RID: 91546
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401659B RID: 91547
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A471 RID: 42097
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322BC RID: 205500
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
