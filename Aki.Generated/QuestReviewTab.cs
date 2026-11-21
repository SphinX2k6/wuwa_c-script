using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200105C RID: 4188
	public struct QuestReviewTab : IFlatbufferObject
	{
		// Token: 0x17002C56 RID: 11350
		// (get) Token: 0x0600BC4C RID: 48204 RVA: 0x002ED76C File Offset: 0x002EB96C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BC4D RID: 48205 RVA: 0x002ED779 File Offset: 0x002EB979
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BC4E RID: 48206 RVA: 0x002ED780 File Offset: 0x002EB980
		public static QuestReviewTab GetRootAsQuestReviewTab(ByteBuffer _bb)
		{
			return QuestReviewTab.GetRootAsQuestReviewTab(_bb, default(QuestReviewTab));
		}

		// Token: 0x0600BC4F RID: 48207 RVA: 0x002ED79C File Offset: 0x002EB99C
		public static QuestReviewTab GetRootAsQuestReviewTab(ByteBuffer _bb, QuestReviewTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BC50 RID: 48208 RVA: 0x002ED7B9 File Offset: 0x002EB9B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BC51 RID: 48209 RVA: 0x002ED7C8 File Offset: 0x002EB9C8
		public QuestReviewTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C57 RID: 11351
		// (get) Token: 0x0600BC52 RID: 48210 RVA: 0x002ED7D8 File Offset: 0x002EB9D8
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

		// Token: 0x17002C58 RID: 11352
		// (get) Token: 0x0600BC53 RID: 48211 RVA: 0x002ED814 File Offset: 0x002EBA14
		public int QuestTree
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C59 RID: 11353
		// (get) Token: 0x0600BC54 RID: 48212 RVA: 0x002ED850 File Offset: 0x002EBA50
		public string TabName
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

		// Token: 0x0600BC55 RID: 48213 RVA: 0x002ED887 File Offset: 0x002EBA87
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BC56 RID: 48214 RVA: 0x002ED896 File Offset: 0x002EBA96
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C5A RID: 11354
		// (get) Token: 0x0600BC57 RID: 48215 RVA: 0x002ED8B0 File Offset: 0x002EBAB0
		public bool HideTabsWhenUnlock
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400562A RID: 22058
		private Table __p;
	}
}
