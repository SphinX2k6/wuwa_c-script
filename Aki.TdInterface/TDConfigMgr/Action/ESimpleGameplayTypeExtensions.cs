using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002417 RID: 9239
	public static class ESimpleGameplayTypeExtensions
	{
		// Token: 0x0600C8E6 RID: 51430 RVA: 0x001D63D8 File Offset: 0x001D45D8
		public static string ToEnumString(this ESimpleGameplayType value)
		{
			string result;
			switch (value)
			{
			case ESimpleGameplayType.Cipher:
				result = "Cipher";
				break;
			case ESimpleGameplayType.SignalBreak:
				result = "SignalBreak";
				break;
			case ESimpleGameplayType.SundialPuzzle:
				result = "SundialPuzzle";
				break;
			case ESimpleGameplayType.SignalDevice:
				result = "SignalDevice";
				break;
			case ESimpleGameplayType.SignalDevice2:
				result = "SignalDevice2";
				break;
			case ESimpleGameplayType.MorseCode:
				result = "MorseCode";
				break;
			case ESimpleGameplayType.RenjuChess:
				result = "RenjuChess";
				break;
			case ESimpleGameplayType.LifePoint:
				result = "LifePoint";
				break;
			case ESimpleGameplayType.BrokenRock:
				result = "BrokenRock";
				break;
			case ESimpleGameplayType.FishingRoulette:
				result = "FishingRoulette";
				break;
			case ESimpleGameplayType.DaolingAuthentication:
				result = "DaolingAuthentication";
				break;
			case ESimpleGameplayType.Reigns:
				result = "Reigns";
				break;
			case ESimpleGameplayType.TuningStand:
				result = "TuningStand";
				break;
			case ESimpleGameplayType.ItemInspection:
				result = "ItemInspection";
				break;
			case ESimpleGameplayType.TraceTracing:
				result = "TraceTracing";
				break;
			case ESimpleGameplayType.FindSunSpirit:
				result = "FindSunSpirit";
				break;
			case ESimpleGameplayType.ProjectorPuzzle:
				result = "ProjectorPuzzle";
				break;
			case ESimpleGameplayType.DollGrab:
				result = "DollGrab";
				break;
			case ESimpleGameplayType.DollGrabShowcase:
				result = "DollGrabShowcase";
				break;
			case ESimpleGameplayType.DaemonHack:
				result = "DaemonHack";
				break;
			case ESimpleGameplayType.ProjectionMachine:
				result = "ProjectionMachine";
				break;
			case ESimpleGameplayType.DragActor:
				result = "DragActor";
				break;
			case ESimpleGameplayType.WuWaGo:
				result = "WuWaGo";
				break;
			case ESimpleGameplayType.SheriffReasoning:
				result = "SheriffReasoning";
				break;
			case ESimpleGameplayType.WriteLetter:
				result = "WriteLetter";
				break;
			case ESimpleGameplayType.QteHourglass:
				result = "QteHourglass";
				break;
			case ESimpleGameplayType.SceneInspection:
				result = "SceneInspection";
				break;
			case ESimpleGameplayType.InstrumentQte:
				result = "InstrumentQte";
				break;
			case ESimpleGameplayType.PlayPiano:
				result = "PlayPiano";
				break;
			case ESimpleGameplayType.Dart:
				result = "Dart";
				break;
			case ESimpleGameplayType.FlowerSeaEscape:
				result = "FlowerSeaEscape";
				break;
			case ESimpleGameplayType.RideFlyingCar:
				result = "RideFlyingCar";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C8E7 RID: 51431 RVA: 0x001D65B4 File Offset: 0x001D47B4
		public static ESimpleGameplayType FromString(string name)
		{
			ESimpleGameplayType result;
			if (!ESimpleGameplayTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESimpleGameplayType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C8E8 RID: 51432 RVA: 0x001D65E0 File Offset: 0x001D47E0
		public static bool TryFromString(string name, out ESimpleGameplayType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESimpleGameplayType.Cipher;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 4:
					if (name == "Dart")
					{
						value = ESimpleGameplayType.Dart;
						return true;
					}
					break;
				case 6:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c != 'R')
						{
							if (c == 'W')
							{
								if (name == "WuWaGo")
								{
									value = ESimpleGameplayType.WuWaGo;
									return true;
								}
							}
						}
						else if (name == "Reigns")
						{
							value = ESimpleGameplayType.Reigns;
							return true;
						}
					}
					else if (name == "Cipher")
					{
						value = ESimpleGameplayType.Cipher;
						return true;
					}
					break;
				}
				case 8:
					if (name == "DollGrab")
					{
						value = ESimpleGameplayType.DollGrab;
						return true;
					}
					break;
				case 9:
				{
					char c = name[0];
					if (c != 'D')
					{
						switch (c)
						{
						case 'L':
							if (name == "LifePoint")
							{
								value = ESimpleGameplayType.LifePoint;
								return true;
							}
							break;
						case 'M':
							if (name == "MorseCode")
							{
								value = ESimpleGameplayType.MorseCode;
								return true;
							}
							break;
						case 'P':
							if (name == "PlayPiano")
							{
								value = ESimpleGameplayType.PlayPiano;
								return true;
							}
							break;
						}
					}
					else if (name == "DragActor")
					{
						value = ESimpleGameplayType.DragActor;
						return true;
					}
					break;
				}
				case 10:
				{
					char c = name[0];
					if (c != 'B')
					{
						if (c != 'D')
						{
							if (c == 'R')
							{
								if (name == "RenjuChess")
								{
									value = ESimpleGameplayType.RenjuChess;
									return true;
								}
							}
						}
						else if (name == "DaemonHack")
						{
							value = ESimpleGameplayType.DaemonHack;
							return true;
						}
					}
					else if (name == "BrokenRock")
					{
						value = ESimpleGameplayType.BrokenRock;
						return true;
					}
					break;
				}
				case 11:
					switch (name[0])
					{
					case 'S':
						if (name == "SignalBreak")
						{
							value = ESimpleGameplayType.SignalBreak;
							return true;
						}
						break;
					case 'T':
						if (name == "TuningStand")
						{
							value = ESimpleGameplayType.TuningStand;
							return true;
						}
						break;
					case 'W':
						if (name == "WriteLetter")
						{
							value = ESimpleGameplayType.WriteLetter;
							return true;
						}
						break;
					}
					break;
				case 12:
					switch (name[0])
					{
					case 'Q':
						if (name == "QteHourglass")
						{
							value = ESimpleGameplayType.QteHourglass;
							return true;
						}
						break;
					case 'S':
						if (name == "SignalDevice")
						{
							value = ESimpleGameplayType.SignalDevice;
							return true;
						}
						break;
					case 'T':
						if (name == "TraceTracing")
						{
							value = ESimpleGameplayType.TraceTracing;
							return true;
						}
						break;
					}
					break;
				case 13:
				{
					char c = name[4];
					if (c <= 'S')
					{
						if (c != 'F')
						{
							if (c == 'S')
							{
								if (name == "FindSunSpirit")
								{
									value = ESimpleGameplayType.FindSunSpirit;
									return true;
								}
							}
						}
						else if (name == "RideFlyingCar")
						{
							value = ESimpleGameplayType.RideFlyingCar;
							return true;
						}
					}
					else if (c != 'a')
					{
						if (c != 'i')
						{
							if (c == 'r')
							{
								if (name == "InstrumentQte")
								{
									value = ESimpleGameplayType.InstrumentQte;
									return true;
								}
							}
						}
						else if (name == "SundialPuzzle")
						{
							value = ESimpleGameplayType.SundialPuzzle;
							return true;
						}
					}
					else if (name == "SignalDevice2")
					{
						value = ESimpleGameplayType.SignalDevice2;
						return true;
					}
					break;
				}
				case 14:
					if (name == "ItemInspection")
					{
						value = ESimpleGameplayType.ItemInspection;
						return true;
					}
					break;
				case 15:
				{
					char c = name[1];
					if (c <= 'i')
					{
						if (c != 'c')
						{
							if (c == 'i')
							{
								if (name == "FishingRoulette")
								{
									value = ESimpleGameplayType.FishingRoulette;
									return true;
								}
							}
						}
						else if (name == "SceneInspection")
						{
							value = ESimpleGameplayType.SceneInspection;
							return true;
						}
					}
					else if (c != 'l')
					{
						if (c == 'r')
						{
							if (name == "ProjectorPuzzle")
							{
								value = ESimpleGameplayType.ProjectorPuzzle;
								return true;
							}
						}
					}
					else if (name == "FlowerSeaEscape")
					{
						value = ESimpleGameplayType.FlowerSeaEscape;
						return true;
					}
					break;
				}
				case 16:
				{
					char c = name[0];
					if (c != 'D')
					{
						if (c == 'S')
						{
							if (name == "SheriffReasoning")
							{
								value = ESimpleGameplayType.SheriffReasoning;
								return true;
							}
						}
					}
					else if (name == "DollGrabShowcase")
					{
						value = ESimpleGameplayType.DollGrabShowcase;
						return true;
					}
					break;
				}
				case 17:
					if (name == "ProjectionMachine")
					{
						value = ESimpleGameplayType.ProjectionMachine;
						return true;
					}
					break;
				case 21:
					if (name == "DaolingAuthentication")
					{
						value = ESimpleGameplayType.DaolingAuthentication;
						return true;
					}
					break;
				}
			}
			value = ESimpleGameplayType.Cipher;
			return false;
		}

		// Token: 0x0600C8E9 RID: 51433 RVA: 0x001D6B18 File Offset: 0x001D4D18
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Cipher",
				"SignalBreak",
				"SundialPuzzle",
				"SignalDevice",
				"SignalDevice2",
				"MorseCode",
				"RenjuChess",
				"LifePoint",
				"BrokenRock",
				"FishingRoulette",
				"DaolingAuthentication",
				"Reigns",
				"TuningStand",
				"ItemInspection",
				"TraceTracing",
				"FindSunSpirit",
				"ProjectorPuzzle",
				"DollGrab",
				"DollGrabShowcase",
				"DaemonHack",
				"ProjectionMachine",
				"DragActor",
				"WuWaGo",
				"SheriffReasoning",
				"WriteLetter",
				"QteHourglass",
				"SceneInspection",
				"InstrumentQte",
				"PlayPiano",
				"Dart",
				"FlowerSeaEscape",
				"RideFlyingCar"
			};
		}

		// Token: 0x0600C8EA RID: 51434 RVA: 0x001D6C43 File Offset: 0x001D4E43
		public static ESimpleGameplayType[] GetValues()
		{
			return new ESimpleGameplayType[]
			{
				ESimpleGameplayType.Cipher,
				ESimpleGameplayType.SignalBreak,
				ESimpleGameplayType.SundialPuzzle,
				ESimpleGameplayType.SignalDevice,
				ESimpleGameplayType.SignalDevice2,
				ESimpleGameplayType.MorseCode,
				ESimpleGameplayType.RenjuChess,
				ESimpleGameplayType.LifePoint,
				ESimpleGameplayType.BrokenRock,
				ESimpleGameplayType.FishingRoulette,
				ESimpleGameplayType.DaolingAuthentication,
				ESimpleGameplayType.Reigns,
				ESimpleGameplayType.TuningStand,
				ESimpleGameplayType.ItemInspection,
				ESimpleGameplayType.TraceTracing,
				ESimpleGameplayType.FindSunSpirit,
				ESimpleGameplayType.ProjectorPuzzle,
				ESimpleGameplayType.DollGrab,
				ESimpleGameplayType.DollGrabShowcase,
				ESimpleGameplayType.DaemonHack,
				ESimpleGameplayType.ProjectionMachine,
				ESimpleGameplayType.DragActor,
				ESimpleGameplayType.WuWaGo,
				ESimpleGameplayType.SheriffReasoning,
				ESimpleGameplayType.WriteLetter,
				ESimpleGameplayType.QteHourglass,
				ESimpleGameplayType.SceneInspection,
				ESimpleGameplayType.InstrumentQte,
				ESimpleGameplayType.PlayPiano,
				ESimpleGameplayType.Dart,
				ESimpleGameplayType.FlowerSeaEscape,
				ESimpleGameplayType.RideFlyingCar
			};
		}

		// Token: 0x0600C8EB RID: 51435 RVA: 0x001D6C58 File Offset: 0x001D4E58
		public static string[] GetNames()
		{
			return new string[]
			{
				"Cipher",
				"SignalBreak",
				"SundialPuzzle",
				"SignalDevice",
				"SignalDevice2",
				"MorseCode",
				"RenjuChess",
				"LifePoint",
				"BrokenRock",
				"FishingRoulette",
				"DaolingAuthentication",
				"Reigns",
				"TuningStand",
				"ItemInspection",
				"TraceTracing",
				"FindSunSpirit",
				"ProjectorPuzzle",
				"DollGrab",
				"DollGrabShowcase",
				"DaemonHack",
				"ProjectionMachine",
				"DragActor",
				"WuWaGo",
				"SheriffReasoning",
				"WriteLetter",
				"QteHourglass",
				"SceneInspection",
				"InstrumentQte",
				"PlayPiano",
				"Dart",
				"FlowerSeaEscape",
				"RideFlyingCar"
			};
		}
	}
}
