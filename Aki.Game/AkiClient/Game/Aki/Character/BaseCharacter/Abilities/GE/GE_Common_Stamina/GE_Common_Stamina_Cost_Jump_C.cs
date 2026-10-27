using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Stamina
{
	// Token: 0x0200440C RID: 17420
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_Stamina_Cost_Jump.GE_Common_Stamina_Cost_Jump_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Common_Stamina_Cost_Jump_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D12C RID: 184620 RVA: 0x00A30590 File Offset: 0x00A2E790
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Common_Stamina_Cost_Jump_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_Stamina_Cost_Jump.GE_Common_Stamina_Cost_Jump_C");
			}
			return GE_Common_Stamina_Cost_Jump_C._ClassPtr;
		}

		// Token: 0x0602D12D RID: 184621 RVA: 0x00A305B4 File Offset: 0x00A2E7B4
		public GE_Common_Stamina_Cost_Jump_C() : this(BuiltinUtils.AllocNativeUObject(GE_Common_Stamina_Cost_Jump_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D12E RID: 184622 RVA: 0x00A305DC File Offset: 0x00A2E7DC
		[NullableContext(1)]
		public GE_Common_Stamina_Cost_Jump_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Common_Stamina_Cost_Jump_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D12F RID: 184623 RVA: 0x00A3060F File Offset: 0x00A2E80F
		protected GE_Common_Stamina_Cost_Jump_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017ED8 RID: 98008
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_Stamina_Cost_Jump.GE_Common_Stamina_Cost_Jump_C";

		// Token: 0x04017ED9 RID: 98009
		private static IntPtr _ClassPtr;

		// Token: 0x04017EDA RID: 98010
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
