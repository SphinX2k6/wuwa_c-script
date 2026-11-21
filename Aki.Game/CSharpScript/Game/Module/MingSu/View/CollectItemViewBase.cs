using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MingSu.View
{
	// Token: 0x020043B9 RID: 17337
	public class CollectItemViewBase : UiViewBase
	{
		// Token: 0x0602BCF9 RID: 179449 RVA: 0x00C4CF98 File Offset: 0x00C4B198
		[NullableContext(1)]
		public CollectItemViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BCFA RID: 179450 RVA: 0x00C4CFA4 File Offset: 0x00C4B1A4
		protected override void OnStart()
		{
			MingSuModel instance = MingSuModel.Instance;
			this.PoolConfigId = instance.GetCurrentDragonPoolId();
			this.CollectItemConfigId = instance.GetCollectItemConfigId();
			this.CurrentShowLevel = instance.GetTargetDragonPoolLevelById(this.PoolConfigId) + 1;
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Add(EEventName.OnAntiqueShopUpgradeSequencePlayFail, new Action(this.OnSubmitItemLevelUpSequencePlayFailCallback));
			EventSystem.Instance.Add(EEventName.UpdateDragonPoolView, new Action(this.OnUpdateDragonPoolViewCallback));
			EventSystem.Instance.Add(EEventName.OnAntiqueShopLevelMaxSequenceFinished, new Action(this.OnLevelMaxSequenceFinishedCallback));
			EventSystem.Instance.Add(EEventName.OnAntiqueShopUpgradeSequenceFinished, new Action(this.OnLevelUpSequenceFinishedCallback));
			MingSuModel.Instance.CurrentInteractCreatureDataLongId = InteractionModel.Instance.InteractCreatureDataLongId;
			this.OnBegined();
		}

		// Token: 0x0602BCFB RID: 179451 RVA: 0x00C4D088 File Offset: 0x00C4B288
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove(EEventName.OnAntiqueShopUpgradeSequencePlayFail, new Action(this.OnSubmitItemLevelUpSequencePlayFailCallback));
			EventSystem.Instance.Remove(EEventName.UpdateDragonPoolView, new Action(this.OnUpdateDragonPoolViewCallback));
			EventSystem.Instance.Remove(EEventName.OnAntiqueShopLevelMaxSequenceFinished, new Action(this.OnLevelMaxSequenceFinishedCallback));
			EventSystem.Instance.Remove(EEventName.OnAntiqueShopUpgradeSequenceFinished, new Action(this.OnLevelUpSequenceFinishedCallback));
			this.OnEnded();
		}

		// Token: 0x0602BCFC RID: 179452 RVA: 0x00C4D124 File Offset: 0x00C4B324
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnSubmitItemLevelUp, new Action(this.OnSubmitItemLevelUpCallback));
			EventSystem.Instance.Add(EEventName.OnSubmitItemLevelMax, new Action(this.OnSubmitItemLevelMaxCallback));
			EventSystem.Instance.Add(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x0602BCFD RID: 179453 RVA: 0x00C4D188 File Offset: 0x00C4B388
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnSubmitItemLevelUp, new Action(this.OnSubmitItemLevelUpCallback));
			EventSystem.Instance.Remove(EEventName.OnSubmitItemLevelMax, new Action(this.OnSubmitItemLevelMaxCallback));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x0602BCFE RID: 179454 RVA: 0x00C4D1E9 File Offset: 0x00C4B3E9
		private void OnUpdateDragonPoolViewCallback()
		{
			this.OnUpdateDragonPoolView();
		}

		// Token: 0x0602BCFF RID: 179455 RVA: 0x00C4D1F1 File Offset: 0x00C4B3F1
		private void OnSubmitItemLevelUpCallback()
		{
			this.OnSubmitItemLevelUp();
		}

		// Token: 0x0602BD00 RID: 179456 RVA: 0x00C4D1F9 File Offset: 0x00C4B3F9
		private void OnSubmitItemLevelMaxCallback()
		{
			this.OnSubmitItemLevelUp();
		}

		// Token: 0x0602BD01 RID: 179457 RVA: 0x00C4D201 File Offset: 0x00C4B401
		private void OnLevelMaxSequenceFinishedCallback()
		{
			this.OnLevelMaxSequenceFinished();
		}

		// Token: 0x0602BD02 RID: 179458 RVA: 0x00C4D209 File Offset: 0x00C4B409
		private void OnLevelUpSequenceFinishedCallback()
		{
			this.OnLevelUpSequenceFinished();
		}

		// Token: 0x0602BD03 RID: 179459 RVA: 0x00C4D211 File Offset: 0x00C4B411
		private void OnSubmitItemLevelUpSequencePlayFailCallback()
		{
			this.OnSubmitItemLevelUpSequencePlayFail();
		}

		// Token: 0x0602BD04 RID: 179460 RVA: 0x00C4D219 File Offset: 0x00C4B419
		private void OnCommonItemCountAnyChange(int configId, int count)
		{
			if (configId != this.CollectItemConfigId)
			{
				return;
			}
			this.OnCollectItemCountChanged(count);
		}

		// Token: 0x0602BD05 RID: 179461 RVA: 0x00C4D22C File Offset: 0x00C4B42C
		private void OnCloseView(EUiViewName viewName, int id)
		{
			if (viewName != EUiViewName.CompositeRewardView)
			{
				return;
			}
			this.OnCloseRewardView();
		}

		// Token: 0x0602BD06 RID: 179462 RVA: 0x00C4D242 File Offset: 0x00C4B442
		protected virtual void OnBegined()
		{
		}

		// Token: 0x0602BD07 RID: 179463 RVA: 0x00C4D244 File Offset: 0x00C4B444
		protected virtual void OnEnded()
		{
		}

		// Token: 0x0602BD08 RID: 179464 RVA: 0x00C4D246 File Offset: 0x00C4B446
		protected virtual void OnUpdateDragonPoolView()
		{
		}

		// Token: 0x0602BD09 RID: 179465 RVA: 0x00C4D248 File Offset: 0x00C4B448
		protected virtual void OnSubmitItemLevelUp()
		{
		}

		// Token: 0x0602BD0A RID: 179466 RVA: 0x00C4D24A File Offset: 0x00C4B44A
		protected virtual void OnSubmitItemLevelMax()
		{
		}

		// Token: 0x0602BD0B RID: 179467 RVA: 0x00C4D24C File Offset: 0x00C4B44C
		protected virtual void OnLevelMaxSequenceFinished()
		{
		}

		// Token: 0x0602BD0C RID: 179468 RVA: 0x00C4D24E File Offset: 0x00C4B44E
		protected virtual void OnLevelUpSequenceFinished()
		{
		}

		// Token: 0x0602BD0D RID: 179469 RVA: 0x00C4D250 File Offset: 0x00C4B450
		protected virtual void OnSubmitItemLevelUpSequencePlayFail()
		{
		}

		// Token: 0x0602BD0E RID: 179470 RVA: 0x00C4D252 File Offset: 0x00C4B452
		protected virtual void OnCloseRewardView()
		{
		}

		// Token: 0x0602BD0F RID: 179471 RVA: 0x00C4D254 File Offset: 0x00C4B454
		protected virtual void OnCollectItemCountChanged(int count)
		{
		}

		// Token: 0x040179CB RID: 96715
		protected int PoolConfigId;

		// Token: 0x040179CC RID: 96716
		protected int CollectItemConfigId;

		// Token: 0x040179CD RID: 96717
		protected int CurrentShowLevel;
	}
}
