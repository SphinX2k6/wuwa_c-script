using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A09 RID: 10761
	public class TraceSpline : ActionParams
	{
		// Token: 0x0600EDDF RID: 60895 RVA: 0x0022F2A6 File Offset: 0x0022D4A6
		public static TraceSpline Create(ITraceSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TraceSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700467B RID: 18043
		// (get) Token: 0x0600EDE0 RID: 60896 RVA: 0x0022F2C5 File Offset: 0x0022D4C5
		public virtual string EffectPath
		{
			get
			{
				return this.Instance.EffectPath;
			}
		}

		// Token: 0x1700467C RID: 18044
		// (get) Token: 0x0600EDE1 RID: 60897 RVA: 0x0022F2D2 File Offset: 0x0022D4D2
		public virtual int Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x1700467D RID: 18045
		// (get) Token: 0x0600EDE2 RID: 60898 RVA: 0x0022F2DF File Offset: 0x0022D4DF
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x040082E5 RID: 33509
		private ITraceSpline Instance;
	}
}
