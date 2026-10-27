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
	// Token: 0x0200412C RID: 16684
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Elemental_Skill.GA_Elemental_Skill_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Elemental_Skill_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AFE4 RID: 176100 RVA: 0x009F2648 File Offset: 0x009F0848
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Elemental_Skill_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Elemental_Skill.GA_Elemental_Skill_C");
			}
			return GA_Elemental_Skill_C._ClassPtr;
		}

		// Token: 0x0602AFE5 RID: 176101 RVA: 0x009F266C File Offset: 0x009F086C
		public GA_Elemental_Skill_C() : this(BuiltinUtils.AllocNativeUObject(GA_Elemental_Skill_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AFE6 RID: 176102 RVA: 0x009F2694 File Offset: 0x009F0894
		[NullableContext(1)]
		public GA_Elemental_Skill_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Elemental_Skill_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AFE7 RID: 176103 RVA: 0x009F26C7 File Offset: 0x009F08C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Elemental_Skill_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFE8 RID: 176104 RVA: 0x009F26DB File Offset: 0x009F08DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Elemental_Skill_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AFE9 RID: 176105 RVA: 0x009F26F0 File Offset: 0x009F08F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Elemental_Skill_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Elemental_Skill_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Elemental_Skill_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Elemental_Skill_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Elemental_Skill_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AFEA RID: 176106 RVA: 0x009F2738 File Offset: 0x009F0938
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Elemental_Skill_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Elemental_Skill_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Elemental_Skill_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Elemental_Skill_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Elemental_Skill_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AFEB RID: 176107 RVA: 0x009F277F File Offset: 0x009F097F
		protected GA_Elemental_Skill_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040164BC RID: 91324
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Elemental_Skill.GA_Elemental_Skill_C";

		// Token: 0x040164BD RID: 91325
		private static IntPtr _ClassPtr;

		// Token: 0x040164BE RID: 91326
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040164BF RID: 91327
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040164C0 RID: 91328
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A45A RID: 42074
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403229E RID: 205470
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
