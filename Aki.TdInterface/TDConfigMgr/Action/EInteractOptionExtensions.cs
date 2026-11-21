using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025D6 RID: 9686
	public static class EInteractOptionExtensions
	{
		// Token: 0x0600D19D RID: 53661 RVA: 0x001E6BC0 File Offset: 0x001E4DC0
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

		// Token: 0x0600D19E RID: 53662 RVA: 0x001E6BF8 File Offset: 0x001E4DF8
		public static EInteractOption FromString(string name)
		{
			EInteractOption result;
			if (!EInteractOptionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractOption 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D19F RID: 53663 RVA: 0x001E6C21 File Offset: 0x001E4E21
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

		// Token: 0x0600D1A0 RID: 53664 RVA: 0x001E6C5A File Offset: 0x001E4E5A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Flow",
				"Actions"
			};
		}

		// Token: 0x0600D1A1 RID: 53665 RVA: 0x001E6C72 File Offset: 0x001E4E72
		public static EInteractOption[] GetValues()
		{
			return new EInteractOption[]
			{
				EInteractOption.Flow,
				EInteractOption.Actions
			};
		}

		// Token: 0x0600D1A2 RID: 53666 RVA: 0x001E6C7E File Offset: 0x001E4E7E
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
