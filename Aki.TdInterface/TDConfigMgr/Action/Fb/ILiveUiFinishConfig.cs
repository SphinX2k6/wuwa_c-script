using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E0F RID: 11791
	public class ILiveUiFinishConfig : ILiveUiConfig
	{
		// Token: 0x06010034 RID: 65588 RVA: 0x0024DFDA File Offset: 0x0024C1DA
		public static ILiveUiFinishConfig Create(ILiveUiFinishConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUiFinishConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050C4 RID: 20676
		// (get) Token: 0x06010035 RID: 65589 RVA: 0x0024DFF9 File Offset: 0x0024C1F9
		public override ELiveUiType Type
		{
			get
			{
				return (ELiveUiType)this.Instance.Type;
			}
		}

		// Token: 0x170050C5 RID: 20677
		// (get) Token: 0x06010036 RID: 65590 RVA: 0x0024E006 File Offset: 0x0024C206
		public virtual int SettlementId
		{
			get
			{
				return this.Instance.SettlementId;
			}
		}

		// Token: 0x04008BD3 RID: 35795
		private ILiveUiFinishConfig Instance;
	}
}
