using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F29 RID: 3881
	public struct PinballDamage : IFlatbufferObject
	{
		// Token: 0x1700292C RID: 10540
		// (get) Token: 0x0600AEA4 RID: 44708 RVA: 0x002C1058 File Offset: 0x002BF258
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AEA5 RID: 44709 RVA: 0x002C1065 File Offset: 0x002BF265
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AEA6 RID: 44710 RVA: 0x002C106C File Offset: 0x002BF26C
		public static PinballDamage GetRootAsPinballDamage(ByteBuffer _bb)
		{
			return PinballDamage.GetRootAsPinballDamage(_bb, default(PinballDamage));
		}

		// Token: 0x0600AEA7 RID: 44711 RVA: 0x002C1088 File Offset: 0x002BF288
		public static PinballDamage GetRootAsPinballDamage(ByteBuffer _bb, PinballDamage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AEA8 RID: 44712 RVA: 0x002C10A5 File Offset: 0x002BF2A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AEA9 RID: 44713 RVA: 0x002C10B4 File Offset: 0x002BF2B4
		public PinballDamage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700292D RID: 10541
		// (get) Token: 0x0600AEAA RID: 44714 RVA: 0x002C10C4 File Offset: 0x002BF2C4
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x1700292E RID: 10542
		// (get) Token: 0x0600AEAB RID: 44715 RVA: 0x002C110C File Offset: 0x002BF30C
		public int CalculateType
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

		// Token: 0x1700292F RID: 10543
		// (get) Token: 0x0600AEAC RID: 44716 RVA: 0x002C1148 File Offset: 0x002BF348
		public int Element
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

		// Token: 0x17002930 RID: 10544
		// (get) Token: 0x0600AEAD RID: 44717 RVA: 0x002C1184 File Offset: 0x002BF384
		public int RelatedProperty
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 7;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002931 RID: 10545
		// (get) Token: 0x0600AEAE RID: 44718 RVA: 0x002C11C4 File Offset: 0x002BF3C4
		public int Amplify
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

		// Token: 0x17002932 RID: 10546
		// (get) Token: 0x0600AEAF RID: 44719 RVA: 0x002C1204 File Offset: 0x002BF404
		public int BaseValue
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

		// Token: 0x17002933 RID: 10547
		// (get) Token: 0x0600AEB0 RID: 44720 RVA: 0x002C1244 File Offset: 0x002BF444
		public int IsRecordedCombo
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

		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x0600AEB1 RID: 44721 RVA: 0x002C1284 File Offset: 0x002BF484
		public int RecoverSkillEnergy
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

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x0600AEB2 RID: 44722 RVA: 0x002C12C4 File Offset: 0x002BF4C4
		public int IsRecoverTeamSkillEnergy
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

		// Token: 0x17002936 RID: 10550
		// (get) Token: 0x0600AEB3 RID: 44723 RVA: 0x002C1304 File Offset: 0x002BF504
		public int RecoverSprintEnergy
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

		// Token: 0x17002937 RID: 10551
		// (get) Token: 0x0600AEB4 RID: 44724 RVA: 0x002C1344 File Offset: 0x002BF544
		public int RecoverFeverEnergy
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

		// Token: 0x04004FF2 RID: 20466
		private Table __p;
	}
}
