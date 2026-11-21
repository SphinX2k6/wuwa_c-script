using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F75 RID: 3957
	public struct NewTowerScoreLevel : IFlatbufferObject
	{
		// Token: 0x170023D2 RID: 9170
		// (get) Token: 0x0600A5C4 RID: 42436 RVA: 0x002BC5D2 File Offset: 0x002BA7D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A5C5 RID: 42437 RVA: 0x002BC5DF File Offset: 0x002BA7DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A5C6 RID: 42438 RVA: 0x002BC5E8 File Offset: 0x002BA7E8
		public static NewTowerScoreLevel GetRootAsNewTowerScoreLevel(ByteBuffer _bb)
		{
			return NewTowerScoreLevel.GetRootAsNewTowerScoreLevel(_bb, default(NewTowerScoreLevel));
		}

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x002BC604 File Offset: 0x002BA804
		public static NewTowerScoreLevel GetRootAsNewTowerScoreLevel(ByteBuffer _bb, NewTowerScoreLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A5C8 RID: 42440 RVA: 0x002BC621 File Offset: 0x002BA821
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A5C9 RID: 42441 RVA: 0x002BC630 File Offset: 0x002BA830
		public NewTowerScoreLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023D3 RID: 9171
		// (get) Token: 0x0600A5CA RID: 42442 RVA: 0x002BC640 File Offset: 0x002BA840
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

		// Token: 0x170023D4 RID: 9172
		// (get) Token: 0x0600A5CB RID: 42443 RVA: 0x002BC67C File Offset: 0x002BA87C
		public string Level
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

		// Token: 0x0600A5CC RID: 42444 RVA: 0x002BC6B3 File Offset: 0x002BA8B3
		public Span<byte> GetLevelBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A5CD RID: 42445 RVA: 0x002BC6C2 File Offset: 0x002BA8C2
		public byte[] GetLevelArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170023D5 RID: 9173
		// (get) Token: 0x0600A5CE RID: 42446 RVA: 0x002BC6DC File Offset: 0x002BA8DC
		public string Icon
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

		// Token: 0x0600A5CF RID: 42447 RVA: 0x002BC713 File Offset: 0x002BA913
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A5D0 RID: 42448 RVA: 0x002BC722 File Offset: 0x002BA922
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170023D6 RID: 9174
		// (get) Token: 0x0600A5D1 RID: 42449 RVA: 0x002BC73C File Offset: 0x002BA93C
		public string IconSettlement
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

		// Token: 0x0600A5D2 RID: 42450 RVA: 0x002BC774 File Offset: 0x002BA974
		public Span<byte> GetIconSettlementBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A5D3 RID: 42451 RVA: 0x002BC784 File Offset: 0x002BA984
		public byte[] GetIconSettlementArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170023D7 RID: 9175
		// (get) Token: 0x0600A5D4 RID: 42452 RVA: 0x002BC79C File Offset: 0x002BA99C
		public string BgColor
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

		// Token: 0x0600A5D5 RID: 42453 RVA: 0x002BC7D4 File Offset: 0x002BA9D4
		public Span<byte> GetBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A5D6 RID: 42454 RVA: 0x002BC7E4 File Offset: 0x002BA9E4
		public byte[] GetBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x0600A5D7 RID: 42455 RVA: 0x002BC7FC File Offset: 0x002BA9FC
		public string SquareColor
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

		// Token: 0x0600A5D8 RID: 42456 RVA: 0x002BC834 File Offset: 0x002BAA34
		public Span<byte> GetSquareColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A5D9 RID: 42457 RVA: 0x002BC844 File Offset: 0x002BAA44
		public byte[] GetSquareColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x0600A5DA RID: 42458 RVA: 0x002BC85C File Offset: 0x002BAA5C
		public string CircleColor
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

		// Token: 0x0600A5DB RID: 42459 RVA: 0x002BC894 File Offset: 0x002BAA94
		public Span<byte> GetCircleColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A5DC RID: 42460 RVA: 0x002BC8A4 File Offset: 0x002BAAA4
		public byte[] GetCircleColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x0600A5DD RID: 42461 RVA: 0x002BC8BC File Offset: 0x002BAABC
		public string GridColor
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

		// Token: 0x0600A5DE RID: 42462 RVA: 0x002BC8F4 File Offset: 0x002BAAF4
		public Span<byte> GetGridColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A5DF RID: 42463 RVA: 0x002BC904 File Offset: 0x002BAB04
		public byte[] GetGridColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x0600A5E0 RID: 42464 RVA: 0x002BC91C File Offset: 0x002BAB1C
		public string BgLightColor
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

		// Token: 0x0600A5E1 RID: 42465 RVA: 0x002BC954 File Offset: 0x002BAB54
		public Span<byte> GetBgLightColorBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A5E2 RID: 42466 RVA: 0x002BC964 File Offset: 0x002BAB64
		public byte[] GetBgLightColorArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x0600A5E3 RID: 42467 RVA: 0x002BC97C File Offset: 0x002BAB7C
		public string TextColor
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

		// Token: 0x0600A5E4 RID: 42468 RVA: 0x002BC9B4 File Offset: 0x002BABB4
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A5E5 RID: 42469 RVA: 0x002BC9C4 File Offset: 0x002BABC4
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04005528 RID: 21800
		private Table __p;
	}
}
