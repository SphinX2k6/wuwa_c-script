using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200115C RID: 4444
	public struct TrapDefenseBuilding : IFlatbufferObject
	{
		// Token: 0x17003BEA RID: 15338
		// (get) Token: 0x0600E2E4 RID: 58084 RVA: 0x003370D5 File Offset: 0x003352D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E2E5 RID: 58085 RVA: 0x003370E2 File Offset: 0x003352E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E2E6 RID: 58086 RVA: 0x003370EC File Offset: 0x003352EC
		public static TrapDefenseBuilding GetRootAsTrapDefenseBuilding(ByteBuffer _bb)
		{
			return TrapDefenseBuilding.GetRootAsTrapDefenseBuilding(_bb, default(TrapDefenseBuilding));
		}

		// Token: 0x0600E2E7 RID: 58087 RVA: 0x00337108 File Offset: 0x00335308
		public static TrapDefenseBuilding GetRootAsTrapDefenseBuilding(ByteBuffer _bb, TrapDefenseBuilding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E2E8 RID: 58088 RVA: 0x00337125 File Offset: 0x00335325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E2E9 RID: 58089 RVA: 0x00337134 File Offset: 0x00335334
		public TrapDefenseBuilding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BEB RID: 15339
		// (get) Token: 0x0600E2EA RID: 58090 RVA: 0x00337144 File Offset: 0x00335344
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

		// Token: 0x17003BEC RID: 15340
		// (get) Token: 0x0600E2EB RID: 58091 RVA: 0x00337180 File Offset: 0x00335380
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E2EC RID: 58092 RVA: 0x003371B7 File Offset: 0x003353B7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E2ED RID: 58093 RVA: 0x003371C6 File Offset: 0x003353C6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E2EE RID: 58094 RVA: 0x003371E0 File Offset: 0x003353E0
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BED RID: 15341
		// (get) Token: 0x0600E2EF RID: 58095 RVA: 0x0033721C File Offset: 0x0033541C
		public int DescArgsLength
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

		// Token: 0x17003BEE RID: 15342
		// (get) Token: 0x0600E2F0 RID: 58096 RVA: 0x00337248 File Offset: 0x00335448
		public string DescDetail
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

		// Token: 0x0600E2F1 RID: 58097 RVA: 0x00337280 File Offset: 0x00335480
		public Span<byte> GetDescDetailBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E2F2 RID: 58098 RVA: 0x00337290 File Offset: 0x00335490
		public byte[] GetDescDetailArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E2F3 RID: 58099 RVA: 0x003372A8 File Offset: 0x003354A8
		public string DescDetailArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BEF RID: 15343
		// (get) Token: 0x0600E2F4 RID: 58100 RVA: 0x003372E4 File Offset: 0x003354E4
		public int DescDetailArgsLength
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

		// Token: 0x17003BF0 RID: 15344
		// (get) Token: 0x0600E2F5 RID: 58101 RVA: 0x00337310 File Offset: 0x00335510
		public int BuildingType
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

		// Token: 0x17003BF1 RID: 15345
		// (get) Token: 0x0600E2F6 RID: 58102 RVA: 0x00337350 File Offset: 0x00335550
		public int DamageType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E2F7 RID: 58103 RVA: 0x00337390 File Offset: 0x00335590
		public int SimpleCombatSubtypeIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BF2 RID: 15346
		// (get) Token: 0x0600E2F8 RID: 58104 RVA: 0x003373D0 File Offset: 0x003355D0
		public int SimpleCombatSubtypeIdsLength
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

		// Token: 0x0600E2F9 RID: 58105 RVA: 0x003373FC File Offset: 0x003355FC
		public Span<int> GetSimpleCombatSubtypeIdsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600E2FA RID: 58106 RVA: 0x0033740C File Offset: 0x0033560C
		public int[] GetSimpleCombatSubtypeIdsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600E2FB RID: 58107 RVA: 0x00337424 File Offset: 0x00335624
		public IntArray? BattleLevelUpgradeCondition(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003BF3 RID: 15347
		// (get) Token: 0x0600E2FC RID: 58108 RVA: 0x00337488 File Offset: 0x00335688
		public int BattleLevelUpgradeConditionLength
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

		// Token: 0x0600E2FD RID: 58109 RVA: 0x003374B4 File Offset: 0x003356B4
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BF4 RID: 15348
		// (get) Token: 0x0600E2FE RID: 58110 RVA: 0x003374F4 File Offset: 0x003356F4
		public int InitBuffsLength
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

		// Token: 0x0600E2FF RID: 58111 RVA: 0x00337520 File Offset: 0x00335720
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600E300 RID: 58112 RVA: 0x00337530 File Offset: 0x00335730
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17003BF5 RID: 15349
		// (get) Token: 0x0600E301 RID: 58113 RVA: 0x00337548 File Offset: 0x00335748
		public int Level
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

		// Token: 0x17003BF6 RID: 15350
		// (get) Token: 0x0600E302 RID: 58114 RVA: 0x00337588 File Offset: 0x00335788
		public int Branch
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

		// Token: 0x17003BF7 RID: 15351
		// (get) Token: 0x0600E303 RID: 58115 RVA: 0x003375C8 File Offset: 0x003357C8
		public string BranchDesc
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

		// Token: 0x0600E304 RID: 58116 RVA: 0x00337600 File Offset: 0x00335800
		public Span<byte> GetBranchDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600E305 RID: 58117 RVA: 0x00337610 File Offset: 0x00335810
		public byte[] GetBranchDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E306 RID: 58118 RVA: 0x00337628 File Offset: 0x00335828
		public string BranchDescArgs(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BF8 RID: 15352
		// (get) Token: 0x0600E307 RID: 58119 RVA: 0x00337664 File Offset: 0x00335864
		public int BranchDescArgsLength
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

		// Token: 0x17003BF9 RID: 15353
		// (get) Token: 0x0600E308 RID: 58120 RVA: 0x00337690 File Offset: 0x00335890
		public float CoolDown
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BFA RID: 15354
		// (get) Token: 0x0600E309 RID: 58121 RVA: 0x003376D4 File Offset: 0x003358D4
		public int UpgradeCost
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

		// Token: 0x17003BFB RID: 15355
		// (get) Token: 0x0600E30A RID: 58122 RVA: 0x00337714 File Offset: 0x00335914
		public int BattleLevel
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

		// Token: 0x0600E30B RID: 58123 RVA: 0x00337754 File Offset: 0x00335954
		public IntArray? BattleLogic(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003BFC RID: 15356
		// (get) Token: 0x0600E30C RID: 58124 RVA: 0x003377B8 File Offset: 0x003359B8
		public int BattleLogicLength
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

		// Token: 0x17003BFD RID: 15357
		// (get) Token: 0x0600E30D RID: 58125 RVA: 0x003377E4 File Offset: 0x003359E4
		public int ConstructDefaultCost
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

		// Token: 0x17003BFE RID: 15358
		// (get) Token: 0x0600E30E RID: 58126 RVA: 0x00337824 File Offset: 0x00335A24
		public int DeconstructDefaultReturn
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

		// Token: 0x17003BFF RID: 15359
		// (get) Token: 0x0600E30F RID: 58127 RVA: 0x00337864 File Offset: 0x00335A64
		public int Deathrattle
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

		// Token: 0x0600E310 RID: 58128 RVA: 0x003378A1 File Offset: 0x00335AA1
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BattleLevelUpgradeConditionIter()或GetBattleLevelUpgradeConditionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] BattleLevelUpgradeCondition()
		{
			return this.BattleLevelUpgradeConditionIter().ToArray<IntArray>();
		}

		// Token: 0x0600E311 RID: 58129 RVA: 0x003378AE File Offset: 0x00335AAE
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> BattleLevelUpgradeConditionIter()
		{
			TrapDefenseBuilding.<BattleLevelUpgradeConditionIter>d__68 <BattleLevelUpgradeConditionIter>d__ = new TrapDefenseBuilding.<BattleLevelUpgradeConditionIter>d__68(-2);
			<BattleLevelUpgradeConditionIter>d__.<>3__<>4__this = this;
			return <BattleLevelUpgradeConditionIter>d__;
		}

		// Token: 0x0600E312 RID: 58130 RVA: 0x003378C3 File Offset: 0x00335AC3
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BattleLogicIter()或GetBattleLogicBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] BattleLogic()
		{
			return this.BattleLogicIter().ToArray<IntArray>();
		}

		// Token: 0x0600E313 RID: 58131 RVA: 0x003378D0 File Offset: 0x00335AD0
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> BattleLogicIter()
		{
			TrapDefenseBuilding.<BattleLogicIter>d__70 <BattleLogicIter>d__ = new TrapDefenseBuilding.<BattleLogicIter>d__70(-2);
			<BattleLogicIter>d__.<>3__<>4__this = this;
			return <BattleLogicIter>d__;
		}

		// Token: 0x0600E314 RID: 58132 RVA: 0x003378E5 File Offset: 0x00335AE5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BranchDescArgsIter()或GetBranchDescArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BranchDescArgs()
		{
			return this.BranchDescArgsIter().ToArray<string>();
		}

		// Token: 0x0600E315 RID: 58133 RVA: 0x003378F2 File Offset: 0x00335AF2
		[NullableContext(1)]
		public readonly IEnumerable<string> BranchDescArgsIter()
		{
			TrapDefenseBuilding.<BranchDescArgsIter>d__72 <BranchDescArgsIter>d__ = new TrapDefenseBuilding.<BranchDescArgsIter>d__72(-2);
			<BranchDescArgsIter>d__.<>3__<>4__this = this;
			return <BranchDescArgsIter>d__;
		}

		// Token: 0x0600E316 RID: 58134 RVA: 0x00337907 File Offset: 0x00335B07
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescArgsIter()或GetDescArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x0600E317 RID: 58135 RVA: 0x00337914 File Offset: 0x00335B14
		[NullableContext(1)]
		public readonly IEnumerable<string> DescArgsIter()
		{
			TrapDefenseBuilding.<DescArgsIter>d__74 <DescArgsIter>d__ = new TrapDefenseBuilding.<DescArgsIter>d__74(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x0600E318 RID: 58136 RVA: 0x00337929 File Offset: 0x00335B29
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescDetailArgsIter()或GetDescDetailArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescDetailArgs()
		{
			return this.DescDetailArgsIter().ToArray<string>();
		}

		// Token: 0x0600E319 RID: 58137 RVA: 0x00337936 File Offset: 0x00335B36
		[NullableContext(1)]
		public readonly IEnumerable<string> DescDetailArgsIter()
		{
			TrapDefenseBuilding.<DescDetailArgsIter>d__76 <DescDetailArgsIter>d__ = new TrapDefenseBuilding.<DescDetailArgsIter>d__76(-2);
			<DescDetailArgsIter>d__.<>3__<>4__this = this;
			return <DescDetailArgsIter>d__;
		}

		// Token: 0x0600E31A RID: 58138 RVA: 0x0033794C File Offset: 0x00335B4C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitBuffsIter()或GetInitBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitBuffs()
		{
			TrapDefenseBuilding trapDefenseBuilding = this;
			return trapDefenseBuilding.GetInitBuffsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E31B RID: 58139 RVA: 0x00337970 File Offset: 0x00335B70
		[NullableContext(1)]
		public readonly IEnumerable<int> InitBuffsIter()
		{
			TrapDefenseBuilding.<InitBuffsIter>d__78 <InitBuffsIter>d__ = new TrapDefenseBuilding.<InitBuffsIter>d__78(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x0600E31C RID: 58140 RVA: 0x00337988 File Offset: 0x00335B88
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SimpleCombatSubtypeIdsIter()或GetSimpleCombatSubtypeIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SimpleCombatSubtypeIds()
		{
			TrapDefenseBuilding trapDefenseBuilding = this;
			return trapDefenseBuilding.GetSimpleCombatSubtypeIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E31D RID: 58141 RVA: 0x003379AC File Offset: 0x00335BAC
		[NullableContext(1)]
		public readonly IEnumerable<int> SimpleCombatSubtypeIdsIter()
		{
			TrapDefenseBuilding.<SimpleCombatSubtypeIdsIter>d__80 <SimpleCombatSubtypeIdsIter>d__ = new TrapDefenseBuilding.<SimpleCombatSubtypeIdsIter>d__80(-2);
			<SimpleCombatSubtypeIdsIter>d__.<>3__<>4__this = this;
			return <SimpleCombatSubtypeIdsIter>d__;
		}

		// Token: 0x040052A1 RID: 21153
		private Table __p;
	}
}
