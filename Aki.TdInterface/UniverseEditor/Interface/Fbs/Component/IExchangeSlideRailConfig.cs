using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005730 RID: 22320
	public struct IExchangeSlideRailConfig : IFlatbufferObject
	{
		// Token: 0x1700A12A RID: 41258
		// (get) Token: 0x06023E7E RID: 147070 RVA: 0x004EFABB File Offset: 0x004EDCBB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023E7F RID: 147071 RVA: 0x004EFAC8 File Offset: 0x004EDCC8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023E80 RID: 147072 RVA: 0x004EFAD0 File Offset: 0x004EDCD0
		public static IExchangeSlideRailConfig GetRootAsIExchangeSlideRailConfig(ByteBuffer _bb)
		{
			return IExchangeSlideRailConfig.GetRootAsIExchangeSlideRailConfig(_bb, default(IExchangeSlideRailConfig));
		}

		// Token: 0x06023E81 RID: 147073 RVA: 0x004EFAEC File Offset: 0x004EDCEC
		public static IExchangeSlideRailConfig GetRootAsIExchangeSlideRailConfig(ByteBuffer _bb, IExchangeSlideRailConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023E82 RID: 147074 RVA: 0x004EFB09 File Offset: 0x004EDD09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023E83 RID: 147075 RVA: 0x004EFB18 File Offset: 0x004EDD18
		public IExchangeSlideRailConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A12B RID: 41259
		// (get) Token: 0x06023E84 RID: 147076 RVA: 0x004EFB28 File Offset: 0x004EDD28
		public int MaxExchangeDistance
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

		// Token: 0x1700A12C RID: 41260
		// (get) Token: 0x06023E85 RID: 147077 RVA: 0x004EFB64 File Offset: 0x004EDD64
		public int MaxExchangeHigh
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

		// Token: 0x06023E86 RID: 147078 RVA: 0x004EFBA0 File Offset: 0x004EDDA0
		public INextSlideRail? NextRails(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new INextSlideRail?(default(INextSlideRail).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A12D RID: 41261
		// (get) Token: 0x06023E87 RID: 147079 RVA: 0x004EFC00 File Offset: 0x004EDE00
		public int NextRailsLength
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

		// Token: 0x1700A12E RID: 41262
		// (get) Token: 0x06023E88 RID: 147080 RVA: 0x004EFC2C File Offset: 0x004EDE2C
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

		// Token: 0x06023E89 RID: 147081 RVA: 0x004EFC69 File Offset: 0x004EDE69
		public static Offset<IExchangeSlideRailConfig> CreateIExchangeSlideRailConfig(FlatBufferBuilder builder, int MaxExchangeDistance = 0, int MaxExchangeHigh = 0, VectorOffset NextRailsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IExchangeSlideRailConfig.AddNextRails(builder, NextRailsOffset);
			IExchangeSlideRailConfig.AddMaxExchangeHigh(builder, MaxExchangeHigh);
			IExchangeSlideRailConfig.AddMaxExchangeDistance(builder, MaxExchangeDistance);
			IExchangeSlideRailConfig.AddNullMask(builder, NullMask);
			return IExchangeSlideRailConfig.EndIExchangeSlideRailConfig(builder);
		}

		// Token: 0x06023E8A RID: 147082 RVA: 0x004EFC95 File Offset: 0x004EDE95
		public static void StartIExchangeSlideRailConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023E8B RID: 147083 RVA: 0x004EFC9E File Offset: 0x004EDE9E
		public static void AddMaxExchangeDistance(FlatBufferBuilder builder, int maxExchangeDistance)
		{
			builder.AddInt(0, maxExchangeDistance, 0);
		}

		// Token: 0x06023E8C RID: 147084 RVA: 0x004EFCA9 File Offset: 0x004EDEA9
		public static void AddMaxExchangeHigh(FlatBufferBuilder builder, int maxExchangeHigh)
		{
			builder.AddInt(1, maxExchangeHigh, 0);
		}

		// Token: 0x06023E8D RID: 147085 RVA: 0x004EFCB4 File Offset: 0x004EDEB4
		public static void AddNextRails(FlatBufferBuilder builder, VectorOffset nextRailsOffset)
		{
			builder.AddOffset(2, nextRailsOffset.Value, 0);
		}

		// Token: 0x06023E8E RID: 147086 RVA: 0x004EFCC4 File Offset: 0x004EDEC4
		public static VectorOffset CreateNextRailsVector(FlatBufferBuilder builder, Offset<INextSlideRail>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023E8F RID: 147087 RVA: 0x004EFD04 File Offset: 0x004EDF04
		public static VectorOffset CreateNextRailsVectorBlock(FlatBufferBuilder builder, Offset<INextSlideRail>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INextSlideRail>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E90 RID: 147088 RVA: 0x004EFD1E File Offset: 0x004EDF1E
		public static VectorOffset CreateNextRailsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INextSlideRail>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INextSlideRail>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E91 RID: 147089 RVA: 0x004EFD3C File Offset: 0x004EDF3C
		public static VectorOffset CreateNextRailsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INextSlideRail>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023E92 RID: 147090 RVA: 0x004EFD55 File Offset: 0x004EDF55
		public static void StartNextRailsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023E93 RID: 147091 RVA: 0x004EFD60 File Offset: 0x004EDF60
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06023E94 RID: 147092 RVA: 0x004EFD6B File Offset: 0x004EDF6B
		public static Offset<IExchangeSlideRailConfig> EndIExchangeSlideRailConfig(FlatBufferBuilder builder)
		{
			return new Offset<IExchangeSlideRailConfig>(builder.EndTable());
		}

		// Token: 0x06023E95 RID: 147093 RVA: 0x004EFD78 File Offset: 0x004EDF78
		public IExchangeSlideRailConfigT UnPack()
		{
			IExchangeSlideRailConfigT exchangeSlideRailConfigT = new IExchangeSlideRailConfigT();
			this.UnPackTo(exchangeSlideRailConfigT);
			return exchangeSlideRailConfigT;
		}

		// Token: 0x06023E96 RID: 147094 RVA: 0x004EFD94 File Offset: 0x004EDF94
		public void UnPackTo(IExchangeSlideRailConfigT _o)
		{
			_o.MaxExchangeDistance = this.MaxExchangeDistance;
			_o.MaxExchangeHigh = this.MaxExchangeHigh;
			_o.NextRails = new List<INextSlideRailT>();
			for (int i = 0; i < this.NextRailsLength; i++)
			{
				_o.NextRails.Add((this.NextRails(i) != null) ? this.NextRails(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023E97 RID: 147095 RVA: 0x004EFE18 File Offset: 0x004EE018
		public static Offset<IExchangeSlideRailConfig> Pack(FlatBufferBuilder builder, IExchangeSlideRailConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExchangeSlideRailConfig>);
			}
			VectorOffset nextRailsOffset = default(VectorOffset);
			if (_o.NextRails != null)
			{
				Offset<INextSlideRail>[] array = new Offset<INextSlideRail>[_o.NextRails.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INextSlideRail.Pack(builder, _o.NextRails[i]);
				}
				nextRailsOffset = IExchangeSlideRailConfig.CreateNextRailsVector(builder, array);
			}
			return IExchangeSlideRailConfig.CreateIExchangeSlideRailConfig(builder, _o.MaxExchangeDistance, _o.MaxExchangeHigh, nextRailsOffset, _o.NullMask);
		}

		// Token: 0x0400EECB RID: 61131
		private Table __p;
	}
}
