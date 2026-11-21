using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A5 RID: 16805
	public struct ICiacconaAvgBoard : IFlatbufferObject
	{
		// Token: 0x17007212 RID: 29202
		// (get) Token: 0x06017340 RID: 95040 RVA: 0x0035011E File Offset: 0x0034E31E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017341 RID: 95041 RVA: 0x0035012B File Offset: 0x0034E32B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017342 RID: 95042 RVA: 0x00350134 File Offset: 0x0034E334
		public static ICiacconaAvgBoard GetRootAsICiacconaAvgBoard(ByteBuffer _bb)
		{
			return ICiacconaAvgBoard.GetRootAsICiacconaAvgBoard(_bb, default(ICiacconaAvgBoard));
		}

		// Token: 0x06017343 RID: 95043 RVA: 0x00350150 File Offset: 0x0034E350
		public static ICiacconaAvgBoard GetRootAsICiacconaAvgBoard(ByteBuffer _bb, ICiacconaAvgBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017344 RID: 95044 RVA: 0x0035016D File Offset: 0x0034E36D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017345 RID: 95045 RVA: 0x0035017C File Offset: 0x0034E37C
		public ICiacconaAvgBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007213 RID: 29203
		// (get) Token: 0x06017346 RID: 95046 RVA: 0x0035018C File Offset: 0x0034E38C
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

		// Token: 0x17007214 RID: 29204
		// (get) Token: 0x06017347 RID: 95047 RVA: 0x003501C8 File Offset: 0x0034E3C8
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

		// Token: 0x17007215 RID: 29205
		// (get) Token: 0x06017348 RID: 95048 RVA: 0x00350204 File Offset: 0x0034E404
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

		// Token: 0x06017349 RID: 95049 RVA: 0x00350240 File Offset: 0x0034E440
		public static Offset<ICiacconaAvgBoard> CreateICiacconaAvgBoard(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, int EndingId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICiacconaAvgBoard.AddEndingId(builder, EndingId);
			ICiacconaAvgBoard.AddNullMask(builder, NullMask);
			ICiacconaAvgBoard.AddType(builder, Type);
			return ICiacconaAvgBoard.EndICiacconaAvgBoard(builder);
		}

		// Token: 0x0601734A RID: 95050 RVA: 0x00350264 File Offset: 0x0034E464
		public static void StartICiacconaAvgBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601734B RID: 95051 RVA: 0x0035026D File Offset: 0x0034E46D
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601734C RID: 95052 RVA: 0x00350278 File Offset: 0x0034E478
		public static void AddEndingId(FlatBufferBuilder builder, int endingId)
		{
			builder.AddInt(1, endingId, 0);
		}

		// Token: 0x0601734D RID: 95053 RVA: 0x00350283 File Offset: 0x0034E483
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601734E RID: 95054 RVA: 0x0035028E File Offset: 0x0034E48E
		public static Offset<ICiacconaAvgBoard> EndICiacconaAvgBoard(FlatBufferBuilder builder)
		{
			return new Offset<ICiacconaAvgBoard>(builder.EndTable());
		}

		// Token: 0x0601734F RID: 95055 RVA: 0x0035029C File Offset: 0x0034E49C
		public ICiacconaAvgBoardT UnPack()
		{
			ICiacconaAvgBoardT ciacconaAvgBoardT = new ICiacconaAvgBoardT();
			this.UnPackTo(ciacconaAvgBoardT);
			return ciacconaAvgBoardT;
		}

		// Token: 0x06017350 RID: 95056 RVA: 0x003502B7 File Offset: 0x0034E4B7
		public void UnPackTo(ICiacconaAvgBoardT _o)
		{
			_o.Type = this.Type;
			_o.EndingId = this.EndingId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017351 RID: 95057 RVA: 0x003502E0 File Offset: 0x0034E4E0
		public static Offset<ICiacconaAvgBoard> Pack(FlatBufferBuilder builder, ICiacconaAvgBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICiacconaAvgBoard>);
			}
			return ICiacconaAvgBoard.CreateICiacconaAvgBoard(builder, _o.Type, _o.EndingId, _o.NullMask);
		}

		// Token: 0x0400C042 RID: 49218
		private Table __p;
	}
}
