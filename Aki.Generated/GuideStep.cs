using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D1B RID: 3355
	public struct GuideStep : IFlatbufferObject
	{
		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06007D22 RID: 32034 RVA: 0x0025112D File Offset: 0x0024F32D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007D23 RID: 32035 RVA: 0x0025113A File Offset: 0x0024F33A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007D24 RID: 32036 RVA: 0x00251144 File Offset: 0x0024F344
		public static GuideStep GetRootAsGuideStep(ByteBuffer _bb)
		{
			return GuideStep.GetRootAsGuideStep(_bb, default(GuideStep));
		}

		// Token: 0x06007D25 RID: 32037 RVA: 0x00251160 File Offset: 0x0024F360
		public static GuideStep GetRootAsGuideStep(ByteBuffer _bb, GuideStep obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007D26 RID: 32038 RVA: 0x0025117D File Offset: 0x0024F37D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007D27 RID: 32039 RVA: 0x0025118C File Offset: 0x0024F38C
		public GuideStep __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06007D28 RID: 32040 RVA: 0x0025119C File Offset: 0x0024F39C
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

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06007D29 RID: 32041 RVA: 0x002511D8 File Offset: 0x0024F3D8
		public string Controller
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007D2A RID: 32042 RVA: 0x0025120F File Offset: 0x0024F40F
		public Span<byte> GetControllerBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007D2B RID: 32043 RVA: 0x0025121E File Offset: 0x0024F41E
		public byte[] GetControllerArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06007D2C RID: 32044 RVA: 0x00251238 File Offset: 0x0024F438
		public int SuccessCondition
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

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x06007D2D RID: 32045 RVA: 0x00251274 File Offset: 0x0024F474
		public int FailureCondition
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

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x06007D2E RID: 32046 RVA: 0x002512B4 File Offset: 0x0024F4B4
		public int TickCondition
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

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06007D2F RID: 32047 RVA: 0x002512F4 File Offset: 0x0024F4F4
		public int SkipCondition
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

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x06007D30 RID: 32048 RVA: 0x00251334 File Offset: 0x0024F534
		public int BreakCondition
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

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x06007D31 RID: 32049 RVA: 0x00251374 File Offset: 0x0024F574
		public float TimeScale
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06007D32 RID: 32050 RVA: 0x002513B8 File Offset: 0x0024F5B8
		public int ContentType
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

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06007D33 RID: 32051 RVA: 0x002513F8 File Offset: 0x0024F5F8
		public int ReportId
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

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06007D34 RID: 32052 RVA: 0x00251438 File Offset: 0x0024F638
		public int Duration
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 5000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06007D35 RID: 32053 RVA: 0x0025147C File Offset: 0x0024F67C
		public int MinDuration
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06007D36 RID: 32054 RVA: 0x002514BC File Offset: 0x0024F6BC
		public int ShowDelay
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x06007D37 RID: 32055 RVA: 0x002514FC File Offset: 0x0024F6FC
		public bool IsDangerous
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06007D38 RID: 32056 RVA: 0x0025153C File Offset: 0x0024F73C
		public bool IsTimeUpAsFinish
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004D93 RID: 19859
		private Table __p;
	}
}
