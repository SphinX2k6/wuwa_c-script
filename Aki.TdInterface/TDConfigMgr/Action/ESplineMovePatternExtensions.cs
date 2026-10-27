using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002429 RID: 9257
	public static class ESplineMovePatternExtensions
	{
		// Token: 0x0600C937 RID: 51511 RVA: 0x001D7640 File Offset: 0x001D5840
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
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C938 RID: 51512 RVA: 0x001D76AC File Offset: 0x001D58AC
		public static ESplineMovePattern FromString(string name)
		{
			ESplineMovePattern result;
			if (!ESplineMovePatternExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESplineMovePattern 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C939 RID: 51513 RVA: 0x001D76D8 File Offset: 0x001D58D8
		public static bool TryFromString(string name, out ESplineMovePattern value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESplineMovePattern.PathLine;
				return false;
			}
			if (name == "PathLine")
			{
				value = ESplineMovePattern.PathLine;
				return true;
			}
			if (name == "RacingTrack")
			{
				value = ESplineMovePattern.RacingTrack;
				return true;
			}
			if (name == "SlideTrack")
			{
				value = ESplineMovePattern.SlideTrack;
				return true;
			}
			if (name == "AirPassage")
			{
				value = ESplineMovePattern.AirPassage;
				return true;
			}
			if (name == "MotorcycleTrack")
			{
				value = ESplineMovePattern.MotorcycleTrack;
				return true;
			}
			if (!(name == "MechaAirPassage"))
			{
				value = ESplineMovePattern.PathLine;
				return false;
			}
			value = ESplineMovePattern.MechaAirPassage;
			return true;
		}

		// Token: 0x0600C93A RID: 51514 RVA: 0x001D7764 File Offset: 0x001D5964
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PathLine",
				"RacingTrack",
				"SlideTrack",
				"AirPassage",
				"MotorcycleTrack",
				"MechaAirPassage"
			};
		}

		// Token: 0x0600C93B RID: 51515 RVA: 0x001D779C File Offset: 0x001D599C
		public static ESplineMovePattern[] GetValues()
		{
			return new ESplineMovePattern[]
			{
				ESplineMovePattern.PathLine,
				ESplineMovePattern.RacingTrack,
				ESplineMovePattern.SlideTrack,
				ESplineMovePattern.AirPassage,
				ESplineMovePattern.MotorcycleTrack,
				ESplineMovePattern.MechaAirPassage
			};
		}

		// Token: 0x0600C93C RID: 51516 RVA: 0x001D77AF File Offset: 0x001D59AF
		public static string[] GetNames()
		{
			return new string[]
			{
				"PathLine",
				"RacingTrack",
				"SlideTrack",
				"AirPassage",
				"MotorcycleTrack",
				"MechaAirPassage"
			};
		}
	}
}
