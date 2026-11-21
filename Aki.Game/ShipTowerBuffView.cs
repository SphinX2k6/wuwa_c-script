using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F1B RID: 7963
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerBuffView : UiViewBase
{
	// Token: 0x06013B76 RID: 80758 RVA: 0x005C0C9E File Offset: 0x005BEE9E
	public ShipTowerBuffView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013B77 RID: 80759 RVA: 0x005C0CA8 File Offset: 0x005BEEA8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06013B78 RID: 80760 RVA: 0x005C0D54 File Offset: 0x005BEF54
	private void InitDataParam()
	{
		ShipTowerBuffViewParams shipTowerBuffViewParams = this.OpenParam as ShipTowerBuffViewParams;
		int? num = (shipTowerBuffViewParams != null) ? shipTowerBuffViewParams.BuffId : null;
		if (num != null && num.GetValueOrDefault() != 0)
		{
			ShipTowerBuffData buffDataByBuffId = ShipTowerModel.Instance.GetBuffDataByBuffId(num.Value);
			if (buffDataByBuffId != null)
			{
				buffDataByBuffId.SetSelected(true);
				return;
			}
		}
		else
		{
			int? stageId = (shipTowerBuffViewParams != null) ? shipTowerBuffViewParams.StageId : null;
			ShipTowerModel.Instance.SelectDefaultBuff(stageId);
		}
	}

	// Token: 0x06013B79 RID: 80761 RVA: 0x005C0DD3 File Offset: 0x005BEFD3
	private static void InvokeOnUseBuff(object openParam, ShipTowerBuffData buffData, [Nullable(2)] object teamData)
	{
		if (openParam == null)
		{
			return;
		}
		Action<ShipTowerBuffData, ShipTowerTeamData> onUseBuff = (openParam as ShipTowerBuffViewParams).OnUseBuff;
		if (onUseBuff == null)
		{
			return;
		}
		onUseBuff(buffData, teamData as ShipTowerTeamData);
	}

	// Token: 0x06013B7A RID: 80762 RVA: 0x005C0DF8 File Offset: 0x005BEFF8
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerBuffView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerBuffView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013B7B RID: 80763 RVA: 0x005C0E3B File Offset: 0x005BF03B
	protected override void OnBeforeDestroy()
	{
		this.FinishLoadedBuffPromise();
		ItemTipsWithButtonComponent itemTipsComponent = this.ItemTipsComponent;
		if (itemTipsComponent != null)
		{
			itemTipsComponent.Destroy(null);
		}
		this.ItemTipsComponent = null;
		this.PopupCaption = null;
	}

	// Token: 0x06013B7C RID: 80764 RVA: 0x005C0E63 File Offset: 0x005BF063
	private void TimerFinishLoadedBuffPromise(float _)
	{
		this.FinishLoadedBuffPromise();
	}

	// Token: 0x06013B7D RID: 80765 RVA: 0x005C0E6B File Offset: 0x005BF06B
	private void FinishLoadedBuffPromise()
	{
		if (this.LoadedBuffPromise != null && !this.LoadedBuffPromise.IsFulfilled)
		{
			this.LoadedBuffPromise.SetResult(true);
		}
	}

	// Token: 0x06013B7E RID: 80766 RVA: 0x005C0E90 File Offset: 0x005BF090
	private void OnClickBtnSelect(int _)
	{
		object openParam = this.OpenParam;
		ShipTowerTeamData teamData = (openParam as ShipTowerBuffViewParams).TeamData;
		ShipTowerBuffView.InvokeOnUseBuff(openParam, this.SelectedData, teamData);
	}

	// Token: 0x06013B7F RID: 80767 RVA: 0x005C0EBB File Offset: 0x005BF0BB
	private ShipTowerBuffListItem CreateBuffListItem()
	{
		return new ShipTowerBuffListItem
		{
			OnItemClickCallback = new Action<ShipTowerBuffData>(this.OnItemClickCallback),
			GetStageIdCallback = new Func<int?>(this.GetStageIdCallback),
			BuffComponentLoadedCallback = new Action(this.BuffComponentLoadedCallback)
		};
	}

	// Token: 0x06013B80 RID: 80768 RVA: 0x005C0EF8 File Offset: 0x005BF0F8
	private void BuffComponentLoadedCallback()
	{
		this.LoadedBuffNum++;
		if (this.LoadedBuffNum < this.LoadedBuffSumNum)
		{
			return;
		}
		this.FinishLoadedBuffPromise();
	}

	// Token: 0x06013B81 RID: 80769 RVA: 0x005C0F20 File Offset: 0x005BF120
	private int? GetStageIdCallback()
	{
		ShipTowerBuffViewParams shipTowerBuffViewParams = this.OpenParam as ShipTowerBuffViewParams;
		if (shipTowerBuffViewParams == null)
		{
			return null;
		}
		ShipTowerTeamData teamData = shipTowerBuffViewParams.TeamData;
		if (teamData == null)
		{
			return null;
		}
		return new int?(teamData.StageId);
	}

	// Token: 0x06013B82 RID: 80770 RVA: 0x005C0F64 File Offset: 0x005BF164
	private void OnItemClickCallback(ShipTowerBuffData data)
	{
		this.SelectedData = data;
		this.UpdateButton();
		ItemTipsData tipsDataById = ItemTipsComponentUtilTool.GetTipsDataById(this.SelectedData.ItemId, null, null);
		int? stageId = (this.OpenParam as ShipTowerBuffViewParams).StageId;
		tipsDataById.UpdateShowNumCallback = (() => data.CanUseCount);
		tipsDataById.IsShowNumTextCallback = (() => data.IsShowNumTextCallback(stageId));
		this.ItemTipsComponent.RefreshTips(tipsDataById);
		this.ItemTipsComponent.SetVisible(true);
		bool flag = data.AddToGetState();
		GenericScrollViewNew<ShipTowerBuffListItem, ShipTowerBuffQuality> scrollView = this.ScrollView;
		List<ShipTowerBuffListItem> list = (scrollView != null) ? scrollView.GetScrollItemList() : null;
		if (list != null)
		{
			for (int i = 0; i < list.Count; i++)
			{
				ShipTowerBuffListItem shipTowerBuffListItem = list[i];
				if (flag)
				{
					shipTowerBuffListItem.UpdateBuffInfo();
				}
				shipTowerBuffListItem.UpdateBuffSelected();
			}
		}
	}

	// Token: 0x06013B83 RID: 80771 RVA: 0x005C1050 File Offset: 0x005BF250
	private void UpdateButton()
	{
		this.ItemTipsComponent.ClearButtonList();
		this.ItemTipsComponent.SetLockStateVisible(false);
		object openParam = this.OpenParam;
		EShipTowerBuffOperationType? operationType = (openParam as ShipTowerBuffViewParams).OperationType;
		if (operationType.GetValueOrDefault() != EShipTowerBuffOperationType.Use)
		{
			return;
		}
		ShipTowerBuffData selectedData = this.SelectedData;
		if (selectedData == null || !selectedData.IsUnlock)
		{
			this.ItemTipsComponent.SetLockStateData(new ItemTipsLockStateData
			{
				TipsTextKey = "GhostShipItemLock_Text"
			});
			return;
		}
		int? stageId = (openParam as ShipTowerBuffViewParams).StageId;
		if (this.SelectedData != null && !this.SelectedData.IsCanUse(stageId))
		{
			this.ItemTipsComponent.SetLockStateData(new ItemTipsLockStateData
			{
				TipsTextKey = "GhostShipItemLimit_Text"
			});
			return;
		}
		List<IButtonInfo> list = new List<IButtonInfo>();
		ButtonInfo item = new ButtonInfo
		{
			Function = new Action<int>(this.OnClickBtnSelect),
			Text = "GhostShipEquipBuff_Text",
			Index = 0
		};
		list.Add(item);
		this.ItemTipsComponent.RefreshButton(list);
	}

	// Token: 0x06013B84 RID: 80772 RVA: 0x005C1148 File Offset: 0x005BF348
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		List<ShipTowerBuffQuality> buffQualityList = ShipTowerModel.Instance.GetBuffQualityList(true);
		if (buffQualityList.Count == 0)
		{
			return null;
		}
		if (configParams.Length != 3)
		{
			return null;
		}
		int num;
		if (!int.TryParse(configParams[1], out num) || num < 0 || num >= buffQualityList.Count)
		{
			return null;
		}
		GenericScrollViewNew<ShipTowerBuffListItem, ShipTowerBuffQuality> scrollView = this.ScrollView;
		ShipTowerBuffListItem shipTowerBuffListItem = (scrollView != null) ? scrollView.GetScrollItemByIndex(num) : null;
		if (shipTowerBuffListItem == null)
		{
			return null;
		}
		return shipTowerBuffListItem.GetGuideUiItemAndUiItemForShowEx(configParams);
	}

	// Token: 0x0400A894 RID: 43156
	[Nullable(2)]
	private PopupCaptionItem PopupCaption;

	// Token: 0x0400A895 RID: 43157
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ShipTowerBuffListItem, ShipTowerBuffQuality> ScrollView;

	// Token: 0x0400A896 RID: 43158
	[Nullable(2)]
	private ItemTipsWithButtonComponent ItemTipsComponent;

	// Token: 0x0400A897 RID: 43159
	[Nullable(2)]
	private ShipTowerBuffData SelectedData;

	// Token: 0x0400A898 RID: 43160
	private int LoadedBuffNum;

	// Token: 0x0400A899 RID: 43161
	private int LoadedBuffSumNum;

	// Token: 0x0400A89A RID: 43162
	[Nullable(2)]
	private CustomPromise<bool> LoadedBuffPromise;

	// Token: 0x020081F0 RID: 33264
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029F75 RID: 171893
		ScrollViewBuffList,
		// Token: 0x04029F76 RID: 171894
		ItemBuffList,
		// Token: 0x04029F77 RID: 171895
		ItemCaption,
		// Token: 0x04029F78 RID: 171896
		ItemBuffDesc
	}
}
