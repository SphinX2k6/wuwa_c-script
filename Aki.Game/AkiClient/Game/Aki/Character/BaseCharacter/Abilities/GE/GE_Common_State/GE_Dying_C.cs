using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_State
{
	// Token: 0x02004402 RID: 17410
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_State/GE_Dying.GE_Dying_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Dying_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D104 RID: 184580 RVA: 0x00A30040 File Offset: 0x00A2E240
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Dying_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_State/GE_Dying.GE_Dying_C");
			}
			return GE_Dying_C._ClassPtr;
		}

		// Token: 0x0602D105 RID: 184581 RVA: 0x00A30064 File Offset: 0x00A2E264
		public GE_Dying_C() : this(BuiltinUtils.AllocNativeUObject(GE_Dying_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D106 RID: 184582 RVA: 0x00A3008C File Offset: 0x00A2E28C
		[NullableContext(1)]
		public GE_Dying_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Dying_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D107 RID: 184583 RVA: 0x00A300BF File Offset: 0x00A2E2BF
		protected GE_Dying_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EBA RID: 97978
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_State/GE_Dying.GE_Dying_C";

		// Token: 0x04017EBB RID: 97979
		private static IntPtr _ClassPtr;

		// Token: 0x04017EBC RID: 97980
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
