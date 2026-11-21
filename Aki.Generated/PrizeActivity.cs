using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001040 RID: 4160
	public struct PrizeActivity : IFlatbufferObject
	{
		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x0600B9A1 RID: 47521 RVA: 0x002E821A File Offset: 0x002E641A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B9A2 RID: 47522 RVA: 0x002E8227 File Offset: 0x002E6427
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B9A3 RID: 47523 RVA: 0x002E8230 File Offset: 0x002E6430
		public static PrizeActivity GetRootAsPrizeActivity(ByteBuffer _bb)
		{
			return PrizeActivity.GetRootAsPrizeActivity(_bb, default(PrizeActivity));
		}

		// Token: 0x0600B9A4 RID: 47524 RVA: 0x002E824C File Offset: 0x002E644C
		public static PrizeActivity GetRootAsPrizeActivity(ByteBuffer _bb, PrizeActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B9A5 RID: 47525 RVA: 0x002E8269 File Offset: 0x002E6469
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B9A6 RID: 47526 RVA: 0x002E8278 File Offset: 0x002E6478
		public PrizeActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B6A RID: 11114
		// (get) Token: 0x0600B9A7 RID: 47527 RVA: 0x002E8288 File Offset: 0x002E6488
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

		// Token: 0x17002B6B RID: 11115
		// (get) Token: 0x0600B9A8 RID: 47528 RVA: 0x002E82C4 File Offset: 0x002E64C4
		public int NotSGroup
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

		// Token: 0x17002B6C RID: 11116
		// (get) Token: 0x0600B9A9 RID: 47529 RVA: 0x002E8300 File Offset: 0x002E6500
		public int MustSGroup
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

		// Token: 0x17002B6D RID: 11117
		// (get) Token: 0x0600B9AA RID: 47530 RVA: 0x002E833C File Offset: 0x002E653C
		public int CostItem1Id
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

		// Token: 0x17002B6E RID: 11118
		// (get) Token: 0x0600B9AB RID: 47531 RVA: 0x002E837C File Offset: 0x002E657C
		public int CostItem1Type
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

		// Token: 0x17002B6F RID: 11119
		// (get) Token: 0x0600B9AC RID: 47532 RVA: 0x002E83BC File Offset: 0x002E65BC
		public int CostItem2Id
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

		// Token: 0x17002B70 RID: 11120
		// (get) Token: 0x0600B9AD RID: 47533 RVA: 0x002E83FC File Offset: 0x002E65FC
		public int CostItem2Type
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

		// Token: 0x17002B71 RID: 11121
		// (get) Token: 0x0600B9AE RID: 47534 RVA: 0x002E843C File Offset: 0x002E663C
		public int CostItem2Num
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

		// Token: 0x17002B72 RID: 11122
		// (get) Token: 0x0600B9AF RID: 47535 RVA: 0x002E847C File Offset: 0x002E667C
		public int CostItem1ConfirmId
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

		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x0600B9B0 RID: 47536 RVA: 0x002E84BC File Offset: 0x002E66BC
		public int CostItem2ConfirmId
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

		// Token: 0x17002B74 RID: 11124
		// (get) Token: 0x0600B9B1 RID: 47537 RVA: 0x002E84FC File Offset: 0x002E66FC
		public int AwardsAmount
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

		// Token: 0x0400560D RID: 22029
		private Table __p;
	}
}
