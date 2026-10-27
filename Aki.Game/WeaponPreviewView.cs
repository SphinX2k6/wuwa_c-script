using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002CFB RID: 11515
[NullableContext(2)]
[Nullable(0)]
public class WeaponPreviewView : UiViewBase
{
	// Token: 0x06018332 RID: 99122 RVA: 0x006283BC File Offset: 0x006265BC
	[NullableContext(1)]
	public WeaponPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06018333 RID: 99123 RVA: 0x006283CC File Offset: 0x006265CC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06018334 RID: 99124 RVA: 0x00628458 File Offset: 0x00626658
	protected override UniTask OnBeforeStartAsync()
	{
		WeaponPreviewView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeaponPreviewView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06018335 RID: 99125 RVA: 0x0062849C File Offset: 0x0062669C
	protected override void OnBeforeShow()
	{
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.WeaponLevelUpView);
		IWeaponPreviewViewParam weaponPreviewViewParam = this.OpenParam as IWeaponPreviewViewParam;
		WeaponListComponent weaponListComponent = this.WeaponListComponent;
		if (weaponListComponent == null)
		{
			return;
		}
		weaponListComponent.SetCurSelect(weaponPreviewViewParam.SelectedIndex);
	}

	// Token: 0x06018336 RID: 99126 RVA: 0x006284D6 File Offset: 0x006266D6
	protected override void OnAfterHide()
	{
		WeaponListComponent weaponListComponent = this.WeaponListComponent;
		if (weaponListComponent != null)
		{
			weaponListComponent.CancelSelect();
		}
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.None);
	}

	// Token: 0x06018337 RID: 99127 RVA: 0x006284F4 File Offset: 0x006266F4
	private void OnCloseBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.WeaponPreviewView, null);
	}

	// Token: 0x06018338 RID: 99128 RVA: 0x00628508 File Offset: 0x00626708
	private void OnWeaponChange()
	{
		WeaponTrialData weaponTrialData = this.WeaponListComponent.GetCurSelectedData() as WeaponTrialData;
		WeaponTrialData fullLevelWeaponData = weaponTrialData.GetFullLevelWeaponData();
		if (fullLevelWeaponData == null)
		{
			this.CaptionItem.SetToggleVisible(false);
		}
		else
		{
			this.CaptionItem.SetToggleVisible(true);
			weaponTrialData = ((this.CaptionItem.GetToggleState() == EToggleState.ETT_Checked) ? fullLevelWeaponData : weaponTrialData);
		}
		this.WeaponDetailComponent.UpdateComponent(weaponTrialData);
		WeaponController.Instance.OnSelectedWeaponChange(weaponTrialData, this.WeaponObserver, this.WeaponScabbardObserver, -1, this.NeedMeshStreaming);
	}

	// Token: 0x06018339 RID: 99129 RVA: 0x0062858C File Offset: 0x0062678C
	protected override void OnBeforeCreate()
	{
		IWeaponPreviewViewParam weaponPreviewViewParam = this.OpenParam as IWeaponPreviewViewParam;
		WeaponSkeletalObserverHandles weaponSkeletalObserverHandles = (weaponPreviewViewParam != null) ? weaponPreviewViewParam.WeaponObservers : null;
		if (weaponSkeletalObserverHandles != null)
		{
			this.WeaponObserver = weaponSkeletalObserverHandles.WeaponObserver;
			this.WeaponScabbardObserver = weaponSkeletalObserverHandles.WeaponScabbardObserver;
			return;
		}
		this.WeaponObserver = UiSceneManager.Instance.InitWeaponObserver(this.NeedMeshStreaming);
		this.WeaponScabbardObserver = UiSceneManager.Instance.InitWeaponScabbardObserver();
	}

	// Token: 0x0601833A RID: 99130 RVA: 0x006285F4 File Offset: 0x006267F4
	protected override void OnBeforeDestroy()
	{
		IWeaponPreviewViewParam weaponPreviewViewParam = this.OpenParam as IWeaponPreviewViewParam;
		if (((weaponPreviewViewParam != null) ? weaponPreviewViewParam.WeaponObservers : null) != null)
		{
			return;
		}
		UiSceneManager.Instance.DestroyWeaponObserver(this.WeaponObserver);
		this.WeaponObserver = null;
		UiSceneManager.Instance.DestroyWeaponScabbardObserver(this.WeaponScabbardObserver);
		this.WeaponScabbardObserver = null;
	}

	// Token: 0x0601833B RID: 99131 RVA: 0x0062864C File Offset: 0x0062684C
	private void OnClickFullLevelToggle(EToggleState state)
	{
		WeaponTrialData weaponTrialData = this.WeaponListComponent.GetCurSelectedData() as WeaponTrialData;
		WeaponTrialData fullLevelWeaponData = weaponTrialData.GetFullLevelWeaponData();
		if (state == EToggleState.ETT_Checked && fullLevelWeaponData != null)
		{
			weaponTrialData = fullLevelWeaponData;
		}
		this.WeaponDetailComponent.UpdateComponent(weaponTrialData);
		WeaponController.Instance.OnSelectedWeaponChange(weaponTrialData, this.WeaponObserver, this.WeaponScabbardObserver, -1, this.NeedMeshStreaming);
	}

	// Token: 0x0400B3E3 RID: 46051
	private WeaponDetailTipsComponent WeaponDetailComponent;

	// Token: 0x0400B3E4 RID: 46052
	private WeaponListComponent WeaponListComponent;

	// Token: 0x0400B3E5 RID: 46053
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400B3E6 RID: 46054
	private readonly bool NeedMeshStreaming = true;

	// Token: 0x0400B3E7 RID: 46055
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x0400B3E8 RID: 46056
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x02009292 RID: 37522
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402F63D RID: 194109
		WeaponDetailItem,
		// Token: 0x0402F63E RID: 194110
		CaptionItem,
		// Token: 0x0402F63F RID: 194111
		WeaponScrollView
	}
}
