using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE3 RID: 3299
	public struct DrinksDrinkBase : IFlatbufferObject
	{
		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x060069AD RID: 27053 RVA: 0x00236721 File Offset: 0x00234921
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060069AE RID: 27054 RVA: 0x0023672E File Offset: 0x0023492E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060069AF RID: 27055 RVA: 0x00236738 File Offset: 0x00234938
		public static DrinksDrinkBase GetRootAsDrinksDrinkBase(ByteBuffer _bb)
		{
			return DrinksDrinkBase.GetRootAsDrinksDrinkBase(_bb, default(DrinksDrinkBase));
		}

		// Token: 0x060069B0 RID: 27056 RVA: 0x00236754 File Offset: 0x00234954
		public static DrinksDrinkBase GetRootAsDrinksDrinkBase(ByteBuffer _bb, DrinksDrinkBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060069B1 RID: 27057 RVA: 0x00236771 File Offset: 0x00234971
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060069B2 RID: 27058 RVA: 0x00236780 File Offset: 0x00234980
		public DrinksDrinkBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x060069B3 RID: 27059 RVA: 0x00236790 File Offset: 0x00234990
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

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x060069B4 RID: 27060 RVA: 0x002367CC File Offset: 0x002349CC
		public int DrinkId
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

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x060069B5 RID: 27061 RVA: 0x00236808 File Offset: 0x00234A08
		public string DrinkIcon
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

		// Token: 0x060069B6 RID: 27062 RVA: 0x0023683F File Offset: 0x00234A3F
		public Span<byte> GetDrinkIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060069B7 RID: 27063 RVA: 0x0023684E File Offset: 0x00234A4E
		public byte[] GetDrinkIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x060069B8 RID: 27064 RVA: 0x00236868 File Offset: 0x00234A68
		public string DrinkName
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

		// Token: 0x060069B9 RID: 27065 RVA: 0x002368A0 File Offset: 0x00234AA0
		public Span<byte> GetDrinkNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x002368B0 File Offset: 0x00234AB0
		public byte[] GetDrinkNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x060069BB RID: 27067 RVA: 0x002368C8 File Offset: 0x00234AC8
		public int QTENum
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

		// Token: 0x060069BC RID: 27068 RVA: 0x00236908 File Offset: 0x00234B08
		public DicIntInt? Flavor(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x060069BD RID: 27069 RVA: 0x0023696C File Offset: 0x00234B6C
		public int FlavorLength
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

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x060069BE RID: 27070 RVA: 0x00236998 File Offset: 0x00234B98
		public int EffectId
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

		// Token: 0x060069BF RID: 27071 RVA: 0x002369D8 File Offset: 0x00234BD8
		[NullableContext(1)]
		public Dictionary<int, int> Flavor()
		{
			return this.FlavorIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060069C0 RID: 27072 RVA: 0x00236A2E File Offset: 0x00234C2E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> FlavorIter()
		{
			DrinksDrinkBase.<FlavorIter>d__28 <FlavorIter>d__ = new DrinksDrinkBase.<FlavorIter>d__28(-2);
			<FlavorIter>d__.<>3__<>4__this = this;
			return <FlavorIter>d__;
		}

		// Token: 0x060069C1 RID: 27073 RVA: 0x00236A44 File Offset: 0x00234C44
		public int? GetFlavor(int key)
		{
			this.EnsureFlavorCacheIfNeeded();
			int value;
			if (!this.FlavorCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060069C2 RID: 27074 RVA: 0x00236A78 File Offset: 0x00234C78
		private void EnsureFlavorCacheIfNeeded()
		{
			if (this.FlavorCache != null)
			{
				return;
			}
			this.FlavorCache = this.FlavorIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060069C3 RID: 27075 RVA: 0x00236ADE File Offset: 0x00234CDE
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetFlavorFrozenDict()
		{
			this.EnsureFlavorCacheIfNeeded();
			return this.FlavorCache;
		}

		// Token: 0x04005218 RID: 21016
		private Table __p;

		// Token: 0x04005219 RID: 21017
		[Nullable(2)]
		private FrozenDictionary<int, int> FlavorCache;
	}
}
