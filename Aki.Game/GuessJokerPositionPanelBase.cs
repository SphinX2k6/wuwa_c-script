using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001075 RID: 4213
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerPositionPanelBase
{
	// Token: 0x06006CD4 RID: 27860 RVA: 0x0016060D File Offset: 0x0015E80D
	public GuessJokerPositionPanelBase(ECardPositionType position, GuessJokerGamePlayView gamePlayView)
	{
		this.Position = position;
		this.GamePlayView = gamePlayView;
	}

	// Token: 0x06006CD5 RID: 27861 RVA: 0x0016063C File Offset: 0x0015E83C
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

	// Token: 0x06006CD6 RID: 27862 RVA: 0x0016068C File Offset: 0x0015E88C
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

	// Token: 0x06006CD7 RID: 27863 RVA: 0x001606AC File Offset: 0x0015E8AC
	public bool CheckCardExist(int cardId)
	{
		return this.CardIdMap.ContainsKey(cardId);
	}

	// Token: 0x06006CD8 RID: 27864 RVA: 0x001606BC File Offset: 0x0015E8BC
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

	// Token: 0x06006CD9 RID: 27865 RVA: 0x00160714 File Offset: 0x0015E914
	public void AddCardByItemList(List<GuessJokerCardItem> cardList)
	{
		for (int i = 0; i < cardList.Count; i++)
		{
			this.AddCardByItem(cardList[i]);
		}
		this.UpdateCardItemsIndexInPanel();
	}

	// Token: 0x06006CDA RID: 27866 RVA: 0x00160748 File Offset: 0x0015E948
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

	// Token: 0x06006CDB RID: 27867 RVA: 0x0016078C File Offset: 0x0015E98C
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

	// Token: 0x06006CDC RID: 27868 RVA: 0x001607F0 File Offset: 0x0015E9F0
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

	// Token: 0x06006CDD RID: 27869 RVA: 0x001608EC File Offset: 0x0015EAEC
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

	// Token: 0x06006CDE RID: 27870 RVA: 0x0016095C File Offset: 0x0015EB5C
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

	// Token: 0x06006CDF RID: 27871 RVA: 0x00160AA4 File Offset: 0x0015ECA4
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

	// Token: 0x06006CE0 RID: 27872 RVA: 0x00160B28 File Offset: 0x0015ED28
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

	// Token: 0x06006CE1 RID: 27873 RVA: 0x00160C1C File Offset: 0x0015EE1C
	public List<int> GetCardIdList()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.CardItemList.Count; i++)
		{
			list.Add(this.CardItemList[i].Data.Id);
		}
		return list;
	}

	// Token: 0x06006CE2 RID: 27874 RVA: 0x00160C64 File Offset: 0x0015EE64
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

	// Token: 0x06006CE3 RID: 27875 RVA: 0x00160CEC File Offset: 0x0015EEEC
	public void UpdateCardItemsIndexInPanel()
	{
		for (int i = 0; i < this.CardItemList.Count; i++)
		{
			this.CardItemList[i].SetIndexInPanel(i);
		}
	}

	// Token: 0x06006CE4 RID: 27876 RVA: 0x00160D24 File Offset: 0x0015EF24
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

	// Token: 0x06006CE5 RID: 27877 RVA: 0x00160D84 File Offset: 0x0015EF84
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

	// Token: 0x06006CE6 RID: 27878 RVA: 0x00160DD8 File Offset: 0x0015EFD8
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

	// Token: 0x04003268 RID: 12904
	public readonly List<GuessJokerCardItem> CardItemList = new List<GuessJokerCardItem>();

	// Token: 0x04003269 RID: 12905
	private readonly Dictionary<int, GuessJokerCardItem> CardIdMap = new Dictionary<int, GuessJokerCardItem>();

	// Token: 0x0400326A RID: 12906
	public readonly ECardPositionType Position;

	// Token: 0x0400326B RID: 12907
	private readonly GuessJokerGamePlayView GamePlayView;
}
