using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D96 RID: 3478
	public struct KurotatoBuild : IFlatbufferObject
	{
		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x060088A4 RID: 34980 RVA: 0x0026BD36 File Offset: 0x00269F36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060088A5 RID: 34981 RVA: 0x0026BD43 File Offset: 0x00269F43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060088A6 RID: 34982 RVA: 0x0026BD4C File Offset: 0x00269F4C
		public static KurotatoBuild GetRootAsKurotatoBuild(ByteBuffer _bb)
		{
			return KurotatoBuild.GetRootAsKurotatoBuild(_bb, default(KurotatoBuild));
		}

		// Token: 0x060088A7 RID: 34983 RVA: 0x0026BD68 File Offset: 0x00269F68
		public static KurotatoBuild GetRootAsKurotatoBuild(ByteBuffer _bb, KurotatoBuild obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060088A8 RID: 34984 RVA: 0x0026BD85 File Offset: 0x00269F85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060088A9 RID: 34985 RVA: 0x0026BD94 File Offset: 0x00269F94
		public KurotatoBuild __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x060088AA RID: 34986 RVA: 0x0026BDA4 File Offset: 0x00269FA4
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

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x060088AB RID: 34987 RVA: 0x0026BDE0 File Offset: 0x00269FE0
		public string Name
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

		// Token: 0x060088AC RID: 34988 RVA: 0x0026BE17 File Offset: 0x0026A017
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060088AD RID: 34989 RVA: 0x0026BE26 File Offset: 0x0026A026
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x060088AE RID: 34990 RVA: 0x0026BE40 File Offset: 0x0026A040
		public string Desc
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

		// Token: 0x060088AF RID: 34991 RVA: 0x0026BE77 File Offset: 0x0026A077
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060088B0 RID: 34992 RVA: 0x0026BE86 File Offset: 0x0026A086
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x060088B1 RID: 34993 RVA: 0x0026BEA0 File Offset: 0x0026A0A0
		public string Icon
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

		// Token: 0x060088B2 RID: 34994 RVA: 0x0026BED8 File Offset: 0x0026A0D8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060088B3 RID: 34995 RVA: 0x0026BEE8 File Offset: 0x0026A0E8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x060088B4 RID: 34996 RVA: 0x0026BF00 File Offset: 0x0026A100
		public DicIntInt? WeightMultiply(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x060088B5 RID: 34997 RVA: 0x0026BF64 File Offset: 0x0026A164
		public int WeightMultiplyLength
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

		// Token: 0x060088B6 RID: 34998 RVA: 0x0026BF90 File Offset: 0x0026A190
		[NullableContext(1)]
		[Obsolete("已废弃，请使用WeightMultiplyFrozenDict()缓存字典，遍历请使用WeightMultiplyIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> WeightMultiply()
		{
			return this.WeightMultiplyIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060088B7 RID: 34999 RVA: 0x0026BFE6 File Offset: 0x0026A1E6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> WeightMultiplyIter()
		{
			KurotatoBuild.<WeightMultiplyIter>d__26 <WeightMultiplyIter>d__ = new KurotatoBuild.<WeightMultiplyIter>d__26(-2);
			<WeightMultiplyIter>d__.<>3__<>4__this = this;
			return <WeightMultiplyIter>d__;
		}

		// Token: 0x060088B8 RID: 35000 RVA: 0x0026BFFC File Offset: 0x0026A1FC
		public int? GetWeightMultiply(int key)
		{
			this.EnsureWeightMultiplyCacheIfNeeded();
			int value;
			if (!this.WeightMultiplyCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060088B9 RID: 35001 RVA: 0x0026C030 File Offset: 0x0026A230
		private void EnsureWeightMultiplyCacheIfNeeded()
		{
			if (this.WeightMultiplyCache != null)
			{
				return;
			}
			this.WeightMultiplyCache = this.WeightMultiplyIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060088BA RID: 35002 RVA: 0x0026C096 File Offset: 0x0026A296
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetWeightMultiplyFrozenDict(int key)
		{
			this.EnsureWeightMultiplyCacheIfNeeded();
			return this.WeightMultiplyCache;
		}

		// Token: 0x04004E25 RID: 20005
		private Table __p;

		// Token: 0x04004E26 RID: 20006
		[Nullable(2)]
		private FrozenDictionary<int, int> WeightMultiplyCache;
	}
}
