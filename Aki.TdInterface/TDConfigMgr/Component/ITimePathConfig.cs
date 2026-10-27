using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000779 RID: 1913
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimePathConfig
	{
		// Token: 0x06002978 RID: 10616 RVA: 0x0006D6A0 File Offset: 0x0006B8A0
		private ITimePathConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimePathConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimePathConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimePathConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x0006D6D8 File Offset: 0x0006B8D8
		public static ITimePathConfig Create([Nullable(2)] ITimePathConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimePathConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x0006D6EB File Offset: 0x0006B8EB
		public static ITimePathConfig CreateFromSetValue([Nullable(2)] ITimePathConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimePathConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x0006D6FE File Offset: 0x0006B8FE
		public ITimePathConfig_SetValue ToSetValue()
		{
			return new ITimePathConfig_SetValue
			{
				TotalTime = this.TotalTime,
				TimePathCurve = this.TimePathCurve
			};
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x0600297C RID: 10620 RVA: 0x0006D71D File Offset: 0x0006B91D
		// (set) Token: 0x0600297D RID: 10621 RVA: 0x0006D74C File Offset: 0x0006B94C
		public virtual float TotalTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TotalTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TotalTime;
			}
			set
			{
				this.GetOrCreatePoco().TotalTime = value;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x0600297E RID: 10622 RVA: 0x0006D75A File Offset: 0x0006B95A
		// (set) Token: 0x0600297F RID: 10623 RVA: 0x0006D785 File Offset: 0x0006B985
		public virtual string TimePathCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimePathCurve;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TimePathCurve;
			}
			set
			{
				this.GetOrCreatePoco().TimePathCurve = value;
			}
		}

		// Token: 0x04001BCF RID: 7119
		[Nullable(2)]
		protected ITimePathConfig FbInstance;

		// Token: 0x04001BD0 RID: 7120
		[Nullable(2)]
		protected ITimePathConfig_SetValue PocoInterface;
	}
}
