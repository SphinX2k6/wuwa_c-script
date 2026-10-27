using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E9 RID: 4585
	public struct TetrisBoardItemConfig : IFlatbufferObject
	{
		// Token: 0x17003F4E RID: 16206
		// (get) Token: 0x0600EBD1 RID: 60369 RVA: 0x0034B059 File Offset: 0x00349259
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EBD2 RID: 60370 RVA: 0x0034B066 File Offset: 0x00349266
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EBD3 RID: 60371 RVA: 0x0034B070 File Offset: 0x00349270
		public static TetrisBoardItemConfig GetRootAsTetrisBoardItemConfig(ByteBuffer _bb)
		{
			return TetrisBoardItemConfig.GetRootAsTetrisBoardItemConfig(_bb, default(TetrisBoardItemConfig));
		}

		// Token: 0x0600EBD4 RID: 60372 RVA: 0x0034B08C File Offset: 0x0034928C
		public static TetrisBoardItemConfig GetRootAsTetrisBoardItemConfig(ByteBuffer _bb, TetrisBoardItemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EBD5 RID: 60373 RVA: 0x0034B0A9 File Offset: 0x003492A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EBD6 RID: 60374 RVA: 0x0034B0B8 File Offset: 0x003492B8
		public TetrisBoardItemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F4F RID: 16207
		// (get) Token: 0x0600EBD7 RID: 60375 RVA: 0x0034B0C8 File Offset: 0x003492C8
		public int Color
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

		// Token: 0x17003F50 RID: 16208
		// (get) Token: 0x0600EBD8 RID: 60376 RVA: 0x0034B104 File Offset: 0x00349304
		public int Gem
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

		// Token: 0x17003F51 RID: 16209
		// (get) Token: 0x0600EBD9 RID: 60377 RVA: 0x0034B140 File Offset: 0x00349340
		public int Seal
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

		// Token: 0x17003F52 RID: 16210
		// (get) Token: 0x0600EBDA RID: 60378 RVA: 0x0034B17C File Offset: 0x0034937C
		public bool Block
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005362 RID: 21346
		private Table __p;
	}
}
