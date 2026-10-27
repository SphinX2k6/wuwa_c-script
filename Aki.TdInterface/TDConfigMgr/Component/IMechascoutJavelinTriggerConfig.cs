using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004E8 RID: 1256
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechascoutJavelinTriggerConfig : ITeleCtrlTriggerConfig
	{
		// Token: 0x06001984 RID: 6532 RVA: 0x0004B424 File Offset: 0x00049624
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

		// Token: 0x06001985 RID: 6533 RVA: 0x0004B45C File Offset: 0x0004965C
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

		// Token: 0x06001986 RID: 6534 RVA: 0x0004B46F File Offset: 0x0004966F
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

		// Token: 0x06001987 RID: 6535 RVA: 0x0004B482 File Offset: 0x00049682
		public new IMechascoutJavelinTriggerConfig_SetValue ToSetValue()
		{
			return new IMechascoutJavelinTriggerConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x0004B495 File Offset: 0x00049695
		// (set) Token: 0x06001989 RID: 6537 RVA: 0x0004B4C0 File Offset: 0x000496C0
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

		// Token: 0x040012AF RID: 4783
		[Nullable(2)]
		protected new IMechascoutJavelinTriggerConfig FbInstance;

		// Token: 0x040012B0 RID: 4784
		[Nullable(2)]
		protected new IMechascoutJavelinTriggerConfig_SetValue PocoInterface;
	}
}
