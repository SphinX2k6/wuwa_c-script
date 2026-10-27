using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023CB RID: 9163
	public static class EPieceColorTypeExtensions
	{
		// Token: 0x0600C790 RID: 51088 RVA: 0x001D365C File Offset: 0x001D185C
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

		// Token: 0x0600C791 RID: 51089 RVA: 0x001D36C8 File Offset: 0x001D18C8
		public static EPieceColorType FromString(string name)
		{
			EPieceColorType result;
			if (!EPieceColorTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPieceColorType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C792 RID: 51090 RVA: 0x001D36F4 File Offset: 0x001D18F4
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

		// Token: 0x0600C793 RID: 51091 RVA: 0x001D3780 File Offset: 0x001D1980
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

		// Token: 0x0600C794 RID: 51092 RVA: 0x001D37B8 File Offset: 0x001D19B8
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

		// Token: 0x0600C795 RID: 51093 RVA: 0x001D37CB File Offset: 0x001D19CB
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
