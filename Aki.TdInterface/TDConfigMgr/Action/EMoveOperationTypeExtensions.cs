using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002628 RID: 9768
	public static class EMoveOperationTypeExtensions
	{
		// Token: 0x0600D30E RID: 54030 RVA: 0x001EAC80 File Offset: 0x001E8E80
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

		// Token: 0x0600D30F RID: 54031 RVA: 0x001EACB8 File Offset: 0x001E8EB8
		public static EMoveOperationType FromString(string name)
		{
			EMoveOperationType result;
			if (!EMoveOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMoveOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D310 RID: 54032 RVA: 0x001EACE1 File Offset: 0x001E8EE1
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

		// Token: 0x0600D311 RID: 54033 RVA: 0x001EAD1A File Offset: 0x001E8F1A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}

		// Token: 0x0600D312 RID: 54034 RVA: 0x001EAD32 File Offset: 0x001E8F32
		public static EMoveOperationType[] GetValues()
		{
			return new EMoveOperationType[]
			{
				EMoveOperationType.Enable,
				EMoveOperationType.Disable
			};
		}

		// Token: 0x0600D313 RID: 54035 RVA: 0x001EAD3E File Offset: 0x001E8F3E
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
