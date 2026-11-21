using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004314 RID: 17172
	public class IKurotatoConditionStepBase_UnionUnion
	{
		// Token: 0x17007599 RID: 30105
		// (get) Token: 0x06018258 RID: 98904 RVA: 0x00371D55 File Offset: 0x0036FF55
		// (set) Token: 0x06018259 RID: 98905 RVA: 0x00371D5D File Offset: 0x0036FF5D
		public IKurotatoConditionStepBase_Union Type { get; set; }

		// Token: 0x1700759A RID: 30106
		// (get) Token: 0x0601825A RID: 98906 RVA: 0x00371D66 File Offset: 0x0036FF66
		// (set) Token: 0x0601825B RID: 98907 RVA: 0x00371D6E File Offset: 0x0036FF6E
		public object Value { get; set; }

		// Token: 0x0601825C RID: 98908 RVA: 0x00371D77 File Offset: 0x0036FF77
		public IKurotatoConditionStepBase_UnionUnion()
		{
			this.Type = IKurotatoConditionStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601825D RID: 98909 RVA: 0x00371D8D File Offset: 0x0036FF8D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601825E RID: 98910 RVA: 0x00371D9F File Offset: 0x0036FF9F
		public IKurotatoConditionStepBaseT AsIKurotatoConditionStepBase()
		{
			return this.As<IKurotatoConditionStepBaseT>();
		}

		// Token: 0x0601825F RID: 98911 RVA: 0x00371DA7 File Offset: 0x0036FFA7
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepBase(IKurotatoConditionStepBaseT _ikurotatoconditionstepbase)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepBase,
				Value = _ikurotatoconditionstepbase
			};
		}

		// Token: 0x06018260 RID: 98912 RVA: 0x00371DBC File Offset: 0x0036FFBC
		public IKurotatoConditionStepPrepareT AsIKurotatoConditionStepPrepare()
		{
			return this.As<IKurotatoConditionStepPrepareT>();
		}

		// Token: 0x06018261 RID: 98913 RVA: 0x00371DC4 File Offset: 0x0036FFC4
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepPrepare(IKurotatoConditionStepPrepareT _ikurotatoconditionstepprepare)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepPrepare,
				Value = _ikurotatoconditionstepprepare
			};
		}

		// Token: 0x06018262 RID: 98914 RVA: 0x00371DD9 File Offset: 0x0036FFD9
		public IKurotatoConditionStepBattleT AsIKurotatoConditionStepBattle()
		{
			return this.As<IKurotatoConditionStepBattleT>();
		}

		// Token: 0x06018263 RID: 98915 RVA: 0x00371DE1 File Offset: 0x0036FFE1
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepBattle(IKurotatoConditionStepBattleT _ikurotatoconditionstepbattle)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepBattle,
				Value = _ikurotatoconditionstepbattle
			};
		}

		// Token: 0x06018264 RID: 98916 RVA: 0x00371DF6 File Offset: 0x0036FFF6
		public IKurotatoConditionStepEndT AsIKurotatoConditionStepEnd()
		{
			return this.As<IKurotatoConditionStepEndT>();
		}

		// Token: 0x06018265 RID: 98917 RVA: 0x00371DFE File Offset: 0x0036FFFE
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepEnd(IKurotatoConditionStepEndT _ikurotatoconditionstepend)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepEnd,
				Value = _ikurotatoconditionstepend
			};
		}

		// Token: 0x06018266 RID: 98918 RVA: 0x00371E13 File Offset: 0x00370013
		public IKurotatoConditionStepSaveRoleT AsIKurotatoConditionStepSaveRole()
		{
			return this.As<IKurotatoConditionStepSaveRoleT>();
		}

		// Token: 0x06018267 RID: 98919 RVA: 0x00371E1B File Offset: 0x0037001B
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepSaveRole(IKurotatoConditionStepSaveRoleT _ikurotatoconditionstepsaverole)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepSaveRole,
				Value = _ikurotatoconditionstepsaverole
			};
		}

		// Token: 0x06018268 RID: 98920 RVA: 0x00371E30 File Offset: 0x00370030
		public IKurotatoConditionStepChestRewardT AsIKurotatoConditionStepChestReward()
		{
			return this.As<IKurotatoConditionStepChestRewardT>();
		}

		// Token: 0x06018269 RID: 98921 RVA: 0x00371E38 File Offset: 0x00370038
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepChestReward(IKurotatoConditionStepChestRewardT _ikurotatoconditionstepchestreward)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepChestReward,
				Value = _ikurotatoconditionstepchestreward
			};
		}

		// Token: 0x0601826A RID: 98922 RVA: 0x00371E4D File Offset: 0x0037004D
		public IKurotatoConditionStepUpgradeRewardT AsIKurotatoConditionStepUpgradeReward()
		{
			return this.As<IKurotatoConditionStepUpgradeRewardT>();
		}

		// Token: 0x0601826B RID: 98923 RVA: 0x00371E55 File Offset: 0x00370055
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepUpgradeReward(IKurotatoConditionStepUpgradeRewardT _ikurotatoconditionstepupgradereward)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepUpgradeReward,
				Value = _ikurotatoconditionstepupgradereward
			};
		}

		// Token: 0x0601826C RID: 98924 RVA: 0x00371E6A File Offset: 0x0037006A
		public IKurotatoConditionStepShoppingT AsIKurotatoConditionStepShopping()
		{
			return this.As<IKurotatoConditionStepShoppingT>();
		}

		// Token: 0x0601826D RID: 98925 RVA: 0x00371E72 File Offset: 0x00370072
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepShopping(IKurotatoConditionStepShoppingT _ikurotatoconditionstepshopping)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepShopping,
				Value = _ikurotatoconditionstepshopping
			};
		}

		// Token: 0x0601826E RID: 98926 RVA: 0x00371E87 File Offset: 0x00370087
		public IKurotatoConditionStepUpdateBatchT AsIKurotatoConditionStepUpdateBatch()
		{
			return this.As<IKurotatoConditionStepUpdateBatchT>();
		}

		// Token: 0x0601826F RID: 98927 RVA: 0x00371E8F File Offset: 0x0037008F
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepUpdateBatch(IKurotatoConditionStepUpdateBatchT _ikurotatoconditionstepupdatebatch)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepUpdateBatch,
				Value = _ikurotatoconditionstepupdatebatch
			};
		}

		// Token: 0x06018270 RID: 98928 RVA: 0x00371EA8 File Offset: 0x003700A8
		public static int Pack(FlatBufferBuilder builder, IKurotatoConditionStepBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IKurotatoConditionStepBase_Union.IKurotatoConditionStepBase:
				return IKurotatoConditionStepBase.Pack(builder, _o.AsIKurotatoConditionStepBase()).Value;
			case IKurotatoConditionStepBase_Union.IKurotatoConditionStepPrepare:
				return IKurotatoConditionStepPrepare.Pack(builder, _o.AsIKurotatoConditionStepPrepare()).Value;
			case IKurotatoConditionStepBase_Union.IKurotatoConditionStepBattle:
				return IKurotatoConditionStepBattle.Pack(builder, _o.AsIKurotatoConditionStepBattle()).Value;
			case IKurotatoConditionStepBase_Union.IKurotatoConditionStepEnd:
				return IKurotatoConditionStepEnd.Pack(builder, _o.AsIKurotatoConditionStepEnd()).Value;
			case IKurotatoConditionStepBase_Union.IKurotatoConditionStepSaveRole:
				return IKurotatoConditionStepSaveRole.Pack(builder, _o.AsIKurotatoConditionStepSaveRole()).Value;
			case IKurotatoConditionStepBase_Union.IKurotatoConditionStepChestReward:
				return IKurotatoConditionStepChestReward.Pack(builder, _o.AsIKurotatoConditionStepChestReward()).Value;
			case IKurotatoConditionStepBase_Union.IKurotatoConditionStepUpgradeReward:
				return IKurotatoConditionStepUpgradeReward.Pack(builder, _o.AsIKurotatoConditionStepUpgradeReward()).Value;
			case IKurotatoConditionStepBase_Union.IKurotatoConditionStepShopping:
				return IKurotatoConditionStepShopping.Pack(builder, _o.AsIKurotatoConditionStepShopping()).Value;
			case IKurotatoConditionStepBase_Union.IKurotatoConditionStepUpdateBatch:
				return IKurotatoConditionStepUpdateBatch.Pack(builder, _o.AsIKurotatoConditionStepUpdateBatch()).Value;
			default:
				return 0;
			}
		}
	}
}
