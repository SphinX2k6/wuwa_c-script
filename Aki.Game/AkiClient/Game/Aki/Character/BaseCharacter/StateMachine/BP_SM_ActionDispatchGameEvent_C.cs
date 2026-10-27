using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200435C RID: 17244
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionDispatchGameEvent.BP_SM_ActionDispatchGameEvent_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_ActionDispatchGameEvent_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB50 RID: 183120 RVA: 0x00A26655 File Offset: 0x00A24855
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionDispatchGameEvent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionDispatchGameEvent.BP_SM_ActionDispatchGameEvent_C");
			}
			return BP_SM_ActionDispatchGameEvent_C._ClassPtr;
		}

		// Token: 0x0602CB51 RID: 183121 RVA: 0x00A2667C File Offset: 0x00A2487C
		public BP_SM_ActionDispatchGameEvent_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionDispatchGameEvent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB52 RID: 183122 RVA: 0x00A266A4 File Offset: 0x00A248A4
		[NullableContext(1)]
		public BP_SM_ActionDispatchGameEvent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionDispatchGameEvent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CB53 RID: 183123 RVA: 0x00A266D7 File Offset: 0x00A248D7
		protected BP_SM_ActionDispatchGameEvent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401792A RID: 96554
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionDispatchGameEvent.BP_SM_ActionDispatchGameEvent_C";

		// Token: 0x0401792B RID: 96555
		private static IntPtr _ClassPtr;

		// Token: 0x0401792C RID: 96556
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
