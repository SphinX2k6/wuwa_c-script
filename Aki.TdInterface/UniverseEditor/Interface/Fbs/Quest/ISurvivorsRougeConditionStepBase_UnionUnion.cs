using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004155 RID: 16725
	public class ISurvivorsRougeConditionStepBase_UnionUnion
	{
		// Token: 0x17007687 RID: 30343
		// (get) Token: 0x060188F8 RID: 100600 RVA: 0x0038A37D File Offset: 0x0038857D
		// (set) Token: 0x060188F9 RID: 100601 RVA: 0x0038A385 File Offset: 0x00388585
		public ISurvivorsRougeConditionStepBase_Union Type { get; set; }

		// Token: 0x17007688 RID: 30344
		// (get) Token: 0x060188FA RID: 100602 RVA: 0x0038A38E File Offset: 0x0038858E
		// (set) Token: 0x060188FB RID: 100603 RVA: 0x0038A396 File Offset: 0x00388596
		public object Value { get; set; }

		// Token: 0x060188FC RID: 100604 RVA: 0x0038A39F File Offset: 0x0038859F
		public ISurvivorsRougeConditionStepBase_UnionUnion()
		{
			this.Type = ISurvivorsRougeConditionStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060188FD RID: 100605 RVA: 0x0038A3B5 File Offset: 0x003885B5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060188FE RID: 100606 RVA: 0x0038A3C7 File Offset: 0x003885C7
		public ISurvivorsRougeConditionStepBaseT AsISurvivorsRougeConditionStepBase()
		{
			return this.As<ISurvivorsRougeConditionStepBaseT>();
		}

		// Token: 0x060188FF RID: 100607 RVA: 0x0038A3CF File Offset: 0x003885CF
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepBase(ISurvivorsRougeConditionStepBaseT _isurvivorsrougeconditionstepbase)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepBase,
				Value = _isurvivorsrougeconditionstepbase
			};
		}

		// Token: 0x06018900 RID: 100608 RVA: 0x0038A3E4 File Offset: 0x003885E4
		public ISurvivorsRougeConditionStepPrepareT AsISurvivorsRougeConditionStepPrepare()
		{
			return this.As<ISurvivorsRougeConditionStepPrepareT>();
		}

		// Token: 0x06018901 RID: 100609 RVA: 0x0038A3EC File Offset: 0x003885EC
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepPrepare(ISurvivorsRougeConditionStepPrepareT _isurvivorsrougeconditionstepprepare)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepPrepare,
				Value = _isurvivorsrougeconditionstepprepare
			};
		}

		// Token: 0x06018902 RID: 100610 RVA: 0x0038A401 File Offset: 0x00388601
		public ISurvivorsRougeConditionStepBattleT AsISurvivorsRougeConditionStepBattle()
		{
			return this.As<ISurvivorsRougeConditionStepBattleT>();
		}

		// Token: 0x06018903 RID: 100611 RVA: 0x0038A409 File Offset: 0x00388609
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepBattle(ISurvivorsRougeConditionStepBattleT _isurvivorsrougeconditionstepbattle)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepBattle,
				Value = _isurvivorsrougeconditionstepbattle
			};
		}

		// Token: 0x06018904 RID: 100612 RVA: 0x0038A41E File Offset: 0x0038861E
		public ISurvivorsRougeConditionStepEndT AsISurvivorsRougeConditionStepEnd()
		{
			return this.As<ISurvivorsRougeConditionStepEndT>();
		}

		// Token: 0x06018905 RID: 100613 RVA: 0x0038A426 File Offset: 0x00388626
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepEnd(ISurvivorsRougeConditionStepEndT _isurvivorsrougeconditionstepend)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepEnd,
				Value = _isurvivorsrougeconditionstepend
			};
		}

		// Token: 0x06018906 RID: 100614 RVA: 0x0038A43B File Offset: 0x0038863B
		public ISurvivorsRougeConditionStepChestRewardT AsISurvivorsRougeConditionStepChestReward()
		{
			return this.As<ISurvivorsRougeConditionStepChestRewardT>();
		}

		// Token: 0x06018907 RID: 100615 RVA: 0x0038A443 File Offset: 0x00388643
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepChestReward(ISurvivorsRougeConditionStepChestRewardT _isurvivorsrougeconditionstepchestreward)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepChestReward,
				Value = _isurvivorsrougeconditionstepchestreward
			};
		}

		// Token: 0x06018908 RID: 100616 RVA: 0x0038A458 File Offset: 0x00388658
		public ISurvivorsRougeConditionStepChooseWeaponT AsISurvivorsRougeConditionStepChooseWeapon()
		{
			return this.As<ISurvivorsRougeConditionStepChooseWeaponT>();
		}

		// Token: 0x06018909 RID: 100617 RVA: 0x0038A460 File Offset: 0x00388660
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepChooseWeapon(ISurvivorsRougeConditionStepChooseWeaponT _isurvivorsrougeconditionstepchooseweapon)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepChooseWeapon,
				Value = _isurvivorsrougeconditionstepchooseweapon
			};
		}

		// Token: 0x0601890A RID: 100618 RVA: 0x0038A475 File Offset: 0x00388675
		public ISurvivorsRougeConditionStepChooseItemT AsISurvivorsRougeConditionStepChooseItem()
		{
			return this.As<ISurvivorsRougeConditionStepChooseItemT>();
		}

		// Token: 0x0601890B RID: 100619 RVA: 0x0038A47D File Offset: 0x0038867D
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepChooseItem(ISurvivorsRougeConditionStepChooseItemT _isurvivorsrougeconditionstepchooseitem)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepChooseItem,
				Value = _isurvivorsrougeconditionstepchooseitem
			};
		}

		// Token: 0x0601890C RID: 100620 RVA: 0x0038A492 File Offset: 0x00388692
		public ISurvivorsRougeConditionStepShoppingT AsISurvivorsRougeConditionStepShopping()
		{
			return this.As<ISurvivorsRougeConditionStepShoppingT>();
		}

		// Token: 0x0601890D RID: 100621 RVA: 0x0038A49A File Offset: 0x0038869A
		public static ISurvivorsRougeConditionStepBase_UnionUnion FromISurvivorsRougeConditionStepShopping(ISurvivorsRougeConditionStepShoppingT _isurvivorsrougeconditionstepshopping)
		{
			return new ISurvivorsRougeConditionStepBase_UnionUnion
			{
				Type = ISurvivorsRougeConditionStepBase_Union.ISurvivorsRougeConditionStepShopping,
				Value = _isurvivorsrougeconditionstepshopping
			};
		}

		// Token: 0x0601890E RID: 100622 RVA: 0x0038A4B0 File Offset: 0x003886B0
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
