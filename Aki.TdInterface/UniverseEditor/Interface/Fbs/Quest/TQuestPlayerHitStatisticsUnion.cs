using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004759 RID: 18265
	public class TQuestPlayerHitStatisticsUnion
	{
		// Token: 0x17007F91 RID: 32657
		// (get) Token: 0x0601AE53 RID: 110163 RVA: 0x003D0CC6 File Offset: 0x003CEEC6
		// (set) Token: 0x0601AE54 RID: 110164 RVA: 0x003D0CCE File Offset: 0x003CEECE
		public TQuestPlayerHitStatistics Type { get; set; }

		// Token: 0x17007F92 RID: 32658
		// (get) Token: 0x0601AE55 RID: 110165 RVA: 0x003D0CD7 File Offset: 0x003CEED7
		// (set) Token: 0x0601AE56 RID: 110166 RVA: 0x003D0CDF File Offset: 0x003CEEDF
		public object Value { get; set; }

		// Token: 0x0601AE57 RID: 110167 RVA: 0x003D0CE8 File Offset: 0x003CEEE8
		public TQuestPlayerHitStatisticsUnion()
		{
			this.Type = TQuestPlayerHitStatistics.NONE;
			this.Value = null;
		}

		// Token: 0x0601AE58 RID: 110168 RVA: 0x003D0CFE File Offset: 0x003CEEFE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AE59 RID: 110169 RVA: 0x003D0D10 File Offset: 0x003CEF10
		public IQuestPlayerBeDamageT AsIQuestPlayerBeDamage()
		{
			return this.As<IQuestPlayerBeDamageT>();
		}

		// Token: 0x0601AE5A RID: 110170 RVA: 0x003D0D18 File Offset: 0x003CEF18
		public static TQuestPlayerHitStatisticsUnion FromIQuestPlayerBeDamage(IQuestPlayerBeDamageT _iquestplayerbedamage)
		{
			return new TQuestPlayerHitStatisticsUnion
			{
				Type = TQuestPlayerHitStatistics.IQuestPlayerBeDamage,
				Value = _iquestplayerbedamage
			};
		}

		// Token: 0x0601AE5B RID: 110171 RVA: 0x003D0D2D File Offset: 0x003CEF2D
		public IQuestPlayerHitCountT AsIQuestPlayerHitCount()
		{
			return this.As<IQuestPlayerHitCountT>();
		}

		// Token: 0x0601AE5C RID: 110172 RVA: 0x003D0D35 File Offset: 0x003CEF35
		public static TQuestPlayerHitStatisticsUnion FromIQuestPlayerHitCount(IQuestPlayerHitCountT _iquestplayerhitcount)
		{
			return new TQuestPlayerHitStatisticsUnion
			{
				Type = TQuestPlayerHitStatistics.IQuestPlayerHitCount,
				Value = _iquestplayerhitcount
			};
		}

		// Token: 0x0601AE5D RID: 110173 RVA: 0x003D0D4C File Offset: 0x003CEF4C
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
