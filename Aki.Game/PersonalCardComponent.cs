using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020018AF RID: 6319
[NullableContext(1)]
[Nullable(0)]
public class PersonalCardComponent : UiPanelBase
{
	// Token: 0x0600F9CB RID: 63947 RVA: 0x00490525 File Offset: 0x0048E725
	public PersonalCardComponent([Nullable(2)] UUIItem uiItem, bool isPreview, PersonalInfoData personalInfoData)
	{
		this.IsPreview = isPreview;
		this.PersonalInfoData = personalInfoData;
		if (uiItem != null)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}
	}

	// Token: 0x0600F9CC RID: 63948 RVA: 0x0049054C File Offset: 0x0048E74C
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
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent))
		};
		if (!this.IsPreview)
		{
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(7, new Action(this.OnClickCardPreviewBtn))
			};
		}
	}

	// Token: 0x0600F9CD RID: 63949 RVA: 0x0049063F File Offset: 0x0048E83F
	protected override void OnStart()
	{
		this.ScrollView = new LoopScrollView<PersonalCardBaseItem, PersonalCardData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<PersonalCardBaseItem>(this.CreateCardItem), false);
		this.AddEventListener();
	}

	// Token: 0x0600F9CE RID: 63950 RVA: 0x00490678 File Offset: 0x0048E878
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		PersonalCardComponent.<OnBeforeShowAsyncImplement>d__9 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PersonalCardComponent.<OnBeforeShowAsyncImplement>d__9>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0600F9CF RID: 63951 RVA: 0x004906BB File Offset: 0x0048E8BB
	protected void OnShowUiTabViewFromToggle()
	{
	}

	// Token: 0x0600F9D0 RID: 63952 RVA: 0x004906C0 File Offset: 0x0048E8C0
	private List<PersonalCardData> GetSortedList()
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
			return list;
		}
		PersonalCardData value = list[num];
		for (int i = num; i > 0; i--)
		{
			list[i] = list[i - 1];
		}
		list[0] = value;
		return list;
	}

	// Token: 0x0600F9D1 RID: 63953 RVA: 0x0049072E File Offset: 0x0048E92E
	protected void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnCardChange, new Action(this.OnCardChange));
	}

	// Token: 0x0600F9D2 RID: 63954 RVA: 0x0049074C File Offset: 0x0048E94C
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnCardChange, new Action(this.OnCardChange));
	}

	// Token: 0x0600F9D3 RID: 63955 RVA: 0x0049076A File Offset: 0x0048E96A
	public void SetRefreshConfirmBtn(Action<bool, bool> refreshConfirmBtn)
	{
		this.RefreshConfirmBtn = refreshConfirmBtn;
	}

	// Token: 0x0600F9D4 RID: 63956 RVA: 0x00490774 File Offset: 0x0048E974
	private void OnCardChange()
	{
		if (this.IsPreview)
		{
			return;
		}
		this.RefreshConfirmBtnState(this.CurPersonalCardData);
		List<PersonalCardData> sortedList = this.GetSortedList();
		this.ScrollView.RefreshByData(sortedList, false, null, false);
		this.ScrollView.SelectGridProxy(0, false);
		this.ScrollView.ScrollToGridIndex(0, true);
		UiNavigationNewController.Instance.SetNavigationFocusForView(this.ScrollView.GetGridByDisplayIndex(0), true, false, false);
	}

	// Token: 0x0600F9D5 RID: 63957 RVA: 0x004907E0 File Offset: 0x0048E9E0
	public void OnClickConfirm(int _)
	{
		PersonalController.Instance.SendChangeCardRequest(this.CurPersonalCardData.CardId);
	}

	// Token: 0x0600F9D6 RID: 63958 RVA: 0x004907F7 File Offset: 0x0048E9F7
	private void OnClickCardPreviewBtn()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.CurPersonalCardData.CardId, true, null, false);
	}

	// Token: 0x0600F9D7 RID: 63959 RVA: 0x00490811 File Offset: 0x0048EA11
	private PersonalCardItem CreateCardItem()
	{
		PersonalCardItem personalCardItem = new PersonalCardItem();
		personalCardItem.SetToggleCallBack(new Action<int, PersonalCardData>(this.CardItemToggleClick));
		return personalCardItem;
	}

	// Token: 0x0600F9D8 RID: 63960 RVA: 0x0049082C File Offset: 0x0048EA2C
	private void CardItemToggleClick(int gridIndex, PersonalCardData cardData)
	{
		this.CurPersonalCardData = cardData;
		List<PersonalCardData> cardDataList = this.PersonalInfoData.CardDataList;
		int count = cardDataList.Count;
		for (int i = 0; i < count; i++)
		{
			PersonalCardData personalCardData = cardDataList[i];
			if (personalCardData.CardId == cardData.CardId && personalCardData.IsUnLock && !personalCardData.IsRead)
			{
				PersonalController.Instance.SendReadCardRequest(cardData.CardId);
				break;
			}
		}
		if (!this.IsPreview)
		{
			this.RefreshConfirmBtnState(cardData);
		}
		this.RefreshCardInfo(cardData);
		this.ScrollView.SelectGridProxy(gridIndex, false);
	}

	// Token: 0x0600F9D9 RID: 63961 RVA: 0x004908BC File Offset: 0x0048EABC
	protected void RefreshCardInfo(PersonalCardData cardData)
	{
		BackgroundCard? config = ConfigBackgroundCardById.GetConfig(cardData.CardId, true);
		base.SetTextureByPath(config.Value.CardPath, base.GetTexture(2), null, null);
		base.GetText(3).ShowTextNew(config.Value.Title);
		base.GetText(4).ShowTextNew(config.Value.AttributesDescription);
		base.GetText(5).ShowTextNew(config.Value.Tips);
	}

	// Token: 0x0600F9DA RID: 63962 RVA: 0x00490950 File Offset: 0x0048EB50
	private void RefreshConfirmBtnState(PersonalCardData cardData)
	{
		int? curCardId = this.PersonalInfoData.CurCardId;
		bool isUnLock = cardData.IsUnLock;
		int? num = curCardId;
		int cardId = cardData.CardId;
		bool flag = !(num.GetValueOrDefault() == cardId & num != null) && isUnLock;
		if (this.RefreshConfirmBtn != null)
		{
			Action<bool, bool> refreshConfirmBtn = this.RefreshConfirmBtn;
			bool arg = flag;
			num = curCardId;
			cardId = cardData.CardId;
			refreshConfirmBtn(arg, num.GetValueOrDefault() == cardId & num != null);
		}
	}

	// Token: 0x0600F9DB RID: 63963 RVA: 0x004909C4 File Offset: 0x0048EBC4
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x04008BBC RID: 35772
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PersonalCardBaseItem, PersonalCardData> ScrollView;

	// Token: 0x04008BBD RID: 35773
	private readonly bool IsPreview;

	// Token: 0x04008BBE RID: 35774
	[Nullable(2)]
	private PersonalCardData CurPersonalCardData;

	// Token: 0x04008BBF RID: 35775
	private readonly PersonalInfoData PersonalInfoData;

	// Token: 0x04008BC0 RID: 35776
	[Nullable(2)]
	private Action<bool, bool> RefreshConfirmBtn;

	// Token: 0x02007AF7 RID: 31479
	[NullableContext(0)]
	public enum EPersonalCardComponentDefine
	{
		// Token: 0x04027DAE RID: 163246
		ScrollView,
		// Token: 0x04027DAF RID: 163247
		PersonalCardItem,
		// Token: 0x04027DB0 RID: 163248
		Texture,
		// Token: 0x04027DB1 RID: 163249
		TitleText,
		// Token: 0x04027DB2 RID: 163250
		DescText,
		// Token: 0x04027DB3 RID: 163251
		TipsText,
		// Token: 0x04027DB4 RID: 163252
		RightItem,
		// Token: 0x04027DB5 RID: 163253
		CardPreviewBtn
	}
}
