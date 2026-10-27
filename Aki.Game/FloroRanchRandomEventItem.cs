using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001B9C RID: 7068
public class FloroRanchRandomEventItem : GridProxyAbstract<int>
{
	// Token: 0x0600D275 RID: 53877 RVA: 0x0030574C File Offset: 0x0030394C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D276 RID: 53878 RVA: 0x003057F4 File Offset: 0x003039F4
	protected override void OnStart()
	{
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(1),
			ViewType = ETermExplanationViewType.Center,
			Style = new ETermExplanationViewStyle?(ETermExplanationViewStyle.FloroRanch),
			ReportType = ETermExplanationReportType.FloroRanch
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x0600D277 RID: 53879 RVA: 0x0030583C File Offset: 0x00303A3C
	public override void Refresh(int choiceId, bool isSelected, int gridIndex)
	{
		this.ChoiceId = choiceId;
		FloroRanchWeeklyChoice? floroRanchWeeklyChoiceById = FloroRanchConfig.Instance.GetFloroRanchWeeklyChoiceById(this.ChoiceId);
		if (floroRanchWeeklyChoiceById != null)
		{
			string desc = floroRanchWeeklyChoiceById.Value.Desc;
			if (!string.IsNullOrEmpty(desc))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), desc, floroRanchWeeklyChoiceById.Value.NameParam());
				return;
			}
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(this.ChoiceId.ToString(), true);
			return;
		}
		else
		{
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew("Farm_Skip");
			return;
		}
	}

	// Token: 0x0600D278 RID: 53880 RVA: 0x003058D8 File Offset: 0x00303AD8
	[NullableContext(1)]
	public void BindClickCallback(Action<int, int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x0600D279 RID: 53881 RVA: 0x003058E1 File Offset: 0x00303AE1
	private void OnClickToggle(EToggleState state)
	{
		this.ClickCallback(base.GridIndex, this.ChoiceId);
	}

	// Token: 0x0600D27A RID: 53882 RVA: 0x003058FA File Offset: 0x00303AFA
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600D27B RID: 53883 RVA: 0x0030590C File Offset: 0x00303B0C
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600D27C RID: 53884 RVA: 0x0030591E File Offset: 0x00303B1E
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(1));
	}

	// Token: 0x04006080 RID: 24704
	[Nullable(1)]
	private Action<int, int> ClickCallback;

	// Token: 0x04006081 RID: 24705
	private int ChoiceId;

	// Token: 0x02008137 RID: 33079
	private class EItemComponent
	{
		// Token: 0x0402A2D5 RID: 172757
		public const int Toggle = 0;

		// Token: 0x0402A2D6 RID: 172758
		public const int Desc = 1;
	}
}
