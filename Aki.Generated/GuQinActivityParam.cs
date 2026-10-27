using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D1F RID: 3359
	public struct GuQinActivityParam : IFlatbufferObject
	{
		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06007D8B RID: 32139 RVA: 0x0025213A File Offset: 0x0025033A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007D8C RID: 32140 RVA: 0x00252147 File Offset: 0x00250347
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007D8D RID: 32141 RVA: 0x00252150 File Offset: 0x00250350
		public static GuQinActivityParam GetRootAsGuQinActivityParam(ByteBuffer _bb)
		{
			return GuQinActivityParam.GetRootAsGuQinActivityParam(_bb, default(GuQinActivityParam));
		}

		// Token: 0x06007D8E RID: 32142 RVA: 0x0025216C File Offset: 0x0025036C
		public static GuQinActivityParam GetRootAsGuQinActivityParam(ByteBuffer _bb, GuQinActivityParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007D8F RID: 32143 RVA: 0x00252189 File Offset: 0x00250389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007D90 RID: 32144 RVA: 0x00252198 File Offset: 0x00250398
		public GuQinActivityParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x06007D91 RID: 32145 RVA: 0x002521A8 File Offset: 0x002503A8
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

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x06007D92 RID: 32146 RVA: 0x002521E4 File Offset: 0x002503E4
		public int RecommendQuestId
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

		// Token: 0x06007D93 RID: 32147 RVA: 0x00252220 File Offset: 0x00250420
		public int RecommendQuestLinkList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x06007D94 RID: 32148 RVA: 0x00252260 File Offset: 0x00250460
		public int RecommendQuestLinkListLength
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

		// Token: 0x06007D95 RID: 32149 RVA: 0x0025228B File Offset: 0x0025048B
		public Span<int> GetRecommendQuestLinkListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007D96 RID: 32150 RVA: 0x0025229A File Offset: 0x0025049A
		public int[] GetRecommendQuestLinkListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x06007D97 RID: 32151 RVA: 0x002522B4 File Offset: 0x002504B4
		public string RecommendQuestLabel
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

		// Token: 0x06007D98 RID: 32152 RVA: 0x002522EC File Offset: 0x002504EC
		public Span<byte> GetRecommendQuestLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007D99 RID: 32153 RVA: 0x002522FC File Offset: 0x002504FC
		public byte[] GetRecommendQuestLabelArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06007D9A RID: 32154 RVA: 0x00252314 File Offset: 0x00250514
		public string MaleMontagePaths(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06007D9B RID: 32155 RVA: 0x00252350 File Offset: 0x00250550
		public int MaleMontagePathsLength
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

		// Token: 0x06007D9C RID: 32156 RVA: 0x0025237C File Offset: 0x0025057C
		public string FemaleMontagePaths(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06007D9D RID: 32157 RVA: 0x002523B8 File Offset: 0x002505B8
		public int FemaleMontagePathsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06007D9E RID: 32158 RVA: 0x002523E4 File Offset: 0x002505E4
		public string UiCameraId
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

		// Token: 0x06007D9F RID: 32159 RVA: 0x0025241C File Offset: 0x0025061C
		public Span<byte> GetUiCameraIdBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007DA0 RID: 32160 RVA: 0x0025242C File Offset: 0x0025062C
		public byte[] GetUiCameraIdArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06007DA1 RID: 32161 RVA: 0x00252444 File Offset: 0x00250644
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FemaleMontagePathsIter()或GetFemaleMontagePathsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FemaleMontagePaths()
		{
			return this.FemaleMontagePathsIter().ToArray<string>();
		}

		// Token: 0x06007DA2 RID: 32162 RVA: 0x00252451 File Offset: 0x00250651
		[NullableContext(1)]
		public readonly IEnumerable<string> FemaleMontagePathsIter()
		{
			GuQinActivityParam.<FemaleMontagePathsIter>d__32 <FemaleMontagePathsIter>d__ = new GuQinActivityParam.<FemaleMontagePathsIter>d__32(-2);
			<FemaleMontagePathsIter>d__.<>3__<>4__this = this;
			return <FemaleMontagePathsIter>d__;
		}

		// Token: 0x06007DA3 RID: 32163 RVA: 0x00252466 File Offset: 0x00250666
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MaleMontagePathsIter()或GetMaleMontagePathsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] MaleMontagePaths()
		{
			return this.MaleMontagePathsIter().ToArray<string>();
		}

		// Token: 0x06007DA4 RID: 32164 RVA: 0x00252473 File Offset: 0x00250673
		[NullableContext(1)]
		public readonly IEnumerable<string> MaleMontagePathsIter()
		{
			GuQinActivityParam.<MaleMontagePathsIter>d__34 <MaleMontagePathsIter>d__ = new GuQinActivityParam.<MaleMontagePathsIter>d__34(-2);
			<MaleMontagePathsIter>d__.<>3__<>4__this = this;
			return <MaleMontagePathsIter>d__;
		}

		// Token: 0x06007DA5 RID: 32165 RVA: 0x00252488 File Offset: 0x00250688
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendQuestLinkListIter()或GetRecommendQuestLinkListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendQuestLinkList()
		{
			GuQinActivityParam guQinActivityParam = this;
			return guQinActivityParam.GetRecommendQuestLinkListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007DA6 RID: 32166 RVA: 0x002524AC File Offset: 0x002506AC
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendQuestLinkListIter()
		{
			GuQinActivityParam.<RecommendQuestLinkListIter>d__36 <RecommendQuestLinkListIter>d__ = new GuQinActivityParam.<RecommendQuestLinkListIter>d__36(-2);
			<RecommendQuestLinkListIter>d__.<>3__<>4__this = this;
			return <RecommendQuestLinkListIter>d__;
		}

		// Token: 0x04004D97 RID: 19863
		private Table __p;
	}
}
