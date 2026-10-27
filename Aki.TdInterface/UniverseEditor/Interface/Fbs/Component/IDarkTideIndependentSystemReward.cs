using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005075 RID: 20597
	public struct IDarkTideIndependentSystemReward : IFlatbufferObject
	{
		// Token: 0x1700956C RID: 38252
		// (get) Token: 0x06021039 RID: 135225 RVA: 0x00496251 File Offset: 0x00494451
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602103A RID: 135226 RVA: 0x0049625E File Offset: 0x0049445E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602103B RID: 135227 RVA: 0x00496268 File Offset: 0x00494468
		public static IDarkTideIndependentSystemReward GetRootAsIDarkTideIndependentSystemReward(ByteBuffer _bb)
		{
			return IDarkTideIndependentSystemReward.GetRootAsIDarkTideIndependentSystemReward(_bb, default(IDarkTideIndependentSystemReward));
		}

		// Token: 0x0602103C RID: 135228 RVA: 0x00496284 File Offset: 0x00494484
		public static IDarkTideIndependentSystemReward GetRootAsIDarkTideIndependentSystemReward(ByteBuffer _bb, IDarkTideIndependentSystemReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602103D RID: 135229 RVA: 0x004962A1 File Offset: 0x004944A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602103E RID: 135230 RVA: 0x004962B0 File Offset: 0x004944B0
		public IDarkTideIndependentSystemReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700956D RID: 38253
		// (get) Token: 0x0602103F RID: 135231 RVA: 0x004962C0 File Offset: 0x004944C0
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

		// Token: 0x1700956E RID: 38254
		// (get) Token: 0x06021040 RID: 135232 RVA: 0x004962FC File Offset: 0x004944FC
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

		// Token: 0x06021041 RID: 135233 RVA: 0x00496338 File Offset: 0x00494538
		public int RewardIdList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700956F RID: 38255
		// (get) Token: 0x06021042 RID: 135234 RVA: 0x00496378 File Offset: 0x00494578
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

		// Token: 0x06021043 RID: 135235 RVA: 0x004963A3 File Offset: 0x004945A3
		public Span<int> GetRewardIdListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06021044 RID: 135236 RVA: 0x004963B2 File Offset: 0x004945B2
		public int[] GetRewardIdListArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17009570 RID: 38256
		// (get) Token: 0x06021045 RID: 135237 RVA: 0x004963C0 File Offset: 0x004945C0
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

		// Token: 0x06021046 RID: 135238 RVA: 0x004963FD File Offset: 0x004945FD
		public static Offset<IDarkTideIndependentSystemReward> CreateIDarkTideIndependentSystemReward(FlatBufferBuilder builder, EIndependentSystemRewardType Type = EIndependentSystemRewardType.DarkTide, int RewardId = 0, VectorOffset RewardIdListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IDarkTideIndependentSystemReward.AddRewardIdList(builder, RewardIdListOffset);
			IDarkTideIndependentSystemReward.AddRewardId(builder, RewardId);
			IDarkTideIndependentSystemReward.AddNullMask(builder, NullMask);
			IDarkTideIndependentSystemReward.AddType(builder, Type);
			return IDarkTideIndependentSystemReward.EndIDarkTideIndependentSystemReward(builder);
		}

		// Token: 0x06021047 RID: 135239 RVA: 0x00496429 File Offset: 0x00494629
		public static void StartIDarkTideIndependentSystemReward(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06021048 RID: 135240 RVA: 0x00496432 File Offset: 0x00494632
		public static void AddType(FlatBufferBuilder builder, EIndependentSystemRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021049 RID: 135241 RVA: 0x0049643D File Offset: 0x0049463D
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(1, rewardId, 0);
		}

		// Token: 0x0602104A RID: 135242 RVA: 0x00496448 File Offset: 0x00494648
		public static void AddRewardIdList(FlatBufferBuilder builder, VectorOffset rewardIdListOffset)
		{
			builder.AddOffset(2, rewardIdListOffset.Value, 0);
		}

		// Token: 0x0602104B RID: 135243 RVA: 0x00496458 File Offset: 0x00494658
		public static VectorOffset CreateRewardIdListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602104C RID: 135244 RVA: 0x0049648F File Offset: 0x0049468F
		public static VectorOffset CreateRewardIdListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602104D RID: 135245 RVA: 0x004964A9 File Offset: 0x004946A9
		public static VectorOffset CreateRewardIdListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602104E RID: 135246 RVA: 0x004964C7 File Offset: 0x004946C7
		public static VectorOffset CreateRewardIdListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602104F RID: 135247 RVA: 0x004964E0 File Offset: 0x004946E0
		public static void StartRewardIdListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021050 RID: 135248 RVA: 0x004964EB File Offset: 0x004946EB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06021051 RID: 135249 RVA: 0x004964F6 File Offset: 0x004946F6
		public static Offset<IDarkTideIndependentSystemReward> EndIDarkTideIndependentSystemReward(FlatBufferBuilder builder)
		{
			return new Offset<IDarkTideIndependentSystemReward>(builder.EndTable());
		}

		// Token: 0x06021052 RID: 135250 RVA: 0x00496504 File Offset: 0x00494704
		public IDarkTideIndependentSystemRewardT UnPack()
		{
			IDarkTideIndependentSystemRewardT darkTideIndependentSystemRewardT = new IDarkTideIndependentSystemRewardT();
			this.UnPackTo(darkTideIndependentSystemRewardT);
			return darkTideIndependentSystemRewardT;
		}

		// Token: 0x06021053 RID: 135251 RVA: 0x00496520 File Offset: 0x00494720
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

		// Token: 0x06021054 RID: 135252 RVA: 0x00496580 File Offset: 0x00494780
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

		// Token: 0x0400E077 RID: 57463
		private Table __p;
	}
}
