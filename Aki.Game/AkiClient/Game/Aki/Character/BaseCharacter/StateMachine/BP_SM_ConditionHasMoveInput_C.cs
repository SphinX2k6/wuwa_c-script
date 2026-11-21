using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033A3 RID: 13219
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionHasMoveInput.BP_SM_ConditionHasMoveInput_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ConditionHasMoveInput_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602187E RID: 137342 RVA: 0x00963261 File Offset: 0x00961461
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionHasMoveInput_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionHasMoveInput.BP_SM_ConditionHasMoveInput_C");
			}
			return BP_SM_ConditionHasMoveInput_C._ClassPtr;
		}

		// Token: 0x0602187F RID: 137343 RVA: 0x00963288 File Offset: 0x00961488
		public BP_SM_ConditionHasMoveInput_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionHasMoveInput_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021880 RID: 137344 RVA: 0x009632B0 File Offset: 0x009614B0
		[NullableContext(1)]
		public BP_SM_ConditionHasMoveInput_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionHasMoveInput_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021881 RID: 137345 RVA: 0x009632E3 File Offset: 0x009614E3
		protected BP_SM_ConditionHasMoveInput_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401255E RID: 75102
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionHasMoveInput.BP_SM_ConditionHasMoveInput_C";

		// Token: 0x0401255F RID: 75103
		private static IntPtr _ClassPtr;

		// Token: 0x04012560 RID: 75104
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
