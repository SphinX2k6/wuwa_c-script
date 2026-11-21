using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000997 RID: 2455
	public static class EAirWallSpawnStyleExtensions
	{
		// Token: 0x0600373A RID: 14138 RVA: 0x0008C2A4 File Offset: 0x0008A4A4
		public static string ToEnumString(this EAirWallSpawnStyle value)
		{
			string result;
			if (value != EAirWallSpawnStyle.AlongSpline)
			{
				if (value != EAirWallSpawnStyle.BothSides)
				{
					result = value.ToString();
				}
				else
				{
					result = "BothSides";
				}
			}
			else
			{
				result = "AlongSpline";
			}
			return result;
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x0008C2DC File Offset: 0x0008A4DC
		public static EAirWallSpawnStyle FromString(string name)
		{
			EAirWallSpawnStyle result;
			if (!EAirWallSpawnStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAirWallSpawnStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x0008C305 File Offset: 0x0008A505
		public static bool TryFromString(string name, out EAirWallSpawnStyle value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAirWallSpawnStyle.AlongSpline;
				return false;
			}
			if (name == "AlongSpline")
			{
				value = EAirWallSpawnStyle.AlongSpline;
				return true;
			}
			if (!(name == "BothSides"))
			{
				value = EAirWallSpawnStyle.AlongSpline;
				return false;
			}
			value = EAirWallSpawnStyle.BothSides;
			return true;
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x0008C33E File Offset: 0x0008A53E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AlongSpline",
				"BothSides"
			};
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x0008C356 File Offset: 0x0008A556
		public static EAirWallSpawnStyle[] GetValues()
		{
			return new EAirWallSpawnStyle[]
			{
				EAirWallSpawnStyle.AlongSpline,
				EAirWallSpawnStyle.BothSides
			};
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x0008C362 File Offset: 0x0008A562
		public static string[] GetNames()
		{
			return new string[]
			{
				"AlongSpline",
				"BothSides"
			};
		}
	}
}
