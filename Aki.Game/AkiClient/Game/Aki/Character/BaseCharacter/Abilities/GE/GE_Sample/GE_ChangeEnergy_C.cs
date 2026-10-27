using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Sample
{
	// Token: 0x020043EE RID: 17390
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_ChangeEnergy.GE_ChangeEnergy_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_ChangeEnergy_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0B2 RID: 184498 RVA: 0x00A2F448 File Offset: 0x00A2D648
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_ChangeEnergy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_ChangeEnergy.GE_ChangeEnergy_C");
			}
			return GE_ChangeEnergy_C._ClassPtr;
		}

		// Token: 0x0602D0B3 RID: 184499 RVA: 0x00A2F46C File Offset: 0x00A2D66C
		public GE_ChangeEnergy_C() : this(BuiltinUtils.AllocNativeUObject(GE_ChangeEnergy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0B4 RID: 184500 RVA: 0x00A2F494 File Offset: 0x00A2D694
		[NullableContext(1)]
		public GE_ChangeEnergy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_ChangeEnergy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0B5 RID: 184501 RVA: 0x00A2F4C7 File Offset: 0x00A2D6C7
		protected GE_ChangeEnergy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E7D RID: 97917
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_ChangeEnergy.GE_ChangeEnergy_C";

		// Token: 0x04017E7E RID: 97918
		private static IntPtr _ClassPtr;

		// Token: 0x04017E7F RID: 97919
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
