using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001DB RID: 475
	[NullableContext(1)]
	[Nullable(0)]
	public class IAudioRangeConfig
	{
		// Token: 0x060007A4 RID: 1956 RVA: 0x00025450 File Offset: 0x00023650
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

		// Token: 0x060007A5 RID: 1957 RVA: 0x00025488 File Offset: 0x00023688
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

		// Token: 0x060007A6 RID: 1958 RVA: 0x0002549B File Offset: 0x0002369B
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

		// Token: 0x060007A7 RID: 1959 RVA: 0x000254AE File Offset: 0x000236AE
		public IAudioRangeConfig_SetValue ToSetValue()
		{
			return new IAudioRangeConfig_SetValue
			{
				LeaveAkEvent = this.LeaveAkEvent
			};
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x000254C1 File Offset: 0x000236C1
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x000254EC File Offset: 0x000236EC
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

		// Token: 0x040008B7 RID: 2231
		[Nullable(2)]
		protected IAudioRangeConfig FbInstance;

		// Token: 0x040008B8 RID: 2232
		[Nullable(2)]
		protected IAudioRangeConfig_SetValue PocoInterface;
	}
}
