using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002255 RID: 8789
[NullableContext(2)]
[Nullable(0)]
public class WeaponPreviewView : UiViewBase
{
	// Token: 0x06015BD3 RID: 89043 RVA: 0x0064E384 File Offset: 0x0064C584
	[NullableContext(1)]
	public WeaponPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015BD4 RID: 89044 RVA: 0x0064E394 File Offset: 0x0064C594
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

	// Token: 0x06015BD5 RID: 89045 RVA: 0x0064E420 File Offset: 0x0064C620
	protected override UniTask OnBeforeStartAsync()
	{
		WeaponPreviewView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeaponPreviewView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015BD6 RID: 89046 RVA: 0x0064E464 File Offset: 0x0064C664
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

	// Token: 0x06015BD7 RID: 89047 RVA: 0x0064E49E File Offset: 0x0064C69E
	protected override void OnAfterHide()
	{
		WeaponListComponent weaponListComponent = this.WeaponListComponent;
		if (weaponListComponent != null)
		{
			weaponListComponent.CancelSelect();
		}
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.None);
	}

	// Token: 0x06015BD8 RID: 89048 RVA: 0x0064E4BC File Offset: 0x0064C6BC
	private void OnCloseBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.WeaponPreviewView, null);
	}

	// Token: 0x06015BD9 RID: 89049 RVA: 0x0064E4D0 File Offset: 0x0064C6D0
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

	// Token: 0x06015BDA RID: 89050 RVA: 0x0064E554 File Offset: 0x0064C754
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

	// Token: 0x06015BDB RID: 89051 RVA: 0x0064E5BC File Offset: 0x0064C7BC
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

	// Token: 0x06015BDC RID: 89052 RVA: 0x0064E614 File Offset: 0x0064C814
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

	// Token: 0x0400B758 RID: 46936
	private WeaponDetailTipsComponent WeaponDetailComponent;

	// Token: 0x0400B759 RID: 46937
	private WeaponListComponent WeaponListComponent;

	// Token: 0x0400B75A RID: 46938
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400B75B RID: 46939
	private readonly bool NeedMeshStreaming = true;

	// Token: 0x0400B75C RID: 46940
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x0400B75D RID: 46941
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x020084BA RID: 33978
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402ACC7 RID: 175303
		WeaponDetailItem,
		// Token: 0x0402ACC8 RID: 175304
		CaptionItem,
		// Token: 0x0402ACC9 RID: 175305
		WeaponScrollView
	}
}
