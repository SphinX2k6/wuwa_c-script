using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DFA RID: 7674
	[NullableContext(1)]
	[Nullable(0)]
	public class ISendBattleEventsForMonsterSummonConfig
	{
		// Token: 0x0600A433 RID: 42035 RVA: 0x001747A8 File Offset: 0x001729A8
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

		// Token: 0x0600A434 RID: 42036 RVA: 0x001747E0 File Offset: 0x001729E0
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

		// Token: 0x0600A435 RID: 42037 RVA: 0x001747F3 File Offset: 0x001729F3
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

		// Token: 0x0600A436 RID: 42038 RVA: 0x00174806 File Offset: 0x00172A06
		public ISendBattleEventsForMonsterSummonConfig_SetValue ToSetValue()
		{
			return new ISendBattleEventsForMonsterSummonConfig_SetValue
			{
				TagConfigId = this.TagConfigId,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x0600A437 RID: 42039 RVA: 0x00174825 File Offset: 0x00172A25
		// (set) Token: 0x0600A438 RID: 42040 RVA: 0x00174850 File Offset: 0x00172A50
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

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x0600A439 RID: 42041 RVA: 0x00174860 File Offset: 0x00172A60
		// (set) Token: 0x0600A43A RID: 42042 RVA: 0x0017489A File Offset: 0x00172A9A
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

		// Token: 0x04006258 RID: 25176
		[Nullable(2)]
		protected ISendBattleEventsForMonsterSummonConfig FbInstance;

		// Token: 0x04006259 RID: 25177
		[Nullable(2)]
		protected ISendBattleEventsForMonsterSummonConfig_SetValue PocoInterface;
	}
}
