using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Ui;

// Token: 0x0200051C RID: 1308
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerSettleFailView : GuessJokerSettleViewBase
{
	// Token: 0x06003FDC RID: 16348 RVA: 0x0016650F File Offset: 0x0016470F
	public GuessJokerSettleFailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06003FDD RID: 16349 RVA: 0x00166518 File Offset: 0x00164718
	protected override string GetWinnerName()
	{
		return GuessJokerGamePlayModel.Instance.GetPlayerNameByType(EGuessJokerPlayerType.Ai);
	}

	// Token: 0x06003FDE RID: 16350 RVA: 0x00166525 File Offset: 0x00164725
	protected override EPokerStateType GetNpcPokerState()
	{
		return EPokerStateType.Win;
	}

	// Token: 0x06003FDF RID: 16351 RVA: 0x0016652C File Offset: 0x0016472C
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

	// Token: 0x06003FE0 RID: 16352 RVA: 0x0016658C File Offset: 0x0016478C
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

	// Token: 0x06003FE1 RID: 16353 RVA: 0x00166668 File Offset: 0x00164868
	protected override EUiViewName GetViewName()
	{
		return EUiViewName.GuessJokerSettleFailView;
	}
}
