using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_AttributeModifier
{
	// Token: 0x0200441E RID: 17438
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element1Clear.GE_Element1Clear_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Element1Clear_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D174 RID: 184692 RVA: 0x00A30F20 File Offset: 0x00A2F120
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Element1Clear_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element1Clear.GE_Element1Clear_C");
			}
			return GE_Element1Clear_C._ClassPtr;
		}

		// Token: 0x0602D175 RID: 184693 RVA: 0x00A30F44 File Offset: 0x00A2F144
		public GE_Element1Clear_C() : this(BuiltinUtils.AllocNativeUObject(GE_Element1Clear_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D176 RID: 184694 RVA: 0x00A30F6C File Offset: 0x00A2F16C
		[NullableContext(1)]
		public GE_Element1Clear_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Element1Clear_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D177 RID: 184695 RVA: 0x00A30F9F File Offset: 0x00A2F19F
		protected GE_Element1Clear_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F0E RID: 98062
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element1Clear.GE_Element1Clear_C";

		// Token: 0x04017F0F RID: 98063
		private static IntPtr _ClassPtr;

		// Token: 0x04017F10 RID: 98064
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
