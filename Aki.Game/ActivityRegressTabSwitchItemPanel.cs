using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001494 RID: 5268
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressTabSwitchItemPanel : CommonTabItemBase, ITabViewRegister
{
	// Token: 0x06009545 RID: 38213 RVA: 0x00203268 File Offset: 0x00201468
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnExtendToggleToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009546 RID: 38214 RVA: 0x00203330 File Offset: 0x00201530
	public override void Refresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.OnRefresh(data, isSelected, gridIndex);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(false);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x06009547 RID: 38215 RVA: 0x0020337F File Offset: 0x0020157F
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06009548 RID: 38216 RVA: 0x00203398 File Offset: 0x00201598
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x06009549 RID: 38217 RVA: 0x002033A6 File Offset: 0x002015A6
	private void OnExtendToggleToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x0600954A RID: 38218 RVA: 0x002033BF File Offset: 0x002015BF
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x0600954B RID: 38219 RVA: 0x002033D1 File Offset: 0x002015D1
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		if (data.Data != null)
		{
			base.UpdateTabIcon(data.Data.GetIcon() ?? string.Empty);
		}
	}

	// Token: 0x0600954C RID: 38220 RVA: 0x002033F5 File Offset: 0x002015F5
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x0600954D RID: 38221 RVA: 0x002033F7 File Offset: 0x002015F7
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x0600954E RID: 38222 RVA: 0x00203400 File Offset: 0x00201600
	public void UpdateView(ActivityRegressTabSwitchItemCommonData tabData)
	{
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, tabData.Title, Array.Empty<object>());
	}

	// Token: 0x02007AC4 RID: 31428
	[NullableContext(0)]
	private class EActivityRecallTabSwitchItemPanelComponents
	{
		// Token: 0x04028641 RID: 165441
		public const int NameTxt = 0;

		// Token: 0x04028642 RID: 165442
		public const int SwitchToggle = 1;

		// Token: 0x04028643 RID: 165443
		public const int RedDotItem = 2;
	}
}
