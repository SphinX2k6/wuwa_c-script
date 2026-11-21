using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E30 RID: 3632
	public struct HonamiStoryRandomLevelPlay : IFlatbufferObject
	{
		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x0600872A RID: 34602 RVA: 0x0027851A File Offset: 0x0027671A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600872B RID: 34603 RVA: 0x00278527 File Offset: 0x00276727
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600872C RID: 34604 RVA: 0x00278530 File Offset: 0x00276730
		public static HonamiStoryRandomLevelPlay GetRootAsHonamiStoryRandomLevelPlay(ByteBuffer _bb)
		{
			return HonamiStoryRandomLevelPlay.GetRootAsHonamiStoryRandomLevelPlay(_bb, default(HonamiStoryRandomLevelPlay));
		}

		// Token: 0x0600872D RID: 34605 RVA: 0x0027854C File Offset: 0x0027674C
		public static HonamiStoryRandomLevelPlay GetRootAsHonamiStoryRandomLevelPlay(ByteBuffer _bb, HonamiStoryRandomLevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600872E RID: 34606 RVA: 0x00278569 File Offset: 0x00276769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600872F RID: 34607 RVA: 0x00278578 File Offset: 0x00276778
		public HonamiStoryRandomLevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x06008730 RID: 34608 RVA: 0x00278588 File Offset: 0x00276788
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

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x06008731 RID: 34609 RVA: 0x002785C4 File Offset: 0x002767C4
		public int Group
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

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x06008732 RID: 34610 RVA: 0x00278600 File Offset: 0x00276800
		public int BTId
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

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x06008733 RID: 34611 RVA: 0x0027863C File Offset: 0x0027683C
		public int Weight
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040053AC RID: 21420
		private Table __p;
	}
}
