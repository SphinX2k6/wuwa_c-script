using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D44 RID: 3396
	public struct HonamiStoryPluginSlot : IFlatbufferObject
	{
		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x060080B3 RID: 32947 RVA: 0x002590D4 File Offset: 0x002572D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060080B4 RID: 32948 RVA: 0x002590E1 File Offset: 0x002572E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060080B5 RID: 32949 RVA: 0x002590E8 File Offset: 0x002572E8
		public static HonamiStoryPluginSlot GetRootAsHonamiStoryPluginSlot(ByteBuffer _bb)
		{
			return HonamiStoryPluginSlot.GetRootAsHonamiStoryPluginSlot(_bb, default(HonamiStoryPluginSlot));
		}

		// Token: 0x060080B6 RID: 32950 RVA: 0x00259104 File Offset: 0x00257304
		public static HonamiStoryPluginSlot GetRootAsHonamiStoryPluginSlot(ByteBuffer _bb, HonamiStoryPluginSlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060080B7 RID: 32951 RVA: 0x00259121 File Offset: 0x00257321
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060080B8 RID: 32952 RVA: 0x00259130 File Offset: 0x00257330
		public HonamiStoryPluginSlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x060080B9 RID: 32953 RVA: 0x00259140 File Offset: 0x00257340
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

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x060080BA RID: 32954 RVA: 0x0025917C File Offset: 0x0025737C
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

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x060080BB RID: 32955 RVA: 0x002591B8 File Offset: 0x002573B8
		public int SlotPos
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

		// Token: 0x060080BC RID: 32956 RVA: 0x002591F4 File Offset: 0x002573F4
		public DicIntInt? ConsumeItems(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x060080BD RID: 32957 RVA: 0x00259258 File Offset: 0x00257458
		public int ConsumeItemsLength
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

		// Token: 0x060080BE RID: 32958 RVA: 0x00259284 File Offset: 0x00257484
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConsumeItemsFrozenDict()缓存字典，遍历请使用ConsumeItemsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ConsumeItems()
		{
			return this.ConsumeItemsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060080BF RID: 32959 RVA: 0x002592DA File Offset: 0x002574DA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConsumeItemsIter()
		{
			HonamiStoryPluginSlot.<ConsumeItemsIter>d__18 <ConsumeItemsIter>d__ = new HonamiStoryPluginSlot.<ConsumeItemsIter>d__18(-2);
			<ConsumeItemsIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIter>d__;
		}

		// Token: 0x060080C0 RID: 32960 RVA: 0x002592F0 File Offset: 0x002574F0
		public int? GetConsumeItems(int key)
		{
			this.EnsureConsumeItemsCacheIfNeeded();
			int value;
			if (!this.ConsumeItemsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060080C1 RID: 32961 RVA: 0x00259324 File Offset: 0x00257524
		private void EnsureConsumeItemsCacheIfNeeded()
		{
			if (this.ConsumeItemsCache != null)
			{
				return;
			}
			this.ConsumeItemsCache = this.ConsumeItemsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060080C2 RID: 32962 RVA: 0x0025938A File Offset: 0x0025758A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConsumeItemsFrozenDict(int key)
		{
			this.EnsureConsumeItemsCacheIfNeeded();
			return this.ConsumeItemsCache;
		}

		// Token: 0x04004DBF RID: 19903
		private Table __p;

		// Token: 0x04004DC0 RID: 19904
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeItemsCache;
	}
}
