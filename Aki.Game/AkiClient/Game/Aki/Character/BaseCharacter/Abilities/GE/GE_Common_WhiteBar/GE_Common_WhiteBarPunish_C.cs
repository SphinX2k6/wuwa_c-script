using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_WhiteBar
{
	// Token: 0x020043F8 RID: 17400
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_WhiteBar/GE_Common_WhiteBarPunish.GE_Common_WhiteBarPunish_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Common_WhiteBarPunish_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0DC RID: 184540 RVA: 0x00A2FAEF File Offset: 0x00A2DCEF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Common_WhiteBarPunish_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_WhiteBar/GE_Common_WhiteBarPunish.GE_Common_WhiteBarPunish_C");
			}
			return GE_Common_WhiteBarPunish_C._ClassPtr;
		}

		// Token: 0x0602D0DD RID: 184541 RVA: 0x00A2FB14 File Offset: 0x00A2DD14
		public GE_Common_WhiteBarPunish_C() : this(BuiltinUtils.AllocNativeUObject(GE_Common_WhiteBarPunish_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0DE RID: 184542 RVA: 0x00A2FB3C File Offset: 0x00A2DD3C
		[NullableContext(1)]
		public GE_Common_WhiteBarPunish_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Common_WhiteBarPunish_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0DF RID: 184543 RVA: 0x00A2FB6F File Offset: 0x00A2DD6F
		protected GE_Common_WhiteBarPunish_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E9C RID: 97948
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_WhiteBar/GE_Common_WhiteBarPunish.GE_Common_WhiteBarPunish_C";

		// Token: 0x04017E9D RID: 97949
		private static IntPtr _ClassPtr;

		// Token: 0x04017E9E RID: 97950
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
