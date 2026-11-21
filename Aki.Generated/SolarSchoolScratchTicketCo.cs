using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001202 RID: 4610
	public struct SolarSchoolScratchTicketCo : IFlatbufferObject
	{
		// Token: 0x17003A93 RID: 14995
		// (get) Token: 0x0600E3D8 RID: 58328 RVA: 0x00346546 File Offset: 0x00344746
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E3D9 RID: 58329 RVA: 0x00346553 File Offset: 0x00344753
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E3DA RID: 58330 RVA: 0x0034655C File Offset: 0x0034475C
		public static SolarSchoolScratchTicketCo GetRootAsSolarSchoolScratchTicketCo(ByteBuffer _bb)
		{
			return SolarSchoolScratchTicketCo.GetRootAsSolarSchoolScratchTicketCo(_bb, default(SolarSchoolScratchTicketCo));
		}

		// Token: 0x0600E3DB RID: 58331 RVA: 0x00346578 File Offset: 0x00344778
		public static SolarSchoolScratchTicketCo GetRootAsSolarSchoolScratchTicketCo(ByteBuffer _bb, SolarSchoolScratchTicketCo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E3DC RID: 58332 RVA: 0x00346595 File Offset: 0x00344795
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E3DD RID: 58333 RVA: 0x003465A4 File Offset: 0x003447A4
		public SolarSchoolScratchTicketCo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A94 RID: 14996
		// (get) Token: 0x0600E3DE RID: 58334 RVA: 0x003465B4 File Offset: 0x003447B4
		public int RoundId
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

		// Token: 0x17003A95 RID: 14997
		// (get) Token: 0x0600E3DF RID: 58335 RVA: 0x003465F0 File Offset: 0x003447F0
		public int CostItem1ConfirmId
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

		// Token: 0x17003A96 RID: 14998
		// (get) Token: 0x0600E3E0 RID: 58336 RVA: 0x0034662C File Offset: 0x0034482C
		public int CostItem2ConfirmId
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

		// Token: 0x17003A97 RID: 14999
		// (get) Token: 0x0600E3E1 RID: 58337 RVA: 0x00346668 File Offset: 0x00344868
		public int Size
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

		// Token: 0x17003A98 RID: 15000
		// (get) Token: 0x0600E3E2 RID: 58338 RVA: 0x003466A8 File Offset: 0x003448A8
		public IntPair? Cost
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IntPair?(default(IntPair).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003A99 RID: 15001
		// (get) Token: 0x0600E3E3 RID: 58339 RVA: 0x00346708 File Offset: 0x00344908
		public int Probability
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

		// Token: 0x17003A9A RID: 15002
		// (get) Token: 0x0600E3E4 RID: 58340 RVA: 0x00346748 File Offset: 0x00344948
		public int Type
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003A9B RID: 15003
		// (get) Token: 0x0600E3E5 RID: 58341 RVA: 0x00346788 File Offset: 0x00344988
		public int MinCondition
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003A9C RID: 15004
		// (get) Token: 0x0600E3E6 RID: 58342 RVA: 0x003467C8 File Offset: 0x003449C8
		public int MaxCondition
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003A9D RID: 15005
		// (get) Token: 0x0600E3E7 RID: 58343 RVA: 0x00346808 File Offset: 0x00344A08
		public int CostId1
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003A9E RID: 15006
		// (get) Token: 0x0600E3E8 RID: 58344 RVA: 0x00346848 File Offset: 0x00344A48
		public int CostId2
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005840 RID: 22592
		private Table __p;
	}
}
