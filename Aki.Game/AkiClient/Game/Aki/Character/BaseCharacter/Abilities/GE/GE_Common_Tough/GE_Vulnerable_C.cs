using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Tough
{
	// Token: 0x020043FF RID: 17407
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Tough/GE_Vulnerable.GE_Vulnerable_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Vulnerable_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0F8 RID: 184568 RVA: 0x00A2FEA8 File Offset: 0x00A2E0A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Vulnerable_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Tough/GE_Vulnerable.GE_Vulnerable_C");
			}
			return GE_Vulnerable_C._ClassPtr;
		}

		// Token: 0x0602D0F9 RID: 184569 RVA: 0x00A2FECC File Offset: 0x00A2E0CC
		public GE_Vulnerable_C() : this(BuiltinUtils.AllocNativeUObject(GE_Vulnerable_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0FA RID: 184570 RVA: 0x00A2FEF4 File Offset: 0x00A2E0F4
		[NullableContext(1)]
		public GE_Vulnerable_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Vulnerable_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0FB RID: 184571 RVA: 0x00A2FF27 File Offset: 0x00A2E127
		protected GE_Vulnerable_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EB1 RID: 97969
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Tough/GE_Vulnerable.GE_Vulnerable_C";

		// Token: 0x04017EB2 RID: 97970
		private static IntPtr _ClassPtr;

		// Token: 0x04017EB3 RID: 97971
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
