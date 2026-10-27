using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004545 RID: 17733
	public struct IRewardConfig : IFlatbufferObject
	{
		// Token: 0x17007DC4 RID: 32196
		// (get) Token: 0x0601AAC9 RID: 109257 RVA: 0x003CE176 File Offset: 0x003CC376
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AACA RID: 109258 RVA: 0x003CE183 File Offset: 0x003CC383
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AACB RID: 109259 RVA: 0x003CE18C File Offset: 0x003CC38C
		public static IRewardConfig GetRootAsIRewardConfig(ByteBuffer _bb)
		{
			return IRewardConfig.GetRootAsIRewardConfig(_bb, default(IRewardConfig));
		}

		// Token: 0x0601AACC RID: 109260 RVA: 0x003CE1A8 File Offset: 0x003CC3A8
		public static IRewardConfig GetRootAsIRewardConfig(ByteBuffer _bb, IRewardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AACD RID: 109261 RVA: 0x003CE1C5 File Offset: 0x003CC3C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AACE RID: 109262 RVA: 0x003CE1D4 File Offset: 0x003CC3D4
		public IRewardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601AACF RID: 109263 RVA: 0x003CE1E4 File Offset: 0x003CC3E4
		public int RewardNodeIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007DC5 RID: 32197
		// (get) Token: 0x0601AAD0 RID: 109264 RVA: 0x003CE224 File Offset: 0x003CC424
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

		// Token: 0x0601AAD1 RID: 109265 RVA: 0x003CE24F File Offset: 0x003CC44F
		public Span<int> GetRewardNodeIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0601AAD2 RID: 109266 RVA: 0x003CE25E File Offset: 0x003CC45E
		public int[] GetRewardNodeIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0601AAD3 RID: 109267 RVA: 0x003CE26C File Offset: 0x003CC46C
		public int TreasureBoxIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007DC6 RID: 32198
		// (get) Token: 0x0601AAD4 RID: 109268 RVA: 0x003CE2AC File Offset: 0x003CC4AC
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

		// Token: 0x0601AAD5 RID: 109269 RVA: 0x003CE2D7 File Offset: 0x003CC4D7
		public Span<int> GetTreasureBoxIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601AAD6 RID: 109270 RVA: 0x003CE2E6 File Offset: 0x003CC4E6
		public int[] GetTreasureBoxIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601AAD7 RID: 109271 RVA: 0x003CE2F4 File Offset: 0x003CC4F4
		public int CompleteRewardIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007DC7 RID: 32199
		// (get) Token: 0x0601AAD8 RID: 109272 RVA: 0x003CE334 File Offset: 0x003CC534
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

		// Token: 0x0601AAD9 RID: 109273 RVA: 0x003CE35F File Offset: 0x003CC55F
		public Span<int> GetCompleteRewardIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601AADA RID: 109274 RVA: 0x003CE36E File Offset: 0x003CC56E
		public int[] GetCompleteRewardIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17007DC8 RID: 32200
		// (get) Token: 0x0601AADB RID: 109275 RVA: 0x003CE37C File Offset: 0x003CC57C
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

		// Token: 0x0601AADC RID: 109276 RVA: 0x003CE3B9 File Offset: 0x003CC5B9
		public static Offset<IRewardConfig> CreateIRewardConfig(FlatBufferBuilder builder, VectorOffset RewardNodeIdsOffset = default(VectorOffset), VectorOffset TreasureBoxIdsOffset = default(VectorOffset), VectorOffset CompleteRewardIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IRewardConfig.AddCompleteRewardIds(builder, CompleteRewardIdsOffset);
			IRewardConfig.AddTreasureBoxIds(builder, TreasureBoxIdsOffset);
			IRewardConfig.AddRewardNodeIds(builder, RewardNodeIdsOffset);
			IRewardConfig.AddNullMask(builder, NullMask);
			return IRewardConfig.EndIRewardConfig(builder);
		}

		// Token: 0x0601AADD RID: 109277 RVA: 0x003CE3E5 File Offset: 0x003CC5E5
		public static void StartIRewardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601AADE RID: 109278 RVA: 0x003CE3EE File Offset: 0x003CC5EE
		public static void AddRewardNodeIds(FlatBufferBuilder builder, VectorOffset rewardNodeIdsOffset)
		{
			builder.AddOffset(0, rewardNodeIdsOffset.Value, 0);
		}

		// Token: 0x0601AADF RID: 109279 RVA: 0x003CE400 File Offset: 0x003CC600
		public static VectorOffset CreateRewardNodeIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AAE0 RID: 109280 RVA: 0x003CE437 File Offset: 0x003CC637
		public static VectorOffset CreateRewardNodeIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AAE1 RID: 109281 RVA: 0x003CE451 File Offset: 0x003CC651
		public static VectorOffset CreateRewardNodeIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AAE2 RID: 109282 RVA: 0x003CE46F File Offset: 0x003CC66F
		public static VectorOffset CreateRewardNodeIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AAE3 RID: 109283 RVA: 0x003CE488 File Offset: 0x003CC688
		public static void StartRewardNodeIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601AAE4 RID: 109284 RVA: 0x003CE493 File Offset: 0x003CC693
		public static void AddTreasureBoxIds(FlatBufferBuilder builder, VectorOffset treasureBoxIdsOffset)
		{
			builder.AddOffset(1, treasureBoxIdsOffset.Value, 0);
		}

		// Token: 0x0601AAE5 RID: 109285 RVA: 0x003CE4A4 File Offset: 0x003CC6A4
		public static VectorOffset CreateTreasureBoxIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AAE6 RID: 109286 RVA: 0x003CE4DB File Offset: 0x003CC6DB
		public static VectorOffset CreateTreasureBoxIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AAE7 RID: 109287 RVA: 0x003CE4F5 File Offset: 0x003CC6F5
		public static VectorOffset CreateTreasureBoxIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AAE8 RID: 109288 RVA: 0x003CE513 File Offset: 0x003CC713
		public static VectorOffset CreateTreasureBoxIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AAE9 RID: 109289 RVA: 0x003CE52C File Offset: 0x003CC72C
		public static void StartTreasureBoxIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601AAEA RID: 109290 RVA: 0x003CE537 File Offset: 0x003CC737
		public static void AddCompleteRewardIds(FlatBufferBuilder builder, VectorOffset completeRewardIdsOffset)
		{
			builder.AddOffset(2, completeRewardIdsOffset.Value, 0);
		}

		// Token: 0x0601AAEB RID: 109291 RVA: 0x003CE548 File Offset: 0x003CC748
		public static VectorOffset CreateCompleteRewardIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AAEC RID: 109292 RVA: 0x003CE57F File Offset: 0x003CC77F
		public static VectorOffset CreateCompleteRewardIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AAED RID: 109293 RVA: 0x003CE599 File Offset: 0x003CC799
		public static VectorOffset CreateCompleteRewardIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AAEE RID: 109294 RVA: 0x003CE5B7 File Offset: 0x003CC7B7
		public static VectorOffset CreateCompleteRewardIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AAEF RID: 109295 RVA: 0x003CE5D0 File Offset: 0x003CC7D0
		public static void StartCompleteRewardIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601AAF0 RID: 109296 RVA: 0x003CE5DB File Offset: 0x003CC7DB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601AAF1 RID: 109297 RVA: 0x003CE5E6 File Offset: 0x003CC7E6
		public static Offset<IRewardConfig> EndIRewardConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRewardConfig>(builder.EndTable());
		}

		// Token: 0x0601AAF2 RID: 109298 RVA: 0x003CE5F4 File Offset: 0x003CC7F4
		public IRewardConfigT UnPack()
		{
			IRewardConfigT rewardConfigT = new IRewardConfigT();
			this.UnPackTo(rewardConfigT);
			return rewardConfigT;
		}

		// Token: 0x0601AAF3 RID: 109299 RVA: 0x003CE610 File Offset: 0x003CC810
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

		// Token: 0x0601AAF4 RID: 109300 RVA: 0x003CE6B4 File Offset: 0x003CC8B4
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

		// Token: 0x0400C5CA RID: 50634
		private Table __p;
	}
}
