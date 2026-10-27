using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004350 RID: 17232
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionHate.BP_FSM_ConditionHate_C")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 81)]
	public class BP_FSM_ConditionHate_C : UKuroStateMachineConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CAF6 RID: 183030 RVA: 0x00A25C31 File Offset: 0x00A23E31
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FSM_ConditionHate_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionHate.BP_FSM_ConditionHate_C");
			}
			return BP_FSM_ConditionHate_C._ClassPtr;
		}

		// Token: 0x0602CAF7 RID: 183031 RVA: 0x00A25C58 File Offset: 0x00A23E58
		public BP_FSM_ConditionHate_C() : this(BuiltinUtils.AllocNativeUObject(BP_FSM_ConditionHate_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CAF8 RID: 183032 RVA: 0x00A25C80 File Offset: 0x00A23E80
		[NullableContext(1)]
		public BP_FSM_ConditionHate_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FSM_ConditionHate_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007073 RID: 28787
		// (get) Token: 0x0602CAF9 RID: 183033 RVA: 0x00A25CB3 File Offset: 0x00A23EB3
		// (set) Token: 0x0602CAFA RID: 183034 RVA: 0x00A25CC3 File Offset: 0x00A23EC3
		public unsafe bool HasHateTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FSM_ConditionHate_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FSM_ConditionHate_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CAFB RID: 183035 RVA: 0x00A25CD4 File Offset: 0x00A23ED4
		protected BP_FSM_ConditionHate_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040178EC RID: 96492
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionHate.BP_FSM_ConditionHate_C";

		// Token: 0x040178ED RID: 96493
		private static IntPtr _ClassPtr;

		// Token: 0x040178EE RID: 96494
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040178EF RID: 96495
		internal static int __PropertyOffset_0;
	}
}
