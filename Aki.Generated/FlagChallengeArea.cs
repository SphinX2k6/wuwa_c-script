using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C91 RID: 3217
	public struct FlagChallengeArea : IFlatbufferObject
	{
		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x06007103 RID: 28931 RVA: 0x00235391 File Offset: 0x00233591
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x0023539E File Offset: 0x0023359E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007105 RID: 28933 RVA: 0x002353A8 File Offset: 0x002335A8
		public static FlagChallengeArea GetRootAsFlagChallengeArea(ByteBuffer _bb)
		{
			return FlagChallengeArea.GetRootAsFlagChallengeArea(_bb, default(FlagChallengeArea));
		}

		// Token: 0x06007106 RID: 28934 RVA: 0x002353C4 File Offset: 0x002335C4
		public static FlagChallengeArea GetRootAsFlagChallengeArea(ByteBuffer _bb, FlagChallengeArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x002353E1 File Offset: 0x002335E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007108 RID: 28936 RVA: 0x002353F0 File Offset: 0x002335F0
		public FlagChallengeArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x06007109 RID: 28937 RVA: 0x00235400 File Offset: 0x00233600
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

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x0600710A RID: 28938 RVA: 0x0023543C File Offset: 0x0023363C
		public int LevelId
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

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x0600710B RID: 28939 RVA: 0x00235478 File Offset: 0x00233678
		public string Name
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

		// Token: 0x0600710C RID: 28940 RVA: 0x002354AF File Offset: 0x002336AF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x002354BE File Offset: 0x002336BE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x0600710E RID: 28942 RVA: 0x002354D8 File Offset: 0x002336D8
		public string Desc
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

		// Token: 0x0600710F RID: 28943 RVA: 0x00235510 File Offset: 0x00233710
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007110 RID: 28944 RVA: 0x00235520 File Offset: 0x00233720
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06007111 RID: 28945 RVA: 0x00235538 File Offset: 0x00233738
		public int Strongholds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x06007112 RID: 28946 RVA: 0x00235578 File Offset: 0x00233778
		public int StrongholdsLength
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

		// Token: 0x06007113 RID: 28947 RVA: 0x002355A4 File Offset: 0x002337A4
		public Span<int> GetStrongholdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06007114 RID: 28948 RVA: 0x002355B4 File Offset: 0x002337B4
		public int[] GetStrongholdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06007115 RID: 28949 RVA: 0x002355CC File Offset: 0x002337CC
		public int RecommendLevels(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x06007116 RID: 28950 RVA: 0x0023560C File Offset: 0x0023380C
		public int RecommendLevelsLength
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

		// Token: 0x06007117 RID: 28951 RVA: 0x00235638 File Offset: 0x00233838
		public Span<int> GetRecommendLevelsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06007118 RID: 28952 RVA: 0x00235648 File Offset: 0x00233848
		public int[] GetRecommendLevelsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x06007119 RID: 28953 RVA: 0x00235660 File Offset: 0x00233860
		public string IconPath
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

		// Token: 0x0600711A RID: 28954 RVA: 0x00235698 File Offset: 0x00233898
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600711B RID: 28955 RVA: 0x002356A8 File Offset: 0x002338A8
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x0600711C RID: 28956 RVA: 0x002356C0 File Offset: 0x002338C0
		public int UiPos
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

		// Token: 0x0600711D RID: 28957 RVA: 0x00235700 File Offset: 0x00233900
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendLevelsIter()或GetRecommendLevelsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendLevels()
		{
			FlagChallengeArea flagChallengeArea = this;
			return flagChallengeArea.GetRecommendLevelsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600711E RID: 28958 RVA: 0x00235724 File Offset: 0x00233924
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendLevelsIter()
		{
			FlagChallengeArea.<RecommendLevelsIter>d__37 <RecommendLevelsIter>d__ = new FlagChallengeArea.<RecommendLevelsIter>d__37(-2);
			<RecommendLevelsIter>d__.<>3__<>4__this = this;
			return <RecommendLevelsIter>d__;
		}

		// Token: 0x0600711F RID: 28959 RVA: 0x0023573C File Offset: 0x0023393C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StrongholdsIter()或GetStrongholdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Strongholds()
		{
			FlagChallengeArea flagChallengeArea = this;
			return flagChallengeArea.GetStrongholdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x00235760 File Offset: 0x00233960
		[NullableContext(1)]
		public readonly IEnumerable<int> StrongholdsIter()
		{
			FlagChallengeArea.<StrongholdsIter>d__39 <StrongholdsIter>d__ = new FlagChallengeArea.<StrongholdsIter>d__39(-2);
			<StrongholdsIter>d__.<>3__<>4__this = this;
			return <StrongholdsIter>d__;
		}

		// Token: 0x04004CE8 RID: 19688
		private Table __p;
	}
}
