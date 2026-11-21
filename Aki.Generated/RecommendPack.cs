using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200108A RID: 4234
	public struct RecommendPack : IFlatbufferObject
	{
		// Token: 0x17002DD4 RID: 11732
		// (get) Token: 0x0600C051 RID: 49233 RVA: 0x002F63B2 File Offset: 0x002F45B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C052 RID: 49234 RVA: 0x002F63BF File Offset: 0x002F45BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C053 RID: 49235 RVA: 0x002F63C8 File Offset: 0x002F45C8
		public static RecommendPack GetRootAsRecommendPack(ByteBuffer _bb)
		{
			return RecommendPack.GetRootAsRecommendPack(_bb, default(RecommendPack));
		}

		// Token: 0x0600C054 RID: 49236 RVA: 0x002F63E4 File Offset: 0x002F45E4
		public static RecommendPack GetRootAsRecommendPack(ByteBuffer _bb, RecommendPack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C055 RID: 49237 RVA: 0x002F6401 File Offset: 0x002F4601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C056 RID: 49238 RVA: 0x002F6410 File Offset: 0x002F4610
		public RecommendPack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DD5 RID: 11733
		// (get) Token: 0x0600C057 RID: 49239 RVA: 0x002F6420 File Offset: 0x002F4620
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

		// Token: 0x0600C058 RID: 49240 RVA: 0x002F645C File Offset: 0x002F465C
		public int FinishQuest(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DD6 RID: 11734
		// (get) Token: 0x0600C059 RID: 49241 RVA: 0x002F649C File Offset: 0x002F469C
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

		// Token: 0x0600C05A RID: 49242 RVA: 0x002F64C7 File Offset: 0x002F46C7
		public Span<int> GetFinishQuestBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600C05B RID: 49243 RVA: 0x002F64D6 File Offset: 0x002F46D6
		public int[] GetFinishQuestArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600C05C RID: 49244 RVA: 0x002F64F0 File Offset: 0x002F46F0
		public int UnfinishQuest(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DD7 RID: 11735
		// (get) Token: 0x0600C05D RID: 49245 RVA: 0x002F6530 File Offset: 0x002F4730
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

		// Token: 0x0600C05E RID: 49246 RVA: 0x002F655B File Offset: 0x002F475B
		public Span<int> GetUnfinishQuestBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C05F RID: 49247 RVA: 0x002F656A File Offset: 0x002F476A
		public int[] GetUnfinishQuestArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600C060 RID: 49248 RVA: 0x002F6584 File Offset: 0x002F4784
		public int Source(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DD8 RID: 11736
		// (get) Token: 0x0600C061 RID: 49249 RVA: 0x002F65C4 File Offset: 0x002F47C4
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

		// Token: 0x0600C062 RID: 49250 RVA: 0x002F65F0 File Offset: 0x002F47F0
		public Span<int> GetSourceBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C063 RID: 49251 RVA: 0x002F6600 File Offset: 0x002F4800
		public int[] GetSourceArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600C064 RID: 49252 RVA: 0x002F6618 File Offset: 0x002F4818
		public int Video(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DD9 RID: 11737
		// (get) Token: 0x0600C065 RID: 49253 RVA: 0x002F6658 File Offset: 0x002F4858
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

		// Token: 0x0600C066 RID: 49254 RVA: 0x002F6684 File Offset: 0x002F4884
		public Span<int> GetVideoBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600C067 RID: 49255 RVA: 0x002F6694 File Offset: 0x002F4894
		public int[] GetVideoArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600C068 RID: 49256 RVA: 0x002F66AC File Offset: 0x002F48AC
		[NullableContext(1)]
		public int[] FinishQuest()
		{
			return this.GetFinishQuestArray();
		}

		// Token: 0x0600C069 RID: 49257 RVA: 0x002F66B4 File Offset: 0x002F48B4
		[NullableContext(1)]
		public IEnumerable<int> FinishQuestIter()
		{
			RecommendPack.<FinishQuestIter>d__31 <FinishQuestIter>d__ = new RecommendPack.<FinishQuestIter>d__31(-2);
			<FinishQuestIter>d__.<>3__<>4__this = this;
			return <FinishQuestIter>d__;
		}

		// Token: 0x0600C06A RID: 49258 RVA: 0x002F66C9 File Offset: 0x002F48C9
		[NullableContext(1)]
		public int[] Source()
		{
			return this.GetSourceArray();
		}

		// Token: 0x0600C06B RID: 49259 RVA: 0x002F66D1 File Offset: 0x002F48D1
		[NullableContext(1)]
		public IEnumerable<int> SourceIter()
		{
			RecommendPack.<SourceIter>d__33 <SourceIter>d__ = new RecommendPack.<SourceIter>d__33(-2);
			<SourceIter>d__.<>3__<>4__this = this;
			return <SourceIter>d__;
		}

		// Token: 0x0600C06C RID: 49260 RVA: 0x002F66E6 File Offset: 0x002F48E6
		[NullableContext(1)]
		public int[] UnfinishQuest()
		{
			return this.GetUnfinishQuestArray();
		}

		// Token: 0x0600C06D RID: 49261 RVA: 0x002F66EE File Offset: 0x002F48EE
		[NullableContext(1)]
		public IEnumerable<int> UnfinishQuestIter()
		{
			RecommendPack.<UnfinishQuestIter>d__35 <UnfinishQuestIter>d__ = new RecommendPack.<UnfinishQuestIter>d__35(-2);
			<UnfinishQuestIter>d__.<>3__<>4__this = this;
			return <UnfinishQuestIter>d__;
		}

		// Token: 0x0600C06E RID: 49262 RVA: 0x002F6703 File Offset: 0x002F4903
		[NullableContext(1)]
		public int[] Video()
		{
			return this.GetVideoArray();
		}

		// Token: 0x0600C06F RID: 49263 RVA: 0x002F670B File Offset: 0x002F490B
		[NullableContext(1)]
		public IEnumerable<int> VideoIter()
		{
			RecommendPack.<VideoIter>d__37 <VideoIter>d__ = new RecommendPack.<VideoIter>d__37(-2);
			<VideoIter>d__.<>3__<>4__this = this;
			return <VideoIter>d__;
		}

		// Token: 0x0400565D RID: 22109
		private Table __p;
	}
}
