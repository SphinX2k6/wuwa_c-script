using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F76 RID: 3958
	public struct QuestReviewTree : IFlatbufferObject
	{
		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x0600B61B RID: 46619 RVA: 0x002D0D54 File Offset: 0x002CEF54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B61C RID: 46620 RVA: 0x002D0D61 File Offset: 0x002CEF61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B61D RID: 46621 RVA: 0x002D0D68 File Offset: 0x002CEF68
		public static QuestReviewTree GetRootAsQuestReviewTree(ByteBuffer _bb)
		{
			return QuestReviewTree.GetRootAsQuestReviewTree(_bb, default(QuestReviewTree));
		}

		// Token: 0x0600B61E RID: 46622 RVA: 0x002D0D84 File Offset: 0x002CEF84
		public static QuestReviewTree GetRootAsQuestReviewTree(ByteBuffer _bb, QuestReviewTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B61F RID: 46623 RVA: 0x002D0DA1 File Offset: 0x002CEFA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B620 RID: 46624 RVA: 0x002D0DB0 File Offset: 0x002CEFB0
		public QuestReviewTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x0600B621 RID: 46625 RVA: 0x002D0DC0 File Offset: 0x002CEFC0
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

		// Token: 0x0600B622 RID: 46626 RVA: 0x002D0DFC File Offset: 0x002CEFFC
		public int QuestLines(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x0600B623 RID: 46627 RVA: 0x002D0E3C File Offset: 0x002CF03C
		public int QuestLinesLength
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

		// Token: 0x0600B624 RID: 46628 RVA: 0x002D0E67 File Offset: 0x002CF067
		public Span<int> GetQuestLinesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600B625 RID: 46629 RVA: 0x002D0E76 File Offset: 0x002CF076
		public int[] GetQuestLinesArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600B626 RID: 46630 RVA: 0x002D0E90 File Offset: 0x002CF090
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用QuestLinesIter()或GetQuestLinesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] QuestLines()
		{
			QuestReviewTree questReviewTree = this;
			return questReviewTree.GetQuestLinesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B627 RID: 46631 RVA: 0x002D0EB4 File Offset: 0x002CF0B4
		[NullableContext(1)]
		public readonly IEnumerable<int> QuestLinesIter()
		{
			QuestReviewTree.<QuestLinesIter>d__16 <QuestLinesIter>d__ = new QuestReviewTree.<QuestLinesIter>d__16(-2);
			<QuestLinesIter>d__.<>3__<>4__this = this;
			return <QuestLinesIter>d__;
		}

		// Token: 0x04005044 RID: 20548
		private Table __p;
	}
}
