using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029FD RID: 10749
	public class INewSplineStopTarget
	{
		// Token: 0x0600EDAE RID: 60846 RVA: 0x0022EE67 File Offset: 0x0022D067
		public static INewSplineStopTarget Create(INewSplineStopTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewSplineStopTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004662 RID: 18018
		// (get) Token: 0x0600EDAF RID: 60847 RVA: 0x0022EE86 File Offset: 0x0022D086
		public virtual ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x040082CB RID: 33483
		private INewSplineStopTarget Instance;
	}
}
