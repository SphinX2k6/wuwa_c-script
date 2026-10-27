using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200434F RID: 17231
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionCheckState.BP_FSM_ConditionCheckState_C")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 97)]
	public class BP_FSM_ConditionCheckState_C : UKuroStateMachineConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CAEE RID: 183022 RVA: 0x00A25B40 File Offset: 0x00A23D40
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FSM_ConditionCheckState_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionCheckState.BP_FSM_ConditionCheckState_C");
			}
			return BP_FSM_ConditionCheckState_C._ClassPtr;
		}

		// Token: 0x0602CAEF RID: 183023 RVA: 0x00A25B64 File Offset: 0x00A23D64
		public BP_FSM_ConditionCheckState_C() : this(BuiltinUtils.AllocNativeUObject(BP_FSM_ConditionCheckState_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CAF0 RID: 183024 RVA: 0x00A25B8C File Offset: 0x00A23D8C
		public BP_FSM_ConditionCheckState_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FSM_ConditionCheckState_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007071 RID: 28785
		// (get) Token: 0x0602CAF1 RID: 183025 RVA: 0x00A25BC0 File Offset: 0x00A23DC0
		// (set) Token: 0x0602CAF2 RID: 183026 RVA: 0x00A25BF9 File Offset: 0x00A23DF9
		public TArray<string> States
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._States) == null)
				{
					result = (this._States = new TArray<string>(base.NativePtr + (IntPtr)BP_FSM_ConditionCheckState_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.States.CopyAssign(value);
			}
		}

		// Token: 0x17007072 RID: 28786
		// (get) Token: 0x0602CAF3 RID: 183027 RVA: 0x00A25C07 File Offset: 0x00A23E07
		// (set) Token: 0x0602CAF4 RID: 183028 RVA: 0x00A25C17 File Offset: 0x00A23E17
		public unsafe bool Activated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FSM_ConditionCheckState_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FSM_ConditionCheckState_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CAF5 RID: 183029 RVA: 0x00A25C28 File Offset: 0x00A23E28
		protected BP_FSM_ConditionCheckState_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040178E6 RID: 96486
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionCheckState.BP_FSM_ConditionCheckState_C";

		// Token: 0x040178E7 RID: 96487
		private static IntPtr _ClassPtr;

		// Token: 0x040178E8 RID: 96488
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040178E9 RID: 96489
		internal static int __PropertyOffset_0;

		// Token: 0x040178EA RID: 96490
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _States;

		// Token: 0x040178EB RID: 96491
		internal static int __PropertyOffset_1;
	}
}
