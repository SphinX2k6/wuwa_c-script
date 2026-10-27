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
	// Token: 0x02004144 RID: 16708
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_SuperCatapult_Passive.GA_Interaction_SuperCatapult_Passive_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class GA_Interaction_SuperCatapult_Passive_C : Ga_Passive_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B131 RID: 176433 RVA: 0x009F4F99 File Offset: 0x009F3199
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Interaction_SuperCatapult_Passive_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_SuperCatapult_Passive.GA_Interaction_SuperCatapult_Passive_C");
			}
			return GA_Interaction_SuperCatapult_Passive_C._ClassPtr;
		}

		// Token: 0x0602B132 RID: 176434 RVA: 0x009F4FC0 File Offset: 0x009F31C0
		public GA_Interaction_SuperCatapult_Passive_C() : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_SuperCatapult_Passive_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B133 RID: 176435 RVA: 0x009F4FE8 File Offset: 0x009F31E8
		[NullableContext(1)]
		public GA_Interaction_SuperCatapult_Passive_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_SuperCatapult_Passive_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B134 RID: 176436 RVA: 0x009F501B File Offset: 0x009F321B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_SuperCatapult_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B135 RID: 176437 RVA: 0x009F502F File Offset: 0x009F322F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_SuperCatapult_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B136 RID: 176438 RVA: 0x009F5044 File Offset: 0x009F3244
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Interaction_SuperCatapult_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_SuperCatapult_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_SuperCatapult_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_SuperCatapult_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_SuperCatapult_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B137 RID: 176439 RVA: 0x009F508C File Offset: 0x009F328C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Interaction_SuperCatapult_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_SuperCatapult_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_SuperCatapult_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_SuperCatapult_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_SuperCatapult_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B138 RID: 176440 RVA: 0x009F50D3 File Offset: 0x009F32D3
		protected GA_Interaction_SuperCatapult_Passive_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040165A8 RID: 91560
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_SuperCatapult_Passive.GA_Interaction_SuperCatapult_Passive_C";

		// Token: 0x040165A9 RID: 91561
		private static IntPtr _ClassPtr;

		// Token: 0x040165AA RID: 91562
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040165AB RID: 91563
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040165AC RID: 91564
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A474 RID: 42100
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322C1 RID: 205505
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
