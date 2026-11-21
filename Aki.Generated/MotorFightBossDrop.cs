using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F22 RID: 3874
	public struct MotorFightBossDrop : IFlatbufferObject
	{
		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x06009E03 RID: 40451 RVA: 0x002AB874 File Offset: 0x002A9A74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E04 RID: 40452 RVA: 0x002AB881 File Offset: 0x002A9A81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E05 RID: 40453 RVA: 0x002AB888 File Offset: 0x002A9A88
		public static MotorFightBossDrop GetRootAsMotorFightBossDrop(ByteBuffer _bb)
		{
			return MotorFightBossDrop.GetRootAsMotorFightBossDrop(_bb, default(MotorFightBossDrop));
		}

		// Token: 0x06009E06 RID: 40454 RVA: 0x002AB8A4 File Offset: 0x002A9AA4
		public static MotorFightBossDrop GetRootAsMotorFightBossDrop(ByteBuffer _bb, MotorFightBossDrop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E07 RID: 40455 RVA: 0x002AB8C1 File Offset: 0x002A9AC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E08 RID: 40456 RVA: 0x002AB8D0 File Offset: 0x002A9AD0
		public MotorFightBossDrop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x06009E09 RID: 40457 RVA: 0x002AB8E0 File Offset: 0x002A9AE0
		public int DropId
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

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x06009E0A RID: 40458 RVA: 0x002AB91C File Offset: 0x002A9B1C
		public int GroupId
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

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x06009E0B RID: 40459 RVA: 0x002AB958 File Offset: 0x002A9B58
		public int Weight
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

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x06009E0C RID: 40460 RVA: 0x002AB994 File Offset: 0x002A9B94
		public int CollectionGroup1
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

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x06009E0D RID: 40461 RVA: 0x002AB9D4 File Offset: 0x002A9BD4
		public int CollectionGroup2
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

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x06009E0E RID: 40462 RVA: 0x002ABA14 File Offset: 0x002A9C14
		public int CollectionGroup3
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

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x06009E0F RID: 40463 RVA: 0x002ABA54 File Offset: 0x002A9C54
		public int UpperLimitItemGroup
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

		// Token: 0x040054CA RID: 21706
		private Table __p;
	}
}
