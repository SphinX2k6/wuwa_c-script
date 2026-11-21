using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000529 RID: 1321
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerPositionPanelBase
{
	// Token: 0x06004069 RID: 16489 RVA: 0x00168F41 File Offset: 0x00167141
	public GuessJokerPositionPanelBase(ECardPositionType position, GuessJokerGamePlayView gamePlayView)
	{
		this.Position = position;
		this.GamePlayView = gamePlayView;
	}

	// Token: 0x0600406A RID: 16490 RVA: 0x00168F70 File Offset: 0x00167170
	private void AddCardByItem(GuessJokerCardItem cardItem)
	{
		if (this.CheckCardExist(cardItem.Data.Id))
		{
			return;
		}
		cardItem.SetPositionType(this.Position);
		this.CardItemList.Add(cardItem);
		this.CardIdMap[cardItem.Data.Id] = cardItem;
	}

	// Token: 0x0600406B RID: 16491 RVA: 0x00168FC0 File Offset: 0x001671C0
	[NullableContext(2)]
	public GuessJokerCardItem GetCardItemByCardId(int cardId)
	{
		GuessJokerCardItem result;
		if (!this.CardIdMap.TryGetValue(cardId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0600406C RID: 16492 RVA: 0x00168FE0 File Offset: 0x001671E0
	public bool CheckCardExist(int cardId)
	{
		return this.CardIdMap.ContainsKey(cardId);
	}

	// Token: 0x0600406D RID: 16493 RVA: 0x00168FF0 File Offset: 0x001671F0
	public void InitCardByItemList(List<GuessJokerCardItem> cardList)
	{
		for (int i = 0; i < cardList.Count; i++)
		{
			GuessJokerCardItem cardItem = cardList[i];
			this.AddCardByItem(cardItem);
		}
		this.UpdateCardItemsPosition();
		this.UpdateCardItemsIndexInPanel();
		for (int j = 0; j < cardList.Count; j++)
		{
			cardList[j].Show(null);
		}
	}

	// Token: 0x0600406E RID: 16494 RVA: 0x00169048 File Offset: 0x00167248
	public void AddCardByItemList(List<GuessJokerCardItem> cardList)
	{
		for (int i = 0; i < cardList.Count; i++)
		{
			this.AddCardByItem(cardList[i]);
		}
		this.UpdateCardItemsIndexInPanel();
	}

	// Token: 0x0600406F RID: 16495 RVA: 0x0016907C File Offset: 0x0016727C
	[NullableContext(2)]
	public GuessJokerCardItem RemoveCardByCardId(int cardId)
	{
		GuessJokerCardItem cardItemByCardId = this.GetCardItemByCardId(cardId);
		if (cardItemByCardId != null)
		{
			int index = this.CardItemList.IndexOf(cardItemByCardId);
			this.CardItemList.RemoveAt(index);
			this.CardIdMap.Remove(cardId);
			return cardItemByCardId;
		}
		return null;
	}

	// Token: 0x06004070 RID: 16496 RVA: 0x001690C0 File Offset: 0x001672C0
	public void DealCards(List<GuessJokerCardItem> cardList, Action finishCallback, int dealInterval = 150)
	{
		GuessJokerPositionPanelBase.<>c__DisplayClass11_0 CS$<>8__locals1 = new GuessJokerPositionPanelBase.<>c__DisplayClass11_0();
		CS$<>8__locals1.finishCallback = finishCallback;
		CS$<>8__locals1.cardList = cardList;
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.dealInterval = dealInterval;
		if (CS$<>8__locals1.cardList.Count == 0)
		{
			CS$<>8__locals1.finishCallback();
			return;
		}
		CS$<>8__locals1.currentIndex = 0;
		CS$<>8__locals1.pendingAnimations = 0;
		CS$<>8__locals1.allDealt = false;
		CS$<>8__locals1.<DealCards>g__DealNext|1();
	}

	// Token: 0x06004071 RID: 16497 RVA: 0x00169124 File Offset: 0x00167324
	[NullableContext(2)]
	public void AnimateCardsToPosition(Action onComplete = null)
	{
		List<GuessJokerCardItem> cardItemList = this.CardItemList;
		if (cardItemList.Count != 0)
		{
			ICardLayoutInfo[] array = GuessJokerUtils.CalculateCardLayoutInfo(cardItemList.Count, this.Position);
			bool[] completedFlags = new bool[cardItemList.Count];
			for (int i = 0; i < cardItemList.Count; i++)
			{
				completedFlags[i] = false;
			}
			for (int j = 0; j < cardItemList.Count; j++)
			{
				GuessJokerCardItem guessJokerCardItem = cardItemList[j];
				ICardLayoutInfo cardLayoutInfo = array[j];
				Vector2D targetPosition = new Vector2D((double)cardLayoutInfo.X, (double)cardLayoutInfo.Y);
				int index = j;
				guessJokerCardItem.SmoothMoveTo(targetPosition, delegate
				{
					completedFlags[index] = true;
					bool flag = true;
					for (int k = 0; k < completedFlags.Length; k++)
					{
						if (!completedFlags[k])
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						Action onComplete3 = onComplete;
						if (onComplete3 == null)
						{
							return;
						}
						onComplete3();
					}
				}, new float?(cardLayoutInfo.Scale), new float?(cardLayoutInfo.Rotation), -1f);
			}
			return;
		}
		Action onComplete2 = onComplete;
		if (onComplete2 == null)
		{
			return;
		}
		onComplete2();
	}

	// Token: 0x06004072 RID: 16498 RVA: 0x00169220 File Offset: 0x00167420
	public void ShuffleCards()
	{
		Random random = new Random();
		for (int i = this.CardItemList.Count - 1; i > 0; i--)
		{
			int index = random.Next(i + 1);
			GuessJokerCardItem value = this.CardItemList[i];
			this.CardItemList[i] = this.CardItemList[index];
			this.CardItemList[index] = value;
		}
		this.UpdateCardItemsIndexInPanel();
	}

	// Token: 0x06004073 RID: 16499 RVA: 0x00169290 File Offset: 0x00167490
	public void ShuffleCardsWithAnimation(Action finishCallback)
	{
		GuessJokerPositionPanelBase.<>c__DisplayClass14_0 CS$<>8__locals1 = new GuessJokerPositionPanelBase.<>c__DisplayClass14_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.finishCallback = finishCallback;
		if (this.CardItemList.Count <= 1)
		{
			CS$<>8__locals1.finishCallback();
			return;
		}
		ICardPositionConfig cardPositionConfig = GuessJokerDefine.GetCardPositionConfig(this.Position);
		float height = UiLayer.Instance.UiRootItem.GetHeight();
		float num = cardPositionConfig.PositionRate * height / 100f;
		Vector2D targetPosition = new Vector2D(0.0, (double)num);
		GuessJokerCardItem guessJokerCardItem = this.CardItemList[0];
		GuessJokerPositionPanelBase.<>c__DisplayClass14_0 CS$<>8__locals2 = CS$<>8__locals1;
		GuessJokerCardData data = guessJokerCardItem.Data;
		bool isPlayerWash;
		if (data == null)
		{
			isPlayerWash = false;
		}
		else
		{
			EGuessJokerPlayerType? belongPlayerType = data.GetBelongPlayerType();
			EGuessJokerPlayerType eguessJokerPlayerType = EGuessJokerPlayerType.Me;
			isPlayerWash = (belongPlayerType.GetValueOrDefault() == eguessJokerPlayerType & belongPlayerType != null);
		}
		CS$<>8__locals2.isPlayerWash = isPlayerWash;
		CS$<>8__locals1.gatherCompleted = 0;
		AudioSystem.Instance.PostEvent("play_ui_springfestival_ghostcard_card_shuffle");
		for (int i = 0; i < this.CardItemList.Count; i++)
		{
			GuessJokerCardItem guessJokerCardItem2 = this.CardItemList[i];
			if (CS$<>8__locals1.isPlayerWash)
			{
				guessJokerCardItem2.CardFlip(false, true);
			}
			guessJokerCardItem2.SmoothMoveTo(targetPosition, new Action(CS$<>8__locals1.<ShuffleCardsWithAnimation>g__OnGatherComplete|0), new float?(cardPositionConfig.Size.GetValueOrDefault(1f)), null, -1f);
		}
	}

	// Token: 0x06004074 RID: 16500 RVA: 0x001693D8 File Offset: 0x001675D8
	public void ShowCardPairNotice(Action finishCallback)
	{
		GuessJokerPositionPanelBase.<>c__DisplayClass15_0 CS$<>8__locals1 = new GuessJokerPositionPanelBase.<>c__DisplayClass15_0();
		CS$<>8__locals1.finishCallback = finishCallback;
		CS$<>8__locals1.totalCount = this.CardItemList.Count;
		if (CS$<>8__locals1.totalCount != 0)
		{
			CS$<>8__locals1.done = 0;
			for (int i = 0; i < this.CardItemList.Count; i++)
			{
				this.CardItemList[i].PlayCardSequence("PairNotice", new Action(CS$<>8__locals1.<ShowCardPairNotice>g__TryFinish|0));
			}
			return;
		}
		Action finishCallback2 = CS$<>8__locals1.finishCallback;
		if (finishCallback2 == null)
		{
			return;
		}
		finishCallback2();
	}

	// Token: 0x06004075 RID: 16501 RVA: 0x0016945C File Offset: 0x0016765C
	public void RemoveCards(Action finishCallback)
	{
		GuessJokerPositionPanelBase.<>c__DisplayClass16_0 CS$<>8__locals1 = new GuessJokerPositionPanelBase.<>c__DisplayClass16_0();
		CS$<>8__locals1.finishCallback = finishCallback;
		CS$<>8__locals1.totalCount = this.CardItemList.Count;
		if (CS$<>8__locals1.totalCount != 0)
		{
			CS$<>8__locals1.done = 0;
			List<int> list = new List<int>();
			for (int i = 0; i < this.CardItemList.Count; i++)
			{
				list.Add(this.CardItemList[i].Data.Id);
			}
			for (int j = 0; j < this.CardItemList.Count; j++)
			{
				GuessJokerCardItem card = this.CardItemList[j];
				card.PlayCardSequence("Dissolve", delegate
				{
					CS$<>8__locals1.<RemoveCards>g__TryFinish|0();
					card.Destroy(null);
				});
			}
			GuessJokerGamePlayModel.Instance.RemoveCardData(list.ToArray());
			this.CardItemList.Clear();
			return;
		}
		Action finishCallback2 = CS$<>8__locals1.finishCallback;
		if (finishCallback2 == null)
		{
			return;
		}
		finishCallback2();
	}

	// Token: 0x06004076 RID: 16502 RVA: 0x00169550 File Offset: 0x00167750
	public List<int> GetCardIdList()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.CardItemList.Count; i++)
		{
			list.Add(this.CardItemList[i].Data.Id);
		}
		return list;
	}

	// Token: 0x06004077 RID: 16503 RVA: 0x00169598 File Offset: 0x00167798
	public void UpdateCardItemsPosition()
	{
		ICardLayoutInfo[] array = GuessJokerUtils.CalculateCardLayoutInfo(this.CardItemList.Count, this.Position);
		for (int i = 0; i < this.CardItemList.Count; i++)
		{
			GuessJokerCardItem guessJokerCardItem = this.CardItemList[i];
			ICardLayoutInfo cardLayoutInfo = array[i];
			guessJokerCardItem.SetAlpha(cardLayoutInfo.Alpha);
			Vector2D position = new Vector2D((double)cardLayoutInfo.X, (double)cardLayoutInfo.Y);
			guessJokerCardItem.SetPosition(position);
			guessJokerCardItem.SetSize(cardLayoutInfo.Scale);
			guessJokerCardItem.SetRotation(cardLayoutInfo.Rotation);
		}
	}

	// Token: 0x06004078 RID: 16504 RVA: 0x00169620 File Offset: 0x00167820
	public void UpdateCardItemsIndexInPanel()
	{
		for (int i = 0; i < this.CardItemList.Count; i++)
		{
			this.CardItemList[i].SetIndexInPanel(i);
		}
	}

	// Token: 0x06004079 RID: 16505 RVA: 0x00169658 File Offset: 0x00167858
	public void SetCardsClickableExcept(bool isClickable, int excludeCardId = 0)
	{
		for (int i = 0; i < this.CardItemList.Count; i++)
		{
			GuessJokerCardItem guessJokerCardItem = this.CardItemList[i];
			GuessJokerCardData data = guessJokerCardItem.Data;
			if (data == null || data.Id != excludeCardId)
			{
				guessJokerCardItem.SetClickEnable(isClickable);
			}
		}
		if (isClickable)
		{
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
		}
	}

	// Token: 0x0600407A RID: 16506 RVA: 0x001696B8 File Offset: 0x001678B8
	public void SetCardsDarkExcept(bool isDark, List<int> excludeCardIdList = null)
	{
		if (excludeCardIdList == null)
		{
			excludeCardIdList = new List<int>();
		}
		for (int i = 0; i < this.CardItemList.Count; i++)
		{
			GuessJokerCardItem guessJokerCardItem = this.CardItemList[i];
			if (!excludeCardIdList.Contains(guessJokerCardItem.Data.Id))
			{
				guessJokerCardItem.SetDark(isDark);
			}
		}
	}

	// Token: 0x0600407B RID: 16507 RVA: 0x0016970C File Offset: 0x0016790C
	public void SwapCardPositionsSilently(int cardId1, int cardId2)
	{
		GuessJokerCardItem cardItemByCardId = this.GetCardItemByCardId(cardId1);
		GuessJokerCardItem cardItemByCardId2 = this.GetCardItemByCardId(cardId2);
		if (cardItemByCardId == null || cardItemByCardId2 == null)
		{
			return;
		}
		GuessJokerCardData cardDataById = GuessJokerGamePlayModel.Instance.GetCardDataById(cardId2);
		GuessJokerCardData cardDataById2 = GuessJokerGamePlayModel.Instance.GetCardDataById(cardId1);
		if (cardDataById == null || cardDataById2 == null)
		{
			return;
		}
		cardItemByCardId.UpdateCardData(cardDataById);
		cardItemByCardId2.UpdateCardData(cardDataById2);
		this.CardIdMap[cardId2] = cardItemByCardId;
		this.CardIdMap[cardId1] = cardItemByCardId2;
		this.GamePlayView.SwapCardItemMap(cardId1, cardId2);
		cardItemByCardId.RefreshCardItem();
		cardItemByCardId2.RefreshCardItem();
	}

	// Token: 0x04003301 RID: 13057
	public readonly List<GuessJokerCardItem> CardItemList = new List<GuessJokerCardItem>();

	// Token: 0x04003302 RID: 13058
	private readonly Dictionary<int, GuessJokerCardItem> CardIdMap = new Dictionary<int, GuessJokerCardItem>();

	// Token: 0x04003303 RID: 13059
	public readonly ECardPositionType Position;

	// Token: 0x04003304 RID: 13060
	private readonly GuessJokerGamePlayView GamePlayView;
}
