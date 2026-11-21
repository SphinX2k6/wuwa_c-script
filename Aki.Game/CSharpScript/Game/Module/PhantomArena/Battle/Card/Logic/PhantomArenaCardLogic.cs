using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.Guide;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card.Logic
{
	// Token: 0x02004291 RID: 17041
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PhantomArenaCardLogic
	{
		// Token: 0x0602B205 RID: 176645 RVA: 0x00C1F78D File Offset: 0x00C1D98D
		public PhantomArenaCardLogic(PhantomArenaCard card, PhantomArenaBattleProxy viewProxy)
		{
			this.Card = card;
			this.ViewProxy = viewProxy;
		}

		// Token: 0x0602B206 RID: 176646 RVA: 0x00C1F7A3 File Offset: 0x00C1D9A3
		public Tuple<bool, EPhantomCardSettingFailReason> CheckRecycleSettingConditionFromHead()
		{
			return this.OnCheckRecycleSettingConditionFromHead();
		}

		// Token: 0x0602B207 RID: 176647 RVA: 0x00C1F7AB File Offset: 0x00C1D9AB
		public Tuple<bool, EPhantomCardSettingFailReason> CheckRecycleSettingConditionFromFunctional()
		{
			return this.OnCheckRecycleSettingConditionFromFunctional();
		}

		// Token: 0x0602B208 RID: 176648
		public abstract Tuple<bool, EPhantomCardSettingFailReason> CheckFunctionalSettingCondition(PhantomArenaCard oldCard);

		// Token: 0x0602B209 RID: 176649
		public abstract Tuple<bool, EPhantomCardSettingFailReason> CheckMonsterSettingCondition(PhantomArenaCard oldCard);

		// Token: 0x0602B20A RID: 176650
		protected abstract Tuple<bool, EPhantomCardSettingFailReason> OnCheckRecycleSettingConditionFromHead();

		// Token: 0x0602B20B RID: 176651
		protected abstract Tuple<bool, EPhantomCardSettingFailReason> OnCheckRecycleSettingConditionFromFunctional();

		// Token: 0x0602B20C RID: 176652 RVA: 0x00C1F7B3 File Offset: 0x00C1D9B3
		public void BeforeStart()
		{
			this.OnBeforeStart();
		}

		// Token: 0x0602B20D RID: 176653 RVA: 0x00C1F7BB File Offset: 0x00C1D9BB
		public virtual List<TCardComponentsRegisterInfoByResourceId> GetComponentsDataList()
		{
			return new List<TCardComponentsRegisterInfoByResourceId>();
		}

		// Token: 0x0602B20E RID: 176654 RVA: 0x00C1F7C2 File Offset: 0x00C1D9C2
		public void Refresh(PhantomCardData data)
		{
			this.Card.Data = data;
			this.OnRefresh();
		}

		// Token: 0x0602B20F RID: 176655 RVA: 0x00C1F7D6 File Offset: 0x00C1D9D6
		public void SetSelectedState(bool value)
		{
			this.OnSetSelectedState(value);
		}

		// Token: 0x0602B210 RID: 176656 RVA: 0x00C1F7E0 File Offset: 0x00C1D9E0
		public UniTask RefreshEffect(int curEffectCount)
		{
			PhantomArenaCardLogic.<RefreshEffect>d__13 <RefreshEffect>d__;
			<RefreshEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEffect>d__.<>4__this = this;
			<RefreshEffect>d__.curEffectCount = curEffectCount;
			<RefreshEffect>d__.<>1__state = -1;
			<RefreshEffect>d__.<>t__builder.Start<PhantomArenaCardLogic.<RefreshEffect>d__13>(ref <RefreshEffect>d__);
			return <RefreshEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602B211 RID: 176657 RVA: 0x00C1F82C File Offset: 0x00C1DA2C
		public void TryFinishCurrentGuide()
		{
			PhantomArenaGuideCardSkillData phantomArenaGuideCardSkillData = new PhantomArenaGuideCardSkillData
			{
				CardId = this.Card.Data.CardId
			};
			this.ViewProxy.GuideManager.TryFinishGuideByType(EBvbPlayerOperationType.BvbUseItemCardSkill, new object[]
			{
				phantomArenaGuideCardSkillData
			});
		}

		// Token: 0x0602B212 RID: 176658 RVA: 0x00C1F870 File Offset: 0x00C1DA70
		protected virtual void OnBeforeStart()
		{
		}

		// Token: 0x0602B213 RID: 176659 RVA: 0x00C1F872 File Offset: 0x00C1DA72
		protected virtual void OnRefresh()
		{
		}

		// Token: 0x0602B214 RID: 176660 RVA: 0x00C1F874 File Offset: 0x00C1DA74
		protected virtual void OnSetSelectedState(bool value)
		{
		}

		// Token: 0x0602B215 RID: 176661 RVA: 0x00C1F876 File Offset: 0x00C1DA76
		protected virtual UniTask OnRefreshEffect(int curEffectCount)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602B216 RID: 176662 RVA: 0x00C1F87D File Offset: 0x00C1DA7D
		protected void SkillBtnClick()
		{
			this.TriggerToolActiveSkill().Forget();
		}

		// Token: 0x0602B217 RID: 176663 RVA: 0x00C1F88C File Offset: 0x00C1DA8C
		private UniTask TriggerToolActiveSkill()
		{
			PhantomArenaCardLogic.<TriggerToolActiveSkill>d__20 <TriggerToolActiveSkill>d__;
			<TriggerToolActiveSkill>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TriggerToolActiveSkill>d__.<>4__this = this;
			<TriggerToolActiveSkill>d__.<>1__state = -1;
			<TriggerToolActiveSkill>d__.<>t__builder.Start<PhantomArenaCardLogic.<TriggerToolActiveSkill>d__20>(ref <TriggerToolActiveSkill>d__);
			return <TriggerToolActiveSkill>d__.<>t__builder.Task;
		}

		// Token: 0x040174E1 RID: 95457
		protected PhantomArenaCard Card;

		// Token: 0x040174E2 RID: 95458
		protected PhantomArenaBattleProxy ViewProxy;
	}
}
