using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001389 RID: 5001
[NullableContext(1)]
[Nullable(0)]
public class TargetTog : UiPanelBase
{
	// Token: 0x0600C679 RID: 50809 RVA: 0x003B2238 File Offset: 0x003B0438
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

	// Token: 0x0600C67A RID: 50810 RVA: 0x003B2320 File Offset: 0x003B0520
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(() => this.CanToggleChange == null || this.Target == null || this.CanToggleChange(this.Target.Value));
	}

	// Token: 0x0600C67B RID: 50811 RVA: 0x003B233F File Offset: 0x003B053F
	public void RefreshTog(ETarget target, bool isUnLock)
	{
		this.Target = new ETarget?(target);
		this.IsUnLock = isUnLock;
		base.GetItem(1).SetUIActive(this.IsUnLock);
		base.GetItem(2).SetUIActive(!this.IsUnLock);
	}

	// Token: 0x0600C67C RID: 50812 RVA: 0x003B237B File Offset: 0x003B057B
	private void OnTogClick(EToggleState toggleState)
	{
		Action onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack();
	}

	// Token: 0x17001318 RID: 4888
	// (get) Token: 0x0600C67D RID: 50813 RVA: 0x003B238D File Offset: 0x003B058D
	public UUIExtendToggle GetTog
	{
		get
		{
			return base.GetExtendToggle(0);
		}
	}

	// Token: 0x0600C67E RID: 50814 RVA: 0x003B2396 File Offset: 0x003B0596
	public void SetRedDotShow(bool isShow)
	{
		base.GetItem(3).SetUIActive(isShow);
	}

	// Token: 0x04007117 RID: 28951
	private bool IsUnLock;

	// Token: 0x04007118 RID: 28952
	public ETarget? Target;

	// Token: 0x04007119 RID: 28953
	[Nullable(2)]
	public Action OnClickToggleBack;

	// Token: 0x0400711A RID: 28954
	[Nullable(2)]
	public Func<ETarget, bool> CanToggleChange;
}
