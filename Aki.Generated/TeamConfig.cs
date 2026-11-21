using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200124D RID: 4685
	public struct TeamConfig : IFlatbufferObject
	{
		// Token: 0x17003D18 RID: 15640
		// (get) Token: 0x0600EA4F RID: 59983 RVA: 0x00354E41 File Offset: 0x00353041
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA50 RID: 59984 RVA: 0x00354E4E File Offset: 0x0035304E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA51 RID: 59985 RVA: 0x00354E58 File Offset: 0x00353058
		public static TeamConfig GetRootAsTeamConfig(ByteBuffer _bb)
		{
			return TeamConfig.GetRootAsTeamConfig(_bb, default(TeamConfig));
		}

		// Token: 0x0600EA52 RID: 59986 RVA: 0x00354E74 File Offset: 0x00353074
		public static TeamConfig GetRootAsTeamConfig(ByteBuffer _bb, TeamConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA53 RID: 59987 RVA: 0x00354E91 File Offset: 0x00353091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA54 RID: 59988 RVA: 0x00354EA0 File Offset: 0x003530A0
		public TeamConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D19 RID: 15641
		// (get) Token: 0x0600EA55 RID: 59989 RVA: 0x00354EB0 File Offset: 0x003530B0
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

		// Token: 0x17003D1A RID: 15642
		// (get) Token: 0x0600EA56 RID: 59990 RVA: 0x00354EEC File Offset: 0x003530EC
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

		// Token: 0x17003D1B RID: 15643
		// (get) Token: 0x0600EA57 RID: 59991 RVA: 0x00354F28 File Offset: 0x00353128
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

		// Token: 0x17003D1C RID: 15644
		// (get) Token: 0x0600EA58 RID: 59992 RVA: 0x00354F64 File Offset: 0x00353164
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

		// Token: 0x17003D1D RID: 15645
		// (get) Token: 0x0600EA59 RID: 59993 RVA: 0x00354FA4 File Offset: 0x003531A4
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

		// Token: 0x17003D1E RID: 15646
		// (get) Token: 0x0600EA5A RID: 59994 RVA: 0x00354FE4 File Offset: 0x003531E4
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

		// Token: 0x17003D1F RID: 15647
		// (get) Token: 0x0600EA5B RID: 59995 RVA: 0x00355024 File Offset: 0x00353224
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

		// Token: 0x17003D20 RID: 15648
		// (get) Token: 0x0600EA5C RID: 59996 RVA: 0x00355064 File Offset: 0x00353264
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

		// Token: 0x17003D21 RID: 15649
		// (get) Token: 0x0600EA5D RID: 59997 RVA: 0x003550A4 File Offset: 0x003532A4
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

		// Token: 0x17003D22 RID: 15650
		// (get) Token: 0x0600EA5E RID: 59998 RVA: 0x003550E4 File Offset: 0x003532E4
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

		// Token: 0x17003D23 RID: 15651
		// (get) Token: 0x0600EA5F RID: 59999 RVA: 0x00355124 File Offset: 0x00353324
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

		// Token: 0x17003D24 RID: 15652
		// (get) Token: 0x0600EA60 RID: 60000 RVA: 0x00355164 File Offset: 0x00353364
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

		// Token: 0x04005897 RID: 22679
		private Table __p;
	}
}
