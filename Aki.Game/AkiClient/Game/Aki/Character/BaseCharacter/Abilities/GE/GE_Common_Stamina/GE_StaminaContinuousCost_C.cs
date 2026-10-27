using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Stamina
{
	// Token: 0x0200440D RID: 17421
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_StaminaContinuousCost.GE_StaminaContinuousCost_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_StaminaContinuousCost_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D130 RID: 184624 RVA: 0x00A30618 File Offset: 0x00A2E818
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_StaminaContinuousCost_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_StaminaContinuousCost.GE_StaminaContinuousCost_C");
			}
			return GE_StaminaContinuousCost_C._ClassPtr;
		}

		// Token: 0x0602D131 RID: 184625 RVA: 0x00A3063C File Offset: 0x00A2E83C
		public GE_StaminaContinuousCost_C() : this(BuiltinUtils.AllocNativeUObject(GE_StaminaContinuousCost_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D132 RID: 184626 RVA: 0x00A30664 File Offset: 0x00A2E864
		[NullableContext(1)]
		public GE_StaminaContinuousCost_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_StaminaContinuousCost_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D133 RID: 184627 RVA: 0x00A30697 File Offset: 0x00A2E897
		protected GE_StaminaContinuousCost_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EDB RID: 98011
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_StaminaContinuousCost.GE_StaminaContinuousCost_C";

		// Token: 0x04017EDC RID: 98012
		private static IntPtr _ClassPtr;

		// Token: 0x04017EDD RID: 98013
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
