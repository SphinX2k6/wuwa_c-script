using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000948 RID: 2376
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressTabSwitchItemPanel : CommonTabItemBase, ITabViewRegister
{
	// Token: 0x060068DA RID: 26842 RVA: 0x0020C1D0 File Offset: 0x0020A3D0
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

	// Token: 0x060068DB RID: 26843 RVA: 0x0020C298 File Offset: 0x0020A498
	public override void Refresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.OnRefresh(data, isSelected, gridIndex);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(false);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x060068DC RID: 26844 RVA: 0x0020C2E7 File Offset: 0x0020A4E7
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060068DD RID: 26845 RVA: 0x0020C300 File Offset: 0x0020A500
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x060068DE RID: 26846 RVA: 0x0020C30E File Offset: 0x0020A50E
	private void OnExtendToggleToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x060068DF RID: 26847 RVA: 0x0020C327 File Offset: 0x0020A527
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x060068E0 RID: 26848 RVA: 0x0020C339 File Offset: 0x0020A539
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		if (data.Data != null)
		{
			base.UpdateTabIcon(data.Data.GetIcon() ?? string.Empty);
		}
	}

	// Token: 0x060068E1 RID: 26849 RVA: 0x0020C35D File Offset: 0x0020A55D
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x060068E2 RID: 26850 RVA: 0x0020C35F File Offset: 0x0020A55F
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x060068E3 RID: 26851 RVA: 0x0020C368 File Offset: 0x0020A568
	public void UpdateView(ActivityRegressTabSwitchItemCommonData tabData)
	{
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, tabData.Title, Array.Empty<object>());
	}

	// Token: 0x02006C48 RID: 27720
	[NullableContext(0)]
	private class EActivityRecallTabSwitchItemPanelComponents
	{
		// Token: 0x0402395B RID: 145755
		public const int NameTxt = 0;

		// Token: 0x0402395C RID: 145756
		public const int SwitchToggle = 1;

		// Token: 0x0402395D RID: 145757
		public const int RedDotItem = 2;
	}
}
