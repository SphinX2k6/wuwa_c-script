using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Stamina
{
	// Token: 0x02004405 RID: 17413
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_StaminaBuffCost.GE_Common_StaminaBuffCost_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Common_StaminaBuffCost_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D110 RID: 184592 RVA: 0x00A301D8 File Offset: 0x00A2E3D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Common_StaminaBuffCost_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_StaminaBuffCost.GE_Common_StaminaBuffCost_C");
			}
			return GE_Common_StaminaBuffCost_C._ClassPtr;
		}

		// Token: 0x0602D111 RID: 184593 RVA: 0x00A301FC File Offset: 0x00A2E3FC
		public GE_Common_StaminaBuffCost_C() : this(BuiltinUtils.AllocNativeUObject(GE_Common_StaminaBuffCost_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D112 RID: 184594 RVA: 0x00A30224 File Offset: 0x00A2E424
		[NullableContext(1)]
		public GE_Common_StaminaBuffCost_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Common_StaminaBuffCost_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D113 RID: 184595 RVA: 0x00A30257 File Offset: 0x00A2E457
		protected GE_Common_StaminaBuffCost_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EC3 RID: 97987
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_StaminaBuffCost.GE_Common_StaminaBuffCost_C";

		// Token: 0x04017EC4 RID: 97988
		private static IntPtr _ClassPtr;

		// Token: 0x04017EC5 RID: 97989
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
