using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033AB RID: 13227
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTaskFinish.BP_SM_ConditionTaskFinish_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ConditionTaskFinish_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218C0 RID: 137408 RVA: 0x009638F6 File Offset: 0x00961AF6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionTaskFinish_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTaskFinish.BP_SM_ConditionTaskFinish_C");
			}
			return BP_SM_ConditionTaskFinish_C._ClassPtr;
		}

		// Token: 0x060218C1 RID: 137409 RVA: 0x0096391C File Offset: 0x00961B1C
		public BP_SM_ConditionTaskFinish_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTaskFinish_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218C2 RID: 137410 RVA: 0x00963944 File Offset: 0x00961B44
		[NullableContext(1)]
		public BP_SM_ConditionTaskFinish_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTaskFinish_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060218C3 RID: 137411 RVA: 0x00963977 File Offset: 0x00961B77
		protected BP_SM_ConditionTaskFinish_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012587 RID: 75143
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTaskFinish.BP_SM_ConditionTaskFinish_C";

		// Token: 0x04012588 RID: 75144
		private static IntPtr _ClassPtr;

		// Token: 0x04012589 RID: 75145
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
