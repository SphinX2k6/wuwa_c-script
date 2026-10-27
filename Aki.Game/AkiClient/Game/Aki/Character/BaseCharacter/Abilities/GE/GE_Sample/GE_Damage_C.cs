using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Sample
{
	// Token: 0x020043EF RID: 17391
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_Damage.GE_Damage_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Damage_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0B6 RID: 184502 RVA: 0x00A2F4D0 File Offset: 0x00A2D6D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Damage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_Damage.GE_Damage_C");
			}
			return GE_Damage_C._ClassPtr;
		}

		// Token: 0x0602D0B7 RID: 184503 RVA: 0x00A2F4F4 File Offset: 0x00A2D6F4
		public GE_Damage_C() : this(BuiltinUtils.AllocNativeUObject(GE_Damage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0B8 RID: 184504 RVA: 0x00A2F51C File Offset: 0x00A2D71C
		[NullableContext(1)]
		public GE_Damage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Damage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0B9 RID: 184505 RVA: 0x00A2F54F File Offset: 0x00A2D74F
		protected GE_Damage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E80 RID: 97920
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_Damage.GE_Damage_C";

		// Token: 0x04017E81 RID: 97921
		private static IntPtr _ClassPtr;

		// Token: 0x04017E82 RID: 97922
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
