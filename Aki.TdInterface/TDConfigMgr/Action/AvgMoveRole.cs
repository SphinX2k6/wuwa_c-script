using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015FC RID: 5628
	public class AvgMoveRole : ActionParams
	{
		// Token: 0x06007F17 RID: 32535 RVA: 0x0012F39C File Offset: 0x0012D59C
		private AvgMoveRole_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AvgMoveRole 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AvgMoveRole_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AvgMoveRole_SetValue());
			}
			return result;
		}

		// Token: 0x06007F18 RID: 32536 RVA: 0x0012F3D4 File Offset: 0x0012D5D4
		public static AvgMoveRole Create([Nullable(2)] AvgMoveRole instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AvgMoveRole
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F19 RID: 32537 RVA: 0x0012F3E7 File Offset: 0x0012D5E7
		public static AvgMoveRole CreateFromSetValue([Nullable(2)] AvgMoveRole_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AvgMoveRole
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F1A RID: 32538 RVA: 0x0012F3FC File Offset: 0x0012D5FC
		public AvgMoveRole_SetValue ToSetValue()
		{
			return new AvgMoveRole_SetValue
			{
				RoleId = this.RoleId,
				AnimationType = this.AnimationType,
				IsAnimationLoop = this.IsAnimationLoop,
				TargetPosition = this.TargetPosition,
				EaseCurve = this.EaseCurve
			};
		}

		// Token: 0x17002A50 RID: 10832
		// (get) Token: 0x06007F1B RID: 32539 RVA: 0x0012F44A File Offset: 0x0012D64A
		// (set) Token: 0x06007F1C RID: 32540 RVA: 0x0012F475 File Offset: 0x0012D675
		public virtual int RoleId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RoleId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RoleId;
			}
			set
			{
				this.GetOrCreatePoco().RoleId = value;
			}
		}

		// Token: 0x17002A51 RID: 10833
		// (get) Token: 0x06007F1D RID: 32541 RVA: 0x0012F483 File Offset: 0x0012D683
		// (set) Token: 0x06007F1E RID: 32542 RVA: 0x0012F4AE File Offset: 0x0012D6AE
		public virtual EAvgRoleAnimationType AnimationType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AnimationType;
				}
				if (this.PocoInterface == null)
				{
					return EAvgRoleAnimationType.Idle;
				}
				return this.PocoInterface.AnimationType;
			}
			set
			{
				this.GetOrCreatePoco().AnimationType = value;
			}
		}

		// Token: 0x17002A52 RID: 10834
		// (get) Token: 0x06007F1F RID: 32543 RVA: 0x0012F4BC File Offset: 0x0012D6BC
		// (set) Token: 0x06007F20 RID: 32544 RVA: 0x0012F4F6 File Offset: 0x0012D6F6
		public virtual bool? IsAnimationLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAnimationLoop;
				}
				AvgMoveRole_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAnimationLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsAnimationLoop = value;
			}
		}

		// Token: 0x17002A53 RID: 10835
		// (get) Token: 0x06007F21 RID: 32545 RVA: 0x0012F504 File Offset: 0x0012D704
		// (set) Token: 0x06007F22 RID: 32546 RVA: 0x0012F52F File Offset: 0x0012D72F
		public virtual EAvgRolePosition TargetPosition
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetPosition;
				}
				if (this.PocoInterface == null)
				{
					return EAvgRolePosition.Center;
				}
				return this.PocoInterface.TargetPosition;
			}
			set
			{
				this.GetOrCreatePoco().TargetPosition = value;
			}
		}

		// Token: 0x17002A54 RID: 10836
		// (get) Token: 0x06007F23 RID: 32547 RVA: 0x0012F540 File Offset: 0x0012D740
		// (set) Token: 0x06007F24 RID: 32548 RVA: 0x0012F5A1 File Offset: 0x0012D7A1
		public virtual IEaseData EaseCurve
		{
			get
			{
				if (this._EaseCurveInited)
				{
					return this._EaseCurveCache;
				}
				this._EaseCurveInited = true;
				if (this.FbInstance != null)
				{
					this._EaseCurveCache = IEaseData.Create(this.FbInstance.EaseCurve);
				}
				else
				{
					AvgMoveRole_SetValue pocoInterface = this.PocoInterface;
					this._EaseCurveCache = ((pocoInterface != null) ? pocoInterface.EaseCurve : null);
				}
				return this._EaseCurveCache;
			}
			set
			{
				this.GetOrCreatePoco().EaseCurve = value;
				this._EaseCurveInited = false;
			}
		}

		// Token: 0x04004985 RID: 18821
		[Nullable(2)]
		protected new AvgMoveRole FbInstance;

		// Token: 0x04004986 RID: 18822
		[Nullable(2)]
		protected AvgMoveRole_SetValue PocoInterface;

		// Token: 0x04004987 RID: 18823
		private IEaseData _EaseCurveCache;

		// Token: 0x04004988 RID: 18824
		private bool _EaseCurveInited;
	}
}
