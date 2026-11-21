using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004599 RID: 17817
	public class ISurvivorsRougeConditionStepBase_UnionUnion
	{
		// Token: 0x17007C96 RID: 31894
		// (get) Token: 0x06019FC0 RID: 106432 RVA: 0x003B4939 File Offset: 0x003B2B39
		// (set) Token: 0x06019FC1 RID: 106433 RVA: 0x003B4941 File Offset: 0x003B2B41
		public ISurvivorsRougeConditionStepBase_Union Type { get; set; }

		// Token: 0x17007C97 RID: 31895
		// (get) Token: 0x06019FC2 RID: 106434 RVA: 0x003B494A File Offset: 0x003B2B4A
		// (set) Token: 0x06019FC3 RID: 106435 RVA: 0x003B4952 File Offset: 0x003B2B52
		public object Value { get; set; }

		// Token: 0x06019FC4 RID: 106436 RVA: 0x003B495B File Offset: 0x003B2B5B
		public ISurvivorsRougeConditionStepBase_UnionUnion()
		{
			this.Type = ISurvivorsRougeConditionStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019FC5 RID: 106437 RVA: 0x003B4971 File Offset: 0x003B2B71
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019FC6 RID: 106438 RVA: 0x003B4983 File Offset: 0x003B2B83
		public ISurvivorsRougeConditionStepBaseT AsISurvivorsRougeConditionStepBase()
		{
			return this.As<ISurvivorsRougeConditionStepBaseT>();
		}

		// Token: 0x06019FC7 RID: 106439 RVA: 0x003B498B File Offset: 0x003B2B8B
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepBase(ISurvivorsRougeConditionStepBaseT _isurvivorsrougeconditionstepbase)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepBase,
				Value = _isurvivorsrougeconditionstepbase
			};
		}

		// Token: 0x06019FC8 RID: 106440 RVA: 0x003B49A0 File Offset: 0x003B2BA0
		public ISurvivorsRougeConditionStepPrepareT AsISurvivorsRougeConditionStepPrepare()
		{
			return this.As<ISurvivorsRougeConditionStepPrepareT>();
		}

		// Token: 0x06019FC9 RID: 106441 RVA: 0x003B49A8 File Offset: 0x003B2BA8
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepPrepare(ISurvivorsRougeConditionStepPrepareT _isurvivorsrougeconditionstepprepare)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepPrepare,
				Value = _isurvivorsrougeconditionstepprepare
			};
		}

		// Token: 0x06019FCA RID: 106442 RVA: 0x003B49BD File Offset: 0x003B2BBD
		public ISurvivorsRougeConditionStepBattleT AsISurvivorsRougeConditionStepBattle()
		{
			return this.As<ISurvivorsRougeConditionStepBattleT>();
		}

		// Token: 0x06019FCB RID: 106443 RVA: 0x003B49C5 File Offset: 0x003B2BC5
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepBattle(ISurvivorsRougeConditionStepBattleT _isurvivorsrougeconditionstepbattle)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepBattle,
				Value = _isurvivorsrougeconditionstepbattle
			};
		}

		// Token: 0x06019FCC RID: 106444 RVA: 0x003B49DA File Offset: 0x003B2BDA
		public ISurvivorsRougeConditionStepEndT AsISurvivorsRougeConditionStepEnd()
		{
			return this.As<ISurvivorsRougeConditionStepEndT>();
		}

		// Token: 0x06019FCD RID: 106445 RVA: 0x003B49E2 File Offset: 0x003B2BE2
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepEnd(ISurvivorsRougeConditionStepEndT _isurvivorsrougeconditionstepend)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepEnd,
				Value = _isurvivorsrougeconditionstepend
			};
		}

		// Token: 0x06019FCE RID: 106446 RVA: 0x003B49F7 File Offset: 0x003B2BF7
		public ISurvivorsRougeConditionStepChestRewardT AsISurvivorsRougeConditionStepChestReward()
		{
			return this.As<ISurvivorsRougeConditionStepChestRewardT>();
		}

		// Token: 0x06019FCF RID: 106447 RVA: 0x003B49FF File Offset: 0x003B2BFF
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepChestReward(ISurvivorsRougeConditionStepChestRewardT _isurvivorsrougeconditionstepchestreward)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepChestReward,
				Value = _isurvivorsrougeconditionstepchestreward
			};
		}

		// Token: 0x06019FD0 RID: 106448 RVA: 0x003B4A14 File Offset: 0x003B2C14
		public ISurvivorsRougeConditionStepChooseWeaponT AsISurvivorsRougeConditionStepChooseWeapon()
		{
			return this.As<ISurvivorsRougeConditionStepChooseWeaponT>();
		}

		// Token: 0x06019FD1 RID: 106449 RVA: 0x003B4A1C File Offset: 0x003B2C1C
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepChooseWeapon(ISurvivorsRougeConditionStepChooseWeaponT _isurvivorsrougeconditionstepchooseweapon)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepChooseWeapon,
				Value = _isurvivorsrougeconditionstepchooseweapon
			};
		}

		// Token: 0x06019FD2 RID: 106450 RVA: 0x003B4A31 File Offset: 0x003B2C31
		public ISurvivorsRougeConditionStepChooseItemT AsISurvivorsRougeConditionStepChooseItem()
		{
			return this.As<ISurvivorsRougeConditionStepChooseItemT>();
		}

		// Token: 0x06019FD3 RID: 106451 RVA: 0x003B4A39 File Offset: 0x003B2C39
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepChooseItem(ISurvivorsRougeConditionStepChooseItemT _isurvivorsrougeconditionstepchooseitem)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepChooseItem,
				Value = _isurvivorsrougeconditionstepchooseitem
			};
		}

		// Token: 0x06019FD4 RID: 106452 RVA: 0x003B4A4E File Offset: 0x003B2C4E
		public ISurvivorsRougeConditionStepShoppingT AsISurvivorsRougeConditionStepShopping()
		{
			return this.As<ISurvivorsRougeConditionStepShoppingT>();
		}

		// Token: 0x06019FD5 RID: 106453 RVA: 0x003B4A56 File Offset: 0x003B2C56
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepShopping(ISurvivorsRougeConditionStepShoppingT _isurvivorsrougeconditionstepshopping)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepShopping,
				Value = _isurvivorsrougeconditionstepshopping
			};
		}

		// Token: 0x06019FD6 RID: 106454 RVA: 0x003B4A6C File Offset: 0x003B2C6C
		public static int Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepBase:
				return ISurvivorsRougeConditionStepBase.Pack(builder, _o.AsISurvivorsRougeConditionStepBase()).Value;
			case ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepPrepare:
				return ISurvivorsRougeConditionStepPrepare.Pack(builder, _o.AsISurvivorsRougeConditionStepPrepare()).Value;
			case ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepBattle:
				return ISurvivorsRougeConditionStepBattle.Pack(builder, _o.AsISurvivorsRougeConditionStepBattle()).Value;
			case ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepEnd:
				return ISurvivorsRougeConditionStepEnd.Pack(builder, _o.AsISurvivorsRougeConditionStepEnd()).Value;
			case ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepChestReward:
				return ISurvivorsRougeConditionStepChestReward.Pack(builder, _o.AsISurvivorsRougeConditionStepChestReward()).Value;
			case ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepChooseWeapon:
				return ISurvivorsRougeConditionStepChooseWeapon.Pack(builder, _o.AsISurvivorsRougeConditionStepChooseWeapon()).Value;
			case ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepChooseItem:
				return ISurvivorsRougeConditionStepChooseItem.Pack(builder, _o.AsISurvivorsRougeConditionStepChooseItem()).Value;
			case ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepShopping:
				return ISurvivorsRougeConditionStepShopping.Pack(builder, _o.AsISurvivorsRougeConditionStepShopping()).Value;
			default:
				return 0;
			}
		}
	}
}
