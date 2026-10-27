using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA
{
	// Token: 0x0200442A RID: 17450
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GA/Ga_Passive.Ga_Passive_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class Ga_Passive_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D20C RID: 184844 RVA: 0x00A33FE0 File Offset: 0x00A321E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (Ga_Passive_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GA/Ga_Passive.Ga_Passive_C");
			}
			return Ga_Passive_C._ClassPtr;
		}

		// Token: 0x0602D20D RID: 184845 RVA: 0x00A34004 File Offset: 0x00A32204
		public Ga_Passive_C() : this(BuiltinUtils.AllocNativeUObject(Ga_Passive_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D20E RID: 184846 RVA: 0x00A3402C File Offset: 0x00A3222C
		[NullableContext(1)]
		public Ga_Passive_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(Ga_Passive_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D20F RID: 184847 RVA: 0x00A3405F File Offset: 0x00A3225F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ga_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602D210 RID: 184848 RVA: 0x00A34073 File Offset: 0x00A32273
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Ga_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602D211 RID: 184849 RVA: 0x00A34088 File Offset: 0x00A32288
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			Ga_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc Ga_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(Ga_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ga_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ga_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D212 RID: 184850 RVA: 0x00A340D0 File Offset: 0x00A322D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			Ga_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc Ga_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(Ga_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ga_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Ga_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602D213 RID: 184851 RVA: 0x00A34117 File Offset: 0x00A32317
		protected Ga_Passive_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F95 RID: 98197
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GA/Ga_Passive.Ga_Passive_C";

		// Token: 0x04017F96 RID: 98198
		private static IntPtr _ClassPtr;

		// Token: 0x04017F97 RID: 98199
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017F98 RID: 98200
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04017F99 RID: 98201
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A6D8 RID: 42712
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040326BF RID: 206527
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
