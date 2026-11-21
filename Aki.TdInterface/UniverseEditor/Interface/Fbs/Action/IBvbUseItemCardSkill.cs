using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068DA RID: 26842
	public struct IBvbUseItemCardSkill : IFlatbufferObject
	{
		// Token: 0x1700C541 RID: 50497
		// (get) Token: 0x0602DED9 RID: 188121 RVA: 0x00646D69 File Offset: 0x00644F69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DEDA RID: 188122 RVA: 0x00646D76 File Offset: 0x00644F76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DEDB RID: 188123 RVA: 0x00646D80 File Offset: 0x00644F80
		public static IBvbUseItemCardSkill GetRootAsIBvbUseItemCardSkill(ByteBuffer _bb)
		{
			return IBvbUseItemCardSkill.GetRootAsIBvbUseItemCardSkill(_bb, default(IBvbUseItemCardSkill));
		}

		// Token: 0x0602DEDC RID: 188124 RVA: 0x00646D9C File Offset: 0x00644F9C
		public static IBvbUseItemCardSkill GetRootAsIBvbUseItemCardSkill(ByteBuffer _bb, IBvbUseItemCardSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DEDD RID: 188125 RVA: 0x00646DB9 File Offset: 0x00644FB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DEDE RID: 188126 RVA: 0x00646DC8 File Offset: 0x00644FC8
		public IBvbUseItemCardSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C542 RID: 50498
		// (get) Token: 0x0602DEDF RID: 188127 RVA: 0x00646DD8 File Offset: 0x00644FD8
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

		// Token: 0x0602DEE0 RID: 188128 RVA: 0x00646E14 File Offset: 0x00645014
		public int BoardPosIndexList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C543 RID: 50499
		// (get) Token: 0x0602DEE1 RID: 188129 RVA: 0x00646E54 File Offset: 0x00645054
		public int BoardPosIndexListLength
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

		// Token: 0x0602DEE2 RID: 188130 RVA: 0x00646E7F File Offset: 0x0064507F
		public Span<int> GetBoardPosIndexListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602DEE3 RID: 188131 RVA: 0x00646E8E File Offset: 0x0064508E
		public int[] GetBoardPosIndexListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700C544 RID: 50500
		// (get) Token: 0x0602DEE4 RID: 188132 RVA: 0x00646E9C File Offset: 0x0064509C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DEE5 RID: 188133 RVA: 0x00646ED8 File Offset: 0x006450D8
		public static Offset<IBvbUseItemCardSkill> CreateIBvbUseItemCardSkill(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy, VectorOffset BoardPosIndexListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IBvbUseItemCardSkill.AddBoardPosIndexList(builder, BoardPosIndexListOffset);
			IBvbUseItemCardSkill.AddNullMask(builder, NullMask);
			IBvbUseItemCardSkill.AddType(builder, Type);
			return IBvbUseItemCardSkill.EndIBvbUseItemCardSkill(builder);
		}

		// Token: 0x0602DEE6 RID: 188134 RVA: 0x00646EFC File Offset: 0x006450FC
		public static void StartIBvbUseItemCardSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602DEE7 RID: 188135 RVA: 0x00646F05 File Offset: 0x00645105
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DEE8 RID: 188136 RVA: 0x00646F10 File Offset: 0x00645110
		public static void AddBoardPosIndexList(FlatBufferBuilder builder, VectorOffset boardPosIndexListOffset)
		{
			builder.AddOffset(1, boardPosIndexListOffset.Value, 0);
		}

		// Token: 0x0602DEE9 RID: 188137 RVA: 0x00646F20 File Offset: 0x00645120
		public static VectorOffset CreateBoardPosIndexListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602DEEA RID: 188138 RVA: 0x00646F57 File Offset: 0x00645157
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DEEB RID: 188139 RVA: 0x00646F71 File Offset: 0x00645171
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DEEC RID: 188140 RVA: 0x00646F8F File Offset: 0x0064518F
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602DEED RID: 188141 RVA: 0x00646FA8 File Offset: 0x006451A8
		public static void StartBoardPosIndexListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602DEEE RID: 188142 RVA: 0x00646FB3 File Offset: 0x006451B3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602DEEF RID: 188143 RVA: 0x00646FBE File Offset: 0x006451BE
		public static Offset<IBvbUseItemCardSkill> EndIBvbUseItemCardSkill(FlatBufferBuilder builder)
		{
			return new Offset<IBvbUseItemCardSkill>(builder.EndTable());
		}

		// Token: 0x0602DEF0 RID: 188144 RVA: 0x00646FCC File Offset: 0x006451CC
		public IBvbUseItemCardSkillT UnPack()
		{
			IBvbUseItemCardSkillT bvbUseItemCardSkillT = new IBvbUseItemCardSkillT();
			this.UnPackTo(bvbUseItemCardSkillT);
			return bvbUseItemCardSkillT;
		}

		// Token: 0x0602DEF1 RID: 188145 RVA: 0x00646FE8 File Offset: 0x006451E8
		public void UnPackTo(IBvbUseItemCardSkillT _o)
		{
			_o.Type = this.Type;
			_o.BoardPosIndexList = new List<int>();
			for (int i = 0; i < this.BoardPosIndexListLength; i++)
			{
				_o.BoardPosIndexList.Add(this.BoardPosIndexList(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DEF2 RID: 188146 RVA: 0x0064703C File Offset: 0x0064523C
		public static Offset<IBvbUseItemCardSkill> Pack(FlatBufferBuilder builder, IBvbUseItemCardSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbUseItemCardSkill>);
			}
			VectorOffset boardPosIndexListOffset = default(VectorOffset);
			if (_o.BoardPosIndexList != null)
			{
				int[] data = _o.BoardPosIndexList.ToArray();
				boardPosIndexListOffset = IBvbUseItemCardSkill.CreateBoardPosIndexListVector(builder, data);
			}
			return IBvbUseItemCardSkill.CreateIBvbUseItemCardSkill(builder, _o.Type, boardPosIndexListOffset, _o.NullMask);
		}

		// Token: 0x040115D7 RID: 71127
		private Table __p;
	}
}
