using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Stamina
{
	// Token: 0x0200440F RID: 17423
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_StaminaSkillTime.GE_StaminaSkillTime_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_StaminaSkillTime_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D138 RID: 184632 RVA: 0x00A30728 File Offset: 0x00A2E928
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_StaminaSkillTime_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_StaminaSkillTime.GE_StaminaSkillTime_C");
			}
			return GE_StaminaSkillTime_C._ClassPtr;
		}

		// Token: 0x0602D139 RID: 184633 RVA: 0x00A3074C File Offset: 0x00A2E94C
		public GE_StaminaSkillTime_C() : this(BuiltinUtils.AllocNativeUObject(GE_StaminaSkillTime_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D13A RID: 184634 RVA: 0x00A30774 File Offset: 0x00A2E974
		[NullableContext(1)]
		public GE_StaminaSkillTime_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_StaminaSkillTime_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D13B RID: 184635 RVA: 0x00A307A7 File Offset: 0x00A2E9A7
		protected GE_StaminaSkillTime_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EE1 RID: 98017
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_StaminaSkillTime.GE_StaminaSkillTime_C";

		// Token: 0x04017EE2 RID: 98018
		private static IntPtr _ClassPtr;

		// Token: 0x04017EE3 RID: 98019
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
