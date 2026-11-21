using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005227 RID: 21031
	public class TBattleConditionUnion
	{
		// Token: 0x17009670 RID: 38512
		// (get) Token: 0x06021205 RID: 135685 RVA: 0x0049320A File Offset: 0x0049140A
		// (set) Token: 0x06021206 RID: 135686 RVA: 0x00493212 File Offset: 0x00491412
		public TBattleCondition Type { get; set; }

		// Token: 0x17009671 RID: 38513
		// (get) Token: 0x06021207 RID: 135687 RVA: 0x0049321B File Offset: 0x0049141B
		// (set) Token: 0x06021208 RID: 135688 RVA: 0x00493223 File Offset: 0x00491423
		public object Value { get; set; }

		// Token: 0x06021209 RID: 135689 RVA: 0x0049322C File Offset: 0x0049142C
		public TBattleConditionUnion()
		{
			this.Type = TBattleCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602120A RID: 135690 RVA: 0x00493242 File Offset: 0x00491442
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602120B RID: 135691 RVA: 0x00493254 File Offset: 0x00491454
		public IBattleTagConditionT AsIBattleTagCondition()
		{
			return this.As<IBattleTagConditionT>();
		}

		// Token: 0x0602120C RID: 135692 RVA: 0x0049325C File Offset: 0x0049145C
		public static TBattleConditionUnion FromIBattleTagCondition(IBattleTagConditionT _ibattletagcondition)
		{
			return new TBattleConditionUnion
			{
				Type = TBattleCondition.IBattleTagCondition,
				Value = _ibattletagcondition
			};
		}

		// Token: 0x0602120D RID: 135693 RVA: 0x00493271 File Offset: 0x00491471
		public ICounterAttackConditionT AsICounterAttackCondition()
		{
			return this.As<ICounterAttackConditionT>();
		}

		// Token: 0x0602120E RID: 135694 RVA: 0x00493279 File Offset: 0x00491479
		public static TBattleConditionUnion FromICounterAttackCondition(ICounterAttackConditionT _icounterattackcondition)
		{
			return new TBattleConditionUnion
			{
				Type = TBattleCondition.ICounterAttackCondition,
				Value = _icounterattackcondition
			};
		}

		// Token: 0x0602120F RID: 135695 RVA: 0x0049328E File Offset: 0x0049148E
		public IPerfectDodgeConditionT AsIPerfectDodgeCondition()
		{
			return this.As<IPerfectDodgeConditionT>();
		}

		// Token: 0x06021210 RID: 135696 RVA: 0x00493296 File Offset: 0x00491496
		public static TBattleConditionUnion FromIPerfectDodgeCondition(IPerfectDodgeConditionT _iperfectdodgecondition)
		{
			return new TBattleConditionUnion
			{
				Type = TBattleCondition.IPerfectDodgeCondition,
				Value = _iperfectdodgecondition
			};
		}

		// Token: 0x06021211 RID: 135697 RVA: 0x004932AC File Offset: 0x004914AC
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
