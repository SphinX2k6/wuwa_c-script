using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002107 RID: 8455
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayDynamicSettlement : ActionParams
	{
		// Token: 0x0600BA04 RID: 47620 RVA: 0x001ADF3C File Offset: 0x001AC13C
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

		// Token: 0x0600BA05 RID: 47621 RVA: 0x001ADF74 File Offset: 0x001AC174
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

		// Token: 0x0600BA06 RID: 47622 RVA: 0x001ADF87 File Offset: 0x001AC187
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

		// Token: 0x0600BA07 RID: 47623 RVA: 0x001ADF9A File Offset: 0x001AC19A
		public PlayDynamicSettlement_SetValue ToSetValue()
		{
			return new PlayDynamicSettlement_SetValue
			{
				DynamicSettlementConfig = this.DynamicSettlementConfig
			};
		}

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x0600BA08 RID: 47624 RVA: 0x001ADFAD File Offset: 0x001AC1AD
		// (set) Token: 0x0600BA09 RID: 47625 RVA: 0x001ADFD4 File Offset: 0x001AC1D4
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

		// Token: 0x04006F60 RID: 28512
		[Nullable(2)]
		protected new PlayDynamicSettlement FbInstance;

		// Token: 0x04006F61 RID: 28513
		[Nullable(2)]
		protected PlayDynamicSettlement_SetValue PocoInterface;
	}
}
