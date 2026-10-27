using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E3B RID: 3643
	public struct MotorFightAttr : IFlatbufferObject
	{
		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x060097B5 RID: 38837 RVA: 0x0028D388 File Offset: 0x0028B588
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060097B6 RID: 38838 RVA: 0x0028D395 File Offset: 0x0028B595
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060097B7 RID: 38839 RVA: 0x0028D39C File Offset: 0x0028B59C
		public static MotorFightAttr GetRootAsMotorFightAttr(ByteBuffer _bb)
		{
			return MotorFightAttr.GetRootAsMotorFightAttr(_bb, default(MotorFightAttr));
		}

		// Token: 0x060097B8 RID: 38840 RVA: 0x0028D3B8 File Offset: 0x0028B5B8
		public static MotorFightAttr GetRootAsMotorFightAttr(ByteBuffer _bb, MotorFightAttr obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060097B9 RID: 38841 RVA: 0x0028D3D5 File Offset: 0x0028B5D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060097BA RID: 38842 RVA: 0x0028D3E4 File Offset: 0x0028B5E4
		public MotorFightAttr __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x060097BB RID: 38843 RVA: 0x0028D3F4 File Offset: 0x0028B5F4
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

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x060097BC RID: 38844 RVA: 0x0028D430 File Offset: 0x0028B630
		public int Life
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

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x060097BD RID: 38845 RVA: 0x0028D46C File Offset: 0x0028B66C
		public int LifeMax
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

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x060097BE RID: 38846 RVA: 0x0028D4A8 File Offset: 0x0028B6A8
		public int Atk
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

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x060097BF RID: 38847 RVA: 0x0028D4E8 File Offset: 0x0028B6E8
		public int Shield
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

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x060097C0 RID: 38848 RVA: 0x0028D528 File Offset: 0x0028B728
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

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x060097C1 RID: 38849 RVA: 0x0028D568 File Offset: 0x0028B768
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

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x060097C2 RID: 38850 RVA: 0x0028D5A8 File Offset: 0x0028B7A8
		public int AtkChange
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

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x060097C3 RID: 38851 RVA: 0x0028D5E8 File Offset: 0x0028B7E8
		public int MaxLifeShieldChange
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

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x060097C4 RID: 38852 RVA: 0x0028D628 File Offset: 0x0028B828
		public int CritChange
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

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x060097C5 RID: 38853 RVA: 0x0028D668 File Offset: 0x0028B868
		public int DamageChange
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

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x060097C6 RID: 38854 RVA: 0x0028D6A8 File Offset: 0x0028B8A8
		public int DamageReduce
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

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x060097C7 RID: 38855 RVA: 0x0028D6E8 File Offset: 0x0028B8E8
		public int DamageLifeSteal
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

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x060097C8 RID: 38856 RVA: 0x0028D728 File Offset: 0x0028B928
		public int HealedChange
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

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x060097C9 RID: 38857 RVA: 0x0028D768 File Offset: 0x0028B968
		public int DamageReduceCollision
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

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x060097CA RID: 38858 RVA: 0x0028D7A8 File Offset: 0x0028B9A8
		public int HealBase
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

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x060097CB RID: 38859 RVA: 0x0028D7E8 File Offset: 0x0028B9E8
		public int MoveSpeed
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x060097CC RID: 38860 RVA: 0x0028D828 File Offset: 0x0028BA28
		public int DamageAbsorptionCount
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

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x060097CD RID: 38861 RVA: 0x0028D868 File Offset: 0x0028BA68
		public int AttackSpeed
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x060097CE RID: 38862 RVA: 0x0028D8A8 File Offset: 0x0028BAA8
		public int AttackSpeedChange
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

		// Token: 0x04004EE3 RID: 20195
		private Table __p;
	}
}
