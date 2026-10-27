using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004380 RID: 17280
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckPositionState.BP_SM_ConditionCheckPositionState_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 57)]
	public class BP_SM_ConditionCheckPositionState_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC54 RID: 183380 RVA: 0x00A282A5 File Offset: 0x00A264A5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckPositionState_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckPositionState.BP_SM_ConditionCheckPositionState_C");
			}
			return BP_SM_ConditionCheckPositionState_C._ClassPtr;
		}

		// Token: 0x0602CC55 RID: 183381 RVA: 0x00A282CC File Offset: 0x00A264CC
		public BP_SM_ConditionCheckPositionState_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckPositionState_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC56 RID: 183382 RVA: 0x00A282F4 File Offset: 0x00A264F4
		[NullableContext(1)]
		public BP_SM_ConditionCheckPositionState_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckPositionState_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070C2 RID: 28866
		// (get) Token: 0x0602CC57 RID: 183383 RVA: 0x00A28327 File Offset: 0x00A26527
		// (set) Token: 0x0602CC58 RID: 183384 RVA: 0x00A2833B File Offset: 0x00A2653B
		public unsafe TEnumAsByte<ECharParentMoveState> 位置状态
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionCheckPositionState_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionCheckPositionState_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602CC59 RID: 183385 RVA: 0x00A28350 File Offset: 0x00A26550
		protected BP_SM_ConditionCheckPositionState_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179D5 RID: 96725
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckPositionState.BP_SM_ConditionCheckPositionState_C";

		// Token: 0x040179D6 RID: 96726
		private static IntPtr _ClassPtr;

		// Token: 0x040179D7 RID: 96727
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040179D8 RID: 96728
		internal static int __PropertyOffset_0;
	}
}
