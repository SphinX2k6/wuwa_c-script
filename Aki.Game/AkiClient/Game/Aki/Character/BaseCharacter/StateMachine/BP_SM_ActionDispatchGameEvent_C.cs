using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200337D RID: 13181
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionDispatchGameEvent.BP_SM_ActionDispatchGameEvent_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_ActionDispatchGameEvent_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602176E RID: 137070 RVA: 0x009614A9 File Offset: 0x0095F6A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionDispatchGameEvent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionDispatchGameEvent.BP_SM_ActionDispatchGameEvent_C");
			}
			return BP_SM_ActionDispatchGameEvent_C._ClassPtr;
		}

		// Token: 0x0602176F RID: 137071 RVA: 0x009614D0 File Offset: 0x0095F6D0
		public BP_SM_ActionDispatchGameEvent_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionDispatchGameEvent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021770 RID: 137072 RVA: 0x009614F8 File Offset: 0x0095F6F8
		[NullableContext(1)]
		public BP_SM_ActionDispatchGameEvent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionDispatchGameEvent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021771 RID: 137073 RVA: 0x0096152B File Offset: 0x0095F72B
		protected BP_SM_ActionDispatchGameEvent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124AB RID: 74923
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionDispatchGameEvent.BP_SM_ActionDispatchGameEvent_C";

		// Token: 0x040124AC RID: 74924
		private static IntPtr _ClassPtr;

		// Token: 0x040124AD RID: 74925
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
