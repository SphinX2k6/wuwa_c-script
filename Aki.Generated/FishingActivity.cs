using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C74 RID: 3188
	public struct FishingActivity : IFlatbufferObject
	{
		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06006E9D RID: 28317 RVA: 0x0022F5B9 File Offset: 0x0022D7B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006E9E RID: 28318 RVA: 0x0022F5C6 File Offset: 0x0022D7C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006E9F RID: 28319 RVA: 0x0022F5D0 File Offset: 0x0022D7D0
		public static FishingActivity GetRootAsFishingActivity(ByteBuffer _bb)
		{
			return FishingActivity.GetRootAsFishingActivity(_bb, default(FishingActivity));
		}

		// Token: 0x06006EA0 RID: 28320 RVA: 0x0022F5EC File Offset: 0x0022D7EC
		public static FishingActivity GetRootAsFishingActivity(ByteBuffer _bb, FishingActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006EA1 RID: 28321 RVA: 0x0022F609 File Offset: 0x0022D809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006EA2 RID: 28322 RVA: 0x0022F618 File Offset: 0x0022D818
		public FishingActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06006EA3 RID: 28323 RVA: 0x0022F628 File Offset: 0x0022D828
		public int ActivityId
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

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06006EA4 RID: 28324 RVA: 0x0022F664 File Offset: 0x0022D864
		public int TimeQuantumId
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

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06006EA5 RID: 28325 RVA: 0x0022F6A0 File Offset: 0x0022D8A0
		public int MilestonItemId
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

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06006EA6 RID: 28326 RVA: 0x0022F6DC File Offset: 0x0022D8DC
		public int PreviewWeaponId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06006EA7 RID: 28327 RVA: 0x0022F71C File Offset: 0x0022D91C
		public int RecommendQuestId
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

		// Token: 0x06006EA8 RID: 28328 RVA: 0x0022F75C File Offset: 0x0022D95C
		public int RecommendQuestLinkList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06006EA9 RID: 28329 RVA: 0x0022F79C File Offset: 0x0022D99C
		public int RecommendQuestLinkListLength
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

		// Token: 0x06006EAA RID: 28330 RVA: 0x0022F7C8 File Offset: 0x0022D9C8
		public Span<int> GetRecommendQuestLinkListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06006EAB RID: 28331 RVA: 0x0022F7D8 File Offset: 0x0022D9D8
		public int[] GetRecommendQuestLinkListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06006EAC RID: 28332 RVA: 0x0022F7F0 File Offset: 0x0022D9F0
		public string RecommendQuestLabel
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

		// Token: 0x06006EAD RID: 28333 RVA: 0x0022F828 File Offset: 0x0022DA28
		public Span<byte> GetRecommendQuestLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x0022F838 File Offset: 0x0022DA38
		public byte[] GetRecommendQuestLabelArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x0022F850 File Offset: 0x0022DA50
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendQuestLinkListIter()或GetRecommendQuestLinkListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendQuestLinkList()
		{
			FishingActivity fishingActivity = this;
			return fishingActivity.GetRecommendQuestLinkListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006EB0 RID: 28336 RVA: 0x0022F874 File Offset: 0x0022DA74
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendQuestLinkListIter()
		{
			FishingActivity.<RecommendQuestLinkListIter>d__28 <RecommendQuestLinkListIter>d__ = new FishingActivity.<RecommendQuestLinkListIter>d__28(-2);
			<RecommendQuestLinkListIter>d__.<>3__<>4__this = this;
			return <RecommendQuestLinkListIter>d__;
		}

		// Token: 0x04004CBF RID: 19647
		private Table __p;
	}
}
