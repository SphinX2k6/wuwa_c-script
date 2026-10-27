using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_AttributeModifier
{
	// Token: 0x02004422 RID: 17442
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element5Clear.GE_Element5Clear_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Element5Clear_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D184 RID: 184708 RVA: 0x00A31140 File Offset: 0x00A2F340
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Element5Clear_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element5Clear.GE_Element5Clear_C");
			}
			return GE_Element5Clear_C._ClassPtr;
		}

		// Token: 0x0602D185 RID: 184709 RVA: 0x00A31164 File Offset: 0x00A2F364
		public GE_Element5Clear_C() : this(BuiltinUtils.AllocNativeUObject(GE_Element5Clear_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D186 RID: 184710 RVA: 0x00A3118C File Offset: 0x00A2F38C
		[NullableContext(1)]
		public GE_Element5Clear_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Element5Clear_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D187 RID: 184711 RVA: 0x00A311BF File Offset: 0x00A2F3BF
		protected GE_Element5Clear_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F1A RID: 98074
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element5Clear.GE_Element5Clear_C";

		// Token: 0x04017F1B RID: 98075
		private static IntPtr _ClassPtr;

		// Token: 0x04017F1C RID: 98076
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
