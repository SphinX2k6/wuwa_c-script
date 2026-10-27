using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ACB RID: 2763
	public struct ActivitySign : IFlatbufferObject
	{
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060043BD RID: 17341 RVA: 0x001CCF68 File Offset: 0x001CB168
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x001CCF75 File Offset: 0x001CB175
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x001CCF7C File Offset: 0x001CB17C
		public static ActivitySign GetRootAsActivitySign(ByteBuffer _bb)
		{
			return ActivitySign.GetRootAsActivitySign(_bb, default(ActivitySign));
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x001CCF98 File Offset: 0x001CB198
		public static ActivitySign GetRootAsActivitySign(ByteBuffer _bb, ActivitySign obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x001CCFB5 File Offset: 0x001CB1B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x001CCFC4 File Offset: 0x001CB1C4
		public ActivitySign __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060043C3 RID: 17347 RVA: 0x001CCFD4 File Offset: 0x001CB1D4
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

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060043C4 RID: 17348 RVA: 0x001CD010 File Offset: 0x001CB210
		public int Type
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

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060043C5 RID: 17349 RVA: 0x001CD04C File Offset: 0x001CB24C
		public string PrefabResource
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

		// Token: 0x060043C6 RID: 17350 RVA: 0x001CD083 File Offset: 0x001CB283
		public Span<byte> GetPrefabResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x001CD092 File Offset: 0x001CB292
		public byte[] GetPrefabResourceArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x001CD0AC File Offset: 0x001CB2AC
		public OneItemConfig? SignRewards(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new OneItemConfig?(default(OneItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060043C9 RID: 17353 RVA: 0x001CD110 File Offset: 0x001CB310
		public int SignRewardsLength
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

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060043CA RID: 17354 RVA: 0x001CD13C File Offset: 0x001CB33C
		public int ImportantRewardIndex
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060043CB RID: 17355 RVA: 0x001CD17C File Offset: 0x001CB37C
		public string ImportantRewardIcon
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

		// Token: 0x060043CC RID: 17356 RVA: 0x001CD1B4 File Offset: 0x001CB3B4
		public Span<byte> GetImportantRewardIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x001CD1C4 File Offset: 0x001CB3C4
		public byte[] GetImportantRewardIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060043CE RID: 17358 RVA: 0x001CD1DC File Offset: 0x001CB3DC
		public int ImportantRewardType
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

		// Token: 0x060043CF RID: 17359 RVA: 0x001CD21C File Offset: 0x001CB41C
		public int PreviewList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060043D0 RID: 17360 RVA: 0x001CD25C File Offset: 0x001CB45C
		public int PreviewListLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x001CD288 File Offset: 0x001CB488
		public Span<int> GetPreviewListBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x001CD298 File Offset: 0x001CB498
		public int[] GetPreviewListArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060043D3 RID: 17363 RVA: 0x001CD2B0 File Offset: 0x001CB4B0
		public int FreeDropId
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

		// Token: 0x060043D4 RID: 17364 RVA: 0x001CD2F0 File Offset: 0x001CB4F0
		public int GrandRewardId(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060043D5 RID: 17365 RVA: 0x001CD330 File Offset: 0x001CB530
		public int GrandRewardIdLength
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

		// Token: 0x060043D6 RID: 17366 RVA: 0x001CD35C File Offset: 0x001CB55C
		public Span<int> GetGrandRewardIdBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x001CD36C File Offset: 0x001CB56C
		public int[] GetGrandRewardIdArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x001CD384 File Offset: 0x001CB584
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GrandRewardIdIter()或GetGrandRewardIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GrandRewardId()
		{
			ActivitySign activitySign = this;
			return activitySign.GetGrandRewardIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x001CD3A8 File Offset: 0x001CB5A8
		[NullableContext(1)]
		public readonly IEnumerable<int> GrandRewardIdIter()
		{
			ActivitySign.<GrandRewardIdIter>d__40 <GrandRewardIdIter>d__ = new ActivitySign.<GrandRewardIdIter>d__40(-2);
			<GrandRewardIdIter>d__.<>3__<>4__this = this;
			return <GrandRewardIdIter>d__;
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x001CD3C0 File Offset: 0x001CB5C0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreviewListIter()或GetPreviewListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreviewList()
		{
			ActivitySign activitySign = this;
			return activitySign.GetPreviewListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x001CD3E4 File Offset: 0x001CB5E4
		[NullableContext(1)]
		public readonly IEnumerable<int> PreviewListIter()
		{
			ActivitySign.<PreviewListIter>d__42 <PreviewListIter>d__ = new ActivitySign.<PreviewListIter>d__42(-2);
			<PreviewListIter>d__.<>3__<>4__this = this;
			return <PreviewListIter>d__;
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x001CD3F9 File Offset: 0x001CB5F9
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SignRewardsIter()或GetSignRewardsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly OneItemConfig[] SignRewards()
		{
			return this.SignRewardsIter().ToArray<OneItemConfig>();
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x001CD406 File Offset: 0x001CB606
		[NullableContext(1)]
		public readonly IEnumerable<OneItemConfig> SignRewardsIter()
		{
			ActivitySign.<SignRewardsIter>d__44 <SignRewardsIter>d__ = new ActivitySign.<SignRewardsIter>d__44(-2);
			<SignRewardsIter>d__.<>3__<>4__this = this;
			return <SignRewardsIter>d__;
		}

		// Token: 0x04004AA8 RID: 19112
		private Table __p;
	}
}
