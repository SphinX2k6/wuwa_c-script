using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE5 RID: 3557
	public struct GiftPackage : IFlatbufferObject
	{
		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x060080D8 RID: 32984 RVA: 0x0026A7C4 File Offset: 0x002689C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060080D9 RID: 32985 RVA: 0x0026A7D1 File Offset: 0x002689D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060080DA RID: 32986 RVA: 0x0026A7D8 File Offset: 0x002689D8
		public static GiftPackage GetRootAsGiftPackage(ByteBuffer _bb)
		{
			return GiftPackage.GetRootAsGiftPackage(_bb, default(GiftPackage));
		}

		// Token: 0x060080DB RID: 32987 RVA: 0x0026A7F4 File Offset: 0x002689F4
		public static GiftPackage GetRootAsGiftPackage(ByteBuffer _bb, GiftPackage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060080DC RID: 32988 RVA: 0x0026A811 File Offset: 0x00268A11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060080DD RID: 32989 RVA: 0x0026A820 File Offset: 0x00268A20
		public GiftPackage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x060080DE RID: 32990 RVA: 0x0026A830 File Offset: 0x00268A30
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

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x060080DF RID: 32991 RVA: 0x0026A86C File Offset: 0x00268A6C
		public GiftType Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return GiftType.Fixed;
				}
				return (GiftType)this.__p.bb.GetSbyte(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060080E0 RID: 32992 RVA: 0x0026A8A8 File Offset: 0x00268AA8
		public DicIntInt? Content(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x060080E1 RID: 32993 RVA: 0x0026A908 File Offset: 0x00268B08
		public int ContentLength
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

		// Token: 0x060080E2 RID: 32994 RVA: 0x0026A934 File Offset: 0x00268B34
		public DicIntInt? Weight(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x060080E3 RID: 32995 RVA: 0x0026A998 File Offset: 0x00268B98
		public int WeightLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x060080E4 RID: 32996 RVA: 0x0026A9C4 File Offset: 0x00268BC4
		public int AvailableNum
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

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x060080E5 RID: 32997 RVA: 0x0026AA04 File Offset: 0x00268C04
		public int ShowType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x060080E6 RID: 32998 RVA: 0x0026AA44 File Offset: 0x00268C44
		public int CheckGoodsMethod
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

		// Token: 0x060080E7 RID: 32999 RVA: 0x0026AA84 File Offset: 0x00268C84
		[NullableContext(1)]
		public Dictionary<int, int> Content()
		{
			return this.ContentIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060080E8 RID: 33000 RVA: 0x0026AADA File Offset: 0x00268CDA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ContentIter()
		{
			GiftPackage.<ContentIter>d__25 <ContentIter>d__ = new GiftPackage.<ContentIter>d__25(-2);
			<ContentIter>d__.<>3__<>4__this = this;
			return <ContentIter>d__;
		}

		// Token: 0x060080E9 RID: 33001 RVA: 0x0026AAF0 File Offset: 0x00268CF0
		[NullableContext(1)]
		public Dictionary<int, int> Weight()
		{
			return this.WeightIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060080EA RID: 33002 RVA: 0x0026AB46 File Offset: 0x00268D46
		[NullableContext(1)]
		public IEnumerable<DicIntInt> WeightIter()
		{
			GiftPackage.<WeightIter>d__27 <WeightIter>d__ = new GiftPackage.<WeightIter>d__27(-2);
			<WeightIter>d__.<>3__<>4__this = this;
			return <WeightIter>d__;
		}

		// Token: 0x060080EB RID: 33003 RVA: 0x0026AB5C File Offset: 0x00268D5C
		public int? GetContent(int key)
		{
			this.EnsureContentCacheIfNeeded();
			int value;
			if (!this.ContentCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060080EC RID: 33004 RVA: 0x0026AB90 File Offset: 0x00268D90
		public int? GetWeight(int key)
		{
			this.EnsureWeightCacheIfNeeded();
			int value;
			if (!this.WeightCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060080ED RID: 33005 RVA: 0x0026ABC4 File Offset: 0x00268DC4
		private void EnsureContentCacheIfNeeded()
		{
			if (this.ContentCache != null)
			{
				return;
			}
			this.ContentCache = this.ContentIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060080EE RID: 33006 RVA: 0x0026AC2C File Offset: 0x00268E2C
		private void EnsureWeightCacheIfNeeded()
		{
			if (this.WeightCache != null)
			{
				return;
			}
			this.WeightCache = this.WeightIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060080EF RID: 33007 RVA: 0x0026AC92 File Offset: 0x00268E92
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetContentFrozenDict()
		{
			this.EnsureContentCacheIfNeeded();
			return this.ContentCache;
		}

		// Token: 0x060080F0 RID: 33008 RVA: 0x0026ACA0 File Offset: 0x00268EA0
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetWeightFrozenDict()
		{
			this.EnsureWeightCacheIfNeeded();
			return this.WeightCache;
		}

		// Token: 0x04005359 RID: 21337
		private Table __p;

		// Token: 0x0400535A RID: 21338
		[Nullable(2)]
		private FrozenDictionary<int, int> ContentCache;

		// Token: 0x0400535B RID: 21339
		[Nullable(2)]
		private FrozenDictionary<int, int> WeightCache;
	}
}
