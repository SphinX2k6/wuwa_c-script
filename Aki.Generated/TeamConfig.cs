using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001117 RID: 4375
	public struct TeamConfig : IFlatbufferObject
	{
		// Token: 0x170039C2 RID: 14786
		// (get) Token: 0x0600DD04 RID: 56580 RVA: 0x00329CED File Offset: 0x00327EED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DD05 RID: 56581 RVA: 0x00329CFA File Offset: 0x00327EFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DD06 RID: 56582 RVA: 0x00329D04 File Offset: 0x00327F04
		public static TeamConfig GetRootAsTeamConfig(ByteBuffer _bb)
		{
			return TeamConfig.GetRootAsTeamConfig(_bb, default(TeamConfig));
		}

		// Token: 0x0600DD07 RID: 56583 RVA: 0x00329D20 File Offset: 0x00327F20
		public static TeamConfig GetRootAsTeamConfig(ByteBuffer _bb, TeamConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DD08 RID: 56584 RVA: 0x00329D3D File Offset: 0x00327F3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DD09 RID: 56585 RVA: 0x00329D4C File Offset: 0x00327F4C
		public TeamConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039C3 RID: 14787
		// (get) Token: 0x0600DD0A RID: 56586 RVA: 0x00329D5C File Offset: 0x00327F5C
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

		// Token: 0x170039C4 RID: 14788
		// (get) Token: 0x0600DD0B RID: 56587 RVA: 0x00329D98 File Offset: 0x00327F98
		public int BuffId
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

		// Token: 0x170039C5 RID: 14789
		// (get) Token: 0x0600DD0C RID: 56588 RVA: 0x00329DD4 File Offset: 0x00327FD4
		public int InviteEffectTime
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

		// Token: 0x170039C6 RID: 14790
		// (get) Token: 0x0600DD0D RID: 56589 RVA: 0x00329E10 File Offset: 0x00328010
		public int ViolationOperationTimes
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

		// Token: 0x170039C7 RID: 14791
		// (get) Token: 0x0600DD0E RID: 56590 RVA: 0x00329E50 File Offset: 0x00328050
		public int ViolationOperationBanTime
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

		// Token: 0x170039C8 RID: 14792
		// (get) Token: 0x0600DD0F RID: 56591 RVA: 0x00329E90 File Offset: 0x00328090
		public int BanTimesCheck
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

		// Token: 0x170039C9 RID: 14793
		// (get) Token: 0x0600DD10 RID: 56592 RVA: 0x00329ED0 File Offset: 0x003280D0
		public int BBanTime
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

		// Token: 0x170039CA RID: 14794
		// (get) Token: 0x0600DD11 RID: 56593 RVA: 0x00329F10 File Offset: 0x00328110
		public int CBanTime
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

		// Token: 0x170039CB RID: 14795
		// (get) Token: 0x0600DD12 RID: 56594 RVA: 0x00329F50 File Offset: 0x00328150
		public int InviteCD
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

		// Token: 0x170039CC RID: 14796
		// (get) Token: 0x0600DD13 RID: 56595 RVA: 0x00329F90 File Offset: 0x00328190
		public int NearbrPlayerCount
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

		// Token: 0x170039CD RID: 14797
		// (get) Token: 0x0600DD14 RID: 56596 RVA: 0x00329FD0 File Offset: 0x003281D0
		public int NearbrPlayerCountRefreshCD
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

		// Token: 0x170039CE RID: 14798
		// (get) Token: 0x0600DD15 RID: 56597 RVA: 0x0032A010 File Offset: 0x00328210
		public int ViolationOperationTimeLimit
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005254 RID: 21076
		private Table __p;
	}
}
