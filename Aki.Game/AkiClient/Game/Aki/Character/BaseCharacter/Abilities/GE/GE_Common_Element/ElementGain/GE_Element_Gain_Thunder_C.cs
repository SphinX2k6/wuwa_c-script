using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Element.ElementGain
{
	// Token: 0x02004417 RID: 17431
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Thunder.GE_Element_Gain_Thunder_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Element_Gain_Thunder_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D158 RID: 184664 RVA: 0x00A30B68 File Offset: 0x00A2ED68
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Element_Gain_Thunder_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Thunder.GE_Element_Gain_Thunder_C");
			}
			return GE_Element_Gain_Thunder_C._ClassPtr;
		}

		// Token: 0x0602D159 RID: 184665 RVA: 0x00A30B8C File Offset: 0x00A2ED8C
		public GE_Element_Gain_Thunder_C() : this(BuiltinUtils.AllocNativeUObject(GE_Element_Gain_Thunder_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D15A RID: 184666 RVA: 0x00A30BB4 File Offset: 0x00A2EDB4
		[NullableContext(1)]
		public GE_Element_Gain_Thunder_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Element_Gain_Thunder_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D15B RID: 184667 RVA: 0x00A30BE7 File Offset: 0x00A2EDE7
		protected GE_Element_Gain_Thunder_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EF9 RID: 98041
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Thunder.GE_Element_Gain_Thunder_C";

		// Token: 0x04017EFA RID: 98042
		private static IntPtr _ClassPtr;

		// Token: 0x04017EFB RID: 98043
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
