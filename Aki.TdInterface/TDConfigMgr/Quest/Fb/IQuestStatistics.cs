using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001356 RID: 4950
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestStatistics
	{
		// Token: 0x0600715D RID: 29021 RVA: 0x001113E4 File Offset: 0x0010F5E4
		public static IQuestStatistics Create(IQuestStatistics? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestStatistics
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x0600715E RID: 29022 RVA: 0x00111403 File Offset: 0x0010F603
		public virtual List<IQuestStatisticsType> StatisticsConfig
		{
			get
			{
				if (this._StatisticsConfigInited)
				{
					return this._StatisticsConfigCache;
				}
				this._StatisticsConfigInited = true;
				this._StatisticsConfigCache = QuestReadHelper.ReadIQuestStatistics_StatisticsConfig(this.Instance);
				return this._StatisticsConfigCache;
			}
		}

		// Token: 0x17002485 RID: 9349
		// (get) Token: 0x0600715F RID: 29023 RVA: 0x00111434 File Offset: 0x0010F634
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ICommonCalculateVar> CalculationOnTriggeringStatistics
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._CalculationOnTriggeringStatisticsInited)
				{
					return this._CalculationOnTriggeringStatisticsCache;
				}
				this._CalculationOnTriggeringStatisticsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int calculationOnTriggeringStatisticsLength = this.Instance.CalculationOnTriggeringStatisticsLength;
				this._CalculationOnTriggeringStatisticsCache = new List<ICommonCalculateVar>(calculationOnTriggeringStatisticsLength);
				for (int i = 0; i < calculationOnTriggeringStatisticsLength; i++)
				{
					this._CalculationOnTriggeringStatisticsCache.Add(ICommonCalculateVar.Create(this.Instance.CalculationOnTriggeringStatistics(i)));
				}
				return this._CalculationOnTriggeringStatisticsCache;
			}
		}

		// Token: 0x04004178 RID: 16760
		private IQuestStatistics Instance;

		// Token: 0x04004179 RID: 16761
		private List<IQuestStatisticsType> _StatisticsConfigCache;

		// Token: 0x0400417A RID: 16762
		private bool _StatisticsConfigInited;

		// Token: 0x0400417B RID: 16763
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICommonCalculateVar> _CalculationOnTriggeringStatisticsCache;

		// Token: 0x0400417C RID: 16764
		private bool _CalculationOnTriggeringStatisticsInited;
	}
}
