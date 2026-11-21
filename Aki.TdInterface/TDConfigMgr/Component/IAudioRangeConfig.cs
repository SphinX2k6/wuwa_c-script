using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000202 RID: 514
	public class IAudioRangeConfig
	{
		// Token: 0x06000812 RID: 2066 RVA: 0x00026B30 File Offset: 0x00024D30
		private IAudioRangeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAudioRangeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAudioRangeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAudioRangeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00026B68 File Offset: 0x00024D68
		public static IAudioRangeConfig Create([Nullable(2)] IAudioRangeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioRangeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00026B7B File Offset: 0x00024D7B
		public static IAudioRangeConfig CreateFromSetValue([Nullable(2)] IAudioRangeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAudioRangeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00026B8E File Offset: 0x00024D8E
		public IAudioRangeConfig_SetValue ToSetValue()
		{
			return new IAudioRangeConfig_SetValue
			{
				LeaveAkEvent = this.LeaveAkEvent
			};
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00026BA1 File Offset: 0x00024DA1
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x00026BCC File Offset: 0x00024DCC
		public virtual string LeaveAkEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LeaveAkEvent;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.LeaveAkEvent;
			}
			set
			{
				this.GetOrCreatePoco().LeaveAkEvent = value;
			}
		}

		// Token: 0x0400093E RID: 2366
		[Nullable(2)]
		protected IAudioRangeConfig FbInstance;

		// Token: 0x0400093F RID: 2367
		[Nullable(2)]
		protected IAudioRangeConfig_SetValue PocoInterface;
	}
}
