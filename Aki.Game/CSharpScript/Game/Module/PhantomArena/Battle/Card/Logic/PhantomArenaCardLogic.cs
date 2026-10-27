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
	// Token: 0x020052C1 RID: 21185
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PhantomArenaCardLogic
	{
		// Token: 0x0603630A RID: 221962 RVA: 0x00CD2065 File Offset: 0x00CD0265
		public PhantomArenaCardLogic(PhantomArenaCard card, PhantomArenaBattleProxy viewProxy)
		{
			this.Card = card;
			this.ViewProxy = viewProxy;
		}

		// Token: 0x0603630B RID: 221963 RVA: 0x00CD207B File Offset: 0x00CD027B
		public Tuple<bool, EPhantomCardSettingFailReason> CheckRecycleSettingConditionFromHead()
		{
			return this.OnCheckRecycleSettingConditionFromHead();
		}

		// Token: 0x0603630C RID: 221964 RVA: 0x00CD2083 File Offset: 0x00CD0283
		public Tuple<bool, EPhantomCardSettingFailReason> CheckRecycleSettingConditionFromFunctional()
		{
			return this.OnCheckRecycleSettingConditionFromFunctional();
		}

		// Token: 0x0603630D RID: 221965
		public abstract Tuple<bool, EPhantomCardSettingFailReason> CheckFunctionalSettingCondition(PhantomArenaCard oldCard);

		// Token: 0x0603630E RID: 221966
		public abstract Tuple<bool, EPhantomCardSettingFailReason> CheckMonsterSettingCondition(PhantomArenaCard oldCard);

		// Token: 0x0603630F RID: 221967
		protected abstract Tuple<bool, EPhantomCardSettingFailReason> OnCheckRecycleSettingConditionFromHead();

		// Token: 0x06036310 RID: 221968
		protected abstract Tuple<bool, EPhantomCardSettingFailReason> OnCheckRecycleSettingConditionFromFunctional();

		// Token: 0x06036311 RID: 221969 RVA: 0x00CD208B File Offset: 0x00CD028B
		public void BeforeStart()
		{
			this.OnBeforeStart();
		}

		// Token: 0x06036312 RID: 221970 RVA: 0x00CD2093 File Offset: 0x00CD0293
		public virtual List<TCardComponentsRegisterInfoByResourceId> GetComponentsDataList()
		{
			return new List<TCardComponentsRegisterInfoByResourceId>();
		}

		// Token: 0x06036313 RID: 221971 RVA: 0x00CD209A File Offset: 0x00CD029A
		public void Refresh(PhantomCardData data)
		{
			this.Card.Data = data;
			this.OnRefresh();
		}

		// Token: 0x06036314 RID: 221972 RVA: 0x00CD20AE File Offset: 0x00CD02AE
		public void SetSelectedState(bool value)
		{
			this.OnSetSelectedState(value);
		}

		// Token: 0x06036315 RID: 221973 RVA: 0x00CD20B8 File Offset: 0x00CD02B8
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

		// Token: 0x06036316 RID: 221974 RVA: 0x00CD2104 File Offset: 0x00CD0304
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

		// Token: 0x06036317 RID: 221975 RVA: 0x00CD2148 File Offset: 0x00CD0348
		protected virtual void OnBeforeStart()
		{
		}

		// Token: 0x06036318 RID: 221976 RVA: 0x00CD214A File Offset: 0x00CD034A
		protected virtual void OnRefresh()
		{
		}

		// Token: 0x06036319 RID: 221977 RVA: 0x00CD214C File Offset: 0x00CD034C
		protected virtual void OnSetSelectedState(bool value)
		{
		}

		// Token: 0x0603631A RID: 221978 RVA: 0x00CD214E File Offset: 0x00CD034E
		protected virtual UniTask OnRefreshEffect(int curEffectCount)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0603631B RID: 221979 RVA: 0x00CD2155 File Offset: 0x00CD0355
		protected void SkillBtnClick()
		{
			this.TriggerToolActiveSkill().Forget();
		}

		// Token: 0x0603631C RID: 221980 RVA: 0x00CD2164 File Offset: 0x00CD0364
		private UniTask TriggerToolActiveSkill()
		{
			PhantomArenaCardLogic.<TriggerToolActiveSkill>d__20 <TriggerToolActiveSkill>d__;
			<TriggerToolActiveSkill>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TriggerToolActiveSkill>d__.<>4__this = this;
			<TriggerToolActiveSkill>d__.<>1__state = -1;
			<TriggerToolActiveSkill>d__.<>t__builder.Start<PhantomArenaCardLogic.<TriggerToolActiveSkill>d__20>(ref <TriggerToolActiveSkill>d__);
			return <TriggerToolActiveSkill>d__.<>t__builder.Task;
		}

		// Token: 0x0401CAAC RID: 117420
		protected PhantomArenaCard Card;

		// Token: 0x0401CAAD RID: 117421
		protected PhantomArenaBattleProxy ViewProxy;
	}
}
