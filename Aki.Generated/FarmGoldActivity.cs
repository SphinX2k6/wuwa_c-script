using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C5A RID: 3162
	public struct FarmGoldActivity : IFlatbufferObject
	{
		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x06006C77 RID: 27767 RVA: 0x0022AA70 File Offset: 0x00228C70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006C78 RID: 27768 RVA: 0x0022AA7D File Offset: 0x00228C7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006C79 RID: 27769 RVA: 0x0022AA84 File Offset: 0x00228C84
		public static FarmGoldActivity GetRootAsFarmGoldActivity(ByteBuffer _bb)
		{
			return FarmGoldActivity.GetRootAsFarmGoldActivity(_bb, default(FarmGoldActivity));
		}

		// Token: 0x06006C7A RID: 27770 RVA: 0x0022AAA0 File Offset: 0x00228CA0
		public static FarmGoldActivity GetRootAsFarmGoldActivity(ByteBuffer _bb, FarmGoldActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006C7B RID: 27771 RVA: 0x0022AABD File Offset: 0x00228CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006C7C RID: 27772 RVA: 0x0022AACC File Offset: 0x00228CCC
		public FarmGoldActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x06006C7D RID: 27773 RVA: 0x0022AADC File Offset: 0x00228CDC
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

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x06006C7E RID: 27774 RVA: 0x0022AB18 File Offset: 0x00228D18
		public int ActivityId
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

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x06006C7F RID: 27775 RVA: 0x0022AB54 File Offset: 0x00228D54
		public int InstId
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

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x06006C80 RID: 27776 RVA: 0x0022AB90 File Offset: 0x00228D90
		public int EntranceId
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

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06006C81 RID: 27777 RVA: 0x0022ABD0 File Offset: 0x00228DD0
		public int GroupId
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

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06006C82 RID: 27778 RVA: 0x0022AC10 File Offset: 0x00228E10
		public int SortId
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

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06006C83 RID: 27779 RVA: 0x0022AC50 File Offset: 0x00228E50
		public int PassScore
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06006C84 RID: 27780 RVA: 0x0022AC90 File Offset: 0x00228E90
		public string LevelRewardDesc
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

		// Token: 0x06006C85 RID: 27781 RVA: 0x0022ACC8 File Offset: 0x00228EC8
		public Span<byte> GetLevelRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006C86 RID: 27782 RVA: 0x0022ACD8 File Offset: 0x00228ED8
		public byte[] GetLevelRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06006C87 RID: 27783 RVA: 0x0022ACF0 File Offset: 0x00228EF0
		public int RewardId
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

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06006C88 RID: 27784 RVA: 0x0022AD30 File Offset: 0x00228F30
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06006C89 RID: 27785 RVA: 0x0022AD70 File Offset: 0x00228F70
		public int PreLevel
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06006C8A RID: 27786 RVA: 0x0022ADB0 File Offset: 0x00228FB0
		public int RecommendLevel
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

		// Token: 0x06006C8B RID: 27787 RVA: 0x0022ADF0 File Offset: 0x00228FF0
		public int DifficultyOptions(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06006C8C RID: 27788 RVA: 0x0022AE30 File Offset: 0x00229030
		public int DifficultyOptionsLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006C8D RID: 27789 RVA: 0x0022AE5C File Offset: 0x0022905C
		public Span<int> GetDifficultyOptionsBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06006C8E RID: 27790 RVA: 0x0022AE6C File Offset: 0x0022906C
		public int[] GetDifficultyOptionsArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x06006C8F RID: 27791 RVA: 0x0022AE84 File Offset: 0x00229084
		public int RecommendTagIds(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06006C90 RID: 27792 RVA: 0x0022AEC4 File Offset: 0x002290C4
		public int RecommendTagIdsLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x0022AEF0 File Offset: 0x002290F0
		public Span<int> GetRecommendTagIdsBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x0022AF00 File Offset: 0x00229100
		public int[] GetRecommendTagIdsArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x06006C93 RID: 27795 RVA: 0x0022AF18 File Offset: 0x00229118
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DifficultyOptionsIter()或GetDifficultyOptionsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DifficultyOptions()
		{
			FarmGoldActivity farmGoldActivity = this;
			return farmGoldActivity.GetDifficultyOptionsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006C94 RID: 27796 RVA: 0x0022AF3C File Offset: 0x0022913C
		[NullableContext(1)]
		public readonly IEnumerable<int> DifficultyOptionsIter()
		{
			FarmGoldActivity.<DifficultyOptionsIter>d__45 <DifficultyOptionsIter>d__ = new FarmGoldActivity.<DifficultyOptionsIter>d__45(-2);
			<DifficultyOptionsIter>d__.<>3__<>4__this = this;
			return <DifficultyOptionsIter>d__;
		}

		// Token: 0x06006C95 RID: 27797 RVA: 0x0022AF54 File Offset: 0x00229154
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendTagIdsIter()或GetRecommendTagIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendTagIds()
		{
			FarmGoldActivity farmGoldActivity = this;
			return farmGoldActivity.GetRecommendTagIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006C96 RID: 27798 RVA: 0x0022AF78 File Offset: 0x00229178
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendTagIdsIter()
		{
			FarmGoldActivity.<RecommendTagIdsIter>d__47 <RecommendTagIdsIter>d__ = new FarmGoldActivity.<RecommendTagIdsIter>d__47(-2);
			<RecommendTagIdsIter>d__.<>3__<>4__this = this;
			return <RecommendTagIdsIter>d__;
		}

		// Token: 0x04004CA5 RID: 19621
		private Table __p;
	}
}
