using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024BD RID: 9405
	public class TraceSpline : ActionParams
	{
		// Token: 0x0600CC78 RID: 52344 RVA: 0x001D1F8C File Offset: 0x001D018C
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

		// Token: 0x0600CC79 RID: 52345 RVA: 0x001D1FC4 File Offset: 0x001D01C4
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

		// Token: 0x0600CC7A RID: 52346 RVA: 0x001D1FD7 File Offset: 0x001D01D7
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

		// Token: 0x0600CC7B RID: 52347 RVA: 0x001D1FEA File Offset: 0x001D01EA
		public TraceSpline_SetValue ToSetValue()
		{
			return new TraceSpline_SetValue
			{
				EffectPath = this.EffectPath,
				Duration = this.Duration,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x17003D45 RID: 15685
		// (get) Token: 0x0600CC7C RID: 52348 RVA: 0x001D2015 File Offset: 0x001D0215
		// (set) Token: 0x0600CC7D RID: 52349 RVA: 0x001D2040 File Offset: 0x001D0240
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

		// Token: 0x17003D46 RID: 15686
		// (get) Token: 0x0600CC7E RID: 52350 RVA: 0x001D204E File Offset: 0x001D024E
		// (set) Token: 0x0600CC7F RID: 52351 RVA: 0x001D2079 File Offset: 0x001D0279
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

		// Token: 0x17003D47 RID: 15687
		// (get) Token: 0x0600CC80 RID: 52352 RVA: 0x001D2087 File Offset: 0x001D0287
		// (set) Token: 0x0600CC81 RID: 52353 RVA: 0x001D20B2 File Offset: 0x001D02B2
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

		// Token: 0x0400792B RID: 31019
		[Nullable(2)]
		protected new TraceSpline FbInstance;

		// Token: 0x0400792C RID: 31020
		[Nullable(2)]
		protected TraceSpline_SetValue PocoInterface;
	}
}
