using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002C1 RID: 705
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollGrabInfiniteScoreReward
	{
		// Token: 0x06000D45 RID: 3397 RVA: 0x00031D3C File Offset: 0x0002FF3C
		private IDollGrabInfiniteScoreReward_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDollGrabInfiniteScoreReward 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDollGrabInfiniteScoreReward_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDollGrabInfiniteScoreReward_SetValue());
			}
			return result;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00031D74 File Offset: 0x0002FF74
		public static IDollGrabInfiniteScoreReward Create([Nullable(2)] IDollGrabInfiniteScoreReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabInfiniteScoreReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00031D87 File Offset: 0x0002FF87
		public static IDollGrabInfiniteScoreReward CreateFromSetValue([Nullable(2)] IDollGrabInfiniteScoreReward_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDollGrabInfiniteScoreReward
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00031D9A File Offset: 0x0002FF9A
		public IDollGrabInfiniteScoreReward_SetValue ToSetValue()
		{
			return new IDollGrabInfiniteScoreReward_SetValue
			{
				TargetScore = this.TargetScore,
				RewardId = this.RewardId
			};
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x00031DB9 File Offset: 0x0002FFB9
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x00031DE4 File Offset: 0x0002FFE4
		public virtual int TargetScore
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetScore;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetScore;
			}
			set
			{
				this.GetOrCreatePoco().TargetScore = value;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00031DF2 File Offset: 0x0002FFF2
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x00031E1D File Offset: 0x0003001D
		public virtual int RewardId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RewardId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RewardId;
			}
			set
			{
				this.GetOrCreatePoco().RewardId = value;
			}
		}

		// Token: 0x04000C19 RID: 3097
		[Nullable(2)]
		protected IDollGrabInfiniteScoreReward FbInstance;

		// Token: 0x04000C1A RID: 3098
		[Nullable(2)]
		protected IDollGrabInfiniteScoreReward_SetValue PocoInterface;
	}
}
