using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033A1 RID: 13217
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckPositionState.BP_SM_ConditionCheckPositionState_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 57)]
	public class BP_SM_ConditionCheckPositionState_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021872 RID: 137330 RVA: 0x009630F9 File Offset: 0x009612F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckPositionState_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckPositionState.BP_SM_ConditionCheckPositionState_C");
			}
			return BP_SM_ConditionCheckPositionState_C._ClassPtr;
		}

		// Token: 0x06021873 RID: 137331 RVA: 0x00963120 File Offset: 0x00961320
		public BP_SM_ConditionCheckPositionState_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckPositionState_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021874 RID: 137332 RVA: 0x00963148 File Offset: 0x00961348
		[NullableContext(1)]
		public BP_SM_ConditionCheckPositionState_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckPositionState_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044C4 RID: 17604
		// (get) Token: 0x06021875 RID: 137333 RVA: 0x0096317B File Offset: 0x0096137B
		// (set) Token: 0x06021876 RID: 137334 RVA: 0x0096318F File Offset: 0x0096138F
		public unsafe TEnumAsByte<ECharParentMoveState> 位置状态
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionCheckPositionState_C.__PropertyOffset_位置状态);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionCheckPositionState_C.__PropertyOffset_位置状态) = value;
			}
		}

		// Token: 0x06021877 RID: 137335 RVA: 0x009631A4 File Offset: 0x009613A4
		protected BP_SM_ConditionCheckPositionState_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012556 RID: 75094
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckPositionState.BP_SM_ConditionCheckPositionState_C";

		// Token: 0x04012557 RID: 75095
		private static IntPtr _ClassPtr;

		// Token: 0x04012558 RID: 75096
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012559 RID: 75097
		internal static int __PropertyOffset_位置状态;
	}
}
