using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200084D RID: 2125
	public class ITurntableConnectorGameplayBase
	{
		// Token: 0x06002DC0 RID: 11712 RVA: 0x00076CFC File Offset: 0x00074EFC
		private ITurntableConnectorGameplayBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITurntableConnectorGameplayBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITurntableConnectorGameplayBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITurntableConnectorGameplayBase_SetValue());
			}
			return result;
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x00076D34 File Offset: 0x00074F34
		public static ITurntableConnectorGameplayBase Create([Nullable(2)] ITurntableConnectorGameplayBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITurntableConnectorGameplayBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00076D47 File Offset: 0x00074F47
		public static ITurntableConnectorGameplayBase CreateFromSetValue([Nullable(2)] ITurntableConnectorGameplayBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITurntableConnectorGameplayBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00076D5A File Offset: 0x00074F5A
		public ITurntableConnectorGameplayBase_SetValue ToSetValue()
		{
			return new ITurntableConnectorGameplayBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06002DC4 RID: 11716 RVA: 0x00076D6D File Offset: 0x00074F6D
		// (set) Token: 0x06002DC5 RID: 11717 RVA: 0x00076D98 File Offset: 0x00074F98
		public virtual ETurntableConnectorGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETurntableConnectorGameplayType.CircuitConnect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001E73 RID: 7795
		[Nullable(2)]
		protected ITurntableConnectorGameplayBase FbInstance;

		// Token: 0x04001E74 RID: 7796
		[Nullable(2)]
		protected ITurntableConnectorGameplayBase_SetValue PocoInterface;
	}
}
