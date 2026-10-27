using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E16 RID: 7702
[NullableContext(1)]
[Nullable(0)]
public class HandBookQuestPlotItem : UiPanelBase, IDynamicScrollItem<HandBookQuestDynamicData>
{
	// Token: 0x0600EA30 RID: 59952 RVA: 0x00376DA4 File Offset: 0x00374FA4
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

	// Token: 0x0600EA31 RID: 59953 RVA: 0x00376DF0 File Offset: 0x00374FF0
	private UniTask InitChildItem()
	{
		HandBookQuestPlotItem.<InitChildItem>d__4 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<HandBookQuestPlotItem.<InitChildItem>d__4>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600EA32 RID: 59954 RVA: 0x00376E33 File Offset: 0x00375033
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600EA33 RID: 59955 RVA: 0x00376E6C File Offset: 0x0037506C
	[return: Nullable(2)]
	public AUIBaseActor GetUsingItem(HandBookQuestDynamicData data)
	{
		return base.GetItem(1).GetOwner() as AUIBaseActor;
	}

	// Token: 0x0600EA34 RID: 59956 RVA: 0x00376E7F File Offset: 0x0037507F
	public void Update(HandBookQuestDynamicData data, int index)
	{
		this.PlotNodeItem.SetUiActive(true);
		this.PlotNodeItem.Update(data.TidText, this.IsSelectNode(data.TidText));
	}

	// Token: 0x0600EA35 RID: 59957 RVA: 0x00376EAA File Offset: 0x003750AA
	public UUIExtendToggle GetNodeToggle()
	{
		return this.PlotNodeItem.GetNodeToggle();
	}

	// Token: 0x0600EA36 RID: 59958 RVA: 0x00376EB7 File Offset: 0x003750B7
	public void SetToggleState(EToggleState state)
	{
		this.PlotNodeItem.SetToggleState(state);
	}

	// Token: 0x0600EA37 RID: 59959 RVA: 0x00376EC5 File Offset: 0x003750C5
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x0600EA38 RID: 59960 RVA: 0x00376ECE File Offset: 0x003750CE
	public void BindClickCallback(TSelectedCallback onClickCallback)
	{
		this.OnCallBack = onClickCallback;
	}

	// Token: 0x0600EA39 RID: 59961 RVA: 0x00376ED7 File Offset: 0x003750D7
	private bool IsSelectNode(string tidText)
	{
		return this.IsSelectFunction != null && this.IsSelectFunction(tidText);
	}

	// Token: 0x0600EA3A RID: 59962 RVA: 0x00376EEF File Offset: 0x003750EF
	public void BindIsSelectFunction(TSelectFunction isSelectFunction)
	{
		this.IsSelectFunction = isSelectFunction;
	}

	// Token: 0x0600EA3B RID: 59963 RVA: 0x00376EF8 File Offset: 0x003750F8
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

	// Token: 0x0600EA3C RID: 59964 RVA: 0x00376F0B File Offset: 0x0037510B
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

	// Token: 0x04006CAB RID: 27819
	[Nullable(2)]
	public PlotNodeItem PlotNodeItem;

	// Token: 0x04006CAC RID: 27820
	[Nullable(2)]
	private TSelectedCallback OnCallBack;

	// Token: 0x04006CAD RID: 27821
	[Nullable(2)]
	private TSelectFunction IsSelectFunction;
}
