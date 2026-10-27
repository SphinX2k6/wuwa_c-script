using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C4 RID: 4292
	public struct SkillPriorityButton : IFlatbufferObject
	{
		// Token: 0x170036EA RID: 14058
		// (get) Token: 0x0600D556 RID: 54614 RVA: 0x00317F60 File Offset: 0x00316160
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D557 RID: 54615 RVA: 0x00317F6D File Offset: 0x0031616D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D558 RID: 54616 RVA: 0x00317F74 File Offset: 0x00316174
		public static SkillPriorityButton GetRootAsSkillPriorityButton(ByteBuffer _bb)
		{
			return SkillPriorityButton.GetRootAsSkillPriorityButton(_bb, default(SkillPriorityButton));
		}

		// Token: 0x0600D559 RID: 54617 RVA: 0x00317F90 File Offset: 0x00316190
		public static SkillPriorityButton GetRootAsSkillPriorityButton(ByteBuffer _bb, SkillPriorityButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D55A RID: 54618 RVA: 0x00317FAD File Offset: 0x003161AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D55B RID: 54619 RVA: 0x00317FBC File Offset: 0x003161BC
		public SkillPriorityButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036EB RID: 14059
		// (get) Token: 0x0600D55C RID: 54620 RVA: 0x00317FCC File Offset: 0x003161CC
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

		// Token: 0x170036EC RID: 14060
		// (get) Token: 0x0600D55D RID: 54621 RVA: 0x00318008 File Offset: 0x00316208
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

		// Token: 0x170036ED RID: 14061
		// (get) Token: 0x0600D55E RID: 54622 RVA: 0x00318044 File Offset: 0x00316244
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

		// Token: 0x0600D55F RID: 54623 RVA: 0x0031807B File Offset: 0x0031627B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D560 RID: 54624 RVA: 0x0031808A File Offset: 0x0031628A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D561 RID: 54625 RVA: 0x003180A4 File Offset: 0x003162A4
		public DicIntInt? SkillIdTagMap(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036EE RID: 14062
		// (get) Token: 0x0600D562 RID: 54626 RVA: 0x00318108 File Offset: 0x00316308
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

		// Token: 0x0600D563 RID: 54627 RVA: 0x00318134 File Offset: 0x00316334
		public int SkillIconTags(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036EF RID: 14063
		// (get) Token: 0x0600D564 RID: 54628 RVA: 0x00318174 File Offset: 0x00316374
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

		// Token: 0x0600D565 RID: 54629 RVA: 0x003181A0 File Offset: 0x003163A0
		public Span<int> GetSkillIconTagsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600D566 RID: 54630 RVA: 0x003181B0 File Offset: 0x003163B0
		public int[] GetSkillIconTagsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600D567 RID: 54631 RVA: 0x003181C8 File Offset: 0x003163C8
		public int DisableTags(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036F0 RID: 14064
		// (get) Token: 0x0600D568 RID: 54632 RVA: 0x00318208 File Offset: 0x00316408
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

		// Token: 0x0600D569 RID: 54633 RVA: 0x00318234 File Offset: 0x00316434
		public Span<int> GetDisableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600D56A RID: 54634 RVA: 0x00318244 File Offset: 0x00316444
		public int[] GetDisableTagsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600D56B RID: 54635 RVA: 0x0031825C File Offset: 0x0031645C
		public DicIntIntArray? DisableSkillIdTags(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036F1 RID: 14065
		// (get) Token: 0x0600D56C RID: 54636 RVA: 0x003182C0 File Offset: 0x003164C0
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

		// Token: 0x0600D56D RID: 54637 RVA: 0x003182EC File Offset: 0x003164EC
		public DicIntInt? DynamicEffectTagMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036F2 RID: 14066
		// (get) Token: 0x0600D56E RID: 54638 RVA: 0x00318350 File Offset: 0x00316550
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

		// Token: 0x0600D56F RID: 54639 RVA: 0x0031837C File Offset: 0x0031657C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DisableSkillIdTagsFrozenDict()缓存字典，遍历请使用DisableSkillIdTagsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> DisableSkillIdTags()
		{
			return this.DisableSkillIdTagsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600D570 RID: 54640 RVA: 0x003183D2 File Offset: 0x003165D2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> DisableSkillIdTagsIter()
		{
			SkillPriorityButton.<DisableSkillIdTagsIter>d__36 <DisableSkillIdTagsIter>d__ = new SkillPriorityButton.<DisableSkillIdTagsIter>d__36(-2);
			<DisableSkillIdTagsIter>d__.<>3__<>4__this = this;
			return <DisableSkillIdTagsIter>d__;
		}

		// Token: 0x0600D571 RID: 54641 RVA: 0x003183E8 File Offset: 0x003165E8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DisableTagsIter()或GetDisableTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DisableTags()
		{
			SkillPriorityButton skillPriorityButton = this;
			return skillPriorityButton.GetDisableTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D572 RID: 54642 RVA: 0x0031840C File Offset: 0x0031660C
		[NullableContext(1)]
		public readonly IEnumerable<int> DisableTagsIter()
		{
			SkillPriorityButton.<DisableTagsIter>d__38 <DisableTagsIter>d__ = new SkillPriorityButton.<DisableTagsIter>d__38(-2);
			<DisableTagsIter>d__.<>3__<>4__this = this;
			return <DisableTagsIter>d__;
		}

		// Token: 0x0600D573 RID: 54643 RVA: 0x00318424 File Offset: 0x00316624
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DynamicEffectTagMapFrozenDict()缓存字典，遍历请使用DynamicEffectTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DynamicEffectTagMap()
		{
			return this.DynamicEffectTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D574 RID: 54644 RVA: 0x0031847A File Offset: 0x0031667A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DynamicEffectTagMapIter()
		{
			SkillPriorityButton.<DynamicEffectTagMapIter>d__40 <DynamicEffectTagMapIter>d__ = new SkillPriorityButton.<DynamicEffectTagMapIter>d__40(-2);
			<DynamicEffectTagMapIter>d__.<>3__<>4__this = this;
			return <DynamicEffectTagMapIter>d__;
		}

		// Token: 0x0600D575 RID: 54645 RVA: 0x00318490 File Offset: 0x00316690
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillIconTagsIter()或GetSkillIconTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillIconTags()
		{
			SkillPriorityButton skillPriorityButton = this;
			return skillPriorityButton.GetSkillIconTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D576 RID: 54646 RVA: 0x003184B4 File Offset: 0x003166B4
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillIconTagsIter()
		{
			SkillPriorityButton.<SkillIconTagsIter>d__42 <SkillIconTagsIter>d__ = new SkillPriorityButton.<SkillIconTagsIter>d__42(-2);
			<SkillIconTagsIter>d__.<>3__<>4__this = this;
			return <SkillIconTagsIter>d__;
		}

		// Token: 0x0600D577 RID: 54647 RVA: 0x003184CC File Offset: 0x003166CC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SkillIdTagMapFrozenDict()缓存字典，遍历请使用SkillIdTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SkillIdTagMap()
		{
			return this.SkillIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D578 RID: 54648 RVA: 0x00318522 File Offset: 0x00316722
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SkillIdTagMapIter()
		{
			SkillPriorityButton.<SkillIdTagMapIter>d__44 <SkillIdTagMapIter>d__ = new SkillPriorityButton.<SkillIdTagMapIter>d__44(-2);
			<SkillIdTagMapIter>d__.<>3__<>4__this = this;
			return <SkillIdTagMapIter>d__;
		}

		// Token: 0x0600D579 RID: 54649 RVA: 0x00318538 File Offset: 0x00316738
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

		// Token: 0x0600D57A RID: 54650 RVA: 0x0031856C File Offset: 0x0031676C
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

		// Token: 0x0600D57B RID: 54651 RVA: 0x003185A0 File Offset: 0x003167A0
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

		// Token: 0x0600D57C RID: 54652 RVA: 0x003185D4 File Offset: 0x003167D4
		private void EnsureDisableSkillIdTagsCacheIfNeeded()
		{
			if (this.DisableSkillIdTagsCache != null)
			{
				return;
			}
			this.DisableSkillIdTagsCache = this.DisableSkillIdTagsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600D57D RID: 54653 RVA: 0x0031863C File Offset: 0x0031683C
		private void EnsureDynamicEffectTagMapCacheIfNeeded()
		{
			if (this.DynamicEffectTagMapCache != null)
			{
				return;
			}
			this.DynamicEffectTagMapCache = this.DynamicEffectTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D57E RID: 54654 RVA: 0x003186A4 File Offset: 0x003168A4
		private void EnsureSkillIdTagMapCacheIfNeeded()
		{
			if (this.SkillIdTagMapCache != null)
			{
				return;
			}
			this.SkillIdTagMapCache = this.SkillIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D57F RID: 54655 RVA: 0x0031870A File Offset: 0x0031690A
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetDisableSkillIdTagsFrozenDict(int key)
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			return this.DisableSkillIdTagsCache;
		}

		// Token: 0x0600D580 RID: 54656 RVA: 0x00318718 File Offset: 0x00316918
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDynamicEffectTagMapFrozenDict(int key)
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			return this.DynamicEffectTagMapCache;
		}

		// Token: 0x0600D581 RID: 54657 RVA: 0x00318726 File Offset: 0x00316926
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSkillIdTagMapFrozenDict(int key)
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			return this.SkillIdTagMapCache;
		}

		// Token: 0x040051EE RID: 20974
		private Table __p;

		// Token: 0x040051EF RID: 20975
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DisableSkillIdTagsCache;

		// Token: 0x040051F0 RID: 20976
		[Nullable(2)]
		private FrozenDictionary<int, int> DynamicEffectTagMapCache;

		// Token: 0x040051F1 RID: 20977
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillIdTagMapCache;
	}
}
