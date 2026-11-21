using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E14 RID: 11796
	public class ILiveUiStartConfig : ILiveUiConfig
	{
		// Token: 0x06010044 RID: 65604 RVA: 0x0024E0EB File Offset: 0x0024C2EB
		public static ILiveUiStartConfig Create(ILiveUiStartConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUiStartConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050CA RID: 20682
		// (get) Token: 0x06010045 RID: 65605 RVA: 0x0024E10A File Offset: 0x0024C30A
		public override ELiveUiType Type
		{
			get
			{
				return (ELiveUiType)this.Instance.Type;
			}
		}

		// Token: 0x04008BD8 RID: 35800
		private ILiveUiStartConfig Instance;
	}
}
