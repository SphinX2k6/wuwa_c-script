using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012AE RID: 4782
	public static class ETrackViewModeExtensions
	{
		// Token: 0x06006BB6 RID: 27574 RVA: 0x00103274 File Offset: 0x00101474
		public static string ToEnumString(this ETrackViewMode value)
		{
			string result;
			if (value != ETrackViewMode.All)
			{
				if (value != ETrackViewMode.Nearest)
				{
					result = value.ToString();
				}
				else
				{
					result = "Nearest";
				}
			}
			else
			{
				result = "All";
			}
			return result;
		}

		// Token: 0x06006BB7 RID: 27575 RVA: 0x001032AC File Offset: 0x001014AC
		public static ETrackViewMode FromString(string name)
		{
			ETrackViewMode result;
			if (!ETrackViewModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrackViewMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006BB8 RID: 27576 RVA: 0x001032D5 File Offset: 0x001014D5
		public static bool TryFromString(string name, out ETrackViewMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETrackViewMode.All;
				return false;
			}
			if (name == "All")
			{
				value = ETrackViewMode.All;
				return true;
			}
			if (!(name == "Nearest"))
			{
				value = ETrackViewMode.All;
				return false;
			}
			value = ETrackViewMode.Nearest;
			return true;
		}

		// Token: 0x06006BB9 RID: 27577 RVA: 0x0010330E File Offset: 0x0010150E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"All",
				"Nearest"
			};
		}

		// Token: 0x06006BBA RID: 27578 RVA: 0x00103326 File Offset: 0x00101526
		public static ETrackViewMode[] GetValues()
		{
			return new ETrackViewMode[]
			{
				ETrackViewMode.All,
				ETrackViewMode.Nearest
			};
		}

		// Token: 0x06006BBB RID: 27579 RVA: 0x00103332 File Offset: 0x00101532
		public static string[] GetNames()
		{
			return new string[]
			{
				"All",
				"Nearest"
			};
		}
	}
}
