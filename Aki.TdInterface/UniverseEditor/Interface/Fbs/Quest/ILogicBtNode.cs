using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F0E RID: 16142
	public struct ILogicBtNode : IFlatbufferObject
	{
		// Token: 0x17006FF8 RID: 28664
		// (get) Token: 0x06016DB2 RID: 93618 RVA: 0x0034BAC3 File Offset: 0x00349CC3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016DB3 RID: 93619 RVA: 0x0034BAD0 File Offset: 0x00349CD0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016DB4 RID: 93620 RVA: 0x0034BAD8 File Offset: 0x00349CD8
		public static ILogicBtNode GetRootAsILogicBtNode(ByteBuffer _bb)
		{
			return ILogicBtNode.GetRootAsILogicBtNode(_bb, default(ILogicBtNode));
		}

		// Token: 0x06016DB5 RID: 93621 RVA: 0x0034BAF4 File Offset: 0x00349CF4
		public static ILogicBtNode GetRootAsILogicBtNode(ByteBuffer _bb, ILogicBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016DB6 RID: 93622 RVA: 0x0034BB11 File Offset: 0x00349D11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016DB7 RID: 93623 RVA: 0x0034BB20 File Offset: 0x00349D20
		public ILogicBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FF9 RID: 28665
		// (get) Token: 0x06016DB8 RID: 93624 RVA: 0x0034BB30 File Offset: 0x00349D30
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

		// Token: 0x17006FFA RID: 28666
		// (get) Token: 0x06016DB9 RID: 93625 RVA: 0x0034BB6C File Offset: 0x00349D6C
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

		// Token: 0x17006FFB RID: 28667
		// (get) Token: 0x06016DBA RID: 93626 RVA: 0x0034BBA8 File Offset: 0x00349DA8
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

		// Token: 0x06016DBB RID: 93627 RVA: 0x0034BBDF File Offset: 0x00349DDF
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06016DBC RID: 93628 RVA: 0x0034BBEE File Offset: 0x00349DEE
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17006FFC RID: 28668
		// (get) Token: 0x06016DBD RID: 93629 RVA: 0x0034BBFC File Offset: 0x00349DFC
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

		// Token: 0x17006FFD RID: 28669
		// (get) Token: 0x06016DBE RID: 93630 RVA: 0x0034BC5C File Offset: 0x00349E5C
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006FFE RID: 28670
		// (get) Token: 0x06016DBF RID: 93631 RVA: 0x0034BC9C File Offset: 0x00349E9C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006FFF RID: 28671
		// (get) Token: 0x06016DC0 RID: 93632 RVA: 0x0034BCDC File Offset: 0x00349EDC
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

		// Token: 0x17007000 RID: 28672
		// (get) Token: 0x06016DC1 RID: 93633 RVA: 0x0034BD3C File Offset: 0x00349F3C
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

		// Token: 0x17007001 RID: 28673
		// (get) Token: 0x06016DC2 RID: 93634 RVA: 0x0034BD9C File Offset: 0x00349F9C
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

		// Token: 0x17007002 RID: 28674
		// (get) Token: 0x06016DC3 RID: 93635 RVA: 0x0034BDFC File Offset: 0x00349FFC
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

		// Token: 0x06016DC4 RID: 93636 RVA: 0x0034BE34 File Offset: 0x0034A034
		public Span<byte> GetTidQuestAliasNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06016DC5 RID: 93637 RVA: 0x0034BE44 File Offset: 0x0034A044
		public byte[] GetTidQuestAliasNameArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x17007003 RID: 28675
		// (get) Token: 0x06016DC6 RID: 93638 RVA: 0x0034BE54 File Offset: 0x0034A054
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

		// Token: 0x06016DC7 RID: 93639 RVA: 0x0034BE8C File Offset: 0x0034A08C
		public Span<byte> GetTidQuestAliasDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06016DC8 RID: 93640 RVA: 0x0034BE9C File Offset: 0x0034A09C
		public byte[] GetTidQuestAliasDescArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x17007004 RID: 28676
		// (get) Token: 0x06016DC9 RID: 93641 RVA: 0x0034BEAC File Offset: 0x0034A0AC
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

		// Token: 0x17007005 RID: 28677
		// (get) Token: 0x06016DCA RID: 93642 RVA: 0x0034BEEC File Offset: 0x0034A0EC
		public bool DisableOnline
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007006 RID: 28678
		// (get) Token: 0x06016DCB RID: 93643 RVA: 0x0034BF2C File Offset: 0x0034A12C
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

		// Token: 0x17007007 RID: 28679
		// (get) Token: 0x06016DCC RID: 93644 RVA: 0x0034BF8C File Offset: 0x0034A18C
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

		// Token: 0x06016DCD RID: 93645 RVA: 0x0034BFEC File Offset: 0x0034A1EC
		public string Occupations(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007008 RID: 28680
		// (get) Token: 0x06016DCE RID: 93646 RVA: 0x0034C028 File Offset: 0x0034A228
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

		// Token: 0x17007009 RID: 28681
		// (get) Token: 0x06016DCF RID: 93647 RVA: 0x0034C054 File Offset: 0x0034A254
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

		// Token: 0x1700700A RID: 28682
		// (get) Token: 0x06016DD0 RID: 93648 RVA: 0x0034C0B4 File Offset: 0x0034A2B4
		public bool DisableSwitchOccupation
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700700B RID: 28683
		// (get) Token: 0x06016DD1 RID: 93649 RVA: 0x0034C0F4 File Offset: 0x0034A2F4
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

		// Token: 0x1700700C RID: 28684
		// (get) Token: 0x06016DD2 RID: 93650 RVA: 0x0034C134 File Offset: 0x0034A334
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

		// Token: 0x1700700D RID: 28685
		// (get) Token: 0x06016DD3 RID: 93651 RVA: 0x0034C194 File Offset: 0x0034A394
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

		// Token: 0x1700700E RID: 28686
		// (get) Token: 0x06016DD4 RID: 93652 RVA: 0x0034C1D4 File Offset: 0x0034A3D4
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

		// Token: 0x1700700F RID: 28687
		// (get) Token: 0x06016DD5 RID: 93653 RVA: 0x0034C234 File Offset: 0x0034A434
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

		// Token: 0x06016DD6 RID: 93654 RVA: 0x0034C274 File Offset: 0x0034A474
		public TTable? SpecialGamePlayConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016DD7 RID: 93655 RVA: 0x0034C2BC File Offset: 0x0034A4BC
		public IEavesdropGamePlayConfig SpecialGamePlayConfigAsIEavesdropGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IEavesdropGamePlayConfig>().Value;
		}

		// Token: 0x06016DD8 RID: 93656 RVA: 0x0034C2D8 File Offset: 0x0034A4D8
		public IFirstPersonTurretGamePlayConfig SpecialGamePlayConfigAsIFirstPersonTurretGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFirstPersonTurretGamePlayConfig>().Value;
		}

		// Token: 0x06016DD9 RID: 93657 RVA: 0x0034C2F4 File Offset: 0x0034A4F4
		public IFreezeOnSightGamePlayConfig SpecialGamePlayConfigAsIFreezeOnSightGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFreezeOnSightGamePlayConfig>().Value;
		}

		// Token: 0x06016DDA RID: 93658 RVA: 0x0034C310 File Offset: 0x0034A510
		public IStalkingGamePlayConfig SpecialGamePlayConfigAsIStalkingGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IStalkingGamePlayConfig>().Value;
		}

		// Token: 0x17007010 RID: 28688
		// (get) Token: 0x06016DDB RID: 93659 RVA: 0x0034C32C File Offset: 0x0034A52C
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

		// Token: 0x06016DDC RID: 93660 RVA: 0x0034C36C File Offset: 0x0034A56C
		public TTable? EnableSystem<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016DDD RID: 93661 RVA: 0x0034C3B4 File Offset: 0x0034A5B4
		public IFlagChallengeSystemConfig EnableSystemAsIFlagChallengeSystemConfig()
		{
			return this.EnableSystem<IFlagChallengeSystemConfig>().Value;
		}

		// Token: 0x06016DDE RID: 93662 RVA: 0x0034C3D0 File Offset: 0x0034A5D0
		public IFlipperSystemConfig EnableSystemAsIFlipperSystemConfig()
		{
			return this.EnableSystem<IFlipperSystemConfig>().Value;
		}

		// Token: 0x06016DDF RID: 93663 RVA: 0x0034C3EC File Offset: 0x0034A5EC
		public IGameDifficultySystemConfig EnableSystemAsIGameDifficultySystemConfig()
		{
			return this.EnableSystem<IGameDifficultySystemConfig>().Value;
		}

		// Token: 0x06016DE0 RID: 93664 RVA: 0x0034C408 File Offset: 0x0034A608
		public IGradingSystemConfig EnableSystemAsIGradingSystemConfig()
		{
			return this.EnableSystem<IGradingSystemConfig>().Value;
		}

		// Token: 0x06016DE1 RID: 93665 RVA: 0x0034C424 File Offset: 0x0034A624
		public IKuroSimpleCombatKillMonsterSystemConfig EnableSystemAsIKuroSimpleCombatKillMonsterSystemConfig()
		{
			return this.EnableSystem<IKuroSimpleCombatKillMonsterSystemConfig>().Value;
		}

		// Token: 0x06016DE2 RID: 93666 RVA: 0x0034C440 File Offset: 0x0034A640
		public IKurotatoSystemConfig EnableSystemAsIKurotatoSystemConfig()
		{
			return this.EnableSystem<IKurotatoSystemConfig>().Value;
		}

		// Token: 0x06016DE3 RID: 93667 RVA: 0x0034C45C File Offset: 0x0034A65C
		public ILinkSystemConfig EnableSystemAsILinkSystemConfig()
		{
			return this.EnableSystem<ILinkSystemConfig>().Value;
		}

		// Token: 0x06016DE4 RID: 93668 RVA: 0x0034C478 File Offset: 0x0034A678
		public IMotorFightSystemConfig EnableSystemAsIMotorFightSystemConfig()
		{
			return this.EnableSystem<IMotorFightSystemConfig>().Value;
		}

		// Token: 0x06016DE5 RID: 93669 RVA: 0x0034C494 File Offset: 0x0034A694
		public IMotorRacingSystemConfig EnableSystemAsIMotorRacingSystemConfig()
		{
			return this.EnableSystem<IMotorRacingSystemConfig>().Value;
		}

		// Token: 0x06016DE6 RID: 93670 RVA: 0x0034C4B0 File Offset: 0x0034A6B0
		public INightmareSettlementSystemConfig EnableSystemAsINightmareSettlementSystemConfig()
		{
			return this.EnableSystem<INightmareSettlementSystemConfig>().Value;
		}

		// Token: 0x06016DE7 RID: 93671 RVA: 0x0034C4CC File Offset: 0x0034A6CC
		public IRogueTowerTrialSystemConfig EnableSystemAsIRogueTowerTrialSystemConfig()
		{
			return this.EnableSystem<IRogueTowerTrialSystemConfig>().Value;
		}

		// Token: 0x06016DE8 RID: 93672 RVA: 0x0034C4E8 File Offset: 0x0034A6E8
		public IRoleTowerSystemConfig EnableSystemAsIRoleTowerSystemConfig()
		{
			return this.EnableSystem<IRoleTowerSystemConfig>().Value;
		}

		// Token: 0x06016DE9 RID: 93673 RVA: 0x0034C504 File Offset: 0x0034A704
		public ISurvivorsRougeSystemConfig EnableSystemAsISurvivorsRougeSystemConfig()
		{
			return this.EnableSystem<ISurvivorsRougeSystemConfig>().Value;
		}

		// Token: 0x06016DEA RID: 93674 RVA: 0x0034C520 File Offset: 0x0034A720
		public ITrapDefenseSystemConfig EnableSystemAsITrapDefenseSystemConfig()
		{
			return this.EnableSystem<ITrapDefenseSystemConfig>().Value;
		}

		// Token: 0x17007011 RID: 28689
		// (get) Token: 0x06016DEB RID: 93675 RVA: 0x0034C53C File Offset: 0x0034A73C
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

		// Token: 0x17007012 RID: 28690
		// (get) Token: 0x06016DEC RID: 93676 RVA: 0x0034C59C File Offset: 0x0034A79C
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

		// Token: 0x17007013 RID: 28691
		// (get) Token: 0x06016DED RID: 93677 RVA: 0x0034C5FC File Offset: 0x0034A7FC
		public bool DisableSwitchGender
		{
			get
			{
				int num = this.__p.__offset(60);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007014 RID: 28692
		// (get) Token: 0x06016DEE RID: 93678 RVA: 0x0034C63C File Offset: 0x0034A83C
		public bool DisableFocusMode
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007015 RID: 28693
		// (get) Token: 0x06016DEF RID: 93679 RVA: 0x0034C67C File Offset: 0x0034A87C
		public bool DisableSkeletalAnimationCheck
		{
			get
			{
				int num = this.__p.__offset(64);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007016 RID: 28694
		// (get) Token: 0x06016DF0 RID: 93680 RVA: 0x0034C6BC File Offset: 0x0034A8BC
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

		// Token: 0x17007017 RID: 28695
		// (get) Token: 0x06016DF1 RID: 93681 RVA: 0x0034C71C File Offset: 0x0034A91C
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

		// Token: 0x17007018 RID: 28696
		// (get) Token: 0x06016DF2 RID: 93682 RVA: 0x0034C77C File Offset: 0x0034A97C
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

		// Token: 0x17007019 RID: 28697
		// (get) Token: 0x06016DF3 RID: 93683 RVA: 0x0034C7DC File Offset: 0x0034A9DC
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

		// Token: 0x1700701A RID: 28698
		// (get) Token: 0x06016DF4 RID: 93684 RVA: 0x0034C83C File Offset: 0x0034AA3C
		public bool DisableGlobalTraffic
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06016DF5 RID: 93685 RVA: 0x0034C87C File Offset: 0x0034AA7C
		public IAreaNameSystemPrompt? DisableSystemPrompt(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IAreaNameSystemPrompt?(default(IAreaNameSystemPrompt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700701B RID: 28699
		// (get) Token: 0x06016DF6 RID: 93686 RVA: 0x0034C8E0 File Offset: 0x0034AAE0
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

		// Token: 0x1700701C RID: 28700
		// (get) Token: 0x06016DF7 RID: 93687 RVA: 0x0034C90C File Offset: 0x0034AB0C
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

		// Token: 0x1700701D RID: 28701
		// (get) Token: 0x06016DF8 RID: 93688 RVA: 0x0034C96C File Offset: 0x0034AB6C
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016DF9 RID: 93689 RVA: 0x0034C9AC File Offset: 0x0034ABAC
		public static Offset<ILogicBtNode> CreateILogicBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, Offset<IQuestScheduleConfig> UIConfigOffset = default(Offset<IQuestScheduleConfig>), Offset<IInformationViewConfig> InformationViewOffset = default(Offset<IInformationViewConfig>), Offset<IInformationBoardConfig> InformationBoardOffset = default(Offset<IInformationBoardConfig>), StringOffset TidQuestAliasNameOffset = default(StringOffset), StringOffset TidQuestAliasDescOffset = default(StringOffset), int DungeonId = 0, bool DisableOnline = false, Offset<ISaveConfig> SaveConfigOffset = default(Offset<ISaveConfig>), Offset<IForceClosedRestriction> ForceClosedRestrictionOffset = default(Offset<IForceClosedRestriction>), VectorOffset OccupationsOffset = default(VectorOffset), Offset<ILogicNodeOccupation> OccupationConfigOffset = default(Offset<ILogicNodeOccupation>), bool DisableSwitchOccupation = false, EBudgetCameraType BudgetCameraType = EBudgetCameraType.Role, Offset<IQuestStatistics> StatisticsOffset = default(Offset<IQuestStatistics>), ETrackViewMode CompositeTrackViewMode = ETrackViewMode.All, Offset<IQuestRewardConfig> RewardConfigOffset = default(Offset<IQuestRewardConfig>), TSpecialGamePlayConfig SpecialGamePlayConfig_type = TSpecialGamePlayConfig.NONE, int SpecialGamePlayConfigOffset = 0, TEnableSystemConfig EnableSystem_type = TEnableSystemConfig.NONE, int EnableSystemOffset = 0, Offset<IWaveConfig> StartWaveOffset = default(Offset<IWaveConfig>), Offset<IDisableTrackAnim> DisableTrackAnimOffset = default(Offset<IDisableTrackAnim>), bool DisableSwitchGender = false, bool DisableFocusMode = false, bool DisableSkeletalAnimationCheck = false, Offset<ILogicProgramSpecialProcess> LogicProgramSpecialProcessOffset = default(Offset<ILogicProgramSpecialProcess>), Offset<IQuestBuffActiveRange> QuestBuffActiveRangeOffset = default(Offset<IQuestBuffActiveRange>), Offset<ISunSpiritProcess> SunSpiritProcessOffset = default(Offset<ISunSpiritProcess>), Offset<ITrackAreaText> ModifyTrackAreaTextOffset = default(Offset<ITrackAreaText>), bool DisableGlobalTraffic = false, VectorOffset DisableSystemPromptOffset = default(VectorOffset), Offset<ITrackCustomBoardOnBtLogicNode> TrackCustomBoardOffset = default(Offset<ITrackCustomBoardOnBtLogicNode>), ushort NullMask = 0)
		{
			builder.StartTable(39);
			ILogicBtNode.AddTrackCustomBoard(builder, TrackCustomBoardOffset);
			ILogicBtNode.AddDisableSystemPrompt(builder, DisableSystemPromptOffset);
			ILogicBtNode.AddModifyTrackAreaText(builder, ModifyTrackAreaTextOffset);
			ILogicBtNode.AddSunSpiritProcess(builder, SunSpiritProcessOffset);
			ILogicBtNode.AddQuestBuffActiveRange(builder, QuestBuffActiveRangeOffset);
			ILogicBtNode.AddLogicProgramSpecialProcess(builder, LogicProgramSpecialProcessOffset);
			ILogicBtNode.AddDisableTrackAnim(builder, DisableTrackAnimOffset);
			ILogicBtNode.AddStartWave(builder, StartWaveOffset);
			ILogicBtNode.AddEnableSystem(builder, EnableSystemOffset);
			ILogicBtNode.AddSpecialGamePlayConfig(builder, SpecialGamePlayConfigOffset);
			ILogicBtNode.AddRewardConfig(builder, RewardConfigOffset);
			ILogicBtNode.AddStatistics(builder, StatisticsOffset);
			ILogicBtNode.AddOccupationConfig(builder, OccupationConfigOffset);
			ILogicBtNode.AddOccupations(builder, OccupationsOffset);
			ILogicBtNode.AddForceClosedRestriction(builder, ForceClosedRestrictionOffset);
			ILogicBtNode.AddSaveConfig(builder, SaveConfigOffset);
			ILogicBtNode.AddDungeonId(builder, DungeonId);
			ILogicBtNode.AddTidQuestAliasDesc(builder, TidQuestAliasDescOffset);
			ILogicBtNode.AddTidQuestAliasName(builder, TidQuestAliasNameOffset);
			ILogicBtNode.AddInformationBoard(builder, InformationBoardOffset);
			ILogicBtNode.AddInformationView(builder, InformationViewOffset);
			ILogicBtNode.AddUIConfig(builder, UIConfigOffset);
			ILogicBtNode.AddFixProcessor(builder, FixProcessorOffset);
			ILogicBtNode.AddDesc(builder, DescOffset);
			ILogicBtNode.AddId(builder, Id);
			ILogicBtNode.AddNullMask(builder, NullMask);
			ILogicBtNode.AddDisableGlobalTraffic(builder, DisableGlobalTraffic);
			ILogicBtNode.AddDisableSkeletalAnimationCheck(builder, DisableSkeletalAnimationCheck);
			ILogicBtNode.AddDisableFocusMode(builder, DisableFocusMode);
			ILogicBtNode.AddDisableSwitchGender(builder, DisableSwitchGender);
			ILogicBtNode.AddEnableSystemType(builder, EnableSystem_type);
			ILogicBtNode.AddSpecialGamePlayConfigType(builder, SpecialGamePlayConfig_type);
			ILogicBtNode.AddCompositeTrackViewMode(builder, CompositeTrackViewMode);
			ILogicBtNode.AddBudgetCameraType(builder, BudgetCameraType);
			ILogicBtNode.AddDisableSwitchOccupation(builder, DisableSwitchOccupation);
			ILogicBtNode.AddDisableOnline(builder, DisableOnline);
			ILogicBtNode.AddDisabled(builder, Disabled);
			ILogicBtNode.Add_FoldedForTree(builder, _foldedForTree);
			ILogicBtNode.AddType(builder, Type);
			return ILogicBtNode.EndILogicBtNode(builder);
		}

		// Token: 0x06016DFA RID: 93690 RVA: 0x0034CAFC File Offset: 0x0034ACFC
		public static void StartILogicBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(39);
		}

		// Token: 0x06016DFB RID: 93691 RVA: 0x0034CB06 File Offset: 0x0034AD06
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016DFC RID: 93692 RVA: 0x0034CB11 File Offset: 0x0034AD11
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06016DFD RID: 93693 RVA: 0x0034CB1C File Offset: 0x0034AD1C
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06016DFE RID: 93694 RVA: 0x0034CB2C File Offset: 0x0034AD2C
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06016DFF RID: 93695 RVA: 0x0034CB3C File Offset: 0x0034AD3C
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06016E00 RID: 93696 RVA: 0x0034CB47 File Offset: 0x0034AD47
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06016E01 RID: 93697 RVA: 0x0034CB52 File Offset: 0x0034AD52
		public static void AddUIConfig(FlatBufferBuilder builder, Offset<IQuestScheduleConfig> uIConfigOffset)
		{
			builder.AddOffset(6, uIConfigOffset.Value, 0);
		}

		// Token: 0x06016E02 RID: 93698 RVA: 0x0034CB62 File Offset: 0x0034AD62
		public static void AddInformationView(FlatBufferBuilder builder, Offset<IInformationViewConfig> informationViewOffset)
		{
			builder.AddOffset(7, informationViewOffset.Value, 0);
		}

		// Token: 0x06016E03 RID: 93699 RVA: 0x0034CB72 File Offset: 0x0034AD72
		public static void AddInformationBoard(FlatBufferBuilder builder, Offset<IInformationBoardConfig> informationBoardOffset)
		{
			builder.AddOffset(8, informationBoardOffset.Value, 0);
		}

		// Token: 0x06016E04 RID: 93700 RVA: 0x0034CB82 File Offset: 0x0034AD82
		public static void AddTidQuestAliasName(FlatBufferBuilder builder, StringOffset tidQuestAliasNameOffset)
		{
			builder.AddOffset(9, tidQuestAliasNameOffset.Value, 0);
		}

		// Token: 0x06016E05 RID: 93701 RVA: 0x0034CB93 File Offset: 0x0034AD93
		public static void AddTidQuestAliasDesc(FlatBufferBuilder builder, StringOffset tidQuestAliasDescOffset)
		{
			builder.AddOffset(10, tidQuestAliasDescOffset.Value, 0);
		}

		// Token: 0x06016E06 RID: 93702 RVA: 0x0034CBA4 File Offset: 0x0034ADA4
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(11, dungeonId, 0);
		}

		// Token: 0x06016E07 RID: 93703 RVA: 0x0034CBB0 File Offset: 0x0034ADB0
		public static void AddDisableOnline(FlatBufferBuilder builder, bool disableOnline)
		{
			builder.AddBool(12, disableOnline, false);
		}

		// Token: 0x06016E08 RID: 93704 RVA: 0x0034CBBC File Offset: 0x0034ADBC
		public static void AddSaveConfig(FlatBufferBuilder builder, Offset<ISaveConfig> saveConfigOffset)
		{
			builder.AddOffset(13, saveConfigOffset.Value, 0);
		}

		// Token: 0x06016E09 RID: 93705 RVA: 0x0034CBCD File Offset: 0x0034ADCD
		public static void AddForceClosedRestriction(FlatBufferBuilder builder, Offset<IForceClosedRestriction> forceClosedRestrictionOffset)
		{
			builder.AddOffset(14, forceClosedRestrictionOffset.Value, 0);
		}

		// Token: 0x06016E0A RID: 93706 RVA: 0x0034CBDE File Offset: 0x0034ADDE
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(15, occupationsOffset.Value, 0);
		}

		// Token: 0x06016E0B RID: 93707 RVA: 0x0034CBF0 File Offset: 0x0034ADF0
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016E0C RID: 93708 RVA: 0x0034CC30 File Offset: 0x0034AE30
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06016E0D RID: 93709 RVA: 0x0034CC4A File Offset: 0x0034AE4A
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06016E0E RID: 93710 RVA: 0x0034CC68 File Offset: 0x0034AE68
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016E0F RID: 93711 RVA: 0x0034CC81 File Offset: 0x0034AE81
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016E10 RID: 93712 RVA: 0x0034CC8C File Offset: 0x0034AE8C
		public static void AddOccupationConfig(FlatBufferBuilder builder, Offset<ILogicNodeOccupation> occupationConfigOffset)
		{
			builder.AddOffset(16, occupationConfigOffset.Value, 0);
		}

		// Token: 0x06016E11 RID: 93713 RVA: 0x0034CC9D File Offset: 0x0034AE9D
		public static void AddDisableSwitchOccupation(FlatBufferBuilder builder, bool disableSwitchOccupation)
		{
			builder.AddBool(17, disableSwitchOccupation, false);
		}

		// Token: 0x06016E12 RID: 93714 RVA: 0x0034CCA9 File Offset: 0x0034AEA9
		public static void AddBudgetCameraType(FlatBufferBuilder builder, EBudgetCameraType budgetCameraType)
		{
			builder.AddByte(18, (byte)budgetCameraType, 0);
		}

		// Token: 0x06016E13 RID: 93715 RVA: 0x0034CCB5 File Offset: 0x0034AEB5
		public static void AddStatistics(FlatBufferBuilder builder, Offset<IQuestStatistics> statisticsOffset)
		{
			builder.AddOffset(19, statisticsOffset.Value, 0);
		}

		// Token: 0x06016E14 RID: 93716 RVA: 0x0034CCC6 File Offset: 0x0034AEC6
		public static void AddCompositeTrackViewMode(FlatBufferBuilder builder, ETrackViewMode compositeTrackViewMode)
		{
			builder.AddByte(20, (byte)compositeTrackViewMode, 0);
		}

		// Token: 0x06016E15 RID: 93717 RVA: 0x0034CCD2 File Offset: 0x0034AED2
		public static void AddRewardConfig(FlatBufferBuilder builder, Offset<IQuestRewardConfig> rewardConfigOffset)
		{
			builder.AddOffset(21, rewardConfigOffset.Value, 0);
		}

		// Token: 0x06016E16 RID: 93718 RVA: 0x0034CCE3 File Offset: 0x0034AEE3
		public static void AddSpecialGamePlayConfigType(FlatBufferBuilder builder, TSpecialGamePlayConfig specialGamePlayConfigType)
		{
			builder.AddByte(22, (byte)specialGamePlayConfigType, 0);
		}

		// Token: 0x06016E17 RID: 93719 RVA: 0x0034CCEF File Offset: 0x0034AEEF
		public static void AddSpecialGamePlayConfig(FlatBufferBuilder builder, int specialGamePlayConfigOffset)
		{
			builder.AddOffset(23, specialGamePlayConfigOffset, 0);
		}

		// Token: 0x06016E18 RID: 93720 RVA: 0x0034CCFB File Offset: 0x0034AEFB
		public static void AddEnableSystemType(FlatBufferBuilder builder, TEnableSystemConfig enableSystemType)
		{
			builder.AddByte(24, (byte)enableSystemType, 0);
		}

		// Token: 0x06016E19 RID: 93721 RVA: 0x0034CD07 File Offset: 0x0034AF07
		public static void AddEnableSystem(FlatBufferBuilder builder, int enableSystemOffset)
		{
			builder.AddOffset(25, enableSystemOffset, 0);
		}

		// Token: 0x06016E1A RID: 93722 RVA: 0x0034CD13 File Offset: 0x0034AF13
		public static void AddStartWave(FlatBufferBuilder builder, Offset<IWaveConfig> startWaveOffset)
		{
			builder.AddOffset(26, startWaveOffset.Value, 0);
		}

		// Token: 0x06016E1B RID: 93723 RVA: 0x0034CD24 File Offset: 0x0034AF24
		public static void AddDisableTrackAnim(FlatBufferBuilder builder, Offset<IDisableTrackAnim> disableTrackAnimOffset)
		{
			builder.AddOffset(27, disableTrackAnimOffset.Value, 0);
		}

		// Token: 0x06016E1C RID: 93724 RVA: 0x0034CD35 File Offset: 0x0034AF35
		public static void AddDisableSwitchGender(FlatBufferBuilder builder, bool disableSwitchGender)
		{
			builder.AddBool(28, disableSwitchGender, false);
		}

		// Token: 0x06016E1D RID: 93725 RVA: 0x0034CD41 File Offset: 0x0034AF41
		public static void AddDisableFocusMode(FlatBufferBuilder builder, bool disableFocusMode)
		{
			builder.AddBool(29, disableFocusMode, false);
		}

		// Token: 0x06016E1E RID: 93726 RVA: 0x0034CD4D File Offset: 0x0034AF4D
		public static void AddDisableSkeletalAnimationCheck(FlatBufferBuilder builder, bool disableSkeletalAnimationCheck)
		{
			builder.AddBool(30, disableSkeletalAnimationCheck, false);
		}

		// Token: 0x06016E1F RID: 93727 RVA: 0x0034CD59 File Offset: 0x0034AF59
		public static void AddLogicProgramSpecialProcess(FlatBufferBuilder builder, Offset<ILogicProgramSpecialProcess> logicProgramSpecialProcessOffset)
		{
			builder.AddOffset(31, logicProgramSpecialProcessOffset.Value, 0);
		}

		// Token: 0x06016E20 RID: 93728 RVA: 0x0034CD6A File Offset: 0x0034AF6A
		public static void AddQuestBuffActiveRange(FlatBufferBuilder builder, Offset<IQuestBuffActiveRange> questBuffActiveRangeOffset)
		{
			builder.AddOffset(32, questBuffActiveRangeOffset.Value, 0);
		}

		// Token: 0x06016E21 RID: 93729 RVA: 0x0034CD7B File Offset: 0x0034AF7B
		public static void AddSunSpiritProcess(FlatBufferBuilder builder, Offset<ISunSpiritProcess> sunSpiritProcessOffset)
		{
			builder.AddOffset(33, sunSpiritProcessOffset.Value, 0);
		}

		// Token: 0x06016E22 RID: 93730 RVA: 0x0034CD8C File Offset: 0x0034AF8C
		public static void AddModifyTrackAreaText(FlatBufferBuilder builder, Offset<ITrackAreaText> modifyTrackAreaTextOffset)
		{
			builder.AddOffset(34, modifyTrackAreaTextOffset.Value, 0);
		}

		// Token: 0x06016E23 RID: 93731 RVA: 0x0034CD9D File Offset: 0x0034AF9D
		public static void AddDisableGlobalTraffic(FlatBufferBuilder builder, bool disableGlobalTraffic)
		{
			builder.AddBool(35, disableGlobalTraffic, false);
		}

		// Token: 0x06016E24 RID: 93732 RVA: 0x0034CDA9 File Offset: 0x0034AFA9
		public static void AddDisableSystemPrompt(FlatBufferBuilder builder, VectorOffset disableSystemPromptOffset)
		{
			builder.AddOffset(36, disableSystemPromptOffset.Value, 0);
		}

		// Token: 0x06016E25 RID: 93733 RVA: 0x0034CDBC File Offset: 0x0034AFBC
		public static VectorOffset CreateDisableSystemPromptVector(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016E26 RID: 93734 RVA: 0x0034CDFC File Offset: 0x0034AFFC
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016E27 RID: 93735 RVA: 0x0034CE16 File Offset: 0x0034B016
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAreaNameSystemPrompt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016E28 RID: 93736 RVA: 0x0034CE34 File Offset: 0x0034B034
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAreaNameSystemPrompt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016E29 RID: 93737 RVA: 0x0034CE4D File Offset: 0x0034B04D
		public static void StartDisableSystemPromptVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016E2A RID: 93738 RVA: 0x0034CE58 File Offset: 0x0034B058
		public static void AddTrackCustomBoard(FlatBufferBuilder builder, Offset<ITrackCustomBoardOnBtLogicNode> trackCustomBoardOffset)
		{
			builder.AddOffset(37, trackCustomBoardOffset.Value, 0);
		}

		// Token: 0x06016E2B RID: 93739 RVA: 0x0034CE69 File Offset: 0x0034B069
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(38, nullMask, 0);
		}

		// Token: 0x06016E2C RID: 93740 RVA: 0x0034CE75 File Offset: 0x0034B075
		public static Offset<ILogicBtNode> EndILogicBtNode(FlatBufferBuilder builder)
		{
			return new Offset<ILogicBtNode>(builder.EndTable());
		}

		// Token: 0x06016E2D RID: 93741 RVA: 0x0034CE84 File Offset: 0x0034B084
		public ILogicBtNodeT UnPack()
		{
			ILogicBtNodeT logicBtNodeT = new ILogicBtNodeT();
			this.UnPackTo(logicBtNodeT);
			return logicBtNodeT;
		}

		// Token: 0x06016E2E RID: 93742 RVA: 0x0034CEA0 File Offset: 0x0034B0A0
		public void UnPackTo(ILogicBtNodeT _o)
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016E2F RID: 93743 RVA: 0x0034D7F0 File Offset: 0x0034B9F0
		public static Offset<ILogicBtNode> Pack(FlatBufferBuilder builder, ILogicBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILogicBtNode>);
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
				occupationsOffset = ILogicBtNode.CreateOccupationsVector(builder, array);
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
				disableSystemPromptOffset = ILogicBtNode.CreateDisableSystemPromptVector(builder, array2);
			}
			Offset<ITrackCustomBoardOnBtLogicNode> trackCustomBoardOffset = (_o.TrackCustomBoard == null) ? default(Offset<ITrackCustomBoardOnBtLogicNode>) : ITrackCustomBoardOnBtLogicNode.Pack(builder, _o.TrackCustomBoard);
			return ILogicBtNode.CreateILogicBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, uiconfigOffset, informationViewOffset, informationBoardOffset, tidQuestAliasNameOffset, tidQuestAliasDescOffset, _o.DungeonId, _o.DisableOnline, saveConfigOffset, forceClosedRestrictionOffset, occupationsOffset, occupationConfigOffset, _o.DisableSwitchOccupation, _o.BudgetCameraType, statisticsOffset, _o.CompositeTrackViewMode, rewardConfigOffset, specialGamePlayConfig_type, specialGamePlayConfigOffset, enableSystem_type, enableSystemOffset, startWaveOffset, disableTrackAnimOffset, _o.DisableSwitchGender, _o.DisableFocusMode, _o.DisableSkeletalAnimationCheck, logicProgramSpecialProcessOffset, questBuffActiveRangeOffset, sunSpiritProcessOffset, modifyTrackAreaTextOffset, _o.DisableGlobalTraffic, disableSystemPromptOffset, trackCustomBoardOffset, _o.NullMask);
		}

		// Token: 0x0400B8EC RID: 47340
		private Table __p;
	}
}
