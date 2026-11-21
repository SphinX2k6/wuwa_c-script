using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC8 RID: 3016
	public struct AiPatrol : IFlatbufferObject
	{
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06004C03 RID: 19459 RVA: 0x001F2F00 File Offset: 0x001F1100
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x001F2F0D File Offset: 0x001F110D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x001F2F14 File Offset: 0x001F1114
		public static AiPatrol GetRootAsAiPatrol(ByteBuffer _bb)
		{
			return AiPatrol.GetRootAsAiPatrol(_bb, default(AiPatrol));
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x001F2F30 File Offset: 0x001F1130
		public static AiPatrol GetRootAsAiPatrol(ByteBuffer _bb, AiPatrol obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x001F2F4D File Offset: 0x001F114D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x001F2F5C File Offset: 0x001F115C
		public AiPatrol __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06004C09 RID: 19465 RVA: 0x001F2F6C File Offset: 0x001F116C
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

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06004C0A RID: 19466 RVA: 0x001F2FA8 File Offset: 0x001F11A8
		public bool CirclePatrol
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06004C0B RID: 19467 RVA: 0x001F2FE8 File Offset: 0x001F11E8
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

		// Token: 0x06004C0C RID: 19468 RVA: 0x001F301F File Offset: 0x001F121F
		public Span<byte> GetPathSplineBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x001F302E File Offset: 0x001F122E
		public byte[] GetPathSplineArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06004C0E RID: 19470 RVA: 0x001F3048 File Offset: 0x001F1248
		public bool IsNavigation
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06004C0F RID: 19471 RVA: 0x001F3088 File Offset: 0x001F1288
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

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06004C10 RID: 19472 RVA: 0x001F30C8 File Offset: 0x001F12C8
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

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06004C11 RID: 19473 RVA: 0x001F310C File Offset: 0x001F130C
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

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06004C12 RID: 19474 RVA: 0x001F3150 File Offset: 0x001F1350
		public bool Loop
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06004C13 RID: 19475 RVA: 0x001F3190 File Offset: 0x001F1390
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

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06004C14 RID: 19476 RVA: 0x001F31D4 File Offset: 0x001F13D4
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

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06004C15 RID: 19477 RVA: 0x001F3218 File Offset: 0x001F1418
		public bool ContainZ
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040050A9 RID: 20649
		private Table __p;
	}
}
