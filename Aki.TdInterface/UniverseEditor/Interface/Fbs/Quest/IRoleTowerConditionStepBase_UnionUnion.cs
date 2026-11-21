using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004512 RID: 17682
	public class IRoleTowerConditionStepBase_UnionUnion
	{
		// Token: 0x17007B0B RID: 31499
		// (get) Token: 0x06019967 RID: 104807 RVA: 0x003A5859 File Offset: 0x003A3A59
		// (set) Token: 0x06019968 RID: 104808 RVA: 0x003A5861 File Offset: 0x003A3A61
		public IRoleTowerConditionStepBase_Union Type { get; set; }

		// Token: 0x17007B0C RID: 31500
		// (get) Token: 0x06019969 RID: 104809 RVA: 0x003A586A File Offset: 0x003A3A6A
		// (set) Token: 0x0601996A RID: 104810 RVA: 0x003A5872 File Offset: 0x003A3A72
		public object Value { get; set; }

		// Token: 0x0601996B RID: 104811 RVA: 0x003A587B File Offset: 0x003A3A7B
		public IRoleTowerConditionStepBase_UnionUnion()
		{
			this.Type = IRoleTowerConditionStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601996C RID: 104812 RVA: 0x003A5891 File Offset: 0x003A3A91
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601996D RID: 104813 RVA: 0x003A58A3 File Offset: 0x003A3AA3
		public IRoleTowerConditionStepBaseT AsIRoleTowerConditionStepBase()
		{
			return this.As<IRoleTowerConditionStepBaseT>();
		}

		// Token: 0x0601996E RID: 104814 RVA: 0x003A58AB File Offset: 0x003A3AAB
		public static IRoleTowerConditionStepBase_UnionUnion FromIRoleTowerConditionStepBase(IRoleTowerConditionStepBaseT _iroletowerconditionstepbase)
		{
			return new IRoleTowerConditionStepBase_UnionUnion
			{
				Type = IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepBase,
				Value = _iroletowerconditionstepbase
			};
		}

		// Token: 0x0601996F RID: 104815 RVA: 0x003A58C0 File Offset: 0x003A3AC0
		public IRoleTowerConditionStepPrepareT AsIRoleTowerConditionStepPrepare()
		{
			return this.As<IRoleTowerConditionStepPrepareT>();
		}

		// Token: 0x06019970 RID: 104816 RVA: 0x003A58C8 File Offset: 0x003A3AC8
		public static IRoleTowerConditionStepBase_UnionUnion FromIRoleTowerConditionStepPrepare(IRoleTowerConditionStepPrepareT _iroletowerconditionstepprepare)
		{
			return new IRoleTowerConditionStepBase_UnionUnion
			{
				Type = IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepPrepare,
				Value = _iroletowerconditionstepprepare
			};
		}

		// Token: 0x06019971 RID: 104817 RVA: 0x003A58DD File Offset: 0x003A3ADD
		public IRoleTowerConditionStepBattleT AsIRoleTowerConditionStepBattle()
		{
			return this.As<IRoleTowerConditionStepBattleT>();
		}

		// Token: 0x06019972 RID: 104818 RVA: 0x003A58E5 File Offset: 0x003A3AE5
		public static IRoleTowerConditionStepBase_UnionUnion FromIRoleTowerConditionStepBattle(IRoleTowerConditionStepBattleT _iroletowerconditionstepbattle)
		{
			return new IRoleTowerConditionStepBase_UnionUnion
			{
				Type = IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepBattle,
				Value = _iroletowerconditionstepbattle
			};
		}

		// Token: 0x06019973 RID: 104819 RVA: 0x003A58FA File Offset: 0x003A3AFA
		public IRoleTowerConditionStepSettleT AsIRoleTowerConditionStepSettle()
		{
			return this.As<IRoleTowerConditionStepSettleT>();
		}

		// Token: 0x06019974 RID: 104820 RVA: 0x003A5902 File Offset: 0x003A3B02
		public static IRoleTowerConditionStepBase_UnionUnion FromIRoleTowerConditionStepSettle(IRoleTowerConditionStepSettleT _iroletowerconditionstepsettle)
		{
			return new IRoleTowerConditionStepBase_UnionUnion
			{
				Type = IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepSettle,
				Value = _iroletowerconditionstepsettle
			};
		}

		// Token: 0x06019975 RID: 104821 RVA: 0x003A5917 File Offset: 0x003A3B17
		public IRoleTowerConditionStepTeamUpgradeT AsIRoleTowerConditionStepTeamUpgrade()
		{
			return this.As<IRoleTowerConditionStepTeamUpgradeT>();
		}

		// Token: 0x06019976 RID: 104822 RVA: 0x003A591F File Offset: 0x003A3B1F
		public static IRoleTowerConditionStepBase_UnionUnion FromIRoleTowerConditionStepTeamUpgrade(IRoleTowerConditionStepTeamUpgradeT _iroletowerconditionstepteamupgrade)
		{
			return new IRoleTowerConditionStepBase_UnionUnion
			{
				Type = IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepTeamUpgrade,
				Value = _iroletowerconditionstepteamupgrade
			};
		}

		// Token: 0x06019977 RID: 104823 RVA: 0x003A5934 File Offset: 0x003A3B34
		public IRoleTowerConditionStepLoadSubLevelT AsIRoleTowerConditionStepLoadSubLevel()
		{
			return this.As<IRoleTowerConditionStepLoadSubLevelT>();
		}

		// Token: 0x06019978 RID: 104824 RVA: 0x003A593C File Offset: 0x003A3B3C
		public static IRoleTowerConditionStepBase_UnionUnion FromIRoleTowerConditionStepLoadSubLevel(IRoleTowerConditionStepLoadSubLevelT _iroletowerconditionsteploadsublevel)
		{
			return new IRoleTowerConditionStepBase_UnionUnion
			{
				Type = IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepLoadSubLevel,
				Value = _iroletowerconditionsteploadsublevel
			};
		}

		// Token: 0x06019979 RID: 104825 RVA: 0x003A5954 File Offset: 0x003A3B54
		public static int Pack(FlatBufferBuilder builder, IRoleTowerConditionStepBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepBase:
				return IRoleTowerConditionStepBase.Pack(builder, _o.AsIRoleTowerConditionStepBase()).Value;
			case IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepPrepare:
				return IRoleTowerConditionStepPrepare.Pack(builder, _o.AsIRoleTowerConditionStepPrepare()).Value;
			case IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepBattle:
				return IRoleTowerConditionStepBattle.Pack(builder, _o.AsIRoleTowerConditionStepBattle()).Value;
			case IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepSettle:
				return IRoleTowerConditionStepSettle.Pack(builder, _o.AsIRoleTowerConditionStepSettle()).Value;
			case IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepTeamUpgrade:
				return IRoleTowerConditionStepTeamUpgrade.Pack(builder, _o.AsIRoleTowerConditionStepTeamUpgrade()).Value;
			case IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepLoadSubLevel:
				return IRoleTowerConditionStepLoadSubLevel.Pack(builder, _o.AsIRoleTowerConditionStepLoadSubLevel()).Value;
			default:
				return 0;
			}
		}
	}
}
