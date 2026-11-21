using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000710 RID: 1808
[NullableContext(1)]
[Nullable(0)]
public class RecommendQuestTipsSubPanel : UiPanelBase
{
	// Token: 0x0600534D RID: 21325 RVA: 0x001B93FC File Offset: 0x001B75FC
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

	// Token: 0x0600534E RID: 21326 RVA: 0x001B94A2 File Offset: 0x001B76A2
	public void SetTipsTxtByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x0600534F RID: 21327 RVA: 0x001B94B7 File Offset: 0x001B76B7
	public void SetTipsTxt(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x06005350 RID: 21328 RVA: 0x001B94C7 File Offset: 0x001B76C7
	public void BindClickBtnTipsCallBack(TRecommendQuestTipsBtnCallBack callBack)
	{
		this.QuestTipsBtnCallBack = callBack;
	}

	// Token: 0x06005351 RID: 21329 RVA: 0x001B94D0 File Offset: 0x001B76D0
	private void OnClickTipsBtn()
	{
		TRecommendQuestTipsBtnCallBack questTipsBtnCallBack = this.QuestTipsBtnCallBack;
		if (questTipsBtnCallBack == null)
		{
			return;
		}
		questTipsBtnCallBack();
	}

	// Token: 0x06005352 RID: 21330 RVA: 0x001B94E4 File Offset: 0x001B76E4
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

	// Token: 0x04003AB2 RID: 15026
	[Nullable(2)]
	private TRecommendQuestTipsBtnCallBack QuestTipsBtnCallBack;

	// Token: 0x020069FC RID: 27132
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04022E2B RID: 142891
		TxtTips,
		// Token: 0x04022E2C RID: 142892
		BtnTips
	}
}
