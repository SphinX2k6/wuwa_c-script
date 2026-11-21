using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001292 RID: 4754
	public struct TrapDefenseBuilding : IFlatbufferObject
	{
		// Token: 0x17003F4E RID: 16206
		// (get) Token: 0x0600F052 RID: 61522 RVA: 0x003621E5 File Offset: 0x003603E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F053 RID: 61523 RVA: 0x003621F2 File Offset: 0x003603F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F054 RID: 61524 RVA: 0x003621FC File Offset: 0x003603FC
		public static TrapDefenseBuilding GetRootAsTrapDefenseBuilding(ByteBuffer _bb)
		{
			return TrapDefenseBuilding.GetRootAsTrapDefenseBuilding(_bb, default(TrapDefenseBuilding));
		}

		// Token: 0x0600F055 RID: 61525 RVA: 0x00362218 File Offset: 0x00360418
		public static TrapDefenseBuilding GetRootAsTrapDefenseBuilding(ByteBuffer _bb, TrapDefenseBuilding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F056 RID: 61526 RVA: 0x00362235 File Offset: 0x00360435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F057 RID: 61527 RVA: 0x00362244 File Offset: 0x00360444
		public TrapDefenseBuilding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F4F RID: 16207
		// (get) Token: 0x0600F058 RID: 61528 RVA: 0x00362254 File Offset: 0x00360454
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

		// Token: 0x17003F50 RID: 16208
		// (get) Token: 0x0600F059 RID: 61529 RVA: 0x00362290 File Offset: 0x00360490
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

		// Token: 0x0600F05A RID: 61530 RVA: 0x003622C7 File Offset: 0x003604C7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F05B RID: 61531 RVA: 0x003622D6 File Offset: 0x003604D6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F05C RID: 61532 RVA: 0x003622F0 File Offset: 0x003604F0
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F51 RID: 16209
		// (get) Token: 0x0600F05D RID: 61533 RVA: 0x0036232C File Offset: 0x0036052C
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

		// Token: 0x17003F52 RID: 16210
		// (get) Token: 0x0600F05E RID: 61534 RVA: 0x00362358 File Offset: 0x00360558
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

		// Token: 0x0600F05F RID: 61535 RVA: 0x00362390 File Offset: 0x00360590
		public Span<byte> GetDescDetailBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F060 RID: 61536 RVA: 0x003623A0 File Offset: 0x003605A0
		public byte[] GetDescDetailArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F061 RID: 61537 RVA: 0x003623B8 File Offset: 0x003605B8
		public string DescDetailArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F53 RID: 16211
		// (get) Token: 0x0600F062 RID: 61538 RVA: 0x003623F4 File Offset: 0x003605F4
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

		// Token: 0x17003F54 RID: 16212
		// (get) Token: 0x0600F063 RID: 61539 RVA: 0x00362420 File Offset: 0x00360620
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

		// Token: 0x17003F55 RID: 16213
		// (get) Token: 0x0600F064 RID: 61540 RVA: 0x00362460 File Offset: 0x00360660
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

		// Token: 0x0600F065 RID: 61541 RVA: 0x003624A0 File Offset: 0x003606A0
		public int SimpleCombatSubtypeIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F56 RID: 16214
		// (get) Token: 0x0600F066 RID: 61542 RVA: 0x003624E0 File Offset: 0x003606E0
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

		// Token: 0x0600F067 RID: 61543 RVA: 0x0036250C File Offset: 0x0036070C
		public Span<int> GetSimpleCombatSubtypeIdsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600F068 RID: 61544 RVA: 0x0036251C File Offset: 0x0036071C
		public int[] GetSimpleCombatSubtypeIdsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600F069 RID: 61545 RVA: 0x00362534 File Offset: 0x00360734
		public IntArray? BattleLevelUpgradeCondition(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003F57 RID: 16215
		// (get) Token: 0x0600F06A RID: 61546 RVA: 0x00362598 File Offset: 0x00360798
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

		// Token: 0x0600F06B RID: 61547 RVA: 0x003625C4 File Offset: 0x003607C4
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F58 RID: 16216
		// (get) Token: 0x0600F06C RID: 61548 RVA: 0x00362604 File Offset: 0x00360804
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

		// Token: 0x0600F06D RID: 61549 RVA: 0x00362630 File Offset: 0x00360830
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600F06E RID: 61550 RVA: 0x00362640 File Offset: 0x00360840
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17003F59 RID: 16217
		// (get) Token: 0x0600F06F RID: 61551 RVA: 0x00362658 File Offset: 0x00360858
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

		// Token: 0x17003F5A RID: 16218
		// (get) Token: 0x0600F070 RID: 61552 RVA: 0x00362698 File Offset: 0x00360898
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

		// Token: 0x17003F5B RID: 16219
		// (get) Token: 0x0600F071 RID: 61553 RVA: 0x003626D8 File Offset: 0x003608D8
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

		// Token: 0x0600F072 RID: 61554 RVA: 0x00362710 File Offset: 0x00360910
		public Span<byte> GetBranchDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600F073 RID: 61555 RVA: 0x00362720 File Offset: 0x00360920
		public byte[] GetBranchDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F074 RID: 61556 RVA: 0x00362738 File Offset: 0x00360938
		public string BranchDescArgs(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F5C RID: 16220
		// (get) Token: 0x0600F075 RID: 61557 RVA: 0x00362774 File Offset: 0x00360974
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

		// Token: 0x17003F5D RID: 16221
		// (get) Token: 0x0600F076 RID: 61558 RVA: 0x003627A0 File Offset: 0x003609A0
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

		// Token: 0x17003F5E RID: 16222
		// (get) Token: 0x0600F077 RID: 61559 RVA: 0x003627E4 File Offset: 0x003609E4
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

		// Token: 0x17003F5F RID: 16223
		// (get) Token: 0x0600F078 RID: 61560 RVA: 0x00362824 File Offset: 0x00360A24
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

		// Token: 0x0600F079 RID: 61561 RVA: 0x00362864 File Offset: 0x00360A64
		public IntArray? BattleLogic(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003F60 RID: 16224
		// (get) Token: 0x0600F07A RID: 61562 RVA: 0x003628C8 File Offset: 0x00360AC8
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

		// Token: 0x17003F61 RID: 16225
		// (get) Token: 0x0600F07B RID: 61563 RVA: 0x003628F4 File Offset: 0x00360AF4
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

		// Token: 0x17003F62 RID: 16226
		// (get) Token: 0x0600F07C RID: 61564 RVA: 0x00362934 File Offset: 0x00360B34
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

		// Token: 0x17003F63 RID: 16227
		// (get) Token: 0x0600F07D RID: 61565 RVA: 0x00362974 File Offset: 0x00360B74
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

		// Token: 0x0600F07E RID: 61566 RVA: 0x003629B1 File Offset: 0x00360BB1
		[NullableContext(1)]
		public IntArray[] BattleLevelUpgradeCondition()
		{
			return this.BattleLevelUpgradeConditionIter().ToArray<IntArray>();
		}

		// Token: 0x0600F07F RID: 61567 RVA: 0x003629BE File Offset: 0x00360BBE
		[NullableContext(1)]
		public IEnumerable<IntArray> BattleLevelUpgradeConditionIter()
		{
			TrapDefenseBuilding.<BattleLevelUpgradeConditionIter>d__68 <BattleLevelUpgradeConditionIter>d__ = new TrapDefenseBuilding.<BattleLevelUpgradeConditionIter>d__68(-2);
			<BattleLevelUpgradeConditionIter>d__.<>3__<>4__this = this;
			return <BattleLevelUpgradeConditionIter>d__;
		}

		// Token: 0x0600F080 RID: 61568 RVA: 0x003629D3 File Offset: 0x00360BD3
		[NullableContext(1)]
		public IntArray[] BattleLogic()
		{
			return this.BattleLogicIter().ToArray<IntArray>();
		}

		// Token: 0x0600F081 RID: 61569 RVA: 0x003629E0 File Offset: 0x00360BE0
		[NullableContext(1)]
		public IEnumerable<IntArray> BattleLogicIter()
		{
			TrapDefenseBuilding.<BattleLogicIter>d__70 <BattleLogicIter>d__ = new TrapDefenseBuilding.<BattleLogicIter>d__70(-2);
			<BattleLogicIter>d__.<>3__<>4__this = this;
			return <BattleLogicIter>d__;
		}

		// Token: 0x0600F082 RID: 61570 RVA: 0x003629F5 File Offset: 0x00360BF5
		[NullableContext(1)]
		public string[] BranchDescArgs()
		{
			return this.BranchDescArgsIter().ToArray<string>();
		}

		// Token: 0x0600F083 RID: 61571 RVA: 0x00362A02 File Offset: 0x00360C02
		[NullableContext(1)]
		public IEnumerable<string> BranchDescArgsIter()
		{
			TrapDefenseBuilding.<BranchDescArgsIter>d__72 <BranchDescArgsIter>d__ = new TrapDefenseBuilding.<BranchDescArgsIter>d__72(-2);
			<BranchDescArgsIter>d__.<>3__<>4__this = this;
			return <BranchDescArgsIter>d__;
		}

		// Token: 0x0600F084 RID: 61572 RVA: 0x00362A17 File Offset: 0x00360C17
		[NullableContext(1)]
		public string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x0600F085 RID: 61573 RVA: 0x00362A24 File Offset: 0x00360C24
		[NullableContext(1)]
		public IEnumerable<string> DescArgsIter()
		{
			TrapDefenseBuilding.<DescArgsIter>d__74 <DescArgsIter>d__ = new TrapDefenseBuilding.<DescArgsIter>d__74(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x0600F086 RID: 61574 RVA: 0x00362A39 File Offset: 0x00360C39
		[NullableContext(1)]
		public string[] DescDetailArgs()
		{
			return this.DescDetailArgsIter().ToArray<string>();
		}

		// Token: 0x0600F087 RID: 61575 RVA: 0x00362A46 File Offset: 0x00360C46
		[NullableContext(1)]
		public IEnumerable<string> DescDetailArgsIter()
		{
			TrapDefenseBuilding.<DescDetailArgsIter>d__76 <DescDetailArgsIter>d__ = new TrapDefenseBuilding.<DescDetailArgsIter>d__76(-2);
			<DescDetailArgsIter>d__.<>3__<>4__this = this;
			return <DescDetailArgsIter>d__;
		}

		// Token: 0x0600F088 RID: 61576 RVA: 0x00362A5B File Offset: 0x00360C5B
		[NullableContext(1)]
		public int[] InitBuffs()
		{
			return this.GetInitBuffsArray();
		}

		// Token: 0x0600F089 RID: 61577 RVA: 0x00362A63 File Offset: 0x00360C63
		[NullableContext(1)]
		public IEnumerable<int> InitBuffsIter()
		{
			TrapDefenseBuilding.<InitBuffsIter>d__78 <InitBuffsIter>d__ = new TrapDefenseBuilding.<InitBuffsIter>d__78(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x0600F08A RID: 61578 RVA: 0x00362A78 File Offset: 0x00360C78
		[NullableContext(1)]
		public int[] SimpleCombatSubtypeIds()
		{
			return this.GetSimpleCombatSubtypeIdsArray();
		}

		// Token: 0x0600F08B RID: 61579 RVA: 0x00362A80 File Offset: 0x00360C80
		[NullableContext(1)]
		public IEnumerable<int> SimpleCombatSubtypeIdsIter()
		{
			TrapDefenseBuilding.<SimpleCombatSubtypeIdsIter>d__80 <SimpleCombatSubtypeIdsIter>d__ = new TrapDefenseBuilding.<SimpleCombatSubtypeIdsIter>d__80(-2);
			<SimpleCombatSubtypeIdsIter>d__.<>3__<>4__this = this;
			return <SimpleCombatSubtypeIdsIter>d__;
		}

		// Token: 0x040058E4 RID: 22756
		private Table __p;
	}
}
