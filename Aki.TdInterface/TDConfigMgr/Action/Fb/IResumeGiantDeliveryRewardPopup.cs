using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C99 RID: 11417
	public class IResumeGiantDeliveryRewardPopup : IResumeSystemRewardPopupType
	{
		// Token: 0x0600FAA2 RID: 64162 RVA: 0x00245729 File Offset: 0x00243929
		public static IResumeGiantDeliveryRewardPopup Create(IResumeGiantDeliveryRewardPopup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResumeGiantDeliveryRewardPopup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E1E RID: 19998
		// (get) Token: 0x0600FAA3 RID: 64163 RVA: 0x00245748 File Offset: 0x00243948
		public override ESystemType Type
		{
			get
			{
				return (ESystemType)this.Instance.Type;
			}
		}

		// Token: 0x040088ED RID: 35053
		private IResumeGiantDeliveryRewardPopup Instance;
	}
}
