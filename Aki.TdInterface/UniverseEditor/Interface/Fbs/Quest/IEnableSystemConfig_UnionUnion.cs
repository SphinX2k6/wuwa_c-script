using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DF5 RID: 15861
	public class IEnableSystemConfig_UnionUnion
	{
		// Token: 0x17006D9F RID: 28063
		// (get) Token: 0x060162CB RID: 90827 RVA: 0x00333F8D File Offset: 0x0033218D
		// (set) Token: 0x060162CC RID: 90828 RVA: 0x00333F95 File Offset: 0x00332195
		public IEnableSystemConfig_Union Type { get; set; }

		// Token: 0x17006DA0 RID: 28064
		// (get) Token: 0x060162CD RID: 90829 RVA: 0x00333F9E File Offset: 0x0033219E
		// (set) Token: 0x060162CE RID: 90830 RVA: 0x00333FA6 File Offset: 0x003321A6
		public object Value { get; set; }

		// Token: 0x060162CF RID: 90831 RVA: 0x00333FAF File Offset: 0x003321AF
		public IEnableSystemConfig_UnionUnion()
		{
			this.Type = IEnableSystemConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060162D0 RID: 90832 RVA: 0x00333FC5 File Offset: 0x003321C5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060162D1 RID: 90833 RVA: 0x00333FD7 File Offset: 0x003321D7
		public IEnableSystemConfigT AsIEnableSystemConfig()
		{
			return this.As<IEnableSystemConfigT>();
		}

		// Token: 0x060162D2 RID: 90834 RVA: 0x00333FDF File Offset: 0x003321DF
		public static IEnableSystemConfig_UnionUnion FromIEnableSystemConfig(IEnableSystemConfigT _ienablesystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IEnableSystemConfig,
				Value = _ienablesystemconfig
			};
		}

		// Token: 0x060162D3 RID: 90835 RVA: 0x00333FF4 File Offset: 0x003321F4
		public IGradingSystemConfigT AsIGradingSystemConfig()
		{
			return this.As<IGradingSystemConfigT>();
		}

		// Token: 0x060162D4 RID: 90836 RVA: 0x00333FFC File Offset: 0x003321FC
		public static IEnableSystemConfig_UnionUnion FromIGradingSystemConfig(IGradingSystemConfigT _igradingsystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IGradingSystemConfig,
				Value = _igradingsystemconfig
			};
		}

		// Token: 0x060162D5 RID: 90837 RVA: 0x00334011 File Offset: 0x00332211
		public ITrapDefenseSystemConfigT AsITrapDefenseSystemConfig()
		{
			return this.As<ITrapDefenseSystemConfigT>();
		}

		// Token: 0x060162D6 RID: 90838 RVA: 0x00334019 File Offset: 0x00332219
		public static IEnableSystemConfig_UnionUnion FromITrapDefenseSystemConfig(ITrapDefenseSystemConfigT _itrapdefensesystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.ITrapDefenseSystemConfig,
				Value = _itrapdefensesystemconfig
			};
		}

		// Token: 0x060162D7 RID: 90839 RVA: 0x0033402E File Offset: 0x0033222E
		public IGameDifficultySystemConfigT AsIGameDifficultySystemConfig()
		{
			return this.As<IGameDifficultySystemConfigT>();
		}

		// Token: 0x060162D8 RID: 90840 RVA: 0x00334036 File Offset: 0x00332236
		public static IEnableSystemConfig_UnionUnion FromIGameDifficultySystemConfig(IGameDifficultySystemConfigT _igamedifficultysystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IGameDifficultySystemConfig,
				Value = _igamedifficultysystemconfig
			};
		}

		// Token: 0x060162D9 RID: 90841 RVA: 0x0033404B File Offset: 0x0033224B
		public ISurvivorsRougeSystemConfigT AsISurvivorsRougeSystemConfig()
		{
			return this.As<ISurvivorsRougeSystemConfigT>();
		}

		// Token: 0x060162DA RID: 90842 RVA: 0x00334053 File Offset: 0x00332253
		public static IEnableSystemConfig_UnionUnion FromISurvivorsRougeSystemConfig(ISurvivorsRougeSystemConfigT _isurvivorsrougesystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.ISurvivorsRougeSystemConfig,
				Value = _isurvivorsrougesystemconfig
			};
		}

		// Token: 0x060162DB RID: 90843 RVA: 0x00334068 File Offset: 0x00332268
		public IKurotatoSystemConfigT AsIKurotatoSystemConfig()
		{
			return this.As<IKurotatoSystemConfigT>();
		}

		// Token: 0x060162DC RID: 90844 RVA: 0x00334070 File Offset: 0x00332270
		public static IEnableSystemConfig_UnionUnion FromIKurotatoSystemConfig(IKurotatoSystemConfigT _ikurotatosystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IKurotatoSystemConfig,
				Value = _ikurotatosystemconfig
			};
		}

		// Token: 0x060162DD RID: 90845 RVA: 0x00334085 File Offset: 0x00332285
		public IRoleTowerSystemConfigT AsIRoleTowerSystemConfig()
		{
			return this.As<IRoleTowerSystemConfigT>();
		}

		// Token: 0x060162DE RID: 90846 RVA: 0x0033408D File Offset: 0x0033228D
		public static IEnableSystemConfig_UnionUnion FromIRoleTowerSystemConfig(IRoleTowerSystemConfigT _iroletowersystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IRoleTowerSystemConfig,
				Value = _iroletowersystemconfig
			};
		}

		// Token: 0x060162DF RID: 90847 RVA: 0x003340A2 File Offset: 0x003322A2
		public ILinkSystemConfigT AsILinkSystemConfig()
		{
			return this.As<ILinkSystemConfigT>();
		}

		// Token: 0x060162E0 RID: 90848 RVA: 0x003340AA File Offset: 0x003322AA
		public static IEnableSystemConfig_UnionUnion FromILinkSystemConfig(ILinkSystemConfigT _ilinksystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.ILinkSystemConfig,
				Value = _ilinksystemconfig
			};
		}

		// Token: 0x060162E1 RID: 90849 RVA: 0x003340BF File Offset: 0x003322BF
		public IMotorRacingSystemConfigT AsIMotorRacingSystemConfig()
		{
			return this.As<IMotorRacingSystemConfigT>();
		}

		// Token: 0x060162E2 RID: 90850 RVA: 0x003340C7 File Offset: 0x003322C7
		public static IEnableSystemConfig_UnionUnion FromIMotorRacingSystemConfig(IMotorRacingSystemConfigT _imotorracingsystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IMotorRacingSystemConfig,
				Value = _imotorracingsystemconfig
			};
		}

		// Token: 0x060162E3 RID: 90851 RVA: 0x003340DD File Offset: 0x003322DD
		public INightmareSettlementSystemConfigT AsINightmareSettlementSystemConfig()
		{
			return this.As<INightmareSettlementSystemConfigT>();
		}

		// Token: 0x060162E4 RID: 90852 RVA: 0x003340E5 File Offset: 0x003322E5
		public static IEnableSystemConfig_UnionUnion FromINightmareSettlementSystemConfig(INightmareSettlementSystemConfigT _inightmaresettlementsystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.INightmareSettlementSystemConfig,
				Value = _inightmaresettlementsystemconfig
			};
		}

		// Token: 0x060162E5 RID: 90853 RVA: 0x003340FB File Offset: 0x003322FB
		public IMotorFightSystemConfigT AsIMotorFightSystemConfig()
		{
			return this.As<IMotorFightSystemConfigT>();
		}

		// Token: 0x060162E6 RID: 90854 RVA: 0x00334103 File Offset: 0x00332303
		public static IEnableSystemConfig_UnionUnion FromIMotorFightSystemConfig(IMotorFightSystemConfigT _imotorfightsystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IMotorFightSystemConfig,
				Value = _imotorfightsystemconfig
			};
		}

		// Token: 0x060162E7 RID: 90855 RVA: 0x00334119 File Offset: 0x00332319
		public IFlagChallengeSystemConfigT AsIFlagChallengeSystemConfig()
		{
			return this.As<IFlagChallengeSystemConfigT>();
		}

		// Token: 0x060162E8 RID: 90856 RVA: 0x00334121 File Offset: 0x00332321
		public static IEnableSystemConfig_UnionUnion FromIFlagChallengeSystemConfig(IFlagChallengeSystemConfigT _iflagchallengesystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IFlagChallengeSystemConfig,
				Value = _iflagchallengesystemconfig
			};
		}

		// Token: 0x060162E9 RID: 90857 RVA: 0x00334137 File Offset: 0x00332337
		public IFlipperSystemConfigT AsIFlipperSystemConfig()
		{
			return this.As<IFlipperSystemConfigT>();
		}

		// Token: 0x060162EA RID: 90858 RVA: 0x0033413F File Offset: 0x0033233F
		public static IEnableSystemConfig_UnionUnion FromIFlipperSystemConfig(IFlipperSystemConfigT _iflippersystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IFlipperSystemConfig,
				Value = _iflippersystemconfig
			};
		}

		// Token: 0x060162EB RID: 90859 RVA: 0x00334155 File Offset: 0x00332355
		public IRogueTowerTrialSystemConfigT AsIRogueTowerTrialSystemConfig()
		{
			return this.As<IRogueTowerTrialSystemConfigT>();
		}

		// Token: 0x060162EC RID: 90860 RVA: 0x0033415D File Offset: 0x0033235D
		public static IEnableSystemConfig_UnionUnion FromIRogueTowerTrialSystemConfig(IRogueTowerTrialSystemConfigT _iroguetowertrialsystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IRogueTowerTrialSystemConfig,
				Value = _iroguetowertrialsystemconfig
			};
		}

		// Token: 0x060162ED RID: 90861 RVA: 0x00334173 File Offset: 0x00332373
		public IKuroSimpleCombatKillMonsterSystemConfigT AsIKuroSimpleCombatKillMonsterSystemConfig()
		{
			return this.As<IKuroSimpleCombatKillMonsterSystemConfigT>();
		}

		// Token: 0x060162EE RID: 90862 RVA: 0x0033417B File Offset: 0x0033237B
		public static IEnableSystemConfig_UnionUnion FromIKuroSimpleCombatKillMonsterSystemConfig(IKuroSimpleCombatKillMonsterSystemConfigT _ikurosimplecombatkillmonstersystemconfig)
		{
			return new IEnableSystemConfig_UnionUnion
			{
				Type = IEnableSystemConfig_Union.IKuroSimpleCombatKillMonsterSystemConfig,
				Value = _ikurosimplecombatkillmonstersystemconfig
			};
		}

		// Token: 0x060162EF RID: 90863 RVA: 0x00334194 File Offset: 0x00332394
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
			default:
				return 0;
			}
		}
	}
}
