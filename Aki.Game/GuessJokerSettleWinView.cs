using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Ui;

// Token: 0x0200051F RID: 1311
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerSettleWinView : GuessJokerSettleViewBase
{
	// Token: 0x06003FF7 RID: 16375 RVA: 0x00166AB7 File Offset: 0x00164CB7
	public GuessJokerSettleWinView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06003FF8 RID: 16376 RVA: 0x00166AC0 File Offset: 0x00164CC0
	protected override string GetWinnerName()
	{
		return GuessJokerGamePlayModel.Instance.GetPlayerNameByType(EGuessJokerPlayerType.Me);
	}

	// Token: 0x06003FF9 RID: 16377 RVA: 0x00166ACD File Offset: 0x00164CCD
	protected override EPokerStateType GetNpcPokerState()
	{
		return EPokerStateType.Lose;
	}

	// Token: 0x06003FFA RID: 16378 RVA: 0x00166AD4 File Offset: 0x00164CD4
	protected override string GetEmojiTexturePath()
	{
		int levelId = GuessJokerGamePlayModel.Instance.GetLevelId();
		GuessJokerLevel? jokerLevelById = GuessJokerConfig.Instance.GetJokerLevelById(levelId);
		if (jokerLevelById == null)
		{
			return "";
		}
		int j = (WorldLevelModel.Instance.Sex == 0) ? 1 : 0;
		string text = jokerLevelById.Value.WinEmojiPath(j);
		if (text == null)
		{
			return "";
		}
		return text;
	}

	// Token: 0x06003FFB RID: 16379 RVA: 0x00166B34 File Offset: 0x00164D34
	protected override string GetDescText()
	{
		int levelId = GuessJokerGamePlayModel.Instance.GetLevelId();
		GuessJokerLevel? jokerLevelById = GuessJokerConfig.Instance.GetJokerLevelById(levelId);
		if (jokerLevelById == null)
		{
			return "";
		}
		Dictionary<int, string> dictionary = jokerLevelById.Value.WinText();
		int roundNumber = GuessJokerGamePlayModel.Instance.RoundNumber;
		int num = 0;
		string result = "";
		foreach (KeyValuePair<int, string> keyValuePair in dictionary)
		{
			int key = keyValuePair.Key;
			string value = keyValuePair.Value;
			if (key >= roundNumber && (num == 0 || key < num))
			{
				num = key;
				result = value;
			}
		}
		if (num == 0)
		{
			string text;
			dictionary.TryGetValue(0, out text);
			return text ?? "";
		}
		return result;
	}

	// Token: 0x06003FFC RID: 16380 RVA: 0x00166C10 File Offset: 0x00164E10
	protected override EUiViewName GetViewName()
	{
		return EUiViewName.GuessJokerSettleWinView;
	}
}
