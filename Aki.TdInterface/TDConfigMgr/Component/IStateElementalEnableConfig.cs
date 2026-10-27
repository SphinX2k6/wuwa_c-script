using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200070F RID: 1807
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateElementalEnableConfig
	{
		// Token: 0x060026E1 RID: 9953 RVA: 0x00067C0C File Offset: 0x00065E0C
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

		// Token: 0x060026E2 RID: 9954 RVA: 0x00067C44 File Offset: 0x00065E44
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

		// Token: 0x060026E3 RID: 9955 RVA: 0x00067C57 File Offset: 0x00065E57
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

		// Token: 0x060026E4 RID: 9956 RVA: 0x00067C6A File Offset: 0x00065E6A
		public IStateElementalEnableConfig_SetValue ToSetValue()
		{
			return new IStateElementalEnableConfig_SetValue
			{
				State = this.State,
				ElementalEnable = this.ElementalEnable
			};
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x00067C89 File Offset: 0x00065E89
		// (set) Token: 0x060026E6 RID: 9958 RVA: 0x00067CB4 File Offset: 0x00065EB4
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

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x060026E7 RID: 9959 RVA: 0x00067CC2 File Offset: 0x00065EC2
		// (set) Token: 0x060026E8 RID: 9960 RVA: 0x00067CED File Offset: 0x00065EED
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

		// Token: 0x04001A4C RID: 6732
		[Nullable(2)]
		protected IStateElementalEnableConfig FbInstance;

		// Token: 0x04001A4D RID: 6733
		[Nullable(2)]
		protected IStateElementalEnableConfig_SetValue PocoInterface;
	}
}
