using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007103 RID: 28931
	public struct IShowTalk_TalkSequenceRow : IFlatbufferObject
	{
		// Token: 0x1700D712 RID: 55058
		// (get) Token: 0x0603348D RID: 210061 RVA: 0x006EA129 File Offset: 0x006E8329
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603348E RID: 210062 RVA: 0x006EA136 File Offset: 0x006E8336
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603348F RID: 210063 RVA: 0x006EA140 File Offset: 0x006E8340
		public static IShowTalk_TalkSequenceRow GetRootAsIShowTalk_TalkSequenceRow(ByteBuffer _bb)
		{
			return IShowTalk_TalkSequenceRow.GetRootAsIShowTalk_TalkSequenceRow(_bb, default(IShowTalk_TalkSequenceRow));
		}

		// Token: 0x06033490 RID: 210064 RVA: 0x006EA15C File Offset: 0x006E835C
		public static IShowTalk_TalkSequenceRow GetRootAsIShowTalk_TalkSequenceRow(ByteBuffer _bb, IShowTalk_TalkSequenceRow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033491 RID: 210065 RVA: 0x006EA179 File Offset: 0x006E8379
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033492 RID: 210066 RVA: 0x006EA188 File Offset: 0x006E8388
		public IShowTalk_TalkSequenceRow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06033493 RID: 210067 RVA: 0x006EA198 File Offset: 0x006E8398
		public int Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D713 RID: 55059
		// (get) Token: 0x06033494 RID: 210068 RVA: 0x006EA1D8 File Offset: 0x006E83D8
		public int ItemsLength
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

		// Token: 0x06033495 RID: 210069 RVA: 0x006EA203 File Offset: 0x006E8403
		public Span<int> GetItemsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06033496 RID: 210070 RVA: 0x006EA212 File Offset: 0x006E8412
		public int[] GetItemsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06033497 RID: 210071 RVA: 0x006EA220 File Offset: 0x006E8420
		public static Offset<IShowTalk_TalkSequenceRow> CreateIShowTalk_TalkSequenceRow(FlatBufferBuilder builder, VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IShowTalk_TalkSequenceRow.AddItems(builder, ItemsOffset);
			return IShowTalk_TalkSequenceRow.EndIShowTalk_TalkSequenceRow(builder);
		}

		// Token: 0x06033498 RID: 210072 RVA: 0x006EA236 File Offset: 0x006E8436
		public static void StartIShowTalk_TalkSequenceRow(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033499 RID: 210073 RVA: 0x006EA23F File Offset: 0x006E843F
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x0603349A RID: 210074 RVA: 0x006EA250 File Offset: 0x006E8450
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603349B RID: 210075 RVA: 0x006EA287 File Offset: 0x006E8487
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603349C RID: 210076 RVA: 0x006EA2A1 File Offset: 0x006E84A1
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603349D RID: 210077 RVA: 0x006EA2BF File Offset: 0x006E84BF
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603349E RID: 210078 RVA: 0x006EA2D8 File Offset: 0x006E84D8
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603349F RID: 210079 RVA: 0x006EA2E3 File Offset: 0x006E84E3
		public static Offset<IShowTalk_TalkSequenceRow> EndIShowTalk_TalkSequenceRow(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalk_TalkSequenceRow>(builder.EndTable());
		}

		// Token: 0x060334A0 RID: 210080 RVA: 0x006EA2F0 File Offset: 0x006E84F0
		public IShowTalk_TalkSequenceRowT UnPack()
		{
			IShowTalk_TalkSequenceRowT showTalk_TalkSequenceRowT = new IShowTalk_TalkSequenceRowT();
			this.UnPackTo(showTalk_TalkSequenceRowT);
			return showTalk_TalkSequenceRowT;
		}

		// Token: 0x060334A1 RID: 210081 RVA: 0x006EA30C File Offset: 0x006E850C
		public void UnPackTo(IShowTalk_TalkSequenceRowT _o)
		{
			_o.Items = new List<int>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add(this.Items(i));
			}
		}

		// Token: 0x060334A2 RID: 210082 RVA: 0x006EA348 File Offset: 0x006E8548
		public static Offset<IShowTalk_TalkSequenceRow> Pack(FlatBufferBuilder builder, IShowTalk_TalkSequenceRowT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTalk_TalkSequenceRow>);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				int[] data = _o.Items.ToArray();
				itemsOffset = IShowTalk_TalkSequenceRow.CreateItemsVector(builder, data);
			}
			return IShowTalk_TalkSequenceRow.CreateIShowTalk_TalkSequenceRow(builder, itemsOffset);
		}

		// Token: 0x04011B92 RID: 72594
		private Table __p;
	}
}
