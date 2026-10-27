using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C4A RID: 3146
	public struct ExploreActivity : IFlatbufferObject
	{
		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06006AFC RID: 27388 RVA: 0x00227348 File Offset: 0x00225548
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006AFD RID: 27389 RVA: 0x00227355 File Offset: 0x00225555
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006AFE RID: 27390 RVA: 0x0022735C File Offset: 0x0022555C
		public static ExploreActivity GetRootAsExploreActivity(ByteBuffer _bb)
		{
			return ExploreActivity.GetRootAsExploreActivity(_bb, default(ExploreActivity));
		}

		// Token: 0x06006AFF RID: 27391 RVA: 0x00227378 File Offset: 0x00225578
		public static ExploreActivity GetRootAsExploreActivity(ByteBuffer _bb, ExploreActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006B00 RID: 27392 RVA: 0x00227395 File Offset: 0x00225595
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006B01 RID: 27393 RVA: 0x002273A4 File Offset: 0x002255A4
		public ExploreActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06006B02 RID: 27394 RVA: 0x002273B4 File Offset: 0x002255B4
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

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06006B03 RID: 27395 RVA: 0x002273F0 File Offset: 0x002255F0
		public string Bg
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

		// Token: 0x06006B04 RID: 27396 RVA: 0x00227427 File Offset: 0x00225627
		public Span<byte> GetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006B05 RID: 27397 RVA: 0x00227436 File Offset: 0x00225636
		public byte[] GetBgArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06006B06 RID: 27398 RVA: 0x00227450 File Offset: 0x00225650
		public string ExploreTitle
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

		// Token: 0x06006B07 RID: 27399 RVA: 0x00227487 File Offset: 0x00225687
		public Span<byte> GetExploreTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006B08 RID: 27400 RVA: 0x00227496 File Offset: 0x00225696
		public byte[] GetExploreTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06006B09 RID: 27401 RVA: 0x002274B0 File Offset: 0x002256B0
		public string PercentDesc
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

		// Token: 0x06006B0A RID: 27402 RVA: 0x002274E8 File Offset: 0x002256E8
		public Span<byte> GetPercentDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006B0B RID: 27403 RVA: 0x002274F8 File Offset: 0x002256F8
		public byte[] GetPercentDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06006B0C RID: 27404 RVA: 0x00227510 File Offset: 0x00225710
		public string AreaTitle
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006B0D RID: 27405 RVA: 0x00227548 File Offset: 0x00225748
		public Span<byte> GetAreaTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006B0E RID: 27406 RVA: 0x00227558 File Offset: 0x00225758
		public byte[] GetAreaTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06006B0F RID: 27407 RVA: 0x00227570 File Offset: 0x00225770
		public string MainTitle
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

		// Token: 0x06006B10 RID: 27408 RVA: 0x002275A8 File Offset: 0x002257A8
		public Span<byte> GetMainTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006B11 RID: 27409 RVA: 0x002275B8 File Offset: 0x002257B8
		public byte[] GetMainTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06006B12 RID: 27410 RVA: 0x002275D0 File Offset: 0x002257D0
		public string Desc
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

		// Token: 0x06006B13 RID: 27411 RVA: 0x00227608 File Offset: 0x00225808
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006B14 RID: 27412 RVA: 0x00227618 File Offset: 0x00225818
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06006B15 RID: 27413 RVA: 0x00227630 File Offset: 0x00225830
		public string SumRewardDesc
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006B16 RID: 27414 RVA: 0x00227668 File Offset: 0x00225868
		public Span<byte> GetSumRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006B17 RID: 27415 RVA: 0x00227678 File Offset: 0x00225878
		public byte[] GetSumRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06006B18 RID: 27416 RVA: 0x00227690 File Offset: 0x00225890
		public int SumRewardNum
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006B19 RID: 27417 RVA: 0x002276D0 File Offset: 0x002258D0
		public int RecommendAreaList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06006B1A RID: 27418 RVA: 0x00227710 File Offset: 0x00225910
		public int RecommendAreaListLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006B1B RID: 27419 RVA: 0x0022773C File Offset: 0x0022593C
		public Span<int> GetRecommendAreaListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06006B1C RID: 27420 RVA: 0x0022774C File Offset: 0x0022594C
		public int[] GetRecommendAreaListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06006B1D RID: 27421 RVA: 0x00227764 File Offset: 0x00225964
		public int SourceList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06006B1E RID: 27422 RVA: 0x002277A4 File Offset: 0x002259A4
		public int SourceListLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006B1F RID: 27423 RVA: 0x002277D0 File Offset: 0x002259D0
		public Span<int> GetSourceListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06006B20 RID: 27424 RVA: 0x002277E0 File Offset: 0x002259E0
		public int[] GetSourceListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x06006B21 RID: 27425 RVA: 0x002277F8 File Offset: 0x002259F8
		public int IsNewPrefab
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006B22 RID: 27426 RVA: 0x00227838 File Offset: 0x00225A38
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendAreaListIter()或GetRecommendAreaListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendAreaList()
		{
			ExploreActivity exploreActivity = this;
			return exploreActivity.GetRecommendAreaListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006B23 RID: 27427 RVA: 0x0022785C File Offset: 0x00225A5C
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendAreaListIter()
		{
			ExploreActivity.<RecommendAreaListIter>d__53 <RecommendAreaListIter>d__ = new ExploreActivity.<RecommendAreaListIter>d__53(-2);
			<RecommendAreaListIter>d__.<>3__<>4__this = this;
			return <RecommendAreaListIter>d__;
		}

		// Token: 0x06006B24 RID: 27428 RVA: 0x00227874 File Offset: 0x00225A74
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SourceListIter()或GetSourceListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SourceList()
		{
			ExploreActivity exploreActivity = this;
			return exploreActivity.GetSourceListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006B25 RID: 27429 RVA: 0x00227898 File Offset: 0x00225A98
		[NullableContext(1)]
		public readonly IEnumerable<int> SourceListIter()
		{
			ExploreActivity.<SourceListIter>d__55 <SourceListIter>d__ = new ExploreActivity.<SourceListIter>d__55(-2);
			<SourceListIter>d__.<>3__<>4__this = this;
			return <SourceListIter>d__;
		}

		// Token: 0x04004C8F RID: 19599
		private Table __p;
	}
}
