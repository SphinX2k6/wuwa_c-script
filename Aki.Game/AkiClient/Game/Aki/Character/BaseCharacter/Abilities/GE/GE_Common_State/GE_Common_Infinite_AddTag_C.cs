using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_State
{
	// Token: 0x02004400 RID: 17408
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_State/GE_Common_Infinite_AddTag.GE_Common_Infinite_AddTag_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Common_Infinite_AddTag_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0FC RID: 184572 RVA: 0x00A2FF30 File Offset: 0x00A2E130
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Common_Infinite_AddTag_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_State/GE_Common_Infinite_AddTag.GE_Common_Infinite_AddTag_C");
			}
			return GE_Common_Infinite_AddTag_C._ClassPtr;
		}

		// Token: 0x0602D0FD RID: 184573 RVA: 0x00A2FF54 File Offset: 0x00A2E154
		public GE_Common_Infinite_AddTag_C() : this(BuiltinUtils.AllocNativeUObject(GE_Common_Infinite_AddTag_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0FE RID: 184574 RVA: 0x00A2FF7C File Offset: 0x00A2E17C
		[NullableContext(1)]
		public GE_Common_Infinite_AddTag_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Common_Infinite_AddTag_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0FF RID: 184575 RVA: 0x00A2FFAF File Offset: 0x00A2E1AF
		protected GE_Common_Infinite_AddTag_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EB4 RID: 97972
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_State/GE_Common_Infinite_AddTag.GE_Common_Infinite_AddTag_C";

		// Token: 0x04017EB5 RID: 97973
		private static IntPtr _ClassPtr;

		// Token: 0x04017EB6 RID: 97974
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
