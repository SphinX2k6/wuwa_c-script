using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F7 RID: 10743
	public class NewMoveWithSpline : ActionParams
	{
		// Token: 0x0600ED95 RID: 60821 RVA: 0x0022EBDF File Offset: 0x0022CDDF
		public static NewMoveWithSpline Create(INewMoveWithSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new NewMoveWithSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004655 RID: 18005
		// (get) Token: 0x0600ED96 RID: 60822 RVA: 0x0022EBFE File Offset: 0x0022CDFE
		public virtual INewSplineMoveTarget MoveTarget
		{
			get
			{
				if (this._MoveTargetInited)
				{
					return this._MoveTargetCache;
				}
				this._MoveTargetInited = true;
				this._MoveTargetCache = ActionReadHelper.ReadNewMoveWithSpline_MoveTarget(this.Instance);
				return this._MoveTargetCache;
			}
		}

		// Token: 0x17004656 RID: 18006
		// (get) Token: 0x0600ED97 RID: 60823 RVA: 0x0022EC2D File Offset: 0x0022CE2D
		[Nullable(2)]
		public virtual IFrontAxleTrackingSplineMove Move
		{
			[NullableContext(2)]
			get
			{
				if (this._MoveInited)
				{
					return this._MoveCache;
				}
				this._MoveInited = true;
				this._MoveCache = IFrontAxleTrackingSplineMove.Create(this.Instance.Move);
				return this._MoveCache;
			}
		}

		// Token: 0x17004657 RID: 18007
		// (get) Token: 0x0600ED98 RID: 60824 RVA: 0x0022EC61 File Offset: 0x0022CE61
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17004658 RID: 18008
		// (get) Token: 0x0600ED99 RID: 60825 RVA: 0x0022EC70 File Offset: 0x0022CE70
		public virtual int? StartPointIndex
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.StartPointIndex);
			}
		}

		// Token: 0x17004659 RID: 18009
		// (get) Token: 0x0600ED9A RID: 60826 RVA: 0x0022ECA8 File Offset: 0x0022CEA8
		public virtual int? EndPointIndex
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.EndPointIndex);
			}
		}

		// Token: 0x1700465A RID: 18010
		// (get) Token: 0x0600ED9B RID: 60827 RVA: 0x0022ECE0 File Offset: 0x0022CEE0
		public virtual bool? IsStartFromCurrentPos
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsStartFromCurrentPos);
			}
		}

		// Token: 0x1700465B RID: 18011
		// (get) Token: 0x0600ED9C RID: 60828 RVA: 0x0022ED18 File Offset: 0x0022CF18
		public virtual bool? IsFollowStrictly
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsFollowStrictly);
			}
		}

		// Token: 0x040082C1 RID: 33473
		private INewMoveWithSpline Instance;

		// Token: 0x040082C2 RID: 33474
		private INewSplineMoveTarget _MoveTargetCache;

		// Token: 0x040082C3 RID: 33475
		private bool _MoveTargetInited;

		// Token: 0x040082C4 RID: 33476
		[Nullable(2)]
		private IFrontAxleTrackingSplineMove _MoveCache;

		// Token: 0x040082C5 RID: 33477
		private bool _MoveInited;
	}
}
