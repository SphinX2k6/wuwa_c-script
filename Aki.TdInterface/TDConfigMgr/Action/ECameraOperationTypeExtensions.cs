using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200253A RID: 9530
	public static class ECameraOperationTypeExtensions
	{
		// Token: 0x0600CEDF RID: 52959 RVA: 0x001DFFA0 File Offset: 0x001DE1A0
		public static string ToEnumString(this ECameraOperationType value)
		{
			string result;
			switch (value)
			{
			case ECameraOperationType.Enable:
				result = "Enable";
				break;
			case ECameraOperationType.EnableSection:
				result = "EnableSection";
				break;
			case ECameraOperationType.Disable:
				result = "Disable";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CEE0 RID: 52960 RVA: 0x001DFFE8 File Offset: 0x001DE1E8
		public static ECameraOperationType FromString(string name)
		{
			ECameraOperationType result;
			if (!ECameraOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECameraOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CEE1 RID: 52961 RVA: 0x001E0014 File Offset: 0x001DE214
		public static bool TryFromString(string name, out ECameraOperationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECameraOperationType.Enable;
				return false;
			}
			if (name == "Enable")
			{
				value = ECameraOperationType.Enable;
				return true;
			}
			if (name == "EnableSection")
			{
				value = ECameraOperationType.EnableSection;
				return true;
			}
			if (!(name == "Disable"))
			{
				value = ECameraOperationType.Enable;
				return false;
			}
			value = ECameraOperationType.Disable;
			return true;
		}

		// Token: 0x0600CEE2 RID: 52962 RVA: 0x001E006A File Offset: 0x001DE26A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"EnableSection",
				"Disable"
			};
		}

		// Token: 0x0600CEE3 RID: 52963 RVA: 0x001E008A File Offset: 0x001DE28A
		public static ECameraOperationType[] GetValues()
		{
			return new ECameraOperationType[]
			{
				ECameraOperationType.Enable,
				ECameraOperationType.EnableSection,
				ECameraOperationType.Disable
			};
		}

		// Token: 0x0600CEE4 RID: 52964 RVA: 0x001E009A File Offset: 0x001DE29A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Enable",
				"EnableSection",
				"Disable"
			};
		}
	}
}
