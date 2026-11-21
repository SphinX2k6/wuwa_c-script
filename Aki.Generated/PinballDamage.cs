using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200100E RID: 4110
	public struct PinballDamage : IFlatbufferObject
	{
		// Token: 0x17002992 RID: 10642
		// (get) Token: 0x0600B4C5 RID: 46277 RVA: 0x002DDB78 File Offset: 0x002DBD78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B4C6 RID: 46278 RVA: 0x002DDB85 File Offset: 0x002DBD85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B4C7 RID: 46279 RVA: 0x002DDB8C File Offset: 0x002DBD8C
		public static PinballDamage GetRootAsPinballDamage(ByteBuffer _bb)
		{
			return PinballDamage.GetRootAsPinballDamage(_bb, default(PinballDamage));
		}

		// Token: 0x0600B4C8 RID: 46280 RVA: 0x002DDBA8 File Offset: 0x002DBDA8
		public static PinballDamage GetRootAsPinballDamage(ByteBuffer _bb, PinballDamage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B4C9 RID: 46281 RVA: 0x002DDBC5 File Offset: 0x002DBDC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B4CA RID: 46282 RVA: 0x002DDBD4 File Offset: 0x002DBDD4
		public PinballDamage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002993 RID: 10643
		// (get) Token: 0x0600B4CB RID: 46283 RVA: 0x002DDBE4 File Offset: 0x002DBDE4
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x0600B4CC RID: 46284 RVA: 0x002DDC2C File Offset: 0x002DBE2C
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

		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x0600B4CD RID: 46285 RVA: 0x002DDC68 File Offset: 0x002DBE68
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

		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x0600B4CE RID: 46286 RVA: 0x002DDCA4 File Offset: 0x002DBEA4
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

		// Token: 0x17002997 RID: 10647
		// (get) Token: 0x0600B4CF RID: 46287 RVA: 0x002DDCE4 File Offset: 0x002DBEE4
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

		// Token: 0x17002998 RID: 10648
		// (get) Token: 0x0600B4D0 RID: 46288 RVA: 0x002DDD24 File Offset: 0x002DBF24
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

		// Token: 0x17002999 RID: 10649
		// (get) Token: 0x0600B4D1 RID: 46289 RVA: 0x002DDD64 File Offset: 0x002DBF64
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

		// Token: 0x1700299A RID: 10650
		// (get) Token: 0x0600B4D2 RID: 46290 RVA: 0x002DDDA4 File Offset: 0x002DBFA4
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

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x0600B4D3 RID: 46291 RVA: 0x002DDDE4 File Offset: 0x002DBFE4
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

		// Token: 0x1700299C RID: 10652
		// (get) Token: 0x0600B4D4 RID: 46292 RVA: 0x002DDE24 File Offset: 0x002DC024
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

		// Token: 0x1700299D RID: 10653
		// (get) Token: 0x0600B4D5 RID: 46293 RVA: 0x002DDE64 File Offset: 0x002DC064
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

		// Token: 0x040055D7 RID: 21975
		private Table __p;
	}
}
