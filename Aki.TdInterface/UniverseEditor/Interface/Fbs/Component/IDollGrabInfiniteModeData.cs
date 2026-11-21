using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055FB RID: 22011
	public struct IDollGrabInfiniteModeData : IFlatbufferObject
	{
		// Token: 0x17009DC0 RID: 40384
		// (get) Token: 0x06023125 RID: 143653 RVA: 0x004D3DA0 File Offset: 0x004D1FA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023126 RID: 143654 RVA: 0x004D3DAD File Offset: 0x004D1FAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023127 RID: 143655 RVA: 0x004D3DB4 File Offset: 0x004D1FB4
		public static IDollGrabInfiniteModeData GetRootAsIDollGrabInfiniteModeData(ByteBuffer _bb)
		{
			return IDollGrabInfiniteModeData.GetRootAsIDollGrabInfiniteModeData(_bb, default(IDollGrabInfiniteModeData));
		}

		// Token: 0x06023128 RID: 143656 RVA: 0x004D3DD0 File Offset: 0x004D1FD0
		public static IDollGrabInfiniteModeData GetRootAsIDollGrabInfiniteModeData(ByteBuffer _bb, IDollGrabInfiniteModeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023129 RID: 143657 RVA: 0x004D3DED File Offset: 0x004D1FED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602312A RID: 143658 RVA: 0x004D3DFC File Offset: 0x004D1FFC
		public IDollGrabInfiniteModeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602312B RID: 143659 RVA: 0x004D3E0C File Offset: 0x004D200C
		public IDollGrabStandbyPoolItem? StandbyItemPool(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IDollGrabStandbyPoolItem?(default(IDollGrabStandbyPoolItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009DC1 RID: 40385
		// (get) Token: 0x0602312C RID: 143660 RVA: 0x004D3E6C File Offset: 0x004D206C
		public int StandbyItemPoolLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009DC2 RID: 40386
		// (get) Token: 0x0602312D RID: 143661 RVA: 0x004D3E98 File Offset: 0x004D2098
		public string RefreshIntervalCurve
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602312E RID: 143662 RVA: 0x004D3ECF File Offset: 0x004D20CF
		public Span<byte> GetRefreshIntervalCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602312F RID: 143663 RVA: 0x004D3EDE File Offset: 0x004D20DE
		public byte[] GetRefreshIntervalCurveArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06023130 RID: 143664 RVA: 0x004D3EEC File Offset: 0x004D20EC
		public IDollGrabInfiniteStageConfig? StageConfigs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IDollGrabInfiniteStageConfig?(default(IDollGrabInfiniteStageConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009DC3 RID: 40387
		// (get) Token: 0x06023131 RID: 143665 RVA: 0x004D3F4C File Offset: 0x004D214C
		public int StageConfigsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06023132 RID: 143666 RVA: 0x004D3F78 File Offset: 0x004D2178
		public IDollGrabInfiniteScoreReward? ScoreRewards(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IDollGrabInfiniteScoreReward?(default(IDollGrabInfiniteScoreReward).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009DC4 RID: 40388
		// (get) Token: 0x06023133 RID: 143667 RVA: 0x004D3FDC File Offset: 0x004D21DC
		public int ScoreRewardsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009DC5 RID: 40389
		// (get) Token: 0x06023134 RID: 143668 RVA: 0x004D4008 File Offset: 0x004D2208
		public IDollGrabInfiniteScoreReward? ScoreReward
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IDollGrabInfiniteScoreReward?(default(IDollGrabInfiniteScoreReward).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009DC6 RID: 40390
		// (get) Token: 0x06023135 RID: 143669 RVA: 0x004D4068 File Offset: 0x004D2268
		public int UnlockConditionGroupId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009DC7 RID: 40391
		// (get) Token: 0x06023136 RID: 143670 RVA: 0x004D40A8 File Offset: 0x004D22A8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023137 RID: 143671 RVA: 0x004D40E8 File Offset: 0x004D22E8
		public static Offset<IDollGrabInfiniteModeData> CreateIDollGrabInfiniteModeData(FlatBufferBuilder builder, VectorOffset StandbyItemPoolOffset = default(VectorOffset), StringOffset RefreshIntervalCurveOffset = default(StringOffset), VectorOffset StageConfigsOffset = default(VectorOffset), VectorOffset ScoreRewardsOffset = default(VectorOffset), Offset<IDollGrabInfiniteScoreReward> ScoreRewardOffset = default(Offset<IDollGrabInfiniteScoreReward>), int UnlockConditionGroupId = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			IDollGrabInfiniteModeData.AddUnlockConditionGroupId(builder, UnlockConditionGroupId);
			IDollGrabInfiniteModeData.AddScoreReward(builder, ScoreRewardOffset);
			IDollGrabInfiniteModeData.AddScoreRewards(builder, ScoreRewardsOffset);
			IDollGrabInfiniteModeData.AddStageConfigs(builder, StageConfigsOffset);
			IDollGrabInfiniteModeData.AddRefreshIntervalCurve(builder, RefreshIntervalCurveOffset);
			IDollGrabInfiniteModeData.AddStandbyItemPool(builder, StandbyItemPoolOffset);
			IDollGrabInfiniteModeData.AddNullMask(builder, NullMask);
			return IDollGrabInfiniteModeData.EndIDollGrabInfiniteModeData(builder);
		}

		// Token: 0x06023138 RID: 143672 RVA: 0x004D4137 File Offset: 0x004D2337
		public static void StartIDollGrabInfiniteModeData(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06023139 RID: 143673 RVA: 0x004D4140 File Offset: 0x004D2340
		public static void AddStandbyItemPool(FlatBufferBuilder builder, VectorOffset standbyItemPoolOffset)
		{
			builder.AddOffset(0, standbyItemPoolOffset.Value, 0);
		}

		// Token: 0x0602313A RID: 143674 RVA: 0x004D4150 File Offset: 0x004D2350
		public static VectorOffset CreateStandbyItemPoolVector(FlatBufferBuilder builder, Offset<IDollGrabStandbyPoolItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602313B RID: 143675 RVA: 0x004D4190 File Offset: 0x004D2390
		public static VectorOffset CreateStandbyItemPoolVectorBlock(FlatBufferBuilder builder, Offset<IDollGrabStandbyPoolItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDollGrabStandbyPoolItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602313C RID: 143676 RVA: 0x004D41AA File Offset: 0x004D23AA
		public static VectorOffset CreateStandbyItemPoolVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDollGrabStandbyPoolItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDollGrabStandbyPoolItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602313D RID: 143677 RVA: 0x004D41C8 File Offset: 0x004D23C8
		public static VectorOffset CreateStandbyItemPoolVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDollGrabStandbyPoolItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602313E RID: 143678 RVA: 0x004D41E1 File Offset: 0x004D23E1
		public static void StartStandbyItemPoolVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602313F RID: 143679 RVA: 0x004D41EC File Offset: 0x004D23EC
		public static void AddRefreshIntervalCurve(FlatBufferBuilder builder, StringOffset refreshIntervalCurveOffset)
		{
			builder.AddOffset(1, refreshIntervalCurveOffset.Value, 0);
		}

		// Token: 0x06023140 RID: 143680 RVA: 0x004D41FC File Offset: 0x004D23FC
		public static void AddStageConfigs(FlatBufferBuilder builder, VectorOffset stageConfigsOffset)
		{
			builder.AddOffset(2, stageConfigsOffset.Value, 0);
		}

		// Token: 0x06023141 RID: 143681 RVA: 0x004D420C File Offset: 0x004D240C
		public static VectorOffset CreateStageConfigsVector(FlatBufferBuilder builder, Offset<IDollGrabInfiniteStageConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023142 RID: 143682 RVA: 0x004D424C File Offset: 0x004D244C
		public static VectorOffset CreateStageConfigsVectorBlock(FlatBufferBuilder builder, Offset<IDollGrabInfiniteStageConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDollGrabInfiniteStageConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023143 RID: 143683 RVA: 0x004D4266 File Offset: 0x004D2466
		public static VectorOffset CreateStageConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDollGrabInfiniteStageConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDollGrabInfiniteStageConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023144 RID: 143684 RVA: 0x004D4284 File Offset: 0x004D2484
		public static VectorOffset CreateStageConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDollGrabInfiniteStageConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023145 RID: 143685 RVA: 0x004D429D File Offset: 0x004D249D
		public static void StartStageConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023146 RID: 143686 RVA: 0x004D42A8 File Offset: 0x004D24A8
		public static void AddScoreRewards(FlatBufferBuilder builder, VectorOffset scoreRewardsOffset)
		{
			builder.AddOffset(3, scoreRewardsOffset.Value, 0);
		}

		// Token: 0x06023147 RID: 143687 RVA: 0x004D42B8 File Offset: 0x004D24B8
		public static VectorOffset CreateScoreRewardsVector(FlatBufferBuilder builder, Offset<IDollGrabInfiniteScoreReward>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023148 RID: 143688 RVA: 0x004D42F8 File Offset: 0x004D24F8
		public static VectorOffset CreateScoreRewardsVectorBlock(FlatBufferBuilder builder, Offset<IDollGrabInfiniteScoreReward>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDollGrabInfiniteScoreReward>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023149 RID: 143689 RVA: 0x004D4312 File Offset: 0x004D2512
		public static VectorOffset CreateScoreRewardsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDollGrabInfiniteScoreReward>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDollGrabInfiniteScoreReward>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602314A RID: 143690 RVA: 0x004D4330 File Offset: 0x004D2530
		public static VectorOffset CreateScoreRewardsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDollGrabInfiniteScoreReward>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602314B RID: 143691 RVA: 0x004D4349 File Offset: 0x004D2549
		public static void StartScoreRewardsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602314C RID: 143692 RVA: 0x004D4354 File Offset: 0x004D2554
		public static void AddScoreReward(FlatBufferBuilder builder, Offset<IDollGrabInfiniteScoreReward> scoreRewardOffset)
		{
			builder.AddOffset(4, scoreRewardOffset.Value, 0);
		}

		// Token: 0x0602314D RID: 143693 RVA: 0x004D4364 File Offset: 0x004D2564
		public static void AddUnlockConditionGroupId(FlatBufferBuilder builder, int unlockConditionGroupId)
		{
			builder.AddInt(5, unlockConditionGroupId, 0);
		}

		// Token: 0x0602314E RID: 143694 RVA: 0x004D436F File Offset: 0x004D256F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602314F RID: 143695 RVA: 0x004D437A File Offset: 0x004D257A
		public static Offset<IDollGrabInfiniteModeData> EndIDollGrabInfiniteModeData(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabInfiniteModeData>(builder.EndTable());
		}

		// Token: 0x06023150 RID: 143696 RVA: 0x004D4388 File Offset: 0x004D2588
		public IDollGrabInfiniteModeDataT UnPack()
		{
			IDollGrabInfiniteModeDataT dollGrabInfiniteModeDataT = new IDollGrabInfiniteModeDataT();
			this.UnPackTo(dollGrabInfiniteModeDataT);
			return dollGrabInfiniteModeDataT;
		}

		// Token: 0x06023151 RID: 143697 RVA: 0x004D43A4 File Offset: 0x004D25A4
		public void UnPackTo(IDollGrabInfiniteModeDataT _o)
		{
			_o.StandbyItemPool = new List<IDollGrabStandbyPoolItemT>();
			for (int i = 0; i < this.StandbyItemPoolLength; i++)
			{
				_o.StandbyItemPool.Add((this.StandbyItemPool(i) != null) ? this.StandbyItemPool(i).Value.UnPack() : null);
			}
			_o.RefreshIntervalCurve = this.RefreshIntervalCurve;
			_o.StageConfigs = new List<IDollGrabInfiniteStageConfigT>();
			for (int j = 0; j < this.StageConfigsLength; j++)
			{
				_o.StageConfigs.Add((this.StageConfigs(j) != null) ? this.StageConfigs(j).Value.UnPack() : null);
			}
			_o.ScoreRewards = new List<IDollGrabInfiniteScoreRewardT>();
			for (int k = 0; k < this.ScoreRewardsLength; k++)
			{
				_o.ScoreRewards.Add((this.ScoreRewards(k) != null) ? this.ScoreRewards(k).Value.UnPack() : null);
			}
			_o.ScoreReward = ((this.ScoreReward != null) ? this.ScoreReward.Value.UnPack() : null);
			_o.UnlockConditionGroupId = this.UnlockConditionGroupId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023152 RID: 143698 RVA: 0x004D450C File Offset: 0x004D270C
		public static Offset<IDollGrabInfiniteModeData> Pack(FlatBufferBuilder builder, IDollGrabInfiniteModeDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabInfiniteModeData>);
			}
			VectorOffset standbyItemPoolOffset = default(VectorOffset);
			if (_o.StandbyItemPool != null)
			{
				Offset<IDollGrabStandbyPoolItem>[] array = new Offset<IDollGrabStandbyPoolItem>[_o.StandbyItemPool.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDollGrabStandbyPoolItem.Pack(builder, _o.StandbyItemPool[i]);
				}
				standbyItemPoolOffset = IDollGrabInfiniteModeData.CreateStandbyItemPoolVector(builder, array);
			}
			StringOffset refreshIntervalCurveOffset = (_o.RefreshIntervalCurve == null) ? default(StringOffset) : builder.CreateString(_o.RefreshIntervalCurve);
			VectorOffset stageConfigsOffset = default(VectorOffset);
			if (_o.StageConfigs != null)
			{
				Offset<IDollGrabInfiniteStageConfig>[] array2 = new Offset<IDollGrabInfiniteStageConfig>[_o.StageConfigs.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IDollGrabInfiniteStageConfig.Pack(builder, _o.StageConfigs[j]);
				}
				stageConfigsOffset = IDollGrabInfiniteModeData.CreateStageConfigsVector(builder, array2);
			}
			VectorOffset scoreRewardsOffset = default(VectorOffset);
			if (_o.ScoreRewards != null)
			{
				Offset<IDollGrabInfiniteScoreReward>[] array3 = new Offset<IDollGrabInfiniteScoreReward>[_o.ScoreRewards.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IDollGrabInfiniteScoreReward.Pack(builder, _o.ScoreRewards[k]);
				}
				scoreRewardsOffset = IDollGrabInfiniteModeData.CreateScoreRewardsVector(builder, array3);
			}
			Offset<IDollGrabInfiniteScoreReward> scoreRewardOffset = (_o.ScoreReward == null) ? default(Offset<IDollGrabInfiniteScoreReward>) : IDollGrabInfiniteScoreReward.Pack(builder, _o.ScoreReward);
			return IDollGrabInfiniteModeData.CreateIDollGrabInfiniteModeData(builder, standbyItemPoolOffset, refreshIntervalCurveOffset, stageConfigsOffset, scoreRewardsOffset, scoreRewardOffset, _o.UnlockConditionGroupId, _o.NullMask);
		}

		// Token: 0x0400ECAC RID: 60588
		private Table __p;
	}
}
