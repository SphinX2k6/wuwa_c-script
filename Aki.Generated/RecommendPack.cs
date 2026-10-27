using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA2 RID: 4002
	public struct RecommendPack : IFlatbufferObject
	{
		// Token: 0x17002D59 RID: 11609
		// (get) Token: 0x0600BA07 RID: 47623 RVA: 0x002D9B34 File Offset: 0x002D7D34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BA08 RID: 47624 RVA: 0x002D9B41 File Offset: 0x002D7D41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BA09 RID: 47625 RVA: 0x002D9B48 File Offset: 0x002D7D48
		public static RecommendPack GetRootAsRecommendPack(ByteBuffer _bb)
		{
			return RecommendPack.GetRootAsRecommendPack(_bb, default(RecommendPack));
		}

		// Token: 0x0600BA0A RID: 47626 RVA: 0x002D9B64 File Offset: 0x002D7D64
		public static RecommendPack GetRootAsRecommendPack(ByteBuffer _bb, RecommendPack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BA0B RID: 47627 RVA: 0x002D9B81 File Offset: 0x002D7D81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BA0C RID: 47628 RVA: 0x002D9B90 File Offset: 0x002D7D90
		public RecommendPack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D5A RID: 11610
		// (get) Token: 0x0600BA0D RID: 47629 RVA: 0x002D9BA0 File Offset: 0x002D7DA0
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

		// Token: 0x0600BA0E RID: 47630 RVA: 0x002D9BDC File Offset: 0x002D7DDC
		public int FinishQuest(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D5B RID: 11611
		// (get) Token: 0x0600BA0F RID: 47631 RVA: 0x002D9C1C File Offset: 0x002D7E1C
		public int FinishQuestLength
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

		// Token: 0x0600BA10 RID: 47632 RVA: 0x002D9C47 File Offset: 0x002D7E47
		public Span<int> GetFinishQuestBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600BA11 RID: 47633 RVA: 0x002D9C56 File Offset: 0x002D7E56
		public int[] GetFinishQuestArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600BA12 RID: 47634 RVA: 0x002D9C70 File Offset: 0x002D7E70
		public int UnfinishQuest(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D5C RID: 11612
		// (get) Token: 0x0600BA13 RID: 47635 RVA: 0x002D9CB0 File Offset: 0x002D7EB0
		public int UnfinishQuestLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BA14 RID: 47636 RVA: 0x002D9CDB File Offset: 0x002D7EDB
		public Span<int> GetUnfinishQuestBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600BA15 RID: 47637 RVA: 0x002D9CEA File Offset: 0x002D7EEA
		public int[] GetUnfinishQuestArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600BA16 RID: 47638 RVA: 0x002D9D04 File Offset: 0x002D7F04
		public int Source(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D5D RID: 11613
		// (get) Token: 0x0600BA17 RID: 47639 RVA: 0x002D9D44 File Offset: 0x002D7F44
		public int SourceLength
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

		// Token: 0x0600BA18 RID: 47640 RVA: 0x002D9D70 File Offset: 0x002D7F70
		public Span<int> GetSourceBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600BA19 RID: 47641 RVA: 0x002D9D80 File Offset: 0x002D7F80
		public int[] GetSourceArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600BA1A RID: 47642 RVA: 0x002D9D98 File Offset: 0x002D7F98
		public int Video(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D5E RID: 11614
		// (get) Token: 0x0600BA1B RID: 47643 RVA: 0x002D9DD8 File Offset: 0x002D7FD8
		public int VideoLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BA1C RID: 47644 RVA: 0x002D9E04 File Offset: 0x002D8004
		public Span<int> GetVideoBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600BA1D RID: 47645 RVA: 0x002D9E14 File Offset: 0x002D8014
		public int[] GetVideoArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600BA1E RID: 47646 RVA: 0x002D9E2C File Offset: 0x002D802C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FinishQuestIter()或GetFinishQuestBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FinishQuest()
		{
			RecommendPack recommendPack = this;
			return recommendPack.GetFinishQuestArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BA1F RID: 47647 RVA: 0x002D9E50 File Offset: 0x002D8050
		[NullableContext(1)]
		public readonly IEnumerable<int> FinishQuestIter()
		{
			RecommendPack.<FinishQuestIter>d__31 <FinishQuestIter>d__ = new RecommendPack.<FinishQuestIter>d__31(-2);
			<FinishQuestIter>d__.<>3__<>4__this = this;
			return <FinishQuestIter>d__;
		}

		// Token: 0x0600BA20 RID: 47648 RVA: 0x002D9E68 File Offset: 0x002D8068
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SourceIter()或GetSourceBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Source()
		{
			RecommendPack recommendPack = this;
			return recommendPack.GetSourceArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BA21 RID: 47649 RVA: 0x002D9E8C File Offset: 0x002D808C
		[NullableContext(1)]
		public readonly IEnumerable<int> SourceIter()
		{
			RecommendPack.<SourceIter>d__33 <SourceIter>d__ = new RecommendPack.<SourceIter>d__33(-2);
			<SourceIter>d__.<>3__<>4__this = this;
			return <SourceIter>d__;
		}

		// Token: 0x0600BA22 RID: 47650 RVA: 0x002D9EA4 File Offset: 0x002D80A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnfinishQuestIter()或GetUnfinishQuestBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnfinishQuest()
		{
			RecommendPack recommendPack = this;
			return recommendPack.GetUnfinishQuestArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BA23 RID: 47651 RVA: 0x002D9EC8 File Offset: 0x002D80C8
		[NullableContext(1)]
		public readonly IEnumerable<int> UnfinishQuestIter()
		{
			RecommendPack.<UnfinishQuestIter>d__35 <UnfinishQuestIter>d__ = new RecommendPack.<UnfinishQuestIter>d__35(-2);
			<UnfinishQuestIter>d__.<>3__<>4__this = this;
			return <UnfinishQuestIter>d__;
		}

		// Token: 0x0600BA24 RID: 47652 RVA: 0x002D9EE0 File Offset: 0x002D80E0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用VideoIter()或GetVideoBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Video()
		{
			RecommendPack recommendPack = this;
			return recommendPack.GetVideoArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BA25 RID: 47653 RVA: 0x002D9F04 File Offset: 0x002D8104
		[NullableContext(1)]
		public readonly IEnumerable<int> VideoIter()
		{
			RecommendPack.<VideoIter>d__37 <VideoIter>d__ = new RecommendPack.<VideoIter>d__37(-2);
			<VideoIter>d__.<>3__<>4__this = this;
			return <VideoIter>d__;
		}

		// Token: 0x04005075 RID: 20597
		private Table __p;
	}
}
