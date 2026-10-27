using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Stamina
{
	// Token: 0x02004409 RID: 17417
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_Stamina_Cost_ClimbDash.GE_Common_Stamina_Cost_ClimbDash_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Common_Stamina_Cost_ClimbDash_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D120 RID: 184608 RVA: 0x00A303F8 File Offset: 0x00A2E5F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Common_Stamina_Cost_ClimbDash_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_Stamina_Cost_ClimbDash.GE_Common_Stamina_Cost_ClimbDash_C");
			}
			return GE_Common_Stamina_Cost_ClimbDash_C._ClassPtr;
		}

		// Token: 0x0602D121 RID: 184609 RVA: 0x00A3041C File Offset: 0x00A2E61C
		public GE_Common_Stamina_Cost_ClimbDash_C() : this(BuiltinUtils.AllocNativeUObject(GE_Common_Stamina_Cost_ClimbDash_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D122 RID: 184610 RVA: 0x00A30444 File Offset: 0x00A2E644
		[NullableContext(1)]
		public GE_Common_Stamina_Cost_ClimbDash_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Common_Stamina_Cost_ClimbDash_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D123 RID: 184611 RVA: 0x00A30477 File Offset: 0x00A2E677
		protected GE_Common_Stamina_Cost_ClimbDash_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017ECF RID: 97999
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_Stamina_Cost_ClimbDash.GE_Common_Stamina_Cost_ClimbDash_C";

		// Token: 0x04017ED0 RID: 98000
		private static IntPtr _ClassPtr;

		// Token: 0x04017ED1 RID: 98001
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
