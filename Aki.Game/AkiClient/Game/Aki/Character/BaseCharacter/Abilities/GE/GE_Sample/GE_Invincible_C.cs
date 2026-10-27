using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Sample
{
	// Token: 0x020043F3 RID: 17395
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_Invincible.GE_Invincible_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Invincible_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0C6 RID: 184518 RVA: 0x00A2F6F0 File Offset: 0x00A2D8F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Invincible_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_Invincible.GE_Invincible_C");
			}
			return GE_Invincible_C._ClassPtr;
		}

		// Token: 0x0602D0C7 RID: 184519 RVA: 0x00A2F714 File Offset: 0x00A2D914
		public GE_Invincible_C() : this(BuiltinUtils.AllocNativeUObject(GE_Invincible_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0C8 RID: 184520 RVA: 0x00A2F73C File Offset: 0x00A2D93C
		[NullableContext(1)]
		public GE_Invincible_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Invincible_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0C9 RID: 184521 RVA: 0x00A2F76F File Offset: 0x00A2D96F
		protected GE_Invincible_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E8C RID: 97932
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_Invincible.GE_Invincible_C";

		// Token: 0x04017E8D RID: 97933
		private static IntPtr _ClassPtr;

		// Token: 0x04017E8E RID: 97934
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
