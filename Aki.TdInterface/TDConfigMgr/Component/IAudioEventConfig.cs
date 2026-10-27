using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001D5 RID: 469
	[NullableContext(2)]
	[Nullable(0)]
	public class IAudioEventConfig
	{
		// Token: 0x06000784 RID: 1924 RVA: 0x0002510C File Offset: 0x0002330C
		[NullableContext(1)]
		private IAudioEventConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAudioEventConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAudioEventConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAudioEventConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00025144 File Offset: 0x00023344
		[NullableContext(1)]
		public static IAudioEventConfig Create([Nullable(2)] IAudioEventConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioEventConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00025157 File Offset: 0x00023357
		[NullableContext(1)]
		public static IAudioEventConfig CreateFromSetValue([Nullable(2)] IAudioEventConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAudioEventConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0002516A File Offset: 0x0002336A
		[NullableContext(1)]
		public IAudioEventConfig_SetValue ToSetValue()
		{
			return new IAudioEventConfig_SetValue
			{
				CollectAkEvent = this.CollectAkEvent
			};
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0002517D File Offset: 0x0002337D
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x000251A4 File Offset: 0x000233A4
		public virtual string CollectAkEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CollectAkEvent;
				}
				IAudioEventConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CollectAkEvent;
			}
			set
			{
				this.GetOrCreatePoco().CollectAkEvent = value;
			}
		}

		// Token: 0x040008AA RID: 2218
		protected IAudioEventConfig FbInstance;

		// Token: 0x040008AB RID: 2219
		protected IAudioEventConfig_SetValue PocoInterface;
	}
}
