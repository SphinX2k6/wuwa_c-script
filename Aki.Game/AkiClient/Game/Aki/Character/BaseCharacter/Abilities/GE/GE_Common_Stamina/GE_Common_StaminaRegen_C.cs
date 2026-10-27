using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Stamina
{
	// Token: 0x02004408 RID: 17416
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_StaminaRegen.GE_Common_StaminaRegen_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Common_StaminaRegen_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D11C RID: 184604 RVA: 0x00A30370 File Offset: 0x00A2E570
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Common_StaminaRegen_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_StaminaRegen.GE_Common_StaminaRegen_C");
			}
			return GE_Common_StaminaRegen_C._ClassPtr;
		}

		// Token: 0x0602D11D RID: 184605 RVA: 0x00A30394 File Offset: 0x00A2E594
		public GE_Common_StaminaRegen_C() : this(BuiltinUtils.AllocNativeUObject(GE_Common_StaminaRegen_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D11E RID: 184606 RVA: 0x00A303BC File Offset: 0x00A2E5BC
		[NullableContext(1)]
		public GE_Common_StaminaRegen_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Common_StaminaRegen_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D11F RID: 184607 RVA: 0x00A303EF File Offset: 0x00A2E5EF
		protected GE_Common_StaminaRegen_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017ECC RID: 97996
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_StaminaRegen.GE_Common_StaminaRegen_C";

		// Token: 0x04017ECD RID: 97997
		private static IntPtr _ClassPtr;

		// Token: 0x04017ECE RID: 97998
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
