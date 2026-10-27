using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D5C RID: 3420
	public struct Influence : IFlatbufferObject
	{
		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x060082A6 RID: 33446 RVA: 0x0025D390 File Offset: 0x0025B590
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060082A7 RID: 33447 RVA: 0x0025D39D File Offset: 0x0025B59D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060082A8 RID: 33448 RVA: 0x0025D3A4 File Offset: 0x0025B5A4
		public static Influence GetRootAsInfluence(ByteBuffer _bb)
		{
			return Influence.GetRootAsInfluence(_bb, default(Influence));
		}

		// Token: 0x060082A9 RID: 33449 RVA: 0x0025D3C0 File Offset: 0x0025B5C0
		public static Influence GetRootAsInfluence(ByteBuffer _bb, Influence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060082AA RID: 33450 RVA: 0x0025D3DD File Offset: 0x0025B5DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060082AB RID: 33451 RVA: 0x0025D3EC File Offset: 0x0025B5EC
		public Influence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x060082AC RID: 33452 RVA: 0x0025D3FC File Offset: 0x0025B5FC
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

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x060082AD RID: 33453 RVA: 0x0025D438 File Offset: 0x0025B638
		public string Title
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

		// Token: 0x060082AE RID: 33454 RVA: 0x0025D46F File Offset: 0x0025B66F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060082AF RID: 33455 RVA: 0x0025D47E File Offset: 0x0025B67E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x060082B0 RID: 33456 RVA: 0x0025D498 File Offset: 0x0025B698
		public string Introduction
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

		// Token: 0x060082B1 RID: 33457 RVA: 0x0025D4CF File Offset: 0x0025B6CF
		public Span<byte> GetIntroductionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060082B2 RID: 33458 RVA: 0x0025D4DE File Offset: 0x0025B6DE
		public byte[] GetIntroductionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x060082B3 RID: 33459 RVA: 0x0025D4F8 File Offset: 0x0025B6F8
		public string ExtraDesc
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

		// Token: 0x060082B4 RID: 33460 RVA: 0x0025D530 File Offset: 0x0025B730
		public Span<byte> GetExtraDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060082B5 RID: 33461 RVA: 0x0025D540 File Offset: 0x0025B740
		public byte[] GetExtraDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x060082B6 RID: 33462 RVA: 0x0025D558 File Offset: 0x0025B758
		public int ShowIcon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x060082B7 RID: 33463 RVA: 0x0025D598 File Offset: 0x0025B798
		public string Logo
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

		// Token: 0x060082B8 RID: 33464 RVA: 0x0025D5D0 File Offset: 0x0025B7D0
		public Span<byte> GetLogoBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060082B9 RID: 33465 RVA: 0x0025D5E0 File Offset: 0x0025B7E0
		public byte[] GetLogoArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x060082BA RID: 33466 RVA: 0x0025D5F8 File Offset: 0x0025B7F8
		public int DailyTaskShow
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x060082BB RID: 33467 RVA: 0x0025D638 File Offset: 0x0025B838
		public int RawRelation
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x060082BC RID: 33468 RVA: 0x0025D678 File Offset: 0x0025B878
		public int RelationCondition
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

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x060082BD RID: 33469 RVA: 0x0025D6B8 File Offset: 0x0025B8B8
		public int LastRelation
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

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x060082BE RID: 33470 RVA: 0x0025D6F8 File Offset: 0x0025B8F8
		public int ReputationMax
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060082BF RID: 33471 RVA: 0x0025D73C File Offset: 0x0025B93C
		public IntPair? ReputationItem(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x060082C0 RID: 33472 RVA: 0x0025D7A0 File Offset: 0x0025B9A0
		public int ReputationItemLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060082C1 RID: 33473 RVA: 0x0025D7CC File Offset: 0x0025B9CC
		public IntPair? ReputationReward(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x060082C2 RID: 33474 RVA: 0x0025D830 File Offset: 0x0025BA30
		public int ReputationRewardLength
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

		// Token: 0x060082C3 RID: 33475 RVA: 0x0025D85C File Offset: 0x0025BA5C
		public int PartyTags(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x060082C4 RID: 33476 RVA: 0x0025D89C File Offset: 0x0025BA9C
		public int PartyTagsLength
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

		// Token: 0x060082C5 RID: 33477 RVA: 0x0025D8C8 File Offset: 0x0025BAC8
		public Span<int> GetPartyTagsBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x060082C6 RID: 33478 RVA: 0x0025D8D8 File Offset: 0x0025BAD8
		public int[] GetPartyTagsArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x060082C7 RID: 33479 RVA: 0x0025D8F0 File Offset: 0x0025BAF0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PartyTagsIter()或GetPartyTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PartyTags()
		{
			Influence influence = this;
			return influence.GetPartyTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060082C8 RID: 33480 RVA: 0x0025D914 File Offset: 0x0025BB14
		[NullableContext(1)]
		public readonly IEnumerable<int> PartyTagsIter()
		{
			Influence.<PartyTagsIter>d__50 <PartyTagsIter>d__ = new Influence.<PartyTagsIter>d__50(-2);
			<PartyTagsIter>d__.<>3__<>4__this = this;
			return <PartyTagsIter>d__;
		}

		// Token: 0x060082C9 RID: 33481 RVA: 0x0025D929 File Offset: 0x0025BB29
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ReputationItemIter()或GetReputationItemBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntPair[] ReputationItem()
		{
			return this.ReputationItemIter().ToArray<IntPair>();
		}

		// Token: 0x060082CA RID: 33482 RVA: 0x0025D936 File Offset: 0x0025BB36
		[NullableContext(1)]
		public readonly IEnumerable<IntPair> ReputationItemIter()
		{
			Influence.<ReputationItemIter>d__52 <ReputationItemIter>d__ = new Influence.<ReputationItemIter>d__52(-2);
			<ReputationItemIter>d__.<>3__<>4__this = this;
			return <ReputationItemIter>d__;
		}

		// Token: 0x060082CB RID: 33483 RVA: 0x0025D94B File Offset: 0x0025BB4B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ReputationRewardIter()或GetReputationRewardBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntPair[] ReputationReward()
		{
			return this.ReputationRewardIter().ToArray<IntPair>();
		}

		// Token: 0x060082CC RID: 33484 RVA: 0x0025D958 File Offset: 0x0025BB58
		[NullableContext(1)]
		public readonly IEnumerable<IntPair> ReputationRewardIter()
		{
			Influence.<ReputationRewardIter>d__54 <ReputationRewardIter>d__ = new Influence.<ReputationRewardIter>d__54(-2);
			<ReputationRewardIter>d__.<>3__<>4__this = this;
			return <ReputationRewardIter>d__;
		}

		// Token: 0x04004DDB RID: 19931
		private Table __p;
	}
}
