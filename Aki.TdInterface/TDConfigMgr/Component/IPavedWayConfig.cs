using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200068B RID: 1675
	public class IPavedWayConfig
	{
		// Token: 0x06002346 RID: 9030 RVA: 0x00060C6C File Offset: 0x0005EE6C
		private IPavedWayConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPavedWayConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPavedWayConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPavedWayConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00060CA4 File Offset: 0x0005EEA4
		public static IPavedWayConfig Create([Nullable(2)] IPavedWayConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPavedWayConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x00060CB7 File Offset: 0x0005EEB7
		public static IPavedWayConfig CreateFromSetValue([Nullable(2)] IPavedWayConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPavedWayConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x00060CCA File Offset: 0x0005EECA
		public IPavedWayConfig_SetValue ToSetValue()
		{
			return new IPavedWayConfig_SetValue
			{
				AutoSprint = this.AutoSprint
			};
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x00060CDD File Offset: 0x0005EEDD
		// (set) Token: 0x0600234B RID: 9035 RVA: 0x00060D08 File Offset: 0x0005EF08
		public virtual bool AutoSprint
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoSprint;
				}
				return this.PocoInterface != null && this.PocoInterface.AutoSprint;
			}
			set
			{
				this.GetOrCreatePoco().AutoSprint = value;
			}
		}

		// Token: 0x0400189C RID: 6300
		[Nullable(2)]
		protected IPavedWayConfig FbInstance;

		// Token: 0x0400189D RID: 6301
		[Nullable(2)]
		protected IPavedWayConfig_SetValue PocoInterface;
	}
}
