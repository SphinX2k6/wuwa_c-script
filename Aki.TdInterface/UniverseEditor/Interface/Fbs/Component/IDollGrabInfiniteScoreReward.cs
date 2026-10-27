using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005099 RID: 20633
	public struct IDollGrabInfiniteScoreReward : IFlatbufferObject
	{
		// Token: 0x170095E2 RID: 38370
		// (get) Token: 0x0602120F RID: 135695 RVA: 0x0049A8A1 File Offset: 0x00498AA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021210 RID: 135696 RVA: 0x0049A8AE File Offset: 0x00498AAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021211 RID: 135697 RVA: 0x0049A8B8 File Offset: 0x00498AB8
		public static IDollGrabInfiniteScoreReward GetRootAsIDollGrabInfiniteScoreReward(ByteBuffer _bb)
		{
			return IDollGrabInfiniteScoreReward.GetRootAsIDollGrabInfiniteScoreReward(_bb, default(IDollGrabInfiniteScoreReward));
		}

		// Token: 0x06021212 RID: 135698 RVA: 0x0049A8D4 File Offset: 0x00498AD4
		public static IDollGrabInfiniteScoreReward GetRootAsIDollGrabInfiniteScoreReward(ByteBuffer _bb, IDollGrabInfiniteScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021213 RID: 135699 RVA: 0x0049A8F1 File Offset: 0x00498AF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021214 RID: 135700 RVA: 0x0049A900 File Offset: 0x00498B00
		public IDollGrabInfiniteScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095E3 RID: 38371
		// (get) Token: 0x06021215 RID: 135701 RVA: 0x0049A910 File Offset: 0x00498B10
		public int TargetScore
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170095E4 RID: 38372
		// (get) Token: 0x06021216 RID: 135702 RVA: 0x0049A94C File Offset: 0x00498B4C
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021217 RID: 135703 RVA: 0x0049A988 File Offset: 0x00498B88
		public static Offset<IDollGrabInfiniteScoreReward> CreateIDollGrabInfiniteScoreReward(FlatBufferBuilder builder, int TargetScore = 0, int RewardId = 0)
		{
			builder.StartTable(2);
			IDollGrabInfiniteScoreReward.AddRewardId(builder, RewardId);
			IDollGrabInfiniteScoreReward.AddTargetScore(builder, TargetScore);
			return IDollGrabInfiniteScoreReward.EndIDollGrabInfiniteScoreReward(builder);
		}

		// Token: 0x06021218 RID: 135704 RVA: 0x0049A9A5 File Offset: 0x00498BA5
		public static void StartIDollGrabInfiniteScoreReward(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021219 RID: 135705 RVA: 0x0049A9AE File Offset: 0x00498BAE
		public static void AddTargetScore(FlatBufferBuilder builder, int targetScore)
		{
			builder.AddInt(0, targetScore, 0);
		}

		// Token: 0x0602121A RID: 135706 RVA: 0x0049A9B9 File Offset: 0x00498BB9
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(1, rewardId, 0);
		}

		// Token: 0x0602121B RID: 135707 RVA: 0x0049A9C4 File Offset: 0x00498BC4
		public static Offset<IDollGrabInfiniteScoreReward> EndIDollGrabInfiniteScoreReward(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabInfiniteScoreReward>(builder.EndTable());
		}

		// Token: 0x0602121C RID: 135708 RVA: 0x0049A9D4 File Offset: 0x00498BD4
		public IDollGrabInfiniteScoreRewardT UnPack()
		{
			IDollGrabInfiniteScoreRewardT dollGrabInfiniteScoreRewardT = new IDollGrabInfiniteScoreRewardT();
			this.UnPackTo(dollGrabInfiniteScoreRewardT);
			return dollGrabInfiniteScoreRewardT;
		}

		// Token: 0x0602121D RID: 135709 RVA: 0x0049A9EF File Offset: 0x00498BEF
		public void UnPackTo(IDollGrabInfiniteScoreRewardT _o)
		{
			_o.TargetScore = this.TargetScore;
			_o.RewardId = this.RewardId;
		}

		// Token: 0x0602121E RID: 135710 RVA: 0x0049AA0C File Offset: 0x00498C0C
		public static Offset<IDollGrabInfiniteScoreReward> Pack(FlatBufferBuilder builder, IDollGrabInfiniteScoreRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabInfiniteScoreReward>);
			}
			return IDollGrabInfiniteScoreReward.CreateIDollGrabInfiniteScoreReward(builder, _o.TargetScore, _o.RewardId);
		}

		// Token: 0x0400E0B7 RID: 57527
		private Table __p;
	}
}
