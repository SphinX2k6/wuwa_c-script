using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018B5 RID: 6325
[NullableContext(1)]
[Nullable(0)]
public class PersonalCardView : UiViewBase
{
	// Token: 0x0600F9EC RID: 63980 RVA: 0x00490E2A File Offset: 0x0048F02A
	public PersonalCardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F9ED RID: 63981 RVA: 0x00490E34 File Offset: 0x0048F034
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIInteractionGroup))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(8, new Action(this.OnClickCardPreviewBtn))
		};
	}

	// Token: 0x0600F9EE RID: 63982 RVA: 0x00490F64 File Offset: 0x0048F164
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(7));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickCloseBtn));
		this.PersonalInfoData = (this.OpenParam as PersonalInfoData);
		if (this.PersonalInfoData == null)
		{
			Log.Instance.Error(ELogModule.Personal, ELogAuthor.BB, "PersonalCardView Invalid OpenParam", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.ConfirmBtn = new ButtonItem(base.GetButton(9).RootUIComp.Get());
		this.ScrollView = new LoopScrollView<PersonalCardBaseItem, PersonalCardData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<PersonalCardBaseItem>(this.CreateCardItem), false);
		PersonalCardData[] sortedList = this.GetSortedList();
		base.GetItem(6).SetUIActive(sortedList.Length != 0);
		this.ScrollView.RefreshByData(sortedList, false, null, false);
		if (sortedList.Length != 0)
		{
			this.ScrollView.SelectGridProxy(0, false);
			this.CurSelectCardData = sortedList[0];
			this.RefreshCardInfo(this.CurSelectCardData);
		}
		if (this.PersonalInfoData.IsOtherData)
		{
			this.ConfirmBtn.SetUiActive(false);
			return;
		}
		this.ConfirmBtn.SetUiActive(true);
		this.RefreshConfirmBtnByCurSelectData(this.CurSelectCardData);
		this.ConfirmBtn.SetFunction(new Action<int>(this.OnClickConfirm));
	}

	// Token: 0x0600F9EF RID: 63983 RVA: 0x004910B6 File Offset: 0x0048F2B6
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnCardChange, new Action(this.OnCardChange));
	}

	// Token: 0x0600F9F0 RID: 63984 RVA: 0x004910D4 File Offset: 0x0048F2D4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnCardChange, new Action(this.OnCardChange));
	}

	// Token: 0x0600F9F1 RID: 63985 RVA: 0x004910F4 File Offset: 0x0048F2F4
	private void OnCardChange()
	{
		PersonalCardData[] sortedList = this.GetSortedList();
		this.ScrollView.RefreshByData(sortedList, false, null, false);
		this.ScrollView.SelectGridProxy(0, false);
		this.ScrollView.ScrollToGridIndex(0, true);
		this.RefreshConfirmBtnByCurSelectData(this.CurSelectCardData);
		UiNavigationNewController.Instance.SetNavigationFocusForView(this.ScrollView.GetGridByDisplayIndex(0), true, false, false);
	}

	// Token: 0x0600F9F2 RID: 63986 RVA: 0x00491157 File Offset: 0x0048F357
	private void OnClickConfirm(int _)
	{
		PersonalController.Instance.SendChangeCardRequest(this.CurSelectCardData.CardId);
		UiManager.Instance.CloseView(EUiViewName.PersonalEditView, null);
		UiManager.Instance.CloseView(EUiViewName.PersonalOptionView, null);
	}

	// Token: 0x0600F9F3 RID: 63987 RVA: 0x0049118E File Offset: 0x0048F38E
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F9F4 RID: 63988 RVA: 0x00491197 File Offset: 0x0048F397
	private void OnClickCardPreviewBtn()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.CurSelectCardData.CardId, true, null, false);
	}

	// Token: 0x0600F9F5 RID: 63989 RVA: 0x004911B1 File Offset: 0x0048F3B1
	private PersonalCardItem CreateCardItem()
	{
		PersonalCardItem personalCardItem = new PersonalCardItem();
		personalCardItem.SetToggleCallBack(new Action<int, PersonalCardData>(this.OnCardItemToggleClick));
		personalCardItem.SetNeedShowRedDot(false);
		PersonalInfoData personalInfoData = this.PersonalInfoData;
		personalCardItem.SetIsOtherCardItem(personalInfoData != null && personalInfoData.IsOtherData);
		return personalCardItem;
	}

	// Token: 0x0600F9F6 RID: 63990 RVA: 0x004911EC File Offset: 0x0048F3EC
	private void OnCardItemToggleClick(int gridIndex, PersonalCardData cardData)
	{
		this.CurSelectCardData = cardData;
		List<PersonalCardData> cardDataList = this.PersonalInfoData.CardDataList;
		int count = cardDataList.Count;
		for (int i = 0; i < count; i++)
		{
			PersonalCardData personalCardData = cardDataList[i];
			if (personalCardData.CardId == this.CurSelectCardData.CardId && personalCardData.IsUnLock && !personalCardData.IsRead)
			{
				PersonalController.Instance.SendReadCardRequest(this.CurSelectCardData.CardId);
				break;
			}
		}
		this.ScrollView.SelectGridProxy(gridIndex, false);
		this.RefreshCardInfo(this.CurSelectCardData);
		this.RefreshConfirmBtnByCurSelectData(this.CurSelectCardData);
	}

	// Token: 0x0600F9F7 RID: 63991 RVA: 0x00491288 File Offset: 0x0048F488
	protected void RefreshCardInfo(PersonalCardData cardData)
	{
		BackgroundCard value = ConfigBackgroundCardById.GetConfig(cardData.CardId, true).Value;
		base.SetTextureByPath(value.CardPath, base.GetTexture(2), null, null);
		base.GetText(3).ShowTextNew(value.Title);
		base.GetText(4).ShowTextNew(value.AttributesDescription);
		base.GetText(5).ShowTextNew(value.Tips);
	}

	// Token: 0x0600F9F8 RID: 63992 RVA: 0x00491304 File Offset: 0x0048F504
	private void RefreshConfirmBtnByCurSelectData(PersonalCardData curSelectCardData)
	{
		int cardId = curSelectCardData.CardId;
		int? curCardId = this.PersonalInfoData.CurCardId;
		bool flag = cardId == curCardId.GetValueOrDefault() & curCardId != null;
		bool flag2 = curSelectCardData.IsUnLock && !flag;
		this.ConfirmBtn.SetEnableClick(flag2);
		base.GetInteractionGroup(10).SetInteractable(flag2);
		string textId = flag ? "Text_InUse_Text" : "ConfirmBox_173_ButtonText_1";
		this.ConfirmBtn.SetLocalTextNew(textId, Array.Empty<object>());
	}

	// Token: 0x0600F9F9 RID: 63993 RVA: 0x00491380 File Offset: 0x0048F580
	private PersonalCardData[] GetSortedList()
	{
		List<PersonalCardData> list = new List<PersonalCardData>(this.PersonalInfoData.GetCardList(true));
		int num = list.FindIndex(delegate(PersonalCardData data)
		{
			int cardId = data.CardId;
			int? curCardId = this.PersonalInfoData.CurCardId;
			return cardId == curCardId.GetValueOrDefault() & curCardId != null;
		});
		if (num <= 0 || num >= list.Count)
		{
			return list.ToArray();
		}
		PersonalCardData value = list[num];
		for (int i = num; i > 0; i--)
		{
			list[i] = list[i - 1];
		}
		list[0] = value;
		return list.ToArray();
	}

	// Token: 0x0600F9FA RID: 63994 RVA: 0x004913F8 File Offset: 0x0048F5F8
	protected override void OnBeforeDestroy()
	{
		if (this.ScrollView != null)
		{
			this.ScrollView.ClearGridProxies();
			this.ScrollView = null;
		}
	}

	// Token: 0x04008BD4 RID: 35796
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PersonalCardBaseItem, PersonalCardData> ScrollView;

	// Token: 0x04008BD5 RID: 35797
	[Nullable(2)]
	private ButtonItem ConfirmBtn;

	// Token: 0x04008BD6 RID: 35798
	[Nullable(2)]
	private PersonalCardData CurSelectCardData;

	// Token: 0x04008BD7 RID: 35799
	[Nullable(2)]
	private PersonalInfoData PersonalInfoData;

	// Token: 0x04008BD8 RID: 35800
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;
}
