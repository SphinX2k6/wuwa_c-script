using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001060 RID: 4192
public class FloroRanchTaskTabItem : GridProxyAbstract<FloroRanchTaskTab>
{
	// Token: 0x0600A6A9 RID: 42665 RVA: 0x003115DC File Offset: 0x0030F7DC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A6AA RID: 42666 RVA: 0x003116A4 File Offset: 0x0030F8A4
	public override void Refresh(FloroRanchTaskTab floroRanchTaskTab, bool isSelected, int gridIndex)
	{
		this.FloroRanchTaskTabType = (EFloroRanchTaskTabType)floroRanchTaskTab.Id;
		string tabName = floroRanchTaskTab.TabName;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), tabName, Array.Empty<object>());
		this.RefreshRedDot();
	}

	// Token: 0x0600A6AB RID: 42667 RVA: 0x003116E4 File Offset: 0x0030F8E4
	public void RefreshRedDot()
	{
		bool uiactive = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true).IsTaskHasRedDotByTab(this.FloroRanchTaskTabType);
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x0600A6AC RID: 42668 RVA: 0x0031171C File Offset: 0x0030F91C
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600A6AD RID: 42669 RVA: 0x00311742 File Offset: 0x0030F942
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x0600A6AE RID: 42670 RVA: 0x0031174B File Offset: 0x0030F94B
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x0600A6AF RID: 42671 RVA: 0x00311754 File Offset: 0x0030F954
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.FloroRanchTaskTabType);
		}
	}

	// Token: 0x0400615A RID: 24922
	private EFloroRanchTaskTabType FloroRanchTaskTabType = EFloroRanchTaskTabType.Dungeon;

	// Token: 0x0400615B RID: 24923
	[Nullable(2)]
	public Action<int, EFloroRanchTaskTabType> OnToggleCallBack;

	// Token: 0x020072CB RID: 29387
	private class EComponents
	{
		// Token: 0x0402562B RID: 153131
		public const int TextTabName = 0;

		// Token: 0x0402562C RID: 153132
		public const int ToggleRoot = 1;

		// Token: 0x0402562D RID: 153133
		public const int ItemRedDot = 2;
	}
}
