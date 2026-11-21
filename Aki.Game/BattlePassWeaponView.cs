using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200181C RID: 6172
[NullableContext(2)]
[Nullable(0)]
public class BattlePassWeaponView : UiTabViewBase
{
	// Token: 0x0600F240 RID: 62016 RVA: 0x00472B0C File Offset: 0x00470D0C
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

	// Token: 0x0600F241 RID: 62017 RVA: 0x00472B78 File Offset: 0x00470D78
	protected override UniTask OnBeforeStartAsync()
	{
		BattlePassWeaponView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BattlePassWeaponView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F242 RID: 62018 RVA: 0x00472BBB File Offset: 0x00470DBB
	protected override void OnBeforeShow()
	{
		WeaponListComponent weaponListComponent = this.WeaponListComponent;
		if (weaponListComponent == null)
		{
			return;
		}
		weaponListComponent.SetCurSelect(0);
	}

	// Token: 0x0600F243 RID: 62019 RVA: 0x00472BCE File Offset: 0x00470DCE
	protected override void OnAfterHide()
	{
		WeaponListComponent weaponListComponent = this.WeaponListComponent;
		if (weaponListComponent == null)
		{
			return;
		}
		weaponListComponent.CancelSelect();
	}

	// Token: 0x0600F244 RID: 62020 RVA: 0x00472BE0 File Offset: 0x00470DE0
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

	// Token: 0x0600F245 RID: 62021 RVA: 0x00472C3D File Offset: 0x00470E3D
	public void OnClickFullLevelToggle(EToggleState state)
	{
		this.RefreshToggleState(state);
	}

	// Token: 0x0600F246 RID: 62022 RVA: 0x00472C48 File Offset: 0x00470E48
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

	// Token: 0x04008886 RID: 34950
	private WeaponDetailTipsComponent WeaponDetailComponent;

	// Token: 0x04008887 RID: 34951
	private WeaponListComponent WeaponListComponent;

	// Token: 0x04008888 RID: 34952
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x04008889 RID: 34953
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x0400888A RID: 34954
	private EToggleState ToggleState = EToggleState.ETT_Checked;

	// Token: 0x02007A45 RID: 31301
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04027A1A RID: 162330
		WeaponDetailItem,
		// Token: 0x04027A1B RID: 162331
		WeaponScrollView
	}
}
