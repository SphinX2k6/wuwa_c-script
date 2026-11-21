using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B57 RID: 6999
	public class IDynamicSettlementConfig
	{
		// Token: 0x060094AB RID: 38059 RVA: 0x0015B06C File Offset: 0x0015926C
		private IDynamicSettlementConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDynamicSettlementConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDynamicSettlementConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDynamicSettlementConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060094AC RID: 38060 RVA: 0x0015B0A4 File Offset: 0x001592A4
		public static IDynamicSettlementConfig Create([Nullable(2)] IDynamicSettlementConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicSettlementConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060094AD RID: 38061 RVA: 0x0015B0B7 File Offset: 0x001592B7
		public static IDynamicSettlementConfig CreateFromSetValue([Nullable(2)] IDynamicSettlementConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDynamicSettlementConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060094AE RID: 38062 RVA: 0x0015B0CA File Offset: 0x001592CA
		public IDynamicSettlementConfig_SetValue ToSetValue()
		{
			return new IDynamicSettlementConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F5F RID: 12127
		// (get) Token: 0x060094AF RID: 38063 RVA: 0x0015B0DD File Offset: 0x001592DD
		// (set) Token: 0x060094B0 RID: 38064 RVA: 0x0015B108 File Offset: 0x00159308
		public virtual EDynamicSettlementType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDynamicSettlementType.Battle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005C2E RID: 23598
		[Nullable(2)]
		protected IDynamicSettlementConfig FbInstance;

		// Token: 0x04005C2F RID: 23599
		[Nullable(2)]
		protected IDynamicSettlementConfig_SetValue PocoInterface;
	}
}
