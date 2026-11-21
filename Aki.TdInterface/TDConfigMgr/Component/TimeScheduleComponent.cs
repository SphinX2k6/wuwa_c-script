using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000967 RID: 2407
	public class TimeScheduleComponent : IComponentBase
	{
		// Token: 0x060035BF RID: 13759 RVA: 0x00088DA4 File Offset: 0x00086FA4
		private TimeScheduleComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TimeScheduleComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TimeScheduleComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TimeScheduleComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x00088DDC File Offset: 0x00086FDC
		public static TimeScheduleComponent Create([Nullable(2)] TimeScheduleComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TimeScheduleComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x00088DEF File Offset: 0x00086FEF
		public static TimeScheduleComponent CreateFromSetValue([Nullable(2)] TimeScheduleComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TimeScheduleComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x00088E02 File Offset: 0x00087002
		public new TimeScheduleComponent_SetValue ToSetValue()
		{
			return new TimeScheduleComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				TimeScheduleConfigs = this.TimeScheduleConfigs
			};
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x060035C3 RID: 13763 RVA: 0x00088E30 File Offset: 0x00087030
		// (set) Token: 0x060035C4 RID: 13764 RVA: 0x00088E6A File Offset: 0x0008706A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				TimeScheduleComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x060035C5 RID: 13765 RVA: 0x00088E78 File Offset: 0x00087078
		// (set) Token: 0x060035C6 RID: 13766 RVA: 0x00088EA2 File Offset: 0x000870A2
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x060035C7 RID: 13767 RVA: 0x00088EB0 File Offset: 0x000870B0
		// (set) Token: 0x060035C8 RID: 13768 RVA: 0x00088F43 File Offset: 0x00087143
		public virtual List<ITimeScheduleConfig> TimeScheduleConfigs
		{
			get
			{
				if (this._TimeScheduleConfigsInited)
				{
					return this._TimeScheduleConfigsCache;
				}
				this._TimeScheduleConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<ITimeScheduleConfig> timeScheduleConfigs = this.FbInstance.TimeScheduleConfigs;
					if (timeScheduleConfigs != null)
					{
						this._TimeScheduleConfigsCache = new List<ITimeScheduleConfig>(timeScheduleConfigs.Count);
						for (int i = 0; i < timeScheduleConfigs.Count; i++)
						{
							this._TimeScheduleConfigsCache.Add(ITimeScheduleConfig.Create(timeScheduleConfigs[i]));
						}
					}
				}
				else
				{
					TimeScheduleComponent_SetValue pocoInterface = this.PocoInterface;
					this._TimeScheduleConfigsCache = ((pocoInterface != null) ? pocoInterface.TimeScheduleConfigs : null);
				}
				return this._TimeScheduleConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().TimeScheduleConfigs = value;
				this._TimeScheduleConfigsInited = false;
			}
		}

		// Token: 0x04002338 RID: 9016
		[Nullable(2)]
		protected new TimeScheduleComponent FbInstance;

		// Token: 0x04002339 RID: 9017
		[Nullable(2)]
		protected new TimeScheduleComponent_SetValue PocoInterface;

		// Token: 0x0400233A RID: 9018
		private List<ITimeScheduleConfig> _TimeScheduleConfigsCache;

		// Token: 0x0400233B RID: 9019
		private bool _TimeScheduleConfigsInited;
	}
}
