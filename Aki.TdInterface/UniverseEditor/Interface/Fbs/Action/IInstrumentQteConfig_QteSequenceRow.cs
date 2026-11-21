using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007028 RID: 28712
	public struct IInstrumentQteConfig_QteSequenceRow : IFlatbufferObject
	{
		// Token: 0x1700D23E RID: 53822
		// (get) Token: 0x06031C1C RID: 203804 RVA: 0x006BC8F3 File Offset: 0x006BAAF3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031C1D RID: 203805 RVA: 0x006BC900 File Offset: 0x006BAB00
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031C1E RID: 203806 RVA: 0x006BC908 File Offset: 0x006BAB08
		public static IInstrumentQteConfig_QteSequenceRow GetRootAsIInstrumentQteConfig_QteSequenceRow(ByteBuffer _bb)
		{
			return IInstrumentQteConfig_QteSequenceRow.GetRootAsIInstrumentQteConfig_QteSequenceRow(_bb, default(IInstrumentQteConfig_QteSequenceRow));
		}

		// Token: 0x06031C1F RID: 203807 RVA: 0x006BC924 File Offset: 0x006BAB24
		public static IInstrumentQteConfig_QteSequenceRow GetRootAsIInstrumentQteConfig_QteSequenceRow(ByteBuffer _bb, IInstrumentQteConfig_QteSequenceRow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031C20 RID: 203808 RVA: 0x006BC941 File Offset: 0x006BAB41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031C21 RID: 203809 RVA: 0x006BC950 File Offset: 0x006BAB50
		public IInstrumentQteConfig_QteSequenceRow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06031C22 RID: 203810 RVA: 0x006BC960 File Offset: 0x006BAB60
		public int Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D23F RID: 53823
		// (get) Token: 0x06031C23 RID: 203811 RVA: 0x006BC9A0 File Offset: 0x006BABA0
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

		// Token: 0x06031C24 RID: 203812 RVA: 0x006BC9CB File Offset: 0x006BABCB
		public Span<int> GetItemsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06031C25 RID: 203813 RVA: 0x006BC9DA File Offset: 0x006BABDA
		public int[] GetItemsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06031C26 RID: 203814 RVA: 0x006BC9E8 File Offset: 0x006BABE8
		public static Offset<IInstrumentQteConfig_QteSequenceRow> CreateIInstrumentQteConfig_QteSequenceRow(FlatBufferBuilder builder, VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IInstrumentQteConfig_QteSequenceRow.AddItems(builder, ItemsOffset);
			return IInstrumentQteConfig_QteSequenceRow.EndIInstrumentQteConfig_QteSequenceRow(builder);
		}

		// Token: 0x06031C27 RID: 203815 RVA: 0x006BC9FE File Offset: 0x006BABFE
		public static void StartIInstrumentQteConfig_QteSequenceRow(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031C28 RID: 203816 RVA: 0x006BCA07 File Offset: 0x006BAC07
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x06031C29 RID: 203817 RVA: 0x006BCA18 File Offset: 0x006BAC18
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031C2A RID: 203818 RVA: 0x006BCA4F File Offset: 0x006BAC4F
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031C2B RID: 203819 RVA: 0x006BCA69 File Offset: 0x006BAC69
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031C2C RID: 203820 RVA: 0x006BCA87 File Offset: 0x006BAC87
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031C2D RID: 203821 RVA: 0x006BCAA0 File Offset: 0x006BACA0
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031C2E RID: 203822 RVA: 0x006BCAAB File Offset: 0x006BACAB
		public static Offset<IInstrumentQteConfig_QteSequenceRow> EndIInstrumentQteConfig_QteSequenceRow(FlatBufferBuilder builder)
		{
			return new Offset<IInstrumentQteConfig_QteSequenceRow>(builder.EndTable());
		}

		// Token: 0x06031C2F RID: 203823 RVA: 0x006BCAB8 File Offset: 0x006BACB8
		public IInstrumentQteConfig_QteSequenceRowT UnPack()
		{
			IInstrumentQteConfig_QteSequenceRowT instrumentQteConfig_QteSequenceRowT = new IInstrumentQteConfig_QteSequenceRowT();
			this.UnPackTo(instrumentQteConfig_QteSequenceRowT);
			return instrumentQteConfig_QteSequenceRowT;
		}

		// Token: 0x06031C30 RID: 203824 RVA: 0x006BCAD4 File Offset: 0x006BACD4
		public void UnPackTo(IInstrumentQteConfig_QteSequenceRowT _o)
		{
			_o.Items = new List<int>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add(this.Items(i));
			}
		}

		// Token: 0x06031C31 RID: 203825 RVA: 0x006BCB10 File Offset: 0x006BAD10
		public static Offset<IInstrumentQteConfig_QteSequenceRow> Pack(FlatBufferBuilder builder, IInstrumentQteConfig_QteSequenceRowT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInstrumentQteConfig_QteSequenceRow>);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				int[] data = _o.Items.ToArray();
				itemsOffset = IInstrumentQteConfig_QteSequenceRow.CreateItemsVector(builder, data);
			}
			return IInstrumentQteConfig_QteSequenceRow.CreateIInstrumentQteConfig_QteSequenceRow(builder, itemsOffset);
		}

		// Token: 0x04011F68 RID: 73576
		private Table __p;
	}
}
