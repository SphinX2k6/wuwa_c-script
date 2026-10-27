using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200410C RID: 16652
	public struct ISequenceBtNode : IFlatbufferObject
	{
		// Token: 0x170075AF RID: 30127
		// (get) Token: 0x06018559 RID: 99673 RVA: 0x00381B49 File Offset: 0x0037FD49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601855A RID: 99674 RVA: 0x00381B56 File Offset: 0x0037FD56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601855B RID: 99675 RVA: 0x00381B60 File Offset: 0x0037FD60
		public static ISequenceBtNode GetRootAsISequenceBtNode(ByteBuffer _bb)
		{
			return ISequenceBtNode.GetRootAsISequenceBtNode(_bb, default(ISequenceBtNode));
		}

		// Token: 0x0601855C RID: 99676 RVA: 0x00381B7C File Offset: 0x0037FD7C
		public static ISequenceBtNode GetRootAsISequenceBtNode(ByteBuffer _bb, ISequenceBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601855D RID: 99677 RVA: 0x00381B99 File Offset: 0x0037FD99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601855E RID: 99678 RVA: 0x00381BA8 File Offset: 0x0037FDA8
		public ISequenceBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075B0 RID: 30128
		// (get) Token: 0x0601855F RID: 99679 RVA: 0x00381BB8 File Offset: 0x0037FDB8
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

		// Token: 0x170075B1 RID: 30129
		// (get) Token: 0x06018560 RID: 99680 RVA: 0x00381BF4 File Offset: 0x0037FDF4
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

		// Token: 0x170075B2 RID: 30130
		// (get) Token: 0x06018561 RID: 99681 RVA: 0x00381C30 File Offset: 0x0037FE30
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

		// Token: 0x06018562 RID: 99682 RVA: 0x00381C67 File Offset: 0x0037FE67
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06018563 RID: 99683 RVA: 0x00381C76 File Offset: 0x0037FE76
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170075B3 RID: 30131
		// (get) Token: 0x06018564 RID: 99684 RVA: 0x00381C84 File Offset: 0x0037FE84
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

		// Token: 0x170075B4 RID: 30132
		// (get) Token: 0x06018565 RID: 99685 RVA: 0x00381CE4 File Offset: 0x0037FEE4
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170075B5 RID: 30133
		// (get) Token: 0x06018566 RID: 99686 RVA: 0x00381D24 File Offset: 0x0037FF24
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170075B6 RID: 30134
		// (get) Token: 0x06018567 RID: 99687 RVA: 0x00381D64 File Offset: 0x0037FF64
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

		// Token: 0x170075B7 RID: 30135
		// (get) Token: 0x06018568 RID: 99688 RVA: 0x00381DC4 File Offset: 0x0037FFC4
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

		// Token: 0x170075B8 RID: 30136
		// (get) Token: 0x06018569 RID: 99689 RVA: 0x00381E24 File Offset: 0x00380024
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

		// Token: 0x170075B9 RID: 30137
		// (get) Token: 0x0601856A RID: 99690 RVA: 0x00381E84 File Offset: 0x00380084
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

		// Token: 0x0601856B RID: 99691 RVA: 0x00381EBC File Offset: 0x003800BC
		public Span<byte> GetTidQuestAliasNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0601856C RID: 99692 RVA: 0x00381ECC File Offset: 0x003800CC
		public byte[] GetTidQuestAliasNameArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x170075BA RID: 30138
		// (get) Token: 0x0601856D RID: 99693 RVA: 0x00381EDC File Offset: 0x003800DC
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

		// Token: 0x0601856E RID: 99694 RVA: 0x00381F14 File Offset: 0x00380114
		public Span<byte> GetTidQuestAliasDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0601856F RID: 99695 RVA: 0x00381F24 File Offset: 0x00380124
		public byte[] GetTidQuestAliasDescArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x170075BB RID: 30139
		// (get) Token: 0x06018570 RID: 99696 RVA: 0x00381F34 File Offset: 0x00380134
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

		// Token: 0x170075BC RID: 30140
		// (get) Token: 0x06018571 RID: 99697 RVA: 0x00381F74 File Offset: 0x00380174
		public bool DisableOnline
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170075BD RID: 30141
		// (get) Token: 0x06018572 RID: 99698 RVA: 0x00381FB4 File Offset: 0x003801B4
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

		// Token: 0x170075BE RID: 30142
		// (get) Token: 0x06018573 RID: 99699 RVA: 0x00382014 File Offset: 0x00380214
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

		// Token: 0x06018574 RID: 99700 RVA: 0x00382074 File Offset: 0x00380274
		public string Occupations(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170075BF RID: 30143
		// (get) Token: 0x06018575 RID: 99701 RVA: 0x003820B0 File Offset: 0x003802B0
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

		// Token: 0x170075C0 RID: 30144
		// (get) Token: 0x06018576 RID: 99702 RVA: 0x003820DC File Offset: 0x003802DC
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

		// Token: 0x170075C1 RID: 30145
		// (get) Token: 0x06018577 RID: 99703 RVA: 0x0038213C File Offset: 0x0038033C
		public bool DisableSwitchOccupation
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170075C2 RID: 30146
		// (get) Token: 0x06018578 RID: 99704 RVA: 0x0038217C File Offset: 0x0038037C
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

		// Token: 0x170075C3 RID: 30147
		// (get) Token: 0x06018579 RID: 99705 RVA: 0x003821BC File Offset: 0x003803BC
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

		// Token: 0x170075C4 RID: 30148
		// (get) Token: 0x0601857A RID: 99706 RVA: 0x0038221C File Offset: 0x0038041C
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

		// Token: 0x170075C5 RID: 30149
		// (get) Token: 0x0601857B RID: 99707 RVA: 0x0038225C File Offset: 0x0038045C
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

		// Token: 0x170075C6 RID: 30150
		// (get) Token: 0x0601857C RID: 99708 RVA: 0x003822BC File Offset: 0x003804BC
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

		// Token: 0x0601857D RID: 99709 RVA: 0x003822FC File Offset: 0x003804FC
		public TTable? SpecialGamePlayConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601857E RID: 99710 RVA: 0x00382344 File Offset: 0x00380544
		public IEavesdropGamePlayConfig SpecialGamePlayConfigAsIEavesdropGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IEavesdropGamePlayConfig>().Value;
		}

		// Token: 0x0601857F RID: 99711 RVA: 0x00382360 File Offset: 0x00380560
		public IFirstPersonTurretGamePlayConfig SpecialGamePlayConfigAsIFirstPersonTurretGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFirstPersonTurretGamePlayConfig>().Value;
		}

		// Token: 0x06018580 RID: 99712 RVA: 0x0038237C File Offset: 0x0038057C
		public IFreezeOnSightGamePlayConfig SpecialGamePlayConfigAsIFreezeOnSightGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFreezeOnSightGamePlayConfig>().Value;
		}

		// Token: 0x06018581 RID: 99713 RVA: 0x00382398 File Offset: 0x00380598
		public IStalkingGamePlayConfig SpecialGamePlayConfigAsIStalkingGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IStalkingGamePlayConfig>().Value;
		}

		// Token: 0x170075C7 RID: 30151
		// (get) Token: 0x06018582 RID: 99714 RVA: 0x003823B4 File Offset: 0x003805B4
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

		// Token: 0x06018583 RID: 99715 RVA: 0x003823F4 File Offset: 0x003805F4
		public TTable? EnableSystem<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018584 RID: 99716 RVA: 0x0038243C File Offset: 0x0038063C
		public IFlagChallengeSystemConfig EnableSystemAsIFlagChallengeSystemConfig()
		{
			return this.EnableSystem<IFlagChallengeSystemConfig>().Value;
		}

		// Token: 0x06018585 RID: 99717 RVA: 0x00382458 File Offset: 0x00380658
		public IFlipperSystemConfig EnableSystemAsIFlipperSystemConfig()
		{
			return this.EnableSystem<IFlipperSystemConfig>().Value;
		}

		// Token: 0x06018586 RID: 99718 RVA: 0x00382474 File Offset: 0x00380674
		public IGameDifficultySystemConfig EnableSystemAsIGameDifficultySystemConfig()
		{
			return this.EnableSystem<IGameDifficultySystemConfig>().Value;
		}

		// Token: 0x06018587 RID: 99719 RVA: 0x00382490 File Offset: 0x00380690
		public IGradingSystemConfig EnableSystemAsIGradingSystemConfig()
		{
			return this.EnableSystem<IGradingSystemConfig>().Value;
		}

		// Token: 0x06018588 RID: 99720 RVA: 0x003824AC File Offset: 0x003806AC
		public IKuroSimpleCombatKillMonsterSystemConfig EnableSystemAsIKuroSimpleCombatKillMonsterSystemConfig()
		{
			return this.EnableSystem<IKuroSimpleCombatKillMonsterSystemConfig>().Value;
		}

		// Token: 0x06018589 RID: 99721 RVA: 0x003824C8 File Offset: 0x003806C8
		public IKurotatoSystemConfig EnableSystemAsIKurotatoSystemConfig()
		{
			return this.EnableSystem<IKurotatoSystemConfig>().Value;
		}

		// Token: 0x0601858A RID: 99722 RVA: 0x003824E4 File Offset: 0x003806E4
		public ILinkSystemConfig EnableSystemAsILinkSystemConfig()
		{
			return this.EnableSystem<ILinkSystemConfig>().Value;
		}

		// Token: 0x0601858B RID: 99723 RVA: 0x00382500 File Offset: 0x00380700
		public IMotorFightSystemConfig EnableSystemAsIMotorFightSystemConfig()
		{
			return this.EnableSystem<IMotorFightSystemConfig>().Value;
		}

		// Token: 0x0601858C RID: 99724 RVA: 0x0038251C File Offset: 0x0038071C
		public IMotorRacingSystemConfig EnableSystemAsIMotorRacingSystemConfig()
		{
			return this.EnableSystem<IMotorRacingSystemConfig>().Value;
		}

		// Token: 0x0601858D RID: 99725 RVA: 0x00382538 File Offset: 0x00380738
		public INightmareSettlementSystemConfig EnableSystemAsINightmareSettlementSystemConfig()
		{
			return this.EnableSystem<INightmareSettlementSystemConfig>().Value;
		}

		// Token: 0x0601858E RID: 99726 RVA: 0x00382554 File Offset: 0x00380754
		public IRogueTowerTrialSystemConfig EnableSystemAsIRogueTowerTrialSystemConfig()
		{
			return this.EnableSystem<IRogueTowerTrialSystemConfig>().Value;
		}

		// Token: 0x0601858F RID: 99727 RVA: 0x00382570 File Offset: 0x00380770
		public IRoleTowerSystemConfig EnableSystemAsIRoleTowerSystemConfig()
		{
			return this.EnableSystem<IRoleTowerSystemConfig>().Value;
		}

		// Token: 0x06018590 RID: 99728 RVA: 0x0038258C File Offset: 0x0038078C
		public ISurvivorsRougeSystemConfig EnableSystemAsISurvivorsRougeSystemConfig()
		{
			return this.EnableSystem<ISurvivorsRougeSystemConfig>().Value;
		}

		// Token: 0x06018591 RID: 99729 RVA: 0x003825A8 File Offset: 0x003807A8
		public ITrapDefenseSystemConfig EnableSystemAsITrapDefenseSystemConfig()
		{
			return this.EnableSystem<ITrapDefenseSystemConfig>().Value;
		}

		// Token: 0x170075C8 RID: 30152
		// (get) Token: 0x06018592 RID: 99730 RVA: 0x003825C4 File Offset: 0x003807C4
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

		// Token: 0x170075C9 RID: 30153
		// (get) Token: 0x06018593 RID: 99731 RVA: 0x00382624 File Offset: 0x00380824
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

		// Token: 0x170075CA RID: 30154
		// (get) Token: 0x06018594 RID: 99732 RVA: 0x00382684 File Offset: 0x00380884
		public bool DisableSwitchGender
		{
			get
			{
				int num = this.__p.__offset(60);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170075CB RID: 30155
		// (get) Token: 0x06018595 RID: 99733 RVA: 0x003826C4 File Offset: 0x003808C4
		public bool DisableFocusMode
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170075CC RID: 30156
		// (get) Token: 0x06018596 RID: 99734 RVA: 0x00382704 File Offset: 0x00380904
		public bool DisableSkeletalAnimationCheck
		{
			get
			{
				int num = this.__p.__offset(64);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170075CD RID: 30157
		// (get) Token: 0x06018597 RID: 99735 RVA: 0x00382744 File Offset: 0x00380944
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

		// Token: 0x170075CE RID: 30158
		// (get) Token: 0x06018598 RID: 99736 RVA: 0x003827A4 File Offset: 0x003809A4
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

		// Token: 0x170075CF RID: 30159
		// (get) Token: 0x06018599 RID: 99737 RVA: 0x00382804 File Offset: 0x00380A04
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

		// Token: 0x170075D0 RID: 30160
		// (get) Token: 0x0601859A RID: 99738 RVA: 0x00382864 File Offset: 0x00380A64
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

		// Token: 0x170075D1 RID: 30161
		// (get) Token: 0x0601859B RID: 99739 RVA: 0x003828C4 File Offset: 0x00380AC4
		public bool DisableGlobalTraffic
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601859C RID: 99740 RVA: 0x00382904 File Offset: 0x00380B04
		public IAreaNameSystemPrompt? DisableSystemPrompt(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IAreaNameSystemPrompt?(default(IAreaNameSystemPrompt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170075D2 RID: 30162
		// (get) Token: 0x0601859D RID: 99741 RVA: 0x00382968 File Offset: 0x00380B68
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

		// Token: 0x170075D3 RID: 30163
		// (get) Token: 0x0601859E RID: 99742 RVA: 0x00382994 File Offset: 0x00380B94
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

		// Token: 0x0601859F RID: 99743 RVA: 0x003829F4 File Offset: 0x00380BF4
		public TBtNode ChildrenType(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return TBtNode.NONE;
			}
			return (TBtNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170075D4 RID: 30164
		// (get) Token: 0x060185A0 RID: 99744 RVA: 0x00382A34 File Offset: 0x00380C34
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

		// Token: 0x060185A1 RID: 99745 RVA: 0x00382A60 File Offset: 0x00380C60
		public Span<TBtNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TBtNode>(80, 1);
		}

		// Token: 0x060185A2 RID: 99746 RVA: 0x00382A70 File Offset: 0x00380C70
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

		// Token: 0x060185A3 RID: 99747 RVA: 0x00382ADC File Offset: 0x00380CDC
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170075D5 RID: 30165
		// (get) Token: 0x060185A4 RID: 99748 RVA: 0x00382B24 File Offset: 0x00380D24
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

		// Token: 0x170075D6 RID: 30166
		// (get) Token: 0x060185A5 RID: 99749 RVA: 0x00382B50 File Offset: 0x00380D50
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

		// Token: 0x170075D7 RID: 30167
		// (get) Token: 0x060185A6 RID: 99750 RVA: 0x00382BB0 File Offset: 0x00380DB0
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

		// Token: 0x060185A7 RID: 99751 RVA: 0x00382BF0 File Offset: 0x00380DF0
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

		// Token: 0x060185A8 RID: 99752 RVA: 0x00382D58 File Offset: 0x00380F58
		public static void StartISequenceBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(42);
		}

		// Token: 0x060185A9 RID: 99753 RVA: 0x00382D62 File Offset: 0x00380F62
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060185AA RID: 99754 RVA: 0x00382D6D File Offset: 0x00380F6D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060185AB RID: 99755 RVA: 0x00382D78 File Offset: 0x00380F78
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x060185AC RID: 99756 RVA: 0x00382D88 File Offset: 0x00380F88
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x060185AD RID: 99757 RVA: 0x00382D98 File Offset: 0x00380F98
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x060185AE RID: 99758 RVA: 0x00382DA3 File Offset: 0x00380FA3
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x060185AF RID: 99759 RVA: 0x00382DAE File Offset: 0x00380FAE
		public static void AddUIConfig(FlatBufferBuilder builder, Offset<IQuestScheduleConfig> uIConfigOffset)
		{
			builder.AddOffset(6, uIConfigOffset.Value, 0);
		}

		// Token: 0x060185B0 RID: 99760 RVA: 0x00382DBE File Offset: 0x00380FBE
		public static void AddInformationView(FlatBufferBuilder builder, Offset<IInformationViewConfig> informationViewOffset)
		{
			builder.AddOffset(7, informationViewOffset.Value, 0);
		}

		// Token: 0x060185B1 RID: 99761 RVA: 0x00382DCE File Offset: 0x00380FCE
		public static void AddInformationBoard(FlatBufferBuilder builder, Offset<IInformationBoardConfig> informationBoardOffset)
		{
			builder.AddOffset(8, informationBoardOffset.Value, 0);
		}

		// Token: 0x060185B2 RID: 99762 RVA: 0x00382DDE File Offset: 0x00380FDE
		public static void AddTidQuestAliasName(FlatBufferBuilder builder, StringOffset tidQuestAliasNameOffset)
		{
			builder.AddOffset(9, tidQuestAliasNameOffset.Value, 0);
		}

		// Token: 0x060185B3 RID: 99763 RVA: 0x00382DEF File Offset: 0x00380FEF
		public static void AddTidQuestAliasDesc(FlatBufferBuilder builder, StringOffset tidQuestAliasDescOffset)
		{
			builder.AddOffset(10, tidQuestAliasDescOffset.Value, 0);
		}

		// Token: 0x060185B4 RID: 99764 RVA: 0x00382E00 File Offset: 0x00381000
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(11, dungeonId, 0);
		}

		// Token: 0x060185B5 RID: 99765 RVA: 0x00382E0C File Offset: 0x0038100C
		public static void AddDisableOnline(FlatBufferBuilder builder, bool disableOnline)
		{
			builder.AddBool(12, disableOnline, false);
		}

		// Token: 0x060185B6 RID: 99766 RVA: 0x00382E18 File Offset: 0x00381018
		public static void AddSaveConfig(FlatBufferBuilder builder, Offset<ISaveConfig> saveConfigOffset)
		{
			builder.AddOffset(13, saveConfigOffset.Value, 0);
		}

		// Token: 0x060185B7 RID: 99767 RVA: 0x00382E29 File Offset: 0x00381029
		public static void AddForceClosedRestriction(FlatBufferBuilder builder, Offset<IForceClosedRestriction> forceClosedRestrictionOffset)
		{
			builder.AddOffset(14, forceClosedRestrictionOffset.Value, 0);
		}

		// Token: 0x060185B8 RID: 99768 RVA: 0x00382E3A File Offset: 0x0038103A
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(15, occupationsOffset.Value, 0);
		}

		// Token: 0x060185B9 RID: 99769 RVA: 0x00382E4C File Offset: 0x0038104C
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060185BA RID: 99770 RVA: 0x00382E8C File Offset: 0x0038108C
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060185BB RID: 99771 RVA: 0x00382EA6 File Offset: 0x003810A6
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060185BC RID: 99772 RVA: 0x00382EC4 File Offset: 0x003810C4
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060185BD RID: 99773 RVA: 0x00382EDD File Offset: 0x003810DD
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060185BE RID: 99774 RVA: 0x00382EE8 File Offset: 0x003810E8
		public static void AddOccupationConfig(FlatBufferBuilder builder, Offset<ILogicNodeOccupation> occupationConfigOffset)
		{
			builder.AddOffset(16, occupationConfigOffset.Value, 0);
		}

		// Token: 0x060185BF RID: 99775 RVA: 0x00382EF9 File Offset: 0x003810F9
		public static void AddDisableSwitchOccupation(FlatBufferBuilder builder, bool disableSwitchOccupation)
		{
			builder.AddBool(17, disableSwitchOccupation, false);
		}

		// Token: 0x060185C0 RID: 99776 RVA: 0x00382F05 File Offset: 0x00381105
		public static void AddBudgetCameraType(FlatBufferBuilder builder, EBudgetCameraType budgetCameraType)
		{
			builder.AddByte(18, (byte)budgetCameraType, 0);
		}

		// Token: 0x060185C1 RID: 99777 RVA: 0x00382F11 File Offset: 0x00381111
		public static void AddStatistics(FlatBufferBuilder builder, Offset<IQuestStatistics> statisticsOffset)
		{
			builder.AddOffset(19, statisticsOffset.Value, 0);
		}

		// Token: 0x060185C2 RID: 99778 RVA: 0x00382F22 File Offset: 0x00381122
		public static void AddCompositeTrackViewMode(FlatBufferBuilder builder, ETrackViewMode compositeTrackViewMode)
		{
			builder.AddByte(20, (byte)compositeTrackViewMode, 0);
		}

		// Token: 0x060185C3 RID: 99779 RVA: 0x00382F2E File Offset: 0x0038112E
		public static void AddRewardConfig(FlatBufferBuilder builder, Offset<IQuestRewardConfig> rewardConfigOffset)
		{
			builder.AddOffset(21, rewardConfigOffset.Value, 0);
		}

		// Token: 0x060185C4 RID: 99780 RVA: 0x00382F3F File Offset: 0x0038113F
		public static void AddSpecialGamePlayConfigType(FlatBufferBuilder builder, TSpecialGamePlayConfig specialGamePlayConfigType)
		{
			builder.AddByte(22, (byte)specialGamePlayConfigType, 0);
		}

		// Token: 0x060185C5 RID: 99781 RVA: 0x00382F4B File Offset: 0x0038114B
		public static void AddSpecialGamePlayConfig(FlatBufferBuilder builder, int specialGamePlayConfigOffset)
		{
			builder.AddOffset(23, specialGamePlayConfigOffset, 0);
		}

		// Token: 0x060185C6 RID: 99782 RVA: 0x00382F57 File Offset: 0x00381157
		public static void AddEnableSystemType(FlatBufferBuilder builder, TEnableSystemConfig enableSystemType)
		{
			builder.AddByte(24, (byte)enableSystemType, 0);
		}

		// Token: 0x060185C7 RID: 99783 RVA: 0x00382F63 File Offset: 0x00381163
		public static void AddEnableSystem(FlatBufferBuilder builder, int enableSystemOffset)
		{
			builder.AddOffset(25, enableSystemOffset, 0);
		}

		// Token: 0x060185C8 RID: 99784 RVA: 0x00382F6F File Offset: 0x0038116F
		public static void AddStartWave(FlatBufferBuilder builder, Offset<IWaveConfig> startWaveOffset)
		{
			builder.AddOffset(26, startWaveOffset.Value, 0);
		}

		// Token: 0x060185C9 RID: 99785 RVA: 0x00382F80 File Offset: 0x00381180
		public static void AddDisableTrackAnim(FlatBufferBuilder builder, Offset<IDisableTrackAnim> disableTrackAnimOffset)
		{
			builder.AddOffset(27, disableTrackAnimOffset.Value, 0);
		}

		// Token: 0x060185CA RID: 99786 RVA: 0x00382F91 File Offset: 0x00381191
		public static void AddDisableSwitchGender(FlatBufferBuilder builder, bool disableSwitchGender)
		{
			builder.AddBool(28, disableSwitchGender, false);
		}

		// Token: 0x060185CB RID: 99787 RVA: 0x00382F9D File Offset: 0x0038119D
		public static void AddDisableFocusMode(FlatBufferBuilder builder, bool disableFocusMode)
		{
			builder.AddBool(29, disableFocusMode, false);
		}

		// Token: 0x060185CC RID: 99788 RVA: 0x00382FA9 File Offset: 0x003811A9
		public static void AddDisableSkeletalAnimationCheck(FlatBufferBuilder builder, bool disableSkeletalAnimationCheck)
		{
			builder.AddBool(30, disableSkeletalAnimationCheck, false);
		}

		// Token: 0x060185CD RID: 99789 RVA: 0x00382FB5 File Offset: 0x003811B5
		public static void AddLogicProgramSpecialProcess(FlatBufferBuilder builder, Offset<ILogicProgramSpecialProcess> logicProgramSpecialProcessOffset)
		{
			builder.AddOffset(31, logicProgramSpecialProcessOffset.Value, 0);
		}

		// Token: 0x060185CE RID: 99790 RVA: 0x00382FC6 File Offset: 0x003811C6
		public static void AddQuestBuffActiveRange(FlatBufferBuilder builder, Offset<IQuestBuffActiveRange> questBuffActiveRangeOffset)
		{
			builder.AddOffset(32, questBuffActiveRangeOffset.Value, 0);
		}

		// Token: 0x060185CF RID: 99791 RVA: 0x00382FD7 File Offset: 0x003811D7
		public static void AddSunSpiritProcess(FlatBufferBuilder builder, Offset<ISunSpiritProcess> sunSpiritProcessOffset)
		{
			builder.AddOffset(33, sunSpiritProcessOffset.Value, 0);
		}

		// Token: 0x060185D0 RID: 99792 RVA: 0x00382FE8 File Offset: 0x003811E8
		public static void AddModifyTrackAreaText(FlatBufferBuilder builder, Offset<ITrackAreaText> modifyTrackAreaTextOffset)
		{
			builder.AddOffset(34, modifyTrackAreaTextOffset.Value, 0);
		}

		// Token: 0x060185D1 RID: 99793 RVA: 0x00382FF9 File Offset: 0x003811F9
		public static void AddDisableGlobalTraffic(FlatBufferBuilder builder, bool disableGlobalTraffic)
		{
			builder.AddBool(35, disableGlobalTraffic, false);
		}

		// Token: 0x060185D2 RID: 99794 RVA: 0x00383005 File Offset: 0x00381205
		public static void AddDisableSystemPrompt(FlatBufferBuilder builder, VectorOffset disableSystemPromptOffset)
		{
			builder.AddOffset(36, disableSystemPromptOffset.Value, 0);
		}

		// Token: 0x060185D3 RID: 99795 RVA: 0x00383018 File Offset: 0x00381218
		public static VectorOffset CreateDisableSystemPromptVector(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060185D4 RID: 99796 RVA: 0x00383058 File Offset: 0x00381258
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x060185D5 RID: 99797 RVA: 0x00383072 File Offset: 0x00381272
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAreaNameSystemPrompt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x060185D6 RID: 99798 RVA: 0x00383090 File Offset: 0x00381290
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAreaNameSystemPrompt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060185D7 RID: 99799 RVA: 0x003830A9 File Offset: 0x003812A9
		public static void StartDisableSystemPromptVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060185D8 RID: 99800 RVA: 0x003830B4 File Offset: 0x003812B4
		public static void AddTrackCustomBoard(FlatBufferBuilder builder, Offset<ITrackCustomBoardOnBtLogicNode> trackCustomBoardOffset)
		{
			builder.AddOffset(37, trackCustomBoardOffset.Value, 0);
		}

		// Token: 0x060185D9 RID: 99801 RVA: 0x003830C5 File Offset: 0x003812C5
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(38, childrenTypeOffset.Value, 0);
		}

		// Token: 0x060185DA RID: 99802 RVA: 0x003830D8 File Offset: 0x003812D8
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060185DB RID: 99803 RVA: 0x0038310F File Offset: 0x0038130F
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x060185DC RID: 99804 RVA: 0x00383129 File Offset: 0x00381329
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TBtNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x060185DD RID: 99805 RVA: 0x00383147 File Offset: 0x00381347
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TBtNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060185DE RID: 99806 RVA: 0x00383160 File Offset: 0x00381360
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060185DF RID: 99807 RVA: 0x0038316B File Offset: 0x0038136B
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(39, childrenOffset.Value, 0);
		}

		// Token: 0x060185E0 RID: 99808 RVA: 0x0038317C File Offset: 0x0038137C
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060185E1 RID: 99809 RVA: 0x003831B3 File Offset: 0x003813B3
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060185E2 RID: 99810 RVA: 0x003831CD File Offset: 0x003813CD
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060185E3 RID: 99811 RVA: 0x003831EB File Offset: 0x003813EB
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060185E4 RID: 99812 RVA: 0x00383204 File Offset: 0x00381404
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060185E5 RID: 99813 RVA: 0x0038320F File Offset: 0x0038140F
		public static void AddPerformanceSetting(FlatBufferBuilder builder, Offset<IPerformanceSetting> performanceSettingOffset)
		{
			builder.AddOffset(40, performanceSettingOffset.Value, 0);
		}

		// Token: 0x060185E6 RID: 99814 RVA: 0x00383220 File Offset: 0x00381420
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(41, nullMask, 0);
		}

		// Token: 0x060185E7 RID: 99815 RVA: 0x0038322C File Offset: 0x0038142C
		public static Offset<ISequenceBtNode> EndISequenceBtNode(FlatBufferBuilder builder)
		{
			return new Offset<ISequenceBtNode>(builder.EndTable());
		}

		// Token: 0x060185E8 RID: 99816 RVA: 0x0038323C File Offset: 0x0038143C
		public ISequenceBtNodeT UnPack()
		{
			ISequenceBtNodeT sequenceBtNodeT = new ISequenceBtNodeT();
			this.UnPackTo(sequenceBtNodeT);
			return sequenceBtNodeT;
		}

		// Token: 0x060185E9 RID: 99817 RVA: 0x00383258 File Offset: 0x00381458
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

		// Token: 0x060185EA RID: 99818 RVA: 0x00383FB0 File Offset: 0x003821B0
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

		// Token: 0x0400BCD8 RID: 48344
		private Table __p;
	}
}
