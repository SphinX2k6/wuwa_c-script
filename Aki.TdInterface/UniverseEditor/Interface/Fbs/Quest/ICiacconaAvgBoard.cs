using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D8E RID: 15758
	public struct ICiacconaAvgBoard : IFlatbufferObject
	{
		// Token: 0x17006C58 RID: 27736
		// (get) Token: 0x06015E08 RID: 89608 RVA: 0x00328DF2 File Offset: 0x00326FF2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015E09 RID: 89609 RVA: 0x00328DFF File Offset: 0x00326FFF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015E0A RID: 89610 RVA: 0x00328E08 File Offset: 0x00327008
		public static ICiacconaAvgBoard GetRootAsICiacconaAvgBoard(ByteBuffer _bb)
		{
			return ICiacconaAvgBoard.GetRootAsICiacconaAvgBoard(_bb, default(ICiacconaAvgBoard));
		}

		// Token: 0x06015E0B RID: 89611 RVA: 0x00328E24 File Offset: 0x00327024
		public static ICiacconaAvgBoard GetRootAsICiacconaAvgBoard(ByteBuffer _bb, ICiacconaAvgBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015E0C RID: 89612 RVA: 0x00328E41 File Offset: 0x00327041
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015E0D RID: 89613 RVA: 0x00328E50 File Offset: 0x00327050
		public ICiacconaAvgBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C59 RID: 27737
		// (get) Token: 0x06015E0E RID: 89614 RVA: 0x00328E60 File Offset: 0x00327060
		public EShowUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowUiType.All;
				}
				return (EShowUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C5A RID: 27738
		// (get) Token: 0x06015E0F RID: 89615 RVA: 0x00328E9C File Offset: 0x0032709C
		public int EndingId
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

		// Token: 0x17006C5B RID: 27739
		// (get) Token: 0x06015E10 RID: 89616 RVA: 0x00328ED8 File Offset: 0x003270D8
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

		// Token: 0x06015E11 RID: 89617 RVA: 0x00328F14 File Offset: 0x00327114
		public static Offset<ICiacconaAvgBoard> CreateICiacconaAvgBoard(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, int EndingId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICiacconaAvgBoard.AddEndingId(builder, EndingId);
			ICiacconaAvgBoard.AddNullMask(builder, NullMask);
			ICiacconaAvgBoard.AddType(builder, Type);
			return ICiacconaAvgBoard.EndICiacconaAvgBoard(builder);
		}

		// Token: 0x06015E12 RID: 89618 RVA: 0x00328F38 File Offset: 0x00327138
		public static void StartICiacconaAvgBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015E13 RID: 89619 RVA: 0x00328F41 File Offset: 0x00327141
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015E14 RID: 89620 RVA: 0x00328F4C File Offset: 0x0032714C
		public static void AddEndingId(FlatBufferBuilder builder, int endingId)
		{
			builder.AddInt(1, endingId, 0);
		}

		// Token: 0x06015E15 RID: 89621 RVA: 0x00328F57 File Offset: 0x00327157
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06015E16 RID: 89622 RVA: 0x00328F62 File Offset: 0x00327162
		public static Offset<ICiacconaAvgBoard> EndICiacconaAvgBoard(FlatBufferBuilder builder)
		{
			return new Offset<ICiacconaAvgBoard>(builder.EndTable());
		}

		// Token: 0x06015E17 RID: 89623 RVA: 0x00328F70 File Offset: 0x00327170
		public ICiacconaAvgBoardT UnPack()
		{
			ICiacconaAvgBoardT ciacconaAvgBoardT = new ICiacconaAvgBoardT();
			this.UnPackTo(ciacconaAvgBoardT);
			return ciacconaAvgBoardT;
		}

		// Token: 0x06015E18 RID: 89624 RVA: 0x00328F8B File Offset: 0x0032718B
		public void UnPackTo(ICiacconaAvgBoardT _o)
		{
			_o.Type = this.Type;
			_o.EndingId = this.EndingId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015E19 RID: 89625 RVA: 0x00328FB4 File Offset: 0x003271B4
		public static Offset<ICiacconaAvgBoard> Pack(FlatBufferBuilder builder, ICiacconaAvgBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICiacconaAvgBoard>);
			}
			return ICiacconaAvgBoard.CreateICiacconaAvgBoard(builder, _o.Type, _o.EndingId, _o.NullMask);
		}

		// Token: 0x0400B695 RID: 46741
		private Table __p;
	}
}
