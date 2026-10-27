using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004109 RID: 16649
	public struct ISelectBtNode : IFlatbufferObject
	{
		// Token: 0x1700755F RID: 30047
		// (get) Token: 0x06018477 RID: 99447 RVA: 0x0037E93B File Offset: 0x0037CB3B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018478 RID: 99448 RVA: 0x0037E948 File Offset: 0x0037CB48
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018479 RID: 99449 RVA: 0x0037E950 File Offset: 0x0037CB50
		public static ISelectBtNode GetRootAsISelectBtNode(ByteBuffer _bb)
		{
			return ISelectBtNode.GetRootAsISelectBtNode(_bb, default(ISelectBtNode));
		}

		// Token: 0x0601847A RID: 99450 RVA: 0x0037E96C File Offset: 0x0037CB6C
		public static ISelectBtNode GetRootAsISelectBtNode(ByteBuffer _bb, ISelectBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601847B RID: 99451 RVA: 0x0037E989 File Offset: 0x0037CB89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601847C RID: 99452 RVA: 0x0037E998 File Offset: 0x0037CB98
		public ISelectBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007560 RID: 30048
		// (get) Token: 0x0601847D RID: 99453 RVA: 0x0037E9A8 File Offset: 0x0037CBA8
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

		// Token: 0x17007561 RID: 30049
		// (get) Token: 0x0601847E RID: 99454 RVA: 0x0037E9E4 File Offset: 0x0037CBE4
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

		// Token: 0x17007562 RID: 30050
		// (get) Token: 0x0601847F RID: 99455 RVA: 0x0037EA20 File Offset: 0x0037CC20
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

		// Token: 0x06018480 RID: 99456 RVA: 0x0037EA57 File Offset: 0x0037CC57
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06018481 RID: 99457 RVA: 0x0037EA66 File Offset: 0x0037CC66
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007563 RID: 30051
		// (get) Token: 0x06018482 RID: 99458 RVA: 0x0037EA74 File Offset: 0x0037CC74
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

		// Token: 0x17007564 RID: 30052
		// (get) Token: 0x06018483 RID: 99459 RVA: 0x0037EAD4 File Offset: 0x0037CCD4
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007565 RID: 30053
		// (get) Token: 0x06018484 RID: 99460 RVA: 0x0037EB14 File Offset: 0x0037CD14
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007566 RID: 30054
		// (get) Token: 0x06018485 RID: 99461 RVA: 0x0037EB54 File Offset: 0x0037CD54
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

		// Token: 0x17007567 RID: 30055
		// (get) Token: 0x06018486 RID: 99462 RVA: 0x0037EBB4 File Offset: 0x0037CDB4
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

		// Token: 0x17007568 RID: 30056
		// (get) Token: 0x06018487 RID: 99463 RVA: 0x0037EC14 File Offset: 0x0037CE14
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

		// Token: 0x17007569 RID: 30057
		// (get) Token: 0x06018488 RID: 99464 RVA: 0x0037EC74 File Offset: 0x0037CE74
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

		// Token: 0x06018489 RID: 99465 RVA: 0x0037ECAC File Offset: 0x0037CEAC
		public Span<byte> GetTidQuestAliasNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0601848A RID: 99466 RVA: 0x0037ECBC File Offset: 0x0037CEBC
		public byte[] GetTidQuestAliasNameArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700756A RID: 30058
		// (get) Token: 0x0601848B RID: 99467 RVA: 0x0037ECCC File Offset: 0x0037CECC
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

		// Token: 0x0601848C RID: 99468 RVA: 0x0037ED04 File Offset: 0x0037CF04
		public Span<byte> GetTidQuestAliasDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0601848D RID: 99469 RVA: 0x0037ED14 File Offset: 0x0037CF14
		public byte[] GetTidQuestAliasDescArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x1700756B RID: 30059
		// (get) Token: 0x0601848E RID: 99470 RVA: 0x0037ED24 File Offset: 0x0037CF24
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

		// Token: 0x1700756C RID: 30060
		// (get) Token: 0x0601848F RID: 99471 RVA: 0x0037ED64 File Offset: 0x0037CF64
		public bool DisableOnline
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700756D RID: 30061
		// (get) Token: 0x06018490 RID: 99472 RVA: 0x0037EDA4 File Offset: 0x0037CFA4
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

		// Token: 0x1700756E RID: 30062
		// (get) Token: 0x06018491 RID: 99473 RVA: 0x0037EE04 File Offset: 0x0037D004
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

		// Token: 0x06018492 RID: 99474 RVA: 0x0037EE64 File Offset: 0x0037D064
		public string Occupations(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700756F RID: 30063
		// (get) Token: 0x06018493 RID: 99475 RVA: 0x0037EEA0 File Offset: 0x0037D0A0
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

		// Token: 0x17007570 RID: 30064
		// (get) Token: 0x06018494 RID: 99476 RVA: 0x0037EECC File Offset: 0x0037D0CC
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

		// Token: 0x17007571 RID: 30065
		// (get) Token: 0x06018495 RID: 99477 RVA: 0x0037EF2C File Offset: 0x0037D12C
		public bool DisableSwitchOccupation
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007572 RID: 30066
		// (get) Token: 0x06018496 RID: 99478 RVA: 0x0037EF6C File Offset: 0x0037D16C
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

		// Token: 0x17007573 RID: 30067
		// (get) Token: 0x06018497 RID: 99479 RVA: 0x0037EFAC File Offset: 0x0037D1AC
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

		// Token: 0x17007574 RID: 30068
		// (get) Token: 0x06018498 RID: 99480 RVA: 0x0037F00C File Offset: 0x0037D20C
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

		// Token: 0x17007575 RID: 30069
		// (get) Token: 0x06018499 RID: 99481 RVA: 0x0037F04C File Offset: 0x0037D24C
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

		// Token: 0x17007576 RID: 30070
		// (get) Token: 0x0601849A RID: 99482 RVA: 0x0037F0AC File Offset: 0x0037D2AC
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

		// Token: 0x0601849B RID: 99483 RVA: 0x0037F0EC File Offset: 0x0037D2EC
		public TTable? SpecialGamePlayConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601849C RID: 99484 RVA: 0x0037F134 File Offset: 0x0037D334
		public IEavesdropGamePlayConfig SpecialGamePlayConfigAsIEavesdropGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IEavesdropGamePlayConfig>().Value;
		}

		// Token: 0x0601849D RID: 99485 RVA: 0x0037F150 File Offset: 0x0037D350
		public IFirstPersonTurretGamePlayConfig SpecialGamePlayConfigAsIFirstPersonTurretGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFirstPersonTurretGamePlayConfig>().Value;
		}

		// Token: 0x0601849E RID: 99486 RVA: 0x0037F16C File Offset: 0x0037D36C
		public IFreezeOnSightGamePlayConfig SpecialGamePlayConfigAsIFreezeOnSightGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFreezeOnSightGamePlayConfig>().Value;
		}

		// Token: 0x0601849F RID: 99487 RVA: 0x0037F188 File Offset: 0x0037D388
		public IStalkingGamePlayConfig SpecialGamePlayConfigAsIStalkingGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IStalkingGamePlayConfig>().Value;
		}

		// Token: 0x17007577 RID: 30071
		// (get) Token: 0x060184A0 RID: 99488 RVA: 0x0037F1A4 File Offset: 0x0037D3A4
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

		// Token: 0x060184A1 RID: 99489 RVA: 0x0037F1E4 File Offset: 0x0037D3E4
		public TTable? EnableSystem<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060184A2 RID: 99490 RVA: 0x0037F22C File Offset: 0x0037D42C
		public IFlagChallengeSystemConfig EnableSystemAsIFlagChallengeSystemConfig()
		{
			return this.EnableSystem<IFlagChallengeSystemConfig>().Value;
		}

		// Token: 0x060184A3 RID: 99491 RVA: 0x0037F248 File Offset: 0x0037D448
		public IFlipperSystemConfig EnableSystemAsIFlipperSystemConfig()
		{
			return this.EnableSystem<IFlipperSystemConfig>().Value;
		}

		// Token: 0x060184A4 RID: 99492 RVA: 0x0037F264 File Offset: 0x0037D464
		public IGameDifficultySystemConfig EnableSystemAsIGameDifficultySystemConfig()
		{
			return this.EnableSystem<IGameDifficultySystemConfig>().Value;
		}

		// Token: 0x060184A5 RID: 99493 RVA: 0x0037F280 File Offset: 0x0037D480
		public IGradingSystemConfig EnableSystemAsIGradingSystemConfig()
		{
			return this.EnableSystem<IGradingSystemConfig>().Value;
		}

		// Token: 0x060184A6 RID: 99494 RVA: 0x0037F29C File Offset: 0x0037D49C
		public IKuroSimpleCombatKillMonsterSystemConfig EnableSystemAsIKuroSimpleCombatKillMonsterSystemConfig()
		{
			return this.EnableSystem<IKuroSimpleCombatKillMonsterSystemConfig>().Value;
		}

		// Token: 0x060184A7 RID: 99495 RVA: 0x0037F2B8 File Offset: 0x0037D4B8
		public IKurotatoSystemConfig EnableSystemAsIKurotatoSystemConfig()
		{
			return this.EnableSystem<IKurotatoSystemConfig>().Value;
		}

		// Token: 0x060184A8 RID: 99496 RVA: 0x0037F2D4 File Offset: 0x0037D4D4
		public ILinkSystemConfig EnableSystemAsILinkSystemConfig()
		{
			return this.EnableSystem<ILinkSystemConfig>().Value;
		}

		// Token: 0x060184A9 RID: 99497 RVA: 0x0037F2F0 File Offset: 0x0037D4F0
		public IMotorFightSystemConfig EnableSystemAsIMotorFightSystemConfig()
		{
			return this.EnableSystem<IMotorFightSystemConfig>().Value;
		}

		// Token: 0x060184AA RID: 99498 RVA: 0x0037F30C File Offset: 0x0037D50C
		public IMotorRacingSystemConfig EnableSystemAsIMotorRacingSystemConfig()
		{
			return this.EnableSystem<IMotorRacingSystemConfig>().Value;
		}

		// Token: 0x060184AB RID: 99499 RVA: 0x0037F328 File Offset: 0x0037D528
		public INightmareSettlementSystemConfig EnableSystemAsINightmareSettlementSystemConfig()
		{
			return this.EnableSystem<INightmareSettlementSystemConfig>().Value;
		}

		// Token: 0x060184AC RID: 99500 RVA: 0x0037F344 File Offset: 0x0037D544
		public IRogueTowerTrialSystemConfig EnableSystemAsIRogueTowerTrialSystemConfig()
		{
			return this.EnableSystem<IRogueTowerTrialSystemConfig>().Value;
		}

		// Token: 0x060184AD RID: 99501 RVA: 0x0037F360 File Offset: 0x0037D560
		public IRoleTowerSystemConfig EnableSystemAsIRoleTowerSystemConfig()
		{
			return this.EnableSystem<IRoleTowerSystemConfig>().Value;
		}

		// Token: 0x060184AE RID: 99502 RVA: 0x0037F37C File Offset: 0x0037D57C
		public ISurvivorsRougeSystemConfig EnableSystemAsISurvivorsRougeSystemConfig()
		{
			return this.EnableSystem<ISurvivorsRougeSystemConfig>().Value;
		}

		// Token: 0x060184AF RID: 99503 RVA: 0x0037F398 File Offset: 0x0037D598
		public ITrapDefenseSystemConfig EnableSystemAsITrapDefenseSystemConfig()
		{
			return this.EnableSystem<ITrapDefenseSystemConfig>().Value;
		}

		// Token: 0x17007578 RID: 30072
		// (get) Token: 0x060184B0 RID: 99504 RVA: 0x0037F3B4 File Offset: 0x0037D5B4
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

		// Token: 0x17007579 RID: 30073
		// (get) Token: 0x060184B1 RID: 99505 RVA: 0x0037F414 File Offset: 0x0037D614
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

		// Token: 0x1700757A RID: 30074
		// (get) Token: 0x060184B2 RID: 99506 RVA: 0x0037F474 File Offset: 0x0037D674
		public bool DisableSwitchGender
		{
			get
			{
				int num = this.__p.__offset(60);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700757B RID: 30075
		// (get) Token: 0x060184B3 RID: 99507 RVA: 0x0037F4B4 File Offset: 0x0037D6B4
		public bool DisableFocusMode
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700757C RID: 30076
		// (get) Token: 0x060184B4 RID: 99508 RVA: 0x0037F4F4 File Offset: 0x0037D6F4
		public bool DisableSkeletalAnimationCheck
		{
			get
			{
				int num = this.__p.__offset(64);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700757D RID: 30077
		// (get) Token: 0x060184B5 RID: 99509 RVA: 0x0037F534 File Offset: 0x0037D734
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

		// Token: 0x1700757E RID: 30078
		// (get) Token: 0x060184B6 RID: 99510 RVA: 0x0037F594 File Offset: 0x0037D794
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

		// Token: 0x1700757F RID: 30079
		// (get) Token: 0x060184B7 RID: 99511 RVA: 0x0037F5F4 File Offset: 0x0037D7F4
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

		// Token: 0x17007580 RID: 30080
		// (get) Token: 0x060184B8 RID: 99512 RVA: 0x0037F654 File Offset: 0x0037D854
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

		// Token: 0x17007581 RID: 30081
		// (get) Token: 0x060184B9 RID: 99513 RVA: 0x0037F6B4 File Offset: 0x0037D8B4
		public bool DisableGlobalTraffic
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060184BA RID: 99514 RVA: 0x0037F6F4 File Offset: 0x0037D8F4
		public IAreaNameSystemPrompt? DisableSystemPrompt(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IAreaNameSystemPrompt?(default(IAreaNameSystemPrompt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007582 RID: 30082
		// (get) Token: 0x060184BB RID: 99515 RVA: 0x0037F758 File Offset: 0x0037D958
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

		// Token: 0x17007583 RID: 30083
		// (get) Token: 0x060184BC RID: 99516 RVA: 0x0037F784 File Offset: 0x0037D984
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

		// Token: 0x060184BD RID: 99517 RVA: 0x0037F7E4 File Offset: 0x0037D9E4
		public TBtNode ChildrenType(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return TBtNode.NONE;
			}
			return (TBtNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007584 RID: 30084
		// (get) Token: 0x060184BE RID: 99518 RVA: 0x0037F824 File Offset: 0x0037DA24
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

		// Token: 0x060184BF RID: 99519 RVA: 0x0037F850 File Offset: 0x0037DA50
		public Span<TBtNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TBtNode>(80, 1);
		}

		// Token: 0x060184C0 RID: 99520 RVA: 0x0037F860 File Offset: 0x0037DA60
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

		// Token: 0x060184C1 RID: 99521 RVA: 0x0037F8CC File Offset: 0x0037DACC
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007585 RID: 30085
		// (get) Token: 0x060184C2 RID: 99522 RVA: 0x0037F914 File Offset: 0x0037DB14
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

		// Token: 0x17007586 RID: 30086
		// (get) Token: 0x060184C3 RID: 99523 RVA: 0x0037F940 File Offset: 0x0037DB40
		public IPerformanceSetting? PerformanceSetting
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return null;
				}
				return new IPerformanceSetting?(default(IPerformanceSetting).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007587 RID: 30087
		// (get) Token: 0x060184C4 RID: 99524 RVA: 0x0037F9A0 File Offset: 0x0037DBA0
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060184C5 RID: 99525 RVA: 0x0037F9E0 File Offset: 0x0037DBE0
		public static Offset<ISelectBtNode> CreateISelectBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, Offset<IQuestScheduleConfig> UIConfigOffset = default(Offset<IQuestScheduleConfig>), Offset<IInformationViewConfig> InformationViewOffset = default(Offset<IInformationViewConfig>), Offset<IInformationBoardConfig> InformationBoardOffset = default(Offset<IInformationBoardConfig>), StringOffset TidQuestAliasNameOffset = default(StringOffset), StringOffset TidQuestAliasDescOffset = default(StringOffset), int DungeonId = 0, bool DisableOnline = false, Offset<ISaveConfig> SaveConfigOffset = default(Offset<ISaveConfig>), Offset<IForceClosedRestriction> ForceClosedRestrictionOffset = default(Offset<IForceClosedRestriction>), VectorOffset OccupationsOffset = default(VectorOffset), Offset<ILogicNodeOccupation> OccupationConfigOffset = default(Offset<ILogicNodeOccupation>), bool DisableSwitchOccupation = false, EBudgetCameraType BudgetCameraType = EBudgetCameraType.Role, Offset<IQuestStatistics> StatisticsOffset = default(Offset<IQuestStatistics>), ETrackViewMode CompositeTrackViewMode = ETrackViewMode.All, Offset<IQuestRewardConfig> RewardConfigOffset = default(Offset<IQuestRewardConfig>), TSpecialGamePlayConfig SpecialGamePlayConfig_type = TSpecialGamePlayConfig.NONE, int SpecialGamePlayConfigOffset = 0, TEnableSystemConfig EnableSystem_type = TEnableSystemConfig.NONE, int EnableSystemOffset = 0, Offset<IWaveConfig> StartWaveOffset = default(Offset<IWaveConfig>), Offset<IDisableTrackAnim> DisableTrackAnimOffset = default(Offset<IDisableTrackAnim>), bool DisableSwitchGender = false, bool DisableFocusMode = false, bool DisableSkeletalAnimationCheck = false, Offset<ILogicProgramSpecialProcess> LogicProgramSpecialProcessOffset = default(Offset<ILogicProgramSpecialProcess>), Offset<IQuestBuffActiveRange> QuestBuffActiveRangeOffset = default(Offset<IQuestBuffActiveRange>), Offset<ISunSpiritProcess> SunSpiritProcessOffset = default(Offset<ISunSpiritProcess>), Offset<ITrackAreaText> ModifyTrackAreaTextOffset = default(Offset<ITrackAreaText>), bool DisableGlobalTraffic = false, VectorOffset DisableSystemPromptOffset = default(VectorOffset), Offset<ITrackCustomBoardOnBtLogicNode> TrackCustomBoardOffset = default(Offset<ITrackCustomBoardOnBtLogicNode>), VectorOffset Children_typeOffset = default(VectorOffset), VectorOffset ChildrenOffset = default(VectorOffset), Offset<IPerformanceSetting> PerformanceSettingOffset = default(Offset<IPerformanceSetting>), ushort NullMask = 0)
		{
			builder.StartTable(42);
			ISelectBtNode.AddPerformanceSetting(builder, PerformanceSettingOffset);
			ISelectBtNode.AddChildren(builder, ChildrenOffset);
			ISelectBtNode.AddChildrenType(builder, Children_typeOffset);
			ISelectBtNode.AddTrackCustomBoard(builder, TrackCustomBoardOffset);
			ISelectBtNode.AddDisableSystemPrompt(builder, DisableSystemPromptOffset);
			ISelectBtNode.AddModifyTrackAreaText(builder, ModifyTrackAreaTextOffset);
			ISelectBtNode.AddSunSpiritProcess(builder, SunSpiritProcessOffset);
			ISelectBtNode.AddQuestBuffActiveRange(builder, QuestBuffActiveRangeOffset);
			ISelectBtNode.AddLogicProgramSpecialProcess(builder, LogicProgramSpecialProcessOffset);
			ISelectBtNode.AddDisableTrackAnim(builder, DisableTrackAnimOffset);
			ISelectBtNode.AddStartWave(builder, StartWaveOffset);
			ISelectBtNode.AddEnableSystem(builder, EnableSystemOffset);
			ISelectBtNode.AddSpecialGamePlayConfig(builder, SpecialGamePlayConfigOffset);
			ISelectBtNode.AddRewardConfig(builder, RewardConfigOffset);
			ISelectBtNode.AddStatistics(builder, StatisticsOffset);
			ISelectBtNode.AddOccupationConfig(builder, OccupationConfigOffset);
			ISelectBtNode.AddOccupations(builder, OccupationsOffset);
			ISelectBtNode.AddForceClosedRestriction(builder, ForceClosedRestrictionOffset);
			ISelectBtNode.AddSaveConfig(builder, SaveConfigOffset);
			ISelectBtNode.AddDungeonId(builder, DungeonId);
			ISelectBtNode.AddTidQuestAliasDesc(builder, TidQuestAliasDescOffset);
			ISelectBtNode.AddTidQuestAliasName(builder, TidQuestAliasNameOffset);
			ISelectBtNode.AddInformationBoard(builder, InformationBoardOffset);
			ISelectBtNode.AddInformationView(builder, InformationViewOffset);
			ISelectBtNode.AddUIConfig(builder, UIConfigOffset);
			ISelectBtNode.AddFixProcessor(builder, FixProcessorOffset);
			ISelectBtNode.AddDesc(builder, DescOffset);
			ISelectBtNode.AddId(builder, Id);
			ISelectBtNode.AddNullMask(builder, NullMask);
			ISelectBtNode.AddDisableGlobalTraffic(builder, DisableGlobalTraffic);
			ISelectBtNode.AddDisableSkeletalAnimationCheck(builder, DisableSkeletalAnimationCheck);
			ISelectBtNode.AddDisableFocusMode(builder, DisableFocusMode);
			ISelectBtNode.AddDisableSwitchGender(builder, DisableSwitchGender);
			ISelectBtNode.AddEnableSystemType(builder, EnableSystem_type);
			ISelectBtNode.AddSpecialGamePlayConfigType(builder, SpecialGamePlayConfig_type);
			ISelectBtNode.AddCompositeTrackViewMode(builder, CompositeTrackViewMode);
			ISelectBtNode.AddBudgetCameraType(builder, BudgetCameraType);
			ISelectBtNode.AddDisableSwitchOccupation(builder, DisableSwitchOccupation);
			ISelectBtNode.AddDisableOnline(builder, DisableOnline);
			ISelectBtNode.AddDisabled(builder, Disabled);
			ISelectBtNode.Add_FoldedForTree(builder, _foldedForTree);
			ISelectBtNode.AddType(builder, Type);
			return ISelectBtNode.EndISelectBtNode(builder);
		}

		// Token: 0x060184C6 RID: 99526 RVA: 0x0037FB48 File Offset: 0x0037DD48
		public static void StartISelectBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(42);
		}

		// Token: 0x060184C7 RID: 99527 RVA: 0x0037FB52 File Offset: 0x0037DD52
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060184C8 RID: 99528 RVA: 0x0037FB5D File Offset: 0x0037DD5D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060184C9 RID: 99529 RVA: 0x0037FB68 File Offset: 0x0037DD68
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x060184CA RID: 99530 RVA: 0x0037FB78 File Offset: 0x0037DD78
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x060184CB RID: 99531 RVA: 0x0037FB88 File Offset: 0x0037DD88
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x060184CC RID: 99532 RVA: 0x0037FB93 File Offset: 0x0037DD93
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x060184CD RID: 99533 RVA: 0x0037FB9E File Offset: 0x0037DD9E
		public static void AddUIConfig(FlatBufferBuilder builder, Offset<IQuestScheduleConfig> uIConfigOffset)
		{
			builder.AddOffset(6, uIConfigOffset.Value, 0);
		}

		// Token: 0x060184CE RID: 99534 RVA: 0x0037FBAE File Offset: 0x0037DDAE
		public static void AddInformationView(FlatBufferBuilder builder, Offset<IInformationViewConfig> informationViewOffset)
		{
			builder.AddOffset(7, informationViewOffset.Value, 0);
		}

		// Token: 0x060184CF RID: 99535 RVA: 0x0037FBBE File Offset: 0x0037DDBE
		public static void AddInformationBoard(FlatBufferBuilder builder, Offset<IInformationBoardConfig> informationBoardOffset)
		{
			builder.AddOffset(8, informationBoardOffset.Value, 0);
		}

		// Token: 0x060184D0 RID: 99536 RVA: 0x0037FBCE File Offset: 0x0037DDCE
		public static void AddTidQuestAliasName(FlatBufferBuilder builder, StringOffset tidQuestAliasNameOffset)
		{
			builder.AddOffset(9, tidQuestAliasNameOffset.Value, 0);
		}

		// Token: 0x060184D1 RID: 99537 RVA: 0x0037FBDF File Offset: 0x0037DDDF
		public static void AddTidQuestAliasDesc(FlatBufferBuilder builder, StringOffset tidQuestAliasDescOffset)
		{
			builder.AddOffset(10, tidQuestAliasDescOffset.Value, 0);
		}

		// Token: 0x060184D2 RID: 99538 RVA: 0x0037FBF0 File Offset: 0x0037DDF0
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(11, dungeonId, 0);
		}

		// Token: 0x060184D3 RID: 99539 RVA: 0x0037FBFC File Offset: 0x0037DDFC
		public static void AddDisableOnline(FlatBufferBuilder builder, bool disableOnline)
		{
			builder.AddBool(12, disableOnline, false);
		}

		// Token: 0x060184D4 RID: 99540 RVA: 0x0037FC08 File Offset: 0x0037DE08
		public static void AddSaveConfig(FlatBufferBuilder builder, Offset<ISaveConfig> saveConfigOffset)
		{
			builder.AddOffset(13, saveConfigOffset.Value, 0);
		}

		// Token: 0x060184D5 RID: 99541 RVA: 0x0037FC19 File Offset: 0x0037DE19
		public static void AddForceClosedRestriction(FlatBufferBuilder builder, Offset<IForceClosedRestriction> forceClosedRestrictionOffset)
		{
			builder.AddOffset(14, forceClosedRestrictionOffset.Value, 0);
		}

		// Token: 0x060184D6 RID: 99542 RVA: 0x0037FC2A File Offset: 0x0037DE2A
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(15, occupationsOffset.Value, 0);
		}

		// Token: 0x060184D7 RID: 99543 RVA: 0x0037FC3C File Offset: 0x0037DE3C
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060184D8 RID: 99544 RVA: 0x0037FC7C File Offset: 0x0037DE7C
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060184D9 RID: 99545 RVA: 0x0037FC96 File Offset: 0x0037DE96
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060184DA RID: 99546 RVA: 0x0037FCB4 File Offset: 0x0037DEB4
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060184DB RID: 99547 RVA: 0x0037FCCD File Offset: 0x0037DECD
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060184DC RID: 99548 RVA: 0x0037FCD8 File Offset: 0x0037DED8
		public static void AddOccupationConfig(FlatBufferBuilder builder, Offset<ILogicNodeOccupation> occupationConfigOffset)
		{
			builder.AddOffset(16, occupationConfigOffset.Value, 0);
		}

		// Token: 0x060184DD RID: 99549 RVA: 0x0037FCE9 File Offset: 0x0037DEE9
		public static void AddDisableSwitchOccupation(FlatBufferBuilder builder, bool disableSwitchOccupation)
		{
			builder.AddBool(17, disableSwitchOccupation, false);
		}

		// Token: 0x060184DE RID: 99550 RVA: 0x0037FCF5 File Offset: 0x0037DEF5
		public static void AddBudgetCameraType(FlatBufferBuilder builder, EBudgetCameraType budgetCameraType)
		{
			builder.AddByte(18, (byte)budgetCameraType, 0);
		}

		// Token: 0x060184DF RID: 99551 RVA: 0x0037FD01 File Offset: 0x0037DF01
		public static void AddStatistics(FlatBufferBuilder builder, Offset<IQuestStatistics> statisticsOffset)
		{
			builder.AddOffset(19, statisticsOffset.Value, 0);
		}

		// Token: 0x060184E0 RID: 99552 RVA: 0x0037FD12 File Offset: 0x0037DF12
		public static void AddCompositeTrackViewMode(FlatBufferBuilder builder, ETrackViewMode compositeTrackViewMode)
		{
			builder.AddByte(20, (byte)compositeTrackViewMode, 0);
		}

		// Token: 0x060184E1 RID: 99553 RVA: 0x0037FD1E File Offset: 0x0037DF1E
		public static void AddRewardConfig(FlatBufferBuilder builder, Offset<IQuestRewardConfig> rewardConfigOffset)
		{
			builder.AddOffset(21, rewardConfigOffset.Value, 0);
		}

		// Token: 0x060184E2 RID: 99554 RVA: 0x0037FD2F File Offset: 0x0037DF2F
		public static void AddSpecialGamePlayConfigType(FlatBufferBuilder builder, TSpecialGamePlayConfig specialGamePlayConfigType)
		{
			builder.AddByte(22, (byte)specialGamePlayConfigType, 0);
		}

		// Token: 0x060184E3 RID: 99555 RVA: 0x0037FD3B File Offset: 0x0037DF3B
		public static void AddSpecialGamePlayConfig(FlatBufferBuilder builder, int specialGamePlayConfigOffset)
		{
			builder.AddOffset(23, specialGamePlayConfigOffset, 0);
		}

		// Token: 0x060184E4 RID: 99556 RVA: 0x0037FD47 File Offset: 0x0037DF47
		public static void AddEnableSystemType(FlatBufferBuilder builder, TEnableSystemConfig enableSystemType)
		{
			builder.AddByte(24, (byte)enableSystemType, 0);
		}

		// Token: 0x060184E5 RID: 99557 RVA: 0x0037FD53 File Offset: 0x0037DF53
		public static void AddEnableSystem(FlatBufferBuilder builder, int enableSystemOffset)
		{
			builder.AddOffset(25, enableSystemOffset, 0);
		}

		// Token: 0x060184E6 RID: 99558 RVA: 0x0037FD5F File Offset: 0x0037DF5F
		public static void AddStartWave(FlatBufferBuilder builder, Offset<IWaveConfig> startWaveOffset)
		{
			builder.AddOffset(26, startWaveOffset.Value, 0);
		}

		// Token: 0x060184E7 RID: 99559 RVA: 0x0037FD70 File Offset: 0x0037DF70
		public static void AddDisableTrackAnim(FlatBufferBuilder builder, Offset<IDisableTrackAnim> disableTrackAnimOffset)
		{
			builder.AddOffset(27, disableTrackAnimOffset.Value, 0);
		}

		// Token: 0x060184E8 RID: 99560 RVA: 0x0037FD81 File Offset: 0x0037DF81
		public static void AddDisableSwitchGender(FlatBufferBuilder builder, bool disableSwitchGender)
		{
			builder.AddBool(28, disableSwitchGender, false);
		}

		// Token: 0x060184E9 RID: 99561 RVA: 0x0037FD8D File Offset: 0x0037DF8D
		public static void AddDisableFocusMode(FlatBufferBuilder builder, bool disableFocusMode)
		{
			builder.AddBool(29, disableFocusMode, false);
		}

		// Token: 0x060184EA RID: 99562 RVA: 0x0037FD99 File Offset: 0x0037DF99
		public static void AddDisableSkeletalAnimationCheck(FlatBufferBuilder builder, bool disableSkeletalAnimationCheck)
		{
			builder.AddBool(30, disableSkeletalAnimationCheck, false);
		}

		// Token: 0x060184EB RID: 99563 RVA: 0x0037FDA5 File Offset: 0x0037DFA5
		public static void AddLogicProgramSpecialProcess(FlatBufferBuilder builder, Offset<ILogicProgramSpecialProcess> logicProgramSpecialProcessOffset)
		{
			builder.AddOffset(31, logicProgramSpecialProcessOffset.Value, 0);
		}

		// Token: 0x060184EC RID: 99564 RVA: 0x0037FDB6 File Offset: 0x0037DFB6
		public static void AddQuestBuffActiveRange(FlatBufferBuilder builder, Offset<IQuestBuffActiveRange> questBuffActiveRangeOffset)
		{
			builder.AddOffset(32, questBuffActiveRangeOffset.Value, 0);
		}

		// Token: 0x060184ED RID: 99565 RVA: 0x0037FDC7 File Offset: 0x0037DFC7
		public static void AddSunSpiritProcess(FlatBufferBuilder builder, Offset<ISunSpiritProcess> sunSpiritProcessOffset)
		{
			builder.AddOffset(33, sunSpiritProcessOffset.Value, 0);
		}

		// Token: 0x060184EE RID: 99566 RVA: 0x0037FDD8 File Offset: 0x0037DFD8
		public static void AddModifyTrackAreaText(FlatBufferBuilder builder, Offset<ITrackAreaText> modifyTrackAreaTextOffset)
		{
			builder.AddOffset(34, modifyTrackAreaTextOffset.Value, 0);
		}

		// Token: 0x060184EF RID: 99567 RVA: 0x0037FDE9 File Offset: 0x0037DFE9
		public static void AddDisableGlobalTraffic(FlatBufferBuilder builder, bool disableGlobalTraffic)
		{
			builder.AddBool(35, disableGlobalTraffic, false);
		}

		// Token: 0x060184F0 RID: 99568 RVA: 0x0037FDF5 File Offset: 0x0037DFF5
		public static void AddDisableSystemPrompt(FlatBufferBuilder builder, VectorOffset disableSystemPromptOffset)
		{
			builder.AddOffset(36, disableSystemPromptOffset.Value, 0);
		}

		// Token: 0x060184F1 RID: 99569 RVA: 0x0037FE08 File Offset: 0x0037E008
		public static VectorOffset CreateDisableSystemPromptVector(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060184F2 RID: 99570 RVA: 0x0037FE48 File Offset: 0x0037E048
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x060184F3 RID: 99571 RVA: 0x0037FE62 File Offset: 0x0037E062
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAreaNameSystemPrompt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x060184F4 RID: 99572 RVA: 0x0037FE80 File Offset: 0x0037E080
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAreaNameSystemPrompt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060184F5 RID: 99573 RVA: 0x0037FE99 File Offset: 0x0037E099
		public static void StartDisableSystemPromptVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060184F6 RID: 99574 RVA: 0x0037FEA4 File Offset: 0x0037E0A4
		public static void AddTrackCustomBoard(FlatBufferBuilder builder, Offset<ITrackCustomBoardOnBtLogicNode> trackCustomBoardOffset)
		{
			builder.AddOffset(37, trackCustomBoardOffset.Value, 0);
		}

		// Token: 0x060184F7 RID: 99575 RVA: 0x0037FEB5 File Offset: 0x0037E0B5
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(38, childrenTypeOffset.Value, 0);
		}

		// Token: 0x060184F8 RID: 99576 RVA: 0x0037FEC8 File Offset: 0x0037E0C8
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060184F9 RID: 99577 RVA: 0x0037FEFF File Offset: 0x0037E0FF
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x060184FA RID: 99578 RVA: 0x0037FF19 File Offset: 0x0037E119
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TBtNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x060184FB RID: 99579 RVA: 0x0037FF37 File Offset: 0x0037E137
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TBtNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060184FC RID: 99580 RVA: 0x0037FF50 File Offset: 0x0037E150
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060184FD RID: 99581 RVA: 0x0037FF5B File Offset: 0x0037E15B
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(39, childrenOffset.Value, 0);
		}

		// Token: 0x060184FE RID: 99582 RVA: 0x0037FF6C File Offset: 0x0037E16C
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060184FF RID: 99583 RVA: 0x0037FFA3 File Offset: 0x0037E1A3
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018500 RID: 99584 RVA: 0x0037FFBD File Offset: 0x0037E1BD
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018501 RID: 99585 RVA: 0x0037FFDB File Offset: 0x0037E1DB
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018502 RID: 99586 RVA: 0x0037FFF4 File Offset: 0x0037E1F4
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018503 RID: 99587 RVA: 0x0037FFFF File Offset: 0x0037E1FF
		public static void AddPerformanceSetting(FlatBufferBuilder builder, Offset<IPerformanceSetting> performanceSettingOffset)
		{
			builder.AddOffset(40, performanceSettingOffset.Value, 0);
		}

		// Token: 0x06018504 RID: 99588 RVA: 0x00380010 File Offset: 0x0037E210
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(41, nullMask, 0);
		}

		// Token: 0x06018505 RID: 99589 RVA: 0x0038001C File Offset: 0x0037E21C
		public static Offset<ISelectBtNode> EndISelectBtNode(FlatBufferBuilder builder)
		{
			return new Offset<ISelectBtNode>(builder.EndTable());
		}

		// Token: 0x06018506 RID: 99590 RVA: 0x0038002C File Offset: 0x0037E22C
		public ISelectBtNodeT UnPack()
		{
			ISelectBtNodeT selectBtNodeT = new ISelectBtNodeT();
			this.UnPackTo(selectBtNodeT);
			return selectBtNodeT;
		}

		// Token: 0x06018507 RID: 99591 RVA: 0x00380048 File Offset: 0x0037E248
		public void UnPackTo(ISelectBtNodeT _o)
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
			_o.PerformanceSetting = ((this.PerformanceSetting != null) ? this.PerformanceSetting.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018508 RID: 99592 RVA: 0x00380DA0 File Offset: 0x0037EFA0
		public static Offset<ISelectBtNode> Pack(FlatBufferBuilder builder, ISelectBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISelectBtNode>);
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
				occupationsOffset = ISelectBtNode.CreateOccupationsVector(builder, array);
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
				disableSystemPromptOffset = ISelectBtNode.CreateDisableSystemPromptVector(builder, array2);
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
				children_typeOffset = ISelectBtNode.CreateChildrenTypeVector(builder, array3);
			}
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				int[] array4 = new int[_o.Children.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = TBtNodeUnion.Pack(builder, _o.Children[l]);
				}
				childrenOffset = ISelectBtNode.CreateChildrenVector(builder, array4);
			}
			Offset<IPerformanceSetting> performanceSettingOffset = (_o.PerformanceSetting == null) ? default(Offset<IPerformanceSetting>) : IPerformanceSetting.Pack(builder, _o.PerformanceSetting);
			return ISelectBtNode.CreateISelectBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, uiconfigOffset, informationViewOffset, informationBoardOffset, tidQuestAliasNameOffset, tidQuestAliasDescOffset, _o.DungeonId, _o.DisableOnline, saveConfigOffset, forceClosedRestrictionOffset, occupationsOffset, occupationConfigOffset, _o.DisableSwitchOccupation, _o.BudgetCameraType, statisticsOffset, _o.CompositeTrackViewMode, rewardConfigOffset, specialGamePlayConfig_type, specialGamePlayConfigOffset, enableSystem_type, enableSystemOffset, startWaveOffset, disableTrackAnimOffset, _o.DisableSwitchGender, _o.DisableFocusMode, _o.DisableSkeletalAnimationCheck, logicProgramSpecialProcessOffset, questBuffActiveRangeOffset, sunSpiritProcessOffset, modifyTrackAreaTextOffset, _o.DisableGlobalTraffic, disableSystemPromptOffset, trackCustomBoardOffset, children_typeOffset, childrenOffset, performanceSettingOffset, _o.NullMask);
		}

		// Token: 0x0400BCB0 RID: 48304
		private Table __p;
	}
}
