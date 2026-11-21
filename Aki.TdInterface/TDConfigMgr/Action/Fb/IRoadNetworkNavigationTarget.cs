using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DC8 RID: 11720
	public class IRoadNetworkNavigationTarget
	{
		// Token: 0x0600FF2D RID: 65325 RVA: 0x0024C7C1 File Offset: 0x0024A9C1
		public static IRoadNetworkNavigationTarget Create(IRoadNetworkNavigationTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoadNetworkNavigationTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700504B RID: 20555
		// (get) Token: 0x0600FF2E RID: 65326 RVA: 0x0024C7E0 File Offset: 0x0024A9E0
		public virtual ERoadNetworkNavigationTarget Type
		{
			get
			{
				return (ERoadNetworkNavigationTarget)this.Instance.Type;
			}
		}

		// Token: 0x04008B4A RID: 35658
		private IRoadNetworkNavigationTarget Instance;
	}
}
