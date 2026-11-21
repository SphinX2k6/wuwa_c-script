using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F56 RID: 3926
	public class ICircuitConnectThreeRings : ICircuitConnectModeBase
	{
		// Token: 0x06005802 RID: 22530 RVA: 0x000D735C File Offset: 0x000D555C
		public static ICircuitConnectThreeRings Create(ICircuitConnectThreeRings? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectThreeRings
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06005803 RID: 22531 RVA: 0x000D737B File Offset: 0x000D557B
		public override ECircuitConnectMode Type
		{
			get
			{
				return (ECircuitConnectMode)this.Instance.Type;
			}
		}

		// Token: 0x04003281 RID: 12929
		private ICircuitConnectThreeRings Instance;
	}
}
