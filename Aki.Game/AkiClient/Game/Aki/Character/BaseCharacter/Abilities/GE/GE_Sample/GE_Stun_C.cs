using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Sample
{
	// Token: 0x020043F5 RID: 17397
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_Stun.GE_Stun_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Stun_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0CE RID: 184526 RVA: 0x00A2F800 File Offset: 0x00A2DA00
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Stun_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_Stun.GE_Stun_C");
			}
			return GE_Stun_C._ClassPtr;
		}

		// Token: 0x0602D0CF RID: 184527 RVA: 0x00A2F824 File Offset: 0x00A2DA24
		public GE_Stun_C() : this(BuiltinUtils.AllocNativeUObject(GE_Stun_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0D0 RID: 184528 RVA: 0x00A2F84C File Offset: 0x00A2DA4C
		[NullableContext(1)]
		public GE_Stun_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Stun_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0D1 RID: 184529 RVA: 0x00A2F87F File Offset: 0x00A2DA7F
		protected GE_Stun_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E92 RID: 97938
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_Stun.GE_Stun_C";

		// Token: 0x04017E93 RID: 97939
		private static IntPtr _ClassPtr;

		// Token: 0x04017E94 RID: 97940
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
