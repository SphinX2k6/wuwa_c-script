using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_AttributeModifier
{
	// Token: 0x0200441D RID: 17437
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_DarkSlotModifier.GE_DarkSlotModifier_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_DarkSlotModifier_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D170 RID: 184688 RVA: 0x00A30E98 File Offset: 0x00A2F098
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_DarkSlotModifier_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_DarkSlotModifier.GE_DarkSlotModifier_C");
			}
			return GE_DarkSlotModifier_C._ClassPtr;
		}

		// Token: 0x0602D171 RID: 184689 RVA: 0x00A30EBC File Offset: 0x00A2F0BC
		public GE_DarkSlotModifier_C() : this(BuiltinUtils.AllocNativeUObject(GE_DarkSlotModifier_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D172 RID: 184690 RVA: 0x00A30EE4 File Offset: 0x00A2F0E4
		[NullableContext(1)]
		public GE_DarkSlotModifier_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_DarkSlotModifier_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D173 RID: 184691 RVA: 0x00A30F17 File Offset: 0x00A2F117
		protected GE_DarkSlotModifier_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F0B RID: 98059
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_DarkSlotModifier.GE_DarkSlotModifier_C";

		// Token: 0x04017F0C RID: 98060
		private static IntPtr _ClassPtr;

		// Token: 0x04017F0D RID: 98061
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
