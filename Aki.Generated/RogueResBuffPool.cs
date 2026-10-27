using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF3 RID: 4083
	public struct RogueResBuffPool : IFlatbufferObject
	{
		// Token: 0x17002FC5 RID: 12229
		// (get) Token: 0x0600C0E9 RID: 49385 RVA: 0x002E93D4 File Offset: 0x002E75D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C0EA RID: 49386 RVA: 0x002E93E1 File Offset: 0x002E75E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C0EB RID: 49387 RVA: 0x002E93E8 File Offset: 0x002E75E8
		public static RogueResBuffPool GetRootAsRogueResBuffPool(ByteBuffer _bb)
		{
			return RogueResBuffPool.GetRootAsRogueResBuffPool(_bb, default(RogueResBuffPool));
		}

		// Token: 0x0600C0EC RID: 49388 RVA: 0x002E9404 File Offset: 0x002E7604
		public static RogueResBuffPool GetRootAsRogueResBuffPool(ByteBuffer _bb, RogueResBuffPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C0ED RID: 49389 RVA: 0x002E9421 File Offset: 0x002E7621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C0EE RID: 49390 RVA: 0x002E9430 File Offset: 0x002E7630
		public RogueResBuffPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FC6 RID: 12230
		// (get) Token: 0x0600C0EF RID: 49391 RVA: 0x002E9440 File Offset: 0x002E7640
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

		// Token: 0x17002FC7 RID: 12231
		// (get) Token: 0x0600C0F0 RID: 49392 RVA: 0x002E947C File Offset: 0x002E767C
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0600C0F1 RID: 49393 RVA: 0x002E94C4 File Offset: 0x002E76C4
		public int PerIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FC8 RID: 12232
		// (get) Token: 0x0600C0F2 RID: 49394 RVA: 0x002E9504 File Offset: 0x002E7704
		public int PerIdsLength
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

		// Token: 0x0600C0F3 RID: 49395 RVA: 0x002E952F File Offset: 0x002E772F
		public Span<int> GetPerIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C0F4 RID: 49396 RVA: 0x002E953E File Offset: 0x002E773E
		public int[] GetPerIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002FC9 RID: 12233
		// (get) Token: 0x0600C0F5 RID: 49397 RVA: 0x002E9558 File Offset: 0x002E7758
		public int EffectId
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

		// Token: 0x17002FCA RID: 12234
		// (get) Token: 0x0600C0F6 RID: 49398 RVA: 0x002E9598 File Offset: 0x002E7798
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C0F7 RID: 49399 RVA: 0x002E95D8 File Offset: 0x002E77D8
		public DicIntInt? BuffElement(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002FCB RID: 12235
		// (get) Token: 0x0600C0F8 RID: 49400 RVA: 0x002E963C File Offset: 0x002E783C
		public int BuffElementLength
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

		// Token: 0x17002FCC RID: 12236
		// (get) Token: 0x0600C0F9 RID: 49401 RVA: 0x002E9668 File Offset: 0x002E7868
		public string BuffIcon
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

		// Token: 0x0600C0FA RID: 49402 RVA: 0x002E96A0 File Offset: 0x002E78A0
		public Span<byte> GetBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C0FB RID: 49403 RVA: 0x002E96B0 File Offset: 0x002E78B0
		public byte[] GetBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FCD RID: 12237
		// (get) Token: 0x0600C0FC RID: 49404 RVA: 0x002E96C8 File Offset: 0x002E78C8
		public string BuffDesc
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

		// Token: 0x0600C0FD RID: 49405 RVA: 0x002E9700 File Offset: 0x002E7900
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C0FE RID: 49406 RVA: 0x002E9710 File Offset: 0x002E7910
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C0FF RID: 49407 RVA: 0x002E9728 File Offset: 0x002E7928
		public string BuffDescParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FCE RID: 12238
		// (get) Token: 0x0600C100 RID: 49408 RVA: 0x002E9764 File Offset: 0x002E7964
		public int BuffDescParamLength
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

		// Token: 0x17002FCF RID: 12239
		// (get) Token: 0x0600C101 RID: 49409 RVA: 0x002E9790 File Offset: 0x002E7990
		public string BuffDescSimple
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C102 RID: 49410 RVA: 0x002E97C8 File Offset: 0x002E79C8
		public Span<byte> GetBuffDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C103 RID: 49411 RVA: 0x002E97D8 File Offset: 0x002E79D8
		public byte[] GetBuffDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FD0 RID: 12240
		// (get) Token: 0x0600C104 RID: 49412 RVA: 0x002E97F0 File Offset: 0x002E79F0
		public string BuffName
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C105 RID: 49413 RVA: 0x002E9828 File Offset: 0x002E7A28
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600C106 RID: 49414 RVA: 0x002E9838 File Offset: 0x002E7A38
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C107 RID: 49415 RVA: 0x002E9850 File Offset: 0x002E7A50
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffDescParamIter()或GetBuffDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BuffDescParam()
		{
			return this.BuffDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C108 RID: 49416 RVA: 0x002E985D File Offset: 0x002E7A5D
		[NullableContext(1)]
		public readonly IEnumerable<string> BuffDescParamIter()
		{
			RogueResBuffPool.<BuffDescParamIter>d__44 <BuffDescParamIter>d__ = new RogueResBuffPool.<BuffDescParamIter>d__44(-2);
			<BuffDescParamIter>d__.<>3__<>4__this = this;
			return <BuffDescParamIter>d__;
		}

		// Token: 0x0600C109 RID: 49417 RVA: 0x002E9874 File Offset: 0x002E7A74
		[NullableContext(1)]
		[Obsolete("已废弃，请使用BuffElementFrozenDict()缓存字典，遍历请使用BuffElementIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> BuffElement()
		{
			return this.BuffElementIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C10A RID: 49418 RVA: 0x002E98CA File Offset: 0x002E7ACA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> BuffElementIter()
		{
			RogueResBuffPool.<BuffElementIter>d__46 <BuffElementIter>d__ = new RogueResBuffPool.<BuffElementIter>d__46(-2);
			<BuffElementIter>d__.<>3__<>4__this = this;
			return <BuffElementIter>d__;
		}

		// Token: 0x0600C10B RID: 49419 RVA: 0x002E98E0 File Offset: 0x002E7AE0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PerIdsIter()或GetPerIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PerIds()
		{
			RogueResBuffPool rogueResBuffPool = this;
			return rogueResBuffPool.GetPerIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C10C RID: 49420 RVA: 0x002E9904 File Offset: 0x002E7B04
		[NullableContext(1)]
		public readonly IEnumerable<int> PerIdsIter()
		{
			RogueResBuffPool.<PerIdsIter>d__48 <PerIdsIter>d__ = new RogueResBuffPool.<PerIdsIter>d__48(-2);
			<PerIdsIter>d__.<>3__<>4__this = this;
			return <PerIdsIter>d__;
		}

		// Token: 0x0600C10D RID: 49421 RVA: 0x002E991C File Offset: 0x002E7B1C
		public int? GetBuffElement(int key)
		{
			this.EnsureBuffElementCacheIfNeeded();
			int value;
			if (!this.BuffElementCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C10E RID: 49422 RVA: 0x002E9950 File Offset: 0x002E7B50
		private void EnsureBuffElementCacheIfNeeded()
		{
			if (this.BuffElementCache != null)
			{
				return;
			}
			this.BuffElementCache = this.BuffElementIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C10F RID: 49423 RVA: 0x002E99B6 File Offset: 0x002E7BB6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetBuffElementFrozenDict(int key)
		{
			this.EnsureBuffElementCacheIfNeeded();
			return this.BuffElementCache;
		}

		// Token: 0x040050DA RID: 20698
		private Table __p;

		// Token: 0x040050DB RID: 20699
		[Nullable(2)]
		private FrozenDictionary<int, int> BuffElementCache;
	}
}
