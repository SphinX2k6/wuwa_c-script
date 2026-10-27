using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Stamina
{
	// Token: 0x02004407 RID: 17415
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_StaminaPunish.GE_Common_StaminaPunish_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Common_StaminaPunish_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D118 RID: 184600 RVA: 0x00A302E8 File Offset: 0x00A2E4E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Common_StaminaPunish_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_StaminaPunish.GE_Common_StaminaPunish_C");
			}
			return GE_Common_StaminaPunish_C._ClassPtr;
		}

		// Token: 0x0602D119 RID: 184601 RVA: 0x00A3030C File Offset: 0x00A2E50C
		public GE_Common_StaminaPunish_C() : this(BuiltinUtils.AllocNativeUObject(GE_Common_StaminaPunish_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D11A RID: 184602 RVA: 0x00A30334 File Offset: 0x00A2E534
		[NullableContext(1)]
		public GE_Common_StaminaPunish_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Common_StaminaPunish_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D11B RID: 184603 RVA: 0x00A30367 File Offset: 0x00A2E567
		protected GE_Common_StaminaPunish_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EC9 RID: 97993
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_StaminaPunish.GE_Common_StaminaPunish_C";

		// Token: 0x04017ECA RID: 97994
		private static IntPtr _ClassPtr;

		// Token: 0x04017ECB RID: 97995
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
