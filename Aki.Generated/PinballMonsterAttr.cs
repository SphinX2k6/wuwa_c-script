using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001015 RID: 4117
	public struct PinballMonsterAttr : IFlatbufferObject
	{
		// Token: 0x170029DC RID: 10716
		// (get) Token: 0x0600B587 RID: 46471 RVA: 0x002DF6EE File Offset: 0x002DD8EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B588 RID: 46472 RVA: 0x002DF6FB File Offset: 0x002DD8FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B589 RID: 46473 RVA: 0x002DF704 File Offset: 0x002DD904
		public static PinballMonsterAttr GetRootAsPinballMonsterAttr(ByteBuffer _bb)
		{
			return PinballMonsterAttr.GetRootAsPinballMonsterAttr(_bb, default(PinballMonsterAttr));
		}

		// Token: 0x0600B58A RID: 46474 RVA: 0x002DF720 File Offset: 0x002DD920
		public static PinballMonsterAttr GetRootAsPinballMonsterAttr(ByteBuffer _bb, PinballMonsterAttr obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B58B RID: 46475 RVA: 0x002DF73D File Offset: 0x002DD93D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B58C RID: 46476 RVA: 0x002DF74C File Offset: 0x002DD94C
		public PinballMonsterAttr __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x0600B58D RID: 46477 RVA: 0x002DF75C File Offset: 0x002DD95C
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

		// Token: 0x170029DE RID: 10718
		// (get) Token: 0x0600B58E RID: 46478 RVA: 0x002DF798 File Offset: 0x002DD998
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

		// Token: 0x170029DF RID: 10719
		// (get) Token: 0x0600B58F RID: 46479 RVA: 0x002DF7D4 File Offset: 0x002DD9D4
		public int LifeMax
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

		// Token: 0x170029E0 RID: 10720
		// (get) Token: 0x0600B590 RID: 46480 RVA: 0x002DF810 File Offset: 0x002DDA10
		public int Atk
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

		// Token: 0x170029E1 RID: 10721
		// (get) Token: 0x0600B591 RID: 46481 RVA: 0x002DF850 File Offset: 0x002DDA50
		public int Def
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

		// Token: 0x170029E2 RID: 10722
		// (get) Token: 0x0600B592 RID: 46482 RVA: 0x002DF890 File Offset: 0x002DDA90
		public int Crit
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

		// Token: 0x170029E3 RID: 10723
		// (get) Token: 0x0600B593 RID: 46483 RVA: 0x002DF8D0 File Offset: 0x002DDAD0
		public int CritDamage
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

		// Token: 0x170029E4 RID: 10724
		// (get) Token: 0x0600B594 RID: 46484 RVA: 0x002DF910 File Offset: 0x002DDB10
		public int DamageAmplify1
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

		// Token: 0x170029E5 RID: 10725
		// (get) Token: 0x0600B595 RID: 46485 RVA: 0x002DF950 File Offset: 0x002DDB50
		public int DamageReduce
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

		// Token: 0x170029E6 RID: 10726
		// (get) Token: 0x0600B596 RID: 46486 RVA: 0x002DF990 File Offset: 0x002DDB90
		public int DamageReduceAuto
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

		// Token: 0x170029E7 RID: 10727
		// (get) Token: 0x0600B597 RID: 46487 RVA: 0x002DF9D0 File Offset: 0x002DDBD0
		public int DamageReduceStrong
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

		// Token: 0x170029E8 RID: 10728
		// (get) Token: 0x0600B598 RID: 46488 RVA: 0x002DFA10 File Offset: 0x002DDC10
		public int DamageReduceSkill
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

		// Token: 0x170029E9 RID: 10729
		// (get) Token: 0x0600B599 RID: 46489 RVA: 0x002DFA50 File Offset: 0x002DDC50
		public int DamageReduceSprint
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

		// Token: 0x170029EA RID: 10730
		// (get) Token: 0x0600B59A RID: 46490 RVA: 0x002DFA90 File Offset: 0x002DDC90
		public int DamageReduceSummon
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

		// Token: 0x170029EB RID: 10731
		// (get) Token: 0x0600B59B RID: 46491 RVA: 0x002DFAD0 File Offset: 0x002DDCD0
		public int ProtectMax
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040055DF RID: 21983
		private Table __p;
	}
}
