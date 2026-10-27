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
	// Token: 0x0200412B RID: 16683
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Elemental_Skill_BossChasing.GA_Elemental_Skill_BossChasing_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Elemental_Skill_BossChasing_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AFDC RID: 176092 RVA: 0x009F2507 File Offset: 0x009F0707
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Elemental_Skill_BossChasing_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Elemental_Skill_BossChasing.GA_Elemental_Skill_BossChasing_C");
			}
			return GA_Elemental_Skill_BossChasing_C._ClassPtr;
		}

		// Token: 0x0602AFDD RID: 176093 RVA: 0x009F252C File Offset: 0x009F072C
		public GA_Elemental_Skill_BossChasing_C() : this(BuiltinUtils.AllocNativeUObject(GA_Elemental_Skill_BossChasing_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AFDE RID: 176094 RVA: 0x009F2554 File Offset: 0x009F0754
		[NullableContext(1)]
		public GA_Elemental_Skill_BossChasing_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Elemental_Skill_BossChasing_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AFDF RID: 176095 RVA: 0x009F2587 File Offset: 0x009F0787
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Elemental_Skill_BossChasing_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFE0 RID: 176096 RVA: 0x009F259B File Offset: 0x009F079B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Elemental_Skill_BossChasing_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AFE1 RID: 176097 RVA: 0x009F25B0 File Offset: 0x009F07B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Elemental_Skill_BossChasing_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Elemental_Skill_BossChasing_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Elemental_Skill_BossChasing_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Elemental_Skill_BossChasing_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Elemental_Skill_BossChasing_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AFE2 RID: 176098 RVA: 0x009F25F8 File Offset: 0x009F07F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Elemental_Skill_BossChasing_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Elemental_Skill_BossChasing_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Elemental_Skill_BossChasing_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Elemental_Skill_BossChasing_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Elemental_Skill_BossChasing_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AFE3 RID: 176099 RVA: 0x009F263F File Offset: 0x009F083F
		protected GA_Elemental_Skill_BossChasing_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040164B7 RID: 91319
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Elemental_Skill_BossChasing.GA_Elemental_Skill_BossChasing_C";

		// Token: 0x040164B8 RID: 91320
		private static IntPtr _ClassPtr;

		// Token: 0x040164B9 RID: 91321
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040164BA RID: 91322
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040164BB RID: 91323
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A459 RID: 42073
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403229D RID: 205469
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
