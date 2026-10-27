using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AED RID: 2797
	public struct AiHate : IFlatbufferObject
	{
		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060046A3 RID: 18083 RVA: 0x001D3001 File Offset: 0x001D1201
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x001D300E File Offset: 0x001D120E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x001D3018 File Offset: 0x001D1218
		public static AiHate GetRootAsAiHate(ByteBuffer _bb)
		{
			return AiHate.GetRootAsAiHate(_bb, default(AiHate));
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x001D3034 File Offset: 0x001D1234
		public static AiHate GetRootAsAiHate(ByteBuffer _bb, AiHate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060046A7 RID: 18087 RVA: 0x001D3051 File Offset: 0x001D1251
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060046A8 RID: 18088 RVA: 0x001D3060 File Offset: 0x001D1260
		public AiHate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060046A9 RID: 18089 RVA: 0x001D3070 File Offset: 0x001D1270
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

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060046AA RID: 18090 RVA: 0x001D30AC File Offset: 0x001D12AC
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

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060046AB RID: 18091 RVA: 0x001D30EC File Offset: 0x001D12EC
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

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060046AC RID: 18092 RVA: 0x001D312C File Offset: 0x001D132C
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

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060046AD RID: 18093 RVA: 0x001D3170 File Offset: 0x001D1370
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

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060046AE RID: 18094 RVA: 0x001D31B4 File Offset: 0x001D13B4
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

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060046AF RID: 18095 RVA: 0x001D31F8 File Offset: 0x001D13F8
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

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060046B0 RID: 18096 RVA: 0x001D323C File Offset: 0x001D143C
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

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060046B1 RID: 18097 RVA: 0x001D329C File Offset: 0x001D149C
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

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060046B2 RID: 18098 RVA: 0x001D32FC File Offset: 0x001D14FC
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

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060046B3 RID: 18099 RVA: 0x001D335C File Offset: 0x001D155C
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

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x001D33BC File Offset: 0x001D15BC
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

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060046B5 RID: 18101 RVA: 0x001D341C File Offset: 0x001D161C
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

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060046B6 RID: 18102 RVA: 0x001D3460 File Offset: 0x001D1660
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

		// Token: 0x060046B7 RID: 18103 RVA: 0x001D3498 File Offset: 0x001D1698
		public Span<byte> GetExcludeTagBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060046B8 RID: 18104 RVA: 0x001D34A8 File Offset: 0x001D16A8
		public byte[] GetExcludeTagArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060046B9 RID: 18105 RVA: 0x001D34C0 File Offset: 0x001D16C0
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

		// Token: 0x060046BA RID: 18106 RVA: 0x001D34F8 File Offset: 0x001D16F8
		public Span<byte> GetSwornHatredTagBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x001D3508 File Offset: 0x001D1708
		public byte[] GetSwornHatredTagArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x04004ACE RID: 19150
		private Table __p;
	}
}
