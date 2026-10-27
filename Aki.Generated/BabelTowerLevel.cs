using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B22 RID: 2850
	public struct BabelTowerLevel : IFlatbufferObject
	{
		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06004AFA RID: 19194 RVA: 0x001DD5A4 File Offset: 0x001DB7A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004AFB RID: 19195 RVA: 0x001DD5B1 File Offset: 0x001DB7B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004AFC RID: 19196 RVA: 0x001DD5B8 File Offset: 0x001DB7B8
		public static BabelTowerLevel GetRootAsBabelTowerLevel(ByteBuffer _bb)
		{
			return BabelTowerLevel.GetRootAsBabelTowerLevel(_bb, default(BabelTowerLevel));
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x001DD5D4 File Offset: 0x001DB7D4
		public static BabelTowerLevel GetRootAsBabelTowerLevel(ByteBuffer _bb, BabelTowerLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x001DD5F1 File Offset: 0x001DB7F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004AFF RID: 19199 RVA: 0x001DD600 File Offset: 0x001DB800
		public BabelTowerLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06004B00 RID: 19200 RVA: 0x001DD610 File Offset: 0x001DB810
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

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06004B01 RID: 19201 RVA: 0x001DD64C File Offset: 0x001DB84C
		public int ActivityId
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

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06004B02 RID: 19202 RVA: 0x001DD688 File Offset: 0x001DB888
		public int InstId
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

		// Token: 0x06004B03 RID: 19203 RVA: 0x001DD6C4 File Offset: 0x001DB8C4
		public DicIntInt? MonstMaxLifeAddRatio(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06004B04 RID: 19204 RVA: 0x001DD728 File Offset: 0x001DB928
		public int MonstMaxLifeAddRatioLength
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

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06004B05 RID: 19205 RVA: 0x001DD754 File Offset: 0x001DB954
		public bool IsDifficult
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06004B06 RID: 19206 RVA: 0x001DD794 File Offset: 0x001DB994
		public string NameText
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

		// Token: 0x06004B07 RID: 19207 RVA: 0x001DD7CC File Offset: 0x001DB9CC
		public Span<byte> GetNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x001DD7DC File Offset: 0x001DB9DC
		public byte[] GetNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06004B09 RID: 19209 RVA: 0x001DD7F4 File Offset: 0x001DB9F4
		public string DesText
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

		// Token: 0x06004B0A RID: 19210 RVA: 0x001DD82C File Offset: 0x001DBA2C
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x001DD83C File Offset: 0x001DBA3C
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06004B0C RID: 19212 RVA: 0x001DD854 File Offset: 0x001DBA54
		public string LevelDesText
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

		// Token: 0x06004B0D RID: 19213 RVA: 0x001DD88C File Offset: 0x001DBA8C
		public Span<byte> GetLevelDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004B0E RID: 19214 RVA: 0x001DD89C File Offset: 0x001DBA9C
		public byte[] GetLevelDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06004B0F RID: 19215 RVA: 0x001DD8B4 File Offset: 0x001DBAB4
		public string BossNameText
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

		// Token: 0x06004B10 RID: 19216 RVA: 0x001DD8EC File Offset: 0x001DBAEC
		public Span<byte> GetBossNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x001DD8FC File Offset: 0x001DBAFC
		public byte[] GetBossNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06004B12 RID: 19218 RVA: 0x001DD914 File Offset: 0x001DBB14
		public string Texture
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

		// Token: 0x06004B13 RID: 19219 RVA: 0x001DD94C File Offset: 0x001DBB4C
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x001DD95C File Offset: 0x001DBB5C
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06004B15 RID: 19221 RVA: 0x001DD974 File Offset: 0x001DBB74
		public string BossTexture
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

		// Token: 0x06004B16 RID: 19222 RVA: 0x001DD9AC File Offset: 0x001DBBAC
		public Span<byte> GetBossTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x001DD9BC File Offset: 0x001DBBBC
		public byte[] GetBossTextureArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06004B18 RID: 19224 RVA: 0x001DD9D4 File Offset: 0x001DBBD4
		public string BossTitleTexture
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

		// Token: 0x06004B19 RID: 19225 RVA: 0x001DDA0C File Offset: 0x001DBC0C
		public Span<byte> GetBossTitleTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x001DDA1C File Offset: 0x001DBC1C
		public byte[] GetBossTitleTextureArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06004B1B RID: 19227 RVA: 0x001DDA34 File Offset: 0x001DBC34
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x001DDA74 File Offset: 0x001DBC74
		public int FixBabelDeTermds(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06004B1D RID: 19229 RVA: 0x001DDAB4 File Offset: 0x001DBCB4
		public int FixBabelDeTermdsLength
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

		// Token: 0x06004B1E RID: 19230 RVA: 0x001DDAE0 File Offset: 0x001DBCE0
		public Span<int> GetFixBabelDeTermdsBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x001DDAF0 File Offset: 0x001DBCF0
		public int[] GetFixBabelDeTermdsArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x001DDB08 File Offset: 0x001DBD08
		public int OptionalBabelBuff(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06004B21 RID: 19233 RVA: 0x001DDB48 File Offset: 0x001DBD48
		public int OptionalBabelBuffLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x001DDB74 File Offset: 0x001DBD74
		public Span<int> GetOptionalBabelBuffBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x001DDB84 File Offset: 0x001DBD84
		public int[] GetOptionalBabelBuffArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06004B24 RID: 19236 RVA: 0x001DDB9C File Offset: 0x001DBD9C
		public int OptionalBabelBuffNum
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06004B25 RID: 19237 RVA: 0x001DDBDC File Offset: 0x001DBDDC
		public int PassStar
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06004B26 RID: 19238 RVA: 0x001DDC1C File Offset: 0x001DBE1C
		public int ReviveStar
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06004B27 RID: 19239 RVA: 0x001DDC5C File Offset: 0x001DBE5C
		public int ReviveBuffId
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x001DDC9C File Offset: 0x001DBE9C
		public int BabelTowerDeTermMutexArray(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06004B29 RID: 19241 RVA: 0x001DDCDC File Offset: 0x001DBEDC
		public int BabelTowerDeTermMutexArrayLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x001DDD08 File Offset: 0x001DBF08
		public Span<int> GetBabelTowerDeTermMutexArrayBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x001DDD18 File Offset: 0x001DBF18
		public int[] GetBabelTowerDeTermMutexArrayArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x001DDD30 File Offset: 0x001DBF30
		public int UnRecommendRoleList(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06004B2D RID: 19245 RVA: 0x001DDD70 File Offset: 0x001DBF70
		public int UnRecommendRoleListLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x001DDD9C File Offset: 0x001DBF9C
		public Span<int> GetUnRecommendRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x001DDDAC File Offset: 0x001DBFAC
		public int[] GetUnRecommendRoleListArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x001DDDC4 File Offset: 0x001DBFC4
		public int RecommendBuff(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06004B31 RID: 19249 RVA: 0x001DDE04 File Offset: 0x001DC004
		public int RecommendBuffLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x001DDE30 File Offset: 0x001DC030
		public Span<int> GetRecommendBuffBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x001DDE40 File Offset: 0x001DC040
		public int[] GetRecommendBuffArray()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x001DDE58 File Offset: 0x001DC058
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BabelTowerDeTermMutexArrayIter()或GetBabelTowerDeTermMutexArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BabelTowerDeTermMutexArray()
		{
			BabelTowerLevel babelTowerLevel = this;
			return babelTowerLevel.GetBabelTowerDeTermMutexArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x001DDE7C File Offset: 0x001DC07C
		[NullableContext(1)]
		public readonly IEnumerable<int> BabelTowerDeTermMutexArrayIter()
		{
			BabelTowerLevel.<BabelTowerDeTermMutexArrayIter>d__83 <BabelTowerDeTermMutexArrayIter>d__ = new BabelTowerLevel.<BabelTowerDeTermMutexArrayIter>d__83(-2);
			<BabelTowerDeTermMutexArrayIter>d__.<>3__<>4__this = this;
			return <BabelTowerDeTermMutexArrayIter>d__;
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x001DDE94 File Offset: 0x001DC094
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FixBabelDeTermdsIter()或GetFixBabelDeTermdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FixBabelDeTermds()
		{
			BabelTowerLevel babelTowerLevel = this;
			return babelTowerLevel.GetFixBabelDeTermdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x001DDEB8 File Offset: 0x001DC0B8
		[NullableContext(1)]
		public readonly IEnumerable<int> FixBabelDeTermdsIter()
		{
			BabelTowerLevel.<FixBabelDeTermdsIter>d__85 <FixBabelDeTermdsIter>d__ = new BabelTowerLevel.<FixBabelDeTermdsIter>d__85(-2);
			<FixBabelDeTermdsIter>d__.<>3__<>4__this = this;
			return <FixBabelDeTermdsIter>d__;
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x001DDED0 File Offset: 0x001DC0D0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用MonstMaxLifeAddRatioFrozenDict()缓存字典，遍历请使用MonstMaxLifeAddRatioIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> MonstMaxLifeAddRatio()
		{
			return this.MonstMaxLifeAddRatioIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x001DDF26 File Offset: 0x001DC126
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> MonstMaxLifeAddRatioIter()
		{
			BabelTowerLevel.<MonstMaxLifeAddRatioIter>d__87 <MonstMaxLifeAddRatioIter>d__ = new BabelTowerLevel.<MonstMaxLifeAddRatioIter>d__87(-2);
			<MonstMaxLifeAddRatioIter>d__.<>3__<>4__this = this;
			return <MonstMaxLifeAddRatioIter>d__;
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x001DDF3C File Offset: 0x001DC13C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OptionalBabelBuffIter()或GetOptionalBabelBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] OptionalBabelBuff()
		{
			BabelTowerLevel babelTowerLevel = this;
			return babelTowerLevel.GetOptionalBabelBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x001DDF60 File Offset: 0x001DC160
		[NullableContext(1)]
		public readonly IEnumerable<int> OptionalBabelBuffIter()
		{
			BabelTowerLevel.<OptionalBabelBuffIter>d__89 <OptionalBabelBuffIter>d__ = new BabelTowerLevel.<OptionalBabelBuffIter>d__89(-2);
			<OptionalBabelBuffIter>d__.<>3__<>4__this = this;
			return <OptionalBabelBuffIter>d__;
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x001DDF78 File Offset: 0x001DC178
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendBuffIter()或GetRecommendBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendBuff()
		{
			BabelTowerLevel babelTowerLevel = this;
			return babelTowerLevel.GetRecommendBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x001DDF9C File Offset: 0x001DC19C
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendBuffIter()
		{
			BabelTowerLevel.<RecommendBuffIter>d__91 <RecommendBuffIter>d__ = new BabelTowerLevel.<RecommendBuffIter>d__91(-2);
			<RecommendBuffIter>d__.<>3__<>4__this = this;
			return <RecommendBuffIter>d__;
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x001DDFB4 File Offset: 0x001DC1B4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnRecommendRoleListIter()或GetUnRecommendRoleListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnRecommendRoleList()
		{
			BabelTowerLevel babelTowerLevel = this;
			return babelTowerLevel.GetUnRecommendRoleListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x001DDFD8 File Offset: 0x001DC1D8
		[NullableContext(1)]
		public readonly IEnumerable<int> UnRecommendRoleListIter()
		{
			BabelTowerLevel.<UnRecommendRoleListIter>d__93 <UnRecommendRoleListIter>d__ = new BabelTowerLevel.<UnRecommendRoleListIter>d__93(-2);
			<UnRecommendRoleListIter>d__.<>3__<>4__this = this;
			return <UnRecommendRoleListIter>d__;
		}

		// Token: 0x06004B40 RID: 19264 RVA: 0x001DDFF0 File Offset: 0x001DC1F0
		public int? GetMonstMaxLifeAddRatio(int key)
		{
			this.EnsureMonstMaxLifeAddRatioCacheIfNeeded();
			int value;
			if (!this.MonstMaxLifeAddRatioCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004B41 RID: 19265 RVA: 0x001DE024 File Offset: 0x001DC224
		private void EnsureMonstMaxLifeAddRatioCacheIfNeeded()
		{
			if (this.MonstMaxLifeAddRatioCache != null)
			{
				return;
			}
			this.MonstMaxLifeAddRatioCache = this.MonstMaxLifeAddRatioIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x001DE08A File Offset: 0x001DC28A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetMonstMaxLifeAddRatioFrozenDict(int key)
		{
			this.EnsureMonstMaxLifeAddRatioCacheIfNeeded();
			return this.MonstMaxLifeAddRatioCache;
		}

		// Token: 0x04004B13 RID: 19219
		private Table __p;

		// Token: 0x04004B14 RID: 19220
		[Nullable(2)]
		private FrozenDictionary<int, int> MonstMaxLifeAddRatioCache;
	}
}
