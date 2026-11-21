using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F50 RID: 3920
	public class ICircuitConnectStraightLayout : ICircuitConnectLayoutBase
	{
		// Token: 0x060057ED RID: 22509 RVA: 0x000D71FD File Offset: 0x000D53FD
		public static ICircuitConnectStraightLayout Create(ICircuitConnectStraightLayout? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectStraightLayout
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x060057EE RID: 22510 RVA: 0x000D721C File Offset: 0x000D541C
		public override ECircuitConnectElementType Type
		{
			get
			{
				return (ECircuitConnectElementType)this.Instance.Type;
			}
		}

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x060057EF RID: 22511 RVA: 0x000D7229 File Offset: 0x000D5429
		public virtual ETurntableConnectorDisk Disk
		{
			get
			{
				return (ETurntableConnectorDisk)this.Instance.Disk;
			}
		}

		// Token: 0x0400327B RID: 12923
		private ICircuitConnectStraightLayout Instance;
	}
}
