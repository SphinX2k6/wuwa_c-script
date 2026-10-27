using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042FA RID: 17146
	public class TQuestPlayerHitStatisticsUnion
	{
		// Token: 0x1700795E RID: 31070
		// (get) Token: 0x060196D1 RID: 104145 RVA: 0x003A5396 File Offset: 0x003A3596
		// (set) Token: 0x060196D2 RID: 104146 RVA: 0x003A539E File Offset: 0x003A359E
		public TQuestPlayerHitStatistics Type { get; set; }

		// Token: 0x1700795F RID: 31071
		// (get) Token: 0x060196D3 RID: 104147 RVA: 0x003A53A7 File Offset: 0x003A35A7
		// (set) Token: 0x060196D4 RID: 104148 RVA: 0x003A53AF File Offset: 0x003A35AF
		public object Value { get; set; }

		// Token: 0x060196D5 RID: 104149 RVA: 0x003A53B8 File Offset: 0x003A35B8
		public TQuestPlayerHitStatisticsUnion()
		{
			this.Type = TQuestPlayerHitStatistics.NONE;
			this.Value = null;
		}

		// Token: 0x060196D6 RID: 104150 RVA: 0x003A53CE File Offset: 0x003A35CE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060196D7 RID: 104151 RVA: 0x003A53E0 File Offset: 0x003A35E0
		public IQuestPlayerBeDamageT AsIQuestPlayerBeDamage()
		{
			return this.As<IQuestPlayerBeDamageT>();
		}

		// Token: 0x060196D8 RID: 104152 RVA: 0x003A53E8 File Offset: 0x003A35E8
		public static TQuestPlayerHitStatisticsUnion FromIQuestPlayerBeDamage(IQuestPlayerBeDamageT _iquestplayerbedamage)
		{
			return new TQuestPlayerHitStatisticsUnion
			{
				Type = TQuestPlayerHitStatistics.IQuestPlayerBeDamage,
				Value = _iquestplayerbedamage
			};
		}

		// Token: 0x060196D9 RID: 104153 RVA: 0x003A53FD File Offset: 0x003A35FD
		public IQuestPlayerHitCountT AsIQuestPlayerHitCount()
		{
			return this.As<IQuestPlayerHitCountT>();
		}

		// Token: 0x060196DA RID: 104154 RVA: 0x003A5405 File Offset: 0x003A3605
		public static TQuestPlayerHitStatisticsUnion FromIQuestPlayerHitCount(IQuestPlayerHitCountT _iquestplayerhitcount)
		{
			return new TQuestPlayerHitStatisticsUnion
			{
				Type = TQuestPlayerHitStatistics.IQuestPlayerHitCount,
				Value = _iquestplayerhitcount
			};
		}

		// Token: 0x060196DB RID: 104155 RVA: 0x003A541C File Offset: 0x003A361C
		public static int Pack(FlatBufferBuilder builder, TQuestPlayerHitStatisticsUnion _o)
		{
			TQuestPlayerHitStatistics type = _o.Type;
			if (type == TQuestPlayerHitStatistics.IQuestPlayerBeDamage)
			{
				return IQuestPlayerBeDamage.Pack(builder, _o.AsIQuestPlayerBeDamage()).Value;
			}
			if (type != TQuestPlayerHitStatistics.IQuestPlayerHitCount)
			{
				return 0;
			}
			return IQuestPlayerHitCount.Pack(builder, _o.AsIQuestPlayerHitCount()).Value;
		}
	}
}
