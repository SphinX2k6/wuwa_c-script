using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Element
{
	// Token: 0x02004412 RID: 17426
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/GE_SetElementEnergy.GE_SetElementEnergy_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_SetElementEnergy_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D144 RID: 184644 RVA: 0x00A308C0 File Offset: 0x00A2EAC0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_SetElementEnergy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/GE_SetElementEnergy.GE_SetElementEnergy_C");
			}
			return GE_SetElementEnergy_C._ClassPtr;
		}

		// Token: 0x0602D145 RID: 184645 RVA: 0x00A308E4 File Offset: 0x00A2EAE4
		public GE_SetElementEnergy_C() : this(BuiltinUtils.AllocNativeUObject(GE_SetElementEnergy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D146 RID: 184646 RVA: 0x00A3090C File Offset: 0x00A2EB0C
		[NullableContext(1)]
		public GE_SetElementEnergy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_SetElementEnergy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D147 RID: 184647 RVA: 0x00A3093F File Offset: 0x00A2EB3F
		protected GE_SetElementEnergy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EEA RID: 98026
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/GE_SetElementEnergy.GE_SetElementEnergy_C";

		// Token: 0x04017EEB RID: 98027
		private static IntPtr _ClassPtr;

		// Token: 0x04017EEC RID: 98028
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
