using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C5 RID: 26821
	public struct IBvbRecycleBoardCard : IFlatbufferObject
	{
		// Token: 0x1700C51E RID: 50462
		// (get) Token: 0x0602DDFB RID: 187899 RVA: 0x00644AD4 File Offset: 0x00642CD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DDFC RID: 187900 RVA: 0x00644AE1 File Offset: 0x00642CE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DDFD RID: 187901 RVA: 0x00644AE8 File Offset: 0x00642CE8
		public static IBvbRecycleBoardCard GetRootAsIBvbRecycleBoardCard(ByteBuffer _bb)
		{
			return IBvbRecycleBoardCard.GetRootAsIBvbRecycleBoardCard(_bb, default(IBvbRecycleBoardCard));
		}

		// Token: 0x0602DDFE RID: 187902 RVA: 0x00644B04 File Offset: 0x00642D04
		public static IBvbRecycleBoardCard GetRootAsIBvbRecycleBoardCard(ByteBuffer _bb, IBvbRecycleBoardCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DDFF RID: 187903 RVA: 0x00644B21 File Offset: 0x00642D21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DE00 RID: 187904 RVA: 0x00644B30 File Offset: 0x00642D30
		public IBvbRecycleBoardCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C51F RID: 50463
		// (get) Token: 0x0602DE01 RID: 187905 RVA: 0x00644B40 File Offset: 0x00642D40
		public EBvbPlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return (EBvbPlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C520 RID: 50464
		// (get) Token: 0x0602DE02 RID: 187906 RVA: 0x00644B7C File Offset: 0x00642D7C
		public int BoardPosIndex
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

		// Token: 0x0602DE03 RID: 187907 RVA: 0x00644BB8 File Offset: 0x00642DB8
		public int BoardPosIndexList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C521 RID: 50465
		// (get) Token: 0x0602DE04 RID: 187908 RVA: 0x00644BF8 File Offset: 0x00642DF8
		public int BoardPosIndexListLength
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

		// Token: 0x0602DE05 RID: 187909 RVA: 0x00644C23 File Offset: 0x00642E23
		public Span<int> GetBoardPosIndexListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602DE06 RID: 187910 RVA: 0x00644C32 File Offset: 0x00642E32
		public int[] GetBoardPosIndexListArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700C522 RID: 50466
		// (get) Token: 0x0602DE07 RID: 187911 RVA: 0x00644C40 File Offset: 0x00642E40
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

		// Token: 0x0602DE08 RID: 187912 RVA: 0x00644C7D File Offset: 0x00642E7D
		public static Offset<IBvbRecycleBoardCard> CreateIBvbRecycleBoardCard(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy, int BoardPosIndex = 0, VectorOffset BoardPosIndexListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IBvbRecycleBoardCard.AddBoardPosIndexList(builder, BoardPosIndexListOffset);
			IBvbRecycleBoardCard.AddBoardPosIndex(builder, BoardPosIndex);
			IBvbRecycleBoardCard.AddNullMask(builder, NullMask);
			IBvbRecycleBoardCard.AddType(builder, Type);
			return IBvbRecycleBoardCard.EndIBvbRecycleBoardCard(builder);
		}

		// Token: 0x0602DE09 RID: 187913 RVA: 0x00644CA9 File Offset: 0x00642EA9
		public static void StartIBvbRecycleBoardCard(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602DE0A RID: 187914 RVA: 0x00644CB2 File Offset: 0x00642EB2
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DE0B RID: 187915 RVA: 0x00644CBD File Offset: 0x00642EBD
		public static void AddBoardPosIndex(FlatBufferBuilder builder, int boardPosIndex)
		{
			builder.AddInt(1, boardPosIndex, 0);
		}

		// Token: 0x0602DE0C RID: 187916 RVA: 0x00644CC8 File Offset: 0x00642EC8
		public static void AddBoardPosIndexList(FlatBufferBuilder builder, VectorOffset boardPosIndexListOffset)
		{
			builder.AddOffset(2, boardPosIndexListOffset.Value, 0);
		}

		// Token: 0x0602DE0D RID: 187917 RVA: 0x00644CD8 File Offset: 0x00642ED8
		public static VectorOffset CreateBoardPosIndexListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602DE0E RID: 187918 RVA: 0x00644D0F File Offset: 0x00642F0F
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DE0F RID: 187919 RVA: 0x00644D29 File Offset: 0x00642F29
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DE10 RID: 187920 RVA: 0x00644D47 File Offset: 0x00642F47
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602DE11 RID: 187921 RVA: 0x00644D60 File Offset: 0x00642F60
		public static void StartBoardPosIndexListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602DE12 RID: 187922 RVA: 0x00644D6B File Offset: 0x00642F6B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602DE13 RID: 187923 RVA: 0x00644D76 File Offset: 0x00642F76
		public static Offset<IBvbRecycleBoardCard> EndIBvbRecycleBoardCard(FlatBufferBuilder builder)
		{
			return new Offset<IBvbRecycleBoardCard>(builder.EndTable());
		}

		// Token: 0x0602DE14 RID: 187924 RVA: 0x00644D84 File Offset: 0x00642F84
		public IBvbRecycleBoardCardT UnPack()
		{
			IBvbRecycleBoardCardT bvbRecycleBoardCardT = new IBvbRecycleBoardCardT();
			this.UnPackTo(bvbRecycleBoardCardT);
			return bvbRecycleBoardCardT;
		}

		// Token: 0x0602DE15 RID: 187925 RVA: 0x00644DA0 File Offset: 0x00642FA0
		public void UnPackTo(IBvbRecycleBoardCardT _o)
		{
			_o.Type = this.Type;
			_o.BoardPosIndex = this.BoardPosIndex;
			_o.BoardPosIndexList = new List<int>();
			for (int i = 0; i < this.BoardPosIndexListLength; i++)
			{
				_o.BoardPosIndexList.Add(this.BoardPosIndexList(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DE16 RID: 187926 RVA: 0x00644E00 File Offset: 0x00643000
		public static Offset<IBvbRecycleBoardCard> Pack(FlatBufferBuilder builder, IBvbRecycleBoardCardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbRecycleBoardCard>);
			}
			VectorOffset boardPosIndexListOffset = default(VectorOffset);
			if (_o.BoardPosIndexList != null)
			{
				int[] data = _o.BoardPosIndexList.ToArray();
				boardPosIndexListOffset = IBvbRecycleBoardCard.CreateBoardPosIndexListVector(builder, data);
			}
			return IBvbRecycleBoardCard.CreateIBvbRecycleBoardCard(builder, _o.Type, _o.BoardPosIndex, boardPosIndexListOffset, _o.NullMask);
		}

		// Token: 0x040115C2 RID: 71106
		private Table __p;
	}
}
