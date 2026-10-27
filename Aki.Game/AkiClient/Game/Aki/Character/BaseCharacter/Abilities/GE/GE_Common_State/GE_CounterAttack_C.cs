using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_State
{
	// Token: 0x02004401 RID: 17409
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_State/GE_CounterAttack.GE_CounterAttack_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_CounterAttack_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D100 RID: 184576 RVA: 0x00A2FFB8 File Offset: 0x00A2E1B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_CounterAttack_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_State/GE_CounterAttack.GE_CounterAttack_C");
			}
			return GE_CounterAttack_C._ClassPtr;
		}

		// Token: 0x0602D101 RID: 184577 RVA: 0x00A2FFDC File Offset: 0x00A2E1DC
		public GE_CounterAttack_C() : this(BuiltinUtils.AllocNativeUObject(GE_CounterAttack_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D102 RID: 184578 RVA: 0x00A30004 File Offset: 0x00A2E204
		[NullableContext(1)]
		public GE_CounterAttack_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_CounterAttack_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D103 RID: 184579 RVA: 0x00A30037 File Offset: 0x00A2E237
		protected GE_CounterAttack_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EB7 RID: 97975
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_State/GE_CounterAttack.GE_CounterAttack_C";

		// Token: 0x04017EB8 RID: 97976
		private static IntPtr _ClassPtr;

		// Token: 0x04017EB9 RID: 97977
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
