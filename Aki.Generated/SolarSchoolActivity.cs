using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D1 RID: 4561
	public struct SolarSchoolActivity : IFlatbufferObject
	{
		// Token: 0x1700389D RID: 14493
		// (get) Token: 0x0600DF0D RID: 57101 RVA: 0x0033B69C File Offset: 0x0033989C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DF0E RID: 57102 RVA: 0x0033B6A9 File Offset: 0x003398A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DF0F RID: 57103 RVA: 0x0033B6B0 File Offset: 0x003398B0
		public static SolarSchoolActivity GetRootAsSolarSchoolActivity(ByteBuffer _bb)
		{
			return SolarSchoolActivity.GetRootAsSolarSchoolActivity(_bb, default(SolarSchoolActivity));
		}

		// Token: 0x0600DF10 RID: 57104 RVA: 0x0033B6CC File Offset: 0x003398CC
		public static SolarSchoolActivity GetRootAsSolarSchoolActivity(ByteBuffer _bb, SolarSchoolActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DF11 RID: 57105 RVA: 0x0033B6E9 File Offset: 0x003398E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DF12 RID: 57106 RVA: 0x0033B6F8 File Offset: 0x003398F8
		public SolarSchoolActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700389E RID: 14494
		// (get) Token: 0x0600DF13 RID: 57107 RVA: 0x0033B708 File Offset: 0x00339908
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 28;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700389F RID: 14495
		// (get) Token: 0x0600DF14 RID: 57108 RVA: 0x0033B748 File Offset: 0x00339948
		public int SaveSlot
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170038A0 RID: 14496
		// (get) Token: 0x0600DF15 RID: 57109 RVA: 0x0033B784 File Offset: 0x00339984
		public int LimitAccNeedNum
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

		// Token: 0x170038A1 RID: 14497
		// (get) Token: 0x0600DF16 RID: 57110 RVA: 0x0033B7C0 File Offset: 0x003399C0
		public int LimitAccDropId
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

		// Token: 0x170038A2 RID: 14498
		// (get) Token: 0x0600DF17 RID: 57111 RVA: 0x0033B800 File Offset: 0x00339A00
		public int WeekScheduleMax
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x0600DF18 RID: 57112 RVA: 0x0033B840 File Offset: 0x00339A40
		public int ScheduleHistoryWeekMax
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005808 RID: 22536
		private Table __p;
	}
}
