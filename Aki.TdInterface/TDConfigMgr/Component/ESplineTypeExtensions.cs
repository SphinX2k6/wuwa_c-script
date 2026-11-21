using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AE3 RID: 2787
	public static class ESplineTypeExtensions
	{
		// Token: 0x06003D10 RID: 15632 RVA: 0x0009C46C File Offset: 0x0009A66C
		public static string ToEnumString(this ESplineType value)
		{
			string result;
			switch (value)
			{
			case ESplineType.Common:
				result = "Common";
				break;
			case ESplineType.Parkour:
				result = "Parkour";
				break;
			case ESplineType.Butterfly:
				result = "Butterfly";
				break;
			case ESplineType.Effect:
				result = "Effect";
				break;
			case ESplineType.Patrol:
				result = "Patrol";
				break;
			case ESplineType.LevelAI:
				result = "LevelAI";
				break;
			case ESplineType.AirPassage:
				result = "AirPassage";
				break;
			case ESplineType.ContinuesVariableSpeedMovement:
				result = "ContinuesVariableSpeedMovement";
				break;
			case ESplineType.TimePatrol:
				result = "TimePatrol";
				break;
			case ESplineType.Range:
				result = "Range";
				break;
			case ESplineType.Way:
				result = "Way";
				break;
			case ESplineType.MotorSlide:
				result = "MotorSlide";
				break;
			case ESplineType.SwordRiderRail:
				result = "SwordRiderRail";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x0009C52C File Offset: 0x0009A72C
		public static ESplineType FromString(string name)
		{
			ESplineType result;
			if (!ESplineTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESplineType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x0009C558 File Offset: 0x0009A758
		public static bool TryFromString(string name, out ESplineType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESplineType.Common;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				switch (length)
				{
				case 3:
					if (name == "Way")
					{
						value = ESplineType.Way;
						return true;
					}
					break;
				case 4:
				case 8:
				case 11:
				case 12:
				case 13:
					break;
				case 5:
					if (name == "Range")
					{
						value = ESplineType.Range;
						return true;
					}
					break;
				case 6:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c != 'E')
						{
							if (c == 'P')
							{
								if (name == "Patrol")
								{
									value = ESplineType.Patrol;
									return true;
								}
							}
						}
						else if (name == "Effect")
						{
							value = ESplineType.Effect;
							return true;
						}
					}
					else if (name == "Common")
					{
						value = ESplineType.Common;
						return true;
					}
					break;
				}
				case 7:
				{
					char c = name[0];
					if (c != 'L')
					{
						if (c == 'P')
						{
							if (name == "Parkour")
							{
								value = ESplineType.Parkour;
								return true;
							}
						}
					}
					else if (name == "LevelAI")
					{
						value = ESplineType.LevelAI;
						return true;
					}
					break;
				}
				case 9:
					if (name == "Butterfly")
					{
						value = ESplineType.Butterfly;
						return true;
					}
					break;
				case 10:
				{
					char c = name[0];
					if (c != 'A')
					{
						if (c != 'M')
						{
							if (c == 'T')
							{
								if (name == "TimePatrol")
								{
									value = ESplineType.TimePatrol;
									return true;
								}
							}
						}
						else if (name == "MotorSlide")
						{
							value = ESplineType.MotorSlide;
							return true;
						}
					}
					else if (name == "AirPassage")
					{
						value = ESplineType.AirPassage;
						return true;
					}
					break;
				}
				case 14:
					if (name == "SwordRiderRail")
					{
						value = ESplineType.SwordRiderRail;
						return true;
					}
					break;
				default:
					if (length == 30)
					{
						if (name == "ContinuesVariableSpeedMovement")
						{
							value = ESplineType.ContinuesVariableSpeedMovement;
							return true;
						}
					}
					break;
				}
			}
			value = ESplineType.Common;
			return false;
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x0009C75C File Offset: 0x0009A95C
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Common",
				"Parkour",
				"Butterfly",
				"Effect",
				"Patrol",
				"LevelAI",
				"AirPassage",
				"ContinuesVariableSpeedMovement",
				"TimePatrol",
				"Range",
				"Way",
				"MotorSlide",
				"SwordRiderRail"
			};
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x0009C7DC File Offset: 0x0009A9DC
		public static ESplineType[] GetValues()
		{
			return new ESplineType[]
			{
				ESplineType.Common,
				ESplineType.Parkour,
				ESplineType.Butterfly,
				ESplineType.Effect,
				ESplineType.Patrol,
				ESplineType.LevelAI,
				ESplineType.AirPassage,
				ESplineType.ContinuesVariableSpeedMovement,
				ESplineType.TimePatrol,
				ESplineType.Range,
				ESplineType.Way,
				ESplineType.MotorSlide,
				ESplineType.SwordRiderRail
			};
		}

		// Token: 0x06003D15 RID: 15637 RVA: 0x0009C7F0 File Offset: 0x0009A9F0
		public static string[] GetNames()
		{
			return new string[]
			{
				"Common",
				"Parkour",
				"Butterfly",
				"Effect",
				"Patrol",
				"LevelAI",
				"AirPassage",
				"ContinuesVariableSpeedMovement",
				"TimePatrol",
				"Range",
				"Way",
				"MotorSlide",
				"SwordRiderRail"
			};
		}
	}
}
