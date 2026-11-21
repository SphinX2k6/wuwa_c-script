using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011EB RID: 4587
	public class IQuestStatistics
	{
		// Token: 0x060066AB RID: 26283 RVA: 0x000F6C24 File Offset: 0x000F4E24
		private IQuestStatistics_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestStatistics 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestStatistics_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestStatistics_SetValue());
			}
			return result;
		}

		// Token: 0x060066AC RID: 26284 RVA: 0x000F6C5C File Offset: 0x000F4E5C
		public static IQuestStatistics Create([Nullable(2)] IQuestStatistics instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestStatistics
			{
				FbInstance = instance
			};
		}

		// Token: 0x060066AD RID: 26285 RVA: 0x000F6C6F File Offset: 0x000F4E6F
		public static IQuestStatistics CreateFromSetValue([Nullable(2)] IQuestStatistics_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestStatistics
			{
				PocoInterface = value
			};
		}

		// Token: 0x060066AE RID: 26286 RVA: 0x000F6C82 File Offset: 0x000F4E82
		public IQuestStatistics_SetValue ToSetValue()
		{
			return new IQuestStatistics_SetValue
			{
				StatisticsConfig = this.StatisticsConfig,
				CalculationOnTriggeringStatistics = this.CalculationOnTriggeringStatistics
			};
		}

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x060066AF RID: 26287 RVA: 0x000F6CA1 File Offset: 0x000F4EA1
		// (set) Token: 0x060066B0 RID: 26288 RVA: 0x000F6CC8 File Offset: 0x000F4EC8
		public virtual List<IQuestStatisticsType> StatisticsConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StatisticsConfig;
				}
				IQuestStatistics_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StatisticsConfig;
			}
			set
			{
				this.GetOrCreatePoco().StatisticsConfig = value;
			}
		}

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x060066B1 RID: 26289 RVA: 0x000F6CD8 File Offset: 0x000F4ED8
		// (set) Token: 0x060066B2 RID: 26290 RVA: 0x000F6D6B File Offset: 0x000F4F6B
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ICommonCalculateVar> CalculationOnTriggeringStatistics
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
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ICommonCalculateVar> calculationOnTriggeringStatistics = this.FbInstance.CalculationOnTriggeringStatistics;
					if (calculationOnTriggeringStatistics != null)
					{
						this._CalculationOnTriggeringStatisticsCache = new List<Aki.TDConfigMgr.Action.ICommonCalculateVar>(calculationOnTriggeringStatistics.Count);
						for (int i = 0; i < calculationOnTriggeringStatistics.Count; i++)
						{
							this._CalculationOnTriggeringStatisticsCache.Add(Aki.TDConfigMgr.Action.ICommonCalculateVar.Create(calculationOnTriggeringStatistics[i]));
						}
					}
				}
				else
				{
					IQuestStatistics_SetValue pocoInterface = this.PocoInterface;
					this._CalculationOnTriggeringStatisticsCache = ((pocoInterface != null) ? pocoInterface.CalculationOnTriggeringStatistics : null);
				}
				return this._CalculationOnTriggeringStatisticsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().CalculationOnTriggeringStatistics = value;
				this._CalculationOnTriggeringStatisticsInited = false;
			}
		}

		// Token: 0x04003D8D RID: 15757
		[Nullable(2)]
		protected IQuestStatistics FbInstance;

		// Token: 0x04003D8E RID: 15758
		[Nullable(2)]
		protected IQuestStatistics_SetValue PocoInterface;

		// Token: 0x04003D8F RID: 15759
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ICommonCalculateVar> _CalculationOnTriggeringStatisticsCache;

		// Token: 0x04003D90 RID: 15760
		private bool _CalculationOnTriggeringStatisticsInited;
	}
}
