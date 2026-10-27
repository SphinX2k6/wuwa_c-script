using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200451E RID: 17694
	public struct ILevelPlayZaxis : IFlatbufferObject
	{
		// Token: 0x17007D6D RID: 32109
		// (get) Token: 0x0601A977 RID: 108919 RVA: 0x003CBE6C File Offset: 0x003CA06C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A978 RID: 108920 RVA: 0x003CBE79 File Offset: 0x003CA079
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A979 RID: 108921 RVA: 0x003CBE80 File Offset: 0x003CA080
		public static ILevelPlayZaxis GetRootAsILevelPlayZaxis(ByteBuffer _bb)
		{
			return ILevelPlayZaxis.GetRootAsILevelPlayZaxis(_bb, default(ILevelPlayZaxis));
		}

		// Token: 0x0601A97A RID: 108922 RVA: 0x003CBE9C File Offset: 0x003CA09C
		public static ILevelPlayZaxis GetRootAsILevelPlayZaxis(ByteBuffer _bb, ILevelPlayZaxis obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A97B RID: 108923 RVA: 0x003CBEB9 File Offset: 0x003CA0B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A97C RID: 108924 RVA: 0x003CBEC8 File Offset: 0x003CA0C8
		public ILevelPlayZaxis __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D6E RID: 32110
		// (get) Token: 0x0601A97D RID: 108925 RVA: 0x003CBED8 File Offset: 0x003CA0D8
		public int Up
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007D6F RID: 32111
		// (get) Token: 0x0601A97E RID: 108926 RVA: 0x003CBF14 File Offset: 0x003CA114
		public int Down
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

		// Token: 0x17007D70 RID: 32112
		// (get) Token: 0x0601A97F RID: 108927 RVA: 0x003CBF50 File Offset: 0x003CA150
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

		// Token: 0x0601A980 RID: 108928 RVA: 0x003CBF8C File Offset: 0x003CA18C
		public static Offset<ILevelPlayZaxis> CreateILevelPlayZaxis(FlatBufferBuilder builder, int Up = 0, int Down = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILevelPlayZaxis.AddDown(builder, Down);
			ILevelPlayZaxis.AddUp(builder, Up);
			ILevelPlayZaxis.AddNullMask(builder, NullMask);
			return ILevelPlayZaxis.EndILevelPlayZaxis(builder);
		}

		// Token: 0x0601A981 RID: 108929 RVA: 0x003CBFB0 File Offset: 0x003CA1B0
		public static void StartILevelPlayZaxis(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A982 RID: 108930 RVA: 0x003CBFB9 File Offset: 0x003CA1B9
		public static void AddUp(FlatBufferBuilder builder, int up)
		{
			builder.AddInt(0, up, 0);
		}

		// Token: 0x0601A983 RID: 108931 RVA: 0x003CBFC4 File Offset: 0x003CA1C4
		public static void AddDown(FlatBufferBuilder builder, int down)
		{
			builder.AddInt(1, down, 0);
		}

		// Token: 0x0601A984 RID: 108932 RVA: 0x003CBFCF File Offset: 0x003CA1CF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601A985 RID: 108933 RVA: 0x003CBFDA File Offset: 0x003CA1DA
		public static Offset<ILevelPlayZaxis> EndILevelPlayZaxis(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayZaxis>(builder.EndTable());
		}

		// Token: 0x0601A986 RID: 108934 RVA: 0x003CBFE8 File Offset: 0x003CA1E8
		public ILevelPlayZaxisT UnPack()
		{
			ILevelPlayZaxisT levelPlayZaxisT = new ILevelPlayZaxisT();
			this.UnPackTo(levelPlayZaxisT);
			return levelPlayZaxisT;
		}

		// Token: 0x0601A987 RID: 108935 RVA: 0x003CC003 File Offset: 0x003CA203
		public void UnPackTo(ILevelPlayZaxisT _o)
		{
			_o.Up = this.Up;
			_o.Down = this.Down;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A988 RID: 108936 RVA: 0x003CC02C File Offset: 0x003CA22C
		public static Offset<ILevelPlayZaxis> Pack(FlatBufferBuilder builder, ILevelPlayZaxisT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayZaxis>);
			}
			return ILevelPlayZaxis.CreateILevelPlayZaxis(builder, _o.Up, _o.Down, _o.NullMask);
		}

		// Token: 0x0400C598 RID: 50584
		private Table __p;
	}
}
