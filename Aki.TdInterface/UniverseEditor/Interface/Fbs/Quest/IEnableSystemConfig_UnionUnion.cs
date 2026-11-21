using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004230 RID: 16944
	public class IEnableSystemConfig_UnionUnion
	{
		// Token: 0x17007385 RID: 29573
		// (get) Token: 0x060178F6 RID: 96502 RVA: 0x0035CB41 File Offset: 0x0035AD41
		// (set) Token: 0x060178F7 RID: 96503 RVA: 0x0035CB49 File Offset: 0x0035AD49
		public IEnableSystemConfig_Union Type { get; set; }

		// Token: 0x17007386 RID: 29574
		// (get) Token: 0x060178F8 RID: 96504 RVA: 0x0035CB52 File Offset: 0x0035AD52
		// (set) Token: 0x060178F9 RID: 96505 RVA: 0x0035CB5A File Offset: 0x0035AD5A
		public object Value { get; set; }

		// Token: 0x060178FA RID: 96506 RVA: 0x0035CB63 File Offset: 0x0035AD63
		public IEnableSystemConfig_UnionUnion()
		{
			this.Type = IEnableSystemConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060178FB RID: 96507 RVA: 0x0035CB79 File Offset: 0x0035AD79
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060178FC RID: 96508 RVA: 0x0035CB8B File Offset: 0x0035AD8B
		public IEnableSystemConfigT AsIEnableSystemConfig()
		{
			return this.As<IEnableSystemConfigT>();
		}

		// Token: 0x060178FD RID: 96509 RVA: 0x0035CB93 File Offset: 0x0035AD93
		public static IEnableSystemConfig_UnionUnion FromIEnableSystemConfig(IEnableSystemConfigT _ienablesystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IEnableSystemConfig,
				Value = _ienablesystemconfig
			};
		}

		// Token: 0x060178FE RID: 96510 RVA: 0x0035CBA8 File Offset: 0x0035ADA8
		public IGradingSystemConfigT AsIGradingSystemConfig()
		{
			return this.As<IGradingSystemConfigT>();
		}

		// Token: 0x060178FF RID: 96511 RVA: 0x0035CBB0 File Offset: 0x0035ADB0
		public static IEnableSystemConfig_UnionUnion FromIGradingSystemConfig(IGradingSystemConfigT _igradingsystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IGradingSystemConfig,
				Value = _igradingsystemconfig
			};
		}

		// Token: 0x06017900 RID: 96512 RVA: 0x0035CBC5 File Offset: 0x0035ADC5
		public ITrapDefenseSystemConfigT AsITrapDefenseSystemConfig()
		{
			return this.As<ITrapDefenseSystemConfigT>();
		}

		// Token: 0x06017901 RID: 96513 RVA: 0x0035CBCD File Offset: 0x0035ADCD
		public static IEnableSystemConfig_UnionUnion FromITrapDefenseSystemConfig(ITrapDefenseSystemConfigT _itrapdefensesystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.ITrapDefenseSystemConfig,
				Value = _itrapdefensesystemconfig
			};
		}

		// Token: 0x06017902 RID: 96514 RVA: 0x0035CBE2 File Offset: 0x0035ADE2
		public IGameDifficultySystemConfigT AsIGameDifficultySystemConfig()
		{
			return this.As<IGameDifficultySystemConfigT>();
		}

		// Token: 0x06017903 RID: 96515 RVA: 0x0035CBEA File Offset: 0x0035ADEA
		public static IEnableSystemConfig_UnionUnion FromIGameDifficultySystemConfig(IGameDifficultySystemConfigT _igamedifficultysystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IGameDifficultySystemConfig,
				Value = _igamedifficultysystemconfig
			};
		}

		// Token: 0x06017904 RID: 96516 RVA: 0x0035CBFF File Offset: 0x0035ADFF
		public ISurvivorsRougeSystemConfigT AsISurvivorsRougeSystemConfig()
		{
			return this.As<ISurvivorsRougeSystemConfigT>();
		}

		// Token: 0x06017905 RID: 96517 RVA: 0x0035CC07 File Offset: 0x0035AE07
		public static IEnableSystemConfig_UnionUnion FromISurvivorsRougeSystemConfig(ISurvivorsRougeSystemConfigT _isurvivorsrougesystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.ISurvivorsRougeSystemConfig,
				Value = _isurvivorsrougesystemconfig
			};
		}

		// Token: 0x06017906 RID: 96518 RVA: 0x0035CC1C File Offset: 0x0035AE1C
		public IKurotatoSystemConfigT AsIKurotatoSystemConfig()
		{
			return this.As<IKurotatoSystemConfigT>();
		}

		// Token: 0x06017907 RID: 96519 RVA: 0x0035CC24 File Offset: 0x0035AE24
		public static IEnableSystemConfig_UnionUnion FromIKurotatoSystemConfig(IKurotatoSystemConfigT _ikurotatosystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IKurotatoSystemConfig,
				Value = _ikurotatosystemconfig
			};
		}

		// Token: 0x06017908 RID: 96520 RVA: 0x0035CC39 File Offset: 0x0035AE39
		public IRoleTowerSystemConfigT AsIRoleTowerSystemConfig()
		{
			return this.As<IRoleTowerSystemConfigT>();
		}

		// Token: 0x06017909 RID: 96521 RVA: 0x0035CC41 File Offset: 0x0035AE41
		public static IEnableSystemConfig_UnionUnion FromIRoleTowerSystemConfig(IRoleTowerSystemConfigT _iroletowersystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IRoleTowerSystemConfig,
				Value = _iroletowersystemconfig
			};
		}

		// Token: 0x0601790A RID: 96522 RVA: 0x0035CC56 File Offset: 0x0035AE56
		public ILinkSystemConfigT AsILinkSystemConfig()
		{
			return this.As<ILinkSystemConfigT>();
		}

		// Token: 0x0601790B RID: 96523 RVA: 0x0035CC5E File Offset: 0x0035AE5E
		public static IEnableSystemConfig_UnionUnion FromILinkSystemConfig(ILinkSystemConfigT _ilinksystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.ILinkSystemConfig,
				Value = _ilinksystemconfig
			};
		}

		// Token: 0x0601790C RID: 96524 RVA: 0x0035CC73 File Offset: 0x0035AE73
		public IMotorRacingSystemConfigT AsIMotorRacingSystemConfig()
		{
			return this.As<IMotorRacingSystemConfigT>();
		}

		// Token: 0x0601790D RID: 96525 RVA: 0x0035CC7B File Offset: 0x0035AE7B
		public static IEnableSystemConfig_UnionUnion FromIMotorRacingSystemConfig(IMotorRacingSystemConfigT _imotorracingsystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IMotorRacingSystemConfig,
				Value = _imotorracingsystemconfig
			};
		}

		// Token: 0x0601790E RID: 96526 RVA: 0x0035CC91 File Offset: 0x0035AE91
		public INightmareSettlementSystemConfigT AsINightmareSettlementSystemConfig()
		{
			return this.As<INightmareSettlementSystemConfigT>();
		}

		// Token: 0x0601790F RID: 96527 RVA: 0x0035CC99 File Offset: 0x0035AE99
		public static IEnableSystemConfig_UnionUnion FromINightmareSettlementSystemConfig(INightmareSettlementSystemConfigT _inightmaresettlementsystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.INightmareSettlementSystemConfig,
				Value = _inightmaresettlementsystemconfig
			};
		}

		// Token: 0x06017910 RID: 96528 RVA: 0x0035CCAF File Offset: 0x0035AEAF
		public IMotorFightSystemConfigT AsIMotorFightSystemConfig()
		{
			return this.As<IMotorFightSystemConfigT>();
		}

		// Token: 0x06017911 RID: 96529 RVA: 0x0035CCB7 File Offset: 0x0035AEB7
		public static IEnableSystemConfig_UnionUnion FromIMotorFightSystemConfig(IMotorFightSystemConfigT _imotorfightsystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IMotorFightSystemConfig,
				Value = _imotorfightsystemconfig
			};
		}

		// Token: 0x06017912 RID: 96530 RVA: 0x0035CCCD File Offset: 0x0035AECD
		public IFlagChallengeSystemConfigT AsIFlagChallengeSystemConfig()
		{
			return this.As<IFlagChallengeSystemConfigT>();
		}

		// Token: 0x06017913 RID: 96531 RVA: 0x0035CCD5 File Offset: 0x0035AED5
		public static IEnableSystemConfig_UnionUnion FromIFlagChallengeSystemConfig(IFlagChallengeSystemConfigT _iflagchallengesystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IFlagChallengeSystemConfig,
				Value = _iflagchallengesystemconfig
			};
		}

		// Token: 0x06017914 RID: 96532 RVA: 0x0035CCEB File Offset: 0x0035AEEB
		public IFlipperSystemConfigT AsIFlipperSystemConfig()
		{
			return this.As<IFlipperSystemConfigT>();
		}

		// Token: 0x06017915 RID: 96533 RVA: 0x0035CCF3 File Offset: 0x0035AEF3
		public static IEnableSystemConfig_UnionUnion FromIFlipperSystemConfig(IFlipperSystemConfigT _iflippersystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IFlipperSystemConfig,
				Value = _iflippersystemconfig
			};
		}

		// Token: 0x06017916 RID: 96534 RVA: 0x0035CD09 File Offset: 0x0035AF09
		public IRogueTowerTrialSystemConfigT AsIRogueTowerTrialSystemConfig()
		{
			return this.As<IRogueTowerTrialSystemConfigT>();
		}

		// Token: 0x06017917 RID: 96535 RVA: 0x0035CD11 File Offset: 0x0035AF11
		public static IEnableSystemConfig_UnionUnion FromIRogueTowerTrialSystemConfig(IRogueTowerTrialSystemConfigT _iroguetowertrialsystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IRogueTowerTrialSystemConfig,
				Value = _iroguetowertrialsystemconfig
			};
		}

		// Token: 0x06017918 RID: 96536 RVA: 0x0035CD27 File Offset: 0x0035AF27
		public IKuroSimpleCombatKillMonsterSystemConfigT AsIKuroSimpleCombatKillMonsterSystemConfig()
		{
			return this.As<IKuroSimpleCombatKillMonsterSystemConfigT>();
		}

		// Token: 0x06017919 RID: 96537 RVA: 0x0035CD2F File Offset: 0x0035AF2F
		public static IEnableSystemConfig_UnionUnion FromIKuroSimpleCombatKillMonsterSystemConfig(IKuroSimpleCombatKillMonsterSystemConfigT _ikurosimplecombatkillmonstersystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IKuroSimpleCombatKillMonsterSystemConfig,
				Value = _ikurosimplecombatkillmonstersystemconfig
			};
		}

		// Token: 0x0601791A RID: 96538 RVA: 0x0035CD45 File Offset: 0x0035AF45
		public IDarkTideSystemConfigT AsIDarkTideSystemConfig()
		{
			return this.As<IDarkTideSystemConfigT>();
		}

		// Token: 0x0601791B RID: 96539 RVA: 0x0035CD4D File Offset: 0x0035AF4D
		public static IEnableSystemConfig_UnionUnion FromIDarkTideSystemConfig(IDarkTideSystemConfigT _idarktidesystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IDarkTideSystemConfig,
				Value = _idarktidesystemconfig
			};
		}

		// Token: 0x0601791C RID: 96540 RVA: 0x0035CD64 File Offset: 0x0035AF64
		public static int Pack(FlatBufferBuilder builder, IEnableSystemConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEnableSystemConfig_Union.IEnableSystemConfig:
				return IEnableSystemConfig.Pack(builder, _o.AsIEnableSystemConfig()).Value;
			case IEnableSystemConfig_Union.IGradingSystemConfig:
				return IGradingSystemConfig.Pack(builder, _o.AsIGradingSystemConfig()).Value;
			case IEnableSystemConfig_Union.ITrapDefenseSystemConfig:
				return ITrapDefenseSystemConfig.Pack(builder, _o.AsITrapDefenseSystemConfig()).Value;
			case IEnableSystemConfig_Union.IGameDifficultySystemConfig:
				return IGameDifficultySystemConfig.Pack(builder, _o.AsIGameDifficultySystemConfig()).Value;
			case IEnableSystemConfig_Union.ISurvivorsRougeSystemConfig:
				return ISurvivorsRougeSystemConfig.Pack(builder, _o.AsISurvivorsRougeSystemConfig()).Value;
			case IEnableSystemConfig_Union.IKurotatoSystemConfig:
				return IKurotatoSystemConfig.Pack(builder, _o.AsIKurotatoSystemConfig()).Value;
			case IEnableSystemConfig_Union.IRoleTowerSystemConfig:
				return IRoleTowerSystemConfig.Pack(builder, _o.AsIRoleTowerSystemConfig()).Value;
			case IEnableSystemConfig_Union.ILinkSystemConfig:
				return ILinkSystemConfig.Pack(builder, _o.AsILinkSystemConfig()).Value;
			case IEnableSystemConfig_Union.IMotorRacingSystemConfig:
				return IMotorRacingSystemConfig.Pack(builder, _o.AsIMotorRacingSystemConfig()).Value;
			case IEnableSystemConfig_Union.INightmareSettlementSystemConfig:
				return INightmareSettlementSystemConfig.Pack(builder, _o.AsINightmareSettlementSystemConfig()).Value;
			case IEnableSystemConfig_Union.IMotorFightSystemConfig:
				return IMotorFightSystemConfig.Pack(builder, _o.AsIMotorFightSystemConfig()).Value;
			case IEnableSystemConfig_Union.IFlagChallengeSystemConfig:
				return IFlagChallengeSystemConfig.Pack(builder, _o.AsIFlagChallengeSystemConfig()).Value;
			case IEnableSystemConfig_Union.IFlipperSystemConfig:
				return IFlipperSystemConfig.Pack(builder, _o.AsIFlipperSystemConfig()).Value;
			case IEnableSystemConfig_Union.IRogueTowerTrialSystemConfig:
				return IRogueTowerTrialSystemConfig.Pack(builder, _o.AsIRogueTowerTrialSystemConfig()).Value;
			case IEnableSystemConfig_Union.IKuroSimpleCombatKillMonsterSystemConfig:
				return IKuroSimpleCombatKillMonsterSystemConfig.Pack(builder, _o.AsIKuroSimpleCombatKillMonsterSystemConfig()).Value;
			case IEnableSystemConfig_Union.IDarkTideSystemConfig:
				return IDarkTideSystemConfig.Pack(builder, _o.AsIDarkTideSystemConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
