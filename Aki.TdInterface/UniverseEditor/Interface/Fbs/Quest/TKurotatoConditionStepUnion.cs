using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200473B RID: 18235
	public class TKurotatoConditionStepUnion
	{
		// Token: 0x17007F7D RID: 32637
		// (get) Token: 0x0601ADA5 RID: 109989 RVA: 0x003CFBBA File Offset: 0x003CDDBA
		// (set) Token: 0x0601ADA6 RID: 109990 RVA: 0x003CFBC2 File Offset: 0x003CDDC2
		public TKurotatoConditionStep Type { get; set; }

		// Token: 0x17007F7E RID: 32638
		// (get) Token: 0x0601ADA7 RID: 109991 RVA: 0x003CFBCB File Offset: 0x003CDDCB
		// (set) Token: 0x0601ADA8 RID: 109992 RVA: 0x003CFBD3 File Offset: 0x003CDDD3
		public object Value { get; set; }

		// Token: 0x0601ADA9 RID: 109993 RVA: 0x003CFBDC File Offset: 0x003CDDDC
		public TKurotatoConditionStepUnion()
		{
			this.Type = TKurotatoConditionStep.NONE;
			this.Value = null;
		}

		// Token: 0x0601ADAA RID: 109994 RVA: 0x003CFBF2 File Offset: 0x003CDDF2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601ADAB RID: 109995 RVA: 0x003CFC04 File Offset: 0x003CDE04
		public IKurotatoConditionStepBattleT AsIKurotatoConditionStepBattle()
		{
			return this.As<IKurotatoConditionStepBattleT>();
		}

		// Token: 0x0601ADAC RID: 109996 RVA: 0x003CFC0C File Offset: 0x003CDE0C
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepBattle(IKurotatoConditionStepBattleT _ikurotatoconditionstepbattle)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepBattle,
				Value = _ikurotatoconditionstepbattle
			};
		}

		// Token: 0x0601ADAD RID: 109997 RVA: 0x003CFC21 File Offset: 0x003CDE21
		public IKurotatoConditionStepChestRewardT AsIKurotatoConditionStepChestReward()
		{
			return this.As<IKurotatoConditionStepChestRewardT>();
		}

		// Token: 0x0601ADAE RID: 109998 RVA: 0x003CFC29 File Offset: 0x003CDE29
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepChestReward(IKurotatoConditionStepChestRewardT _ikurotatoconditionstepchestreward)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepChestReward,
				Value = _ikurotatoconditionstepchestreward
			};
		}

		// Token: 0x0601ADAF RID: 109999 RVA: 0x003CFC3E File Offset: 0x003CDE3E
		public IKurotatoConditionStepEndT AsIKurotatoConditionStepEnd()
		{
			return this.As<IKurotatoConditionStepEndT>();
		}

		// Token: 0x0601ADB0 RID: 110000 RVA: 0x003CFC46 File Offset: 0x003CDE46
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepEnd(IKurotatoConditionStepEndT _ikurotatoconditionstepend)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepEnd,
				Value = _ikurotatoconditionstepend
			};
		}

		// Token: 0x0601ADB1 RID: 110001 RVA: 0x003CFC5B File Offset: 0x003CDE5B
		public IKurotatoConditionStepPrepareT AsIKurotatoConditionStepPrepare()
		{
			return this.As<IKurotatoConditionStepPrepareT>();
		}

		// Token: 0x0601ADB2 RID: 110002 RVA: 0x003CFC63 File Offset: 0x003CDE63
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepPrepare(IKurotatoConditionStepPrepareT _ikurotatoconditionstepprepare)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepPrepare,
				Value = _ikurotatoconditionstepprepare
			};
		}

		// Token: 0x0601ADB3 RID: 110003 RVA: 0x003CFC78 File Offset: 0x003CDE78
		public IKurotatoConditionStepSaveRoleT AsIKurotatoConditionStepSaveRole()
		{
			return this.As<IKurotatoConditionStepSaveRoleT>();
		}

		// Token: 0x0601ADB4 RID: 110004 RVA: 0x003CFC80 File Offset: 0x003CDE80
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepSaveRole(IKurotatoConditionStepSaveRoleT _ikurotatoconditionstepsaverole)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepSaveRole,
				Value = _ikurotatoconditionstepsaverole
			};
		}

		// Token: 0x0601ADB5 RID: 110005 RVA: 0x003CFC95 File Offset: 0x003CDE95
		public IKurotatoConditionStepShoppingT AsIKurotatoConditionStepShopping()
		{
			return this.As<IKurotatoConditionStepShoppingT>();
		}

		// Token: 0x0601ADB6 RID: 110006 RVA: 0x003CFC9D File Offset: 0x003CDE9D
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepShopping(IKurotatoConditionStepShoppingT _ikurotatoconditionstepshopping)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepShopping,
				Value = _ikurotatoconditionstepshopping
			};
		}

		// Token: 0x0601ADB7 RID: 110007 RVA: 0x003CFCB2 File Offset: 0x003CDEB2
		public IKurotatoConditionStepUpdateBatchT AsIKurotatoConditionStepUpdateBatch()
		{
			return this.As<IKurotatoConditionStepUpdateBatchT>();
		}

		// Token: 0x0601ADB8 RID: 110008 RVA: 0x003CFCBA File Offset: 0x003CDEBA
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepUpdateBatch(IKurotatoConditionStepUpdateBatchT _ikurotatoconditionstepupdatebatch)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepUpdateBatch,
				Value = _ikurotatoconditionstepupdatebatch
			};
		}

		// Token: 0x0601ADB9 RID: 110009 RVA: 0x003CFCCF File Offset: 0x003CDECF
		public IKurotatoConditionStepUpgradeRewardT AsIKurotatoConditionStepUpgradeReward()
		{
			return this.As<IKurotatoConditionStepUpgradeRewardT>();
		}

		// Token: 0x0601ADBA RID: 110010 RVA: 0x003CFCD7 File Offset: 0x003CDED7
		public static TKurotatoConditionStepUnion FromIKurotatoConditionStepUpgradeReward(IKurotatoConditionStepUpgradeRewardT _ikurotatoconditionstepupgradereward)
		{
			return new TKurotatoConditionStepUnion
			{
				Type = TKurotatoConditionStep.IKurotatoConditionStepUpgradeReward,
				Value = _ikurotatoconditionstepupgradereward
			};
		}

		// Token: 0x0601ADBB RID: 110011 RVA: 0x003CFCEC File Offset: 0x003CDEEC
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
