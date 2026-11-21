using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200337F RID: 13183
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionExitHit.BP_SM_ActionExitHit_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_ActionExitHit_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021776 RID: 137078 RVA: 0x009615BC File Offset: 0x0095F7BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionExitHit_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionExitHit.BP_SM_ActionExitHit_C");
			}
			return BP_SM_ActionExitHit_C._ClassPtr;
		}

		// Token: 0x06021777 RID: 137079 RVA: 0x009615E0 File Offset: 0x0095F7E0
		public BP_SM_ActionExitHit_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionExitHit_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021778 RID: 137080 RVA: 0x00961608 File Offset: 0x0095F808
		[NullableContext(1)]
		public BP_SM_ActionExitHit_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionExitHit_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021779 RID: 137081 RVA: 0x0096163B File Offset: 0x0095F83B
		protected BP_SM_ActionExitHit_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124B1 RID: 74929
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionExitHit.BP_SM_ActionExitHit_C";

		// Token: 0x040124B2 RID: 74930
		private static IntPtr _ClassPtr;

		// Token: 0x040124B3 RID: 74931
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
