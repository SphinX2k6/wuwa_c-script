using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002742 RID: 10050
	public static class EVillageInfrBuildTypeExtensions
	{
		// Token: 0x0600D803 RID: 55299 RVA: 0x001F8EF8 File Offset: 0x001F70F8
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

		// Token: 0x0600D804 RID: 55300 RVA: 0x001F8F30 File Offset: 0x001F7130
		public static EVillageInfrBuildType FromString(string name)
		{
			EVillageInfrBuildType result;
			if (!EVillageInfrBuildTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVillageInfrBuildType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D805 RID: 55301 RVA: 0x001F8F59 File Offset: 0x001F7159
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

		// Token: 0x0600D806 RID: 55302 RVA: 0x001F8F92 File Offset: 0x001F7192
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Village",
				"Tree"
			};
		}

		// Token: 0x0600D807 RID: 55303 RVA: 0x001F8FAA File Offset: 0x001F71AA
		public static EVillageInfrBuildType[] GetValues()
		{
			return new EVillageInfrBuildType[]
			{
				EVillageInfrBuildType.Village,
				EVillageInfrBuildType.Tree
			};
		}

		// Token: 0x0600D808 RID: 55304 RVA: 0x001F8FB6 File Offset: 0x001F71B6
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
