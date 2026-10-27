using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C4F RID: 7247
public class FunctionOpenView : UiViewBase
{
	// Token: 0x0600DA94 RID: 55956 RVA: 0x0032C420 File Offset: 0x0032A620
	[NullableContext(1)]
	public FunctionOpenView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DA95 RID: 55957 RVA: 0x0032C42C File Offset: 0x0032A62C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickClose));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600DA96 RID: 55958 RVA: 0x0032C538 File Offset: 0x0032A738
	protected override void OnStart()
	{
		if (PlotModel.Instance.IsInHighLevelPlot())
		{
			this.RootItem.SetUIActive(false);
		}
		this.RefreshInfo(FunctionModel.Instance.PopNewOpenFunctionList().Value);
	}

	// Token: 0x0600DA97 RID: 55959 RVA: 0x0032C578 File Offset: 0x0032A778
	protected override void OnAfterShow()
	{
		this.UiViewSequence.PlaySequence("Show", true, null);
	}

	// Token: 0x0600DA98 RID: 55960 RVA: 0x0032C5A0 File Offset: 0x0032A7A0
	private void ShowNextFunction(FunctionCondition functionCondition)
	{
		this.UiViewSequence.PlaySequence("Show", true, null);
		this.RefreshInfo(functionCondition);
	}

	// Token: 0x0600DA99 RID: 55961 RVA: 0x0032C5D0 File Offset: 0x0032A7D0
	private void RefreshInfo(FunctionCondition functionCondition)
	{
		UUITexture texture = base.GetTexture(0);
		base.SetTextureByPath(functionCondition.Icon, texture, null, null);
		base.GetText(1).ShowTextNew(functionCondition.Title);
		base.GetText(2).ShowTextNew(functionCondition.Desc);
	}

	// Token: 0x0600DA9A RID: 55962 RVA: 0x0032C624 File Offset: 0x0032A824
	private void OnClickClose()
	{
		FunctionCondition? functionCondition = FunctionModel.Instance.PopNewOpenFunctionList();
		if (functionCondition != null)
		{
			this.ShowNextFunction(functionCondition.Value);
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600DA9B RID: 55963 RVA: 0x0032C65A File Offset: 0x0032A85A
	protected override void OnBeforeShow()
	{
		GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("FunctionOpenView");
	}

	// Token: 0x0600DA9C RID: 55964 RVA: 0x0032C66B File Offset: 0x0032A86B
	protected override void OnAfterHide()
	{
		GameSettingsDeviceRender.Instance.CancelTemporaryDisableFrameGeneration("FunctionOpenView");
	}

	// Token: 0x02008211 RID: 33297
	private enum EFunctionOpenViewDefine
	{
		// Token: 0x0402A728 RID: 173864
		Icon,
		// Token: 0x0402A729 RID: 173865
		TitleText,
		// Token: 0x0402A72A RID: 173866
		DescText,
		// Token: 0x0402A72B RID: 173867
		CloseButton,
		// Token: 0x0402A72C RID: 173868
		CloseText
	}
}
