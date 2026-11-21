using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001052 RID: 4178
	public class IDarkTideChonglouTrialBossEvent : IDarkTideBossEvent
	{
		// Token: 0x06005C1C RID: 23580 RVA: 0x000E0448 File Offset: 0x000DE648
		private IDarkTideChonglouTrialBossEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDarkTideChonglouTrialBossEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDarkTideChonglouTrialBossEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDarkTideChonglouTrialBossEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06005C1D RID: 23581 RVA: 0x000E0480 File Offset: 0x000DE680
		public static IDarkTideChonglouTrialBossEvent Create([Nullable(2)] IDarkTideChonglouTrialBossEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideChonglouTrialBossEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C1E RID: 23582 RVA: 0x000E0493 File Offset: 0x000DE693
		public static IDarkTideChonglouTrialBossEvent CreateFromSetValue([Nullable(2)] IDarkTideChonglouTrialBossEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDarkTideChonglouTrialBossEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C1F RID: 23583 RVA: 0x000E04A6 File Offset: 0x000DE6A6
		public new IDarkTideChonglouTrialBossEvent_SetValue ToSetValue()
		{
			return new IDarkTideChonglouTrialBossEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x06005C20 RID: 23584 RVA: 0x000E04B9 File Offset: 0x000DE6B9
		// (set) Token: 0x06005C21 RID: 23585 RVA: 0x000E04E4 File Offset: 0x000DE6E4
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

		// Token: 0x04003789 RID: 14217
		[Nullable(2)]
		protected new IDarkTideChonglouTrialBossEvent FbInstance;

		// Token: 0x0400378A RID: 14218
		[Nullable(2)]
		protected new IDarkTideChonglouTrialBossEvent_SetValue PocoInterface;
	}
}
