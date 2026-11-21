using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055FE RID: 22014
	public struct IDollGrabInfiniteScoreReward : IFlatbufferObject
	{
		// Token: 0x17009DCF RID: 40399
		// (get) Token: 0x06023163 RID: 143715 RVA: 0x004D482D File Offset: 0x004D2A2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023164 RID: 143716 RVA: 0x004D483A File Offset: 0x004D2A3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023165 RID: 143717 RVA: 0x004D4844 File Offset: 0x004D2A44
		public static IDollGrabInfiniteScoreReward GetRootAsIDollGrabInfiniteScoreReward(ByteBuffer _bb)
		{
			return IDollGrabInfiniteScoreReward.GetRootAsIDollGrabInfiniteScoreReward(_bb, default(IDollGrabInfiniteScoreReward));
		}

		// Token: 0x06023166 RID: 143718 RVA: 0x004D4860 File Offset: 0x004D2A60
		public static IDollGrabInfiniteScoreReward GetRootAsIDollGrabInfiniteScoreReward(ByteBuffer _bb, IDollGrabInfiniteScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023167 RID: 143719 RVA: 0x004D487D File Offset: 0x004D2A7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023168 RID: 143720 RVA: 0x004D488C File Offset: 0x004D2A8C
		public IDollGrabInfiniteScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DD0 RID: 40400
		// (get) Token: 0x06023169 RID: 143721 RVA: 0x004D489C File Offset: 0x004D2A9C
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

		// Token: 0x17009DD1 RID: 40401
		// (get) Token: 0x0602316A RID: 143722 RVA: 0x004D48D8 File Offset: 0x004D2AD8
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

		// Token: 0x0602316B RID: 143723 RVA: 0x004D4914 File Offset: 0x004D2B14
		public static Offset<IDollGrabInfiniteScoreReward> CreateIDollGrabInfiniteScoreReward(FlatBufferBuilder builder, int TargetScore = 0, int RewardId = 0)
		{
			builder.StartTable(2);
			IDollGrabInfiniteScoreReward.AddRewardId(builder, RewardId);
			IDollGrabInfiniteScoreReward.AddTargetScore(builder, TargetScore);
			return IDollGrabInfiniteScoreReward.EndIDollGrabInfiniteScoreReward(builder);
		}

		// Token: 0x0602316C RID: 143724 RVA: 0x004D4931 File Offset: 0x004D2B31
		public static void StartIDollGrabInfiniteScoreReward(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602316D RID: 143725 RVA: 0x004D493A File Offset: 0x004D2B3A
		public static void AddTargetScore(FlatBufferBuilder builder, int targetScore)
		{
			builder.AddInt(0, targetScore, 0);
		}

		// Token: 0x0602316E RID: 143726 RVA: 0x004D4945 File Offset: 0x004D2B45
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(1, rewardId, 0);
		}

		// Token: 0x0602316F RID: 143727 RVA: 0x004D4950 File Offset: 0x004D2B50
		public static Offset<IDollGrabInfiniteScoreReward> EndIDollGrabInfiniteScoreReward(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabInfiniteScoreReward>(builder.EndTable());
		}

		// Token: 0x06023170 RID: 143728 RVA: 0x004D4960 File Offset: 0x004D2B60
		public IDollGrabInfiniteScoreRewardT UnPack()
		{
			IDollGrabInfiniteScoreRewardT dollGrabInfiniteScoreRewardT = new IDollGrabInfiniteScoreRewardT();
			this.UnPackTo(dollGrabInfiniteScoreRewardT);
			return dollGrabInfiniteScoreRewardT;
		}

		// Token: 0x06023171 RID: 143729 RVA: 0x004D497B File Offset: 0x004D2B7B
		public void UnPackTo(IDollGrabInfiniteScoreRewardT _o)
		{
			_o.TargetScore = this.TargetScore;
			_o.RewardId = this.RewardId;
		}

		// Token: 0x06023172 RID: 143730 RVA: 0x004D4998 File Offset: 0x004D2B98
		public static Offset<IDollGrabInfiniteScoreReward> Pack(FlatBufferBuilder builder, IDollGrabInfiniteScoreRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabInfiniteScoreReward>);
			}
			return IDollGrabInfiniteScoreReward.CreateIDollGrabInfiniteScoreReward(builder, _o.TargetScore, _o.RewardId);
		}

		// Token: 0x0400ECB4 RID: 60596
		private Table __p;
	}
}
