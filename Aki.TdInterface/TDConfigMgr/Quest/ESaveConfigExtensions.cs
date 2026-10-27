using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200128A RID: 4746
	public static class ESaveConfigExtensions
	{
		// Token: 0x06006B14 RID: 27412 RVA: 0x00100DE8 File Offset: 0x000FEFE8
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

		// Token: 0x06006B15 RID: 27413 RVA: 0x00100E20 File Offset: 0x000FF020
		public static ESaveConfig FromString(string name)
		{
			ESaveConfig result;
			if (!ESaveConfigExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESaveConfig 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B16 RID: 27414 RVA: 0x00100E49 File Offset: 0x000FF049
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

		// Token: 0x06006B17 RID: 27415 RVA: 0x00100E82 File Offset: 0x000FF082
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SaveNew",
				"SavePoint"
			};
		}

		// Token: 0x06006B18 RID: 27416 RVA: 0x00100E9A File Offset: 0x000FF09A
		public static ESaveConfig[] GetValues()
		{
			return new ESaveConfig[]
			{
				ESaveConfig.SaveNew,
				ESaveConfig.SavePoint
			};
		}

		// Token: 0x06006B19 RID: 27417 RVA: 0x00100EA6 File Offset: 0x000FF0A6
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
