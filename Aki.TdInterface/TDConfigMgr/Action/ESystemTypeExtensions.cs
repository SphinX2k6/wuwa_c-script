using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200244D RID: 9293
	public static class ESystemTypeExtensions
	{
		// Token: 0x0600C9D9 RID: 51673 RVA: 0x001D8B90 File Offset: 0x001D6D90
		public static string ToEnumString(this ESystemType value)
		{
			string result;
			switch (value)
			{
			case ESystemType.Shop:
				result = "Shop";
				break;
			case ESystemType.RegionQuest:
				result = "RegionQuest";
				break;
			case ESystemType.ContributionLevel:
				result = "ContributionLevel";
				break;
			case ESystemType.InstanceEntrance:
				result = "InstanceEntrance";
				break;
			case ESystemType.MingSuTi:
				result = "MingSuTi";
				break;
			case ESystemType.InformationView:
				result = "InformationView";
				break;
			case ESystemType.DailyQuest:
				result = "DailyQuest";
				break;
			case ESystemType.Cook:
				result = "Cook";
				break;
			case ESystemType.FixCook:
				result = "FixCook";
				break;
			case ESystemType.Synthetic:
				result = "Synthetic";
				break;
			case ESystemType.Forging:
				result = "Forging";
				break;
			case ESystemType.Expostulation:
				result = "Expostulation";
				break;
			case ESystemType.RoleDescription:
				result = "RoleDescription";
				break;
			case ESystemType.TrialRoleDescription:
				result = "TrialRoleDescription";
				break;
			case ESystemType.RogueAbilitySelect:
				result = "RogueAbilitySelect";
				break;
			case ESystemType.RogueShop:
				result = "RogueShop";
				break;
			case ESystemType.RogueRandomEvent:
				result = "RogueRandomEvent";
				break;
			case ESystemType.RogueActivityIntroduce:
				result = "RogueActivityIntroduce";
				break;
			case ESystemType.RogueSettlement:
				result = "RogueSettlement";
				break;
			case ESystemType.RogueTowerTrial:
				result = "RogueTowerTrial";
				break;
			case ESystemType.GameSysOpen:
				result = "GameSysOpen";
				break;
			case ESystemType.TurntableControl:
				result = "TurntableControl";
				break;
			case ESystemType.InstanceFailure:
				result = "InstanceFailure";
				break;
			case ESystemType.FeedingPets:
				result = "FeedingPets";
				break;
			case ESystemType.SoundAreaPlayInfo:
				result = "SoundAreaPlayInfo";
				break;
			case ESystemType.LordChallenge:
				result = "LordChallenge";
				break;
			case ESystemType.ExploreLevelView:
				result = "ExploreLevelView";
				break;
			case ESystemType.ConfirmBox:
				result = "ConfirmBox";
				break;
			case ESystemType.ConfirmBox2:
				result = "ConfirmBox2";
				break;
			case ESystemType.ActivityIntroduce:
				result = "ActivityIntroduce";
				break;
			case ESystemType.ActivitySubInterface:
				result = "ActivitySubInterface";
				break;
			case ESystemType.Photograph:
				result = "Photograph";
				break;
			case ESystemType.DigitalScreen:
				result = "DigitalScreen";
				break;
			case ESystemType.ChasingMoonMain:
				result = "ChasingMoonMain";
				break;
			case ESystemType.Gramophone:
				result = "Gramophone";
				break;
			case ESystemType.DreamLink:
				result = "DreamLink";
				break;
			case ESystemType.MowBuffDistribute:
				result = "MowBuffDistribute";
				break;
			case ESystemType.ScratchTicket:
				result = "ScratchTicket";
				break;
			case ESystemType.PreheatingCheckIn:
				result = "PreheatingCheckIn";
				break;
			case ESystemType.MowingTowerActivity:
				result = "MowingTowerActivity";
				break;
			case ESystemType.SoaringChallenge:
				result = "SoaringChallenge";
				break;
			case ESystemType.MotorRaceChallenge:
				result = "MotorRaceChallenge";
				break;
			case ESystemType.PhotoMemoryTopic:
				result = "PhotoMemoryTopic";
				break;
			case ESystemType.LordGymEntrance:
				result = "LordGymEntrance";
				break;
			case ESystemType.RaidReportSettlement:
				result = "RaidReportSettlement";
				break;
			case ESystemType.HideLordOpen:
				result = "HideLordOpen";
				break;
			case ESystemType.FishingDock:
				result = "FishingDock";
				break;
			case ESystemType.FishingCage:
				result = "FishingCage";
				break;
			case ESystemType.FishingItemDelivery:
				result = "FishingItemDelivery";
				break;
			case ESystemType.RogueTokenSelect:
				result = "RogueTokenSelect";
				break;
			case ESystemType.SlashAndTower:
				result = "SlashAndTower";
				break;
			case ESystemType.BossRushPlayInfo:
				result = "BossRushPlayInfo";
				break;
			case ESystemType.GravityFlipControl:
				result = "GravityFlipControl";
				break;
			case ESystemType.PermanentRogueAbilitySelect:
				result = "PermanentRogueAbilitySelect";
				break;
			case ESystemType.PermanentRogueShop:
				result = "PermanentRogueShop";
				break;
			case ESystemType.PermanentRogueRandomEvent:
				result = "PermanentRogueRandomEvent";
				break;
			case ESystemType.PermanentRogueActivityIntroduce:
				result = "PermanentRogueActivityIntroduce";
				break;
			case ESystemType.PermanentRogueSettlement:
				result = "PermanentRogueSettlement";
				break;
			case ESystemType.PermanentRogueTokenSelect:
				result = "PermanentRogueTokenSelect";
				break;
			case ESystemType.CiacconaAvgSystemBoard:
				result = "CiacconaAvgSystemBoard";
				break;
			case ESystemType.CiacconaAvgChapterBoard:
				result = "CiacconaAvgChapterBoard";
				break;
			case ESystemType.DangoAbyssActivity:
				result = "DangoAbyssActivity";
				break;
			case ESystemType.PhantomBattleChallenge:
				result = "PhantomBattleChallenge";
				break;
			case ESystemType.CoBathing:
				result = "CoBathing";
				break;
			case ESystemType.PlotReview:
				result = "PlotReview";
				break;
			case ESystemType.PlotReviewJumpTips:
				result = "PlotReviewJumpTips";
				break;
			case ESystemType.MoraleSystem:
				result = "MoraleSystem";
				break;
			case ESystemType.LifePointChallenge:
				result = "LifePointChallenge";
				break;
			case ESystemType.GreatSwordChallenge:
				result = "GreatSwordChallenge";
				break;
			case ESystemType.TrapDefenseMapChange:
				result = "TrapDefenseMapChange";
				break;
			case ESystemType.HonamiStorySafeBag:
				result = "HonamiStorySafeBag";
				break;
			case ESystemType.HonamiStoryFightPreparation:
				result = "HonamiStoryFightPreparation";
				break;
			case ESystemType.HonamiStoryMascot:
				result = "HonamiStoryMascot";
				break;
			case ESystemType.HonamiStoryTalentTree:
				result = "HonamiStoryTalentTree";
				break;
			case ESystemType.HonamiStoryResourceStation:
				result = "HonamiStoryResourceStation";
				break;
			case ESystemType.HonamiStoryChooseLevel:
				result = "HonamiStoryChooseLevel";
				break;
			case ESystemType.HonamiStoryWareHouse:
				result = "HonamiStoryWareHouse";
				break;
			case ESystemType.FindBug:
				result = "FindBug";
				break;
			case ESystemType.InfrastructureItemDelivery:
				result = "InfrastructureItemDelivery";
				break;
			case ESystemType.SurvivorsGameplay:
				result = "SurvivorsGameplay";
				break;
			case ESystemType.PhotographFightActivity:
				result = "PhotographFightActivity";
				break;
			case ESystemType.TransitionPopup:
				result = "TransitionPopup";
				break;
			case ESystemType.InfrActivityFinishInfrastructure:
				result = "InfrActivityFinishInfrastructure";
				break;
			case ESystemType.Enrollment:
				result = "Enrollment";
				break;
			case ESystemType.Motorcycle:
				result = "Motorcycle";
				break;
			case ESystemType.MotorcycleDiy:
				result = "MotorcycleDiy";
				break;
			case ESystemType.Map:
				result = "Map";
				break;
			case ESystemType.AreaTerminalGamePlay:
				result = "AreaTerminalGamePlay";
				break;
			case ESystemType.GuessCardGamePlayView:
				result = "GuessCardGamePlayView";
				break;
			case ESystemType.GuessJokerSelectRoleView:
				result = "GuessJokerSelectRoleView";
				break;
			case ESystemType.ChangePhantomExhibitView:
				result = "ChangePhantomExhibitView";
				break;
			case ESystemType.ChangeWeaponExhibitView:
				result = "ChangeWeaponExhibitView";
				break;
			case ESystemType.DrinksMixDrinksView:
				result = "DrinksMixDrinksView";
				break;
			case ESystemType.DrinksSelectRoleView:
				result = "DrinksSelectRoleView";
				break;
			case ESystemType.FurnitureDiyShop:
				result = "FurnitureDiyShop";
				break;
			case ESystemType.TakePhoto:
				result = "TakePhoto";
				break;
			case ESystemType.SpringFestivalBrochure:
				result = "SpringFestivalBrochure";
				break;
			case ESystemType.SpringFestivalPictureAlbum:
				result = "SpringFestivalPictureAlbum";
				break;
			case ESystemType.PictureCaption:
				result = "PictureCaption";
				break;
			case ESystemType.Coop:
				result = "Coop";
				break;
			case ESystemType.RhythmSpaceshipInMainStory:
				result = "RhythmSpaceshipInMainStory";
				break;
			case ESystemType.DropCatchInMainStory:
				result = "DropCatchInMainStory";
				break;
			case ESystemType.TetrisBoardGameEndlessLevel:
				result = "TetrisBoardGameEndlessLevel";
				break;
			case ESystemType.VillageInfrMainView:
				result = "VillageInfrMainView";
				break;
			case ESystemType.VillageInfrDelivery:
				result = "VillageInfrDelivery";
				break;
			case ESystemType.VillageInfrFinishConstruction:
				result = "VillageInfrFinishConstruction";
				break;
			case ESystemType.InteractiveComic:
				result = "InteractiveComic";
				break;
			case ESystemType.CyberpunkCollaborationVehicleShare:
				result = "CyberpunkCollaborationVehicleShare";
				break;
			case ESystemType.CyberpunkCollaborationVehicleShareInProgress:
				result = "CyberpunkCollaborationVehicleShareInProgress";
				break;
			case ESystemType.QuestBranch:
				result = "QuestBranch";
				break;
			case ESystemType.QuestBranchTips:
				result = "QuestBranchTips";
				break;
			case ESystemType.SheriffCriminalIdentityConfirmed:
				result = "SheriffCriminalIdentityConfirmed";
				break;
			case ESystemType.SheriffAnomaly:
				result = "SheriffAnomaly";
				break;
			case ESystemType.SheriffMainStoryError:
				result = "SheriffMainStoryError";
				break;
			case ESystemType.DollGrabDelivery:
				result = "DollGrabDelivery";
				break;
			case ESystemType.WriteLetter:
				result = "WriteLetter";
				break;
			case ESystemType.MechascoutMindSpaceDungeon:
				result = "MechascoutMindSpaceDungeon";
				break;
			case ESystemType.RoverRogueTrophy:
				result = "RoverRogueTrophy";
				break;
			case ESystemType.FoxFailureTips:
				result = "FoxFailureTips";
				break;
			case ESystemType.GiantDelivery:
				result = "GiantDelivery";
				break;
			case ESystemType.DangoBrawlVictorySettlement:
				result = "DangoBrawlVictorySettlement";
				break;
			case ESystemType.DangoBrawlFailureSettlement:
				result = "DangoBrawlFailureSettlement";
				break;
			case ESystemType.InformationViewPopup:
				result = "InformationViewPopup";
				break;
			case ESystemType.DeliverItemProbeCollectibles:
				result = "DeliverItemProbeCollectibles";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C9DA RID: 51674 RVA: 0x001D92D0 File Offset: 0x001D74D0
		public static ESystemType FromString(string name)
		{
			ESystemType result;
			if (!ESystemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESystemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C9DB RID: 51675 RVA: 0x001D92FC File Offset: 0x001D74FC
		public static bool TryFromString(string name, out ESystemType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESystemType.Shop;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 3:
					if (name == "Map")
					{
						value = ESystemType.Map;
						return true;
					}
					break;
				case 4:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c == 'S')
						{
							if (name == "Shop")
							{
								value = ESystemType.Shop;
								return true;
							}
						}
					}
					else
					{
						if (name == "Cook")
						{
							value = ESystemType.Cook;
							return true;
						}
						if (name == "Coop")
						{
							value = ESystemType.Coop;
							return true;
						}
					}
					break;
				}
				case 7:
				{
					char c = name[2];
					if (c != 'n')
					{
						if (c != 'r')
						{
							if (c == 'x')
							{
								if (name == "FixCook")
								{
									value = ESystemType.FixCook;
									return true;
								}
							}
						}
						else if (name == "Forging")
						{
							value = ESystemType.Forging;
							return true;
						}
					}
					else if (name == "FindBug")
					{
						value = ESystemType.FindBug;
						return true;
					}
					break;
				}
				case 8:
					if (name == "MingSuTi")
					{
						value = ESystemType.MingSuTi;
						return true;
					}
					break;
				case 9:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c != 'D')
						{
							switch (c)
							{
							case 'R':
								if (name == "RogueShop")
								{
									value = ESystemType.RogueShop;
									return true;
								}
								break;
							case 'S':
								if (name == "Synthetic")
								{
									value = ESystemType.Synthetic;
									return true;
								}
								break;
							case 'T':
								if (name == "TakePhoto")
								{
									value = ESystemType.TakePhoto;
									return true;
								}
								break;
							}
						}
						else if (name == "DreamLink")
						{
							value = ESystemType.DreamLink;
							return true;
						}
					}
					else if (name == "CoBathing")
					{
						value = ESystemType.CoBathing;
						return true;
					}
					break;
				}
				case 10:
				{
					char c = name[5];
					if (c <= 'g')
					{
						if (c != 'Q')
						{
							switch (c)
							{
							case 'c':
								if (name == "Motorcycle")
								{
									value = ESystemType.Motorcycle;
									return true;
								}
								break;
							case 'e':
								if (name == "PlotReview")
								{
									value = ESystemType.PlotReview;
									return true;
								}
								break;
							case 'g':
								if (name == "Photograph")
								{
									value = ESystemType.Photograph;
									return true;
								}
								break;
							}
						}
						else if (name == "DailyQuest")
						{
							value = ESystemType.DailyQuest;
							return true;
						}
					}
					else if (c != 'l')
					{
						if (c != 'p')
						{
							if (c == 'r')
							{
								if (name == "ConfirmBox")
								{
									value = ESystemType.ConfirmBox;
									return true;
								}
							}
						}
						else if (name == "Gramophone")
						{
							value = ESystemType.Gramophone;
							return true;
						}
					}
					else if (name == "Enrollment")
					{
						value = ESystemType.Enrollment;
						return true;
					}
					break;
				}
				case 11:
				{
					char c = name[7];
					if (c <= 'P')
					{
						switch (c)
						{
						case 'B':
							if (name == "ConfirmBox2")
							{
								value = ESystemType.ConfirmBox2;
								return true;
							}
							break;
						case 'C':
							if (name == "FishingCage")
							{
								value = ESystemType.FishingCage;
								return true;
							}
							break;
						case 'D':
							if (name == "FishingDock")
							{
								value = ESystemType.FishingDock;
								return true;
							}
							break;
						default:
							if (c != 'O')
							{
								if (c == 'P')
								{
									if (name == "FeedingPets")
									{
										value = ESystemType.FeedingPets;
										return true;
									}
								}
							}
							else if (name == "GameSysOpen")
							{
								value = ESystemType.GameSysOpen;
								return true;
							}
							break;
						}
					}
					else if (c != 'a')
					{
						if (c != 't')
						{
							if (c == 'u')
							{
								if (name == "RegionQuest")
								{
									value = ESystemType.RegionQuest;
									return true;
								}
							}
						}
						else if (name == "WriteLetter")
						{
							value = ESystemType.WriteLetter;
							return true;
						}
					}
					else if (name == "QuestBranch")
					{
						value = ESystemType.QuestBranch;
						return true;
					}
					break;
				}
				case 12:
				{
					char c = name[0];
					if (c != 'H')
					{
						if (c == 'M')
						{
							if (name == "MoraleSystem")
							{
								value = ESystemType.MoraleSystem;
								return true;
							}
						}
					}
					else if (name == "HideLordOpen")
					{
						value = ESystemType.HideLordOpen;
						return true;
					}
					break;
				}
				case 13:
				{
					char c = name[6];
					if (c <= 'h')
					{
						if (c != 'a')
						{
							if (c != 'e')
							{
								if (c == 'h')
								{
									if (name == "ScratchTicket")
									{
										value = ESystemType.ScratchTicket;
										return true;
									}
								}
							}
							else if (name == "GiantDelivery")
							{
								value = ESystemType.GiantDelivery;
								return true;
							}
						}
						else if (name == "LordChallenge")
						{
							value = ESystemType.LordChallenge;
							return true;
						}
					}
					else if (c <= 'n')
					{
						if (c != 'l')
						{
							if (c == 'n')
							{
								if (name == "SlashAndTower")
								{
									value = ESystemType.SlashAndTower;
									return true;
								}
							}
						}
						else if (name == "DigitalScreen")
						{
							value = ESystemType.DigitalScreen;
							return true;
						}
					}
					else if (c != 'u')
					{
						if (c == 'y')
						{
							if (name == "MotorcycleDiy")
							{
								value = ESystemType.MotorcycleDiy;
								return true;
							}
						}
					}
					else if (name == "Expostulation")
					{
						value = ESystemType.Expostulation;
						return true;
					}
					break;
				}
				case 14:
				{
					char c = name[0];
					if (c != 'F')
					{
						if (c != 'P')
						{
							if (c == 'S')
							{
								if (name == "SheriffAnomaly")
								{
									value = ESystemType.SheriffAnomaly;
									return true;
								}
							}
						}
						else if (name == "PictureCaption")
						{
							value = ESystemType.PictureCaption;
							return true;
						}
					}
					else if (name == "FoxFailureTips")
					{
						value = ESystemType.FoxFailureTips;
						return true;
					}
					break;
				}
				case 15:
				{
					char c = name[6];
					switch (c)
					{
					case 'a':
						if (name == "InformationView")
						{
							value = ESystemType.InformationView;
							return true;
						}
						break;
					case 'b':
					case 'd':
					case 'f':
						break;
					case 'c':
						if (name == "InstanceFailure")
						{
							value = ESystemType.InstanceFailure;
							return true;
						}
						break;
					case 'e':
						if (name == "RogueSettlement")
						{
							value = ESystemType.RogueSettlement;
							return true;
						}
						break;
					case 'g':
						if (name == "ChasingMoonMain")
						{
							value = ESystemType.ChasingMoonMain;
							return true;
						}
						break;
					default:
						switch (c)
						{
						case 'm':
							if (name == "LordGymEntrance")
							{
								value = ESystemType.LordGymEntrance;
								return true;
							}
							break;
						case 'o':
							if (name == "RogueTowerTrial")
							{
								value = ESystemType.RogueTowerTrial;
								return true;
							}
							break;
						case 'r':
							if (name == "QuestBranchTips")
							{
								value = ESystemType.QuestBranchTips;
								return true;
							}
							break;
						case 's':
							if (name == "RoleDescription")
							{
								value = ESystemType.RoleDescription;
								return true;
							}
							break;
						case 't':
							if (name == "TransitionPopup")
							{
								value = ESystemType.TransitionPopup;
								return true;
							}
							break;
						}
						break;
					}
					break;
				}
				case 16:
				{
					char c = name[7];
					if (c != 'C')
					{
						if (c != 'L')
						{
							switch (c)
							{
							case 'b':
								if (name == "DollGrabDelivery")
								{
									value = ESystemType.DollGrabDelivery;
									return true;
								}
								break;
							case 'e':
								if (name == "InstanceEntrance")
								{
									value = ESystemType.InstanceEntrance;
									return true;
								}
								break;
							case 'g':
								if (name == "RoverRogueTrophy")
								{
									value = ESystemType.RoverRogueTrophy;
									return true;
								}
								break;
							case 'h':
								if (name == "BossRushPlayInfo")
								{
									value = ESystemType.BossRushPlayInfo;
									return true;
								}
								break;
							case 'k':
								if (name == "RogueTokenSelect")
								{
									value = ESystemType.RogueTokenSelect;
									return true;
								}
								break;
							case 'l':
								if (name == "TurntableControl")
								{
									value = ESystemType.TurntableControl;
									return true;
								}
								break;
							case 'm':
								if (name == "PhotoMemoryTopic")
								{
									value = ESystemType.PhotoMemoryTopic;
									return true;
								}
								break;
							case 'n':
								if (name == "RogueRandomEvent")
								{
									value = ESystemType.RogueRandomEvent;
									return true;
								}
								break;
							case 'r':
								if (name == "FurnitureDiyShop")
								{
									value = ESystemType.FurnitureDiyShop;
									return true;
								}
								break;
							case 't':
								if (name == "InteractiveComic")
								{
									value = ESystemType.InteractiveComic;
									return true;
								}
								break;
							}
						}
						else if (name == "ExploreLevelView")
						{
							value = ESystemType.ExploreLevelView;
							return true;
						}
					}
					else if (name == "SoaringChallenge")
					{
						value = ESystemType.SoaringChallenge;
						return true;
					}
					break;
				}
				case 17:
				{
					char c = name[3];
					if (c <= 'h')
					{
						if (c != 'B')
						{
							if (c != 'a')
							{
								if (c == 'h')
								{
									if (name == "PreheatingCheckIn")
									{
										value = ESystemType.PreheatingCheckIn;
										return true;
									}
								}
							}
							else if (name == "HonamiStoryMascot")
							{
								value = ESystemType.HonamiStoryMascot;
								return true;
							}
						}
						else if (name == "MowBuffDistribute")
						{
							value = ESystemType.MowBuffDistribute;
							return true;
						}
					}
					else if (c <= 'n')
					{
						if (c != 'i')
						{
							if (c == 'n')
							{
								if (name == "SoundAreaPlayInfo")
								{
									value = ESystemType.SoundAreaPlayInfo;
									return true;
								}
							}
						}
						else if (name == "ActivityIntroduce")
						{
							value = ESystemType.ActivityIntroduce;
							return true;
						}
					}
					else if (c != 't')
					{
						if (c == 'v')
						{
							if (name == "SurvivorsGameplay")
							{
								value = ESystemType.SurvivorsGameplay;
								return true;
							}
						}
					}
					else if (name == "ContributionLevel")
					{
						value = ESystemType.ContributionLevel;
						return true;
					}
					break;
				}
				case 18:
				{
					char c = name[3];
					if (c <= 'g')
					{
						if (c != 'a')
						{
							if (c != 'e')
							{
								if (c == 'g')
								{
									if (name == "DangoAbyssActivity")
									{
										value = ESystemType.DangoAbyssActivity;
										return true;
									}
								}
							}
							else if (name == "LifePointChallenge")
							{
								value = ESystemType.LifePointChallenge;
								return true;
							}
						}
						else if (name == "HonamiStorySafeBag")
						{
							value = ESystemType.HonamiStorySafeBag;
							return true;
						}
					}
					else if (c != 'm')
					{
						if (c != 'o')
						{
							switch (c)
							{
							case 't':
								if (name == "PlotReviewJumpTips")
								{
									value = ESystemType.PlotReviewJumpTips;
									return true;
								}
								break;
							case 'u':
								if (name == "RogueAbilitySelect")
								{
									value = ESystemType.RogueAbilitySelect;
									return true;
								}
								break;
							case 'v':
								if (name == "GravityFlipControl")
								{
									value = ESystemType.GravityFlipControl;
									return true;
								}
								break;
							}
						}
						else if (name == "MotorRaceChallenge")
						{
							value = ESystemType.MotorRaceChallenge;
							return true;
						}
					}
					else if (name == "PermanentRogueShop")
					{
						value = ESystemType.PermanentRogueShop;
						return true;
					}
					break;
				}
				case 19:
				{
					char c = name[0];
					switch (c)
					{
					case 'D':
						if (name == "DrinksMixDrinksView")
						{
							value = ESystemType.DrinksMixDrinksView;
							return true;
						}
						break;
					case 'E':
						break;
					case 'F':
						if (name == "FishingItemDelivery")
						{
							value = ESystemType.FishingItemDelivery;
							return true;
						}
						break;
					case 'G':
						if (name == "GreatSwordChallenge")
						{
							value = ESystemType.GreatSwordChallenge;
							return true;
						}
						break;
					default:
						if (c != 'M')
						{
							if (c == 'V')
							{
								if (name == "VillageInfrMainView")
								{
									value = ESystemType.VillageInfrMainView;
									return true;
								}
								if (name == "VillageInfrDelivery")
								{
									value = ESystemType.VillageInfrDelivery;
									return true;
								}
							}
						}
						else if (name == "MowingTowerActivity")
						{
							value = ESystemType.MowingTowerActivity;
							return true;
						}
						break;
					}
					break;
				}
				case 20:
				{
					char c = name[4];
					if (c <= 'R')
					{
						if (c != 'C')
						{
							if (c != 'D')
							{
								if (c == 'R')
								{
									if (name == "RaidReportSettlement")
									{
										value = ESystemType.RaidReportSettlement;
										return true;
									}
								}
							}
							else if (name == "TrapDefenseMapChange")
							{
								value = ESystemType.TrapDefenseMapChange;
								return true;
							}
						}
						else if (name == "DropCatchInMainStory")
						{
							value = ESystemType.DropCatchInMainStory;
							return true;
						}
					}
					else if (c <= 'm')
					{
						if (c != 'T')
						{
							switch (c)
							{
							case 'k':
								if (name == "DrinksSelectRoleView")
								{
									value = ESystemType.DrinksSelectRoleView;
									return true;
								}
								break;
							case 'l':
								if (name == "TrialRoleDescription")
								{
									value = ESystemType.TrialRoleDescription;
									return true;
								}
								break;
							case 'm':
								if (name == "HonamiStoryWareHouse")
								{
									value = ESystemType.HonamiStoryWareHouse;
									return true;
								}
								break;
							}
						}
						else if (name == "AreaTerminalGamePlay")
						{
							value = ESystemType.AreaTerminalGamePlay;
							return true;
						}
					}
					else if (c != 'r')
					{
						if (c == 'v')
						{
							if (name == "ActivitySubInterface")
							{
								value = ESystemType.ActivitySubInterface;
								return true;
							}
						}
					}
					else if (name == "InformationViewPopup")
					{
						value = ESystemType.InformationViewPopup;
						return true;
					}
					break;
				}
				case 21:
				{
					char c = name[0];
					if (c != 'G')
					{
						if (c != 'H')
						{
							if (c == 'S')
							{
								if (name == "SheriffMainStoryError")
								{
									value = ESystemType.SheriffMainStoryError;
									return true;
								}
							}
						}
						else if (name == "HonamiStoryTalentTree")
						{
							value = ESystemType.HonamiStoryTalentTree;
							return true;
						}
					}
					else if (name == "GuessCardGamePlayView")
					{
						value = ESystemType.GuessCardGamePlayView;
						return true;
					}
					break;
				}
				case 22:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c != 'H')
						{
							switch (c)
							{
							case 'P':
								if (name == "PhantomBattleChallenge")
								{
									value = ESystemType.PhantomBattleChallenge;
									return true;
								}
								break;
							case 'R':
								if (name == "RogueActivityIntroduce")
								{
									value = ESystemType.RogueActivityIntroduce;
									return true;
								}
								break;
							case 'S':
								if (name == "SpringFestivalBrochure")
								{
									value = ESystemType.SpringFestivalBrochure;
									return true;
								}
								break;
							}
						}
						else if (name == "HonamiStoryChooseLevel")
						{
							value = ESystemType.HonamiStoryChooseLevel;
							return true;
						}
					}
					else if (name == "CiacconaAvgSystemBoard")
					{
						value = ESystemType.CiacconaAvgSystemBoard;
						return true;
					}
					break;
				}
				case 23:
				{
					char c = name[3];
					if (c != 'c')
					{
						if (c != 'n')
						{
							if (c == 't')
							{
								if (name == "PhotographFightActivity")
								{
									value = ESystemType.PhotographFightActivity;
									return true;
								}
							}
						}
						else if (name == "ChangeWeaponExhibitView")
						{
							value = ESystemType.ChangeWeaponExhibitView;
							return true;
						}
					}
					else if (name == "CiacconaAvgChapterBoard")
					{
						value = ESystemType.CiacconaAvgChapterBoard;
						return true;
					}
					break;
				}
				case 24:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c != 'G')
						{
							if (c == 'P')
							{
								if (name == "PermanentRogueSettlement")
								{
									value = ESystemType.PermanentRogueSettlement;
									return true;
								}
							}
						}
						else if (name == "GuessJokerSelectRoleView")
						{
							value = ESystemType.GuessJokerSelectRoleView;
							return true;
						}
					}
					else if (name == "ChangePhantomExhibitView")
					{
						value = ESystemType.ChangePhantomExhibitView;
						return true;
					}
					break;
				}
				case 25:
				{
					char c = name[14];
					if (c != 'R')
					{
						if (c == 'T')
						{
							if (name == "PermanentRogueTokenSelect")
							{
								value = ESystemType.PermanentRogueTokenSelect;
								return true;
							}
						}
					}
					else if (name == "PermanentRogueRandomEvent")
					{
						value = ESystemType.PermanentRogueRandomEvent;
						return true;
					}
					break;
				}
				case 26:
				{
					char c = name[0];
					if (c <= 'I')
					{
						if (c != 'H')
						{
							if (c == 'I')
							{
								if (name == "InfrastructureItemDelivery")
								{
									value = ESystemType.InfrastructureItemDelivery;
									return true;
								}
							}
						}
						else if (name == "HonamiStoryResourceStation")
						{
							value = ESystemType.HonamiStoryResourceStation;
							return true;
						}
					}
					else if (c != 'M')
					{
						if (c != 'R')
						{
							if (c == 'S')
							{
								if (name == "SpringFestivalPictureAlbum")
								{
									value = ESystemType.SpringFestivalPictureAlbum;
									return true;
								}
							}
						}
						else if (name == "RhythmSpaceshipInMainStory")
						{
							value = ESystemType.RhythmSpaceshipInMainStory;
							return true;
						}
					}
					else if (name == "MechascoutMindSpaceDungeon")
					{
						value = ESystemType.MechascoutMindSpaceDungeon;
						return true;
					}
					break;
				}
				case 27:
				{
					char c = name[10];
					if (c <= 'V')
					{
						if (c != 'F')
						{
							if (c == 'V')
							{
								if (name == "DangoBrawlVictorySettlement")
								{
									value = ESystemType.DangoBrawlVictorySettlement;
									return true;
								}
							}
						}
						else if (name == "DangoBrawlFailureSettlement")
						{
							value = ESystemType.DangoBrawlFailureSettlement;
							return true;
						}
					}
					else if (c != 'd')
					{
						if (c != 'o')
						{
							if (c == 'y')
							{
								if (name == "HonamiStoryFightPreparation")
								{
									value = ESystemType.HonamiStoryFightPreparation;
									return true;
								}
							}
						}
						else if (name == "PermanentRogueAbilitySelect")
						{
							value = ESystemType.PermanentRogueAbilitySelect;
							return true;
						}
					}
					else if (name == "TetrisBoardGameEndlessLevel")
					{
						value = ESystemType.TetrisBoardGameEndlessLevel;
						return true;
					}
					break;
				}
				case 28:
					if (name == "DeliverItemProbeCollectibles")
					{
						value = ESystemType.DeliverItemProbeCollectibles;
						return true;
					}
					break;
				case 29:
					if (name == "VillageInfrFinishConstruction")
					{
						value = ESystemType.VillageInfrFinishConstruction;
						return true;
					}
					break;
				case 31:
					if (name == "PermanentRogueActivityIntroduce")
					{
						value = ESystemType.PermanentRogueActivityIntroduce;
						return true;
					}
					break;
				case 32:
				{
					char c = name[0];
					if (c != 'I')
					{
						if (c == 'S')
						{
							if (name == "SheriffCriminalIdentityConfirmed")
							{
								value = ESystemType.SheriffCriminalIdentityConfirmed;
								return true;
							}
						}
					}
					else if (name == "InfrActivityFinishInfrastructure")
					{
						value = ESystemType.InfrActivityFinishInfrastructure;
						return true;
					}
					break;
				}
				case 34:
					if (name == "CyberpunkCollaborationVehicleShare")
					{
						value = ESystemType.CyberpunkCollaborationVehicleShare;
						return true;
					}
					break;
				case 44:
					if (name == "CyberpunkCollaborationVehicleShareInProgress")
					{
						value = ESystemType.CyberpunkCollaborationVehicleShareInProgress;
						return true;
					}
					break;
				}
			}
			value = ESystemType.Shop;
			return false;
		}

		// Token: 0x0600C9DC RID: 51676 RVA: 0x001DA60C File Offset: 0x001D880C
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Shop",
				"RegionQuest",
				"ContributionLevel",
				"InstanceEntrance",
				"MingSuTi",
				"InformationView",
				"DailyQuest",
				"Cook",
				"FixCook",
				"Synthetic",
				"Forging",
				"Expostulation",
				"RoleDescription",
				"TrialRoleDescription",
				"RogueAbilitySelect",
				"RogueShop",
				"RogueRandomEvent",
				"RogueActivityIntroduce",
				"RogueSettlement",
				"RogueTowerTrial",
				"GameSysOpen",
				"TurntableControl",
				"InstanceFailure",
				"FeedingPets",
				"SoundAreaPlayInfo",
				"LordChallenge",
				"ExploreLevelView",
				"ConfirmBox",
				"ConfirmBox2",
				"ActivityIntroduce",
				"ActivitySubInterface",
				"Photograph",
				"DigitalScreen",
				"ChasingMoonMain",
				"Gramophone",
				"DreamLink",
				"MowBuffDistribute",
				"ScratchTicket",
				"PreheatingCheckIn",
				"MowingTowerActivity",
				"SoaringChallenge",
				"MotorRaceChallenge",
				"PhotoMemoryTopic",
				"LordGymEntrance",
				"RaidReportSettlement",
				"HideLordOpen",
				"FishingDock",
				"FishingCage",
				"FishingItemDelivery",
				"RogueTokenSelect",
				"SlashAndTower",
				"BossRushPlayInfo",
				"GravityFlipControl",
				"PermanentRogueAbilitySelect",
				"PermanentRogueShop",
				"PermanentRogueRandomEvent",
				"PermanentRogueActivityIntroduce",
				"PermanentRogueSettlement",
				"PermanentRogueTokenSelect",
				"CiacconaAvgSystemBoard",
				"CiacconaAvgChapterBoard",
				"DangoAbyssActivity",
				"PhantomBattleChallenge",
				"CoBathing",
				"PlotReview",
				"PlotReviewJumpTips",
				"MoraleSystem",
				"LifePointChallenge",
				"GreatSwordChallenge",
				"TrapDefenseMapChange",
				"HonamiStorySafeBag",
				"HonamiStoryFightPreparation",
				"HonamiStoryMascot",
				"HonamiStoryTalentTree",
				"HonamiStoryResourceStation",
				"HonamiStoryChooseLevel",
				"HonamiStoryWareHouse",
				"FindBug",
				"InfrastructureItemDelivery",
				"SurvivorsGameplay",
				"PhotographFightActivity",
				"TransitionPopup",
				"InfrActivityFinishInfrastructure",
				"Enrollment",
				"Motorcycle",
				"MotorcycleDiy",
				"Map",
				"AreaTerminalGamePlay",
				"GuessCardGamePlayView",
				"GuessJokerSelectRoleView",
				"ChangePhantomExhibitView",
				"ChangeWeaponExhibitView",
				"DrinksMixDrinksView",
				"DrinksSelectRoleView",
				"FurnitureDiyShop",
				"TakePhoto",
				"SpringFestivalBrochure",
				"SpringFestivalPictureAlbum",
				"PictureCaption",
				"Coop",
				"RhythmSpaceshipInMainStory",
				"DropCatchInMainStory",
				"TetrisBoardGameEndlessLevel",
				"VillageInfrMainView",
				"VillageInfrDelivery",
				"VillageInfrFinishConstruction",
				"InteractiveComic",
				"CyberpunkCollaborationVehicleShare",
				"CyberpunkCollaborationVehicleShareInProgress",
				"QuestBranch",
				"QuestBranchTips",
				"SheriffCriminalIdentityConfirmed",
				"SheriffAnomaly",
				"SheriffMainStoryError",
				"DollGrabDelivery",
				"WriteLetter",
				"MechascoutMindSpaceDungeon",
				"RoverRogueTrophy",
				"FoxFailureTips",
				"GiantDelivery",
				"DangoBrawlVictorySettlement",
				"DangoBrawlFailureSettlement",
				"InformationViewPopup",
				"DeliverItemProbeCollectibles"
			};
		}

		// Token: 0x0600C9DD RID: 51677 RVA: 0x001DAA73 File Offset: 0x001D8C73
		public static ESystemType[] GetValues()
		{
			return new ESystemType[]
			{
				ESystemType.Shop,
				ESystemType.RegionQuest,
				ESystemType.ContributionLevel,
				ESystemType.InstanceEntrance,
				ESystemType.MingSuTi,
				ESystemType.InformationView,
				ESystemType.DailyQuest,
				ESystemType.Cook,
				ESystemType.FixCook,
				ESystemType.Synthetic,
				ESystemType.Forging,
				ESystemType.Expostulation,
				ESystemType.RoleDescription,
				ESystemType.TrialRoleDescription,
				ESystemType.RogueAbilitySelect,
				ESystemType.RogueShop,
				ESystemType.RogueRandomEvent,
				ESystemType.RogueActivityIntroduce,
				ESystemType.RogueSettlement,
				ESystemType.RogueTowerTrial,
				ESystemType.GameSysOpen,
				ESystemType.TurntableControl,
				ESystemType.InstanceFailure,
				ESystemType.FeedingPets,
				ESystemType.SoundAreaPlayInfo,
				ESystemType.LordChallenge,
				ESystemType.ExploreLevelView,
				ESystemType.ConfirmBox,
				ESystemType.ConfirmBox2,
				ESystemType.ActivityIntroduce,
				ESystemType.ActivitySubInterface,
				ESystemType.Photograph,
				ESystemType.DigitalScreen,
				ESystemType.ChasingMoonMain,
				ESystemType.Gramophone,
				ESystemType.DreamLink,
				ESystemType.MowBuffDistribute,
				ESystemType.ScratchTicket,
				ESystemType.PreheatingCheckIn,
				ESystemType.MowingTowerActivity,
				ESystemType.SoaringChallenge,
				ESystemType.MotorRaceChallenge,
				ESystemType.PhotoMemoryTopic,
				ESystemType.LordGymEntrance,
				ESystemType.RaidReportSettlement,
				ESystemType.HideLordOpen,
				ESystemType.FishingDock,
				ESystemType.FishingCage,
				ESystemType.FishingItemDelivery,
				ESystemType.RogueTokenSelect,
				ESystemType.SlashAndTower,
				ESystemType.BossRushPlayInfo,
				ESystemType.GravityFlipControl,
				ESystemType.PermanentRogueAbilitySelect,
				ESystemType.PermanentRogueShop,
				ESystemType.PermanentRogueRandomEvent,
				ESystemType.PermanentRogueActivityIntroduce,
				ESystemType.PermanentRogueSettlement,
				ESystemType.PermanentRogueTokenSelect,
				ESystemType.CiacconaAvgSystemBoard,
				ESystemType.CiacconaAvgChapterBoard,
				ESystemType.DangoAbyssActivity,
				ESystemType.PhantomBattleChallenge,
				ESystemType.CoBathing,
				ESystemType.PlotReview,
				ESystemType.PlotReviewJumpTips,
				ESystemType.MoraleSystem,
				ESystemType.LifePointChallenge,
				ESystemType.GreatSwordChallenge,
				ESystemType.TrapDefenseMapChange,
				ESystemType.HonamiStorySafeBag,
				ESystemType.HonamiStoryFightPreparation,
				ESystemType.HonamiStoryMascot,
				ESystemType.HonamiStoryTalentTree,
				ESystemType.HonamiStoryResourceStation,
				ESystemType.HonamiStoryChooseLevel,
				ESystemType.HonamiStoryWareHouse,
				ESystemType.FindBug,
				ESystemType.InfrastructureItemDelivery,
				ESystemType.SurvivorsGameplay,
				ESystemType.PhotographFightActivity,
				ESystemType.TransitionPopup,
				ESystemType.InfrActivityFinishInfrastructure,
				ESystemType.Enrollment,
				ESystemType.Motorcycle,
				ESystemType.MotorcycleDiy,
				ESystemType.Map,
				ESystemType.AreaTerminalGamePlay,
				ESystemType.GuessCardGamePlayView,
				ESystemType.GuessJokerSelectRoleView,
				ESystemType.ChangePhantomExhibitView,
				ESystemType.ChangeWeaponExhibitView,
				ESystemType.DrinksMixDrinksView,
				ESystemType.DrinksSelectRoleView,
				ESystemType.FurnitureDiyShop,
				ESystemType.TakePhoto,
				ESystemType.SpringFestivalBrochure,
				ESystemType.SpringFestivalPictureAlbum,
				ESystemType.PictureCaption,
				ESystemType.Coop,
				ESystemType.RhythmSpaceshipInMainStory,
				ESystemType.DropCatchInMainStory,
				ESystemType.TetrisBoardGameEndlessLevel,
				ESystemType.VillageInfrMainView,
				ESystemType.VillageInfrDelivery,
				ESystemType.VillageInfrFinishConstruction,
				ESystemType.InteractiveComic,
				ESystemType.CyberpunkCollaborationVehicleShare,
				ESystemType.CyberpunkCollaborationVehicleShareInProgress,
				ESystemType.QuestBranch,
				ESystemType.QuestBranchTips,
				ESystemType.SheriffCriminalIdentityConfirmed,
				ESystemType.SheriffAnomaly,
				ESystemType.SheriffMainStoryError,
				ESystemType.DollGrabDelivery,
				ESystemType.WriteLetter,
				ESystemType.MechascoutMindSpaceDungeon,
				ESystemType.RoverRogueTrophy,
				ESystemType.FoxFailureTips,
				ESystemType.GiantDelivery,
				ESystemType.DangoBrawlVictorySettlement,
				ESystemType.DangoBrawlFailureSettlement,
				ESystemType.InformationViewPopup,
				ESystemType.DeliverItemProbeCollectibles
			};
		}

		// Token: 0x0600C9DE RID: 51678 RVA: 0x001DAA88 File Offset: 0x001D8C88
		public static string[] GetNames()
		{
			return new string[]
			{
				"Shop",
				"RegionQuest",
				"ContributionLevel",
				"InstanceEntrance",
				"MingSuTi",
				"InformationView",
				"DailyQuest",
				"Cook",
				"FixCook",
				"Synthetic",
				"Forging",
				"Expostulation",
				"RoleDescription",
				"TrialRoleDescription",
				"RogueAbilitySelect",
				"RogueShop",
				"RogueRandomEvent",
				"RogueActivityIntroduce",
				"RogueSettlement",
				"RogueTowerTrial",
				"GameSysOpen",
				"TurntableControl",
				"InstanceFailure",
				"FeedingPets",
				"SoundAreaPlayInfo",
				"LordChallenge",
				"ExploreLevelView",
				"ConfirmBox",
				"ConfirmBox2",
				"ActivityIntroduce",
				"ActivitySubInterface",
				"Photograph",
				"DigitalScreen",
				"ChasingMoonMain",
				"Gramophone",
				"DreamLink",
				"MowBuffDistribute",
				"ScratchTicket",
				"PreheatingCheckIn",
				"MowingTowerActivity",
				"SoaringChallenge",
				"MotorRaceChallenge",
				"PhotoMemoryTopic",
				"LordGymEntrance",
				"RaidReportSettlement",
				"HideLordOpen",
				"FishingDock",
				"FishingCage",
				"FishingItemDelivery",
				"RogueTokenSelect",
				"SlashAndTower",
				"BossRushPlayInfo",
				"GravityFlipControl",
				"PermanentRogueAbilitySelect",
				"PermanentRogueShop",
				"PermanentRogueRandomEvent",
				"PermanentRogueActivityIntroduce",
				"PermanentRogueSettlement",
				"PermanentRogueTokenSelect",
				"CiacconaAvgSystemBoard",
				"CiacconaAvgChapterBoard",
				"DangoAbyssActivity",
				"PhantomBattleChallenge",
				"CoBathing",
				"PlotReview",
				"PlotReviewJumpTips",
				"MoraleSystem",
				"LifePointChallenge",
				"GreatSwordChallenge",
				"TrapDefenseMapChange",
				"HonamiStorySafeBag",
				"HonamiStoryFightPreparation",
				"HonamiStoryMascot",
				"HonamiStoryTalentTree",
				"HonamiStoryResourceStation",
				"HonamiStoryChooseLevel",
				"HonamiStoryWareHouse",
				"FindBug",
				"InfrastructureItemDelivery",
				"SurvivorsGameplay",
				"PhotographFightActivity",
				"TransitionPopup",
				"InfrActivityFinishInfrastructure",
				"Enrollment",
				"Motorcycle",
				"MotorcycleDiy",
				"Map",
				"AreaTerminalGamePlay",
				"GuessCardGamePlayView",
				"GuessJokerSelectRoleView",
				"ChangePhantomExhibitView",
				"ChangeWeaponExhibitView",
				"DrinksMixDrinksView",
				"DrinksSelectRoleView",
				"FurnitureDiyShop",
				"TakePhoto",
				"SpringFestivalBrochure",
				"SpringFestivalPictureAlbum",
				"PictureCaption",
				"Coop",
				"RhythmSpaceshipInMainStory",
				"DropCatchInMainStory",
				"TetrisBoardGameEndlessLevel",
				"VillageInfrMainView",
				"VillageInfrDelivery",
				"VillageInfrFinishConstruction",
				"InteractiveComic",
				"CyberpunkCollaborationVehicleShare",
				"CyberpunkCollaborationVehicleShareInProgress",
				"QuestBranch",
				"QuestBranchTips",
				"SheriffCriminalIdentityConfirmed",
				"SheriffAnomaly",
				"SheriffMainStoryError",
				"DollGrabDelivery",
				"WriteLetter",
				"MechascoutMindSpaceDungeon",
				"RoverRogueTrophy",
				"FoxFailureTips",
				"GiantDelivery",
				"DangoBrawlVictorySettlement",
				"DangoBrawlFailureSettlement",
				"InformationViewPopup",
				"DeliverItemProbeCollectibles"
			};
		}
	}
}
