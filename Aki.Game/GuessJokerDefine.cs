using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x020004FD RID: 1277
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerDefine : IStaticVariableResetter
{
	// Token: 0x06003E97 RID: 16023 RVA: 0x00161368 File Offset: 0x0015F568
	static GuessJokerDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuessJokerDefine.CreateStaticDefaultValue), new Action(GuessJokerDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06003E98 RID: 16024 RVA: 0x00161388 File Offset: 0x0015F588
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

	// Token: 0x06003E99 RID: 16025 RVA: 0x001615F1 File Offset: 0x0015F7F1
	public static void ResetStaticDefaultValue()
	{
		GuessJokerDefine.GuessJokerCardStageTransitionMap = null;
		GuessJokerDefine.GuessJokerCardPositionConfig = null;
	}

	// Token: 0x06003E9A RID: 16026 RVA: 0x001615FF File Offset: 0x0015F7FF
	public static IReadOnlyDictionary<EGuessJokerCardStateType, EGuessJokerCardStateType[]> GetGuessJokerCardStageTransitionMap()
	{
		return GuessJokerDefine.GuessJokerCardStageTransitionMap;
	}

	// Token: 0x06003E9B RID: 16027 RVA: 0x00161608 File Offset: 0x0015F808
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

	// Token: 0x06003E9C RID: 16028 RVA: 0x00161698 File Offset: 0x0015F898
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

	// Token: 0x06003E9D RID: 16029 RVA: 0x001616F0 File Offset: 0x0015F8F0
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

	// Token: 0x06003E9E RID: 16030 RVA: 0x00161748 File Offset: 0x0015F948
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

	// Token: 0x06003E9F RID: 16031 RVA: 0x00161810 File Offset: 0x0015FA10
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

	// Token: 0x040031D3 RID: 12755
	public const int GUESS_JOKER_LUHESI_SKILL_ID = 151001;

	// Token: 0x040031D4 RID: 12756
	public const int GUESS_JOKER_JIABEI_SKILL_ID = 120801;

	// Token: 0x040031D5 RID: 12757
	public const int GUESS_JOKER_JINXI_SKILL_ID = 130401;

	// Token: 0x040031D6 RID: 12758
	public const int GUESS_JOKER_PLAYER_SKILL_ID = 100001;

	// Token: 0x040031D7 RID: 12759
	public const int GUESS_JOKER_JINXI_LEVEL_ID = 1010;

	// Token: 0x040031D8 RID: 12760
	public const int GUESS_JOKER_AI_CHECK_CARD_MAX_LENGTH = 3;

	// Token: 0x040031D9 RID: 12761
	public const int GUESS_JOKER_AI_CHECK_CARD_MIN_LENGTH = 1;

	// Token: 0x040031DA RID: 12762
	public const int GUESS_JOKER_CARD_CHECK_ITEM_UP_OFFSET = 200;

	// Token: 0x040031DB RID: 12763
	public const float GUESS_JOKER_CARD_DISABLE_ALPHA = 0.3f;

	// Token: 0x040031DC RID: 12764
	public const int GUESS_JOKER_AI_BECHOOSE_CARD_EMOTION_COUNT = 2;

	// Token: 0x040031DD RID: 12765
	public const float GUESS_JOKER_SKILL_PROGRESS_THRESHOLD = 0.3f;

	// Token: 0x040031DE RID: 12766
	public const int GUESS_JOKER_START_CARD_SIZE = 1;

	// Token: 0x040031DF RID: 12767
	public const int GUESS_JOKER_START_CARD_SCALE_RANGE = 0;

	// Token: 0x040031E0 RID: 12768
	public const int GUESS_JOKER_START_CARD_ROTATION = 0;

	// Token: 0x040031E1 RID: 12769
	public const int GUESS_JOKER_START_CARD_ROTATION_RANGE = 0;

	// Token: 0x040031E2 RID: 12770
	public const int GUESS_JOKER_CARD_AI_CARDS_COUNT_LIMIT = 3;

	// Token: 0x040031E3 RID: 12771
	public const int GUESS_JOKER_CARD_PLAYER_CARDS_COUNT_LIMIT_ADVANTAGE = 4;

	// Token: 0x040031E4 RID: 12772
	public const int GUESS_JOKER_CARD_AI_CARDS_COUNT_LIMIT_ADVANTAGE = 4;

	// Token: 0x040031E5 RID: 12773
	public const int GUESS_JOKER_CARD_SHOW_TIME = 1000;

	// Token: 0x040031E6 RID: 12774
	public const int GUESS_JOKER_CARD_SKILL_EXECUTE_TIME = 1500;

	// Token: 0x040031E7 RID: 12775
	public const int GUESS_JOKER_CARD_WIDTH = 240;

	// Token: 0x040031E8 RID: 12776
	private static Dictionary<EGuessJokerCardStateType, EGuessJokerCardStateType[]> GuessJokerCardStageTransitionMap;

	// Token: 0x040031E9 RID: 12777
	private static Dictionary<ECardPositionType, ICardPositionConfig> GuessJokerCardPositionConfig;
}
