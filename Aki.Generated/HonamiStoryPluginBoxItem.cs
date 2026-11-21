using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E28 RID: 3624
	public struct HonamiStoryPluginBoxItem : IFlatbufferObject
	{
		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x060086C4 RID: 34500 RVA: 0x002777AD File Offset: 0x002759AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060086C5 RID: 34501 RVA: 0x002777BA File Offset: 0x002759BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060086C6 RID: 34502 RVA: 0x002777C4 File Offset: 0x002759C4
		public static HonamiStoryPluginBoxItem GetRootAsHonamiStoryPluginBoxItem(ByteBuffer _bb)
		{
			return HonamiStoryPluginBoxItem.GetRootAsHonamiStoryPluginBoxItem(_bb, default(HonamiStoryPluginBoxItem));
		}

		// Token: 0x060086C7 RID: 34503 RVA: 0x002777E0 File Offset: 0x002759E0
		public static HonamiStoryPluginBoxItem GetRootAsHonamiStoryPluginBoxItem(ByteBuffer _bb, HonamiStoryPluginBoxItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060086C8 RID: 34504 RVA: 0x002777FD File Offset: 0x002759FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060086C9 RID: 34505 RVA: 0x0027780C File Offset: 0x00275A0C
		public HonamiStoryPluginBoxItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x060086CA RID: 34506 RVA: 0x0027781C File Offset: 0x00275A1C
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

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x060086CB RID: 34507 RVA: 0x00277858 File Offset: 0x00275A58
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

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x060086CC RID: 34508 RVA: 0x00277894 File Offset: 0x00275A94
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

		// Token: 0x040053A3 RID: 21411
		private Table __p;
	}
}
