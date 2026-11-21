using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F55 RID: 3925
	public class ICircuitConnectTwoRings : ICircuitConnectModeBase
	{
		// Token: 0x060057FF RID: 22527 RVA: 0x000D7328 File Offset: 0x000D5528
		public static ICircuitConnectTwoRings Create(ICircuitConnectTwoRings? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectTwoRings
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06005800 RID: 22528 RVA: 0x000D7347 File Offset: 0x000D5547
		public override ECircuitConnectMode Type
		{
			get
			{
				return (ECircuitConnectMode)this.Instance.Type;
			}
		}

		// Token: 0x04003280 RID: 12928
		private ICircuitConnectTwoRings Instance;
	}
}
