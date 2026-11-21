using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DB0 RID: 11696
	public class ISplineWayPoint
	{
		// Token: 0x0600FED3 RID: 65235 RVA: 0x0024BE33 File Offset: 0x0024A033
		public static ISplineWayPoint Create(ISplineWayPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineWayPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005021 RID: 20513
		// (get) Token: 0x0600FED4 RID: 65236 RVA: 0x0024BE52 File Offset: 0x0024A052
		public virtual int Spline
		{
			get
			{
				return this.Instance.Spline;
			}
		}

		// Token: 0x17005022 RID: 20514
		// (get) Token: 0x0600FED5 RID: 65237 RVA: 0x0024BE5F File Offset: 0x0024A05F
		public virtual int PointId
		{
			get
			{
				return this.Instance.PointId;
			}
		}

		// Token: 0x04008B1A RID: 35610
		private ISplineWayPoint Instance;
	}
}
