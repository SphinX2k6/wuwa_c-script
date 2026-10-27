using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200249F RID: 9375
	public static class EVillageInfrBuildTypeExtensions
	{
		// Token: 0x0600CB4A RID: 52042 RVA: 0x001DED30 File Offset: 0x001DCF30
		public static string ToEnumString(this EVillageInfrBuildType value)
		{
			string result;
			if (value != EVillageInfrBuildType.Village)
			{
				if (value != EVillageInfrBuildType.Tree)
				{
					result = value.ToString();
				}
				else
				{
					result = "Tree";
				}
			}
			else
			{
				result = "Village";
			}
			return result;
		}

		// Token: 0x0600CB4B RID: 52043 RVA: 0x001DED68 File Offset: 0x001DCF68
		public static EVillageInfrBuildType FromString(string name)
		{
			EVillageInfrBuildType result;
			if (!EVillageInfrBuildTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVillageInfrBuildType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB4C RID: 52044 RVA: 0x001DED91 File Offset: 0x001DCF91
		public static bool TryFromString(string name, out EVillageInfrBuildType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVillageInfrBuildType.Village;
				return false;
			}
			if (name == "Village")
			{
				value = EVillageInfrBuildType.Village;
				return true;
			}
			if (!(name == "Tree"))
			{
				value = EVillageInfrBuildType.Village;
				return false;
			}
			value = EVillageInfrBuildType.Tree;
			return true;
		}

		// Token: 0x0600CB4D RID: 52045 RVA: 0x001DEDCA File Offset: 0x001DCFCA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Village",
				"Tree"
			};
		}

		// Token: 0x0600CB4E RID: 52046 RVA: 0x001DEDE2 File Offset: 0x001DCFE2
		public static EVillageInfrBuildType[] GetValues()
		{
			return new EVillageInfrBuildType[]
			{
				EVillageInfrBuildType.Village,
				EVillageInfrBuildType.Tree
			};
		}

		// Token: 0x0600CB4F RID: 52047 RVA: 0x001DEDEE File Offset: 0x001DCFEE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Village",
				"Tree"
			};
		}
	}
}
