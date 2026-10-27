using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Element.ElementGain
{
	// Token: 0x02004415 RID: 17429
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Ice.GE_Element_Gain_Ice_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Element_Gain_Ice_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D150 RID: 184656 RVA: 0x00A30A58 File Offset: 0x00A2EC58
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Element_Gain_Ice_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Ice.GE_Element_Gain_Ice_C");
			}
			return GE_Element_Gain_Ice_C._ClassPtr;
		}

		// Token: 0x0602D151 RID: 184657 RVA: 0x00A30A7C File Offset: 0x00A2EC7C
		public GE_Element_Gain_Ice_C() : this(BuiltinUtils.AllocNativeUObject(GE_Element_Gain_Ice_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D152 RID: 184658 RVA: 0x00A30AA4 File Offset: 0x00A2ECA4
		[NullableContext(1)]
		public GE_Element_Gain_Ice_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Element_Gain_Ice_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D153 RID: 184659 RVA: 0x00A30AD7 File Offset: 0x00A2ECD7
		protected GE_Element_Gain_Ice_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EF3 RID: 98035
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/ElementGain/GE_Element_Gain_Ice.GE_Element_Gain_Ice_C";

		// Token: 0x04017EF4 RID: 98036
		private static IntPtr _ClassPtr;

		// Token: 0x04017EF5 RID: 98037
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
