using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200707C RID: 28796
	public struct IJigsawConfig : IFlatbufferObject
	{
		// Token: 0x1700D2F2 RID: 54002
		// (get) Token: 0x06031F23 RID: 204579 RVA: 0x006C2962 File Offset: 0x006C0B62
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031F24 RID: 204580 RVA: 0x006C296F File Offset: 0x006C0B6F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031F25 RID: 204581 RVA: 0x006C2978 File Offset: 0x006C0B78
		public static IJigsawConfig GetRootAsIJigsawConfig(ByteBuffer _bb)
		{
			return IJigsawConfig.GetRootAsIJigsawConfig(_bb, default(IJigsawConfig));
		}

		// Token: 0x06031F26 RID: 204582 RVA: 0x006C2994 File Offset: 0x006C0B94
		public static IJigsawConfig GetRootAsIJigsawConfig(ByteBuffer _bb, IJigsawConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031F27 RID: 204583 RVA: 0x006C29B1 File Offset: 0x006C0BB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031F28 RID: 204584 RVA: 0x006C29C0 File Offset: 0x006C0BC0
		public IJigsawConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2F3 RID: 54003
		// (get) Token: 0x06031F29 RID: 204585 RVA: 0x006C29D0 File Offset: 0x006C0BD0
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

		// Token: 0x1700D2F4 RID: 54004
		// (get) Token: 0x06031F2A RID: 204586 RVA: 0x006C2A0C File Offset: 0x006C0C0C
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

		// Token: 0x1700D2F5 RID: 54005
		// (get) Token: 0x06031F2B RID: 204587 RVA: 0x006C2A48 File Offset: 0x006C0C48
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

		// Token: 0x1700D2F6 RID: 54006
		// (get) Token: 0x06031F2C RID: 204588 RVA: 0x006C2A84 File Offset: 0x006C0C84
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

		// Token: 0x06031F2D RID: 204589 RVA: 0x006C2AC4 File Offset: 0x006C0CC4
		public IJigsawPiece? Pieces(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IJigsawPiece?(default(IJigsawPiece).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D2F7 RID: 54007
		// (get) Token: 0x06031F2E RID: 204590 RVA: 0x006C2B28 File Offset: 0x006C0D28
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

		// Token: 0x1700D2F8 RID: 54008
		// (get) Token: 0x06031F2F RID: 204591 RVA: 0x006C2B54 File Offset: 0x006C0D54
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

		// Token: 0x06031F30 RID: 204592 RVA: 0x006C2B91 File Offset: 0x006C0D91
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

		// Token: 0x06031F31 RID: 204593 RVA: 0x006C2BCD File Offset: 0x006C0DCD
		public static void StartIJigsawConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06031F32 RID: 204594 RVA: 0x006C2BD6 File Offset: 0x006C0DD6
		public static void AddRow(FlatBufferBuilder builder, int row)
		{
			builder.AddInt(0, row, 0);
		}

		// Token: 0x06031F33 RID: 204595 RVA: 0x006C2BE1 File Offset: 0x006C0DE1
		public static void AddColumn(FlatBufferBuilder builder, int column)
		{
			builder.AddInt(1, column, 0);
		}

		// Token: 0x06031F34 RID: 204596 RVA: 0x006C2BEC File Offset: 0x006C0DEC
		public static void AddSize(FlatBufferBuilder builder, int size)
		{
			builder.AddInt(2, size, 0);
		}

		// Token: 0x06031F35 RID: 204597 RVA: 0x006C2BF7 File Offset: 0x006C0DF7
		public static void AddShape(FlatBufferBuilder builder, EJigsawShape shape)
		{
			builder.AddByte(3, (byte)shape, 0);
		}

		// Token: 0x06031F36 RID: 204598 RVA: 0x006C2C02 File Offset: 0x006C0E02
		public static void AddPieces(FlatBufferBuilder builder, VectorOffset piecesOffset)
		{
			builder.AddOffset(4, piecesOffset.Value, 0);
		}

		// Token: 0x06031F37 RID: 204599 RVA: 0x006C2C14 File Offset: 0x006C0E14
		public static VectorOffset CreatePiecesVector(FlatBufferBuilder builder, Offset<IJigsawPiece>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06031F38 RID: 204600 RVA: 0x006C2C54 File Offset: 0x006C0E54
		public static VectorOffset CreatePiecesVectorBlock(FlatBufferBuilder builder, Offset<IJigsawPiece>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IJigsawPiece>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031F39 RID: 204601 RVA: 0x006C2C6E File Offset: 0x006C0E6E
		public static VectorOffset CreatePiecesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IJigsawPiece>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IJigsawPiece>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031F3A RID: 204602 RVA: 0x006C2C8C File Offset: 0x006C0E8C
		public static VectorOffset CreatePiecesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IJigsawPiece>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031F3B RID: 204603 RVA: 0x006C2CA5 File Offset: 0x006C0EA5
		public static void StartPiecesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031F3C RID: 204604 RVA: 0x006C2CB0 File Offset: 0x006C0EB0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06031F3D RID: 204605 RVA: 0x006C2CBB File Offset: 0x006C0EBB
		public static Offset<IJigsawConfig> EndIJigsawConfig(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawConfig>(builder.EndTable());
		}

		// Token: 0x06031F3E RID: 204606 RVA: 0x006C2CC8 File Offset: 0x006C0EC8
		public IJigsawConfigT UnPack()
		{
			IJigsawConfigT jigsawConfigT = new IJigsawConfigT();
			this.UnPackTo(jigsawConfigT);
			return jigsawConfigT;
		}

		// Token: 0x06031F3F RID: 204607 RVA: 0x006C2CE4 File Offset: 0x006C0EE4
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

		// Token: 0x06031F40 RID: 204608 RVA: 0x006C2D80 File Offset: 0x006C0F80
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

		// Token: 0x04011FF0 RID: 73712
		private Table __p;
	}
}
