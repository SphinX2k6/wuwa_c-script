using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CDE RID: 7390
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowCollectionSelectView : UiViewBase
{
	// Token: 0x0600DFE5 RID: 57317 RVA: 0x003472C6 File Offset: 0x003454C6
	public MotorcycleArrowCollectionSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DFE6 RID: 57318 RVA: 0x003472E8 File Offset: 0x003454E8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIMultiTemplateScrollViewComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x0600DFE7 RID: 57319 RVA: 0x0034739C File Offset: 0x0034559C
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleArrowCollectionSelectView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleArrowCollectionSelectView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFE8 RID: 57320 RVA: 0x003473E0 File Offset: 0x003455E0
	protected override void OnBeforeShow()
	{
		this.SequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		this.UpdateData(false);
	}

	// Token: 0x0600DFE9 RID: 57321 RVA: 0x00347411 File Offset: 0x00345611
	protected override void OnAfterDestroy()
	{
		this.ViewModel.OnViewClose();
	}

	// Token: 0x0600DFEA RID: 57322 RVA: 0x00347420 File Offset: 0x00345620
	private void InitScrollViewData()
	{
		List<int> sortedMotorFightItemTypeList = this.ViewModel.GetSortedMotorFightItemTypeList();
		for (int i = 0; i < sortedMotorFightItemTypeList.Count; i++)
		{
			int num = sortedMotorFightItemTypeList[i];
			CollectionTypeItemData collectionTypeItemData = new CollectionTypeItemData();
			collectionTypeItemData.Data = MotorcycleArrowConfig.Instance.GetCollectionTypeConfigById(num).Value;
			this.ScrollDataList.Add(collectionTypeItemData);
			List<MotorcycleArrowCollectionItemData> motorFightItemDataListByType = this.ViewModel.GetMotorFightItemDataListByType(num);
			if (motorFightItemDataListByType != null)
			{
				for (int j = 0; j < motorFightItemDataListByType.Count; j++)
				{
					MotorcycleArrowCollectionItemData data = motorFightItemDataListByType[j];
					CollectionGridItemData collectionGridItemData = new CollectionGridItemData();
					collectionGridItemData.Data = data;
					collectionGridItemData.OnClickCb = new Action<MotorcycleArrowCollectionItemData, CollectionGridItem>(this.OnItemClick);
					this.ScrollDataList.Add(collectionGridItemData);
				}
			}
		}
	}

	// Token: 0x0600DFEB RID: 57323 RVA: 0x003474E7 File Offset: 0x003456E7
	public void OnBtnClose()
	{
		if (this.ViewModel.CollectionList.Count <= 0)
		{
			this.CloseMeWithCallBack();
		}
	}

	// Token: 0x0600DFEC RID: 57324 RVA: 0x00347504 File Offset: 0x00345704
	private UniTask CreateCollectionSelectPanel()
	{
		MotorcycleArrowCollectionSelectView.<CreateCollectionSelectPanel>d__19 <CreateCollectionSelectPanel>d__;
		<CreateCollectionSelectPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCollectionSelectPanel>d__.<>4__this = this;
		<CreateCollectionSelectPanel>d__.<>1__state = -1;
		<CreateCollectionSelectPanel>d__.<>t__builder.Start<MotorcycleArrowCollectionSelectView.<CreateCollectionSelectPanel>d__19>(ref <CreateCollectionSelectPanel>d__);
		return <CreateCollectionSelectPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFED RID: 57325 RVA: 0x00347547 File Offset: 0x00345747
	private void OnItemClick(MotorcycleArrowCollectionItemData data, CollectionGridItem item)
	{
		item.SetToggleState(false);
		UiManager.Instance.OpenView(EUiViewName.MotorcycleArrowCollectionTipsView, data, null);
	}

	// Token: 0x0600DFEE RID: 57326 RVA: 0x00347561 File Offset: 0x00345761
	public void OnClickRefreshBuff()
	{
		this.RequestUpdateCollectionListAsync().Forget();
	}

	// Token: 0x0600DFEF RID: 57327 RVA: 0x00347570 File Offset: 0x00345770
	private UniTask RequestUpdateCollectionListAsync()
	{
		MotorcycleArrowCollectionSelectView.<RequestUpdateCollectionListAsync>d__22 <RequestUpdateCollectionListAsync>d__;
		<RequestUpdateCollectionListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestUpdateCollectionListAsync>d__.<>4__this = this;
		<RequestUpdateCollectionListAsync>d__.<>1__state = -1;
		<RequestUpdateCollectionListAsync>d__.<>t__builder.Start<MotorcycleArrowCollectionSelectView.<RequestUpdateCollectionListAsync>d__22>(ref <RequestUpdateCollectionListAsync>d__);
		return <RequestUpdateCollectionListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFF0 RID: 57328 RVA: 0x003475B3 File Offset: 0x003457B3
	public void OnClickBtnSure()
	{
		if (this.ViewModel.CollectionList.Count <= 0)
		{
			this.CloseMeWithCallBack();
			return;
		}
		this.SureBuffSelect().Forget();
	}

	// Token: 0x0600DFF1 RID: 57329 RVA: 0x003475DC File Offset: 0x003457DC
	public UniTask SureBuffSelect()
	{
		MotorcycleArrowCollectionSelectView.<SureBuffSelect>d__24 <SureBuffSelect>d__;
		<SureBuffSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SureBuffSelect>d__.<>4__this = this;
		<SureBuffSelect>d__.<>1__state = -1;
		<SureBuffSelect>d__.<>t__builder.Start<MotorcycleArrowCollectionSelectView.<SureBuffSelect>d__24>(ref <SureBuffSelect>d__);
		return <SureBuffSelect>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFF2 RID: 57330 RVA: 0x00347620 File Offset: 0x00345820
	public void UpdateData(bool bRefresh)
	{
		List<MotorcycleArrowCollectionItemData> collectionList = this.ViewModel.CollectionList;
		this.ViewModel.SetSelectCollectionItem(null);
		for (int i = 0; i < this.CollectionItemList.Count; i++)
		{
			MotorcycleArrowCollectionItem motorcycleArrowCollectionItem = this.CollectionItemList[i];
			MotorcycleArrowCollectionItemData motorcycleArrowCollectionItemData = (i < collectionList.Count) ? collectionList[i] : null;
			motorcycleArrowCollectionItem.SetActive(motorcycleArrowCollectionItemData != null);
			if (motorcycleArrowCollectionItemData != null)
			{
				motorcycleArrowCollectionItem.UpdateData(motorcycleArrowCollectionItemData, bRefresh);
				motorcycleArrowCollectionItem.SetSelect(false);
			}
		}
		this.UpdateSureBtnEnable();
		this.UpdateRefreshBtn();
	}

	// Token: 0x0600DFF3 RID: 57331 RVA: 0x003476A4 File Offset: 0x003458A4
	public void UpdateSureBtnEnable()
	{
		bool enableClick = this.ViewModel.CurSelectCollectionItem != null || this.ViewModel.CollectionList.Count <= 0;
		ButtonItem confirmButton = this.ConfirmButton;
		if (confirmButton == null)
		{
			return;
		}
		confirmButton.SetEnableClick(enableClick);
	}

	// Token: 0x0600DFF4 RID: 57332 RVA: 0x003476EC File Offset: 0x003458EC
	public void UpdateRefreshBtn()
	{
		bool enableClick = this.ViewModel.RemainRefreshCount > 0;
		ButtonItem refreshButton = this.RefreshButton;
		if (refreshButton != null)
		{
			refreshButton.SetLocalTextNew("PrefabTextItem_1210882995_Text", new object[]
			{
				this.ViewModel.RemainRefreshCount,
				this.ViewModel.MaxRefreshCount
			});
		}
		ButtonItem refreshButton2 = this.RefreshButton;
		if (refreshButton2 == null)
		{
			return;
		}
		refreshButton2.SetEnableClick(enableClick);
	}

	// Token: 0x0600DFF5 RID: 57333 RVA: 0x0034775C File Offset: 0x0034595C
	public void UpdateCollectionPanelSelectState()
	{
		MotorcycleArrowCollectionItemData curSelectCollectionItem = this.ViewModel.CurSelectCollectionItem;
		for (int i = 0; i < this.CollectionItemList.Count; i++)
		{
			MotorcycleArrowCollectionItem motorcycleArrowCollectionItem = this.CollectionItemList[i];
			motorcycleArrowCollectionItem.SetSelect(curSelectCollectionItem == motorcycleArrowCollectionItem.CollectionData);
		}
	}

	// Token: 0x0600DFF6 RID: 57334 RVA: 0x003477A7 File Offset: 0x003459A7
	public void OnSelectCollection(MotorcycleArrowCollectionItemData data)
	{
		this.ViewModel.SetSelectCollectionItem(data);
		this.UpdateCollectionPanelSelectState();
		this.UpdateSureBtnEnable();
	}

	// Token: 0x0600DFF7 RID: 57335 RVA: 0x003477C1 File Offset: 0x003459C1
	public void UpdateCollectionEmptyState()
	{
		this.CollectionEmpty.SetUIActive(this.ViewModel.IsMotorFightItemEmpty());
	}

	// Token: 0x0600DFF8 RID: 57336 RVA: 0x003477D9 File Offset: 0x003459D9
	public void CloseMeWithCallBack()
	{
		base.CloseMe(delegate(bool success)
		{
			if (success)
			{
				this.ViewModel.OnViewClose();
			}
		});
	}

	// Token: 0x0400670E RID: 26382
	public MotorcycleArrowCollectionSelectViewModel ViewModel;

	// Token: 0x0400670F RID: 26383
	public PopupCaptionItem PopupCaption;

	// Token: 0x04006710 RID: 26384
	public UUIItem CollectionListParent;

	// Token: 0x04006711 RID: 26385
	public List<MotorcycleArrowCollectionItem> CollectionItemList = new List<MotorcycleArrowCollectionItem>();

	// Token: 0x04006712 RID: 26386
	public UUIItem CollectionItem;

	// Token: 0x04006713 RID: 26387
	public ButtonItem RefreshButton;

	// Token: 0x04006714 RID: 26388
	public ButtonItem ConfirmButton;

	// Token: 0x04006715 RID: 26389
	[Nullable(2)]
	private MultiTemplateScrollView ItemMultiTemplateScrollView;

	// Token: 0x04006716 RID: 26390
	public UUIItem CollectionEmpty;

	// Token: 0x04006717 RID: 26391
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04006718 RID: 26392
	private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

	// Token: 0x020082E5 RID: 33509
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AB35 RID: 174901
		public const int CaptionItem = 0;

		// Token: 0x0402AB36 RID: 174902
		public const int CollectionSelectList = 1;

		// Token: 0x0402AB37 RID: 174903
		public const int CollectionItem = 2;

		// Token: 0x0402AB38 RID: 174904
		public const int RefreshItem = 3;

		// Token: 0x0402AB39 RID: 174905
		public const int SelectItem = 4;

		// Token: 0x0402AB3A RID: 174906
		public const int CollectionBagList = 5;

		// Token: 0x0402AB3B RID: 174907
		public const int CollectionEmpty = 6;
	}
}
