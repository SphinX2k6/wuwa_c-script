using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004382 RID: 17282
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionHasMoveInput.BP_SM_ConditionHasMoveInput_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ConditionHasMoveInput_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC60 RID: 183392 RVA: 0x00A2840D File Offset: 0x00A2660D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionHasMoveInput_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionHasMoveInput.BP_SM_ConditionHasMoveInput_C");
			}
			return BP_SM_ConditionHasMoveInput_C._ClassPtr;
		}

		// Token: 0x0602CC61 RID: 183393 RVA: 0x00A28434 File Offset: 0x00A26634
		public BP_SM_ConditionHasMoveInput_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionHasMoveInput_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC62 RID: 183394 RVA: 0x00A2845C File Offset: 0x00A2665C
		[NullableContext(1)]
		public BP_SM_ConditionHasMoveInput_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionHasMoveInput_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CC63 RID: 183395 RVA: 0x00A2848F File Offset: 0x00A2668F
		protected BP_SM_ConditionHasMoveInput_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179DD RID: 96733
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionHasMoveInput.BP_SM_ConditionHasMoveInput_C";

		// Token: 0x040179DE RID: 96734
		private static IntPtr _ClassPtr;

		// Token: 0x040179DF RID: 96735
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
