using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200438C RID: 17292
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTrue.BP_SM_ConditionTrue_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ConditionTrue_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CCB0 RID: 183472 RVA: 0x00A28C17 File Offset: 0x00A26E17
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionTrue_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTrue.BP_SM_ConditionTrue_C");
			}
			return BP_SM_ConditionTrue_C._ClassPtr;
		}

		// Token: 0x0602CCB1 RID: 183473 RVA: 0x00A28C3C File Offset: 0x00A26E3C
		public BP_SM_ConditionTrue_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTrue_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CCB2 RID: 183474 RVA: 0x00A28C64 File Offset: 0x00A26E64
		[NullableContext(1)]
		public BP_SM_ConditionTrue_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTrue_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CCB3 RID: 183475 RVA: 0x00A28C97 File Offset: 0x00A26E97
		protected BP_SM_ConditionTrue_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A0F RID: 96783
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTrue.BP_SM_ConditionTrue_C";

		// Token: 0x04017A10 RID: 96784
		private static IntPtr _ClassPtr;

		// Token: 0x04017A11 RID: 96785
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
