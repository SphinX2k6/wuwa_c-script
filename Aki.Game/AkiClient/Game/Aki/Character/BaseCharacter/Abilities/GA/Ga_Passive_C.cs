using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA
{
	// Token: 0x020033FB RID: 13307
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GA/Ga_Passive.Ga_Passive_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class Ga_Passive_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021C75 RID: 138357 RVA: 0x0096AC73 File Offset: 0x00968E73
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (Ga_Passive_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GA/Ga_Passive.Ga_Passive_C");
			}
			return Ga_Passive_C._ClassPtr;
		}

		// Token: 0x06021C76 RID: 138358 RVA: 0x0096AC98 File Offset: 0x00968E98
		public Ga_Passive_C() : this(BuiltinUtils.AllocNativeUObject(Ga_Passive_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021C77 RID: 138359 RVA: 0x0096ACC0 File Offset: 0x00968EC0
		[NullableContext(1)]
		public Ga_Passive_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(Ga_Passive_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021C78 RID: 138360 RVA: 0x0096ACF3 File Offset: 0x00968EF3
		[SkipLocalsInit]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ga_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x06021C79 RID: 138361 RVA: 0x0096AD07 File Offset: 0x00968F07
		[SkipLocalsInit]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Ga_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x06021C7A RID: 138362 RVA: 0x0096AD1C File Offset: 0x00968F1C
		[SkipLocalsInit]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			Ga_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc Ga_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(Ga_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ga_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ga_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C7B RID: 138363 RVA: 0x0096AD64 File Offset: 0x00968F64
		[SkipLocalsInit]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			Ga_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc Ga_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(Ga_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ga_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Ga_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C7C RID: 138364 RVA: 0x0096ADAA File Offset: 0x00968FAA
		protected Ga_Passive_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040129E9 RID: 76265
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GA/Ga_Passive.Ga_Passive_C";

		// Token: 0x040129EA RID: 76266
		private static IntPtr _ClassPtr;

		// Token: 0x040129EB RID: 76267
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040129EC RID: 76268
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040129ED RID: 76269
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x020090E3 RID: 37091
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0402CF91 RID: 184209
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
