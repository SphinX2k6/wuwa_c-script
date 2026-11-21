using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E00 RID: 3584
	public struct GuideStep : IFlatbufferObject
	{
		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x0600833C RID: 33596 RVA: 0x0026FA99 File Offset: 0x0026DC99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600833D RID: 33597 RVA: 0x0026FAA6 File Offset: 0x0026DCA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600833E RID: 33598 RVA: 0x0026FAB0 File Offset: 0x0026DCB0
		public static GuideStep GetRootAsGuideStep(ByteBuffer _bb)
		{
			return GuideStep.GetRootAsGuideStep(_bb, default(GuideStep));
		}

		// Token: 0x0600833F RID: 33599 RVA: 0x0026FACC File Offset: 0x0026DCCC
		public static GuideStep GetRootAsGuideStep(ByteBuffer _bb, GuideStep obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008340 RID: 33600 RVA: 0x0026FAE9 File Offset: 0x0026DCE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008341 RID: 33601 RVA: 0x0026FAF8 File Offset: 0x0026DCF8
		public GuideStep __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x06008342 RID: 33602 RVA: 0x0026FB08 File Offset: 0x0026DD08
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

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x06008343 RID: 33603 RVA: 0x0026FB44 File Offset: 0x0026DD44
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

		// Token: 0x06008344 RID: 33604 RVA: 0x0026FB7B File Offset: 0x0026DD7B
		public Span<byte> GetControllerBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008345 RID: 33605 RVA: 0x0026FB8A File Offset: 0x0026DD8A
		public byte[] GetControllerArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x06008346 RID: 33606 RVA: 0x0026FBA4 File Offset: 0x0026DDA4
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

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06008347 RID: 33607 RVA: 0x0026FBE0 File Offset: 0x0026DDE0
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

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06008348 RID: 33608 RVA: 0x0026FC20 File Offset: 0x0026DE20
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

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06008349 RID: 33609 RVA: 0x0026FC60 File Offset: 0x0026DE60
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

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x0600834A RID: 33610 RVA: 0x0026FCA0 File Offset: 0x0026DEA0
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

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x0600834B RID: 33611 RVA: 0x0026FCE0 File Offset: 0x0026DEE0
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

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x0600834C RID: 33612 RVA: 0x0026FD24 File Offset: 0x0026DF24
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

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x0600834D RID: 33613 RVA: 0x0026FD64 File Offset: 0x0026DF64
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

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x0600834E RID: 33614 RVA: 0x0026FDA4 File Offset: 0x0026DFA4
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

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x0600834F RID: 33615 RVA: 0x0026FDE8 File Offset: 0x0026DFE8
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

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06008350 RID: 33616 RVA: 0x0026FE28 File Offset: 0x0026E028
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

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06008351 RID: 33617 RVA: 0x0026FE68 File Offset: 0x0026E068
		public bool IsDangerous
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06008352 RID: 33618 RVA: 0x0026FEA8 File Offset: 0x0026E0A8
		public bool IsTimeUpAsFinish
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005378 RID: 21368
		private Table __p;
	}
}
