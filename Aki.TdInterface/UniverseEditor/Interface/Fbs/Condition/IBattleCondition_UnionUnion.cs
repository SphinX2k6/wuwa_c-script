using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E31 RID: 20017
	public class IBattleCondition_UnionUnion
	{
		// Token: 0x17008E93 RID: 36499
		// (get) Token: 0x0601EF39 RID: 126777 RVA: 0x00452CDD File Offset: 0x00450EDD
		// (set) Token: 0x0601EF3A RID: 126778 RVA: 0x00452CE5 File Offset: 0x00450EE5
		public IBattleCondition_Union Type { get; set; }

		// Token: 0x17008E94 RID: 36500
		// (get) Token: 0x0601EF3B RID: 126779 RVA: 0x00452CEE File Offset: 0x00450EEE
		// (set) Token: 0x0601EF3C RID: 126780 RVA: 0x00452CF6 File Offset: 0x00450EF6
		public object Value { get; set; }

		// Token: 0x0601EF3D RID: 126781 RVA: 0x00452CFF File Offset: 0x00450EFF
		public IBattleCondition_UnionUnion()
		{
			this.Type = IBattleCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601EF3E RID: 126782 RVA: 0x00452D15 File Offset: 0x00450F15
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EF3F RID: 126783 RVA: 0x00452D27 File Offset: 0x00450F27
		public IBattleConditionT AsIBattleCondition()
		{
			return this.As<IBattleConditionT>();
		}

		// Token: 0x0601EF40 RID: 126784 RVA: 0x00452D2F File Offset: 0x00450F2F
		public static IBattleCondition_UnionUnion FromIBattleCondition(IBattleConditionT _ibattlecondition)
		{
			return new IBattleCondition_UnionUnion
			{
				Type = IBattleCondition_Union.IBattleCondition,
				Value = _ibattlecondition
			};
		}

		// Token: 0x0601EF41 RID: 126785 RVA: 0x00452D44 File Offset: 0x00450F44
		public IBattleTagConditionT AsIBattleTagCondition()
		{
			return this.As<IBattleTagConditionT>();
		}

		// Token: 0x0601EF42 RID: 126786 RVA: 0x00452D4C File Offset: 0x00450F4C
		public static IBattleCondition_UnionUnion FromIBattleTagCondition(IBattleTagConditionT _ibattletagcondition)
		{
			return new IBattleCondition_UnionUnion
			{
				Type = IBattleCondition_Union.IBattleTagCondition,
				Value = _ibattletagcondition
			};
		}

		// Token: 0x0601EF43 RID: 126787 RVA: 0x00452D61 File Offset: 0x00450F61
		public IPerfectDodgeConditionT AsIPerfectDodgeCondition()
		{
			return this.As<IPerfectDodgeConditionT>();
		}

		// Token: 0x0601EF44 RID: 126788 RVA: 0x00452D69 File Offset: 0x00450F69
		public static IBattleCondition_UnionUnion FromIPerfectDodgeCondition(IPerfectDodgeConditionT _iperfectdodgecondition)
		{
			return new IBattleCondition_UnionUnion
			{
				Type = IBattleCondition_Union.IPerfectDodgeCondition,
				Value = _iperfectdodgecondition
			};
		}

		// Token: 0x0601EF45 RID: 126789 RVA: 0x00452D7E File Offset: 0x00450F7E
		public ICounterAttackConditionT AsICounterAttackCondition()
		{
			return this.As<ICounterAttackConditionT>();
		}

		// Token: 0x0601EF46 RID: 126790 RVA: 0x00452D86 File Offset: 0x00450F86
		public static IBattleCondition_UnionUnion FromICounterAttackCondition(ICounterAttackConditionT _icounterattackcondition)
		{
			return new IBattleCondition_UnionUnion
			{
				Type = IBattleCondition_Union.ICounterAttackCondition,
				Value = _icounterattackcondition
			};
		}

		// Token: 0x0601EF47 RID: 126791 RVA: 0x00452D9C File Offset: 0x00450F9C
		public static int Pack(FlatBufferBuilder builder, IBattleCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBattleCondition_Union.IBattleCondition:
				return IBattleCondition.Pack(builder, _o.AsIBattleCondition()).Value;
			case IBattleCondition_Union.IBattleTagCondition:
				return IBattleTagCondition.Pack(builder, _o.AsIBattleTagCondition()).Value;
			case IBattleCondition_Union.IPerfectDodgeCondition:
				return IPerfectDodgeCondition.Pack(builder, _o.AsIPerfectDodgeCondition()).Value;
			case IBattleCondition_Union.ICounterAttackCondition:
				return ICounterAttackCondition.Pack(builder, _o.AsICounterAttackCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
