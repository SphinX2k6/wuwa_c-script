using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013CA RID: 5066
	public static class ESaveConfigExtensions
	{
		// Token: 0x06007167 RID: 29031 RVA: 0x0010EAE4 File Offset: 0x0010CCE4
		public static string ToEnumString(this ESaveConfig value)
		{
			string result;
			if (value != ESaveConfig.SaveNew)
			{
				if (value != ESaveConfig.SavePoint)
				{
					result = value.ToString();
				}
				else
				{
					result = "SavePoint";
				}
			}
			else
			{
				result = "SaveNew";
			}
			return result;
		}

		// Token: 0x06007168 RID: 29032 RVA: 0x0010EB1C File Offset: 0x0010CD1C
		public static ESaveConfig FromString(string name)
		{
			ESaveConfig result;
			if (!ESaveConfigExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESaveConfig 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007169 RID: 29033 RVA: 0x0010EB45 File Offset: 0x0010CD45
		public static bool TryFromString(string name, out ESaveConfig value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESaveConfig.SaveNew;
				return false;
			}
			if (name == "SaveNew")
			{
				value = ESaveConfig.SaveNew;
				return true;
			}
			if (!(name == "SavePoint"))
			{
				value = ESaveConfig.SaveNew;
				return false;
			}
			value = ESaveConfig.SavePoint;
			return true;
		}

		// Token: 0x0600716A RID: 29034 RVA: 0x0010EB7E File Offset: 0x0010CD7E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SaveNew",
				"SavePoint"
			};
		}

		// Token: 0x0600716B RID: 29035 RVA: 0x0010EB96 File Offset: 0x0010CD96
		public static ESaveConfig[] GetValues()
		{
			return new ESaveConfig[]
			{
				ESaveConfig.SaveNew,
				ESaveConfig.SavePoint
			};
		}

		// Token: 0x0600716C RID: 29036 RVA: 0x0010EBA2 File Offset: 0x0010CDA2
		public static string[] GetNames()
		{
			return new string[]
			{
				"SaveNew",
				"SavePoint"
			};
		}
	}
}
