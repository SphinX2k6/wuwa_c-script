using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006245 RID: 25157
	public struct IBvbEvolution : IFlatbufferObject
	{
		// Token: 0x1700BB7A RID: 47994
		// (get) Token: 0x0602B602 RID: 177666 RVA: 0x005F89F5 File Offset: 0x005F6BF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B603 RID: 177667 RVA: 0x005F8A02 File Offset: 0x005F6C02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B604 RID: 177668 RVA: 0x005F8A0C File Offset: 0x005F6C0C
		public static IBvbEvolution GetRootAsIBvbEvolution(ByteBuffer _bb)
		{
			return IBvbEvolution.GetRootAsIBvbEvolution(_bb, default(IBvbEvolution));
		}

		// Token: 0x0602B605 RID: 177669 RVA: 0x005F8A28 File Offset: 0x005F6C28
		public static IBvbEvolution GetRootAsIBvbEvolution(ByteBuffer _bb, IBvbEvolution obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B606 RID: 177670 RVA: 0x005F8A45 File Offset: 0x005F6C45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B607 RID: 177671 RVA: 0x005F8A54 File Offset: 0x005F6C54
		public IBvbEvolution __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB7B RID: 47995
		// (get) Token: 0x0602B608 RID: 177672 RVA: 0x005F8A64 File Offset: 0x005F6C64
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

		// Token: 0x1700BB7C RID: 47996
		// (get) Token: 0x0602B609 RID: 177673 RVA: 0x005F8AA0 File Offset: 0x005F6CA0
		public int HandCardIndex
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

		// Token: 0x1700BB7D RID: 47997
		// (get) Token: 0x0602B60A RID: 177674 RVA: 0x005F8ADC File Offset: 0x005F6CDC
		public int BoardPosIndex
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

		// Token: 0x0602B60B RID: 177675 RVA: 0x005F8B18 File Offset: 0x005F6D18
		public int BoardPosIndexList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BB7E RID: 47998
		// (get) Token: 0x0602B60C RID: 177676 RVA: 0x005F8B58 File Offset: 0x005F6D58
		public int BoardPosIndexListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602B60D RID: 177677 RVA: 0x005F8B84 File Offset: 0x005F6D84
		public Span<int> GetBoardPosIndexListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602B60E RID: 177678 RVA: 0x005F8B94 File Offset: 0x005F6D94
		public int[] GetBoardPosIndexListArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700BB7F RID: 47999
		// (get) Token: 0x0602B60F RID: 177679 RVA: 0x005F8BA4 File Offset: 0x005F6DA4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B610 RID: 177680 RVA: 0x005F8BE1 File Offset: 0x005F6DE1
		public static Offset<IBvbEvolution> CreateIBvbEvolution(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy, int HandCardIndex = 0, int BoardPosIndex = 0, VectorOffset BoardPosIndexListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IBvbEvolution.AddBoardPosIndexList(builder, BoardPosIndexListOffset);
			IBvbEvolution.AddBoardPosIndex(builder, BoardPosIndex);
			IBvbEvolution.AddHandCardIndex(builder, HandCardIndex);
			IBvbEvolution.AddNullMask(builder, NullMask);
			IBvbEvolution.AddType(builder, Type);
			return IBvbEvolution.EndIBvbEvolution(builder);
		}

		// Token: 0x0602B611 RID: 177681 RVA: 0x005F8C15 File Offset: 0x005F6E15
		public static void StartIBvbEvolution(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B612 RID: 177682 RVA: 0x005F8C1E File Offset: 0x005F6E1E
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B613 RID: 177683 RVA: 0x005F8C29 File Offset: 0x005F6E29
		public static void AddHandCardIndex(FlatBufferBuilder builder, int handCardIndex)
		{
			builder.AddInt(1, handCardIndex, 0);
		}

		// Token: 0x0602B614 RID: 177684 RVA: 0x005F8C34 File Offset: 0x005F6E34
		public static void AddBoardPosIndex(FlatBufferBuilder builder, int boardPosIndex)
		{
			builder.AddInt(2, boardPosIndex, 0);
		}

		// Token: 0x0602B615 RID: 177685 RVA: 0x005F8C3F File Offset: 0x005F6E3F
		public static void AddBoardPosIndexList(FlatBufferBuilder builder, VectorOffset boardPosIndexListOffset)
		{
			builder.AddOffset(3, boardPosIndexListOffset.Value, 0);
		}

		// Token: 0x0602B616 RID: 177686 RVA: 0x005F8C50 File Offset: 0x005F6E50
		public static VectorOffset CreateBoardPosIndexListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B617 RID: 177687 RVA: 0x005F8C87 File Offset: 0x005F6E87
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B618 RID: 177688 RVA: 0x005F8CA1 File Offset: 0x005F6EA1
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B619 RID: 177689 RVA: 0x005F8CBF File Offset: 0x005F6EBF
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B61A RID: 177690 RVA: 0x005F8CD8 File Offset: 0x005F6ED8
		public static void StartBoardPosIndexListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B61B RID: 177691 RVA: 0x005F8CE3 File Offset: 0x005F6EE3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602B61C RID: 177692 RVA: 0x005F8CEE File Offset: 0x005F6EEE
		public static Offset<IBvbEvolution> EndIBvbEvolution(FlatBufferBuilder builder)
		{
			return new Offset<IBvbEvolution>(builder.EndTable());
		}

		// Token: 0x0602B61D RID: 177693 RVA: 0x005F8CFC File Offset: 0x005F6EFC
		public IBvbEvolutionT UnPack()
		{
			IBvbEvolutionT bvbEvolutionT = new IBvbEvolutionT();
			this.UnPackTo(bvbEvolutionT);
			return bvbEvolutionT;
		}

		// Token: 0x0602B61E RID: 177694 RVA: 0x005F8D18 File Offset: 0x005F6F18
		public void UnPackTo(IBvbEvolutionT _o)
		{
			_o.Type = this.Type;
			_o.HandCardIndex = this.HandCardIndex;
			_o.BoardPosIndex = this.BoardPosIndex;
			_o.BoardPosIndexList = new List<int>();
			for (int i = 0; i < this.BoardPosIndexListLength; i++)
			{
				_o.BoardPosIndexList.Add(this.BoardPosIndexList(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602B61F RID: 177695 RVA: 0x005F8D84 File Offset: 0x005F6F84
		public static Offset<IBvbEvolution> Pack(FlatBufferBuilder builder, IBvbEvolutionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbEvolution>);
			}
			VectorOffset boardPosIndexListOffset = default(VectorOffset);
			if (_o.BoardPosIndexList != null)
			{
				int[] data = _o.BoardPosIndexList.ToArray();
				boardPosIndexListOffset = IBvbEvolution.CreateBoardPosIndexListVector(builder, data);
			}
			return IBvbEvolution.CreateIBvbEvolution(builder, _o.Type, _o.HandCardIndex, _o.BoardPosIndex, boardPosIndexListOffset, _o.NullMask);
		}

		// Token: 0x0401078F RID: 67471
		private Table __p;
	}
}
