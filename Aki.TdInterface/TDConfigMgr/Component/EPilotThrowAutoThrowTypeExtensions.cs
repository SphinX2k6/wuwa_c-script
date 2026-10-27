using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D2 RID: 2514
	public static class EPilotThrowAutoThrowTypeExtensions
	{
		// Token: 0x060037E2 RID: 14306 RVA: 0x00091198 File Offset: 0x0008F398
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

		// Token: 0x060037E3 RID: 14307 RVA: 0x000911D0 File Offset: 0x0008F3D0
		public static EPilotThrowAutoThrowType FromString(string name)
		{
			EPilotThrowAutoThrowType result;
			if (!EPilotThrowAutoThrowTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPilotThrowAutoThrowType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x000911F9 File Offset: 0x0008F3F9
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

		// Token: 0x060037E5 RID: 14309 RVA: 0x00091232 File Offset: 0x0008F432
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LowAngle",
				"HighAngle"
			};
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x0009124A File Offset: 0x0008F44A
		public static EPilotThrowAutoThrowType[] GetValues()
		{
			return new EPilotThrowAutoThrowType[]
			{
				EPilotThrowAutoThrowType.LowAngle,
				EPilotThrowAutoThrowType.HighAngle
			};
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x00091256 File Offset: 0x0008F456
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
