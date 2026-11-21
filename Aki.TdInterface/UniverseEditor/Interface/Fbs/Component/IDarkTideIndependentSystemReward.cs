using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055D7 RID: 21975
	public struct IDarkTideIndependentSystemReward : IFlatbufferObject
	{
		// Token: 0x17009D52 RID: 40274
		// (get) Token: 0x06022F73 RID: 143219 RVA: 0x004CFF05 File Offset: 0x004CE105
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022F74 RID: 143220 RVA: 0x004CFF12 File Offset: 0x004CE112
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022F75 RID: 143221 RVA: 0x004CFF1C File Offset: 0x004CE11C
		public static IDarkTideIndependentSystemReward GetRootAsIDarkTideIndependentSystemReward(ByteBuffer _bb)
		{
			return IDarkTideIndependentSystemReward.GetRootAsIDarkTideIndependentSystemReward(_bb, default(IDarkTideIndependentSystemReward));
		}

		// Token: 0x06022F76 RID: 143222 RVA: 0x004CFF38 File Offset: 0x004CE138
		public static IDarkTideIndependentSystemReward GetRootAsIDarkTideIndependentSystemReward(ByteBuffer _bb, IDarkTideIndependentSystemReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022F77 RID: 143223 RVA: 0x004CFF55 File Offset: 0x004CE155
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022F78 RID: 143224 RVA: 0x004CFF64 File Offset: 0x004CE164
		public IDarkTideIndependentSystemReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D53 RID: 40275
		// (get) Token: 0x06022F79 RID: 143225 RVA: 0x004CFF74 File Offset: 0x004CE174
		public EIndependentSystemRewardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EIndependentSystemRewardType.DarkTide;
				}
				return (EIndependentSystemRewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009D54 RID: 40276
		// (get) Token: 0x06022F7A RID: 143226 RVA: 0x004CFFB0 File Offset: 0x004CE1B0
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

		// Token: 0x06022F7B RID: 143227 RVA: 0x004CFFEC File Offset: 0x004CE1EC
		public int RewardIdList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009D55 RID: 40277
		// (get) Token: 0x06022F7C RID: 143228 RVA: 0x004D002C File Offset: 0x004CE22C
		public int RewardIdListLength
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

		// Token: 0x06022F7D RID: 143229 RVA: 0x004D0057 File Offset: 0x004CE257
		public Span<int> GetRewardIdListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06022F7E RID: 143230 RVA: 0x004D0066 File Offset: 0x004CE266
		public int[] GetRewardIdListArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17009D56 RID: 40278
		// (get) Token: 0x06022F7F RID: 143231 RVA: 0x004D0074 File Offset: 0x004CE274
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

		// Token: 0x06022F80 RID: 143232 RVA: 0x004D00B1 File Offset: 0x004CE2B1
		public static Offset<IDarkTideIndependentSystemReward> CreateIDarkTideIndependentSystemReward(FlatBufferBuilder builder, EIndependentSystemRewardType Type = EIndependentSystemRewardType.DarkTide, int RewardId = 0, VectorOffset RewardIdListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IDarkTideIndependentSystemReward.AddRewardIdList(builder, RewardIdListOffset);
			IDarkTideIndependentSystemReward.AddRewardId(builder, RewardId);
			IDarkTideIndependentSystemReward.AddNullMask(builder, NullMask);
			IDarkTideIndependentSystemReward.AddType(builder, Type);
			return IDarkTideIndependentSystemReward.EndIDarkTideIndependentSystemReward(builder);
		}

		// Token: 0x06022F81 RID: 143233 RVA: 0x004D00DD File Offset: 0x004CE2DD
		public static void StartIDarkTideIndependentSystemReward(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022F82 RID: 143234 RVA: 0x004D00E6 File Offset: 0x004CE2E6
		public static void AddType(FlatBufferBuilder builder, EIndependentSystemRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022F83 RID: 143235 RVA: 0x004D00F1 File Offset: 0x004CE2F1
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(1, rewardId, 0);
		}

		// Token: 0x06022F84 RID: 143236 RVA: 0x004D00FC File Offset: 0x004CE2FC
		public static void AddRewardIdList(FlatBufferBuilder builder, VectorOffset rewardIdListOffset)
		{
			builder.AddOffset(2, rewardIdListOffset.Value, 0);
		}

		// Token: 0x06022F85 RID: 143237 RVA: 0x004D010C File Offset: 0x004CE30C
		public static VectorOffset CreateRewardIdListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022F86 RID: 143238 RVA: 0x004D0143 File Offset: 0x004CE343
		public static VectorOffset CreateRewardIdListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022F87 RID: 143239 RVA: 0x004D015D File Offset: 0x004CE35D
		public static VectorOffset CreateRewardIdListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022F88 RID: 143240 RVA: 0x004D017B File Offset: 0x004CE37B
		public static VectorOffset CreateRewardIdListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022F89 RID: 143241 RVA: 0x004D0194 File Offset: 0x004CE394
		public static void StartRewardIdListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022F8A RID: 143242 RVA: 0x004D019F File Offset: 0x004CE39F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06022F8B RID: 143243 RVA: 0x004D01AA File Offset: 0x004CE3AA
		public static Offset<IDarkTideIndependentSystemReward> EndIDarkTideIndependentSystemReward(FlatBufferBuilder builder)
		{
			return new Offset<IDarkTideIndependentSystemReward>(builder.EndTable());
		}

		// Token: 0x06022F8C RID: 143244 RVA: 0x004D01B8 File Offset: 0x004CE3B8
		public IDarkTideIndependentSystemRewardT UnPack()
		{
			IDarkTideIndependentSystemRewardT darkTideIndependentSystemRewardT = new IDarkTideIndependentSystemRewardT();
			this.UnPackTo(darkTideIndependentSystemRewardT);
			return darkTideIndependentSystemRewardT;
		}

		// Token: 0x06022F8D RID: 143245 RVA: 0x004D01D4 File Offset: 0x004CE3D4
		public void UnPackTo(IDarkTideIndependentSystemRewardT _o)
		{
			_o.Type = this.Type;
			_o.RewardId = this.RewardId;
			_o.RewardIdList = new List<int>();
			for (int i = 0; i < this.RewardIdListLength; i++)
			{
				_o.RewardIdList.Add(this.RewardIdList(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022F8E RID: 143246 RVA: 0x004D0234 File Offset: 0x004CE434
		public static Offset<IDarkTideIndependentSystemReward> Pack(FlatBufferBuilder builder, IDarkTideIndependentSystemRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDarkTideIndependentSystemReward>);
			}
			VectorOffset rewardIdListOffset = default(VectorOffset);
			if (_o.RewardIdList != null)
			{
				int[] data = _o.RewardIdList.ToArray();
				rewardIdListOffset = IDarkTideIndependentSystemReward.CreateRewardIdListVector(builder, data);
			}
			return IDarkTideIndependentSystemReward.CreateIDarkTideIndependentSystemReward(builder, _o.Type, _o.RewardId, rewardIdListOffset, _o.NullMask);
		}

		// Token: 0x0400EC70 RID: 60528
		private Table __p;
	}
}
