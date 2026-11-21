using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A00 RID: 10752
	public class IPlayerNewSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x0600EDB9 RID: 60857 RVA: 0x0022EF1D File Offset: 0x0022D11D
		public static IPlayerNewSplineStopTarget Create(IPlayerNewSplineStopTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerNewSplineStopTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004667 RID: 18023
		// (get) Token: 0x0600EDBA RID: 60858 RVA: 0x0022EF3C File Offset: 0x0022D13C
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x040082CE RID: 33486
		private IPlayerNewSplineStopTarget Instance;
	}
}
