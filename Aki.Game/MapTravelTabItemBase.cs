using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012E1 RID: 4833
public class MapTravelTabItemBase : UiPanelBase
{
	// Token: 0x0600854F RID: 34127 RVA: 0x001C5900 File Offset: 0x001C3B00
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleSelectOn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008550 RID: 34128 RVA: 0x001C5A2A File Offset: 0x001C3C2A
	private void OnToggleSelectOn(EToggleState _)
	{
		if (this.Data != null)
		{
			Action<SoarChallengePlayData> selectedCallBack = this.SelectedCallBack;
			if (selectedCallBack == null)
			{
				return;
			}
			selectedCallBack(this.Data);
		}
	}

	// Token: 0x06008551 RID: 34129 RVA: 0x001C5A4C File Offset: 0x001C3C4C
	public void SetToggleState(bool bOn, bool bFireEvent)
	{
		EToggleState state = bOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, bFireEvent, false, false);
	}

	// Token: 0x04003BCC RID: 15308
	[Nullable(2)]
	protected SoarChallengePlayData Data;

	// Token: 0x04003BCD RID: 15309
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<SoarChallengePlayData> SelectedCallBack;

	// Token: 0x020078F6 RID: 30966
	private class ETabComponents
	{
		// Token: 0x04027D8E RID: 163214
		public const int Toggle = 0;

		// Token: 0x04027D8F RID: 163215
		public const int Name = 1;

		// Token: 0x04027D90 RID: 163216
		public const int SpriteDone = 2;

		// Token: 0x04027D91 RID: 163217
		public const int SpriteLock = 3;

		// Token: 0x04027D92 RID: 163218
		public const int RedDot = 4;

		// Token: 0x04027D93 RID: 163219
		public const int ItemNew = 5;
	}
}
