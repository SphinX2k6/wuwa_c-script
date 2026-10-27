using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040D1 RID: 16593
	public class IRoleTowerConditionStepBase_UnionUnion
	{
		// Token: 0x17007505 RID: 29957
		// (get) Token: 0x060182C6 RID: 99014 RVA: 0x0037B909 File Offset: 0x00379B09
		// (set) Token: 0x060182C7 RID: 99015 RVA: 0x0037B911 File Offset: 0x00379B11
		public IRoleTowerConditionStepBase_Union Type { get; set; }

		// Token: 0x17007506 RID: 29958
		// (get) Token: 0x060182C8 RID: 99016 RVA: 0x0037B91A File Offset: 0x00379B1A
		// (set) Token: 0x060182C9 RID: 99017 RVA: 0x0037B922 File Offset: 0x00379B22
		public object Value { get; set; }

		// Token: 0x060182CA RID: 99018 RVA: 0x0037B92B File Offset: 0x00379B2B
		public IRoleTowerConditionStepBase_UnionUnion()
		{
			this.Type = IRoleTowerConditionStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060182CB RID: 99019 RVA: 0x0037B941 File Offset: 0x00379B41
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060182CC RID: 99020 RVA: 0x0037B953 File Offset: 0x00379B53
		public IRoleTowerConditionStepBaseT AsIRoleTowerConditionStepBase()
		{
			return this.As<IRoleTowerConditionStepBaseT>();
		}

		// Token: 0x060182CD RID: 99021 RVA: 0x0037B95B File Offset: 0x00379B5B
		public static IRoleTowerConditionStepBase_UnionUnion FromIRoleTowerConditionStepBase(IRoleTowerConditionStepBaseT _iroletowerconditionstepbase)
		{
			return new IRoleTowerConditionStepBase_UnionUnion
			{
				Type = IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepBase,
				Value = _iroletowerconditionstepbase
			};
		}

		// Token: 0x060182CE RID: 99022 RVA: 0x0037B970 File Offset: 0x00379B70
		public IRoleTowerConditionStepPrepareT AsIRoleTowerConditionStepPrepare()
		{
			return this.As<IRoleTowerConditionStepPrepareT>();
		}

		// Token: 0x060182CF RID: 99023 RVA: 0x0037B978 File Offset: 0x00379B78
		public static IRoleTowerConditionStepBase_UnionUnion FromIRoleTowerConditionStepPrepare(IRoleTowerConditionStepPrepareT _iroletowerconditionstepprepare)
		{
			return new IRoleTowerConditionStepBase_UnionUnion
			{
				Type = IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepPrepare,
				Value = _iroletowerconditionstepprepare
			};
		}

		// Token: 0x060182D0 RID: 99024 RVA: 0x0037B98D File Offset: 0x00379B8D
		public IRoleTowerConditionStepBattleT AsIRoleTowerConditionStepBattle()
		{
			return this.As<IRoleTowerConditionStepBattleT>();
		}

		// Token: 0x060182D1 RID: 99025 RVA: 0x0037B995 File Offset: 0x00379B95
		public static IRoleTowerConditionStepBase_UnionUnion FromIRoleTowerConditionStepBattle(IRoleTowerConditionStepBattleT _iroletowerconditionstepbattle)
		{
			return new IRoleTowerConditionStepBase_UnionUnion
			{
				Type = IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepBattle,
				Value = _iroletowerconditionstepbattle
			};
		}

		// Token: 0x060182D2 RID: 99026 RVA: 0x0037B9AA File Offset: 0x00379BAA
		public IRoleTowerConditionStepSettleT AsIRoleTowerConditionStepSettle()
		{
			return this.As<IRoleTowerConditionStepSettleT>();
		}

		// Token: 0x060182D3 RID: 99027 RVA: 0x0037B9B2 File Offset: 0x00379BB2
		public static IRoleTowerConditionStepBase_UnionUnion FromIRoleTowerConditionStepSettle(IRoleTowerConditionStepSettleT _iroletowerconditionstepsettle)
		{
			return new IRoleTowerConditionStepBase_UnionUnion
			{
				Type = IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepSettle,
				Value = _iroletowerconditionstepsettle
			};
		}

		// Token: 0x060182D4 RID: 99028 RVA: 0x0037B9C7 File Offset: 0x00379BC7
		public IRoleTowerConditionStepTeamUpgradeT AsIRoleTowerConditionStepTeamUpgrade()
		{
			return this.As<IRoleTowerConditionStepTeamUpgradeT>();
		}

		// Token: 0x060182D5 RID: 99029 RVA: 0x0037B9CF File Offset: 0x00379BCF
		public static IRoleTowerConditionStepBase_UnionUnion FromIRoleTowerConditionStepTeamUpgrade(IRoleTowerConditionStepTeamUpgradeT _iroletowerconditionstepteamupgrade)
		{
			return new IRoleTowerConditionStepBase_UnionUnion
			{
				Type = IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepTeamUpgrade,
				Value = _iroletowerconditionstepteamupgrade
			};
		}

		// Token: 0x060182D6 RID: 99030 RVA: 0x0037B9E4 File Offset: 0x00379BE4
		public IRoleTowerConditionStepLoadSubLevelT AsIRoleTowerConditionStepLoadSubLevel()
		{
			return this.As<IRoleTowerConditionStepLoadSubLevelT>();
		}

		// Token: 0x060182D7 RID: 99031 RVA: 0x0037B9EC File Offset: 0x00379BEC
		public static IRoleTowerConditionStepBase_UnionUnion FromIRoleTowerConditionStepLoadSubLevel(IRoleTowerConditionStepLoadSubLevelT _iroletowerconditionsteploadsublevel)
		{
			return new IRoleTowerConditionStepBase_UnionUnion
			{
				Type = IRoleTowerConditionStepBase_Union.IRoleTowerConditionStepLoadSubLevel,
				Value = _iroletowerconditionsteploadsublevel
			};
		}

		// Token: 0x060182D8 RID: 99032 RVA: 0x0037BA04 File Offset: 0x00379C04
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
