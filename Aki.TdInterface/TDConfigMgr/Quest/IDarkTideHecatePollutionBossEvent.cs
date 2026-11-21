using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001056 RID: 4182
	public class IDarkTideHecatePollutionBossEvent : IDarkTideBossEvent
	{
		// Token: 0x06005C2C RID: 23596 RVA: 0x000E05C0 File Offset: 0x000DE7C0
		private IDarkTideHecatePollutionBossEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDarkTideHecatePollutionBossEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDarkTideHecatePollutionBossEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDarkTideHecatePollutionBossEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06005C2D RID: 23597 RVA: 0x000E05F8 File Offset: 0x000DE7F8
		public static IDarkTideHecatePollutionBossEvent Create([Nullable(2)] IDarkTideHecatePollutionBossEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideHecatePollutionBossEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x000E060B File Offset: 0x000DE80B
		public static IDarkTideHecatePollutionBossEvent CreateFromSetValue([Nullable(2)] IDarkTideHecatePollutionBossEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDarkTideHecatePollutionBossEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x000E061E File Offset: 0x000DE81E
		public new IDarkTideHecatePollutionBossEvent_SetValue ToSetValue()
		{
			return new IDarkTideHecatePollutionBossEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x06005C30 RID: 23600 RVA: 0x000E0631 File Offset: 0x000DE831
		// (set) Token: 0x06005C31 RID: 23601 RVA: 0x000E065C File Offset: 0x000DE85C
		public override EDarkTideBossEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDarkTideBossEventType.XinjilemuChase;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400378F RID: 14223
		[Nullable(2)]
		protected new IDarkTideHecatePollutionBossEvent FbInstance;

		// Token: 0x04003790 RID: 14224
		[Nullable(2)]
		protected new IDarkTideHecatePollutionBossEvent_SetValue PocoInterface;
	}
}
