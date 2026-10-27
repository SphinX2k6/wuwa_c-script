using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022BB RID: 8891
	public static class EBlackScreenWhiteTextStartAnimNameExtensions
	{
		// Token: 0x0600C2C8 RID: 49864 RVA: 0x001C7594 File Offset: 0x001C5794
		public static string ToEnumString(this EBlackScreenWhiteTextStartAnimName value)
		{
			string result;
			switch (value)
			{
			case EBlackScreenWhiteTextStartAnimName.Start01:
				result = "Start01";
				break;
			case EBlackScreenWhiteTextStartAnimName.Start02:
				result = "Start02";
				break;
			case EBlackScreenWhiteTextStartAnimName.Start03:
				result = "Start03";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C2C9 RID: 49865 RVA: 0x001C75DC File Offset: 0x001C57DC
		public static EBlackScreenWhiteTextStartAnimName FromString(string name)
		{
			EBlackScreenWhiteTextStartAnimName result;
			if (!EBlackScreenWhiteTextStartAnimNameExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBlackScreenWhiteTextStartAnimName 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C2CA RID: 49866 RVA: 0x001C7608 File Offset: 0x001C5808
		public static bool TryFromString(string name, out EBlackScreenWhiteTextStartAnimName value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBlackScreenWhiteTextStartAnimName.Start01;
				return false;
			}
			if (name == "Start01")
			{
				value = EBlackScreenWhiteTextStartAnimName.Start01;
				return true;
			}
			if (name == "Start02")
			{
				value = EBlackScreenWhiteTextStartAnimName.Start02;
				return true;
			}
			if (!(name == "Start03"))
			{
				value = EBlackScreenWhiteTextStartAnimName.Start01;
				return false;
			}
			value = EBlackScreenWhiteTextStartAnimName.Start03;
			return true;
		}

		// Token: 0x0600C2CB RID: 49867 RVA: 0x001C765E File Offset: 0x001C585E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Start01",
				"Start02",
				"Start03"
			};
		}

		// Token: 0x0600C2CC RID: 49868 RVA: 0x001C767E File Offset: 0x001C587E
		public static EBlackScreenWhiteTextStartAnimName[] GetValues()
		{
			return new EBlackScreenWhiteTextStartAnimName[]
			{
				EBlackScreenWhiteTextStartAnimName.Start01,
				EBlackScreenWhiteTextStartAnimName.Start02,
				EBlackScreenWhiteTextStartAnimName.Start03
			};
		}

		// Token: 0x0600C2CD RID: 49869 RVA: 0x001C768E File Offset: 0x001C588E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Start01",
				"Start02",
				"Start03"
			};
		}
	}
}
