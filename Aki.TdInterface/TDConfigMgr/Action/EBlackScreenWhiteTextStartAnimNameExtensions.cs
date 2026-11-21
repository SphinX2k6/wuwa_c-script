using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200252A RID: 9514
	public static class EBlackScreenWhiteTextStartAnimNameExtensions
	{
		// Token: 0x0600CE97 RID: 52887 RVA: 0x001DF39C File Offset: 0x001DD59C
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

		// Token: 0x0600CE98 RID: 52888 RVA: 0x001DF3E4 File Offset: 0x001DD5E4
		public static EBlackScreenWhiteTextStartAnimName FromString(string name)
		{
			EBlackScreenWhiteTextStartAnimName result;
			if (!EBlackScreenWhiteTextStartAnimNameExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBlackScreenWhiteTextStartAnimName 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE99 RID: 52889 RVA: 0x001DF410 File Offset: 0x001DD610
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

		// Token: 0x0600CE9A RID: 52890 RVA: 0x001DF466 File Offset: 0x001DD666
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Start01",
				"Start02",
				"Start03"
			};
		}

		// Token: 0x0600CE9B RID: 52891 RVA: 0x001DF486 File Offset: 0x001DD686
		public static EBlackScreenWhiteTextStartAnimName[] GetValues()
		{
			return new EBlackScreenWhiteTextStartAnimName[]
			{
				EBlackScreenWhiteTextStartAnimName.Start01,
				EBlackScreenWhiteTextStartAnimName.Start02,
				EBlackScreenWhiteTextStartAnimName.Start03
			};
		}

		// Token: 0x0600CE9C RID: 52892 RVA: 0x001DF496 File Offset: 0x001DD696
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
