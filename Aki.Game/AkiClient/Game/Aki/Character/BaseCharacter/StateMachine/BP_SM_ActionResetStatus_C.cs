using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004362 RID: 17250
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionResetStatus.BP_SM_ActionResetStatus_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_ActionResetStatus_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB74 RID: 183156 RVA: 0x00A26A63 File Offset: 0x00A24C63
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionResetStatus_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionResetStatus.BP_SM_ActionResetStatus_C");
			}
			return BP_SM_ActionResetStatus_C._ClassPtr;
		}

		// Token: 0x0602CB75 RID: 183157 RVA: 0x00A26A88 File Offset: 0x00A24C88
		public BP_SM_ActionResetStatus_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionResetStatus_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB76 RID: 183158 RVA: 0x00A26AB0 File Offset: 0x00A24CB0
		[NullableContext(1)]
		public BP_SM_ActionResetStatus_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionResetStatus_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CB77 RID: 183159 RVA: 0x00A26AE3 File Offset: 0x00A24CE3
		protected BP_SM_ActionResetStatus_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017942 RID: 96578
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionResetStatus.BP_SM_ActionResetStatus_C";

		// Token: 0x04017943 RID: 96579
		private static IntPtr _ClassPtr;

		// Token: 0x04017944 RID: 96580
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
