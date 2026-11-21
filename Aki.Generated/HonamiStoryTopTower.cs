using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E36 RID: 3638
	public struct HonamiStoryTopTower : IFlatbufferObject
	{
		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x060087B3 RID: 34739 RVA: 0x002798B4 File Offset: 0x00277AB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060087B4 RID: 34740 RVA: 0x002798C1 File Offset: 0x00277AC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060087B5 RID: 34741 RVA: 0x002798C8 File Offset: 0x00277AC8
		public static HonamiStoryTopTower GetRootAsHonamiStoryTopTower(ByteBuffer _bb)
		{
			return HonamiStoryTopTower.GetRootAsHonamiStoryTopTower(_bb, default(HonamiStoryTopTower));
		}

		// Token: 0x060087B6 RID: 34742 RVA: 0x002798E4 File Offset: 0x00277AE4
		public static HonamiStoryTopTower GetRootAsHonamiStoryTopTower(ByteBuffer _bb, HonamiStoryTopTower obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060087B7 RID: 34743 RVA: 0x00279901 File Offset: 0x00277B01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060087B8 RID: 34744 RVA: 0x00279910 File Offset: 0x00277B10
		public HonamiStoryTopTower __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x060087B9 RID: 34745 RVA: 0x00279920 File Offset: 0x00277B20
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

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x060087BA RID: 34746 RVA: 0x0027995C File Offset: 0x00277B5C
		public int ActivityId
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

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x060087BB RID: 34747 RVA: 0x00279998 File Offset: 0x00277B98
		public int Floor
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

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x060087BC RID: 34748 RVA: 0x002799D4 File Offset: 0x00277BD4
		public int DropId
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

		// Token: 0x040053B4 RID: 21428
		private Table __p;
	}
}
