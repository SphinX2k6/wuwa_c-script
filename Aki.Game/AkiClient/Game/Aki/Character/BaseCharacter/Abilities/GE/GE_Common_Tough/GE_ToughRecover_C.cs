using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Tough
{
	// Token: 0x020043FC RID: 17404
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Tough/GE_ToughRecover.GE_ToughRecover_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_ToughRecover_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0EC RID: 184556 RVA: 0x00A2FD10 File Offset: 0x00A2DF10
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_ToughRecover_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Tough/GE_ToughRecover.GE_ToughRecover_C");
			}
			return GE_ToughRecover_C._ClassPtr;
		}

		// Token: 0x0602D0ED RID: 184557 RVA: 0x00A2FD34 File Offset: 0x00A2DF34
		public GE_ToughRecover_C() : this(BuiltinUtils.AllocNativeUObject(GE_ToughRecover_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0EE RID: 184558 RVA: 0x00A2FD5C File Offset: 0x00A2DF5C
		[NullableContext(1)]
		public GE_ToughRecover_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_ToughRecover_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0EF RID: 184559 RVA: 0x00A2FD8F File Offset: 0x00A2DF8F
		protected GE_ToughRecover_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EA8 RID: 97960
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Tough/GE_ToughRecover.GE_ToughRecover_C";

		// Token: 0x04017EA9 RID: 97961
		private static IntPtr _ClassPtr;

		// Token: 0x04017EAA RID: 97962
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
