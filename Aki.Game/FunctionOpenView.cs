using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200110E RID: 4366
public class FunctionOpenView : UiViewBase
{
	// Token: 0x0600AEAA RID: 44714 RVA: 0x00337828 File Offset: 0x00335A28
	[NullableContext(1)]
	public FunctionOpenView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600AEAB RID: 44715 RVA: 0x00337834 File Offset: 0x00335A34
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

	// Token: 0x0600AEAC RID: 44716 RVA: 0x00337940 File Offset: 0x00335B40
	protected override void OnStart()
	{
		if (PlotModel.Instance.IsInHighLevelPlot())
		{
			this.RootItem.SetUIActive(false);
		}
		this.RefreshInfo(FunctionModel.Instance.PopNewOpenFunctionList().Value);
	}

	// Token: 0x0600AEAD RID: 44717 RVA: 0x00337980 File Offset: 0x00335B80
	protected override void OnAfterShow()
	{
		this.UiViewSequence.PlaySequence("Show", true, null);
	}

	// Token: 0x0600AEAE RID: 44718 RVA: 0x003379A8 File Offset: 0x00335BA8
	private void ShowNextFunction(FunctionCondition functionCondition)
	{
		this.UiViewSequence.PlaySequence("Show", true, null);
		this.RefreshInfo(functionCondition);
	}

	// Token: 0x0600AEAF RID: 44719 RVA: 0x003379D8 File Offset: 0x00335BD8
	private void RefreshInfo(FunctionCondition functionCondition)
	{
		UUITexture texture = base.GetTexture(0);
		base.SetTextureByPath(functionCondition.Icon, texture, null, null);
		base.GetText(1).ShowTextNew(functionCondition.Title);
		base.GetText(2).ShowTextNew(functionCondition.Desc);
	}

	// Token: 0x0600AEB0 RID: 44720 RVA: 0x00337A2C File Offset: 0x00335C2C
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

	// Token: 0x0600AEB1 RID: 44721 RVA: 0x00337A62 File Offset: 0x00335C62
	protected override void OnBeforeShow()
	{
		GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("FunctionOpenView");
	}

	// Token: 0x0600AEB2 RID: 44722 RVA: 0x00337A73 File Offset: 0x00335C73
	protected override void OnAfterHide()
	{
		GameSettingsDeviceRender.Instance.CancelTemporaryDisableFrameGeneration("FunctionOpenView");
	}

	// Token: 0x0200739A RID: 29594
	private enum EFunctionOpenViewDefine
	{
		// Token: 0x04025A4F RID: 154191
		Icon,
		// Token: 0x04025A50 RID: 154192
		TitleText,
		// Token: 0x04025A51 RID: 154193
		DescText,
		// Token: 0x04025A52 RID: 154194
		CloseButton,
		// Token: 0x04025A53 RID: 154195
		CloseText
	}
}
