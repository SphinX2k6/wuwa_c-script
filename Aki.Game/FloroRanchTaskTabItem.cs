using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001BA1 RID: 7073
public class FloroRanchTaskTabItem : GridProxyAbstract<FloroRanchTaskTab>
{
	// Token: 0x0600D298 RID: 53912 RVA: 0x003064FC File Offset: 0x003046FC
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

	// Token: 0x0600D299 RID: 53913 RVA: 0x003065C4 File Offset: 0x003047C4
	public override void Refresh(FloroRanchTaskTab floroRanchTaskTab, bool isSelected, int gridIndex)
	{
		this.FloroRanchTaskTabType = (EFloroRanchTaskTabType)floroRanchTaskTab.Id;
		string tabName = floroRanchTaskTab.TabName;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), tabName, Array.Empty<object>());
		this.RefreshRedDot();
	}

	// Token: 0x0600D29A RID: 53914 RVA: 0x00306604 File Offset: 0x00304804
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

	// Token: 0x0600D29B RID: 53915 RVA: 0x0030663C File Offset: 0x0030483C
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600D29C RID: 53916 RVA: 0x00306662 File Offset: 0x00304862
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x0600D29D RID: 53917 RVA: 0x0030666B File Offset: 0x0030486B
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x0600D29E RID: 53918 RVA: 0x00306674 File Offset: 0x00304874
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.FloroRanchTaskTabType);
		}
	}

	// Token: 0x0400608B RID: 24715
	private EFloroRanchTaskTabType FloroRanchTaskTabType = EFloroRanchTaskTabType.Dungeon;

	// Token: 0x0400608C RID: 24716
	[Nullable(2)]
	public Action<int, EFloroRanchTaskTabType> OnToggleCallBack;

	// Token: 0x0200813D RID: 33085
	private class EComponents
	{
		// Token: 0x0402A2F7 RID: 172791
		public const int TextTabName = 0;

		// Token: 0x0402A2F8 RID: 172792
		public const int ToggleRoot = 1;

		// Token: 0x0402A2F9 RID: 172793
		public const int ItemRedDot = 2;
	}
}
