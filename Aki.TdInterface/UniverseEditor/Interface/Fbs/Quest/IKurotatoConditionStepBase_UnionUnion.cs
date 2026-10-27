using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003ED6 RID: 16086
	public class IKurotatoConditionStepBase_UnionUnion
	{
		// Token: 0x17006FAA RID: 28586
		// (get) Token: 0x06016C01 RID: 93185 RVA: 0x00348B89 File Offset: 0x00346D89
		// (set) Token: 0x06016C02 RID: 93186 RVA: 0x00348B91 File Offset: 0x00346D91
		public IKurotatoConditionStepBase_Union Type { get; set; }

		// Token: 0x17006FAB RID: 28587
		// (get) Token: 0x06016C03 RID: 93187 RVA: 0x00348B9A File Offset: 0x00346D9A
		// (set) Token: 0x06016C04 RID: 93188 RVA: 0x00348BA2 File Offset: 0x00346DA2
		public object Value { get; set; }

		// Token: 0x06016C05 RID: 93189 RVA: 0x00348BAB File Offset: 0x00346DAB
		public IKurotatoConditionStepBase_UnionUnion()
		{
			this.Type = IKurotatoConditionStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016C06 RID: 93190 RVA: 0x00348BC1 File Offset: 0x00346DC1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016C07 RID: 93191 RVA: 0x00348BD3 File Offset: 0x00346DD3
		public IKurotatoConditionStepBaseT AsIKurotatoConditionStepBase()
		{
			return this.As<IKurotatoConditionStepBaseT>();
		}

		// Token: 0x06016C08 RID: 93192 RVA: 0x00348BDB File Offset: 0x00346DDB
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepBase(IKurotatoConditionStepBaseT _ikurotatoconditionstepbase)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepBase,
				Value = _ikurotatoconditionstepbase
			};
		}

		// Token: 0x06016C09 RID: 93193 RVA: 0x00348BF0 File Offset: 0x00346DF0
		public IKurotatoConditionStepPrepareT AsIKurotatoConditionStepPrepare()
		{
			return this.As<IKurotatoConditionStepPrepareT>();
		}

		// Token: 0x06016C0A RID: 93194 RVA: 0x00348BF8 File Offset: 0x00346DF8
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepPrepare(IKurotatoConditionStepPrepareT _ikurotatoconditionstepprepare)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepPrepare,
				Value = _ikurotatoconditionstepprepare
			};
		}

		// Token: 0x06016C0B RID: 93195 RVA: 0x00348C0D File Offset: 0x00346E0D
		public IKurotatoConditionStepBattleT AsIKurotatoConditionStepBattle()
		{
			return this.As<IKurotatoConditionStepBattleT>();
		}

		// Token: 0x06016C0C RID: 93196 RVA: 0x00348C15 File Offset: 0x00346E15
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepBattle(IKurotatoConditionStepBattleT _ikurotatoconditionstepbattle)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepBattle,
				Value = _ikurotatoconditionstepbattle
			};
		}

		// Token: 0x06016C0D RID: 93197 RVA: 0x00348C2A File Offset: 0x00346E2A
		public IKurotatoConditionStepEndT AsIKurotatoConditionStepEnd()
		{
			return this.As<IKurotatoConditionStepEndT>();
		}

		// Token: 0x06016C0E RID: 93198 RVA: 0x00348C32 File Offset: 0x00346E32
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepEnd(IKurotatoConditionStepEndT _ikurotatoconditionstepend)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepEnd,
				Value = _ikurotatoconditionstepend
			};
		}

		// Token: 0x06016C0F RID: 93199 RVA: 0x00348C47 File Offset: 0x00346E47
		public IKurotatoConditionStepSaveRoleT AsIKurotatoConditionStepSaveRole()
		{
			return this.As<IKurotatoConditionStepSaveRoleT>();
		}

		// Token: 0x06016C10 RID: 93200 RVA: 0x00348C4F File Offset: 0x00346E4F
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepSaveRole(IKurotatoConditionStepSaveRoleT _ikurotatoconditionstepsaverole)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepSaveRole,
				Value = _ikurotatoconditionstepsaverole
			};
		}

		// Token: 0x06016C11 RID: 93201 RVA: 0x00348C64 File Offset: 0x00346E64
		public IKurotatoConditionStepChestRewardT AsIKurotatoConditionStepChestReward()
		{
			return this.As<IKurotatoConditionStepChestRewardT>();
		}

		// Token: 0x06016C12 RID: 93202 RVA: 0x00348C6C File Offset: 0x00346E6C
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepChestReward(IKurotatoConditionStepChestRewardT _ikurotatoconditionstepchestreward)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepChestReward,
				Value = _ikurotatoconditionstepchestreward
			};
		}

		// Token: 0x06016C13 RID: 93203 RVA: 0x00348C81 File Offset: 0x00346E81
		public IKurotatoConditionStepUpgradeRewardT AsIKurotatoConditionStepUpgradeReward()
		{
			return this.As<IKurotatoConditionStepUpgradeRewardT>();
		}

		// Token: 0x06016C14 RID: 93204 RVA: 0x00348C89 File Offset: 0x00346E89
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepUpgradeReward(IKurotatoConditionStepUpgradeRewardT _ikurotatoconditionstepupgradereward)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepUpgradeReward,
				Value = _ikurotatoconditionstepupgradereward
			};
		}

		// Token: 0x06016C15 RID: 93205 RVA: 0x00348C9E File Offset: 0x00346E9E
		public IKurotatoConditionStepShoppingT AsIKurotatoConditionStepShopping()
		{
			return this.As<IKurotatoConditionStepShoppingT>();
		}

		// Token: 0x06016C16 RID: 93206 RVA: 0x00348CA6 File Offset: 0x00346EA6
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepShopping(IKurotatoConditionStepShoppingT _ikurotatoconditionstepshopping)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepShopping,
				Value = _ikurotatoconditionstepshopping
			};
		}

		// Token: 0x06016C17 RID: 93207 RVA: 0x00348CBB File Offset: 0x00346EBB
		public IKurotatoConditionStepUpdateBatchT AsIKurotatoConditionStepUpdateBatch()
		{
			return this.As<IKurotatoConditionStepUpdateBatchT>();
		}

		// Token: 0x06016C18 RID: 93208 RVA: 0x00348CC3 File Offset: 0x00346EC3
		public static IKurotatoConditionStepBase_UnionUnion FromIKurotatoConditionStepUpdateBatch(IKurotatoConditionStepUpdateBatchT _ikurotatoconditionstepupdatebatch)
		{
			return new IKurotatoConditionStepBase_UnionUnion
			{
				Type = IKurotatoConditionStepBase_Union.IKurotatoConditionStepUpdateBatch,
				Value = _ikurotatoconditionstepupdatebatch
			};
		}

		// Token: 0x06016C19 RID: 93209 RVA: 0x00348CDC File Offset: 0x00346EDC
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
