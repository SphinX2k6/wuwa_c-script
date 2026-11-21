using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078CF RID: 30927
	public struct IShowTalk_TalkSequenceRow : IFlatbufferObject
	{
		// Token: 0x1700E2F5 RID: 58101
		// (get) Token: 0x0603672F RID: 223023 RVA: 0x0074A735 File Offset: 0x00748935
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036730 RID: 223024 RVA: 0x0074A742 File Offset: 0x00748942
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036731 RID: 223025 RVA: 0x0074A74C File Offset: 0x0074894C
		public static IShowTalk_TalkSequenceRow GetRootAsIShowTalk_TalkSequenceRow(ByteBuffer _bb)
		{
			return IShowTalk_TalkSequenceRow.GetRootAsIShowTalk_TalkSequenceRow(_bb, default(IShowTalk_TalkSequenceRow));
		}

		// Token: 0x06036732 RID: 223026 RVA: 0x0074A768 File Offset: 0x00748968
		public static IShowTalk_TalkSequenceRow GetRootAsIShowTalk_TalkSequenceRow(ByteBuffer _bb, IShowTalk_TalkSequenceRow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036733 RID: 223027 RVA: 0x0074A785 File Offset: 0x00748985
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036734 RID: 223028 RVA: 0x0074A794 File Offset: 0x00748994
		public IShowTalk_TalkSequenceRow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06036735 RID: 223029 RVA: 0x0074A7A4 File Offset: 0x007489A4
		public int Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E2F6 RID: 58102
		// (get) Token: 0x06036736 RID: 223030 RVA: 0x0074A7E4 File Offset: 0x007489E4
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

		// Token: 0x06036737 RID: 223031 RVA: 0x0074A80F File Offset: 0x00748A0F
		public Span<int> GetItemsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06036738 RID: 223032 RVA: 0x0074A81E File Offset: 0x00748A1E
		public int[] GetItemsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06036739 RID: 223033 RVA: 0x0074A82C File Offset: 0x00748A2C
		public static Offset<IShowTalk_TalkSequenceRow> CreateIShowTalk_TalkSequenceRow(FlatBufferBuilder builder, VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IShowTalk_TalkSequenceRow.AddItems(builder, ItemsOffset);
			return IShowTalk_TalkSequenceRow.EndIShowTalk_TalkSequenceRow(builder);
		}

		// Token: 0x0603673A RID: 223034 RVA: 0x0074A842 File Offset: 0x00748A42
		public static void StartIShowTalk_TalkSequenceRow(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603673B RID: 223035 RVA: 0x0074A84B File Offset: 0x00748A4B
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x0603673C RID: 223036 RVA: 0x0074A85C File Offset: 0x00748A5C
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603673D RID: 223037 RVA: 0x0074A893 File Offset: 0x00748A93
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603673E RID: 223038 RVA: 0x0074A8AD File Offset: 0x00748AAD
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603673F RID: 223039 RVA: 0x0074A8CB File Offset: 0x00748ACB
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036740 RID: 223040 RVA: 0x0074A8E4 File Offset: 0x00748AE4
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036741 RID: 223041 RVA: 0x0074A8EF File Offset: 0x00748AEF
		public static Offset<IShowTalk_TalkSequenceRow> EndIShowTalk_TalkSequenceRow(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalk_TalkSequenceRow>(builder.EndTable());
		}

		// Token: 0x06036742 RID: 223042 RVA: 0x0074A8FC File Offset: 0x00748AFC
		public IShowTalk_TalkSequenceRowT UnPack()
		{
			IShowTalk_TalkSequenceRowT showTalk_TalkSequenceRowT = new IShowTalk_TalkSequenceRowT();
			this.UnPackTo(showTalk_TalkSequenceRowT);
			return showTalk_TalkSequenceRowT;
		}

		// Token: 0x06036743 RID: 223043 RVA: 0x0074A918 File Offset: 0x00748B18
		public void UnPackTo(IShowTalk_TalkSequenceRowT _o)
		{
			_o.Items = new List<int>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add(this.Items(i));
			}
		}

		// Token: 0x06036744 RID: 223044 RVA: 0x0074A954 File Offset: 0x00748B54
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

		// Token: 0x04012B80 RID: 76672
		private Table __p;
	}
}
