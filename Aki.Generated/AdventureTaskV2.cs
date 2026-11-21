using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB0 RID: 2992
	public struct AdventureTaskV2 : IFlatbufferObject
	{
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060049E1 RID: 18913 RVA: 0x001EE785 File Offset: 0x001EC985
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x001EE792 File Offset: 0x001EC992
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x001EE79C File Offset: 0x001EC99C
		public static AdventureTaskV2 GetRootAsAdventureTaskV2(ByteBuffer _bb)
		{
			return AdventureTaskV2.GetRootAsAdventureTaskV2(_bb, default(AdventureTaskV2));
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x001EE7B8 File Offset: 0x001EC9B8
		public static AdventureTaskV2 GetRootAsAdventureTaskV2(ByteBuffer _bb, AdventureTaskV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x001EE7D5 File Offset: 0x001EC9D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060049E6 RID: 18918 RVA: 0x001EE7E4 File Offset: 0x001EC9E4
		public AdventureTaskV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060049E7 RID: 18919 RVA: 0x001EE7F4 File Offset: 0x001EC9F4
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

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060049E8 RID: 18920 RVA: 0x001EE830 File Offset: 0x001ECA30
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

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060049E9 RID: 18921 RVA: 0x001EE86C File Offset: 0x001ECA6C
		public string TaskText
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

		// Token: 0x060049EA RID: 18922 RVA: 0x001EE8A3 File Offset: 0x001ECAA3
		public Span<byte> GetTaskTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060049EB RID: 18923 RVA: 0x001EE8B2 File Offset: 0x001ECAB2
		public byte[] GetTaskTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060049EC RID: 18924 RVA: 0x001EE8CC File Offset: 0x001ECACC
		public int ChapterId
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

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060049ED RID: 18925 RVA: 0x001EE90C File Offset: 0x001ECB0C
		public int DropId
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

		// Token: 0x060049EE RID: 18926 RVA: 0x001EE94C File Offset: 0x001ECB4C
		public DicIntString? JumpTo(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060049EF RID: 18927 RVA: 0x001EE9B0 File Offset: 0x001ECBB0
		public int JumpToLength
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

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060049F0 RID: 18928 RVA: 0x001EE9DC File Offset: 0x001ECBDC
		public int TaskType
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

		// Token: 0x060049F1 RID: 18929 RVA: 0x001EEA1C File Offset: 0x001ECC1C
		[NullableContext(1)]
		public Dictionary<int, string> JumpTo()
		{
			return this.JumpToIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x001EEA72 File Offset: 0x001ECC72
		[NullableContext(1)]
		public IEnumerable<DicIntString> JumpToIter()
		{
			AdventureTaskV2.<JumpToIter>d__26 <JumpToIter>d__ = new AdventureTaskV2.<JumpToIter>d__26(-2);
			<JumpToIter>d__.<>3__<>4__this = this;
			return <JumpToIter>d__;
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x001EEA88 File Offset: 0x001ECC88
		[NullableContext(2)]
		public string GetJumpTo(int key)
		{
			this.EnsureJumpToCacheIfNeeded();
			string result;
			if (!this.JumpToCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x001EEAB0 File Offset: 0x001ECCB0
		private void EnsureJumpToCacheIfNeeded()
		{
			if (this.JumpToCache != null)
			{
				return;
			}
			this.JumpToCache = this.JumpToIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x001EEB16 File Offset: 0x001ECD16
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetJumpToFrozenDict()
		{
			this.EnsureJumpToCacheIfNeeded();
			return this.JumpToCache;
		}

		// Token: 0x0400508E RID: 20622
		private Table __p;

		// Token: 0x0400508F RID: 20623
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> JumpToCache;
	}
}
