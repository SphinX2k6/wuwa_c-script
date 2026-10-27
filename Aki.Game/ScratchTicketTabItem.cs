using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014F3 RID: 5363
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ScratchTicketTabItem : GridProxyAbstract<ScratchTicketRoundData>
{
	// Token: 0x060098D5 RID: 39125 RVA: 0x002106A4 File Offset: 0x0020E8A4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTabToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060098D6 RID: 39126 RVA: 0x0021078C File Offset: 0x0020E98C
	protected override void OnBeforeCreateImplement()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
		base.GetExtendToggle(0).CanExecuteChange.Bind(() => base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_UnChecked);
	}

	// Token: 0x060098D7 RID: 39127 RVA: 0x002107C4 File Offset: 0x0020E9C4
	public override void Refresh(ScratchTicketRoundData data, bool isSelected, int gridIndex)
	{
		this.RoundData = data;
		this.SetSpriteByPath(data.Config.Value.TogRoundIcon, base.GetSprite(1), false, null, null);
		EScratchTicketRoundState roundState = data.GetRoundState();
		base.GetItem(2).SetUIActive(roundState == EScratchTicketRoundState.Lock);
		base.GetItem(3).SetUIActive(roundState == EScratchTicketRoundState.Finish);
	}

	// Token: 0x060098D8 RID: 39128 RVA: 0x0021082C File Offset: 0x0020EA2C
	public void SetSelect(bool state, bool isFireEvent)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleStateForce(state2, isFireEvent, false, false);
	}

	// Token: 0x060098D9 RID: 39129 RVA: 0x00210851 File Offset: 0x0020EA51
	private void OnClickTabToggle(EToggleState toggleState)
	{
		Action<ScratchTicketRoundData, ScratchTicketTabItem> clickToggleCallBack = this.ClickToggleCallBack;
		if (clickToggleCallBack == null)
		{
			return;
		}
		clickToggleCallBack(this.RoundData, this);
	}

	// Token: 0x060098DA RID: 39130 RVA: 0x0021086A File Offset: 0x0020EA6A
	public void SetClickToggleCallback(Action<ScratchTicketRoundData, ScratchTicketTabItem> callback)
	{
		this.ClickToggleCallBack = callback;
	}

	// Token: 0x0400433B RID: 17211
	[Nullable(2)]
	private ScratchTicketRoundData RoundData;

	// Token: 0x0400433C RID: 17212
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<ScratchTicketRoundData, ScratchTicketTabItem> ClickToggleCallBack;

	// Token: 0x0400433D RID: 17213
	[Nullable(2)]
	public UiBehaviorLevelSequence UiLevelSequence;

	// Token: 0x02007B26 RID: 31526
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04028805 RID: 165893
		public const int TabToggle = 0;

		// Token: 0x04028806 RID: 165894
		public const int RoundIcon = 1;

		// Token: 0x04028807 RID: 165895
		public const int LockItem = 2;

		// Token: 0x04028808 RID: 165896
		public const int FinishItem = 3;
	}
}
