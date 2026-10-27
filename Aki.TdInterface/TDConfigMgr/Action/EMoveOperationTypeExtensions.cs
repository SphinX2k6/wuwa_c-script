using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200239D RID: 9117
	public static class EMoveOperationTypeExtensions
	{
		// Token: 0x0600C6C1 RID: 50881 RVA: 0x001D1AE0 File Offset: 0x001CFCE0
		public static string ToEnumString(this EMoveOperationType value)
		{
			string result;
			if (value != EMoveOperationType.Enable)
			{
				if (value != EMoveOperationType.Disable)
				{
					result = value.ToString();
				}
				else
				{
					result = "Disable";
				}
			}
			else
			{
				result = "Enable";
			}
			return result;
		}

		// Token: 0x0600C6C2 RID: 50882 RVA: 0x001D1B18 File Offset: 0x001CFD18
		public static EMoveOperationType FromString(string name)
		{
			EMoveOperationType result;
			if (!EMoveOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMoveOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C6C3 RID: 50883 RVA: 0x001D1B41 File Offset: 0x001CFD41
		public static bool TryFromString(string name, out EMoveOperationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMoveOperationType.Enable;
				return false;
			}
			if (name == "Enable")
			{
				value = EMoveOperationType.Enable;
				return true;
			}
			if (!(name == "Disable"))
			{
				value = EMoveOperationType.Enable;
				return false;
			}
			value = EMoveOperationType.Disable;
			return true;
		}

		// Token: 0x0600C6C4 RID: 50884 RVA: 0x001D1B7A File Offset: 0x001CFD7A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}

		// Token: 0x0600C6C5 RID: 50885 RVA: 0x001D1B92 File Offset: 0x001CFD92
		public static EMoveOperationType[] GetValues()
		{
			return new EMoveOperationType[]
			{
				EMoveOperationType.Enable,
				EMoveOperationType.Disable
			};
		}

		// Token: 0x0600C6C6 RID: 50886 RVA: 0x001D1B9E File Offset: 0x001CFD9E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}
	}
}
