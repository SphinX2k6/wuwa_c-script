using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000623 RID: 1571
	public class IParkourPointLayerConfig
	{
		// Token: 0x060020F6 RID: 8438 RVA: 0x0005C1B4 File Offset: 0x0005A3B4
		private IParkourPointLayerConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IParkourPointLayerConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IParkourPointLayerConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IParkourPointLayerConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x0005C1EC File Offset: 0x0005A3EC
		public static IParkourPointLayerConfig Create([Nullable(2)] IParkourPointLayerConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IParkourPointLayerConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x0005C1FF File Offset: 0x0005A3FF
		public static IParkourPointLayerConfig CreateFromSetValue([Nullable(2)] IParkourPointLayerConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IParkourPointLayerConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x0005C212 File Offset: 0x0005A412
		public IParkourPointLayerConfig_SetValue ToSetValue()
		{
			return new IParkourPointLayerConfig_SetValue
			{
				Width = this.Width,
				Length = this.Length
			};
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060020FA RID: 8442 RVA: 0x0005C231 File Offset: 0x0005A431
		// (set) Token: 0x060020FB RID: 8443 RVA: 0x0005C25C File Offset: 0x0005A45C
		public virtual int Width
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Width;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Width;
			}
			set
			{
				this.GetOrCreatePoco().Width = value;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x0005C26A File Offset: 0x0005A46A
		// (set) Token: 0x060020FD RID: 8445 RVA: 0x0005C295 File Offset: 0x0005A495
		public virtual int Length
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Length;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Length;
			}
			set
			{
				this.GetOrCreatePoco().Length = value;
			}
		}

		// Token: 0x04001760 RID: 5984
		[Nullable(2)]
		protected IParkourPointLayerConfig FbInstance;

		// Token: 0x04001761 RID: 5985
		[Nullable(2)]
		protected IParkourPointLayerConfig_SetValue PocoInterface;
	}
}
