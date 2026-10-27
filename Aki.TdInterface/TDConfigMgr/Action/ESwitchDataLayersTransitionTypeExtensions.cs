using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002441 RID: 9281
	public static class ESwitchDataLayersTransitionTypeExtensions
	{
		// Token: 0x0600C9A3 RID: 51619 RVA: 0x001D8538 File Offset: 0x001D6738
		public static string ToEnumString(this ESwitchDataLayersTransitionType value)
		{
			string result;
			if (value == ESwitchDataLayersTransitionType.Sequence)
			{
				result = "Sequence";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C9A4 RID: 51620 RVA: 0x001D8560 File Offset: 0x001D6760
		public static ESwitchDataLayersTransitionType FromString(string name)
		{
			ESwitchDataLayersTransitionType result;
			if (!ESwitchDataLayersTransitionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESwitchDataLayersTransitionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C9A5 RID: 51621 RVA: 0x001D8589 File Offset: 0x001D6789
		public static bool TryFromString(string name, out ESwitchDataLayersTransitionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESwitchDataLayersTransitionType.Sequence;
				return false;
			}
			if (name == "Sequence")
			{
				value = ESwitchDataLayersTransitionType.Sequence;
				return true;
			}
			value = ESwitchDataLayersTransitionType.Sequence;
			return false;
		}

		// Token: 0x0600C9A6 RID: 51622 RVA: 0x001D85AE File Offset: 0x001D67AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Sequence"
			};
		}

		// Token: 0x0600C9A7 RID: 51623 RVA: 0x001D85BE File Offset: 0x001D67BE
		public static ESwitchDataLayersTransitionType[] GetValues()
		{
			return new ESwitchDataLayersTransitionType[1];
		}

		// Token: 0x0600C9A8 RID: 51624 RVA: 0x001D85C6 File Offset: 0x001D67C6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Sequence"
			};
		}
	}
}
