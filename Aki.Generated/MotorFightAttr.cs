using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F20 RID: 3872
	public struct MotorFightAttr : IFlatbufferObject
	{
		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x06009DD5 RID: 40405 RVA: 0x002AAFEC File Offset: 0x002A91EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009DD6 RID: 40406 RVA: 0x002AAFF9 File Offset: 0x002A91F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009DD7 RID: 40407 RVA: 0x002AB000 File Offset: 0x002A9200
		public static MotorFightAttr GetRootAsMotorFightAttr(ByteBuffer _bb)
		{
			return MotorFightAttr.GetRootAsMotorFightAttr(_bb, default(MotorFightAttr));
		}

		// Token: 0x06009DD8 RID: 40408 RVA: 0x002AB01C File Offset: 0x002A921C
		public static MotorFightAttr GetRootAsMotorFightAttr(ByteBuffer _bb, MotorFightAttr obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009DD9 RID: 40409 RVA: 0x002AB039 File Offset: 0x002A9239
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009DDA RID: 40410 RVA: 0x002AB048 File Offset: 0x002A9248
		public MotorFightAttr __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x06009DDB RID: 40411 RVA: 0x002AB058 File Offset: 0x002A9258
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

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x06009DDC RID: 40412 RVA: 0x002AB094 File Offset: 0x002A9294
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

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x06009DDD RID: 40413 RVA: 0x002AB0D0 File Offset: 0x002A92D0
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

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x06009DDE RID: 40414 RVA: 0x002AB10C File Offset: 0x002A930C
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

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x06009DDF RID: 40415 RVA: 0x002AB14C File Offset: 0x002A934C
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

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x06009DE0 RID: 40416 RVA: 0x002AB18C File Offset: 0x002A938C
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

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x06009DE1 RID: 40417 RVA: 0x002AB1CC File Offset: 0x002A93CC
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

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x06009DE2 RID: 40418 RVA: 0x002AB20C File Offset: 0x002A940C
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

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x06009DE3 RID: 40419 RVA: 0x002AB24C File Offset: 0x002A944C
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

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x06009DE4 RID: 40420 RVA: 0x002AB28C File Offset: 0x002A948C
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

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x06009DE5 RID: 40421 RVA: 0x002AB2CC File Offset: 0x002A94CC
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

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x06009DE6 RID: 40422 RVA: 0x002AB30C File Offset: 0x002A950C
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

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x06009DE7 RID: 40423 RVA: 0x002AB34C File Offset: 0x002A954C
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

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x06009DE8 RID: 40424 RVA: 0x002AB38C File Offset: 0x002A958C
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

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x06009DE9 RID: 40425 RVA: 0x002AB3CC File Offset: 0x002A95CC
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

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x06009DEA RID: 40426 RVA: 0x002AB40C File Offset: 0x002A960C
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

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x06009DEB RID: 40427 RVA: 0x002AB44C File Offset: 0x002A964C
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

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x06009DEC RID: 40428 RVA: 0x002AB48C File Offset: 0x002A968C
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

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x06009DED RID: 40429 RVA: 0x002AB4CC File Offset: 0x002A96CC
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

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x06009DEE RID: 40430 RVA: 0x002AB50C File Offset: 0x002A970C
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

		// Token: 0x040054C8 RID: 21704
		private Table __p;
	}
}
