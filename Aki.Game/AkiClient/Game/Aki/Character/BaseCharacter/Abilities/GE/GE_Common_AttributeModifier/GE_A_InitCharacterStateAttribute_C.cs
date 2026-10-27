using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_AttributeModifier
{
	// Token: 0x0200441C RID: 17436
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_A_InitCharacterStateAttribute.GE_A_InitCharacterStateAttribute_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_A_InitCharacterStateAttribute_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D16C RID: 184684 RVA: 0x00A30E10 File Offset: 0x00A2F010
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_A_InitCharacterStateAttribute_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_A_InitCharacterStateAttribute.GE_A_InitCharacterStateAttribute_C");
			}
			return GE_A_InitCharacterStateAttribute_C._ClassPtr;
		}

		// Token: 0x0602D16D RID: 184685 RVA: 0x00A30E34 File Offset: 0x00A2F034
		public GE_A_InitCharacterStateAttribute_C() : this(BuiltinUtils.AllocNativeUObject(GE_A_InitCharacterStateAttribute_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D16E RID: 184686 RVA: 0x00A30E5C File Offset: 0x00A2F05C
		[NullableContext(1)]
		public GE_A_InitCharacterStateAttribute_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_A_InitCharacterStateAttribute_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D16F RID: 184687 RVA: 0x00A30E8F File Offset: 0x00A2F08F
		protected GE_A_InitCharacterStateAttribute_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F08 RID: 98056
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_A_InitCharacterStateAttribute.GE_A_InitCharacterStateAttribute_C";

		// Token: 0x04017F09 RID: 98057
		private static IntPtr _ClassPtr;

		// Token: 0x04017F0A RID: 98058
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
