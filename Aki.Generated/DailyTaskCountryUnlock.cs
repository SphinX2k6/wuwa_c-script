using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C96 RID: 3222
	public struct DailyTaskCountryUnlock : IFlatbufferObject
	{
		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x060060EF RID: 24815 RVA: 0x002232A0 File Offset: 0x002214A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060060F0 RID: 24816 RVA: 0x002232AD File Offset: 0x002214AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060060F1 RID: 24817 RVA: 0x002232B4 File Offset: 0x002214B4
		public static DailyTaskCountryUnlock GetRootAsDailyTaskCountryUnlock(ByteBuffer _bb)
		{
			return DailyTaskCountryUnlock.GetRootAsDailyTaskCountryUnlock(_bb, default(DailyTaskCountryUnlock));
		}

		// Token: 0x060060F2 RID: 24818 RVA: 0x002232D0 File Offset: 0x002214D0
		public static DailyTaskCountryUnlock GetRootAsDailyTaskCountryUnlock(ByteBuffer _bb, DailyTaskCountryUnlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x002232ED File Offset: 0x002214ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x002232FC File Offset: 0x002214FC
		public DailyTaskCountryUnlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x060060F5 RID: 24821 RVA: 0x0022330C File Offset: 0x0022150C
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

		// Token: 0x040051BA RID: 20922
		private Table __p;
	}
}
