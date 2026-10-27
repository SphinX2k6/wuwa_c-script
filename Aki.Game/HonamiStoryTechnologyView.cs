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

// Token: 0x02001EF3 RID: 7923
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryTechnologyView : UiViewBase
{
	// Token: 0x0600F3D5 RID: 62421 RVA: 0x003AC9BE File Offset: 0x003AABBE
	[NullableContext(1)]
	public HonamiStoryTechnologyView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F3D6 RID: 62422 RVA: 0x003AC9D0 File Offset: 0x003AABD0
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

	// Token: 0x0600F3D7 RID: 62423 RVA: 0x003ACAE0 File Offset: 0x003AACE0
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryTechnologyView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryTechnologyView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F3D8 RID: 62424 RVA: 0x003ACB24 File Offset: 0x003AAD24
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

	// Token: 0x0600F3D9 RID: 62425 RVA: 0x003ACC17 File Offset: 0x003AAE17
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHonamiStoryTechNodeLevelUpdate, new Action(this.OnTechNodeUpdate));
		EventSystem.Instance.Add(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotEnd));
	}

	// Token: 0x0600F3DA RID: 62426 RVA: 0x003ACC51 File Offset: 0x003AAE51
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHonamiStoryTechNodeLevelUpdate, new Action(this.OnTechNodeUpdate));
		EventSystem.Instance.Remove(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotEnd));
	}

	// Token: 0x0600F3DB RID: 62427 RVA: 0x003ACC8C File Offset: 0x003AAE8C
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

	// Token: 0x0600F3DC RID: 62428 RVA: 0x003ACCD8 File Offset: 0x003AAED8
	private UniTask OnNodeUpdateAsync()
	{
		HonamiStoryTechnologyView.<OnNodeUpdateAsync>d__17 <OnNodeUpdateAsync>d__;
		<OnNodeUpdateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnNodeUpdateAsync>d__.<>4__this = this;
		<OnNodeUpdateAsync>d__.<>1__state = -1;
		<OnNodeUpdateAsync>d__.<>t__builder.Start<HonamiStoryTechnologyView.<OnNodeUpdateAsync>d__17>(ref <OnNodeUpdateAsync>d__);
		return <OnNodeUpdateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F3DD RID: 62429 RVA: 0x003ACD1B File Offset: 0x003AAF1B
	[NullableContext(1)]
	private HonamiStoryTechnologyAreaItem InitAreaItem()
	{
		return new HonamiStoryTechnologyAreaItem
		{
			OnAfterRefreshOneNode = new Action<HonamiStoryTechnologyNodeItem>(this.OnAfterRefreshOneNode)
		};
	}

	// Token: 0x0600F3DE RID: 62430 RVA: 0x003ACD34 File Offset: 0x003AAF34
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

	// Token: 0x0600F3DF RID: 62431 RVA: 0x003ACD8B File Offset: 0x003AAF8B
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F3E0 RID: 62432 RVA: 0x003ACD94 File Offset: 0x003AAF94
	[NullableContext(1)]
	private void OnPlotEnd(PlotResultInfo plotResult)
	{
		HonamiStoryModel instance = HonamiStoryModel.Instance;
		if (instance.CurrentSelectNode != null && instance.CurrentSelectNode.GetConfig.Type == 1)
		{
			UiManager.Instance.ResetToBattleView(null);
		}
	}

	// Token: 0x040070E2 RID: 28898
	private const int COST_ITEM_ID = 80600001;

	// Token: 0x040070E3 RID: 28899
	private PopupCaptionItem CaptionItem;

	// Token: 0x040070E4 RID: 28900
	private HonamiStoryTechnologyNodeItem FirstTreeNode;

	// Token: 0x040070E5 RID: 28901
	[Nullable(1)]
	private GenericScrollViewNew<HonamiStoryTechnologyAreaItem, HonamiStoryTechAreaData> PnlNodeList;

	// Token: 0x040070E6 RID: 28902
	private HonamiStoryTechnologyInfoPanel PnlTechnologyInfo;

	// Token: 0x040070E7 RID: 28903
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x040070E8 RID: 28904
	private HonamiStoryBozaiTalkPanel BoZaiTalk;

	// Token: 0x040070E9 RID: 28905
	private bool IsInitSelect;

	// Token: 0x040070EA RID: 28906
	private int InitSelectNodeId = -1;

	// Token: 0x020084EB RID: 34027
	[NullableContext(0)]
	private enum EHonamiStoryTechnologyComponent
	{
		// Token: 0x0402B40F RID: 177167
		FirstTreeNode,
		// Token: 0x0402B410 RID: 177168
		PnlTechnologyGrid,
		// Token: 0x0402B411 RID: 177169
		PnlTechnologyInfo,
		// Token: 0x0402B412 RID: 177170
		SvTreeInfo,
		// Token: 0x0402B413 RID: 177171
		ContentRootNode,
		// Token: 0x0402B414 RID: 177172
		CaptionItem,
		// Token: 0x0402B415 RID: 177173
		BoZaiTalkPanel
	}
}
