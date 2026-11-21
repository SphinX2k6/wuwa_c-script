using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B84 RID: 2948
public class AdviceCreateChangeBtnItem : UiPanelBase
{
	// Token: 0x06007AD3 RID: 31443 RVA: 0x00261179 File Offset: 0x0025F379
	[NullableContext(1)]
	public AdviceCreateChangeBtnItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06007AD4 RID: 31444 RVA: 0x00261190 File Offset: 0x0025F390
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnChangeBtn))
		};
	}

	// Token: 0x06007AD5 RID: 31445 RVA: 0x0026120D File Offset: 0x0025F40D
	private void OnChangeBtn()
	{
		this.InitWordViewParam();
		UiManager.Instance.OpenView(EUiViewName.AdviceWordView, null, null);
	}

	// Token: 0x06007AD6 RID: 31446 RVA: 0x00261228 File Offset: 0x0025F428
	private void InitWordViewParam()
	{
		AdviceModel instance = AdviceModel.Instance;
		instance.CurrentChangeWordType = EChangeWordType.Sentence;
		int currentSelectWordId;
		instance.CurrentSentenceWordMap.TryGetValue(this.Index, out currentSelectWordId);
		instance.CurrentSelectWordId = currentSelectWordId;
		instance.CurrentPreSelectSentenceIndex = this.Index;
	}

	// Token: 0x06007AD7 RID: 31447 RVA: 0x00261267 File Offset: 0x0025F467
	public void SetIndex(int index)
	{
		this.Index = index;
	}

	// Token: 0x06007AD8 RID: 31448 RVA: 0x00261270 File Offset: 0x0025F470
	public void UpdateCurrentLineMode(ELineMode lineMode)
	{
		this.RefreshViewText(lineMode);
	}

	// Token: 0x06007AD9 RID: 31449 RVA: 0x0026127C File Offset: 0x0025F47C
	private void RefreshViewText(ELineMode lineMode)
	{
		if (lineMode == ELineMode.SingleLine)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(1), "ChangeOneLineWord", Array.Empty<object>());
			return;
		}
		if (this.Index == 0)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(1), "ChangeFirstLineWord", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalText(base.GetText(1), "ChangeLastLineWord", Array.Empty<object>());
	}

	// Token: 0x04004C12 RID: 19474
	private int Index;

	// Token: 0x02006E26 RID: 28198
	private static class EComponents
	{
		// Token: 0x04024147 RID: 147783
		public const int ChangeBtn = 0;

		// Token: 0x04024148 RID: 147784
		public const int ChangeText = 1;

		// Token: 0x04024149 RID: 147785
		public const int ItemSelf = 2;
	}
}
