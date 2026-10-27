using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200437C RID: 17276
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckGroupPerform.BP_SM_ConditionCheckGroupPerform_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ConditionCheckGroupPerform_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC3E RID: 183358 RVA: 0x00A28004 File Offset: 0x00A26204
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckGroupPerform_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckGroupPerform.BP_SM_ConditionCheckGroupPerform_C");
			}
			return BP_SM_ConditionCheckGroupPerform_C._ClassPtr;
		}

		// Token: 0x0602CC3F RID: 183359 RVA: 0x00A28028 File Offset: 0x00A26228
		public BP_SM_ConditionCheckGroupPerform_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckGroupPerform_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC40 RID: 183360 RVA: 0x00A28050 File Offset: 0x00A26250
		[NullableContext(1)]
		public BP_SM_ConditionCheckGroupPerform_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckGroupPerform_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CC41 RID: 183361 RVA: 0x00A28083 File Offset: 0x00A26283
		protected BP_SM_ConditionCheckGroupPerform_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179C6 RID: 96710
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckGroupPerform.BP_SM_ConditionCheckGroupPerform_C";

		// Token: 0x040179C7 RID: 96711
		private static IntPtr _ClassPtr;

		// Token: 0x040179C8 RID: 96712
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
