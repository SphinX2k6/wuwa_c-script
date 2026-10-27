using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005EE RID: 1518
	[NullableContext(1)]
	[Nullable(0)]
	public class IPavedWayConfig
	{
		// Token: 0x06002044 RID: 8260 RVA: 0x00059FF0 File Offset: 0x000581F0
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

		// Token: 0x06002045 RID: 8261 RVA: 0x0005A028 File Offset: 0x00058228
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

		// Token: 0x06002046 RID: 8262 RVA: 0x0005A03B File Offset: 0x0005823B
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

		// Token: 0x06002047 RID: 8263 RVA: 0x0005A04E File Offset: 0x0005824E
		public IPavedWayConfig_SetValue ToSetValue()
		{
			return new IPavedWayConfig_SetValue
			{
				AutoSprint = this.AutoSprint
			};
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x0005A061 File Offset: 0x00058261
		// (set) Token: 0x06002049 RID: 8265 RVA: 0x0005A08C File Offset: 0x0005828C
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

		// Token: 0x040016AC RID: 5804
		[Nullable(2)]
		protected IPavedWayConfig FbInstance;

		// Token: 0x040016AD RID: 5805
		[Nullable(2)]
		protected IPavedWayConfig_SetValue PocoInterface;
	}
}
