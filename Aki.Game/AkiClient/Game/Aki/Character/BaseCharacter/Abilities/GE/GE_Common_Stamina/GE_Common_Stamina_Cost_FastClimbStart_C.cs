using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Stamina
{
	// Token: 0x0200440B RID: 17419
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_Stamina_Cost_FastClimbStart.GE_Common_Stamina_Cost_FastClimbStart_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Common_Stamina_Cost_FastClimbStart_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D128 RID: 184616 RVA: 0x00A30508 File Offset: 0x00A2E708
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Common_Stamina_Cost_FastClimbStart_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_Stamina_Cost_FastClimbStart.GE_Common_Stamina_Cost_FastClimbStart_C");
			}
			return GE_Common_Stamina_Cost_FastClimbStart_C._ClassPtr;
		}

		// Token: 0x0602D129 RID: 184617 RVA: 0x00A3052C File Offset: 0x00A2E72C
		public GE_Common_Stamina_Cost_FastClimbStart_C() : this(BuiltinUtils.AllocNativeUObject(GE_Common_Stamina_Cost_FastClimbStart_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D12A RID: 184618 RVA: 0x00A30554 File Offset: 0x00A2E754
		[NullableContext(1)]
		public GE_Common_Stamina_Cost_FastClimbStart_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Common_Stamina_Cost_FastClimbStart_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D12B RID: 184619 RVA: 0x00A30587 File Offset: 0x00A2E787
		protected GE_Common_Stamina_Cost_FastClimbStart_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017ED5 RID: 98005
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_Stamina_Cost_FastClimbStart.GE_Common_Stamina_Cost_FastClimbStart_C";

		// Token: 0x04017ED6 RID: 98006
		private static IntPtr _ClassPtr;

		// Token: 0x04017ED7 RID: 98007
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
