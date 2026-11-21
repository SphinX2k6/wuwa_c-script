using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000541 RID: 1345
	public class IMechascoutJavelinTriggerConfig : ITeleCtrlTriggerConfig
	{
		// Token: 0x06001B1E RID: 6942 RVA: 0x0004F16C File Offset: 0x0004D36C
		private IMechascoutJavelinTriggerConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechascoutJavelinTriggerConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechascoutJavelinTriggerConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechascoutJavelinTriggerConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0004F1A4 File Offset: 0x0004D3A4
		public static IMechascoutJavelinTriggerConfig Create([Nullable(2)] IMechascoutJavelinTriggerConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechascoutJavelinTriggerConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0004F1B7 File Offset: 0x0004D3B7
		public static IMechascoutJavelinTriggerConfig CreateFromSetValue([Nullable(2)] IMechascoutJavelinTriggerConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechascoutJavelinTriggerConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0004F1CA File Offset: 0x0004D3CA
		public new IMechascoutJavelinTriggerConfig_SetValue ToSetValue()
		{
			return new IMechascoutJavelinTriggerConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001B22 RID: 6946 RVA: 0x0004F1DD File Offset: 0x0004D3DD
		// (set) Token: 0x06001B23 RID: 6947 RVA: 0x0004F208 File Offset: 0x0004D408
		public override ETeleCtrlTriggerType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleCtrlTriggerType.MechascoutJavelin;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040013D1 RID: 5073
		[Nullable(2)]
		protected new IMechascoutJavelinTriggerConfig FbInstance;

		// Token: 0x040013D2 RID: 5074
		[Nullable(2)]
		protected new IMechascoutJavelinTriggerConfig_SetValue PocoInterface;
	}
}
