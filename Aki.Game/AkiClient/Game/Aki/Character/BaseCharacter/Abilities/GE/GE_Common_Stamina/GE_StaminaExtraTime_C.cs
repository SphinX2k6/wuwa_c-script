using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Stamina
{
	// Token: 0x0200440E RID: 17422
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_StaminaExtraTime.GE_StaminaExtraTime_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_StaminaExtraTime_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D134 RID: 184628 RVA: 0x00A306A0 File Offset: 0x00A2E8A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_StaminaExtraTime_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_StaminaExtraTime.GE_StaminaExtraTime_C");
			}
			return GE_StaminaExtraTime_C._ClassPtr;
		}

		// Token: 0x0602D135 RID: 184629 RVA: 0x00A306C4 File Offset: 0x00A2E8C4
		public GE_StaminaExtraTime_C() : this(BuiltinUtils.AllocNativeUObject(GE_StaminaExtraTime_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D136 RID: 184630 RVA: 0x00A306EC File Offset: 0x00A2E8EC
		[NullableContext(1)]
		public GE_StaminaExtraTime_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_StaminaExtraTime_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D137 RID: 184631 RVA: 0x00A3071F File Offset: 0x00A2E91F
		protected GE_StaminaExtraTime_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EDE RID: 98014
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_StaminaExtraTime.GE_StaminaExtraTime_C";

		// Token: 0x04017EDF RID: 98015
		private static IntPtr _ClassPtr;

		// Token: 0x04017EE0 RID: 98016
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
