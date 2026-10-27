using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069CC RID: 27084
	public struct IJigsawConfig : IFlatbufferObject
	{
		// Token: 0x1700C8F2 RID: 51442
		// (get) Token: 0x0602F563 RID: 193891 RVA: 0x0067260A File Offset: 0x0067080A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F564 RID: 193892 RVA: 0x00672617 File Offset: 0x00670817
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F565 RID: 193893 RVA: 0x00672620 File Offset: 0x00670820
		public static IJigsawConfig GetRootAsIJigsawConfig(ByteBuffer _bb)
		{
			return IJigsawConfig.GetRootAsIJigsawConfig(_bb, default(IJigsawConfig));
		}

		// Token: 0x0602F566 RID: 193894 RVA: 0x0067263C File Offset: 0x0067083C
		public static IJigsawConfig GetRootAsIJigsawConfig(ByteBuffer _bb, IJigsawConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F567 RID: 193895 RVA: 0x00672659 File Offset: 0x00670859
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F568 RID: 193896 RVA: 0x00672668 File Offset: 0x00670868
		public IJigsawConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8F3 RID: 51443
		// (get) Token: 0x0602F569 RID: 193897 RVA: 0x00672678 File Offset: 0x00670878
		public int Row
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

		// Token: 0x1700C8F4 RID: 51444
		// (get) Token: 0x0602F56A RID: 193898 RVA: 0x006726B4 File Offset: 0x006708B4
		public int Column
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

		// Token: 0x1700C8F5 RID: 51445
		// (get) Token: 0x0602F56B RID: 193899 RVA: 0x006726F0 File Offset: 0x006708F0
		public int Size
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C8F6 RID: 51446
		// (get) Token: 0x0602F56C RID: 193900 RVA: 0x0067272C File Offset: 0x0067092C
		public EJigsawShape Shape
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EJigsawShape.Circle;
				}
				return (EJigsawShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F56D RID: 193901 RVA: 0x0067276C File Offset: 0x0067096C
		public IJigsawPiece? Pieces(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IJigsawPiece?(default(IJigsawPiece).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C8F7 RID: 51447
		// (get) Token: 0x0602F56E RID: 193902 RVA: 0x006727D0 File Offset: 0x006709D0
		public int PiecesLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700C8F8 RID: 51448
		// (get) Token: 0x0602F56F RID: 193903 RVA: 0x006727FC File Offset: 0x006709FC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F570 RID: 193904 RVA: 0x00672839 File Offset: 0x00670A39
		public static Offset<IJigsawConfig> CreateIJigsawConfig(FlatBufferBuilder builder, int Row = 0, int Column = 0, int Size = 0, EJigsawShape Shape = EJigsawShape.Circle, VectorOffset PiecesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IJigsawConfig.AddPieces(builder, PiecesOffset);
			IJigsawConfig.AddSize(builder, Size);
			IJigsawConfig.AddColumn(builder, Column);
			IJigsawConfig.AddRow(builder, Row);
			IJigsawConfig.AddNullMask(builder, NullMask);
			IJigsawConfig.AddShape(builder, Shape);
			return IJigsawConfig.EndIJigsawConfig(builder);
		}

		// Token: 0x0602F571 RID: 193905 RVA: 0x00672875 File Offset: 0x00670A75
		public static void StartIJigsawConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602F572 RID: 193906 RVA: 0x0067287E File Offset: 0x00670A7E
		public static void AddRow(FlatBufferBuilder builder, int row)
		{
			builder.AddInt(0, row, 0);
		}

		// Token: 0x0602F573 RID: 193907 RVA: 0x00672889 File Offset: 0x00670A89
		public static void AddColumn(FlatBufferBuilder builder, int column)
		{
			builder.AddInt(1, column, 0);
		}

		// Token: 0x0602F574 RID: 193908 RVA: 0x00672894 File Offset: 0x00670A94
		public static void AddSize(FlatBufferBuilder builder, int size)
		{
			builder.AddInt(2, size, 0);
		}

		// Token: 0x0602F575 RID: 193909 RVA: 0x0067289F File Offset: 0x00670A9F
		public static void AddShape(FlatBufferBuilder builder, EJigsawShape shape)
		{
			builder.AddByte(3, (byte)shape, 0);
		}

		// Token: 0x0602F576 RID: 193910 RVA: 0x006728AA File Offset: 0x00670AAA
		public static void AddPieces(FlatBufferBuilder builder, VectorOffset piecesOffset)
		{
			builder.AddOffset(4, piecesOffset.Value, 0);
		}

		// Token: 0x0602F577 RID: 193911 RVA: 0x006728BC File Offset: 0x00670ABC
		public static VectorOffset CreatePiecesVector(FlatBufferBuilder builder, Offset<IJigsawPiece>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F578 RID: 193912 RVA: 0x006728FC File Offset: 0x00670AFC
		public static VectorOffset CreatePiecesVectorBlock(FlatBufferBuilder builder, Offset<IJigsawPiece>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IJigsawPiece>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F579 RID: 193913 RVA: 0x00672916 File Offset: 0x00670B16
		public static VectorOffset CreatePiecesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IJigsawPiece>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IJigsawPiece>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F57A RID: 193914 RVA: 0x00672934 File Offset: 0x00670B34
		public static VectorOffset CreatePiecesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IJigsawPiece>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F57B RID: 193915 RVA: 0x0067294D File Offset: 0x00670B4D
		public static void StartPiecesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F57C RID: 193916 RVA: 0x00672958 File Offset: 0x00670B58
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602F57D RID: 193917 RVA: 0x00672963 File Offset: 0x00670B63
		public static Offset<IJigsawConfig> EndIJigsawConfig(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawConfig>(builder.EndTable());
		}

		// Token: 0x0602F57E RID: 193918 RVA: 0x00672970 File Offset: 0x00670B70
		public IJigsawConfigT UnPack()
		{
			IJigsawConfigT jigsawConfigT = new IJigsawConfigT();
			this.UnPackTo(jigsawConfigT);
			return jigsawConfigT;
		}

		// Token: 0x0602F57F RID: 193919 RVA: 0x0067298C File Offset: 0x00670B8C
		public void UnPackTo(IJigsawConfigT _o)
		{
			_o.Row = this.Row;
			_o.Column = this.Column;
			_o.Size = this.Size;
			_o.Shape = this.Shape;
			_o.Pieces = new List<IJigsawPieceT>();
			for (int i = 0; i < this.PiecesLength; i++)
			{
				_o.Pieces.Add((this.Pieces(i) != null) ? this.Pieces(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F580 RID: 193920 RVA: 0x00672A28 File Offset: 0x00670C28
		public static Offset<IJigsawConfig> Pack(FlatBufferBuilder builder, IJigsawConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IJigsawConfig>);
			}
			VectorOffset piecesOffset = default(VectorOffset);
			if (_o.Pieces != null)
			{
				Offset<IJigsawPiece>[] array = new Offset<IJigsawPiece>[_o.Pieces.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IJigsawPiece.Pack(builder, _o.Pieces[i]);
				}
				piecesOffset = IJigsawConfig.CreatePiecesVector(builder, array);
			}
			return IJigsawConfig.CreateIJigsawConfig(builder, _o.Row, _o.Column, _o.Size, _o.Shape, piecesOffset, _o.NullMask);
		}

		// Token: 0x04011186 RID: 70022
		private Table __p;
	}
}
