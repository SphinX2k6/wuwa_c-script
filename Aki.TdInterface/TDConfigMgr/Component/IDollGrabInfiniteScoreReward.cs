using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000308 RID: 776
	public class IDollGrabInfiniteScoreReward
	{
		// Token: 0x06000E75 RID: 3701 RVA: 0x00034C70 File Offset: 0x00032E70
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

		// Token: 0x06000E76 RID: 3702 RVA: 0x00034CA8 File Offset: 0x00032EA8
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

		// Token: 0x06000E77 RID: 3703 RVA: 0x00034CBB File Offset: 0x00032EBB
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

		// Token: 0x06000E78 RID: 3704 RVA: 0x00034CCE File Offset: 0x00032ECE
		public IDollGrabInfiniteScoreReward_SetValue ToSetValue()
		{
			return new IDollGrabInfiniteScoreReward_SetValue
			{
				TargetScore = this.TargetScore,
				RewardId = this.RewardId
			};
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x00034CED File Offset: 0x00032EED
		// (set) Token: 0x06000E7A RID: 3706 RVA: 0x00034D18 File Offset: 0x00032F18
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

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x00034D26 File Offset: 0x00032F26
		// (set) Token: 0x06000E7C RID: 3708 RVA: 0x00034D51 File Offset: 0x00032F51
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

		// Token: 0x04000D03 RID: 3331
		[Nullable(2)]
		protected IDollGrabInfiniteScoreReward FbInstance;

		// Token: 0x04000D04 RID: 3332
		[Nullable(2)]
		protected IDollGrabInfiniteScoreReward_SetValue PocoInterface;
	}
}
