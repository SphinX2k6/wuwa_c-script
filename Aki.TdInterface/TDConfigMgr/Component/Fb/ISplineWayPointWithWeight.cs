using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C5A RID: 3162
	public class ISplineWayPointWithWeight : ISplineWayPoint
	{
		// Token: 0x0600486E RID: 18542 RVA: 0x000B6049 File Offset: 0x000B4249
		[NullableContext(1)]
		public static ISplineWayPointWithWeight Create(ISplineWayPointWithWeight? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineWayPointWithWeight
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x0600486F RID: 18543 RVA: 0x000B6068 File Offset: 0x000B4268
		public override int Spline
		{
			get
			{
				return this.Instance.Spline;
			}
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x06004870 RID: 18544 RVA: 0x000B6075 File Offset: 0x000B4275
		public override int PointId
		{
			get
			{
				return this.Instance.PointId;
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06004871 RID: 18545 RVA: 0x000B6082 File Offset: 0x000B4282
		public virtual int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x04002945 RID: 10565
		private ISplineWayPointWithWeight Instance;
	}
}
