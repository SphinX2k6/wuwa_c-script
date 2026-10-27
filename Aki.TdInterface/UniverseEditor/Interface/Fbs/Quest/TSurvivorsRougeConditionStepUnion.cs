using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200431B RID: 17179
	public class TSurvivorsRougeConditionStepUnion
	{
		// Token: 0x17007974 RID: 31092
		// (get) Token: 0x0601979F RID: 104351 RVA: 0x003A6842 File Offset: 0x003A4A42
		// (set) Token: 0x060197A0 RID: 104352 RVA: 0x003A684A File Offset: 0x003A4A4A
		public TSurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x17007975 RID: 31093
		// (get) Token: 0x060197A1 RID: 104353 RVA: 0x003A6853 File Offset: 0x003A4A53
		// (set) Token: 0x060197A2 RID: 104354 RVA: 0x003A685B File Offset: 0x003A4A5B
		public object Value { get; set; }

		// Token: 0x060197A3 RID: 104355 RVA: 0x003A6864 File Offset: 0x003A4A64
		public TSurvivorsRougeConditionStepUnion()
		{
			this.Type = TSurvivorsRougeConditionStep.NONE;
			this.Value = null;
		}

		// Token: 0x060197A4 RID: 104356 RVA: 0x003A687A File Offset: 0x003A4A7A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060197A5 RID: 104357 RVA: 0x003A688C File Offset: 0x003A4A8C
		public ISurvivorsRougeConditionStepBattleT AsISurvivorsRougeConditionStepBattle()
		{
			return this.As<ISurvivorsRougeConditionStepBattleT>();
		}

		// Token: 0x060197A6 RID: 104358 RVA: 0x003A6894 File Offset: 0x003A4A94
		public static TSurvivorsRougeConditionStepUnion FromISurvivorsRougeConditionStepBattle(ISurvivorsRougeConditionStepBattleT _isurvivorsrougeconditionstepbattle)
		{
			return new TSurvivorsRougeConditionStepUnion
			{
				Type = TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepBattle,
				Value = _isurvivorsrougeconditionstepbattle
			};
		}

		// Token: 0x060197A7 RID: 104359 RVA: 0x003A68A9 File Offset: 0x003A4AA9
		public ISurvivorsRougeConditionStepChestRewardT AsISurvivorsRougeConditionStepChestReward()
		{
			return this.As<ISurvivorsRougeConditionStepChestRewardT>();
		}

		// Token: 0x060197A8 RID: 104360 RVA: 0x003A68B1 File Offset: 0x003A4AB1
		public static TSurvivorsRougeConditionStepUnion FromISurvivorsRougeConditionStepChestReward(ISurvivorsRougeConditionStepChestRewardT _isurvivorsrougeconditionstepchestreward)
		{
			return new TSurvivorsRougeConditionStepUnion
			{
				Type = TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepChestReward,
				Value = _isurvivorsrougeconditionstepchestreward
			};
		}

		// Token: 0x060197A9 RID: 104361 RVA: 0x003A68C6 File Offset: 0x003A4AC6
		public ISurvivorsRougeConditionStepChooseItemT AsISurvivorsRougeConditionStepChooseItem()
		{
			return this.As<ISurvivorsRougeConditionStepChooseItemT>();
		}

		// Token: 0x060197AA RID: 104362 RVA: 0x003A68CE File Offset: 0x003A4ACE
		public static TSurvivorsRougeConditionStepUnion FromISurvivorsRougeConditionStepChooseItem(ISurvivorsRougeConditionStepChooseItemT _isurvivorsrougeconditionstepchooseitem)
		{
			return new TSurvivorsRougeConditionStepUnion
			{
				Type = TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepChooseItem,
				Value = _isurvivorsrougeconditionstepchooseitem
			};
		}

		// Token: 0x060197AB RID: 104363 RVA: 0x003A68E3 File Offset: 0x003A4AE3
		public ISurvivorsRougeConditionStepChooseWeaponT AsISurvivorsRougeConditionStepChooseWeapon()
		{
			return this.As<ISurvivorsRougeConditionStepChooseWeaponT>();
		}

		// Token: 0x060197AC RID: 104364 RVA: 0x003A68EB File Offset: 0x003A4AEB
		public static TSurvivorsRougeConditionStepUnion FromISurvivorsRougeConditionStepChooseWeapon(ISurvivorsRougeConditionStepChooseWeaponT _isurvivorsrougeconditionstepchooseweapon)
		{
			return new TSurvivorsRougeConditionStepUnion
			{
				Type = TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepChooseWeapon,
				Value = _isurvivorsrougeconditionstepchooseweapon
			};
		}

		// Token: 0x060197AD RID: 104365 RVA: 0x003A6900 File Offset: 0x003A4B00
		public ISurvivorsRougeConditionStepEndT AsISurvivorsRougeConditionStepEnd()
		{
			return this.As<ISurvivorsRougeConditionStepEndT>();
		}

		// Token: 0x060197AE RID: 104366 RVA: 0x003A6908 File Offset: 0x003A4B08
		public static TSurvivorsRougeConditionStepUnion FromISurvivorsRougeConditionStepEnd(ISurvivorsRougeConditionStepEndT _isurvivorsrougeconditionstepend)
		{
			return new TSurvivorsRougeConditionStepUnion
			{
				Type = TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepEnd,
				Value = _isurvivorsrougeconditionstepend
			};
		}

		// Token: 0x060197AF RID: 104367 RVA: 0x003A691D File Offset: 0x003A4B1D
		public ISurvivorsRougeConditionStepPrepareT AsISurvivorsRougeConditionStepPrepare()
		{
			return this.As<ISurvivorsRougeConditionStepPrepareT>();
		}

		// Token: 0x060197B0 RID: 104368 RVA: 0x003A6925 File Offset: 0x003A4B25
		public static TSurvivorsRougeConditionStepUnion FromISurvivorsRougeConditionStepPrepare(ISurvivorsRougeConditionStepPrepareT _isurvivorsrougeconditionstepprepare)
		{
			return new TSurvivorsRougeConditionStepUnion
			{
				Type = TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepPrepare,
				Value = _isurvivorsrougeconditionstepprepare
			};
		}

		// Token: 0x060197B1 RID: 104369 RVA: 0x003A693A File Offset: 0x003A4B3A
		public ISurvivorsRougeConditionStepShoppingT AsISurvivorsRougeConditionStepShopping()
		{
			return this.As<ISurvivorsRougeConditionStepShoppingT>();
		}

		// Token: 0x060197B2 RID: 104370 RVA: 0x003A6942 File Offset: 0x003A4B42
		public static TSurvivorsRougeConditionStepUnion FromISurvivorsRougeConditionStepShopping(ISurvivorsRougeConditionStepShoppingT _isurvivorsrougeconditionstepshopping)
		{
			return new TSurvivorsRougeConditionStepUnion
			{
				Type = TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepShopping,
				Value = _isurvivorsrougeconditionstepshopping
			};
		}

		// Token: 0x060197B3 RID: 104371 RVA: 0x003A6958 File Offset: 0x003A4B58
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
