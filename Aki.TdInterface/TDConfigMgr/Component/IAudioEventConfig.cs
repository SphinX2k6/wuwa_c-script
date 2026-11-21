using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001FC RID: 508
	public class IAudioEventConfig
	{
		// Token: 0x060007F2 RID: 2034 RVA: 0x000267EC File Offset: 0x000249EC
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

		// Token: 0x060007F3 RID: 2035 RVA: 0x00026824 File Offset: 0x00024A24
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

		// Token: 0x060007F4 RID: 2036 RVA: 0x00026837 File Offset: 0x00024A37
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

		// Token: 0x060007F5 RID: 2037 RVA: 0x0002684A File Offset: 0x00024A4A
		public IAudioEventConfig_SetValue ToSetValue()
		{
			return new IAudioEventConfig_SetValue
			{
				CollectAkEvent = this.CollectAkEvent
			};
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0002685D File Offset: 0x00024A5D
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00026884 File Offset: 0x00024A84
		[Nullable(2)]
		public virtual string CollectAkEvent
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CollectAkEvent = value;
			}
		}

		// Token: 0x04000931 RID: 2353
		[Nullable(2)]
		protected IAudioEventConfig FbInstance;

		// Token: 0x04000932 RID: 2354
		[Nullable(2)]
		protected IAudioEventConfig_SetValue PocoInterface;
	}
}
