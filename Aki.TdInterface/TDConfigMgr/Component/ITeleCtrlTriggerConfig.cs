using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007F7 RID: 2039
	public class ITeleCtrlTriggerConfig
	{
		// Token: 0x06002BAD RID: 11181 RVA: 0x00072650 File Offset: 0x00070850
		private ITeleCtrlTriggerConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleCtrlTriggerConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleCtrlTriggerConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleCtrlTriggerConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x00072688 File Offset: 0x00070888
		public static ITeleCtrlTriggerConfig Create([Nullable(2)] ITeleCtrlTriggerConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleCtrlTriggerConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x0007269B File Offset: 0x0007089B
		public static ITeleCtrlTriggerConfig CreateFromSetValue([Nullable(2)] ITeleCtrlTriggerConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleCtrlTriggerConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x000726AE File Offset: 0x000708AE
		public ITeleCtrlTriggerConfig_SetValue ToSetValue()
		{
			return new ITeleCtrlTriggerConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002BB1 RID: 11185 RVA: 0x000726C1 File Offset: 0x000708C1
		// (set) Token: 0x06002BB2 RID: 11186 RVA: 0x000726EC File Offset: 0x000708EC
		public virtual ETeleCtrlTriggerType Type
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

		// Token: 0x04001D44 RID: 7492
		[Nullable(2)]
		protected ITeleCtrlTriggerConfig FbInstance;

		// Token: 0x04001D45 RID: 7493
		[Nullable(2)]
		protected ITeleCtrlTriggerConfig_SetValue PocoInterface;
	}
}
