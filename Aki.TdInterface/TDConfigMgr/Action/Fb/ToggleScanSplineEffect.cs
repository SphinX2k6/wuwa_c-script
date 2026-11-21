using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A06 RID: 10758
	public class ToggleScanSplineEffect : ActionParams
	{
		// Token: 0x0600EDD3 RID: 60883 RVA: 0x0022F1E3 File Offset: 0x0022D3E3
		public static ToggleScanSplineEffect Create(IToggleScanSplineEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleScanSplineEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004675 RID: 18037
		// (get) Token: 0x0600EDD4 RID: 60884 RVA: 0x0022F202 File Offset: 0x0022D402
		public virtual ETraceSplineOptionType Type
		{
			get
			{
				return (ETraceSplineOptionType)this.Instance.Type;
			}
		}

		// Token: 0x040082E2 RID: 33506
		private IToggleScanSplineEffect Instance;
	}
}
