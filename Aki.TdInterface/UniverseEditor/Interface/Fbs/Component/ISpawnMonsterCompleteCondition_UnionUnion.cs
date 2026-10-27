using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200594B RID: 22859
	public class ISpawnMonsterCompleteCondition_UnionUnion
	{
		// Token: 0x1700AB8B RID: 43915
		// (get) Token: 0x06026AD4 RID: 158420 RVA: 0x00553741 File Offset: 0x00551941
		// (set) Token: 0x06026AD5 RID: 158421 RVA: 0x00553749 File Offset: 0x00551949
		public ISpawnMonsterCompleteCondition_Union Type { get; set; }

		// Token: 0x1700AB8C RID: 43916
		// (get) Token: 0x06026AD6 RID: 158422 RVA: 0x00553752 File Offset: 0x00551952
		// (set) Token: 0x06026AD7 RID: 158423 RVA: 0x0055375A File Offset: 0x0055195A
		public object Value { get; set; }

		// Token: 0x06026AD8 RID: 158424 RVA: 0x00553763 File Offset: 0x00551963
		public ISpawnMonsterCompleteCondition_UnionUnion()
		{
			this.Type = ISpawnMonsterCompleteCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026AD9 RID: 158425 RVA: 0x00553779 File Offset: 0x00551979
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026ADA RID: 158426 RVA: 0x0055378B File Offset: 0x0055198B
		public ISpawnMonsterCompleteConditionT AsISpawnMonsterCompleteCondition()
		{
			return this.As<ISpawnMonsterCompleteConditionT>();
		}

		// Token: 0x06026ADB RID: 158427 RVA: 0x00553793 File Offset: 0x00551993
		public static ISpawnMonsterCompleteCondition_UnionUnion FromISpawnMonsterCompleteCondition(ISpawnMonsterCompleteConditionT _ispawnmonstercompletecondition)
		{
			return new ISpawnMonsterCompleteCondition_UnionUnion
			{
				Type = ISpawnMonsterCompleteCondition_Union.ISpawnMonsterCompleteCondition,
				Value = _ispawnmonstercompletecondition
			};
		}

		// Token: 0x06026ADC RID: 158428 RVA: 0x005537A8 File Offset: 0x005519A8
		public IAllKillConditionT AsIAllKillCondition()
		{
			return this.As<IAllKillConditionT>();
		}

		// Token: 0x06026ADD RID: 158429 RVA: 0x005537B0 File Offset: 0x005519B0
		public static ISpawnMonsterCompleteCondition_UnionUnion FromIAllKillCondition(IAllKillConditionT _iallkillcondition)
		{
			return new ISpawnMonsterCompleteCondition_UnionUnion
			{
				Type = ISpawnMonsterCompleteCondition_Union.IAllKillCondition,
				Value = _iallkillcondition
			};
		}

		// Token: 0x06026ADE RID: 158430 RVA: 0x005537C5 File Offset: 0x005519C5
		public IDurationConditionT AsIDurationCondition()
		{
			return this.As<IDurationConditionT>();
		}

		// Token: 0x06026ADF RID: 158431 RVA: 0x005537CD File Offset: 0x005519CD
		public static ISpawnMonsterCompleteCondition_UnionUnion FromIDurationCondition(IDurationConditionT _idurationcondition)
		{
			return new ISpawnMonsterCompleteCondition_UnionUnion
			{
				Type = ISpawnMonsterCompleteCondition_Union.IDurationCondition,
				Value = _idurationcondition
			};
		}

		// Token: 0x06026AE0 RID: 158432 RVA: 0x005537E2 File Offset: 0x005519E2
		public IQuantityRefillConditionT AsIQuantityRefillCondition()
		{
			return this.As<IQuantityRefillConditionT>();
		}

		// Token: 0x06026AE1 RID: 158433 RVA: 0x005537EA File Offset: 0x005519EA
		public static ISpawnMonsterCompleteCondition_UnionUnion FromIQuantityRefillCondition(IQuantityRefillConditionT _iquantityrefillcondition)
		{
			return new ISpawnMonsterCompleteCondition_UnionUnion
			{
				Type = ISpawnMonsterCompleteCondition_Union.IQuantityRefillCondition,
				Value = _iquantityrefillcondition
			};
		}

		// Token: 0x06026AE2 RID: 158434 RVA: 0x00553800 File Offset: 0x00551A00
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
