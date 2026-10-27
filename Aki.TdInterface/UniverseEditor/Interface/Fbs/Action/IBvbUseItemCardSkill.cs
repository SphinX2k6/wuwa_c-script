using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006269 RID: 25193
	public struct IBvbUseItemCardSkill : IFlatbufferObject
	{
		// Token: 0x1700BBB9 RID: 48057
		// (get) Token: 0x0602B778 RID: 178040 RVA: 0x005FBF61 File Offset: 0x005FA161
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B779 RID: 178041 RVA: 0x005FBF6E File Offset: 0x005FA16E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B77A RID: 178042 RVA: 0x005FBF78 File Offset: 0x005FA178
		public static IBvbUseItemCardSkill GetRootAsIBvbUseItemCardSkill(ByteBuffer _bb)
		{
			return IBvbUseItemCardSkill.GetRootAsIBvbUseItemCardSkill(_bb, default(IBvbUseItemCardSkill));
		}

		// Token: 0x0602B77B RID: 178043 RVA: 0x005FBF94 File Offset: 0x005FA194
		public static IBvbUseItemCardSkill GetRootAsIBvbUseItemCardSkill(ByteBuffer _bb, IBvbUseItemCardSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B77C RID: 178044 RVA: 0x005FBFB1 File Offset: 0x005FA1B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B77D RID: 178045 RVA: 0x005FBFC0 File Offset: 0x005FA1C0
		public IBvbUseItemCardSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBBA RID: 48058
		// (get) Token: 0x0602B77E RID: 178046 RVA: 0x005FBFD0 File Offset: 0x005FA1D0
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

		// Token: 0x0602B77F RID: 178047 RVA: 0x005FC00C File Offset: 0x005FA20C
		public int BoardPosIndexList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BBBB RID: 48059
		// (get) Token: 0x0602B780 RID: 178048 RVA: 0x005FC04C File Offset: 0x005FA24C
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

		// Token: 0x0602B781 RID: 178049 RVA: 0x005FC077 File Offset: 0x005FA277
		public Span<int> GetBoardPosIndexListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602B782 RID: 178050 RVA: 0x005FC086 File Offset: 0x005FA286
		public int[] GetBoardPosIndexListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700BBBC RID: 48060
		// (get) Token: 0x0602B783 RID: 178051 RVA: 0x005FC094 File Offset: 0x005FA294
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

		// Token: 0x0602B784 RID: 178052 RVA: 0x005FC0D0 File Offset: 0x005FA2D0
		public static Offset<IBvbUseItemCardSkill> CreateIBvbUseItemCardSkill(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy, VectorOffset BoardPosIndexListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IBvbUseItemCardSkill.AddBoardPosIndexList(builder, BoardPosIndexListOffset);
			IBvbUseItemCardSkill.AddNullMask(builder, NullMask);
			IBvbUseItemCardSkill.AddType(builder, Type);
			return IBvbUseItemCardSkill.EndIBvbUseItemCardSkill(builder);
		}

		// Token: 0x0602B785 RID: 178053 RVA: 0x005FC0F4 File Offset: 0x005FA2F4
		public static void StartIBvbUseItemCardSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B786 RID: 178054 RVA: 0x005FC0FD File Offset: 0x005FA2FD
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B787 RID: 178055 RVA: 0x005FC108 File Offset: 0x005FA308
		public static void AddBoardPosIndexList(FlatBufferBuilder builder, VectorOffset boardPosIndexListOffset)
		{
			builder.AddOffset(1, boardPosIndexListOffset.Value, 0);
		}

		// Token: 0x0602B788 RID: 178056 RVA: 0x005FC118 File Offset: 0x005FA318
		public static VectorOffset CreateBoardPosIndexListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B789 RID: 178057 RVA: 0x005FC14F File Offset: 0x005FA34F
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B78A RID: 178058 RVA: 0x005FC169 File Offset: 0x005FA369
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B78B RID: 178059 RVA: 0x005FC187 File Offset: 0x005FA387
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B78C RID: 178060 RVA: 0x005FC1A0 File Offset: 0x005FA3A0
		public static void StartBoardPosIndexListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B78D RID: 178061 RVA: 0x005FC1AB File Offset: 0x005FA3AB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602B78E RID: 178062 RVA: 0x005FC1B6 File Offset: 0x005FA3B6
		public static Offset<IBvbUseItemCardSkill> EndIBvbUseItemCardSkill(FlatBufferBuilder builder)
		{
			return new Offset<IBvbUseItemCardSkill>(builder.EndTable());
		}

		// Token: 0x0602B78F RID: 178063 RVA: 0x005FC1C4 File Offset: 0x005FA3C4
		public IBvbUseItemCardSkillT UnPack()
		{
			IBvbUseItemCardSkillT bvbUseItemCardSkillT = new IBvbUseItemCardSkillT();
			this.UnPackTo(bvbUseItemCardSkillT);
			return bvbUseItemCardSkillT;
		}

		// Token: 0x0602B790 RID: 178064 RVA: 0x005FC1E0 File Offset: 0x005FA3E0
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

		// Token: 0x0602B791 RID: 178065 RVA: 0x005FC234 File Offset: 0x005FA434
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

		// Token: 0x040107C2 RID: 67522
		private Table __p;
	}
}
