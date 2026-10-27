using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004352 RID: 17234
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionTag.BP_FSM_ConditionTag_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 93)]
	public class BP_FSM_ConditionTag_C : UKuroStateMachineConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB00 RID: 183040 RVA: 0x00A25D68 File Offset: 0x00A23F68
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FSM_ConditionTag_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionTag.BP_FSM_ConditionTag_C");
			}
			return BP_FSM_ConditionTag_C._ClassPtr;
		}

		// Token: 0x0602CB01 RID: 183041 RVA: 0x00A25D8C File Offset: 0x00A23F8C
		public BP_FSM_ConditionTag_C() : this(BuiltinUtils.AllocNativeUObject(BP_FSM_ConditionTag_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB02 RID: 183042 RVA: 0x00A25DB4 File Offset: 0x00A23FB4
		[NullableContext(1)]
		public BP_FSM_ConditionTag_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FSM_ConditionTag_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007074 RID: 28788
		// (get) Token: 0x0602CB03 RID: 183043 RVA: 0x00A25DE7 File Offset: 0x00A23FE7
		// (set) Token: 0x0602CB04 RID: 183044 RVA: 0x00A25DFB File Offset: 0x00A23FFB
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FSM_ConditionTag_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FSM_ConditionTag_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17007075 RID: 28789
		// (get) Token: 0x0602CB05 RID: 183045 RVA: 0x00A25E10 File Offset: 0x00A24010
		// (set) Token: 0x0602CB06 RID: 183046 RVA: 0x00A25E20 File Offset: 0x00A24020
		public unsafe bool CheckExist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FSM_ConditionTag_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FSM_ConditionTag_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CB07 RID: 183047 RVA: 0x00A25E31 File Offset: 0x00A24031
		protected BP_FSM_ConditionTag_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040178F3 RID: 96499
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionTag.BP_FSM_ConditionTag_C";

		// Token: 0x040178F4 RID: 96500
		private static IntPtr _ClassPtr;

		// Token: 0x040178F5 RID: 96501
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040178F6 RID: 96502
		internal static int __PropertyOffset_0;

		// Token: 0x040178F7 RID: 96503
		internal static int __PropertyOffset_1;
	}
}
