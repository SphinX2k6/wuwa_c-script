using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200234B RID: 9035
	public static class EGroupAiCommunicateTypeExtensions
	{
		// Token: 0x0600C550 RID: 50512 RVA: 0x001CCD14 File Offset: 0x001CAF14
		public static string ToEnumString(this EGroupAiCommunicateType value)
		{
			string result;
			if (value != EGroupAiCommunicateType.AddTag)
			{
				if (value != EGroupAiCommunicateType.RemoveTag)
				{
					result = value.ToString();
				}
				else
				{
					result = "RemoveTag";
				}
			}
			else
			{
				result = "AddTag";
			}
			return result;
		}

		// Token: 0x0600C551 RID: 50513 RVA: 0x001CCD4C File Offset: 0x001CAF4C
		public static EGroupAiCommunicateType FromString(string name)
		{
			EGroupAiCommunicateType result;
			if (!EGroupAiCommunicateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGroupAiCommunicateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C552 RID: 50514 RVA: 0x001CCD75 File Offset: 0x001CAF75
		public static bool TryFromString(string name, out EGroupAiCommunicateType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGroupAiCommunicateType.AddTag;
				return false;
			}
			if (name == "AddTag")
			{
				value = EGroupAiCommunicateType.AddTag;
				return true;
			}
			if (!(name == "RemoveTag"))
			{
				value = EGroupAiCommunicateType.AddTag;
				return false;
			}
			value = EGroupAiCommunicateType.RemoveTag;
			return true;
		}

		// Token: 0x0600C553 RID: 50515 RVA: 0x001CCDAE File Offset: 0x001CAFAE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AddTag",
				"RemoveTag"
			};
		}

		// Token: 0x0600C554 RID: 50516 RVA: 0x001CCDC6 File Offset: 0x001CAFC6
		public static EGroupAiCommunicateType[] GetValues()
		{
			return new EGroupAiCommunicateType[]
			{
				EGroupAiCommunicateType.AddTag,
				EGroupAiCommunicateType.RemoveTag
			};
		}

		// Token: 0x0600C555 RID: 50517 RVA: 0x001CCDD2 File Offset: 0x001CAFD2
		public static string[] GetNames()
		{
			return new string[]
			{
				"AddTag",
				"RemoveTag"
			};
		}
	}
}
