using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068AA RID: 26794
	public struct IBvbChangeBoardCard : IFlatbufferObject
	{
		// Token: 0x1700C4E4 RID: 50404
		// (get) Token: 0x0602DCE7 RID: 187623 RVA: 0x00642AD6 File Offset: 0x00640CD6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DCE8 RID: 187624 RVA: 0x00642AE3 File Offset: 0x00640CE3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DCE9 RID: 187625 RVA: 0x00642AEC File Offset: 0x00640CEC
		public static IBvbChangeBoardCard GetRootAsIBvbChangeBoardCard(ByteBuffer _bb)
		{
			return IBvbChangeBoardCard.GetRootAsIBvbChangeBoardCard(_bb, default(IBvbChangeBoardCard));
		}

		// Token: 0x0602DCEA RID: 187626 RVA: 0x00642B08 File Offset: 0x00640D08
		public static IBvbChangeBoardCard GetRootAsIBvbChangeBoardCard(ByteBuffer _bb, IBvbChangeBoardCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DCEB RID: 187627 RVA: 0x00642B25 File Offset: 0x00640D25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DCEC RID: 187628 RVA: 0x00642B34 File Offset: 0x00640D34
		public IBvbChangeBoardCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4E5 RID: 50405
		// (get) Token: 0x0602DCED RID: 187629 RVA: 0x00642B44 File Offset: 0x00640D44
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

		// Token: 0x1700C4E6 RID: 50406
		// (get) Token: 0x0602DCEE RID: 187630 RVA: 0x00642B80 File Offset: 0x00640D80
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

		// Token: 0x0602DCEF RID: 187631 RVA: 0x00642BBC File Offset: 0x00640DBC
		public int BoardPosIndexList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C4E7 RID: 50407
		// (get) Token: 0x0602DCF0 RID: 187632 RVA: 0x00642BFC File Offset: 0x00640DFC
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

		// Token: 0x0602DCF1 RID: 187633 RVA: 0x00642C27 File Offset: 0x00640E27
		public Span<int> GetBoardPosIndexListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602DCF2 RID: 187634 RVA: 0x00642C36 File Offset: 0x00640E36
		public int[] GetBoardPosIndexListArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700C4E8 RID: 50408
		// (get) Token: 0x0602DCF3 RID: 187635 RVA: 0x00642C44 File Offset: 0x00640E44
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

		// Token: 0x0602DCF4 RID: 187636 RVA: 0x00642C81 File Offset: 0x00640E81
		public static Offset<IBvbChangeBoardCard> CreateIBvbChangeBoardCard(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy, int BoardPosIndex = 0, VectorOffset BoardPosIndexListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IBvbChangeBoardCard.AddBoardPosIndexList(builder, BoardPosIndexListOffset);
			IBvbChangeBoardCard.AddBoardPosIndex(builder, BoardPosIndex);
			IBvbChangeBoardCard.AddNullMask(builder, NullMask);
			IBvbChangeBoardCard.AddType(builder, Type);
			return IBvbChangeBoardCard.EndIBvbChangeBoardCard(builder);
		}

		// Token: 0x0602DCF5 RID: 187637 RVA: 0x00642CAD File Offset: 0x00640EAD
		public static void StartIBvbChangeBoardCard(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602DCF6 RID: 187638 RVA: 0x00642CB6 File Offset: 0x00640EB6
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DCF7 RID: 187639 RVA: 0x00642CC1 File Offset: 0x00640EC1
		public static void AddBoardPosIndex(FlatBufferBuilder builder, int boardPosIndex)
		{
			builder.AddInt(1, boardPosIndex, 0);
		}

		// Token: 0x0602DCF8 RID: 187640 RVA: 0x00642CCC File Offset: 0x00640ECC
		public static void AddBoardPosIndexList(FlatBufferBuilder builder, VectorOffset boardPosIndexListOffset)
		{
			builder.AddOffset(2, boardPosIndexListOffset.Value, 0);
		}

		// Token: 0x0602DCF9 RID: 187641 RVA: 0x00642CDC File Offset: 0x00640EDC
		public static VectorOffset CreateBoardPosIndexListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602DCFA RID: 187642 RVA: 0x00642D13 File Offset: 0x00640F13
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DCFB RID: 187643 RVA: 0x00642D2D File Offset: 0x00640F2D
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DCFC RID: 187644 RVA: 0x00642D4B File Offset: 0x00640F4B
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602DCFD RID: 187645 RVA: 0x00642D64 File Offset: 0x00640F64
		public static void StartBoardPosIndexListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602DCFE RID: 187646 RVA: 0x00642D6F File Offset: 0x00640F6F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602DCFF RID: 187647 RVA: 0x00642D7A File Offset: 0x00640F7A
		public static Offset<IBvbChangeBoardCard> EndIBvbChangeBoardCard(FlatBufferBuilder builder)
		{
			return new Offset<IBvbChangeBoardCard>(builder.EndTable());
		}

		// Token: 0x0602DD00 RID: 187648 RVA: 0x00642D88 File Offset: 0x00640F88
		public IBvbChangeBoardCardT UnPack()
		{
			IBvbChangeBoardCardT bvbChangeBoardCardT = new IBvbChangeBoardCardT();
			this.UnPackTo(bvbChangeBoardCardT);
			return bvbChangeBoardCardT;
		}

		// Token: 0x0602DD01 RID: 187649 RVA: 0x00642DA4 File Offset: 0x00640FA4
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

		// Token: 0x0602DD02 RID: 187650 RVA: 0x00642E04 File Offset: 0x00641004
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

		// Token: 0x04011593 RID: 71059
		private Table __p;
	}
}
