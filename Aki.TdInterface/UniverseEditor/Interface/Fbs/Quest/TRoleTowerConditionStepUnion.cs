using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200476B RID: 18283
	public class TRoleTowerConditionStepUnion
	{
		// Token: 0x17007F9D RID: 32669
		// (get) Token: 0x0601AEC5 RID: 110277 RVA: 0x003D1844 File Offset: 0x003CFA44
		// (set) Token: 0x0601AEC6 RID: 110278 RVA: 0x003D184C File Offset: 0x003CFA4C
		public TRoleTowerConditionStep Type { get; set; }

		// Token: 0x17007F9E RID: 32670
		// (get) Token: 0x0601AEC7 RID: 110279 RVA: 0x003D1855 File Offset: 0x003CFA55
		// (set) Token: 0x0601AEC8 RID: 110280 RVA: 0x003D185D File Offset: 0x003CFA5D
		public object Value { get; set; }

		// Token: 0x0601AEC9 RID: 110281 RVA: 0x003D1866 File Offset: 0x003CFA66
		public TRoleTowerConditionStepUnion()
		{
			this.Type = TRoleTowerConditionStep.NONE;
			this.Value = null;
		}

		// Token: 0x0601AECA RID: 110282 RVA: 0x003D187C File Offset: 0x003CFA7C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AECB RID: 110283 RVA: 0x003D188E File Offset: 0x003CFA8E
		public IRoleTowerConditionStepBattleT AsIRoleTowerConditionStepBattle()
		{
			return this.As<IRoleTowerConditionStepBattleT>();
		}

		// Token: 0x0601AECC RID: 110284 RVA: 0x003D1896 File Offset: 0x003CFA96
		public static TRoleTowerConditionStepUnion FromIRoleTowerConditionStepBattle(IRoleTowerConditionStepBattleT _iroletowerconditionstepbattle)
		{
			return new TRoleTowerConditionStepUnion
			{
				Type = TRoleTowerConditionStep.IRoleTowerConditionStepBattle,
				Value = _iroletowerconditionstepbattle
			};
		}

		// Token: 0x0601AECD RID: 110285 RVA: 0x003D18AB File Offset: 0x003CFAAB
		public IRoleTowerConditionStepLoadSubLevelT AsIRoleTowerConditionStepLoadSubLevel()
		{
			return this.As<IRoleTowerConditionStepLoadSubLevelT>();
		}

		// Token: 0x0601AECE RID: 110286 RVA: 0x003D18B3 File Offset: 0x003CFAB3
		public static TRoleTowerConditionStepUnion FromIRoleTowerConditionStepLoadSubLevel(IRoleTowerConditionStepLoadSubLevelT _iroletowerconditionsteploadsublevel)
		{
			return new TRoleTowerConditionStepUnion
			{
				Type = TRoleTowerConditionStep.IRoleTowerConditionStepLoadSubLevel,
				Value = _iroletowerconditionsteploadsublevel
			};
		}

		// Token: 0x0601AECF RID: 110287 RVA: 0x003D18C8 File Offset: 0x003CFAC8
		public IRoleTowerConditionStepPrepareT AsIRoleTowerConditionStepPrepare()
		{
			return this.As<IRoleTowerConditionStepPrepareT>();
		}

		// Token: 0x0601AED0 RID: 110288 RVA: 0x003D18D0 File Offset: 0x003CFAD0
		public static TRoleTowerConditionStepUnion FromIRoleTowerConditionStepPrepare(IRoleTowerConditionStepPrepareT _iroletowerconditionstepprepare)
		{
			return new TRoleTowerConditionStepUnion
			{
				Type = TRoleTowerConditionStep.IRoleTowerConditionStepPrepare,
				Value = _iroletowerconditionstepprepare
			};
		}

		// Token: 0x0601AED1 RID: 110289 RVA: 0x003D18E5 File Offset: 0x003CFAE5
		public IRoleTowerConditionStepSettleT AsIRoleTowerConditionStepSettle()
		{
			return this.As<IRoleTowerConditionStepSettleT>();
		}

		// Token: 0x0601AED2 RID: 110290 RVA: 0x003D18ED File Offset: 0x003CFAED
		public static TRoleTowerConditionStepUnion FromIRoleTowerConditionStepSettle(IRoleTowerConditionStepSettleT _iroletowerconditionstepsettle)
		{
			return new TRoleTowerConditionStepUnion
			{
				Type = TRoleTowerConditionStep.IRoleTowerConditionStepSettle,
				Value = _iroletowerconditionstepsettle
			};
		}

		// Token: 0x0601AED3 RID: 110291 RVA: 0x003D1902 File Offset: 0x003CFB02
		public IRoleTowerConditionStepTeamUpgradeT AsIRoleTowerConditionStepTeamUpgrade()
		{
			return this.As<IRoleTowerConditionStepTeamUpgradeT>();
		}

		// Token: 0x0601AED4 RID: 110292 RVA: 0x003D190A File Offset: 0x003CFB0A
		public static TRoleTowerConditionStepUnion FromIRoleTowerConditionStepTeamUpgrade(IRoleTowerConditionStepTeamUpgradeT _iroletowerconditionstepteamupgrade)
		{
			return new TRoleTowerConditionStepUnion
			{
				Type = TRoleTowerConditionStep.IRoleTowerConditionStepTeamUpgrade,
				Value = _iroletowerconditionstepteamupgrade
			};
		}

		// Token: 0x0601AED5 RID: 110293 RVA: 0x003D1920 File Offset: 0x003CFB20
		public static int Pack(FlatBufferBuilder builder, TRoleTowerConditionStepUnion _o)
		{
			switch (_o.Type)
			{
			case TRoleTowerConditionStep.IRoleTowerConditionStepBattle:
				return IRoleTowerConditionStepBattle.Pack(builder, _o.AsIRoleTowerConditionStepBattle()).Value;
			case TRoleTowerConditionStep.IRoleTowerConditionStepLoadSubLevel:
				return IRoleTowerConditionStepLoadSubLevel.Pack(builder, _o.AsIRoleTowerConditionStepLoadSubLevel()).Value;
			case TRoleTowerConditionStep.IRoleTowerConditionStepPrepare:
				return IRoleTowerConditionStepPrepare.Pack(builder, _o.AsIRoleTowerConditionStepPrepare()).Value;
			case TRoleTowerConditionStep.IRoleTowerConditionStepSettle:
				return IRoleTowerConditionStepSettle.Pack(builder, _o.AsIRoleTowerConditionStepSettle()).Value;
			case TRoleTowerConditionStep.IRoleTowerConditionStepTeamUpgrade:
				return IRoleTowerConditionStepTeamUpgrade.Pack(builder, _o.AsIRoleTowerConditionStepTeamUpgrade()).Value;
			default:
				return 0;
			}
		}
	}
}
