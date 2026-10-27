using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001125 RID: 4389
	public struct TetrisMap : IFlatbufferObject
	{
		// Token: 0x17003A3A RID: 14906
		// (get) Token: 0x0600DE3D RID: 56893 RVA: 0x0032C7F0 File Offset: 0x0032A9F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE3E RID: 56894 RVA: 0x0032C7FD File Offset: 0x0032A9FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE3F RID: 56895 RVA: 0x0032C804 File Offset: 0x0032AA04
		public static TetrisMap GetRootAsTetrisMap(ByteBuffer _bb)
		{
			return TetrisMap.GetRootAsTetrisMap(_bb, default(TetrisMap));
		}

		// Token: 0x0600DE40 RID: 56896 RVA: 0x0032C820 File Offset: 0x0032AA20
		public static TetrisMap GetRootAsTetrisMap(ByteBuffer _bb, TetrisMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE41 RID: 56897 RVA: 0x0032C83D File Offset: 0x0032AA3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE42 RID: 56898 RVA: 0x0032C84C File Offset: 0x0032AA4C
		public TetrisMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A3B RID: 14907
		// (get) Token: 0x0600DE43 RID: 56899 RVA: 0x0032C85C File Offset: 0x0032AA5C
		public int Id
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

		// Token: 0x17003A3C RID: 14908
		// (get) Token: 0x0600DE44 RID: 56900 RVA: 0x0032C898 File Offset: 0x0032AA98
		public int MapID
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

		// Token: 0x17003A3D RID: 14909
		// (get) Token: 0x0600DE45 RID: 56901 RVA: 0x0032C8D4 File Offset: 0x0032AAD4
		public TetrisBoardItemConfig? Column1
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new TetrisBoardItemConfig?(default(TetrisBoardItemConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003A3E RID: 14910
		// (get) Token: 0x0600DE46 RID: 56902 RVA: 0x0032C934 File Offset: 0x0032AB34
		public TetrisBoardItemConfig? Column2
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new TetrisBoardItemConfig?(default(TetrisBoardItemConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003A3F RID: 14911
		// (get) Token: 0x0600DE47 RID: 56903 RVA: 0x0032C994 File Offset: 0x0032AB94
		public TetrisBoardItemConfig? Column3
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new TetrisBoardItemConfig?(default(TetrisBoardItemConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003A40 RID: 14912
		// (get) Token: 0x0600DE48 RID: 56904 RVA: 0x0032C9F4 File Offset: 0x0032ABF4
		public TetrisBoardItemConfig? Column4
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new TetrisBoardItemConfig?(default(TetrisBoardItemConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003A41 RID: 14913
		// (get) Token: 0x0600DE49 RID: 56905 RVA: 0x0032CA54 File Offset: 0x0032AC54
		public TetrisBoardItemConfig? Column5
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new TetrisBoardItemConfig?(default(TetrisBoardItemConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003A42 RID: 14914
		// (get) Token: 0x0600DE4A RID: 56906 RVA: 0x0032CAB4 File Offset: 0x0032ACB4
		public TetrisBoardItemConfig? Column6
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new TetrisBoardItemConfig?(default(TetrisBoardItemConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003A43 RID: 14915
		// (get) Token: 0x0600DE4B RID: 56907 RVA: 0x0032CB14 File Offset: 0x0032AD14
		public TetrisBoardItemConfig? Column7
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new TetrisBoardItemConfig?(default(TetrisBoardItemConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003A44 RID: 14916
		// (get) Token: 0x0600DE4C RID: 56908 RVA: 0x0032CB74 File Offset: 0x0032AD74
		public TetrisBoardItemConfig? Column8
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new TetrisBoardItemConfig?(default(TetrisBoardItemConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x04005263 RID: 21091
		private Table __p;
	}
}
