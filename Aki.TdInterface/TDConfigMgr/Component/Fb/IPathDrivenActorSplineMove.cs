using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F15 RID: 3861
	public class IPathDrivenActorSplineMove : IPathDrivenActorMoveBase
	{
		// Token: 0x060056D4 RID: 22228 RVA: 0x000D4F71 File Offset: 0x000D3171
		public static IPathDrivenActorSplineMove Create(IPathDrivenActorSplineMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathDrivenActorSplineMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x060056D5 RID: 22229 RVA: 0x000D4F90 File Offset: 0x000D3190
		public override EPathDrivenActorMoveType Type
		{
			get
			{
				return (EPathDrivenActorMoveType)this.Instance.Type;
			}
		}

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x060056D6 RID: 22230 RVA: 0x000D4FA0 File Offset: 0x000D31A0
		public virtual List<int> SplineEntityIds
		{
			get
			{
				if (this._SplineEntityIdsInited)
				{
					return this._SplineEntityIdsCache;
				}
				this._SplineEntityIdsInited = true;
				int splineEntityIdsLength = this.Instance.SplineEntityIdsLength;
				this._SplineEntityIdsCache = new List<int>(splineEntityIdsLength);
				for (int i = 0; i < splineEntityIdsLength; i++)
				{
					this._SplineEntityIdsCache.Add(this.Instance.SplineEntityIds(i));
				}
				return this._SplineEntityIdsCache;
			}
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x060056D7 RID: 22231 RVA: 0x000D5004 File Offset: 0x000D3204
		public virtual bool? IsRandomSpline
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsRandomSpline);
			}
		}

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x060056D8 RID: 22232 RVA: 0x000D503C File Offset: 0x000D323C
		public virtual bool? IsChainedSpline
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsChainedSpline);
			}
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x060056D9 RID: 22233 RVA: 0x000D5074 File Offset: 0x000D3274
		public virtual bool? IsLoop
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsLoop);
			}
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x060056DA RID: 22234 RVA: 0x000D50AC File Offset: 0x000D32AC
		public virtual bool? IsFollowSplineDir
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsFollowSplineDir);
			}
		}

		// Token: 0x040031D4 RID: 12756
		private IPathDrivenActorSplineMove Instance;

		// Token: 0x040031D5 RID: 12757
		private List<int> _SplineEntityIdsCache;

		// Token: 0x040031D6 RID: 12758
		private bool _SplineEntityIdsInited;
	}
}
