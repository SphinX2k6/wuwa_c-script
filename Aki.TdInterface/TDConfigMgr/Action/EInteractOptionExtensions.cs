using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002361 RID: 9057
	public static class EInteractOptionExtensions
	{
		// Token: 0x0600C5B3 RID: 50611 RVA: 0x001CE8E0 File Offset: 0x001CCAE0
		public static string ToEnumString(this EInteractOption value)
		{
			string result;
			if (value != EInteractOption.Flow)
			{
				if (value != EInteractOption.Actions)
				{
					result = value.ToString();
				}
				else
				{
					result = "Actions";
				}
			}
			else
			{
				result = "Flow";
			}
			return result;
		}

		// Token: 0x0600C5B4 RID: 50612 RVA: 0x001CE918 File Offset: 0x001CCB18
		public static EInteractOption FromString(string name)
		{
			EInteractOption result;
			if (!EInteractOptionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractOption 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C5B5 RID: 50613 RVA: 0x001CE941 File Offset: 0x001CCB41
		public static bool TryFromString(string name, out EInteractOption value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInteractOption.Flow;
				return false;
			}
			if (name == "Flow")
			{
				value = EInteractOption.Flow;
				return true;
			}
			if (!(name == "Actions"))
			{
				value = EInteractOption.Flow;
				return false;
			}
			value = EInteractOption.Actions;
			return true;
		}

		// Token: 0x0600C5B6 RID: 50614 RVA: 0x001CE97A File Offset: 0x001CCB7A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Flow",
				"Actions"
			};
		}

		// Token: 0x0600C5B7 RID: 50615 RVA: 0x001CE992 File Offset: 0x001CCB92
		public static EInteractOption[] GetValues()
		{
			return new EInteractOption[]
			{
				EInteractOption.Flow,
				EInteractOption.Actions
			};
		}

		// Token: 0x0600C5B8 RID: 50616 RVA: 0x001CE99E File Offset: 0x001CCB9E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Flow",
				"Actions"
			};
		}
	}
}
