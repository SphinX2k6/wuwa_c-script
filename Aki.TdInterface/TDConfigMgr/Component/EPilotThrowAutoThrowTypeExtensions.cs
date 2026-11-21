using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A97 RID: 2711
	public static class EPilotThrowAutoThrowTypeExtensions
	{
		// Token: 0x06003BBA RID: 15290 RVA: 0x00099A58 File Offset: 0x00097C58
		public static string ToEnumString(this EPilotThrowAutoThrowType value)
		{
			string result;
			if (value != EPilotThrowAutoThrowType.LowAngle)
			{
				if (value != EPilotThrowAutoThrowType.HighAngle)
				{
					result = value.ToString();
				}
				else
				{
					result = "HighAngle";
				}
			}
			else
			{
				result = "LowAngle";
			}
			return result;
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x00099A90 File Offset: 0x00097C90
		public static EPilotThrowAutoThrowType FromString(string name)
		{
			EPilotThrowAutoThrowType result;
			if (!EPilotThrowAutoThrowTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPilotThrowAutoThrowType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x00099AB9 File Offset: 0x00097CB9
		public static bool TryFromString(string name, out EPilotThrowAutoThrowType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPilotThrowAutoThrowType.LowAngle;
				return false;
			}
			if (name == "LowAngle")
			{
				value = EPilotThrowAutoThrowType.LowAngle;
				return true;
			}
			if (!(name == "HighAngle"))
			{
				value = EPilotThrowAutoThrowType.LowAngle;
				return false;
			}
			value = EPilotThrowAutoThrowType.HighAngle;
			return true;
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x00099AF2 File Offset: 0x00097CF2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LowAngle",
				"HighAngle"
			};
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x00099B0A File Offset: 0x00097D0A
		public static EPilotThrowAutoThrowType[] GetValues()
		{
			return new EPilotThrowAutoThrowType[]
			{
				EPilotThrowAutoThrowType.LowAngle,
				EPilotThrowAutoThrowType.HighAngle
			};
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x00099B16 File Offset: 0x00097D16
		public static string[] GetNames()
		{
			return new string[]
			{
				"LowAngle",
				"HighAngle"
			};
		}
	}
}
