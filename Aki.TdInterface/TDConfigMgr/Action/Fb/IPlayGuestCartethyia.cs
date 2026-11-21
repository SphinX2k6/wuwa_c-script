using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CFB RID: 11515
	public class IPlayGuestCartethyia : IPlayGuestUiAnimationType
	{
		// Token: 0x0600FC08 RID: 64520 RVA: 0x00247732 File Offset: 0x00245932
		public static IPlayGuestCartethyia Create(IPlayGuestCartethyia? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayGuestCartethyia
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EC0 RID: 20160
		// (get) Token: 0x0600FC09 RID: 64521 RVA: 0x00247751 File Offset: 0x00245951
		public override EGuestUiAnimationType Type
		{
			get
			{
				return (EGuestUiAnimationType)this.Instance.Type;
			}
		}

		// Token: 0x040089A3 RID: 35235
		private IPlayGuestCartethyia Instance;
	}
}
