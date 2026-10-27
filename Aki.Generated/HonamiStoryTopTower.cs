using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D51 RID: 3409
	public struct HonamiStoryTopTower : IFlatbufferObject
	{
		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x06008199 RID: 33177 RVA: 0x0025B114 File Offset: 0x00259314
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600819A RID: 33178 RVA: 0x0025B121 File Offset: 0x00259321
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600819B RID: 33179 RVA: 0x0025B128 File Offset: 0x00259328
		public static HonamiStoryTopTower GetRootAsHonamiStoryTopTower(ByteBuffer _bb)
		{
			return HonamiStoryTopTower.GetRootAsHonamiStoryTopTower(_bb, default(HonamiStoryTopTower));
		}

		// Token: 0x0600819C RID: 33180 RVA: 0x0025B144 File Offset: 0x00259344
		public static HonamiStoryTopTower GetRootAsHonamiStoryTopTower(ByteBuffer _bb, HonamiStoryTopTower obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600819D RID: 33181 RVA: 0x0025B161 File Offset: 0x00259361
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600819E RID: 33182 RVA: 0x0025B170 File Offset: 0x00259370
		public HonamiStoryTopTower __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x0600819F RID: 33183 RVA: 0x0025B180 File Offset: 0x00259380
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

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x060081A0 RID: 33184 RVA: 0x0025B1BC File Offset: 0x002593BC
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

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x060081A1 RID: 33185 RVA: 0x0025B1F8 File Offset: 0x002593F8
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

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x060081A2 RID: 33186 RVA: 0x0025B234 File Offset: 0x00259434
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

		// Token: 0x04004DCF RID: 19919
		private Table __p;
	}
}
