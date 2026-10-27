using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DB2 RID: 15794
	public struct IConditionSelectorBtNode : IFlatbufferObject
	{
		// Token: 0x17006CB6 RID: 27830
		// (get) Token: 0x06015F8C RID: 89996 RVA: 0x0032C3F3 File Offset: 0x0032A5F3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015F8D RID: 89997 RVA: 0x0032C400 File Offset: 0x0032A600
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015F8E RID: 89998 RVA: 0x0032C408 File Offset: 0x0032A608
		public static IConditionSelectorBtNode GetRootAsIConditionSelectorBtNode(ByteBuffer _bb)
		{
			return IConditionSelectorBtNode.GetRootAsIConditionSelectorBtNode(_bb, default(IConditionSelectorBtNode));
		}

		// Token: 0x06015F8F RID: 89999 RVA: 0x0032C424 File Offset: 0x0032A624
		public static IConditionSelectorBtNode GetRootAsIConditionSelectorBtNode(ByteBuffer _bb, IConditionSelectorBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015F90 RID: 90000 RVA: 0x0032C441 File Offset: 0x0032A641
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015F91 RID: 90001 RVA: 0x0032C450 File Offset: 0x0032A650
		public IConditionSelectorBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006CB7 RID: 27831
		// (get) Token: 0x06015F92 RID: 90002 RVA: 0x0032C460 File Offset: 0x0032A660
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

		// Token: 0x17006CB8 RID: 27832
		// (get) Token: 0x06015F93 RID: 90003 RVA: 0x0032C49C File Offset: 0x0032A69C
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

		// Token: 0x17006CB9 RID: 27833
		// (get) Token: 0x06015F94 RID: 90004 RVA: 0x0032C4D8 File Offset: 0x0032A6D8
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

		// Token: 0x06015F95 RID: 90005 RVA: 0x0032C50F File Offset: 0x0032A70F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06015F96 RID: 90006 RVA: 0x0032C51E File Offset: 0x0032A71E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17006CBA RID: 27834
		// (get) Token: 0x06015F97 RID: 90007 RVA: 0x0032C52C File Offset: 0x0032A72C
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

		// Token: 0x17006CBB RID: 27835
		// (get) Token: 0x06015F98 RID: 90008 RVA: 0x0032C58C File Offset: 0x0032A78C
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006CBC RID: 27836
		// (get) Token: 0x06015F99 RID: 90009 RVA: 0x0032C5CC File Offset: 0x0032A7CC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006CBD RID: 27837
		// (get) Token: 0x06015F9A RID: 90010 RVA: 0x0032C60C File Offset: 0x0032A80C
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

		// Token: 0x17006CBE RID: 27838
		// (get) Token: 0x06015F9B RID: 90011 RVA: 0x0032C66C File Offset: 0x0032A86C
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

		// Token: 0x17006CBF RID: 27839
		// (get) Token: 0x06015F9C RID: 90012 RVA: 0x0032C6CC File Offset: 0x0032A8CC
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

		// Token: 0x17006CC0 RID: 27840
		// (get) Token: 0x06015F9D RID: 90013 RVA: 0x0032C72C File Offset: 0x0032A92C
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

		// Token: 0x06015F9E RID: 90014 RVA: 0x0032C764 File Offset: 0x0032A964
		public Span<byte> GetTidQuestAliasNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06015F9F RID: 90015 RVA: 0x0032C774 File Offset: 0x0032A974
		public byte[] GetTidQuestAliasNameArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x17006CC1 RID: 27841
		// (get) Token: 0x06015FA0 RID: 90016 RVA: 0x0032C784 File Offset: 0x0032A984
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

		// Token: 0x06015FA1 RID: 90017 RVA: 0x0032C7BC File Offset: 0x0032A9BC
		public Span<byte> GetTidQuestAliasDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06015FA2 RID: 90018 RVA: 0x0032C7CC File Offset: 0x0032A9CC
		public byte[] GetTidQuestAliasDescArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x17006CC2 RID: 27842
		// (get) Token: 0x06015FA3 RID: 90019 RVA: 0x0032C7DC File Offset: 0x0032A9DC
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

		// Token: 0x17006CC3 RID: 27843
		// (get) Token: 0x06015FA4 RID: 90020 RVA: 0x0032C81C File Offset: 0x0032AA1C
		public bool DisableOnline
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006CC4 RID: 27844
		// (get) Token: 0x06015FA5 RID: 90021 RVA: 0x0032C85C File Offset: 0x0032AA5C
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

		// Token: 0x17006CC5 RID: 27845
		// (get) Token: 0x06015FA6 RID: 90022 RVA: 0x0032C8BC File Offset: 0x0032AABC
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

		// Token: 0x06015FA7 RID: 90023 RVA: 0x0032C91C File Offset: 0x0032AB1C
		public string Occupations(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006CC6 RID: 27846
		// (get) Token: 0x06015FA8 RID: 90024 RVA: 0x0032C958 File Offset: 0x0032AB58
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

		// Token: 0x17006CC7 RID: 27847
		// (get) Token: 0x06015FA9 RID: 90025 RVA: 0x0032C984 File Offset: 0x0032AB84
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

		// Token: 0x17006CC8 RID: 27848
		// (get) Token: 0x06015FAA RID: 90026 RVA: 0x0032C9E4 File Offset: 0x0032ABE4
		public bool DisableSwitchOccupation
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006CC9 RID: 27849
		// (get) Token: 0x06015FAB RID: 90027 RVA: 0x0032CA24 File Offset: 0x0032AC24
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

		// Token: 0x17006CCA RID: 27850
		// (get) Token: 0x06015FAC RID: 90028 RVA: 0x0032CA64 File Offset: 0x0032AC64
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

		// Token: 0x17006CCB RID: 27851
		// (get) Token: 0x06015FAD RID: 90029 RVA: 0x0032CAC4 File Offset: 0x0032ACC4
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

		// Token: 0x17006CCC RID: 27852
		// (get) Token: 0x06015FAE RID: 90030 RVA: 0x0032CB04 File Offset: 0x0032AD04
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

		// Token: 0x17006CCD RID: 27853
		// (get) Token: 0x06015FAF RID: 90031 RVA: 0x0032CB64 File Offset: 0x0032AD64
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

		// Token: 0x06015FB0 RID: 90032 RVA: 0x0032CBA4 File Offset: 0x0032ADA4
		public TTable? SpecialGamePlayConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015FB1 RID: 90033 RVA: 0x0032CBEC File Offset: 0x0032ADEC
		public IEavesdropGamePlayConfig SpecialGamePlayConfigAsIEavesdropGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IEavesdropGamePlayConfig>().Value;
		}

		// Token: 0x06015FB2 RID: 90034 RVA: 0x0032CC08 File Offset: 0x0032AE08
		public IFirstPersonTurretGamePlayConfig SpecialGamePlayConfigAsIFirstPersonTurretGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFirstPersonTurretGamePlayConfig>().Value;
		}

		// Token: 0x06015FB3 RID: 90035 RVA: 0x0032CC24 File Offset: 0x0032AE24
		public IFreezeOnSightGamePlayConfig SpecialGamePlayConfigAsIFreezeOnSightGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFreezeOnSightGamePlayConfig>().Value;
		}

		// Token: 0x06015FB4 RID: 90036 RVA: 0x0032CC40 File Offset: 0x0032AE40
		public IStalkingGamePlayConfig SpecialGamePlayConfigAsIStalkingGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IStalkingGamePlayConfig>().Value;
		}

		// Token: 0x17006CCE RID: 27854
		// (get) Token: 0x06015FB5 RID: 90037 RVA: 0x0032CC5C File Offset: 0x0032AE5C
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

		// Token: 0x06015FB6 RID: 90038 RVA: 0x0032CC9C File Offset: 0x0032AE9C
		public TTable? EnableSystem<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015FB7 RID: 90039 RVA: 0x0032CCE4 File Offset: 0x0032AEE4
		public IFlagChallengeSystemConfig EnableSystemAsIFlagChallengeSystemConfig()
		{
			return this.EnableSystem<IFlagChallengeSystemConfig>().Value;
		}

		// Token: 0x06015FB8 RID: 90040 RVA: 0x0032CD00 File Offset: 0x0032AF00
		public IFlipperSystemConfig EnableSystemAsIFlipperSystemConfig()
		{
			return this.EnableSystem<IFlipperSystemConfig>().Value;
		}

		// Token: 0x06015FB9 RID: 90041 RVA: 0x0032CD1C File Offset: 0x0032AF1C
		public IGameDifficultySystemConfig EnableSystemAsIGameDifficultySystemConfig()
		{
			return this.EnableSystem<IGameDifficultySystemConfig>().Value;
		}

		// Token: 0x06015FBA RID: 90042 RVA: 0x0032CD38 File Offset: 0x0032AF38
		public IGradingSystemConfig EnableSystemAsIGradingSystemConfig()
		{
			return this.EnableSystem<IGradingSystemConfig>().Value;
		}

		// Token: 0x06015FBB RID: 90043 RVA: 0x0032CD54 File Offset: 0x0032AF54
		public IKuroSimpleCombatKillMonsterSystemConfig EnableSystemAsIKuroSimpleCombatKillMonsterSystemConfig()
		{
			return this.EnableSystem<IKuroSimpleCombatKillMonsterSystemConfig>().Value;
		}

		// Token: 0x06015FBC RID: 90044 RVA: 0x0032CD70 File Offset: 0x0032AF70
		public IKurotatoSystemConfig EnableSystemAsIKurotatoSystemConfig()
		{
			return this.EnableSystem<IKurotatoSystemConfig>().Value;
		}

		// Token: 0x06015FBD RID: 90045 RVA: 0x0032CD8C File Offset: 0x0032AF8C
		public ILinkSystemConfig EnableSystemAsILinkSystemConfig()
		{
			return this.EnableSystem<ILinkSystemConfig>().Value;
		}

		// Token: 0x06015FBE RID: 90046 RVA: 0x0032CDA8 File Offset: 0x0032AFA8
		public IMotorFightSystemConfig EnableSystemAsIMotorFightSystemConfig()
		{
			return this.EnableSystem<IMotorFightSystemConfig>().Value;
		}

		// Token: 0x06015FBF RID: 90047 RVA: 0x0032CDC4 File Offset: 0x0032AFC4
		public IMotorRacingSystemConfig EnableSystemAsIMotorRacingSystemConfig()
		{
			return this.EnableSystem<IMotorRacingSystemConfig>().Value;
		}

		// Token: 0x06015FC0 RID: 90048 RVA: 0x0032CDE0 File Offset: 0x0032AFE0
		public INightmareSettlementSystemConfig EnableSystemAsINightmareSettlementSystemConfig()
		{
			return this.EnableSystem<INightmareSettlementSystemConfig>().Value;
		}

		// Token: 0x06015FC1 RID: 90049 RVA: 0x0032CDFC File Offset: 0x0032AFFC
		public IRogueTowerTrialSystemConfig EnableSystemAsIRogueTowerTrialSystemConfig()
		{
			return this.EnableSystem<IRogueTowerTrialSystemConfig>().Value;
		}

		// Token: 0x06015FC2 RID: 90050 RVA: 0x0032CE18 File Offset: 0x0032B018
		public IRoleTowerSystemConfig EnableSystemAsIRoleTowerSystemConfig()
		{
			return this.EnableSystem<IRoleTowerSystemConfig>().Value;
		}

		// Token: 0x06015FC3 RID: 90051 RVA: 0x0032CE34 File Offset: 0x0032B034
		public ISurvivorsRougeSystemConfig EnableSystemAsISurvivorsRougeSystemConfig()
		{
			return this.EnableSystem<ISurvivorsRougeSystemConfig>().Value;
		}

		// Token: 0x06015FC4 RID: 90052 RVA: 0x0032CE50 File Offset: 0x0032B050
		public ITrapDefenseSystemConfig EnableSystemAsITrapDefenseSystemConfig()
		{
			return this.EnableSystem<ITrapDefenseSystemConfig>().Value;
		}

		// Token: 0x17006CCF RID: 27855
		// (get) Token: 0x06015FC5 RID: 90053 RVA: 0x0032CE6C File Offset: 0x0032B06C
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

		// Token: 0x17006CD0 RID: 27856
		// (get) Token: 0x06015FC6 RID: 90054 RVA: 0x0032CECC File Offset: 0x0032B0CC
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

		// Token: 0x17006CD1 RID: 27857
		// (get) Token: 0x06015FC7 RID: 90055 RVA: 0x0032CF2C File Offset: 0x0032B12C
		public bool DisableSwitchGender
		{
			get
			{
				int num = this.__p.__offset(60);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006CD2 RID: 27858
		// (get) Token: 0x06015FC8 RID: 90056 RVA: 0x0032CF6C File Offset: 0x0032B16C
		public bool DisableFocusMode
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006CD3 RID: 27859
		// (get) Token: 0x06015FC9 RID: 90057 RVA: 0x0032CFAC File Offset: 0x0032B1AC
		public bool DisableSkeletalAnimationCheck
		{
			get
			{
				int num = this.__p.__offset(64);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006CD4 RID: 27860
		// (get) Token: 0x06015FCA RID: 90058 RVA: 0x0032CFEC File Offset: 0x0032B1EC
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

		// Token: 0x17006CD5 RID: 27861
		// (get) Token: 0x06015FCB RID: 90059 RVA: 0x0032D04C File Offset: 0x0032B24C
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

		// Token: 0x17006CD6 RID: 27862
		// (get) Token: 0x06015FCC RID: 90060 RVA: 0x0032D0AC File Offset: 0x0032B2AC
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

		// Token: 0x17006CD7 RID: 27863
		// (get) Token: 0x06015FCD RID: 90061 RVA: 0x0032D10C File Offset: 0x0032B30C
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

		// Token: 0x17006CD8 RID: 27864
		// (get) Token: 0x06015FCE RID: 90062 RVA: 0x0032D16C File Offset: 0x0032B36C
		public bool DisableGlobalTraffic
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06015FCF RID: 90063 RVA: 0x0032D1AC File Offset: 0x0032B3AC
		public IAreaNameSystemPrompt? DisableSystemPrompt(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IAreaNameSystemPrompt?(default(IAreaNameSystemPrompt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006CD9 RID: 27865
		// (get) Token: 0x06015FD0 RID: 90064 RVA: 0x0032D210 File Offset: 0x0032B410
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

		// Token: 0x17006CDA RID: 27866
		// (get) Token: 0x06015FD1 RID: 90065 RVA: 0x0032D23C File Offset: 0x0032B43C
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

		// Token: 0x17006CDB RID: 27867
		// (get) Token: 0x06015FD2 RID: 90066 RVA: 0x0032D29C File Offset: 0x0032B49C
		public bool PendingClientResults
		{
			get
			{
				int num = this.__p.__offset(80);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06015FD3 RID: 90067 RVA: 0x0032D2DC File Offset: 0x0032B4DC
		public IConditionSelectorBtNodeSlot? Slots(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return new IConditionSelectorBtNodeSlot?(default(IConditionSelectorBtNodeSlot).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006CDC RID: 27868
		// (get) Token: 0x06015FD4 RID: 90068 RVA: 0x0032D340 File Offset: 0x0032B540
		public int SlotsLength
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

		// Token: 0x17006CDD RID: 27869
		// (get) Token: 0x06015FD5 RID: 90069 RVA: 0x0032D36C File Offset: 0x0032B56C
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015FD6 RID: 90070 RVA: 0x0032D3AC File Offset: 0x0032B5AC
		public static Offset<IConditionSelectorBtNode> CreateIConditionSelectorBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, Offset<IQuestScheduleConfig> UIConfigOffset = default(Offset<IQuestScheduleConfig>), Offset<IInformationViewConfig> InformationViewOffset = default(Offset<IInformationViewConfig>), Offset<IInformationBoardConfig> InformationBoardOffset = default(Offset<IInformationBoardConfig>), StringOffset TidQuestAliasNameOffset = default(StringOffset), StringOffset TidQuestAliasDescOffset = default(StringOffset), int DungeonId = 0, bool DisableOnline = false, Offset<ISaveConfig> SaveConfigOffset = default(Offset<ISaveConfig>), Offset<IForceClosedRestriction> ForceClosedRestrictionOffset = default(Offset<IForceClosedRestriction>), VectorOffset OccupationsOffset = default(VectorOffset), Offset<ILogicNodeOccupation> OccupationConfigOffset = default(Offset<ILogicNodeOccupation>), bool DisableSwitchOccupation = false, EBudgetCameraType BudgetCameraType = EBudgetCameraType.Role, Offset<IQuestStatistics> StatisticsOffset = default(Offset<IQuestStatistics>), ETrackViewMode CompositeTrackViewMode = ETrackViewMode.All, Offset<IQuestRewardConfig> RewardConfigOffset = default(Offset<IQuestRewardConfig>), TSpecialGamePlayConfig SpecialGamePlayConfig_type = TSpecialGamePlayConfig.NONE, int SpecialGamePlayConfigOffset = 0, TEnableSystemConfig EnableSystem_type = TEnableSystemConfig.NONE, int EnableSystemOffset = 0, Offset<IWaveConfig> StartWaveOffset = default(Offset<IWaveConfig>), Offset<IDisableTrackAnim> DisableTrackAnimOffset = default(Offset<IDisableTrackAnim>), bool DisableSwitchGender = false, bool DisableFocusMode = false, bool DisableSkeletalAnimationCheck = false, Offset<ILogicProgramSpecialProcess> LogicProgramSpecialProcessOffset = default(Offset<ILogicProgramSpecialProcess>), Offset<IQuestBuffActiveRange> QuestBuffActiveRangeOffset = default(Offset<IQuestBuffActiveRange>), Offset<ISunSpiritProcess> SunSpiritProcessOffset = default(Offset<ISunSpiritProcess>), Offset<ITrackAreaText> ModifyTrackAreaTextOffset = default(Offset<ITrackAreaText>), bool DisableGlobalTraffic = false, VectorOffset DisableSystemPromptOffset = default(VectorOffset), Offset<ITrackCustomBoardOnBtLogicNode> TrackCustomBoardOffset = default(Offset<ITrackCustomBoardOnBtLogicNode>), bool PendingClientResults = false, VectorOffset SlotsOffset = default(VectorOffset), ushort NullMask = 0)
		{
			builder.StartTable(41);
			IConditionSelectorBtNode.AddSlots(builder, SlotsOffset);
			IConditionSelectorBtNode.AddTrackCustomBoard(builder, TrackCustomBoardOffset);
			IConditionSelectorBtNode.AddDisableSystemPrompt(builder, DisableSystemPromptOffset);
			IConditionSelectorBtNode.AddModifyTrackAreaText(builder, ModifyTrackAreaTextOffset);
			IConditionSelectorBtNode.AddSunSpiritProcess(builder, SunSpiritProcessOffset);
			IConditionSelectorBtNode.AddQuestBuffActiveRange(builder, QuestBuffActiveRangeOffset);
			IConditionSelectorBtNode.AddLogicProgramSpecialProcess(builder, LogicProgramSpecialProcessOffset);
			IConditionSelectorBtNode.AddDisableTrackAnim(builder, DisableTrackAnimOffset);
			IConditionSelectorBtNode.AddStartWave(builder, StartWaveOffset);
			IConditionSelectorBtNode.AddEnableSystem(builder, EnableSystemOffset);
			IConditionSelectorBtNode.AddSpecialGamePlayConfig(builder, SpecialGamePlayConfigOffset);
			IConditionSelectorBtNode.AddRewardConfig(builder, RewardConfigOffset);
			IConditionSelectorBtNode.AddStatistics(builder, StatisticsOffset);
			IConditionSelectorBtNode.AddOccupationConfig(builder, OccupationConfigOffset);
			IConditionSelectorBtNode.AddOccupations(builder, OccupationsOffset);
			IConditionSelectorBtNode.AddForceClosedRestriction(builder, ForceClosedRestrictionOffset);
			IConditionSelectorBtNode.AddSaveConfig(builder, SaveConfigOffset);
			IConditionSelectorBtNode.AddDungeonId(builder, DungeonId);
			IConditionSelectorBtNode.AddTidQuestAliasDesc(builder, TidQuestAliasDescOffset);
			IConditionSelectorBtNode.AddTidQuestAliasName(builder, TidQuestAliasNameOffset);
			IConditionSelectorBtNode.AddInformationBoard(builder, InformationBoardOffset);
			IConditionSelectorBtNode.AddInformationView(builder, InformationViewOffset);
			IConditionSelectorBtNode.AddUIConfig(builder, UIConfigOffset);
			IConditionSelectorBtNode.AddFixProcessor(builder, FixProcessorOffset);
			IConditionSelectorBtNode.AddDesc(builder, DescOffset);
			IConditionSelectorBtNode.AddId(builder, Id);
			IConditionSelectorBtNode.AddNullMask(builder, NullMask);
			IConditionSelectorBtNode.AddPendingClientResults(builder, PendingClientResults);
			IConditionSelectorBtNode.AddDisableGlobalTraffic(builder, DisableGlobalTraffic);
			IConditionSelectorBtNode.AddDisableSkeletalAnimationCheck(builder, DisableSkeletalAnimationCheck);
			IConditionSelectorBtNode.AddDisableFocusMode(builder, DisableFocusMode);
			IConditionSelectorBtNode.AddDisableSwitchGender(builder, DisableSwitchGender);
			IConditionSelectorBtNode.AddEnableSystemType(builder, EnableSystem_type);
			IConditionSelectorBtNode.AddSpecialGamePlayConfigType(builder, SpecialGamePlayConfig_type);
			IConditionSelectorBtNode.AddCompositeTrackViewMode(builder, CompositeTrackViewMode);
			IConditionSelectorBtNode.AddBudgetCameraType(builder, BudgetCameraType);
			IConditionSelectorBtNode.AddDisableSwitchOccupation(builder, DisableSwitchOccupation);
			IConditionSelectorBtNode.AddDisableOnline(builder, DisableOnline);
			IConditionSelectorBtNode.AddDisabled(builder, Disabled);
			IConditionSelectorBtNode.Add_FoldedForTree(builder, _foldedForTree);
			IConditionSelectorBtNode.AddType(builder, Type);
			return IConditionSelectorBtNode.EndIConditionSelectorBtNode(builder);
		}

		// Token: 0x06015FD7 RID: 90071 RVA: 0x0032D50C File Offset: 0x0032B70C
		public static void StartIConditionSelectorBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(41);
		}

		// Token: 0x06015FD8 RID: 90072 RVA: 0x0032D516 File Offset: 0x0032B716
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015FD9 RID: 90073 RVA: 0x0032D521 File Offset: 0x0032B721
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06015FDA RID: 90074 RVA: 0x0032D52C File Offset: 0x0032B72C
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06015FDB RID: 90075 RVA: 0x0032D53C File Offset: 0x0032B73C
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06015FDC RID: 90076 RVA: 0x0032D54C File Offset: 0x0032B74C
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06015FDD RID: 90077 RVA: 0x0032D557 File Offset: 0x0032B757
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06015FDE RID: 90078 RVA: 0x0032D562 File Offset: 0x0032B762
		public static void AddUIConfig(FlatBufferBuilder builder, Offset<IQuestScheduleConfig> uIConfigOffset)
		{
			builder.AddOffset(6, uIConfigOffset.Value, 0);
		}

		// Token: 0x06015FDF RID: 90079 RVA: 0x0032D572 File Offset: 0x0032B772
		public static void AddInformationView(FlatBufferBuilder builder, Offset<IInformationViewConfig> informationViewOffset)
		{
			builder.AddOffset(7, informationViewOffset.Value, 0);
		}

		// Token: 0x06015FE0 RID: 90080 RVA: 0x0032D582 File Offset: 0x0032B782
		public static void AddInformationBoard(FlatBufferBuilder builder, Offset<IInformationBoardConfig> informationBoardOffset)
		{
			builder.AddOffset(8, informationBoardOffset.Value, 0);
		}

		// Token: 0x06015FE1 RID: 90081 RVA: 0x0032D592 File Offset: 0x0032B792
		public static void AddTidQuestAliasName(FlatBufferBuilder builder, StringOffset tidQuestAliasNameOffset)
		{
			builder.AddOffset(9, tidQuestAliasNameOffset.Value, 0);
		}

		// Token: 0x06015FE2 RID: 90082 RVA: 0x0032D5A3 File Offset: 0x0032B7A3
		public static void AddTidQuestAliasDesc(FlatBufferBuilder builder, StringOffset tidQuestAliasDescOffset)
		{
			builder.AddOffset(10, tidQuestAliasDescOffset.Value, 0);
		}

		// Token: 0x06015FE3 RID: 90083 RVA: 0x0032D5B4 File Offset: 0x0032B7B4
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(11, dungeonId, 0);
		}

		// Token: 0x06015FE4 RID: 90084 RVA: 0x0032D5C0 File Offset: 0x0032B7C0
		public static void AddDisableOnline(FlatBufferBuilder builder, bool disableOnline)
		{
			builder.AddBool(12, disableOnline, false);
		}

		// Token: 0x06015FE5 RID: 90085 RVA: 0x0032D5CC File Offset: 0x0032B7CC
		public static void AddSaveConfig(FlatBufferBuilder builder, Offset<ISaveConfig> saveConfigOffset)
		{
			builder.AddOffset(13, saveConfigOffset.Value, 0);
		}

		// Token: 0x06015FE6 RID: 90086 RVA: 0x0032D5DD File Offset: 0x0032B7DD
		public static void AddForceClosedRestriction(FlatBufferBuilder builder, Offset<IForceClosedRestriction> forceClosedRestrictionOffset)
		{
			builder.AddOffset(14, forceClosedRestrictionOffset.Value, 0);
		}

		// Token: 0x06015FE7 RID: 90087 RVA: 0x0032D5EE File Offset: 0x0032B7EE
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(15, occupationsOffset.Value, 0);
		}

		// Token: 0x06015FE8 RID: 90088 RVA: 0x0032D600 File Offset: 0x0032B800
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06015FE9 RID: 90089 RVA: 0x0032D640 File Offset: 0x0032B840
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06015FEA RID: 90090 RVA: 0x0032D65A File Offset: 0x0032B85A
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06015FEB RID: 90091 RVA: 0x0032D678 File Offset: 0x0032B878
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015FEC RID: 90092 RVA: 0x0032D691 File Offset: 0x0032B891
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015FED RID: 90093 RVA: 0x0032D69C File Offset: 0x0032B89C
		public static void AddOccupationConfig(FlatBufferBuilder builder, Offset<ILogicNodeOccupation> occupationConfigOffset)
		{
			builder.AddOffset(16, occupationConfigOffset.Value, 0);
		}

		// Token: 0x06015FEE RID: 90094 RVA: 0x0032D6AD File Offset: 0x0032B8AD
		public static void AddDisableSwitchOccupation(FlatBufferBuilder builder, bool disableSwitchOccupation)
		{
			builder.AddBool(17, disableSwitchOccupation, false);
		}

		// Token: 0x06015FEF RID: 90095 RVA: 0x0032D6B9 File Offset: 0x0032B8B9
		public static void AddBudgetCameraType(FlatBufferBuilder builder, EBudgetCameraType budgetCameraType)
		{
			builder.AddByte(18, (byte)budgetCameraType, 0);
		}

		// Token: 0x06015FF0 RID: 90096 RVA: 0x0032D6C5 File Offset: 0x0032B8C5
		public static void AddStatistics(FlatBufferBuilder builder, Offset<IQuestStatistics> statisticsOffset)
		{
			builder.AddOffset(19, statisticsOffset.Value, 0);
		}

		// Token: 0x06015FF1 RID: 90097 RVA: 0x0032D6D6 File Offset: 0x0032B8D6
		public static void AddCompositeTrackViewMode(FlatBufferBuilder builder, ETrackViewMode compositeTrackViewMode)
		{
			builder.AddByte(20, (byte)compositeTrackViewMode, 0);
		}

		// Token: 0x06015FF2 RID: 90098 RVA: 0x0032D6E2 File Offset: 0x0032B8E2
		public static void AddRewardConfig(FlatBufferBuilder builder, Offset<IQuestRewardConfig> rewardConfigOffset)
		{
			builder.AddOffset(21, rewardConfigOffset.Value, 0);
		}

		// Token: 0x06015FF3 RID: 90099 RVA: 0x0032D6F3 File Offset: 0x0032B8F3
		public static void AddSpecialGamePlayConfigType(FlatBufferBuilder builder, TSpecialGamePlayConfig specialGamePlayConfigType)
		{
			builder.AddByte(22, (byte)specialGamePlayConfigType, 0);
		}

		// Token: 0x06015FF4 RID: 90100 RVA: 0x0032D6FF File Offset: 0x0032B8FF
		public static void AddSpecialGamePlayConfig(FlatBufferBuilder builder, int specialGamePlayConfigOffset)
		{
			builder.AddOffset(23, specialGamePlayConfigOffset, 0);
		}

		// Token: 0x06015FF5 RID: 90101 RVA: 0x0032D70B File Offset: 0x0032B90B
		public static void AddEnableSystemType(FlatBufferBuilder builder, TEnableSystemConfig enableSystemType)
		{
			builder.AddByte(24, (byte)enableSystemType, 0);
		}

		// Token: 0x06015FF6 RID: 90102 RVA: 0x0032D717 File Offset: 0x0032B917
		public static void AddEnableSystem(FlatBufferBuilder builder, int enableSystemOffset)
		{
			builder.AddOffset(25, enableSystemOffset, 0);
		}

		// Token: 0x06015FF7 RID: 90103 RVA: 0x0032D723 File Offset: 0x0032B923
		public static void AddStartWave(FlatBufferBuilder builder, Offset<IWaveConfig> startWaveOffset)
		{
			builder.AddOffset(26, startWaveOffset.Value, 0);
		}

		// Token: 0x06015FF8 RID: 90104 RVA: 0x0032D734 File Offset: 0x0032B934
		public static void AddDisableTrackAnim(FlatBufferBuilder builder, Offset<IDisableTrackAnim> disableTrackAnimOffset)
		{
			builder.AddOffset(27, disableTrackAnimOffset.Value, 0);
		}

		// Token: 0x06015FF9 RID: 90105 RVA: 0x0032D745 File Offset: 0x0032B945
		public static void AddDisableSwitchGender(FlatBufferBuilder builder, bool disableSwitchGender)
		{
			builder.AddBool(28, disableSwitchGender, false);
		}

		// Token: 0x06015FFA RID: 90106 RVA: 0x0032D751 File Offset: 0x0032B951
		public static void AddDisableFocusMode(FlatBufferBuilder builder, bool disableFocusMode)
		{
			builder.AddBool(29, disableFocusMode, false);
		}

		// Token: 0x06015FFB RID: 90107 RVA: 0x0032D75D File Offset: 0x0032B95D
		public static void AddDisableSkeletalAnimationCheck(FlatBufferBuilder builder, bool disableSkeletalAnimationCheck)
		{
			builder.AddBool(30, disableSkeletalAnimationCheck, false);
		}

		// Token: 0x06015FFC RID: 90108 RVA: 0x0032D769 File Offset: 0x0032B969
		public static void AddLogicProgramSpecialProcess(FlatBufferBuilder builder, Offset<ILogicProgramSpecialProcess> logicProgramSpecialProcessOffset)
		{
			builder.AddOffset(31, logicProgramSpecialProcessOffset.Value, 0);
		}

		// Token: 0x06015FFD RID: 90109 RVA: 0x0032D77A File Offset: 0x0032B97A
		public static void AddQuestBuffActiveRange(FlatBufferBuilder builder, Offset<IQuestBuffActiveRange> questBuffActiveRangeOffset)
		{
			builder.AddOffset(32, questBuffActiveRangeOffset.Value, 0);
		}

		// Token: 0x06015FFE RID: 90110 RVA: 0x0032D78B File Offset: 0x0032B98B
		public static void AddSunSpiritProcess(FlatBufferBuilder builder, Offset<ISunSpiritProcess> sunSpiritProcessOffset)
		{
			builder.AddOffset(33, sunSpiritProcessOffset.Value, 0);
		}

		// Token: 0x06015FFF RID: 90111 RVA: 0x0032D79C File Offset: 0x0032B99C
		public static void AddModifyTrackAreaText(FlatBufferBuilder builder, Offset<ITrackAreaText> modifyTrackAreaTextOffset)
		{
			builder.AddOffset(34, modifyTrackAreaTextOffset.Value, 0);
		}

		// Token: 0x06016000 RID: 90112 RVA: 0x0032D7AD File Offset: 0x0032B9AD
		public static void AddDisableGlobalTraffic(FlatBufferBuilder builder, bool disableGlobalTraffic)
		{
			builder.AddBool(35, disableGlobalTraffic, false);
		}

		// Token: 0x06016001 RID: 90113 RVA: 0x0032D7B9 File Offset: 0x0032B9B9
		public static void AddDisableSystemPrompt(FlatBufferBuilder builder, VectorOffset disableSystemPromptOffset)
		{
			builder.AddOffset(36, disableSystemPromptOffset.Value, 0);
		}

		// Token: 0x06016002 RID: 90114 RVA: 0x0032D7CC File Offset: 0x0032B9CC
		public static VectorOffset CreateDisableSystemPromptVector(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016003 RID: 90115 RVA: 0x0032D80C File Offset: 0x0032BA0C
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016004 RID: 90116 RVA: 0x0032D826 File Offset: 0x0032BA26
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAreaNameSystemPrompt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016005 RID: 90117 RVA: 0x0032D844 File Offset: 0x0032BA44
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAreaNameSystemPrompt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016006 RID: 90118 RVA: 0x0032D85D File Offset: 0x0032BA5D
		public static void StartDisableSystemPromptVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016007 RID: 90119 RVA: 0x0032D868 File Offset: 0x0032BA68
		public static void AddTrackCustomBoard(FlatBufferBuilder builder, Offset<ITrackCustomBoardOnBtLogicNode> trackCustomBoardOffset)
		{
			builder.AddOffset(37, trackCustomBoardOffset.Value, 0);
		}

		// Token: 0x06016008 RID: 90120 RVA: 0x0032D879 File Offset: 0x0032BA79
		public static void AddPendingClientResults(FlatBufferBuilder builder, bool pendingClientResults)
		{
			builder.AddBool(38, pendingClientResults, false);
		}

		// Token: 0x06016009 RID: 90121 RVA: 0x0032D885 File Offset: 0x0032BA85
		public static void AddSlots(FlatBufferBuilder builder, VectorOffset slotsOffset)
		{
			builder.AddOffset(39, slotsOffset.Value, 0);
		}

		// Token: 0x0601600A RID: 90122 RVA: 0x0032D898 File Offset: 0x0032BA98
		public static VectorOffset CreateSlotsVector(FlatBufferBuilder builder, Offset<IConditionSelectorBtNodeSlot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601600B RID: 90123 RVA: 0x0032D8D8 File Offset: 0x0032BAD8
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, Offset<IConditionSelectorBtNodeSlot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionSelectorBtNodeSlot>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601600C RID: 90124 RVA: 0x0032D8F2 File Offset: 0x0032BAF2
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionSelectorBtNodeSlot>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionSelectorBtNodeSlot>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601600D RID: 90125 RVA: 0x0032D910 File Offset: 0x0032BB10
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionSelectorBtNodeSlot>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601600E RID: 90126 RVA: 0x0032D929 File Offset: 0x0032BB29
		public static void StartSlotsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601600F RID: 90127 RVA: 0x0032D934 File Offset: 0x0032BB34
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(40, nullMask, 0);
		}

		// Token: 0x06016010 RID: 90128 RVA: 0x0032D940 File Offset: 0x0032BB40
		public static Offset<IConditionSelectorBtNode> EndIConditionSelectorBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IConditionSelectorBtNode>(builder.EndTable());
		}

		// Token: 0x06016011 RID: 90129 RVA: 0x0032D950 File Offset: 0x0032BB50
		public IConditionSelectorBtNodeT UnPack()
		{
			IConditionSelectorBtNodeT conditionSelectorBtNodeT = new IConditionSelectorBtNodeT();
			this.UnPackTo(conditionSelectorBtNodeT);
			return conditionSelectorBtNodeT;
		}

		// Token: 0x06016012 RID: 90130 RVA: 0x0032D96C File Offset: 0x0032BB6C
		public void UnPackTo(IConditionSelectorBtNodeT _o)
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
			_o.PendingClientResults = this.PendingClientResults;
			_o.Slots = new List<IConditionSelectorBtNodeSlotT>();
			for (int k = 0; k < this.SlotsLength; k++)
			{
				_o.Slots.Add((this.Slots(k) != null) ? this.Slots(k).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016013 RID: 90131 RVA: 0x0032E324 File Offset: 0x0032C524
		public static Offset<IConditionSelectorBtNode> Pack(FlatBufferBuilder builder, IConditionSelectorBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionSelectorBtNode>);
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
				occupationsOffset = IConditionSelectorBtNode.CreateOccupationsVector(builder, array);
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
				disableSystemPromptOffset = IConditionSelectorBtNode.CreateDisableSystemPromptVector(builder, array2);
			}
			Offset<ITrackCustomBoardOnBtLogicNode> trackCustomBoardOffset = (_o.TrackCustomBoard == null) ? default(Offset<ITrackCustomBoardOnBtLogicNode>) : ITrackCustomBoardOnBtLogicNode.Pack(builder, _o.TrackCustomBoard);
			VectorOffset slotsOffset = default(VectorOffset);
			if (_o.Slots != null)
			{
				Offset<IConditionSelectorBtNodeSlot>[] array3 = new Offset<IConditionSelectorBtNodeSlot>[_o.Slots.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IConditionSelectorBtNodeSlot.Pack(builder, _o.Slots[k]);
				}
				slotsOffset = IConditionSelectorBtNode.CreateSlotsVector(builder, array3);
			}
			return IConditionSelectorBtNode.CreateIConditionSelectorBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, uiconfigOffset, informationViewOffset, informationBoardOffset, tidQuestAliasNameOffset, tidQuestAliasDescOffset, _o.DungeonId, _o.DisableOnline, saveConfigOffset, forceClosedRestrictionOffset, occupationsOffset, occupationConfigOffset, _o.DisableSwitchOccupation, _o.BudgetCameraType, statisticsOffset, _o.CompositeTrackViewMode, rewardConfigOffset, specialGamePlayConfig_type, specialGamePlayConfigOffset, enableSystem_type, enableSystemOffset, startWaveOffset, disableTrackAnimOffset, _o.DisableSwitchGender, _o.DisableFocusMode, _o.DisableSkeletalAnimationCheck, logicProgramSpecialProcessOffset, questBuffActiveRangeOffset, sunSpiritProcessOffset, modifyTrackAreaTextOffset, _o.DisableGlobalTraffic, disableSystemPromptOffset, trackCustomBoardOffset, _o.PendingClientResults, slotsOffset, _o.NullMask);
		}

		// Token: 0x0400B6CA RID: 46794
		private Table __p;
	}
}
