using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_AttributeModifier
{
	// Token: 0x02004425 RID: 17445
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_HpModifier.GE_HpModifier_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_HpModifier_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D190 RID: 184720 RVA: 0x00A312D8 File Offset: 0x00A2F4D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_HpModifier_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_HpModifier.GE_HpModifier_C");
			}
			return GE_HpModifier_C._ClassPtr;
		}

		// Token: 0x0602D191 RID: 184721 RVA: 0x00A312FC File Offset: 0x00A2F4FC
		public GE_HpModifier_C() : this(BuiltinUtils.AllocNativeUObject(GE_HpModifier_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D192 RID: 184722 RVA: 0x00A31324 File Offset: 0x00A2F524
		[NullableContext(1)]
		public GE_HpModifier_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_HpModifier_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D193 RID: 184723 RVA: 0x00A31357 File Offset: 0x00A2F557
		protected GE_HpModifier_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F23 RID: 98083
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_HpModifier.GE_HpModifier_C";

		// Token: 0x04017F24 RID: 98084
		private static IntPtr _ClassPtr;

		// Token: 0x04017F25 RID: 98085
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
