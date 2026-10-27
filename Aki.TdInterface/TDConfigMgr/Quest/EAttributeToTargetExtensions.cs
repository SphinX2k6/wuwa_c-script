using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001226 RID: 4646
	public static class EAttributeToTargetExtensions
	{
		// Token: 0x06006952 RID: 26962 RVA: 0x000FAF54 File Offset: 0x000F9154
		public static string ToEnumString(this EAttributeToTarget value)
		{
			string result;
			if (value == EAttributeToTarget.Health)
			{
				result = "Health";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x000FAF7C File Offset: 0x000F917C
		public static EAttributeToTarget FromString(string name)
		{
			EAttributeToTarget result;
			if (!EAttributeToTargetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAttributeToTarget 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x000FAFA5 File Offset: 0x000F91A5
		public static bool TryFromString(string name, out EAttributeToTarget value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAttributeToTarget.Health;
				return false;
			}
			if (name == "Health")
			{
				value = EAttributeToTarget.Health;
				return true;
			}
			value = EAttributeToTarget.Health;
			return false;
		}

		// Token: 0x06006955 RID: 26965 RVA: 0x000FAFCA File Offset: 0x000F91CA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Health"
			};
		}

		// Token: 0x06006956 RID: 26966 RVA: 0x000FAFDA File Offset: 0x000F91DA
		public static EAttributeToTarget[] GetValues()
		{
			return new EAttributeToTarget[1];
		}

		// Token: 0x06006957 RID: 26967 RVA: 0x000FAFE2 File Offset: 0x000F91E2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Health"
			};
		}
	}
}
