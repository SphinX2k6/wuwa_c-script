using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007B0 RID: 1968
	public class IStateElementalEnableConfig
	{
		// Token: 0x06002A01 RID: 10753 RVA: 0x0006EC7C File Offset: 0x0006CE7C
		private IStateElementalEnableConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateElementalEnableConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateElementalEnableConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateElementalEnableConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x0006ECB4 File Offset: 0x0006CEB4
		public static IStateElementalEnableConfig Create([Nullable(2)] IStateElementalEnableConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateElementalEnableConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x0006ECC7 File Offset: 0x0006CEC7
		public static IStateElementalEnableConfig CreateFromSetValue([Nullable(2)] IStateElementalEnableConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateElementalEnableConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x0006ECDA File Offset: 0x0006CEDA
		public IStateElementalEnableConfig_SetValue ToSetValue()
		{
			return new IStateElementalEnableConfig_SetValue
			{
				State = this.State,
				ElementalEnable = this.ElementalEnable
			};
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x0006ECF9 File Offset: 0x0006CEF9
		// (set) Token: 0x06002A06 RID: 10758 RVA: 0x0006ED24 File Offset: 0x0006CF24
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x0006ED32 File Offset: 0x0006CF32
		// (set) Token: 0x06002A08 RID: 10760 RVA: 0x0006ED5D File Offset: 0x0006CF5D
		public virtual bool ElementalEnable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ElementalEnable;
				}
				return this.PocoInterface != null && this.PocoInterface.ElementalEnable;
			}
			set
			{
				this.GetOrCreatePoco().ElementalEnable = value;
			}
		}

		// Token: 0x04001C4B RID: 7243
		[Nullable(2)]
		protected IStateElementalEnableConfig FbInstance;

		// Token: 0x04001C4C RID: 7244
		[Nullable(2)]
		protected IStateElementalEnableConfig_SetValue PocoInterface;
	}
}
