using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002510 RID: 9488
	public static class EAspectRatioExtensions
	{
		// Token: 0x0600CE22 RID: 52770 RVA: 0x001DE2E0 File Offset: 0x001DC4E0
		public static string ToEnumString(this EAspectRatio value)
		{
			string result;
			if (value != EAspectRatio.Ratio16x9)
			{
				if (value != EAspectRatio.Ratio21x9)
				{
					result = value.ToString();
				}
				else
				{
					result = "21:9";
				}
			}
			else
			{
				result = "16:9";
			}
			return result;
		}

		// Token: 0x0600CE23 RID: 52771 RVA: 0x001DE318 File Offset: 0x001DC518
		public static EAspectRatio FromString(string name)
		{
			EAspectRatio result;
			if (!EAspectRatioExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAspectRatio 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE24 RID: 52772 RVA: 0x001DE341 File Offset: 0x001DC541
		public static bool TryFromString(string name, out EAspectRatio value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAspectRatio.Ratio16x9;
				return false;
			}
			if (name == "16:9")
			{
				value = EAspectRatio.Ratio16x9;
				return true;
			}
			if (!(name == "21:9"))
			{
				value = EAspectRatio.Ratio16x9;
				return false;
			}
			value = EAspectRatio.Ratio21x9;
			return true;
		}

		// Token: 0x0600CE25 RID: 52773 RVA: 0x001DE37A File Offset: 0x001DC57A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"16:9",
				"21:9"
			};
		}

		// Token: 0x0600CE26 RID: 52774 RVA: 0x001DE392 File Offset: 0x001DC592
		public static EAspectRatio[] GetValues()
		{
			return new EAspectRatio[]
			{
				EAspectRatio.Ratio16x9,
				EAspectRatio.Ratio21x9
			};
		}

		// Token: 0x0600CE27 RID: 52775 RVA: 0x001DE39E File Offset: 0x001DC59E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Ratio16x9",
				"Ratio21x9"
			};
		}
	}
}
