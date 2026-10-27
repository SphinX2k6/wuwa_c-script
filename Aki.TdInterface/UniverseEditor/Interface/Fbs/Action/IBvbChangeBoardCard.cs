using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006239 RID: 25145
	public struct IBvbChangeBoardCard : IFlatbufferObject
	{
		// Token: 0x1700BB5C RID: 47964
		// (get) Token: 0x0602B586 RID: 177542 RVA: 0x005F7CCE File Offset: 0x005F5ECE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B587 RID: 177543 RVA: 0x005F7CDB File Offset: 0x005F5EDB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B588 RID: 177544 RVA: 0x005F7CE4 File Offset: 0x005F5EE4
		public static IBvbChangeBoardCard GetRootAsIBvbChangeBoardCard(ByteBuffer _bb)
		{
			return IBvbChangeBoardCard.GetRootAsIBvbChangeBoardCard(_bb, default(IBvbChangeBoardCard));
		}

		// Token: 0x0602B589 RID: 177545 RVA: 0x005F7D00 File Offset: 0x005F5F00
		public static IBvbChangeBoardCard GetRootAsIBvbChangeBoardCard(ByteBuffer _bb, IBvbChangeBoardCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B58A RID: 177546 RVA: 0x005F7D1D File Offset: 0x005F5F1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B58B RID: 177547 RVA: 0x005F7D2C File Offset: 0x005F5F2C
		public IBvbChangeBoardCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB5D RID: 47965
		// (get) Token: 0x0602B58C RID: 177548 RVA: 0x005F7D3C File Offset: 0x005F5F3C
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

		// Token: 0x1700BB5E RID: 47966
		// (get) Token: 0x0602B58D RID: 177549 RVA: 0x005F7D78 File Offset: 0x005F5F78
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

		// Token: 0x0602B58E RID: 177550 RVA: 0x005F7DB4 File Offset: 0x005F5FB4
		public int BoardPosIndexList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BB5F RID: 47967
		// (get) Token: 0x0602B58F RID: 177551 RVA: 0x005F7DF4 File Offset: 0x005F5FF4
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

		// Token: 0x0602B590 RID: 177552 RVA: 0x005F7E1F File Offset: 0x005F601F
		public Span<int> GetBoardPosIndexListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602B591 RID: 177553 RVA: 0x005F7E2E File Offset: 0x005F602E
		public int[] GetBoardPosIndexListArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700BB60 RID: 47968
		// (get) Token: 0x0602B592 RID: 177554 RVA: 0x005F7E3C File Offset: 0x005F603C
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

		// Token: 0x0602B593 RID: 177555 RVA: 0x005F7E79 File Offset: 0x005F6079
		public static Offset<IBvbChangeBoardCard> CreateIBvbChangeBoardCard(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy, int BoardPosIndex = 0, VectorOffset BoardPosIndexListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IBvbChangeBoardCard.AddBoardPosIndexList(builder, BoardPosIndexListOffset);
			IBvbChangeBoardCard.AddBoardPosIndex(builder, BoardPosIndex);
			IBvbChangeBoardCard.AddNullMask(builder, NullMask);
			IBvbChangeBoardCard.AddType(builder, Type);
			return IBvbChangeBoardCard.EndIBvbChangeBoardCard(builder);
		}

		// Token: 0x0602B594 RID: 177556 RVA: 0x005F7EA5 File Offset: 0x005F60A5
		public static void StartIBvbChangeBoardCard(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602B595 RID: 177557 RVA: 0x005F7EAE File Offset: 0x005F60AE
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B596 RID: 177558 RVA: 0x005F7EB9 File Offset: 0x005F60B9
		public static void AddBoardPosIndex(FlatBufferBuilder builder, int boardPosIndex)
		{
			builder.AddInt(1, boardPosIndex, 0);
		}

		// Token: 0x0602B597 RID: 177559 RVA: 0x005F7EC4 File Offset: 0x005F60C4
		public static void AddBoardPosIndexList(FlatBufferBuilder builder, VectorOffset boardPosIndexListOffset)
		{
			builder.AddOffset(2, boardPosIndexListOffset.Value, 0);
		}

		// Token: 0x0602B598 RID: 177560 RVA: 0x005F7ED4 File Offset: 0x005F60D4
		public static VectorOffset CreateBoardPosIndexListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B599 RID: 177561 RVA: 0x005F7F0B File Offset: 0x005F610B
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B59A RID: 177562 RVA: 0x005F7F25 File Offset: 0x005F6125
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B59B RID: 177563 RVA: 0x005F7F43 File Offset: 0x005F6143
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B59C RID: 177564 RVA: 0x005F7F5C File Offset: 0x005F615C
		public static void StartBoardPosIndexListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B59D RID: 177565 RVA: 0x005F7F67 File Offset: 0x005F6167
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602B59E RID: 177566 RVA: 0x005F7F72 File Offset: 0x005F6172
		public static Offset<IBvbChangeBoardCard> EndIBvbChangeBoardCard(FlatBufferBuilder builder)
		{
			return new Offset<IBvbChangeBoardCard>(builder.EndTable());
		}

		// Token: 0x0602B59F RID: 177567 RVA: 0x005F7F80 File Offset: 0x005F6180
		public IBvbChangeBoardCardT UnPack()
		{
			IBvbChangeBoardCardT bvbChangeBoardCardT = new IBvbChangeBoardCardT();
			this.UnPackTo(bvbChangeBoardCardT);
			return bvbChangeBoardCardT;
		}

		// Token: 0x0602B5A0 RID: 177568 RVA: 0x005F7F9C File Offset: 0x005F619C
		public void UnPackTo(IBvbChangeBoardCardT _o)
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

		// Token: 0x0602B5A1 RID: 177569 RVA: 0x005F7FFC File Offset: 0x005F61FC
		public static Offset<IBvbChangeBoardCard> Pack(FlatBufferBuilder builder, IBvbChangeBoardCardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbChangeBoardCard>);
			}
			VectorOffset boardPosIndexListOffset = default(VectorOffset);
			if (_o.BoardPosIndexList != null)
			{
				int[] data = _o.BoardPosIndexList.ToArray();
				boardPosIndexListOffset = IBvbChangeBoardCard.CreateBoardPosIndexListVector(builder, data);
			}
			return IBvbChangeBoardCard.CreateIBvbChangeBoardCard(builder, _o.Type, _o.BoardPosIndex, boardPosIndexListOffset, _o.NullMask);
		}

		// Token: 0x0401077E RID: 67454
		private Table __p;
	}
}
