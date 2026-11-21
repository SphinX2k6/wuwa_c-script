using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200477A RID: 18298
	public class TSurvivorsRougeConditionStepUnion
	{
		// Token: 0x17007FA7 RID: 32679
		// (get) Token: 0x0601AF21 RID: 110369 RVA: 0x003D2172 File Offset: 0x003D0372
		// (set) Token: 0x0601AF22 RID: 110370 RVA: 0x003D217A File Offset: 0x003D037A
		public TSurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x17007FA8 RID: 32680
		// (get) Token: 0x0601AF23 RID: 110371 RVA: 0x003D2183 File Offset: 0x003D0383
		// (set) Token: 0x0601AF24 RID: 110372 RVA: 0x003D218B File Offset: 0x003D038B
		public object Value { get; set; }

		// Token: 0x0601AF25 RID: 110373 RVA: 0x003D2194 File Offset: 0x003D0394
		public TSurvivorsRougeConditionStepUnion()
		{
			this.Type = TSurvivorsRougeConditionStep.NONE;
			this.Value = null;
		}

		// Token: 0x0601AF26 RID: 110374 RVA: 0x003D21AA File Offset: 0x003D03AA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AF27 RID: 110375 RVA: 0x003D21BC File Offset: 0x003D03BC
		public ISurvivorsRougeConditionStepBattleT AsISurvivorsRougeConditionStepBattle()
		{
			return this.As<ISurvivorsRougeConditionStepBattleT>();
		}

		// Token: 0x0601AF28 RID: 110376 RVA: 0x003D21C4 File Offset: 0x003D03C4
		public static TSurvivorsRougeConditionStepUnion FromISurvivorsRougeConditionStepBattle(ISurvivorsRougeConditionStepBattleT _isurvivorsrougeconditionstepbattle)
		{
			return new TSurvivorsRougeConditionStepUnion
			{
				Type = TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepBattle,
				Value = _isurvivorsrougeconditionstepbattle
			};
		}

		// Token: 0x0601AF29 RID: 110377 RVA: 0x003D21D9 File Offset: 0x003D03D9
		public ISurvivorsRougeConditionStepChestRewardT AsISurvivorsRougeConditionStepChestReward()
		{
			return this.As<ISurvivorsRougeConditionStepChestRewardT>();
		}

		// Token: 0x0601AF2A RID: 110378 RVA: 0x003D21E1 File Offset: 0x003D03E1
		public static TSurvivorsRougeConditionStepUnion FromISurvivorsRougeConditionStepChestReward(ISurvivorsRougeConditionStepChestRewardT _isurvivorsrougeconditionstepchestreward)
		{
			return new TSurvivorsRougeConditionStepUnion
			{
				Type = TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepChestReward,
				Value = _isurvivorsrougeconditionstepchestreward
			};
		}

		// Token: 0x0601AF2B RID: 110379 RVA: 0x003D21F6 File Offset: 0x003D03F6
		public ISurvivorsRougeConditionStepChooseItemT AsISurvivorsRougeConditionStepChooseItem()
		{
			return this.As<ISurvivorsRougeConditionStepChooseItemT>();
		}

		// Token: 0x0601AF2C RID: 110380 RVA: 0x003D21FE File Offset: 0x003D03FE
		public static TSurvivorsRougeConditionStepUnion FromISurvivorsRougeConditionStepChooseItem(ISurvivorsRougeConditionStepChooseItemT _isurvivorsrougeconditionstepchooseitem)
		{
			return new TSurvivorsRougeConditionStepUnion
			{
				Type = TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepChooseItem,
				Value = _isurvivorsrougeconditionstepchooseitem
			};
		}

		// Token: 0x0601AF2D RID: 110381 RVA: 0x003D2213 File Offset: 0x003D0413
		public ISurvivorsRougeConditionStepChooseWeaponT AsISurvivorsRougeConditionStepChooseWeapon()
		{
			return this.As<ISurvivorsRougeConditionStepChooseWeaponT>();
		}

		// Token: 0x0601AF2E RID: 110382 RVA: 0x003D221B File Offset: 0x003D041B
		public static TSurvivorsRougeConditionStepUnion FromISurvivorsRougeConditionStepChooseWeapon(ISurvivorsRougeConditionStepChooseWeaponT _isurvivorsrougeconditionstepchooseweapon)
		{
			return new TSurvivorsRougeConditionStepUnion
			{
				Type = TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepChooseWeapon,
				Value = _isurvivorsrougeconditionstepchooseweapon
			};
		}

		// Token: 0x0601AF2F RID: 110383 RVA: 0x003D2230 File Offset: 0x003D0430
		public ISurvivorsRougeConditionStepEndT AsISurvivorsRougeConditionStepEnd()
		{
			return this.As<ISurvivorsRougeConditionStepEndT>();
		}

		// Token: 0x0601AF30 RID: 110384 RVA: 0x003D2238 File Offset: 0x003D0438
		public static TSurvivorsRougeConditionStepUnion FromISurvivorsRougeConditionStepEnd(ISurvivorsRougeConditionStepEndT _isurvivorsrougeconditionstepend)
		{
			return new TSurvivorsRougeConditionStepUnion
			{
				Type = TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepEnd,
				Value = _isurvivorsrougeconditionstepend
			};
		}

		// Token: 0x0601AF31 RID: 110385 RVA: 0x003D224D File Offset: 0x003D044D
		public ISurvivorsRougeConditionStepPrepareT AsISurvivorsRougeConditionStepPrepare()
		{
			return this.As<ISurvivorsRougeConditionStepPrepareT>();
		}

		// Token: 0x0601AF32 RID: 110386 RVA: 0x003D2255 File Offset: 0x003D0455
		public static TSurvivorsRougeConditionStepUnion FromISurvivorsRougeConditionStepPrepare(ISurvivorsRougeConditionStepPrepareT _isurvivorsrougeconditionstepprepare)
		{
			return new TSurvivorsRougeConditionStepUnion
			{
				Type = TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepPrepare,
				Value = _isurvivorsrougeconditionstepprepare
			};
		}

		// Token: 0x0601AF33 RID: 110387 RVA: 0x003D226A File Offset: 0x003D046A
		public ISurvivorsRougeConditionStepShoppingT AsISurvivorsRougeConditionStepShopping()
		{
			return this.As<ISurvivorsRougeConditionStepShoppingT>();
		}

		// Token: 0x0601AF34 RID: 110388 RVA: 0x003D2272 File Offset: 0x003D0472
		public static TSurvivorsRougeConditionStepUnion FromISurvivorsRougeConditionStepShopping(ISurvivorsRougeConditionStepShoppingT _isurvivorsrougeconditionstepshopping)
		{
			return new TSurvivorsRougeConditionStepUnion
			{
				Type = TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepShopping,
				Value = _isurvivorsrougeconditionstepshopping
			};
		}

		// Token: 0x0601AF35 RID: 110389 RVA: 0x003D2288 File Offset: 0x003D0488
		public static int Pack(FlatBufferBuilder builder, TSurvivorsRougeConditionStepUnion _o)
		{
			switch (_o.Type)
			{
			case TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepBattle:
				return ISurvivorsRougeConditionStepBattle.Pack(builder, _o.AsISurvivorsRougeConditionStepBattle()).Value;
			case TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepChestReward:
				return ISurvivorsRougeConditionStepChestReward.Pack(builder, _o.AsISurvivorsRougeConditionStepChestReward()).Value;
			case TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepChooseItem:
				return ISurvivorsRougeConditionStepChooseItem.Pack(builder, _o.AsISurvivorsRougeConditionStepChooseItem()).Value;
			case TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepChooseWeapon:
				return ISurvivorsRougeConditionStepChooseWeapon.Pack(builder, _o.AsISurvivorsRougeConditionStepChooseWeapon()).Value;
			case TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepEnd:
				return ISurvivorsRougeConditionStepEnd.Pack(builder, _o.AsISurvivorsRougeConditionStepEnd()).Value;
			case TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepPrepare:
				return ISurvivorsRougeConditionStepPrepare.Pack(builder, _o.AsISurvivorsRougeConditionStepPrepare()).Value;
			case TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepShopping:
				return ISurvivorsRougeConditionStepShopping.Pack(builder, _o.AsISurvivorsRougeConditionStepShopping()).Value;
			default:
				return 0;
			}
		}
	}
}
