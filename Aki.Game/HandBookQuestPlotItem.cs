using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012D8 RID: 4824
[NullableContext(1)]
[Nullable(0)]
public class HandBookQuestPlotItem : UiPanelBase, IDynamicScrollItem<HandBookQuestDynamicData>
{
	// Token: 0x0600BE4F RID: 48719 RVA: 0x00382AAC File Offset: 0x00380CAC
	public UniTask Init(UUIItem actor)
	{
		HandBookQuestPlotItem.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<HandBookQuestPlotItem.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600BE50 RID: 48720 RVA: 0x00382AF8 File Offset: 0x00380CF8
	private UniTask InitChildItem()
	{
		HandBookQuestPlotItem.<InitChildItem>d__4 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<HandBookQuestPlotItem.<InitChildItem>d__4>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600BE51 RID: 48721 RVA: 0x00382B3B File Offset: 0x00380D3B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600BE52 RID: 48722 RVA: 0x00382B74 File Offset: 0x00380D74
	[return: Nullable(2)]
	public AUIBaseActor GetUsingItem(HandBookQuestDynamicData data)
	{
		return base.GetItem(1).GetOwner() as AUIBaseActor;
	}

	// Token: 0x0600BE53 RID: 48723 RVA: 0x00382B87 File Offset: 0x00380D87
	public void Update(HandBookQuestDynamicData data, int index)
	{
		this.PlotNodeItem.SetUiActive(true);
		this.PlotNodeItem.Update(data.TidText, this.IsSelectNode(data.TidText));
	}

	// Token: 0x0600BE54 RID: 48724 RVA: 0x00382BB2 File Offset: 0x00380DB2
	public UUIExtendToggle GetNodeToggle()
	{
		return this.PlotNodeItem.GetNodeToggle();
	}

	// Token: 0x0600BE55 RID: 48725 RVA: 0x00382BBF File Offset: 0x00380DBF
	public void SetToggleState(EToggleState state)
	{
		this.PlotNodeItem.SetToggleState(state);
	}

	// Token: 0x0600BE56 RID: 48726 RVA: 0x00382BCD File Offset: 0x00380DCD
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x0600BE57 RID: 48727 RVA: 0x00382BD6 File Offset: 0x00380DD6
	public void BindClickCallback(TSelectedCallback onClickCallback)
	{
		this.OnCallBack = onClickCallback;
	}

	// Token: 0x0600BE58 RID: 48728 RVA: 0x00382BDF File Offset: 0x00380DDF
	private bool IsSelectNode(string tidText)
	{
		return this.IsSelectFunction != null && this.IsSelectFunction(tidText);
	}

	// Token: 0x0600BE59 RID: 48729 RVA: 0x00382BF7 File Offset: 0x00380DF7
	public void BindIsSelectFunction(TSelectFunction isSelectFunction)
	{
		this.IsSelectFunction = isSelectFunction;
	}

	// Token: 0x0600BE5A RID: 48730 RVA: 0x00382C00 File Offset: 0x00380E00
	[NullableContext(2)]
	public string GetTidText()
	{
		PlotNodeItem plotNodeItem = this.PlotNodeItem;
		if (plotNodeItem == null)
		{
			return null;
		}
		return plotNodeItem.GetTidText();
	}

	// Token: 0x0600BE5B RID: 48731 RVA: 0x00382C13 File Offset: 0x00380E13
	[NullableContext(2)]
	public UUIExtendToggle GetToggleItem()
	{
		PlotNodeItem plotNodeItem = this.PlotNodeItem;
		if (plotNodeItem == null)
		{
			return null;
		}
		return plotNodeItem.GetNodeToggle();
	}

	// Token: 0x04006D8C RID: 28044
	[Nullable(2)]
	public PlotNodeItem PlotNodeItem;

	// Token: 0x04006D8D RID: 28045
	[Nullable(2)]
	private TSelectedCallback OnCallBack;

	// Token: 0x04006D8E RID: 28046
	[Nullable(2)]
	private TSelectFunction IsSelectFunction;
}
