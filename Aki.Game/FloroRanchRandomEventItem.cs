using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200105B RID: 4187
public class FloroRanchRandomEventItem : GridProxyAbstract<int>
{
	// Token: 0x0600A686 RID: 42630 RVA: 0x0031082C File Offset: 0x0030EA2C
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

	// Token: 0x0600A687 RID: 42631 RVA: 0x003108D4 File Offset: 0x0030EAD4
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

	// Token: 0x0600A688 RID: 42632 RVA: 0x0031091C File Offset: 0x0030EB1C
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

	// Token: 0x0600A689 RID: 42633 RVA: 0x003109B8 File Offset: 0x0030EBB8
	[NullableContext(1)]
	public void BindClickCallback(Action<int, int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x0600A68A RID: 42634 RVA: 0x003109C1 File Offset: 0x0030EBC1
	private void OnClickToggle(EToggleState state)
	{
		this.ClickCallback(base.GridIndex, this.ChoiceId);
	}

	// Token: 0x0600A68B RID: 42635 RVA: 0x003109DA File Offset: 0x0030EBDA
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600A68C RID: 42636 RVA: 0x003109EC File Offset: 0x0030EBEC
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600A68D RID: 42637 RVA: 0x003109FE File Offset: 0x0030EBFE
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(1));
	}

	// Token: 0x0400614F RID: 24911
	[Nullable(1)]
	private Action<int, int> ClickCallback;

	// Token: 0x04006150 RID: 24912
	private int ChoiceId;

	// Token: 0x020072C5 RID: 29381
	private class EItemComponent
	{
		// Token: 0x04025609 RID: 153097
		public const int Toggle = 0;

		// Token: 0x0402560A RID: 153098
		public const int Desc = 1;
	}
}
