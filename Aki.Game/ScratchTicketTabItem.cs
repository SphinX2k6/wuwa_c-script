using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020009AB RID: 2475
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ScratchTicketTabItem : GridProxyAbstract<ScratchTicketRoundData>
{
	// Token: 0x06006CAF RID: 27823 RVA: 0x0021A394 File Offset: 0x00218594
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

	// Token: 0x06006CB0 RID: 27824 RVA: 0x0021A47C File Offset: 0x0021867C
	protected override void OnBeforeCreateImplement()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
		base.GetExtendToggle(0).CanExecuteChange.Bind(() => base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_UnChecked);
	}

	// Token: 0x06006CB1 RID: 27825 RVA: 0x0021A4B4 File Offset: 0x002186B4
	public override void Refresh(ScratchTicketRoundData data, bool isSelected, int gridIndex)
	{
		this.RoundData = data;
		this.SetSpriteByPath(data.Config.Value.TogRoundIcon, base.GetSprite(1), false, null, null);
		EScratchTicketRoundState roundState = data.GetRoundState();
		base.GetItem(2).SetUIActive(roundState == EScratchTicketRoundState.Lock);
		base.GetItem(3).SetUIActive(roundState == EScratchTicketRoundState.Finish);
	}

	// Token: 0x06006CB2 RID: 27826 RVA: 0x0021A51C File Offset: 0x0021871C
	public void SetSelect(bool state, bool isFireEvent)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleStateForce(state2, isFireEvent, false, false);
	}

	// Token: 0x06006CB3 RID: 27827 RVA: 0x0021A541 File Offset: 0x00218741
	private void OnClickTabToggle(EToggleState toggleState)
	{
		Action<ScratchTicketRoundData, ScratchTicketTabItem> clickToggleCallBack = this.ClickToggleCallBack;
		if (clickToggleCallBack == null)
		{
			return;
		}
		clickToggleCallBack(this.RoundData, this);
	}

	// Token: 0x06006CB4 RID: 27828 RVA: 0x0021A55A File Offset: 0x0021875A
	public void SetClickToggleCallback(Action<ScratchTicketRoundData, ScratchTicketTabItem> callback)
	{
		this.ClickToggleCallBack = callback;
	}

	// Token: 0x040043E0 RID: 17376
	[Nullable(2)]
	private ScratchTicketRoundData RoundData;

	// Token: 0x040043E1 RID: 17377
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<ScratchTicketRoundData, ScratchTicketTabItem> ClickToggleCallBack;

	// Token: 0x040043E2 RID: 17378
	[Nullable(2)]
	public UiBehaviorLevelSequence UiLevelSequence;

	// Token: 0x02006CB2 RID: 27826
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04023B43 RID: 146243
		public const int TabToggle = 0;

		// Token: 0x04023B44 RID: 146244
		public const int RoundIcon = 1;

		// Token: 0x04023B45 RID: 146245
		public const int LockItem = 2;

		// Token: 0x04023B46 RID: 146246
		public const int FinishItem = 3;
	}
}
