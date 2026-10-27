using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ABC RID: 10940
	public class ISplineWayPoint
	{
		// Token: 0x0600F01D RID: 61469 RVA: 0x0022E127 File Offset: 0x0022C327
		[NullableContext(1)]
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

		// Token: 0x17004C67 RID: 19559
		// (get) Token: 0x0600F01E RID: 61470 RVA: 0x0022E146 File Offset: 0x0022C346
		public virtual int Spline
		{
			get
			{
				return this.Instance.Spline;
			}
		}

		// Token: 0x17004C68 RID: 19560
		// (get) Token: 0x0600F01F RID: 61471 RVA: 0x0022E153 File Offset: 0x0022C353
		public virtual int PointId
		{
			get
			{
				return this.Instance.PointId;
			}
		}

		// Token: 0x04008416 RID: 33814
		private ISplineWayPoint Instance;
	}
}
