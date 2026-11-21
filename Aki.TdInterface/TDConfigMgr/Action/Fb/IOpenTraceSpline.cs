using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A07 RID: 10759
	public class IOpenTraceSpline : ToggleScanSplineEffect
	{
		// Token: 0x0600EDD6 RID: 60886 RVA: 0x0022F217 File Offset: 0x0022D417
		public static IOpenTraceSpline Create(IOpenTraceSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenTraceSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004676 RID: 18038
		// (get) Token: 0x0600EDD7 RID: 60887 RVA: 0x0022F236 File Offset: 0x0022D436
		public override ETraceSplineOptionType Type
		{
			get
			{
				return (ETraceSplineOptionType)this.Instance.Type;
			}
		}

		// Token: 0x17004677 RID: 18039
		// (get) Token: 0x0600EDD8 RID: 60888 RVA: 0x0022F243 File Offset: 0x0022D443
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17004678 RID: 18040
		// (get) Token: 0x0600EDD9 RID: 60889 RVA: 0x0022F250 File Offset: 0x0022D450
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x040082E3 RID: 33507
		private IOpenTraceSpline Instance;
	}
}
