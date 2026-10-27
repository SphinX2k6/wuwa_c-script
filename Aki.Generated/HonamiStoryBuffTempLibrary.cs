using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D32 RID: 3378
	public struct HonamiStoryBuffTempLibrary : IFlatbufferObject
	{
		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x06007F43 RID: 32579 RVA: 0x00255F48 File Offset: 0x00254148
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007F44 RID: 32580 RVA: 0x00255F55 File Offset: 0x00254155
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007F45 RID: 32581 RVA: 0x00255F5C File Offset: 0x0025415C
		public static HonamiStoryBuffTempLibrary GetRootAsHonamiStoryBuffTempLibrary(ByteBuffer _bb)
		{
			return HonamiStoryBuffTempLibrary.GetRootAsHonamiStoryBuffTempLibrary(_bb, default(HonamiStoryBuffTempLibrary));
		}

		// Token: 0x06007F46 RID: 32582 RVA: 0x00255F78 File Offset: 0x00254178
		public static HonamiStoryBuffTempLibrary GetRootAsHonamiStoryBuffTempLibrary(ByteBuffer _bb, HonamiStoryBuffTempLibrary obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007F47 RID: 32583 RVA: 0x00255F95 File Offset: 0x00254195
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007F48 RID: 32584 RVA: 0x00255FA4 File Offset: 0x002541A4
		public HonamiStoryBuffTempLibrary __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06007F49 RID: 32585 RVA: 0x00255FB4 File Offset: 0x002541B4
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

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x06007F4A RID: 32586 RVA: 0x00255FF0 File Offset: 0x002541F0
		public int BuffTermpId
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

		// Token: 0x04004DAB RID: 19883
		private Table __p;
	}
}
