using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D43 RID: 3395
	public struct HonamiStoryPluginBoxItem : IFlatbufferObject
	{
		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x060080AA RID: 32938 RVA: 0x00258FB1 File Offset: 0x002571B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060080AB RID: 32939 RVA: 0x00258FBE File Offset: 0x002571BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060080AC RID: 32940 RVA: 0x00258FC8 File Offset: 0x002571C8
		public static HonamiStoryPluginBoxItem GetRootAsHonamiStoryPluginBoxItem(ByteBuffer _bb)
		{
			return HonamiStoryPluginBoxItem.GetRootAsHonamiStoryPluginBoxItem(_bb, default(HonamiStoryPluginBoxItem));
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x00258FE4 File Offset: 0x002571E4
		public static HonamiStoryPluginBoxItem GetRootAsHonamiStoryPluginBoxItem(ByteBuffer _bb, HonamiStoryPluginBoxItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060080AE RID: 32942 RVA: 0x00259001 File Offset: 0x00257201
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060080AF RID: 32943 RVA: 0x00259010 File Offset: 0x00257210
		public HonamiStoryPluginBoxItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x060080B0 RID: 32944 RVA: 0x00259020 File Offset: 0x00257220
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

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x060080B1 RID: 32945 RVA: 0x0025905C File Offset: 0x0025725C
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

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x060080B2 RID: 32946 RVA: 0x00259098 File Offset: 0x00257298
		public int BuyLimit
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

		// Token: 0x04004DBE RID: 19902
		private Table __p;
	}
}
