using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B76 RID: 2934
	public class IRewardRefreshConfig
	{
		// Token: 0x0600432B RID: 17195 RVA: 0x000AA89E File Offset: 0x000A8A9E
		public static IRewardRefreshConfig Create(IRewardRefreshConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRewardRefreshConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x0600432C RID: 17196 RVA: 0x000AA8BD File Offset: 0x000A8ABD
		public virtual IRefreshConditionBase RefreshCondition
		{
			get
			{
				if (this._RefreshConditionInited)
				{
					return this._RefreshConditionCache;
				}
				this._RefreshConditionInited = true;
				this._RefreshConditionCache = ComponentReadHelper.ReadIRewardRefreshConfig_RefreshCondition(this.Instance);
				return this._RefreshConditionCache;
			}
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x0600432D RID: 17197 RVA: 0x000AA8EC File Offset: 0x000A8AEC
		public virtual IRefreshRule RefreshType
		{
			get
			{
				if (this._RefreshTypeInited)
				{
					return this._RefreshTypeCache;
				}
				this._RefreshTypeInited = true;
				this._RefreshTypeCache = ComponentReadHelper.ReadIRewardRefreshConfig_RefreshType(this.Instance);
				return this._RefreshTypeCache;
			}
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x0600432E RID: 17198 RVA: 0x000AA91C File Offset: 0x000A8B1C
		public virtual int? MaxCount
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MaxCount);
			}
		}

		// Token: 0x04002519 RID: 9497
		private IRewardRefreshConfig Instance;

		// Token: 0x0400251A RID: 9498
		private IRefreshConditionBase _RefreshConditionCache;

		// Token: 0x0400251B RID: 9499
		private bool _RefreshConditionInited;

		// Token: 0x0400251C RID: 9500
		private IRefreshRule _RefreshTypeCache;

		// Token: 0x0400251D RID: 9501
		private bool _RefreshTypeInited;
	}
}
