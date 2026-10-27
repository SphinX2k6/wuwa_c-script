using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC8 RID: 3016
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnDollGrabDelivery : INpcUiInteractType
	{
		// Token: 0x0600455B RID: 17755 RVA: 0x000AFAEE File Offset: 0x000ADCEE
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

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x0600455C RID: 17756 RVA: 0x000AFB0D File Offset: 0x000ADD0D
		public override ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x0600455D RID: 17757 RVA: 0x000AFB1A File Offset: 0x000ADD1A
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

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x0600455E RID: 17758 RVA: 0x000AFB4E File Offset: 0x000ADD4E
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

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x0600455F RID: 17759 RVA: 0x000AFB82 File Offset: 0x000ADD82
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

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x06004560 RID: 17760 RVA: 0x000AFBB6 File Offset: 0x000ADDB6
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

		// Token: 0x0400276B RID: 10091
		private INpcUiInteractOnDollGrabDelivery Instance;

		// Token: 0x0400276C RID: 10092
		[Nullable(2)]
		private IOnDollGrabDeliveryPerform _OnFirstAchievementPerformCache;

		// Token: 0x0400276D RID: 10093
		private bool _OnFirstAchievementPerformInited;

		// Token: 0x0400276E RID: 10094
		[Nullable(2)]
		private IOnDollGrabDeliveryPerform _OnSubsequentAchievementPerformCache;

		// Token: 0x0400276F RID: 10095
		private bool _OnSubsequentAchievementPerformInited;

		// Token: 0x04002770 RID: 10096
		[Nullable(2)]
		private IOnDollGrabDeliveryPerform _OnNeverAchievementPerformCache;

		// Token: 0x04002771 RID: 10097
		private bool _OnNeverAchievementPerformInited;

		// Token: 0x04002772 RID: 10098
		[Nullable(2)]
		private IOnDollGrabDeliveryPerform _OnAlreadyAchievementPerformCache;

		// Token: 0x04002773 RID: 10099
		private bool _OnAlreadyAchievementPerformInited;
	}
}
