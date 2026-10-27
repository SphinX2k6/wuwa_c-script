using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042CD RID: 17101
	public class TEnableSystemConfigUnion
	{
		// Token: 0x17007940 RID: 31040
		// (get) Token: 0x060195CD RID: 103885 RVA: 0x003A3A2E File Offset: 0x003A1C2E
		// (set) Token: 0x060195CE RID: 103886 RVA: 0x003A3A36 File Offset: 0x003A1C36
		public TEnableSystemConfig Type { get; set; }

		// Token: 0x17007941 RID: 31041
		// (get) Token: 0x060195CF RID: 103887 RVA: 0x003A3A3F File Offset: 0x003A1C3F
		// (set) Token: 0x060195D0 RID: 103888 RVA: 0x003A3A47 File Offset: 0x003A1C47
		public object Value { get; set; }

		// Token: 0x060195D1 RID: 103889 RVA: 0x003A3A50 File Offset: 0x003A1C50
		public TEnableSystemConfigUnion()
		{
			this.Type = TEnableSystemConfig.NONE;
			this.Value = null;
		}

		// Token: 0x060195D2 RID: 103890 RVA: 0x003A3A66 File Offset: 0x003A1C66
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060195D3 RID: 103891 RVA: 0x003A3A78 File Offset: 0x003A1C78
		public IFlagChallengeSystemConfigT AsIFlagChallengeSystemConfig()
		{
			return this.As<IFlagChallengeSystemConfigT>();
		}

		// Token: 0x060195D4 RID: 103892 RVA: 0x003A3A80 File Offset: 0x003A1C80
		public static TEnableSystemConfigUnion FromIFlagChallengeSystemConfig(IFlagChallengeSystemConfigT _iflagchallengesystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IFlagChallengeSystemConfig,
				Value = _iflagchallengesystemconfig
			};
		}

		// Token: 0x060195D5 RID: 103893 RVA: 0x003A3A95 File Offset: 0x003A1C95
		public IFlipperSystemConfigT AsIFlipperSystemConfig()
		{
			return this.As<IFlipperSystemConfigT>();
		}

		// Token: 0x060195D6 RID: 103894 RVA: 0x003A3A9D File Offset: 0x003A1C9D
		public static TEnableSystemConfigUnion FromIFlipperSystemConfig(IFlipperSystemConfigT _iflippersystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IFlipperSystemConfig,
				Value = _iflippersystemconfig
			};
		}

		// Token: 0x060195D7 RID: 103895 RVA: 0x003A3AB2 File Offset: 0x003A1CB2
		public IGameDifficultySystemConfigT AsIGameDifficultySystemConfig()
		{
			return this.As<IGameDifficultySystemConfigT>();
		}

		// Token: 0x060195D8 RID: 103896 RVA: 0x003A3ABA File Offset: 0x003A1CBA
		public static TEnableSystemConfigUnion FromIGameDifficultySystemConfig(IGameDifficultySystemConfigT _igamedifficultysystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IGameDifficultySystemConfig,
				Value = _igamedifficultysystemconfig
			};
		}

		// Token: 0x060195D9 RID: 103897 RVA: 0x003A3ACF File Offset: 0x003A1CCF
		public IGradingSystemConfigT AsIGradingSystemConfig()
		{
			return this.As<IGradingSystemConfigT>();
		}

		// Token: 0x060195DA RID: 103898 RVA: 0x003A3AD7 File Offset: 0x003A1CD7
		public static TEnableSystemConfigUnion FromIGradingSystemConfig(IGradingSystemConfigT _igradingsystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IGradingSystemConfig,
				Value = _igradingsystemconfig
			};
		}

		// Token: 0x060195DB RID: 103899 RVA: 0x003A3AEC File Offset: 0x003A1CEC
		public IKuroSimpleCombatKillMonsterSystemConfigT AsIKuroSimpleCombatKillMonsterSystemConfig()
		{
			return this.As<IKuroSimpleCombatKillMonsterSystemConfigT>();
		}

		// Token: 0x060195DC RID: 103900 RVA: 0x003A3AF4 File Offset: 0x003A1CF4
		public static TEnableSystemConfigUnion FromIKuroSimpleCombatKillMonsterSystemConfig(IKuroSimpleCombatKillMonsterSystemConfigT _ikurosimplecombatkillmonstersystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IKuroSimpleCombatKillMonsterSystemConfig,
				Value = _ikurosimplecombatkillmonstersystemconfig
			};
		}

		// Token: 0x060195DD RID: 103901 RVA: 0x003A3B09 File Offset: 0x003A1D09
		public IKurotatoSystemConfigT AsIKurotatoSystemConfig()
		{
			return this.As<IKurotatoSystemConfigT>();
		}

		// Token: 0x060195DE RID: 103902 RVA: 0x003A3B11 File Offset: 0x003A1D11
		public static TEnableSystemConfigUnion FromIKurotatoSystemConfig(IKurotatoSystemConfigT _ikurotatosystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IKurotatoSystemConfig,
				Value = _ikurotatosystemconfig
			};
		}

		// Token: 0x060195DF RID: 103903 RVA: 0x003A3B26 File Offset: 0x003A1D26
		public ILinkSystemConfigT AsILinkSystemConfig()
		{
			return this.As<ILinkSystemConfigT>();
		}

		// Token: 0x060195E0 RID: 103904 RVA: 0x003A3B2E File Offset: 0x003A1D2E
		public static TEnableSystemConfigUnion FromILinkSystemConfig(ILinkSystemConfigT _ilinksystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.ILinkSystemConfig,
				Value = _ilinksystemconfig
			};
		}

		// Token: 0x060195E1 RID: 103905 RVA: 0x003A3B43 File Offset: 0x003A1D43
		public IMotorFightSystemConfigT AsIMotorFightSystemConfig()
		{
			return this.As<IMotorFightSystemConfigT>();
		}

		// Token: 0x060195E2 RID: 103906 RVA: 0x003A3B4B File Offset: 0x003A1D4B
		public static TEnableSystemConfigUnion FromIMotorFightSystemConfig(IMotorFightSystemConfigT _imotorfightsystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IMotorFightSystemConfig,
				Value = _imotorfightsystemconfig
			};
		}

		// Token: 0x060195E3 RID: 103907 RVA: 0x003A3B60 File Offset: 0x003A1D60
		public IMotorRacingSystemConfigT AsIMotorRacingSystemConfig()
		{
			return this.As<IMotorRacingSystemConfigT>();
		}

		// Token: 0x060195E4 RID: 103908 RVA: 0x003A3B68 File Offset: 0x003A1D68
		public static TEnableSystemConfigUnion FromIMotorRacingSystemConfig(IMotorRacingSystemConfigT _imotorracingsystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IMotorRacingSystemConfig,
				Value = _imotorracingsystemconfig
			};
		}

		// Token: 0x060195E5 RID: 103909 RVA: 0x003A3B7E File Offset: 0x003A1D7E
		public INightmareSettlementSystemConfigT AsINightmareSettlementSystemConfig()
		{
			return this.As<INightmareSettlementSystemConfigT>();
		}

		// Token: 0x060195E6 RID: 103910 RVA: 0x003A3B86 File Offset: 0x003A1D86
		public static TEnableSystemConfigUnion FromINightmareSettlementSystemConfig(INightmareSettlementSystemConfigT _inightmaresettlementsystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.INightmareSettlementSystemConfig,
				Value = _inightmaresettlementsystemconfig
			};
		}

		// Token: 0x060195E7 RID: 103911 RVA: 0x003A3B9C File Offset: 0x003A1D9C
		public IRogueTowerTrialSystemConfigT AsIRogueTowerTrialSystemConfig()
		{
			return this.As<IRogueTowerTrialSystemConfigT>();
		}

		// Token: 0x060195E8 RID: 103912 RVA: 0x003A3BA4 File Offset: 0x003A1DA4
		public static TEnableSystemConfigUnion FromIRogueTowerTrialSystemConfig(IRogueTowerTrialSystemConfigT _iroguetowertrialsystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IRogueTowerTrialSystemConfig,
				Value = _iroguetowertrialsystemconfig
			};
		}

		// Token: 0x060195E9 RID: 103913 RVA: 0x003A3BBA File Offset: 0x003A1DBA
		public IRoleTowerSystemConfigT AsIRoleTowerSystemConfig()
		{
			return this.As<IRoleTowerSystemConfigT>();
		}

		// Token: 0x060195EA RID: 103914 RVA: 0x003A3BC2 File Offset: 0x003A1DC2
		public static TEnableSystemConfigUnion FromIRoleTowerSystemConfig(IRoleTowerSystemConfigT _iroletowersystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IRoleTowerSystemConfig,
				Value = _iroletowersystemconfig
			};
		}

		// Token: 0x060195EB RID: 103915 RVA: 0x003A3BD8 File Offset: 0x003A1DD8
		public ISurvivorsRougeSystemConfigT AsISurvivorsRougeSystemConfig()
		{
			return this.As<ISurvivorsRougeSystemConfigT>();
		}

		// Token: 0x060195EC RID: 103916 RVA: 0x003A3BE0 File Offset: 0x003A1DE0
		public static TEnableSystemConfigUnion FromISurvivorsRougeSystemConfig(ISurvivorsRougeSystemConfigT _isurvivorsrougesystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.ISurvivorsRougeSystemConfig,
				Value = _isurvivorsrougesystemconfig
			};
		}

		// Token: 0x060195ED RID: 103917 RVA: 0x003A3BF6 File Offset: 0x003A1DF6
		public ITrapDefenseSystemConfigT AsITrapDefenseSystemConfig()
		{
			return this.As<ITrapDefenseSystemConfigT>();
		}

		// Token: 0x060195EE RID: 103918 RVA: 0x003A3BFE File Offset: 0x003A1DFE
		public static TEnableSystemConfigUnion FromITrapDefenseSystemConfig(ITrapDefenseSystemConfigT _itrapdefensesystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.ITrapDefenseSystemConfig,
				Value = _itrapdefensesystemconfig
			};
		}

		// Token: 0x060195EF RID: 103919 RVA: 0x003A3C14 File Offset: 0x003A1E14
		public static int Pack(FlatBufferBuilder builder, TEnableSystemConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TEnableSystemConfig.IFlagChallengeSystemConfig:
				return IFlagChallengeSystemConfig.Pack(builder, _o.AsIFlagChallengeSystemConfig()).Value;
			case TEnableSystemConfig.IFlipperSystemConfig:
				return IFlipperSystemConfig.Pack(builder, _o.AsIFlipperSystemConfig()).Value;
			case TEnableSystemConfig.IGameDifficultySystemConfig:
				return IGameDifficultySystemConfig.Pack(builder, _o.AsIGameDifficultySystemConfig()).Value;
			case TEnableSystemConfig.IGradingSystemConfig:
				return IGradingSystemConfig.Pack(builder, _o.AsIGradingSystemConfig()).Value;
			case TEnableSystemConfig.IKuroSimpleCombatKillMonsterSystemConfig:
				return IKuroSimpleCombatKillMonsterSystemConfig.Pack(builder, _o.AsIKuroSimpleCombatKillMonsterSystemConfig()).Value;
			case TEnableSystemConfig.IKurotatoSystemConfig:
				return IKurotatoSystemConfig.Pack(builder, _o.AsIKurotatoSystemConfig()).Value;
			case TEnableSystemConfig.ILinkSystemConfig:
				return ILinkSystemConfig.Pack(builder, _o.AsILinkSystemConfig()).Value;
			case TEnableSystemConfig.IMotorFightSystemConfig:
				return IMotorFightSystemConfig.Pack(builder, _o.AsIMotorFightSystemConfig()).Value;
			case TEnableSystemConfig.IMotorRacingSystemConfig:
				return IMotorRacingSystemConfig.Pack(builder, _o.AsIMotorRacingSystemConfig()).Value;
			case TEnableSystemConfig.INightmareSettlementSystemConfig:
				return INightmareSettlementSystemConfig.Pack(builder, _o.AsINightmareSettlementSystemConfig()).Value;
			case TEnableSystemConfig.IRogueTowerTrialSystemConfig:
				return IRogueTowerTrialSystemConfig.Pack(builder, _o.AsIRogueTowerTrialSystemConfig()).Value;
			case TEnableSystemConfig.IRoleTowerSystemConfig:
				return IRoleTowerSystemConfig.Pack(builder, _o.AsIRoleTowerSystemConfig()).Value;
			case TEnableSystemConfig.ISurvivorsRougeSystemConfig:
				return ISurvivorsRougeSystemConfig.Pack(builder, _o.AsISurvivorsRougeSystemConfig()).Value;
			case TEnableSystemConfig.ITrapDefenseSystemConfig:
				return ITrapDefenseSystemConfig.Pack(builder, _o.AsITrapDefenseSystemConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
