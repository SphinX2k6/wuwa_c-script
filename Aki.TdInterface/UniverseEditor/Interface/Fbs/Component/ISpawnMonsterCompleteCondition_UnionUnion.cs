using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F58 RID: 24408
	public class ISpawnMonsterCompleteCondition_UnionUnion
	{
		// Token: 0x1700B4BF RID: 46271
		// (get) Token: 0x0602903E RID: 167998 RVA: 0x0059A3AD File Offset: 0x005985AD
		// (set) Token: 0x0602903F RID: 167999 RVA: 0x0059A3B5 File Offset: 0x005985B5
		public ISpawnMonsterCompleteCondition_Union Type { get; set; }

		// Token: 0x1700B4C0 RID: 46272
		// (get) Token: 0x06029040 RID: 168000 RVA: 0x0059A3BE File Offset: 0x005985BE
		// (set) Token: 0x06029041 RID: 168001 RVA: 0x0059A3C6 File Offset: 0x005985C6
		public object Value { get; set; }

		// Token: 0x06029042 RID: 168002 RVA: 0x0059A3CF File Offset: 0x005985CF
		public ISpawnMonsterCompleteCondition_UnionUnion()
		{
			this.Type = ISpawnMonsterCompleteCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029043 RID: 168003 RVA: 0x0059A3E5 File Offset: 0x005985E5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029044 RID: 168004 RVA: 0x0059A3F7 File Offset: 0x005985F7
		public ISpawnMonsterCompleteConditionT AsISpawnMonsterCompleteCondition()
		{
			return this.As<ISpawnMonsterCompleteConditionT>();
		}

		// Token: 0x06029045 RID: 168005 RVA: 0x0059A3FF File Offset: 0x005985FF
		public static ISpawnMonsterCompleteCondition_UnionUnion FromISpawnMonsterCompleteCondition(ISpawnMonsterCompleteConditionT _ispawnmonstercompletecondition)
		{
			return new ISpawnMonsterCompleteCondition_UnionUnion
			{
				Type = ISpawnMonsterCompleteCondition_Union.ISpawnMonsterCompleteCondition,
				Value = _ispawnmonstercompletecondition
			};
		}

		// Token: 0x06029046 RID: 168006 RVA: 0x0059A414 File Offset: 0x00598614
		public IAllKillConditionT AsIAllKillCondition()
		{
			return this.As<IAllKillConditionT>();
		}

		// Token: 0x06029047 RID: 168007 RVA: 0x0059A41C File Offset: 0x0059861C
		public static ISpawnMonsterCompleteCondition_UnionUnion FromIAllKillCondition(IAllKillConditionT _iallkillcondition)
		{
			return new ISpawnMonsterCompleteCondition_UnionUnion
			{
				Type = ISpawnMonsterCompleteCondition_Union.IAllKillCondition,
				Value = _iallkillcondition
			};
		}

		// Token: 0x06029048 RID: 168008 RVA: 0x0059A431 File Offset: 0x00598631
		public IDurationConditionT AsIDurationCondition()
		{
			return this.As<IDurationConditionT>();
		}

		// Token: 0x06029049 RID: 168009 RVA: 0x0059A439 File Offset: 0x00598639
		public static ISpawnMonsterCompleteCondition_UnionUnion FromIDurationCondition(IDurationConditionT _idurationcondition)
		{
			return new ISpawnMonsterCompleteCondition_UnionUnion
			{
				Type = ISpawnMonsterCompleteCondition_Union.IDurationCondition,
				Value = _idurationcondition
			};
		}

		// Token: 0x0602904A RID: 168010 RVA: 0x0059A44E File Offset: 0x0059864E
		public IQuantityRefillConditionT AsIQuantityRefillCondition()
		{
			return this.As<IQuantityRefillConditionT>();
		}

		// Token: 0x0602904B RID: 168011 RVA: 0x0059A456 File Offset: 0x00598656
		public static ISpawnMonsterCompleteCondition_UnionUnion FromIQuantityRefillCondition(IQuantityRefillConditionT _iquantityrefillcondition)
		{
			return new ISpawnMonsterCompleteCondition_UnionUnion
			{
				Type = ISpawnMonsterCompleteCondition_Union.IQuantityRefillCondition,
				Value = _iquantityrefillcondition
			};
		}

		// Token: 0x0602904C RID: 168012 RVA: 0x0059A46C File Offset: 0x0059866C
		public static int Pack(FlatBufferBuilder builder, ISpawnMonsterCompleteCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISpawnMonsterCompleteCondition_Union.ISpawnMonsterCompleteCondition:
				return ISpawnMonsterCompleteCondition.Pack(builder, _o.AsISpawnMonsterCompleteCondition()).Value;
			case ISpawnMonsterCompleteCondition_Union.IAllKillCondition:
				return IAllKillCondition.Pack(builder, _o.AsIAllKillCondition()).Value;
			case ISpawnMonsterCompleteCondition_Union.IDurationCondition:
				return IDurationCondition.Pack(builder, _o.AsIDurationCondition()).Value;
			case ISpawnMonsterCompleteCondition_Union.IQuantityRefillCondition:
				return IQuantityRefillCondition.Pack(builder, _o.AsIQuantityRefillCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
