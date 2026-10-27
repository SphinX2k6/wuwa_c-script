using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MingSu.View
{
	// Token: 0x020053D6 RID: 21462
	public class CollectItemViewBase : UiViewBase
	{
		// Token: 0x06036DB2 RID: 224690 RVA: 0x00CFDEC8 File Offset: 0x00CFC0C8
		[NullableContext(1)]
		public CollectItemViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036DB3 RID: 224691 RVA: 0x00CFDED4 File Offset: 0x00CFC0D4
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

		// Token: 0x06036DB4 RID: 224692 RVA: 0x00CFDFB8 File Offset: 0x00CFC1B8
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove(EEventName.OnAntiqueShopUpgradeSequencePlayFail, new Action(this.OnSubmitItemLevelUpSequencePlayFailCallback));
			EventSystem.Instance.Remove(EEventName.UpdateDragonPoolView, new Action(this.OnUpdateDragonPoolViewCallback));
			EventSystem.Instance.Remove(EEventName.OnAntiqueShopLevelMaxSequenceFinished, new Action(this.OnLevelMaxSequenceFinishedCallback));
			EventSystem.Instance.Remove(EEventName.OnAntiqueShopUpgradeSequenceFinished, new Action(this.OnLevelUpSequenceFinishedCallback));
			this.OnEnded();
		}

		// Token: 0x06036DB5 RID: 224693 RVA: 0x00CFE054 File Offset: 0x00CFC254
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnSubmitItemLevelUp, new Action(this.OnSubmitItemLevelUpCallback));
			EventSystem.Instance.Add(EEventName.OnSubmitItemLevelMax, new Action(this.OnSubmitItemLevelMaxCallback));
			EventSystem.Instance.Add(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x06036DB6 RID: 224694 RVA: 0x00CFE0B8 File Offset: 0x00CFC2B8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnSubmitItemLevelUp, new Action(this.OnSubmitItemLevelUpCallback));
			EventSystem.Instance.Remove(EEventName.OnSubmitItemLevelMax, new Action(this.OnSubmitItemLevelMaxCallback));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x06036DB7 RID: 224695 RVA: 0x00CFE119 File Offset: 0x00CFC319
		private void OnUpdateDragonPoolViewCallback()
		{
			this.OnUpdateDragonPoolView();
		}

		// Token: 0x06036DB8 RID: 224696 RVA: 0x00CFE121 File Offset: 0x00CFC321
		private void OnSubmitItemLevelUpCallback()
		{
			this.OnSubmitItemLevelUp();
		}

		// Token: 0x06036DB9 RID: 224697 RVA: 0x00CFE129 File Offset: 0x00CFC329
		private void OnSubmitItemLevelMaxCallback()
		{
			this.OnSubmitItemLevelUp();
		}

		// Token: 0x06036DBA RID: 224698 RVA: 0x00CFE131 File Offset: 0x00CFC331
		private void OnLevelMaxSequenceFinishedCallback()
		{
			this.OnLevelMaxSequenceFinished();
		}

		// Token: 0x06036DBB RID: 224699 RVA: 0x00CFE139 File Offset: 0x00CFC339
		private void OnLevelUpSequenceFinishedCallback()
		{
			this.OnLevelUpSequenceFinished();
		}

		// Token: 0x06036DBC RID: 224700 RVA: 0x00CFE141 File Offset: 0x00CFC341
		private void OnSubmitItemLevelUpSequencePlayFailCallback()
		{
			this.OnSubmitItemLevelUpSequencePlayFail();
		}

		// Token: 0x06036DBD RID: 224701 RVA: 0x00CFE149 File Offset: 0x00CFC349
		private void OnCommonItemCountAnyChange(int configId, int count)
		{
			if (configId != this.CollectItemConfigId)
			{
				return;
			}
			this.OnCollectItemCountChanged(count);
		}

		// Token: 0x06036DBE RID: 224702 RVA: 0x00CFE15C File Offset: 0x00CFC35C
		private void OnCloseView(EUiViewName viewName, int id)
		{
			if (viewName != EUiViewName.CompositeRewardView)
			{
				return;
			}
			this.OnCloseRewardView();
		}

		// Token: 0x06036DBF RID: 224703 RVA: 0x00CFE172 File Offset: 0x00CFC372
		protected virtual void OnBegined()
		{
		}

		// Token: 0x06036DC0 RID: 224704 RVA: 0x00CFE174 File Offset: 0x00CFC374
		protected virtual void OnEnded()
		{
		}

		// Token: 0x06036DC1 RID: 224705 RVA: 0x00CFE176 File Offset: 0x00CFC376
		protected virtual void OnUpdateDragonPoolView()
		{
		}

		// Token: 0x06036DC2 RID: 224706 RVA: 0x00CFE178 File Offset: 0x00CFC378
		protected virtual void OnSubmitItemLevelUp()
		{
		}

		// Token: 0x06036DC3 RID: 224707 RVA: 0x00CFE17A File Offset: 0x00CFC37A
		protected virtual void OnSubmitItemLevelMax()
		{
		}

		// Token: 0x06036DC4 RID: 224708 RVA: 0x00CFE17C File Offset: 0x00CFC37C
		protected virtual void OnLevelMaxSequenceFinished()
		{
		}

		// Token: 0x06036DC5 RID: 224709 RVA: 0x00CFE17E File Offset: 0x00CFC37E
		protected virtual void OnLevelUpSequenceFinished()
		{
		}

		// Token: 0x06036DC6 RID: 224710 RVA: 0x00CFE180 File Offset: 0x00CFC380
		protected virtual void OnSubmitItemLevelUpSequencePlayFail()
		{
		}

		// Token: 0x06036DC7 RID: 224711 RVA: 0x00CFE182 File Offset: 0x00CFC382
		protected virtual void OnCloseRewardView()
		{
		}

		// Token: 0x06036DC8 RID: 224712 RVA: 0x00CFE184 File Offset: 0x00CFC384
		protected virtual void OnCollectItemCountChanged(int count)
		{
		}

		// Token: 0x0401CF33 RID: 118579
		protected int PoolConfigId;

		// Token: 0x0401CF34 RID: 118580
		protected int CollectItemConfigId;

		// Token: 0x0401CF35 RID: 118581
		protected int CurrentShowLevel;
	}
}
