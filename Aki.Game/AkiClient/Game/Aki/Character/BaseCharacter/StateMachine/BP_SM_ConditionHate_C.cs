using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004383 RID: 17283
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionHate.BP_SM_ConditionHate_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ConditionHate_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC64 RID: 183396 RVA: 0x00A28498 File Offset: 0x00A26698
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionHate_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionHate.BP_SM_ConditionHate_C");
			}
			return BP_SM_ConditionHate_C._ClassPtr;
		}

		// Token: 0x0602CC65 RID: 183397 RVA: 0x00A284BC File Offset: 0x00A266BC
		public BP_SM_ConditionHate_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionHate_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC66 RID: 183398 RVA: 0x00A284E4 File Offset: 0x00A266E4
		[NullableContext(1)]
		public BP_SM_ConditionHate_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionHate_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CC67 RID: 183399 RVA: 0x00A28517 File Offset: 0x00A26717
		protected BP_SM_ConditionHate_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179E0 RID: 96736
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionHate.BP_SM_ConditionHate_C";

		// Token: 0x040179E1 RID: 96737
		private static IntPtr _ClassPtr;

		// Token: 0x040179E2 RID: 96738
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
