using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE1 RID: 3553
	public struct GiantItemAccess : IFlatbufferObject
	{
		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x06008089 RID: 32905 RVA: 0x00269CB5 File Offset: 0x00267EB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600808A RID: 32906 RVA: 0x00269CC2 File Offset: 0x00267EC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600808B RID: 32907 RVA: 0x00269CCC File Offset: 0x00267ECC
		public static GiantItemAccess GetRootAsGiantItemAccess(ByteBuffer _bb)
		{
			return GiantItemAccess.GetRootAsGiantItemAccess(_bb, default(GiantItemAccess));
		}

		// Token: 0x0600808C RID: 32908 RVA: 0x00269CE8 File Offset: 0x00267EE8
		public static GiantItemAccess GetRootAsGiantItemAccess(ByteBuffer _bb, GiantItemAccess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600808D RID: 32909 RVA: 0x00269D05 File Offset: 0x00267F05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600808E RID: 32910 RVA: 0x00269D14 File Offset: 0x00267F14
		public GiantItemAccess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x0600808F RID: 32911 RVA: 0x00269D24 File Offset: 0x00267F24
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

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x06008090 RID: 32912 RVA: 0x00269D60 File Offset: 0x00267F60
		public int EcoType
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

		// Token: 0x06008091 RID: 32913 RVA: 0x00269D9C File Offset: 0x00267F9C
		public DicIntInt? ItemCounts(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x06008092 RID: 32914 RVA: 0x00269DFC File Offset: 0x00267FFC
		public int ItemCountsLength
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

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x06008093 RID: 32915 RVA: 0x00269E28 File Offset: 0x00268028
		public int AccessPathId
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

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x06008094 RID: 32916 RVA: 0x00269E68 File Offset: 0x00268068
		public int SortIndex
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

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x06008095 RID: 32917 RVA: 0x00269EA8 File Offset: 0x002680A8
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008096 RID: 32918 RVA: 0x00269EE0 File Offset: 0x002680E0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008097 RID: 32919 RVA: 0x00269EF0 File Offset: 0x002680F0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x06008098 RID: 32920 RVA: 0x00269F08 File Offset: 0x00268108
		public int UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x06008099 RID: 32921 RVA: 0x00269F48 File Offset: 0x00268148
		public int DisplayGroup
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600809A RID: 32922 RVA: 0x00269F88 File Offset: 0x00268188
		[NullableContext(1)]
		public Dictionary<int, int> ItemCounts()
		{
			return this.ItemCountsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600809B RID: 32923 RVA: 0x00269FDE File Offset: 0x002681DE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ItemCountsIter()
		{
			GiantItemAccess.<ItemCountsIter>d__28 <ItemCountsIter>d__ = new GiantItemAccess.<ItemCountsIter>d__28(-2);
			<ItemCountsIter>d__.<>3__<>4__this = this;
			return <ItemCountsIter>d__;
		}

		// Token: 0x0600809C RID: 32924 RVA: 0x00269FF4 File Offset: 0x002681F4
		public int? GetItemCounts(int key)
		{
			this.EnsureItemCountsCacheIfNeeded();
			int value;
			if (!this.ItemCountsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600809D RID: 32925 RVA: 0x0026A028 File Offset: 0x00268228
		private void EnsureItemCountsCacheIfNeeded()
		{
			if (this.ItemCountsCache != null)
			{
				return;
			}
			this.ItemCountsCache = this.ItemCountsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600809E RID: 32926 RVA: 0x0026A08E File Offset: 0x0026828E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetItemCountsFrozenDict()
		{
			this.EnsureItemCountsCacheIfNeeded();
			return this.ItemCountsCache;
		}

		// Token: 0x04005354 RID: 21332
		private Table __p;

		// Token: 0x04005355 RID: 21333
		[Nullable(2)]
		private FrozenDictionary<int, int> ItemCountsCache;
	}
}
