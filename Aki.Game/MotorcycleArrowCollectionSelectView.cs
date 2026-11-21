using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011A0 RID: 4512
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowCollectionSelectView : UiViewBase
{
	// Token: 0x0600B402 RID: 46082 RVA: 0x00352CEE File Offset: 0x00350EEE
	public MotorcycleArrowCollectionSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B403 RID: 46083 RVA: 0x00352D10 File Offset: 0x00350F10
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

	// Token: 0x0600B404 RID: 46084 RVA: 0x00352DC4 File Offset: 0x00350FC4
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleArrowCollectionSelectView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleArrowCollectionSelectView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B405 RID: 46085 RVA: 0x00352E08 File Offset: 0x00351008
	protected override void OnBeforeShow()
	{
		this.SequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		this.UpdateData(false);
	}

	// Token: 0x0600B406 RID: 46086 RVA: 0x00352E39 File Offset: 0x00351039
	protected override void OnAfterDestroy()
	{
		this.ViewModel.OnViewClose();
	}

	// Token: 0x0600B407 RID: 46087 RVA: 0x00352E48 File Offset: 0x00351048
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

	// Token: 0x0600B408 RID: 46088 RVA: 0x00352F0F File Offset: 0x0035110F
	public void OnBtnClose()
	{
		if (this.ViewModel.CollectionList.Count <= 0)
		{
			this.CloseMeWithCallBack();
		}
	}

	// Token: 0x0600B409 RID: 46089 RVA: 0x00352F2C File Offset: 0x0035112C
	private UniTask CreateCollectionSelectPanel()
	{
		MotorcycleArrowCollectionSelectView.<CreateCollectionSelectPanel>d__19 <CreateCollectionSelectPanel>d__;
		<CreateCollectionSelectPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCollectionSelectPanel>d__.<>4__this = this;
		<CreateCollectionSelectPanel>d__.<>1__state = -1;
		<CreateCollectionSelectPanel>d__.<>t__builder.Start<MotorcycleArrowCollectionSelectView.<CreateCollectionSelectPanel>d__19>(ref <CreateCollectionSelectPanel>d__);
		return <CreateCollectionSelectPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B40A RID: 46090 RVA: 0x00352F6F File Offset: 0x0035116F
	private void OnItemClick(MotorcycleArrowCollectionItemData data, CollectionGridItem item)
	{
		item.SetToggleState(false);
		UiManager.Instance.OpenView(EUiViewName.MotorcycleArrowCollectionTipsView, data, null);
	}

	// Token: 0x0600B40B RID: 46091 RVA: 0x00352F89 File Offset: 0x00351189
	public void OnClickRefreshBuff()
	{
		this.RequestUpdateCollectionListAsync().Forget();
	}

	// Token: 0x0600B40C RID: 46092 RVA: 0x00352F98 File Offset: 0x00351198
	private UniTask RequestUpdateCollectionListAsync()
	{
		MotorcycleArrowCollectionSelectView.<RequestUpdateCollectionListAsync>d__22 <RequestUpdateCollectionListAsync>d__;
		<RequestUpdateCollectionListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestUpdateCollectionListAsync>d__.<>4__this = this;
		<RequestUpdateCollectionListAsync>d__.<>1__state = -1;
		<RequestUpdateCollectionListAsync>d__.<>t__builder.Start<MotorcycleArrowCollectionSelectView.<RequestUpdateCollectionListAsync>d__22>(ref <RequestUpdateCollectionListAsync>d__);
		return <RequestUpdateCollectionListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B40D RID: 46093 RVA: 0x00352FDB File Offset: 0x003511DB
	public void OnClickBtnSure()
	{
		if (this.ViewModel.CollectionList.Count <= 0)
		{
			this.CloseMeWithCallBack();
			return;
		}
		this.SureBuffSelect().Forget();
	}

	// Token: 0x0600B40E RID: 46094 RVA: 0x00353004 File Offset: 0x00351204
	public UniTask SureBuffSelect()
	{
		MotorcycleArrowCollectionSelectView.<SureBuffSelect>d__24 <SureBuffSelect>d__;
		<SureBuffSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SureBuffSelect>d__.<>4__this = this;
		<SureBuffSelect>d__.<>1__state = -1;
		<SureBuffSelect>d__.<>t__builder.Start<MotorcycleArrowCollectionSelectView.<SureBuffSelect>d__24>(ref <SureBuffSelect>d__);
		return <SureBuffSelect>d__.<>t__builder.Task;
	}

	// Token: 0x0600B40F RID: 46095 RVA: 0x00353048 File Offset: 0x00351248
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

	// Token: 0x0600B410 RID: 46096 RVA: 0x003530CC File Offset: 0x003512CC
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

	// Token: 0x0600B411 RID: 46097 RVA: 0x00353114 File Offset: 0x00351314
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

	// Token: 0x0600B412 RID: 46098 RVA: 0x00353184 File Offset: 0x00351384
	public void UpdateCollectionPanelSelectState()
	{
		MotorcycleArrowCollectionItemData curSelectCollectionItem = this.ViewModel.CurSelectCollectionItem;
		for (int i = 0; i < this.CollectionItemList.Count; i++)
		{
			MotorcycleArrowCollectionItem motorcycleArrowCollectionItem = this.CollectionItemList[i];
			motorcycleArrowCollectionItem.SetSelect(curSelectCollectionItem == motorcycleArrowCollectionItem.CollectionData);
		}
	}

	// Token: 0x0600B413 RID: 46099 RVA: 0x003531CF File Offset: 0x003513CF
	public void OnSelectCollection(MotorcycleArrowCollectionItemData data)
	{
		this.ViewModel.SetSelectCollectionItem(data);
		this.UpdateCollectionPanelSelectState();
		this.UpdateSureBtnEnable();
	}

	// Token: 0x0600B414 RID: 46100 RVA: 0x003531E9 File Offset: 0x003513E9
	public void UpdateCollectionEmptyState()
	{
		this.CollectionEmpty.SetUIActive(this.ViewModel.IsMotorFightItemEmpty());
	}

	// Token: 0x0600B415 RID: 46101 RVA: 0x00353201 File Offset: 0x00351401
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

	// Token: 0x040067ED RID: 26605
	public MotorcycleArrowCollectionSelectViewModel ViewModel;

	// Token: 0x040067EE RID: 26606
	public PopupCaptionItem PopupCaption;

	// Token: 0x040067EF RID: 26607
	public UUIItem CollectionListParent;

	// Token: 0x040067F0 RID: 26608
	public List<MotorcycleArrowCollectionItem> CollectionItemList = new List<MotorcycleArrowCollectionItem>();

	// Token: 0x040067F1 RID: 26609
	public UUIItem CollectionItem;

	// Token: 0x040067F2 RID: 26610
	public ButtonItem RefreshButton;

	// Token: 0x040067F3 RID: 26611
	public ButtonItem ConfirmButton;

	// Token: 0x040067F4 RID: 26612
	[Nullable(2)]
	private MultiTemplateScrollView ItemMultiTemplateScrollView;

	// Token: 0x040067F5 RID: 26613
	public UUIItem CollectionEmpty;

	// Token: 0x040067F6 RID: 26614
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x040067F7 RID: 26615
	private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

	// Token: 0x0200746E RID: 29806
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025E5D RID: 155229
		public const int CaptionItem = 0;

		// Token: 0x04025E5E RID: 155230
		public const int CollectionSelectList = 1;

		// Token: 0x04025E5F RID: 155231
		public const int CollectionItem = 2;

		// Token: 0x04025E60 RID: 155232
		public const int RefreshItem = 3;

		// Token: 0x04025E61 RID: 155233
		public const int SelectItem = 4;

		// Token: 0x04025E62 RID: 155234
		public const int CollectionBagList = 5;

		// Token: 0x04025E63 RID: 155235
		public const int CollectionEmpty = 6;
	}
}
