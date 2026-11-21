using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E10 RID: 11792
	public class ILiveUiHideConfig : ILiveUiConfig
	{
		// Token: 0x06010038 RID: 65592 RVA: 0x0024E01B File Offset: 0x0024C21B
		public static ILiveUiHideConfig Create(ILiveUiHideConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUiHideConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050C6 RID: 20678
		// (get) Token: 0x06010039 RID: 65593 RVA: 0x0024E03A File Offset: 0x0024C23A
		public override ELiveUiType Type
		{
			get
			{
				return (ELiveUiType)this.Instance.Type;
			}
		}

		// Token: 0x04008BD4 RID: 35796
		private ILiveUiHideConfig Instance;
	}
}
