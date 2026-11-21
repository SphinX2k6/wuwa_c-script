using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001156 RID: 4438
	public struct RoleTowerStage : IFlatbufferObject
	{
		// Token: 0x17003453 RID: 13395
		// (get) Token: 0x0600D2B5 RID: 53941 RVA: 0x0031F35D File Offset: 0x0031D55D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D2B6 RID: 53942 RVA: 0x0031F36A File Offset: 0x0031D56A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D2B7 RID: 53943 RVA: 0x0031F374 File Offset: 0x0031D574
		public static RoleTowerStage GetRootAsRoleTowerStage(ByteBuffer _bb)
		{
			return RoleTowerStage.GetRootAsRoleTowerStage(_bb, default(RoleTowerStage));
		}

		// Token: 0x0600D2B8 RID: 53944 RVA: 0x0031F390 File Offset: 0x0031D590
		public static RoleTowerStage GetRootAsRoleTowerStage(ByteBuffer _bb, RoleTowerStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D2B9 RID: 53945 RVA: 0x0031F3AD File Offset: 0x0031D5AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D2BA RID: 53946 RVA: 0x0031F3BC File Offset: 0x0031D5BC
		public RoleTowerStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003454 RID: 13396
		// (get) Token: 0x0600D2BB RID: 53947 RVA: 0x0031F3CC File Offset: 0x0031D5CC
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

		// Token: 0x17003455 RID: 13397
		// (get) Token: 0x0600D2BC RID: 53948 RVA: 0x0031F408 File Offset: 0x0031D608
		public int Stage
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

		// Token: 0x17003456 RID: 13398
		// (get) Token: 0x0600D2BD RID: 53949 RVA: 0x0031F444 File Offset: 0x0031D644
		public int LevelPlayId
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

		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x0600D2BE RID: 53950 RVA: 0x0031F480 File Offset: 0x0031D680
		public string RoleTowerStageName
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

		// Token: 0x0600D2BF RID: 53951 RVA: 0x0031F4B8 File Offset: 0x0031D6B8
		public Span<byte> GetRoleTowerStageNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D2C0 RID: 53952 RVA: 0x0031F4C8 File Offset: 0x0031D6C8
		public byte[] GetRoleTowerStageNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x0600D2C1 RID: 53953 RVA: 0x0031F4E0 File Offset: 0x0031D6E0
		public string RoleTowerStageIcon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D2C2 RID: 53954 RVA: 0x0031F518 File Offset: 0x0031D718
		public Span<byte> GetRoleTowerStageIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D2C3 RID: 53955 RVA: 0x0031F528 File Offset: 0x0031D728
		public byte[] GetRoleTowerStageIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x0600D2C4 RID: 53956 RVA: 0x0031F540 File Offset: 0x0031D740
		public string RoleTowerStageIconBg
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

		// Token: 0x0600D2C5 RID: 53957 RVA: 0x0031F578 File Offset: 0x0031D778
		public Span<byte> GetRoleTowerStageIconBgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D2C6 RID: 53958 RVA: 0x0031F588 File Offset: 0x0031D788
		public byte[] GetRoleTowerStageIconBgArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700345A RID: 13402
		// (get) Token: 0x0600D2C7 RID: 53959 RVA: 0x0031F5A0 File Offset: 0x0031D7A0
		public string RoleTowerStageDesc
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

		// Token: 0x0600D2C8 RID: 53960 RVA: 0x0031F5D8 File Offset: 0x0031D7D8
		public Span<byte> GetRoleTowerStageDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D2C9 RID: 53961 RVA: 0x0031F5E8 File Offset: 0x0031D7E8
		public byte[] GetRoleTowerStageDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D2CA RID: 53962 RVA: 0x0031F600 File Offset: 0x0031D800
		public string RoleTowerStageDescParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700345B RID: 13403
		// (get) Token: 0x0600D2CB RID: 53963 RVA: 0x0031F63C File Offset: 0x0031D83C
		public int RoleTowerStageDescParamLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D2CC RID: 53964 RVA: 0x0031F668 File Offset: 0x0031D868
		public int StarUpPreview(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700345C RID: 13404
		// (get) Token: 0x0600D2CD RID: 53965 RVA: 0x0031F6A8 File Offset: 0x0031D8A8
		public int StarUpPreviewLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D2CE RID: 53966 RVA: 0x0031F6D4 File Offset: 0x0031D8D4
		public Span<int> GetStarUpPreviewBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600D2CF RID: 53967 RVA: 0x0031F6E4 File Offset: 0x0031D8E4
		public int[] GetStarUpPreviewArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600D2D0 RID: 53968 RVA: 0x0031F6FC File Offset: 0x0031D8FC
		public int RecommendTokenIds(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700345D RID: 13405
		// (get) Token: 0x0600D2D1 RID: 53969 RVA: 0x0031F73C File Offset: 0x0031D93C
		public int RecommendTokenIdsLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D2D2 RID: 53970 RVA: 0x0031F768 File Offset: 0x0031D968
		public Span<int> GetRecommendTokenIdsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600D2D3 RID: 53971 RVA: 0x0031F778 File Offset: 0x0031D978
		public int[] GetRecommendTokenIdsArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x1700345E RID: 13406
		// (get) Token: 0x0600D2D4 RID: 53972 RVA: 0x0031F790 File Offset: 0x0031D990
		public int FatigueCost
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D2D5 RID: 53973 RVA: 0x0031F7D0 File Offset: 0x0031D9D0
		public DicIntInt? TokenPreview(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700345F RID: 13407
		// (get) Token: 0x0600D2D6 RID: 53974 RVA: 0x0031F834 File Offset: 0x0031DA34
		public int TokenPreviewLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003460 RID: 13408
		// (get) Token: 0x0600D2D7 RID: 53975 RVA: 0x0031F860 File Offset: 0x0031DA60
		public int NextTokenDes
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

		// Token: 0x17003461 RID: 13409
		// (get) Token: 0x0600D2D8 RID: 53976 RVA: 0x0031F8A0 File Offset: 0x0031DAA0
		public int NextStarDes
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D2D9 RID: 53977 RVA: 0x0031F8DD File Offset: 0x0031DADD
		[NullableContext(1)]
		public int[] RecommendTokenIds()
		{
			return this.GetRecommendTokenIdsArray();
		}

		// Token: 0x0600D2DA RID: 53978 RVA: 0x0031F8E5 File Offset: 0x0031DAE5
		[NullableContext(1)]
		public IEnumerable<int> RecommendTokenIdsIter()
		{
			RoleTowerStage.<RecommendTokenIdsIter>d__53 <RecommendTokenIdsIter>d__ = new RoleTowerStage.<RecommendTokenIdsIter>d__53(-2);
			<RecommendTokenIdsIter>d__.<>3__<>4__this = this;
			return <RecommendTokenIdsIter>d__;
		}

		// Token: 0x0600D2DB RID: 53979 RVA: 0x0031F8FA File Offset: 0x0031DAFA
		[NullableContext(1)]
		public string[] RoleTowerStageDescParam()
		{
			return this.RoleTowerStageDescParamIter().ToArray<string>();
		}

		// Token: 0x0600D2DC RID: 53980 RVA: 0x0031F907 File Offset: 0x0031DB07
		[NullableContext(1)]
		public IEnumerable<string> RoleTowerStageDescParamIter()
		{
			RoleTowerStage.<RoleTowerStageDescParamIter>d__55 <RoleTowerStageDescParamIter>d__ = new RoleTowerStage.<RoleTowerStageDescParamIter>d__55(-2);
			<RoleTowerStageDescParamIter>d__.<>3__<>4__this = this;
			return <RoleTowerStageDescParamIter>d__;
		}

		// Token: 0x0600D2DD RID: 53981 RVA: 0x0031F91C File Offset: 0x0031DB1C
		[NullableContext(1)]
		public int[] StarUpPreview()
		{
			return this.GetStarUpPreviewArray();
		}

		// Token: 0x0600D2DE RID: 53982 RVA: 0x0031F924 File Offset: 0x0031DB24
		[NullableContext(1)]
		public IEnumerable<int> StarUpPreviewIter()
		{
			RoleTowerStage.<StarUpPreviewIter>d__57 <StarUpPreviewIter>d__ = new RoleTowerStage.<StarUpPreviewIter>d__57(-2);
			<StarUpPreviewIter>d__.<>3__<>4__this = this;
			return <StarUpPreviewIter>d__;
		}

		// Token: 0x0600D2DF RID: 53983 RVA: 0x0031F93C File Offset: 0x0031DB3C
		[NullableContext(1)]
		public Dictionary<int, int> TokenPreview()
		{
			return this.TokenPreviewIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D2E0 RID: 53984 RVA: 0x0031F992 File Offset: 0x0031DB92
		[NullableContext(1)]
		public IEnumerable<DicIntInt> TokenPreviewIter()
		{
			RoleTowerStage.<TokenPreviewIter>d__59 <TokenPreviewIter>d__ = new RoleTowerStage.<TokenPreviewIter>d__59(-2);
			<TokenPreviewIter>d__.<>3__<>4__this = this;
			return <TokenPreviewIter>d__;
		}

		// Token: 0x0600D2E1 RID: 53985 RVA: 0x0031F9A8 File Offset: 0x0031DBA8
		public int? GetTokenPreview(int key)
		{
			this.EnsureTokenPreviewCacheIfNeeded();
			int value;
			if (!this.TokenPreviewCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D2E2 RID: 53986 RVA: 0x0031F9DC File Offset: 0x0031DBDC
		private void EnsureTokenPreviewCacheIfNeeded()
		{
			if (this.TokenPreviewCache != null)
			{
				return;
			}
			this.TokenPreviewCache = this.TokenPreviewIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D2E3 RID: 53987 RVA: 0x0031FA42 File Offset: 0x0031DC42
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetTokenPreviewFrozenDict()
		{
			this.EnsureTokenPreviewCacheIfNeeded();
			return this.TokenPreviewCache;
		}

		// Token: 0x0400575D RID: 22365
		private Table __p;

		// Token: 0x0400575E RID: 22366
		[Nullable(2)]
		private FrozenDictionary<int, int> TokenPreviewCache;
	}
}
