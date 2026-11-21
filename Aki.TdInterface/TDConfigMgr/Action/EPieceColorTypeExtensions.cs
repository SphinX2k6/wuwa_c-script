using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002660 RID: 9824
	public static class EPieceColorTypeExtensions
	{
		// Token: 0x0600D40A RID: 54282 RVA: 0x001ECCF4 File Offset: 0x001EAEF4
		public static string ToEnumString(this EPieceColorType value)
		{
			string result;
			switch (value)
			{
			case EPieceColorType.White:
				result = "White";
				break;
			case EPieceColorType.Red:
				result = "Red";
				break;
			case EPieceColorType.Yellow:
				result = "Yellow";
				break;
			case EPieceColorType.Blue:
				result = "Blue";
				break;
			case EPieceColorType.Green:
				result = "Green";
				break;
			case EPieceColorType.Gray:
				result = "Gray";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D40B RID: 54283 RVA: 0x001ECD60 File Offset: 0x001EAF60
		public static EPieceColorType FromString(string name)
		{
			EPieceColorType result;
			if (!EPieceColorTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPieceColorType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D40C RID: 54284 RVA: 0x001ECD8C File Offset: 0x001EAF8C
		public static bool TryFromString(string name, out EPieceColorType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPieceColorType.White;
				return false;
			}
			if (name == "White")
			{
				value = EPieceColorType.White;
				return true;
			}
			if (name == "Red")
			{
				value = EPieceColorType.Red;
				return true;
			}
			if (name == "Yellow")
			{
				value = EPieceColorType.Yellow;
				return true;
			}
			if (name == "Blue")
			{
				value = EPieceColorType.Blue;
				return true;
			}
			if (name == "Green")
			{
				value = EPieceColorType.Green;
				return true;
			}
			if (!(name == "Gray"))
			{
				value = EPieceColorType.White;
				return false;
			}
			value = EPieceColorType.Gray;
			return true;
		}

		// Token: 0x0600D40D RID: 54285 RVA: 0x001ECE18 File Offset: 0x001EB018
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"White",
				"Red",
				"Yellow",
				"Blue",
				"Green",
				"Gray"
			};
		}

		// Token: 0x0600D40E RID: 54286 RVA: 0x001ECE50 File Offset: 0x001EB050
		public static EPieceColorType[] GetValues()
		{
			return new EPieceColorType[]
			{
				EPieceColorType.White,
				EPieceColorType.Red,
				EPieceColorType.Yellow,
				EPieceColorType.Blue,
				EPieceColorType.Green,
				EPieceColorType.Gray
			};
		}

		// Token: 0x0600D40F RID: 54287 RVA: 0x001ECE63 File Offset: 0x001EB063
		public static string[] GetNames()
		{
			return new string[]
			{
				"White",
				"Red",
				"Yellow",
				"Blue",
				"Green",
				"Gray"
			};
		}
	}
}
