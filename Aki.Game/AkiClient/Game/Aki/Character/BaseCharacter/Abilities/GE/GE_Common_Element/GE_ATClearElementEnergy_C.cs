using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Element
{
	// Token: 0x02004410 RID: 17424
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/GE_ATClearElementEnergy.GE_ATClearElementEnergy_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_ATClearElementEnergy_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D13C RID: 184636 RVA: 0x00A307B0 File Offset: 0x00A2E9B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_ATClearElementEnergy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/GE_ATClearElementEnergy.GE_ATClearElementEnergy_C");
			}
			return GE_ATClearElementEnergy_C._ClassPtr;
		}

		// Token: 0x0602D13D RID: 184637 RVA: 0x00A307D4 File Offset: 0x00A2E9D4
		public GE_ATClearElementEnergy_C() : this(BuiltinUtils.AllocNativeUObject(GE_ATClearElementEnergy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D13E RID: 184638 RVA: 0x00A307FC File Offset: 0x00A2E9FC
		[NullableContext(1)]
		public GE_ATClearElementEnergy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_ATClearElementEnergy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D13F RID: 184639 RVA: 0x00A3082F File Offset: 0x00A2EA2F
		protected GE_ATClearElementEnergy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EE4 RID: 98020
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/GE_ATClearElementEnergy.GE_ATClearElementEnergy_C";

		// Token: 0x04017EE5 RID: 98021
		private static IntPtr _ClassPtr;

		// Token: 0x04017EE6 RID: 98022
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
