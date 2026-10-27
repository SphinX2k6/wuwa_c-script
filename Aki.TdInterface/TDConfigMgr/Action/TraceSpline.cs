using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002250 RID: 8784
	[NullableContext(1)]
	[Nullable(0)]
	public class TraceSpline : ActionParams
	{
		// Token: 0x0600C0B2 RID: 49330 RVA: 0x001BA808 File Offset: 0x001B8A08
		private TraceSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TraceSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TraceSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TraceSpline_SetValue());
			}
			return result;
		}

		// Token: 0x0600C0B3 RID: 49331 RVA: 0x001BA840 File Offset: 0x001B8A40
		public static TraceSpline Create([Nullable(2)] TraceSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TraceSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C0B4 RID: 49332 RVA: 0x001BA853 File Offset: 0x001B8A53
		public static TraceSpline CreateFromSetValue([Nullable(2)] TraceSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TraceSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C0B5 RID: 49333 RVA: 0x001BA866 File Offset: 0x001B8A66
		public TraceSpline_SetValue ToSetValue()
		{
			return new TraceSpline_SetValue
			{
				EffectPath = this.EffectPath,
				Duration = this.Duration,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x17003A4E RID: 14926
		// (get) Token: 0x0600C0B6 RID: 49334 RVA: 0x001BA891 File Offset: 0x001B8A91
		// (set) Token: 0x0600C0B7 RID: 49335 RVA: 0x001BA8BC File Offset: 0x001B8ABC
		public virtual string EffectPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EffectPath;
			}
			set
			{
				this.GetOrCreatePoco().EffectPath = value;
			}
		}

		// Token: 0x17003A4F RID: 14927
		// (get) Token: 0x0600C0B8 RID: 49336 RVA: 0x001BA8CA File Offset: 0x001B8ACA
		// (set) Token: 0x0600C0B9 RID: 49337 RVA: 0x001BA8F5 File Offset: 0x001B8AF5
		public virtual int Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x17003A50 RID: 14928
		// (get) Token: 0x0600C0BA RID: 49338 RVA: 0x001BA903 File Offset: 0x001B8B03
		// (set) Token: 0x0600C0BB RID: 49339 RVA: 0x001BA92E File Offset: 0x001B8B2E
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x040072DE RID: 29406
		[Nullable(2)]
		protected new TraceSpline FbInstance;

		// Token: 0x040072DF RID: 29407
		[Nullable(2)]
		protected TraceSpline_SetValue PocoInterface;
	}
}
