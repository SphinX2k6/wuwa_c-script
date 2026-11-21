using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043B2 RID: 17330
	public struct IParallelSelectBtNode : IFlatbufferObject
	{
		// Token: 0x17007706 RID: 30470
		// (get) Token: 0x06018874 RID: 100468 RVA: 0x0037EAC6 File Offset: 0x0037CCC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018875 RID: 100469 RVA: 0x0037EAD3 File Offset: 0x0037CCD3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018876 RID: 100470 RVA: 0x0037EADC File Offset: 0x0037CCDC
		public static IParallelSelectBtNode GetRootAsIParallelSelectBtNode(ByteBuffer _bb)
		{
			return IParallelSelectBtNode.GetRootAsIParallelSelectBtNode(_bb, default(IParallelSelectBtNode));
		}

		// Token: 0x06018877 RID: 100471 RVA: 0x0037EAF8 File Offset: 0x0037CCF8
		public static IParallelSelectBtNode GetRootAsIParallelSelectBtNode(ByteBuffer _bb, IParallelSelectBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018878 RID: 100472 RVA: 0x0037EB15 File Offset: 0x0037CD15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018879 RID: 100473 RVA: 0x0037EB24 File Offset: 0x0037CD24
		public IParallelSelectBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007707 RID: 30471
		// (get) Token: 0x0601887A RID: 100474 RVA: 0x0037EB34 File Offset: 0x0037CD34
		public EBtNode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBtNode.Start;
				}
				return (EBtNode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007708 RID: 30472
		// (get) Token: 0x0601887B RID: 100475 RVA: 0x0037EB70 File Offset: 0x0037CD70
		public int Id
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

		// Token: 0x17007709 RID: 30473
		// (get) Token: 0x0601887C RID: 100476 RVA: 0x0037EBAC File Offset: 0x0037CDAC
		public string Desc
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

		// Token: 0x0601887D RID: 100477 RVA: 0x0037EBE3 File Offset: 0x0037CDE3
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601887E RID: 100478 RVA: 0x0037EBF2 File Offset: 0x0037CDF2
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700770A RID: 30474
		// (get) Token: 0x0601887F RID: 100479 RVA: 0x0037EC00 File Offset: 0x0037CE00
		public IFixProcessor? FixProcessor
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IFixProcessor?(default(IFixProcessor).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700770B RID: 30475
		// (get) Token: 0x06018880 RID: 100480 RVA: 0x0037EC60 File Offset: 0x0037CE60
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700770C RID: 30476
		// (get) Token: 0x06018881 RID: 100481 RVA: 0x0037ECA0 File Offset: 0x0037CEA0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700770D RID: 30477
		// (get) Token: 0x06018882 RID: 100482 RVA: 0x0037ECE0 File Offset: 0x0037CEE0
		public IQuestScheduleConfig? UIConfig
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IQuestScheduleConfig?(default(IQuestScheduleConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700770E RID: 30478
		// (get) Token: 0x06018883 RID: 100483 RVA: 0x0037ED40 File Offset: 0x0037CF40
		public IInformationViewConfig? InformationView
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IInformationViewConfig?(default(IInformationViewConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700770F RID: 30479
		// (get) Token: 0x06018884 RID: 100484 RVA: 0x0037EDA0 File Offset: 0x0037CFA0
		public IInformationBoardConfig? InformationBoard
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IInformationBoardConfig?(default(IInformationBoardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007710 RID: 30480
		// (get) Token: 0x06018885 RID: 100485 RVA: 0x0037EE00 File Offset: 0x0037D000
		public string TidQuestAliasName
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

		// Token: 0x06018886 RID: 100486 RVA: 0x0037EE38 File Offset: 0x0037D038
		public Span<byte> GetTidQuestAliasNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06018887 RID: 100487 RVA: 0x0037EE48 File Offset: 0x0037D048
		public byte[] GetTidQuestAliasNameArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x17007711 RID: 30481
		// (get) Token: 0x06018888 RID: 100488 RVA: 0x0037EE58 File Offset: 0x0037D058
		public string TidQuestAliasDesc
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

		// Token: 0x06018889 RID: 100489 RVA: 0x0037EE90 File Offset: 0x0037D090
		public Span<byte> GetTidQuestAliasDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0601888A RID: 100490 RVA: 0x0037EEA0 File Offset: 0x0037D0A0
		public byte[] GetTidQuestAliasDescArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x17007712 RID: 30482
		// (get) Token: 0x0601888B RID: 100491 RVA: 0x0037EEB0 File Offset: 0x0037D0B0
		public int DungeonId
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

		// Token: 0x17007713 RID: 30483
		// (get) Token: 0x0601888C RID: 100492 RVA: 0x0037EEF0 File Offset: 0x0037D0F0
		public bool DisableOnline
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007714 RID: 30484
		// (get) Token: 0x0601888D RID: 100493 RVA: 0x0037EF30 File Offset: 0x0037D130
		public ISaveConfig? SaveConfig
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return new ISaveConfig?(default(ISaveConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007715 RID: 30485
		// (get) Token: 0x0601888E RID: 100494 RVA: 0x0037EF90 File Offset: 0x0037D190
		public IForceClosedRestriction? ForceClosedRestriction
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return new IForceClosedRestriction?(default(IForceClosedRestriction).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601888F RID: 100495 RVA: 0x0037EFF0 File Offset: 0x0037D1F0
		public string Occupations(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007716 RID: 30486
		// (get) Token: 0x06018890 RID: 100496 RVA: 0x0037F02C File Offset: 0x0037D22C
		public int OccupationsLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007717 RID: 30487
		// (get) Token: 0x06018891 RID: 100497 RVA: 0x0037F058 File Offset: 0x0037D258
		public ILogicNodeOccupation? OccupationConfig
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return new ILogicNodeOccupation?(default(ILogicNodeOccupation).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007718 RID: 30488
		// (get) Token: 0x06018892 RID: 100498 RVA: 0x0037F0B8 File Offset: 0x0037D2B8
		public bool DisableSwitchOccupation
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007719 RID: 30489
		// (get) Token: 0x06018893 RID: 100499 RVA: 0x0037F0F8 File Offset: 0x0037D2F8
		public EBudgetCameraType BudgetCameraType
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return EBudgetCameraType.Role;
				}
				return (EBudgetCameraType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700771A RID: 30490
		// (get) Token: 0x06018894 RID: 100500 RVA: 0x0037F138 File Offset: 0x0037D338
		public IQuestStatistics? Statistics
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return new IQuestStatistics?(default(IQuestStatistics).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700771B RID: 30491
		// (get) Token: 0x06018895 RID: 100501 RVA: 0x0037F198 File Offset: 0x0037D398
		public ETrackViewMode CompositeTrackViewMode
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return ETrackViewMode.All;
				}
				return (ETrackViewMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700771C RID: 30492
		// (get) Token: 0x06018896 RID: 100502 RVA: 0x0037F1D8 File Offset: 0x0037D3D8
		public IQuestRewardConfig? RewardConfig
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return new IQuestRewardConfig?(default(IQuestRewardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700771D RID: 30493
		// (get) Token: 0x06018897 RID: 100503 RVA: 0x0037F238 File Offset: 0x0037D438
		public TSpecialGamePlayConfig SpecialGamePlayConfigType
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return TSpecialGamePlayConfig.NONE;
				}
				return (TSpecialGamePlayConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018898 RID: 100504 RVA: 0x0037F278 File Offset: 0x0037D478
		public TTable? SpecialGamePlayConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018899 RID: 100505 RVA: 0x0037F2C0 File Offset: 0x0037D4C0
		public IEavesdropGamePlayConfig SpecialGamePlayConfigAsIEavesdropGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IEavesdropGamePlayConfig>().Value;
		}

		// Token: 0x0601889A RID: 100506 RVA: 0x0037F2DC File Offset: 0x0037D4DC
		public IFirstPersonTurretGamePlayConfig SpecialGamePlayConfigAsIFirstPersonTurretGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFirstPersonTurretGamePlayConfig>().Value;
		}

		// Token: 0x0601889B RID: 100507 RVA: 0x0037F2F8 File Offset: 0x0037D4F8
		public IFreezeOnSightGamePlayConfig SpecialGamePlayConfigAsIFreezeOnSightGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFreezeOnSightGamePlayConfig>().Value;
		}

		// Token: 0x0601889C RID: 100508 RVA: 0x0037F314 File Offset: 0x0037D514
		public IStalkingGamePlayConfig SpecialGamePlayConfigAsIStalkingGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IStalkingGamePlayConfig>().Value;
		}

		// Token: 0x1700771E RID: 30494
		// (get) Token: 0x0601889D RID: 100509 RVA: 0x0037F330 File Offset: 0x0037D530
		public TEnableSystemConfig EnableSystemType
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return TEnableSystemConfig.NONE;
				}
				return (TEnableSystemConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601889E RID: 100510 RVA: 0x0037F370 File Offset: 0x0037D570
		public TTable? EnableSystem<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601889F RID: 100511 RVA: 0x0037F3B8 File Offset: 0x0037D5B8
		public IDarkTideSystemConfig EnableSystemAsIDarkTideSystemConfig()
		{
			return this.EnableSystem<IDarkTideSystemConfig>().Value;
		}

		// Token: 0x060188A0 RID: 100512 RVA: 0x0037F3D4 File Offset: 0x0037D5D4
		public IFlagChallengeSystemConfig EnableSystemAsIFlagChallengeSystemConfig()
		{
			return this.EnableSystem<IFlagChallengeSystemConfig>().Value;
		}

		// Token: 0x060188A1 RID: 100513 RVA: 0x0037F3F0 File Offset: 0x0037D5F0
		public IFlipperSystemConfig EnableSystemAsIFlipperSystemConfig()
		{
			return this.EnableSystem<IFlipperSystemConfig>().Value;
		}

		// Token: 0x060188A2 RID: 100514 RVA: 0x0037F40C File Offset: 0x0037D60C
		public IGameDifficultySystemConfig EnableSystemAsIGameDifficultySystemConfig()
		{
			return this.EnableSystem<IGameDifficultySystemConfig>().Value;
		}

		// Token: 0x060188A3 RID: 100515 RVA: 0x0037F428 File Offset: 0x0037D628
		public IGradingSystemConfig EnableSystemAsIGradingSystemConfig()
		{
			return this.EnableSystem<IGradingSystemConfig>().Value;
		}

		// Token: 0x060188A4 RID: 100516 RVA: 0x0037F444 File Offset: 0x0037D644
		public IKuroSimpleCombatKillMonsterSystemConfig EnableSystemAsIKuroSimpleCombatKillMonsterSystemConfig()
		{
			return this.EnableSystem<IKuroSimpleCombatKillMonsterSystemConfig>().Value;
		}

		// Token: 0x060188A5 RID: 100517 RVA: 0x0037F460 File Offset: 0x0037D660
		public IKurotatoSystemConfig EnableSystemAsIKurotatoSystemConfig()
		{
			return this.EnableSystem<IKurotatoSystemConfig>().Value;
		}

		// Token: 0x060188A6 RID: 100518 RVA: 0x0037F47C File Offset: 0x0037D67C
		public ILinkSystemConfig EnableSystemAsILinkSystemConfig()
		{
			return this.EnableSystem<ILinkSystemConfig>().Value;
		}

		// Token: 0x060188A7 RID: 100519 RVA: 0x0037F498 File Offset: 0x0037D698
		public IMotorFightSystemConfig EnableSystemAsIMotorFightSystemConfig()
		{
			return this.EnableSystem<IMotorFightSystemConfig>().Value;
		}

		// Token: 0x060188A8 RID: 100520 RVA: 0x0037F4B4 File Offset: 0x0037D6B4
		public IMotorRacingSystemConfig EnableSystemAsIMotorRacingSystemConfig()
		{
			return this.EnableSystem<IMotorRacingSystemConfig>().Value;
		}

		// Token: 0x060188A9 RID: 100521 RVA: 0x0037F4D0 File Offset: 0x0037D6D0
		public INightmareSettlementSystemConfig EnableSystemAsINightmareSettlementSystemConfig()
		{
			return this.EnableSystem<INightmareSettlementSystemConfig>().Value;
		}

		// Token: 0x060188AA RID: 100522 RVA: 0x0037F4EC File Offset: 0x0037D6EC
		public IRogueTowerTrialSystemConfig EnableSystemAsIRogueTowerTrialSystemConfig()
		{
			return this.EnableSystem<IRogueTowerTrialSystemConfig>().Value;
		}

		// Token: 0x060188AB RID: 100523 RVA: 0x0037F508 File Offset: 0x0037D708
		public IRoleTowerSystemConfig EnableSystemAsIRoleTowerSystemConfig()
		{
			return this.EnableSystem<IRoleTowerSystemConfig>().Value;
		}

		// Token: 0x060188AC RID: 100524 RVA: 0x0037F524 File Offset: 0x0037D724
		public ISurvivorsRougeSystemConfig EnableSystemAsISurvivorsRougeSystemConfig()
		{
			return this.EnableSystem<ISurvivorsRougeSystemConfig>().Value;
		}

		// Token: 0x060188AD RID: 100525 RVA: 0x0037F540 File Offset: 0x0037D740
		public ITrapDefenseSystemConfig EnableSystemAsITrapDefenseSystemConfig()
		{
			return this.EnableSystem<ITrapDefenseSystemConfig>().Value;
		}

		// Token: 0x1700771F RID: 30495
		// (get) Token: 0x060188AE RID: 100526 RVA: 0x0037F55C File Offset: 0x0037D75C
		public IWaveConfig? StartWave
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return new IWaveConfig?(default(IWaveConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007720 RID: 30496
		// (get) Token: 0x060188AF RID: 100527 RVA: 0x0037F5BC File Offset: 0x0037D7BC
		public IDisableTrackAnim? DisableTrackAnim
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return new IDisableTrackAnim?(default(IDisableTrackAnim).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007721 RID: 30497
		// (get) Token: 0x060188B0 RID: 100528 RVA: 0x0037F61C File Offset: 0x0037D81C
		public bool DisableSwitchGender
		{
			get
			{
				int num = this.__p.__offset(60);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007722 RID: 30498
		// (get) Token: 0x060188B1 RID: 100529 RVA: 0x0037F65C File Offset: 0x0037D85C
		public bool DisableFocusMode
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007723 RID: 30499
		// (get) Token: 0x060188B2 RID: 100530 RVA: 0x0037F69C File Offset: 0x0037D89C
		public bool DisableSkeletalAnimationCheck
		{
			get
			{
				int num = this.__p.__offset(64);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007724 RID: 30500
		// (get) Token: 0x060188B3 RID: 100531 RVA: 0x0037F6DC File Offset: 0x0037D8DC
		public ILogicProgramSpecialProcess? LogicProgramSpecialProcess
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return new ILogicProgramSpecialProcess?(default(ILogicProgramSpecialProcess).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007725 RID: 30501
		// (get) Token: 0x060188B4 RID: 100532 RVA: 0x0037F73C File Offset: 0x0037D93C
		public IQuestBuffActiveRange? QuestBuffActiveRange
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return null;
				}
				return new IQuestBuffActiveRange?(default(IQuestBuffActiveRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007726 RID: 30502
		// (get) Token: 0x060188B5 RID: 100533 RVA: 0x0037F79C File Offset: 0x0037D99C
		public ISunSpiritProcess? SunSpiritProcess
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return null;
				}
				return new ISunSpiritProcess?(default(ISunSpiritProcess).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007727 RID: 30503
		// (get) Token: 0x060188B6 RID: 100534 RVA: 0x0037F7FC File Offset: 0x0037D9FC
		public ITrackAreaText? ModifyTrackAreaText
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return null;
				}
				return new ITrackAreaText?(default(ITrackAreaText).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007728 RID: 30504
		// (get) Token: 0x060188B7 RID: 100535 RVA: 0x0037F85C File Offset: 0x0037DA5C
		public bool DisableGlobalTraffic
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060188B8 RID: 100536 RVA: 0x0037F89C File Offset: 0x0037DA9C
		public IAreaNameSystemPrompt? DisableSystemPrompt(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IAreaNameSystemPrompt?(default(IAreaNameSystemPrompt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007729 RID: 30505
		// (get) Token: 0x060188B9 RID: 100537 RVA: 0x0037F900 File Offset: 0x0037DB00
		public int DisableSystemPromptLength
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700772A RID: 30506
		// (get) Token: 0x060188BA RID: 100538 RVA: 0x0037F92C File Offset: 0x0037DB2C
		public ITrackCustomBoardOnBtLogicNode? TrackCustomBoard
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return null;
				}
				return new ITrackCustomBoardOnBtLogicNode?(default(ITrackCustomBoardOnBtLogicNode).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060188BB RID: 100539 RVA: 0x0037F98C File Offset: 0x0037DB8C
		public TBtNode ChildrenType(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return TBtNode.NONE;
			}
			return (TBtNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700772B RID: 30507
		// (get) Token: 0x060188BC RID: 100540 RVA: 0x0037F9CC File Offset: 0x0037DBCC
		public int ChildrenTypeLength
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060188BD RID: 100541 RVA: 0x0037F9F8 File Offset: 0x0037DBF8
		public Span<TBtNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TBtNode>(80, 1);
		}

		// Token: 0x060188BE RID: 100542 RVA: 0x0037FA08 File Offset: 0x0037DC08
		public TBtNode[] GetChildrenTypeArray()
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TBtNode[] array = new TBtNode[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TBtNode)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x060188BF RID: 100543 RVA: 0x0037FA74 File Offset: 0x0037DC74
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700772C RID: 30508
		// (get) Token: 0x060188C0 RID: 100544 RVA: 0x0037FABC File Offset: 0x0037DCBC
		public int ChildrenLength
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700772D RID: 30509
		// (get) Token: 0x060188C1 RID: 100545 RVA: 0x0037FAE8 File Offset: 0x0037DCE8
		public EConditionCount Count
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return EConditionCount.All;
				}
				return (EConditionCount)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700772E RID: 30510
		// (get) Token: 0x060188C2 RID: 100546 RVA: 0x0037FB28 File Offset: 0x0037DD28
		public IPerformanceSetting? PerformanceSetting
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return null;
				}
				return new IPerformanceSetting?(default(IPerformanceSetting).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700772F RID: 30511
		// (get) Token: 0x060188C3 RID: 100547 RVA: 0x0037FB88 File Offset: 0x0037DD88
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060188C4 RID: 100548 RVA: 0x0037FBC8 File Offset: 0x0037DDC8
		public static Offset<IParallelSelectBtNode> CreateIParallelSelectBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, Offset<IQuestScheduleConfig> UIConfigOffset = default(Offset<IQuestScheduleConfig>), Offset<IInformationViewConfig> InformationViewOffset = default(Offset<IInformationViewConfig>), Offset<IInformationBoardConfig> InformationBoardOffset = default(Offset<IInformationBoardConfig>), StringOffset TidQuestAliasNameOffset = default(StringOffset), StringOffset TidQuestAliasDescOffset = default(StringOffset), int DungeonId = 0, bool DisableOnline = false, Offset<ISaveConfig> SaveConfigOffset = default(Offset<ISaveConfig>), Offset<IForceClosedRestriction> ForceClosedRestrictionOffset = default(Offset<IForceClosedRestriction>), VectorOffset OccupationsOffset = default(VectorOffset), Offset<ILogicNodeOccupation> OccupationConfigOffset = default(Offset<ILogicNodeOccupation>), bool DisableSwitchOccupation = false, EBudgetCameraType BudgetCameraType = EBudgetCameraType.Role, Offset<IQuestStatistics> StatisticsOffset = default(Offset<IQuestStatistics>), ETrackViewMode CompositeTrackViewMode = ETrackViewMode.All, Offset<IQuestRewardConfig> RewardConfigOffset = default(Offset<IQuestRewardConfig>), TSpecialGamePlayConfig SpecialGamePlayConfig_type = TSpecialGamePlayConfig.NONE, int SpecialGamePlayConfigOffset = 0, TEnableSystemConfig EnableSystem_type = TEnableSystemConfig.NONE, int EnableSystemOffset = 0, Offset<IWaveConfig> StartWaveOffset = default(Offset<IWaveConfig>), Offset<IDisableTrackAnim> DisableTrackAnimOffset = default(Offset<IDisableTrackAnim>), bool DisableSwitchGender = false, bool DisableFocusMode = false, bool DisableSkeletalAnimationCheck = false, Offset<ILogicProgramSpecialProcess> LogicProgramSpecialProcessOffset = default(Offset<ILogicProgramSpecialProcess>), Offset<IQuestBuffActiveRange> QuestBuffActiveRangeOffset = default(Offset<IQuestBuffActiveRange>), Offset<ISunSpiritProcess> SunSpiritProcessOffset = default(Offset<ISunSpiritProcess>), Offset<ITrackAreaText> ModifyTrackAreaTextOffset = default(Offset<ITrackAreaText>), bool DisableGlobalTraffic = false, VectorOffset DisableSystemPromptOffset = default(VectorOffset), Offset<ITrackCustomBoardOnBtLogicNode> TrackCustomBoardOffset = default(Offset<ITrackCustomBoardOnBtLogicNode>), VectorOffset Children_typeOffset = default(VectorOffset), VectorOffset ChildrenOffset = default(VectorOffset), EConditionCount Count = EConditionCount.All, Offset<IPerformanceSetting> PerformanceSettingOffset = default(Offset<IPerformanceSetting>), ushort NullMask = 0)
		{
			builder.StartTable(43);
			IParallelSelectBtNode.AddPerformanceSetting(builder, PerformanceSettingOffset);
			IParallelSelectBtNode.AddChildren(builder, ChildrenOffset);
			IParallelSelectBtNode.AddChildrenType(builder, Children_typeOffset);
			IParallelSelectBtNode.AddTrackCustomBoard(builder, TrackCustomBoardOffset);
			IParallelSelectBtNode.AddDisableSystemPrompt(builder, DisableSystemPromptOffset);
			IParallelSelectBtNode.AddModifyTrackAreaText(builder, ModifyTrackAreaTextOffset);
			IParallelSelectBtNode.AddSunSpiritProcess(builder, SunSpiritProcessOffset);
			IParallelSelectBtNode.AddQuestBuffActiveRange(builder, QuestBuffActiveRangeOffset);
			IParallelSelectBtNode.AddLogicProgramSpecialProcess(builder, LogicProgramSpecialProcessOffset);
			IParallelSelectBtNode.AddDisableTrackAnim(builder, DisableTrackAnimOffset);
			IParallelSelectBtNode.AddStartWave(builder, StartWaveOffset);
			IParallelSelectBtNode.AddEnableSystem(builder, EnableSystemOffset);
			IParallelSelectBtNode.AddSpecialGamePlayConfig(builder, SpecialGamePlayConfigOffset);
			IParallelSelectBtNode.AddRewardConfig(builder, RewardConfigOffset);
			IParallelSelectBtNode.AddStatistics(builder, StatisticsOffset);
			IParallelSelectBtNode.AddOccupationConfig(builder, OccupationConfigOffset);
			IParallelSelectBtNode.AddOccupations(builder, OccupationsOffset);
			IParallelSelectBtNode.AddForceClosedRestriction(builder, ForceClosedRestrictionOffset);
			IParallelSelectBtNode.AddSaveConfig(builder, SaveConfigOffset);
			IParallelSelectBtNode.AddDungeonId(builder, DungeonId);
			IParallelSelectBtNode.AddTidQuestAliasDesc(builder, TidQuestAliasDescOffset);
			IParallelSelectBtNode.AddTidQuestAliasName(builder, TidQuestAliasNameOffset);
			IParallelSelectBtNode.AddInformationBoard(builder, InformationBoardOffset);
			IParallelSelectBtNode.AddInformationView(builder, InformationViewOffset);
			IParallelSelectBtNode.AddUIConfig(builder, UIConfigOffset);
			IParallelSelectBtNode.AddFixProcessor(builder, FixProcessorOffset);
			IParallelSelectBtNode.AddDesc(builder, DescOffset);
			IParallelSelectBtNode.AddId(builder, Id);
			IParallelSelectBtNode.AddNullMask(builder, NullMask);
			IParallelSelectBtNode.AddCount(builder, Count);
			IParallelSelectBtNode.AddDisableGlobalTraffic(builder, DisableGlobalTraffic);
			IParallelSelectBtNode.AddDisableSkeletalAnimationCheck(builder, DisableSkeletalAnimationCheck);
			IParallelSelectBtNode.AddDisableFocusMode(builder, DisableFocusMode);
			IParallelSelectBtNode.AddDisableSwitchGender(builder, DisableSwitchGender);
			IParallelSelectBtNode.AddEnableSystemType(builder, EnableSystem_type);
			IParallelSelectBtNode.AddSpecialGamePlayConfigType(builder, SpecialGamePlayConfig_type);
			IParallelSelectBtNode.AddCompositeTrackViewMode(builder, CompositeTrackViewMode);
			IParallelSelectBtNode.AddBudgetCameraType(builder, BudgetCameraType);
			IParallelSelectBtNode.AddDisableSwitchOccupation(builder, DisableSwitchOccupation);
			IParallelSelectBtNode.AddDisableOnline(builder, DisableOnline);
			IParallelSelectBtNode.AddDisabled(builder, Disabled);
			IParallelSelectBtNode.Add_FoldedForTree(builder, _foldedForTree);
			IParallelSelectBtNode.AddType(builder, Type);
			return IParallelSelectBtNode.EndIParallelSelectBtNode(builder);
		}

		// Token: 0x060188C5 RID: 100549 RVA: 0x0037FD38 File Offset: 0x0037DF38
		public static void StartIParallelSelectBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(43);
		}

		// Token: 0x060188C6 RID: 100550 RVA: 0x0037FD42 File Offset: 0x0037DF42
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060188C7 RID: 100551 RVA: 0x0037FD4D File Offset: 0x0037DF4D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060188C8 RID: 100552 RVA: 0x0037FD58 File Offset: 0x0037DF58
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x060188C9 RID: 100553 RVA: 0x0037FD68 File Offset: 0x0037DF68
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x060188CA RID: 100554 RVA: 0x0037FD78 File Offset: 0x0037DF78
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x060188CB RID: 100555 RVA: 0x0037FD83 File Offset: 0x0037DF83
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x060188CC RID: 100556 RVA: 0x0037FD8E File Offset: 0x0037DF8E
		public static void AddUIConfig(FlatBufferBuilder builder, Offset<IQuestScheduleConfig> uIConfigOffset)
		{
			builder.AddOffset(6, uIConfigOffset.Value, 0);
		}

		// Token: 0x060188CD RID: 100557 RVA: 0x0037FD9E File Offset: 0x0037DF9E
		public static void AddInformationView(FlatBufferBuilder builder, Offset<IInformationViewConfig> informationViewOffset)
		{
			builder.AddOffset(7, informationViewOffset.Value, 0);
		}

		// Token: 0x060188CE RID: 100558 RVA: 0x0037FDAE File Offset: 0x0037DFAE
		public static void AddInformationBoard(FlatBufferBuilder builder, Offset<IInformationBoardConfig> informationBoardOffset)
		{
			builder.AddOffset(8, informationBoardOffset.Value, 0);
		}

		// Token: 0x060188CF RID: 100559 RVA: 0x0037FDBE File Offset: 0x0037DFBE
		public static void AddTidQuestAliasName(FlatBufferBuilder builder, StringOffset tidQuestAliasNameOffset)
		{
			builder.AddOffset(9, tidQuestAliasNameOffset.Value, 0);
		}

		// Token: 0x060188D0 RID: 100560 RVA: 0x0037FDCF File Offset: 0x0037DFCF
		public static void AddTidQuestAliasDesc(FlatBufferBuilder builder, StringOffset tidQuestAliasDescOffset)
		{
			builder.AddOffset(10, tidQuestAliasDescOffset.Value, 0);
		}

		// Token: 0x060188D1 RID: 100561 RVA: 0x0037FDE0 File Offset: 0x0037DFE0
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(11, dungeonId, 0);
		}

		// Token: 0x060188D2 RID: 100562 RVA: 0x0037FDEC File Offset: 0x0037DFEC
		public static void AddDisableOnline(FlatBufferBuilder builder, bool disableOnline)
		{
			builder.AddBool(12, disableOnline, false);
		}

		// Token: 0x060188D3 RID: 100563 RVA: 0x0037FDF8 File Offset: 0x0037DFF8
		public static void AddSaveConfig(FlatBufferBuilder builder, Offset<ISaveConfig> saveConfigOffset)
		{
			builder.AddOffset(13, saveConfigOffset.Value, 0);
		}

		// Token: 0x060188D4 RID: 100564 RVA: 0x0037FE09 File Offset: 0x0037E009
		public static void AddForceClosedRestriction(FlatBufferBuilder builder, Offset<IForceClosedRestriction> forceClosedRestrictionOffset)
		{
			builder.AddOffset(14, forceClosedRestrictionOffset.Value, 0);
		}

		// Token: 0x060188D5 RID: 100565 RVA: 0x0037FE1A File Offset: 0x0037E01A
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(15, occupationsOffset.Value, 0);
		}

		// Token: 0x060188D6 RID: 100566 RVA: 0x0037FE2C File Offset: 0x0037E02C
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060188D7 RID: 100567 RVA: 0x0037FE6C File Offset: 0x0037E06C
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060188D8 RID: 100568 RVA: 0x0037FE86 File Offset: 0x0037E086
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060188D9 RID: 100569 RVA: 0x0037FEA4 File Offset: 0x0037E0A4
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060188DA RID: 100570 RVA: 0x0037FEBD File Offset: 0x0037E0BD
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060188DB RID: 100571 RVA: 0x0037FEC8 File Offset: 0x0037E0C8
		public static void AddOccupationConfig(FlatBufferBuilder builder, Offset<ILogicNodeOccupation> occupationConfigOffset)
		{
			builder.AddOffset(16, occupationConfigOffset.Value, 0);
		}

		// Token: 0x060188DC RID: 100572 RVA: 0x0037FED9 File Offset: 0x0037E0D9
		public static void AddDisableSwitchOccupation(FlatBufferBuilder builder, bool disableSwitchOccupation)
		{
			builder.AddBool(17, disableSwitchOccupation, false);
		}

		// Token: 0x060188DD RID: 100573 RVA: 0x0037FEE5 File Offset: 0x0037E0E5
		public static void AddBudgetCameraType(FlatBufferBuilder builder, EBudgetCameraType budgetCameraType)
		{
			builder.AddByte(18, (byte)budgetCameraType, 0);
		}

		// Token: 0x060188DE RID: 100574 RVA: 0x0037FEF1 File Offset: 0x0037E0F1
		public static void AddStatistics(FlatBufferBuilder builder, Offset<IQuestStatistics> statisticsOffset)
		{
			builder.AddOffset(19, statisticsOffset.Value, 0);
		}

		// Token: 0x060188DF RID: 100575 RVA: 0x0037FF02 File Offset: 0x0037E102
		public static void AddCompositeTrackViewMode(FlatBufferBuilder builder, ETrackViewMode compositeTrackViewMode)
		{
			builder.AddByte(20, (byte)compositeTrackViewMode, 0);
		}

		// Token: 0x060188E0 RID: 100576 RVA: 0x0037FF0E File Offset: 0x0037E10E
		public static void AddRewardConfig(FlatBufferBuilder builder, Offset<IQuestRewardConfig> rewardConfigOffset)
		{
			builder.AddOffset(21, rewardConfigOffset.Value, 0);
		}

		// Token: 0x060188E1 RID: 100577 RVA: 0x0037FF1F File Offset: 0x0037E11F
		public static void AddSpecialGamePlayConfigType(FlatBufferBuilder builder, TSpecialGamePlayConfig specialGamePlayConfigType)
		{
			builder.AddByte(22, (byte)specialGamePlayConfigType, 0);
		}

		// Token: 0x060188E2 RID: 100578 RVA: 0x0037FF2B File Offset: 0x0037E12B
		public static void AddSpecialGamePlayConfig(FlatBufferBuilder builder, int specialGamePlayConfigOffset)
		{
			builder.AddOffset(23, specialGamePlayConfigOffset, 0);
		}

		// Token: 0x060188E3 RID: 100579 RVA: 0x0037FF37 File Offset: 0x0037E137
		public static void AddEnableSystemType(FlatBufferBuilder builder, TEnableSystemConfig enableSystemType)
		{
			builder.AddByte(24, (byte)enableSystemType, 0);
		}

		// Token: 0x060188E4 RID: 100580 RVA: 0x0037FF43 File Offset: 0x0037E143
		public static void AddEnableSystem(FlatBufferBuilder builder, int enableSystemOffset)
		{
			builder.AddOffset(25, enableSystemOffset, 0);
		}

		// Token: 0x060188E5 RID: 100581 RVA: 0x0037FF4F File Offset: 0x0037E14F
		public static void AddStartWave(FlatBufferBuilder builder, Offset<IWaveConfig> startWaveOffset)
		{
			builder.AddOffset(26, startWaveOffset.Value, 0);
		}

		// Token: 0x060188E6 RID: 100582 RVA: 0x0037FF60 File Offset: 0x0037E160
		public static void AddDisableTrackAnim(FlatBufferBuilder builder, Offset<IDisableTrackAnim> disableTrackAnimOffset)
		{
			builder.AddOffset(27, disableTrackAnimOffset.Value, 0);
		}

		// Token: 0x060188E7 RID: 100583 RVA: 0x0037FF71 File Offset: 0x0037E171
		public static void AddDisableSwitchGender(FlatBufferBuilder builder, bool disableSwitchGender)
		{
			builder.AddBool(28, disableSwitchGender, false);
		}

		// Token: 0x060188E8 RID: 100584 RVA: 0x0037FF7D File Offset: 0x0037E17D
		public static void AddDisableFocusMode(FlatBufferBuilder builder, bool disableFocusMode)
		{
			builder.AddBool(29, disableFocusMode, false);
		}

		// Token: 0x060188E9 RID: 100585 RVA: 0x0037FF89 File Offset: 0x0037E189
		public static void AddDisableSkeletalAnimationCheck(FlatBufferBuilder builder, bool disableSkeletalAnimationCheck)
		{
			builder.AddBool(30, disableSkeletalAnimationCheck, false);
		}

		// Token: 0x060188EA RID: 100586 RVA: 0x0037FF95 File Offset: 0x0037E195
		public static void AddLogicProgramSpecialProcess(FlatBufferBuilder builder, Offset<ILogicProgramSpecialProcess> logicProgramSpecialProcessOffset)
		{
			builder.AddOffset(31, logicProgramSpecialProcessOffset.Value, 0);
		}

		// Token: 0x060188EB RID: 100587 RVA: 0x0037FFA6 File Offset: 0x0037E1A6
		public static void AddQuestBuffActiveRange(FlatBufferBuilder builder, Offset<IQuestBuffActiveRange> questBuffActiveRangeOffset)
		{
			builder.AddOffset(32, questBuffActiveRangeOffset.Value, 0);
		}

		// Token: 0x060188EC RID: 100588 RVA: 0x0037FFB7 File Offset: 0x0037E1B7
		public static void AddSunSpiritProcess(FlatBufferBuilder builder, Offset<ISunSpiritProcess> sunSpiritProcessOffset)
		{
			builder.AddOffset(33, sunSpiritProcessOffset.Value, 0);
		}

		// Token: 0x060188ED RID: 100589 RVA: 0x0037FFC8 File Offset: 0x0037E1C8
		public static void AddModifyTrackAreaText(FlatBufferBuilder builder, Offset<ITrackAreaText> modifyTrackAreaTextOffset)
		{
			builder.AddOffset(34, modifyTrackAreaTextOffset.Value, 0);
		}

		// Token: 0x060188EE RID: 100590 RVA: 0x0037FFD9 File Offset: 0x0037E1D9
		public static void AddDisableGlobalTraffic(FlatBufferBuilder builder, bool disableGlobalTraffic)
		{
			builder.AddBool(35, disableGlobalTraffic, false);
		}

		// Token: 0x060188EF RID: 100591 RVA: 0x0037FFE5 File Offset: 0x0037E1E5
		public static void AddDisableSystemPrompt(FlatBufferBuilder builder, VectorOffset disableSystemPromptOffset)
		{
			builder.AddOffset(36, disableSystemPromptOffset.Value, 0);
		}

		// Token: 0x060188F0 RID: 100592 RVA: 0x0037FFF8 File Offset: 0x0037E1F8
		public static VectorOffset CreateDisableSystemPromptVector(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060188F1 RID: 100593 RVA: 0x00380038 File Offset: 0x0037E238
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x060188F2 RID: 100594 RVA: 0x00380052 File Offset: 0x0037E252
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAreaNameSystemPrompt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x060188F3 RID: 100595 RVA: 0x00380070 File Offset: 0x0037E270
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAreaNameSystemPrompt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060188F4 RID: 100596 RVA: 0x00380089 File Offset: 0x0037E289
		public static void StartDisableSystemPromptVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060188F5 RID: 100597 RVA: 0x00380094 File Offset: 0x0037E294
		public static void AddTrackCustomBoard(FlatBufferBuilder builder, Offset<ITrackCustomBoardOnBtLogicNode> trackCustomBoardOffset)
		{
			builder.AddOffset(37, trackCustomBoardOffset.Value, 0);
		}

		// Token: 0x060188F6 RID: 100598 RVA: 0x003800A5 File Offset: 0x0037E2A5
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(38, childrenTypeOffset.Value, 0);
		}

		// Token: 0x060188F7 RID: 100599 RVA: 0x003800B8 File Offset: 0x0037E2B8
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060188F8 RID: 100600 RVA: 0x003800EF File Offset: 0x0037E2EF
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x060188F9 RID: 100601 RVA: 0x00380109 File Offset: 0x0037E309
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TBtNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x060188FA RID: 100602 RVA: 0x00380127 File Offset: 0x0037E327
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TBtNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060188FB RID: 100603 RVA: 0x00380140 File Offset: 0x0037E340
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060188FC RID: 100604 RVA: 0x0038014B File Offset: 0x0037E34B
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(39, childrenOffset.Value, 0);
		}

		// Token: 0x060188FD RID: 100605 RVA: 0x0038015C File Offset: 0x0037E35C
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060188FE RID: 100606 RVA: 0x00380193 File Offset: 0x0037E393
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060188FF RID: 100607 RVA: 0x003801AD File Offset: 0x0037E3AD
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018900 RID: 100608 RVA: 0x003801CB File Offset: 0x0037E3CB
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018901 RID: 100609 RVA: 0x003801E4 File Offset: 0x0037E3E4
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018902 RID: 100610 RVA: 0x003801EF File Offset: 0x0037E3EF
		public static void AddCount(FlatBufferBuilder builder, EConditionCount count)
		{
			builder.AddByte(40, (byte)count, 0);
		}

		// Token: 0x06018903 RID: 100611 RVA: 0x003801FB File Offset: 0x0037E3FB
		public static void AddPerformanceSetting(FlatBufferBuilder builder, Offset<IPerformanceSetting> performanceSettingOffset)
		{
			builder.AddOffset(41, performanceSettingOffset.Value, 0);
		}

		// Token: 0x06018904 RID: 100612 RVA: 0x0038020C File Offset: 0x0037E40C
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(42, nullMask, 0);
		}

		// Token: 0x06018905 RID: 100613 RVA: 0x00380218 File Offset: 0x0037E418
		public static Offset<IParallelSelectBtNode> EndIParallelSelectBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IParallelSelectBtNode>(builder.EndTable());
		}

		// Token: 0x06018906 RID: 100614 RVA: 0x00380228 File Offset: 0x0037E428
		public IParallelSelectBtNodeT UnPack()
		{
			IParallelSelectBtNodeT parallelSelectBtNodeT = new IParallelSelectBtNodeT();
			this.UnPackTo(parallelSelectBtNodeT);
			return parallelSelectBtNodeT;
		}

		// Token: 0x06018907 RID: 100615 RVA: 0x00380244 File Offset: 0x0037E444
		public void UnPackTo(IParallelSelectBtNodeT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.FixProcessor = ((this.FixProcessor != null) ? this.FixProcessor.Value.UnPack() : null);
			_o._FoldedForTree = this._FoldedForTree;
			_o.Disabled = this.Disabled;
			_o.UIConfig = ((this.UIConfig != null) ? this.UIConfig.Value.UnPack() : null);
			_o.InformationView = ((this.InformationView != null) ? this.InformationView.Value.UnPack() : null);
			_o.InformationBoard = ((this.InformationBoard != null) ? this.InformationBoard.Value.UnPack() : null);
			_o.TidQuestAliasName = this.TidQuestAliasName;
			_o.TidQuestAliasDesc = this.TidQuestAliasDesc;
			_o.DungeonId = this.DungeonId;
			_o.DisableOnline = this.DisableOnline;
			_o.SaveConfig = ((this.SaveConfig != null) ? this.SaveConfig.Value.UnPack() : null);
			_o.ForceClosedRestriction = ((this.ForceClosedRestriction != null) ? this.ForceClosedRestriction.Value.UnPack() : null);
			_o.Occupations = new List<string>();
			for (int i = 0; i < this.OccupationsLength; i++)
			{
				_o.Occupations.Add(this.Occupations(i));
			}
			_o.OccupationConfig = ((this.OccupationConfig != null) ? this.OccupationConfig.Value.UnPack() : null);
			_o.DisableSwitchOccupation = this.DisableSwitchOccupation;
			_o.BudgetCameraType = this.BudgetCameraType;
			_o.Statistics = ((this.Statistics != null) ? this.Statistics.Value.UnPack() : null);
			_o.CompositeTrackViewMode = this.CompositeTrackViewMode;
			_o.RewardConfig = ((this.RewardConfig != null) ? this.RewardConfig.Value.UnPack() : null);
			_o.SpecialGamePlayConfig = new TSpecialGamePlayConfigUnion();
			_o.SpecialGamePlayConfig.Type = this.SpecialGamePlayConfigType;
			switch (this.SpecialGamePlayConfigType)
			{
			case TSpecialGamePlayConfig.IEavesdropGamePlayConfig:
				_o.SpecialGamePlayConfig.Value = ((this.SpecialGamePlayConfig<IEavesdropGamePlayConfig>() != null) ? this.SpecialGamePlayConfig<IEavesdropGamePlayConfig>().Value.UnPack() : null);
				break;
			case TSpecialGamePlayConfig.IFirstPersonTurretGamePlayConfig:
				_o.SpecialGamePlayConfig.Value = ((this.SpecialGamePlayConfig<IFirstPersonTurretGamePlayConfig>() != null) ? this.SpecialGamePlayConfig<IFirstPersonTurretGamePlayConfig>().Value.UnPack() : null);
				break;
			case TSpecialGamePlayConfig.IFreezeOnSightGamePlayConfig:
				_o.SpecialGamePlayConfig.Value = ((this.SpecialGamePlayConfig<IFreezeOnSightGamePlayConfig>() != null) ? this.SpecialGamePlayConfig<IFreezeOnSightGamePlayConfig>().Value.UnPack() : null);
				break;
			case TSpecialGamePlayConfig.IStalkingGamePlayConfig:
				_o.SpecialGamePlayConfig.Value = ((this.SpecialGamePlayConfig<IStalkingGamePlayConfig>() != null) ? this.SpecialGamePlayConfig<IStalkingGamePlayConfig>().Value.UnPack() : null);
				break;
			}
			_o.EnableSystem = new TEnableSystemConfigUnion();
			_o.EnableSystem.Type = this.EnableSystemType;
			switch (this.EnableSystemType)
			{
			case TEnableSystemConfig.IDarkTideSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IDarkTideSystemConfig>() != null) ? this.EnableSystem<IDarkTideSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IFlagChallengeSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IFlagChallengeSystemConfig>() != null) ? this.EnableSystem<IFlagChallengeSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IFlipperSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IFlipperSystemConfig>() != null) ? this.EnableSystem<IFlipperSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IGameDifficultySystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IGameDifficultySystemConfig>() != null) ? this.EnableSystem<IGameDifficultySystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IGradingSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IGradingSystemConfig>() != null) ? this.EnableSystem<IGradingSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IKuroSimpleCombatKillMonsterSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IKuroSimpleCombatKillMonsterSystemConfig>() != null) ? this.EnableSystem<IKuroSimpleCombatKillMonsterSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IKurotatoSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IKurotatoSystemConfig>() != null) ? this.EnableSystem<IKurotatoSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.ILinkSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<ILinkSystemConfig>() != null) ? this.EnableSystem<ILinkSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IMotorFightSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IMotorFightSystemConfig>() != null) ? this.EnableSystem<IMotorFightSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IMotorRacingSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IMotorRacingSystemConfig>() != null) ? this.EnableSystem<IMotorRacingSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.INightmareSettlementSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<INightmareSettlementSystemConfig>() != null) ? this.EnableSystem<INightmareSettlementSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IRogueTowerTrialSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IRogueTowerTrialSystemConfig>() != null) ? this.EnableSystem<IRogueTowerTrialSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IRoleTowerSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IRoleTowerSystemConfig>() != null) ? this.EnableSystem<IRoleTowerSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.ISurvivorsRougeSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<ISurvivorsRougeSystemConfig>() != null) ? this.EnableSystem<ISurvivorsRougeSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.ITrapDefenseSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<ITrapDefenseSystemConfig>() != null) ? this.EnableSystem<ITrapDefenseSystemConfig>().Value.UnPack() : null);
				break;
			}
			_o.StartWave = ((this.StartWave != null) ? this.StartWave.Value.UnPack() : null);
			_o.DisableTrackAnim = ((this.DisableTrackAnim != null) ? this.DisableTrackAnim.Value.UnPack() : null);
			_o.DisableSwitchGender = this.DisableSwitchGender;
			_o.DisableFocusMode = this.DisableFocusMode;
			_o.DisableSkeletalAnimationCheck = this.DisableSkeletalAnimationCheck;
			_o.LogicProgramSpecialProcess = ((this.LogicProgramSpecialProcess != null) ? this.LogicProgramSpecialProcess.Value.UnPack() : null);
			_o.QuestBuffActiveRange = ((this.QuestBuffActiveRange != null) ? this.QuestBuffActiveRange.Value.UnPack() : null);
			_o.SunSpiritProcess = ((this.SunSpiritProcess != null) ? this.SunSpiritProcess.Value.UnPack() : null);
			_o.ModifyTrackAreaText = ((this.ModifyTrackAreaText != null) ? this.ModifyTrackAreaText.Value.UnPack() : null);
			_o.DisableGlobalTraffic = this.DisableGlobalTraffic;
			_o.DisableSystemPrompt = new List<IAreaNameSystemPromptT>();
			for (int j = 0; j < this.DisableSystemPromptLength; j++)
			{
				_o.DisableSystemPrompt.Add((this.DisableSystemPrompt(j) != null) ? this.DisableSystemPrompt(j).Value.UnPack() : null);
			}
			_o.TrackCustomBoard = ((this.TrackCustomBoard != null) ? this.TrackCustomBoard.Value.UnPack() : null);
			_o.Children = new List<TBtNodeUnion>();
			for (int k = 0; k < this.ChildrenLength; k++)
			{
				TBtNodeUnion tbtNodeUnion = new TBtNodeUnion();
				tbtNodeUnion.Type = this.ChildrenType(k);
				switch (this.ChildrenType(k))
				{
				case TBtNode.IActionBtNode:
					tbtNodeUnion.Value = ((this.Children<IActionBtNode>(k) != null) ? this.Children<IActionBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IActionWithResultBtNode:
					tbtNodeUnion.Value = ((this.Children<IActionWithResultBtNode>(k) != null) ? this.Children<IActionWithResultBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IAlwaysFalseBtNode:
					tbtNodeUnion.Value = ((this.Children<IAlwaysFalseBtNode>(k) != null) ? this.Children<IAlwaysFalseBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IAlwaysTrueBtNode:
					tbtNodeUnion.Value = ((this.Children<IAlwaysTrueBtNode>(k) != null) ? this.Children<IAlwaysTrueBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IChildQuestBtNode:
					tbtNodeUnion.Value = ((this.Children<IChildQuestBtNode>(k) != null) ? this.Children<IChildQuestBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IConditionBtNode:
					tbtNodeUnion.Value = ((this.Children<IConditionBtNode>(k) != null) ? this.Children<IConditionBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IConditionSelectorBtNode:
					tbtNodeUnion.Value = ((this.Children<IConditionSelectorBtNode>(k) != null) ? this.Children<IConditionSelectorBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IParallelSelectBtNode:
					tbtNodeUnion.Value = ((this.Children<IParallelSelectBtNode>(k) != null) ? this.Children<IParallelSelectBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IQuestFailedBtNode:
					tbtNodeUnion.Value = ((this.Children<IQuestFailedBtNode>(k) != null) ? this.Children<IQuestFailedBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IQuestSucceedBtNode:
					tbtNodeUnion.Value = ((this.Children<IQuestSucceedBtNode>(k) != null) ? this.Children<IQuestSucceedBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IRepeaterBtNode:
					tbtNodeUnion.Value = ((this.Children<IRepeaterBtNode>(k) != null) ? this.Children<IRepeaterBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.ISelectBtNode:
					tbtNodeUnion.Value = ((this.Children<ISelectBtNode>(k) != null) ? this.Children<ISelectBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.ISequenceBtNode:
					tbtNodeUnion.Value = ((this.Children<ISequenceBtNode>(k) != null) ? this.Children<ISequenceBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IStartBtNode:
					tbtNodeUnion.Value = ((this.Children<IStartBtNode>(k) != null) ? this.Children<IStartBtNode>(k).Value.UnPack() : null);
					break;
				}
				_o.Children.Add(tbtNodeUnion);
			}
			_o.Count = this.Count;
			_o.PerformanceSetting = ((this.PerformanceSetting != null) ? this.PerformanceSetting.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018908 RID: 100616 RVA: 0x00380FE8 File Offset: 0x0037F1E8
		public static Offset<IParallelSelectBtNode> Pack(FlatBufferBuilder builder, IParallelSelectBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IParallelSelectBtNode>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			Offset<IFixProcessor> fixProcessorOffset = (_o.FixProcessor == null) ? default(Offset<IFixProcessor>) : IFixProcessor.Pack(builder, _o.FixProcessor);
			Offset<IQuestScheduleConfig> uiconfigOffset = (_o.UIConfig == null) ? default(Offset<IQuestScheduleConfig>) : IQuestScheduleConfig.Pack(builder, _o.UIConfig);
			Offset<IInformationViewConfig> informationViewOffset = (_o.InformationView == null) ? default(Offset<IInformationViewConfig>) : IInformationViewConfig.Pack(builder, _o.InformationView);
			Offset<IInformationBoardConfig> informationBoardOffset = (_o.InformationBoard == null) ? default(Offset<IInformationBoardConfig>) : IInformationBoardConfig.Pack(builder, _o.InformationBoard);
			StringOffset tidQuestAliasNameOffset = (_o.TidQuestAliasName == null) ? default(StringOffset) : builder.CreateString(_o.TidQuestAliasName);
			StringOffset tidQuestAliasDescOffset = (_o.TidQuestAliasDesc == null) ? default(StringOffset) : builder.CreateString(_o.TidQuestAliasDesc);
			Offset<ISaveConfig> saveConfigOffset = (_o.SaveConfig == null) ? default(Offset<ISaveConfig>) : ISaveConfig.Pack(builder, _o.SaveConfig);
			Offset<IForceClosedRestriction> forceClosedRestrictionOffset = (_o.ForceClosedRestriction == null) ? default(Offset<IForceClosedRestriction>) : IForceClosedRestriction.Pack(builder, _o.ForceClosedRestriction);
			VectorOffset occupationsOffset = default(VectorOffset);
			if (_o.Occupations != null)
			{
				StringOffset[] array = new StringOffset[_o.Occupations.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Occupations[i]);
				}
				occupationsOffset = IParallelSelectBtNode.CreateOccupationsVector(builder, array);
			}
			Offset<ILogicNodeOccupation> occupationConfigOffset = (_o.OccupationConfig == null) ? default(Offset<ILogicNodeOccupation>) : ILogicNodeOccupation.Pack(builder, _o.OccupationConfig);
			Offset<IQuestStatistics> statisticsOffset = (_o.Statistics == null) ? default(Offset<IQuestStatistics>) : IQuestStatistics.Pack(builder, _o.Statistics);
			Offset<IQuestRewardConfig> rewardConfigOffset = (_o.RewardConfig == null) ? default(Offset<IQuestRewardConfig>) : IQuestRewardConfig.Pack(builder, _o.RewardConfig);
			TSpecialGamePlayConfig specialGamePlayConfig_type = (_o.SpecialGamePlayConfig == null) ? TSpecialGamePlayConfig.NONE : _o.SpecialGamePlayConfig.Type;
			int specialGamePlayConfigOffset = (_o.SpecialGamePlayConfig == null) ? 0 : TSpecialGamePlayConfigUnion.Pack(builder, _o.SpecialGamePlayConfig);
			TEnableSystemConfig enableSystem_type = (_o.EnableSystem == null) ? TEnableSystemConfig.NONE : _o.EnableSystem.Type;
			int enableSystemOffset = (_o.EnableSystem == null) ? 0 : TEnableSystemConfigUnion.Pack(builder, _o.EnableSystem);
			Offset<IWaveConfig> startWaveOffset = (_o.StartWave == null) ? default(Offset<IWaveConfig>) : IWaveConfig.Pack(builder, _o.StartWave);
			Offset<IDisableTrackAnim> disableTrackAnimOffset = (_o.DisableTrackAnim == null) ? default(Offset<IDisableTrackAnim>) : IDisableTrackAnim.Pack(builder, _o.DisableTrackAnim);
			Offset<ILogicProgramSpecialProcess> logicProgramSpecialProcessOffset = (_o.LogicProgramSpecialProcess == null) ? default(Offset<ILogicProgramSpecialProcess>) : ILogicProgramSpecialProcess.Pack(builder, _o.LogicProgramSpecialProcess);
			Offset<IQuestBuffActiveRange> questBuffActiveRangeOffset = (_o.QuestBuffActiveRange == null) ? default(Offset<IQuestBuffActiveRange>) : IQuestBuffActiveRange.Pack(builder, _o.QuestBuffActiveRange);
			Offset<ISunSpiritProcess> sunSpiritProcessOffset = (_o.SunSpiritProcess == null) ? default(Offset<ISunSpiritProcess>) : ISunSpiritProcess.Pack(builder, _o.SunSpiritProcess);
			Offset<ITrackAreaText> modifyTrackAreaTextOffset = (_o.ModifyTrackAreaText == null) ? default(Offset<ITrackAreaText>) : ITrackAreaText.Pack(builder, _o.ModifyTrackAreaText);
			VectorOffset disableSystemPromptOffset = default(VectorOffset);
			if (_o.DisableSystemPrompt != null)
			{
				Offset<IAreaNameSystemPrompt>[] array2 = new Offset<IAreaNameSystemPrompt>[_o.DisableSystemPrompt.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IAreaNameSystemPrompt.Pack(builder, _o.DisableSystemPrompt[j]);
				}
				disableSystemPromptOffset = IParallelSelectBtNode.CreateDisableSystemPromptVector(builder, array2);
			}
			Offset<ITrackCustomBoardOnBtLogicNode> trackCustomBoardOffset = (_o.TrackCustomBoard == null) ? default(Offset<ITrackCustomBoardOnBtLogicNode>) : ITrackCustomBoardOnBtLogicNode.Pack(builder, _o.TrackCustomBoard);
			VectorOffset children_typeOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				TBtNode[] array3 = new TBtNode[_o.Children.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = _o.Children[k].Type;
				}
				children_typeOffset = IParallelSelectBtNode.CreateChildrenTypeVector(builder, array3);
			}
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				int[] array4 = new int[_o.Children.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = TBtNodeUnion.Pack(builder, _o.Children[l]);
				}
				childrenOffset = IParallelSelectBtNode.CreateChildrenVector(builder, array4);
			}
			Offset<IPerformanceSetting> performanceSettingOffset = (_o.PerformanceSetting == null) ? default(Offset<IPerformanceSetting>) : IPerformanceSetting.Pack(builder, _o.PerformanceSetting);
			return IParallelSelectBtNode.CreateIParallelSelectBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, uiconfigOffset, informationViewOffset, informationBoardOffset, tidQuestAliasNameOffset, tidQuestAliasDescOffset, _o.DungeonId, _o.DisableOnline, saveConfigOffset, forceClosedRestrictionOffset, occupationsOffset, occupationConfigOffset, _o.DisableSwitchOccupation, _o.BudgetCameraType, statisticsOffset, _o.CompositeTrackViewMode, rewardConfigOffset, specialGamePlayConfig_type, specialGamePlayConfigOffset, enableSystem_type, enableSystemOffset, startWaveOffset, disableTrackAnimOffset, _o.DisableSwitchGender, _o.DisableFocusMode, _o.DisableSkeletalAnimationCheck, logicProgramSpecialProcessOffset, questBuffActiveRangeOffset, sunSpiritProcessOffset, modifyTrackAreaTextOffset, _o.DisableGlobalTraffic, disableSystemPromptOffset, trackCustomBoardOffset, children_typeOffset, childrenOffset, _o.Count, performanceSettingOffset, _o.NullMask);
		}

		// Token: 0x0400C37E RID: 50046
		private Table __p;
	}
}
