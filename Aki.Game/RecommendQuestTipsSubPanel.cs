using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200125C RID: 4700
[NullableContext(1)]
[Nullable(0)]
public class RecommendQuestTipsSubPanel : UiPanelBase
{
	// Token: 0x06007FB6 RID: 32694 RVA: 0x001B074C File Offset: 0x001AE94C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickTipsBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007FB7 RID: 32695 RVA: 0x001B07F2 File Offset: 0x001AE9F2
	public void SetTipsTxtByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x06007FB8 RID: 32696 RVA: 0x001B0807 File Offset: 0x001AEA07
	public void SetTipsTxt(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x06007FB9 RID: 32697 RVA: 0x001B0817 File Offset: 0x001AEA17
	public void BindClickBtnTipsCallBack(TRecommendQuestTipsBtnCallBack callBack)
	{
		this.QuestTipsBtnCallBack = callBack;
	}

	// Token: 0x06007FBA RID: 32698 RVA: 0x001B0820 File Offset: 0x001AEA20
	private void OnClickTipsBtn()
	{
		TRecommendQuestTipsBtnCallBack questTipsBtnCallBack = this.QuestTipsBtnCallBack;
		if (questTipsBtnCallBack == null)
		{
			return;
		}
		questTipsBtnCallBack();
	}

	// Token: 0x06007FBB RID: 32699 RVA: 0x001B0834 File Offset: 0x001AEA34
	public void SetBtnActive(bool active)
	{
		UUIButtonComponent button = base.GetButton(1);
		if (button == null)
		{
			return;
		}
		UUIItem uuiitem = button.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(active);
	}

	// Token: 0x04003A1A RID: 14874
	[Nullable(2)]
	private TRecommendQuestTipsBtnCallBack QuestTipsBtnCallBack;

	// Token: 0x02007871 RID: 30833
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04027AFA RID: 162554
		TxtTips,
		// Token: 0x04027AFB RID: 162555
		BtnTips
	}
}
