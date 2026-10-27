using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001288 RID: 4744
	public static class ERollBlockLaunchMethodExtensions
	{
		// Token: 0x06006B0B RID: 27403 RVA: 0x00100CD4 File Offset: 0x000FEED4
		public static string ToEnumString(this ERollBlockLaunchMethod value)
		{
			string result;
			if (value != ERollBlockLaunchMethod.Interact)
			{
				if (value != ERollBlockLaunchMethod.Range)
				{
					result = value.ToString();
				}
				else
				{
					result = "Range";
				}
			}
			else
			{
				result = "Interact";
			}
			return result;
		}

		// Token: 0x06006B0C RID: 27404 RVA: 0x00100D0C File Offset: 0x000FEF0C
		public static ERollBlockLaunchMethod FromString(string name)
		{
			ERollBlockLaunchMethod result;
			if (!ERollBlockLaunchMethodExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERollBlockLaunchMethod 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B0D RID: 27405 RVA: 0x00100D35 File Offset: 0x000FEF35
		public static bool TryFromString(string name, out ERollBlockLaunchMethod value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERollBlockLaunchMethod.Interact;
				return false;
			}
			if (name == "Interact")
			{
				value = ERollBlockLaunchMethod.Interact;
				return true;
			}
			if (!(name == "Range"))
			{
				value = ERollBlockLaunchMethod.Interact;
				return false;
			}
			value = ERollBlockLaunchMethod.Range;
			return true;
		}

		// Token: 0x06006B0E RID: 27406 RVA: 0x00100D6E File Offset: 0x000FEF6E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Interact",
				"Range"
			};
		}

		// Token: 0x06006B0F RID: 27407 RVA: 0x00100D86 File Offset: 0x000FEF86
		public static ERollBlockLaunchMethod[] GetValues()
		{
			return new ERollBlockLaunchMethod[]
			{
				ERollBlockLaunchMethod.Interact,
				ERollBlockLaunchMethod.Range
			};
		}

		// Token: 0x06006B10 RID: 27408 RVA: 0x00100D92 File Offset: 0x000FEF92
		public static string[] GetNames()
		{
			return new string[]
			{
				"Interact",
				"Range"
			};
		}
	}
}
