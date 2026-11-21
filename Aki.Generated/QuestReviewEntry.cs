using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001059 RID: 4185
	public struct QuestReviewEntry : IFlatbufferObject
	{
		// Token: 0x17002C39 RID: 11321
		// (get) Token: 0x0600BBFC RID: 48124 RVA: 0x002ECD48 File Offset: 0x002EAF48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BBFD RID: 48125 RVA: 0x002ECD55 File Offset: 0x002EAF55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BBFE RID: 48126 RVA: 0x002ECD5C File Offset: 0x002EAF5C
		public static QuestReviewEntry GetRootAsQuestReviewEntry(ByteBuffer _bb)
		{
			return QuestReviewEntry.GetRootAsQuestReviewEntry(_bb, default(QuestReviewEntry));
		}

		// Token: 0x0600BBFF RID: 48127 RVA: 0x002ECD78 File Offset: 0x002EAF78
		public static QuestReviewEntry GetRootAsQuestReviewEntry(ByteBuffer _bb, QuestReviewEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BC00 RID: 48128 RVA: 0x002ECD95 File Offset: 0x002EAF95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BC01 RID: 48129 RVA: 0x002ECDA4 File Offset: 0x002EAFA4
		public QuestReviewEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C3A RID: 11322
		// (get) Token: 0x0600BC02 RID: 48130 RVA: 0x002ECDB4 File Offset: 0x002EAFB4
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

		// Token: 0x0600BC03 RID: 48131 RVA: 0x002ECDF0 File Offset: 0x002EAFF0
		public int QuestTabs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C3B RID: 11323
		// (get) Token: 0x0600BC04 RID: 48132 RVA: 0x002ECE30 File Offset: 0x002EB030
		public int QuestTabsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BC05 RID: 48133 RVA: 0x002ECE5B File Offset: 0x002EB05B
		public Span<int> GetQuestTabsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600BC06 RID: 48134 RVA: 0x002ECE6A File Offset: 0x002EB06A
		public int[] GetQuestTabsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002C3C RID: 11324
		// (get) Token: 0x0600BC07 RID: 48135 RVA: 0x002ECE84 File Offset: 0x002EB084
		public int TargetTab
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

		// Token: 0x0600BC08 RID: 48136 RVA: 0x002ECEC0 File Offset: 0x002EB0C0
		public int RelatedQuest(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C3D RID: 11325
		// (get) Token: 0x0600BC09 RID: 48137 RVA: 0x002ECF00 File Offset: 0x002EB100
		public int RelatedQuestLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BC0A RID: 48138 RVA: 0x002ECF2C File Offset: 0x002EB12C
		public Span<int> GetRelatedQuestBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600BC0B RID: 48139 RVA: 0x002ECF3C File Offset: 0x002EB13C
		public int[] GetRelatedQuestArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002C3E RID: 11326
		// (get) Token: 0x0600BC0C RID: 48140 RVA: 0x002ECF54 File Offset: 0x002EB154
		public int TimerDuration
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 5;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC0D RID: 48141 RVA: 0x002ECF91 File Offset: 0x002EB191
		[NullableContext(1)]
		public int[] QuestTabs()
		{
			return this.GetQuestTabsArray();
		}

		// Token: 0x0600BC0E RID: 48142 RVA: 0x002ECF99 File Offset: 0x002EB199
		[NullableContext(1)]
		public IEnumerable<int> QuestTabsIter()
		{
			QuestReviewEntry.<QuestTabsIter>d__25 <QuestTabsIter>d__ = new QuestReviewEntry.<QuestTabsIter>d__25(-2);
			<QuestTabsIter>d__.<>3__<>4__this = this;
			return <QuestTabsIter>d__;
		}

		// Token: 0x0600BC0F RID: 48143 RVA: 0x002ECFAE File Offset: 0x002EB1AE
		[NullableContext(1)]
		public int[] RelatedQuest()
		{
			return this.GetRelatedQuestArray();
		}

		// Token: 0x0600BC10 RID: 48144 RVA: 0x002ECFB6 File Offset: 0x002EB1B6
		[NullableContext(1)]
		public IEnumerable<int> RelatedQuestIter()
		{
			QuestReviewEntry.<RelatedQuestIter>d__27 <RelatedQuestIter>d__ = new QuestReviewEntry.<RelatedQuestIter>d__27(-2);
			<RelatedQuestIter>d__.<>3__<>4__this = this;
			return <RelatedQuestIter>d__;
		}

		// Token: 0x04005627 RID: 22055
		private Table __p;
	}
}
