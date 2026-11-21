using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000795 RID: 1941
public class MapTravelTabItemBase : UiPanelBase
{
	// Token: 0x060058EA RID: 22762 RVA: 0x001CE75C File Offset: 0x001CC95C
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

	// Token: 0x060058EB RID: 22763 RVA: 0x001CE886 File Offset: 0x001CCA86
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

	// Token: 0x060058EC RID: 22764 RVA: 0x001CE8A8 File Offset: 0x001CCAA8
	public void SetToggleState(bool bOn, bool bFireEvent)
	{
		EToggleState state = bOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, bFireEvent, false, false);
	}

	// Token: 0x04003C64 RID: 15460
	[Nullable(2)]
	protected SoarChallengePlayData Data;

	// Token: 0x04003C65 RID: 15461
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<SoarChallengePlayData> SelectedCallBack;

	// Token: 0x02006A80 RID: 27264
	private class ETabComponents
	{
		// Token: 0x040230BC RID: 143548
		public const int Toggle = 0;

		// Token: 0x040230BD RID: 143549
		public const int Name = 1;

		// Token: 0x040230BE RID: 143550
		public const int SpriteDone = 2;

		// Token: 0x040230BF RID: 143551
		public const int SpriteLock = 3;

		// Token: 0x040230C0 RID: 143552
		public const int RedDot = 4;

		// Token: 0x040230C1 RID: 143553
		public const int ItemNew = 5;
	}
}
