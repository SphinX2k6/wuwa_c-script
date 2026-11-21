using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BC9 RID: 11209
	public class IAccelerateSkiConfig : ISkiConfigType
	{
		// Token: 0x0600F713 RID: 63251 RVA: 0x0023FAB7 File Offset: 0x0023DCB7
		public static IAccelerateSkiConfig Create(IAccelerateSkiConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAccelerateSkiConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C2F RID: 19503
		// (get) Token: 0x0600F714 RID: 63252 RVA: 0x0023FAD6 File Offset: 0x0023DCD6
		public override ESkiConfig Type
		{
			get
			{
				return (ESkiConfig)this.Instance.Type;
			}
		}

		// Token: 0x17004C30 RID: 19504
		// (get) Token: 0x0600F715 RID: 63253 RVA: 0x0023FAE3 File Offset: 0x0023DCE3
		public override ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadIAccelerateSkiConfig_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x17004C31 RID: 19505
		// (get) Token: 0x0600F716 RID: 63254 RVA: 0x0023FB12 File Offset: 0x0023DD12
		public virtual int Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17004C32 RID: 19506
		// (get) Token: 0x0600F717 RID: 63255 RVA: 0x0023FB1F File Offset: 0x0023DD1F
		public virtual int LimitSpeed
		{
			get
			{
				return this.Instance.LimitSpeed;
			}
		}

		// Token: 0x17004C33 RID: 19507
		// (get) Token: 0x0600F718 RID: 63256 RVA: 0x0023FB2C File Offset: 0x0023DD2C
		public virtual int Acceleration
		{
			get
			{
				return this.Instance.Acceleration;
			}
		}

		// Token: 0x17004C34 RID: 19508
		// (get) Token: 0x0600F719 RID: 63257 RVA: 0x0023FB3C File Offset: 0x0023DD3C
		public virtual int? InstantSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.InstantSpeed);
			}
		}

		// Token: 0x0400874D RID: 34637
		private IAccelerateSkiConfig Instance;

		// Token: 0x0400874E RID: 34638
		private ITargetEntityType _TargetCache;

		// Token: 0x0400874F RID: 34639
		private bool _TargetInited;
	}
}
