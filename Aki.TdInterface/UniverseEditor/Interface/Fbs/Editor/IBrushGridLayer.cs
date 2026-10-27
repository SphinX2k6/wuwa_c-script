using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004826 RID: 18470
	public struct IBrushGridLayer : IFlatbufferObject
	{
		// Token: 0x17008495 RID: 33941
		// (get) Token: 0x0601C8C3 RID: 116931 RVA: 0x004099CC File Offset: 0x00407BCC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C8C4 RID: 116932 RVA: 0x004099D9 File Offset: 0x00407BD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C8C5 RID: 116933 RVA: 0x004099E0 File Offset: 0x00407BE0
		public static IBrushGridLayer GetRootAsIBrushGridLayer(ByteBuffer _bb)
		{
			return IBrushGridLayer.GetRootAsIBrushGridLayer(_bb, default(IBrushGridLayer));
		}

		// Token: 0x0601C8C6 RID: 116934 RVA: 0x004099FC File Offset: 0x00407BFC
		public static IBrushGridLayer GetRootAsIBrushGridLayer(ByteBuffer _bb, IBrushGridLayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C8C7 RID: 116935 RVA: 0x00409A19 File Offset: 0x00407C19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C8C8 RID: 116936 RVA: 0x00409A28 File Offset: 0x00407C28
		public IBrushGridLayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008496 RID: 33942
		// (get) Token: 0x0601C8C9 RID: 116937 RVA: 0x00409A38 File Offset: 0x00407C38
		public string Name
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C8CA RID: 116938 RVA: 0x00409A6F File Offset: 0x00407C6F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C8CB RID: 116939 RVA: 0x00409A7E File Offset: 0x00407C7E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601C8CC RID: 116940 RVA: 0x00409A8C File Offset: 0x00407C8C
		public IVector2? Cells(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVector2?(default(IVector2).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008497 RID: 33943
		// (get) Token: 0x0601C8CD RID: 116941 RVA: 0x00409AEC File Offset: 0x00407CEC
		public int CellsLength
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

		// Token: 0x0601C8CE RID: 116942 RVA: 0x00409B17 File Offset: 0x00407D17
		public static Offset<IBrushGridLayer> CreateIBrushGridLayer(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), VectorOffset CellsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IBrushGridLayer.AddCells(builder, CellsOffset);
			IBrushGridLayer.AddName(builder, NameOffset);
			return IBrushGridLayer.EndIBrushGridLayer(builder);
		}

		// Token: 0x0601C8CF RID: 116943 RVA: 0x00409B34 File Offset: 0x00407D34
		public static void StartIBrushGridLayer(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C8D0 RID: 116944 RVA: 0x00409B3D File Offset: 0x00407D3D
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x0601C8D1 RID: 116945 RVA: 0x00409B4D File Offset: 0x00407D4D
		public static void AddCells(FlatBufferBuilder builder, VectorOffset cellsOffset)
		{
			builder.AddOffset(1, cellsOffset.Value, 0);
		}

		// Token: 0x0601C8D2 RID: 116946 RVA: 0x00409B60 File Offset: 0x00407D60
		public static VectorOffset CreateCellsVector(FlatBufferBuilder builder, Offset<IVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C8D3 RID: 116947 RVA: 0x00409BA0 File Offset: 0x00407DA0
		public static VectorOffset CreateCellsVectorBlock(FlatBufferBuilder builder, Offset<IVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C8D4 RID: 116948 RVA: 0x00409BBA File Offset: 0x00407DBA
		public static VectorOffset CreateCellsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVector2>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C8D5 RID: 116949 RVA: 0x00409BD8 File Offset: 0x00407DD8
		public static VectorOffset CreateCellsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVector2>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C8D6 RID: 116950 RVA: 0x00409BF1 File Offset: 0x00407DF1
		public static void StartCellsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C8D7 RID: 116951 RVA: 0x00409BFC File Offset: 0x00407DFC
		public static Offset<IBrushGridLayer> EndIBrushGridLayer(FlatBufferBuilder builder)
		{
			return new Offset<IBrushGridLayer>(builder.EndTable());
		}

		// Token: 0x0601C8D8 RID: 116952 RVA: 0x00409C0C File Offset: 0x00407E0C
		public IBrushGridLayerT UnPack()
		{
			IBrushGridLayerT brushGridLayerT = new IBrushGridLayerT();
			this.UnPackTo(brushGridLayerT);
			return brushGridLayerT;
		}

		// Token: 0x0601C8D9 RID: 116953 RVA: 0x00409C28 File Offset: 0x00407E28
		public void UnPackTo(IBrushGridLayerT _o)
		{
			_o.Name = this.Name;
			_o.Cells = new List<IVector2T>();
			for (int i = 0; i < this.CellsLength; i++)
			{
				_o.Cells.Add((this.Cells(i) != null) ? this.Cells(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C8DA RID: 116954 RVA: 0x00409C94 File Offset: 0x00407E94
		public static Offset<IBrushGridLayer> Pack(FlatBufferBuilder builder, IBrushGridLayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBrushGridLayer>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			VectorOffset cellsOffset = default(VectorOffset);
			if (_o.Cells != null)
			{
				Offset<IVector2>[] array = new Offset<IVector2>[_o.Cells.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVector2.Pack(builder, _o.Cells[i]);
				}
				cellsOffset = IBrushGridLayer.CreateCellsVector(builder, array);
			}
			return IBrushGridLayer.CreateIBrushGridLayer(builder, nameOffset, cellsOffset);
		}

		// Token: 0x0400CD4F RID: 52559
		private Table __p;
	}
}
