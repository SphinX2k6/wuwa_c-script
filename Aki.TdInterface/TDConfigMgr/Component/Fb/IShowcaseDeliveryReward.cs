using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EFA RID: 3834
	public class IShowcaseDeliveryReward
	{
		// Token: 0x06005645 RID: 22085 RVA: 0x000D3BF8 File Offset: 0x000D1DF8
		public static IShowcaseDeliveryReward Create(IShowcaseDeliveryReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowcaseDeliveryReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06005646 RID: 22086 RVA: 0x000D3C17 File Offset: 0x000D1E17
		public virtual int AchievedDollCount
		{
			get
			{
				return this.Instance.AchievedDollCount;
			}
		}

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x06005647 RID: 22087 RVA: 0x000D3C24 File Offset: 0x000D1E24
		public virtual int DropId
		{
			get
			{
				return this.Instance.DropId;
			}
		}

		// Token: 0x0400316F RID: 12655
		private IShowcaseDeliveryReward Instance;
	}
}
