using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002172 RID: 8562
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueReceiveReward : ActionParams
	{
		// Token: 0x0600BC48 RID: 48200 RVA: 0x001B234C File Offset: 0x001B054C
		private RogueReceiveReward_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RogueReceiveReward 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RogueReceiveReward_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RogueReceiveReward_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC49 RID: 48201 RVA: 0x001B2384 File Offset: 0x001B0584
		public static RogueReceiveReward Create([Nullable(2)] RogueReceiveReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RogueReceiveReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC4A RID: 48202 RVA: 0x001B2397 File Offset: 0x001B0597
		public static RogueReceiveReward CreateFromSetValue([Nullable(2)] RogueReceiveReward_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RogueReceiveReward
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC4B RID: 48203 RVA: 0x001B23AA File Offset: 0x001B05AA
		public RogueReceiveReward_SetValue ToSetValue()
		{
			return new RogueReceiveReward_SetValue
			{
				RogueRewardReceiveType = this.RogueRewardReceiveType
			};
		}

		// Token: 0x17003958 RID: 14680
		// (get) Token: 0x0600BC4C RID: 48204 RVA: 0x001B23C0 File Offset: 0x001B05C0
		// (set) Token: 0x0600BC4D RID: 48205 RVA: 0x001B23FA File Offset: 0x001B05FA
		public virtual ERogueRewardReceiveType? RogueRewardReceiveType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RogueRewardReceiveType;
				}
				RogueReceiveReward_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RogueRewardReceiveType;
			}
			set
			{
				this.GetOrCreatePoco().RogueRewardReceiveType = value;
			}
		}

		// Token: 0x04007078 RID: 28792
		[Nullable(2)]
		protected new RogueReceiveReward FbInstance;

		// Token: 0x04007079 RID: 28793
		[Nullable(2)]
		protected RogueReceiveReward_SetValue PocoInterface;
	}
}
