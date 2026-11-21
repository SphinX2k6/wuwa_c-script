using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E0E RID: 11790
	public class ILiveUiConfig
	{
		// Token: 0x06010031 RID: 65585 RVA: 0x0024DFA6 File Offset: 0x0024C1A6
		public static ILiveUiConfig Create(ILiveUiConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUiConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050C3 RID: 20675
		// (get) Token: 0x06010032 RID: 65586 RVA: 0x0024DFC5 File Offset: 0x0024C1C5
		public virtual ELiveUiType Type
		{
			get
			{
				return (ELiveUiType)this.Instance.Type;
			}
		}

		// Token: 0x04008BD2 RID: 35794
		private ILiveUiConfig Instance;
	}
}
