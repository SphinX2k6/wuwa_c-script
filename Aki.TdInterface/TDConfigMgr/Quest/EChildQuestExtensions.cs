using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001232 RID: 4658
	public static class EChildQuestExtensions
	{
		// Token: 0x06006988 RID: 27016 RVA: 0x000FB870 File Offset: 0x000F9A70
		public static string ToEnumString(this EChildQuest value)
		{
			string result;
			switch (value)
			{
			case EChildQuest.DoInteract:
				result = "DoInteract";
				break;
			case EChildQuest.ReachArea:
				result = "ReachArea";
				break;
			case EChildQuest.Kill:
				result = "Kill";
				break;
			case EChildQuest.GetItem:
				result = "GetItem";
				break;
			case EChildQuest.UseSkill:
				result = "UseSkill";
				break;
			case EChildQuest.GetSkill:
				result = "GetSkill";
				break;
			case EChildQuest.PlayFlow:
				result = "PlayFlow";
				break;
			case EChildQuest.DetectCombatState:
				result = "DetectCombatState";
				break;
			case EChildQuest.Parkour:
				result = "Parkour";
				break;
			case EChildQuest.Timer:
				result = "Timer";
				break;
			case EChildQuest.HandInItems:
				result = "HandInItems";
				break;
			case EChildQuest.NewHandInItems:
				result = "NewHandInItems";
				break;
			case EChildQuest.MonsterCreator:
				result = "MonsterCreator";
				break;
			case EChildQuest.InformationViewCheck:
				result = "InformationViewCheck";
				break;
			case EChildQuest.UseItem:
				result = "UseItem";
				break;
			case EChildQuest.CheckEntityState:
				result = "CheckEntityState";
				break;
			case EChildQuest.CheckLevelPlay:
				result = "CheckLevelPlay";
				break;
			case EChildQuest.CheckUiGame:
				result = "CheckUiGame";
				break;
			case EChildQuest.FinishDungeon:
				result = "FinishDungeon";
				break;
			case EChildQuest.WaitTime:
				result = "WaitTime";
				break;
			case EChildQuest.ScheduleTime:
				result = "ScheduleTime";
				break;
			case EChildQuest.ReadMail:
				result = "ReadMail";
				break;
			case EChildQuest.Guide:
				result = "Guide";
				break;
			case EChildQuest.EnterDungeon:
				result = "EnterDungeon";
				break;
			case EChildQuest.LeaveDungeon:
				result = "LeaveDungeon";
				break;
			case EChildQuest.CheckTargetBattleAttribute:
				result = "CheckTargetBattleAttribute";
				break;
			case EChildQuest.WaitBattleCondition:
				result = "WaitBattleCondition";
				break;
			case EChildQuest.CompareVar:
				result = "CompareVar";
				break;
			case EChildQuest.CompareActorVar:
				result = "CompareActorVar";
				break;
			case EChildQuest.ReceiveTelecom:
				result = "ReceiveTelecom";
				break;
			case EChildQuest.ShowUi:
				result = "ShowUi";
				break;
			case EChildQuest.TakePhoto:
				result = "TakePhoto";
				break;
			case EChildQuest.TakePhoto2:
				result = "TakePhoto2";
				break;
			case EChildQuest.VisionSystem:
				result = "VisionSystem";
				break;
			case EChildQuest.ParallaxAlign:
				result = "ParallaxAlign";
				break;
			case EChildQuest.CheckConditionGroup:
				result = "CheckConditionGroup";
				break;
			case EChildQuest.CheckClientConditionGroup:
				result = "CheckClientConditionGroup";
				break;
			case EChildQuest.CheckActivityState:
				result = "CheckActivityState";
				break;
			case EChildQuest.CheckPlayerInput:
				result = "CheckPlayerInput";
				break;
			case EChildQuest.AwakeAndLoadEntity:
				result = "AwakeAndLoadEntity";
				break;
			case EChildQuest.WalkingPattern:
				result = "WalkingPattern";
				break;
			case EChildQuest.DetectCombatState2:
				result = "DetectCombatState2";
				break;
			case EChildQuest.FinishBvbChallenge:
				result = "FinishBvbChallenge";
				break;
			case EChildQuest.FinishTrapDefense:
				result = "FinishTrapDefense";
				break;
			case EChildQuest.CheckTrapDefenseEvent:
				result = "CheckTrapDefenseEvent";
				break;
			case EChildQuest.ProgramSpecialProcess:
				result = "ProgramSpecialProcess";
				break;
			case EChildQuest.WaitUntilLevelSequenceReachMark:
				result = "WaitUntilLevelSequenceReachMark";
				break;
			case EChildQuest.FinishSurvivorsRouge:
				result = "FinishSurvivorsRouge";
				break;
			case EChildQuest.TakePicturesWithTimeScale:
				result = "TakePicturesWithTimeScale";
				break;
			case EChildQuest.FinishRollBlock:
				result = "FinishRollBlock";
				break;
			case EChildQuest.ReadPhoneMessage:
				result = "ReadPhoneMessage";
				break;
			case EChildQuest.ListenToEvent:
				result = "ListenToEvent";
				break;
			case EChildQuest.AtomicProcess:
				result = "AtomicProcess";
				break;
			case EChildQuest.UseWeatherSwitch:
				result = "UseWeatherSwitch";
				break;
			case EChildQuest.FinishRhythmSpaceship:
				result = "FinishRhythmSpaceship";
				break;
			case EChildQuest.FinishFlipper:
				result = "FinishFlipper";
				break;
			case EChildQuest.FinishKurotato:
				result = "FinishKurotato";
				break;
			case EChildQuest.FinishRoleTower:
				result = "FinishRoleTower";
				break;
			case EChildQuest.CheckSpringFestivalGameplayCompleted:
				result = "CheckSpringFestivalGameplayCompleted";
				break;
			case EChildQuest.FinishTetris:
				result = "FinishTetris";
				break;
			case EChildQuest.FinishArcadeGameplay:
				result = "FinishArcadeGameplay";
				break;
			case EChildQuest.FinishKuroSimpleCombatKillMonster:
				result = "FinishKuroSimpleCombatKillMonster";
				break;
			case EChildQuest.CrossSceneSyncKillMonster:
				result = "CrossSceneSyncKillMonster";
				break;
			case EChildQuest.PlaybackShowTimeline:
				result = "PlaybackShowTimeline";
				break;
			case EChildQuest.FinishJellyfishReturn:
				result = "FinishJellyfishReturn";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x000FBC3C File Offset: 0x000F9E3C
		public static EChildQuest FromString(string name)
		{
			EChildQuest result;
			if (!EChildQuestExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EChildQuest 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600698A RID: 27018 RVA: 0x000FBC68 File Offset: 0x000F9E68
		public static bool TryFromString(string name, out EChildQuest value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EChildQuest.DoInteract;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 4:
					if (name == "Kill")
					{
						value = EChildQuest.Kill;
						return true;
					}
					break;
				case 5:
				{
					char c = name[0];
					if (c != 'G')
					{
						if (c == 'T')
						{
							if (name == "Timer")
							{
								value = EChildQuest.Timer;
								return true;
							}
						}
					}
					else if (name == "Guide")
					{
						value = EChildQuest.Guide;
						return true;
					}
					break;
				}
				case 6:
					if (name == "ShowUi")
					{
						value = EChildQuest.ShowUi;
						return true;
					}
					break;
				case 7:
				{
					char c = name[0];
					if (c != 'G')
					{
						if (c != 'P')
						{
							if (c == 'U')
							{
								if (name == "UseItem")
								{
									value = EChildQuest.UseItem;
									return true;
								}
							}
						}
						else if (name == "Parkour")
						{
							value = EChildQuest.Parkour;
							return true;
						}
					}
					else if (name == "GetItem")
					{
						value = EChildQuest.GetItem;
						return true;
					}
					break;
				}
				case 8:
				{
					char c = name[0];
					if (c <= 'P')
					{
						if (c != 'G')
						{
							if (c == 'P')
							{
								if (name == "PlayFlow")
								{
									value = EChildQuest.PlayFlow;
									return true;
								}
							}
						}
						else if (name == "GetSkill")
						{
							value = EChildQuest.GetSkill;
							return true;
						}
					}
					else if (c != 'R')
					{
						if (c != 'U')
						{
							if (c == 'W')
							{
								if (name == "WaitTime")
								{
									value = EChildQuest.WaitTime;
									return true;
								}
							}
						}
						else if (name == "UseSkill")
						{
							value = EChildQuest.UseSkill;
							return true;
						}
					}
					else if (name == "ReadMail")
					{
						value = EChildQuest.ReadMail;
						return true;
					}
					break;
				}
				case 9:
				{
					char c = name[0];
					if (c != 'R')
					{
						if (c == 'T')
						{
							if (name == "TakePhoto")
							{
								value = EChildQuest.TakePhoto;
								return true;
							}
						}
					}
					else if (name == "ReachArea")
					{
						value = EChildQuest.ReachArea;
						return true;
					}
					break;
				}
				case 10:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c != 'D')
						{
							if (c == 'T')
							{
								if (name == "TakePhoto2")
								{
									value = EChildQuest.TakePhoto2;
									return true;
								}
							}
						}
						else if (name == "DoInteract")
						{
							value = EChildQuest.DoInteract;
							return true;
						}
					}
					else if (name == "CompareVar")
					{
						value = EChildQuest.CompareVar;
						return true;
					}
					break;
				}
				case 11:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c == 'H')
						{
							if (name == "HandInItems")
							{
								value = EChildQuest.HandInItems;
								return true;
							}
						}
					}
					else if (name == "CheckUiGame")
					{
						value = EChildQuest.CheckUiGame;
						return true;
					}
					break;
				}
				case 12:
				{
					char c = name[0];
					if (c <= 'F')
					{
						if (c != 'E')
						{
							if (c == 'F')
							{
								if (name == "FinishTetris")
								{
									value = EChildQuest.FinishTetris;
									return true;
								}
							}
						}
						else if (name == "EnterDungeon")
						{
							value = EChildQuest.EnterDungeon;
							return true;
						}
					}
					else if (c != 'L')
					{
						if (c != 'S')
						{
							if (c == 'V')
							{
								if (name == "VisionSystem")
								{
									value = EChildQuest.VisionSystem;
									return true;
								}
							}
						}
						else if (name == "ScheduleTime")
						{
							value = EChildQuest.ScheduleTime;
							return true;
						}
					}
					else if (name == "LeaveDungeon")
					{
						value = EChildQuest.LeaveDungeon;
						return true;
					}
					break;
				}
				case 13:
				{
					char c = name[6];
					if (c <= 'F')
					{
						if (c != 'D')
						{
							if (c == 'F')
							{
								if (name == "FinishFlipper")
								{
									value = EChildQuest.FinishFlipper;
									return true;
								}
							}
						}
						else if (name == "FinishDungeon")
						{
							value = EChildQuest.FinishDungeon;
							return true;
						}
					}
					else if (c != 'P')
					{
						if (c != 'T')
						{
							if (c == 'a')
							{
								if (name == "ParallaxAlign")
								{
									value = EChildQuest.ParallaxAlign;
									return true;
								}
							}
						}
						else if (name == "ListenToEvent")
						{
							value = EChildQuest.ListenToEvent;
							return true;
						}
					}
					else if (name == "AtomicProcess")
					{
						value = EChildQuest.AtomicProcess;
						return true;
					}
					break;
				}
				case 14:
				{
					char c = name[0];
					if (c <= 'M')
					{
						if (c != 'C')
						{
							if (c != 'F')
							{
								if (c == 'M')
								{
									if (name == "MonsterCreator")
									{
										value = EChildQuest.MonsterCreator;
										return true;
									}
								}
							}
							else if (name == "FinishKurotato")
							{
								value = EChildQuest.FinishKurotato;
								return true;
							}
						}
						else if (name == "CheckLevelPlay")
						{
							value = EChildQuest.CheckLevelPlay;
							return true;
						}
					}
					else if (c != 'N')
					{
						if (c != 'R')
						{
							if (c == 'W')
							{
								if (name == "WalkingPattern")
								{
									value = EChildQuest.WalkingPattern;
									return true;
								}
							}
						}
						else if (name == "ReceiveTelecom")
						{
							value = EChildQuest.ReceiveTelecom;
							return true;
						}
					}
					else if (name == "NewHandInItems")
					{
						value = EChildQuest.NewHandInItems;
						return true;
					}
					break;
				}
				case 15:
				{
					char c = name[9];
					if (c != 'e')
					{
						if (c != 'l')
						{
							if (c == 't')
							{
								if (name == "CompareActorVar")
								{
									value = EChildQuest.CompareActorVar;
									return true;
								}
							}
						}
						else if (name == "FinishRollBlock")
						{
							value = EChildQuest.FinishRollBlock;
							return true;
						}
					}
					else if (name == "FinishRoleTower")
					{
						value = EChildQuest.FinishRoleTower;
						return true;
					}
					break;
				}
				case 16:
				{
					char c = name[5];
					if (c <= 'P')
					{
						if (c != 'E')
						{
							if (c == 'P')
							{
								if (name == "CheckPlayerInput")
								{
									value = EChildQuest.CheckPlayerInput;
									return true;
								}
							}
						}
						else if (name == "CheckEntityState")
						{
							value = EChildQuest.CheckEntityState;
							return true;
						}
					}
					else if (c != 'a')
					{
						if (c == 'h')
						{
							if (name == "ReadPhoneMessage")
							{
								value = EChildQuest.ReadPhoneMessage;
								return true;
							}
						}
					}
					else if (name == "UseWeatherSwitch")
					{
						value = EChildQuest.UseWeatherSwitch;
						return true;
					}
					break;
				}
				case 17:
				{
					char c = name[0];
					if (c != 'D')
					{
						if (c == 'F')
						{
							if (name == "FinishTrapDefense")
							{
								value = EChildQuest.FinishTrapDefense;
								return true;
							}
						}
					}
					else if (name == "DetectCombatState")
					{
						value = EChildQuest.DetectCombatState;
						return true;
					}
					break;
				}
				case 18:
					switch (name[0])
					{
					case 'A':
						if (name == "AwakeAndLoadEntity")
						{
							value = EChildQuest.AwakeAndLoadEntity;
							return true;
						}
						break;
					case 'C':
						if (name == "CheckActivityState")
						{
							value = EChildQuest.CheckActivityState;
							return true;
						}
						break;
					case 'D':
						if (name == "DetectCombatState2")
						{
							value = EChildQuest.DetectCombatState2;
							return true;
						}
						break;
					case 'F':
						if (name == "FinishBvbChallenge")
						{
							value = EChildQuest.FinishBvbChallenge;
							return true;
						}
						break;
					}
					break;
				case 19:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c == 'W')
						{
							if (name == "WaitBattleCondition")
							{
								value = EChildQuest.WaitBattleCondition;
								return true;
							}
						}
					}
					else if (name == "CheckConditionGroup")
					{
						value = EChildQuest.CheckConditionGroup;
						return true;
					}
					break;
				}
				case 20:
				{
					char c = name[6];
					if (c <= 'S')
					{
						if (c != 'A')
						{
							if (c == 'S')
							{
								if (name == "FinishSurvivorsRouge")
								{
									value = EChildQuest.FinishSurvivorsRouge;
									return true;
								}
							}
						}
						else if (name == "FinishArcadeGameplay")
						{
							value = EChildQuest.FinishArcadeGameplay;
							return true;
						}
					}
					else if (c != 'a')
					{
						if (c == 'c')
						{
							if (name == "PlaybackShowTimeline")
							{
								value = EChildQuest.PlaybackShowTimeline;
								return true;
							}
						}
					}
					else if (name == "InformationViewCheck")
					{
						value = EChildQuest.InformationViewCheck;
						return true;
					}
					break;
				}
				case 21:
				{
					char c = name[6];
					if (c <= 'R')
					{
						if (c != 'J')
						{
							if (c == 'R')
							{
								if (name == "FinishRhythmSpaceship")
								{
									value = EChildQuest.FinishRhythmSpaceship;
									return true;
								}
							}
						}
						else if (name == "FinishJellyfishReturn")
						{
							value = EChildQuest.FinishJellyfishReturn;
							return true;
						}
					}
					else if (c != 'm')
					{
						if (c == 'r')
						{
							if (name == "CheckTrapDefenseEvent")
							{
								value = EChildQuest.CheckTrapDefenseEvent;
								return true;
							}
						}
					}
					else if (name == "ProgramSpecialProcess")
					{
						value = EChildQuest.ProgramSpecialProcess;
						return true;
					}
					break;
				}
				case 25:
				{
					char c = name[1];
					if (c != 'a')
					{
						if (c != 'h')
						{
							if (c == 'r')
							{
								if (name == "CrossSceneSyncKillMonster")
								{
									value = EChildQuest.CrossSceneSyncKillMonster;
									return true;
								}
							}
						}
						else if (name == "CheckClientConditionGroup")
						{
							value = EChildQuest.CheckClientConditionGroup;
							return true;
						}
					}
					else if (name == "TakePicturesWithTimeScale")
					{
						value = EChildQuest.TakePicturesWithTimeScale;
						return true;
					}
					break;
				}
				case 26:
					if (name == "CheckTargetBattleAttribute")
					{
						value = EChildQuest.CheckTargetBattleAttribute;
						return true;
					}
					break;
				case 31:
					if (name == "WaitUntilLevelSequenceReachMark")
					{
						value = EChildQuest.WaitUntilLevelSequenceReachMark;
						return true;
					}
					break;
				case 33:
					if (name == "FinishKuroSimpleCombatKillMonster")
					{
						value = EChildQuest.FinishKuroSimpleCombatKillMonster;
						return true;
					}
					break;
				case 36:
					if (name == "CheckSpringFestivalGameplayCompleted")
					{
						value = EChildQuest.CheckSpringFestivalGameplayCompleted;
						return true;
					}
					break;
				}
			}
			value = EChildQuest.DoInteract;
			return false;
		}

		// Token: 0x0600698B RID: 27019 RVA: 0x000FC6F4 File Offset: 0x000FA8F4
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DoInteract",
				"ReachArea",
				"Kill",
				"GetItem",
				"UseSkill",
				"GetSkill",
				"PlayFlow",
				"DetectCombatState",
				"Parkour",
				"Timer",
				"HandInItems",
				"NewHandInItems",
				"MonsterCreator",
				"InformationViewCheck",
				"UseItem",
				"CheckEntityState",
				"CheckLevelPlay",
				"CheckUiGame",
				"FinishDungeon",
				"WaitTime",
				"ScheduleTime",
				"ReadMail",
				"Guide",
				"EnterDungeon",
				"LeaveDungeon",
				"CheckTargetBattleAttribute",
				"WaitBattleCondition",
				"CompareVar",
				"CompareActorVar",
				"ReceiveTelecom",
				"ShowUi",
				"TakePhoto",
				"TakePhoto2",
				"VisionSystem",
				"ParallaxAlign",
				"CheckConditionGroup",
				"CheckClientConditionGroup",
				"CheckActivityState",
				"CheckPlayerInput",
				"AwakeAndLoadEntity",
				"WalkingPattern",
				"DetectCombatState2",
				"FinishBvbChallenge",
				"FinishTrapDefense",
				"CheckTrapDefenseEvent",
				"ProgramSpecialProcess",
				"WaitUntilLevelSequenceReachMark",
				"FinishSurvivorsRouge",
				"TakePicturesWithTimeScale",
				"FinishRollBlock",
				"ReadPhoneMessage",
				"ListenToEvent",
				"AtomicProcess",
				"UseWeatherSwitch",
				"FinishRhythmSpaceship",
				"FinishFlipper",
				"FinishKurotato",
				"FinishRoleTower",
				"CheckSpringFestivalGameplayCompleted",
				"FinishTetris",
				"FinishArcadeGameplay",
				"FinishKuroSimpleCombatKillMonster",
				"CrossSceneSyncKillMonster",
				"PlaybackShowTimeline",
				"FinishJellyfishReturn"
			};
		}

		// Token: 0x0600698C RID: 27020 RVA: 0x000FC948 File Offset: 0x000FAB48
		public static EChildQuest[] GetValues()
		{
			return new EChildQuest[]
			{
				EChildQuest.DoInteract,
				EChildQuest.ReachArea,
				EChildQuest.Kill,
				EChildQuest.GetItem,
				EChildQuest.UseSkill,
				EChildQuest.GetSkill,
				EChildQuest.PlayFlow,
				EChildQuest.DetectCombatState,
				EChildQuest.Parkour,
				EChildQuest.Timer,
				EChildQuest.HandInItems,
				EChildQuest.NewHandInItems,
				EChildQuest.MonsterCreator,
				EChildQuest.InformationViewCheck,
				EChildQuest.UseItem,
				EChildQuest.CheckEntityState,
				EChildQuest.CheckLevelPlay,
				EChildQuest.CheckUiGame,
				EChildQuest.FinishDungeon,
				EChildQuest.WaitTime,
				EChildQuest.ScheduleTime,
				EChildQuest.ReadMail,
				EChildQuest.Guide,
				EChildQuest.EnterDungeon,
				EChildQuest.LeaveDungeon,
				EChildQuest.CheckTargetBattleAttribute,
				EChildQuest.WaitBattleCondition,
				EChildQuest.CompareVar,
				EChildQuest.CompareActorVar,
				EChildQuest.ReceiveTelecom,
				EChildQuest.ShowUi,
				EChildQuest.TakePhoto,
				EChildQuest.TakePhoto2,
				EChildQuest.VisionSystem,
				EChildQuest.ParallaxAlign,
				EChildQuest.CheckConditionGroup,
				EChildQuest.CheckClientConditionGroup,
				EChildQuest.CheckActivityState,
				EChildQuest.CheckPlayerInput,
				EChildQuest.AwakeAndLoadEntity,
				EChildQuest.WalkingPattern,
				EChildQuest.DetectCombatState2,
				EChildQuest.FinishBvbChallenge,
				EChildQuest.FinishTrapDefense,
				EChildQuest.CheckTrapDefenseEvent,
				EChildQuest.ProgramSpecialProcess,
				EChildQuest.WaitUntilLevelSequenceReachMark,
				EChildQuest.FinishSurvivorsRouge,
				EChildQuest.TakePicturesWithTimeScale,
				EChildQuest.FinishRollBlock,
				EChildQuest.ReadPhoneMessage,
				EChildQuest.ListenToEvent,
				EChildQuest.AtomicProcess,
				EChildQuest.UseWeatherSwitch,
				EChildQuest.FinishRhythmSpaceship,
				EChildQuest.FinishFlipper,
				EChildQuest.FinishKurotato,
				EChildQuest.FinishRoleTower,
				EChildQuest.CheckSpringFestivalGameplayCompleted,
				EChildQuest.FinishTetris,
				EChildQuest.FinishArcadeGameplay,
				EChildQuest.FinishKuroSimpleCombatKillMonster,
				EChildQuest.CrossSceneSyncKillMonster,
				EChildQuest.PlaybackShowTimeline,
				EChildQuest.FinishJellyfishReturn
			};
		}

		// Token: 0x0600698D RID: 27021 RVA: 0x000FC95C File Offset: 0x000FAB5C
		public static string[] GetNames()
		{
			return new string[]
			{
				"DoInteract",
				"ReachArea",
				"Kill",
				"GetItem",
				"UseSkill",
				"GetSkill",
				"PlayFlow",
				"DetectCombatState",
				"Parkour",
				"Timer",
				"HandInItems",
				"NewHandInItems",
				"MonsterCreator",
				"InformationViewCheck",
				"UseItem",
				"CheckEntityState",
				"CheckLevelPlay",
				"CheckUiGame",
				"FinishDungeon",
				"WaitTime",
				"ScheduleTime",
				"ReadMail",
				"Guide",
				"EnterDungeon",
				"LeaveDungeon",
				"CheckTargetBattleAttribute",
				"WaitBattleCondition",
				"CompareVar",
				"CompareActorVar",
				"ReceiveTelecom",
				"ShowUi",
				"TakePhoto",
				"TakePhoto2",
				"VisionSystem",
				"ParallaxAlign",
				"CheckConditionGroup",
				"CheckClientConditionGroup",
				"CheckActivityState",
				"CheckPlayerInput",
				"AwakeAndLoadEntity",
				"WalkingPattern",
				"DetectCombatState2",
				"FinishBvbChallenge",
				"FinishTrapDefense",
				"CheckTrapDefenseEvent",
				"ProgramSpecialProcess",
				"WaitUntilLevelSequenceReachMark",
				"FinishSurvivorsRouge",
				"TakePicturesWithTimeScale",
				"FinishRollBlock",
				"ReadPhoneMessage",
				"ListenToEvent",
				"AtomicProcess",
				"UseWeatherSwitch",
				"FinishRhythmSpaceship",
				"FinishFlipper",
				"FinishKurotato",
				"FinishRoleTower",
				"CheckSpringFestivalGameplayCompleted",
				"FinishTetris",
				"FinishArcadeGameplay",
				"FinishKuroSimpleCombatKillMonster",
				"CrossSceneSyncKillMonster",
				"PlaybackShowTimeline",
				"FinishJellyfishReturn"
			};
		}
	}
}
