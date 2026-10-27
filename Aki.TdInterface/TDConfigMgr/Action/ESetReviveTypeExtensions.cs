using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200240B RID: 9227
	public static class ESetReviveTypeExtensions
	{
		// Token: 0x0600C8B0 RID: 51376 RVA: 0x001D5D98 File Offset: 0x001D3F98
		public static string ToEnumString(this ESetReviveType value)
		{
			string result;
			if (value != ESetReviveType.Add)
			{
				if (value != ESetReviveType.Remove)
				{
					result = value.ToString();
				}
				else
				{
					result = "Remove";
				}
			}
			else
			{
				result = "Add";
			}
			return result;
		}

		// Token: 0x0600C8B1 RID: 51377 RVA: 0x001D5DD0 File Offset: 0x001D3FD0
		public static ESetReviveType FromString(string name)
		{
			ESetReviveType result;
			if (!ESetReviveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetReviveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C8B2 RID: 51378 RVA: 0x001D5DF9 File Offset: 0x001D3FF9
		public static bool TryFromString(string name, out ESetReviveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESetReviveType.Add;
				return false;
			}
			if (name == "Add")
			{
				value = ESetReviveType.Add;
				return true;
			}
			if (!(name == "Remove"))
			{
				value = ESetReviveType.Add;
				return false;
			}
			value = ESetReviveType.Remove;
			return true;
		}

		// Token: 0x0600C8B3 RID: 51379 RVA: 0x001D5E32 File Offset: 0x001D4032
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Add",
				"Remove"
			};
		}

		// Token: 0x0600C8B4 RID: 51380 RVA: 0x001D5E4A File Offset: 0x001D404A
		public static ESetReviveType[] GetValues()
		{
			return new ESetReviveType[]
			{
				ESetReviveType.Add,
				ESetReviveType.Remove
			};
		}

		// Token: 0x0600C8B5 RID: 51381 RVA: 0x001D5E56 File Offset: 0x001D4056
		public static string[] GetNames()
		{
			return new string[]
			{
				"Add",
				"Remove"
			};
		}
	}
}
