using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029EF RID: 10735
	[NullableContext(2)]
	[Nullable(0)]
	public class MoveWithSpline : ActionParams
	{
		// Token: 0x0600ED6C RID: 60780 RVA: 0x0022E723 File Offset: 0x0022C923
		[NullableContext(0)]
		public static MoveWithSpline Create(IMoveWithSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MoveWithSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700463C RID: 17980
		// (get) Token: 0x0600ED6D RID: 60781 RVA: 0x0022E742 File Offset: 0x0022C942
		[Nullable(0)]
		public virtual ISplineMoveTargetType MoveTarget
		{
			[NullableContext(0)]
			get
			{
				if (this._MoveTargetInited)
				{
					return this._MoveTargetCache;
				}
				this._MoveTargetInited = true;
				this._MoveTargetCache = ActionReadHelper.ReadMoveWithSpline_MoveTarget(this.Instance);
				return this._MoveTargetCache;
			}
		}

		// Token: 0x1700463D RID: 17981
		// (get) Token: 0x0600ED6E RID: 60782 RVA: 0x0022E771 File Offset: 0x0022C971
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x1700463E RID: 17982
		// (get) Token: 0x0600ED6F RID: 60783 RVA: 0x0022E77E File Offset: 0x0022C97E
		public virtual ICheckClimb CheckClimb
		{
			get
			{
				if (this._CheckClimbInited)
				{
					return this._CheckClimbCache;
				}
				this._CheckClimbInited = true;
				this._CheckClimbCache = ICheckClimb.Create(this.Instance.CheckClimb);
				return this._CheckClimbCache;
			}
		}

		// Token: 0x1700463F RID: 17983
		// (get) Token: 0x0600ED70 RID: 60784 RVA: 0x0022E7B2 File Offset: 0x0022C9B2
		public virtual IMoveOnWallConfig MoveOnWallConfig
		{
			get
			{
				if (this._MoveOnWallConfigInited)
				{
					return this._MoveOnWallConfigCache;
				}
				this._MoveOnWallConfigInited = true;
				this._MoveOnWallConfigCache = IMoveOnWallConfig.Create(this.Instance.MoveOnWallConfig);
				return this._MoveOnWallConfigCache;
			}
		}

		// Token: 0x17004640 RID: 17984
		// (get) Token: 0x0600ED71 RID: 60785 RVA: 0x0022E7E8 File Offset: 0x0022C9E8
		public virtual EMoveSpeed? MoveState
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EMoveSpeed?((EMoveSpeed)this.Instance.MoveState);
			}
		}

		// Token: 0x17004641 RID: 17985
		// (get) Token: 0x0600ED72 RID: 60786 RVA: 0x0022E820 File Offset: 0x0022CA20
		public virtual int? StartPointIndex
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.StartPointIndex);
			}
		}

		// Token: 0x17004642 RID: 17986
		// (get) Token: 0x0600ED73 RID: 60787 RVA: 0x0022E858 File Offset: 0x0022CA58
		public virtual int? EndPointIndex
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.EndPointIndex);
			}
		}

		// Token: 0x17004643 RID: 17987
		// (get) Token: 0x0600ED74 RID: 60788 RVA: 0x0022E890 File Offset: 0x0022CA90
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

		// Token: 0x17004644 RID: 17988
		// (get) Token: 0x0600ED75 RID: 60789 RVA: 0x0022E8C8 File Offset: 0x0022CAC8
		public virtual bool? IsForceToFirstPoint
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsForceToFirstPoint);
			}
		}

		// Token: 0x17004645 RID: 17989
		// (get) Token: 0x0600ED76 RID: 60790 RVA: 0x0022E900 File Offset: 0x0022CB00
		public virtual bool? IsLookDir
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsLookDir);
			}
		}

		// Token: 0x17004646 RID: 17990
		// (get) Token: 0x0600ED77 RID: 60791 RVA: 0x0022E937 File Offset: 0x0022CB37
		public virtual INpcFollowConfig NpcFollow
		{
			get
			{
				if (this._NpcFollowInited)
				{
					return this._NpcFollowCache;
				}
				this._NpcFollowInited = true;
				this._NpcFollowCache = INpcFollowConfig.Create(this.Instance.NpcFollow);
				return this._NpcFollowCache;
			}
		}

		// Token: 0x17004647 RID: 17991
		// (get) Token: 0x0600ED78 RID: 60792 RVA: 0x0022E96C File Offset: 0x0022CB6C
		public virtual bool? NpcCollisionEnabled
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.NpcCollisionEnabled);
			}
		}

		// Token: 0x040082AF RID: 33455
		private IMoveWithSpline Instance;

		// Token: 0x040082B0 RID: 33456
		[Nullable(0)]
		private ISplineMoveTargetType _MoveTargetCache;

		// Token: 0x040082B1 RID: 33457
		private bool _MoveTargetInited;

		// Token: 0x040082B2 RID: 33458
		private ICheckClimb _CheckClimbCache;

		// Token: 0x040082B3 RID: 33459
		private bool _CheckClimbInited;

		// Token: 0x040082B4 RID: 33460
		private IMoveOnWallConfig _MoveOnWallConfigCache;

		// Token: 0x040082B5 RID: 33461
		private bool _MoveOnWallConfigInited;

		// Token: 0x040082B6 RID: 33462
		private INpcFollowConfig _NpcFollowCache;

		// Token: 0x040082B7 RID: 33463
		private bool _NpcFollowInited;
	}
}
