using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card.Logic
{
	// Token: 0x020052C4 RID: 21188
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaNormalLogic : PhantomArenaCardLogic
	{
		// Token: 0x06036324 RID: 221988 RVA: 0x00CD2229 File Offset: 0x00CD0429
		public PhantomArenaNormalLogic(PhantomArenaCard card, PhantomArenaBattleProxy viewProxy) : base(card, viewProxy)
		{
		}

		// Token: 0x06036325 RID: 221989 RVA: 0x00CD2234 File Offset: 0x00CD0434
		public override Tuple<bool, EPhantomCardSettingFailReason> CheckFunctionalSettingCondition(PhantomArenaCard oldCard)
		{
			if (oldCard != null)
			{
				return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.ExistCard);
			}
			if (this.Card.Data.Index == -1)
			{
				int battleStatusValue = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleCostPoint);
				if (this.Card.Data.HasActiveSkill)
				{
					int costConsume = PhantomArenaConfig.Instance.GetPhantomBattleSkillConfig(this.Card.Data.ActiveSkillId).CostConsume;
					if (battleStatusValue - costConsume < 0)
					{
						return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.NotEnoughCost);
					}
				}
			}
			if (!this.Card.Data.CanUse)
			{
				return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.CardLock);
			}
			if (!this.Card.Data.HasActiveSkill)
			{
				return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.NotHasActiveSkill);
			}
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(true, EPhantomCardSettingFailReason.None);
		}

		// Token: 0x06036326 RID: 221990 RVA: 0x00CD2304 File Offset: 0x00CD0504
		private Tuple<bool, EPhantomCardSettingFailReason> CheckCanSettingCardByEvolve(PhantomArenaCard oldCard)
		{
			if (this.Card.Data.Index == -1)
			{
				if (PhantomArenaBattleModel.Instance.OwnData.CanEvolveNum <= 0)
				{
					return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.EvolveNumLimit);
				}
				ValueTuple<bool, EPhantomCardSettingFailReason> valueTuple = oldCard.Data.IsOtherCardCanEvolve(this.Card.Data);
				if (!valueTuple.Item1)
				{
					return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, valueTuple.Item2);
				}
			}
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(true, EPhantomCardSettingFailReason.None);
		}

		// Token: 0x06036327 RID: 221991 RVA: 0x00CD237C File Offset: 0x00CD057C
		private Tuple<bool, EPhantomCardSettingFailReason> CheckCanSettingCardBySetting()
		{
			if (this.Card.Data.Index == -1)
			{
				if (PhantomArenaBattleModel.Instance.OwnData.MonsterCardLength >= 4)
				{
					return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.SettingLimit);
				}
				if (this.Card.Data.ConfigCost == 3)
				{
					return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.CantDragMonsterByThreeCost);
				}
			}
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(true, EPhantomCardSettingFailReason.None);
		}

		// Token: 0x06036328 RID: 221992 RVA: 0x00CD23E4 File Offset: 0x00CD05E4
		public override Tuple<bool, EPhantomCardSettingFailReason> CheckMonsterSettingCondition(PhantomArenaCard oldCard)
		{
			if (this.Card.Data.Index == -1)
			{
				int battleStatusValue = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleCostPoint);
				int useCost = this.Card.Data.UseCost;
				if (battleStatusValue - useCost < 0)
				{
					return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.NotEnoughCost);
				}
			}
			if (!this.Card.Data.CanUse)
			{
				return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.CardLock);
			}
			if (oldCard != null)
			{
				if (!PhantomArenaBattleModel.Instance.CanSetSlotIndex(oldCard.Data.Index))
				{
					return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.WaitBattleSlotIndex);
				}
				return this.CheckCanSettingCardByEvolve(oldCard);
			}
			else
			{
				if (!PhantomArenaBattleModel.Instance.CanSetSlotIndex(this.Card.Data.Index))
				{
					return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.WaitBattleSlotIndex);
				}
				return this.CheckCanSettingCardBySetting();
			}
		}

		// Token: 0x06036329 RID: 221993 RVA: 0x00CD24B0 File Offset: 0x00CD06B0
		protected override Tuple<bool, EPhantomCardSettingFailReason> OnCheckRecycleSettingConditionFromHead()
		{
			if (this.Card.Data.UseCost == 0)
			{
				return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.CantDragToRecycle);
			}
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(true, EPhantomCardSettingFailReason.None);
		}

		// Token: 0x0603632A RID: 221994 RVA: 0x00CD24DB File Offset: 0x00CD06DB
		protected override Tuple<bool, EPhantomCardSettingFailReason> OnCheckRecycleSettingConditionFromFunctional()
		{
			if (this.Card.Data.UseCost == 0)
			{
				return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.CantDragToRecycle);
			}
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(true, EPhantomCardSettingFailReason.None);
		}

		// Token: 0x0603632B RID: 221995 RVA: 0x00CD2508 File Offset: 0x00CD0708
		protected override void OnBeforeStart()
		{
			CardSkillComponent component = this.Card.GetComponent<CardSkillComponent>(ECardItemComponent.CardSkillComponent);
			if (component != null)
			{
				component.SkillBtnClick = new Action(base.SkillBtnClick);
			}
		}

		// Token: 0x0603632C RID: 221996 RVA: 0x00CD2538 File Offset: 0x00CD0738
		public override List<TCardComponentsRegisterInfoByResourceId> GetComponentsDataList()
		{
			List<TCardComponentsRegisterInfoByResourceId> list = new List<TCardComponentsRegisterInfoByResourceId>();
			if (this.Card.Data.HasClickActiveSkill)
			{
				list.Add(new TCardComponentsRegisterInfoByResourceId(ECardItemComponent.CardSkillComponent, "UiItem_ActiveSkill", this.Card.GetPhantomArenaCardSpineRootItem()));
			}
			if (this.Card.Data.HasCountSkill)
			{
				list.Add(new TCardComponentsRegisterInfoByResourceId(ECardItemComponent.CardEffectCountComponent, "UiItem_CardCount", this.Card.GetPhantomArenaCardSpineRootItem()));
			}
			return list;
		}

		// Token: 0x0603632D RID: 221997 RVA: 0x00CD25AC File Offset: 0x00CD07AC
		protected override void OnRefresh()
		{
			CardSkillComponentData data = new CardSkillComponentData
			{
				SkillCd = this.Card.Data.SkillCd,
				InSelect = false,
				InFight = (this.Card.Data.Index != -1)
			};
			CardSkillComponent component = this.Card.GetComponent<CardSkillComponent>(ECardItemComponent.CardSkillComponent);
			if (component != null)
			{
				component.Refresh(data);
			}
			CardEffectCountComponentData data2 = new CardEffectCountComponentData
			{
				EffectCount = this.Card.Data.CurEffectCount,
				EffectCountMax = this.Card.Data.MaxEffectCount,
				InFight = (this.Card.Data.Index != -1)
			};
			CardEffectCountComponent component2 = this.Card.GetComponent<CardEffectCountComponent>(ECardItemComponent.CardEffectCountComponent);
			if (component2 == null)
			{
				return;
			}
			component2.Refresh(data2);
		}

		// Token: 0x0603632E RID: 221998 RVA: 0x00CD2678 File Offset: 0x00CD0878
		protected override void OnSetSelectedState(bool value)
		{
			CardSkillComponentData data = new CardSkillComponentData
			{
				SkillCd = this.Card.Data.SkillCd,
				InSelect = (value && !this.Card.Data.IsNpcCard),
				InFight = (this.Card.Data.Index != -1)
			};
			CardSkillComponent component = this.Card.GetComponent<CardSkillComponent>(ECardItemComponent.CardSkillComponent);
			if (component == null)
			{
				return;
			}
			component.Refresh(data);
		}

		// Token: 0x0603632F RID: 221999 RVA: 0x00CD26F4 File Offset: 0x00CD08F4
		protected override UniTask OnRefreshEffect(int curEffectCount)
		{
			PhantomArenaNormalLogic.<OnRefreshEffect>d__11 <OnRefreshEffect>d__;
			<OnRefreshEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnRefreshEffect>d__.<>4__this = this;
			<OnRefreshEffect>d__.curEffectCount = curEffectCount;
			<OnRefreshEffect>d__.<>1__state = -1;
			<OnRefreshEffect>d__.<>t__builder.Start<PhantomArenaNormalLogic.<OnRefreshEffect>d__11>(ref <OnRefreshEffect>d__);
			return <OnRefreshEffect>d__.<>t__builder.Task;
		}
	}
}
