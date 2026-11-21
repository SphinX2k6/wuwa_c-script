using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013B4 RID: 5044
	public static class ERangeLimitingPriorityExtensions
	{
		// Token: 0x06007104 RID: 28932 RVA: 0x0010DAA4 File Offset: 0x0010BCA4
		public static string ToEnumString(this ERangeLimitingPriority value)
		{
			string result;
			if (value != ERangeLimitingPriority.Low)
			{
				if (value != ERangeLimitingPriority.High)
				{
					result = value.ToString();
				}
				else
				{
					result = "High";
				}
			}
			else
			{
				result = "Low";
			}
			return result;
		}

		// Token: 0x06007105 RID: 28933 RVA: 0x0010DADC File Offset: 0x0010BCDC
		public static ERangeLimitingPriority FromString(string name)
		{
			ERangeLimitingPriority result;
			if (!ERangeLimitingPriorityExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERangeLimitingPriority 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007106 RID: 28934 RVA: 0x0010DB05 File Offset: 0x0010BD05
		public static bool TryFromString(string name, out ERangeLimitingPriority value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERangeLimitingPriority.Low;
				return false;
			}
			if (name == "Low")
			{
				value = ERangeLimitingPriority.Low;
				return true;
			}
			if (!(name == "High"))
			{
				value = ERangeLimitingPriority.Low;
				return false;
			}
			value = ERangeLimitingPriority.High;
			return true;
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x0010DB3E File Offset: 0x0010BD3E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Low",
				"High"
			};
		}

		// Token: 0x06007108 RID: 28936 RVA: 0x0010DB56 File Offset: 0x0010BD56
		public static ERangeLimitingPriority[] GetValues()
		{
			return new ERangeLimitingPriority[]
			{
				ERangeLimitingPriority.Low,
				ERangeLimitingPriority.High
			};
		}

		// Token: 0x06007109 RID: 28937 RVA: 0x0010DB62 File Offset: 0x0010BD62
		public static string[] GetNames()
		{
			return new string[]
			{
				"Low",
				"High"
			};
		}
	}
}
