using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A08 RID: 10760
	public class ICloseTraceSpline : ToggleScanSplineEffect
	{
		// Token: 0x0600EDDB RID: 60891 RVA: 0x0022F265 File Offset: 0x0022D465
		public static ICloseTraceSpline Create(ICloseTraceSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseTraceSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004679 RID: 18041
		// (get) Token: 0x0600EDDC RID: 60892 RVA: 0x0022F284 File Offset: 0x0022D484
		public override ETraceSplineOptionType Type
		{
			get
			{
				return (ETraceSplineOptionType)this.Instance.Type;
			}
		}

		// Token: 0x1700467A RID: 18042
		// (get) Token: 0x0600EDDD RID: 60893 RVA: 0x0022F291 File Offset: 0x0022D491
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x040082E4 RID: 33508
		private ICloseTraceSpline Instance;
	}
}
