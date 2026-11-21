using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000830 RID: 2096
	public class ITimeScheduleRefreshInterval
	{
		// Token: 0x06002D1A RID: 11546 RVA: 0x00075920 File Offset: 0x00073B20
		private ITimeScheduleRefreshInterval_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScheduleRefreshInterval 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScheduleRefreshInterval_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScheduleRefreshInterval_SetValue());
			}
			return result;
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x00075958 File Offset: 0x00073B58
		public static ITimeScheduleRefreshInterval Create([Nullable(2)] ITimeScheduleRefreshInterval instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleRefreshInterval
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x0007596B File Offset: 0x00073B6B
		public static ITimeScheduleRefreshInterval CreateFromSetValue([Nullable(2)] ITimeScheduleRefreshInterval_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScheduleRefreshInterval
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x0007597E File Offset: 0x00073B7E
		public ITimeScheduleRefreshInterval_SetValue ToSetValue()
		{
			return new ITimeScheduleRefreshInterval_SetValue
			{
				MaxInterval = this.MaxInterval,
				MinInterval = this.MinInterval
			};
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06002D1E RID: 11550 RVA: 0x0007599D File Offset: 0x00073B9D
		// (set) Token: 0x06002D1F RID: 11551 RVA: 0x000759CC File Offset: 0x00073BCC
		public virtual float MaxInterval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxInterval;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxInterval;
			}
			set
			{
				this.GetOrCreatePoco().MaxInterval = value;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002D20 RID: 11552 RVA: 0x000759DA File Offset: 0x00073BDA
		// (set) Token: 0x06002D21 RID: 11553 RVA: 0x00075A09 File Offset: 0x00073C09
		public virtual float MinInterval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinInterval;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MinInterval;
			}
			set
			{
				this.GetOrCreatePoco().MinInterval = value;
			}
		}

		// Token: 0x04001E22 RID: 7714
		[Nullable(2)]
		protected ITimeScheduleRefreshInterval FbInstance;

		// Token: 0x04001E23 RID: 7715
		[Nullable(2)]
		protected ITimeScheduleRefreshInterval_SetValue PocoInterface;
	}
}
