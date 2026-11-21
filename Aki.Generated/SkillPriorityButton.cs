using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011BF RID: 4543
	public struct SkillPriorityButton : IFlatbufferObject
	{
		// Token: 0x170037FB RID: 14331
		// (get) Token: 0x0600DD33 RID: 56627 RVA: 0x003370E4 File Offset: 0x003352E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DD34 RID: 56628 RVA: 0x003370F1 File Offset: 0x003352F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DD35 RID: 56629 RVA: 0x003370F8 File Offset: 0x003352F8
		public static SkillPriorityButton GetRootAsSkillPriorityButton(ByteBuffer _bb)
		{
			return SkillPriorityButton.GetRootAsSkillPriorityButton(_bb, default(SkillPriorityButton));
		}

		// Token: 0x0600DD36 RID: 56630 RVA: 0x00337114 File Offset: 0x00335314
		public static SkillPriorityButton GetRootAsSkillPriorityButton(ByteBuffer _bb, SkillPriorityButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DD37 RID: 56631 RVA: 0x00337131 File Offset: 0x00335331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DD38 RID: 56632 RVA: 0x00337140 File Offset: 0x00335340
		public SkillPriorityButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037FC RID: 14332
		// (get) Token: 0x0600DD39 RID: 56633 RVA: 0x00337150 File Offset: 0x00335350
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

		// Token: 0x170037FD RID: 14333
		// (get) Token: 0x0600DD3A RID: 56634 RVA: 0x0033718C File Offset: 0x0033538C
		public int ButtonType
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

		// Token: 0x170037FE RID: 14334
		// (get) Token: 0x0600DD3B RID: 56635 RVA: 0x003371C8 File Offset: 0x003353C8
		public string Name
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

		// Token: 0x0600DD3C RID: 56636 RVA: 0x003371FF File Offset: 0x003353FF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DD3D RID: 56637 RVA: 0x0033720E File Offset: 0x0033540E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DD3E RID: 56638 RVA: 0x00337228 File Offset: 0x00335428
		public DicIntInt? SkillIdTagMap(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170037FF RID: 14335
		// (get) Token: 0x0600DD3F RID: 56639 RVA: 0x0033728C File Offset: 0x0033548C
		public int SkillIdTagMapLength
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

		// Token: 0x0600DD40 RID: 56640 RVA: 0x003372B8 File Offset: 0x003354B8
		public int SkillIconTags(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003800 RID: 14336
		// (get) Token: 0x0600DD41 RID: 56641 RVA: 0x003372F8 File Offset: 0x003354F8
		public int SkillIconTagsLength
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

		// Token: 0x0600DD42 RID: 56642 RVA: 0x00337324 File Offset: 0x00335524
		public Span<int> GetSkillIconTagsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600DD43 RID: 56643 RVA: 0x00337334 File Offset: 0x00335534
		public int[] GetSkillIconTagsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600DD44 RID: 56644 RVA: 0x0033734C File Offset: 0x0033554C
		public int DisableTags(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003801 RID: 14337
		// (get) Token: 0x0600DD45 RID: 56645 RVA: 0x0033738C File Offset: 0x0033558C
		public int DisableTagsLength
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

		// Token: 0x0600DD46 RID: 56646 RVA: 0x003373B8 File Offset: 0x003355B8
		public Span<int> GetDisableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600DD47 RID: 56647 RVA: 0x003373C8 File Offset: 0x003355C8
		public int[] GetDisableTagsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600DD48 RID: 56648 RVA: 0x003373E0 File Offset: 0x003355E0
		public DicIntIntArray? DisableSkillIdTags(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003802 RID: 14338
		// (get) Token: 0x0600DD49 RID: 56649 RVA: 0x00337444 File Offset: 0x00335644
		public int DisableSkillIdTagsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DD4A RID: 56650 RVA: 0x00337470 File Offset: 0x00335670
		public DicIntInt? DynamicEffectTagMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003803 RID: 14339
		// (get) Token: 0x0600DD4B RID: 56651 RVA: 0x003374D4 File Offset: 0x003356D4
		public int DynamicEffectTagMapLength
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

		// Token: 0x0600DD4C RID: 56652 RVA: 0x00337500 File Offset: 0x00335700
		[NullableContext(1)]
		public Dictionary<int, IntArray> DisableSkillIdTags()
		{
			return this.DisableSkillIdTagsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600DD4D RID: 56653 RVA: 0x00337556 File Offset: 0x00335756
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> DisableSkillIdTagsIter()
		{
			SkillPriorityButton.<DisableSkillIdTagsIter>d__36 <DisableSkillIdTagsIter>d__ = new SkillPriorityButton.<DisableSkillIdTagsIter>d__36(-2);
			<DisableSkillIdTagsIter>d__.<>3__<>4__this = this;
			return <DisableSkillIdTagsIter>d__;
		}

		// Token: 0x0600DD4E RID: 56654 RVA: 0x0033756B File Offset: 0x0033576B
		[NullableContext(1)]
		public int[] DisableTags()
		{
			return this.GetDisableTagsArray();
		}

		// Token: 0x0600DD4F RID: 56655 RVA: 0x00337573 File Offset: 0x00335773
		[NullableContext(1)]
		public IEnumerable<int> DisableTagsIter()
		{
			SkillPriorityButton.<DisableTagsIter>d__38 <DisableTagsIter>d__ = new SkillPriorityButton.<DisableTagsIter>d__38(-2);
			<DisableTagsIter>d__.<>3__<>4__this = this;
			return <DisableTagsIter>d__;
		}

		// Token: 0x0600DD50 RID: 56656 RVA: 0x00337588 File Offset: 0x00335788
		[NullableContext(1)]
		public Dictionary<int, int> DynamicEffectTagMap()
		{
			return this.DynamicEffectTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DD51 RID: 56657 RVA: 0x003375DE File Offset: 0x003357DE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DynamicEffectTagMapIter()
		{
			SkillPriorityButton.<DynamicEffectTagMapIter>d__40 <DynamicEffectTagMapIter>d__ = new SkillPriorityButton.<DynamicEffectTagMapIter>d__40(-2);
			<DynamicEffectTagMapIter>d__.<>3__<>4__this = this;
			return <DynamicEffectTagMapIter>d__;
		}

		// Token: 0x0600DD52 RID: 56658 RVA: 0x003375F3 File Offset: 0x003357F3
		[NullableContext(1)]
		public int[] SkillIconTags()
		{
			return this.GetSkillIconTagsArray();
		}

		// Token: 0x0600DD53 RID: 56659 RVA: 0x003375FB File Offset: 0x003357FB
		[NullableContext(1)]
		public IEnumerable<int> SkillIconTagsIter()
		{
			SkillPriorityButton.<SkillIconTagsIter>d__42 <SkillIconTagsIter>d__ = new SkillPriorityButton.<SkillIconTagsIter>d__42(-2);
			<SkillIconTagsIter>d__.<>3__<>4__this = this;
			return <SkillIconTagsIter>d__;
		}

		// Token: 0x0600DD54 RID: 56660 RVA: 0x00337610 File Offset: 0x00335810
		[NullableContext(1)]
		public Dictionary<int, int> SkillIdTagMap()
		{
			return this.SkillIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DD55 RID: 56661 RVA: 0x00337666 File Offset: 0x00335866
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SkillIdTagMapIter()
		{
			SkillPriorityButton.<SkillIdTagMapIter>d__44 <SkillIdTagMapIter>d__ = new SkillPriorityButton.<SkillIdTagMapIter>d__44(-2);
			<SkillIdTagMapIter>d__.<>3__<>4__this = this;
			return <SkillIdTagMapIter>d__;
		}

		// Token: 0x0600DD56 RID: 56662 RVA: 0x0033767C File Offset: 0x0033587C
		public IntArray? GetDisableSkillIdTags(int key)
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			IntArray value;
			if (!this.DisableSkillIdTagsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600DD57 RID: 56663 RVA: 0x003376B0 File Offset: 0x003358B0
		public int? GetDynamicEffectTagMap(int key)
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			int value;
			if (!this.DynamicEffectTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DD58 RID: 56664 RVA: 0x003376E4 File Offset: 0x003358E4
		public int? GetSkillIdTagMap(int key)
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			int value;
			if (!this.SkillIdTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DD59 RID: 56665 RVA: 0x00337718 File Offset: 0x00335918
		private void EnsureDisableSkillIdTagsCacheIfNeeded()
		{
			if (this.DisableSkillIdTagsCache != null)
			{
				return;
			}
			this.DisableSkillIdTagsCache = this.DisableSkillIdTagsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600DD5A RID: 56666 RVA: 0x00337780 File Offset: 0x00335980
		private void EnsureDynamicEffectTagMapCacheIfNeeded()
		{
			if (this.DynamicEffectTagMapCache != null)
			{
				return;
			}
			this.DynamicEffectTagMapCache = this.DynamicEffectTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DD5B RID: 56667 RVA: 0x003377E8 File Offset: 0x003359E8
		private void EnsureSkillIdTagMapCacheIfNeeded()
		{
			if (this.SkillIdTagMapCache != null)
			{
				return;
			}
			this.SkillIdTagMapCache = this.SkillIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DD5C RID: 56668 RVA: 0x0033784E File Offset: 0x00335A4E
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetDisableSkillIdTagsFrozenDict()
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			return this.DisableSkillIdTagsCache;
		}

		// Token: 0x0600DD5D RID: 56669 RVA: 0x0033785C File Offset: 0x00335A5C
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDynamicEffectTagMapFrozenDict()
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			return this.DynamicEffectTagMapCache;
		}

		// Token: 0x0600DD5E RID: 56670 RVA: 0x0033786A File Offset: 0x00335A6A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSkillIdTagMapFrozenDict()
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			return this.SkillIdTagMapCache;
		}

		// Token: 0x040057ED RID: 22509
		private Table __p;

		// Token: 0x040057EE RID: 22510
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DisableSkillIdTagsCache;

		// Token: 0x040057EF RID: 22511
		[Nullable(2)]
		private FrozenDictionary<int, int> DynamicEffectTagMapCache;

		// Token: 0x040057F0 RID: 22512
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillIdTagMapCache;
	}
}
