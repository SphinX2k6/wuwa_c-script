using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_AttributeModifier
{
	// Token: 0x0200441F RID: 17439
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element2Clear.GE_Element2Clear_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Element2Clear_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D178 RID: 184696 RVA: 0x00A30FA8 File Offset: 0x00A2F1A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Element2Clear_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element2Clear.GE_Element2Clear_C");
			}
			return GE_Element2Clear_C._ClassPtr;
		}

		// Token: 0x0602D179 RID: 184697 RVA: 0x00A30FCC File Offset: 0x00A2F1CC
		public GE_Element2Clear_C() : this(BuiltinUtils.AllocNativeUObject(GE_Element2Clear_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D17A RID: 184698 RVA: 0x00A30FF4 File Offset: 0x00A2F1F4
		[NullableContext(1)]
		public GE_Element2Clear_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Element2Clear_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D17B RID: 184699 RVA: 0x00A31027 File Offset: 0x00A2F227
		protected GE_Element2Clear_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F11 RID: 98065
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element2Clear.GE_Element2Clear_C";

		// Token: 0x04017F12 RID: 98066
		private static IntPtr _ClassPtr;

		// Token: 0x04017F13 RID: 98067
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
