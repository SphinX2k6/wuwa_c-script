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
	// Token: 0x02004294 RID: 17044
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaNormalLogic : PhantomArenaCardLogic
	{
		// Token: 0x0602B21F RID: 176671 RVA: 0x00C1F951 File Offset: 0x00C1DB51
		public PhantomArenaNormalLogic(PhantomArenaCard card, PhantomArenaBattleProxy viewProxy) : base(card, viewProxy)
		{
		}

		// Token: 0x0602B220 RID: 176672 RVA: 0x00C1F95C File Offset: 0x00C1DB5C
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

		// Token: 0x0602B221 RID: 176673 RVA: 0x00C1FA2C File Offset: 0x00C1DC2C
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

		// Token: 0x0602B222 RID: 176674 RVA: 0x00C1FAA4 File Offset: 0x00C1DCA4
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

		// Token: 0x0602B223 RID: 176675 RVA: 0x00C1FB0C File Offset: 0x00C1DD0C
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

		// Token: 0x0602B224 RID: 176676 RVA: 0x00C1FBD8 File Offset: 0x00C1DDD8
		protected override Tuple<bool, EPhantomCardSettingFailReason> OnCheckRecycleSettingConditionFromHead()
		{
			if (this.Card.Data.UseCost == 0)
			{
				return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.CantDragToRecycle);
			}
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(true, EPhantomCardSettingFailReason.None);
		}

		// Token: 0x0602B225 RID: 176677 RVA: 0x00C1FC03 File Offset: 0x00C1DE03
		protected override Tuple<bool, EPhantomCardSettingFailReason> OnCheckRecycleSettingConditionFromFunctional()
		{
			if (this.Card.Data.UseCost == 0)
			{
				return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.CantDragToRecycle);
			}
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(true, EPhantomCardSettingFailReason.None);
		}

		// Token: 0x0602B226 RID: 176678 RVA: 0x00C1FC30 File Offset: 0x00C1DE30
		protected override void OnBeforeStart()
		{
			CardSkillComponent component = this.Card.GetComponent<CardSkillComponent>(ECardItemComponent.CardSkillComponent);
			if (component != null)
			{
				component.SkillBtnClick = new Action(base.SkillBtnClick);
			}
		}

		// Token: 0x0602B227 RID: 176679 RVA: 0x00C1FC60 File Offset: 0x00C1DE60
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

		// Token: 0x0602B228 RID: 176680 RVA: 0x00C1FCD4 File Offset: 0x00C1DED4
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

		// Token: 0x0602B229 RID: 176681 RVA: 0x00C1FDA0 File Offset: 0x00C1DFA0
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

		// Token: 0x0602B22A RID: 176682 RVA: 0x00C1FE1C File Offset: 0x00C1E01C
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
