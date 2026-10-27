using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FCE RID: 4046
	public struct RiskHarvestInst : IFlatbufferObject
	{
		// Token: 0x17002E94 RID: 11924
		// (get) Token: 0x0600BD6F RID: 48495 RVA: 0x002E1429 File Offset: 0x002DF629
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BD70 RID: 48496 RVA: 0x002E1436 File Offset: 0x002DF636
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BD71 RID: 48497 RVA: 0x002E1440 File Offset: 0x002DF640
		public static RiskHarvestInst GetRootAsRiskHarvestInst(ByteBuffer _bb)
		{
			return RiskHarvestInst.GetRootAsRiskHarvestInst(_bb, default(RiskHarvestInst));
		}

		// Token: 0x0600BD72 RID: 48498 RVA: 0x002E145C File Offset: 0x002DF65C
		public static RiskHarvestInst GetRootAsRiskHarvestInst(ByteBuffer _bb, RiskHarvestInst obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BD73 RID: 48499 RVA: 0x002E1479 File Offset: 0x002DF679
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BD74 RID: 48500 RVA: 0x002E1488 File Offset: 0x002DF688
		public RiskHarvestInst __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E95 RID: 11925
		// (get) Token: 0x0600BD75 RID: 48501 RVA: 0x002E1498 File Offset: 0x002DF698
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

		// Token: 0x17002E96 RID: 11926
		// (get) Token: 0x0600BD76 RID: 48502 RVA: 0x002E14D4 File Offset: 0x002DF6D4
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

		// Token: 0x17002E97 RID: 11927
		// (get) Token: 0x0600BD77 RID: 48503 RVA: 0x002E1510 File Offset: 0x002DF710
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

		// Token: 0x17002E98 RID: 11928
		// (get) Token: 0x0600BD78 RID: 48504 RVA: 0x002E154C File Offset: 0x002DF74C
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

		// Token: 0x17002E99 RID: 11929
		// (get) Token: 0x0600BD79 RID: 48505 RVA: 0x002E158C File Offset: 0x002DF78C
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

		// Token: 0x17002E9A RID: 11930
		// (get) Token: 0x0600BD7A RID: 48506 RVA: 0x002E15CC File Offset: 0x002DF7CC
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

		// Token: 0x17002E9B RID: 11931
		// (get) Token: 0x0600BD7B RID: 48507 RVA: 0x002E160C File Offset: 0x002DF80C
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

		// Token: 0x17002E9C RID: 11932
		// (get) Token: 0x0600BD7C RID: 48508 RVA: 0x002E164C File Offset: 0x002DF84C
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

		// Token: 0x17002E9D RID: 11933
		// (get) Token: 0x0600BD7D RID: 48509 RVA: 0x002E168C File Offset: 0x002DF88C
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

		// Token: 0x17002E9E RID: 11934
		// (get) Token: 0x0600BD7E RID: 48510 RVA: 0x002E16CC File Offset: 0x002DF8CC
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

		// Token: 0x17002E9F RID: 11935
		// (get) Token: 0x0600BD7F RID: 48511 RVA: 0x002E170C File Offset: 0x002DF90C
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

		// Token: 0x17002EA0 RID: 11936
		// (get) Token: 0x0600BD80 RID: 48512 RVA: 0x002E174C File Offset: 0x002DF94C
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

		// Token: 0x0600BD81 RID: 48513 RVA: 0x002E1784 File Offset: 0x002DF984
		public Span<byte> GetDifficultyNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600BD82 RID: 48514 RVA: 0x002E1794 File Offset: 0x002DF994
		public byte[] GetDifficultyNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EA1 RID: 11937
		// (get) Token: 0x0600BD83 RID: 48515 RVA: 0x002E17AC File Offset: 0x002DF9AC
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

		// Token: 0x0600BD84 RID: 48516 RVA: 0x002E17E4 File Offset: 0x002DF9E4
		public Span<byte> GetMonsterRatioBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600BD85 RID: 48517 RVA: 0x002E17F4 File Offset: 0x002DF9F4
		public byte[] GetMonsterRatioArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EA2 RID: 11938
		// (get) Token: 0x0600BD86 RID: 48518 RVA: 0x002E180C File Offset: 0x002DFA0C
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

		// Token: 0x0600BD87 RID: 48519 RVA: 0x002E1844 File Offset: 0x002DFA44
		public Span<byte> GetTimePointNameBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600BD88 RID: 48520 RVA: 0x002E1854 File Offset: 0x002DFA54
		public byte[] GetTimePointNameArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EA3 RID: 11939
		// (get) Token: 0x0600BD89 RID: 48521 RVA: 0x002E186C File Offset: 0x002DFA6C
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

		// Token: 0x0600BD8A RID: 48522 RVA: 0x002E18A4 File Offset: 0x002DFAA4
		public Span<byte> GetScorePointNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600BD8B RID: 48523 RVA: 0x002E18B4 File Offset: 0x002DFAB4
		public byte[] GetScorePointNameArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EA4 RID: 11940
		// (get) Token: 0x0600BD8C RID: 48524 RVA: 0x002E18CC File Offset: 0x002DFACC
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

		// Token: 0x0600BD8D RID: 48525 RVA: 0x002E1904 File Offset: 0x002DFB04
		public Span<byte> GetTimeScoreValidNameBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600BD8E RID: 48526 RVA: 0x002E1914 File Offset: 0x002DFB14
		public byte[] GetTimeScoreValidNameArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EA5 RID: 11941
		// (get) Token: 0x0600BD8F RID: 48527 RVA: 0x002E192C File Offset: 0x002DFB2C
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

		// Token: 0x0600BD90 RID: 48528 RVA: 0x002E196C File Offset: 0x002DFB6C
		public IntPair? StarRewardList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002EA6 RID: 11942
		// (get) Token: 0x0600BD91 RID: 48529 RVA: 0x002E19D0 File Offset: 0x002DFBD0
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

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x0600BD92 RID: 48530 RVA: 0x002E19FC File Offset: 0x002DFBFC
		public bool Accumulate
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x0600BD93 RID: 48531 RVA: 0x002E1A3C File Offset: 0x002DFC3C
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

		// Token: 0x0600BD94 RID: 48532 RVA: 0x002E1A74 File Offset: 0x002DFC74
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600BD95 RID: 48533 RVA: 0x002E1A84 File Offset: 0x002DFC84
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EA9 RID: 11945
		// (get) Token: 0x0600BD96 RID: 48534 RVA: 0x002E1A9C File Offset: 0x002DFC9C
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

		// Token: 0x0600BD97 RID: 48535 RVA: 0x002E1AD4 File Offset: 0x002DFCD4
		public Span<byte> GetStarRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600BD98 RID: 48536 RVA: 0x002E1AE4 File Offset: 0x002DFCE4
		public byte[] GetStarRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BD99 RID: 48537 RVA: 0x002E1AFC File Offset: 0x002DFCFC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StarRewardListIter()或GetStarRewardListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntPair[] StarRewardList()
		{
			return this.StarRewardListIter().ToArray<IntPair>();
		}

		// Token: 0x0600BD9A RID: 48538 RVA: 0x002E1B09 File Offset: 0x002DFD09
		[NullableContext(1)]
		public readonly IEnumerable<IntPair> StarRewardListIter()
		{
			RiskHarvestInst.<StarRewardListIter>d__66 <StarRewardListIter>d__ = new RiskHarvestInst.<StarRewardListIter>d__66(-2);
			<StarRewardListIter>d__.<>3__<>4__this = this;
			return <StarRewardListIter>d__;
		}

		// Token: 0x040050A9 RID: 20649
		private Table __p;
	}
}
