using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E19 RID: 3609
	[NullableContext(1)]
	[Nullable(0)]
	public class IPathDrivenActorSplineMove : IPathDrivenActorMoveBase
	{
		// Token: 0x060051AD RID: 20909 RVA: 0x000C96A9 File Offset: 0x000C78A9
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

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x060051AE RID: 20910 RVA: 0x000C96C8 File Offset: 0x000C78C8
		public override EPathDrivenActorMoveType Type
		{
			get
			{
				return (EPathDrivenActorMoveType)this.Instance.Type;
			}
		}

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x060051AF RID: 20911 RVA: 0x000C96D8 File Offset: 0x000C78D8
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

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x060051B0 RID: 20912 RVA: 0x000C973C File Offset: 0x000C793C
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

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x060051B1 RID: 20913 RVA: 0x000C9774 File Offset: 0x000C7974
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

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x060051B2 RID: 20914 RVA: 0x000C97AC File Offset: 0x000C79AC
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

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x060051B3 RID: 20915 RVA: 0x000C97E4 File Offset: 0x000C79E4
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

		// Token: 0x04002F0C RID: 12044
		private IPathDrivenActorSplineMove Instance;

		// Token: 0x04002F0D RID: 12045
		private List<int> _SplineEntityIdsCache;

		// Token: 0x04002F0E RID: 12046
		private bool _SplineEntityIdsInited;
	}
}
