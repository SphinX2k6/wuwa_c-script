using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Sample
{
	// Token: 0x020043F6 RID: 17398
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_SummonBullet.GE_SummonBullet_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_SummonBullet_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0D2 RID: 184530 RVA: 0x00A2F888 File Offset: 0x00A2DA88
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_SummonBullet_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_SummonBullet.GE_SummonBullet_C");
			}
			return GE_SummonBullet_C._ClassPtr;
		}

		// Token: 0x0602D0D3 RID: 184531 RVA: 0x00A2F8AC File Offset: 0x00A2DAAC
		public GE_SummonBullet_C() : this(BuiltinUtils.AllocNativeUObject(GE_SummonBullet_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0D4 RID: 184532 RVA: 0x00A2F8D4 File Offset: 0x00A2DAD4
		[NullableContext(1)]
		public GE_SummonBullet_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_SummonBullet_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0D5 RID: 184533 RVA: 0x00A2F907 File Offset: 0x00A2DB07
		protected GE_SummonBullet_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E95 RID: 97941
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_SummonBullet.GE_SummonBullet_C";

		// Token: 0x04017E96 RID: 97942
		private static IntPtr _ClassPtr;

		// Token: 0x04017E97 RID: 97943
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
