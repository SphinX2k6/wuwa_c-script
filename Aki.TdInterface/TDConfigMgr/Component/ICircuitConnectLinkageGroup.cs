using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000274 RID: 628
	public class ICircuitConnectLinkageGroup
	{
		// Token: 0x06000B1C RID: 2844 RVA: 0x0002D7AC File Offset: 0x0002B9AC
		private ICircuitConnectLinkageGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICircuitConnectLinkageGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICircuitConnectLinkageGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICircuitConnectLinkageGroup_SetValue());
			}
			return result;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0002D7E4 File Offset: 0x0002B9E4
		public static ICircuitConnectLinkageGroup Create([Nullable(2)] ICircuitConnectLinkageGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectLinkageGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0002D7F7 File Offset: 0x0002B9F7
		public static ICircuitConnectLinkageGroup CreateFromSetValue([Nullable(2)] ICircuitConnectLinkageGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICircuitConnectLinkageGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0002D80A File Offset: 0x0002BA0A
		public ICircuitConnectLinkageGroup_SetValue ToSetValue()
		{
			return new ICircuitConnectLinkageGroup_SetValue
			{
				MainDisk = this.MainDisk,
				LinkedDisks = this.LinkedDisks
			};
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0002D829 File Offset: 0x0002BA29
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x0002D854 File Offset: 0x0002BA54
		public virtual ETurntableConnectorDisk MainDisk
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MainDisk;
				}
				if (this.PocoInterface == null)
				{
					return ETurntableConnectorDisk.Disk0;
				}
				return this.PocoInterface.MainDisk;
			}
			set
			{
				this.GetOrCreatePoco().MainDisk = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x0002D862 File Offset: 0x0002BA62
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x0002D889 File Offset: 0x0002BA89
		public virtual List<ETurntableConnectorDisk> LinkedDisks
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LinkedDisks;
				}
				ICircuitConnectLinkageGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LinkedDisks;
			}
			set
			{
				this.GetOrCreatePoco().LinkedDisks = value;
			}
		}

		// Token: 0x04000B16 RID: 2838
		[Nullable(2)]
		protected ICircuitConnectLinkageGroup FbInstance;

		// Token: 0x04000B17 RID: 2839
		[Nullable(2)]
		protected ICircuitConnectLinkageGroup_SetValue PocoInterface;
	}
}
