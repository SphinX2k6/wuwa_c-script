using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F2E RID: 3886
	public struct MotorFightMonsterDrop : IFlatbufferObject
	{
		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x06009F07 RID: 40711 RVA: 0x002ADC1E File Offset: 0x002ABE1E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009F08 RID: 40712 RVA: 0x002ADC2B File Offset: 0x002ABE2B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009F09 RID: 40713 RVA: 0x002ADC34 File Offset: 0x002ABE34
		public static MotorFightMonsterDrop GetRootAsMotorFightMonsterDrop(ByteBuffer _bb)
		{
			return MotorFightMonsterDrop.GetRootAsMotorFightMonsterDrop(_bb, default(MotorFightMonsterDrop));
		}

		// Token: 0x06009F0A RID: 40714 RVA: 0x002ADC50 File Offset: 0x002ABE50
		public static MotorFightMonsterDrop GetRootAsMotorFightMonsterDrop(ByteBuffer _bb, MotorFightMonsterDrop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009F0B RID: 40715 RVA: 0x002ADC6D File Offset: 0x002ABE6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009F0C RID: 40716 RVA: 0x002ADC7C File Offset: 0x002ABE7C
		public MotorFightMonsterDrop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x06009F0D RID: 40717 RVA: 0x002ADC8C File Offset: 0x002ABE8C
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

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x06009F0E RID: 40718 RVA: 0x002ADCC8 File Offset: 0x002ABEC8
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

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x06009F0F RID: 40719 RVA: 0x002ADD04 File Offset: 0x002ABF04
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

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x06009F10 RID: 40720 RVA: 0x002ADD40 File Offset: 0x002ABF40
		public int BuffGateId
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

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x06009F11 RID: 40721 RVA: 0x002ADD80 File Offset: 0x002ABF80
		public int BuffId
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

		// Token: 0x040054D6 RID: 21718
		private Table __p;
	}
}
