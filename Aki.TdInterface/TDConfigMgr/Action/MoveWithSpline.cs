using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002342 RID: 9026
	public class MoveWithSpline : ActionParams
	{
		// Token: 0x0600C476 RID: 50294 RVA: 0x001C2A94 File Offset: 0x001C0C94
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

		// Token: 0x0600C477 RID: 50295 RVA: 0x001C2ACC File Offset: 0x001C0CCC
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

		// Token: 0x0600C478 RID: 50296 RVA: 0x001C2ADF File Offset: 0x001C0CDF
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

		// Token: 0x0600C479 RID: 50297 RVA: 0x001C2AF4 File Offset: 0x001C0CF4
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

		// Token: 0x17003B68 RID: 15208
		// (get) Token: 0x0600C47A RID: 50298 RVA: 0x001C2B96 File Offset: 0x001C0D96
		// (set) Token: 0x0600C47B RID: 50299 RVA: 0x001C2BBD File Offset: 0x001C0DBD
		public virtual ISplineMoveTargetType MoveTarget
		{
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
			set
			{
				this.GetOrCreatePoco().MoveTarget = value;
			}
		}

		// Token: 0x17003B69 RID: 15209
		// (get) Token: 0x0600C47C RID: 50300 RVA: 0x001C2BCB File Offset: 0x001C0DCB
		// (set) Token: 0x0600C47D RID: 50301 RVA: 0x001C2BF6 File Offset: 0x001C0DF6
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

		// Token: 0x17003B6A RID: 15210
		// (get) Token: 0x0600C47E RID: 50302 RVA: 0x001C2C04 File Offset: 0x001C0E04
		// (set) Token: 0x0600C47F RID: 50303 RVA: 0x001C2C65 File Offset: 0x001C0E65
		[Nullable(2)]
		public virtual ICheckClimb CheckClimb
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CheckClimb = value;
				this._CheckClimbInited = false;
			}
		}

		// Token: 0x17003B6B RID: 15211
		// (get) Token: 0x0600C480 RID: 50304 RVA: 0x001C2C7C File Offset: 0x001C0E7C
		// (set) Token: 0x0600C481 RID: 50305 RVA: 0x001C2CDD File Offset: 0x001C0EDD
		[Nullable(2)]
		public virtual IMoveOnWallConfig MoveOnWallConfig
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MoveOnWallConfig = value;
				this._MoveOnWallConfigInited = false;
			}
		}

		// Token: 0x17003B6C RID: 15212
		// (get) Token: 0x0600C482 RID: 50306 RVA: 0x001C2CF4 File Offset: 0x001C0EF4
		// (set) Token: 0x0600C483 RID: 50307 RVA: 0x001C2D2E File Offset: 0x001C0F2E
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

		// Token: 0x17003B6D RID: 15213
		// (get) Token: 0x0600C484 RID: 50308 RVA: 0x001C2D3C File Offset: 0x001C0F3C
		// (set) Token: 0x0600C485 RID: 50309 RVA: 0x001C2D76 File Offset: 0x001C0F76
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

		// Token: 0x17003B6E RID: 15214
		// (get) Token: 0x0600C486 RID: 50310 RVA: 0x001C2D84 File Offset: 0x001C0F84
		// (set) Token: 0x0600C487 RID: 50311 RVA: 0x001C2DBE File Offset: 0x001C0FBE
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

		// Token: 0x17003B6F RID: 15215
		// (get) Token: 0x0600C488 RID: 50312 RVA: 0x001C2DCC File Offset: 0x001C0FCC
		// (set) Token: 0x0600C489 RID: 50313 RVA: 0x001C2E06 File Offset: 0x001C1006
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

		// Token: 0x17003B70 RID: 15216
		// (get) Token: 0x0600C48A RID: 50314 RVA: 0x001C2E14 File Offset: 0x001C1014
		// (set) Token: 0x0600C48B RID: 50315 RVA: 0x001C2E4E File Offset: 0x001C104E
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

		// Token: 0x17003B71 RID: 15217
		// (get) Token: 0x0600C48C RID: 50316 RVA: 0x001C2E5C File Offset: 0x001C105C
		// (set) Token: 0x0600C48D RID: 50317 RVA: 0x001C2E96 File Offset: 0x001C1096
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

		// Token: 0x17003B72 RID: 15218
		// (get) Token: 0x0600C48E RID: 50318 RVA: 0x001C2EA4 File Offset: 0x001C10A4
		// (set) Token: 0x0600C48F RID: 50319 RVA: 0x001C2F05 File Offset: 0x001C1105
		[Nullable(2)]
		public virtual INpcFollowConfig NpcFollow
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().NpcFollow = value;
				this._NpcFollowInited = false;
			}
		}

		// Token: 0x17003B73 RID: 15219
		// (get) Token: 0x0600C490 RID: 50320 RVA: 0x001C2F1C File Offset: 0x001C111C
		// (set) Token: 0x0600C491 RID: 50321 RVA: 0x001C2F56 File Offset: 0x001C1156
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

		// Token: 0x040074F3 RID: 29939
		[Nullable(2)]
		protected new MoveWithSpline FbInstance;

		// Token: 0x040074F4 RID: 29940
		[Nullable(2)]
		protected MoveWithSpline_SetValue PocoInterface;

		// Token: 0x040074F5 RID: 29941
		private ICheckClimb _CheckClimbCache;

		// Token: 0x040074F6 RID: 29942
		private bool _CheckClimbInited;

		// Token: 0x040074F7 RID: 29943
		private IMoveOnWallConfig _MoveOnWallConfigCache;

		// Token: 0x040074F8 RID: 29944
		private bool _MoveOnWallConfigInited;

		// Token: 0x040074F9 RID: 29945
		private INpcFollowConfig _NpcFollowCache;

		// Token: 0x040074FA RID: 29946
		private bool _NpcFollowInited;
	}
}
