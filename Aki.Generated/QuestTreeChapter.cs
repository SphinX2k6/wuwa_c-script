using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001062 RID: 4194
	public struct QuestTreeChapter : IFlatbufferObject
	{
		// Token: 0x17002C8D RID: 11405
		// (get) Token: 0x0600BCE8 RID: 48360 RVA: 0x002EEBA2 File Offset: 0x002ECDA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BCE9 RID: 48361 RVA: 0x002EEBAF File Offset: 0x002ECDAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BCEA RID: 48362 RVA: 0x002EEBB8 File Offset: 0x002ECDB8
		public static QuestTreeChapter GetRootAsQuestTreeChapter(ByteBuffer _bb)
		{
			return QuestTreeChapter.GetRootAsQuestTreeChapter(_bb, default(QuestTreeChapter));
		}

		// Token: 0x0600BCEB RID: 48363 RVA: 0x002EEBD4 File Offset: 0x002ECDD4
		public static QuestTreeChapter GetRootAsQuestTreeChapter(ByteBuffer _bb, QuestTreeChapter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BCEC RID: 48364 RVA: 0x002EEBF1 File Offset: 0x002ECDF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BCED RID: 48365 RVA: 0x002EEC00 File Offset: 0x002ECE00
		public QuestTreeChapter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C8E RID: 11406
		// (get) Token: 0x0600BCEE RID: 48366 RVA: 0x002EEC10 File Offset: 0x002ECE10
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

		// Token: 0x17002C8F RID: 11407
		// (get) Token: 0x0600BCEF RID: 48367 RVA: 0x002EEC4C File Offset: 0x002ECE4C
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

		// Token: 0x0600BCF0 RID: 48368 RVA: 0x002EEC83 File Offset: 0x002ECE83
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BCF1 RID: 48369 RVA: 0x002EEC92 File Offset: 0x002ECE92
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C90 RID: 11408
		// (get) Token: 0x0600BCF2 RID: 48370 RVA: 0x002EECAC File Offset: 0x002ECEAC
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

		// Token: 0x0600BCF3 RID: 48371 RVA: 0x002EECE3 File Offset: 0x002ECEE3
		public Span<byte> GetRegionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BCF4 RID: 48372 RVA: 0x002EECF2 File Offset: 0x002ECEF2
		public byte[] GetRegionNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C91 RID: 11409
		// (get) Token: 0x0600BCF5 RID: 48373 RVA: 0x002EED0C File Offset: 0x002ECF0C
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

		// Token: 0x0600BCF6 RID: 48374 RVA: 0x002EED44 File Offset: 0x002ECF44
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BCF7 RID: 48375 RVA: 0x002EED54 File Offset: 0x002ECF54
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C92 RID: 11410
		// (get) Token: 0x0600BCF8 RID: 48376 RVA: 0x002EED6C File Offset: 0x002ECF6C
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

		// Token: 0x0600BCF9 RID: 48377 RVA: 0x002EEDA4 File Offset: 0x002ECFA4
		public Span<byte> GetImageBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BCFA RID: 48378 RVA: 0x002EEDB4 File Offset: 0x002ECFB4
		public byte[] GetImageArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C93 RID: 11411
		// (get) Token: 0x0600BCFB RID: 48379 RVA: 0x002EEDCC File Offset: 0x002ECFCC
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

		// Token: 0x0600BCFC RID: 48380 RVA: 0x002EEE04 File Offset: 0x002ED004
		public Span<byte> GetRegionImageBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BCFD RID: 48381 RVA: 0x002EEE14 File Offset: 0x002ED014
		public byte[] GetRegionImageArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C94 RID: 11412
		// (get) Token: 0x0600BCFE RID: 48382 RVA: 0x002EEE2C File Offset: 0x002ED02C
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

		// Token: 0x0600BCFF RID: 48383 RVA: 0x002EEE64 File Offset: 0x002ED064
		public Span<byte> GetInnerRegionImageBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BD00 RID: 48384 RVA: 0x002EEE74 File Offset: 0x002ED074
		public byte[] GetInnerRegionImageArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C95 RID: 11413
		// (get) Token: 0x0600BD01 RID: 48385 RVA: 0x002EEE8C File Offset: 0x002ED08C
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

		// Token: 0x0600BD02 RID: 48386 RVA: 0x002EEEC4 File Offset: 0x002ED0C4
		public Span<byte> GetRomanNumberImageBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BD03 RID: 48387 RVA: 0x002EEED4 File Offset: 0x002ED0D4
		public byte[] GetRomanNumberImageArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C96 RID: 11414
		// (get) Token: 0x0600BD04 RID: 48388 RVA: 0x002EEEEC File Offset: 0x002ED0EC
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

		// Token: 0x0600BD05 RID: 48389 RVA: 0x002EEF24 File Offset: 0x002ED124
		public Span<byte> GetInnerBackgroundImageBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BD06 RID: 48390 RVA: 0x002EEF34 File Offset: 0x002ED134
		public byte[] GetInnerBackgroundImageArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04005630 RID: 22064
		private Table __p;
	}
}
