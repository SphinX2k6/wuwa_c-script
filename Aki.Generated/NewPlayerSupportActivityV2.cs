using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E86 RID: 3718
	public struct NewPlayerSupportActivityV2 : IFlatbufferObject
	{
		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x06009EAD RID: 40621 RVA: 0x0029CAF4 File Offset: 0x0029ACF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009EAE RID: 40622 RVA: 0x0029CB01 File Offset: 0x0029AD01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009EAF RID: 40623 RVA: 0x0029CB08 File Offset: 0x0029AD08
		public static NewPlayerSupportActivityV2 GetRootAsNewPlayerSupportActivityV2(ByteBuffer _bb)
		{
			return NewPlayerSupportActivityV2.GetRootAsNewPlayerSupportActivityV2(_bb, default(NewPlayerSupportActivityV2));
		}

		// Token: 0x06009EB0 RID: 40624 RVA: 0x0029CB24 File Offset: 0x0029AD24
		public static NewPlayerSupportActivityV2 GetRootAsNewPlayerSupportActivityV2(ByteBuffer _bb, NewPlayerSupportActivityV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009EB1 RID: 40625 RVA: 0x0029CB41 File Offset: 0x0029AD41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009EB2 RID: 40626 RVA: 0x0029CB50 File Offset: 0x0029AD50
		public NewPlayerSupportActivityV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x06009EB3 RID: 40627 RVA: 0x0029CB60 File Offset: 0x0029AD60
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

		// Token: 0x17002316 RID: 8982
		// (get) Token: 0x06009EB4 RID: 40628 RVA: 0x0029CB9C File Offset: 0x0029AD9C
		public int ContinueDays
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

		// Token: 0x17002317 RID: 8983
		// (get) Token: 0x06009EB5 RID: 40629 RVA: 0x0029CBD8 File Offset: 0x0029ADD8
		public int LivenessContinueDays
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

		// Token: 0x06009EB6 RID: 40630 RVA: 0x0029CC14 File Offset: 0x0029AE14
		public int LivenessBonusItemId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002318 RID: 8984
		// (get) Token: 0x06009EB7 RID: 40631 RVA: 0x0029CC54 File Offset: 0x0029AE54
		public int LivenessBonusItemIdLength
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

		// Token: 0x06009EB8 RID: 40632 RVA: 0x0029CC80 File Offset: 0x0029AE80
		public Span<int> GetLivenessBonusItemIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009EB9 RID: 40633 RVA: 0x0029CC90 File Offset: 0x0029AE90
		public int[] GetLivenessBonusItemIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x06009EBA RID: 40634 RVA: 0x0029CCA8 File Offset: 0x0029AEA8
		public int LivenessTimes
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

		// Token: 0x06009EBB RID: 40635 RVA: 0x0029CCE8 File Offset: 0x0029AEE8
		public int PayGifts(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x06009EBC RID: 40636 RVA: 0x0029CD28 File Offset: 0x0029AF28
		public int PayGiftsLength
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

		// Token: 0x06009EBD RID: 40637 RVA: 0x0029CD54 File Offset: 0x0029AF54
		public Span<int> GetPayGiftsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06009EBE RID: 40638 RVA: 0x0029CD64 File Offset: 0x0029AF64
		public int[] GetPayGiftsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x06009EBF RID: 40639 RVA: 0x0029CD7C File Offset: 0x0029AF7C
		public int PayGiftsContinueDays
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

		// Token: 0x06009EC0 RID: 40640 RVA: 0x0029CDBC File Offset: 0x0029AFBC
		public int GachaIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x06009EC1 RID: 40641 RVA: 0x0029CDFC File Offset: 0x0029AFFC
		public int GachaIdsLength
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

		// Token: 0x06009EC2 RID: 40642 RVA: 0x0029CE28 File Offset: 0x0029B028
		public Span<int> GetGachaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06009EC3 RID: 40643 RVA: 0x0029CE38 File Offset: 0x0029B038
		public int[] GetGachaIdsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x06009EC4 RID: 40644 RVA: 0x0029CE50 File Offset: 0x0029B050
		public int GachaContinueDays
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

		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x06009EC5 RID: 40645 RVA: 0x0029CE90 File Offset: 0x0029B090
		public int WeekCardContinueDays
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

		// Token: 0x06009EC6 RID: 40646 RVA: 0x0029CED0 File Offset: 0x0029B0D0
		public int WeekCardIds(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x06009EC7 RID: 40647 RVA: 0x0029CF10 File Offset: 0x0029B110
		public int WeekCardIdsLength
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

		// Token: 0x06009EC8 RID: 40648 RVA: 0x0029CF3C File Offset: 0x0029B13C
		public Span<int> GetWeekCardIdsBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06009EC9 RID: 40649 RVA: 0x0029CF4C File Offset: 0x0029B14C
		public int[] GetWeekCardIdsArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06009ECA RID: 40650 RVA: 0x0029CF64 File Offset: 0x0029B164
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GachaIdsIter()或GetGachaIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GachaIds()
		{
			NewPlayerSupportActivityV2 newPlayerSupportActivityV = this;
			return newPlayerSupportActivityV.GetGachaIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009ECB RID: 40651 RVA: 0x0029CF88 File Offset: 0x0029B188
		[NullableContext(1)]
		public readonly IEnumerable<int> GachaIdsIter()
		{
			NewPlayerSupportActivityV2.<GachaIdsIter>d__43 <GachaIdsIter>d__ = new NewPlayerSupportActivityV2.<GachaIdsIter>d__43(-2);
			<GachaIdsIter>d__.<>3__<>4__this = this;
			return <GachaIdsIter>d__;
		}

		// Token: 0x06009ECC RID: 40652 RVA: 0x0029CFA0 File Offset: 0x0029B1A0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LivenessBonusItemIdIter()或GetLivenessBonusItemIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LivenessBonusItemId()
		{
			NewPlayerSupportActivityV2 newPlayerSupportActivityV = this;
			return newPlayerSupportActivityV.GetLivenessBonusItemIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009ECD RID: 40653 RVA: 0x0029CFC4 File Offset: 0x0029B1C4
		[NullableContext(1)]
		public readonly IEnumerable<int> LivenessBonusItemIdIter()
		{
			NewPlayerSupportActivityV2.<LivenessBonusItemIdIter>d__45 <LivenessBonusItemIdIter>d__ = new NewPlayerSupportActivityV2.<LivenessBonusItemIdIter>d__45(-2);
			<LivenessBonusItemIdIter>d__.<>3__<>4__this = this;
			return <LivenessBonusItemIdIter>d__;
		}

		// Token: 0x06009ECE RID: 40654 RVA: 0x0029CFDC File Offset: 0x0029B1DC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PayGiftsIter()或GetPayGiftsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PayGifts()
		{
			NewPlayerSupportActivityV2 newPlayerSupportActivityV = this;
			return newPlayerSupportActivityV.GetPayGiftsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009ECF RID: 40655 RVA: 0x0029D000 File Offset: 0x0029B200
		[NullableContext(1)]
		public readonly IEnumerable<int> PayGiftsIter()
		{
			NewPlayerSupportActivityV2.<PayGiftsIter>d__47 <PayGiftsIter>d__ = new NewPlayerSupportActivityV2.<PayGiftsIter>d__47(-2);
			<PayGiftsIter>d__.<>3__<>4__this = this;
			return <PayGiftsIter>d__;
		}

		// Token: 0x06009ED0 RID: 40656 RVA: 0x0029D018 File Offset: 0x0029B218
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WeekCardIdsIter()或GetWeekCardIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WeekCardIds()
		{
			NewPlayerSupportActivityV2 newPlayerSupportActivityV = this;
			return newPlayerSupportActivityV.GetWeekCardIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009ED1 RID: 40657 RVA: 0x0029D03C File Offset: 0x0029B23C
		[NullableContext(1)]
		public readonly IEnumerable<int> WeekCardIdsIter()
		{
			NewPlayerSupportActivityV2.<WeekCardIdsIter>d__49 <WeekCardIdsIter>d__ = new NewPlayerSupportActivityV2.<WeekCardIdsIter>d__49(-2);
			<WeekCardIdsIter>d__.<>3__<>4__this = this;
			return <WeekCardIdsIter>d__;
		}

		// Token: 0x04004F34 RID: 20276
		private Table __p;
	}
}
