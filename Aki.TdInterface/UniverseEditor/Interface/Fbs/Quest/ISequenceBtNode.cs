using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200454D RID: 17741
	public struct ISequenceBtNode : IFlatbufferObject
	{
		// Token: 0x17007BB5 RID: 31669
		// (get) Token: 0x06019BFB RID: 105467 RVA: 0x003ABAF5 File Offset: 0x003A9CF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019BFC RID: 105468 RVA: 0x003ABB02 File Offset: 0x003A9D02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019BFD RID: 105469 RVA: 0x003ABB0C File Offset: 0x003A9D0C
		public static ISequenceBtNode GetRootAsISequenceBtNode(ByteBuffer _bb)
		{
			return ISequenceBtNode.GetRootAsISequenceBtNode(_bb, default(ISequenceBtNode));
		}

		// Token: 0x06019BFE RID: 105470 RVA: 0x003ABB28 File Offset: 0x003A9D28
		public static ISequenceBtNode GetRootAsISequenceBtNode(ByteBuffer _bb, ISequenceBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019BFF RID: 105471 RVA: 0x003ABB45 File Offset: 0x003A9D45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019C00 RID: 105472 RVA: 0x003ABB54 File Offset: 0x003A9D54
		public ISequenceBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007BB6 RID: 31670
		// (get) Token: 0x06019C01 RID: 105473 RVA: 0x003ABB64 File Offset: 0x003A9D64
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

		// Token: 0x17007BB7 RID: 31671
		// (get) Token: 0x06019C02 RID: 105474 RVA: 0x003ABBA0 File Offset: 0x003A9DA0
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

		// Token: 0x17007BB8 RID: 31672
		// (get) Token: 0x06019C03 RID: 105475 RVA: 0x003ABBDC File Offset: 0x003A9DDC
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

		// Token: 0x06019C04 RID: 105476 RVA: 0x003ABC13 File Offset: 0x003A9E13
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06019C05 RID: 105477 RVA: 0x003ABC22 File Offset: 0x003A9E22
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007BB9 RID: 31673
		// (get) Token: 0x06019C06 RID: 105478 RVA: 0x003ABC30 File Offset: 0x003A9E30
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

		// Token: 0x17007BBA RID: 31674
		// (get) Token: 0x06019C07 RID: 105479 RVA: 0x003ABC90 File Offset: 0x003A9E90
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007BBB RID: 31675
		// (get) Token: 0x06019C08 RID: 105480 RVA: 0x003ABCD0 File Offset: 0x003A9ED0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007BBC RID: 31676
		// (get) Token: 0x06019C09 RID: 105481 RVA: 0x003ABD10 File Offset: 0x003A9F10
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

		// Token: 0x17007BBD RID: 31677
		// (get) Token: 0x06019C0A RID: 105482 RVA: 0x003ABD70 File Offset: 0x003A9F70
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

		// Token: 0x17007BBE RID: 31678
		// (get) Token: 0x06019C0B RID: 105483 RVA: 0x003ABDD0 File Offset: 0x003A9FD0
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

		// Token: 0x17007BBF RID: 31679
		// (get) Token: 0x06019C0C RID: 105484 RVA: 0x003ABE30 File Offset: 0x003AA030
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

		// Token: 0x06019C0D RID: 105485 RVA: 0x003ABE68 File Offset: 0x003AA068
		public Span<byte> GetTidQuestAliasNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06019C0E RID: 105486 RVA: 0x003ABE78 File Offset: 0x003AA078
		public byte[] GetTidQuestAliasNameArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x17007BC0 RID: 31680
		// (get) Token: 0x06019C0F RID: 105487 RVA: 0x003ABE88 File Offset: 0x003AA088
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

		// Token: 0x06019C10 RID: 105488 RVA: 0x003ABEC0 File Offset: 0x003AA0C0
		public Span<byte> GetTidQuestAliasDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06019C11 RID: 105489 RVA: 0x003ABED0 File Offset: 0x003AA0D0
		public byte[] GetTidQuestAliasDescArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x17007BC1 RID: 31681
		// (get) Token: 0x06019C12 RID: 105490 RVA: 0x003ABEE0 File Offset: 0x003AA0E0
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

		// Token: 0x17007BC2 RID: 31682
		// (get) Token: 0x06019C13 RID: 105491 RVA: 0x003ABF20 File Offset: 0x003AA120
		public bool DisableOnline
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007BC3 RID: 31683
		// (get) Token: 0x06019C14 RID: 105492 RVA: 0x003ABF60 File Offset: 0x003AA160
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

		// Token: 0x17007BC4 RID: 31684
		// (get) Token: 0x06019C15 RID: 105493 RVA: 0x003ABFC0 File Offset: 0x003AA1C0
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

		// Token: 0x06019C16 RID: 105494 RVA: 0x003AC020 File Offset: 0x003AA220
		public string Occupations(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007BC5 RID: 31685
		// (get) Token: 0x06019C17 RID: 105495 RVA: 0x003AC05C File Offset: 0x003AA25C
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

		// Token: 0x17007BC6 RID: 31686
		// (get) Token: 0x06019C18 RID: 105496 RVA: 0x003AC088 File Offset: 0x003AA288
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

		// Token: 0x17007BC7 RID: 31687
		// (get) Token: 0x06019C19 RID: 105497 RVA: 0x003AC0E8 File Offset: 0x003AA2E8
		public bool DisableSwitchOccupation
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007BC8 RID: 31688
		// (get) Token: 0x06019C1A RID: 105498 RVA: 0x003AC128 File Offset: 0x003AA328
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

		// Token: 0x17007BC9 RID: 31689
		// (get) Token: 0x06019C1B RID: 105499 RVA: 0x003AC168 File Offset: 0x003AA368
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

		// Token: 0x17007BCA RID: 31690
		// (get) Token: 0x06019C1C RID: 105500 RVA: 0x003AC1C8 File Offset: 0x003AA3C8
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

		// Token: 0x17007BCB RID: 31691
		// (get) Token: 0x06019C1D RID: 105501 RVA: 0x003AC208 File Offset: 0x003AA408
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

		// Token: 0x17007BCC RID: 31692
		// (get) Token: 0x06019C1E RID: 105502 RVA: 0x003AC268 File Offset: 0x003AA468
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

		// Token: 0x06019C1F RID: 105503 RVA: 0x003AC2A8 File Offset: 0x003AA4A8
		public TTable? SpecialGamePlayConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019C20 RID: 105504 RVA: 0x003AC2F0 File Offset: 0x003AA4F0
		public IEavesdropGamePlayConfig SpecialGamePlayConfigAsIEavesdropGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IEavesdropGamePlayConfig>().Value;
		}

		// Token: 0x06019C21 RID: 105505 RVA: 0x003AC30C File Offset: 0x003AA50C
		public IFirstPersonTurretGamePlayConfig SpecialGamePlayConfigAsIFirstPersonTurretGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFirstPersonTurretGamePlayConfig>().Value;
		}

		// Token: 0x06019C22 RID: 105506 RVA: 0x003AC328 File Offset: 0x003AA528
		public IFreezeOnSightGamePlayConfig SpecialGamePlayConfigAsIFreezeOnSightGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFreezeOnSightGamePlayConfig>().Value;
		}

		// Token: 0x06019C23 RID: 105507 RVA: 0x003AC344 File Offset: 0x003AA544
		public IStalkingGamePlayConfig SpecialGamePlayConfigAsIStalkingGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IStalkingGamePlayConfig>().Value;
		}

		// Token: 0x17007BCD RID: 31693
		// (get) Token: 0x06019C24 RID: 105508 RVA: 0x003AC360 File Offset: 0x003AA560
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

		// Token: 0x06019C25 RID: 105509 RVA: 0x003AC3A0 File Offset: 0x003AA5A0
		public TTable? EnableSystem<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019C26 RID: 105510 RVA: 0x003AC3E8 File Offset: 0x003AA5E8
		public IDarkTideSystemConfig EnableSystemAsIDarkTideSystemConfig()
		{
			return this.EnableSystem<IDarkTideSystemConfig>().Value;
		}

		// Token: 0x06019C27 RID: 105511 RVA: 0x003AC404 File Offset: 0x003AA604
		public IFlagChallengeSystemConfig EnableSystemAsIFlagChallengeSystemConfig()
		{
			return this.EnableSystem<IFlagChallengeSystemConfig>().Value;
		}

		// Token: 0x06019C28 RID: 105512 RVA: 0x003AC420 File Offset: 0x003AA620
		public IFlipperSystemConfig EnableSystemAsIFlipperSystemConfig()
		{
			return this.EnableSystem<IFlipperSystemConfig>().Value;
		}

		// Token: 0x06019C29 RID: 105513 RVA: 0x003AC43C File Offset: 0x003AA63C
		public IGameDifficultySystemConfig EnableSystemAsIGameDifficultySystemConfig()
		{
			return this.EnableSystem<IGameDifficultySystemConfig>().Value;
		}

		// Token: 0x06019C2A RID: 105514 RVA: 0x003AC458 File Offset: 0x003AA658
		public IGradingSystemConfig EnableSystemAsIGradingSystemConfig()
		{
			return this.EnableSystem<IGradingSystemConfig>().Value;
		}

		// Token: 0x06019C2B RID: 105515 RVA: 0x003AC474 File Offset: 0x003AA674
		public IKuroSimpleCombatKillMonsterSystemConfig EnableSystemAsIKuroSimpleCombatKillMonsterSystemConfig()
		{
			return this.EnableSystem<IKuroSimpleCombatKillMonsterSystemConfig>().Value;
		}

		// Token: 0x06019C2C RID: 105516 RVA: 0x003AC490 File Offset: 0x003AA690
		public IKurotatoSystemConfig EnableSystemAsIKurotatoSystemConfig()
		{
			return this.EnableSystem<IKurotatoSystemConfig>().Value;
		}

		// Token: 0x06019C2D RID: 105517 RVA: 0x003AC4AC File Offset: 0x003AA6AC
		public ILinkSystemConfig EnableSystemAsILinkSystemConfig()
		{
			return this.EnableSystem<ILinkSystemConfig>().Value;
		}

		// Token: 0x06019C2E RID: 105518 RVA: 0x003AC4C8 File Offset: 0x003AA6C8
		public IMotorFightSystemConfig EnableSystemAsIMotorFightSystemConfig()
		{
			return this.EnableSystem<IMotorFightSystemConfig>().Value;
		}

		// Token: 0x06019C2F RID: 105519 RVA: 0x003AC4E4 File Offset: 0x003AA6E4
		public IMotorRacingSystemConfig EnableSystemAsIMotorRacingSystemConfig()
		{
			return this.EnableSystem<IMotorRacingSystemConfig>().Value;
		}

		// Token: 0x06019C30 RID: 105520 RVA: 0x003AC500 File Offset: 0x003AA700
		public INightmareSettlementSystemConfig EnableSystemAsINightmareSettlementSystemConfig()
		{
			return this.EnableSystem<INightmareSettlementSystemConfig>().Value;
		}

		// Token: 0x06019C31 RID: 105521 RVA: 0x003AC51C File Offset: 0x003AA71C
		public IRogueTowerTrialSystemConfig EnableSystemAsIRogueTowerTrialSystemConfig()
		{
			return this.EnableSystem<IRogueTowerTrialSystemConfig>().Value;
		}

		// Token: 0x06019C32 RID: 105522 RVA: 0x003AC538 File Offset: 0x003AA738
		public IRoleTowerSystemConfig EnableSystemAsIRoleTowerSystemConfig()
		{
			return this.EnableSystem<IRoleTowerSystemConfig>().Value;
		}

		// Token: 0x06019C33 RID: 105523 RVA: 0x003AC554 File Offset: 0x003AA754
		public ISurvivorsRougeSystemConfig EnableSystemAsISurvivorsRougeSystemConfig()
		{
			return this.EnableSystem<ISurvivorsRougeSystemConfig>().Value;
		}

		// Token: 0x06019C34 RID: 105524 RVA: 0x003AC570 File Offset: 0x003AA770
		public ITrapDefenseSystemConfig EnableSystemAsITrapDefenseSystemConfig()
		{
			return this.EnableSystem<ITrapDefenseSystemConfig>().Value;
		}

		// Token: 0x17007BCE RID: 31694
		// (get) Token: 0x06019C35 RID: 105525 RVA: 0x003AC58C File Offset: 0x003AA78C
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

		// Token: 0x17007BCF RID: 31695
		// (get) Token: 0x06019C36 RID: 105526 RVA: 0x003AC5EC File Offset: 0x003AA7EC
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

		// Token: 0x17007BD0 RID: 31696
		// (get) Token: 0x06019C37 RID: 105527 RVA: 0x003AC64C File Offset: 0x003AA84C
		public bool DisableSwitchGender
		{
			get
			{
				int num = this.__p.__offset(60);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007BD1 RID: 31697
		// (get) Token: 0x06019C38 RID: 105528 RVA: 0x003AC68C File Offset: 0x003AA88C
		public bool DisableFocusMode
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007BD2 RID: 31698
		// (get) Token: 0x06019C39 RID: 105529 RVA: 0x003AC6CC File Offset: 0x003AA8CC
		public bool DisableSkeletalAnimationCheck
		{
			get
			{
				int num = this.__p.__offset(64);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007BD3 RID: 31699
		// (get) Token: 0x06019C3A RID: 105530 RVA: 0x003AC70C File Offset: 0x003AA90C
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

		// Token: 0x17007BD4 RID: 31700
		// (get) Token: 0x06019C3B RID: 105531 RVA: 0x003AC76C File Offset: 0x003AA96C
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

		// Token: 0x17007BD5 RID: 31701
		// (get) Token: 0x06019C3C RID: 105532 RVA: 0x003AC7CC File Offset: 0x003AA9CC
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

		// Token: 0x17007BD6 RID: 31702
		// (get) Token: 0x06019C3D RID: 105533 RVA: 0x003AC82C File Offset: 0x003AAA2C
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

		// Token: 0x17007BD7 RID: 31703
		// (get) Token: 0x06019C3E RID: 105534 RVA: 0x003AC88C File Offset: 0x003AAA8C
		public bool DisableGlobalTraffic
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06019C3F RID: 105535 RVA: 0x003AC8CC File Offset: 0x003AAACC
		public IAreaNameSystemPrompt? DisableSystemPrompt(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IAreaNameSystemPrompt?(default(IAreaNameSystemPrompt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007BD8 RID: 31704
		// (get) Token: 0x06019C40 RID: 105536 RVA: 0x003AC930 File Offset: 0x003AAB30
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

		// Token: 0x17007BD9 RID: 31705
		// (get) Token: 0x06019C41 RID: 105537 RVA: 0x003AC95C File Offset: 0x003AAB5C
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

		// Token: 0x06019C42 RID: 105538 RVA: 0x003AC9BC File Offset: 0x003AABBC
		public TBtNode ChildrenType(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return TBtNode.NONE;
			}
			return (TBtNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007BDA RID: 31706
		// (get) Token: 0x06019C43 RID: 105539 RVA: 0x003AC9FC File Offset: 0x003AABFC
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

		// Token: 0x06019C44 RID: 105540 RVA: 0x003ACA28 File Offset: 0x003AAC28
		public Span<TBtNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TBtNode>(80, 1);
		}

		// Token: 0x06019C45 RID: 105541 RVA: 0x003ACA38 File Offset: 0x003AAC38
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

		// Token: 0x06019C46 RID: 105542 RVA: 0x003ACAA4 File Offset: 0x003AACA4
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007BDB RID: 31707
		// (get) Token: 0x06019C47 RID: 105543 RVA: 0x003ACAEC File Offset: 0x003AACEC
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

		// Token: 0x17007BDC RID: 31708
		// (get) Token: 0x06019C48 RID: 105544 RVA: 0x003ACB18 File Offset: 0x003AAD18
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

		// Token: 0x17007BDD RID: 31709
		// (get) Token: 0x06019C49 RID: 105545 RVA: 0x003ACB78 File Offset: 0x003AAD78
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

		// Token: 0x06019C4A RID: 105546 RVA: 0x003ACBB8 File Offset: 0x003AADB8
		public static Offset<ISequenceBtNode> CreateISequenceBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, Offset<IQuestScheduleConfig> UIConfigOffset = default(Offset<IQuestScheduleConfig>), Offset<IInformationViewConfig> InformationViewOffset = default(Offset<IInformationViewConfig>), Offset<IInformationBoardConfig> InformationBoardOffset = default(Offset<IInformationBoardConfig>), StringOffset TidQuestAliasNameOffset = default(StringOffset), StringOffset TidQuestAliasDescOffset = default(StringOffset), int DungeonId = 0, bool DisableOnline = false, Offset<ISaveConfig> SaveConfigOffset = default(Offset<ISaveConfig>), Offset<IForceClosedRestriction> ForceClosedRestrictionOffset = default(Offset<IForceClosedRestriction>), VectorOffset OccupationsOffset = default(VectorOffset), Offset<ILogicNodeOccupation> OccupationConfigOffset = default(Offset<ILogicNodeOccupation>), bool DisableSwitchOccupation = false, EBudgetCameraType BudgetCameraType = EBudgetCameraType.Role, Offset<IQuestStatistics> StatisticsOffset = default(Offset<IQuestStatistics>), ETrackViewMode CompositeTrackViewMode = ETrackViewMode.All, Offset<IQuestRewardConfig> RewardConfigOffset = default(Offset<IQuestRewardConfig>), TSpecialGamePlayConfig SpecialGamePlayConfig_type = TSpecialGamePlayConfig.NONE, int SpecialGamePlayConfigOffset = 0, TEnableSystemConfig EnableSystem_type = TEnableSystemConfig.NONE, int EnableSystemOffset = 0, Offset<IWaveConfig> StartWaveOffset = default(Offset<IWaveConfig>), Offset<IDisableTrackAnim> DisableTrackAnimOffset = default(Offset<IDisableTrackAnim>), bool DisableSwitchGender = false, bool DisableFocusMode = false, bool DisableSkeletalAnimationCheck = false, Offset<ILogicProgramSpecialProcess> LogicProgramSpecialProcessOffset = default(Offset<ILogicProgramSpecialProcess>), Offset<IQuestBuffActiveRange> QuestBuffActiveRangeOffset = default(Offset<IQuestBuffActiveRange>), Offset<ISunSpiritProcess> SunSpiritProcessOffset = default(Offset<ISunSpiritProcess>), Offset<ITrackAreaText> ModifyTrackAreaTextOffset = default(Offset<ITrackAreaText>), bool DisableGlobalTraffic = false, VectorOffset DisableSystemPromptOffset = default(VectorOffset), Offset<ITrackCustomBoardOnBtLogicNode> TrackCustomBoardOffset = default(Offset<ITrackCustomBoardOnBtLogicNode>), VectorOffset Children_typeOffset = default(VectorOffset), VectorOffset ChildrenOffset = default(VectorOffset), Offset<IPerformanceSetting> PerformanceSettingOffset = default(Offset<IPerformanceSetting>), ushort NullMask = 0)
		{
			builder.StartTable(42);
			ISequenceBtNode.AddPerformanceSetting(builder, PerformanceSettingOffset);
			ISequenceBtNode.AddChildren(builder, ChildrenOffset);
			ISequenceBtNode.AddChildrenType(builder, Children_typeOffset);
			ISequenceBtNode.AddTrackCustomBoard(builder, TrackCustomBoardOffset);
			ISequenceBtNode.AddDisableSystemPrompt(builder, DisableSystemPromptOffset);
			ISequenceBtNode.AddModifyTrackAreaText(builder, ModifyTrackAreaTextOffset);
			ISequenceBtNode.AddSunSpiritProcess(builder, SunSpiritProcessOffset);
			ISequenceBtNode.AddQuestBuffActiveRange(builder, QuestBuffActiveRangeOffset);
			ISequenceBtNode.AddLogicProgramSpecialProcess(builder, LogicProgramSpecialProcessOffset);
			ISequenceBtNode.AddDisableTrackAnim(builder, DisableTrackAnimOffset);
			ISequenceBtNode.AddStartWave(builder, StartWaveOffset);
			ISequenceBtNode.AddEnableSystem(builder, EnableSystemOffset);
			ISequenceBtNode.AddSpecialGamePlayConfig(builder, SpecialGamePlayConfigOffset);
			ISequenceBtNode.AddRewardConfig(builder, RewardConfigOffset);
			ISequenceBtNode.AddStatistics(builder, StatisticsOffset);
			ISequenceBtNode.AddOccupationConfig(builder, OccupationConfigOffset);
			ISequenceBtNode.AddOccupations(builder, OccupationsOffset);
			ISequenceBtNode.AddForceClosedRestriction(builder, ForceClosedRestrictionOffset);
			ISequenceBtNode.AddSaveConfig(builder, SaveConfigOffset);
			ISequenceBtNode.AddDungeonId(builder, DungeonId);
			ISequenceBtNode.AddTidQuestAliasDesc(builder, TidQuestAliasDescOffset);
			ISequenceBtNode.AddTidQuestAliasName(builder, TidQuestAliasNameOffset);
			ISequenceBtNode.AddInformationBoard(builder, InformationBoardOffset);
			ISequenceBtNode.AddInformationView(builder, InformationViewOffset);
			ISequenceBtNode.AddUIConfig(builder, UIConfigOffset);
			ISequenceBtNode.AddFixProcessor(builder, FixProcessorOffset);
			ISequenceBtNode.AddDesc(builder, DescOffset);
			ISequenceBtNode.AddId(builder, Id);
			ISequenceBtNode.AddNullMask(builder, NullMask);
			ISequenceBtNode.AddDisableGlobalTraffic(builder, DisableGlobalTraffic);
			ISequenceBtNode.AddDisableSkeletalAnimationCheck(builder, DisableSkeletalAnimationCheck);
			ISequenceBtNode.AddDisableFocusMode(builder, DisableFocusMode);
			ISequenceBtNode.AddDisableSwitchGender(builder, DisableSwitchGender);
			ISequenceBtNode.AddEnableSystemType(builder, EnableSystem_type);
			ISequenceBtNode.AddSpecialGamePlayConfigType(builder, SpecialGamePlayConfig_type);
			ISequenceBtNode.AddCompositeTrackViewMode(builder, CompositeTrackViewMode);
			ISequenceBtNode.AddBudgetCameraType(builder, BudgetCameraType);
			ISequenceBtNode.AddDisableSwitchOccupation(builder, DisableSwitchOccupation);
			ISequenceBtNode.AddDisableOnline(builder, DisableOnline);
			ISequenceBtNode.AddDisabled(builder, Disabled);
			ISequenceBtNode.Add_FoldedForTree(builder, _foldedForTree);
			ISequenceBtNode.AddType(builder, Type);
			return ISequenceBtNode.EndISequenceBtNode(builder);
		}

		// Token: 0x06019C4B RID: 105547 RVA: 0x003ACD20 File Offset: 0x003AAF20
		public static void StartISequenceBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(42);
		}

		// Token: 0x06019C4C RID: 105548 RVA: 0x003ACD2A File Offset: 0x003AAF2A
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019C4D RID: 105549 RVA: 0x003ACD35 File Offset: 0x003AAF35
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06019C4E RID: 105550 RVA: 0x003ACD40 File Offset: 0x003AAF40
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06019C4F RID: 105551 RVA: 0x003ACD50 File Offset: 0x003AAF50
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06019C50 RID: 105552 RVA: 0x003ACD60 File Offset: 0x003AAF60
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06019C51 RID: 105553 RVA: 0x003ACD6B File Offset: 0x003AAF6B
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06019C52 RID: 105554 RVA: 0x003ACD76 File Offset: 0x003AAF76
		public static void AddUIConfig(FlatBufferBuilder builder, Offset<IQuestScheduleConfig> uIConfigOffset)
		{
			builder.AddOffset(6, uIConfigOffset.Value, 0);
		}

		// Token: 0x06019C53 RID: 105555 RVA: 0x003ACD86 File Offset: 0x003AAF86
		public static void AddInformationView(FlatBufferBuilder builder, Offset<IInformationViewConfig> informationViewOffset)
		{
			builder.AddOffset(7, informationViewOffset.Value, 0);
		}

		// Token: 0x06019C54 RID: 105556 RVA: 0x003ACD96 File Offset: 0x003AAF96
		public static void AddInformationBoard(FlatBufferBuilder builder, Offset<IInformationBoardConfig> informationBoardOffset)
		{
			builder.AddOffset(8, informationBoardOffset.Value, 0);
		}

		// Token: 0x06019C55 RID: 105557 RVA: 0x003ACDA6 File Offset: 0x003AAFA6
		public static void AddTidQuestAliasName(FlatBufferBuilder builder, StringOffset tidQuestAliasNameOffset)
		{
			builder.AddOffset(9, tidQuestAliasNameOffset.Value, 0);
		}

		// Token: 0x06019C56 RID: 105558 RVA: 0x003ACDB7 File Offset: 0x003AAFB7
		public static void AddTidQuestAliasDesc(FlatBufferBuilder builder, StringOffset tidQuestAliasDescOffset)
		{
			builder.AddOffset(10, tidQuestAliasDescOffset.Value, 0);
		}

		// Token: 0x06019C57 RID: 105559 RVA: 0x003ACDC8 File Offset: 0x003AAFC8
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(11, dungeonId, 0);
		}

		// Token: 0x06019C58 RID: 105560 RVA: 0x003ACDD4 File Offset: 0x003AAFD4
		public static void AddDisableOnline(FlatBufferBuilder builder, bool disableOnline)
		{
			builder.AddBool(12, disableOnline, false);
		}

		// Token: 0x06019C59 RID: 105561 RVA: 0x003ACDE0 File Offset: 0x003AAFE0
		public static void AddSaveConfig(FlatBufferBuilder builder, Offset<ISaveConfig> saveConfigOffset)
		{
			builder.AddOffset(13, saveConfigOffset.Value, 0);
		}

		// Token: 0x06019C5A RID: 105562 RVA: 0x003ACDF1 File Offset: 0x003AAFF1
		public static void AddForceClosedRestriction(FlatBufferBuilder builder, Offset<IForceClosedRestriction> forceClosedRestrictionOffset)
		{
			builder.AddOffset(14, forceClosedRestrictionOffset.Value, 0);
		}

		// Token: 0x06019C5B RID: 105563 RVA: 0x003ACE02 File Offset: 0x003AB002
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(15, occupationsOffset.Value, 0);
		}

		// Token: 0x06019C5C RID: 105564 RVA: 0x003ACE14 File Offset: 0x003AB014
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019C5D RID: 105565 RVA: 0x003ACE54 File Offset: 0x003AB054
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C5E RID: 105566 RVA: 0x003ACE6E File Offset: 0x003AB06E
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C5F RID: 105567 RVA: 0x003ACE8C File Offset: 0x003AB08C
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019C60 RID: 105568 RVA: 0x003ACEA5 File Offset: 0x003AB0A5
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019C61 RID: 105569 RVA: 0x003ACEB0 File Offset: 0x003AB0B0
		public static void AddOccupationConfig(FlatBufferBuilder builder, Offset<ILogicNodeOccupation> occupationConfigOffset)
		{
			builder.AddOffset(16, occupationConfigOffset.Value, 0);
		}

		// Token: 0x06019C62 RID: 105570 RVA: 0x003ACEC1 File Offset: 0x003AB0C1
		public static void AddDisableSwitchOccupation(FlatBufferBuilder builder, bool disableSwitchOccupation)
		{
			builder.AddBool(17, disableSwitchOccupation, false);
		}

		// Token: 0x06019C63 RID: 105571 RVA: 0x003ACECD File Offset: 0x003AB0CD
		public static void AddBudgetCameraType(FlatBufferBuilder builder, EBudgetCameraType budgetCameraType)
		{
			builder.AddByte(18, (byte)budgetCameraType, 0);
		}

		// Token: 0x06019C64 RID: 105572 RVA: 0x003ACED9 File Offset: 0x003AB0D9
		public static void AddStatistics(FlatBufferBuilder builder, Offset<IQuestStatistics> statisticsOffset)
		{
			builder.AddOffset(19, statisticsOffset.Value, 0);
		}

		// Token: 0x06019C65 RID: 105573 RVA: 0x003ACEEA File Offset: 0x003AB0EA
		public static void AddCompositeTrackViewMode(FlatBufferBuilder builder, ETrackViewMode compositeTrackViewMode)
		{
			builder.AddByte(20, (byte)compositeTrackViewMode, 0);
		}

		// Token: 0x06019C66 RID: 105574 RVA: 0x003ACEF6 File Offset: 0x003AB0F6
		public static void AddRewardConfig(FlatBufferBuilder builder, Offset<IQuestRewardConfig> rewardConfigOffset)
		{
			builder.AddOffset(21, rewardConfigOffset.Value, 0);
		}

		// Token: 0x06019C67 RID: 105575 RVA: 0x003ACF07 File Offset: 0x003AB107
		public static void AddSpecialGamePlayConfigType(FlatBufferBuilder builder, TSpecialGamePlayConfig specialGamePlayConfigType)
		{
			builder.AddByte(22, (byte)specialGamePlayConfigType, 0);
		}

		// Token: 0x06019C68 RID: 105576 RVA: 0x003ACF13 File Offset: 0x003AB113
		public static void AddSpecialGamePlayConfig(FlatBufferBuilder builder, int specialGamePlayConfigOffset)
		{
			builder.AddOffset(23, specialGamePlayConfigOffset, 0);
		}

		// Token: 0x06019C69 RID: 105577 RVA: 0x003ACF1F File Offset: 0x003AB11F
		public static void AddEnableSystemType(FlatBufferBuilder builder, TEnableSystemConfig enableSystemType)
		{
			builder.AddByte(24, (byte)enableSystemType, 0);
		}

		// Token: 0x06019C6A RID: 105578 RVA: 0x003ACF2B File Offset: 0x003AB12B
		public static void AddEnableSystem(FlatBufferBuilder builder, int enableSystemOffset)
		{
			builder.AddOffset(25, enableSystemOffset, 0);
		}

		// Token: 0x06019C6B RID: 105579 RVA: 0x003ACF37 File Offset: 0x003AB137
		public static void AddStartWave(FlatBufferBuilder builder, Offset<IWaveConfig> startWaveOffset)
		{
			builder.AddOffset(26, startWaveOffset.Value, 0);
		}

		// Token: 0x06019C6C RID: 105580 RVA: 0x003ACF48 File Offset: 0x003AB148
		public static void AddDisableTrackAnim(FlatBufferBuilder builder, Offset<IDisableTrackAnim> disableTrackAnimOffset)
		{
			builder.AddOffset(27, disableTrackAnimOffset.Value, 0);
		}

		// Token: 0x06019C6D RID: 105581 RVA: 0x003ACF59 File Offset: 0x003AB159
		public static void AddDisableSwitchGender(FlatBufferBuilder builder, bool disableSwitchGender)
		{
			builder.AddBool(28, disableSwitchGender, false);
		}

		// Token: 0x06019C6E RID: 105582 RVA: 0x003ACF65 File Offset: 0x003AB165
		public static void AddDisableFocusMode(FlatBufferBuilder builder, bool disableFocusMode)
		{
			builder.AddBool(29, disableFocusMode, false);
		}

		// Token: 0x06019C6F RID: 105583 RVA: 0x003ACF71 File Offset: 0x003AB171
		public static void AddDisableSkeletalAnimationCheck(FlatBufferBuilder builder, bool disableSkeletalAnimationCheck)
		{
			builder.AddBool(30, disableSkeletalAnimationCheck, false);
		}

		// Token: 0x06019C70 RID: 105584 RVA: 0x003ACF7D File Offset: 0x003AB17D
		public static void AddLogicProgramSpecialProcess(FlatBufferBuilder builder, Offset<ILogicProgramSpecialProcess> logicProgramSpecialProcessOffset)
		{
			builder.AddOffset(31, logicProgramSpecialProcessOffset.Value, 0);
		}

		// Token: 0x06019C71 RID: 105585 RVA: 0x003ACF8E File Offset: 0x003AB18E
		public static void AddQuestBuffActiveRange(FlatBufferBuilder builder, Offset<IQuestBuffActiveRange> questBuffActiveRangeOffset)
		{
			builder.AddOffset(32, questBuffActiveRangeOffset.Value, 0);
		}

		// Token: 0x06019C72 RID: 105586 RVA: 0x003ACF9F File Offset: 0x003AB19F
		public static void AddSunSpiritProcess(FlatBufferBuilder builder, Offset<ISunSpiritProcess> sunSpiritProcessOffset)
		{
			builder.AddOffset(33, sunSpiritProcessOffset.Value, 0);
		}

		// Token: 0x06019C73 RID: 105587 RVA: 0x003ACFB0 File Offset: 0x003AB1B0
		public static void AddModifyTrackAreaText(FlatBufferBuilder builder, Offset<ITrackAreaText> modifyTrackAreaTextOffset)
		{
			builder.AddOffset(34, modifyTrackAreaTextOffset.Value, 0);
		}

		// Token: 0x06019C74 RID: 105588 RVA: 0x003ACFC1 File Offset: 0x003AB1C1
		public static void AddDisableGlobalTraffic(FlatBufferBuilder builder, bool disableGlobalTraffic)
		{
			builder.AddBool(35, disableGlobalTraffic, false);
		}

		// Token: 0x06019C75 RID: 105589 RVA: 0x003ACFCD File Offset: 0x003AB1CD
		public static void AddDisableSystemPrompt(FlatBufferBuilder builder, VectorOffset disableSystemPromptOffset)
		{
			builder.AddOffset(36, disableSystemPromptOffset.Value, 0);
		}

		// Token: 0x06019C76 RID: 105590 RVA: 0x003ACFE0 File Offset: 0x003AB1E0
		public static VectorOffset CreateDisableSystemPromptVector(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019C77 RID: 105591 RVA: 0x003AD020 File Offset: 0x003AB220
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C78 RID: 105592 RVA: 0x003AD03A File Offset: 0x003AB23A
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAreaNameSystemPrompt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C79 RID: 105593 RVA: 0x003AD058 File Offset: 0x003AB258
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAreaNameSystemPrompt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019C7A RID: 105594 RVA: 0x003AD071 File Offset: 0x003AB271
		public static void StartDisableSystemPromptVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019C7B RID: 105595 RVA: 0x003AD07C File Offset: 0x003AB27C
		public static void AddTrackCustomBoard(FlatBufferBuilder builder, Offset<ITrackCustomBoardOnBtLogicNode> trackCustomBoardOffset)
		{
			builder.AddOffset(37, trackCustomBoardOffset.Value, 0);
		}

		// Token: 0x06019C7C RID: 105596 RVA: 0x003AD08D File Offset: 0x003AB28D
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(38, childrenTypeOffset.Value, 0);
		}

		// Token: 0x06019C7D RID: 105597 RVA: 0x003AD0A0 File Offset: 0x003AB2A0
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019C7E RID: 105598 RVA: 0x003AD0D7 File Offset: 0x003AB2D7
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C7F RID: 105599 RVA: 0x003AD0F1 File Offset: 0x003AB2F1
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TBtNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C80 RID: 105600 RVA: 0x003AD10F File Offset: 0x003AB30F
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TBtNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019C81 RID: 105601 RVA: 0x003AD128 File Offset: 0x003AB328
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06019C82 RID: 105602 RVA: 0x003AD133 File Offset: 0x003AB333
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(39, childrenOffset.Value, 0);
		}

		// Token: 0x06019C83 RID: 105603 RVA: 0x003AD144 File Offset: 0x003AB344
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019C84 RID: 105604 RVA: 0x003AD17B File Offset: 0x003AB37B
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C85 RID: 105605 RVA: 0x003AD195 File Offset: 0x003AB395
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C86 RID: 105606 RVA: 0x003AD1B3 File Offset: 0x003AB3B3
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019C87 RID: 105607 RVA: 0x003AD1CC File Offset: 0x003AB3CC
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019C88 RID: 105608 RVA: 0x003AD1D7 File Offset: 0x003AB3D7
		public static void AddPerformanceSetting(FlatBufferBuilder builder, Offset<IPerformanceSetting> performanceSettingOffset)
		{
			builder.AddOffset(40, performanceSettingOffset.Value, 0);
		}

		// Token: 0x06019C89 RID: 105609 RVA: 0x003AD1E8 File Offset: 0x003AB3E8
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(41, nullMask, 0);
		}

		// Token: 0x06019C8A RID: 105610 RVA: 0x003AD1F4 File Offset: 0x003AB3F4
		public static Offset<ISequenceBtNode> EndISequenceBtNode(FlatBufferBuilder builder)
		{
			return new Offset<ISequenceBtNode>(builder.EndTable());
		}

		// Token: 0x06019C8B RID: 105611 RVA: 0x003AD204 File Offset: 0x003AB404
		public ISequenceBtNodeT UnPack()
		{
			ISequenceBtNodeT sequenceBtNodeT = new ISequenceBtNodeT();
			this.UnPackTo(sequenceBtNodeT);
			return sequenceBtNodeT;
		}

		// Token: 0x06019C8C RID: 105612 RVA: 0x003AD220 File Offset: 0x003AB420
		public void UnPackTo(ISequenceBtNodeT _o)
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
			_o.PerformanceSetting = ((this.PerformanceSetting != null) ? this.PerformanceSetting.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019C8D RID: 105613 RVA: 0x003ADFB8 File Offset: 0x003AC1B8
		public static Offset<ISequenceBtNode> Pack(FlatBufferBuilder builder, ISequenceBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISequenceBtNode>);
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
				occupationsOffset = ISequenceBtNode.CreateOccupationsVector(builder, array);
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
				disableSystemPromptOffset = ISequenceBtNode.CreateDisableSystemPromptVector(builder, array2);
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
				children_typeOffset = ISequenceBtNode.CreateChildrenTypeVector(builder, array3);
			}
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				int[] array4 = new int[_o.Children.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = TBtNodeUnion.Pack(builder, _o.Children[l]);
				}
				childrenOffset = ISequenceBtNode.CreateChildrenVector(builder, array4);
			}
			Offset<IPerformanceSetting> performanceSettingOffset = (_o.PerformanceSetting == null) ? default(Offset<IPerformanceSetting>) : IPerformanceSetting.Pack(builder, _o.PerformanceSetting);
			return ISequenceBtNode.CreateISequenceBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, uiconfigOffset, informationViewOffset, informationBoardOffset, tidQuestAliasNameOffset, tidQuestAliasDescOffset, _o.DungeonId, _o.DisableOnline, saveConfigOffset, forceClosedRestrictionOffset, occupationsOffset, occupationConfigOffset, _o.DisableSwitchOccupation, _o.BudgetCameraType, statisticsOffset, _o.CompositeTrackViewMode, rewardConfigOffset, specialGamePlayConfig_type, specialGamePlayConfigOffset, enableSystem_type, enableSystemOffset, startWaveOffset, disableTrackAnimOffset, _o.DisableSwitchGender, _o.DisableFocusMode, _o.DisableSkeletalAnimationCheck, logicProgramSpecialProcessOffset, questBuffActiveRangeOffset, sunSpiritProcessOffset, modifyTrackAreaTextOffset, _o.DisableGlobalTraffic, disableSystemPromptOffset, trackCustomBoardOffset, children_typeOffset, childrenOffset, performanceSettingOffset, _o.NullMask);
		}

		// Token: 0x0400C6C1 RID: 50881
		private Table __p;
	}
}
