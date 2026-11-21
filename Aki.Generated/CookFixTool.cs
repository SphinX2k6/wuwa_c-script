using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C7F RID: 3199
	public struct CookFixTool : IFlatbufferObject
	{
		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06005F05 RID: 24325 RVA: 0x0021EFC4 File Offset: 0x0021D1C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005F06 RID: 24326 RVA: 0x0021EFD1 File Offset: 0x0021D1D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005F07 RID: 24327 RVA: 0x0021EFD8 File Offset: 0x0021D1D8
		public static CookFixTool GetRootAsCookFixTool(ByteBuffer _bb)
		{
			return CookFixTool.GetRootAsCookFixTool(_bb, default(CookFixTool));
		}

		// Token: 0x06005F08 RID: 24328 RVA: 0x0021EFF4 File Offset: 0x0021D1F4
		public static CookFixTool GetRootAsCookFixTool(ByteBuffer _bb, CookFixTool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005F09 RID: 24329 RVA: 0x0021F011 File Offset: 0x0021D211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005F0A RID: 24330 RVA: 0x0021F020 File Offset: 0x0021D220
		public CookFixTool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06005F0B RID: 24331 RVA: 0x0021F030 File Offset: 0x0021D230
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

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06005F0C RID: 24332 RVA: 0x0021F06C File Offset: 0x0021D26C
		public string Description
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005F0D RID: 24333 RVA: 0x0021F0A3 File Offset: 0x0021D2A3
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005F0E RID: 24334 RVA: 0x0021F0B2 File Offset: 0x0021D2B2
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06005F0F RID: 24335 RVA: 0x0021F0CC File Offset: 0x0021D2CC
		public DicIntInt? Items(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06005F10 RID: 24336 RVA: 0x0021F12C File Offset: 0x0021D32C
		public int ItemsLength
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

		// Token: 0x06005F11 RID: 24337 RVA: 0x0021F158 File Offset: 0x0021D358
		[NullableContext(1)]
		public Dictionary<int, int> Items()
		{
			return this.ItemsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005F12 RID: 24338 RVA: 0x0021F1AE File Offset: 0x0021D3AE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ItemsIter()
		{
			CookFixTool.<ItemsIter>d__18 <ItemsIter>d__ = new CookFixTool.<ItemsIter>d__18(-2);
			<ItemsIter>d__.<>3__<>4__this = this;
			return <ItemsIter>d__;
		}

		// Token: 0x06005F13 RID: 24339 RVA: 0x0021F1C4 File Offset: 0x0021D3C4
		public int? GetItems(int key)
		{
			this.EnsureItemsCacheIfNeeded();
			int value;
			if (!this.ItemsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06005F14 RID: 24340 RVA: 0x0021F1F8 File Offset: 0x0021D3F8
		private void EnsureItemsCacheIfNeeded()
		{
			if (this.ItemsCache != null)
			{
				return;
			}
			this.ItemsCache = this.ItemsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005F15 RID: 24341 RVA: 0x0021F25E File Offset: 0x0021D45E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetItemsFrozenDict()
		{
			this.EnsureItemsCacheIfNeeded();
			return this.ItemsCache;
		}

		// Token: 0x040051A0 RID: 20896
		private Table __p;

		// Token: 0x040051A1 RID: 20897
		[Nullable(2)]
		private FrozenDictionary<int, int> ItemsCache;
	}
}
