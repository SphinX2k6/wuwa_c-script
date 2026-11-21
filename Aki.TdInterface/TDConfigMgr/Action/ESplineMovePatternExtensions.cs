using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026CA RID: 9930
	public static class ESplineMovePatternExtensions
	{
		// Token: 0x0600D5E7 RID: 54759 RVA: 0x001F13F0 File Offset: 0x001EF5F0
		public static string ToEnumString(this ESplineMovePattern value)
		{
			string result;
			switch (value)
			{
			case ESplineMovePattern.PathLine:
				result = "PathLine";
				break;
			case ESplineMovePattern.RacingTrack:
				result = "RacingTrack";
				break;
			case ESplineMovePattern.SlideTrack:
				result = "SlideTrack";
				break;
			case ESplineMovePattern.AirPassage:
				result = "AirPassage";
				break;
			case ESplineMovePattern.MotorcycleTrack:
				result = "MotorcycleTrack";
				break;
			case ESplineMovePattern.MechaAirPassage:
				result = "MechaAirPassage";
				break;
			case ESplineMovePattern.PetalGrabMove:
				result = "PetalGrabMove";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D5E8 RID: 54760 RVA: 0x001F1468 File Offset: 0x001EF668
		public static ESplineMovePattern FromString(string name)
		{
			ESplineMovePattern result;
			if (!ESplineMovePatternExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESplineMovePattern 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D5E9 RID: 54761 RVA: 0x001F1494 File Offset: 0x001EF694
		public static bool TryFromString(string name, out ESplineMovePattern value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESplineMovePattern.PathLine;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 8:
					if (name == "PathLine")
					{
						value = ESplineMovePattern.PathLine;
						return true;
					}
					break;
				case 10:
				{
					char c = name[0];
					if (c != 'A')
					{
						if (c == 'S')
						{
							if (name == "SlideTrack")
							{
								value = ESplineMovePattern.SlideTrack;
								return true;
							}
						}
					}
					else if (name == "AirPassage")
					{
						value = ESplineMovePattern.AirPassage;
						return true;
					}
					break;
				}
				case 11:
					if (name == "RacingTrack")
					{
						value = ESplineMovePattern.RacingTrack;
						return true;
					}
					break;
				case 13:
					if (name == "PetalGrabMove")
					{
						value = ESplineMovePattern.PetalGrabMove;
						return true;
					}
					break;
				case 15:
				{
					char c = name[1];
					if (c != 'e')
					{
						if (c == 'o')
						{
							if (name == "MotorcycleTrack")
							{
								value = ESplineMovePattern.MotorcycleTrack;
								return true;
							}
						}
					}
					else if (name == "MechaAirPassage")
					{
						value = ESplineMovePattern.MechaAirPassage;
						return true;
					}
					break;
				}
				}
			}
			value = ESplineMovePattern.PathLine;
			return false;
		}

		// Token: 0x0600D5EA RID: 54762 RVA: 0x001F15A6 File Offset: 0x001EF7A6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PathLine",
				"RacingTrack",
				"SlideTrack",
				"AirPassage",
				"MotorcycleTrack",
				"MechaAirPassage",
				"PetalGrabMove"
			};
		}

		// Token: 0x0600D5EB RID: 54763 RVA: 0x001F15E6 File Offset: 0x001EF7E6
		public static ESplineMovePattern[] GetValues()
		{
			return new ESplineMovePattern[]
			{
				ESplineMovePattern.PathLine,
				ESplineMovePattern.RacingTrack,
				ESplineMovePattern.SlideTrack,
				ESplineMovePattern.AirPassage,
				ESplineMovePattern.MotorcycleTrack,
				ESplineMovePattern.MechaAirPassage,
				ESplineMovePattern.PetalGrabMove
			};
		}

		// Token: 0x0600D5EC RID: 54764 RVA: 0x001F15F9 File Offset: 0x001EF7F9
		public static string[] GetNames()
		{
			return new string[]
			{
				"PathLine",
				"RacingTrack",
				"SlideTrack",
				"AirPassage",
				"MotorcycleTrack",
				"MechaAirPassage",
				"PetalGrabMove"
			};
		}
	}
}
