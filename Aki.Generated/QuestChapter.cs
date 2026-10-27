using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F68 RID: 3944
	public struct QuestChapter : IFlatbufferObject
	{
		// Token: 0x17002B8E RID: 11150
		// (get) Token: 0x0600B522 RID: 46370 RVA: 0x002CEF1F File Offset: 0x002CD11F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B523 RID: 46371 RVA: 0x002CEF2C File Offset: 0x002CD12C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B524 RID: 46372 RVA: 0x002CEF34 File Offset: 0x002CD134
		public static QuestChapter GetRootAsQuestChapter(ByteBuffer _bb)
		{
			return QuestChapter.GetRootAsQuestChapter(_bb, default(QuestChapter));
		}

		// Token: 0x0600B525 RID: 46373 RVA: 0x002CEF50 File Offset: 0x002CD150
		public static QuestChapter GetRootAsQuestChapter(ByteBuffer _bb, QuestChapter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B526 RID: 46374 RVA: 0x002CEF6D File Offset: 0x002CD16D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B527 RID: 46375 RVA: 0x002CEF7C File Offset: 0x002CD17C
		public QuestChapter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B8F RID: 11151
		// (get) Token: 0x0600B528 RID: 46376 RVA: 0x002CEF8C File Offset: 0x002CD18C
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

		// Token: 0x17002B90 RID: 11152
		// (get) Token: 0x0600B529 RID: 46377 RVA: 0x002CEFC8 File Offset: 0x002CD1C8
		public string ChapterNum
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

		// Token: 0x0600B52A RID: 46378 RVA: 0x002CEFFF File Offset: 0x002CD1FF
		public Span<byte> GetChapterNumBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B52B RID: 46379 RVA: 0x002CF00E File Offset: 0x002CD20E
		public byte[] GetChapterNumArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B91 RID: 11153
		// (get) Token: 0x0600B52C RID: 46380 RVA: 0x002CF028 File Offset: 0x002CD228
		public string SectionNum
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

		// Token: 0x0600B52D RID: 46381 RVA: 0x002CF05F File Offset: 0x002CD25F
		public Span<byte> GetSectionNumBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B52E RID: 46382 RVA: 0x002CF06E File Offset: 0x002CD26E
		public byte[] GetSectionNumArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B92 RID: 11154
		// (get) Token: 0x0600B52F RID: 46383 RVA: 0x002CF088 File Offset: 0x002CD288
		public string ActName
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

		// Token: 0x0600B530 RID: 46384 RVA: 0x002CF0C0 File Offset: 0x002CD2C0
		public Span<byte> GetActNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B531 RID: 46385 RVA: 0x002CF0D0 File Offset: 0x002CD2D0
		public byte[] GetActNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B93 RID: 11155
		// (get) Token: 0x0600B532 RID: 46386 RVA: 0x002CF0E8 File Offset: 0x002CD2E8
		public string ChapterName
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

		// Token: 0x0600B533 RID: 46387 RVA: 0x002CF120 File Offset: 0x002CD320
		public Span<byte> GetChapterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B534 RID: 46388 RVA: 0x002CF130 File Offset: 0x002CD330
		public byte[] GetChapterNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B94 RID: 11156
		// (get) Token: 0x0600B535 RID: 46389 RVA: 0x002CF148 File Offset: 0x002CD348
		public string ChapterIcon
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

		// Token: 0x0600B536 RID: 46390 RVA: 0x002CF180 File Offset: 0x002CD380
		public Span<byte> GetChapterIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B537 RID: 46391 RVA: 0x002CF190 File Offset: 0x002CD390
		public byte[] GetChapterIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B95 RID: 11157
		// (get) Token: 0x0600B538 RID: 46392 RVA: 0x002CF1A8 File Offset: 0x002CD3A8
		public string PrefabName
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

		// Token: 0x0600B539 RID: 46393 RVA: 0x002CF1E0 File Offset: 0x002CD3E0
		public Span<byte> GetPrefabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B53A RID: 46394 RVA: 0x002CF1F0 File Offset: 0x002CD3F0
		public byte[] GetPrefabNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005036 RID: 20534
		private Table __p;
	}
}
