using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Element.ElementGain
{
	// Token: 0x02004413 RID: 17427
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Dark.GE_Element_Gain_Dark_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Element_Gain_Dark_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D148 RID: 184648 RVA: 0x00A30948 File Offset: 0x00A2EB48
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Element_Gain_Dark_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Dark.GE_Element_Gain_Dark_C");
			}
			return GE_Element_Gain_Dark_C._ClassPtr;
		}

		// Token: 0x0602D149 RID: 184649 RVA: 0x00A3096C File Offset: 0x00A2EB6C
		public GE_Element_Gain_Dark_C() : this(BuiltinUtils.AllocNativeUObject(GE_Element_Gain_Dark_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D14A RID: 184650 RVA: 0x00A30994 File Offset: 0x00A2EB94
		[NullableContext(1)]
		public GE_Element_Gain_Dark_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Element_Gain_Dark_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D14B RID: 184651 RVA: 0x00A309C7 File Offset: 0x00A2EBC7
		protected GE_Element_Gain_Dark_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EED RID: 98029
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Dark.GE_Element_Gain_Dark_C";

		// Token: 0x04017EEE RID: 98030
		private static IntPtr _ClassPtr;

		// Token: 0x04017EEF RID: 98031
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
