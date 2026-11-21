using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F52 RID: 3922
	public class ICircuitConnectPowerPortLayout : ICircuitConnectLayoutBase
	{
		// Token: 0x060057F5 RID: 22517 RVA: 0x000D727F File Offset: 0x000D547F
		public static ICircuitConnectPowerPortLayout Create(ICircuitConnectPowerPortLayout? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectPowerPortLayout
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x060057F6 RID: 22518 RVA: 0x000D729E File Offset: 0x000D549E
		public override ECircuitConnectElementType Type
		{
			get
			{
				return (ECircuitConnectElementType)this.Instance.Type;
			}
		}

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x060057F7 RID: 22519 RVA: 0x000D72AB File Offset: 0x000D54AB
		public virtual ETurntableConnectorDisk Disk
		{
			get
			{
				return (ETurntableConnectorDisk)this.Instance.Disk;
			}
		}

		// Token: 0x0400327D RID: 12925
		private ICircuitConnectPowerPortLayout Instance;
	}
}
