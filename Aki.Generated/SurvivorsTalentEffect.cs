using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001107 RID: 4359
	public struct SurvivorsTalentEffect : IFlatbufferObject
	{
		// Token: 0x1700392A RID: 14634
		// (get) Token: 0x0600DB72 RID: 56178 RVA: 0x003261F1 File Offset: 0x003243F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DB73 RID: 56179 RVA: 0x003261FE File Offset: 0x003243FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DB74 RID: 56180 RVA: 0x00326208 File Offset: 0x00324408
		public static SurvivorsTalentEffect GetRootAsSurvivorsTalentEffect(ByteBuffer _bb)
		{
			return SurvivorsTalentEffect.GetRootAsSurvivorsTalentEffect(_bb, default(SurvivorsTalentEffect));
		}

		// Token: 0x0600DB75 RID: 56181 RVA: 0x00326224 File Offset: 0x00324424
		public static SurvivorsTalentEffect GetRootAsSurvivorsTalentEffect(ByteBuffer _bb, SurvivorsTalentEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DB76 RID: 56182 RVA: 0x00326241 File Offset: 0x00324441
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DB77 RID: 56183 RVA: 0x00326250 File Offset: 0x00324450
		public SurvivorsTalentEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700392B RID: 14635
		// (get) Token: 0x0600DB78 RID: 56184 RVA: 0x00326260 File Offset: 0x00324460
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

		// Token: 0x1700392C RID: 14636
		// (get) Token: 0x0600DB79 RID: 56185 RVA: 0x0032629C File Offset: 0x0032449C
		public int Effect
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

		// Token: 0x0600DB7A RID: 56186 RVA: 0x003262D8 File Offset: 0x003244D8
		public DicIntInt? Consume(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700392D RID: 14637
		// (get) Token: 0x0600DB7B RID: 56187 RVA: 0x00326338 File Offset: 0x00324538
		public int ConsumeLength
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

		// Token: 0x1700392E RID: 14638
		// (get) Token: 0x0600DB7C RID: 56188 RVA: 0x00326364 File Offset: 0x00324564
		public int ShowType
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

		// Token: 0x0600DB7D RID: 56189 RVA: 0x003263A4 File Offset: 0x003245A4
		public int UnlockItem(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700392F RID: 14639
		// (get) Token: 0x0600DB7E RID: 56190 RVA: 0x003263E4 File Offset: 0x003245E4
		public int UnlockItemLength
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

		// Token: 0x0600DB7F RID: 56191 RVA: 0x00326410 File Offset: 0x00324610
		public Span<int> GetUnlockItemBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600DB80 RID: 56192 RVA: 0x00326420 File Offset: 0x00324620
		public int[] GetUnlockItemArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17003930 RID: 14640
		// (get) Token: 0x0600DB81 RID: 56193 RVA: 0x00326438 File Offset: 0x00324638
		public string Title
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

		// Token: 0x0600DB82 RID: 56194 RVA: 0x00326470 File Offset: 0x00324670
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DB83 RID: 56195 RVA: 0x00326480 File Offset: 0x00324680
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003931 RID: 14641
		// (get) Token: 0x0600DB84 RID: 56196 RVA: 0x00326498 File Offset: 0x00324698
		public string Tag
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

		// Token: 0x0600DB85 RID: 56197 RVA: 0x003264D0 File Offset: 0x003246D0
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600DB86 RID: 56198 RVA: 0x003264E0 File Offset: 0x003246E0
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003932 RID: 14642
		// (get) Token: 0x0600DB87 RID: 56199 RVA: 0x003264F8 File Offset: 0x003246F8
		public string Desc
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

		// Token: 0x0600DB88 RID: 56200 RVA: 0x00326530 File Offset: 0x00324730
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600DB89 RID: 56201 RVA: 0x00326540 File Offset: 0x00324740
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DB8A RID: 56202 RVA: 0x00326558 File Offset: 0x00324758
		public string DescParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003933 RID: 14643
		// (get) Token: 0x0600DB8B RID: 56203 RVA: 0x00326594 File Offset: 0x00324794
		public int DescParamsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DB8C RID: 56204 RVA: 0x003265C0 File Offset: 0x003247C0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConsumeFrozenDict()缓存字典，遍历请使用ConsumeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DB8D RID: 56205 RVA: 0x00326616 File Offset: 0x00324816
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConsumeIter()
		{
			SurvivorsTalentEffect.<ConsumeIter>d__38 <ConsumeIter>d__ = new SurvivorsTalentEffect.<ConsumeIter>d__38(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x0600DB8E RID: 56206 RVA: 0x0032662B File Offset: 0x0032482B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamsIter()或GetDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x0600DB8F RID: 56207 RVA: 0x00326638 File Offset: 0x00324838
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamsIter()
		{
			SurvivorsTalentEffect.<DescParamsIter>d__40 <DescParamsIter>d__ = new SurvivorsTalentEffect.<DescParamsIter>d__40(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x0600DB90 RID: 56208 RVA: 0x00326650 File Offset: 0x00324850
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnlockItemIter()或GetUnlockItemBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnlockItem()
		{
			SurvivorsTalentEffect survivorsTalentEffect = this;
			return survivorsTalentEffect.GetUnlockItemArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DB91 RID: 56209 RVA: 0x00326674 File Offset: 0x00324874
		[NullableContext(1)]
		public readonly IEnumerable<int> UnlockItemIter()
		{
			SurvivorsTalentEffect.<UnlockItemIter>d__42 <UnlockItemIter>d__ = new SurvivorsTalentEffect.<UnlockItemIter>d__42(-2);
			<UnlockItemIter>d__.<>3__<>4__this = this;
			return <UnlockItemIter>d__;
		}

		// Token: 0x0600DB92 RID: 56210 RVA: 0x0032668C File Offset: 0x0032488C
		public int? GetConsume(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			int value;
			if (!this.ConsumeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DB93 RID: 56211 RVA: 0x003266C0 File Offset: 0x003248C0
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DB94 RID: 56212 RVA: 0x00326726 File Offset: 0x00324926
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x04005240 RID: 21056
		private Table __p;

		// Token: 0x04005241 RID: 21057
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;
	}
}
