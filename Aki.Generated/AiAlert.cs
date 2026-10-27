using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE6 RID: 2790
	public struct AiAlert : IFlatbufferObject
	{
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600461F RID: 17951 RVA: 0x001D1CCD File Offset: 0x001CFECD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x001D1CDA File Offset: 0x001CFEDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x001D1CE4 File Offset: 0x001CFEE4
		public static AiAlert GetRootAsAiAlert(ByteBuffer _bb)
		{
			return AiAlert.GetRootAsAiAlert(_bb, default(AiAlert));
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x001D1D00 File Offset: 0x001CFF00
		public static AiAlert GetRootAsAiAlert(ByteBuffer _bb, AiAlert obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x001D1D1D File Offset: 0x001CFF1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x001D1D2C File Offset: 0x001CFF2C
		public AiAlert __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06004625 RID: 17957 RVA: 0x001D1D3C File Offset: 0x001CFF3C
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

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06004626 RID: 17958 RVA: 0x001D1D78 File Offset: 0x001CFF78
		public float BaseIncrease
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 500f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06004627 RID: 17959 RVA: 0x001D1DB8 File Offset: 0x001CFFB8
		public float DecreaseByDist
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0.25f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06004628 RID: 17960 RVA: 0x001D1DF8 File Offset: 0x001CFFF8
		public float MaxDist
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return -1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06004629 RID: 17961 RVA: 0x001D1E3C File Offset: 0x001D003C
		public float ForwardAngle
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 45f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600462A RID: 17962 RVA: 0x001D1E80 File Offset: 0x001D0080
		public float BackwardRate
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0.25f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600462B RID: 17963 RVA: 0x001D1EC4 File Offset: 0x001D00C4
		public float BaseDecrease
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 25f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600462C RID: 17964 RVA: 0x001D1F08 File Offset: 0x001D0108
		public int AlertnessType
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

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600462D RID: 17965 RVA: 0x001D1F48 File Offset: 0x001D0148
		public int ShowDist
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 3000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004AC6 RID: 19142
		private Table __p;
	}
}
