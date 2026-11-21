using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002368 RID: 9064
	public class PlayDynamicSettlement : ActionParams
	{
		// Token: 0x0600C590 RID: 50576 RVA: 0x001C509C File Offset: 0x001C329C
		private PlayDynamicSettlement_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayDynamicSettlement 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayDynamicSettlement_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayDynamicSettlement_SetValue());
			}
			return result;
		}

		// Token: 0x0600C591 RID: 50577 RVA: 0x001C50D4 File Offset: 0x001C32D4
		public static PlayDynamicSettlement Create([Nullable(2)] PlayDynamicSettlement instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayDynamicSettlement
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C592 RID: 50578 RVA: 0x001C50E7 File Offset: 0x001C32E7
		public static PlayDynamicSettlement CreateFromSetValue([Nullable(2)] PlayDynamicSettlement_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayDynamicSettlement
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C593 RID: 50579 RVA: 0x001C50FA File Offset: 0x001C32FA
		public PlayDynamicSettlement_SetValue ToSetValue()
		{
			return new PlayDynamicSettlement_SetValue
			{
				DynamicSettlementConfig = this.DynamicSettlementConfig
			};
		}

		// Token: 0x17003BBD RID: 15293
		// (get) Token: 0x0600C594 RID: 50580 RVA: 0x001C510D File Offset: 0x001C330D
		// (set) Token: 0x0600C595 RID: 50581 RVA: 0x001C5134 File Offset: 0x001C3334
		public virtual IDynamicSettlementConfig DynamicSettlementConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DynamicSettlementConfig;
				}
				PlayDynamicSettlement_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DynamicSettlementConfig;
			}
			set
			{
				this.GetOrCreatePoco().DynamicSettlementConfig = value;
			}
		}

		// Token: 0x04007594 RID: 30100
		[Nullable(2)]
		protected new PlayDynamicSettlement FbInstance;

		// Token: 0x04007595 RID: 30101
		[Nullable(2)]
		protected PlayDynamicSettlement_SetValue PocoInterface;
	}
}
