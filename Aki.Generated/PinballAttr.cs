using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F20 RID: 3872
	public struct PinballAttr : IFlatbufferObject
	{
		// Token: 0x170028CB RID: 10443
		// (get) Token: 0x0600ADD6 RID: 44502 RVA: 0x002BF201 File Offset: 0x002BD401
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ADD7 RID: 44503 RVA: 0x002BF20E File Offset: 0x002BD40E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ADD8 RID: 44504 RVA: 0x002BF218 File Offset: 0x002BD418
		public static PinballAttr GetRootAsPinballAttr(ByteBuffer _bb)
		{
			return PinballAttr.GetRootAsPinballAttr(_bb, default(PinballAttr));
		}

		// Token: 0x0600ADD9 RID: 44505 RVA: 0x002BF234 File Offset: 0x002BD434
		public static PinballAttr GetRootAsPinballAttr(ByteBuffer _bb, PinballAttr obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ADDA RID: 44506 RVA: 0x002BF251 File Offset: 0x002BD451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ADDB RID: 44507 RVA: 0x002BF260 File Offset: 0x002BD460
		public PinballAttr __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028CC RID: 10444
		// (get) Token: 0x0600ADDC RID: 44508 RVA: 0x002BF270 File Offset: 0x002BD470
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

		// Token: 0x170028CD RID: 10445
		// (get) Token: 0x0600ADDD RID: 44509 RVA: 0x002BF2AC File Offset: 0x002BD4AC
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

		// Token: 0x170028CE RID: 10446
		// (get) Token: 0x0600ADDE RID: 44510 RVA: 0x002BF2E8 File Offset: 0x002BD4E8
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

		// Token: 0x170028CF RID: 10447
		// (get) Token: 0x0600ADDF RID: 44511 RVA: 0x002BF324 File Offset: 0x002BD524
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

		// Token: 0x170028D0 RID: 10448
		// (get) Token: 0x0600ADE0 RID: 44512 RVA: 0x002BF364 File Offset: 0x002BD564
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

		// Token: 0x170028D1 RID: 10449
		// (get) Token: 0x0600ADE1 RID: 44513 RVA: 0x002BF3A4 File Offset: 0x002BD5A4
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

		// Token: 0x170028D2 RID: 10450
		// (get) Token: 0x0600ADE2 RID: 44514 RVA: 0x002BF3E4 File Offset: 0x002BD5E4
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

		// Token: 0x170028D3 RID: 10451
		// (get) Token: 0x0600ADE3 RID: 44515 RVA: 0x002BF424 File Offset: 0x002BD624
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

		// Token: 0x170028D4 RID: 10452
		// (get) Token: 0x0600ADE4 RID: 44516 RVA: 0x002BF464 File Offset: 0x002BD664
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

		// Token: 0x170028D5 RID: 10453
		// (get) Token: 0x0600ADE5 RID: 44517 RVA: 0x002BF4A4 File Offset: 0x002BD6A4
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

		// Token: 0x170028D6 RID: 10454
		// (get) Token: 0x0600ADE6 RID: 44518 RVA: 0x002BF4E4 File Offset: 0x002BD6E4
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

		// Token: 0x170028D7 RID: 10455
		// (get) Token: 0x0600ADE7 RID: 44519 RVA: 0x002BF524 File Offset: 0x002BD724
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

		// Token: 0x170028D8 RID: 10456
		// (get) Token: 0x0600ADE8 RID: 44520 RVA: 0x002BF564 File Offset: 0x002BD764
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

		// Token: 0x170028D9 RID: 10457
		// (get) Token: 0x0600ADE9 RID: 44521 RVA: 0x002BF5A4 File Offset: 0x002BD7A4
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

		// Token: 0x170028DA RID: 10458
		// (get) Token: 0x0600ADEA RID: 44522 RVA: 0x002BF5E4 File Offset: 0x002BD7E4
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

		// Token: 0x170028DB RID: 10459
		// (get) Token: 0x0600ADEB RID: 44523 RVA: 0x002BF624 File Offset: 0x002BD824
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

		// Token: 0x170028DC RID: 10460
		// (get) Token: 0x0600ADEC RID: 44524 RVA: 0x002BF664 File Offset: 0x002BD864
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

		// Token: 0x170028DD RID: 10461
		// (get) Token: 0x0600ADED RID: 44525 RVA: 0x002BF6A4 File Offset: 0x002BD8A4
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

		// Token: 0x170028DE RID: 10462
		// (get) Token: 0x0600ADEE RID: 44526 RVA: 0x002BF6E4 File Offset: 0x002BD8E4
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

		// Token: 0x170028DF RID: 10463
		// (get) Token: 0x0600ADEF RID: 44527 RVA: 0x002BF724 File Offset: 0x002BD924
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

		// Token: 0x170028E0 RID: 10464
		// (get) Token: 0x0600ADF0 RID: 44528 RVA: 0x002BF764 File Offset: 0x002BD964
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

		// Token: 0x170028E1 RID: 10465
		// (get) Token: 0x0600ADF1 RID: 44529 RVA: 0x002BF7A4 File Offset: 0x002BD9A4
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

		// Token: 0x170028E2 RID: 10466
		// (get) Token: 0x0600ADF2 RID: 44530 RVA: 0x002BF7E4 File Offset: 0x002BD9E4
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

		// Token: 0x170028E3 RID: 10467
		// (get) Token: 0x0600ADF3 RID: 44531 RVA: 0x002BF824 File Offset: 0x002BDA24
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

		// Token: 0x170028E4 RID: 10468
		// (get) Token: 0x0600ADF4 RID: 44532 RVA: 0x002BF864 File Offset: 0x002BDA64
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

		// Token: 0x170028E5 RID: 10469
		// (get) Token: 0x0600ADF5 RID: 44533 RVA: 0x002BF8A4 File Offset: 0x002BDAA4
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

		// Token: 0x170028E6 RID: 10470
		// (get) Token: 0x0600ADF6 RID: 44534 RVA: 0x002BF8E4 File Offset: 0x002BDAE4
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

		// Token: 0x170028E7 RID: 10471
		// (get) Token: 0x0600ADF7 RID: 44535 RVA: 0x002BF924 File Offset: 0x002BDB24
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

		// Token: 0x170028E8 RID: 10472
		// (get) Token: 0x0600ADF8 RID: 44536 RVA: 0x002BF964 File Offset: 0x002BDB64
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

		// Token: 0x170028E9 RID: 10473
		// (get) Token: 0x0600ADF9 RID: 44537 RVA: 0x002BF9A4 File Offset: 0x002BDBA4
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

		// Token: 0x170028EA RID: 10474
		// (get) Token: 0x0600ADFA RID: 44538 RVA: 0x002BF9E4 File Offset: 0x002BDBE4
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

		// Token: 0x170028EB RID: 10475
		// (get) Token: 0x0600ADFB RID: 44539 RVA: 0x002BFA24 File Offset: 0x002BDC24
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

		// Token: 0x170028EC RID: 10476
		// (get) Token: 0x0600ADFC RID: 44540 RVA: 0x002BFA64 File Offset: 0x002BDC64
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

		// Token: 0x170028ED RID: 10477
		// (get) Token: 0x0600ADFD RID: 44541 RVA: 0x002BFAA4 File Offset: 0x002BDCA4
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

		// Token: 0x170028EE RID: 10478
		// (get) Token: 0x0600ADFE RID: 44542 RVA: 0x002BFAE4 File Offset: 0x002BDCE4
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

		// Token: 0x170028EF RID: 10479
		// (get) Token: 0x0600ADFF RID: 44543 RVA: 0x002BFB24 File Offset: 0x002BDD24
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

		// Token: 0x170028F0 RID: 10480
		// (get) Token: 0x0600AE00 RID: 44544 RVA: 0x002BFB64 File Offset: 0x002BDD64
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

		// Token: 0x04004FE9 RID: 20457
		private Table __p;
	}
}
