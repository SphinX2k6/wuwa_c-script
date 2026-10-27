using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA6 RID: 23718
	public class TSpawnMonsterCompleteConditionUnion
	{
		// Token: 0x1700B24C RID: 45644
		// (get) Token: 0x060289C3 RID: 166339 RVA: 0x00594D86 File Offset: 0x00592F86
		// (set) Token: 0x060289C4 RID: 166340 RVA: 0x00594D8E File Offset: 0x00592F8E
		public TSpawnMonsterCompleteCondition Type { get; set; }

		// Token: 0x1700B24D RID: 45645
		// (get) Token: 0x060289C5 RID: 166341 RVA: 0x00594D97 File Offset: 0x00592F97
		// (set) Token: 0x060289C6 RID: 166342 RVA: 0x00594D9F File Offset: 0x00592F9F
		public object Value { get; set; }

		// Token: 0x060289C7 RID: 166343 RVA: 0x00594DA8 File Offset: 0x00592FA8
		public TSpawnMonsterCompleteConditionUnion()
		{
			this.Type = TSpawnMonsterCompleteCondition.NONE;
			this.Value = null;
		}

		// Token: 0x060289C8 RID: 166344 RVA: 0x00594DBE File Offset: 0x00592FBE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060289C9 RID: 166345 RVA: 0x00594DD0 File Offset: 0x00592FD0
		public IAllKillConditionT AsIAllKillCondition()
		{
			return this.As<IAllKillConditionT>();
		}

		// Token: 0x060289CA RID: 166346 RVA: 0x00594DD8 File Offset: 0x00592FD8
		public static TSpawnMonsterCompleteConditionUnion FromIAllKillCondition(IAllKillConditionT _iallkillcondition)
		{
			return new TSpawnMonsterCompleteConditionUnion
			{
				Type = TSpawnMonsterCompleteCondition.IAllKillCondition,
				Value = _iallkillcondition
			};
		}

		// Token: 0x060289CB RID: 166347 RVA: 0x00594DED File Offset: 0x00592FED
		public IDurationConditionT AsIDurationCondition()
		{
			return this.As<IDurationConditionT>();
		}

		// Token: 0x060289CC RID: 166348 RVA: 0x00594DF5 File Offset: 0x00592FF5
		public static TSpawnMonsterCompleteConditionUnion FromIDurationCondition(IDurationConditionT _idurationcondition)
		{
			return new TSpawnMonsterCompleteConditionUnion
			{
				Type = TSpawnMonsterCompleteCondition.IDurationCondition,
				Value = _idurationcondition
			};
		}

		// Token: 0x060289CD RID: 166349 RVA: 0x00594E0A File Offset: 0x0059300A
		public IQuantityRefillConditionT AsIQuantityRefillCondition()
		{
			return this.As<IQuantityRefillConditionT>();
		}

		// Token: 0x060289CE RID: 166350 RVA: 0x00594E12 File Offset: 0x00593012
		public static TSpawnMonsterCompleteConditionUnion FromIQuantityRefillCondition(IQuantityRefillConditionT _iquantityrefillcondition)
		{
			return new TSpawnMonsterCompleteConditionUnion
			{
				Type = TSpawnMonsterCompleteCondition.IQuantityRefillCondition,
				Value = _iquantityrefillcondition
			};
		}

		// Token: 0x060289CF RID: 166351 RVA: 0x00594E28 File Offset: 0x00593028
		public static int Pack(FlatBufferBuilder builder, TSpawnMonsterCompleteConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TSpawnMonsterCompleteCondition.IAllKillCondition:
				return IAllKillCondition.Pack(builder, _o.AsIAllKillCondition()).Value;
			case TSpawnMonsterCompleteCondition.IDurationCondition:
				return IDurationCondition.Pack(builder, _o.AsIDurationCondition()).Value;
			case TSpawnMonsterCompleteCondition.IQuantityRefillCondition:
				return IQuantityRefillCondition.Pack(builder, _o.AsIQuantityRefillCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
