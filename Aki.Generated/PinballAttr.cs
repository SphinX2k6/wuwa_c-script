using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001005 RID: 4101
	public struct PinballAttr : IFlatbufferObject
	{
		// Token: 0x17002931 RID: 10545
		// (get) Token: 0x0600B3F7 RID: 46071 RVA: 0x002DBD80 File Offset: 0x002D9F80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B3F8 RID: 46072 RVA: 0x002DBD8D File Offset: 0x002D9F8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B3F9 RID: 46073 RVA: 0x002DBD94 File Offset: 0x002D9F94
		public static PinballAttr GetRootAsPinballAttr(ByteBuffer _bb)
		{
			return PinballAttr.GetRootAsPinballAttr(_bb, default(PinballAttr));
		}

		// Token: 0x0600B3FA RID: 46074 RVA: 0x002DBDB0 File Offset: 0x002D9FB0
		public static PinballAttr GetRootAsPinballAttr(ByteBuffer _bb, PinballAttr obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B3FB RID: 46075 RVA: 0x002DBDCD File Offset: 0x002D9FCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B3FC RID: 46076 RVA: 0x002DBDDC File Offset: 0x002D9FDC
		public PinballAttr __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002932 RID: 10546
		// (get) Token: 0x0600B3FD RID: 46077 RVA: 0x002DBDEC File Offset: 0x002D9FEC
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

		// Token: 0x17002933 RID: 10547
		// (get) Token: 0x0600B3FE RID: 46078 RVA: 0x002DBE28 File Offset: 0x002DA028
		public int Life
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

		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x0600B3FF RID: 46079 RVA: 0x002DBE64 File Offset: 0x002DA064
		public int BaseLife
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x0600B400 RID: 46080 RVA: 0x002DBEA0 File Offset: 0x002DA0A0
		public int LifeMax
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002936 RID: 10550
		// (get) Token: 0x0600B401 RID: 46081 RVA: 0x002DBEE0 File Offset: 0x002DA0E0
		public int Atk
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002937 RID: 10551
		// (get) Token: 0x0600B402 RID: 46082 RVA: 0x002DBF20 File Offset: 0x002DA120
		public int Def
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

		// Token: 0x17002938 RID: 10552
		// (get) Token: 0x0600B403 RID: 46083 RVA: 0x002DBF60 File Offset: 0x002DA160
		public int Crit
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

		// Token: 0x17002939 RID: 10553
		// (get) Token: 0x0600B404 RID: 46084 RVA: 0x002DBFA0 File Offset: 0x002DA1A0
		public int CritDamage
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

		// Token: 0x1700293A RID: 10554
		// (get) Token: 0x0600B405 RID: 46085 RVA: 0x002DBFE0 File Offset: 0x002DA1E0
		public int Energy
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

		// Token: 0x1700293B RID: 10555
		// (get) Token: 0x0600B406 RID: 46086 RVA: 0x002DC020 File Offset: 0x002DA220
		public int EnergyMax
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

		// Token: 0x1700293C RID: 10556
		// (get) Token: 0x0600B407 RID: 46087 RVA: 0x002DC060 File Offset: 0x002DA260
		public int EnergyRecoverSpeed
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

		// Token: 0x1700293D RID: 10557
		// (get) Token: 0x0600B408 RID: 46088 RVA: 0x002DC0A0 File Offset: 0x002DA2A0
		public int EnergyEfficiency
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

		// Token: 0x1700293E RID: 10558
		// (get) Token: 0x0600B409 RID: 46089 RVA: 0x002DC0E0 File Offset: 0x002DA2E0
		public int SprintEnergy
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700293F RID: 10559
		// (get) Token: 0x0600B40A RID: 46090 RVA: 0x002DC120 File Offset: 0x002DA320
		public int SprintEnergyMax
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x0600B40B RID: 46091 RVA: 0x002DC160 File Offset: 0x002DA360
		public int SprintEnergyRecoverSpeed
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x0600B40C RID: 46092 RVA: 0x002DC1A0 File Offset: 0x002DA3A0
		public int SprintEnergyEfficiency
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x0600B40D RID: 46093 RVA: 0x002DC1E0 File Offset: 0x002DA3E0
		public int FeverEnergy
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x0600B40E RID: 46094 RVA: 0x002DC220 File Offset: 0x002DA420
		public int FeverEnergyMax
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002944 RID: 10564
		// (get) Token: 0x0600B40F RID: 46095 RVA: 0x002DC260 File Offset: 0x002DA460
		public int FeverEnergyRecoverSpeed
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x0600B410 RID: 46096 RVA: 0x002DC2A0 File Offset: 0x002DA4A0
		public int FeverEnergyCostSpeed
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x0600B411 RID: 46097 RVA: 0x002DC2E0 File Offset: 0x002DA4E0
		public int FeverEnergyEfficiency
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x0600B412 RID: 46098 RVA: 0x002DC320 File Offset: 0x002DA520
		public int DamageChangeAuto
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002948 RID: 10568
		// (get) Token: 0x0600B413 RID: 46099 RVA: 0x002DC360 File Offset: 0x002DA560
		public int DamageChangeStrong
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002949 RID: 10569
		// (get) Token: 0x0600B414 RID: 46100 RVA: 0x002DC3A0 File Offset: 0x002DA5A0
		public int DamageChangeSkill
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700294A RID: 10570
		// (get) Token: 0x0600B415 RID: 46101 RVA: 0x002DC3E0 File Offset: 0x002DA5E0
		public int DamageChangeSprint
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700294B RID: 10571
		// (get) Token: 0x0600B416 RID: 46102 RVA: 0x002DC420 File Offset: 0x002DA620
		public int DamageChangeSummon
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700294C RID: 10572
		// (get) Token: 0x0600B417 RID: 46103 RVA: 0x002DC460 File Offset: 0x002DA660
		public int DamageChange
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700294D RID: 10573
		// (get) Token: 0x0600B418 RID: 46104 RVA: 0x002DC4A0 File Offset: 0x002DA6A0
		public int DamageAmplify1
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700294E RID: 10574
		// (get) Token: 0x0600B419 RID: 46105 RVA: 0x002DC4E0 File Offset: 0x002DA6E0
		public int DamageReduce
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700294F RID: 10575
		// (get) Token: 0x0600B41A RID: 46106 RVA: 0x002DC520 File Offset: 0x002DA720
		public int DamageReduceAuto
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002950 RID: 10576
		// (get) Token: 0x0600B41B RID: 46107 RVA: 0x002DC560 File Offset: 0x002DA760
		public int DamageReduceStrong
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002951 RID: 10577
		// (get) Token: 0x0600B41C RID: 46108 RVA: 0x002DC5A0 File Offset: 0x002DA7A0
		public int DamageReduceSkill
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002952 RID: 10578
		// (get) Token: 0x0600B41D RID: 46109 RVA: 0x002DC5E0 File Offset: 0x002DA7E0
		public int DamageReduceSprint
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002953 RID: 10579
		// (get) Token: 0x0600B41E RID: 46110 RVA: 0x002DC620 File Offset: 0x002DA820
		public int DamageReduceSummon
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002954 RID: 10580
		// (get) Token: 0x0600B41F RID: 46111 RVA: 0x002DC660 File Offset: 0x002DA860
		public int HealEfficiency
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002955 RID: 10581
		// (get) Token: 0x0600B420 RID: 46112 RVA: 0x002DC6A0 File Offset: 0x002DA8A0
		public int ProtectEfficiency
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002956 RID: 10582
		// (get) Token: 0x0600B421 RID: 46113 RVA: 0x002DC6E0 File Offset: 0x002DA8E0
		public int ProtectMax
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040055CE RID: 21966
		private Table __p;
	}
}
