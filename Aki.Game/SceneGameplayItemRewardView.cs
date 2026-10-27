using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;

// Token: 0x02002064 RID: 8292
[NullableContext(1)]
[Nullable(0)]
public class SceneGameplayItemRewardView : CommonResultView
{
	// Token: 0x06010517 RID: 66839 RVA: 0x003FBB6A File Offset: 0x003F9D6A
	public SceneGameplayItemRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010518 RID: 66840 RVA: 0x003FBB73 File Offset: 0x003F9D73
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.PlotNetworkStartEvent));
		EventSystem.Instance.Add<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.PlotNetworkEndEvent));
	}

	// Token: 0x06010519 RID: 66841 RVA: 0x003FBBAD File Offset: 0x003F9DAD
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.PlotNetworkStartEvent));
		EventSystem.Instance.Remove<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.PlotNetworkEndEvent));
	}

	// Token: 0x0601051A RID: 66842 RVA: 0x003FBBE7 File Offset: 0x003F9DE7
	protected override void OnStart()
	{
		base.OnStart();
		this.UpdateView();
	}

	// Token: 0x0601051B RID: 66843 RVA: 0x003FBBF5 File Offset: 0x003F9DF5
	private void PlotNetworkStartEvent(PlotInfo info)
	{
		this.SetActive(false);
	}

	// Token: 0x0601051C RID: 66844 RVA: 0x003FBBFE File Offset: 0x003F9DFE
	private void PlotNetworkEndEvent(PlotResultInfo info)
	{
		this.SetActive(true);
	}

	// Token: 0x0601051D RID: 66845 RVA: 0x003FBC07 File Offset: 0x003F9E07
	private void UpdateView()
	{
		this.UpdateRewardPreview();
	}

	// Token: 0x0601051E RID: 66846 RVA: 0x003FBC10 File Offset: 0x003F9E10
	private void UpdateRewardPreview()
	{
		ItemRewardData itemRewardData = ItemHintModel.Instance.ShiftItemRewardListFirst();
		List<TItem> data = ItemHintController.ConvertRewardListToItem(new List<ItemRewardInfo>(ItemHintController.Instance.CombineAllShowItems(itemRewardData.ItemReward, true)));
		this.RewardLayout.RebuildLayoutByDataNew<TItem>(data, null);
	}

	// Token: 0x0601051F RID: 66847 RVA: 0x003FBC5C File Offset: 0x003F9E5C
	protected override void SetupButtonFormat()
	{
		List<CommonResultButtonData> dataList = this.CreateInstanceDungeonCommonButtonData();
		base.RefreshButtonList(dataList);
	}

	// Token: 0x06010520 RID: 66848 RVA: 0x003FBC77 File Offset: 0x003F9E77
	private List<CommonResultButtonData> CreateInstanceDungeonCommonButtonData()
	{
		return new List<CommonResultButtonData>
		{
			this.CreateFirstButtonData()
		};
	}

	// Token: 0x06010521 RID: 66849 RVA: 0x003FBC8A File Offset: 0x003F9E8A
	private CommonResultButtonData CreateFirstButtonData()
	{
		CommonResultButtonData commonResultButtonData = new CommonResultButtonData();
		commonResultButtonData.SetRefreshCallBack(delegate(CommonResultButton button)
		{
			button.SetBtnText("ButtonTextConfirm", Array.Empty<object>());
		});
		commonResultButtonData.SetClickCallBack(new Action(this.OnClickBtnConfirm));
		return commonResultButtonData;
	}

	// Token: 0x06010522 RID: 66850 RVA: 0x003FBCC8 File Offset: 0x003F9EC8
	private void OnClickBtnConfirm()
	{
		if (UiManager.Instance.IsViewShow(this.ViewInfo.Name))
		{
			base.CloseMe(null);
		}
	}
}
