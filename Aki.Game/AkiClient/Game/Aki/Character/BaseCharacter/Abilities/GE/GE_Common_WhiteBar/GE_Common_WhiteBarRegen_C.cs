using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_WhiteBar
{
	// Token: 0x020043F9 RID: 17401
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_WhiteBar/GE_Common_WhiteBarRegen.GE_Common_WhiteBarRegen_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Common_WhiteBarRegen_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0E0 RID: 184544 RVA: 0x00A2FB78 File Offset: 0x00A2DD78
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Common_WhiteBarRegen_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_WhiteBar/GE_Common_WhiteBarRegen.GE_Common_WhiteBarRegen_C");
			}
			return GE_Common_WhiteBarRegen_C._ClassPtr;
		}

		// Token: 0x0602D0E1 RID: 184545 RVA: 0x00A2FB9C File Offset: 0x00A2DD9C
		public GE_Common_WhiteBarRegen_C() : this(BuiltinUtils.AllocNativeUObject(GE_Common_WhiteBarRegen_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0E2 RID: 184546 RVA: 0x00A2FBC4 File Offset: 0x00A2DDC4
		[NullableContext(1)]
		public GE_Common_WhiteBarRegen_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Common_WhiteBarRegen_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0E3 RID: 184547 RVA: 0x00A2FBF7 File Offset: 0x00A2DDF7
		protected GE_Common_WhiteBarRegen_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E9F RID: 97951
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_WhiteBar/GE_Common_WhiteBarRegen.GE_Common_WhiteBarRegen_C";

		// Token: 0x04017EA0 RID: 97952
		private static IntPtr _ClassPtr;

		// Token: 0x04017EA1 RID: 97953
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
