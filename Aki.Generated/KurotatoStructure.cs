using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E99 RID: 3737
	public struct KurotatoStructure : IFlatbufferObject
	{
		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x060091C1 RID: 37313 RVA: 0x00290FBF File Offset: 0x0028F1BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060091C2 RID: 37314 RVA: 0x00290FCC File Offset: 0x0028F1CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060091C3 RID: 37315 RVA: 0x00290FD4 File Offset: 0x0028F1D4
		public static KurotatoStructure GetRootAsKurotatoStructure(ByteBuffer _bb)
		{
			return KurotatoStructure.GetRootAsKurotatoStructure(_bb, default(KurotatoStructure));
		}

		// Token: 0x060091C4 RID: 37316 RVA: 0x00290FF0 File Offset: 0x0028F1F0
		public static KurotatoStructure GetRootAsKurotatoStructure(ByteBuffer _bb, KurotatoStructure obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060091C5 RID: 37317 RVA: 0x0029100D File Offset: 0x0028F20D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060091C6 RID: 37318 RVA: 0x0029101C File Offset: 0x0028F21C
		public KurotatoStructure __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x060091C7 RID: 37319 RVA: 0x0029102C File Offset: 0x0028F22C
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

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x060091C8 RID: 37320 RVA: 0x00291068 File Offset: 0x0028F268
		public int BasicProperty
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

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x060091C9 RID: 37321 RVA: 0x002910A4 File Offset: 0x0028F2A4
		public int TemplateId
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

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x060091CA RID: 37322 RVA: 0x002910E0 File Offset: 0x0028F2E0
		public int SimpleCombatSubtypeId
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

		// Token: 0x060091CB RID: 37323 RVA: 0x00291120 File Offset: 0x0028F320
		public int Deathrattles(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x060091CC RID: 37324 RVA: 0x00291160 File Offset: 0x0028F360
		public int DeathrattlesLength
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

		// Token: 0x060091CD RID: 37325 RVA: 0x0029118C File Offset: 0x0028F38C
		public Span<int> GetDeathrattlesBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060091CE RID: 37326 RVA: 0x0029119C File Offset: 0x0028F39C
		public int[] GetDeathrattlesArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x060091CF RID: 37327 RVA: 0x002911B4 File Offset: 0x0028F3B4
		public string Type
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

		// Token: 0x060091D0 RID: 37328 RVA: 0x002911EC File Offset: 0x0028F3EC
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060091D1 RID: 37329 RVA: 0x002911FC File Offset: 0x0028F3FC
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x060091D2 RID: 37330 RVA: 0x00291214 File Offset: 0x0028F414
		public string Param1
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

		// Token: 0x060091D3 RID: 37331 RVA: 0x0029124C File Offset: 0x0028F44C
		public Span<byte> GetParam1Bytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060091D4 RID: 37332 RVA: 0x0029125C File Offset: 0x0028F45C
		public byte[] GetParam1Array()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x060091D5 RID: 37333 RVA: 0x00291274 File Offset: 0x0028F474
		public string Param2
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

		// Token: 0x060091D6 RID: 37334 RVA: 0x002912AC File Offset: 0x0028F4AC
		public Span<byte> GetParam2Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060091D7 RID: 37335 RVA: 0x002912BC File Offset: 0x0028F4BC
		public byte[] GetParam2Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x060091D8 RID: 37336 RVA: 0x002912D4 File Offset: 0x0028F4D4
		public string Param3
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060091D9 RID: 37337 RVA: 0x0029130C File Offset: 0x0028F50C
		public Span<byte> GetParam3Bytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060091DA RID: 37338 RVA: 0x0029131C File Offset: 0x0028F51C
		public byte[] GetParam3Array()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x060091DB RID: 37339 RVA: 0x00291334 File Offset: 0x0028F534
		public string Param4
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060091DC RID: 37340 RVA: 0x0029136C File Offset: 0x0028F56C
		public Span<byte> GetParam4Bytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060091DD RID: 37341 RVA: 0x0029137C File Offset: 0x0028F57C
		public byte[] GetParam4Array()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x060091DE RID: 37342 RVA: 0x00291394 File Offset: 0x0028F594
		public string Param5
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060091DF RID: 37343 RVA: 0x002913CC File Offset: 0x0028F5CC
		public Span<byte> GetParam5Bytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060091E0 RID: 37344 RVA: 0x002913DC File Offset: 0x0028F5DC
		public byte[] GetParam5Array()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x060091E1 RID: 37345 RVA: 0x002913F4 File Offset: 0x0028F5F4
		public string Param6
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060091E2 RID: 37346 RVA: 0x0029142C File Offset: 0x0028F62C
		public Span<byte> GetParam6Bytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060091E3 RID: 37347 RVA: 0x0029143C File Offset: 0x0028F63C
		public byte[] GetParam6Array()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x060091E4 RID: 37348 RVA: 0x00291454 File Offset: 0x0028F654
		public DicIntFloat? InheritScale(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntFloat?(default(DicIntFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x060091E5 RID: 37349 RVA: 0x002914B8 File Offset: 0x0028F6B8
		public int InheritScaleLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060091E6 RID: 37350 RVA: 0x002914E4 File Offset: 0x0028F6E4
		public DicIntInt? InheritSource(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x060091E7 RID: 37351 RVA: 0x00291548 File Offset: 0x0028F748
		public int InheritSourceLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060091E8 RID: 37352 RVA: 0x00291574 File Offset: 0x0028F774
		[NullableContext(1)]
		public int[] Deathrattles()
		{
			return this.GetDeathrattlesArray();
		}

		// Token: 0x060091E9 RID: 37353 RVA: 0x0029157C File Offset: 0x0028F77C
		[NullableContext(1)]
		public IEnumerable<int> DeathrattlesIter()
		{
			KurotatoStructure.<DeathrattlesIter>d__56 <DeathrattlesIter>d__ = new KurotatoStructure.<DeathrattlesIter>d__56(-2);
			<DeathrattlesIter>d__.<>3__<>4__this = this;
			return <DeathrattlesIter>d__;
		}

		// Token: 0x060091EA RID: 37354 RVA: 0x00291594 File Offset: 0x0028F794
		[NullableContext(1)]
		public Dictionary<int, float> InheritScale()
		{
			return this.InheritScaleIter().ToDictionary((DicIntFloat element) => element.Key, (DicIntFloat element) => element.Value);
		}

		// Token: 0x060091EB RID: 37355 RVA: 0x002915EA File Offset: 0x0028F7EA
		[NullableContext(1)]
		public IEnumerable<DicIntFloat> InheritScaleIter()
		{
			KurotatoStructure.<InheritScaleIter>d__58 <InheritScaleIter>d__ = new KurotatoStructure.<InheritScaleIter>d__58(-2);
			<InheritScaleIter>d__.<>3__<>4__this = this;
			return <InheritScaleIter>d__;
		}

		// Token: 0x060091EC RID: 37356 RVA: 0x00291600 File Offset: 0x0028F800
		[NullableContext(1)]
		public Dictionary<int, int> InheritSource()
		{
			return this.InheritSourceIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060091ED RID: 37357 RVA: 0x00291656 File Offset: 0x0028F856
		[NullableContext(1)]
		public IEnumerable<DicIntInt> InheritSourceIter()
		{
			KurotatoStructure.<InheritSourceIter>d__60 <InheritSourceIter>d__ = new KurotatoStructure.<InheritSourceIter>d__60(-2);
			<InheritSourceIter>d__.<>3__<>4__this = this;
			return <InheritSourceIter>d__;
		}

		// Token: 0x060091EE RID: 37358 RVA: 0x0029166C File Offset: 0x0028F86C
		public float? GetInheritScale(int key)
		{
			this.EnsureInheritScaleCacheIfNeeded();
			float value;
			if (!this.InheritScaleCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new float?(value);
		}

		// Token: 0x060091EF RID: 37359 RVA: 0x002916A0 File Offset: 0x0028F8A0
		public int? GetInheritSource(int key)
		{
			this.EnsureInheritSourceCacheIfNeeded();
			int value;
			if (!this.InheritSourceCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060091F0 RID: 37360 RVA: 0x002916D4 File Offset: 0x0028F8D4
		private void EnsureInheritScaleCacheIfNeeded()
		{
			if (this.InheritScaleCache != null)
			{
				return;
			}
			this.InheritScaleCache = this.InheritScaleIter().ToFrozenDictionary((DicIntFloat kvp) => kvp.Key, (DicIntFloat kvp) => kvp.Value, null);
		}

		// Token: 0x060091F1 RID: 37361 RVA: 0x0029173C File Offset: 0x0028F93C
		private void EnsureInheritSourceCacheIfNeeded()
		{
			if (this.InheritSourceCache != null)
			{
				return;
			}
			this.InheritSourceCache = this.InheritSourceIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060091F2 RID: 37362 RVA: 0x002917A2 File Offset: 0x0028F9A2
		[NullableContext(1)]
		public FrozenDictionary<int, float> GetInheritScaleFrozenDict()
		{
			this.EnsureInheritScaleCacheIfNeeded();
			return this.InheritScaleCache;
		}

		// Token: 0x060091F3 RID: 37363 RVA: 0x002917B0 File Offset: 0x0028F9B0
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetInheritSourceFrozenDict()
		{
			this.EnsureInheritSourceCacheIfNeeded();
			return this.InheritSourceCache;
		}

		// Token: 0x0400542B RID: 21547
		private Table __p;

		// Token: 0x0400542C RID: 21548
		[Nullable(2)]
		private FrozenDictionary<int, float> InheritScaleCache;

		// Token: 0x0400542D RID: 21549
		[Nullable(2)]
		private FrozenDictionary<int, int> InheritSourceCache;
	}
}
