using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020E1 RID: 8417
	[NullableContext(2)]
	[Nullable(0)]
	public class MoveWithSpline : ActionParams
	{
		// Token: 0x0600B8EC RID: 47340 RVA: 0x001AB9B8 File Offset: 0x001A9BB8
		[NullableContext(1)]
		private MoveWithSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("MoveWithSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			MoveWithSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new MoveWithSpline_SetValue());
			}
			return result;
		}

		// Token: 0x0600B8ED RID: 47341 RVA: 0x001AB9F0 File Offset: 0x001A9BF0
		[NullableContext(1)]
		public static MoveWithSpline Create([Nullable(2)] MoveWithSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MoveWithSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B8EE RID: 47342 RVA: 0x001ABA03 File Offset: 0x001A9C03
		[NullableContext(1)]
		public static MoveWithSpline CreateFromSetValue([Nullable(2)] MoveWithSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new MoveWithSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B8EF RID: 47343 RVA: 0x001ABA18 File Offset: 0x001A9C18
		[NullableContext(1)]
		public MoveWithSpline_SetValue ToSetValue()
		{
			return new MoveWithSpline_SetValue
			{
				MoveTarget = this.MoveTarget,
				SplineEntityId = this.SplineEntityId,
				CheckClimb = this.CheckClimb,
				MoveOnWallConfig = this.MoveOnWallConfig,
				MoveState = this.MoveState,
				StartPointIndex = this.StartPointIndex,
				EndPointIndex = this.EndPointIndex,
				IsFollowStrictly = this.IsFollowStrictly,
				IsForceToFirstPoint = this.IsForceToFirstPoint,
				IsLookDir = this.IsLookDir,
				NpcFollow = this.NpcFollow,
				NpcCollisionEnabled = this.NpcCollisionEnabled
			};
		}

		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x0600B8F0 RID: 47344 RVA: 0x001ABABA File Offset: 0x001A9CBA
		// (set) Token: 0x0600B8F1 RID: 47345 RVA: 0x001ABAE1 File Offset: 0x001A9CE1
		[Nullable(1)]
		public virtual ISplineMoveTargetType MoveTarget
		{
			[NullableContext(1)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveTarget;
				}
				MoveWithSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveTarget;
			}
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().MoveTarget = value;
			}
		}

		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x0600B8F2 RID: 47346 RVA: 0x001ABAEF File Offset: 0x001A9CEF
		// (set) Token: 0x0600B8F3 RID: 47347 RVA: 0x001ABB1A File Offset: 0x001A9D1A
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x0600B8F4 RID: 47348 RVA: 0x001ABB28 File Offset: 0x001A9D28
		// (set) Token: 0x0600B8F5 RID: 47349 RVA: 0x001ABB89 File Offset: 0x001A9D89
		public virtual ICheckClimb CheckClimb
		{
			get
			{
				if (this._CheckClimbInited)
				{
					return this._CheckClimbCache;
				}
				this._CheckClimbInited = true;
				if (this.FbInstance != null)
				{
					this._CheckClimbCache = ICheckClimb.Create(this.FbInstance.CheckClimb);
				}
				else
				{
					MoveWithSpline_SetValue pocoInterface = this.PocoInterface;
					this._CheckClimbCache = ((pocoInterface != null) ? pocoInterface.CheckClimb : null);
				}
				return this._CheckClimbCache;
			}
			set
			{
				this.GetOrCreatePoco().CheckClimb = value;
				this._CheckClimbInited = false;
			}
		}

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x0600B8F6 RID: 47350 RVA: 0x001ABBA0 File Offset: 0x001A9DA0
		// (set) Token: 0x0600B8F7 RID: 47351 RVA: 0x001ABC01 File Offset: 0x001A9E01
		public virtual IMoveOnWallConfig MoveOnWallConfig
		{
			get
			{
				if (this._MoveOnWallConfigInited)
				{
					return this._MoveOnWallConfigCache;
				}
				this._MoveOnWallConfigInited = true;
				if (this.FbInstance != null)
				{
					this._MoveOnWallConfigCache = IMoveOnWallConfig.Create(this.FbInstance.MoveOnWallConfig);
				}
				else
				{
					MoveWithSpline_SetValue pocoInterface = this.PocoInterface;
					this._MoveOnWallConfigCache = ((pocoInterface != null) ? pocoInterface.MoveOnWallConfig : null);
				}
				return this._MoveOnWallConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().MoveOnWallConfig = value;
				this._MoveOnWallConfigInited = false;
			}
		}

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x0600B8F8 RID: 47352 RVA: 0x001ABC18 File Offset: 0x001A9E18
		// (set) Token: 0x0600B8F9 RID: 47353 RVA: 0x001ABC52 File Offset: 0x001A9E52
		public virtual EMoveSpeed? MoveState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveState;
				}
				MoveWithSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveState;
			}
			set
			{
				this.GetOrCreatePoco().MoveState = value;
			}
		}

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x0600B8FA RID: 47354 RVA: 0x001ABC60 File Offset: 0x001A9E60
		// (set) Token: 0x0600B8FB RID: 47355 RVA: 0x001ABC9A File Offset: 0x001A9E9A
		public virtual int? StartPointIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartPointIndex;
				}
				MoveWithSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartPointIndex;
			}
			set
			{
				this.GetOrCreatePoco().StartPointIndex = value;
			}
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x0600B8FC RID: 47356 RVA: 0x001ABCA8 File Offset: 0x001A9EA8
		// (set) Token: 0x0600B8FD RID: 47357 RVA: 0x001ABCE2 File Offset: 0x001A9EE2
		public virtual int? EndPointIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndPointIndex;
				}
				MoveWithSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EndPointIndex;
			}
			set
			{
				this.GetOrCreatePoco().EndPointIndex = value;
			}
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x0600B8FE RID: 47358 RVA: 0x001ABCF0 File Offset: 0x001A9EF0
		// (set) Token: 0x0600B8FF RID: 47359 RVA: 0x001ABD2A File Offset: 0x001A9F2A
		public virtual bool? IsFollowStrictly
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFollowStrictly;
				}
				MoveWithSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsFollowStrictly;
			}
			set
			{
				this.GetOrCreatePoco().IsFollowStrictly = value;
			}
		}

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x0600B900 RID: 47360 RVA: 0x001ABD38 File Offset: 0x001A9F38
		// (set) Token: 0x0600B901 RID: 47361 RVA: 0x001ABD72 File Offset: 0x001A9F72
		public virtual bool? IsForceToFirstPoint
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsForceToFirstPoint;
				}
				MoveWithSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsForceToFirstPoint;
			}
			set
			{
				this.GetOrCreatePoco().IsForceToFirstPoint = value;
			}
		}

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x0600B902 RID: 47362 RVA: 0x001ABD80 File Offset: 0x001A9F80
		// (set) Token: 0x0600B903 RID: 47363 RVA: 0x001ABDBA File Offset: 0x001A9FBA
		public virtual bool? IsLookDir
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLookDir;
				}
				MoveWithSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsLookDir;
			}
			set
			{
				this.GetOrCreatePoco().IsLookDir = value;
			}
		}

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x0600B904 RID: 47364 RVA: 0x001ABDC8 File Offset: 0x001A9FC8
		// (set) Token: 0x0600B905 RID: 47365 RVA: 0x001ABE29 File Offset: 0x001AA029
		public virtual INpcFollowConfig NpcFollow
		{
			get
			{
				if (this._NpcFollowInited)
				{
					return this._NpcFollowCache;
				}
				this._NpcFollowInited = true;
				if (this.FbInstance != null)
				{
					this._NpcFollowCache = INpcFollowConfig.Create(this.FbInstance.NpcFollow);
				}
				else
				{
					MoveWithSpline_SetValue pocoInterface = this.PocoInterface;
					this._NpcFollowCache = ((pocoInterface != null) ? pocoInterface.NpcFollow : null);
				}
				return this._NpcFollowCache;
			}
			set
			{
				this.GetOrCreatePoco().NpcFollow = value;
				this._NpcFollowInited = false;
			}
		}

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x0600B906 RID: 47366 RVA: 0x001ABE40 File Offset: 0x001AA040
		// (set) Token: 0x0600B907 RID: 47367 RVA: 0x001ABE7A File Offset: 0x001AA07A
		public virtual bool? NpcCollisionEnabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NpcCollisionEnabled;
				}
				MoveWithSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NpcCollisionEnabled;
			}
			set
			{
				this.GetOrCreatePoco().NpcCollisionEnabled = value;
			}
		}

		// Token: 0x04006EC2 RID: 28354
		protected new MoveWithSpline FbInstance;

		// Token: 0x04006EC3 RID: 28355
		protected MoveWithSpline_SetValue PocoInterface;

		// Token: 0x04006EC4 RID: 28356
		[Nullable(1)]
		private ICheckClimb _CheckClimbCache;

		// Token: 0x04006EC5 RID: 28357
		private bool _CheckClimbInited;

		// Token: 0x04006EC6 RID: 28358
		[Nullable(1)]
		private IMoveOnWallConfig _MoveOnWallConfigCache;

		// Token: 0x04006EC7 RID: 28359
		private bool _MoveOnWallConfigInited;

		// Token: 0x04006EC8 RID: 28360
		[Nullable(1)]
		private INpcFollowConfig _NpcFollowCache;

		// Token: 0x04006EC9 RID: 28361
		private bool _NpcFollowInited;
	}
}
