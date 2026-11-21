using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013B5 RID: 5045
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryTechnologyView : UiViewBase
{
	// Token: 0x0600C7F4 RID: 51188 RVA: 0x003B84BA File Offset: 0x003B66BA
	[NullableContext(1)]
	public HonamiStoryTechnologyView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C7F5 RID: 51189 RVA: 0x003B84CC File Offset: 0x003B66CC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C7F6 RID: 51190 RVA: 0x003B85DC File Offset: 0x003B67DC
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryTechnologyView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryTechnologyView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7F7 RID: 51191 RVA: 0x003B8620 File Offset: 0x003B6820
	private void OnAfterRefreshOneNode(HonamiStoryTechnologyNodeItem nodeItem)
	{
		if (nodeItem == null)
		{
			return;
		}
		if (nodeItem.OnClickToggleBack == null)
		{
			nodeItem.OnClickToggleBack = new Action<HonamiStoryTechnologyNodeItem, HonamiStoryTechNodeData, UUIExtendToggle>(this.OnClickItem);
		}
		if (this.IsInitSelect)
		{
			return;
		}
		if (this.InitSelectNodeId == this.FirstTreeNode.GetNodeDataConfig().Id)
		{
			this.FirstTreeNode.SelectNode();
			UiNavigationNewController.Instance.SetNavigationFocusForView(this.FirstTreeNode.ToggleItem.RootUIComp, true, true, false);
			this.IsInitSelect = true;
			return;
		}
		if (this.InitSelectNodeId == nodeItem.GetNodeDataConfig().Id)
		{
			nodeItem.SelectNode();
			UiNavigationNewController.Instance.SetNavigationFocusForView(nodeItem.ToggleItem.RootUIComp, true, true, false);
			UUIItem itemByIndex = this.PnlNodeList.GetItemByIndex(nodeItem.GetNodeDataConfig().Area - 1);
			if (itemByIndex != null)
			{
				this.PnlNodeList.LateScrollTo(itemByIndex, null, false);
			}
			this.IsInitSelect = true;
		}
	}

	// Token: 0x0600C7F8 RID: 51192 RVA: 0x003B8713 File Offset: 0x003B6913
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHonamiStoryTechNodeLevelUpdate, new Action(this.OnTechNodeUpdate));
		EventSystem.Instance.Add(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotEnd));
	}

	// Token: 0x0600C7F9 RID: 51193 RVA: 0x003B874D File Offset: 0x003B694D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHonamiStoryTechNodeLevelUpdate, new Action(this.OnTechNodeUpdate));
		EventSystem.Instance.Remove(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotEnd));
	}

	// Token: 0x0600C7FA RID: 51194 RVA: 0x003B8788 File Offset: 0x003B6988
	private void OnTechNodeUpdate()
	{
		new UiAsyncTask("TechNodeUpdate", delegate()
		{
			HonamiStoryTechnologyView.<<OnTechNodeUpdate>b__16_0>d <<OnTechNodeUpdate>b__16_0>d;
			<<OnTechNodeUpdate>b__16_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnTechNodeUpdate>b__16_0>d.<>4__this = this;
			<<OnTechNodeUpdate>b__16_0>d.<>1__state = -1;
			<<OnTechNodeUpdate>b__16_0>d.<>t__builder.Start<HonamiStoryTechnologyView.<<OnTechNodeUpdate>b__16_0>d>(ref <<OnTechNodeUpdate>b__16_0>d);
			return <<OnTechNodeUpdate>b__16_0>d.<>t__builder.Task;
		}, null).Run();
		if (this.BoZaiTalk != null)
		{
			HonamiStoryOutDialog? randomDialogData = HonamiStoryModel.Instance.GetRandomDialogData(5);
			this.BoZaiTalk.SetTalkInfoTextAndPlayAudio(randomDialogData);
		}
	}

	// Token: 0x0600C7FB RID: 51195 RVA: 0x003B87D4 File Offset: 0x003B69D4
	private UniTask OnNodeUpdateAsync()
	{
		HonamiStoryTechnologyView.<OnNodeUpdateAsync>d__17 <OnNodeUpdateAsync>d__;
		<OnNodeUpdateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnNodeUpdateAsync>d__.<>4__this = this;
		<OnNodeUpdateAsync>d__.<>1__state = -1;
		<OnNodeUpdateAsync>d__.<>t__builder.Start<HonamiStoryTechnologyView.<OnNodeUpdateAsync>d__17>(ref <OnNodeUpdateAsync>d__);
		return <OnNodeUpdateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7FC RID: 51196 RVA: 0x003B8817 File Offset: 0x003B6A17
	[NullableContext(1)]
	private HonamiStoryTechnologyAreaItem InitAreaItem()
	{
		return new HonamiStoryTechnologyAreaItem
		{
			OnAfterRefreshOneNode = new Action<HonamiStoryTechnologyNodeItem>(this.OnAfterRefreshOneNode)
		};
	}

	// Token: 0x0600C7FD RID: 51197 RVA: 0x003B8830 File Offset: 0x003B6A30
	[NullableContext(1)]
	private void OnClickItem(HonamiStoryTechnologyNodeItem node, HonamiStoryTechNodeData data, UUIExtendToggle toggle)
	{
		if (this.CurrentSelectToggle != null && this.CurrentSelectToggle != toggle)
		{
			this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		HonamiStoryModel.Instance.CurrentSelectNode = data;
		HonamiStoryModel.Instance.CurrentSelectNodeItem = node;
		this.PnlTechnologyInfo.Refresh(data);
	}

	// Token: 0x0600C7FE RID: 51198 RVA: 0x003B8887 File Offset: 0x003B6A87
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C7FF RID: 51199 RVA: 0x003B8890 File Offset: 0x003B6A90
	[NullableContext(1)]
	private void OnPlotEnd(PlotResultInfo plotResult)
	{
		HonamiStoryModel instance = HonamiStoryModel.Instance;
		if (instance.CurrentSelectNode != null && instance.CurrentSelectNode.GetConfig.Type == 1)
		{
			UiManager.Instance.ResetToBattleView(null);
		}
	}

	// Token: 0x040071C3 RID: 29123
	private const int COST_ITEM_ID = 80600001;

	// Token: 0x040071C4 RID: 29124
	private PopupCaptionItem CaptionItem;

	// Token: 0x040071C5 RID: 29125
	private HonamiStoryTechnologyNodeItem FirstTreeNode;

	// Token: 0x040071C6 RID: 29126
	[Nullable(1)]
	private GenericScrollViewNew<HonamiStoryTechnologyAreaItem, HonamiStoryTechAreaData> PnlNodeList;

	// Token: 0x040071C7 RID: 29127
	private HonamiStoryTechnologyInfoPanel PnlTechnologyInfo;

	// Token: 0x040071C8 RID: 29128
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x040071C9 RID: 29129
	private HonamiStoryBozaiTalkPanel BoZaiTalk;

	// Token: 0x040071CA RID: 29130
	private bool IsInitSelect;

	// Token: 0x040071CB RID: 29131
	private int InitSelectNodeId = -1;

	// Token: 0x02007670 RID: 30320
	[NullableContext(0)]
	private enum EHonamiStoryTechnologyComponent
	{
		// Token: 0x04026733 RID: 157491
		FirstTreeNode,
		// Token: 0x04026734 RID: 157492
		PnlTechnologyGrid,
		// Token: 0x04026735 RID: 157493
		PnlTechnologyInfo,
		// Token: 0x04026736 RID: 157494
		SvTreeInfo,
		// Token: 0x04026737 RID: 157495
		ContentRootNode,
		// Token: 0x04026738 RID: 157496
		CaptionItem,
		// Token: 0x04026739 RID: 157497
		BoZaiTalkPanel
	}
}
