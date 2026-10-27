using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006975 RID: 26997
	public struct IInstrumentQteConfig_QteSequenceRow : IFlatbufferObject
	{
		// Token: 0x1700C83B RID: 51259
		// (get) Token: 0x0602F24C RID: 193100 RVA: 0x0066C40B File Offset: 0x0066A60B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F24D RID: 193101 RVA: 0x0066C418 File Offset: 0x0066A618
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F24E RID: 193102 RVA: 0x0066C420 File Offset: 0x0066A620
		public static IInstrumentQteConfig_QteSequenceRow GetRootAsIInstrumentQteConfig_QteSequenceRow(ByteBuffer _bb)
		{
			return IInstrumentQteConfig_QteSequenceRow.GetRootAsIInstrumentQteConfig_QteSequenceRow(_bb, default(IInstrumentQteConfig_QteSequenceRow));
		}

		// Token: 0x0602F24F RID: 193103 RVA: 0x0066C43C File Offset: 0x0066A63C
		public static IInstrumentQteConfig_QteSequenceRow GetRootAsIInstrumentQteConfig_QteSequenceRow(ByteBuffer _bb, IInstrumentQteConfig_QteSequenceRow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F250 RID: 193104 RVA: 0x0066C459 File Offset: 0x0066A659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F251 RID: 193105 RVA: 0x0066C468 File Offset: 0x0066A668
		public IInstrumentQteConfig_QteSequenceRow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602F252 RID: 193106 RVA: 0x0066C478 File Offset: 0x0066A678
		public int Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C83C RID: 51260
		// (get) Token: 0x0602F253 RID: 193107 RVA: 0x0066C4B8 File Offset: 0x0066A6B8
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

		// Token: 0x0602F254 RID: 193108 RVA: 0x0066C4E3 File Offset: 0x0066A6E3
		public Span<int> GetItemsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602F255 RID: 193109 RVA: 0x0066C4F2 File Offset: 0x0066A6F2
		public int[] GetItemsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0602F256 RID: 193110 RVA: 0x0066C500 File Offset: 0x0066A700
		public static Offset<IInstrumentQteConfig_QteSequenceRow> CreateIInstrumentQteConfig_QteSequenceRow(FlatBufferBuilder builder, VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IInstrumentQteConfig_QteSequenceRow.AddItems(builder, ItemsOffset);
			return IInstrumentQteConfig_QteSequenceRow.EndIInstrumentQteConfig_QteSequenceRow(builder);
		}

		// Token: 0x0602F257 RID: 193111 RVA: 0x0066C516 File Offset: 0x0066A716
		public static void StartIInstrumentQteConfig_QteSequenceRow(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F258 RID: 193112 RVA: 0x0066C51F File Offset: 0x0066A71F
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x0602F259 RID: 193113 RVA: 0x0066C530 File Offset: 0x0066A730
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F25A RID: 193114 RVA: 0x0066C567 File Offset: 0x0066A767
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F25B RID: 193115 RVA: 0x0066C581 File Offset: 0x0066A781
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F25C RID: 193116 RVA: 0x0066C59F File Offset: 0x0066A79F
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F25D RID: 193117 RVA: 0x0066C5B8 File Offset: 0x0066A7B8
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F25E RID: 193118 RVA: 0x0066C5C3 File Offset: 0x0066A7C3
		public static Offset<IInstrumentQteConfig_QteSequenceRow> EndIInstrumentQteConfig_QteSequenceRow(FlatBufferBuilder builder)
		{
			return new Offset<IInstrumentQteConfig_QteSequenceRow>(builder.EndTable());
		}

		// Token: 0x0602F25F RID: 193119 RVA: 0x0066C5D0 File Offset: 0x0066A7D0
		public IInstrumentQteConfig_QteSequenceRowT UnPack()
		{
			IInstrumentQteConfig_QteSequenceRowT instrumentQteConfig_QteSequenceRowT = new IInstrumentQteConfig_QteSequenceRowT();
			this.UnPackTo(instrumentQteConfig_QteSequenceRowT);
			return instrumentQteConfig_QteSequenceRowT;
		}

		// Token: 0x0602F260 RID: 193120 RVA: 0x0066C5EC File Offset: 0x0066A7EC
		public void UnPackTo(IInstrumentQteConfig_QteSequenceRowT _o)
		{
			_o.Items = new List<int>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add(this.Items(i));
			}
		}

		// Token: 0x0602F261 RID: 193121 RVA: 0x0066C628 File Offset: 0x0066A828
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

		// Token: 0x040110FC RID: 69884
		private Table __p;
	}
}
