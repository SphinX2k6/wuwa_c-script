using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200339C RID: 13212
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckGroupPatrol.BP_SM_ConditionCheckGroupPatrol_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ConditionCheckGroupPatrol_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021858 RID: 137304 RVA: 0x00962DD0 File Offset: 0x00960FD0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckGroupPatrol_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckGroupPatrol.BP_SM_ConditionCheckGroupPatrol_C");
			}
			return BP_SM_ConditionCheckGroupPatrol_C._ClassPtr;
		}

		// Token: 0x06021859 RID: 137305 RVA: 0x00962DF4 File Offset: 0x00960FF4
		public BP_SM_ConditionCheckGroupPatrol_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckGroupPatrol_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602185A RID: 137306 RVA: 0x00962E1C File Offset: 0x0096101C
		[NullableContext(1)]
		public BP_SM_ConditionCheckGroupPatrol_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckGroupPatrol_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602185B RID: 137307 RVA: 0x00962E4F File Offset: 0x0096104F
		protected BP_SM_ConditionCheckGroupPatrol_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012544 RID: 75076
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckGroupPatrol.BP_SM_ConditionCheckGroupPatrol_C";

		// Token: 0x04012545 RID: 75077
		private static IntPtr _ClassPtr;

		// Token: 0x04012546 RID: 75078
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
