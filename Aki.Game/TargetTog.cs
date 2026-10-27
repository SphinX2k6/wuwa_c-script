using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EC7 RID: 7879
[NullableContext(1)]
[Nullable(0)]
public class TargetTog : UiPanelBase
{
	// Token: 0x0600F25A RID: 62042 RVA: 0x003A6738 File Offset: 0x003A4938
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
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
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTogClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F25B RID: 62043 RVA: 0x003A6820 File Offset: 0x003A4A20
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(() => this.CanToggleChange == null || this.Target == null || this.CanToggleChange(this.Target.Value));
	}

	// Token: 0x0600F25C RID: 62044 RVA: 0x003A683F File Offset: 0x003A4A3F
	public void RefreshTog(ETarget target, bool isUnLock)
	{
		this.Target = new ETarget?(target);
		this.IsUnLock = isUnLock;
		base.GetItem(1).SetUIActive(this.IsUnLock);
		base.GetItem(2).SetUIActive(!this.IsUnLock);
	}

	// Token: 0x0600F25D RID: 62045 RVA: 0x003A687B File Offset: 0x003A4A7B
	private void OnTogClick(EToggleState toggleState)
	{
		Action onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack();
	}

	// Token: 0x170012EE RID: 4846
	// (get) Token: 0x0600F25E RID: 62046 RVA: 0x003A688D File Offset: 0x003A4A8D
	public UUIExtendToggle GetTog
	{
		get
		{
			return base.GetExtendToggle(0);
		}
	}

	// Token: 0x0600F25F RID: 62047 RVA: 0x003A6896 File Offset: 0x003A4A96
	public void SetRedDotShow(bool isShow)
	{
		base.GetItem(3).SetUIActive(isShow);
	}

	// Token: 0x04007036 RID: 28726
	private bool IsUnLock;

	// Token: 0x04007037 RID: 28727
	public ETarget? Target;

	// Token: 0x04007038 RID: 28728
	[Nullable(2)]
	public Action OnClickToggleBack;

	// Token: 0x04007039 RID: 28729
	[Nullable(2)]
	public Func<ETarget, bool> CanToggleChange;
}
