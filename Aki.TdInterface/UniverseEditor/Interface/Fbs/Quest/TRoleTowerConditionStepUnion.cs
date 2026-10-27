using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200430C RID: 17164
	public class TRoleTowerConditionStepUnion
	{
		// Token: 0x1700796A RID: 31082
		// (get) Token: 0x06019743 RID: 104259 RVA: 0x003A5F14 File Offset: 0x003A4114
		// (set) Token: 0x06019744 RID: 104260 RVA: 0x003A5F1C File Offset: 0x003A411C
		public TRoleTowerConditionStep Type { get; set; }

		// Token: 0x1700796B RID: 31083
		// (get) Token: 0x06019745 RID: 104261 RVA: 0x003A5F25 File Offset: 0x003A4125
		// (set) Token: 0x06019746 RID: 104262 RVA: 0x003A5F2D File Offset: 0x003A412D
		public object Value { get; set; }

		// Token: 0x06019747 RID: 104263 RVA: 0x003A5F36 File Offset: 0x003A4136
		public TRoleTowerConditionStepUnion()
		{
			this.Type = TRoleTowerConditionStep.NONE;
			this.Value = null;
		}

		// Token: 0x06019748 RID: 104264 RVA: 0x003A5F4C File Offset: 0x003A414C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019749 RID: 104265 RVA: 0x003A5F5E File Offset: 0x003A415E
		public IRoleTowerConditionStepBattleT AsIRoleTowerConditionStepBattle()
		{
			return this.As<IRoleTowerConditionStepBattleT>();
		}

		// Token: 0x0601974A RID: 104266 RVA: 0x003A5F66 File Offset: 0x003A4166
		public static TRoleTowerConditionStepUnion FromIRoleTowerConditionStepBattle(IRoleTowerConditionStepBattleT _iroletowerconditionstepbattle)
		{
			return new TRoleTowerConditionStepUnion
			{
				Type = TRoleTowerConditionStep.IRoleTowerConditionStepBattle,
				Value = _iroletowerconditionstepbattle
			};
		}

		// Token: 0x0601974B RID: 104267 RVA: 0x003A5F7B File Offset: 0x003A417B
		public IRoleTowerConditionStepLoadSubLevelT AsIRoleTowerConditionStepLoadSubLevel()
		{
			return this.As<IRoleTowerConditionStepLoadSubLevelT>();
		}

		// Token: 0x0601974C RID: 104268 RVA: 0x003A5F83 File Offset: 0x003A4183
		public static TRoleTowerConditionStepUnion FromIRoleTowerConditionStepLoadSubLevel(IRoleTowerConditionStepLoadSubLevelT _iroletowerconditionsteploadsublevel)
		{
			return new TRoleTowerConditionStepUnion
			{
				Type = TRoleTowerConditionStep.IRoleTowerConditionStepLoadSubLevel,
				Value = _iroletowerconditionsteploadsublevel
			};
		}

		// Token: 0x0601974D RID: 104269 RVA: 0x003A5F98 File Offset: 0x003A4198
		public IRoleTowerConditionStepPrepareT AsIRoleTowerConditionStepPrepare()
		{
			return this.As<IRoleTowerConditionStepPrepareT>();
		}

		// Token: 0x0601974E RID: 104270 RVA: 0x003A5FA0 File Offset: 0x003A41A0
		public static TRoleTowerConditionStepUnion FromIRoleTowerConditionStepPrepare(IRoleTowerConditionStepPrepareT _iroletowerconditionstepprepare)
		{
			return new TRoleTowerConditionStepUnion
			{
				Type = TRoleTowerConditionStep.IRoleTowerConditionStepPrepare,
				Value = _iroletowerconditionstepprepare
			};
		}

		// Token: 0x0601974F RID: 104271 RVA: 0x003A5FB5 File Offset: 0x003A41B5
		public IRoleTowerConditionStepSettleT AsIRoleTowerConditionStepSettle()
		{
			return this.As<IRoleTowerConditionStepSettleT>();
		}

		// Token: 0x06019750 RID: 104272 RVA: 0x003A5FBD File Offset: 0x003A41BD
		public static TRoleTowerConditionStepUnion FromIRoleTowerConditionStepSettle(IRoleTowerConditionStepSettleT _iroletowerconditionstepsettle)
		{
			return new TRoleTowerConditionStepUnion
			{
				Type = TRoleTowerConditionStep.IRoleTowerConditionStepSettle,
				Value = _iroletowerconditionstepsettle
			};
		}

		// Token: 0x06019751 RID: 104273 RVA: 0x003A5FD2 File Offset: 0x003A41D2
		public IRoleTowerConditionStepTeamUpgradeT AsIRoleTowerConditionStepTeamUpgrade()
		{
			return this.As<IRoleTowerConditionStepTeamUpgradeT>();
		}

		// Token: 0x06019752 RID: 104274 RVA: 0x003A5FDA File Offset: 0x003A41DA
		public static TRoleTowerConditionStepUnion FromIRoleTowerConditionStepTeamUpgrade(IRoleTowerConditionStepTeamUpgradeT _iroletowerconditionstepteamupgrade)
		{
			return new TRoleTowerConditionStepUnion
			{
				Type = TRoleTowerConditionStep.IRoleTowerConditionStepTeamUpgrade,
				Value = _iroletowerconditionstepteamupgrade
			};
		}

		// Token: 0x06019753 RID: 104275 RVA: 0x003A5FF0 File Offset: 0x003A41F0
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
