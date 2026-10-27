using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005096 RID: 20630
	public struct IDollGrabInfiniteModeData : IFlatbufferObject
	{
		// Token: 0x170095D3 RID: 38355
		// (get) Token: 0x060211D1 RID: 135633 RVA: 0x00499E14 File Offset: 0x00498014
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060211D2 RID: 135634 RVA: 0x00499E21 File Offset: 0x00498021
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060211D3 RID: 135635 RVA: 0x00499E28 File Offset: 0x00498028
		public static IDollGrabInfiniteModeData GetRootAsIDollGrabInfiniteModeData(ByteBuffer _bb)
		{
			return IDollGrabInfiniteModeData.GetRootAsIDollGrabInfiniteModeData(_bb, default(IDollGrabInfiniteModeData));
		}

		// Token: 0x060211D4 RID: 135636 RVA: 0x00499E44 File Offset: 0x00498044
		public static IDollGrabInfiniteModeData GetRootAsIDollGrabInfiniteModeData(ByteBuffer _bb, IDollGrabInfiniteModeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060211D5 RID: 135637 RVA: 0x00499E61 File Offset: 0x00498061
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060211D6 RID: 135638 RVA: 0x00499E70 File Offset: 0x00498070
		public IDollGrabInfiniteModeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060211D7 RID: 135639 RVA: 0x00499E80 File Offset: 0x00498080
		public IDollGrabStandbyPoolItem? StandbyItemPool(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IDollGrabStandbyPoolItem?(default(IDollGrabStandbyPoolItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170095D4 RID: 38356
		// (get) Token: 0x060211D8 RID: 135640 RVA: 0x00499EE0 File Offset: 0x004980E0
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

		// Token: 0x170095D5 RID: 38357
		// (get) Token: 0x060211D9 RID: 135641 RVA: 0x00499F0C File Offset: 0x0049810C
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

		// Token: 0x060211DA RID: 135642 RVA: 0x00499F43 File Offset: 0x00498143
		public Span<byte> GetRefreshIntervalCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060211DB RID: 135643 RVA: 0x00499F52 File Offset: 0x00498152
		public byte[] GetRefreshIntervalCurveArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060211DC RID: 135644 RVA: 0x00499F60 File Offset: 0x00498160
		public IDollGrabInfiniteStageConfig? StageConfigs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IDollGrabInfiniteStageConfig?(default(IDollGrabInfiniteStageConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170095D6 RID: 38358
		// (get) Token: 0x060211DD RID: 135645 RVA: 0x00499FC0 File Offset: 0x004981C0
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

		// Token: 0x060211DE RID: 135646 RVA: 0x00499FEC File Offset: 0x004981EC
		public IDollGrabInfiniteScoreReward? ScoreRewards(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IDollGrabInfiniteScoreReward?(default(IDollGrabInfiniteScoreReward).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170095D7 RID: 38359
		// (get) Token: 0x060211DF RID: 135647 RVA: 0x0049A050 File Offset: 0x00498250
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

		// Token: 0x170095D8 RID: 38360
		// (get) Token: 0x060211E0 RID: 135648 RVA: 0x0049A07C File Offset: 0x0049827C
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

		// Token: 0x170095D9 RID: 38361
		// (get) Token: 0x060211E1 RID: 135649 RVA: 0x0049A0DC File Offset: 0x004982DC
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

		// Token: 0x170095DA RID: 38362
		// (get) Token: 0x060211E2 RID: 135650 RVA: 0x0049A11C File Offset: 0x0049831C
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

		// Token: 0x060211E3 RID: 135651 RVA: 0x0049A15C File Offset: 0x0049835C
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

		// Token: 0x060211E4 RID: 135652 RVA: 0x0049A1AB File Offset: 0x004983AB
		public static void StartIDollGrabInfiniteModeData(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060211E5 RID: 135653 RVA: 0x0049A1B4 File Offset: 0x004983B4
		public static void AddStandbyItemPool(FlatBufferBuilder builder, VectorOffset standbyItemPoolOffset)
		{
			builder.AddOffset(0, standbyItemPoolOffset.Value, 0);
		}

		// Token: 0x060211E6 RID: 135654 RVA: 0x0049A1C4 File Offset: 0x004983C4
		public static VectorOffset CreateStandbyItemPoolVector(FlatBufferBuilder builder, Offset<IDollGrabStandbyPoolItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060211E7 RID: 135655 RVA: 0x0049A204 File Offset: 0x00498404
		public static VectorOffset CreateStandbyItemPoolVectorBlock(FlatBufferBuilder builder, Offset<IDollGrabStandbyPoolItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDollGrabStandbyPoolItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x060211E8 RID: 135656 RVA: 0x0049A21E File Offset: 0x0049841E
		public static VectorOffset CreateStandbyItemPoolVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDollGrabStandbyPoolItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDollGrabStandbyPoolItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x060211E9 RID: 135657 RVA: 0x0049A23C File Offset: 0x0049843C
		public static VectorOffset CreateStandbyItemPoolVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDollGrabStandbyPoolItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060211EA RID: 135658 RVA: 0x0049A255 File Offset: 0x00498455
		public static void StartStandbyItemPoolVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060211EB RID: 135659 RVA: 0x0049A260 File Offset: 0x00498460
		public static void AddRefreshIntervalCurve(FlatBufferBuilder builder, StringOffset refreshIntervalCurveOffset)
		{
			builder.AddOffset(1, refreshIntervalCurveOffset.Value, 0);
		}

		// Token: 0x060211EC RID: 135660 RVA: 0x0049A270 File Offset: 0x00498470
		public static void AddStageConfigs(FlatBufferBuilder builder, VectorOffset stageConfigsOffset)
		{
			builder.AddOffset(2, stageConfigsOffset.Value, 0);
		}

		// Token: 0x060211ED RID: 135661 RVA: 0x0049A280 File Offset: 0x00498480
		public static VectorOffset CreateStageConfigsVector(FlatBufferBuilder builder, Offset<IDollGrabInfiniteStageConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060211EE RID: 135662 RVA: 0x0049A2C0 File Offset: 0x004984C0
		public static VectorOffset CreateStageConfigsVectorBlock(FlatBufferBuilder builder, Offset<IDollGrabInfiniteStageConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDollGrabInfiniteStageConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060211EF RID: 135663 RVA: 0x0049A2DA File Offset: 0x004984DA
		public static VectorOffset CreateStageConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDollGrabInfiniteStageConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDollGrabInfiniteStageConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060211F0 RID: 135664 RVA: 0x0049A2F8 File Offset: 0x004984F8
		public static VectorOffset CreateStageConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDollGrabInfiniteStageConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060211F1 RID: 135665 RVA: 0x0049A311 File Offset: 0x00498511
		public static void StartStageConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060211F2 RID: 135666 RVA: 0x0049A31C File Offset: 0x0049851C
		public static void AddScoreRewards(FlatBufferBuilder builder, VectorOffset scoreRewardsOffset)
		{
			builder.AddOffset(3, scoreRewardsOffset.Value, 0);
		}

		// Token: 0x060211F3 RID: 135667 RVA: 0x0049A32C File Offset: 0x0049852C
		public static VectorOffset CreateScoreRewardsVector(FlatBufferBuilder builder, Offset<IDollGrabInfiniteScoreReward>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060211F4 RID: 135668 RVA: 0x0049A36C File Offset: 0x0049856C
		public static VectorOffset CreateScoreRewardsVectorBlock(FlatBufferBuilder builder, Offset<IDollGrabInfiniteScoreReward>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDollGrabInfiniteScoreReward>>(data);
			return builder.EndVector();
		}

		// Token: 0x060211F5 RID: 135669 RVA: 0x0049A386 File Offset: 0x00498586
		public static VectorOffset CreateScoreRewardsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDollGrabInfiniteScoreReward>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDollGrabInfiniteScoreReward>>(data);
			return builder.EndVector();
		}

		// Token: 0x060211F6 RID: 135670 RVA: 0x0049A3A4 File Offset: 0x004985A4
		public static VectorOffset CreateScoreRewardsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDollGrabInfiniteScoreReward>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060211F7 RID: 135671 RVA: 0x0049A3BD File Offset: 0x004985BD
		public static void StartScoreRewardsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060211F8 RID: 135672 RVA: 0x0049A3C8 File Offset: 0x004985C8
		public static void AddScoreReward(FlatBufferBuilder builder, Offset<IDollGrabInfiniteScoreReward> scoreRewardOffset)
		{
			builder.AddOffset(4, scoreRewardOffset.Value, 0);
		}

		// Token: 0x060211F9 RID: 135673 RVA: 0x0049A3D8 File Offset: 0x004985D8
		public static void AddUnlockConditionGroupId(FlatBufferBuilder builder, int unlockConditionGroupId)
		{
			builder.AddInt(5, unlockConditionGroupId, 0);
		}

		// Token: 0x060211FA RID: 135674 RVA: 0x0049A3E3 File Offset: 0x004985E3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060211FB RID: 135675 RVA: 0x0049A3EE File Offset: 0x004985EE
		public static Offset<IDollGrabInfiniteModeData> EndIDollGrabInfiniteModeData(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabInfiniteModeData>(builder.EndTable());
		}

		// Token: 0x060211FC RID: 135676 RVA: 0x0049A3FC File Offset: 0x004985FC
		public IDollGrabInfiniteModeDataT UnPack()
		{
			IDollGrabInfiniteModeDataT dollGrabInfiniteModeDataT = new IDollGrabInfiniteModeDataT();
			this.UnPackTo(dollGrabInfiniteModeDataT);
			return dollGrabInfiniteModeDataT;
		}

		// Token: 0x060211FD RID: 135677 RVA: 0x0049A418 File Offset: 0x00498618
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

		// Token: 0x060211FE RID: 135678 RVA: 0x0049A580 File Offset: 0x00498780
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

		// Token: 0x0400E0AF RID: 57519
		private Table __p;
	}
}
