using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;

// Token: 0x02000514 RID: 1300
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerUtils
{
	// Token: 0x06003F58 RID: 16216 RVA: 0x00163917 File Offset: 0x00161B17
	public static EGuessJokerPlayerType ServerPlayerTransToClient(JokerGuessActor playerType)
	{
		if (playerType != JokerGuessActor.Who)
		{
			return EGuessJokerPlayerType.Ai;
		}
		return EGuessJokerPlayerType.Me;
	}

	// Token: 0x06003F59 RID: 16217 RVA: 0x0016391F File Offset: 0x00161B1F
	public static bool ServerUseSkillTransToClient(JokerGuessSkillOp useSkill)
	{
		return useSkill == JokerGuessSkillOp.Use;
	}

	// Token: 0x06003F5A RID: 16218 RVA: 0x00163928 File Offset: 0x00161B28
	public static void LogCardsGlobalIndex(GuessJokerCardItem[] cardItems, string logType = "")
	{
		List<int> list = new List<int>();
		for (int i = 0; i < cardItems.Length; i++)
		{
			list.Add(cardItems[i].GetGlobalIndex());
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GuessJokerCard;
		ELogAuthor author = ELogAuthor.LRC;
		string message = string.Format("{0}: cards index", logType);
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("globalIndexList", string.Join<int>(",", list));
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06003F5B RID: 16219 RVA: 0x00163994 File Offset: 0x00161B94
	public static void LogCardsIdList(GuessJokerCardItem[] cardItems, string logType = "")
	{
		List<int> list = new List<int>();
		for (int i = 0; i < cardItems.Length; i++)
		{
			list.Add(cardItems[i].Data.Id);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GuessJokerCard;
		ELogAuthor author = ELogAuthor.LRC;
		string message = string.Format("{0}: cards ids", logType);
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("idList", string.Join<int>(",", list));
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06003F5C RID: 16220 RVA: 0x00163A04 File Offset: 0x00161C04
	public static ICardLayoutInfo[] CalculateCardLayoutInfo(int cardCount, ECardPositionType postionType)
	{
		ICardPositionConfig cardPositionConfig = GuessJokerDefine.GetCardPositionConfig(postionType);
		float spacing = cardPositionConfig.Spacing;
		float valueOrDefault = cardPositionConfig.Size.GetValueOrDefault(1f);
		float valueOrDefault2 = cardPositionConfig.Alpha.GetValueOrDefault(1f);
		float height = UiLayer.Instance.UiRootItem.GetHeight();
		float y = cardPositionConfig.PositionRate * height / 100f;
		List<CardLayoutInfo> list = new List<CardLayoutInfo>();
		List<float> list2 = new List<float>();
		List<float> list3 = new List<float>();
		float num = 0f;
		for (int i = 0; i < cardCount; i++)
		{
			float num2 = GuessJokerDefine.CalculateCardScaleByIndex(i, cardCount);
			float num3 = valueOrDefault * num2;
			list2.Add(num3);
			float item = GuessJokerDefine.CalculateCardRotation(i, cardCount);
			list3.Add(item);
			float num4 = 240f * num3;
			if (i == 0)
			{
				num += num4;
			}
			else
			{
				num += spacing + num4;
			}
		}
		float num5 = -num / 2f;
		for (int j = 0; j < cardCount; j++)
		{
			float num6 = 240f * list2[j];
			if (j == 0)
			{
				num5 += num6 / 2f;
			}
			else
			{
				num5 += spacing + num6 / 2f;
			}
			list.Add(new CardLayoutInfo
			{
				X = num5,
				Y = y,
				Scale = list2[j],
				Rotation = list3[j],
				Alpha = valueOrDefault2
			});
			num5 += num6 / 2f;
		}
		return list.ToArray();
	}

	// Token: 0x06003F5D RID: 16221 RVA: 0x00163B8C File Offset: 0x00161D8C
	public static GuessJokerPlotConfig? GetPlotConfig(EGuessJokerPlayerType playerType, EGuessJokerPlotTiming timing, int? extraParam = null)
	{
		GuessJokerAIPlotConfig? jokerAiPlotConfig = GuessJokerConfig.Instance.GetJokerAiPlotConfig(playerType, timing, extraParam.GetValueOrDefault());
		if (jokerAiPlotConfig == null)
		{
			return null;
		}
		int[] plotIdListArray = jokerAiPlotConfig.Value.GetPlotIdListArray();
		List<int> list = new List<int>();
		foreach (int item in plotIdListArray)
		{
			list.Add(item);
		}
		if (list.Count == 0)
		{
			return null;
		}
		int id = jokerAiPlotConfig.Value.Id;
		int? lastUsedPlotId = GuessJokerGamePlayModel.Instance.GetLastUsedPlotId(id);
		List<int> list2 = list;
		if (lastUsedPlotId != null && list.Count > 1)
		{
			List<int> list3 = new List<int>();
			for (int j = 0; j < list.Count; j++)
			{
				int num = list[j];
				if (num != lastUsedPlotId.Value)
				{
					list3.Add(num);
				}
			}
			list2 = list3;
		}
		if (list2.Count == 0)
		{
			list2 = list;
		}
		int index = new Random().Next(list2.Count);
		int plotId = list2[index];
		return GuessJokerConfig.Instance.GetJokerPlotConfig(plotId);
	}

	// Token: 0x06003F5E RID: 16222 RVA: 0x00163CB4 File Offset: 0x00161EB4
	public static EPokerStateType CalculateNpcState(ENpcPokerChangeTimingType changeTiming, int relatedCardId = 0)
	{
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		if (instance == null)
		{
			return EPokerStateType.Idel;
		}
		List<GuessJokerCardData> handCardsByPlayer = instance.GetHandCardsByPlayer(EGuessJokerPlayerType.Ai);
		int count = handCardsByPlayer.Count;
		int count2 = instance.GetHandCardsByPlayer(EGuessJokerPlayerType.Me).Count;
		bool flag = false;
		for (int i = 0; i < handCardsByPlayer.Count; i++)
		{
			if (handCardsByPlayer[i].Type == EGuessJokerCardType.Joker)
			{
				flag = true;
				break;
			}
		}
		bool flag2 = false;
		if (relatedCardId > 0)
		{
			GuessJokerCardData cardDataById = instance.GetCardDataById(relatedCardId);
			if (cardDataById != null)
			{
				flag2 = (cardDataById.Type == EGuessJokerCardType.Joker);
			}
		}
		EPokerStateType result;
		switch (changeTiming)
		{
		case ENpcPokerChangeTimingType.BeChooseCard:
			if (count > GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerBeChooseAiCardCount.ToString()))
			{
				result = EPokerStateType.BeChosenCardWeak;
			}
			else
			{
				result = EPokerStateType.BeChosenCardStrong;
			}
			break;
		case ENpcPokerChangeTimingType.BeDrawCard:
			if (count == 0)
			{
				result = EPokerStateType.BeDrawnCardHappy;
			}
			else if (flag2)
			{
				result = EPokerStateType.BeDrawnCardHappy;
			}
			else if (count <= GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerBeDrawAiCardCount.ToString()))
			{
				if (flag)
				{
					result = EPokerStateType.BeDrawnCardSad;
				}
				else
				{
					result = EPokerStateType.Idel;
				}
			}
			else
			{
				result = EPokerStateType.Idel;
			}
			break;
		case ENpcPokerChangeTimingType.ChooseCard:
			if (count > GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerDrawAiCardCount.ToString()))
			{
				result = EPokerStateType.DrawCardNormal;
			}
			else
			{
				result = EPokerStateType.DrawCardThinking;
			}
			break;
		case ENpcPokerChangeTimingType.DrawCard:
			if (count2 == 0)
			{
				result = EPokerStateType.GetCardSad;
			}
			else if (flag2)
			{
				result = EPokerStateType.GetCardSad;
			}
			else if (count2 <= GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerDrawAiCardCount.ToString()))
			{
				result = EPokerStateType.GetCardHappy;
			}
			else
			{
				result = EPokerStateType.Idel;
			}
			break;
		default:
			result = EPokerStateType.Idel;
			break;
		}
		return result;
	}

	// Token: 0x06003F5F RID: 16223 RVA: 0x00163E1C File Offset: 0x0016201C
	public static EGuessJokerPlotTiming GetPlayerGetCardState(int relatedCardId)
	{
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		if (instance == null)
		{
			return EGuessJokerPlotTiming.GetCardNormal;
		}
		int count = instance.GetHandCardsByPlayer(EGuessJokerPlayerType.Me).Count;
		bool count2 = instance.GetHandCardsByPlayer(EGuessJokerPlayerType.Ai).Count != 0;
		bool flag = false;
		if (relatedCardId > 0)
		{
			GuessJokerCardData cardDataById = instance.GetCardDataById(relatedCardId);
			if (cardDataById != null)
			{
				flag = (cardDataById.Type == EGuessJokerCardType.Joker);
			}
		}
		if (!count2)
		{
			return EGuessJokerPlotTiming.GetCardSad;
		}
		if (flag)
		{
			return EGuessJokerPlotTiming.GetCardSad;
		}
		if (count <= GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerBeDrawPlayerCardCount.ToString()))
		{
			return EGuessJokerPlotTiming.GetCardHappy;
		}
		return EGuessJokerPlotTiming.GetCardNormal;
	}

	// Token: 0x06003F60 RID: 16224 RVA: 0x00163E93 File Offset: 0x00162093
	public static EGuessJokerPlayerType GetOtherPlayerType(EGuessJokerPlayerType playerType)
	{
		if (playerType != EGuessJokerPlayerType.Ai)
		{
			return EGuessJokerPlayerType.Ai;
		}
		return EGuessJokerPlayerType.Me;
	}

	// Token: 0x06003F61 RID: 16225 RVA: 0x00163E9C File Offset: 0x0016209C
	[NullableContext(2)]
	public static string GetCameraNameByCameraId(int cameraId)
	{
		UiCameraMapping? uiCameraMappingConfigById = UiCameraConfig.Instance.GetUiCameraMappingConfigById(cameraId);
		if (uiCameraMappingConfigById == null)
		{
			return null;
		}
		return uiCameraMappingConfigById.Value.ViewName;
	}

	// Token: 0x06003F62 RID: 16226 RVA: 0x00163ED0 File Offset: 0x001620D0
	[NullableContext(2)]
	public static string GetCameraSettingNameByCameraId(int cameraId)
	{
		UiCameraMapping? uiCameraMappingConfigById = UiCameraConfig.Instance.GetUiCameraMappingConfigById(cameraId);
		if (uiCameraMappingConfigById == null)
		{
			return null;
		}
		return uiCameraMappingConfigById.Value.DefaultUiCameraSettingsName;
	}

	// Token: 0x06003F63 RID: 16227 RVA: 0x00163F04 File Offset: 0x00162104
	public static int GetJokerParamConfig(string key)
	{
		GuessJokerParam? jokerParam = GuessJokerConfig.Instance.GetJokerParam(key);
		if (jokerParam == null)
		{
			return 0;
		}
		return jokerParam.Value.Value;
	}
}
