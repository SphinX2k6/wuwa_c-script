using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022CB RID: 8907
	public static class ECameraOperationTypeExtensions
	{
		// Token: 0x0600C310 RID: 49936 RVA: 0x001C8198 File Offset: 0x001C6398
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

		// Token: 0x0600C311 RID: 49937 RVA: 0x001C81E0 File Offset: 0x001C63E0
		public static ECameraOperationType FromString(string name)
		{
			ECameraOperationType result;
			if (!ECameraOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECameraOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C312 RID: 49938 RVA: 0x001C820C File Offset: 0x001C640C
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

		// Token: 0x0600C313 RID: 49939 RVA: 0x001C8262 File Offset: 0x001C6462
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"EnableSection",
				"Disable"
			};
		}

		// Token: 0x0600C314 RID: 49940 RVA: 0x001C8282 File Offset: 0x001C6482
		public static ECameraOperationType[] GetValues()
		{
			return new ECameraOperationType[]
			{
				ECameraOperationType.Enable,
				ECameraOperationType.EnableSection,
				ECameraOperationType.Disable
			};
		}

		// Token: 0x0600C315 RID: 49941 RVA: 0x001C8292 File Offset: 0x001C6492
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
