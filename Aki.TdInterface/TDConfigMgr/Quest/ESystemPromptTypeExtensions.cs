using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200129A RID: 4762
	public static class ESystemPromptTypeExtensions
	{
		// Token: 0x06006B5C RID: 27484 RVA: 0x00101F94 File Offset: 0x00100194
		public static string ToEnumString(this ESystemPromptType value)
		{
			string result;
			if (value == ESystemPromptType.AreaName)
			{
				result = "AreaName";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x00101FBC File Offset: 0x001001BC
		public static ESystemPromptType FromString(string name)
		{
			ESystemPromptType result;
			if (!ESystemPromptTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESystemPromptType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B5E RID: 27486 RVA: 0x00101FE5 File Offset: 0x001001E5
		public static bool TryFromString(string name, out ESystemPromptType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESystemPromptType.AreaName;
				return false;
			}
			if (name == "AreaName")
			{
				value = ESystemPromptType.AreaName;
				return true;
			}
			value = ESystemPromptType.AreaName;
			return false;
		}

		// Token: 0x06006B5F RID: 27487 RVA: 0x0010200A File Offset: 0x0010020A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AreaName"
			};
		}

		// Token: 0x06006B60 RID: 27488 RVA: 0x0010201A File Offset: 0x0010021A
		public static ESystemPromptType[] GetValues()
		{
			return new ESystemPromptType[1];
		}

		// Token: 0x06006B61 RID: 27489 RVA: 0x00102022 File Offset: 0x00100222
		public static string[] GetNames()
		{
			return new string[]
			{
				"AreaName"
			};
		}
	}
}
