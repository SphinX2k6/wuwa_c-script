using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C92 RID: 3218
	public struct FlagChallengeLevel : IFlatbufferObject
	{
		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x06007121 RID: 28961 RVA: 0x00235775 File Offset: 0x00233975
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007122 RID: 28962 RVA: 0x00235782 File Offset: 0x00233982
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007123 RID: 28963 RVA: 0x0023578C File Offset: 0x0023398C
		public static FlagChallengeLevel GetRootAsFlagChallengeLevel(ByteBuffer _bb)
		{
			return FlagChallengeLevel.GetRootAsFlagChallengeLevel(_bb, default(FlagChallengeLevel));
		}

		// Token: 0x06007124 RID: 28964 RVA: 0x002357A8 File Offset: 0x002339A8
		public static FlagChallengeLevel GetRootAsFlagChallengeLevel(ByteBuffer _bb, FlagChallengeLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007125 RID: 28965 RVA: 0x002357C5 File Offset: 0x002339C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007126 RID: 28966 RVA: 0x002357D4 File Offset: 0x002339D4
		public FlagChallengeLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x06007127 RID: 28967 RVA: 0x002357E4 File Offset: 0x002339E4
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

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x06007128 RID: 28968 RVA: 0x00235820 File Offset: 0x00233A20
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

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x06007129 RID: 28969 RVA: 0x0023585C File Offset: 0x00233A5C
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

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x0600712A RID: 28970 RVA: 0x00235898 File Offset: 0x00233A98
		public int UnlockLevel
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

		// Token: 0x0600712B RID: 28971 RVA: 0x002358D8 File Offset: 0x00233AD8
		public int PreLevelId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x0600712C RID: 28972 RVA: 0x00235918 File Offset: 0x00233B18
		public int PreLevelIdLength
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

		// Token: 0x0600712D RID: 28973 RVA: 0x00235944 File Offset: 0x00233B44
		public Span<int> GetPreLevelIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600712E RID: 28974 RVA: 0x00235954 File Offset: 0x00233B54
		public int[] GetPreLevelIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x0600712F RID: 28975 RVA: 0x0023596C File Offset: 0x00233B6C
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

		// Token: 0x06007130 RID: 28976 RVA: 0x002359A4 File Offset: 0x00233BA4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007131 RID: 28977 RVA: 0x002359B4 File Offset: 0x00233BB4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x06007132 RID: 28978 RVA: 0x002359CC File Offset: 0x00233BCC
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

		// Token: 0x06007133 RID: 28979 RVA: 0x00235A04 File Offset: 0x00233C04
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007134 RID: 28980 RVA: 0x00235A14 File Offset: 0x00233C14
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x06007135 RID: 28981 RVA: 0x00235A2C File Offset: 0x00233C2C
		public int UiStyle
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x06007136 RID: 28982 RVA: 0x00235A6C File Offset: 0x00233C6C
		public bool IsHiddenLevel
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06007137 RID: 28983 RVA: 0x00235AAC File Offset: 0x00233CAC
		public int RecommendLevels(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x06007138 RID: 28984 RVA: 0x00235AEC File Offset: 0x00233CEC
		public int RecommendLevelsLength
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

		// Token: 0x06007139 RID: 28985 RVA: 0x00235B18 File Offset: 0x00233D18
		public Span<int> GetRecommendLevelsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600713A RID: 28986 RVA: 0x00235B28 File Offset: 0x00233D28
		public int[] GetRecommendLevelsArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600713B RID: 28987 RVA: 0x00235B40 File Offset: 0x00233D40
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreLevelIdIter()或GetPreLevelIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreLevelId()
		{
			FlagChallengeLevel flagChallengeLevel = this;
			return flagChallengeLevel.GetPreLevelIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600713C RID: 28988 RVA: 0x00235B64 File Offset: 0x00233D64
		[NullableContext(1)]
		public readonly IEnumerable<int> PreLevelIdIter()
		{
			FlagChallengeLevel.<PreLevelIdIter>d__39 <PreLevelIdIter>d__ = new FlagChallengeLevel.<PreLevelIdIter>d__39(-2);
			<PreLevelIdIter>d__.<>3__<>4__this = this;
			return <PreLevelIdIter>d__;
		}

		// Token: 0x0600713D RID: 28989 RVA: 0x00235B7C File Offset: 0x00233D7C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendLevelsIter()或GetRecommendLevelsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendLevels()
		{
			FlagChallengeLevel flagChallengeLevel = this;
			return flagChallengeLevel.GetRecommendLevelsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600713E RID: 28990 RVA: 0x00235BA0 File Offset: 0x00233DA0
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendLevelsIter()
		{
			FlagChallengeLevel.<RecommendLevelsIter>d__41 <RecommendLevelsIter>d__ = new FlagChallengeLevel.<RecommendLevelsIter>d__41(-2);
			<RecommendLevelsIter>d__.<>3__<>4__this = this;
			return <RecommendLevelsIter>d__;
		}

		// Token: 0x04004CE9 RID: 19689
		private Table __p;
	}
}
