using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016CC RID: 5836
public class AdviceCreateChangeBtnItem : UiPanelBase
{
	// Token: 0x0600A6F3 RID: 42739 RVA: 0x00256D6D File Offset: 0x00254F6D
	[NullableContext(1)]
	public AdviceCreateChangeBtnItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A6F4 RID: 42740 RVA: 0x00256D84 File Offset: 0x00254F84
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

	// Token: 0x0600A6F5 RID: 42741 RVA: 0x00256E01 File Offset: 0x00255001
	private void OnChangeBtn()
	{
		this.InitWordViewParam();
		UiManager.Instance.OpenView(EUiViewName.AdviceWordView, null, null);
	}

	// Token: 0x0600A6F6 RID: 42742 RVA: 0x00256E1C File Offset: 0x0025501C
	private void InitWordViewParam()
	{
		AdviceModel instance = AdviceModel.Instance;
		instance.CurrentChangeWordType = EChangeWordType.Sentence;
		int currentSelectWordId;
		instance.CurrentSentenceWordMap.TryGetValue(this.Index, out currentSelectWordId);
		instance.CurrentSelectWordId = currentSelectWordId;
		instance.CurrentPreSelectSentenceIndex = this.Index;
	}

	// Token: 0x0600A6F7 RID: 42743 RVA: 0x00256E5B File Offset: 0x0025505B
	public void SetIndex(int index)
	{
		this.Index = index;
	}

	// Token: 0x0600A6F8 RID: 42744 RVA: 0x00256E64 File Offset: 0x00255064
	public void UpdateCurrentLineMode(ELineMode lineMode)
	{
		this.RefreshViewText(lineMode);
	}

	// Token: 0x0600A6F9 RID: 42745 RVA: 0x00256E70 File Offset: 0x00255070
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

	// Token: 0x04004B6B RID: 19307
	private int Index;

	// Token: 0x02007CA1 RID: 31905
	private static class EComponents
	{
		// Token: 0x04028E1E RID: 167454
		public const int ChangeBtn = 0;

		// Token: 0x04028E1F RID: 167455
		public const int ChangeText = 1;

		// Token: 0x04028E20 RID: 167456
		public const int ItemSelf = 2;
	}
}
