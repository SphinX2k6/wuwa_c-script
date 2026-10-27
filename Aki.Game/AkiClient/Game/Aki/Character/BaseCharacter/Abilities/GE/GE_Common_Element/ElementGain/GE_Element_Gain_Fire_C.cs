using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Element.ElementGain
{
	// Token: 0x02004414 RID: 17428
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Fire.GE_Element_Gain_Fire_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Element_Gain_Fire_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D14C RID: 184652 RVA: 0x00A309D0 File Offset: 0x00A2EBD0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Element_Gain_Fire_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Fire.GE_Element_Gain_Fire_C");
			}
			return GE_Element_Gain_Fire_C._ClassPtr;
		}

		// Token: 0x0602D14D RID: 184653 RVA: 0x00A309F4 File Offset: 0x00A2EBF4
		public GE_Element_Gain_Fire_C() : this(BuiltinUtils.AllocNativeUObject(GE_Element_Gain_Fire_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D14E RID: 184654 RVA: 0x00A30A1C File Offset: 0x00A2EC1C
		[NullableContext(1)]
		public GE_Element_Gain_Fire_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Element_Gain_Fire_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D14F RID: 184655 RVA: 0x00A30A4F File Offset: 0x00A2EC4F
		protected GE_Element_Gain_Fire_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EF0 RID: 98032
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Fire.GE_Element_Gain_Fire_C";

		// Token: 0x04017EF1 RID: 98033
		private static IntPtr _ClassPtr;

		// Token: 0x04017EF2 RID: 98034
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
