using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200437A RID: 17274
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckDissolveCombine.BP_SM_ConditionCheckDissolveCombine_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ConditionCheckDissolveCombine_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC36 RID: 183350 RVA: 0x00A27EF3 File Offset: 0x00A260F3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckDissolveCombine_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckDissolveCombine.BP_SM_ConditionCheckDissolveCombine_C");
			}
			return BP_SM_ConditionCheckDissolveCombine_C._ClassPtr;
		}

		// Token: 0x0602CC37 RID: 183351 RVA: 0x00A27F18 File Offset: 0x00A26118
		public BP_SM_ConditionCheckDissolveCombine_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckDissolveCombine_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC38 RID: 183352 RVA: 0x00A27F40 File Offset: 0x00A26140
		[NullableContext(1)]
		public BP_SM_ConditionCheckDissolveCombine_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckDissolveCombine_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CC39 RID: 183353 RVA: 0x00A27F73 File Offset: 0x00A26173
		protected BP_SM_ConditionCheckDissolveCombine_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179C0 RID: 96704
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckDissolveCombine.BP_SM_ConditionCheckDissolveCombine_C";

		// Token: 0x040179C1 RID: 96705
		private static IntPtr _ClassPtr;

		// Token: 0x040179C2 RID: 96706
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
