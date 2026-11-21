using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D32 RID: 3378
	public struct ExploreReward : IFlatbufferObject
	{
		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06007172 RID: 29042 RVA: 0x0024774D File Offset: 0x0024594D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007173 RID: 29043 RVA: 0x0024775A File Offset: 0x0024595A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007174 RID: 29044 RVA: 0x00247764 File Offset: 0x00245964
		public static ExploreReward GetRootAsExploreReward(ByteBuffer _bb)
		{
			return ExploreReward.GetRootAsExploreReward(_bb, default(ExploreReward));
		}

		// Token: 0x06007175 RID: 29045 RVA: 0x00247780 File Offset: 0x00245980
		public static ExploreReward GetRootAsExploreReward(ByteBuffer _bb, ExploreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007176 RID: 29046 RVA: 0x0024779D File Offset: 0x0024599D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007177 RID: 29047 RVA: 0x002477AC File Offset: 0x002459AC
		public ExploreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06007178 RID: 29048 RVA: 0x002477BC File Offset: 0x002459BC
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

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06007179 RID: 29049 RVA: 0x002477F8 File Offset: 0x002459F8
		public int Country
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

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x0600717A RID: 29050 RVA: 0x00247834 File Offset: 0x00245A34
		public int ExploreLevel
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

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x0600717B RID: 29051 RVA: 0x00247870 File Offset: 0x00245A70
		public int NeedScore
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

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x0600717C RID: 29052 RVA: 0x002478B0 File Offset: 0x00245AB0
		public int Drop
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

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x0600717D RID: 29053 RVA: 0x002478F0 File Offset: 0x00245AF0
		public int ShowItem
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

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x0600717E RID: 29054 RVA: 0x00247930 File Offset: 0x00245B30
		public string ScoreName
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

		// Token: 0x0600717F RID: 29055 RVA: 0x00247968 File Offset: 0x00245B68
		public Span<byte> GetScoreNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007180 RID: 29056 RVA: 0x00247978 File Offset: 0x00245B78
		public byte[] GetScoreNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06007181 RID: 29057 RVA: 0x00247990 File Offset: 0x00245B90
		public string ScoreTexturePath
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

		// Token: 0x06007182 RID: 29058 RVA: 0x002479C8 File Offset: 0x00245BC8
		public Span<byte> GetScoreTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007183 RID: 29059 RVA: 0x002479D8 File Offset: 0x00245BD8
		public byte[] GetScoreTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x06007184 RID: 29060 RVA: 0x002479F0 File Offset: 0x00245BF0
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x06007185 RID: 29061 RVA: 0x00247A30 File Offset: 0x00245C30
		public string Pic
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

		// Token: 0x06007186 RID: 29062 RVA: 0x00247A68 File Offset: 0x00245C68
		public Span<byte> GetPicBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007187 RID: 29063 RVA: 0x00247A78 File Offset: 0x00245C78
		public byte[] GetPicArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x06007188 RID: 29064 RVA: 0x00247A90 File Offset: 0x00245C90
		public string RewardName
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

		// Token: 0x06007189 RID: 29065 RVA: 0x00247AC8 File Offset: 0x00245CC8
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600718A RID: 29066 RVA: 0x00247AD8 File Offset: 0x00245CD8
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x0600718B RID: 29067 RVA: 0x00247AF0 File Offset: 0x00245CF0
		public string Reward
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

		// Token: 0x0600718C RID: 29068 RVA: 0x00247B28 File Offset: 0x00245D28
		public Span<byte> GetRewardBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600718D RID: 29069 RVA: 0x00247B38 File Offset: 0x00245D38
		public byte[] GetRewardArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x0600718E RID: 29070 RVA: 0x00247B50 File Offset: 0x00245D50
		public int Help
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

		// Token: 0x04005279 RID: 21113
		private Table __p;
	}
}
