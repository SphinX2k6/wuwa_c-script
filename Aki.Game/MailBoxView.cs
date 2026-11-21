using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Mail;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020016B4 RID: 5812
[NullableContext(1)]
[Nullable(0)]
public class MailBoxView : UiViewBase
{
	// Token: 0x0600E21E RID: 57886 RVA: 0x00424901 File Offset: 0x00422B01
	public MailBoxView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E21F RID: 57887 RVA: 0x00424914 File Offset: 0x00422B14
	protected unsafe override void OnRegisterComponent()
	{
		int num = 23;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIDynScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x0600E220 RID: 57888 RVA: 0x00424C4C File Offset: 0x00422E4C
	protected override UniTask OnBeforeStartAsync()
	{
		MailBoxView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MailBoxView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E221 RID: 57889 RVA: 0x00424C90 File Offset: 0x00422E90
	protected override void OnStart()
	{
		this.InitCaptionUiStyle();
		this.InitLinkButtonObj();
		this.InitFavoriteToggle();
		this.InitAttachmentList();
		this.InitDropDownList();
		this.InitMailOpButtonObj();
		this.DeleteAllReadButton = new ButtonAndTextItem(base.GetItem(5));
		this.DeleteAllReadButton.BindCallback(new Action(this.DeleteAllExhaustedMail));
		this.DeleteAllReadButton.RefreshText("DeleteReadedMail", Array.Empty<object>());
		this.ReceiveAllRewardButton = new ButtonAndTextItem(base.GetItem(4));
		this.ReceiveAllRewardButton.BindCallback(new Action(this.PickAllAccessibleAttachment));
		this.ReceiveAllRewardButton.RefreshText("GetAllItem", Array.Empty<object>());
		this.MailSwitchSequence = new LevelSequencePlayer(this.RootItem);
		Log.Instance.Info(ELogModule.Mail, ELogAuthor.YZY, "邮件界面：OnStartFinish", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600E222 RID: 57890 RVA: 0x00424D6C File Offset: 0x00422F6C
	protected override void OnBeforeShow()
	{
		this.RefreshInsufficientSpaceTip();
		MailModel.Instance.ReloadMailList();
		EMailFilter[] filterTypeList = MailConfig.Instance.GetFilterTypeList();
		int defaultIndex = Math.Max(0, Array.IndexOf<EMailFilter>(filterTypeList, this.CurrentFilterState));
		if (this.CurrentMailDataList != null && this.SelectedMailData != null)
		{
			this.DropDownList.RefreshAllDropDownItem();
			MailDropDownItem mailDropDownItem = this.DropDownList.GetDropDownItemObject(this.DropDownList.GetSelectedIndex()) as MailDropDownItem;
			string selectedMailId = this.SelectedMailData.Id;
			this.CurrentMailDataList = new List<MailData>(mailDropDownItem.GetFilteredMailList());
			int num = this.CurrentMailDataList.FindIndex((MailData mail) => mail.Id == selectedMailId);
			num = ((num >= 0) ? num : 0);
			this.RefreshMailScrollList(this.CurrentMailDataList, num);
			return;
		}
		this.DropDownList.InitScroll(filterTypeList, new Func<EMailFilter, MailFilter>(this.GetMailFilterConfigData), defaultIndex, true);
	}

	// Token: 0x0600E223 RID: 57891 RVA: 0x00424E5C File Offset: 0x0042305C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string, int>(EEventName.SelectedMail, new Action<string, int>(this.CallBackSelected));
		EventSystem.Instance.Add<EMailAttachmentPickType>(EEventName.PickingAttachment, new Action<EMailAttachmentPickType>(this.CallBackPickMailView));
		EventSystem.Instance.Add<string, bool>(EEventName.MailFavoriteChanged, new Action<string, bool>(this.CallBackMailFavoriteChanged));
		EventSystem.Instance.Add<IReadOnlyList<string>>(EEventName.DeletingMail, new Action<IReadOnlyList<string>>(this.CallBackDeleteMailView));
		EventSystem.Instance.Add(EEventName.DeletingMailPassively, new Action(this.CallBackPassivelyDeleteMailView));
		EventSystem.Instance.Add(EEventName.AddingNewMail, new Action(this.CallBackAddMailView));
	}

	// Token: 0x0600E224 RID: 57892 RVA: 0x00424F14 File Offset: 0x00423114
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.SelectedMail, new Action<string, int>(this.CallBackSelected));
		EventSystem.Instance.Remove(EEventName.PickingAttachment, new Action<EMailAttachmentPickType>(this.CallBackPickMailView));
		EventSystem.Instance.Remove(EEventName.MailFavoriteChanged, new Action<string, bool>(this.CallBackMailFavoriteChanged));
		EventSystem.Instance.Remove(EEventName.DeletingMail, new Action<IReadOnlyList<string>>(this.CallBackDeleteMailView));
		EventSystem.Instance.Remove(EEventName.DeletingMailPassively, new Action(this.CallBackPassivelyDeleteMailView));
		EventSystem.Instance.Remove(EEventName.AddingNewMail, new Action(this.CallBackAddMailView));
	}

	// Token: 0x0600E225 RID: 57893 RVA: 0x00424FCC File Offset: 0x004231CC
	protected override void OnBeforeDestroy()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(22);
		if (extendToggle != null)
		{
			extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnFavoriteToggleStateChanged));
		}
		PopupCaptionItem caption = this.Caption;
		if (caption != null)
		{
			caption.Destroy(null);
		}
		CommonDropDown<MailFilter, EMailFilter> dropDownList = this.DropDownList;
		if (dropDownList != null)
		{
			dropDownList.Destroy(null);
		}
		MailLinkButton linkButton = this.LinkButton;
		if (linkButton != null)
		{
			linkButton.Destroy(null);
		}
		this.MailLoopScrollList.ClearChildren();
		this.MailSwitchSequence.Clear();
	}

	// Token: 0x0600E226 RID: 57894 RVA: 0x0042504C File Offset: 0x0042324C
	private void InitCaptionUiStyle()
	{
		this.Caption = new PopupCaptionItem(base.GetItem(0));
		this.Caption.SetHelpBtnActive(true);
		this.Caption.SetCloseBtnActive(true);
		this.Caption.SetCloseCallBack(new Action(this.OnClickClose));
		this.Caption.SetTitle(TextConfig.Instance.GetTextById("Mail") ?? "");
	}

	// Token: 0x0600E227 RID: 57895 RVA: 0x004250BD File Offset: 0x004232BD
	private void InitDropDownList()
	{
		this.DropDownList.SetOnSelectCall(new Action<int, EMailFilter>(this.OnSelectDropItem));
	}

	// Token: 0x0600E228 RID: 57896 RVA: 0x004250D8 File Offset: 0x004232D8
	private UniTask InitMailScrollView()
	{
		MailBoxView.<InitMailScrollView>d__28 <InitMailScrollView>d__;
		<InitMailScrollView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitMailScrollView>d__.<>4__this = this;
		<InitMailScrollView>d__.<>1__state = -1;
		<InitMailScrollView>d__.<>t__builder.Start<MailBoxView.<InitMailScrollView>d__28>(ref <InitMailScrollView>d__);
		return <InitMailScrollView>d__.<>t__builder.Task;
	}

	// Token: 0x0600E229 RID: 57897 RVA: 0x0042511B File Offset: 0x0042331B
	private MailScrollItemNew OnItemCreate(MailData data, UUIItem uiItem, int index)
	{
		MailScrollItemNew mailScrollItemNew = new MailScrollItemNew();
		mailScrollItemNew.BindSelectCall(new Action<int, MailData>(this.OnSelectMailItem));
		mailScrollItemNew.BindGetSelectedIndexFunction(new Func<int>(this.GetSelectedIndex));
		mailScrollItemNew.BindFavoriteClickCall(new Action<int, MailData>(this.OnListMailFavoriteClick));
		return mailScrollItemNew;
	}

	// Token: 0x0600E22A RID: 57898 RVA: 0x00425158 File Offset: 0x00423358
	private void InitLinkButtonObj()
	{
		this.LinkButton = new MailLinkButton(base.GetItem(14));
		this.LinkButton.ClickDelegate = new Action(this.OnClickLink);
		base.GetItem(14).SetUIActive(false);
	}

	// Token: 0x0600E22B RID: 57899 RVA: 0x00425194 File Offset: 0x00423394
	private void InitFavoriteToggle()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(22);
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		UUIItem uuiitem = extendToggle.RootUIComp.Get();
		if (uuiitem != null)
		{
			uuiitem.SetUIActive(false);
		}
		extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnFavoriteToggleStateChanged));
	}

	// Token: 0x0600E22C RID: 57900 RVA: 0x004251E4 File Offset: 0x004233E4
	private void RefreshFavoriteToggle(MailData mailData)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(22);
		bool flag = mailData.CanShowFavoriteControl();
		UUIItem uuiitem = extendToggle.RootUIComp.Get();
		if (uuiitem != null)
		{
			uuiitem.SetUIActive(flag);
		}
		if (flag)
		{
			extendToggle.SetToggleState(mailData.IsFavorite ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x0600E22D RID: 57901 RVA: 0x00425234 File Offset: 0x00423434
	private void RefreshInsufficientSpaceTip()
	{
		bool flag = this.CurrentFilterState == EMailFilter.FilterAll && MailModel.Instance.IsMailSpaceNearFull();
		base.GetItem(23).SetUIActive(flag);
		if (flag)
		{
			UUIText insufficientTipText = this.GetInsufficientTipText();
			LguiUtil.Instance.SetLocalTextNew(insufficientTipText, "Text_MailMaxTips_Text", Array.Empty<object>());
		}
	}

	// Token: 0x0600E22E RID: 57902 RVA: 0x00425288 File Offset: 0x00423488
	private UUIText GetInsufficientTipText()
	{
		if (this.InsufficientTipText != null)
		{
			return this.InsufficientTipText;
		}
		UUIItem item = base.GetItem(23);
		if (item == null)
		{
			return null;
		}
		AActor owner = item.GetOwner();
		UUIText uuitext = ((owner != null) ? owner.GetComponentByClass(UUIText.StaticClass()) : null) as UUIText;
		if (uuitext != null)
		{
			this.InsufficientTipText = uuitext;
			return uuitext;
		}
		int num = item.GetAttachUIChildren().Num();
		for (int i = 0; i < num; i++)
		{
			UUIItem attachUIChild = item.GetAttachUIChild(i);
			object obj;
			if (attachUIChild == null)
			{
				obj = null;
			}
			else
			{
				AActor owner2 = attachUIChild.GetOwner();
				obj = ((owner2 != null) ? owner2.GetComponentByClass(UUIText.StaticClass()) : null);
			}
			UUIText uuitext2 = obj as UUIText;
			if (uuitext2 != null)
			{
				this.InsufficientTipText = uuitext2;
				return uuitext2;
			}
		}
		return null;
	}

	// Token: 0x0600E22F RID: 57903 RVA: 0x00425338 File Offset: 0x00423538
	private void RefreshEmptyTipText()
	{
		UUIText emptyTipText = this.GetEmptyTipText();
		if (emptyTipText == null)
		{
			return;
		}
		string textStringId = (this.CurrentFilterState == EMailFilter.FilterFavorite) ? "Text_NoCollectedMail_Text" : "Text_NoMail_Text";
		LguiUtil.Instance.SetLocalTextNew(emptyTipText, textStringId, Array.Empty<object>());
	}

	// Token: 0x0600E230 RID: 57904 RVA: 0x00425378 File Offset: 0x00423578
	private UUIText GetEmptyTipText()
	{
		if (this.EmptyTipText != null)
		{
			return this.EmptyTipText;
		}
		UUIItem item = base.GetItem(21);
		if (item == null)
		{
			return null;
		}
		AActor owner = item.GetOwner();
		UUIText uuitext = ((owner != null) ? owner.GetComponentByClass(UUIText.StaticClass()) : null) as UUIText;
		if (uuitext != null)
		{
			this.EmptyTipText = uuitext;
			return uuitext;
		}
		int num = item.GetAttachUIChildren().Num();
		for (int i = 0; i < num; i++)
		{
			UUIItem attachUIChild = item.GetAttachUIChild(i);
			object obj;
			if (attachUIChild == null)
			{
				obj = null;
			}
			else
			{
				AActor owner2 = attachUIChild.GetOwner();
				obj = ((owner2 != null) ? owner2.GetComponentByClass(UUIText.StaticClass()) : null);
			}
			UUIText uuitext2 = obj as UUIText;
			if (uuitext2 != null)
			{
				this.EmptyTipText = uuitext2;
				return uuitext2;
			}
		}
		return null;
	}

	// Token: 0x0600E231 RID: 57905 RVA: 0x00425428 File Offset: 0x00423628
	private void RequestMailFavoriteForMail(MailData mail, bool isFavorite, Action onFailed = null)
	{
		if (isFavorite && !mail.IsFavorite && MailModel.Instance.IsFavoriteMailFull())
		{
			MailController.ShowMailFloatTipsByTextKey("Text_CollectedMailMaxTips_Text");
			Action onFailed2 = onFailed;
			if (onFailed2 == null)
			{
				return;
			}
			onFailed2();
			return;
		}
		else
		{
			if (!isFavorite && mail.NeedExpiredUnfavoriteConfirm())
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ExpiredFavoriteMailUnfavoriteConfirm);
				confirmBoxDataNew.FunctionMap[1] = delegate()
				{
					Action onFailed3 = onFailed;
					if (onFailed3 == null)
					{
						return;
					}
					onFailed3();
				};
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					MailController.RequestMailFavorite(mail.Id, false, onFailed, null);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			MailController.RequestMailFavorite(mail.Id, isFavorite, onFailed, null);
			return;
		}
	}

	// Token: 0x0600E232 RID: 57906 RVA: 0x004254F0 File Offset: 0x004236F0
	private void OnFavoriteToggleStateChanged(EToggleState state)
	{
		if (this.SelectedMailData == null)
		{
			return;
		}
		bool flag = state == EToggleState.ETT_Checked;
		EToggleState rollbackState = flag ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		this.RequestMailFavoriteForMail(this.SelectedMailData, flag, delegate
		{
			this.GetExtendToggle(22).SetToggleState(rollbackState, false, false, false);
		});
	}

	// Token: 0x0600E233 RID: 57907 RVA: 0x00425540 File Offset: 0x00423740
	private void OnListMailFavoriteClick(int index, MailData data)
	{
		bool isFavorite = !data.IsFavorite;
		this.RequestMailFavoriteForMail(data, isFavorite, delegate
		{
			MailData mailInstanceById = MailModel.Instance.GetMailInstanceById(data.Id);
			if (mailInstanceById != null)
			{
				MailScrollItemNew scrollItemFromIndex = this.MailLoopScrollList.GetScrollItemFromIndex(index);
				if (scrollItemFromIndex == null)
				{
					return;
				}
				scrollItemFromIndex.Update(mailInstanceById, index);
			}
		});
	}

	// Token: 0x0600E234 RID: 57908 RVA: 0x00425590 File Offset: 0x00423790
	private void CallBackMailFavoriteChanged(string mailId, bool isFavorite)
	{
		this.DropDownList.RefreshAllDropDownItem();
		MailData mailInstanceById = MailModel.Instance.GetMailInstanceById(mailId);
		if (mailInstanceById == null || this.CurrentMailDataList == null)
		{
			return;
		}
		if (this.CurrentFilterState == EMailFilter.FilterFavorite && !isFavorite)
		{
			MailDropDownItem dropDownItem = this.DropDownList.GetDropDownItemObject(this.DropDownList.GetSelectedIndex()) as MailDropDownItem;
			this.ReloadDisplayMailDataList(dropDownItem, 0);
			int num = Math.Min(this.SelectedMailIndex, Math.Max(0, this.CurrentMailDataList.Count - 1));
			this.RefreshMailScrollList(this.CurrentMailDataList, num);
			this.SelectedMailData = ((num >= 0 && num < this.CurrentMailDataList.Count) ? this.CurrentMailDataList[num] : null);
			if (this.SelectedMailData != null)
			{
				this.OnSelectMailItem(num, this.SelectedMailData);
			}
			return;
		}
		int num2 = this.CurrentMailDataList.FindIndex((MailData mail) => mail.Id == mailId);
		if (num2 >= 0)
		{
			this.CurrentMailDataList[num2] = mailInstanceById;
			MailScrollItemNew scrollItemFromIndex = this.MailLoopScrollList.GetScrollItemFromIndex(num2);
			if (scrollItemFromIndex != null)
			{
				scrollItemFromIndex.Update(mailInstanceById, num2);
			}
		}
		MailData selectedMailData = this.SelectedMailData;
		if (((selectedMailData != null) ? selectedMailData.Id : null) == mailId)
		{
			this.SelectedMailData = mailInstanceById;
			this.RefreshMailValidTime(mailInstanceById);
			this.RefreshFavoriteToggle(mailInstanceById);
			this.RefreshMailOpButtonState(mailInstanceById);
		}
	}

	// Token: 0x0600E235 RID: 57909 RVA: 0x004256F4 File Offset: 0x004238F4
	private void InitMailOpButtonObj()
	{
		this.MailOpButton = new ButtonAndTextItem(base.GetItem(18));
		this.MailOpButton.BindCallback(new Action(this.OnClickMailOp));
	}

	// Token: 0x0600E236 RID: 57910 RVA: 0x00425720 File Offset: 0x00423920
	private void InitAttachmentList()
	{
		this.AttachmentsLayout = new LoopScrollView<CSharpScript.Game.Module.Mail.RewardItem, TItem>(base.GetLoopScrollViewComponent(16), base.GetItem(17).GetOwner() as AUIBaseActor, new Func<CSharpScript.Game.Module.Mail.RewardItem>(this.CreateAttachItem), false);
	}

	// Token: 0x0600E237 RID: 57911 RVA: 0x00425754 File Offset: 0x00423954
	private CSharpScript.Game.Module.Mail.RewardItem CreateAttachItem()
	{
		return new CSharpScript.Game.Module.Mail.RewardItem
		{
			Onwner = this
		};
	}

	// Token: 0x0600E238 RID: 57912 RVA: 0x00425764 File Offset: 0x00423964
	private MailDropDownItem CreateDropDownItemFunc(UUIItem uiItem, EMailFilter type)
	{
		MailDropDownItem result;
		switch (type)
		{
		case EMailFilter.FilterAll:
			result = new MailTotalDropDownItem(uiItem);
			break;
		case EMailFilter.FilterImportant:
			result = new MailImportantDropDownItem(uiItem);
			break;
		case EMailFilter.FilterUnScanned:
			result = new MailUnReadDropDownItem(uiItem);
			break;
		case EMailFilter.FilterFavorite:
			result = new MailFavoriteDropDownItem(uiItem);
			break;
		default:
			result = new MailTotalDropDownItem(uiItem);
			break;
		}
		return result;
	}

	// Token: 0x0600E239 RID: 57913 RVA: 0x004257BC File Offset: 0x004239BC
	private List<string> GetBatchDeletableMailIds()
	{
		List<MailData> currentMailDataList = this.CurrentMailDataList;
		List<string> list = new List<string>();
		if (this.CurrentFilterState == EMailFilter.FilterImportant)
		{
			using (List<MailData>.Enumerator enumerator = currentMailDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					MailData mailData = enumerator.Current;
					if (mailData.GetWasScanned() && !mailData.IsFavorite && mailData.GetAttachmentStatus() != EMailAttachment.AttachmentRemained)
					{
						list.Add(mailData.Id);
					}
				}
				return list;
			}
		}
		foreach (MailData mailData2 in currentMailDataList)
		{
			if (mailData2.GetWasScanned() && !mailData2.IsFavorite && mailData2.GetMailLevel() != 2 && mailData2.GetAttachmentStatus() != EMailAttachment.AttachmentRemained)
			{
				list.Add(mailData2.Id);
			}
		}
		return list;
	}

	// Token: 0x0600E23A RID: 57914 RVA: 0x004258AC File Offset: 0x00423AAC
	private void DeleteAllExhaustedMail()
	{
		if (this.CurrentFilterState == EMailFilter.FilterFavorite)
		{
			MailController.ShowMailFloatTipsByTextKey("Text_NoDeletedMailsTips_Text");
			return;
		}
		List<string> deletingMailIds = this.GetBatchDeletableMailIds();
		if (deletingMailIds.Count <= 0)
		{
			MailController.ShowMailFloatTipsByTextKey("Text_NoDeletedMailsTips_Text");
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ScannedMailsBeingDeleted);
		Action value = delegate()
		{
			MailController.RequestDeleteMail(deletingMailIds);
		};
		confirmBoxDataNew.FunctionMap[2] = value;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600E23B RID: 57915 RVA: 0x00425928 File Offset: 0x00423B28
	private void PickAllAccessibleAttachment()
	{
		Log.Instance.Info(ELogModule.Mail, ELogAuthor.YZY, "邮件界面：一键领取", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.CurrentFilterState == EMailFilter.FilterFavorite)
		{
			List<string> list = new List<string>();
			foreach (MailData mailData in this.CurrentMailDataList)
			{
				if (mailData.GetAttachmentStatus() == EMailAttachment.AttachmentRemained)
				{
					list.Add(mailData.Id);
				}
			}
			if (list.Count > 0)
			{
				MailController.RequestPickAttachment(list, EMailAttachmentPickType.PickAll);
				return;
			}
			MailController.ShowMailFloatTipsByTextKey("Text_NoRewardMailsTips_Text");
			return;
		}
		else
		{
			List<MailData> mailList = MailModel.Instance.GetMailList();
			List<string> list2 = new List<string>();
			int num = (this.CurrentFilterState == EMailFilter.FilterImportant) ? 2 : 1;
			foreach (MailData mailData2 in mailList)
			{
				if (mailData2.GetAttachmentStatus() == EMailAttachment.AttachmentRemained && mailData2.Level >= num)
				{
					list2.Add(mailData2.Id);
				}
			}
			if (list2.Count > 0)
			{
				MailController.RequestPickAttachment(list2, EMailAttachmentPickType.PickAll);
				return;
			}
			EMailFilter currentFilterState = this.CurrentFilterState;
			if (currentFilterState == EMailFilter.FilterAll)
			{
				GenericPromptController.Instance.ShowPromptByCode("MailClearAllAttachment", Array.Empty<object>());
				return;
			}
			if (currentFilterState != EMailFilter.FilterImportant)
			{
				return;
			}
			GenericPromptController.Instance.ShowPromptByCode("MailClearImportantAttachment", Array.Empty<object>());
			return;
		}
	}

	// Token: 0x0600E23C RID: 57916 RVA: 0x00425A98 File Offset: 0x00423C98
	private void ClearMailSelection()
	{
		MailScrollItemNew scrollItemFromIndex = this.MailLoopScrollList.GetScrollItemFromIndex(this.SelectedMailIndex);
		if (scrollItemFromIndex != null)
		{
			scrollItemFromIndex.OnDeselected(true);
		}
		this.SelectedMailIndex = -1;
	}

	// Token: 0x0600E23D RID: 57917 RVA: 0x00425AC0 File Offset: 0x00423CC0
	private unsafe void RefreshMailScrollList(List<MailData> mailList, int selectedIndex = 0)
	{
		this.ClearMailSelection();
		this.SelectedMailIndex = selectedIndex;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件界面：刷新列表 RefreshMailScrollList";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("selectedIndex", selectedIndex);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("mailList长度", (mailList != null) ? new int?(mailList.Count) : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.MailLoopScrollList.RefreshByData(mailList.ToArray(), false, false);
		if (mailList.Count > 0)
		{
			base.GetItem(20).SetUIActive(true);
			base.GetItem(21).SetUIActive(false);
			this.ReceiveAllRewardButton.SetActive(true);
			this.DeleteAllReadButton.SetActive(this.CurrentFilterState == EMailFilter.FilterAll || this.CurrentFilterState == EMailFilter.FilterFavorite);
			this.ScrollToItemThenRefreshItem(mailList[selectedIndex], selectedIndex);
		}
		else
		{
			base.GetItem(20).SetUIActive(false);
			base.GetItem(21).SetUIActive(true);
			this.RefreshEmptyTipText();
			this.ReceiveAllRewardButton.SetActive(false);
			this.DeleteAllReadButton.SetActive(false);
			this.SelectedMailIndex = 0;
		}
		this.RefreshInsufficientSpaceTip();
	}

	// Token: 0x0600E23E RID: 57918 RVA: 0x00425C0C File Offset: 0x00423E0C
	private UniTask ScrollToItemThenRefreshItem(MailData data, int selectedIndex)
	{
		MailBoxView.<ScrollToItemThenRefreshItem>d__50 <ScrollToItemThenRefreshItem>d__;
		<ScrollToItemThenRefreshItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ScrollToItemThenRefreshItem>d__.<>4__this = this;
		<ScrollToItemThenRefreshItem>d__.data = data;
		<ScrollToItemThenRefreshItem>d__.selectedIndex = selectedIndex;
		<ScrollToItemThenRefreshItem>d__.<>1__state = -1;
		<ScrollToItemThenRefreshItem>d__.<>t__builder.Start<MailBoxView.<ScrollToItemThenRefreshItem>d__50>(ref <ScrollToItemThenRefreshItem>d__);
		return <ScrollToItemThenRefreshItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600E23F RID: 57919 RVA: 0x00425C60 File Offset: 0x00423E60
	private void RefreshMailValidTime(MailData selectedMail)
	{
		if (selectedMail.IsFavorite)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "Text_LastingTimeCollectedMax_Text", Array.Empty<object>());
			return;
		}
		if (selectedMail.GetMailLevel() == 2)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(11), "ForeverValid", Array.Empty<object>());
			return;
		}
		long expiryTime = selectedMail.GetExpiryTime();
		double num = TimeUtil.Instance.CalculateHourGapBetweenNow((double)expiryTime, true);
		double num2 = TimeUtil.Instance.CalculateMinuteGapBetweenNow((double)expiryTime, true);
		if (num >= 24.0)
		{
			int num3 = TimeUtil.Instance.CalculateDayGapBetweenNow((double)expiryTime, true);
			LguiUtil.Instance.SetLocalText(base.GetText(11), "AfterDayAutoDelete", new <>z__ReadOnlySingleElementList<object>(num3.ToString("F0")));
			return;
		}
		if (num > 1.0)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(11), "AfterTimeAutoDelete", new <>z__ReadOnlySingleElementList<object>(num.ToString("F0")));
			return;
		}
		LguiUtil.Instance.SetLocalText(base.GetText(11), "AfterMinAutoDelete", new <>z__ReadOnlySingleElementList<object>(num2.ToString("F0")));
		if (num2 < 1.0)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(11), "AutoDeleteInOneMinute", Array.Empty<object>());
		}
	}

	// Token: 0x0600E240 RID: 57920 RVA: 0x00425DA4 File Offset: 0x00423FA4
	private void RefreshMailAttachment(MailData selectedMail)
	{
		List<TItem> list = new List<TItem>();
		foreach (PbMailAttachment pbMailAttachment in selectedMail.GetAttachmentInfo())
		{
			InventoryDefine.IGetItemData itemData = new InventoryDefine.GetItemData(pbMailAttachment.Id, 0);
			list.Add(new TItem(itemData, pbMailAttachment.Count));
		}
		this.AttachmentsLayout.ReloadData(list, false);
		base.GetItem(15).SetUIActive(list.Count > 0);
	}

	// Token: 0x0600E241 RID: 57921 RVA: 0x00425E14 File Offset: 0x00424014
	private void RefreshMailOpButtonState(MailData data)
	{
		if (data.GetAttachmentStatus() == EMailAttachment.AttachmentRemained)
		{
			this.MailOpButton.RefreshText("GetText", Array.Empty<object>());
			this.MailOpButton.RefreshEnable(true);
			return;
		}
		this.MailOpButton.RefreshText("DeleteText", Array.Empty<object>());
		this.MailOpButton.RefreshEnable(true);
	}

	// Token: 0x0600E242 RID: 57922 RVA: 0x00425E70 File Offset: 0x00424070
	private void RefreshMailContentView(MailData data)
	{
		base.GetText(7).SetText(data.Title, true);
		base.GetText(13).SetText(data.GetText(), true);
		base.GetText(13).bBestFit = false;
		base.GetText(8).SetText(data.Sender, true);
		base.GetText(9).SetText(TimeUtil.Instance.DateFormatString((double)data.Time), true);
		bool flag = data.GetSubContentJumpId() > 0 || !StringUtils.IsEmpty(data.GetSubUrl()) || data.IsQuestionMail();
		base.GetItem(14).SetUIActive(flag);
		if (flag)
		{
			string linkButtonTitle = data.GetLinkButtonTitle();
			MailTo? mailToConfigById = MailConfig.Instance.GetMailToConfigById(data.GetSubContentJumpId());
			if (!StringUtils.IsEmpty(linkButtonTitle))
			{
				this.LinkButton.SetTitle(linkButtonTitle);
			}
			else if (mailToConfigById != null)
			{
				this.LinkButton.SetTitleByTextKey(mailToConfigById.Value.Description);
			}
			string subTextColor = data.GetSubTextColor();
			if (!StringUtils.IsEmpty(subTextColor))
			{
				this.LinkButton.SetColor(subTextColor);
			}
			this.LinkButton.SetJumpIcon(data.GetSubContentJumpId());
		}
		this.RefreshMailValidTime(data);
		this.RefreshMailAttachment(data);
		this.RefreshMailOpButtonState(data);
		this.RefreshFavoriteToggle(data);
		base.GetItem(6).SetUIActive(data.GetMailLevel() == 2);
		this.MailSwitchSequence.StopSequenceByKey("Switch", false, true);
		this.MailSwitchSequence.PlayLevelSequenceByName("Switch", false, null, false);
	}

	// Token: 0x0600E243 RID: 57923 RVA: 0x00425FF2 File Offset: 0x004241F2
	private MailDropDownTitle CreateDropTitle(UUIItem uiItem)
	{
		return new MailDropDownTitle(uiItem);
	}

	// Token: 0x0600E244 RID: 57924 RVA: 0x00425FFA File Offset: 0x004241FA
	private MailFilter GetMailFilterConfigData(EMailFilter type)
	{
		return MailModel.Instance.GetMailFilterConfigData(type);
	}

	// Token: 0x0600E245 RID: 57925 RVA: 0x00426008 File Offset: 0x00424208
	private void CallBackSelected(string mailId, int configId)
	{
		int index = this.CurrentMailDataList.FindIndex((MailData value) => value.Id == mailId);
		this.MailLoopScrollList.GetScrollItemFromIndex(index).Update(this.CurrentMailDataList[index], index);
		MailModel.Instance.SetCurrentSelectMailId(mailId);
		if (this.SelectedMailData != null)
		{
			this.RefreshMailValidTime(this.SelectedMailData);
			this.RefreshFavoriteToggle(this.SelectedMailData);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件界面：选择邮件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mailId", mailId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600E246 RID: 57926 RVA: 0x004260B4 File Offset: 0x004242B4
	private void ReloadDisplayMailDataList(MailDropDownItem dropDownItem, int defaultSelectedIndex = 0)
	{
		this.CurrentMailDataList = new List<MailData>(dropDownItem.GetFilteredMailList());
		this.SelectedMailIndex = this.CurrentMailDataList.FindIndex(delegate(MailData value)
		{
			string id = value.Id;
			MailData selectedMailData = this.SelectedMailData;
			return id == ((selectedMailData != null) ? selectedMailData.Id : null);
		});
		this.SelectedMailIndex = ((this.SelectedMailIndex == -1) ? defaultSelectedIndex : this.SelectedMailIndex);
		this.SelectedMailIndex = MathUtils.Instance.Clamp(this.SelectedMailIndex, 0, Math.Max(0, this.CurrentMailDataList.Count - 1));
	}

	// Token: 0x0600E247 RID: 57927 RVA: 0x00426134 File Offset: 0x00424334
	private void CallBackPickMailView(EMailAttachmentPickType pickType)
	{
		Log.Instance.Info(ELogModule.Mail, ELogAuthor.YZY, "邮件界面：CallBackPickMailView领取附件", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.SelectedMailData == null)
		{
			return;
		}
		if (pickType == EMailAttachmentPickType.PickAll && this.CurrentMailDataList != null)
		{
			for (int i = 0; i < this.CurrentMailDataList.Count; i++)
			{
				MailData mailInstanceById = MailModel.Instance.GetMailInstanceById(this.CurrentMailDataList[i].Id);
				this.CurrentMailDataList[i] = mailInstanceById;
				MailScrollItemNew scrollItemFromIndex = this.MailLoopScrollList.GetScrollItemFromIndex(i);
				if (scrollItemFromIndex != null)
				{
					scrollItemFromIndex.Update(mailInstanceById, i);
				}
			}
		}
		else
		{
			int selectedMailIndex = this.SelectedMailIndex;
			MailData mailInstanceById2 = MailModel.Instance.GetMailInstanceById(this.SelectedMailData.Id);
			if (this.CurrentMailDataList != null && selectedMailIndex >= 0 && selectedMailIndex < this.CurrentMailDataList.Count)
			{
				this.CurrentMailDataList[selectedMailIndex] = mailInstanceById2;
			}
			MailScrollItemNew scrollItemFromIndex2 = this.MailLoopScrollList.GetScrollItemFromIndex(selectedMailIndex);
			if (scrollItemFromIndex2 != null)
			{
				scrollItemFromIndex2.Update(mailInstanceById2, selectedMailIndex);
			}
		}
		this.SelectedMailData = (MailModel.Instance.GetMailInstanceById(this.SelectedMailData.Id) ?? this.SelectedMailData);
		this.RefreshMailContentView(this.SelectedMailData);
		Log.Instance.Info(ELogModule.Mail, ELogAuthor.YZY, "邮件界面：CallBackPickMailView领取附件Finish", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600E248 RID: 57928 RVA: 0x0042627C File Offset: 0x0042447C
	private void CallBackDeleteMailView(IReadOnlyList<string> deletedMails)
	{
		Log.Instance.Info(ELogModule.Mail, ELogAuthor.YZY, "邮件界面：CallBackDeleteMailView删除邮件", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.SelectedMailData == null)
		{
			Log.Instance.Info(ELogModule.Mail, ELogAuthor.YZY, "邮件界面：CallBackDeleteMailView没有选择邮件,没有选择邮件的时候但是却删除了邮件", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.DropDownList.RefreshAllDropDownItem();
		MailDropDownItem mailDropDownItem = this.DropDownList.GetDropDownItemObject(this.DropDownList.GetSelectedIndex()) as MailDropDownItem;
		if (mailDropDownItem == null)
		{
			return;
		}
		int defaultSelectedIndex = (deletedMails.Count > 1) ? 0 : this.SelectedMailIndex;
		this.ReloadDisplayMailDataList(mailDropDownItem, defaultSelectedIndex);
		this.RefreshMailScrollList(this.CurrentMailDataList, this.SelectedMailIndex);
		this.SelectedMailData = ((this.SelectedMailIndex >= 0 && this.SelectedMailIndex < this.CurrentMailDataList.Count) ? this.CurrentMailDataList[this.SelectedMailIndex] : null);
		if (this.SelectedMailData != null)
		{
			this.OnSelectMailItem(this.SelectedMailIndex, this.SelectedMailData);
		}
		Log.Instance.Info(ELogModule.Mail, ELogAuthor.YZY, "邮件界面：CallBackDeleteMailView删除邮件结束", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600E249 RID: 57929 RVA: 0x00426390 File Offset: 0x00424590
	private void CallBackPassivelyDeleteMailView()
	{
		Log.Instance.Info(ELogModule.Mail, ELogAuthor.YZY, "邮件界面：CallBackPassivelyDeleteMailView被动删除邮件", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.SelectedMailData == null)
		{
			Log.Instance.Info(ELogModule.Mail, ELogAuthor.YZY, "邮件界面：CallBackPassivelyDeleteMailView没有选择邮件", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.DropDownList.RefreshAllDropDownItem();
		MailDropDownItem mailDropDownItem = this.DropDownList.GetDropDownItemObject(this.DropDownList.GetSelectedIndex()) as MailDropDownItem;
		if (mailDropDownItem == null)
		{
			return;
		}
		this.ReloadDisplayMailDataList(mailDropDownItem, 0);
		this.RefreshMailScrollList(this.CurrentMailDataList, this.SelectedMailIndex);
		this.SelectedMailData = ((this.SelectedMailIndex >= 0 && this.SelectedMailIndex < this.CurrentMailDataList.Count) ? this.CurrentMailDataList[this.SelectedMailIndex] : null);
		if (this.SelectedMailData != null)
		{
			this.OnSelectMailItem(this.SelectedMailIndex, this.SelectedMailData);
		}
		Log.Instance.Info(ELogModule.Mail, ELogAuthor.YZY, "邮件界面：CallBackPassivelyDeleteMailView被动删除邮件结束", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600E24A RID: 57930 RVA: 0x00426490 File Offset: 0x00424690
	private void CallBackAddMailView()
	{
		Log.Instance.Info(ELogModule.Mail, ELogAuthor.YZY, "邮件界面：CallBackAddMailView,添加新邮件", default(ReadOnlySpan<ValueTuple<string, object>>));
		MailDropDownItem mailDropDownItem = this.DropDownList.GetDropDownItemObject(this.DropDownList.GetSelectedIndex()) as MailDropDownItem;
		if (mailDropDownItem == null)
		{
			return;
		}
		this.DropDownList.RefreshAllDropDownItem();
		this.ReloadDisplayMailDataList(mailDropDownItem, 0);
		this.RefreshMailScrollList(this.CurrentMailDataList, this.SelectedMailIndex);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件界面：CallBackAddMailView,添加新邮件结束";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CurrentMailDataList", this.CurrentMailDataList);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600E24B RID: 57931 RVA: 0x0042652C File Offset: 0x0042472C
	private unsafe void OpenUrl(string link, string title = "", bool forceUseDefaultBrowser = false, bool ifLandscape = true)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件界面：OpenUrl";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("link", link);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("title", title);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("forceUseDefaultBrowser", forceUseDefaultBrowser);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ifLandscape", ifLandscape);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		if (forceUseDefaultBrowser)
		{
			string extendExternalUrl = PublicUtil.Instance.GetExtendExternalUrl(link, forceUseDefaultBrowser);
			MailModel.Instance.OpenWebBrowser(extendExternalUrl);
			return;
		}
		if (KuroSdkController.Instance.CanUseSdk())
		{
			string extendExternalUrl2 = PublicUtil.Instance.GetExtendExternalUrl(link, true);
			KuroSdkController.Instance.SdkOpenUrlWnd(title, extendExternalUrl2, ifLandscape, false, true);
			return;
		}
		string extendExternalUrl3 = PublicUtil.Instance.GetExtendExternalUrl(link, false);
		MailModel.Instance.OpenWebBrowser(extendExternalUrl3);
	}

	// Token: 0x0600E24C RID: 57932 RVA: 0x00426628 File Offset: 0x00424828
	private void OnClickLink()
	{
		MailController.RecordMailJumpLog(this.SelectedMailData);
		if (this.SelectedMailData.GetSubContentJumpId() > 0)
		{
			MailModel.Instance.SetCurrentSelectMailId(this.SelectedMailData.Id);
			MailController.OpenMailJumpView(this.SelectedMailData);
			return;
		}
		string title = (this.SelectedMailData.GetSubTitle() == null) ? "" : this.SelectedMailData.GetSubTitle();
		if (this.SelectedMailData.IsQuestionMail())
		{
			this.OpenUrl(this.SelectedMailData.GetQuestionUrl(), title, this.SelectedMailData.GetUseDefaultBrowser(), this.SelectedMailData.GetIfLandscape());
			return;
		}
		string subUrl = this.SelectedMailData.GetSubUrl();
		if (!StringUtils.IsEmpty(subUrl))
		{
			this.OpenUrl(subUrl, title, this.SelectedMailData.GetUseDefaultBrowser(), this.SelectedMailData.GetIfLandscape());
		}
	}

	// Token: 0x0600E24D RID: 57933 RVA: 0x004266F7 File Offset: 0x004248F7
	private void OnClickClose()
	{
		UiManager.Instance.CloseView(EUiViewName.MailBoxView, null);
	}

	// Token: 0x0600E24E RID: 57934 RVA: 0x0042670C File Offset: 0x0042490C
	private unsafe void OnSelectDropItem(int index, EMailFilter data)
	{
		this.CurrentFilterState = data;
		this.CurrentMailDataList = new List<MailData>((this.DropDownList.GetDropDownItemObject(index) as MailDropDownItem).GetFilteredMailList());
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件界面：选择下拉item OnSelectDropItem";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("index", index);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "this.CurrentMailDataList.length";
		List<MailData> currentMailDataList = this.CurrentMailDataList;
		ptr = new ValueTuple<string, object>(item, (currentMailDataList != null) ? new int?(currentMailDataList.Count) : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.SelectedMailIndex = 0;
		this.RefreshMailScrollList(this.CurrentMailDataList, 0);
	}

	// Token: 0x0600E24F RID: 57935 RVA: 0x004267D0 File Offset: 0x004249D0
	private int GetSelectedIndex()
	{
		return this.SelectedMailIndex;
	}

	// Token: 0x0600E250 RID: 57936 RVA: 0x004267D8 File Offset: 0x004249D8
	private void OnSelectMailItem(int index, MailData data)
	{
		if (index < 0 || index >= this.CurrentMailDataList.Count || data == null)
		{
			return;
		}
		MailScrollItemNew scrollItemFromIndex = this.MailLoopScrollList.GetScrollItemFromIndex(this.SelectedMailIndex);
		if (scrollItemFromIndex != null)
		{
			scrollItemFromIndex.OnDeselected(true);
		}
		this.SelectedMailData = data;
		this.SelectedMailIndex = index;
		this.RefreshMailContentView(data);
		MailController.SelectedMail(data);
		data.SetWasScanned(1);
	}

	// Token: 0x0600E251 RID: 57937 RVA: 0x0042683C File Offset: 0x00424A3C
	private void OnClickMailOp()
	{
		if (this.SelectedMailData == null)
		{
			return;
		}
		MailData mail = MailModel.Instance.GetMailInstanceById(this.SelectedMailData.Id) ?? this.SelectedMailData;
		if (mail.GetAttachmentStatus() == EMailAttachment.AttachmentRemained)
		{
			MailController.RequestPickAttachment(new List<string>
			{
				mail.Id
			}, EMailAttachmentPickType.PickOne);
			return;
		}
		if (!mail.IsFavorite)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.OneMailBeingDeleted);
			Action value = delegate()
			{
				MailController.RequestDeleteMail(new List<string>
				{
					mail.Id
				});
			};
			confirmBoxDataNew.FunctionMap[2] = value;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		if (mail.NeedExpiredUnfavoriteConfirm())
		{
			ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.ExpiredFavoriteMailUnfavoriteConfirm);
			confirmBoxDataNew2.FunctionMap[2] = delegate()
			{
				MailController.RequestMailFavorite(mail.Id, false, null, null);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew2);
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew3 = new ConfirmBoxDataNew(EConfirmBoxConfigId.FavoriteMailDeleteConfirm);
		confirmBoxDataNew3.FunctionMap[2] = delegate()
		{
			MailController.RequestDeleteFavoriteMail(mail.Id);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew3);
	}

	// Token: 0x04008150 RID: 33104
	private const int DEFAULT_MAIL_INDEX = 0;

	// Token: 0x04008151 RID: 33105
	private const int HOUR_PER_DAY = 24;

	// Token: 0x04008152 RID: 33106
	[Nullable(2)]
	public MailData SelectedMailData;

	// Token: 0x04008153 RID: 33107
	private int SelectedMailIndex;

	// Token: 0x04008154 RID: 33108
	private PopupCaptionItem Caption;

	// Token: 0x04008155 RID: 33109
	private CommonDropDown<MailFilter, EMailFilter> DropDownList;

	// Token: 0x04008156 RID: 33110
	private DynamicScrollView<MailScrollItemNew, MailDynamicScrollItemNew, MailData> MailLoopScrollList;

	// Token: 0x04008157 RID: 33111
	private MailLinkButton LinkButton;

	// Token: 0x04008158 RID: 33112
	private LoopScrollView<CSharpScript.Game.Module.Mail.RewardItem, TItem> AttachmentsLayout;

	// Token: 0x04008159 RID: 33113
	private List<MailData> CurrentMailDataList;

	// Token: 0x0400815A RID: 33114
	private EMailFilter CurrentFilterState = EMailFilter.FilterAll;

	// Token: 0x0400815B RID: 33115
	private ButtonAndTextItem MailOpButton;

	// Token: 0x0400815C RID: 33116
	private ButtonAndTextItem DeleteAllReadButton;

	// Token: 0x0400815D RID: 33117
	private ButtonAndTextItem ReceiveAllRewardButton;

	// Token: 0x0400815E RID: 33118
	private LevelSequencePlayer MailSwitchSequence;

	// Token: 0x0400815F RID: 33119
	private UUIText InsufficientTipText;

	// Token: 0x04008160 RID: 33120
	private UUIText EmptyTipText;

	// Token: 0x0200789A RID: 30874
	[NullableContext(0)]
	private class EMailComponents
	{
		// Token: 0x040271E9 RID: 160233
		public const int Caption = 0;

		// Token: 0x040271EA RID: 160234
		public const int Dropdown = 1;

		// Token: 0x040271EB RID: 160235
		public const int MailLoopScrollView = 2;

		// Token: 0x040271EC RID: 160236
		public const int MailScrollItem = 3;

		// Token: 0x040271ED RID: 160237
		public const int BtnReceive = 4;

		// Token: 0x040271EE RID: 160238
		public const int BtnDelete = 5;

		// Token: 0x040271EF RID: 160239
		public const int SprStar = 6;

		// Token: 0x040271F0 RID: 160240
		public const int TxtMainTitle = 7;

		// Token: 0x040271F1 RID: 160241
		public const int TxtMainPoster = 8;

		// Token: 0x040271F2 RID: 160242
		public const int TxtPostTime = 9;

		// Token: 0x040271F3 RID: 160243
		public const int PnlLimitTime = 10;

		// Token: 0x040271F4 RID: 160244
		public const int TxtLimitTime = 11;

		// Token: 0x040271F5 RID: 160245
		public const int Content1 = 12;

		// Token: 0x040271F6 RID: 160246
		public const int TxtMainContent = 13;

		// Token: 0x040271F7 RID: 160247
		public const int BtnPageLink = 14;

		// Token: 0x040271F8 RID: 160248
		public const int PnlReward = 15;

		// Token: 0x040271F9 RID: 160249
		public const int AttachItemList = 16;

		// Token: 0x040271FA RID: 160250
		public const int AttachItem = 17;

		// Token: 0x040271FB RID: 160251
		public const int BtnMailOp = 18;

		// Token: 0x040271FC RID: 160252
		public const int PnlLeft = 19;

		// Token: 0x040271FD RID: 160253
		public const int PnlRight = 20;

		// Token: 0x040271FE RID: 160254
		public const int PnlEmpty = 21;

		// Token: 0x040271FF RID: 160255
		public const int TogFavorite = 22;

		// Token: 0x04027200 RID: 160256
		public const int PnlInsufficient = 23;
	}
}
