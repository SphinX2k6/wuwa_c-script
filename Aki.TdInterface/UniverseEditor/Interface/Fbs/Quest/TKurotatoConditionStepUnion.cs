using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042DC RID: 17116
	public class TKurotatoConditionStepUnion
	{
		// Token: 0x1700794A RID: 31050
		// (get) Token: 0x06019623 RID: 103971 RVA: 0x003A428A File Offset: 0x003A248A
		// (set) Token: 0x06019624 RID: 103972 RVA: 0x003A4292 File Offset: 0x003A2492
		public TKurotatoConditionStep Type { get; set; }

		// Token: 0x1700794B RID: 31051
		// (get) Token: 0x06019625 RID: 103973 RVA: 0x003A429B File Offset: 0x003A249B
		// (set) Token: 0x06019626 RID: 103974 RVA: 0x003A42A3 File Offset: 0x003A24A3
		public object Value { get; set; }

		// Token: 0x06019627 RID: 103975 RVA: 0x003A42AC File Offset: 0x003A24AC
		public TKurotatoConditionStepUnion()
		{
			this.Type = TKurotatoConditionStep.NONE;
			this.Value = null;
		}

		// Token: 0x06019628 RID: 103976 RVA: 0x003A42C2 File Offset: 0x003A24C2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019629 RID: 103977 RVA: 0x003A42D4 File Offset: 0x003A24D4
		public IKurotatoConditionStepBattleT AsIKurotatoConditionStepBattle()
		{
			return this.As<IKurotatoConditionStepBattleT>();
		}

		// Token: 0x0601962A RID: 103978 RVA: 0x003A42DC File Offset: 0x003A24DC
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepBattle(IKurotatoConditionStepBattleT _ikurotatoconditionstepbattle)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepBattle,
				Value = _ikurotatoconditionstepbattle
			};
		}

		// Token: 0x0601962B RID: 103979 RVA: 0x003A42F1 File Offset: 0x003A24F1
		public IKurotatoConditionStepChestRewardT AsIKurotatoConditionStepChestReward()
		{
			return this.As<IKurotatoConditionStepChestRewardT>();
		}

		// Token: 0x0601962C RID: 103980 RVA: 0x003A42F9 File Offset: 0x003A24F9
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepChestReward(IKurotatoConditionStepChestRewardT _ikurotatoconditionstepchestreward)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepChestReward,
				Value = _ikurotatoconditionstepchestreward
			};
		}

		// Token: 0x0601962D RID: 103981 RVA: 0x003A430E File Offset: 0x003A250E
		public IKurotatoConditionStepEndT AsIKurotatoConditionStepEnd()
		{
			return this.As<IKurotatoConditionStepEndT>();
		}

		// Token: 0x0601962E RID: 103982 RVA: 0x003A4316 File Offset: 0x003A2516
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepEnd(IKurotatoConditionStepEndT _ikurotatoconditionstepend)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepEnd,
				Value = _ikurotatoconditionstepend
			};
		}

		// Token: 0x0601962F RID: 103983 RVA: 0x003A432B File Offset: 0x003A252B
		public IKurotatoConditionStepPrepareT AsIKurotatoConditionStepPrepare()
		{
			return this.As<IKurotatoConditionStepPrepareT>();
		}

		// Token: 0x06019630 RID: 103984 RVA: 0x003A4333 File Offset: 0x003A2533
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepPrepare(IKurotatoConditionStepPrepareT _ikurotatoconditionstepprepare)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepPrepare,
				Value = _ikurotatoconditionstepprepare
			};
		}

		// Token: 0x06019631 RID: 103985 RVA: 0x003A4348 File Offset: 0x003A2548
		public IKurotatoConditionStepSaveRoleT AsIKurotatoConditionStepSaveRole()
		{
			return this.As<IKurotatoConditionStepSaveRoleT>();
		}

		// Token: 0x06019632 RID: 103986 RVA: 0x003A4350 File Offset: 0x003A2550
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepSaveRole(IKurotatoConditionStepSaveRoleT _ikurotatoconditionstepsaverole)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepSaveRole,
				Value = _ikurotatoconditionstepsaverole
			};
		}

		// Token: 0x06019633 RID: 103987 RVA: 0x003A4365 File Offset: 0x003A2565
		public IKurotatoConditionStepShoppingT AsIKurotatoConditionStepShopping()
		{
			return this.As<IKurotatoConditionStepShoppingT>();
		}

		// Token: 0x06019634 RID: 103988 RVA: 0x003A436D File Offset: 0x003A256D
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepShopping(IKurotatoConditionStepShoppingT _ikurotatoconditionstepshopping)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepShopping,
				Value = _ikurotatoconditionstepshopping
			};
		}

		// Token: 0x06019635 RID: 103989 RVA: 0x003A4382 File Offset: 0x003A2582
		public IKurotatoConditionStepUpdateBatchT AsIKurotatoConditionStepUpdateBatch()
		{
			return this.As<IKurotatoConditionStepUpdateBatchT>();
		}

		// Token: 0x06019636 RID: 103990 RVA: 0x003A438A File Offset: 0x003A258A
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepUpdateBatch(IKurotatoConditionStepUpdateBatchT _ikurotatoconditionstepupdatebatch)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepUpdateBatch,
				Value = _ikurotatoconditionstepupdatebatch
			};
		}

		// Token: 0x06019637 RID: 103991 RVA: 0x003A439F File Offset: 0x003A259F
		public IKurotatoConditionStepUpgradeRewardT AsIKurotatoConditionStepUpgradeReward()
		{
			return this.As<IKurotatoConditionStepUpgradeRewardT>();
		}

		// Token: 0x06019638 RID: 103992 RVA: 0x003A43A7 File Offset: 0x003A25A7
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepUpgradeReward(IKurotatoConditionStepUpgradeRewardT _ikurotatoconditionstepupgradereward)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepUpgradeReward,
				Value = _ikurotatoconditionstepupgradereward
			};
		}

		// Token: 0x06019639 RID: 103993 RVA: 0x003A43BC File Offset: 0x003A25BC
		public static int Pack(FlatBufferBuilder builder, TKurotatoConditionStepUnion _o)
		{
			switch (_o.Type)
			{
			case TKurotatoConditionStep.IKurotatoConditionStepBattle:
				return IKurotatoConditionStepBattle.Pack(builder, _o.AsIKurotatoConditionStepBattle()).Value;
			case TKurotatoConditionStep.IKurotatoConditionStepChestReward:
				return IKurotatoConditionStepChestReward.Pack(builder, _o.AsIKurotatoConditionStepChestReward()).Value;
			case TKurotatoConditionStep.IKurotatoConditionStepEnd:
				return IKurotatoConditionStepEnd.Pack(builder, _o.AsIKurotatoConditionStepEnd()).Value;
			case TKurotatoConditionStep.IKurotatoConditionStepPrepare:
				return IKurotatoConditionStepPrepare.Pack(builder, _o.AsIKurotatoConditionStepPrepare()).Value;
			case TKurotatoConditionStep.IKurotatoConditionStepSaveRole:
				return IKurotatoConditionStepSaveRole.Pack(builder, _o.AsIKurotatoConditionStepSaveRole()).Value;
			case TKurotatoConditionStep.IKurotatoConditionStepShopping:
				return IKurotatoConditionStepShopping.Pack(builder, _o.AsIKurotatoConditionStepShopping()).Value;
			case TKurotatoConditionStep.IKurotatoConditionStepUpdateBatch:
				return IKurotatoConditionStepUpdateBatch.Pack(builder, _o.AsIKurotatoConditionStepUpdateBatch()).Value;
			case TKurotatoConditionStep.IKurotatoConditionStepUpgradeReward:
				return IKurotatoConditionStepUpgradeReward.Pack(builder, _o.AsIKurotatoConditionStepUpgradeReward()).Value;
			default:
				return 0;
			}
		}
	}
}
