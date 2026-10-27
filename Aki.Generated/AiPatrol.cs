using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AEE RID: 2798
	public struct AiPatrol : IFlatbufferObject
	{
		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060046BC RID: 18108 RVA: 0x001D3520 File Offset: 0x001D1720
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060046BD RID: 18109 RVA: 0x001D352D File Offset: 0x001D172D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060046BE RID: 18110 RVA: 0x001D3534 File Offset: 0x001D1734
		public static AiPatrol GetRootAsAiPatrol(ByteBuffer _bb)
		{
			return AiPatrol.GetRootAsAiPatrol(_bb, default(AiPatrol));
		}

		// Token: 0x060046BF RID: 18111 RVA: 0x001D3550 File Offset: 0x001D1750
		public static AiPatrol GetRootAsAiPatrol(ByteBuffer _bb, AiPatrol obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060046C0 RID: 18112 RVA: 0x001D356D File Offset: 0x001D176D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060046C1 RID: 18113 RVA: 0x001D357C File Offset: 0x001D177C
		public AiPatrol __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060046C2 RID: 18114 RVA: 0x001D358C File Offset: 0x001D178C
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

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060046C3 RID: 18115 RVA: 0x001D35C8 File Offset: 0x001D17C8
		public bool CirclePatrol
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060046C4 RID: 18116 RVA: 0x001D3608 File Offset: 0x001D1808
		public string PathSpline
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x001D363F File Offset: 0x001D183F
		public Span<byte> GetPathSplineBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x001D364E File Offset: 0x001D184E
		public byte[] GetPathSplineArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060046C7 RID: 18119 RVA: 0x001D3668 File Offset: 0x001D1868
		public bool IsNavigation
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060046C8 RID: 18120 RVA: 0x001D36A8 File Offset: 0x001D18A8
		public int StartIndex
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

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060046C9 RID: 18121 RVA: 0x001D36E8 File Offset: 0x001D18E8
		public float LimitNpcDistance
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060046CA RID: 18122 RVA: 0x001D372C File Offset: 0x001D192C
		public float TurnSpeed
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 180f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060046CB RID: 18123 RVA: 0x001D3770 File Offset: 0x001D1970
		public bool Loop
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060046CC RID: 18124 RVA: 0x001D37B0 File Offset: 0x001D19B0
		public float EndDistance
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 50f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060046CD RID: 18125 RVA: 0x001D37F4 File Offset: 0x001D19F4
		public float Sampling
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060046CE RID: 18126 RVA: 0x001D3838 File Offset: 0x001D1A38
		public bool ContainZ
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004ACF RID: 19151
		private Table __p;
	}
}
