using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020023CA RID: 9162
[NullableContext(1)]
[Nullable(0)]
public class PersonalCardComponent : UiPanelBase
{
	// Token: 0x06012519 RID: 75033 RVA: 0x00483025 File Offset: 0x00481225
	public PersonalCardComponent([Nullable(2)] UUIItem uiItem, bool isPreview, PersonalInfoData personalInfoData)
	{
		this.IsPreview = isPreview;
		this.PersonalInfoData = personalInfoData;
		if (uiItem != null)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}
	}

	// Token: 0x0601251A RID: 75034 RVA: 0x0048304C File Offset: 0x0048124C
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

	// Token: 0x0601251B RID: 75035 RVA: 0x0048313F File Offset: 0x0048133F
	protected override void OnStart()
	{
		this.ScrollView = new LoopScrollView<PersonalCardBaseItem, PersonalCardData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<PersonalCardBaseItem>(this.CreateCardItem), false);
		this.AddEventListener();
	}

	// Token: 0x0601251C RID: 75036 RVA: 0x00483178 File Offset: 0x00481378
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		PersonalCardComponent.<OnBeforeShowAsyncImplement>d__9 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PersonalCardComponent.<OnBeforeShowAsyncImplement>d__9>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0601251D RID: 75037 RVA: 0x004831BB File Offset: 0x004813BB
	protected void OnShowUiTabViewFromToggle()
	{
	}

	// Token: 0x0601251E RID: 75038 RVA: 0x004831C0 File Offset: 0x004813C0
	private List<PersonalCardData> GetSortedList()
	{
		List<PersonalCardData> list = this.PersonalInfoData.GetCardList(true).ToList<PersonalCardData>();
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

	// Token: 0x0601251F RID: 75039 RVA: 0x0048322E File Offset: 0x0048142E
	protected void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnCardChange, new Action(this.OnCardChange));
	}

	// Token: 0x06012520 RID: 75040 RVA: 0x0048324C File Offset: 0x0048144C
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnCardChange, new Action(this.OnCardChange));
	}

	// Token: 0x06012521 RID: 75041 RVA: 0x0048326A File Offset: 0x0048146A
	public void SetRefreshConfirmBtn(Action<bool, bool> refreshConfirmBtn)
	{
		this.RefreshConfirmBtn = refreshConfirmBtn;
	}

	// Token: 0x06012522 RID: 75042 RVA: 0x00483274 File Offset: 0x00481474
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

	// Token: 0x06012523 RID: 75043 RVA: 0x004832E0 File Offset: 0x004814E0
	public void OnClickConfirm(int _)
	{
		PersonalController.Instance.SendChangeCardRequest(this.CurPersonalCardData.CardId);
	}

	// Token: 0x06012524 RID: 75044 RVA: 0x004832F7 File Offset: 0x004814F7
	private void OnClickCardPreviewBtn()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.CurPersonalCardData.CardId, true, null);
	}

	// Token: 0x06012525 RID: 75045 RVA: 0x00483310 File Offset: 0x00481510
	private PersonalCardItem CreateCardItem()
	{
		PersonalCardItem personalCardItem = new PersonalCardItem();
		personalCardItem.SetToggleCallBack(new Action<int, PersonalCardData>(this.CardItemToggleClick));
		return personalCardItem;
	}

	// Token: 0x06012526 RID: 75046 RVA: 0x0048332C File Offset: 0x0048152C
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

	// Token: 0x06012527 RID: 75047 RVA: 0x004833BC File Offset: 0x004815BC
	protected void RefreshCardInfo(PersonalCardData cardData)
	{
		BackgroundCard? config = ConfigBackgroundCardById.GetConfig(cardData.CardId, true);
		base.SetTextureByPath(config.Value.CardPath, base.GetTexture(2), null, null);
		base.GetText(3).ShowTextNew(config.Value.Title);
		base.GetText(4).ShowTextNew(config.Value.AttributesDescription);
		base.GetText(5).ShowTextNew(config.Value.Tips);
	}

	// Token: 0x06012528 RID: 75048 RVA: 0x00483450 File Offset: 0x00481650
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

	// Token: 0x06012529 RID: 75049 RVA: 0x004834C4 File Offset: 0x004816C4
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x04008A75 RID: 35445
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PersonalCardBaseItem, PersonalCardData> ScrollView;

	// Token: 0x04008A76 RID: 35446
	private readonly bool IsPreview;

	// Token: 0x04008A77 RID: 35447
	[Nullable(2)]
	private PersonalCardData CurPersonalCardData;

	// Token: 0x04008A78 RID: 35448
	private readonly PersonalInfoData PersonalInfoData;

	// Token: 0x04008A79 RID: 35449
	[Nullable(2)]
	private Action<bool, bool> RefreshConfirmBtn;

	// Token: 0x0200896E RID: 35182
	[NullableContext(0)]
	public enum EPersonalCardComponentDefine
	{
		// Token: 0x0402CA93 RID: 182931
		ScrollView,
		// Token: 0x0402CA94 RID: 182932
		PersonalCardItem,
		// Token: 0x0402CA95 RID: 182933
		Texture,
		// Token: 0x0402CA96 RID: 182934
		TitleText,
		// Token: 0x0402CA97 RID: 182935
		DescText,
		// Token: 0x0402CA98 RID: 182936
		TipsText,
		// Token: 0x0402CA99 RID: 182937
		RightItem,
		// Token: 0x0402CA9A RID: 182938
		CardPreviewBtn
	}
}
