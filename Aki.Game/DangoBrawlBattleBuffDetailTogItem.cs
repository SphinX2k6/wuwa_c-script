using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001171 RID: 4465
public class DangoBrawlBattleBuffDetailTogItem : GridProxyAbstract<EDangoBrawlBuffType>
{
	// Token: 0x0600B1D6 RID: 45526 RVA: 0x003491F8 File Offset: 0x003473F8
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

	// Token: 0x0600B1D7 RID: 45527 RVA: 0x003492BF File Offset: 0x003474BF
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

	// Token: 0x0600B1D8 RID: 45528 RVA: 0x003492F4 File Offset: 0x003474F4
	public override void Refresh(EDangoBrawlBuffType buffType, bool isSelected, int gridIndex)
	{
		this.CurBuffType = buffType;
		string textStringId = (buffType == EDangoBrawlBuffType.Buff) ? "DangoBrawlGeneral_1009" : "DangoBrawlGeneral_1010";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
	}

	// Token: 0x0600B1D9 RID: 45529 RVA: 0x00349330 File Offset: 0x00347530
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x0600B1DA RID: 45530 RVA: 0x0034933A File Offset: 0x0034753A
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x0600B1DB RID: 45531 RVA: 0x00349344 File Offset: 0x00347544
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

	// Token: 0x0600B1DC RID: 45532 RVA: 0x0034936E File Offset: 0x0034756E
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

	// Token: 0x0600B1DD RID: 45533 RVA: 0x0034938C File Offset: 0x0034758C
	private bool OnCanExecuteChange()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
	}

	// Token: 0x0400669F RID: 26271
	[Nullable(2)]
	public Action<EDangoBrawlBuffType> OnClickType;

	// Token: 0x040066A0 RID: 26272
	private EDangoBrawlBuffType CurBuffType = EDangoBrawlBuffType.Buff;

	// Token: 0x0200741A RID: 29722
	private enum EComp
	{
		// Token: 0x04025CB4 RID: 154804
		TogItem,
		// Token: 0x04025CB5 RID: 154805
		TxtToggle,
		// Token: 0x04025CB6 RID: 154806
		RedDotItem
	}
}
