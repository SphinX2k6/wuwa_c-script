using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_AttributeModifier
{
	// Token: 0x02004424 RID: 17444
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_EnergyModifier.GE_EnergyModifier_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_EnergyModifier_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D18C RID: 184716 RVA: 0x00A31250 File Offset: 0x00A2F450
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_EnergyModifier_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_EnergyModifier.GE_EnergyModifier_C");
			}
			return GE_EnergyModifier_C._ClassPtr;
		}

		// Token: 0x0602D18D RID: 184717 RVA: 0x00A31274 File Offset: 0x00A2F474
		public GE_EnergyModifier_C() : this(BuiltinUtils.AllocNativeUObject(GE_EnergyModifier_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D18E RID: 184718 RVA: 0x00A3129C File Offset: 0x00A2F49C
		[NullableContext(1)]
		public GE_EnergyModifier_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_EnergyModifier_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D18F RID: 184719 RVA: 0x00A312CF File Offset: 0x00A2F4CF
		protected GE_EnergyModifier_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F20 RID: 98080
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_EnergyModifier.GE_EnergyModifier_C";

		// Token: 0x04017F21 RID: 98081
		private static IntPtr _ClassPtr;

		// Token: 0x04017F22 RID: 98082
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
