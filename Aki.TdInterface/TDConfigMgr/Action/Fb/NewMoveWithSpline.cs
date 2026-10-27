using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200272B RID: 10027
	[NullableContext(1)]
	[Nullable(0)]
	public class NewMoveWithSpline : ActionParams
	{
		// Token: 0x0600DF96 RID: 57238 RVA: 0x002120DA File Offset: 0x002102DA
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

		// Token: 0x17004302 RID: 17154
		// (get) Token: 0x0600DF97 RID: 57239 RVA: 0x002120F9 File Offset: 0x002102F9
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

		// Token: 0x17004303 RID: 17155
		// (get) Token: 0x0600DF98 RID: 57240 RVA: 0x00212128 File Offset: 0x00210328
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17004304 RID: 17156
		// (get) Token: 0x0600DF99 RID: 57241 RVA: 0x00212138 File Offset: 0x00210338
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

		// Token: 0x17004305 RID: 17157
		// (get) Token: 0x0600DF9A RID: 57242 RVA: 0x00212170 File Offset: 0x00210370
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

		// Token: 0x17004306 RID: 17158
		// (get) Token: 0x0600DF9B RID: 57243 RVA: 0x002121A8 File Offset: 0x002103A8
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

		// Token: 0x17004307 RID: 17159
		// (get) Token: 0x0600DF9C RID: 57244 RVA: 0x002121E0 File Offset: 0x002103E0
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

		// Token: 0x04007C15 RID: 31765
		private INewMoveWithSpline Instance;

		// Token: 0x04007C16 RID: 31766
		private INewSplineMoveTarget _MoveTargetCache;

		// Token: 0x04007C17 RID: 31767
		private bool _MoveTargetInited;
	}
}
