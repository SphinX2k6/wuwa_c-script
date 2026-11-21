using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E11 RID: 11793
	public class ILiveUiPauseConfig : ILiveUiConfig
	{
		// Token: 0x0601003B RID: 65595 RVA: 0x0024E04F File Offset: 0x0024C24F
		public static ILiveUiPauseConfig Create(ILiveUiPauseConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUiPauseConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050C7 RID: 20679
		// (get) Token: 0x0601003C RID: 65596 RVA: 0x0024E06E File Offset: 0x0024C26E
		public override ELiveUiType Type
		{
			get
			{
				return (ELiveUiType)this.Instance.Type;
			}
		}

		// Token: 0x04008BD5 RID: 35797
		private ILiveUiPauseConfig Instance;
	}
}
