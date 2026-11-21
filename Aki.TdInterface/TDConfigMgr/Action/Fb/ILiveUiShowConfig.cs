using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E13 RID: 11795
	public class ILiveUiShowConfig : ILiveUiConfig
	{
		// Token: 0x06010041 RID: 65601 RVA: 0x0024E0B7 File Offset: 0x0024C2B7
		public static ILiveUiShowConfig Create(ILiveUiShowConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUiShowConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050C9 RID: 20681
		// (get) Token: 0x06010042 RID: 65602 RVA: 0x0024E0D6 File Offset: 0x0024C2D6
		public override ELiveUiType Type
		{
			get
			{
				return (ELiveUiType)this.Instance.Type;
			}
		}

		// Token: 0x04008BD7 RID: 35799
		private ILiveUiShowConfig Instance;
	}
}
