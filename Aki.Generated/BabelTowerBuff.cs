using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B1C RID: 2844
	public struct BabelTowerBuff : IFlatbufferObject
	{
		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06004A7C RID: 19068 RVA: 0x001DC3D4 File Offset: 0x001DA5D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x001DC3E1 File Offset: 0x001DA5E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x001DC3E8 File Offset: 0x001DA5E8
		public static BabelTowerBuff GetRootAsBabelTowerBuff(ByteBuffer _bb)
		{
			return BabelTowerBuff.GetRootAsBabelTowerBuff(_bb, default(BabelTowerBuff));
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x001DC404 File Offset: 0x001DA604
		public static BabelTowerBuff GetRootAsBabelTowerBuff(ByteBuffer _bb, BabelTowerBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x001DC421 File Offset: 0x001DA621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x001DC430 File Offset: 0x001DA630
		public BabelTowerBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06004A82 RID: 19074 RVA: 0x001DC440 File Offset: 0x001DA640
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

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06004A83 RID: 19075 RVA: 0x001DC47C File Offset: 0x001DA67C
		public int Star
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

		// Token: 0x06004A84 RID: 19076 RVA: 0x001DC4B8 File Offset: 0x001DA6B8
		public int DifficultPreLevel(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06004A85 RID: 19077 RVA: 0x001DC4F8 File Offset: 0x001DA6F8
		public int DifficultPreLevelLength
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

		// Token: 0x06004A86 RID: 19078 RVA: 0x001DC523 File Offset: 0x001DA723
		public Span<int> GetDifficultPreLevelBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x001DC532 File Offset: 0x001DA732
		public int[] GetDifficultPreLevelArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x001DC54C File Offset: 0x001DA74C
		public DicIntInt? DifficultPreLevelStar(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06004A89 RID: 19081 RVA: 0x001DC5B0 File Offset: 0x001DA7B0
		public int DifficultPreLevelStarLength
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

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06004A8A RID: 19082 RVA: 0x001DC5DC File Offset: 0x001DA7DC
		public int DifficultLimitTime
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

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06004A8B RID: 19083 RVA: 0x001DC61C File Offset: 0x001DA81C
		public string Texture
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

		// Token: 0x06004A8C RID: 19084 RVA: 0x001DC654 File Offset: 0x001DA854
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x001DC664 File Offset: 0x001DA864
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06004A8E RID: 19086 RVA: 0x001DC67C File Offset: 0x001DA87C
		public string NameText
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

		// Token: 0x06004A8F RID: 19087 RVA: 0x001DC6B4 File Offset: 0x001DA8B4
		public Span<byte> GetNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004A90 RID: 19088 RVA: 0x001DC6C4 File Offset: 0x001DA8C4
		public byte[] GetNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06004A91 RID: 19089 RVA: 0x001DC6DC File Offset: 0x001DA8DC
		public string DesText
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

		// Token: 0x06004A92 RID: 19090 RVA: 0x001DC714 File Offset: 0x001DA914
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x001DC724 File Offset: 0x001DA924
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x001DC73C File Offset: 0x001DA93C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DifficultPreLevelIter()或GetDifficultPreLevelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DifficultPreLevel()
		{
			BabelTowerBuff babelTowerBuff = this;
			return babelTowerBuff.GetDifficultPreLevelArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004A95 RID: 19093 RVA: 0x001DC760 File Offset: 0x001DA960
		[NullableContext(1)]
		public readonly IEnumerable<int> DifficultPreLevelIter()
		{
			BabelTowerBuff.<DifficultPreLevelIter>d__35 <DifficultPreLevelIter>d__ = new BabelTowerBuff.<DifficultPreLevelIter>d__35(-2);
			<DifficultPreLevelIter>d__.<>3__<>4__this = this;
			return <DifficultPreLevelIter>d__;
		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x001DC778 File Offset: 0x001DA978
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DifficultPreLevelStarFrozenDict()缓存字典，遍历请使用DifficultPreLevelStarIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DifficultPreLevelStar()
		{
			return this.DifficultPreLevelStarIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x001DC7CE File Offset: 0x001DA9CE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DifficultPreLevelStarIter()
		{
			BabelTowerBuff.<DifficultPreLevelStarIter>d__37 <DifficultPreLevelStarIter>d__ = new BabelTowerBuff.<DifficultPreLevelStarIter>d__37(-2);
			<DifficultPreLevelStarIter>d__.<>3__<>4__this = this;
			return <DifficultPreLevelStarIter>d__;
		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x001DC7E4 File Offset: 0x001DA9E4
		public int? GetDifficultPreLevelStar(int key)
		{
			this.EnsureDifficultPreLevelStarCacheIfNeeded();
			int value;
			if (!this.DifficultPreLevelStarCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004A99 RID: 19097 RVA: 0x001DC818 File Offset: 0x001DAA18
		private void EnsureDifficultPreLevelStarCacheIfNeeded()
		{
			if (this.DifficultPreLevelStarCache != null)
			{
				return;
			}
			this.DifficultPreLevelStarCache = this.DifficultPreLevelStarIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x001DC87E File Offset: 0x001DAA7E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDifficultPreLevelStarFrozenDict(int key)
		{
			this.EnsureDifficultPreLevelStarCacheIfNeeded();
			return this.DifficultPreLevelStarCache;
		}

		// Token: 0x04004B0B RID: 19211
		private Table __p;

		// Token: 0x04004B0C RID: 19212
		[Nullable(2)]
		private FrozenDictionary<int, int> DifficultPreLevelStarCache;
	}
}
