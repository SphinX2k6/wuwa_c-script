using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200105D RID: 4189
	public struct QuestReviewTree : IFlatbufferObject
	{
		// Token: 0x17002C5B RID: 11355
		// (get) Token: 0x0600BC58 RID: 48216 RVA: 0x002ED8F0 File Offset: 0x002EBAF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BC59 RID: 48217 RVA: 0x002ED8FD File Offset: 0x002EBAFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BC5A RID: 48218 RVA: 0x002ED904 File Offset: 0x002EBB04
		public static QuestReviewTree GetRootAsQuestReviewTree(ByteBuffer _bb)
		{
			return QuestReviewTree.GetRootAsQuestReviewTree(_bb, default(QuestReviewTree));
		}

		// Token: 0x0600BC5B RID: 48219 RVA: 0x002ED920 File Offset: 0x002EBB20
		public static QuestReviewTree GetRootAsQuestReviewTree(ByteBuffer _bb, QuestReviewTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BC5C RID: 48220 RVA: 0x002ED93D File Offset: 0x002EBB3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BC5D RID: 48221 RVA: 0x002ED94C File Offset: 0x002EBB4C
		public QuestReviewTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C5C RID: 11356
		// (get) Token: 0x0600BC5E RID: 48222 RVA: 0x002ED95C File Offset: 0x002EBB5C
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

		// Token: 0x0600BC5F RID: 48223 RVA: 0x002ED998 File Offset: 0x002EBB98
		public int QuestLines(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C5D RID: 11357
		// (get) Token: 0x0600BC60 RID: 48224 RVA: 0x002ED9D8 File Offset: 0x002EBBD8
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

		// Token: 0x0600BC61 RID: 48225 RVA: 0x002EDA03 File Offset: 0x002EBC03
		public Span<int> GetQuestLinesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600BC62 RID: 48226 RVA: 0x002EDA12 File Offset: 0x002EBC12
		public int[] GetQuestLinesArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600BC63 RID: 48227 RVA: 0x002EDA29 File Offset: 0x002EBC29
		[NullableContext(1)]
		public int[] QuestLines()
		{
			return this.GetQuestLinesArray();
		}

		// Token: 0x0600BC64 RID: 48228 RVA: 0x002EDA31 File Offset: 0x002EBC31
		[NullableContext(1)]
		public IEnumerable<int> QuestLinesIter()
		{
			QuestReviewTree.<QuestLinesIter>d__16 <QuestLinesIter>d__ = new QuestReviewTree.<QuestLinesIter>d__16(-2);
			<QuestLinesIter>d__.<>3__<>4__this = this;
			return <QuestLinesIter>d__;
		}

		// Token: 0x0400562B RID: 22059
		private Table __p;
	}
}
