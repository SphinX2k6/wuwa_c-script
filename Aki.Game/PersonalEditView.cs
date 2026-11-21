using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020018B9 RID: 6329
[NullableContext(2)]
[Nullable(0)]
public class PersonalEditView : UiViewBase
{
	// Token: 0x0600FA07 RID: 64007 RVA: 0x00491661 File Offset: 0x0048F861
	[NullableContext(1)]
	public PersonalEditView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001803 RID: 6147
	// (get) Token: 0x0600FA08 RID: 64008 RVA: 0x0049166A File Offset: 0x0048F86A
	private new EPersonalEditDefine OpenParam
	{
		get
		{
			return (EPersonalEditDefine)this.OpenParam;
		}
	}

	// Token: 0x0600FA09 RID: 64009 RVA: 0x00491678 File Offset: 0x0048F878
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

	// Token: 0x0600FA0A RID: 64010 RVA: 0x00491714 File Offset: 0x0048F914
	[NullableContext(1)]
	private PersonalEditTabItem CreatePersonalEditTabItem()
	{
		PersonalEditTabItem personalEditTabItem = new PersonalEditTabItem();
		personalEditTabItem.SetToggleCallBack(new Action<int, EPersonalEditDefine>(this.TabItemToggleClick));
		return personalEditTabItem;
	}

	// Token: 0x0600FA0B RID: 64011 RVA: 0x00491730 File Offset: 0x0048F930
	protected override UniTask OnBeforeStartAsync()
	{
		PersonalEditView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PersonalEditView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FA0C RID: 64012 RVA: 0x00491773 File Offset: 0x0048F973
	protected override void OnStart()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView == null)
		{
			return;
		}
		childPopView.PopItem.OverrideBackBtnCallBack(new Action(this.OnClose));
	}

	// Token: 0x0600FA0D RID: 64013 RVA: 0x00491796 File Offset: 0x0048F996
	public void TabItemToggleClick(int gridIndex, EPersonalEditDefine personalEditType)
	{
		this.TabLayout.SelectGridProxy(gridIndex, false);
		this.ShowContent(personalEditType).Forget();
	}

	// Token: 0x0600FA0E RID: 64014 RVA: 0x004917B4 File Offset: 0x0048F9B4
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

	// Token: 0x0600FA0F RID: 64015 RVA: 0x00491800 File Offset: 0x0048FA00
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

	// Token: 0x0600FA10 RID: 64016 RVA: 0x00491871 File Offset: 0x0048FA71
	public void OnClickedConfirm()
	{
	}

	// Token: 0x0600FA11 RID: 64017 RVA: 0x00491874 File Offset: 0x0048FA74
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

	// Token: 0x0600FA12 RID: 64018 RVA: 0x004918CC File Offset: 0x0048FACC
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

	// Token: 0x0600FA13 RID: 64019 RVA: 0x00491934 File Offset: 0x0048FB34
	private void OnClose()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.PersonalOptionView))
		{
			UiManager.Instance.CloseView(EUiViewName.PersonalOptionView, null);
		}
		UiManager.Instance.CloseView(EUiViewName.PersonalEditView, null);
	}

	// Token: 0x04008BE7 RID: 35815
	private EPersonalEditDefine EditType;

	// Token: 0x04008BE8 RID: 35816
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PersonalEditTabItem, EPersonalEditDefine> TabLayout;

	// Token: 0x04008BE9 RID: 35817
	private PersonalCardComponent PersonalCardComponent;

	// Token: 0x04008BEA RID: 35818
	private PersonalHeadPhotoComponent PersonalHeadPhotoComponent;

	// Token: 0x04008BEB RID: 35819
	private PersonalPlayerTitleComponent PersonalTitleComponent;

	// Token: 0x04008BEC RID: 35820
	private PersonalInfoData PersonalInfoData;

	// Token: 0x04008BED RID: 35821
	private ButtonItem ConfirmBtn;
}
