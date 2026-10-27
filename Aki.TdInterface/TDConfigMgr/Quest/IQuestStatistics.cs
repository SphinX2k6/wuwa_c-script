using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010BD RID: 4285
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestStatistics
	{
		// Token: 0x060060B2 RID: 24754 RVA: 0x000E9B04 File Offset: 0x000E7D04
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

		// Token: 0x060060B3 RID: 24755 RVA: 0x000E9B3C File Offset: 0x000E7D3C
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

		// Token: 0x060060B4 RID: 24756 RVA: 0x000E9B4F File Offset: 0x000E7D4F
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

		// Token: 0x060060B5 RID: 24757 RVA: 0x000E9B62 File Offset: 0x000E7D62
		public IQuestStatistics_SetValue ToSetValue()
		{
			return new IQuestStatistics_SetValue
			{
				StatisticsConfig = this.StatisticsConfig,
				CalculationOnTriggeringStatistics = this.CalculationOnTriggeringStatistics
			};
		}

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x060060B6 RID: 24758 RVA: 0x000E9B81 File Offset: 0x000E7D81
		// (set) Token: 0x060060B7 RID: 24759 RVA: 0x000E9BA8 File Offset: 0x000E7DA8
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

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x060060B8 RID: 24760 RVA: 0x000E9BB8 File Offset: 0x000E7DB8
		// (set) Token: 0x060060B9 RID: 24761 RVA: 0x000E9C4B File Offset: 0x000E7E4B
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ICommonCalculateVar> CalculationOnTriggeringStatistics
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().CalculationOnTriggeringStatistics = value;
				this._CalculationOnTriggeringStatisticsInited = false;
			}
		}

		// Token: 0x04003A40 RID: 14912
		[Nullable(2)]
		protected IQuestStatistics FbInstance;

		// Token: 0x04003A41 RID: 14913
		[Nullable(2)]
		protected IQuestStatistics_SetValue PocoInterface;

		// Token: 0x04003A42 RID: 14914
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ICommonCalculateVar> _CalculationOnTriggeringStatisticsCache;

		// Token: 0x04003A43 RID: 14915
		private bool _CalculationOnTriggeringStatisticsInited;
	}
}
