using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014A6 RID: 5286
	public class IQuestStatistics
	{
		// Token: 0x060077FD RID: 30717 RVA: 0x0011F950 File Offset: 0x0011DB50
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

		// Token: 0x17002653 RID: 9811
		// (get) Token: 0x060077FE RID: 30718 RVA: 0x0011F96F File Offset: 0x0011DB6F
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

		// Token: 0x17002654 RID: 9812
		// (get) Token: 0x060077FF RID: 30719 RVA: 0x0011F9A0 File Offset: 0x0011DBA0
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ICommonCalculateVar> CalculationOnTriggeringStatistics
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x040044F4 RID: 17652
		private IQuestStatistics Instance;

		// Token: 0x040044F5 RID: 17653
		private List<IQuestStatisticsType> _StatisticsConfigCache;

		// Token: 0x040044F6 RID: 17654
		private bool _StatisticsConfigInited;

		// Token: 0x040044F7 RID: 17655
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ICommonCalculateVar> _CalculationOnTriggeringStatisticsCache;

		// Token: 0x040044F8 RID: 17656
		private bool _CalculationOnTriggeringStatisticsInited;
	}
}
