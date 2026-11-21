using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200105E RID: 4190
	public struct QuestTag : IFlatbufferObject
	{
		// Token: 0x17002C5E RID: 11358
		// (get) Token: 0x0600BC65 RID: 48229 RVA: 0x002EDA46 File Offset: 0x002EBC46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BC66 RID: 48230 RVA: 0x002EDA53 File Offset: 0x002EBC53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BC67 RID: 48231 RVA: 0x002EDA5C File Offset: 0x002EBC5C
		public static QuestTag GetRootAsQuestTag(ByteBuffer _bb)
		{
			return QuestTag.GetRootAsQuestTag(_bb, default(QuestTag));
		}

		// Token: 0x0600BC68 RID: 48232 RVA: 0x002EDA78 File Offset: 0x002EBC78
		public static QuestTag GetRootAsQuestTag(ByteBuffer _bb, QuestTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BC69 RID: 48233 RVA: 0x002EDA95 File Offset: 0x002EBC95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BC6A RID: 48234 RVA: 0x002EDAA4 File Offset: 0x002EBCA4
		public QuestTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C5F RID: 11359
		// (get) Token: 0x0600BC6B RID: 48235 RVA: 0x002EDAB4 File Offset: 0x002EBCB4
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

		// Token: 0x17002C60 RID: 11360
		// (get) Token: 0x0600BC6C RID: 48236 RVA: 0x002EDAF0 File Offset: 0x002EBCF0
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

		// Token: 0x0600BC6D RID: 48237 RVA: 0x002EDB27 File Offset: 0x002EBD27
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BC6E RID: 48238 RVA: 0x002EDB36 File Offset: 0x002EBD36
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C61 RID: 11361
		// (get) Token: 0x0600BC6F RID: 48239 RVA: 0x002EDB50 File Offset: 0x002EBD50
		public string BgSpritePath
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

		// Token: 0x0600BC70 RID: 48240 RVA: 0x002EDB87 File Offset: 0x002EBD87
		public Span<byte> GetBgSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BC71 RID: 48241 RVA: 0x002EDB96 File Offset: 0x002EBD96
		public byte[] GetBgSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C62 RID: 11362
		// (get) Token: 0x0600BC72 RID: 48242 RVA: 0x002EDBB0 File Offset: 0x002EBDB0
		public string Text
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

		// Token: 0x0600BC73 RID: 48243 RVA: 0x002EDBE8 File Offset: 0x002EBDE8
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BC74 RID: 48244 RVA: 0x002EDBF8 File Offset: 0x002EBDF8
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C63 RID: 11363
		// (get) Token: 0x0600BC75 RID: 48245 RVA: 0x002EDC10 File Offset: 0x002EBE10
		public bool UseOriginalSize
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002C64 RID: 11364
		// (get) Token: 0x0600BC76 RID: 48246 RVA: 0x002EDC50 File Offset: 0x002EBE50
		public string PrefabPath
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

		// Token: 0x0600BC77 RID: 48247 RVA: 0x002EDC88 File Offset: 0x002EBE88
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BC78 RID: 48248 RVA: 0x002EDC98 File Offset: 0x002EBE98
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400562C RID: 22060
		private Table __p;
	}
}
