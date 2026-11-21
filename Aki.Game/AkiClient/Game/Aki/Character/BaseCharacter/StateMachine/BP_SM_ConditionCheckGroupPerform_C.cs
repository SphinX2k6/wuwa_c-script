using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200339D RID: 13213
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckGroupPerform.BP_SM_ConditionCheckGroupPerform_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ConditionCheckGroupPerform_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602185C RID: 137308 RVA: 0x00962E58 File Offset: 0x00961058
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckGroupPerform_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckGroupPerform.BP_SM_ConditionCheckGroupPerform_C");
			}
			return BP_SM_ConditionCheckGroupPerform_C._ClassPtr;
		}

		// Token: 0x0602185D RID: 137309 RVA: 0x00962E7C File Offset: 0x0096107C
		public BP_SM_ConditionCheckGroupPerform_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckGroupPerform_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602185E RID: 137310 RVA: 0x00962EA4 File Offset: 0x009610A4
		[NullableContext(1)]
		public BP_SM_ConditionCheckGroupPerform_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckGroupPerform_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602185F RID: 137311 RVA: 0x00962ED7 File Offset: 0x009610D7
		protected BP_SM_ConditionCheckGroupPerform_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012547 RID: 75079
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckGroupPerform.BP_SM_ConditionCheckGroupPerform_C";

		// Token: 0x04012548 RID: 75080
		private static IntPtr _ClassPtr;

		// Token: 0x04012549 RID: 75081
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
