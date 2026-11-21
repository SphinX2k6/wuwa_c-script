using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200472C RID: 18220
	public class TEnableSystemConfigUnion
	{
		// Token: 0x17007F73 RID: 32627
		// (get) Token: 0x0601AD4D RID: 109901 RVA: 0x003CF316 File Offset: 0x003CD516
		// (set) Token: 0x0601AD4E RID: 109902 RVA: 0x003CF31E File Offset: 0x003CD51E
		public TEnableSystemConfig Type { get; set; }

		// Token: 0x17007F74 RID: 32628
		// (get) Token: 0x0601AD4F RID: 109903 RVA: 0x003CF327 File Offset: 0x003CD527
		// (set) Token: 0x0601AD50 RID: 109904 RVA: 0x003CF32F File Offset: 0x003CD52F
		public object Value { get; set; }

		// Token: 0x0601AD51 RID: 109905 RVA: 0x003CF338 File Offset: 0x003CD538
		public TEnableSystemConfigUnion()
		{
			this.Type = TEnableSystemConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0601AD52 RID: 109906 RVA: 0x003CF34E File Offset: 0x003CD54E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AD53 RID: 109907 RVA: 0x003CF360 File Offset: 0x003CD560
		public IDarkTideSystemConfigT AsIDarkTideSystemConfig()
		{
			return this.As<IDarkTideSystemConfigT>();
		}

		// Token: 0x0601AD54 RID: 109908 RVA: 0x003CF368 File Offset: 0x003CD568
		public static TEnableSystemConfigUnion FromIDarkTideSystemConfig(IDarkTideSystemConfigT _idarktidesystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IDarkTideSystemConfig,
				Value = _idarktidesystemconfig
			};
		}

		// Token: 0x0601AD55 RID: 109909 RVA: 0x003CF37D File Offset: 0x003CD57D
		public IFlagChallengeSystemConfigT AsIFlagChallengeSystemConfig()
		{
			return this.As<IFlagChallengeSystemConfigT>();
		}

		// Token: 0x0601AD56 RID: 109910 RVA: 0x003CF385 File Offset: 0x003CD585
		public static TEnableSystemConfigUnion FromIFlagChallengeSystemConfig(IFlagChallengeSystemConfigT _iflagchallengesystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IFlagChallengeSystemConfig,
				Value = _iflagchallengesystemconfig
			};
		}

		// Token: 0x0601AD57 RID: 109911 RVA: 0x003CF39A File Offset: 0x003CD59A
		public IFlipperSystemConfigT AsIFlipperSystemConfig()
		{
			return this.As<IFlipperSystemConfigT>();
		}

		// Token: 0x0601AD58 RID: 109912 RVA: 0x003CF3A2 File Offset: 0x003CD5A2
		public static TEnableSystemConfigUnion FromIFlipperSystemConfig(IFlipperSystemConfigT _iflippersystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IFlipperSystemConfig,
				Value = _iflippersystemconfig
			};
		}

		// Token: 0x0601AD59 RID: 109913 RVA: 0x003CF3B7 File Offset: 0x003CD5B7
		public IGameDifficultySystemConfigT AsIGameDifficultySystemConfig()
		{
			return this.As<IGameDifficultySystemConfigT>();
		}

		// Token: 0x0601AD5A RID: 109914 RVA: 0x003CF3BF File Offset: 0x003CD5BF
		public static TEnableSystemConfigUnion FromIGameDifficultySystemConfig(IGameDifficultySystemConfigT _igamedifficultysystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IGameDifficultySystemConfig,
				Value = _igamedifficultysystemconfig
			};
		}

		// Token: 0x0601AD5B RID: 109915 RVA: 0x003CF3D4 File Offset: 0x003CD5D4
		public IGradingSystemConfigT AsIGradingSystemConfig()
		{
			return this.As<IGradingSystemConfigT>();
		}

		// Token: 0x0601AD5C RID: 109916 RVA: 0x003CF3DC File Offset: 0x003CD5DC
		public static TEnableSystemConfigUnion FromIGradingSystemConfig(IGradingSystemConfigT _igradingsystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IGradingSystemConfig,
				Value = _igradingsystemconfig
			};
		}

		// Token: 0x0601AD5D RID: 109917 RVA: 0x003CF3F1 File Offset: 0x003CD5F1
		public IKuroSimpleCombatKillMonsterSystemConfigT AsIKuroSimpleCombatKillMonsterSystemConfig()
		{
			return this.As<IKuroSimpleCombatKillMonsterSystemConfigT>();
		}

		// Token: 0x0601AD5E RID: 109918 RVA: 0x003CF3F9 File Offset: 0x003CD5F9
		public static TEnableSystemConfigUnion FromIKuroSimpleCombatKillMonsterSystemConfig(IKuroSimpleCombatKillMonsterSystemConfigT _ikurosimplecombatkillmonstersystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IKuroSimpleCombatKillMonsterSystemConfig,
				Value = _ikurosimplecombatkillmonstersystemconfig
			};
		}

		// Token: 0x0601AD5F RID: 109919 RVA: 0x003CF40E File Offset: 0x003CD60E
		public IKurotatoSystemConfigT AsIKurotatoSystemConfig()
		{
			return this.As<IKurotatoSystemConfigT>();
		}

		// Token: 0x0601AD60 RID: 109920 RVA: 0x003CF416 File Offset: 0x003CD616
		public static TEnableSystemConfigUnion FromIKurotatoSystemConfig(IKurotatoSystemConfigT _ikurotatosystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IKurotatoSystemConfig,
				Value = _ikurotatosystemconfig
			};
		}

		// Token: 0x0601AD61 RID: 109921 RVA: 0x003CF42B File Offset: 0x003CD62B
		public ILinkSystemConfigT AsILinkSystemConfig()
		{
			return this.As<ILinkSystemConfigT>();
		}

		// Token: 0x0601AD62 RID: 109922 RVA: 0x003CF433 File Offset: 0x003CD633
		public static TEnableSystemConfigUnion FromILinkSystemConfig(ILinkSystemConfigT _ilinksystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.ILinkSystemConfig,
				Value = _ilinksystemconfig
			};
		}

		// Token: 0x0601AD63 RID: 109923 RVA: 0x003CF448 File Offset: 0x003CD648
		public IMotorFightSystemConfigT AsIMotorFightSystemConfig()
		{
			return this.As<IMotorFightSystemConfigT>();
		}

		// Token: 0x0601AD64 RID: 109924 RVA: 0x003CF450 File Offset: 0x003CD650
		public static TEnableSystemConfigUnion FromIMotorFightSystemConfig(IMotorFightSystemConfigT _imotorfightsystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IMotorFightSystemConfig,
				Value = _imotorfightsystemconfig
			};
		}

		// Token: 0x0601AD65 RID: 109925 RVA: 0x003CF466 File Offset: 0x003CD666
		public IMotorRacingSystemConfigT AsIMotorRacingSystemConfig()
		{
			return this.As<IMotorRacingSystemConfigT>();
		}

		// Token: 0x0601AD66 RID: 109926 RVA: 0x003CF46E File Offset: 0x003CD66E
		public static TEnableSystemConfigUnion FromIMotorRacingSystemConfig(IMotorRacingSystemConfigT _imotorracingsystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IMotorRacingSystemConfig,
				Value = _imotorracingsystemconfig
			};
		}

		// Token: 0x0601AD67 RID: 109927 RVA: 0x003CF484 File Offset: 0x003CD684
		public INightmareSettlementSystemConfigT AsINightmareSettlementSystemConfig()
		{
			return this.As<INightmareSettlementSystemConfigT>();
		}

		// Token: 0x0601AD68 RID: 109928 RVA: 0x003CF48C File Offset: 0x003CD68C
		public static TEnableSystemConfigUnion FromINightmareSettlementSystemConfig(INightmareSettlementSystemConfigT _inightmaresettlementsystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.INightmareSettlementSystemConfig,
				Value = _inightmaresettlementsystemconfig
			};
		}

		// Token: 0x0601AD69 RID: 109929 RVA: 0x003CF4A2 File Offset: 0x003CD6A2
		public IRogueTowerTrialSystemConfigT AsIRogueTowerTrialSystemConfig()
		{
			return this.As<IRogueTowerTrialSystemConfigT>();
		}

		// Token: 0x0601AD6A RID: 109930 RVA: 0x003CF4AA File Offset: 0x003CD6AA
		public static TEnableSystemConfigUnion FromIRogueTowerTrialSystemConfig(IRogueTowerTrialSystemConfigT _iroguetowertrialsystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IRogueTowerTrialSystemConfig,
				Value = _iroguetowertrialsystemconfig
			};
		}

		// Token: 0x0601AD6B RID: 109931 RVA: 0x003CF4C0 File Offset: 0x003CD6C0
		public IRoleTowerSystemConfigT AsIRoleTowerSystemConfig()
		{
			return this.As<IRoleTowerSystemConfigT>();
		}

		// Token: 0x0601AD6C RID: 109932 RVA: 0x003CF4C8 File Offset: 0x003CD6C8
		public static TEnableSystemConfigUnion FromIRoleTowerSystemConfig(IRoleTowerSystemConfigT _iroletowersystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.IRoleTowerSystemConfig,
				Value = _iroletowersystemconfig
			};
		}

		// Token: 0x0601AD6D RID: 109933 RVA: 0x003CF4DE File Offset: 0x003CD6DE
		public ISurvivorsRougeSystemConfigT AsISurvivorsRougeSystemConfig()
		{
			return this.As<ISurvivorsRougeSystemConfigT>();
		}

		// Token: 0x0601AD6E RID: 109934 RVA: 0x003CF4E6 File Offset: 0x003CD6E6
		public static TEnableSystemConfigUnion FromISurvivorsRougeSystemConfig(ISurvivorsRougeSystemConfigT _isurvivorsrougesystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.ISurvivorsRougeSystemConfig,
				Value = _isurvivorsrougesystemconfig
			};
		}

		// Token: 0x0601AD6F RID: 109935 RVA: 0x003CF4FC File Offset: 0x003CD6FC
		public ITrapDefenseSystemConfigT AsITrapDefenseSystemConfig()
		{
			return this.As<ITrapDefenseSystemConfigT>();
		}

		// Token: 0x0601AD70 RID: 109936 RVA: 0x003CF504 File Offset: 0x003CD704
		public static TEnableSystemConfigUnion FromITrapDefenseSystemConfig(ITrapDefenseSystemConfigT _itrapdefensesystemconfig)
		{
			return new TEnableSystemConfigUnion
			{
				Type = TEnableSystemConfig.ITrapDefenseSystemConfig,
				Value = _itrapdefensesystemconfig
			};
		}

		// Token: 0x0601AD71 RID: 109937 RVA: 0x003CF51C File Offset: 0x003CD71C
		public static int Pack(FlatBufferBuilder builder, TEnableSystemConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TEnableSystemConfig.IDarkTideSystemConfig:
				return IDarkTideSystemConfig.Pack(builder, _o.AsIDarkTideSystemConfig()).Value;
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
