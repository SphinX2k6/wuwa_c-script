using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F53 RID: 3923
	public class ICircuitConnectOutputPortLayout : ICircuitConnectLayoutBase
	{
		// Token: 0x060057F9 RID: 22521 RVA: 0x000D72C0 File Offset: 0x000D54C0
		public static ICircuitConnectOutputPortLayout Create(ICircuitConnectOutputPortLayout? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectOutputPortLayout
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x060057FA RID: 22522 RVA: 0x000D72DF File Offset: 0x000D54DF
		public override ECircuitConnectElementType Type
		{
			get
			{
				return (ECircuitConnectElementType)this.Instance.Type;
			}
		}

		// Token: 0x0400327E RID: 12926
		private ICircuitConnectOutputPortLayout Instance;
	}
}
