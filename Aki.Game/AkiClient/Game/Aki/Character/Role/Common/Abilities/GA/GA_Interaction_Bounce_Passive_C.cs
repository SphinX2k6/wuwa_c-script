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
	// Token: 0x02004139 RID: 16697
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Bounce_Passive.GA_Interaction_Bounce_Passive_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class GA_Interaction_Bounce_Passive_C : Ga_Passive_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B0A8 RID: 176296 RVA: 0x009F3E81 File Offset: 0x009F2081
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Interaction_Bounce_Passive_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Bounce_Passive.GA_Interaction_Bounce_Passive_C");
			}
			return GA_Interaction_Bounce_Passive_C._ClassPtr;
		}

		// Token: 0x0602B0A9 RID: 176297 RVA: 0x009F3EA8 File Offset: 0x009F20A8
		public GA_Interaction_Bounce_Passive_C() : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_Bounce_Passive_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B0AA RID: 176298 RVA: 0x009F3ED0 File Offset: 0x009F20D0
		[NullableContext(1)]
		public GA_Interaction_Bounce_Passive_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_Bounce_Passive_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B0AB RID: 176299 RVA: 0x009F3F03 File Offset: 0x009F2103
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Bounce_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0AC RID: 176300 RVA: 0x009F3F17 File Offset: 0x009F2117
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_Bounce_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B0AD RID: 176301 RVA: 0x009F3F2C File Offset: 0x009F212C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Interaction_Bounce_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_Bounce_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_Bounce_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_Bounce_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Bounce_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B0AE RID: 176302 RVA: 0x009F3F74 File Offset: 0x009F2174
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Interaction_Bounce_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_Bounce_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_Bounce_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_Bounce_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_Bounce_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B0AF RID: 176303 RVA: 0x009F3FBB File Offset: 0x009F21BB
		protected GA_Interaction_Bounce_Passive_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016543 RID: 91459
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Bounce_Passive.GA_Interaction_Bounce_Passive_C";

		// Token: 0x04016544 RID: 91460
		private static IntPtr _ClassPtr;

		// Token: 0x04016545 RID: 91461
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016546 RID: 91462
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016547 RID: 91463
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A46A RID: 42090
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322B1 RID: 205489
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
