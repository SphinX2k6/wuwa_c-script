using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200125B RID: 4699
	public struct TetrisMap : IFlatbufferObject
	{
		// Token: 0x17003D9C RID: 15772
		// (get) Token: 0x0600EBA4 RID: 60324 RVA: 0x00357D10 File Offset: 0x00355F10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EBA5 RID: 60325 RVA: 0x00357D1D File Offset: 0x00355F1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EBA6 RID: 60326 RVA: 0x00357D24 File Offset: 0x00355F24
		public static TetrisMap GetRootAsTetrisMap(ByteBuffer _bb)
		{
			return TetrisMap.GetRootAsTetrisMap(_bb, default(TetrisMap));
		}

		// Token: 0x0600EBA7 RID: 60327 RVA: 0x00357D40 File Offset: 0x00355F40
		public static TetrisMap GetRootAsTetrisMap(ByteBuffer _bb, TetrisMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EBA8 RID: 60328 RVA: 0x00357D5D File Offset: 0x00355F5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EBA9 RID: 60329 RVA: 0x00357D6C File Offset: 0x00355F6C
		public TetrisMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D9D RID: 15773
		// (get) Token: 0x0600EBAA RID: 60330 RVA: 0x00357D7C File Offset: 0x00355F7C
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

		// Token: 0x17003D9E RID: 15774
		// (get) Token: 0x0600EBAB RID: 60331 RVA: 0x00357DB8 File Offset: 0x00355FB8
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

		// Token: 0x17003D9F RID: 15775
		// (get) Token: 0x0600EBAC RID: 60332 RVA: 0x00357DF4 File Offset: 0x00355FF4
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

		// Token: 0x17003DA0 RID: 15776
		// (get) Token: 0x0600EBAD RID: 60333 RVA: 0x00357E54 File Offset: 0x00356054
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

		// Token: 0x17003DA1 RID: 15777
		// (get) Token: 0x0600EBAE RID: 60334 RVA: 0x00357EB4 File Offset: 0x003560B4
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

		// Token: 0x17003DA2 RID: 15778
		// (get) Token: 0x0600EBAF RID: 60335 RVA: 0x00357F14 File Offset: 0x00356114
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

		// Token: 0x17003DA3 RID: 15779
		// (get) Token: 0x0600EBB0 RID: 60336 RVA: 0x00357F74 File Offset: 0x00356174
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

		// Token: 0x17003DA4 RID: 15780
		// (get) Token: 0x0600EBB1 RID: 60337 RVA: 0x00357FD4 File Offset: 0x003561D4
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

		// Token: 0x17003DA5 RID: 15781
		// (get) Token: 0x0600EBB2 RID: 60338 RVA: 0x00358034 File Offset: 0x00356234
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

		// Token: 0x17003DA6 RID: 15782
		// (get) Token: 0x0600EBB3 RID: 60339 RVA: 0x00358094 File Offset: 0x00356294
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

		// Token: 0x040058A6 RID: 22694
		private Table __p;
	}
}
