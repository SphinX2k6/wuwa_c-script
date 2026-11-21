using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C8E RID: 19598
	public struct IBrushGridLayer : IFlatbufferObject
	{
		// Token: 0x17008AE0 RID: 35552
		// (get) Token: 0x0601E0C0 RID: 123072 RVA: 0x0043631C File Offset: 0x0043451C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E0C1 RID: 123073 RVA: 0x00436329 File Offset: 0x00434529
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E0C2 RID: 123074 RVA: 0x00436330 File Offset: 0x00434530
		public static IBrushGridLayer GetRootAsIBrushGridLayer(ByteBuffer _bb)
		{
			return IBrushGridLayer.GetRootAsIBrushGridLayer(_bb, default(IBrushGridLayer));
		}

		// Token: 0x0601E0C3 RID: 123075 RVA: 0x0043634C File Offset: 0x0043454C
		public static IBrushGridLayer GetRootAsIBrushGridLayer(ByteBuffer _bb, IBrushGridLayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E0C4 RID: 123076 RVA: 0x00436369 File Offset: 0x00434569
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E0C5 RID: 123077 RVA: 0x00436378 File Offset: 0x00434578
		public IBrushGridLayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AE1 RID: 35553
		// (get) Token: 0x0601E0C6 RID: 123078 RVA: 0x00436388 File Offset: 0x00434588
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

		// Token: 0x0601E0C7 RID: 123079 RVA: 0x004363BF File Offset: 0x004345BF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E0C8 RID: 123080 RVA: 0x004363CE File Offset: 0x004345CE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601E0C9 RID: 123081 RVA: 0x004363DC File Offset: 0x004345DC
		public IVector2? Cells(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVector2?(default(IVector2).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008AE2 RID: 35554
		// (get) Token: 0x0601E0CA RID: 123082 RVA: 0x0043643C File Offset: 0x0043463C
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

		// Token: 0x0601E0CB RID: 123083 RVA: 0x00436467 File Offset: 0x00434667
		public static Offset<IBrushGridLayer> CreateIBrushGridLayer(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), VectorOffset CellsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IBrushGridLayer.AddCells(builder, CellsOffset);
			IBrushGridLayer.AddName(builder, NameOffset);
			return IBrushGridLayer.EndIBrushGridLayer(builder);
		}

		// Token: 0x0601E0CC RID: 123084 RVA: 0x00436484 File Offset: 0x00434684
		public static void StartIBrushGridLayer(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E0CD RID: 123085 RVA: 0x0043648D File Offset: 0x0043468D
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x0601E0CE RID: 123086 RVA: 0x0043649D File Offset: 0x0043469D
		public static void AddCells(FlatBufferBuilder builder, VectorOffset cellsOffset)
		{
			builder.AddOffset(1, cellsOffset.Value, 0);
		}

		// Token: 0x0601E0CF RID: 123087 RVA: 0x004364B0 File Offset: 0x004346B0
		public static VectorOffset CreateCellsVector(FlatBufferBuilder builder, Offset<IVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E0D0 RID: 123088 RVA: 0x004364F0 File Offset: 0x004346F0
		public static VectorOffset CreateCellsVectorBlock(FlatBufferBuilder builder, Offset<IVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E0D1 RID: 123089 RVA: 0x0043650A File Offset: 0x0043470A
		public static VectorOffset CreateCellsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVector2>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E0D2 RID: 123090 RVA: 0x00436528 File Offset: 0x00434728
		public static VectorOffset CreateCellsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVector2>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E0D3 RID: 123091 RVA: 0x00436541 File Offset: 0x00434741
		public static void StartCellsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E0D4 RID: 123092 RVA: 0x0043654C File Offset: 0x0043474C
		public static Offset<IBrushGridLayer> EndIBrushGridLayer(FlatBufferBuilder builder)
		{
			return new Offset<IBrushGridLayer>(builder.EndTable());
		}

		// Token: 0x0601E0D5 RID: 123093 RVA: 0x0043655C File Offset: 0x0043475C
		public IBrushGridLayerT UnPack()
		{
			IBrushGridLayerT brushGridLayerT = new IBrushGridLayerT();
			this.UnPackTo(brushGridLayerT);
			return brushGridLayerT;
		}

		// Token: 0x0601E0D6 RID: 123094 RVA: 0x00436578 File Offset: 0x00434778
		public void UnPackTo(IBrushGridLayerT _o)
		{
			_o.Name = this.Name;
			_o.Cells = new List<IVector2T>();
			for (int i = 0; i < this.CellsLength; i++)
			{
				_o.Cells.Add((this.Cells(i) != null) ? this.Cells(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601E0D7 RID: 123095 RVA: 0x004365E4 File Offset: 0x004347E4
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

		// Token: 0x0400D78A RID: 55178
		private Table __p;
	}
}
