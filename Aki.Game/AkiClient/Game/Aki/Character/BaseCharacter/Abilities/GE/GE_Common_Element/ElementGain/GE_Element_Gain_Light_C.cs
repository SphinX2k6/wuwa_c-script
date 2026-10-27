using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Element.ElementGain
{
	// Token: 0x02004416 RID: 17430
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Light.GE_Element_Gain_Light_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Element_Gain_Light_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D154 RID: 184660 RVA: 0x00A30AE0 File Offset: 0x00A2ECE0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Element_Gain_Light_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Light.GE_Element_Gain_Light_C");
			}
			return GE_Element_Gain_Light_C._ClassPtr;
		}

		// Token: 0x0602D155 RID: 184661 RVA: 0x00A30B04 File Offset: 0x00A2ED04
		public GE_Element_Gain_Light_C() : this(BuiltinUtils.AllocNativeUObject(GE_Element_Gain_Light_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D156 RID: 184662 RVA: 0x00A30B2C File Offset: 0x00A2ED2C
		[NullableContext(1)]
		public GE_Element_Gain_Light_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Element_Gain_Light_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D157 RID: 184663 RVA: 0x00A30B5F File Offset: 0x00A2ED5F
		protected GE_Element_Gain_Light_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EF6 RID: 98038
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Light.GE_Element_Gain_Light_C";

		// Token: 0x04017EF7 RID: 98039
		private static IntPtr _ClassPtr;

		// Token: 0x04017EF8 RID: 98040
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
