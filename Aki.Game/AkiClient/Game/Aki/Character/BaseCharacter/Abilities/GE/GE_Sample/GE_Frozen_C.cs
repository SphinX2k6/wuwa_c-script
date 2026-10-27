using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Sample
{
	// Token: 0x020043F1 RID: 17393
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_Frozen.GE_Frozen_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Frozen_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0BE RID: 184510 RVA: 0x00A2F5E0 File Offset: 0x00A2D7E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Frozen_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_Frozen.GE_Frozen_C");
			}
			return GE_Frozen_C._ClassPtr;
		}

		// Token: 0x0602D0BF RID: 184511 RVA: 0x00A2F604 File Offset: 0x00A2D804
		public GE_Frozen_C() : this(BuiltinUtils.AllocNativeUObject(GE_Frozen_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0C0 RID: 184512 RVA: 0x00A2F62C File Offset: 0x00A2D82C
		[NullableContext(1)]
		public GE_Frozen_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Frozen_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0C1 RID: 184513 RVA: 0x00A2F65F File Offset: 0x00A2D85F
		protected GE_Frozen_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E86 RID: 97926
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_Frozen.GE_Frozen_C";

		// Token: 0x04017E87 RID: 97927
		private static IntPtr _ClassPtr;

		// Token: 0x04017E88 RID: 97928
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
