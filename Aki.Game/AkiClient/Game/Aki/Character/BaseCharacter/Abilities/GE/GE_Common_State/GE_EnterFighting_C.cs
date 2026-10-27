using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_State
{
	// Token: 0x02004403 RID: 17411
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_State/GE_EnterFighting.GE_EnterFighting_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_EnterFighting_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D108 RID: 184584 RVA: 0x00A300C8 File Offset: 0x00A2E2C8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_EnterFighting_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_State/GE_EnterFighting.GE_EnterFighting_C");
			}
			return GE_EnterFighting_C._ClassPtr;
		}

		// Token: 0x0602D109 RID: 184585 RVA: 0x00A300EC File Offset: 0x00A2E2EC
		public GE_EnterFighting_C() : this(BuiltinUtils.AllocNativeUObject(GE_EnterFighting_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D10A RID: 184586 RVA: 0x00A30114 File Offset: 0x00A2E314
		[NullableContext(1)]
		public GE_EnterFighting_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_EnterFighting_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D10B RID: 184587 RVA: 0x00A30147 File Offset: 0x00A2E347
		protected GE_EnterFighting_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EBD RID: 97981
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_State/GE_EnterFighting.GE_EnterFighting_C";

		// Token: 0x04017EBE RID: 97982
		private static IntPtr _ClassPtr;

		// Token: 0x04017EBF RID: 97983
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
