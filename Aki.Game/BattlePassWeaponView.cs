using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002337 RID: 9015
[NullableContext(2)]
[Nullable(0)]
public class BattlePassWeaponView : UiTabViewBase
{
	// Token: 0x06011D90 RID: 73104 RVA: 0x00465A44 File Offset: 0x00463C44
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06011D91 RID: 73105 RVA: 0x00465AB0 File Offset: 0x00463CB0
	protected override UniTask OnBeforeStartAsync()
	{
		BattlePassWeaponView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BattlePassWeaponView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011D92 RID: 73106 RVA: 0x00465AF3 File Offset: 0x00463CF3
	protected override void OnBeforeShow()
	{
		WeaponListComponent weaponListComponent = this.WeaponListComponent;
		if (weaponListComponent == null)
		{
			return;
		}
		weaponListComponent.SetCurSelect(0);
	}

	// Token: 0x06011D93 RID: 73107 RVA: 0x00465B06 File Offset: 0x00463D06
	protected override void OnAfterHide()
	{
		WeaponListComponent weaponListComponent = this.WeaponListComponent;
		if (weaponListComponent == null)
		{
			return;
		}
		weaponListComponent.CancelSelect();
	}

	// Token: 0x06011D94 RID: 73108 RVA: 0x00465B18 File Offset: 0x00463D18
	private void OnWeaponChange()
	{
		WeaponTrialData weaponTrialData = (WeaponTrialData)this.WeaponListComponent.GetCurSelectedData();
		WeaponTrialData fullLevelWeaponData = weaponTrialData.GetFullLevelWeaponData();
		if (fullLevelWeaponData != null)
		{
			weaponTrialData = ((this.ToggleState == EToggleState.ETT_Checked) ? fullLevelWeaponData : weaponTrialData);
		}
		this.WeaponDetailComponent.UpdateComponent(weaponTrialData);
		WeaponController.Instance.OnSelectedWeaponChange(weaponTrialData, this.WeaponObserver, this.WeaponScabbardObserver, -1, true);
	}

	// Token: 0x06011D95 RID: 73109 RVA: 0x00465B75 File Offset: 0x00463D75
	public void OnClickFullLevelToggle(EToggleState state)
	{
		this.RefreshToggleState(state);
	}

	// Token: 0x06011D96 RID: 73110 RVA: 0x00465B80 File Offset: 0x00463D80
	public void RefreshToggleState(EToggleState state)
	{
		if (state == this.ToggleState)
		{
			return;
		}
		this.ToggleState = state;
		if (!base.IsShowOrShowing)
		{
			return;
		}
		WeaponTrialData weaponTrialData = (WeaponTrialData)this.WeaponListComponent.GetCurSelectedData();
		WeaponTrialData fullLevelWeaponData = weaponTrialData.GetFullLevelWeaponData();
		if (state == EToggleState.ETT_Checked && fullLevelWeaponData != null)
		{
			weaponTrialData = fullLevelWeaponData;
		}
		this.WeaponDetailComponent.UpdateComponent(weaponTrialData);
		WeaponController.Instance.OnSelectedWeaponChange(weaponTrialData, this.WeaponObserver, this.WeaponScabbardObserver, -1, true);
	}

	// Token: 0x04008743 RID: 34627
	private WeaponDetailTipsComponent WeaponDetailComponent;

	// Token: 0x04008744 RID: 34628
	private WeaponListComponent WeaponListComponent;

	// Token: 0x04008745 RID: 34629
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x04008746 RID: 34630
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x04008747 RID: 34631
	private EToggleState ToggleState = EToggleState.ETT_Checked;

	// Token: 0x020088BC RID: 35004
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402C706 RID: 182022
		WeaponDetailItem,
		// Token: 0x0402C707 RID: 182023
		WeaponScrollView
	}
}
