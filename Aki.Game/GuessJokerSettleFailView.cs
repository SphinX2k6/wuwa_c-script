using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Ui;

// Token: 0x02001068 RID: 4200
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerSettleFailView : GuessJokerSettleViewBase
{
	// Token: 0x06006C47 RID: 27719 RVA: 0x0015DBD7 File Offset: 0x0015BDD7
	public GuessJokerSettleFailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006C48 RID: 27720 RVA: 0x0015DBE0 File Offset: 0x0015BDE0
	protected override string GetWinnerName()
	{
		return GuessJokerGamePlayModel.Instance.GetPlayerNameByType(EGuessJokerPlayerType.Ai);
	}

	// Token: 0x06006C49 RID: 27721 RVA: 0x0015DBED File Offset: 0x0015BDED
	protected override EPokerStateType GetNpcPokerState()
	{
		return EPokerStateType.Win;
	}

	// Token: 0x06006C4A RID: 27722 RVA: 0x0015DBF4 File Offset: 0x0015BDF4
	protected override string GetEmojiTexturePath()
	{
		int levelId = GuessJokerGamePlayModel.Instance.GetLevelId();
		GuessJokerLevel? jokerLevelById = GuessJokerConfig.Instance.GetJokerLevelById(levelId);
		if (jokerLevelById == null)
		{
			return "";
		}
		int j = (WorldLevelModel.Instance.Sex == 0) ? 1 : 0;
		string text = jokerLevelById.Value.FailEmojiPath(j);
		if (text == null)
		{
			return "";
		}
		return text;
	}

	// Token: 0x06006C4B RID: 27723 RVA: 0x0015DC54 File Offset: 0x0015BE54
	protected override string GetDescText()
	{
		int levelId = GuessJokerGamePlayModel.Instance.GetLevelId();
		GuessJokerLevel? jokerLevelById = GuessJokerConfig.Instance.GetJokerLevelById(levelId);
		if (jokerLevelById == null)
		{
			return "";
		}
		Dictionary<int, string> dictionary = jokerLevelById.Value.FailText();
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

	// Token: 0x06006C4C RID: 27724 RVA: 0x0015DD30 File Offset: 0x0015BF30
	protected override EUiViewName GetViewName()
	{
		return EUiViewName.GuessJokerSettleFailView;
	}
}
