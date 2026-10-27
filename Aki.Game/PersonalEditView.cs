using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020023D4 RID: 9172
[NullableContext(2)]
[Nullable(0)]
public class PersonalEditView : UiViewBase
{
	// Token: 0x06012555 RID: 75093 RVA: 0x00484156 File Offset: 0x00482356
	[NullableContext(1)]
	public PersonalEditView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x170017C9 RID: 6089
	// (get) Token: 0x06012556 RID: 75094 RVA: 0x0048415F File Offset: 0x0048235F
	private new EPersonalEditDefine OpenParam
	{
		get
		{
			return (EPersonalEditDefine)this.OpenParam;
		}
	}

	// Token: 0x06012557 RID: 75095 RVA: 0x0048416C File Offset: 0x0048236C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIInteractionGroup))
		};
	}

	// Token: 0x06012558 RID: 75096 RVA: 0x00484208 File Offset: 0x00482408
	[NullableContext(1)]
	private PersonalEditTabItem CreatePersonalEditTabItem()
	{
		PersonalEditTabItem personalEditTabItem = new PersonalEditTabItem();
		personalEditTabItem.SetToggleCallBack(new Action<int, EPersonalEditDefine>(this.TabItemToggleClick));
		return personalEditTabItem;
	}

	// Token: 0x06012559 RID: 75097 RVA: 0x00484224 File Offset: 0x00482424
	protected override UniTask OnBeforeStartAsync()
	{
		PersonalEditView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PersonalEditView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601255A RID: 75098 RVA: 0x00484267 File Offset: 0x00482467
	protected override void OnStart()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView == null)
		{
			return;
		}
		childPopView.PopItem.OverrideBackBtnCallBack(new Action(this.OnClose));
	}

	// Token: 0x0601255B RID: 75099 RVA: 0x0048428A File Offset: 0x0048248A
	public void TabItemToggleClick(int gridIndex, EPersonalEditDefine personalEditType)
	{
		this.TabLayout.SelectGridProxy(gridIndex, false);
		this.ShowContent(personalEditType).Forget();
	}

	// Token: 0x0601255C RID: 75100 RVA: 0x004842A8 File Offset: 0x004824A8
	public UniTask ShowContent(EPersonalEditDefine personalEditType)
	{
		PersonalEditView.<ShowContent>d__15 <ShowContent>d__;
		<ShowContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowContent>d__.<>4__this = this;
		<ShowContent>d__.personalEditType = personalEditType;
		<ShowContent>d__.<>1__state = -1;
		<ShowContent>d__.<>t__builder.Start<PersonalEditView.<ShowContent>d__15>(ref <ShowContent>d__);
		return <ShowContent>d__.<>t__builder.Task;
	}

	// Token: 0x0601255D RID: 75101 RVA: 0x004842F4 File Offset: 0x004824F4
	public void UpdateCollectNum()
	{
		int num = 0;
		switch (this.EditType)
		{
		case EPersonalEditDefine.HeadPhoto:
			num = PersonalModel.Instance.GetUnlockHeadNum();
			break;
		case EPersonalEditDefine.Card:
			num = this.PersonalInfoData.GetUnlockCardDataCount();
			break;
		case EPersonalEditDefine.PlayerTitle:
			num = PersonalModel.Instance.GetUnlockTitleDataCount();
			break;
		}
		LguiUtil.Instance.SetLocalText(base.GetText(2), "Collected", new <>z__ReadOnlySingleElementList<object>(num));
	}

	// Token: 0x0601255E RID: 75102 RVA: 0x00484365 File Offset: 0x00482565
	public void OnClickedConfirm()
	{
	}

	// Token: 0x0601255F RID: 75103 RVA: 0x00484368 File Offset: 0x00482568
	protected override void OnBeforeDestroy()
	{
		PersonalHeadPhotoComponent personalHeadPhotoComponent = this.PersonalHeadPhotoComponent;
		if (personalHeadPhotoComponent != null)
		{
			personalHeadPhotoComponent.Destroy(null);
		}
		this.PersonalHeadPhotoComponent = null;
		PersonalCardComponent personalCardComponent = this.PersonalCardComponent;
		if (personalCardComponent != null)
		{
			personalCardComponent.Destroy(null);
		}
		this.PersonalCardComponent = null;
		PersonalPlayerTitleComponent personalTitleComponent = this.PersonalTitleComponent;
		if (personalTitleComponent != null)
		{
			personalTitleComponent.Destroy(null);
		}
		this.PersonalTitleComponent = null;
	}

	// Token: 0x06012560 RID: 75104 RVA: 0x004843C0 File Offset: 0x004825C0
	public void RefreshBtnConfirm(bool isInteractive, bool isBeUsed)
	{
		this.ConfirmBtn.SetEnableClick(isInteractive);
		base.GetInteractionGroup(5).SetInteractable(isInteractive);
		string textId;
		if (this.EditType == EPersonalEditDefine.PlayerTitle)
		{
			textId = (isBeUsed ? "Text_PhantomTakeOff_Text" : "ConfirmBox_173_ButtonText_1");
		}
		else
		{
			textId = (isBeUsed ? "Text_InUse_Text" : "ConfirmBox_173_ButtonText_1");
		}
		this.ConfirmBtn.SetLocalTextNew(textId, Array.Empty<object>());
	}

	// Token: 0x06012561 RID: 75105 RVA: 0x00484428 File Offset: 0x00482628
	private void OnClose()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.PersonalOptionView))
		{
			UiManager.Instance.CloseView(EUiViewName.PersonalOptionView, null);
		}
		UiManager.Instance.CloseView(EUiViewName.PersonalEditView, null);
	}

	// Token: 0x04008AA0 RID: 35488
	private EPersonalEditDefine EditType;

	// Token: 0x04008AA1 RID: 35489
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PersonalEditTabItem, EPersonalEditDefine> TabLayout;

	// Token: 0x04008AA2 RID: 35490
	private PersonalCardComponent PersonalCardComponent;

	// Token: 0x04008AA3 RID: 35491
	private PersonalHeadPhotoComponent PersonalHeadPhotoComponent;

	// Token: 0x04008AA4 RID: 35492
	private PersonalPlayerTitleComponent PersonalTitleComponent;

	// Token: 0x04008AA5 RID: 35493
	private PersonalInfoData PersonalInfoData;

	// Token: 0x04008AA6 RID: 35494
	private ButtonItem ConfirmBtn;
}
