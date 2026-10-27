using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CAF RID: 7343
public class DangoBrawlBattleBuffDetailTogItem : GridProxyAbstract<EDangoBrawlBuffType>
{
	// Token: 0x0600DDB9 RID: 56761 RVA: 0x0033D7BC File Offset: 0x0033B9BC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTogItem));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600DDBA RID: 56762 RVA: 0x0033D883 File Offset: 0x0033BA83
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.CanExecuteChange.Unbind();
		}
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x0600DDBB RID: 56763 RVA: 0x0033D8B8 File Offset: 0x0033BAB8
	public override void Refresh(EDangoBrawlBuffType buffType, bool isSelected, int gridIndex)
	{
		this.CurBuffType = buffType;
		string textStringId = (buffType == EDangoBrawlBuffType.Buff) ? "DangoBrawlGeneral_1009" : "DangoBrawlGeneral_1010";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
	}

	// Token: 0x0600DDBC RID: 56764 RVA: 0x0033D8F4 File Offset: 0x0033BAF4
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x0600DDBD RID: 56765 RVA: 0x0033D8FE File Offset: 0x0033BAFE
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x0600DDBE RID: 56766 RVA: 0x0033D908 File Offset: 0x0033BB08
	private void SetToggleState(bool state, bool fireEvent)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(state2, fireEvent, false, false);
	}

	// Token: 0x0600DDBF RID: 56767 RVA: 0x0033D932 File Offset: 0x0033BB32
	private void OnClickTogItem(EToggleState toggleState)
	{
		if (toggleState != EToggleState.ETT_Checked)
		{
			return;
		}
		Action<EDangoBrawlBuffType> onClickType = this.OnClickType;
		if (onClickType == null)
		{
			return;
		}
		onClickType(this.CurBuffType);
	}

	// Token: 0x0600DDC0 RID: 56768 RVA: 0x0033D950 File Offset: 0x0033BB50
	private bool OnCanExecuteChange()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
	}

	// Token: 0x040065C0 RID: 26048
	[Nullable(2)]
	public Action<EDangoBrawlBuffType> OnClickType;

	// Token: 0x040065C1 RID: 26049
	private EDangoBrawlBuffType CurBuffType = EDangoBrawlBuffType.Buff;

	// Token: 0x02008290 RID: 33424
	private enum EComp
	{
		// Token: 0x0402A989 RID: 174473
		TogItem,
		// Token: 0x0402A98A RID: 174474
		TxtToggle,
		// Token: 0x0402A98B RID: 174475
		RedDotItem
	}
}
