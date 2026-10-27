using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C01 RID: 3073
	public struct DrinksDrinkBase : IFlatbufferObject
	{
		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x060063CE RID: 25550 RVA: 0x002170C1 File Offset: 0x002152C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060063CF RID: 25551 RVA: 0x002170CE File Offset: 0x002152CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060063D0 RID: 25552 RVA: 0x002170D8 File Offset: 0x002152D8
		public static DrinksDrinkBase GetRootAsDrinksDrinkBase(ByteBuffer _bb)
		{
			return DrinksDrinkBase.GetRootAsDrinksDrinkBase(_bb, default(DrinksDrinkBase));
		}

		// Token: 0x060063D1 RID: 25553 RVA: 0x002170F4 File Offset: 0x002152F4
		public static DrinksDrinkBase GetRootAsDrinksDrinkBase(ByteBuffer _bb, DrinksDrinkBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060063D2 RID: 25554 RVA: 0x00217111 File Offset: 0x00215311
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060063D3 RID: 25555 RVA: 0x00217120 File Offset: 0x00215320
		public DrinksDrinkBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x060063D4 RID: 25556 RVA: 0x00217130 File Offset: 0x00215330
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

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x060063D5 RID: 25557 RVA: 0x0021716C File Offset: 0x0021536C
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

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x060063D6 RID: 25558 RVA: 0x002171A8 File Offset: 0x002153A8
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

		// Token: 0x060063D7 RID: 25559 RVA: 0x002171DF File Offset: 0x002153DF
		public Span<byte> GetDrinkIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x002171EE File Offset: 0x002153EE
		public byte[] GetDrinkIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x060063D9 RID: 25561 RVA: 0x00217208 File Offset: 0x00215408
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

		// Token: 0x060063DA RID: 25562 RVA: 0x00217240 File Offset: 0x00215440
		public Span<byte> GetDrinkNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x00217250 File Offset: 0x00215450
		public byte[] GetDrinkNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x060063DC RID: 25564 RVA: 0x00217268 File Offset: 0x00215468
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

		// Token: 0x060063DD RID: 25565 RVA: 0x002172A8 File Offset: 0x002154A8
		public DicIntInt? Flavor(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x060063DE RID: 25566 RVA: 0x0021730C File Offset: 0x0021550C
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

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x060063DF RID: 25567 RVA: 0x00217338 File Offset: 0x00215538
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

		// Token: 0x060063E0 RID: 25568 RVA: 0x00217378 File Offset: 0x00215578
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FlavorFrozenDict()缓存字典，遍历请使用FlavorIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Flavor()
		{
			return this.FlavorIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060063E1 RID: 25569 RVA: 0x002173CE File Offset: 0x002155CE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> FlavorIter()
		{
			DrinksDrinkBase.<FlavorIter>d__28 <FlavorIter>d__ = new DrinksDrinkBase.<FlavorIter>d__28(-2);
			<FlavorIter>d__.<>3__<>4__this = this;
			return <FlavorIter>d__;
		}

		// Token: 0x060063E2 RID: 25570 RVA: 0x002173E4 File Offset: 0x002155E4
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

		// Token: 0x060063E3 RID: 25571 RVA: 0x00217418 File Offset: 0x00215618
		private void EnsureFlavorCacheIfNeeded()
		{
			if (this.FlavorCache != null)
			{
				return;
			}
			this.FlavorCache = this.FlavorIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060063E4 RID: 25572 RVA: 0x0021747E File Offset: 0x0021567E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetFlavorFrozenDict(int key)
		{
			this.EnsureFlavorCacheIfNeeded();
			return this.FlavorCache;
		}

		// Token: 0x04004C36 RID: 19510
		private Table __p;

		// Token: 0x04004C37 RID: 19511
		[Nullable(2)]
		private FrozenDictionary<int, int> FlavorCache;
	}
}
