using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068B6 RID: 26806
	public struct IBvbEvolution : IFlatbufferObject
	{
		// Token: 0x1700C502 RID: 50434
		// (get) Token: 0x0602DD63 RID: 187747 RVA: 0x006437FD File Offset: 0x006419FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DD64 RID: 187748 RVA: 0x0064380A File Offset: 0x00641A0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DD65 RID: 187749 RVA: 0x00643814 File Offset: 0x00641A14
		public static IBvbEvolution GetRootAsIBvbEvolution(ByteBuffer _bb)
		{
			return IBvbEvolution.GetRootAsIBvbEvolution(_bb, default(IBvbEvolution));
		}

		// Token: 0x0602DD66 RID: 187750 RVA: 0x00643830 File Offset: 0x00641A30
		public static IBvbEvolution GetRootAsIBvbEvolution(ByteBuffer _bb, IBvbEvolution obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DD67 RID: 187751 RVA: 0x0064384D File Offset: 0x00641A4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DD68 RID: 187752 RVA: 0x0064385C File Offset: 0x00641A5C
		public IBvbEvolution __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C503 RID: 50435
		// (get) Token: 0x0602DD69 RID: 187753 RVA: 0x0064386C File Offset: 0x00641A6C
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

		// Token: 0x1700C504 RID: 50436
		// (get) Token: 0x0602DD6A RID: 187754 RVA: 0x006438A8 File Offset: 0x00641AA8
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

		// Token: 0x1700C505 RID: 50437
		// (get) Token: 0x0602DD6B RID: 187755 RVA: 0x006438E4 File Offset: 0x00641AE4
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

		// Token: 0x0602DD6C RID: 187756 RVA: 0x00643920 File Offset: 0x00641B20
		public int BoardPosIndexList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C506 RID: 50438
		// (get) Token: 0x0602DD6D RID: 187757 RVA: 0x00643960 File Offset: 0x00641B60
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

		// Token: 0x0602DD6E RID: 187758 RVA: 0x0064398C File Offset: 0x00641B8C
		public Span<int> GetBoardPosIndexListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602DD6F RID: 187759 RVA: 0x0064399C File Offset: 0x00641B9C
		public int[] GetBoardPosIndexListArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700C507 RID: 50439
		// (get) Token: 0x0602DD70 RID: 187760 RVA: 0x006439AC File Offset: 0x00641BAC
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

		// Token: 0x0602DD71 RID: 187761 RVA: 0x006439E9 File Offset: 0x00641BE9
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

		// Token: 0x0602DD72 RID: 187762 RVA: 0x00643A1D File Offset: 0x00641C1D
		public static void StartIBvbEvolution(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602DD73 RID: 187763 RVA: 0x00643A26 File Offset: 0x00641C26
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DD74 RID: 187764 RVA: 0x00643A31 File Offset: 0x00641C31
		public static void AddHandCardIndex(FlatBufferBuilder builder, int handCardIndex)
		{
			builder.AddInt(1, handCardIndex, 0);
		}

		// Token: 0x0602DD75 RID: 187765 RVA: 0x00643A3C File Offset: 0x00641C3C
		public static void AddBoardPosIndex(FlatBufferBuilder builder, int boardPosIndex)
		{
			builder.AddInt(2, boardPosIndex, 0);
		}

		// Token: 0x0602DD76 RID: 187766 RVA: 0x00643A47 File Offset: 0x00641C47
		public static void AddBoardPosIndexList(FlatBufferBuilder builder, VectorOffset boardPosIndexListOffset)
		{
			builder.AddOffset(3, boardPosIndexListOffset.Value, 0);
		}

		// Token: 0x0602DD77 RID: 187767 RVA: 0x00643A58 File Offset: 0x00641C58
		public static VectorOffset CreateBoardPosIndexListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602DD78 RID: 187768 RVA: 0x00643A8F File Offset: 0x00641C8F
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DD79 RID: 187769 RVA: 0x00643AA9 File Offset: 0x00641CA9
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DD7A RID: 187770 RVA: 0x00643AC7 File Offset: 0x00641CC7
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602DD7B RID: 187771 RVA: 0x00643AE0 File Offset: 0x00641CE0
		public static void StartBoardPosIndexListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602DD7C RID: 187772 RVA: 0x00643AEB File Offset: 0x00641CEB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602DD7D RID: 187773 RVA: 0x00643AF6 File Offset: 0x00641CF6
		public static Offset<IBvbEvolution> EndIBvbEvolution(FlatBufferBuilder builder)
		{
			return new Offset<IBvbEvolution>(builder.EndTable());
		}

		// Token: 0x0602DD7E RID: 187774 RVA: 0x00643B04 File Offset: 0x00641D04
		public IBvbEvolutionT UnPack()
		{
			IBvbEvolutionT bvbEvolutionT = new IBvbEvolutionT();
			this.UnPackTo(bvbEvolutionT);
			return bvbEvolutionT;
		}

		// Token: 0x0602DD7F RID: 187775 RVA: 0x00643B20 File Offset: 0x00641D20
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

		// Token: 0x0602DD80 RID: 187776 RVA: 0x00643B8C File Offset: 0x00641D8C
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

		// Token: 0x040115A4 RID: 71076
		private Table __p;
	}
}
