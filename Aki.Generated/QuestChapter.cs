using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200104F RID: 4175
	public struct QuestChapter : IFlatbufferObject
	{
		// Token: 0x17002C06 RID: 11270
		// (get) Token: 0x0600BB5F RID: 47967 RVA: 0x002EBB3A File Offset: 0x002E9D3A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB60 RID: 47968 RVA: 0x002EBB47 File Offset: 0x002E9D47
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB61 RID: 47969 RVA: 0x002EBB50 File Offset: 0x002E9D50
		public static QuestChapter GetRootAsQuestChapter(ByteBuffer _bb)
		{
			return QuestChapter.GetRootAsQuestChapter(_bb, default(QuestChapter));
		}

		// Token: 0x0600BB62 RID: 47970 RVA: 0x002EBB6C File Offset: 0x002E9D6C
		public static QuestChapter GetRootAsQuestChapter(ByteBuffer _bb, QuestChapter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB63 RID: 47971 RVA: 0x002EBB89 File Offset: 0x002E9D89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB64 RID: 47972 RVA: 0x002EBB98 File Offset: 0x002E9D98
		public QuestChapter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C07 RID: 11271
		// (get) Token: 0x0600BB65 RID: 47973 RVA: 0x002EBBA8 File Offset: 0x002E9DA8
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

		// Token: 0x17002C08 RID: 11272
		// (get) Token: 0x0600BB66 RID: 47974 RVA: 0x002EBBE4 File Offset: 0x002E9DE4
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

		// Token: 0x0600BB67 RID: 47975 RVA: 0x002EBC1B File Offset: 0x002E9E1B
		public Span<byte> GetChapterNumBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BB68 RID: 47976 RVA: 0x002EBC2A File Offset: 0x002E9E2A
		public byte[] GetChapterNumArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C09 RID: 11273
		// (get) Token: 0x0600BB69 RID: 47977 RVA: 0x002EBC44 File Offset: 0x002E9E44
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

		// Token: 0x0600BB6A RID: 47978 RVA: 0x002EBC7B File Offset: 0x002E9E7B
		public Span<byte> GetSectionNumBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BB6B RID: 47979 RVA: 0x002EBC8A File Offset: 0x002E9E8A
		public byte[] GetSectionNumArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C0A RID: 11274
		// (get) Token: 0x0600BB6C RID: 47980 RVA: 0x002EBCA4 File Offset: 0x002E9EA4
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

		// Token: 0x0600BB6D RID: 47981 RVA: 0x002EBCDC File Offset: 0x002E9EDC
		public Span<byte> GetActNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BB6E RID: 47982 RVA: 0x002EBCEC File Offset: 0x002E9EEC
		public byte[] GetActNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C0B RID: 11275
		// (get) Token: 0x0600BB6F RID: 47983 RVA: 0x002EBD04 File Offset: 0x002E9F04
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

		// Token: 0x0600BB70 RID: 47984 RVA: 0x002EBD3C File Offset: 0x002E9F3C
		public Span<byte> GetChapterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BB71 RID: 47985 RVA: 0x002EBD4C File Offset: 0x002E9F4C
		public byte[] GetChapterNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C0C RID: 11276
		// (get) Token: 0x0600BB72 RID: 47986 RVA: 0x002EBD64 File Offset: 0x002E9F64
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

		// Token: 0x0600BB73 RID: 47987 RVA: 0x002EBD9C File Offset: 0x002E9F9C
		public Span<byte> GetChapterIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BB74 RID: 47988 RVA: 0x002EBDAC File Offset: 0x002E9FAC
		public byte[] GetChapterIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C0D RID: 11277
		// (get) Token: 0x0600BB75 RID: 47989 RVA: 0x002EBDC4 File Offset: 0x002E9FC4
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

		// Token: 0x0600BB76 RID: 47990 RVA: 0x002EBDFC File Offset: 0x002E9FFC
		public Span<byte> GetPrefabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BB77 RID: 47991 RVA: 0x002EBE0C File Offset: 0x002EA00C
		public byte[] GetPrefabNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0400561D RID: 22045
		private Table __p;
	}
}
