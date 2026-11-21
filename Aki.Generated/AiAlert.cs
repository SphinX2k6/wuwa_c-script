using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC0 RID: 3008
	public struct AiAlert : IFlatbufferObject
	{
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06004B66 RID: 19302 RVA: 0x001F1765 File Offset: 0x001EF965
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004B67 RID: 19303 RVA: 0x001F1772 File Offset: 0x001EF972
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x001F177C File Offset: 0x001EF97C
		public static AiAlert GetRootAsAiAlert(ByteBuffer _bb)
		{
			return AiAlert.GetRootAsAiAlert(_bb, default(AiAlert));
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x001F1798 File Offset: 0x001EF998
		public static AiAlert GetRootAsAiAlert(ByteBuffer _bb, AiAlert obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x001F17B5 File Offset: 0x001EF9B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x001F17C4 File Offset: 0x001EF9C4
		public AiAlert __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06004B6C RID: 19308 RVA: 0x001F17D4 File Offset: 0x001EF9D4
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

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06004B6D RID: 19309 RVA: 0x001F1810 File Offset: 0x001EFA10
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

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06004B6E RID: 19310 RVA: 0x001F1850 File Offset: 0x001EFA50
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

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06004B6F RID: 19311 RVA: 0x001F1890 File Offset: 0x001EFA90
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

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06004B70 RID: 19312 RVA: 0x001F18D4 File Offset: 0x001EFAD4
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

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06004B71 RID: 19313 RVA: 0x001F1918 File Offset: 0x001EFB18
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

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06004B72 RID: 19314 RVA: 0x001F195C File Offset: 0x001EFB5C
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

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06004B73 RID: 19315 RVA: 0x001F19A0 File Offset: 0x001EFBA0
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

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06004B74 RID: 19316 RVA: 0x001F19E0 File Offset: 0x001EFBE0
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

		// Token: 0x040050A0 RID: 20640
		private Table __p;
	}
}
