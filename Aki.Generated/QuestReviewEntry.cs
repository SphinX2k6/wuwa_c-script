using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F72 RID: 3954
	public struct QuestReviewEntry : IFlatbufferObject
	{
		// Token: 0x17002BC1 RID: 11201
		// (get) Token: 0x0600B5BF RID: 46527 RVA: 0x002D016C File Offset: 0x002CE36C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B5C0 RID: 46528 RVA: 0x002D0179 File Offset: 0x002CE379
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B5C1 RID: 46529 RVA: 0x002D0180 File Offset: 0x002CE380
		public static QuestReviewEntry GetRootAsQuestReviewEntry(ByteBuffer _bb)
		{
			return QuestReviewEntry.GetRootAsQuestReviewEntry(_bb, default(QuestReviewEntry));
		}

		// Token: 0x0600B5C2 RID: 46530 RVA: 0x002D019C File Offset: 0x002CE39C
		public static QuestReviewEntry GetRootAsQuestReviewEntry(ByteBuffer _bb, QuestReviewEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B5C3 RID: 46531 RVA: 0x002D01B9 File Offset: 0x002CE3B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B5C4 RID: 46532 RVA: 0x002D01C8 File Offset: 0x002CE3C8
		public QuestReviewEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BC2 RID: 11202
		// (get) Token: 0x0600B5C5 RID: 46533 RVA: 0x002D01D8 File Offset: 0x002CE3D8
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

		// Token: 0x0600B5C6 RID: 46534 RVA: 0x002D0214 File Offset: 0x002CE414
		public int QuestTabs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002BC3 RID: 11203
		// (get) Token: 0x0600B5C7 RID: 46535 RVA: 0x002D0254 File Offset: 0x002CE454
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

		// Token: 0x0600B5C8 RID: 46536 RVA: 0x002D027F File Offset: 0x002CE47F
		public Span<int> GetQuestTabsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600B5C9 RID: 46537 RVA: 0x002D028E File Offset: 0x002CE48E
		public int[] GetQuestTabsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002BC4 RID: 11204
		// (get) Token: 0x0600B5CA RID: 46538 RVA: 0x002D02A8 File Offset: 0x002CE4A8
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

		// Token: 0x0600B5CB RID: 46539 RVA: 0x002D02E4 File Offset: 0x002CE4E4
		public int RelatedQuest(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002BC5 RID: 11205
		// (get) Token: 0x0600B5CC RID: 46540 RVA: 0x002D0324 File Offset: 0x002CE524
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

		// Token: 0x0600B5CD RID: 46541 RVA: 0x002D0350 File Offset: 0x002CE550
		public Span<int> GetRelatedQuestBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600B5CE RID: 46542 RVA: 0x002D0360 File Offset: 0x002CE560
		public int[] GetRelatedQuestArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002BC6 RID: 11206
		// (get) Token: 0x0600B5CF RID: 46543 RVA: 0x002D0378 File Offset: 0x002CE578
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

		// Token: 0x0600B5D0 RID: 46544 RVA: 0x002D03B8 File Offset: 0x002CE5B8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用QuestTabsIter()或GetQuestTabsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] QuestTabs()
		{
			QuestReviewEntry questReviewEntry = this;
			return questReviewEntry.GetQuestTabsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B5D1 RID: 46545 RVA: 0x002D03DC File Offset: 0x002CE5DC
		[NullableContext(1)]
		public readonly IEnumerable<int> QuestTabsIter()
		{
			QuestReviewEntry.<QuestTabsIter>d__25 <QuestTabsIter>d__ = new QuestReviewEntry.<QuestTabsIter>d__25(-2);
			<QuestTabsIter>d__.<>3__<>4__this = this;
			return <QuestTabsIter>d__;
		}

		// Token: 0x0600B5D2 RID: 46546 RVA: 0x002D03F4 File Offset: 0x002CE5F4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RelatedQuestIter()或GetRelatedQuestBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RelatedQuest()
		{
			QuestReviewEntry questReviewEntry = this;
			return questReviewEntry.GetRelatedQuestArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B5D3 RID: 46547 RVA: 0x002D0418 File Offset: 0x002CE618
		[NullableContext(1)]
		public readonly IEnumerable<int> RelatedQuestIter()
		{
			QuestReviewEntry.<RelatedQuestIter>d__27 <RelatedQuestIter>d__ = new QuestReviewEntry.<RelatedQuestIter>d__27(-2);
			<RelatedQuestIter>d__.<>3__<>4__this = this;
			return <RelatedQuestIter>d__;
		}

		// Token: 0x04005040 RID: 20544
		private Table __p;
	}
}
