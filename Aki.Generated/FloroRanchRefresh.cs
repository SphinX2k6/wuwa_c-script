using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D92 RID: 3474
	public struct FloroRanchRefresh : IFlatbufferObject
	{
		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x060079BC RID: 31164 RVA: 0x0025AB68 File Offset: 0x00258D68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060079BD RID: 31165 RVA: 0x0025AB75 File Offset: 0x00258D75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060079BE RID: 31166 RVA: 0x0025AB7C File Offset: 0x00258D7C
		public static FloroRanchRefresh GetRootAsFloroRanchRefresh(ByteBuffer _bb)
		{
			return FloroRanchRefresh.GetRootAsFloroRanchRefresh(_bb, default(FloroRanchRefresh));
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x0025AB98 File Offset: 0x00258D98
		public static FloroRanchRefresh GetRootAsFloroRanchRefresh(ByteBuffer _bb, FloroRanchRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060079C0 RID: 31168 RVA: 0x0025ABB5 File Offset: 0x00258DB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060079C1 RID: 31169 RVA: 0x0025ABC4 File Offset: 0x00258DC4
		public FloroRanchRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x060079C2 RID: 31170 RVA: 0x0025ABD4 File Offset: 0x00258DD4
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

		// Token: 0x040052F6 RID: 21238
		private Table __p;
	}
}
