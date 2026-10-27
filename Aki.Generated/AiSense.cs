using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AEF RID: 2799
	public struct AiSense : IFlatbufferObject
	{
		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060046CF RID: 18127 RVA: 0x001D3878 File Offset: 0x001D1A78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x001D3885 File Offset: 0x001D1A85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060046D1 RID: 18129 RVA: 0x001D388C File Offset: 0x001D1A8C
		public static AiSense GetRootAsAiSense(ByteBuffer _bb)
		{
			return AiSense.GetRootAsAiSense(_bb, default(AiSense));
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x001D38A8 File Offset: 0x001D1AA8
		public static AiSense GetRootAsAiSense(ByteBuffer _bb, AiSense obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060046D3 RID: 18131 RVA: 0x001D38C5 File Offset: 0x001D1AC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x001D38D4 File Offset: 0x001D1AD4
		public AiSense __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060046D5 RID: 18133 RVA: 0x001D38E4 File Offset: 0x001D1AE4
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

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060046D6 RID: 18134 RVA: 0x001D3920 File Offset: 0x001D1B20
		public int SenseType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060046D7 RID: 18135 RVA: 0x001D395C File Offset: 0x001D1B5C
		public bool DefaultEnabled
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060046D8 RID: 18136 RVA: 0x001D399C File Offset: 0x001D1B9C
		public FloatRange? SenseDistanceRange
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060046D9 RID: 18137 RVA: 0x001D39FC File Offset: 0x001D1BFC
		public FloatRange? HorizontalAngle
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060046DA RID: 18138 RVA: 0x001D3A5C File Offset: 0x001D1C5C
		public FloatRange? VerticalAngle
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060046DB RID: 18139 RVA: 0x001D3ABC File Offset: 0x001D1CBC
		public bool CantBeBlock
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060046DC RID: 18140 RVA: 0x001D3AFC File Offset: 0x001D1CFC
		public int BlockType
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

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060046DD RID: 18141 RVA: 0x001D3B3C File Offset: 0x001D1D3C
		public float WalkSenseRate
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060046DE RID: 18142 RVA: 0x001D3B80 File Offset: 0x001D1D80
		public float AirSenseRate
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060046DF RID: 18143 RVA: 0x001D3BC4 File Offset: 0x001D1DC4
		public int SenseTarget
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

		// Token: 0x04004AD0 RID: 19152
		private Table __p;
	}
}
