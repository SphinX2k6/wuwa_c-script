using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001274 RID: 4724
	public static class ERangeLimitingPriorityExtensions
	{
		// Token: 0x06006AB1 RID: 27313 RVA: 0x000FFE78 File Offset: 0x000FE078
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

		// Token: 0x06006AB2 RID: 27314 RVA: 0x000FFEB0 File Offset: 0x000FE0B0
		public static ERangeLimitingPriority FromString(string name)
		{
			ERangeLimitingPriority result;
			if (!ERangeLimitingPriorityExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERangeLimitingPriority 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006AB3 RID: 27315 RVA: 0x000FFED9 File Offset: 0x000FE0D9
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

		// Token: 0x06006AB4 RID: 27316 RVA: 0x000FFF12 File Offset: 0x000FE112
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Low",
				"High"
			};
		}

		// Token: 0x06006AB5 RID: 27317 RVA: 0x000FFF2A File Offset: 0x000FE12A
		public static ERangeLimitingPriority[] GetValues()
		{
			return new ERangeLimitingPriority[]
			{
				ERangeLimitingPriority.Low,
				ERangeLimitingPriority.High
			};
		}

		// Token: 0x06006AB6 RID: 27318 RVA: 0x000FFF36 File Offset: 0x000FE136
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
