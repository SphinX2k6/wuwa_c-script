using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C83 RID: 3203
	public struct CookProcessed : IFlatbufferObject
	{
		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06005F51 RID: 24401 RVA: 0x0021FAD1 File Offset: 0x0021DCD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005F52 RID: 24402 RVA: 0x0021FADE File Offset: 0x0021DCDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005F53 RID: 24403 RVA: 0x0021FAE8 File Offset: 0x0021DCE8
		public static CookProcessed GetRootAsCookProcessed(ByteBuffer _bb)
		{
			return CookProcessed.GetRootAsCookProcessed(_bb, default(CookProcessed));
		}

		// Token: 0x06005F54 RID: 24404 RVA: 0x0021FB04 File Offset: 0x0021DD04
		public static CookProcessed GetRootAsCookProcessed(ByteBuffer _bb, CookProcessed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x0021FB21 File Offset: 0x0021DD21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005F56 RID: 24406 RVA: 0x0021FB30 File Offset: 0x0021DD30
		public CookProcessed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06005F57 RID: 24407 RVA: 0x0021FB40 File Offset: 0x0021DD40
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

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06005F58 RID: 24408 RVA: 0x0021FB7C File Offset: 0x0021DD7C
		public int FinalItemId
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

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06005F59 RID: 24409 RVA: 0x0021FBB8 File Offset: 0x0021DDB8
		public bool Unlock
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06005F5A RID: 24410 RVA: 0x0021FBF8 File Offset: 0x0021DDF8
		public string Name
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

		// Token: 0x06005F5B RID: 24411 RVA: 0x0021FC30 File Offset: 0x0021DE30
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005F5C RID: 24412 RVA: 0x0021FC40 File Offset: 0x0021DE40
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06005F5D RID: 24413 RVA: 0x0021FC58 File Offset: 0x0021DE58
		public OneItemConfig? ConsumeItemsId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new OneItemConfig?(default(OneItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06005F5E RID: 24414 RVA: 0x0021FCBC File Offset: 0x0021DEBC
		public int ConsumeItemsIdLength
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

		// Token: 0x06005F5F RID: 24415 RVA: 0x0021FCE8 File Offset: 0x0021DEE8
		public DicIntInt? LeastItemId(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06005F60 RID: 24416 RVA: 0x0021FD4C File Offset: 0x0021DF4C
		public int LeastItemIdLength
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

		// Token: 0x06005F61 RID: 24417 RVA: 0x0021FD78 File Offset: 0x0021DF78
		public int InterationId(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06005F62 RID: 24418 RVA: 0x0021FDB8 File Offset: 0x0021DFB8
		public int InterationIdLength
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

		// Token: 0x06005F63 RID: 24419 RVA: 0x0021FDE4 File Offset: 0x0021DFE4
		public Span<int> GetInterationIdBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06005F64 RID: 24420 RVA: 0x0021FDF4 File Offset: 0x0021DFF4
		public int[] GetInterationIdArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06005F65 RID: 24421 RVA: 0x0021FE0C File Offset: 0x0021E00C
		[NullableContext(1)]
		public OneItemConfig[] ConsumeItemsId()
		{
			return this.ConsumeItemsIdIter().ToArray<OneItemConfig>();
		}

		// Token: 0x06005F66 RID: 24422 RVA: 0x0021FE19 File Offset: 0x0021E019
		[NullableContext(1)]
		public IEnumerable<OneItemConfig> ConsumeItemsIdIter()
		{
			CookProcessed.<ConsumeItemsIdIter>d__30 <ConsumeItemsIdIter>d__ = new CookProcessed.<ConsumeItemsIdIter>d__30(-2);
			<ConsumeItemsIdIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIdIter>d__;
		}

		// Token: 0x06005F67 RID: 24423 RVA: 0x0021FE2E File Offset: 0x0021E02E
		[NullableContext(1)]
		public int[] InterationId()
		{
			return this.GetInterationIdArray();
		}

		// Token: 0x06005F68 RID: 24424 RVA: 0x0021FE36 File Offset: 0x0021E036
		[NullableContext(1)]
		public IEnumerable<int> InterationIdIter()
		{
			CookProcessed.<InterationIdIter>d__32 <InterationIdIter>d__ = new CookProcessed.<InterationIdIter>d__32(-2);
			<InterationIdIter>d__.<>3__<>4__this = this;
			return <InterationIdIter>d__;
		}

		// Token: 0x06005F69 RID: 24425 RVA: 0x0021FE4C File Offset: 0x0021E04C
		[NullableContext(1)]
		public Dictionary<int, int> LeastItemId()
		{
			return this.LeastItemIdIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005F6A RID: 24426 RVA: 0x0021FEA2 File Offset: 0x0021E0A2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> LeastItemIdIter()
		{
			CookProcessed.<LeastItemIdIter>d__34 <LeastItemIdIter>d__ = new CookProcessed.<LeastItemIdIter>d__34(-2);
			<LeastItemIdIter>d__.<>3__<>4__this = this;
			return <LeastItemIdIter>d__;
		}

		// Token: 0x06005F6B RID: 24427 RVA: 0x0021FEB8 File Offset: 0x0021E0B8
		public int? GetLeastItemId(int key)
		{
			this.EnsureLeastItemIdCacheIfNeeded();
			int value;
			if (!this.LeastItemIdCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06005F6C RID: 24428 RVA: 0x0021FEEC File Offset: 0x0021E0EC
		private void EnsureLeastItemIdCacheIfNeeded()
		{
			if (this.LeastItemIdCache != null)
			{
				return;
			}
			this.LeastItemIdCache = this.LeastItemIdIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005F6D RID: 24429 RVA: 0x0021FF52 File Offset: 0x0021E152
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetLeastItemIdFrozenDict()
		{
			this.EnsureLeastItemIdCacheIfNeeded();
			return this.LeastItemIdCache;
		}

		// Token: 0x040051A5 RID: 20901
		private Table __p;

		// Token: 0x040051A6 RID: 20902
		[Nullable(2)]
		private FrozenDictionary<int, int> LeastItemIdCache;
	}
}
