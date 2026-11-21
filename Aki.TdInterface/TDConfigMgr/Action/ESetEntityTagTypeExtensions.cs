using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026A4 RID: 9892
	public static class ESetEntityTagTypeExtensions
	{
		// Token: 0x0600D53C RID: 54588 RVA: 0x001EF6C8 File Offset: 0x001ED8C8
		public static string ToEnumString(this ESetEntityTagType value)
		{
			string result;
			if (value != ESetEntityTagType.Add)
			{
				if (value != ESetEntityTagType.Remove)
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

		// Token: 0x0600D53D RID: 54589 RVA: 0x001EF700 File Offset: 0x001ED900
		public static ESetEntityTagType FromString(string name)
		{
			ESetEntityTagType result;
			if (!ESetEntityTagTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetEntityTagType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D53E RID: 54590 RVA: 0x001EF729 File Offset: 0x001ED929
		public static bool TryFromString(string name, out ESetEntityTagType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESetEntityTagType.Add;
				return false;
			}
			if (name == "Add")
			{
				value = ESetEntityTagType.Add;
				return true;
			}
			if (!(name == "Remove"))
			{
				value = ESetEntityTagType.Add;
				return false;
			}
			value = ESetEntityTagType.Remove;
			return true;
		}

		// Token: 0x0600D53F RID: 54591 RVA: 0x001EF762 File Offset: 0x001ED962
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Add",
				"Remove"
			};
		}

		// Token: 0x0600D540 RID: 54592 RVA: 0x001EF77A File Offset: 0x001ED97A
		public static ESetEntityTagType[] GetValues()
		{
			return new ESetEntityTagType[]
			{
				ESetEntityTagType.Add,
				ESetEntityTagType.Remove
			};
		}

		// Token: 0x0600D541 RID: 54593 RVA: 0x001EF786 File Offset: 0x001ED986
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
