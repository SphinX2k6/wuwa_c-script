using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA4 RID: 3236
	public struct FloroRanchCardGroup : IFlatbufferObject
	{
		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x060072D0 RID: 29392 RVA: 0x00239E29 File Offset: 0x00238029
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060072D1 RID: 29393 RVA: 0x00239E36 File Offset: 0x00238036
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060072D2 RID: 29394 RVA: 0x00239E40 File Offset: 0x00238040
		public static FloroRanchCardGroup GetRootAsFloroRanchCardGroup(ByteBuffer _bb)
		{
			return FloroRanchCardGroup.GetRootAsFloroRanchCardGroup(_bb, default(FloroRanchCardGroup));
		}

		// Token: 0x060072D3 RID: 29395 RVA: 0x00239E5C File Offset: 0x0023805C
		public static FloroRanchCardGroup GetRootAsFloroRanchCardGroup(ByteBuffer _bb, FloroRanchCardGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060072D4 RID: 29396 RVA: 0x00239E79 File Offset: 0x00238079
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060072D5 RID: 29397 RVA: 0x00239E88 File Offset: 0x00238088
		public FloroRanchCardGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x060072D6 RID: 29398 RVA: 0x00239E98 File Offset: 0x00238098
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

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x060072D7 RID: 29399 RVA: 0x00239ED4 File Offset: 0x002380D4
		public int Race
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

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x060072D8 RID: 29400 RVA: 0x00239F10 File Offset: 0x00238110
		public int RarityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060072D9 RID: 29401 RVA: 0x00239F4C File Offset: 0x0023814C
		public DicIntInt? Minimum(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x060072DA RID: 29402 RVA: 0x00239FB0 File Offset: 0x002381B0
		public int MinimumLength
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

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x060072DB RID: 29403 RVA: 0x00239FDC File Offset: 0x002381DC
		public int Price
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

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x060072DC RID: 29404 RVA: 0x0023A01C File Offset: 0x0023821C
		public string Name
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

		// Token: 0x060072DD RID: 29405 RVA: 0x0023A054 File Offset: 0x00238254
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060072DE RID: 29406 RVA: 0x0023A064 File Offset: 0x00238264
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x060072DF RID: 29407 RVA: 0x0023A07C File Offset: 0x0023827C
		public string Desc
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

		// Token: 0x060072E0 RID: 29408 RVA: 0x0023A0B4 File Offset: 0x002382B4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060072E1 RID: 29409 RVA: 0x0023A0C4 File Offset: 0x002382C4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x060072E2 RID: 29410 RVA: 0x0023A0DC File Offset: 0x002382DC
		public string Icon
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

		// Token: 0x060072E3 RID: 29411 RVA: 0x0023A114 File Offset: 0x00238314
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060072E4 RID: 29412 RVA: 0x0023A124 File Offset: 0x00238324
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x060072E5 RID: 29413 RVA: 0x0023A13C File Offset: 0x0023833C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用MinimumFrozenDict()缓存字典，遍历请使用MinimumIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Minimum()
		{
			return this.MinimumIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060072E6 RID: 29414 RVA: 0x0023A192 File Offset: 0x00238392
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> MinimumIter()
		{
			FloroRanchCardGroup.<MinimumIter>d__32 <MinimumIter>d__ = new FloroRanchCardGroup.<MinimumIter>d__32(-2);
			<MinimumIter>d__.<>3__<>4__this = this;
			return <MinimumIter>d__;
		}

		// Token: 0x060072E7 RID: 29415 RVA: 0x0023A1A8 File Offset: 0x002383A8
		public int? GetMinimum(int key)
		{
			this.EnsureMinimumCacheIfNeeded();
			int value;
			if (!this.MinimumCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060072E8 RID: 29416 RVA: 0x0023A1DC File Offset: 0x002383DC
		private void EnsureMinimumCacheIfNeeded()
		{
			if (this.MinimumCache != null)
			{
				return;
			}
			this.MinimumCache = this.MinimumIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060072E9 RID: 29417 RVA: 0x0023A242 File Offset: 0x00238442
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetMinimumFrozenDict(int key)
		{
			this.EnsureMinimumCacheIfNeeded();
			return this.MinimumCache;
		}

		// Token: 0x04004D05 RID: 19717
		private Table __p;

		// Token: 0x04004D06 RID: 19718
		[Nullable(2)]
		private FrozenDictionary<int, int> MinimumCache;
	}
}
