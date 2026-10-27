using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001210 RID: 4624
	[NullableContext(1)]
	[Nullable(0)]
	public class IWaveConfig
	{
		// Token: 0x060068EA RID: 26858 RVA: 0x000FA390 File Offset: 0x000F8590
		private IWaveConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWaveConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWaveConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWaveConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060068EB RID: 26859 RVA: 0x000FA3C8 File Offset: 0x000F85C8
		public static IWaveConfig Create([Nullable(2)] IWaveConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaveConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060068EC RID: 26860 RVA: 0x000FA3DB File Offset: 0x000F85DB
		public static IWaveConfig CreateFromSetValue([Nullable(2)] IWaveConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWaveConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x000FA3EE File Offset: 0x000F85EE
		public IWaveConfig_SetValue ToSetValue()
		{
			return new IWaveConfig_SetValue
			{
				Id = this.Id
			};
		}

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x060068EE RID: 26862 RVA: 0x000FA401 File Offset: 0x000F8601
		// (set) Token: 0x060068EF RID: 26863 RVA: 0x000FA42C File Offset: 0x000F862C
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04003EC1 RID: 16065
		[Nullable(2)]
		protected IWaveConfig FbInstance;

		// Token: 0x04003EC2 RID: 16066
		[Nullable(2)]
		protected IWaveConfig_SetValue PocoInterface;
	}
}
