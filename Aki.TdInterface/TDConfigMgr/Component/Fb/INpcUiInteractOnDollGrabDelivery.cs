using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C96 RID: 3222
	public class INpcUiInteractOnDollGrabDelivery : INpcUiInteractType
	{
		// Token: 0x060049B4 RID: 18868 RVA: 0x000B9BB2 File Offset: 0x000B7DB2
		public static INpcUiInteractOnDollGrabDelivery Create(INpcUiInteractOnDollGrabDelivery? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnDollGrabDelivery
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x060049B5 RID: 18869 RVA: 0x000B9BD1 File Offset: 0x000B7DD1
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x060049B6 RID: 18870 RVA: 0x000B9BDE File Offset: 0x000B7DDE
		public virtual IOnDollGrabDeliveryPerform OnFirstAchievementPerform
		{
			get
			{
				if (this._OnFirstAchievementPerformInited)
				{
					return this._OnFirstAchievementPerformCache;
				}
				this._OnFirstAchievementPerformInited = true;
				this._OnFirstAchievementPerformCache = IOnDollGrabDeliveryPerform.Create(this.Instance.OnFirstAchievementPerform);
				return this._OnFirstAchievementPerformCache;
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x060049B7 RID: 18871 RVA: 0x000B9C12 File Offset: 0x000B7E12
		public virtual IOnDollGrabDeliveryPerform OnSubsequentAchievementPerform
		{
			get
			{
				if (this._OnSubsequentAchievementPerformInited)
				{
					return this._OnSubsequentAchievementPerformCache;
				}
				this._OnSubsequentAchievementPerformInited = true;
				this._OnSubsequentAchievementPerformCache = IOnDollGrabDeliveryPerform.Create(this.Instance.OnSubsequentAchievementPerform);
				return this._OnSubsequentAchievementPerformCache;
			}
		}

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x060049B8 RID: 18872 RVA: 0x000B9C46 File Offset: 0x000B7E46
		public virtual IOnDollGrabDeliveryPerform OnNeverAchievementPerform
		{
			get
			{
				if (this._OnNeverAchievementPerformInited)
				{
					return this._OnNeverAchievementPerformCache;
				}
				this._OnNeverAchievementPerformInited = true;
				this._OnNeverAchievementPerformCache = IOnDollGrabDeliveryPerform.Create(this.Instance.OnNeverAchievementPerform);
				return this._OnNeverAchievementPerformCache;
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x060049B9 RID: 18873 RVA: 0x000B9C7A File Offset: 0x000B7E7A
		public virtual IOnDollGrabDeliveryPerform OnAlreadyAchievementPerform
		{
			get
			{
				if (this._OnAlreadyAchievementPerformInited)
				{
					return this._OnAlreadyAchievementPerformCache;
				}
				this._OnAlreadyAchievementPerformInited = true;
				this._OnAlreadyAchievementPerformCache = IOnDollGrabDeliveryPerform.Create(this.Instance.OnAlreadyAchievementPerform);
				return this._OnAlreadyAchievementPerformCache;
			}
		}

		// Token: 0x040029B3 RID: 10675
		private INpcUiInteractOnDollGrabDelivery Instance;

		// Token: 0x040029B4 RID: 10676
		[Nullable(2)]
		private IOnDollGrabDeliveryPerform _OnFirstAchievementPerformCache;

		// Token: 0x040029B5 RID: 10677
		private bool _OnFirstAchievementPerformInited;

		// Token: 0x040029B6 RID: 10678
		[Nullable(2)]
		private IOnDollGrabDeliveryPerform _OnSubsequentAchievementPerformCache;

		// Token: 0x040029B7 RID: 10679
		private bool _OnSubsequentAchievementPerformInited;

		// Token: 0x040029B8 RID: 10680
		[Nullable(2)]
		private IOnDollGrabDeliveryPerform _OnNeverAchievementPerformCache;

		// Token: 0x040029B9 RID: 10681
		private bool _OnNeverAchievementPerformInited;

		// Token: 0x040029BA RID: 10682
		[Nullable(2)]
		private IOnDollGrabDeliveryPerform _OnAlreadyAchievementPerformCache;

		// Token: 0x040029BB RID: 10683
		private bool _OnAlreadyAchievementPerformInited;
	}
}
