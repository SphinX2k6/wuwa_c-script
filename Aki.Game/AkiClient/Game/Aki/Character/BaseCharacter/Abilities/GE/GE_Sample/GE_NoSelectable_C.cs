using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Sample
{
	// Token: 0x020043F4 RID: 17396
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_NoSelectable.GE_NoSelectable_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_NoSelectable_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0CA RID: 184522 RVA: 0x00A2F778 File Offset: 0x00A2D978
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_NoSelectable_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_NoSelectable.GE_NoSelectable_C");
			}
			return GE_NoSelectable_C._ClassPtr;
		}

		// Token: 0x0602D0CB RID: 184523 RVA: 0x00A2F79C File Offset: 0x00A2D99C
		public GE_NoSelectable_C() : this(BuiltinUtils.AllocNativeUObject(GE_NoSelectable_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0CC RID: 184524 RVA: 0x00A2F7C4 File Offset: 0x00A2D9C4
		[NullableContext(1)]
		public GE_NoSelectable_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_NoSelectable_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0CD RID: 184525 RVA: 0x00A2F7F7 File Offset: 0x00A2D9F7
		protected GE_NoSelectable_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E8F RID: 97935
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_NoSelectable.GE_NoSelectable_C";

		// Token: 0x04017E90 RID: 97936
		private static IntPtr _ClassPtr;

		// Token: 0x04017E91 RID: 97937
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
