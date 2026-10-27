using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200438A RID: 17290
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTaskFinish.BP_SM_ConditionTaskFinish_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ConditionTaskFinish_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CCA2 RID: 183458 RVA: 0x00A28AA2 File Offset: 0x00A26CA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionTaskFinish_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTaskFinish.BP_SM_ConditionTaskFinish_C");
			}
			return BP_SM_ConditionTaskFinish_C._ClassPtr;
		}

		// Token: 0x0602CCA3 RID: 183459 RVA: 0x00A28AC8 File Offset: 0x00A26CC8
		public BP_SM_ConditionTaskFinish_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTaskFinish_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CCA4 RID: 183460 RVA: 0x00A28AF0 File Offset: 0x00A26CF0
		[NullableContext(1)]
		public BP_SM_ConditionTaskFinish_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTaskFinish_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CCA5 RID: 183461 RVA: 0x00A28B23 File Offset: 0x00A26D23
		protected BP_SM_ConditionTaskFinish_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A06 RID: 96774
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTaskFinish.BP_SM_ConditionTaskFinish_C";

		// Token: 0x04017A07 RID: 96775
		private static IntPtr _ClassPtr;

		// Token: 0x04017A08 RID: 96776
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
