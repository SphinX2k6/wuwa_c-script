using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E12 RID: 11794
	public class ILiveUiResumeConfig : ILiveUiConfig
	{
		// Token: 0x0601003E RID: 65598 RVA: 0x0024E083 File Offset: 0x0024C283
		public static ILiveUiResumeConfig Create(ILiveUiResumeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUiResumeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050C8 RID: 20680
		// (get) Token: 0x0601003F RID: 65599 RVA: 0x0024E0A2 File Offset: 0x0024C2A2
		public override ELiveUiType Type
		{
			get
			{
				return (ELiveUiType)this.Instance.Type;
			}
		}

		// Token: 0x04008BD6 RID: 35798
		private ILiveUiResumeConfig Instance;
	}
}
