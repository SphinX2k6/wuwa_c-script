using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000995 RID: 2453
	public static class EAirWallSpawnModeExtensions
	{
		// Token: 0x06003731 RID: 14129 RVA: 0x0008C1C8 File Offset: 0x0008A3C8
		public static string ToEnumString(this EAirWallSpawnMode value)
		{
			string result;
			if (value == EAirWallSpawnMode.Whole)
			{
				result = "Whole";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x0008C1F0 File Offset: 0x0008A3F0
		public static EAirWallSpawnMode FromString(string name)
		{
			EAirWallSpawnMode result;
			if (!EAirWallSpawnModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAirWallSpawnMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x0008C219 File Offset: 0x0008A419
		public static bool TryFromString(string name, out EAirWallSpawnMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAirWallSpawnMode.Whole;
				return false;
			}
			if (name == "Whole")
			{
				value = EAirWallSpawnMode.Whole;
				return true;
			}
			value = EAirWallSpawnMode.Whole;
			return false;
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x0008C23E File Offset: 0x0008A43E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Whole"
			};
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x0008C24E File Offset: 0x0008A44E
		public static EAirWallSpawnMode[] GetValues()
		{
			return new EAirWallSpawnMode[1];
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x0008C256 File Offset: 0x0008A456
		public static string[] GetNames()
		{
			return new string[]
			{
				"Whole"
			};
		}
	}
}
