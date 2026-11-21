using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;

// Token: 0x02001537 RID: 5431
[NullableContext(1)]
[Nullable(0)]
public class SceneGameplayItemRewardView : CommonResultView
{
	// Token: 0x0600D97F RID: 55679 RVA: 0x00407FB2 File Offset: 0x004061B2
	public SceneGameplayItemRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D980 RID: 55680 RVA: 0x00407FBB File Offset: 0x004061BB
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.PlotNetworkStartEvent));
		EventSystem.Instance.Add<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.PlotNetworkEndEvent));
	}

	// Token: 0x0600D981 RID: 55681 RVA: 0x00407FF5 File Offset: 0x004061F5
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.PlotNetworkStartEvent));
		EventSystem.Instance.Remove<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.PlotNetworkEndEvent));
	}

	// Token: 0x0600D982 RID: 55682 RVA: 0x0040802F File Offset: 0x0040622F
	protected override void OnStart()
	{
		base.OnStart();
		this.UpdateView();
	}

	// Token: 0x0600D983 RID: 55683 RVA: 0x0040803D File Offset: 0x0040623D
	private void PlotNetworkStartEvent(PlotInfo info)
	{
		this.SetActive(false);
	}

	// Token: 0x0600D984 RID: 55684 RVA: 0x00408046 File Offset: 0x00406246
	private void PlotNetworkEndEvent(PlotResultInfo info)
	{
		this.SetActive(true);
	}

	// Token: 0x0600D985 RID: 55685 RVA: 0x0040804F File Offset: 0x0040624F
	private void UpdateView()
	{
		this.UpdateRewardPreview();
	}

	// Token: 0x0600D986 RID: 55686 RVA: 0x00408058 File Offset: 0x00406258
	private void UpdateRewardPreview()
	{
		ItemRewardData itemRewardData = ItemHintModel.Instance.ShiftItemRewardListFirst();
		List<TItem> data = ItemHintController.ConvertRewardListToItem(new List<ItemRewardInfo>(ItemHintController.Instance.CombineAllShowItems(itemRewardData.ItemReward, true)));
		this.RewardLayout.RebuildLayoutByDataNew<TItem>(data, null);
	}

	// Token: 0x0600D987 RID: 55687 RVA: 0x004080A4 File Offset: 0x004062A4
	protected override void SetupButtonFormat()
	{
		List<CommonResultButtonData> dataList = this.CreateInstanceDungeonCommonButtonData();
		base.RefreshButtonList(dataList);
	}

	// Token: 0x0600D988 RID: 55688 RVA: 0x004080BF File Offset: 0x004062BF
	private List<CommonResultButtonData> CreateInstanceDungeonCommonButtonData()
	{
		return new List<CommonResultButtonData>
		{
			this.CreateFirstButtonData()
		};
	}

	// Token: 0x0600D989 RID: 55689 RVA: 0x004080D2 File Offset: 0x004062D2
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

	// Token: 0x0600D98A RID: 55690 RVA: 0x00408110 File Offset: 0x00406310
	private void OnClickBtnConfirm()
	{
		if (UiManager.Instance.IsViewShow(this.ViewInfo.Name))
		{
			base.CloseMe(null);
		}
	}
}
