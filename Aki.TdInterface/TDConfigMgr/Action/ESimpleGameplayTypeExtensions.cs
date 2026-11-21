using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026B6 RID: 9910
	public static class ESimpleGameplayTypeExtensions
	{
		// Token: 0x0600D58D RID: 54669 RVA: 0x001EFFD4 File Offset: 0x001EE1D4
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
			case ESimpleGameplayType.FrequencyPaint:
				result = "FrequencyPaint";
				break;
			case ESimpleGameplayType.FrequencyDetect:
				result = "FrequencyDetect";
				break;
			case ESimpleGameplayType.TurntableConnector:
				result = "TurntableConnector";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D58E RID: 54670 RVA: 0x001F01DC File Offset: 0x001EE3DC
		public static ESimpleGameplayType FromString(string name)
		{
			ESimpleGameplayType result;
			if (!ESimpleGameplayTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESimpleGameplayType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D58F RID: 54671 RVA: 0x001F0208 File Offset: 0x001EE408
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
				{
					char c = name[0];
					if (c != 'F')
					{
						if (c == 'I')
						{
							if (name == "ItemInspection")
							{
								value = ESimpleGameplayType.ItemInspection;
								return true;
							}
						}
					}
					else if (name == "FrequencyPaint")
					{
						value = ESimpleGameplayType.FrequencyPaint;
						return true;
					}
					break;
				}
				case 15:
				{
					char c = name[3];
					if (c <= 'j')
					{
						if (c != 'h')
						{
							if (c == 'j')
							{
								if (name == "ProjectorPuzzle")
								{
									value = ESimpleGameplayType.ProjectorPuzzle;
									return true;
								}
							}
						}
						else if (name == "FishingRoulette")
						{
							value = ESimpleGameplayType.FishingRoulette;
							return true;
						}
					}
					else if (c != 'n')
					{
						if (c != 'q')
						{
							if (c == 'w')
							{
								if (name == "FlowerSeaEscape")
								{
									value = ESimpleGameplayType.FlowerSeaEscape;
									return true;
								}
							}
						}
						else if (name == "FrequencyDetect")
						{
							value = ESimpleGameplayType.FrequencyDetect;
							return true;
						}
					}
					else if (name == "SceneInspection")
					{
						value = ESimpleGameplayType.SceneInspection;
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
				case 18:
					if (name == "TurntableConnector")
					{
						value = ESimpleGameplayType.TurntableConnector;
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

		// Token: 0x0600D590 RID: 54672 RVA: 0x001F07B4 File Offset: 0x001EE9B4
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
				"RideFlyingCar",
				"FrequencyPaint",
				"FrequencyDetect",
				"TurntableConnector"
			};
		}

		// Token: 0x0600D591 RID: 54673 RVA: 0x001F08FA File Offset: 0x001EEAFA
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
				ESimpleGameplayType.RideFlyingCar,
				ESimpleGameplayType.FrequencyPaint,
				ESimpleGameplayType.FrequencyDetect,
				ESimpleGameplayType.TurntableConnector
			};
		}

		// Token: 0x0600D592 RID: 54674 RVA: 0x001F0910 File Offset: 0x001EEB10
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
				"RideFlyingCar",
				"FrequencyPaint",
				"FrequencyDetect",
				"TurntableConnector"
			};
		}
	}
}
