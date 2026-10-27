using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200235F RID: 9055
	public static class EInteractIconExtensions
	{
		// Token: 0x0600C5AA RID: 50602 RVA: 0x001CD854 File Offset: 0x001CBA54
		public static string ToEnumString(this EInteractIcon value)
		{
			string result;
			switch (value)
			{
			case EInteractIcon.Dialog:
				result = "Dialog";
				break;
			case EInteractIcon.Shop:
				result = "Shop";
				break;
			case EInteractIcon.OS:
				result = "OS";
				break;
			case EInteractIcon.Other:
				result = "Other";
				break;
			case EInteractIcon.Weapon:
				result = "Weapon";
				break;
			case EInteractIcon.Cook:
				result = "Cook";
				break;
			case EInteractIcon.Souvenir:
				result = "Souvenir";
				break;
			case EInteractIcon.Hospital:
				result = "Hospital";
				break;
			case EInteractIcon.Institute:
				result = "Institute";
				break;
			case EInteractIcon.Grocery:
				result = "Grocery";
				break;
			case EInteractIcon.SearchingLegacy:
				result = "SearchingLegacy";
				break;
			case EInteractIcon.AntecedentConvention:
				result = "AntecedentConvention";
				break;
			case EInteractIcon.AnechoicRegion:
				result = "AnechoicRegion";
				break;
			case EInteractIcon.Leave:
				result = "Leave";
				break;
			case EInteractIcon.Collect:
				result = "Collect";
				break;
			case EInteractIcon.Dungeon:
				result = "Dungeon";
				break;
			case EInteractIcon.ChengXiaoShanShop:
				result = "ChengXiaoShanShop";
				break;
			case EInteractIcon.GroceryKuroRobot:
				result = "GroceryKuroRobot";
				break;
			case EInteractIcon.Phonograph:
				result = "Phonograph";
				break;
			case EInteractIcon.LifePointShop:
				result = "LifePointShop";
				break;
			case EInteractIcon.PlushVillage:
				result = "PlushVillage";
				break;
			case EInteractIcon.FishingDock:
				result = "FishingDock";
				break;
			case EInteractIcon.CartethyiaCall:
				result = "CartethyiaCall";
				break;
			case EInteractIcon.ChurchShop:
				result = "ChurchShop";
				break;
			case EInteractIcon.BvbEntrance:
				result = "BvbEntrance";
				break;
			case EInteractIcon.TuningStand:
				result = "TuningStand";
				break;
			case EInteractIcon.Switch:
				result = "Switch";
				break;
			case EInteractIcon.HandInHand:
				result = "HandInHand";
				break;
			case EInteractIcon.Silhouette:
				result = "Silhouette";
				break;
			case EInteractIcon.BlackBlade:
				result = "BlackBlade";
				break;
			case EInteractIcon.Exchange:
				result = "Exchange";
				break;
			case EInteractIcon.Sunstone:
				result = "Sunstone";
				break;
			case EInteractIcon.Arseni:
				result = "Arseni";
				break;
			case EInteractIcon.RollBlock:
				result = "RollBlock";
				break;
			case EInteractIcon.BvbInteract:
				result = "BvbInteract";
				break;
			case EInteractIcon.GuessCard:
				result = "GuessCard";
				break;
			case EInteractIcon.MixDrinks:
				result = "MixDrinks";
				break;
			case EInteractIcon.CyberpunkShareMoon:
				result = "CyberpunkShareMoon";
				break;
			case EInteractIcon.SoundBox35:
				result = "SoundBox35";
				break;
			case EInteractIcon.FakeShop:
				result = "FakeShop";
				break;
			case EInteractIcon.SuisuiDance1:
				result = "SuisuiDance1";
				break;
			case EInteractIcon.SuisuiDance2:
				result = "SuisuiDance2";
				break;
			case EInteractIcon.SuisuiDance3:
				result = "SuisuiDance3";
				break;
			case EInteractIcon.WriteLetter:
				result = "WriteLetter";
				break;
			case EInteractIcon.QingxiaoInstance:
				result = "QingxiaoInstance";
				break;
			case EInteractIcon.JianYI:
				result = "JianYI";
				break;
			case EInteractIcon.GiantDeliveryWood:
				result = "GiantDeliveryWood";
				break;
			case EInteractIcon.GiantDeliveryWater:
				result = "GiantDeliveryWater";
				break;
			case EInteractIcon.GiantDeliveryFire:
				result = "GiantDeliveryFire";
				break;
			case EInteractIcon.GiantBell:
				result = "GiantBell";
				break;
			case EInteractIcon.GiantGift:
				result = "GiantGift";
				break;
			case EInteractIcon.ElementalWell:
				result = "ElementalWell";
				break;
			case EInteractIcon.FoxPush:
				result = "FoxPush";
				break;
			case EInteractIcon.FoxPickUp:
				result = "FoxPickUp";
				break;
			case EInteractIcon.FoxTalk:
				result = "FoxTalk";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C5AB RID: 50603 RVA: 0x001CDB88 File Offset: 0x001CBD88
		public static EInteractIcon FromString(string name)
		{
			EInteractIcon result;
			if (!EInteractIconExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractIcon 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C5AC RID: 50604 RVA: 0x001CDBB4 File Offset: 0x001CBDB4
		public static bool TryFromString(string name, out EInteractIcon value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInteractIcon.Dialog;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 2:
					if (name == "OS")
					{
						value = EInteractIcon.OS;
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
								value = EInteractIcon.Shop;
								return true;
							}
						}
					}
					else if (name == "Cook")
					{
						value = EInteractIcon.Cook;
						return true;
					}
					break;
				}
				case 5:
				{
					char c = name[0];
					if (c != 'L')
					{
						if (c == 'O')
						{
							if (name == "Other")
							{
								value = EInteractIcon.Other;
								return true;
							}
						}
					}
					else if (name == "Leave")
					{
						value = EInteractIcon.Leave;
						return true;
					}
					break;
				}
				case 6:
				{
					char c = name[0];
					if (c <= 'D')
					{
						if (c != 'A')
						{
							if (c == 'D')
							{
								if (name == "Dialog")
								{
									value = EInteractIcon.Dialog;
									return true;
								}
							}
						}
						else if (name == "Arseni")
						{
							value = EInteractIcon.Arseni;
							return true;
						}
					}
					else if (c != 'J')
					{
						if (c != 'S')
						{
							if (c == 'W')
							{
								if (name == "Weapon")
								{
									value = EInteractIcon.Weapon;
									return true;
								}
							}
						}
						else if (name == "Switch")
						{
							value = EInteractIcon.Switch;
							return true;
						}
					}
					else if (name == "JianYI")
					{
						value = EInteractIcon.JianYI;
						return true;
					}
					break;
				}
				case 7:
				{
					char c = name[3];
					if (c <= 'T')
					{
						if (c != 'P')
						{
							if (c == 'T')
							{
								if (name == "FoxTalk")
								{
									value = EInteractIcon.FoxTalk;
									return true;
								}
							}
						}
						else if (name == "FoxPush")
						{
							value = EInteractIcon.FoxPush;
							return true;
						}
					}
					else if (c != 'c')
					{
						if (c != 'g')
						{
							if (c == 'l')
							{
								if (name == "Collect")
								{
									value = EInteractIcon.Collect;
									return true;
								}
							}
						}
						else if (name == "Dungeon")
						{
							value = EInteractIcon.Dungeon;
							return true;
						}
					}
					else if (name == "Grocery")
					{
						value = EInteractIcon.Grocery;
						return true;
					}
					break;
				}
				case 8:
				{
					char c = name[2];
					if (c <= 'k')
					{
						if (c != 'c')
						{
							if (c == 'k')
							{
								if (name == "FakeShop")
								{
									value = EInteractIcon.FakeShop;
									return true;
								}
							}
						}
						else if (name == "Exchange")
						{
							value = EInteractIcon.Exchange;
							return true;
						}
					}
					else if (c != 'n')
					{
						if (c != 's')
						{
							if (c == 'u')
							{
								if (name == "Souvenir")
								{
									value = EInteractIcon.Souvenir;
									return true;
								}
							}
						}
						else if (name == "Hospital")
						{
							value = EInteractIcon.Hospital;
							return true;
						}
					}
					else if (name == "Sunstone")
					{
						value = EInteractIcon.Sunstone;
						return true;
					}
					break;
				}
				case 9:
				{
					char c = name[5];
					if (c <= 'G')
					{
						if (c != 'B')
						{
							if (c != 'C')
							{
								if (c == 'G')
								{
									if (name == "GiantGift")
									{
										value = EInteractIcon.GiantGift;
										return true;
									}
								}
							}
							else if (name == "GuessCard")
							{
								value = EInteractIcon.GuessCard;
								return true;
							}
						}
						else if (name == "GiantBell")
						{
							value = EInteractIcon.GiantBell;
							return true;
						}
					}
					else if (c <= 'i')
					{
						if (c != 'c')
						{
							if (c == 'i')
							{
								if (name == "MixDrinks")
								{
									value = EInteractIcon.MixDrinks;
									return true;
								}
							}
						}
						else if (name == "FoxPickUp")
						{
							value = EInteractIcon.FoxPickUp;
							return true;
						}
					}
					else if (c != 'l')
					{
						if (c == 't')
						{
							if (name == "Institute")
							{
								value = EInteractIcon.Institute;
								return true;
							}
						}
					}
					else if (name == "RollBlock")
					{
						value = EInteractIcon.RollBlock;
						return true;
					}
					break;
				}
				case 10:
				{
					char c = name[6];
					if (c <= 'e')
					{
						if (c != 'H')
						{
							if (c != 'S')
							{
								if (c == 'e')
								{
									if (name == "Silhouette")
									{
										value = EInteractIcon.Silhouette;
										return true;
									}
								}
							}
							else if (name == "ChurchShop")
							{
								value = EInteractIcon.ChurchShop;
								return true;
							}
						}
						else if (name == "HandInHand")
						{
							value = EInteractIcon.HandInHand;
							return true;
						}
					}
					else if (c != 'l')
					{
						if (c != 'o')
						{
							if (c == 'r')
							{
								if (name == "Phonograph")
								{
									value = EInteractIcon.Phonograph;
									return true;
								}
							}
						}
						else if (name == "SoundBox35")
						{
							value = EInteractIcon.SoundBox35;
							return true;
						}
					}
					else if (name == "BlackBlade")
					{
						value = EInteractIcon.BlackBlade;
						return true;
					}
					break;
				}
				case 11:
				{
					char c = name[3];
					if (c <= 'I')
					{
						if (c != 'E')
						{
							if (c == 'I')
							{
								if (name == "BvbInteract")
								{
									value = EInteractIcon.BvbInteract;
									return true;
								}
							}
						}
						else if (name == "BvbEntrance")
						{
							value = EInteractIcon.BvbEntrance;
							return true;
						}
					}
					else if (c != 'h')
					{
						if (c != 'i')
						{
							if (c == 't')
							{
								if (name == "WriteLetter")
								{
									value = EInteractIcon.WriteLetter;
									return true;
								}
							}
						}
						else if (name == "TuningStand")
						{
							value = EInteractIcon.TuningStand;
							return true;
						}
					}
					else if (name == "FishingDock")
					{
						value = EInteractIcon.FishingDock;
						return true;
					}
					break;
				}
				case 12:
				{
					char c = name[11];
					switch (c)
					{
					case '1':
						if (name == "SuisuiDance1")
						{
							value = EInteractIcon.SuisuiDance1;
							return true;
						}
						break;
					case '2':
						if (name == "SuisuiDance2")
						{
							value = EInteractIcon.SuisuiDance2;
							return true;
						}
						break;
					case '3':
						if (name == "SuisuiDance3")
						{
							value = EInteractIcon.SuisuiDance3;
							return true;
						}
						break;
					default:
						if (c == 'e')
						{
							if (name == "PlushVillage")
							{
								value = EInteractIcon.PlushVillage;
								return true;
							}
						}
						break;
					}
					break;
				}
				case 13:
				{
					char c = name[0];
					if (c != 'E')
					{
						if (c == 'L')
						{
							if (name == "LifePointShop")
							{
								value = EInteractIcon.LifePointShop;
								return true;
							}
						}
					}
					else if (name == "ElementalWell")
					{
						value = EInteractIcon.ElementalWell;
						return true;
					}
					break;
				}
				case 14:
				{
					char c = name[0];
					if (c != 'A')
					{
						if (c == 'C')
						{
							if (name == "CartethyiaCall")
							{
								value = EInteractIcon.CartethyiaCall;
								return true;
							}
						}
					}
					else if (name == "AnechoicRegion")
					{
						value = EInteractIcon.AnechoicRegion;
						return true;
					}
					break;
				}
				case 15:
					if (name == "SearchingLegacy")
					{
						value = EInteractIcon.SearchingLegacy;
						return true;
					}
					break;
				case 16:
				{
					char c = name[0];
					if (c != 'G')
					{
						if (c == 'Q')
						{
							if (name == "QingxiaoInstance")
							{
								value = EInteractIcon.QingxiaoInstance;
								return true;
							}
						}
					}
					else if (name == "GroceryKuroRobot")
					{
						value = EInteractIcon.GroceryKuroRobot;
						return true;
					}
					break;
				}
				case 17:
				{
					char c = name[13];
					if (c != 'F')
					{
						if (c != 'S')
						{
							if (c == 'W')
							{
								if (name == "GiantDeliveryWood")
								{
									value = EInteractIcon.GiantDeliveryWood;
									return true;
								}
							}
						}
						else if (name == "ChengXiaoShanShop")
						{
							value = EInteractIcon.ChengXiaoShanShop;
							return true;
						}
					}
					else if (name == "GiantDeliveryFire")
					{
						value = EInteractIcon.GiantDeliveryFire;
						return true;
					}
					break;
				}
				case 18:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c == 'G')
						{
							if (name == "GiantDeliveryWater")
							{
								value = EInteractIcon.GiantDeliveryWater;
								return true;
							}
						}
					}
					else if (name == "CyberpunkShareMoon")
					{
						value = EInteractIcon.CyberpunkShareMoon;
						return true;
					}
					break;
				}
				case 20:
					if (name == "AntecedentConvention")
					{
						value = EInteractIcon.AntecedentConvention;
						return true;
					}
					break;
				}
			}
			value = EInteractIcon.Dialog;
			return false;
		}

		// Token: 0x0600C5AD RID: 50605 RVA: 0x001CE498 File Offset: 0x001CC698
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Dialog",
				"Shop",
				"OS",
				"Other",
				"Weapon",
				"Cook",
				"Souvenir",
				"Hospital",
				"Institute",
				"Grocery",
				"SearchingLegacy",
				"AntecedentConvention",
				"AnechoicRegion",
				"Leave",
				"Collect",
				"Dungeon",
				"ChengXiaoShanShop",
				"GroceryKuroRobot",
				"Phonograph",
				"LifePointShop",
				"PlushVillage",
				"FishingDock",
				"CartethyiaCall",
				"ChurchShop",
				"BvbEntrance",
				"TuningStand",
				"Switch",
				"HandInHand",
				"Silhouette",
				"BlackBlade",
				"Exchange",
				"Sunstone",
				"Arseni",
				"RollBlock",
				"BvbInteract",
				"GuessCard",
				"MixDrinks",
				"CyberpunkShareMoon",
				"SoundBox35",
				"FakeShop",
				"SuisuiDance1",
				"SuisuiDance2",
				"SuisuiDance3",
				"WriteLetter",
				"QingxiaoInstance",
				"JianYI",
				"GiantDeliveryWood",
				"GiantDeliveryWater",
				"GiantDeliveryFire",
				"GiantBell",
				"GiantGift",
				"ElementalWell",
				"FoxPush",
				"FoxPickUp",
				"FoxTalk"
			};
		}

		// Token: 0x0600C5AE RID: 50606 RVA: 0x001CE692 File Offset: 0x001CC892
		public static EInteractIcon[] GetValues()
		{
			return new EInteractIcon[]
			{
				EInteractIcon.Dialog,
				EInteractIcon.Shop,
				EInteractIcon.OS,
				EInteractIcon.Other,
				EInteractIcon.Weapon,
				EInteractIcon.Cook,
				EInteractIcon.Souvenir,
				EInteractIcon.Hospital,
				EInteractIcon.Institute,
				EInteractIcon.Grocery,
				EInteractIcon.SearchingLegacy,
				EInteractIcon.AntecedentConvention,
				EInteractIcon.AnechoicRegion,
				EInteractIcon.Leave,
				EInteractIcon.Collect,
				EInteractIcon.Dungeon,
				EInteractIcon.ChengXiaoShanShop,
				EInteractIcon.GroceryKuroRobot,
				EInteractIcon.Phonograph,
				EInteractIcon.LifePointShop,
				EInteractIcon.PlushVillage,
				EInteractIcon.FishingDock,
				EInteractIcon.CartethyiaCall,
				EInteractIcon.ChurchShop,
				EInteractIcon.BvbEntrance,
				EInteractIcon.TuningStand,
				EInteractIcon.Switch,
				EInteractIcon.HandInHand,
				EInteractIcon.Silhouette,
				EInteractIcon.BlackBlade,
				EInteractIcon.Exchange,
				EInteractIcon.Sunstone,
				EInteractIcon.Arseni,
				EInteractIcon.RollBlock,
				EInteractIcon.BvbInteract,
				EInteractIcon.GuessCard,
				EInteractIcon.MixDrinks,
				EInteractIcon.CyberpunkShareMoon,
				EInteractIcon.SoundBox35,
				EInteractIcon.FakeShop,
				EInteractIcon.SuisuiDance1,
				EInteractIcon.SuisuiDance2,
				EInteractIcon.SuisuiDance3,
				EInteractIcon.WriteLetter,
				EInteractIcon.QingxiaoInstance,
				EInteractIcon.JianYI,
				EInteractIcon.GiantDeliveryWood,
				EInteractIcon.GiantDeliveryWater,
				EInteractIcon.GiantDeliveryFire,
				EInteractIcon.GiantBell,
				EInteractIcon.GiantGift,
				EInteractIcon.ElementalWell,
				EInteractIcon.FoxPush,
				EInteractIcon.FoxPickUp,
				EInteractIcon.FoxTalk
			};
		}

		// Token: 0x0600C5AF RID: 50607 RVA: 0x001CE6A8 File Offset: 0x001CC8A8
		public static string[] GetNames()
		{
			return new string[]
			{
				"Dialog",
				"Shop",
				"OS",
				"Other",
				"Weapon",
				"Cook",
				"Souvenir",
				"Hospital",
				"Institute",
				"Grocery",
				"SearchingLegacy",
				"AntecedentConvention",
				"AnechoicRegion",
				"Leave",
				"Collect",
				"Dungeon",
				"ChengXiaoShanShop",
				"GroceryKuroRobot",
				"Phonograph",
				"LifePointShop",
				"PlushVillage",
				"FishingDock",
				"CartethyiaCall",
				"ChurchShop",
				"BvbEntrance",
				"TuningStand",
				"Switch",
				"HandInHand",
				"Silhouette",
				"BlackBlade",
				"Exchange",
				"Sunstone",
				"Arseni",
				"RollBlock",
				"BvbInteract",
				"GuessCard",
				"MixDrinks",
				"CyberpunkShareMoon",
				"SoundBox35",
				"FakeShop",
				"SuisuiDance1",
				"SuisuiDance2",
				"SuisuiDance3",
				"WriteLetter",
				"QingxiaoInstance",
				"JianYI",
				"GiantDeliveryWood",
				"GiantDeliveryWater",
				"GiantDeliveryFire",
				"GiantBell",
				"GiantGift",
				"ElementalWell",
				"FoxPush",
				"FoxPickUp",
				"FoxTalk"
			};
		}
	}
}
