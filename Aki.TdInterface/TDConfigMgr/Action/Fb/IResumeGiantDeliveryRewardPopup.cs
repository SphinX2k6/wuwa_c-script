using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029AC RID: 10668
	public class IResumeGiantDeliveryRewardPopup : IResumeSystemRewardPopupType
	{
		// Token: 0x0600EC0B RID: 60427 RVA: 0x00227DA4 File Offset: 0x00225FA4
		[NullableContext(1)]
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

		// Token: 0x17004A75 RID: 19061
		// (get) Token: 0x0600EC0C RID: 60428 RVA: 0x00227DC3 File Offset: 0x00225FC3
		public override ESystemType Type
		{
			get
			{
				return (ESystemType)this.Instance.Type;
			}
		}

		// Token: 0x040081FC RID: 33276
		private IResumeGiantDeliveryRewardPopup Instance;
	}
}
