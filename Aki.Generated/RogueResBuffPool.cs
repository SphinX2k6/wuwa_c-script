using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010DB RID: 4315
	public struct RogueResBuffPool : IFlatbufferObject
	{
		// Token: 0x17003040 RID: 12352
		// (get) Token: 0x0600C733 RID: 50995 RVA: 0x003056BC File Offset: 0x003038BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C734 RID: 50996 RVA: 0x003056C9 File Offset: 0x003038C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C735 RID: 50997 RVA: 0x003056D0 File Offset: 0x003038D0
		public static RogueResBuffPool GetRootAsRogueResBuffPool(ByteBuffer _bb)
		{
			return RogueResBuffPool.GetRootAsRogueResBuffPool(_bb, default(RogueResBuffPool));
		}

		// Token: 0x0600C736 RID: 50998 RVA: 0x003056EC File Offset: 0x003038EC
		public static RogueResBuffPool GetRootAsRogueResBuffPool(ByteBuffer _bb, RogueResBuffPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C737 RID: 50999 RVA: 0x00305709 File Offset: 0x00303909
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C738 RID: 51000 RVA: 0x00305718 File Offset: 0x00303918
		public RogueResBuffPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x0600C739 RID: 51001 RVA: 0x00305728 File Offset: 0x00303928
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

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x0600C73A RID: 51002 RVA: 0x00305764 File Offset: 0x00303964
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0600C73B RID: 51003 RVA: 0x003057AC File Offset: 0x003039AC
		public int PerIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x0600C73C RID: 51004 RVA: 0x003057EC File Offset: 0x003039EC
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

		// Token: 0x0600C73D RID: 51005 RVA: 0x00305817 File Offset: 0x00303A17
		public Span<int> GetPerIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C73E RID: 51006 RVA: 0x00305826 File Offset: 0x00303A26
		public int[] GetPerIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x0600C73F RID: 51007 RVA: 0x00305840 File Offset: 0x00303A40
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

		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x0600C740 RID: 51008 RVA: 0x00305880 File Offset: 0x00303A80
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

		// Token: 0x0600C741 RID: 51009 RVA: 0x003058C0 File Offset: 0x00303AC0
		public DicIntInt? BuffElement(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x0600C742 RID: 51010 RVA: 0x00305924 File Offset: 0x00303B24
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

		// Token: 0x17003047 RID: 12359
		// (get) Token: 0x0600C743 RID: 51011 RVA: 0x00305950 File Offset: 0x00303B50
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

		// Token: 0x0600C744 RID: 51012 RVA: 0x00305988 File Offset: 0x00303B88
		public Span<byte> GetBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C745 RID: 51013 RVA: 0x00305998 File Offset: 0x00303B98
		public byte[] GetBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x0600C746 RID: 51014 RVA: 0x003059B0 File Offset: 0x00303BB0
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

		// Token: 0x0600C747 RID: 51015 RVA: 0x003059E8 File Offset: 0x00303BE8
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C748 RID: 51016 RVA: 0x003059F8 File Offset: 0x00303BF8
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C749 RID: 51017 RVA: 0x00305A10 File Offset: 0x00303C10
		public string BuffDescParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x0600C74A RID: 51018 RVA: 0x00305A4C File Offset: 0x00303C4C
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

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x0600C74B RID: 51019 RVA: 0x00305A78 File Offset: 0x00303C78
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

		// Token: 0x0600C74C RID: 51020 RVA: 0x00305AB0 File Offset: 0x00303CB0
		public Span<byte> GetBuffDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C74D RID: 51021 RVA: 0x00305AC0 File Offset: 0x00303CC0
		public byte[] GetBuffDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700304B RID: 12363
		// (get) Token: 0x0600C74E RID: 51022 RVA: 0x00305AD8 File Offset: 0x00303CD8
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

		// Token: 0x0600C74F RID: 51023 RVA: 0x00305B10 File Offset: 0x00303D10
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600C750 RID: 51024 RVA: 0x00305B20 File Offset: 0x00303D20
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C751 RID: 51025 RVA: 0x00305B38 File Offset: 0x00303D38
		[NullableContext(1)]
		public string[] BuffDescParam()
		{
			return this.BuffDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C752 RID: 51026 RVA: 0x00305B45 File Offset: 0x00303D45
		[NullableContext(1)]
		public IEnumerable<string> BuffDescParamIter()
		{
			RogueResBuffPool.<BuffDescParamIter>d__44 <BuffDescParamIter>d__ = new RogueResBuffPool.<BuffDescParamIter>d__44(-2);
			<BuffDescParamIter>d__.<>3__<>4__this = this;
			return <BuffDescParamIter>d__;
		}

		// Token: 0x0600C753 RID: 51027 RVA: 0x00305B5C File Offset: 0x00303D5C
		[NullableContext(1)]
		public Dictionary<int, int> BuffElement()
		{
			return this.BuffElementIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C754 RID: 51028 RVA: 0x00305BB2 File Offset: 0x00303DB2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> BuffElementIter()
		{
			RogueResBuffPool.<BuffElementIter>d__46 <BuffElementIter>d__ = new RogueResBuffPool.<BuffElementIter>d__46(-2);
			<BuffElementIter>d__.<>3__<>4__this = this;
			return <BuffElementIter>d__;
		}

		// Token: 0x0600C755 RID: 51029 RVA: 0x00305BC7 File Offset: 0x00303DC7
		[NullableContext(1)]
		public int[] PerIds()
		{
			return this.GetPerIdsArray();
		}

		// Token: 0x0600C756 RID: 51030 RVA: 0x00305BCF File Offset: 0x00303DCF
		[NullableContext(1)]
		public IEnumerable<int> PerIdsIter()
		{
			RogueResBuffPool.<PerIdsIter>d__48 <PerIdsIter>d__ = new RogueResBuffPool.<PerIdsIter>d__48(-2);
			<PerIdsIter>d__.<>3__<>4__this = this;
			return <PerIdsIter>d__;
		}

		// Token: 0x0600C757 RID: 51031 RVA: 0x00305BE4 File Offset: 0x00303DE4
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

		// Token: 0x0600C758 RID: 51032 RVA: 0x00305C18 File Offset: 0x00303E18
		private void EnsureBuffElementCacheIfNeeded()
		{
			if (this.BuffElementCache != null)
			{
				return;
			}
			this.BuffElementCache = this.BuffElementIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C759 RID: 51033 RVA: 0x00305C7E File Offset: 0x00303E7E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetBuffElementFrozenDict()
		{
			this.EnsureBuffElementCacheIfNeeded();
			return this.BuffElementCache;
		}

		// Token: 0x040056C2 RID: 22210
		private Table __p;

		// Token: 0x040056C3 RID: 22211
		[Nullable(2)]
		private FrozenDictionary<int, int> BuffElementCache;
	}
}
