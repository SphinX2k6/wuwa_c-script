using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003383 RID: 13187
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionResetStatus.BP_SM_ActionResetStatus_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_ActionResetStatus_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021792 RID: 137106 RVA: 0x009618B7 File Offset: 0x0095FAB7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionResetStatus_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionResetStatus.BP_SM_ActionResetStatus_C");
			}
			return BP_SM_ActionResetStatus_C._ClassPtr;
		}

		// Token: 0x06021793 RID: 137107 RVA: 0x009618DC File Offset: 0x0095FADC
		public BP_SM_ActionResetStatus_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionResetStatus_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021794 RID: 137108 RVA: 0x00961904 File Offset: 0x0095FB04
		[NullableContext(1)]
		public BP_SM_ActionResetStatus_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionResetStatus_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021795 RID: 137109 RVA: 0x00961937 File Offset: 0x0095FB37
		protected BP_SM_ActionResetStatus_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124C3 RID: 74947
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionResetStatus.BP_SM_ActionResetStatus_C";

		// Token: 0x040124C4 RID: 74948
		private static IntPtr _ClassPtr;

		// Token: 0x040124C5 RID: 74949
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
