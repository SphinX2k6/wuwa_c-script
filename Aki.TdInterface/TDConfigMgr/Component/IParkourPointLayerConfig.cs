using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005B8 RID: 1464
	[NullableContext(1)]
	[Nullable(0)]
	public class IParkourPointLayerConfig
	{
		// Token: 0x06001EE6 RID: 7910 RVA: 0x00057188 File Offset: 0x00055388
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

		// Token: 0x06001EE7 RID: 7911 RVA: 0x000571C0 File Offset: 0x000553C0
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

		// Token: 0x06001EE8 RID: 7912 RVA: 0x000571D3 File Offset: 0x000553D3
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

		// Token: 0x06001EE9 RID: 7913 RVA: 0x000571E6 File Offset: 0x000553E6
		public IParkourPointLayerConfig_SetValue ToSetValue()
		{
			return new IParkourPointLayerConfig_SetValue
			{
				Width = this.Width,
				Length = this.Length
			};
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001EEA RID: 7914 RVA: 0x00057205 File Offset: 0x00055405
		// (set) Token: 0x06001EEB RID: 7915 RVA: 0x00057230 File Offset: 0x00055430
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

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001EEC RID: 7916 RVA: 0x0005723E File Offset: 0x0005543E
		// (set) Token: 0x06001EED RID: 7917 RVA: 0x00057269 File Offset: 0x00055469
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

		// Token: 0x040015EC RID: 5612
		[Nullable(2)]
		protected IParkourPointLayerConfig FbInstance;

		// Token: 0x040015ED RID: 5613
		[Nullable(2)]
		protected IParkourPointLayerConfig_SetValue PocoInterface;
	}
}
