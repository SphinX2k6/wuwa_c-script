using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B6 RID: 4278
	public struct RiskHarvestInst : IFlatbufferObject
	{
		// Token: 0x17002F0F RID: 12047
		// (get) Token: 0x0600C3B9 RID: 50105 RVA: 0x002FD9F6 File Offset: 0x002FBBF6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C3BA RID: 50106 RVA: 0x002FDA03 File Offset: 0x002FBC03
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C3BB RID: 50107 RVA: 0x002FDA0C File Offset: 0x002FBC0C
		public static RiskHarvestInst GetRootAsRiskHarvestInst(ByteBuffer _bb)
		{
			return RiskHarvestInst.GetRootAsRiskHarvestInst(_bb, default(RiskHarvestInst));
		}

		// Token: 0x0600C3BC RID: 50108 RVA: 0x002FDA28 File Offset: 0x002FBC28
		public static RiskHarvestInst GetRootAsRiskHarvestInst(ByteBuffer _bb, RiskHarvestInst obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C3BD RID: 50109 RVA: 0x002FDA45 File Offset: 0x002FBC45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C3BE RID: 50110 RVA: 0x002FDA54 File Offset: 0x002FBC54
		public RiskHarvestInst __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F10 RID: 12048
		// (get) Token: 0x0600C3BF RID: 50111 RVA: 0x002FDA64 File Offset: 0x002FBC64
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

		// Token: 0x17002F11 RID: 12049
		// (get) Token: 0x0600C3C0 RID: 50112 RVA: 0x002FDAA0 File Offset: 0x002FBCA0
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

		// Token: 0x17002F12 RID: 12050
		// (get) Token: 0x0600C3C1 RID: 50113 RVA: 0x002FDADC File Offset: 0x002FBCDC
		public int InstanceID
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

		// Token: 0x17002F13 RID: 12051
		// (get) Token: 0x0600C3C2 RID: 50114 RVA: 0x002FDB18 File Offset: 0x002FBD18
		public int UnlockDay
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

		// Token: 0x17002F14 RID: 12052
		// (get) Token: 0x0600C3C3 RID: 50115 RVA: 0x002FDB58 File Offset: 0x002FBD58
		public int UnlockInst
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

		// Token: 0x17002F15 RID: 12053
		// (get) Token: 0x0600C3C4 RID: 50116 RVA: 0x002FDB98 File Offset: 0x002FBD98
		public int UnlockScore
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

		// Token: 0x17002F16 RID: 12054
		// (get) Token: 0x0600C3C5 RID: 50117 RVA: 0x002FDBD8 File Offset: 0x002FBDD8
		public int RewardScore
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002F17 RID: 12055
		// (get) Token: 0x0600C3C6 RID: 50118 RVA: 0x002FDC18 File Offset: 0x002FBE18
		public int MaxScore
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

		// Token: 0x17002F18 RID: 12056
		// (get) Token: 0x0600C3C7 RID: 50119 RVA: 0x002FDC58 File Offset: 0x002FBE58
		public int HarvestBuff
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002F19 RID: 12057
		// (get) Token: 0x0600C3C8 RID: 50120 RVA: 0x002FDC98 File Offset: 0x002FBE98
		public int Reward
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002F1A RID: 12058
		// (get) Token: 0x0600C3C9 RID: 50121 RVA: 0x002FDCD8 File Offset: 0x002FBED8
		public int Difficulty
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

		// Token: 0x17002F1B RID: 12059
		// (get) Token: 0x0600C3CA RID: 50122 RVA: 0x002FDD18 File Offset: 0x002FBF18
		public string DifficultyName
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

		// Token: 0x0600C3CB RID: 50123 RVA: 0x002FDD50 File Offset: 0x002FBF50
		public Span<byte> GetDifficultyNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600C3CC RID: 50124 RVA: 0x002FDD60 File Offset: 0x002FBF60
		public byte[] GetDifficultyNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F1C RID: 12060
		// (get) Token: 0x0600C3CD RID: 50125 RVA: 0x002FDD78 File Offset: 0x002FBF78
		public string MonsterRatio
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C3CE RID: 50126 RVA: 0x002FDDB0 File Offset: 0x002FBFB0
		public Span<byte> GetMonsterRatioBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600C3CF RID: 50127 RVA: 0x002FDDC0 File Offset: 0x002FBFC0
		public byte[] GetMonsterRatioArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F1D RID: 12061
		// (get) Token: 0x0600C3D0 RID: 50128 RVA: 0x002FDDD8 File Offset: 0x002FBFD8
		public string TimePointName
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C3D1 RID: 50129 RVA: 0x002FDE10 File Offset: 0x002FC010
		public Span<byte> GetTimePointNameBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600C3D2 RID: 50130 RVA: 0x002FDE20 File Offset: 0x002FC020
		public byte[] GetTimePointNameArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F1E RID: 12062
		// (get) Token: 0x0600C3D3 RID: 50131 RVA: 0x002FDE38 File Offset: 0x002FC038
		public string ScorePointName
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C3D4 RID: 50132 RVA: 0x002FDE70 File Offset: 0x002FC070
		public Span<byte> GetScorePointNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600C3D5 RID: 50133 RVA: 0x002FDE80 File Offset: 0x002FC080
		public byte[] GetScorePointNameArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F1F RID: 12063
		// (get) Token: 0x0600C3D6 RID: 50134 RVA: 0x002FDE98 File Offset: 0x002FC098
		public string TimeScoreValidName
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C3D7 RID: 50135 RVA: 0x002FDED0 File Offset: 0x002FC0D0
		public Span<byte> GetTimeScoreValidNameBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600C3D8 RID: 50136 RVA: 0x002FDEE0 File Offset: 0x002FC0E0
		public byte[] GetTimeScoreValidNameArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F20 RID: 12064
		// (get) Token: 0x0600C3D9 RID: 50137 RVA: 0x002FDEF8 File Offset: 0x002FC0F8
		public int MaxTimeScore
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

		// Token: 0x0600C3DA RID: 50138 RVA: 0x002FDF38 File Offset: 0x002FC138
		public IntPair? StarRewardList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002F21 RID: 12065
		// (get) Token: 0x0600C3DB RID: 50139 RVA: 0x002FDF9C File Offset: 0x002FC19C
		public int StarRewardListLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002F22 RID: 12066
		// (get) Token: 0x0600C3DC RID: 50140 RVA: 0x002FDFC8 File Offset: 0x002FC1C8
		public bool Accumulate
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002F23 RID: 12067
		// (get) Token: 0x0600C3DD RID: 50141 RVA: 0x002FE008 File Offset: 0x002FC208
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C3DE RID: 50142 RVA: 0x002FE040 File Offset: 0x002FC240
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600C3DF RID: 50143 RVA: 0x002FE050 File Offset: 0x002FC250
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F24 RID: 12068
		// (get) Token: 0x0600C3E0 RID: 50144 RVA: 0x002FE068 File Offset: 0x002FC268
		public string StarRewardDesc
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C3E1 RID: 50145 RVA: 0x002FE0A0 File Offset: 0x002FC2A0
		public Span<byte> GetStarRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600C3E2 RID: 50146 RVA: 0x002FE0B0 File Offset: 0x002FC2B0
		public byte[] GetStarRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C3E3 RID: 50147 RVA: 0x002FE0C8 File Offset: 0x002FC2C8
		[NullableContext(1)]
		public IntPair[] StarRewardList()
		{
			return this.StarRewardListIter().ToArray<IntPair>();
		}

		// Token: 0x0600C3E4 RID: 50148 RVA: 0x002FE0D5 File Offset: 0x002FC2D5
		[NullableContext(1)]
		public IEnumerable<IntPair> StarRewardListIter()
		{
			RiskHarvestInst.<StarRewardListIter>d__66 <StarRewardListIter>d__ = new RiskHarvestInst.<StarRewardListIter>d__66(-2);
			<StarRewardListIter>d__.<>3__<>4__this = this;
			return <StarRewardListIter>d__;
		}

		// Token: 0x04005691 RID: 22161
		private Table __p;
	}
}
