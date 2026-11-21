using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013C8 RID: 5064
	public static class ERollBlockLaunchMethodExtensions
	{
		// Token: 0x0600715E RID: 29022 RVA: 0x0010E9D0 File Offset: 0x0010CBD0
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

		// Token: 0x0600715F RID: 29023 RVA: 0x0010EA08 File Offset: 0x0010CC08
		public static ERollBlockLaunchMethod FromString(string name)
		{
			ERollBlockLaunchMethod result;
			if (!ERollBlockLaunchMethodExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERollBlockLaunchMethod 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x0010EA31 File Offset: 0x0010CC31
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

		// Token: 0x06007161 RID: 29025 RVA: 0x0010EA6A File Offset: 0x0010CC6A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Interact",
				"Range"
			};
		}

		// Token: 0x06007162 RID: 29026 RVA: 0x0010EA82 File Offset: 0x0010CC82
		public static ERollBlockLaunchMethod[] GetValues()
		{
			return new ERollBlockLaunchMethod[]
			{
				ERollBlockLaunchMethod.Interact,
				ERollBlockLaunchMethod.Range
			};
		}

		// Token: 0x06007163 RID: 29027 RVA: 0x0010EA8E File Offset: 0x0010CC8E
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
