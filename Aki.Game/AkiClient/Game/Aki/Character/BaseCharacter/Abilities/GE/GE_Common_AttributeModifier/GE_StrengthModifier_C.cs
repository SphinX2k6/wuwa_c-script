using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_AttributeModifier
{
	// Token: 0x02004426 RID: 17446
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_StrengthModifier.GE_StrengthModifier_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_StrengthModifier_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D194 RID: 184724 RVA: 0x00A31360 File Offset: 0x00A2F560
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_StrengthModifier_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_StrengthModifier.GE_StrengthModifier_C");
			}
			return GE_StrengthModifier_C._ClassPtr;
		}

		// Token: 0x0602D195 RID: 184725 RVA: 0x00A31384 File Offset: 0x00A2F584
		public GE_StrengthModifier_C() : this(BuiltinUtils.AllocNativeUObject(GE_StrengthModifier_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D196 RID: 184726 RVA: 0x00A313AC File Offset: 0x00A2F5AC
		[NullableContext(1)]
		public GE_StrengthModifier_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_StrengthModifier_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D197 RID: 184727 RVA: 0x00A313DF File Offset: 0x00A2F5DF
		protected GE_StrengthModifier_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F26 RID: 98086
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_StrengthModifier.GE_StrengthModifier_C";

		// Token: 0x04017F27 RID: 98087
		private static IntPtr _ClassPtr;

		// Token: 0x04017F28 RID: 98088
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
