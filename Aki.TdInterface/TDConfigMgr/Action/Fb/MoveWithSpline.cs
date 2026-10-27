using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002725 RID: 10021
	[NullableContext(2)]
	[Nullable(0)]
	public class MoveWithSpline : ActionParams
	{
		// Token: 0x0600DF74 RID: 57204 RVA: 0x00211C93 File Offset: 0x0020FE93
		[NullableContext(1)]
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

		// Token: 0x170042EC RID: 17132
		// (get) Token: 0x0600DF75 RID: 57205 RVA: 0x00211CB2 File Offset: 0x0020FEB2
		[Nullable(1)]
		public virtual ISplineMoveTargetType MoveTarget
		{
			[NullableContext(1)]
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

		// Token: 0x170042ED RID: 17133
		// (get) Token: 0x0600DF76 RID: 57206 RVA: 0x00211CE1 File Offset: 0x0020FEE1
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x170042EE RID: 17134
		// (get) Token: 0x0600DF77 RID: 57207 RVA: 0x00211CEE File Offset: 0x0020FEEE
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

		// Token: 0x170042EF RID: 17135
		// (get) Token: 0x0600DF78 RID: 57208 RVA: 0x00211D22 File Offset: 0x0020FF22
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

		// Token: 0x170042F0 RID: 17136
		// (get) Token: 0x0600DF79 RID: 57209 RVA: 0x00211D58 File Offset: 0x0020FF58
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

		// Token: 0x170042F1 RID: 17137
		// (get) Token: 0x0600DF7A RID: 57210 RVA: 0x00211D90 File Offset: 0x0020FF90
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

		// Token: 0x170042F2 RID: 17138
		// (get) Token: 0x0600DF7B RID: 57211 RVA: 0x00211DC8 File Offset: 0x0020FFC8
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

		// Token: 0x170042F3 RID: 17139
		// (get) Token: 0x0600DF7C RID: 57212 RVA: 0x00211E00 File Offset: 0x00210000
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

		// Token: 0x170042F4 RID: 17140
		// (get) Token: 0x0600DF7D RID: 57213 RVA: 0x00211E38 File Offset: 0x00210038
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

		// Token: 0x170042F5 RID: 17141
		// (get) Token: 0x0600DF7E RID: 57214 RVA: 0x00211E70 File Offset: 0x00210070
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

		// Token: 0x170042F6 RID: 17142
		// (get) Token: 0x0600DF7F RID: 57215 RVA: 0x00211EA7 File Offset: 0x002100A7
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

		// Token: 0x170042F7 RID: 17143
		// (get) Token: 0x0600DF80 RID: 57216 RVA: 0x00211EDC File Offset: 0x002100DC
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

		// Token: 0x04007C05 RID: 31749
		private IMoveWithSpline Instance;

		// Token: 0x04007C06 RID: 31750
		[Nullable(1)]
		private ISplineMoveTargetType _MoveTargetCache;

		// Token: 0x04007C07 RID: 31751
		private bool _MoveTargetInited;

		// Token: 0x04007C08 RID: 31752
		private ICheckClimb _CheckClimbCache;

		// Token: 0x04007C09 RID: 31753
		private bool _CheckClimbInited;

		// Token: 0x04007C0A RID: 31754
		private IMoveOnWallConfig _MoveOnWallConfigCache;

		// Token: 0x04007C0B RID: 31755
		private bool _MoveOnWallConfigInited;

		// Token: 0x04007C0C RID: 31756
		private INpcFollowConfig _NpcFollowCache;

		// Token: 0x04007C0D RID: 31757
		private bool _NpcFollowInited;
	}
}
