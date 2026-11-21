using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C2 RID: 4290
	public struct RogueBuffPool : IFlatbufferObject
	{
		// Token: 0x17002F67 RID: 12135
		// (get) Token: 0x0600C48A RID: 50314 RVA: 0x002FF748 File Offset: 0x002FD948
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C48B RID: 50315 RVA: 0x002FF755 File Offset: 0x002FD955
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C48C RID: 50316 RVA: 0x002FF75C File Offset: 0x002FD95C
		public static RogueBuffPool GetRootAsRogueBuffPool(ByteBuffer _bb)
		{
			return RogueBuffPool.GetRootAsRogueBuffPool(_bb, default(RogueBuffPool));
		}

		// Token: 0x0600C48D RID: 50317 RVA: 0x002FF778 File Offset: 0x002FD978
		public static RogueBuffPool GetRootAsRogueBuffPool(ByteBuffer _bb, RogueBuffPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C48E RID: 50318 RVA: 0x002FF795 File Offset: 0x002FD995
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C48F RID: 50319 RVA: 0x002FF7A4 File Offset: 0x002FD9A4
		public RogueBuffPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F68 RID: 12136
		// (get) Token: 0x0600C490 RID: 50320 RVA: 0x002FF7B4 File Offset: 0x002FD9B4
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

		// Token: 0x17002F69 RID: 12137
		// (get) Token: 0x0600C491 RID: 50321 RVA: 0x002FF7F0 File Offset: 0x002FD9F0
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0600C492 RID: 50322 RVA: 0x002FF838 File Offset: 0x002FDA38
		public int PerIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F6A RID: 12138
		// (get) Token: 0x0600C493 RID: 50323 RVA: 0x002FF878 File Offset: 0x002FDA78
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

		// Token: 0x0600C494 RID: 50324 RVA: 0x002FF8A3 File Offset: 0x002FDAA3
		public Span<int> GetPerIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C495 RID: 50325 RVA: 0x002FF8B2 File Offset: 0x002FDAB2
		public int[] GetPerIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002F6B RID: 12139
		// (get) Token: 0x0600C496 RID: 50326 RVA: 0x002FF8CC File Offset: 0x002FDACC
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

		// Token: 0x17002F6C RID: 12140
		// (get) Token: 0x0600C497 RID: 50327 RVA: 0x002FF90C File Offset: 0x002FDB0C
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

		// Token: 0x17002F6D RID: 12141
		// (get) Token: 0x0600C498 RID: 50328 RVA: 0x002FF94C File Offset: 0x002FDB4C
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

		// Token: 0x0600C499 RID: 50329 RVA: 0x002FF98C File Offset: 0x002FDB8C
		public DicIntInt? BuffElement(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002F6E RID: 12142
		// (get) Token: 0x0600C49A RID: 50330 RVA: 0x002FF9F0 File Offset: 0x002FDBF0
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

		// Token: 0x17002F6F RID: 12143
		// (get) Token: 0x0600C49B RID: 50331 RVA: 0x002FFA1C File Offset: 0x002FDC1C
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

		// Token: 0x0600C49C RID: 50332 RVA: 0x002FFA54 File Offset: 0x002FDC54
		public Span<byte> GetBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C49D RID: 50333 RVA: 0x002FFA64 File Offset: 0x002FDC64
		public byte[] GetBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F70 RID: 12144
		// (get) Token: 0x0600C49E RID: 50334 RVA: 0x002FFA7C File Offset: 0x002FDC7C
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

		// Token: 0x0600C49F RID: 50335 RVA: 0x002FFAB4 File Offset: 0x002FDCB4
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C4A0 RID: 50336 RVA: 0x002FFAC4 File Offset: 0x002FDCC4
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C4A1 RID: 50337 RVA: 0x002FFADC File Offset: 0x002FDCDC
		public string BuffDescParam(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F71 RID: 12145
		// (get) Token: 0x0600C4A2 RID: 50338 RVA: 0x002FFB18 File Offset: 0x002FDD18
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

		// Token: 0x17002F72 RID: 12146
		// (get) Token: 0x0600C4A3 RID: 50339 RVA: 0x002FFB44 File Offset: 0x002FDD44
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

		// Token: 0x0600C4A4 RID: 50340 RVA: 0x002FFB7C File Offset: 0x002FDD7C
		public Span<byte> GetBuffDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600C4A5 RID: 50341 RVA: 0x002FFB8C File Offset: 0x002FDD8C
		public byte[] GetBuffDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F73 RID: 12147
		// (get) Token: 0x0600C4A6 RID: 50342 RVA: 0x002FFBA4 File Offset: 0x002FDDA4
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

		// Token: 0x0600C4A7 RID: 50343 RVA: 0x002FFBDC File Offset: 0x002FDDDC
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600C4A8 RID: 50344 RVA: 0x002FFBEC File Offset: 0x002FDDEC
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x0600C4A9 RID: 50345 RVA: 0x002FFC04 File Offset: 0x002FDE04
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

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x0600C4AA RID: 50346 RVA: 0x002FFC44 File Offset: 0x002FDE44
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

		// Token: 0x0600C4AB RID: 50347 RVA: 0x002FFC81 File Offset: 0x002FDE81
		[NullableContext(1)]
		public string[] BuffDescParam()
		{
			return this.BuffDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C4AC RID: 50348 RVA: 0x002FFC8E File Offset: 0x002FDE8E
		[NullableContext(1)]
		public IEnumerable<string> BuffDescParamIter()
		{
			RogueBuffPool.<BuffDescParamIter>d__50 <BuffDescParamIter>d__ = new RogueBuffPool.<BuffDescParamIter>d__50(-2);
			<BuffDescParamIter>d__.<>3__<>4__this = this;
			return <BuffDescParamIter>d__;
		}

		// Token: 0x0600C4AD RID: 50349 RVA: 0x002FFCA4 File Offset: 0x002FDEA4
		[NullableContext(1)]
		public Dictionary<int, int> BuffElement()
		{
			return this.BuffElementIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C4AE RID: 50350 RVA: 0x002FFCFA File Offset: 0x002FDEFA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> BuffElementIter()
		{
			RogueBuffPool.<BuffElementIter>d__52 <BuffElementIter>d__ = new RogueBuffPool.<BuffElementIter>d__52(-2);
			<BuffElementIter>d__.<>3__<>4__this = this;
			return <BuffElementIter>d__;
		}

		// Token: 0x0600C4AF RID: 50351 RVA: 0x002FFD0F File Offset: 0x002FDF0F
		[NullableContext(1)]
		public int[] PerIds()
		{
			return this.GetPerIdsArray();
		}

		// Token: 0x0600C4B0 RID: 50352 RVA: 0x002FFD17 File Offset: 0x002FDF17
		[NullableContext(1)]
		public IEnumerable<int> PerIdsIter()
		{
			RogueBuffPool.<PerIdsIter>d__54 <PerIdsIter>d__ = new RogueBuffPool.<PerIdsIter>d__54(-2);
			<PerIdsIter>d__.<>3__<>4__this = this;
			return <PerIdsIter>d__;
		}

		// Token: 0x0600C4B1 RID: 50353 RVA: 0x002FFD2C File Offset: 0x002FDF2C
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

		// Token: 0x0600C4B2 RID: 50354 RVA: 0x002FFD60 File Offset: 0x002FDF60
		private void EnsureBuffElementCacheIfNeeded()
		{
			if (this.BuffElementCache != null)
			{
				return;
			}
			this.BuffElementCache = this.BuffElementIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C4B3 RID: 50355 RVA: 0x002FFDC6 File Offset: 0x002FDFC6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetBuffElementFrozenDict()
		{
			this.EnsureBuffElementCacheIfNeeded();
			return this.BuffElementCache;
		}

		// Token: 0x0400569E RID: 22174
		private Table __p;

		// Token: 0x0400569F RID: 22175
		[Nullable(2)]
		private FrozenDictionary<int, int> BuffElementCache;
	}
}
