using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_AttributeModifier
{
	// Token: 0x0200441A RID: 17434
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_A_InitCharacterAttributesGrow.GE_A_InitCharacterAttributesGrow_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_A_InitCharacterAttributesGrow_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D164 RID: 184676 RVA: 0x00A30D00 File Offset: 0x00A2EF00
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_A_InitCharacterAttributesGrow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_A_InitCharacterAttributesGrow.GE_A_InitCharacterAttributesGrow_C");
			}
			return GE_A_InitCharacterAttributesGrow_C._ClassPtr;
		}

		// Token: 0x0602D165 RID: 184677 RVA: 0x00A30D24 File Offset: 0x00A2EF24
		public GE_A_InitCharacterAttributesGrow_C() : this(BuiltinUtils.AllocNativeUObject(GE_A_InitCharacterAttributesGrow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D166 RID: 184678 RVA: 0x00A30D4C File Offset: 0x00A2EF4C
		[NullableContext(1)]
		public GE_A_InitCharacterAttributesGrow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_A_InitCharacterAttributesGrow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D167 RID: 184679 RVA: 0x00A30D7F File Offset: 0x00A2EF7F
		protected GE_A_InitCharacterAttributesGrow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F02 RID: 98050
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_A_InitCharacterAttributesGrow.GE_A_InitCharacterAttributesGrow_C";

		// Token: 0x04017F03 RID: 98051
		private static IntPtr _ClassPtr;

		// Token: 0x04017F04 RID: 98052
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
