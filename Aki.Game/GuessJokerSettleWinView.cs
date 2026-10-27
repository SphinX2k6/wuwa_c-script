using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Ui;

// Token: 0x0200106B RID: 4203
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerSettleWinView : GuessJokerSettleViewBase
{
	// Token: 0x06006C62 RID: 27746 RVA: 0x0015E183 File Offset: 0x0015C383
	public GuessJokerSettleWinView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006C63 RID: 27747 RVA: 0x0015E18C File Offset: 0x0015C38C
	protected override string GetWinnerName()
	{
		return GuessJokerGamePlayModel.Instance.GetPlayerNameByType(EGuessJokerPlayerType.Me);
	}

	// Token: 0x06006C64 RID: 27748 RVA: 0x0015E199 File Offset: 0x0015C399
	protected override EPokerStateType GetNpcPokerState()
	{
		return EPokerStateType.Lose;
	}

	// Token: 0x06006C65 RID: 27749 RVA: 0x0015E1A0 File Offset: 0x0015C3A0
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

	// Token: 0x06006C66 RID: 27750 RVA: 0x0015E200 File Offset: 0x0015C400
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

	// Token: 0x06006C67 RID: 27751 RVA: 0x0015E2DC File Offset: 0x0015C4DC
	protected override EUiViewName GetViewName()
	{
		return EUiViewName.GuessJokerSettleWinView;
	}
}
