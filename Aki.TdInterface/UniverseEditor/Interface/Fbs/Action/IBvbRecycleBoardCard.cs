using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006254 RID: 25172
	public struct IBvbRecycleBoardCard : IFlatbufferObject
	{
		// Token: 0x1700BB96 RID: 48022
		// (get) Token: 0x0602B69A RID: 177818 RVA: 0x005F9CCC File Offset: 0x005F7ECC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B69B RID: 177819 RVA: 0x005F9CD9 File Offset: 0x005F7ED9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B69C RID: 177820 RVA: 0x005F9CE0 File Offset: 0x005F7EE0
		public static IBvbRecycleBoardCard GetRootAsIBvbRecycleBoardCard(ByteBuffer _bb)
		{
			return IBvbRecycleBoardCard.GetRootAsIBvbRecycleBoardCard(_bb, default(IBvbRecycleBoardCard));
		}

		// Token: 0x0602B69D RID: 177821 RVA: 0x005F9CFC File Offset: 0x005F7EFC
		public static IBvbRecycleBoardCard GetRootAsIBvbRecycleBoardCard(ByteBuffer _bb, IBvbRecycleBoardCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B69E RID: 177822 RVA: 0x005F9D19 File Offset: 0x005F7F19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B69F RID: 177823 RVA: 0x005F9D28 File Offset: 0x005F7F28
		public IBvbRecycleBoardCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB97 RID: 48023
		// (get) Token: 0x0602B6A0 RID: 177824 RVA: 0x005F9D38 File Offset: 0x005F7F38
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

		// Token: 0x1700BB98 RID: 48024
		// (get) Token: 0x0602B6A1 RID: 177825 RVA: 0x005F9D74 File Offset: 0x005F7F74
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

		// Token: 0x0602B6A2 RID: 177826 RVA: 0x005F9DB0 File Offset: 0x005F7FB0
		public int BoardPosIndexList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BB99 RID: 48025
		// (get) Token: 0x0602B6A3 RID: 177827 RVA: 0x005F9DF0 File Offset: 0x005F7FF0
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

		// Token: 0x0602B6A4 RID: 177828 RVA: 0x005F9E1B File Offset: 0x005F801B
		public Span<int> GetBoardPosIndexListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602B6A5 RID: 177829 RVA: 0x005F9E2A File Offset: 0x005F802A
		public int[] GetBoardPosIndexListArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700BB9A RID: 48026
		// (get) Token: 0x0602B6A6 RID: 177830 RVA: 0x005F9E38 File Offset: 0x005F8038
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

		// Token: 0x0602B6A7 RID: 177831 RVA: 0x005F9E75 File Offset: 0x005F8075
		public static Offset<IBvbRecycleBoardCard> CreateIBvbRecycleBoardCard(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy, int BoardPosIndex = 0, VectorOffset BoardPosIndexListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IBvbRecycleBoardCard.AddBoardPosIndexList(builder, BoardPosIndexListOffset);
			IBvbRecycleBoardCard.AddBoardPosIndex(builder, BoardPosIndex);
			IBvbRecycleBoardCard.AddNullMask(builder, NullMask);
			IBvbRecycleBoardCard.AddType(builder, Type);
			return IBvbRecycleBoardCard.EndIBvbRecycleBoardCard(builder);
		}

		// Token: 0x0602B6A8 RID: 177832 RVA: 0x005F9EA1 File Offset: 0x005F80A1
		public static void StartIBvbRecycleBoardCard(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602B6A9 RID: 177833 RVA: 0x005F9EAA File Offset: 0x005F80AA
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B6AA RID: 177834 RVA: 0x005F9EB5 File Offset: 0x005F80B5
		public static void AddBoardPosIndex(FlatBufferBuilder builder, int boardPosIndex)
		{
			builder.AddInt(1, boardPosIndex, 0);
		}

		// Token: 0x0602B6AB RID: 177835 RVA: 0x005F9EC0 File Offset: 0x005F80C0
		public static void AddBoardPosIndexList(FlatBufferBuilder builder, VectorOffset boardPosIndexListOffset)
		{
			builder.AddOffset(2, boardPosIndexListOffset.Value, 0);
		}

		// Token: 0x0602B6AC RID: 177836 RVA: 0x005F9ED0 File Offset: 0x005F80D0
		public static VectorOffset CreateBoardPosIndexListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B6AD RID: 177837 RVA: 0x005F9F07 File Offset: 0x005F8107
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B6AE RID: 177838 RVA: 0x005F9F21 File Offset: 0x005F8121
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B6AF RID: 177839 RVA: 0x005F9F3F File Offset: 0x005F813F
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B6B0 RID: 177840 RVA: 0x005F9F58 File Offset: 0x005F8158
		public static void StartBoardPosIndexListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B6B1 RID: 177841 RVA: 0x005F9F63 File Offset: 0x005F8163
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602B6B2 RID: 177842 RVA: 0x005F9F6E File Offset: 0x005F816E
		public static Offset<IBvbRecycleBoardCard> EndIBvbRecycleBoardCard(FlatBufferBuilder builder)
		{
			return new Offset<IBvbRecycleBoardCard>(builder.EndTable());
		}

		// Token: 0x0602B6B3 RID: 177843 RVA: 0x005F9F7C File Offset: 0x005F817C
		public IBvbRecycleBoardCardT UnPack()
		{
			IBvbRecycleBoardCardT bvbRecycleBoardCardT = new IBvbRecycleBoardCardT();
			this.UnPackTo(bvbRecycleBoardCardT);
			return bvbRecycleBoardCardT;
		}

		// Token: 0x0602B6B4 RID: 177844 RVA: 0x005F9F98 File Offset: 0x005F8198
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

		// Token: 0x0602B6B5 RID: 177845 RVA: 0x005F9FF8 File Offset: 0x005F81F8
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

		// Token: 0x040107AD RID: 67501
		private Table __p;
	}
}
