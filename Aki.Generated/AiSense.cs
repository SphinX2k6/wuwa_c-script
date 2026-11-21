using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC9 RID: 3017
	public struct AiSense : IFlatbufferObject
	{
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06004C16 RID: 19478 RVA: 0x001F3258 File Offset: 0x001F1458
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x001F3265 File Offset: 0x001F1465
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x001F326C File Offset: 0x001F146C
		public static AiSense GetRootAsAiSense(ByteBuffer _bb)
		{
			return AiSense.GetRootAsAiSense(_bb, default(AiSense));
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x001F3288 File Offset: 0x001F1488
		public static AiSense GetRootAsAiSense(ByteBuffer _bb, AiSense obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x001F32A5 File Offset: 0x001F14A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x001F32B4 File Offset: 0x001F14B4
		public AiSense __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06004C1C RID: 19484 RVA: 0x001F32C4 File Offset: 0x001F14C4
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

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06004C1D RID: 19485 RVA: 0x001F3300 File Offset: 0x001F1500
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

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06004C1E RID: 19486 RVA: 0x001F333C File Offset: 0x001F153C
		public bool DefaultEnabled
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06004C1F RID: 19487 RVA: 0x001F337C File Offset: 0x001F157C
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

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06004C20 RID: 19488 RVA: 0x001F33DC File Offset: 0x001F15DC
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

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06004C21 RID: 19489 RVA: 0x001F343C File Offset: 0x001F163C
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

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06004C22 RID: 19490 RVA: 0x001F349C File Offset: 0x001F169C
		public bool CantBeBlock
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06004C23 RID: 19491 RVA: 0x001F34DC File Offset: 0x001F16DC
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

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06004C24 RID: 19492 RVA: 0x001F351C File Offset: 0x001F171C
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

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06004C25 RID: 19493 RVA: 0x001F3560 File Offset: 0x001F1760
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

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06004C26 RID: 19494 RVA: 0x001F35A4 File Offset: 0x001F17A4
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

		// Token: 0x040050AA RID: 20650
		private Table __p;
	}
}
