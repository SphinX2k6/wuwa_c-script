using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA1 RID: 2977
	public struct CookProcessed : IFlatbufferObject
	{
		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06005978 RID: 22904 RVA: 0x001FFD51 File Offset: 0x001FDF51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x001FFD5E File Offset: 0x001FDF5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x001FFD68 File Offset: 0x001FDF68
		public static CookProcessed GetRootAsCookProcessed(ByteBuffer _bb)
		{
			return CookProcessed.GetRootAsCookProcessed(_bb, default(CookProcessed));
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x001FFD84 File Offset: 0x001FDF84
		public static CookProcessed GetRootAsCookProcessed(ByteBuffer _bb, CookProcessed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x001FFDA1 File Offset: 0x001FDFA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x001FFDB0 File Offset: 0x001FDFB0
		public CookProcessed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x0600597E RID: 22910 RVA: 0x001FFDC0 File Offset: 0x001FDFC0
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

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x0600597F RID: 22911 RVA: 0x001FFDFC File Offset: 0x001FDFFC
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

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06005980 RID: 22912 RVA: 0x001FFE38 File Offset: 0x001FE038
		public bool Unlock
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06005981 RID: 22913 RVA: 0x001FFE78 File Offset: 0x001FE078
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

		// Token: 0x06005982 RID: 22914 RVA: 0x001FFEB0 File Offset: 0x001FE0B0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005983 RID: 22915 RVA: 0x001FFEC0 File Offset: 0x001FE0C0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x001FFED8 File Offset: 0x001FE0D8
		public OneItemConfig? ConsumeItemsId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new OneItemConfig?(default(OneItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06005985 RID: 22917 RVA: 0x001FFF3C File Offset: 0x001FE13C
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

		// Token: 0x06005986 RID: 22918 RVA: 0x001FFF68 File Offset: 0x001FE168
		public DicIntInt? LeastItemId(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06005987 RID: 22919 RVA: 0x001FFFCC File Offset: 0x001FE1CC
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

		// Token: 0x06005988 RID: 22920 RVA: 0x001FFFF8 File Offset: 0x001FE1F8
		public int InterationId(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06005989 RID: 22921 RVA: 0x00200038 File Offset: 0x001FE238
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

		// Token: 0x0600598A RID: 22922 RVA: 0x00200064 File Offset: 0x001FE264
		public Span<int> GetInterationIdBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600598B RID: 22923 RVA: 0x00200074 File Offset: 0x001FE274
		public int[] GetInterationIdArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600598C RID: 22924 RVA: 0x0020008C File Offset: 0x001FE28C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConsumeItemsIdIter()或GetConsumeItemsIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly OneItemConfig[] ConsumeItemsId()
		{
			return this.ConsumeItemsIdIter().ToArray<OneItemConfig>();
		}

		// Token: 0x0600598D RID: 22925 RVA: 0x00200099 File Offset: 0x001FE299
		[NullableContext(1)]
		public readonly IEnumerable<OneItemConfig> ConsumeItemsIdIter()
		{
			CookProcessed.<ConsumeItemsIdIter>d__30 <ConsumeItemsIdIter>d__ = new CookProcessed.<ConsumeItemsIdIter>d__30(-2);
			<ConsumeItemsIdIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIdIter>d__;
		}

		// Token: 0x0600598E RID: 22926 RVA: 0x002000B0 File Offset: 0x001FE2B0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InterationIdIter()或GetInterationIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InterationId()
		{
			CookProcessed cookProcessed = this;
			return cookProcessed.GetInterationIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x002000D4 File Offset: 0x001FE2D4
		[NullableContext(1)]
		public readonly IEnumerable<int> InterationIdIter()
		{
			CookProcessed.<InterationIdIter>d__32 <InterationIdIter>d__ = new CookProcessed.<InterationIdIter>d__32(-2);
			<InterationIdIter>d__.<>3__<>4__this = this;
			return <InterationIdIter>d__;
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x002000EC File Offset: 0x001FE2EC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用LeastItemIdFrozenDict()缓存字典，遍历请使用LeastItemIdIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> LeastItemId()
		{
			return this.LeastItemIdIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x00200142 File Offset: 0x001FE342
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> LeastItemIdIter()
		{
			CookProcessed.<LeastItemIdIter>d__34 <LeastItemIdIter>d__ = new CookProcessed.<LeastItemIdIter>d__34(-2);
			<LeastItemIdIter>d__.<>3__<>4__this = this;
			return <LeastItemIdIter>d__;
		}

		// Token: 0x06005992 RID: 22930 RVA: 0x00200158 File Offset: 0x001FE358
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

		// Token: 0x06005993 RID: 22931 RVA: 0x0020018C File Offset: 0x001FE38C
		private void EnsureLeastItemIdCacheIfNeeded()
		{
			if (this.LeastItemIdCache != null)
			{
				return;
			}
			this.LeastItemIdCache = this.LeastItemIdIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005994 RID: 22932 RVA: 0x002001F2 File Offset: 0x001FE3F2
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetLeastItemIdFrozenDict(int key)
		{
			this.EnsureLeastItemIdCacheIfNeeded();
			return this.LeastItemIdCache;
		}

		// Token: 0x04004BC3 RID: 19395
		private Table __p;

		// Token: 0x04004BC4 RID: 19396
		[Nullable(2)]
		private FrozenDictionary<int, int> LeastItemIdCache;
	}
}
