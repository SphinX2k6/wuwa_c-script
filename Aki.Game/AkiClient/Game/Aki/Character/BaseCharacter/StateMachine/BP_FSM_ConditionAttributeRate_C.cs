using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Monster.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200434D RID: 17229
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionAttributeRate.BP_FSM_ConditionAttributeRate_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class BP_FSM_ConditionAttributeRate_C : UKuroStateMachineConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CAE2 RID: 183010 RVA: 0x00A2599E File Offset: 0x00A23B9E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FSM_ConditionAttributeRate_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionAttributeRate.BP_FSM_ConditionAttributeRate_C");
			}
			return BP_FSM_ConditionAttributeRate_C._ClassPtr;
		}

		// Token: 0x0602CAE3 RID: 183011 RVA: 0x00A259C4 File Offset: 0x00A23BC4
		public BP_FSM_ConditionAttributeRate_C() : this(BuiltinUtils.AllocNativeUObject(BP_FSM_ConditionAttributeRate_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CAE4 RID: 183012 RVA: 0x00A259EC File Offset: 0x00A23BEC
		public BP_FSM_ConditionAttributeRate_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FSM_ConditionAttributeRate_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700706F RID: 28783
		// (get) Token: 0x0602CAE5 RID: 183013 RVA: 0x00A25A20 File Offset: 0x00A23C20
		// (set) Token: 0x0602CAE6 RID: 183014 RVA: 0x00A25A59 File Offset: 0x00A23C59
		public TArray<SAiAttributeRate> AttributeRates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SAiAttributeRate> result;
				if ((result = this._AttributeRates) == null)
				{
					result = (this._AttributeRates = new TArray<SAiAttributeRate>(base.NativePtr + (IntPtr)BP_FSM_ConditionAttributeRate_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.AttributeRates.CopyAssign(value);
			}
		}

		// Token: 0x0602CAE7 RID: 183015 RVA: 0x00A25A67 File Offset: 0x00A23C67
		protected BP_FSM_ConditionAttributeRate_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040178DC RID: 96476
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionAttributeRate.BP_FSM_ConditionAttributeRate_C";

		// Token: 0x040178DD RID: 96477
		private static IntPtr _ClassPtr;

		// Token: 0x040178DE RID: 96478
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040178DF RID: 96479
		internal static int __PropertyOffset_0;

		// Token: 0x040178E0 RID: 96480
		[Nullable(2)]
		private TArray<SAiAttributeRate> _AttributeRates;
	}
}
