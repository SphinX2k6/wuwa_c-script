using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002405 RID: 9221
	public static class ESetEntityTagTypeExtensions
	{
		// Token: 0x0600C895 RID: 51349 RVA: 0x001D5ACC File Offset: 0x001D3CCC
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

		// Token: 0x0600C896 RID: 51350 RVA: 0x001D5B04 File Offset: 0x001D3D04
		public static ESetEntityTagType FromString(string name)
		{
			ESetEntityTagType result;
			if (!ESetEntityTagTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetEntityTagType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C897 RID: 51351 RVA: 0x001D5B2D File Offset: 0x001D3D2D
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

		// Token: 0x0600C898 RID: 51352 RVA: 0x001D5B66 File Offset: 0x001D3D66
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Add",
				"Remove"
			};
		}

		// Token: 0x0600C899 RID: 51353 RVA: 0x001D5B7E File Offset: 0x001D3D7E
		public static ESetEntityTagType[] GetValues()
		{
			return new ESetEntityTagType[]
			{
				ESetEntityTagType.Add,
				ESetEntityTagType.Remove
			};
		}

		// Token: 0x0600C89A RID: 51354 RVA: 0x001D5B8A File Offset: 0x001D3D8A
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
