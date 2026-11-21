using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F54 RID: 3924
	public class ICircuitConnectModeBase
	{
		// Token: 0x060057FC RID: 22524 RVA: 0x000D72F4 File Offset: 0x000D54F4
		public static ICircuitConnectModeBase Create(ICircuitConnectModeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectModeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x060057FD RID: 22525 RVA: 0x000D7313 File Offset: 0x000D5513
		public virtual ECircuitConnectMode Type
		{
			get
			{
				return (ECircuitConnectMode)this.Instance.Type;
			}
		}

		// Token: 0x0400327F RID: 12927
		private ICircuitConnectModeBase Instance;
	}
}
