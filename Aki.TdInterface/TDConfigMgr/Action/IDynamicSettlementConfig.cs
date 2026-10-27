using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019CA RID: 6602
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicSettlementConfig
	{
		// Token: 0x06008D69 RID: 36201 RVA: 0x0014B560 File Offset: 0x00149760
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

		// Token: 0x06008D6A RID: 36202 RVA: 0x0014B598 File Offset: 0x00149798
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

		// Token: 0x06008D6B RID: 36203 RVA: 0x0014B5AB File Offset: 0x001497AB
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

		// Token: 0x06008D6C RID: 36204 RVA: 0x0014B5BE File Offset: 0x001497BE
		public IDynamicSettlementConfig_SetValue ToSetValue()
		{
			return new IDynamicSettlementConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D5A RID: 11610
		// (get) Token: 0x06008D6D RID: 36205 RVA: 0x0014B5D1 File Offset: 0x001497D1
		// (set) Token: 0x06008D6E RID: 36206 RVA: 0x0014B5FC File Offset: 0x001497FC
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

		// Token: 0x040057D9 RID: 22489
		[Nullable(2)]
		protected IDynamicSettlementConfig FbInstance;

		// Token: 0x040057DA RID: 22490
		[Nullable(2)]
		protected IDynamicSettlementConfig_SetValue PocoInterface;
	}
}
