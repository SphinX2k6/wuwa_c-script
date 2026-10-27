using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02001049 RID: 4169
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerDefine : IStaticVariableResetter
{
	// Token: 0x06006B02 RID: 27394 RVA: 0x00158A40 File Offset: 0x00156C40
	static GuessJokerDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuessJokerDefine.CreateStaticDefaultValue), new Action(GuessJokerDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06006B03 RID: 27395 RVA: 0x00158A60 File Offset: 0x00156C60
	public static void CreateStaticDefaultValue()
	{
		GuessJokerDefine.GuessJokerCardStageTransitionMap = new Dictionary<EGuessJokerCardStateType, EGuessJokerCardStateType[]>
		{
			{
				EGuessJokerCardStateType.None,
				new EGuessJokerCardStateType[]
				{
					EGuessJokerCardStateType.GameStart
				}
			},
			{
				EGuessJokerCardStateType.GameStart,
				new EGuessJokerCardStateType[]
				{
					EGuessJokerCardStateType.DealCards,
					EGuessJokerCardStateType.GameExit
				}
			},
			{
				EGuessJokerCardStateType.DealCards,
				new EGuessJokerCardStateType[]
				{
					EGuessJokerCardStateType.FlipCoin,
					EGuessJokerCardStateType.GameExit
				}
			},
			{
				EGuessJokerCardStateType.FlipCoin,
				new EGuessJokerCardStateType[]
				{
					EGuessJokerCardStateType.RoundPlay,
					EGuessJokerCardStateType.GameExit
				}
			},
			{
				EGuessJokerCardStateType.RoundPlay,
				new EGuessJokerCardStateType[]
				{
					EGuessJokerCardStateType.SettleStage,
					EGuessJokerCardStateType.GameExit
				}
			},
			{
				EGuessJokerCardStateType.SettleStage,
				new EGuessJokerCardStateType[]
				{
					EGuessJokerCardStateType.GameStart,
					EGuessJokerCardStateType.GameExit
				}
			},
			{
				EGuessJokerCardStateType.GameExit,
				Array.Empty<EGuessJokerCardStateType>()
			}
		};
		GuessJokerDefine.GuessJokerCardPositionConfig = new Dictionary<ECardPositionType, ICardPositionConfig>
		{
			{
				ECardPositionType.Middle,
				new CardPositionConfig
				{
					PositionRate = -18f,
					Spacing = 4f,
					Size = new float?(0.8f)
				}
			},
			{
				ECardPositionType.PlayerBeDrawCard,
				new CardPositionConfig
				{
					PositionRate = -37f,
					Spacing = -50f,
					Size = new float?(0.75f)
				}
			},
			{
				ECardPositionType.PlayerHand,
				new CardPositionConfig
				{
					PositionRate = -50f,
					Spacing = -50f,
					Size = new float?(0.75f)
				}
			},
			{
				ECardPositionType.PlayerPlay,
				new CardPositionConfig
				{
					PositionRate = -50f,
					Spacing = -50f,
					Size = new float?(0.75f)
				}
			},
			{
				ECardPositionType.PlayerInitial,
				new CardPositionConfig
				{
					PositionRate = -42f,
					Spacing = -50f,
					Size = new float?(0.75f)
				}
			},
			{
				ECardPositionType.AiHand,
				new CardPositionConfig
				{
					PositionRate = -12.5f,
					Spacing = 4f,
					Size = new float?(0.42f),
					Alpha = new float?(0.45f)
				}
			},
			{
				ECardPositionType.AiBeDrawCard,
				new CardPositionConfig
				{
					PositionRate = -16f,
					Spacing = 8f,
					Size = new float?(0.71f),
					Alpha = new float?(1f)
				}
			},
			{
				ECardPositionType.AiInitial,
				new CardPositionConfig
				{
					PositionRate = -12.5f,
					Spacing = 4f,
					Size = new float?(0.42f),
					Alpha = new float?(0.45f)
				}
			}
		};
	}

	// Token: 0x06006B04 RID: 27396 RVA: 0x00158CC9 File Offset: 0x00156EC9
	public static void ResetStaticDefaultValue()
	{
		GuessJokerDefine.GuessJokerCardStageTransitionMap = null;
		GuessJokerDefine.GuessJokerCardPositionConfig = null;
	}

	// Token: 0x06006B05 RID: 27397 RVA: 0x00158CD7 File Offset: 0x00156ED7
	public static IReadOnlyDictionary<EGuessJokerCardStateType, EGuessJokerCardStateType[]> GetGuessJokerCardStageTransitionMap()
	{
		return GuessJokerDefine.GuessJokerCardStageTransitionMap;
	}

	// Token: 0x06006B06 RID: 27398 RVA: 0x00158CE0 File Offset: 0x00156EE0
	public static ICardPositionConfig GetCardPositionConfig(ECardPositionType cardPositionType)
	{
		ICardPositionConfig cardPositionConfig = GuessJokerDefine.GuessJokerCardPositionConfig[cardPositionType];
		return new CardPositionConfig
		{
			PositionRate = cardPositionConfig.PositionRate,
			Spacing = cardPositionConfig.Spacing,
			UpOffset = new float?(cardPositionConfig.UpOffset.GetValueOrDefault(70f)),
			Size = new float?(cardPositionConfig.Size.GetValueOrDefault(1f)),
			Alpha = new float?(cardPositionConfig.Alpha.GetValueOrDefault(1f))
		};
	}

	// Token: 0x06006B07 RID: 27399 RVA: 0x00158D70 File Offset: 0x00156F70
	public static float CalculateCardScaleByIndex(int index, int totalCount)
	{
		if (totalCount <= 1)
		{
			return 1f;
		}
		bool flag = totalCount % 2 == 0;
		float num = (float)(totalCount - 1) / 2f;
		if (flag)
		{
			int num2 = (int)Math.Floor((double)num);
			int num3 = (int)Math.Ceiling((double)num);
			return (float)1;
		}
		int num4 = (int)Math.Floor((double)num);
		Math.Abs(index - num4);
		return (float)1;
	}

	// Token: 0x06006B08 RID: 27400 RVA: 0x00158DC8 File Offset: 0x00156FC8
	public static float CalculateCardRotation(int index, int totalCount)
	{
		if (totalCount <= 1)
		{
			return 0f;
		}
		bool flag = totalCount % 2 == 0;
		float num = (float)(totalCount - 1) / 2f;
		if (flag)
		{
			int num2 = (int)Math.Floor((double)num);
			int num3 = (int)Math.Ceiling((double)num);
			return 0f;
		}
		int num4 = (int)Math.Floor((double)num);
		int num5 = index - num4;
		return (float)0;
	}

	// Token: 0x06006B09 RID: 27401 RVA: 0x00158E20 File Offset: 0x00157020
	public static string GetPokerStateName(EPokerStateType state)
	{
		Dictionary<EPokerStateType, string> dictionary = new Dictionary<EPokerStateType, string>
		{
			{
				EPokerStateType.Idel,
				"Idle"
			},
			{
				EPokerStateType.BeChosenCardStrong,
				"BeChosenCardStrong"
			},
			{
				EPokerStateType.BeChosenCardWeak,
				"BeChosenCardWeak"
			},
			{
				EPokerStateType.BeDrawnCardHappy,
				"BeDrawnCardHappy"
			},
			{
				EPokerStateType.BeDrawnCardSad,
				"BeDrawnCardSad"
			},
			{
				EPokerStateType.DrawCardNormal,
				"DrawCardNormal"
			},
			{
				EPokerStateType.DrawCardThinking,
				"DrawCardThinking"
			},
			{
				EPokerStateType.GetCardHappy,
				"GetCardHappy"
			},
			{
				EPokerStateType.GetCardSad,
				"GetCardSad"
			},
			{
				EPokerStateType.Win,
				"Win"
			},
			{
				EPokerStateType.Lose,
				"Lose"
			},
			{
				EPokerStateType.IdelPerformance,
				"IdelPerformance"
			},
			{
				EPokerStateType.EPokerStateType_MAX,
				"Unknown"
			}
		};
		string result;
		if (!dictionary.TryGetValue(state, out result))
		{
			return dictionary[EPokerStateType.EPokerStateType_MAX];
		}
		return result;
	}

	// Token: 0x06006B0A RID: 27402 RVA: 0x00158EE8 File Offset: 0x001570E8
	public static string GetPokerIdleStateName(EPokerIdleState state)
	{
		Dictionary<EPokerIdleState, string> dictionary = new Dictionary<EPokerIdleState, string>
		{
			{
				EPokerIdleState.Normal,
				"Idle_Normal"
			},
			{
				EPokerIdleState.Disadvantage,
				"Idle_Disadvantage"
			},
			{
				EPokerIdleState.Advantage,
				"Idle_Advantage"
			},
			{
				EPokerIdleState.EPokerIdleState_MAX,
				"Idle_Unknown"
			}
		};
		string result;
		if (!dictionary.TryGetValue(state, out result))
		{
			return dictionary[EPokerIdleState.EPokerIdleState_MAX];
		}
		return result;
	}

	// Token: 0x0400313A RID: 12602
	public const int GUESS_JOKER_LUHESI_SKILL_ID = 151001;

	// Token: 0x0400313B RID: 12603
	public const int GUESS_JOKER_JIABEI_SKILL_ID = 120801;

	// Token: 0x0400313C RID: 12604
	public const int GUESS_JOKER_JINXI_SKILL_ID = 130401;

	// Token: 0x0400313D RID: 12605
	public const int GUESS_JOKER_PLAYER_SKILL_ID = 100001;

	// Token: 0x0400313E RID: 12606
	public const int GUESS_JOKER_JINXI_LEVEL_ID = 1010;

	// Token: 0x0400313F RID: 12607
	public const int GUESS_JOKER_AI_CHECK_CARD_MAX_LENGTH = 3;

	// Token: 0x04003140 RID: 12608
	public const int GUESS_JOKER_AI_CHECK_CARD_MIN_LENGTH = 1;

	// Token: 0x04003141 RID: 12609
	public const int GUESS_JOKER_CARD_CHECK_ITEM_UP_OFFSET = 200;

	// Token: 0x04003142 RID: 12610
	public const float GUESS_JOKER_CARD_DISABLE_ALPHA = 0.3f;

	// Token: 0x04003143 RID: 12611
	public const int GUESS_JOKER_AI_BECHOOSE_CARD_EMOTION_COUNT = 2;

	// Token: 0x04003144 RID: 12612
	public const float GUESS_JOKER_SKILL_PROGRESS_THRESHOLD = 0.3f;

	// Token: 0x04003145 RID: 12613
	public const int GUESS_JOKER_START_CARD_SIZE = 1;

	// Token: 0x04003146 RID: 12614
	public const int GUESS_JOKER_START_CARD_SCALE_RANGE = 0;

	// Token: 0x04003147 RID: 12615
	public const int GUESS_JOKER_START_CARD_ROTATION = 0;

	// Token: 0x04003148 RID: 12616
	public const int GUESS_JOKER_START_CARD_ROTATION_RANGE = 0;

	// Token: 0x04003149 RID: 12617
	public const int GUESS_JOKER_CARD_AI_CARDS_COUNT_LIMIT = 3;

	// Token: 0x0400314A RID: 12618
	public const int GUESS_JOKER_CARD_PLAYER_CARDS_COUNT_LIMIT_ADVANTAGE = 4;

	// Token: 0x0400314B RID: 12619
	public const int GUESS_JOKER_CARD_AI_CARDS_COUNT_LIMIT_ADVANTAGE = 4;

	// Token: 0x0400314C RID: 12620
	public const int GUESS_JOKER_CARD_SHOW_TIME = 1000;

	// Token: 0x0400314D RID: 12621
	public const int GUESS_JOKER_CARD_SKILL_EXECUTE_TIME = 1500;

	// Token: 0x0400314E RID: 12622
	public const int GUESS_JOKER_CARD_WIDTH = 240;

	// Token: 0x0400314F RID: 12623
	private static Dictionary<EGuessJokerCardStateType, EGuessJokerCardStateType[]> GuessJokerCardStageTransitionMap;

	// Token: 0x04003150 RID: 12624
	private static Dictionary<ECardPositionType, ICardPositionConfig> GuessJokerCardPositionConfig;
}
