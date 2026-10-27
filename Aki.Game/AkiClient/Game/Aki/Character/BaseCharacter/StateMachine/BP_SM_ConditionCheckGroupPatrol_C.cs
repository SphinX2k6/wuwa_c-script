using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200437B RID: 17275
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckGroupPatrol.BP_SM_ConditionCheckGroupPatrol_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ConditionCheckGroupPatrol_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC3A RID: 183354 RVA: 0x00A27F7C File Offset: 0x00A2617C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckGroupPatrol_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckGroupPatrol.BP_SM_ConditionCheckGroupPatrol_C");
			}
			return BP_SM_ConditionCheckGroupPatrol_C._ClassPtr;
		}

		// Token: 0x0602CC3B RID: 183355 RVA: 0x00A27FA0 File Offset: 0x00A261A0
		public BP_SM_ConditionCheckGroupPatrol_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckGroupPatrol_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC3C RID: 183356 RVA: 0x00A27FC8 File Offset: 0x00A261C8
		[NullableContext(1)]
		public BP_SM_ConditionCheckGroupPatrol_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckGroupPatrol_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CC3D RID: 183357 RVA: 0x00A27FFB File Offset: 0x00A261FB
		protected BP_SM_ConditionCheckGroupPatrol_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179C3 RID: 96707
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckGroupPatrol.BP_SM_ConditionCheckGroupPatrol_C";

		// Token: 0x040179C4 RID: 96708
		private static IntPtr _ClassPtr;

		// Token: 0x040179C5 RID: 96709
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
