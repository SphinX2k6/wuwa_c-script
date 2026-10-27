using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004351 RID: 17233
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionSkillEnd.BP_FSM_ConditionSkillEnd_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class BP_FSM_ConditionSkillEnd_C : UKuroStateMachineConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CAFC RID: 183036 RVA: 0x00A25CDD File Offset: 0x00A23EDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FSM_ConditionSkillEnd_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionSkillEnd.BP_FSM_ConditionSkillEnd_C");
			}
			return BP_FSM_ConditionSkillEnd_C._ClassPtr;
		}

		// Token: 0x0602CAFD RID: 183037 RVA: 0x00A25D04 File Offset: 0x00A23F04
		public BP_FSM_ConditionSkillEnd_C() : this(BuiltinUtils.AllocNativeUObject(BP_FSM_ConditionSkillEnd_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CAFE RID: 183038 RVA: 0x00A25D2C File Offset: 0x00A23F2C
		[NullableContext(1)]
		public BP_FSM_ConditionSkillEnd_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FSM_ConditionSkillEnd_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CAFF RID: 183039 RVA: 0x00A25D5F File Offset: 0x00A23F5F
		protected BP_FSM_ConditionSkillEnd_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040178F0 RID: 96496
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionSkillEnd.BP_FSM_ConditionSkillEnd_C";

		// Token: 0x040178F1 RID: 96497
		private static IntPtr _ClassPtr;

		// Token: 0x040178F2 RID: 96498
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
