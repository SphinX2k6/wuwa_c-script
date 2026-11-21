using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049AD RID: 18861
	public struct IRewardConfig : IFlatbufferObject
	{
		// Token: 0x17008405 RID: 33797
		// (get) Token: 0x0601C29E RID: 115358 RVA: 0x003FA412 File Offset: 0x003F8612
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C29F RID: 115359 RVA: 0x003FA41F File Offset: 0x003F861F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C2A0 RID: 115360 RVA: 0x003FA428 File Offset: 0x003F8628
		public static IRewardConfig GetRootAsIRewardConfig(ByteBuffer _bb)
		{
			return IRewardConfig.GetRootAsIRewardConfig(_bb, default(IRewardConfig));
		}

		// Token: 0x0601C2A1 RID: 115361 RVA: 0x003FA444 File Offset: 0x003F8644
		public static IRewardConfig GetRootAsIRewardConfig(ByteBuffer _bb, IRewardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C2A2 RID: 115362 RVA: 0x003FA461 File Offset: 0x003F8661
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C2A3 RID: 115363 RVA: 0x003FA470 File Offset: 0x003F8670
		public IRewardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C2A4 RID: 115364 RVA: 0x003FA480 File Offset: 0x003F8680
		public int RewardNodeIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008406 RID: 33798
		// (get) Token: 0x0601C2A5 RID: 115365 RVA: 0x003FA4C0 File Offset: 0x003F86C0
		public int RewardNodeIdsLength
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

		// Token: 0x0601C2A6 RID: 115366 RVA: 0x003FA4EB File Offset: 0x003F86EB
		public Span<int> GetRewardNodeIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0601C2A7 RID: 115367 RVA: 0x003FA4FA File Offset: 0x003F86FA
		public int[] GetRewardNodeIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0601C2A8 RID: 115368 RVA: 0x003FA508 File Offset: 0x003F8708
		public int TreasureBoxIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008407 RID: 33799
		// (get) Token: 0x0601C2A9 RID: 115369 RVA: 0x003FA548 File Offset: 0x003F8748
		public int TreasureBoxIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601C2AA RID: 115370 RVA: 0x003FA573 File Offset: 0x003F8773
		public Span<int> GetTreasureBoxIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601C2AB RID: 115371 RVA: 0x003FA582 File Offset: 0x003F8782
		public int[] GetTreasureBoxIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601C2AC RID: 115372 RVA: 0x003FA590 File Offset: 0x003F8790
		public int CompleteRewardIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008408 RID: 33800
		// (get) Token: 0x0601C2AD RID: 115373 RVA: 0x003FA5D0 File Offset: 0x003F87D0
		public int CompleteRewardIdsLength
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

		// Token: 0x0601C2AE RID: 115374 RVA: 0x003FA5FB File Offset: 0x003F87FB
		public Span<int> GetCompleteRewardIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601C2AF RID: 115375 RVA: 0x003FA60A File Offset: 0x003F880A
		public int[] GetCompleteRewardIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17008409 RID: 33801
		// (get) Token: 0x0601C2B0 RID: 115376 RVA: 0x003FA618 File Offset: 0x003F8818
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C2B1 RID: 115377 RVA: 0x003FA655 File Offset: 0x003F8855
		public static Offset<IRewardConfig> CreateIRewardConfig(FlatBufferBuilder builder, VectorOffset RewardNodeIdsOffset = default(VectorOffset), VectorOffset TreasureBoxIdsOffset = default(VectorOffset), VectorOffset CompleteRewardIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IRewardConfig.AddCompleteRewardIds(builder, CompleteRewardIdsOffset);
			IRewardConfig.AddTreasureBoxIds(builder, TreasureBoxIdsOffset);
			IRewardConfig.AddRewardNodeIds(builder, RewardNodeIdsOffset);
			IRewardConfig.AddNullMask(builder, NullMask);
			return IRewardConfig.EndIRewardConfig(builder);
		}

		// Token: 0x0601C2B2 RID: 115378 RVA: 0x003FA681 File Offset: 0x003F8881
		public static void StartIRewardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C2B3 RID: 115379 RVA: 0x003FA68A File Offset: 0x003F888A
		public static void AddRewardNodeIds(FlatBufferBuilder builder, VectorOffset rewardNodeIdsOffset)
		{
			builder.AddOffset(0, rewardNodeIdsOffset.Value, 0);
		}

		// Token: 0x0601C2B4 RID: 115380 RVA: 0x003FA69C File Offset: 0x003F889C
		public static VectorOffset CreateRewardNodeIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C2B5 RID: 115381 RVA: 0x003FA6D3 File Offset: 0x003F88D3
		public static VectorOffset CreateRewardNodeIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C2B6 RID: 115382 RVA: 0x003FA6ED File Offset: 0x003F88ED
		public static VectorOffset CreateRewardNodeIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C2B7 RID: 115383 RVA: 0x003FA70B File Offset: 0x003F890B
		public static VectorOffset CreateRewardNodeIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C2B8 RID: 115384 RVA: 0x003FA724 File Offset: 0x003F8924
		public static void StartRewardNodeIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C2B9 RID: 115385 RVA: 0x003FA72F File Offset: 0x003F892F
		public static void AddTreasureBoxIds(FlatBufferBuilder builder, VectorOffset treasureBoxIdsOffset)
		{
			builder.AddOffset(1, treasureBoxIdsOffset.Value, 0);
		}

		// Token: 0x0601C2BA RID: 115386 RVA: 0x003FA740 File Offset: 0x003F8940
		public static VectorOffset CreateTreasureBoxIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C2BB RID: 115387 RVA: 0x003FA777 File Offset: 0x003F8977
		public static VectorOffset CreateTreasureBoxIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C2BC RID: 115388 RVA: 0x003FA791 File Offset: 0x003F8991
		public static VectorOffset CreateTreasureBoxIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C2BD RID: 115389 RVA: 0x003FA7AF File Offset: 0x003F89AF
		public static VectorOffset CreateTreasureBoxIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C2BE RID: 115390 RVA: 0x003FA7C8 File Offset: 0x003F89C8
		public static void StartTreasureBoxIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C2BF RID: 115391 RVA: 0x003FA7D3 File Offset: 0x003F89D3
		public static void AddCompleteRewardIds(FlatBufferBuilder builder, VectorOffset completeRewardIdsOffset)
		{
			builder.AddOffset(2, completeRewardIdsOffset.Value, 0);
		}

		// Token: 0x0601C2C0 RID: 115392 RVA: 0x003FA7E4 File Offset: 0x003F89E4
		public static VectorOffset CreateCompleteRewardIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C2C1 RID: 115393 RVA: 0x003FA81B File Offset: 0x003F8A1B
		public static VectorOffset CreateCompleteRewardIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C2C2 RID: 115394 RVA: 0x003FA835 File Offset: 0x003F8A35
		public static VectorOffset CreateCompleteRewardIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C2C3 RID: 115395 RVA: 0x003FA853 File Offset: 0x003F8A53
		public static VectorOffset CreateCompleteRewardIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C2C4 RID: 115396 RVA: 0x003FA86C File Offset: 0x003F8A6C
		public static void StartCompleteRewardIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C2C5 RID: 115397 RVA: 0x003FA877 File Offset: 0x003F8A77
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601C2C6 RID: 115398 RVA: 0x003FA882 File Offset: 0x003F8A82
		public static Offset<IRewardConfig> EndIRewardConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRewardConfig>(builder.EndTable());
		}

		// Token: 0x0601C2C7 RID: 115399 RVA: 0x003FA890 File Offset: 0x003F8A90
		public IRewardConfigT UnPack()
		{
			IRewardConfigT rewardConfigT = new IRewardConfigT();
			this.UnPackTo(rewardConfigT);
			return rewardConfigT;
		}

		// Token: 0x0601C2C8 RID: 115400 RVA: 0x003FA8AC File Offset: 0x003F8AAC
		public void UnPackTo(IRewardConfigT _o)
		{
			_o.RewardNodeIds = new List<int>();
			for (int i = 0; i < this.RewardNodeIdsLength; i++)
			{
				_o.RewardNodeIds.Add(this.RewardNodeIds(i));
			}
			_o.TreasureBoxIds = new List<int>();
			for (int j = 0; j < this.TreasureBoxIdsLength; j++)
			{
				_o.TreasureBoxIds.Add(this.TreasureBoxIds(j));
			}
			_o.CompleteRewardIds = new List<int>();
			for (int k = 0; k < this.CompleteRewardIdsLength; k++)
			{
				_o.CompleteRewardIds.Add(this.CompleteRewardIds(k));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C2C9 RID: 115401 RVA: 0x003FA950 File Offset: 0x003F8B50
		public static Offset<IRewardConfig> Pack(FlatBufferBuilder builder, IRewardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRewardConfig>);
			}
			VectorOffset rewardNodeIdsOffset = default(VectorOffset);
			if (_o.RewardNodeIds != null)
			{
				int[] data = _o.RewardNodeIds.ToArray();
				rewardNodeIdsOffset = IRewardConfig.CreateRewardNodeIdsVector(builder, data);
			}
			VectorOffset treasureBoxIdsOffset = default(VectorOffset);
			if (_o.TreasureBoxIds != null)
			{
				int[] data2 = _o.TreasureBoxIds.ToArray();
				treasureBoxIdsOffset = IRewardConfig.CreateTreasureBoxIdsVector(builder, data2);
			}
			VectorOffset completeRewardIdsOffset = default(VectorOffset);
			if (_o.CompleteRewardIds != null)
			{
				int[] data3 = _o.CompleteRewardIds.ToArray();
				completeRewardIdsOffset = IRewardConfig.CreateCompleteRewardIdsVector(builder, data3);
			}
			return IRewardConfig.CreateIRewardConfig(builder, rewardNodeIdsOffset, treasureBoxIdsOffset, completeRewardIdsOffset, _o.NullMask);
		}

		// Token: 0x0400CFF9 RID: 53241
		private Table __p;
	}
}
