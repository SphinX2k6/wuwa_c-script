using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Sample
{
	// Token: 0x020043F0 RID: 17392
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_DogdeForbidden.GE_DogdeForbidden_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_DogdeForbidden_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0BA RID: 184506 RVA: 0x00A2F558 File Offset: 0x00A2D758
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_DogdeForbidden_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_DogdeForbidden.GE_DogdeForbidden_C");
			}
			return GE_DogdeForbidden_C._ClassPtr;
		}

		// Token: 0x0602D0BB RID: 184507 RVA: 0x00A2F57C File Offset: 0x00A2D77C
		public GE_DogdeForbidden_C() : this(BuiltinUtils.AllocNativeUObject(GE_DogdeForbidden_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0BC RID: 184508 RVA: 0x00A2F5A4 File Offset: 0x00A2D7A4
		[NullableContext(1)]
		public GE_DogdeForbidden_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_DogdeForbidden_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0BD RID: 184509 RVA: 0x00A2F5D7 File Offset: 0x00A2D7D7
		protected GE_DogdeForbidden_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E83 RID: 97923
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_DogdeForbidden.GE_DogdeForbidden_C";

		// Token: 0x04017E84 RID: 97924
		private static IntPtr _ClassPtr;

		// Token: 0x04017E85 RID: 97925
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
