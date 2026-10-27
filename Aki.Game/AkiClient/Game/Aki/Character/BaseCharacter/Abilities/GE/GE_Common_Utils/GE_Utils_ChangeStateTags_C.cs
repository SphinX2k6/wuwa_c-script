using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Utils
{
	// Token: 0x020043FA RID: 17402
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Utils/GE_Utils_ChangeStateTags.GE_Utils_ChangeStateTags_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Utils_ChangeStateTags_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0E4 RID: 184548 RVA: 0x00A2FC00 File Offset: 0x00A2DE00
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Utils_ChangeStateTags_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Utils/GE_Utils_ChangeStateTags.GE_Utils_ChangeStateTags_C");
			}
			return GE_Utils_ChangeStateTags_C._ClassPtr;
		}

		// Token: 0x0602D0E5 RID: 184549 RVA: 0x00A2FC24 File Offset: 0x00A2DE24
		public GE_Utils_ChangeStateTags_C() : this(BuiltinUtils.AllocNativeUObject(GE_Utils_ChangeStateTags_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0E6 RID: 184550 RVA: 0x00A2FC4C File Offset: 0x00A2DE4C
		[NullableContext(1)]
		public GE_Utils_ChangeStateTags_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Utils_ChangeStateTags_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0E7 RID: 184551 RVA: 0x00A2FC7F File Offset: 0x00A2DE7F
		protected GE_Utils_ChangeStateTags_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EA2 RID: 97954
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Utils/GE_Utils_ChangeStateTags.GE_Utils_ChangeStateTags_C";

		// Token: 0x04017EA3 RID: 97955
		private static IntPtr _ClassPtr;

		// Token: 0x04017EA4 RID: 97956
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
