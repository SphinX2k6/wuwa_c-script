using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FDA RID: 4058
	public struct RogueBuffPool : IFlatbufferObject
	{
		// Token: 0x17002EEC RID: 12012
		// (get) Token: 0x0600BE40 RID: 48704 RVA: 0x002E319C File Offset: 0x002E139C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BE41 RID: 48705 RVA: 0x002E31A9 File Offset: 0x002E13A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BE42 RID: 48706 RVA: 0x002E31B0 File Offset: 0x002E13B0
		public static RogueBuffPool GetRootAsRogueBuffPool(ByteBuffer _bb)
		{
			return RogueBuffPool.GetRootAsRogueBuffPool(_bb, default(RogueBuffPool));
		}

		// Token: 0x0600BE43 RID: 48707 RVA: 0x002E31CC File Offset: 0x002E13CC
		public static RogueBuffPool GetRootAsRogueBuffPool(ByteBuffer _bb, RogueBuffPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE44 RID: 48708 RVA: 0x002E31E9 File Offset: 0x002E13E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE45 RID: 48709 RVA: 0x002E31F8 File Offset: 0x002E13F8
		public RogueBuffPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EED RID: 12013
		// (get) Token: 0x0600BE46 RID: 48710 RVA: 0x002E3208 File Offset: 0x002E1408
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

		// Token: 0x17002EEE RID: 12014
		// (get) Token: 0x0600BE47 RID: 48711 RVA: 0x002E3244 File Offset: 0x002E1444
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0600BE48 RID: 48712 RVA: 0x002E328C File Offset: 0x002E148C
		public int PerIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002EEF RID: 12015
		// (get) Token: 0x0600BE49 RID: 48713 RVA: 0x002E32CC File Offset: 0x002E14CC
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

		// Token: 0x0600BE4A RID: 48714 RVA: 0x002E32F7 File Offset: 0x002E14F7
		public Span<int> GetPerIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600BE4B RID: 48715 RVA: 0x002E3306 File Offset: 0x002E1506
		public int[] GetPerIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002EF0 RID: 12016
		// (get) Token: 0x0600BE4C RID: 48716 RVA: 0x002E3320 File Offset: 0x002E1520
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

		// Token: 0x17002EF1 RID: 12017
		// (get) Token: 0x0600BE4D RID: 48717 RVA: 0x002E3360 File Offset: 0x002E1560
		public int PerkType
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

		// Token: 0x17002EF2 RID: 12018
		// (get) Token: 0x0600BE4E RID: 48718 RVA: 0x002E33A0 File Offset: 0x002E15A0
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BE4F RID: 48719 RVA: 0x002E33E0 File Offset: 0x002E15E0
		public DicIntInt? BuffElement(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002EF3 RID: 12019
		// (get) Token: 0x0600BE50 RID: 48720 RVA: 0x002E3444 File Offset: 0x002E1644
		public int BuffElementLength
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

		// Token: 0x17002EF4 RID: 12020
		// (get) Token: 0x0600BE51 RID: 48721 RVA: 0x002E3470 File Offset: 0x002E1670
		public string BuffIcon
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

		// Token: 0x0600BE52 RID: 48722 RVA: 0x002E34A8 File Offset: 0x002E16A8
		public Span<byte> GetBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BE53 RID: 48723 RVA: 0x002E34B8 File Offset: 0x002E16B8
		public byte[] GetBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EF5 RID: 12021
		// (get) Token: 0x0600BE54 RID: 48724 RVA: 0x002E34D0 File Offset: 0x002E16D0
		public string BuffDesc
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BE55 RID: 48725 RVA: 0x002E3508 File Offset: 0x002E1708
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BE56 RID: 48726 RVA: 0x002E3518 File Offset: 0x002E1718
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BE57 RID: 48727 RVA: 0x002E3530 File Offset: 0x002E1730
		public string BuffDescParam(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002EF6 RID: 12022
		// (get) Token: 0x0600BE58 RID: 48728 RVA: 0x002E356C File Offset: 0x002E176C
		public int BuffDescParamLength
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

		// Token: 0x17002EF7 RID: 12023
		// (get) Token: 0x0600BE59 RID: 48729 RVA: 0x002E3598 File Offset: 0x002E1798
		public string BuffDescSimple
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

		// Token: 0x0600BE5A RID: 48730 RVA: 0x002E35D0 File Offset: 0x002E17D0
		public Span<byte> GetBuffDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600BE5B RID: 48731 RVA: 0x002E35E0 File Offset: 0x002E17E0
		public byte[] GetBuffDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EF8 RID: 12024
		// (get) Token: 0x0600BE5C RID: 48732 RVA: 0x002E35F8 File Offset: 0x002E17F8
		public string BuffName
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BE5D RID: 48733 RVA: 0x002E3630 File Offset: 0x002E1830
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600BE5E RID: 48734 RVA: 0x002E3640 File Offset: 0x002E1840
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EF9 RID: 12025
		// (get) Token: 0x0600BE5F RID: 48735 RVA: 0x002E3658 File Offset: 0x002E1858
		public int RoleId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002EFA RID: 12026
		// (get) Token: 0x0600BE60 RID: 48736 RVA: 0x002E3698 File Offset: 0x002E1898
		public int TrialRoleId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BE61 RID: 48737 RVA: 0x002E36D5 File Offset: 0x002E18D5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffDescParamIter()或GetBuffDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BuffDescParam()
		{
			return this.BuffDescParamIter().ToArray<string>();
		}

		// Token: 0x0600BE62 RID: 48738 RVA: 0x002E36E2 File Offset: 0x002E18E2
		[NullableContext(1)]
		public readonly IEnumerable<string> BuffDescParamIter()
		{
			RogueBuffPool.<BuffDescParamIter>d__50 <BuffDescParamIter>d__ = new RogueBuffPool.<BuffDescParamIter>d__50(-2);
			<BuffDescParamIter>d__.<>3__<>4__this = this;
			return <BuffDescParamIter>d__;
		}

		// Token: 0x0600BE63 RID: 48739 RVA: 0x002E36F8 File Offset: 0x002E18F8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用BuffElementFrozenDict()缓存字典，遍历请使用BuffElementIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> BuffElement()
		{
			return this.BuffElementIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600BE64 RID: 48740 RVA: 0x002E374E File Offset: 0x002E194E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> BuffElementIter()
		{
			RogueBuffPool.<BuffElementIter>d__52 <BuffElementIter>d__ = new RogueBuffPool.<BuffElementIter>d__52(-2);
			<BuffElementIter>d__.<>3__<>4__this = this;
			return <BuffElementIter>d__;
		}

		// Token: 0x0600BE65 RID: 48741 RVA: 0x002E3764 File Offset: 0x002E1964
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PerIdsIter()或GetPerIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PerIds()
		{
			RogueBuffPool rogueBuffPool = this;
			return rogueBuffPool.GetPerIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BE66 RID: 48742 RVA: 0x002E3788 File Offset: 0x002E1988
		[NullableContext(1)]
		public readonly IEnumerable<int> PerIdsIter()
		{
			RogueBuffPool.<PerIdsIter>d__54 <PerIdsIter>d__ = new RogueBuffPool.<PerIdsIter>d__54(-2);
			<PerIdsIter>d__.<>3__<>4__this = this;
			return <PerIdsIter>d__;
		}

		// Token: 0x0600BE67 RID: 48743 RVA: 0x002E37A0 File Offset: 0x002E19A0
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

		// Token: 0x0600BE68 RID: 48744 RVA: 0x002E37D4 File Offset: 0x002E19D4
		private void EnsureBuffElementCacheIfNeeded()
		{
			if (this.BuffElementCache != null)
			{
				return;
			}
			this.BuffElementCache = this.BuffElementIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600BE69 RID: 48745 RVA: 0x002E383A File Offset: 0x002E1A3A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetBuffElementFrozenDict(int key)
		{
			this.EnsureBuffElementCacheIfNeeded();
			return this.BuffElementCache;
		}

		// Token: 0x040050B6 RID: 20662
		private Table __p;

		// Token: 0x040050B7 RID: 20663
		[Nullable(2)]
		private FrozenDictionary<int, int> BuffElementCache;
	}
}
