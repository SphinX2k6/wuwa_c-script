using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D3 RID: 9171
	public class RogueReceiveReward : ActionParams
	{
		// Token: 0x0600C7D6 RID: 51158 RVA: 0x001C9500 File Offset: 0x001C7700
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

		// Token: 0x0600C7D7 RID: 51159 RVA: 0x001C9538 File Offset: 0x001C7738
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

		// Token: 0x0600C7D8 RID: 51160 RVA: 0x001C954B File Offset: 0x001C774B
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

		// Token: 0x0600C7D9 RID: 51161 RVA: 0x001C955E File Offset: 0x001C775E
		public RogueReceiveReward_SetValue ToSetValue()
		{
			return new RogueReceiveReward_SetValue
			{
				RogueRewardReceiveType = this.RogueRewardReceiveType
			};
		}

		// Token: 0x17003C45 RID: 15429
		// (get) Token: 0x0600C7DA RID: 51162 RVA: 0x001C9574 File Offset: 0x001C7774
		// (set) Token: 0x0600C7DB RID: 51163 RVA: 0x001C95AE File Offset: 0x001C77AE
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

		// Token: 0x040076AD RID: 30381
		[Nullable(2)]
		protected new RogueReceiveReward FbInstance;

		// Token: 0x040076AE RID: 30382
		[Nullable(2)]
		protected RogueReceiveReward_SetValue PocoInterface;
	}
}
