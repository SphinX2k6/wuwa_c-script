using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA9 RID: 23721
	public class TSpawnMonsterStartConditionUnion
	{
		// Token: 0x1700B24E RID: 45646
		// (get) Token: 0x060289D1 RID: 166353 RVA: 0x00594ED0 File Offset: 0x005930D0
		// (set) Token: 0x060289D2 RID: 166354 RVA: 0x00594ED8 File Offset: 0x005930D8
		public TSpawnMonsterStartCondition Type { get; set; }

		// Token: 0x1700B24F RID: 45647
		// (get) Token: 0x060289D3 RID: 166355 RVA: 0x00594EE1 File Offset: 0x005930E1
		// (set) Token: 0x060289D4 RID: 166356 RVA: 0x00594EE9 File Offset: 0x005930E9
		public object Value { get; set; }

		// Token: 0x060289D5 RID: 166357 RVA: 0x00594EF2 File Offset: 0x005930F2
		public TSpawnMonsterStartConditionUnion()
		{
			this.Type = TSpawnMonsterStartCondition.NONE;
			this.Value = null;
		}

		// Token: 0x060289D6 RID: 166358 RVA: 0x00594F08 File Offset: 0x00593108
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060289D7 RID: 166359 RVA: 0x00594F1A File Offset: 0x0059311A
		public IImmediateStartConditionT AsIImmediateStartCondition()
		{
			return this.As<IImmediateStartConditionT>();
		}

		// Token: 0x060289D8 RID: 166360 RVA: 0x00594F22 File Offset: 0x00593122
		public static TSpawnMonsterStartConditionUnion FromIImmediateStartCondition(IImmediateStartConditionT _iimmediatestartcondition)
		{
			return new TSpawnMonsterStartConditionUnion
			{
				Type = TSpawnMonsterStartCondition.IImmediateStartCondition,
				Value = _iimmediatestartcondition
			};
		}

		// Token: 0x060289D9 RID: 166361 RVA: 0x00594F37 File Offset: 0x00593137
		public ITriggerRangeStartConditionT AsITriggerRangeStartCondition()
		{
			return this.As<ITriggerRangeStartConditionT>();
		}

		// Token: 0x060289DA RID: 166362 RVA: 0x00594F3F File Offset: 0x0059313F
		public static TSpawnMonsterStartConditionUnion FromITriggerRangeStartCondition(ITriggerRangeStartConditionT _itriggerrangestartcondition)
		{
			return new TSpawnMonsterStartConditionUnion
			{
				Type = TSpawnMonsterStartCondition.ITriggerRangeStartCondition,
				Value = _itriggerrangestartcondition
			};
		}

		// Token: 0x060289DB RID: 166363 RVA: 0x00594F54 File Offset: 0x00593154
		public static int Pack(FlatBufferBuilder builder, TSpawnMonsterStartConditionUnion _o)
		{
			TSpawnMonsterStartCondition type = _o.Type;
			if (type == TSpawnMonsterStartCondition.IImmediateStartCondition)
			{
				return IImmediateStartCondition.Pack(builder, _o.AsIImmediateStartCondition()).Value;
			}
			if (type != TSpawnMonsterStartCondition.ITriggerRangeStartCondition)
			{
				return 0;
			}
			return ITriggerRangeStartCondition.Pack(builder, _o.AsITriggerRangeStartCondition()).Value;
		}
	}
}
