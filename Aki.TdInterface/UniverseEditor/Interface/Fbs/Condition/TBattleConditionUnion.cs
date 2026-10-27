using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D2B RID: 19755
	public class TBattleConditionUnion
	{
		// Token: 0x17008F37 RID: 36663
		// (get) Token: 0x0601F5BE RID: 128446 RVA: 0x0045F27A File Offset: 0x0045D47A
		// (set) Token: 0x0601F5BF RID: 128447 RVA: 0x0045F282 File Offset: 0x0045D482
		public TBattleCondition Type { get; set; }

		// Token: 0x17008F38 RID: 36664
		// (get) Token: 0x0601F5C0 RID: 128448 RVA: 0x0045F28B File Offset: 0x0045D48B
		// (set) Token: 0x0601F5C1 RID: 128449 RVA: 0x0045F293 File Offset: 0x0045D493
		public object Value { get; set; }

		// Token: 0x0601F5C2 RID: 128450 RVA: 0x0045F29C File Offset: 0x0045D49C
		public TBattleConditionUnion()
		{
			this.Type = TBattleCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0601F5C3 RID: 128451 RVA: 0x0045F2B2 File Offset: 0x0045D4B2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F5C4 RID: 128452 RVA: 0x0045F2C4 File Offset: 0x0045D4C4
		public IBattleTagConditionT AsIBattleTagCondition()
		{
			return this.As<IBattleTagConditionT>();
		}

		// Token: 0x0601F5C5 RID: 128453 RVA: 0x0045F2CC File Offset: 0x0045D4CC
		public static TBattleConditionUnion FromIBattleTagCondition(IBattleTagConditionT _ibattletagcondition)
		{
			return new TBattleConditionUnion
			{
				Type = TBattleCondition.IBattleTagCondition,
				Value = _ibattletagcondition
			};
		}

		// Token: 0x0601F5C6 RID: 128454 RVA: 0x0045F2E1 File Offset: 0x0045D4E1
		public ICounterAttackConditionT AsICounterAttackCondition()
		{
			return this.As<ICounterAttackConditionT>();
		}

		// Token: 0x0601F5C7 RID: 128455 RVA: 0x0045F2E9 File Offset: 0x0045D4E9
		public static TBattleConditionUnion FromICounterAttackCondition(ICounterAttackConditionT _icounterattackcondition)
		{
			return new TBattleConditionUnion
			{
				Type = TBattleCondition.ICounterAttackCondition,
				Value = _icounterattackcondition
			};
		}

		// Token: 0x0601F5C8 RID: 128456 RVA: 0x0045F2FE File Offset: 0x0045D4FE
		public IPerfectDodgeConditionT AsIPerfectDodgeCondition()
		{
			return this.As<IPerfectDodgeConditionT>();
		}

		// Token: 0x0601F5C9 RID: 128457 RVA: 0x0045F306 File Offset: 0x0045D506
		public static TBattleConditionUnion FromIPerfectDodgeCondition(IPerfectDodgeConditionT _iperfectdodgecondition)
		{
			return new TBattleConditionUnion
			{
				Type = TBattleCondition.IPerfectDodgeCondition,
				Value = _iperfectdodgecondition
			};
		}

		// Token: 0x0601F5CA RID: 128458 RVA: 0x0045F31C File Offset: 0x0045D51C
		public static int Pack(FlatBufferBuilder builder, TBattleConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TBattleCondition.IBattleTagCondition:
				return IBattleTagCondition.Pack(builder, _o.AsIBattleTagCondition()).Value;
			case TBattleCondition.ICounterAttackCondition:
				return ICounterAttackCondition.Pack(builder, _o.AsICounterAttackCondition()).Value;
			case TBattleCondition.IPerfectDodgeCondition:
				return IPerfectDodgeCondition.Pack(builder, _o.AsIPerfectDodgeCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
