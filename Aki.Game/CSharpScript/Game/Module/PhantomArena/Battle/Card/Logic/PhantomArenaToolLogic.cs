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
	// Token: 0x020052C5 RID: 21189
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaToolLogic : PhantomArenaCardLogic
	{
		// Token: 0x06036330 RID: 222000 RVA: 0x00CD273F File Offset: 0x00CD093F
		public PhantomArenaToolLogic(PhantomArenaCard card, PhantomArenaBattleProxy viewProxy) : base(card, viewProxy)
		{
		}

		// Token: 0x06036331 RID: 222001 RVA: 0x00CD2749 File Offset: 0x00CD0949
		public override Tuple<bool, EPhantomCardSettingFailReason> CheckFunctionalSettingCondition(PhantomArenaCard oldCard)
		{
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.ToolCantDragToFunctional);
		}

		// Token: 0x06036332 RID: 222002 RVA: 0x00CD2758 File Offset: 0x00CD0958
		public override Tuple<bool, EPhantomCardSettingFailReason> CheckMonsterSettingCondition(PhantomArenaCard oldCard)
		{
			if (this.Card.Data.Index == -1)
			{
				if (oldCard != null)
				{
					return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.ExistCard);
				}
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
			if (oldCard != null && !PhantomArenaBattleModel.Instance.CanSetSlotIndex(oldCard.Data.Index))
			{
				return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.WaitBattleSlotIndex);
			}
			if (!PhantomArenaBattleModel.Instance.CanSetSlotIndex(this.Card.Data.Index))
			{
				return Tuple.Create<bool, EPhantomCardSettingFailReason>(false, EPhantomCardSettingFailReason.WaitBattleSlotIndex);
			}
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(true, EPhantomCardSettingFailReason.None);
		}

		// Token: 0x06036333 RID: 222003 RVA: 0x00CD2830 File Offset: 0x00CD0A30
		protected override Tuple<bool, EPhantomCardSettingFailReason> OnCheckRecycleSettingConditionFromHead()
		{
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(true, EPhantomCardSettingFailReason.None);
		}

		// Token: 0x06036334 RID: 222004 RVA: 0x00CD283D File Offset: 0x00CD0A3D
		protected override Tuple<bool, EPhantomCardSettingFailReason> OnCheckRecycleSettingConditionFromFunctional()
		{
			return Tuple.Create<bool, EPhantomCardSettingFailReason>(true, EPhantomCardSettingFailReason.None);
		}

		// Token: 0x06036335 RID: 222005 RVA: 0x00CD284C File Offset: 0x00CD0A4C
		protected override void OnBeforeStart()
		{
			CardSkillComponent component = this.Card.GetComponent<CardSkillComponent>(ECardItemComponent.CardSkillComponent);
			if (component != null)
			{
				component.SkillBtnClick = new Action(base.SkillBtnClick);
			}
		}

		// Token: 0x06036336 RID: 222006 RVA: 0x00CD287C File Offset: 0x00CD0A7C
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

		// Token: 0x06036337 RID: 222007 RVA: 0x00CD28F0 File Offset: 0x00CD0AF0
		protected override void OnRefresh()
		{
			bool inFight = this.Card.Data.Index != -1;
			CardSkillComponentData data = new CardSkillComponentData
			{
				SkillCd = this.Card.Data.SkillCd,
				InSelect = false,
				InFight = inFight
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
				InFight = inFight
			};
			CardEffectCountComponent component2 = this.Card.GetComponent<CardEffectCountComponent>(ECardItemComponent.CardEffectCountComponent);
			if (component2 == null)
			{
				return;
			}
			component2.Refresh(data2);
		}

		// Token: 0x06036338 RID: 222008 RVA: 0x00CD29A8 File Offset: 0x00CD0BA8
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

		// Token: 0x06036339 RID: 222009 RVA: 0x00CD2A24 File Offset: 0x00CD0C24
		protected override UniTask OnRefreshEffect(int curEffectCount)
		{
			PhantomArenaToolLogic.<OnRefreshEffect>d__9 <OnRefreshEffect>d__;
			<OnRefreshEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnRefreshEffect>d__.<>4__this = this;
			<OnRefreshEffect>d__.curEffectCount = curEffectCount;
			<OnRefreshEffect>d__.<>1__state = -1;
			<OnRefreshEffect>d__.<>t__builder.Start<PhantomArenaToolLogic.<OnRefreshEffect>d__9>(ref <OnRefreshEffect>d__);
			return <OnRefreshEffect>d__.<>t__builder.Task;
		}
	}
}
