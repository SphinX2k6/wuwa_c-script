using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Tough
{
	// Token: 0x020043FE RID: 17406
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Tough/GE_Tough_Skill.GE_Tough_Skill_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Tough_Skill_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0F4 RID: 184564 RVA: 0x00A2FE20 File Offset: 0x00A2E020
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Tough_Skill_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Tough/GE_Tough_Skill.GE_Tough_Skill_C");
			}
			return GE_Tough_Skill_C._ClassPtr;
		}

		// Token: 0x0602D0F5 RID: 184565 RVA: 0x00A2FE44 File Offset: 0x00A2E044
		public GE_Tough_Skill_C() : this(BuiltinUtils.AllocNativeUObject(GE_Tough_Skill_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0F6 RID: 184566 RVA: 0x00A2FE6C File Offset: 0x00A2E06C
		[NullableContext(1)]
		public GE_Tough_Skill_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Tough_Skill_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0F7 RID: 184567 RVA: 0x00A2FE9F File Offset: 0x00A2E09F
		protected GE_Tough_Skill_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EAE RID: 97966
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Tough/GE_Tough_Skill.GE_Tough_Skill_C";

		// Token: 0x04017EAF RID: 97967
		private static IntPtr _ClassPtr;

		// Token: 0x04017EB0 RID: 97968
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
