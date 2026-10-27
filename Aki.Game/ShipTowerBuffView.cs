using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029A0 RID: 10656
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerBuffView : UiViewBase
{
	// Token: 0x06016170 RID: 90480 RVA: 0x00595CDE File Offset: 0x00593EDE
	public ShipTowerBuffView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016171 RID: 90481 RVA: 0x00595CE8 File Offset: 0x00593EE8
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

	// Token: 0x06016172 RID: 90482 RVA: 0x00595D94 File Offset: 0x00593F94
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

	// Token: 0x06016173 RID: 90483 RVA: 0x00595E13 File Offset: 0x00594013
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

	// Token: 0x06016174 RID: 90484 RVA: 0x00595E38 File Offset: 0x00594038
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerBuffView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerBuffView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016175 RID: 90485 RVA: 0x00595E7B File Offset: 0x0059407B
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

	// Token: 0x06016176 RID: 90486 RVA: 0x00595EA3 File Offset: 0x005940A3
	private void TimerFinishLoadedBuffPromise(float _)
	{
		this.FinishLoadedBuffPromise();
	}

	// Token: 0x06016177 RID: 90487 RVA: 0x00595EAB File Offset: 0x005940AB
	private void FinishLoadedBuffPromise()
	{
		if (this.LoadedBuffPromise != null && !this.LoadedBuffPromise.IsFulfilled)
		{
			this.LoadedBuffPromise.SetResult(true);
		}
	}

	// Token: 0x06016178 RID: 90488 RVA: 0x00595ED0 File Offset: 0x005940D0
	private void OnClickBtnSelect(int _)
	{
		object openParam = this.OpenParam;
		ShipTowerTeamData teamData = (openParam as ShipTowerBuffViewParams).TeamData;
		ShipTowerBuffView.InvokeOnUseBuff(openParam, this.SelectedData, teamData);
	}

	// Token: 0x06016179 RID: 90489 RVA: 0x00595EFB File Offset: 0x005940FB
	private ShipTowerBuffListItem CreateBuffListItem()
	{
		return new ShipTowerBuffListItem
		{
			OnItemClickCallback = new Action<ShipTowerBuffData>(this.OnItemClickCallback),
			GetStageIdCallback = new Func<int?>(this.GetStageIdCallback),
			BuffComponentLoadedCallback = new Action(this.BuffComponentLoadedCallback)
		};
	}

	// Token: 0x0601617A RID: 90490 RVA: 0x00595F38 File Offset: 0x00594138
	private void BuffComponentLoadedCallback()
	{
		this.LoadedBuffNum++;
		if (this.LoadedBuffNum < this.LoadedBuffSumNum)
		{
			return;
		}
		this.FinishLoadedBuffPromise();
	}

	// Token: 0x0601617B RID: 90491 RVA: 0x00595F60 File Offset: 0x00594160
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

	// Token: 0x0601617C RID: 90492 RVA: 0x00595FA4 File Offset: 0x005941A4
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

	// Token: 0x0601617D RID: 90493 RVA: 0x00596090 File Offset: 0x00594290
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

	// Token: 0x0601617E RID: 90494 RVA: 0x00596188 File Offset: 0x00594388
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

	// Token: 0x0400A4AA RID: 42154
	[Nullable(2)]
	private PopupCaptionItem PopupCaption;

	// Token: 0x0400A4AB RID: 42155
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ShipTowerBuffListItem, ShipTowerBuffQuality> ScrollView;

	// Token: 0x0400A4AC RID: 42156
	[Nullable(2)]
	private ItemTipsWithButtonComponent ItemTipsComponent;

	// Token: 0x0400A4AD RID: 42157
	[Nullable(2)]
	private ShipTowerBuffData SelectedData;

	// Token: 0x0400A4AE RID: 42158
	private int LoadedBuffNum;

	// Token: 0x0400A4AF RID: 42159
	private int LoadedBuffSumNum;

	// Token: 0x0400A4B0 RID: 42160
	[Nullable(2)]
	private CustomPromise<bool> LoadedBuffPromise;

	// Token: 0x02008FA7 RID: 36775
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402E876 RID: 190582
		ScrollViewBuffList,
		// Token: 0x0402E877 RID: 190583
		ItemBuffList,
		// Token: 0x0402E878 RID: 190584
		ItemCaption,
		// Token: 0x0402E879 RID: 190585
		ItemBuffDesc
	}
}
