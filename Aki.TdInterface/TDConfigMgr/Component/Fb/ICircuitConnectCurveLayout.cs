using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F51 RID: 3921
	public class ICircuitConnectCurveLayout : ICircuitConnectLayoutBase
	{
		// Token: 0x060057F1 RID: 22513 RVA: 0x000D723E File Offset: 0x000D543E
		public static ICircuitConnectCurveLayout Create(ICircuitConnectCurveLayout? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectCurveLayout
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x060057F2 RID: 22514 RVA: 0x000D725D File Offset: 0x000D545D
		public override ECircuitConnectElementType Type
		{
			get
			{
				return (ECircuitConnectElementType)this.Instance.Type;
			}
		}

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x060057F3 RID: 22515 RVA: 0x000D726A File Offset: 0x000D546A
		public virtual ETurntableConnectorDisk Disk
		{
			get
			{
				return (ETurntableConnectorDisk)this.Instance.Disk;
			}
		}

		// Token: 0x0400327C RID: 12924
		private ICircuitConnectCurveLayout Instance;
	}
}
