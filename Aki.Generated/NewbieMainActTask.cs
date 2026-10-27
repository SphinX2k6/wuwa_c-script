using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E84 RID: 3716
	public struct NewbieMainActTask : IFlatbufferObject
	{
		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x06009E8A RID: 40586 RVA: 0x0029C695 File Offset: 0x0029A895
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E8B RID: 40587 RVA: 0x0029C6A2 File Offset: 0x0029A8A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E8C RID: 40588 RVA: 0x0029C6AC File Offset: 0x0029A8AC
		public static NewbieMainActTask GetRootAsNewbieMainActTask(ByteBuffer _bb)
		{
			return NewbieMainActTask.GetRootAsNewbieMainActTask(_bb, default(NewbieMainActTask));
		}

		// Token: 0x06009E8D RID: 40589 RVA: 0x0029C6C8 File Offset: 0x0029A8C8
		public static NewbieMainActTask GetRootAsNewbieMainActTask(ByteBuffer _bb, NewbieMainActTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E8E RID: 40590 RVA: 0x0029C6E5 File Offset: 0x0029A8E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E8F RID: 40591 RVA: 0x0029C6F4 File Offset: 0x0029A8F4
		public NewbieMainActTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x06009E90 RID: 40592 RVA: 0x0029C704 File Offset: 0x0029A904
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

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x06009E91 RID: 40593 RVA: 0x0029C740 File Offset: 0x0029A940
		public int TabId
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

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x06009E92 RID: 40594 RVA: 0x0029C77C File Offset: 0x0029A97C
		public int QuestId
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

		// Token: 0x06009E93 RID: 40595 RVA: 0x0029C7B8 File Offset: 0x0029A9B8
		public int Quest(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x06009E94 RID: 40596 RVA: 0x0029C7F8 File Offset: 0x0029A9F8
		public int QuestLength
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

		// Token: 0x06009E95 RID: 40597 RVA: 0x0029C824 File Offset: 0x0029AA24
		public Span<int> GetQuestBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009E96 RID: 40598 RVA: 0x0029C834 File Offset: 0x0029AA34
		public int[] GetQuestArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x06009E97 RID: 40599 RVA: 0x0029C84C File Offset: 0x0029AA4C
		public int QuestType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x06009E98 RID: 40600 RVA: 0x0029C88C File Offset: 0x0029AA8C
		public int Act
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009E99 RID: 40601 RVA: 0x0029C8CC File Offset: 0x0029AACC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用QuestIter()或GetQuestBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Quest()
		{
			NewbieMainActTask newbieMainActTask = this;
			return newbieMainActTask.GetQuestArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009E9A RID: 40602 RVA: 0x0029C8F0 File Offset: 0x0029AAF0
		[NullableContext(1)]
		public readonly IEnumerable<int> QuestIter()
		{
			NewbieMainActTask.<QuestIter>d__24 <QuestIter>d__ = new NewbieMainActTask.<QuestIter>d__24(-2);
			<QuestIter>d__.<>3__<>4__this = this;
			return <QuestIter>d__;
		}

		// Token: 0x04004F32 RID: 20274
		private Table __p;
	}
}
