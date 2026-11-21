using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001320 RID: 4896
	public struct TetrisBoardItemConfig : IFlatbufferObject
	{
		// Token: 0x170042B6 RID: 17078
		// (get) Token: 0x0600F94A RID: 63818 RVA: 0x00375D0E File Offset: 0x00373F0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F94B RID: 63819 RVA: 0x00375D1B File Offset: 0x00373F1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F94C RID: 63820 RVA: 0x00375D24 File Offset: 0x00373F24
		public static TetrisBoardItemConfig GetRootAsTetrisBoardItemConfig(ByteBuffer _bb)
		{
			return TetrisBoardItemConfig.GetRootAsTetrisBoardItemConfig(_bb, default(TetrisBoardItemConfig));
		}

		// Token: 0x0600F94D RID: 63821 RVA: 0x00375D40 File Offset: 0x00373F40
		public static TetrisBoardItemConfig GetRootAsTetrisBoardItemConfig(ByteBuffer _bb, TetrisBoardItemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F94E RID: 63822 RVA: 0x00375D5D File Offset: 0x00373F5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F94F RID: 63823 RVA: 0x00375D6C File Offset: 0x00373F6C
		public TetrisBoardItemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170042B7 RID: 17079
		// (get) Token: 0x0600F950 RID: 63824 RVA: 0x00375D7C File Offset: 0x00373F7C
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

		// Token: 0x170042B8 RID: 17080
		// (get) Token: 0x0600F951 RID: 63825 RVA: 0x00375DB8 File Offset: 0x00373FB8
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

		// Token: 0x170042B9 RID: 17081
		// (get) Token: 0x0600F952 RID: 63826 RVA: 0x00375DF4 File Offset: 0x00373FF4
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

		// Token: 0x170042BA RID: 17082
		// (get) Token: 0x0600F953 RID: 63827 RVA: 0x00375E30 File Offset: 0x00374030
		public bool Block
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040059A6 RID: 22950
		private Table __p;
	}
}
