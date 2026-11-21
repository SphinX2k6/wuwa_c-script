using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200202D RID: 8237
	public class ISendBattleEventsForMonsterSummonConfig
	{
		// Token: 0x0600AEDB RID: 44763 RVA: 0x0018A1B0 File Offset: 0x001883B0
		private ISendBattleEventsForMonsterSummonConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISendBattleEventsForMonsterSummonConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISendBattleEventsForMonsterSummonConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISendBattleEventsForMonsterSummonConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600AEDC RID: 44764 RVA: 0x0018A1E8 File Offset: 0x001883E8
		public static ISendBattleEventsForMonsterSummonConfig Create([Nullable(2)] ISendBattleEventsForMonsterSummonConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISendBattleEventsForMonsterSummonConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AEDD RID: 44765 RVA: 0x0018A1FB File Offset: 0x001883FB
		public static ISendBattleEventsForMonsterSummonConfig CreateFromSetValue([Nullable(2)] ISendBattleEventsForMonsterSummonConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISendBattleEventsForMonsterSummonConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AEDE RID: 44766 RVA: 0x0018A20E File Offset: 0x0018840E
		public ISendBattleEventsForMonsterSummonConfig_SetValue ToSetValue()
		{
			return new ISendBattleEventsForMonsterSummonConfig_SetValue
			{
				TagConfigId = this.TagConfigId,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x17003538 RID: 13624
		// (get) Token: 0x0600AEDF RID: 44767 RVA: 0x0018A22D File Offset: 0x0018842D
		// (set) Token: 0x0600AEE0 RID: 44768 RVA: 0x0018A258 File Offset: 0x00188458
		public virtual int TagConfigId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TagConfigId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TagConfigId;
			}
			set
			{
				this.GetOrCreatePoco().TagConfigId = value;
			}
		}

		// Token: 0x17003539 RID: 13625
		// (get) Token: 0x0600AEE1 RID: 44769 RVA: 0x0018A268 File Offset: 0x00188468
		// (set) Token: 0x0600AEE2 RID: 44770 RVA: 0x0018A2A2 File Offset: 0x001884A2
		public virtual int? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				ISendBattleEventsForMonsterSummonConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x0400682F RID: 26671
		[Nullable(2)]
		protected ISendBattleEventsForMonsterSummonConfig FbInstance;

		// Token: 0x04006830 RID: 26672
		[Nullable(2)]
		protected ISendBattleEventsForMonsterSummonConfig_SetValue PocoInterface;
	}
}
