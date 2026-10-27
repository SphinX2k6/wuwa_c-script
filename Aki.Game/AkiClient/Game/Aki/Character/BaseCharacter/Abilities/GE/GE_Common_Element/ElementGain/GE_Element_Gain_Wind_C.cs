using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Element.ElementGain
{
	// Token: 0x02004418 RID: 17432
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Wind.GE_Element_Gain_Wind_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Element_Gain_Wind_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D15C RID: 184668 RVA: 0x00A30BF0 File Offset: 0x00A2EDF0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Element_Gain_Wind_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Wind.GE_Element_Gain_Wind_C");
			}
			return GE_Element_Gain_Wind_C._ClassPtr;
		}

		// Token: 0x0602D15D RID: 184669 RVA: 0x00A30C14 File Offset: 0x00A2EE14
		public GE_Element_Gain_Wind_C() : this(BuiltinUtils.AllocNativeUObject(GE_Element_Gain_Wind_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D15E RID: 184670 RVA: 0x00A30C3C File Offset: 0x00A2EE3C
		[NullableContext(1)]
		public GE_Element_Gain_Wind_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Element_Gain_Wind_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D15F RID: 184671 RVA: 0x00A30C6F File Offset: 0x00A2EE6F
		protected GE_Element_Gain_Wind_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EFC RID: 98044
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Wind.GE_Element_Gain_Wind_C";

		// Token: 0x04017EFD RID: 98045
		private static IntPtr _ClassPtr;

		// Token: 0x04017EFE RID: 98046
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
