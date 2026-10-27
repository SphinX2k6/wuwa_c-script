using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB4 RID: 2996
	public struct DailyTaskCountryUnlock : IFlatbufferObject
	{
		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06005B16 RID: 23318 RVA: 0x002035F8 File Offset: 0x002017F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005B17 RID: 23319 RVA: 0x00203605 File Offset: 0x00201805
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005B18 RID: 23320 RVA: 0x0020360C File Offset: 0x0020180C
		public static DailyTaskCountryUnlock GetRootAsDailyTaskCountryUnlock(ByteBuffer _bb)
		{
			return DailyTaskCountryUnlock.GetRootAsDailyTaskCountryUnlock(_bb, default(DailyTaskCountryUnlock));
		}

		// Token: 0x06005B19 RID: 23321 RVA: 0x00203628 File Offset: 0x00201828
		public static DailyTaskCountryUnlock GetRootAsDailyTaskCountryUnlock(ByteBuffer _bb, DailyTaskCountryUnlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005B1A RID: 23322 RVA: 0x00203645 File Offset: 0x00201845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005B1B RID: 23323 RVA: 0x00203654 File Offset: 0x00201854
		public DailyTaskCountryUnlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06005B1C RID: 23324 RVA: 0x00203664 File Offset: 0x00201864
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

		// Token: 0x04004BD8 RID: 19416
		private Table __p;
	}
}
