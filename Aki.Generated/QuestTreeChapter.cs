using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F7B RID: 3963
	public struct QuestTreeChapter : IFlatbufferObject
	{
		// Token: 0x17002C15 RID: 11285
		// (get) Token: 0x0600B6AB RID: 46763 RVA: 0x002D2081 File Offset: 0x002D0281
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B6AC RID: 46764 RVA: 0x002D208E File Offset: 0x002D028E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B6AD RID: 46765 RVA: 0x002D2098 File Offset: 0x002D0298
		public static QuestTreeChapter GetRootAsQuestTreeChapter(ByteBuffer _bb)
		{
			return QuestTreeChapter.GetRootAsQuestTreeChapter(_bb, default(QuestTreeChapter));
		}

		// Token: 0x0600B6AE RID: 46766 RVA: 0x002D20B4 File Offset: 0x002D02B4
		public static QuestTreeChapter GetRootAsQuestTreeChapter(ByteBuffer _bb, QuestTreeChapter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B6AF RID: 46767 RVA: 0x002D20D1 File Offset: 0x002D02D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B6B0 RID: 46768 RVA: 0x002D20E0 File Offset: 0x002D02E0
		public QuestTreeChapter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C16 RID: 11286
		// (get) Token: 0x0600B6B1 RID: 46769 RVA: 0x002D20F0 File Offset: 0x002D02F0
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

		// Token: 0x17002C17 RID: 11287
		// (get) Token: 0x0600B6B2 RID: 46770 RVA: 0x002D212C File Offset: 0x002D032C
		public string Name
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

		// Token: 0x0600B6B3 RID: 46771 RVA: 0x002D2163 File Offset: 0x002D0363
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B6B4 RID: 46772 RVA: 0x002D2172 File Offset: 0x002D0372
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C18 RID: 11288
		// (get) Token: 0x0600B6B5 RID: 46773 RVA: 0x002D218C File Offset: 0x002D038C
		public string RegionName
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

		// Token: 0x0600B6B6 RID: 46774 RVA: 0x002D21C3 File Offset: 0x002D03C3
		public Span<byte> GetRegionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B6B7 RID: 46775 RVA: 0x002D21D2 File Offset: 0x002D03D2
		public byte[] GetRegionNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C19 RID: 11289
		// (get) Token: 0x0600B6B8 RID: 46776 RVA: 0x002D21EC File Offset: 0x002D03EC
		public string TitleText
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

		// Token: 0x0600B6B9 RID: 46777 RVA: 0x002D2224 File Offset: 0x002D0424
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B6BA RID: 46778 RVA: 0x002D2234 File Offset: 0x002D0434
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C1A RID: 11290
		// (get) Token: 0x0600B6BB RID: 46779 RVA: 0x002D224C File Offset: 0x002D044C
		public string Image
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

		// Token: 0x0600B6BC RID: 46780 RVA: 0x002D2284 File Offset: 0x002D0484
		public Span<byte> GetImageBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B6BD RID: 46781 RVA: 0x002D2294 File Offset: 0x002D0494
		public byte[] GetImageArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C1B RID: 11291
		// (get) Token: 0x0600B6BE RID: 46782 RVA: 0x002D22AC File Offset: 0x002D04AC
		public string RegionImage
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

		// Token: 0x0600B6BF RID: 46783 RVA: 0x002D22E4 File Offset: 0x002D04E4
		public Span<byte> GetRegionImageBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B6C0 RID: 46784 RVA: 0x002D22F4 File Offset: 0x002D04F4
		public byte[] GetRegionImageArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C1C RID: 11292
		// (get) Token: 0x0600B6C1 RID: 46785 RVA: 0x002D230C File Offset: 0x002D050C
		public string InnerRegionImage
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

		// Token: 0x0600B6C2 RID: 46786 RVA: 0x002D2344 File Offset: 0x002D0544
		public Span<byte> GetInnerRegionImageBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B6C3 RID: 46787 RVA: 0x002D2354 File Offset: 0x002D0554
		public byte[] GetInnerRegionImageArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C1D RID: 11293
		// (get) Token: 0x0600B6C4 RID: 46788 RVA: 0x002D236C File Offset: 0x002D056C
		public string RomanNumberImage
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

		// Token: 0x0600B6C5 RID: 46789 RVA: 0x002D23A4 File Offset: 0x002D05A4
		public Span<byte> GetRomanNumberImageBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B6C6 RID: 46790 RVA: 0x002D23B4 File Offset: 0x002D05B4
		public byte[] GetRomanNumberImageArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C1E RID: 11294
		// (get) Token: 0x0600B6C7 RID: 46791 RVA: 0x002D23CC File Offset: 0x002D05CC
		public string InnerBackgroundImage
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

		// Token: 0x0600B6C8 RID: 46792 RVA: 0x002D2404 File Offset: 0x002D0604
		public Span<byte> GetInnerBackgroundImageBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B6C9 RID: 46793 RVA: 0x002D2414 File Offset: 0x002D0614
		public byte[] GetInnerBackgroundImageArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04005049 RID: 20553
		private Table __p;
	}
}
