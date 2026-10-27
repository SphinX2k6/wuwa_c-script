using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_AttributeModifier
{
	// Token: 0x0200441B RID: 17435
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_A_InitCharacterAttributes.GE_A_InitCharacterAttributes_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_A_InitCharacterAttributes_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D168 RID: 184680 RVA: 0x00A30D88 File Offset: 0x00A2EF88
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_A_InitCharacterAttributes_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_A_InitCharacterAttributes.GE_A_InitCharacterAttributes_C");
			}
			return GE_A_InitCharacterAttributes_C._ClassPtr;
		}

		// Token: 0x0602D169 RID: 184681 RVA: 0x00A30DAC File Offset: 0x00A2EFAC
		public GE_A_InitCharacterAttributes_C() : this(BuiltinUtils.AllocNativeUObject(GE_A_InitCharacterAttributes_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D16A RID: 184682 RVA: 0x00A30DD4 File Offset: 0x00A2EFD4
		[NullableContext(1)]
		public GE_A_InitCharacterAttributes_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_A_InitCharacterAttributes_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D16B RID: 184683 RVA: 0x00A30E07 File Offset: 0x00A2F007
		protected GE_A_InitCharacterAttributes_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F05 RID: 98053
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_A_InitCharacterAttributes.GE_A_InitCharacterAttributes_C";

		// Token: 0x04017F06 RID: 98054
		private static IntPtr _ClassPtr;

		// Token: 0x04017F07 RID: 98055
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
