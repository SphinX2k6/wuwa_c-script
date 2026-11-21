using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD0 RID: 3280
	public struct Dice : IFlatbufferObject
	{
		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060067B7 RID: 26551 RVA: 0x00232128 File Offset: 0x00230328
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060067B8 RID: 26552 RVA: 0x00232135 File Offset: 0x00230335
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060067B9 RID: 26553 RVA: 0x0023213C File Offset: 0x0023033C
		public static Dice GetRootAsDice(ByteBuffer _bb)
		{
			return Dice.GetRootAsDice(_bb, default(Dice));
		}

		// Token: 0x060067BA RID: 26554 RVA: 0x00232158 File Offset: 0x00230358
		public static Dice GetRootAsDice(ByteBuffer _bb, Dice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060067BB RID: 26555 RVA: 0x00232175 File Offset: 0x00230375
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060067BC RID: 26556 RVA: 0x00232184 File Offset: 0x00230384
		public Dice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x060067BD RID: 26557 RVA: 0x00232194 File Offset: 0x00230394
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

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060067BE RID: 26558 RVA: 0x002321D0 File Offset: 0x002303D0
		public string Icon
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

		// Token: 0x060067BF RID: 26559 RVA: 0x00232207 File Offset: 0x00230407
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060067C0 RID: 26560 RVA: 0x00232216 File Offset: 0x00230416
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060067C1 RID: 26561 RVA: 0x00232230 File Offset: 0x00230430
		public int Num
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

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060067C2 RID: 26562 RVA: 0x0023226C File Offset: 0x0023046C
		public string DicePointOneIcon
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060067C3 RID: 26563 RVA: 0x002322A4 File Offset: 0x002304A4
		public Span<byte> GetDicePointOneIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060067C4 RID: 26564 RVA: 0x002322B4 File Offset: 0x002304B4
		public byte[] GetDicePointOneIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060067C5 RID: 26565 RVA: 0x002322CC File Offset: 0x002304CC
		public string DicePointTwoIcon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060067C6 RID: 26566 RVA: 0x00232304 File Offset: 0x00230504
		public Span<byte> GetDicePointTwoIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060067C7 RID: 26567 RVA: 0x00232314 File Offset: 0x00230514
		public byte[] GetDicePointTwoIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060067C8 RID: 26568 RVA: 0x0023232C File Offset: 0x0023052C
		public string DicePointThreeIcon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060067C9 RID: 26569 RVA: 0x00232364 File Offset: 0x00230564
		public Span<byte> GetDicePointThreeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060067CA RID: 26570 RVA: 0x00232374 File Offset: 0x00230574
		public byte[] GetDicePointThreeIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060067CB RID: 26571 RVA: 0x0023238C File Offset: 0x0023058C
		public string DicePointFourIcon
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060067CC RID: 26572 RVA: 0x002323C4 File Offset: 0x002305C4
		public Span<byte> GetDicePointFourIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060067CD RID: 26573 RVA: 0x002323D4 File Offset: 0x002305D4
		public byte[] GetDicePointFourIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060067CE RID: 26574 RVA: 0x002323EC File Offset: 0x002305EC
		public string DicePointFiveIcon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x00232424 File Offset: 0x00230624
		public Span<byte> GetDicePointFiveIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060067D0 RID: 26576 RVA: 0x00232434 File Offset: 0x00230634
		public byte[] GetDicePointFiveIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060067D1 RID: 26577 RVA: 0x0023244C File Offset: 0x0023064C
		public string DicePointSixIcon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060067D2 RID: 26578 RVA: 0x00232484 File Offset: 0x00230684
		public Span<byte> GetDicePointSixIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060067D3 RID: 26579 RVA: 0x00232494 File Offset: 0x00230694
		public byte[] GetDicePointSixIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x060067D4 RID: 26580 RVA: 0x002324AC File Offset: 0x002306AC
		public string DiceBackgroundIcon
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060067D5 RID: 26581 RVA: 0x002324E4 File Offset: 0x002306E4
		public Span<byte> GetDiceBackgroundIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060067D6 RID: 26582 RVA: 0x002324F4 File Offset: 0x002306F4
		public byte[] GetDiceBackgroundIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060067D7 RID: 26583 RVA: 0x0023250C File Offset: 0x0023070C
		public string RollDiceBackgroundIcon
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x00232544 File Offset: 0x00230744
		public Span<byte> GetRollDiceBackgroundIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060067D9 RID: 26585 RVA: 0x00232554 File Offset: 0x00230754
		public byte[] GetRollDiceBackgroundIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x060067DA RID: 26586 RVA: 0x0023256C File Offset: 0x0023076C
		public string DiceColor
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060067DB RID: 26587 RVA: 0x002325A4 File Offset: 0x002307A4
		public Span<byte> GetDiceColorBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060067DC RID: 26588 RVA: 0x002325B4 File Offset: 0x002307B4
		public byte[] GetDiceColorArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060067DD RID: 26589 RVA: 0x002325CC File Offset: 0x002307CC
		public string DiceNumColor
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060067DE RID: 26590 RVA: 0x00232604 File Offset: 0x00230804
		public Span<byte> GetDiceNumColorBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060067DF RID: 26591 RVA: 0x00232614 File Offset: 0x00230814
		public byte[] GetDiceNumColorArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x060067E0 RID: 26592 RVA: 0x0023262C File Offset: 0x0023082C
		public string DiceHighLightColor
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

		// Token: 0x060067E1 RID: 26593 RVA: 0x00232664 File Offset: 0x00230864
		public Span<byte> GetDiceHighLightColorBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060067E2 RID: 26594 RVA: 0x00232674 File Offset: 0x00230874
		public byte[] GetDiceHighLightColorArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x060067E3 RID: 26595 RVA: 0x0023268C File Offset: 0x0023088C
		public int FacesNum
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040051FD RID: 20989
		private Table __p;
	}
}
