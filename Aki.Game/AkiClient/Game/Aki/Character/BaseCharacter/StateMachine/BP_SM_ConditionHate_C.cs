using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033A4 RID: 13220
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionHate.BP_SM_ConditionHate_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ConditionHate_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021882 RID: 137346 RVA: 0x009632EC File Offset: 0x009614EC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionHate_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionHate.BP_SM_ConditionHate_C");
			}
			return BP_SM_ConditionHate_C._ClassPtr;
		}

		// Token: 0x06021883 RID: 137347 RVA: 0x00963310 File Offset: 0x00961510
		public BP_SM_ConditionHate_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionHate_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021884 RID: 137348 RVA: 0x00963338 File Offset: 0x00961538
		[NullableContext(1)]
		public BP_SM_ConditionHate_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionHate_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021885 RID: 137349 RVA: 0x0096336B File Offset: 0x0096156B
		protected BP_SM_ConditionHate_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012561 RID: 75105
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionHate.BP_SM_ConditionHate_C";

		// Token: 0x04012562 RID: 75106
		private static IntPtr _ClassPtr;

		// Token: 0x04012563 RID: 75107
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
