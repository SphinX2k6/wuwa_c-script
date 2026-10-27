using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B43 RID: 2883
	public struct BossRushActivity : IFlatbufferObject
	{
		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06004EBD RID: 20157 RVA: 0x001E6B7D File Offset: 0x001E4D7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x001E6B8A File Offset: 0x001E4D8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x001E6B94 File Offset: 0x001E4D94
		public static BossRushActivity GetRootAsBossRushActivity(ByteBuffer _bb)
		{
			return BossRushActivity.GetRootAsBossRushActivity(_bb, default(BossRushActivity));
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x001E6BB0 File Offset: 0x001E4DB0
		public static BossRushActivity GetRootAsBossRushActivity(ByteBuffer _bb, BossRushActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x001E6BCD File Offset: 0x001E4DCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x001E6BDC File Offset: 0x001E4DDC
		public BossRushActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06004EC3 RID: 20163 RVA: 0x001E6BEC File Offset: 0x001E4DEC
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

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06004EC4 RID: 20164 RVA: 0x001E6C28 File Offset: 0x001E4E28
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

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06004EC5 RID: 20165 RVA: 0x001E6C64 File Offset: 0x001E4E64
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

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06004EC6 RID: 20166 RVA: 0x001E6CA0 File Offset: 0x001E4EA0
		public int GroupId
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

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06004EC7 RID: 20167 RVA: 0x001E6CE0 File Offset: 0x001E4EE0
		public int SortId
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

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06004EC8 RID: 20168 RVA: 0x001E6D20 File Offset: 0x001E4F20
		public int BuffCount
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

		// Token: 0x06004EC9 RID: 20169 RVA: 0x001E6D60 File Offset: 0x001E4F60
		public int DefaultBuff(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06004ECA RID: 20170 RVA: 0x001E6DA0 File Offset: 0x001E4FA0
		public int DefaultBuffLength
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

		// Token: 0x06004ECB RID: 20171 RVA: 0x001E6DCC File Offset: 0x001E4FCC
		public Span<int> GetDefaultBuffBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x001E6DDC File Offset: 0x001E4FDC
		public int[] GetDefaultBuffArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06004ECD RID: 20173 RVA: 0x001E6DF4 File Offset: 0x001E4FF4
		public int OptionalBuff(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06004ECE RID: 20174 RVA: 0x001E6E34 File Offset: 0x001E5034
		public int OptionalBuffLength
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

		// Token: 0x06004ECF RID: 20175 RVA: 0x001E6E60 File Offset: 0x001E5060
		public Span<int> GetOptionalBuffBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06004ED0 RID: 20176 RVA: 0x001E6E70 File Offset: 0x001E5070
		public int[] GetOptionalBuffArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x001E6E88 File Offset: 0x001E5088
		public int UnlockBuff(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06004ED2 RID: 20178 RVA: 0x001E6EC8 File Offset: 0x001E50C8
		public int UnlockBuffLength
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

		// Token: 0x06004ED3 RID: 20179 RVA: 0x001E6EF4 File Offset: 0x001E50F4
		public Span<int> GetUnlockBuffBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06004ED4 RID: 20180 RVA: 0x001E6F04 File Offset: 0x001E5104
		public int[] GetUnlockBuffArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06004ED5 RID: 20181 RVA: 0x001E6F1C File Offset: 0x001E511C
		public int OpenDay
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

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06004ED6 RID: 20182 RVA: 0x001E6F5C File Offset: 0x001E515C
		public int Condition
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

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06004ED7 RID: 20183 RVA: 0x001E6F9C File Offset: 0x001E519C
		public int PreLevel
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06004ED8 RID: 20184 RVA: 0x001E6FDC File Offset: 0x001E51DC
		public int RewardScore
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

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06004ED9 RID: 20185 RVA: 0x001E701C File Offset: 0x001E521C
		public string LevelRewardDesc
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

		// Token: 0x06004EDA RID: 20186 RVA: 0x001E7054 File Offset: 0x001E5254
		public Span<byte> GetLevelRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06004EDB RID: 20187 RVA: 0x001E7064 File Offset: 0x001E5264
		public byte[] GetLevelRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06004EDC RID: 20188 RVA: 0x001E707C File Offset: 0x001E527C
		public string LevelDesc
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

		// Token: 0x06004EDD RID: 20189 RVA: 0x001E70B4 File Offset: 0x001E52B4
		public Span<byte> GetLevelDescBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06004EDE RID: 20190 RVA: 0x001E70C4 File Offset: 0x001E52C4
		public byte[] GetLevelDescArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06004EDF RID: 20191 RVA: 0x001E70DC File Offset: 0x001E52DC
		public int RewardId
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

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06004EE0 RID: 20192 RVA: 0x001E711C File Offset: 0x001E531C
		public int BossInfo
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

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06004EE1 RID: 20193 RVA: 0x001E715C File Offset: 0x001E535C
		public string PreviewTexture
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x001E7194 File Offset: 0x001E5394
		public Span<byte> GetPreviewTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x001E71A4 File Offset: 0x001E53A4
		public byte[] GetPreviewTextureArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06004EE4 RID: 20196 RVA: 0x001E71BC File Offset: 0x001E53BC
		public string StageTexture
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x001E71F4 File Offset: 0x001E53F4
		public Span<byte> GetStageTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x001E7204 File Offset: 0x001E5404
		public byte[] GetStageTextureArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06004EE7 RID: 20199 RVA: 0x001E721C File Offset: 0x001E541C
		public int BossCount
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06004EE8 RID: 20200 RVA: 0x001E725C File Offset: 0x001E545C
		public int ScoreBuffCount
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x001E729C File Offset: 0x001E549C
		public int ScoreBuff(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06004EEA RID: 20202 RVA: 0x001E72DC File Offset: 0x001E54DC
		public int ScoreBuffLength
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

		// Token: 0x06004EEB RID: 20203 RVA: 0x001E7308 File Offset: 0x001E5508
		public Span<int> GetScoreBuffBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x001E7318 File Offset: 0x001E5518
		public int[] GetScoreBuffArray()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x001E7330 File Offset: 0x001E5530
		public IntPair? LevelScoreRewardList(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06004EEE RID: 20206 RVA: 0x001E7394 File Offset: 0x001E5594
		public int LevelScoreRewardListLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06004EEF RID: 20207 RVA: 0x001E73C0 File Offset: 0x001E55C0
		public string RewardName
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x001E73F8 File Offset: 0x001E55F8
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06004EF1 RID: 20209 RVA: 0x001E7408 File Offset: 0x001E5608
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06004EF2 RID: 20210 RVA: 0x001E7420 File Offset: 0x001E5620
		public string RewardTexture
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004EF3 RID: 20211 RVA: 0x001E7458 File Offset: 0x001E5658
		public Span<byte> GetRewardTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x06004EF4 RID: 20212 RVA: 0x001E7468 File Offset: 0x001E5668
		public byte[] GetRewardTextureArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x001E7480 File Offset: 0x001E5680
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DefaultBuffIter()或GetDefaultBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DefaultBuff()
		{
			BossRushActivity bossRushActivity = this;
			return bossRushActivity.GetDefaultBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004EF6 RID: 20214 RVA: 0x001E74A4 File Offset: 0x001E56A4
		[NullableContext(1)]
		public readonly IEnumerable<int> DefaultBuffIter()
		{
			BossRushActivity.<DefaultBuffIter>d__84 <DefaultBuffIter>d__ = new BossRushActivity.<DefaultBuffIter>d__84(-2);
			<DefaultBuffIter>d__.<>3__<>4__this = this;
			return <DefaultBuffIter>d__;
		}

		// Token: 0x06004EF7 RID: 20215 RVA: 0x001E74B9 File Offset: 0x001E56B9
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelScoreRewardListIter()或GetLevelScoreRewardListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntPair[] LevelScoreRewardList()
		{
			return this.LevelScoreRewardListIter().ToArray<IntPair>();
		}

		// Token: 0x06004EF8 RID: 20216 RVA: 0x001E74C6 File Offset: 0x001E56C6
		[NullableContext(1)]
		public readonly IEnumerable<IntPair> LevelScoreRewardListIter()
		{
			BossRushActivity.<LevelScoreRewardListIter>d__86 <LevelScoreRewardListIter>d__ = new BossRushActivity.<LevelScoreRewardListIter>d__86(-2);
			<LevelScoreRewardListIter>d__.<>3__<>4__this = this;
			return <LevelScoreRewardListIter>d__;
		}

		// Token: 0x06004EF9 RID: 20217 RVA: 0x001E74DC File Offset: 0x001E56DC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OptionalBuffIter()或GetOptionalBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] OptionalBuff()
		{
			BossRushActivity bossRushActivity = this;
			return bossRushActivity.GetOptionalBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004EFA RID: 20218 RVA: 0x001E7500 File Offset: 0x001E5700
		[NullableContext(1)]
		public readonly IEnumerable<int> OptionalBuffIter()
		{
			BossRushActivity.<OptionalBuffIter>d__88 <OptionalBuffIter>d__ = new BossRushActivity.<OptionalBuffIter>d__88(-2);
			<OptionalBuffIter>d__.<>3__<>4__this = this;
			return <OptionalBuffIter>d__;
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x001E7518 File Offset: 0x001E5718
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ScoreBuffIter()或GetScoreBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ScoreBuff()
		{
			BossRushActivity bossRushActivity = this;
			return bossRushActivity.GetScoreBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004EFC RID: 20220 RVA: 0x001E753C File Offset: 0x001E573C
		[NullableContext(1)]
		public readonly IEnumerable<int> ScoreBuffIter()
		{
			BossRushActivity.<ScoreBuffIter>d__90 <ScoreBuffIter>d__ = new BossRushActivity.<ScoreBuffIter>d__90(-2);
			<ScoreBuffIter>d__.<>3__<>4__this = this;
			return <ScoreBuffIter>d__;
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x001E7554 File Offset: 0x001E5754
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnlockBuffIter()或GetUnlockBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnlockBuff()
		{
			BossRushActivity bossRushActivity = this;
			return bossRushActivity.GetUnlockBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x001E7578 File Offset: 0x001E5778
		[NullableContext(1)]
		public readonly IEnumerable<int> UnlockBuffIter()
		{
			BossRushActivity.<UnlockBuffIter>d__92 <UnlockBuffIter>d__ = new BossRushActivity.<UnlockBuffIter>d__92(-2);
			<UnlockBuffIter>d__.<>3__<>4__this = this;
			return <UnlockBuffIter>d__;
		}

		// Token: 0x04004B3E RID: 19262
		private Table __p;
	}
}
