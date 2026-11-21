using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC7 RID: 3015
	public struct AiHate : IFlatbufferObject
	{
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06004BEA RID: 19434 RVA: 0x001F29E1 File Offset: 0x001F0BE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x001F29EE File Offset: 0x001F0BEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x001F29F8 File Offset: 0x001F0BF8
		public static AiHate GetRootAsAiHate(ByteBuffer _bb)
		{
			return AiHate.GetRootAsAiHate(_bb, default(AiHate));
		}

		// Token: 0x06004BED RID: 19437 RVA: 0x001F2A14 File Offset: 0x001F0C14
		public static AiHate GetRootAsAiHate(ByteBuffer _bb, AiHate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004BEE RID: 19438 RVA: 0x001F2A31 File Offset: 0x001F0C31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004BEF RID: 19439 RVA: 0x001F2A40 File Offset: 0x001F0C40
		public AiHate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06004BF0 RID: 19440 RVA: 0x001F2A50 File Offset: 0x001F0C50
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

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06004BF1 RID: 19441 RVA: 0x001F2A8C File Offset: 0x001F0C8C
		public float BaseHatred
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06004BF2 RID: 19442 RVA: 0x001F2ACC File Offset: 0x001F0CCC
		public float DecreaseRate
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0.8f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06004BF3 RID: 19443 RVA: 0x001F2B0C File Offset: 0x001F0D0C
		public float DecreaseTimeLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 5000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06004BF4 RID: 19444 RVA: 0x001F2B50 File Offset: 0x001F0D50
		public float DecreaseTimeCd
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 10000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06004BF5 RID: 19445 RVA: 0x001F2B94 File Offset: 0x001F0D94
		public float IncreaseRateWhenDecreasing
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06004BF6 RID: 19446 RVA: 0x001F2BD8 File Offset: 0x001F0DD8
		public float MinClearTime
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06004BF7 RID: 19447 RVA: 0x001F2C1C File Offset: 0x001F0E1C
		public FloatRange? DisengageDistanceRange
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06004BF8 RID: 19448 RVA: 0x001F2C7C File Offset: 0x001F0E7C
		public FloatRange? DisengageTimeRange
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06004BF9 RID: 19449 RVA: 0x001F2CDC File Offset: 0x001F0EDC
		public FloatRange? DisengageHeightRange
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06004BFA RID: 19450 RVA: 0x001F2D3C File Offset: 0x001F0F3C
		public FloatRange? DisengageHeightRangeMax
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06004BFB RID: 19451 RVA: 0x001F2D9C File Offset: 0x001F0F9C
		public FloatRange? DisengageBornDistance
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06004BFC RID: 19452 RVA: 0x001F2DFC File Offset: 0x001F0FFC
		public float MaxMoveFromBorn
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return -1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06004BFD RID: 19453 RVA: 0x001F2E40 File Offset: 0x001F1040
		public string ExcludeTag
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x001F2E78 File Offset: 0x001F1078
		public Span<byte> GetExcludeTagBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x001F2E88 File Offset: 0x001F1088
		public byte[] GetExcludeTagArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06004C00 RID: 19456 RVA: 0x001F2EA0 File Offset: 0x001F10A0
		public string SwornHatredTag
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x001F2ED8 File Offset: 0x001F10D8
		public Span<byte> GetSwornHatredTagBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x001F2EE8 File Offset: 0x001F10E8
		public byte[] GetSwornHatredTagArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x040050A8 RID: 20648
		private Table __p;
	}
}
