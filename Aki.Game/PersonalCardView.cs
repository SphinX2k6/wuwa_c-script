using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020023D0 RID: 9168
[NullableContext(1)]
[Nullable(0)]
public class PersonalCardView : UiViewBase
{
	// Token: 0x0601253A RID: 75066 RVA: 0x0048392A File Offset: 0x00481B2A
	public PersonalCardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601253B RID: 75067 RVA: 0x00483934 File Offset: 0x00481B34
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

	// Token: 0x0601253C RID: 75068 RVA: 0x00483A64 File Offset: 0x00481C64
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
		this.ScrollView.RefreshByData(sortedList.ToList<PersonalCardData>(), false, null, false);
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

	// Token: 0x0601253D RID: 75069 RVA: 0x00483BBB File Offset: 0x00481DBB
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnCardChange, new Action(this.OnCardChange));
	}

	// Token: 0x0601253E RID: 75070 RVA: 0x00483BD9 File Offset: 0x00481DD9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnCardChange, new Action(this.OnCardChange));
	}

	// Token: 0x0601253F RID: 75071 RVA: 0x00483BF8 File Offset: 0x00481DF8
	private void OnCardChange()
	{
		PersonalCardData[] sortedList = this.GetSortedList();
		this.ScrollView.RefreshByData(sortedList.ToList<PersonalCardData>(), false, null, false);
		this.ScrollView.SelectGridProxy(0, false);
		this.ScrollView.ScrollToGridIndex(0, true);
		this.RefreshConfirmBtnByCurSelectData(this.CurSelectCardData);
		UiNavigationNewController.Instance.SetNavigationFocusForView(this.ScrollView.GetGridByDisplayIndex(0), true, false, false);
	}

	// Token: 0x06012540 RID: 75072 RVA: 0x00483C60 File Offset: 0x00481E60
	private void OnClickConfirm(int _)
	{
		PersonalController.Instance.SendChangeCardRequest(this.CurSelectCardData.CardId);
		UiManager.Instance.CloseView(EUiViewName.PersonalEditView, null);
		UiManager.Instance.CloseView(EUiViewName.PersonalOptionView, null);
	}

	// Token: 0x06012541 RID: 75073 RVA: 0x00483C97 File Offset: 0x00481E97
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06012542 RID: 75074 RVA: 0x00483CA0 File Offset: 0x00481EA0
	private void OnClickCardPreviewBtn()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.CurSelectCardData.CardId, true, null);
	}

	// Token: 0x06012543 RID: 75075 RVA: 0x00483CB9 File Offset: 0x00481EB9
	private PersonalCardItem CreateCardItem()
	{
		PersonalCardItem personalCardItem = new PersonalCardItem();
		personalCardItem.SetToggleCallBack(new Action<int, PersonalCardData>(this.OnCardItemToggleClick));
		personalCardItem.SetNeedShowRedDot(false);
		PersonalInfoData personalInfoData = this.PersonalInfoData;
		personalCardItem.SetIsOtherCardItem(personalInfoData != null && personalInfoData.IsOtherData);
		return personalCardItem;
	}

	// Token: 0x06012544 RID: 75076 RVA: 0x00483CF4 File Offset: 0x00481EF4
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

	// Token: 0x06012545 RID: 75077 RVA: 0x00483D90 File Offset: 0x00481F90
	protected void RefreshCardInfo(PersonalCardData cardData)
	{
		BackgroundCard value = ConfigBackgroundCardById.GetConfig(cardData.CardId, true).Value;
		base.SetTextureByPath(value.CardPath, base.GetTexture(2), null, null);
		base.GetText(3).ShowTextNew(value.Title);
		base.GetText(4).ShowTextNew(value.AttributesDescription);
		base.GetText(5).ShowTextNew(value.Tips);
	}

	// Token: 0x06012546 RID: 75078 RVA: 0x00483E0C File Offset: 0x0048200C
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

	// Token: 0x06012547 RID: 75079 RVA: 0x00483E88 File Offset: 0x00482088
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

	// Token: 0x06012548 RID: 75080 RVA: 0x00483F00 File Offset: 0x00482100
	protected override void OnBeforeDestroy()
	{
		if (this.ScrollView != null)
		{
			this.ScrollView.ClearGridProxies();
			this.ScrollView = null;
		}
	}

	// Token: 0x04008A8D RID: 35469
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PersonalCardBaseItem, PersonalCardData> ScrollView;

	// Token: 0x04008A8E RID: 35470
	[Nullable(2)]
	private ButtonItem ConfirmBtn;

	// Token: 0x04008A8F RID: 35471
	[Nullable(2)]
	private PersonalCardData CurSelectCardData;

	// Token: 0x04008A90 RID: 35472
	[Nullable(2)]
	private PersonalInfoData PersonalInfoData;

	// Token: 0x04008A91 RID: 35473
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;
}
