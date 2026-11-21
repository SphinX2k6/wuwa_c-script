using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013F4 RID: 5108
	public static class ETrackViewModeExtensions
	{
		// Token: 0x06007224 RID: 29220 RVA: 0x0011123C File Offset: 0x0010F43C
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

		// Token: 0x06007225 RID: 29221 RVA: 0x00111274 File Offset: 0x0010F474
		public static ETrackViewMode FromString(string name)
		{
			ETrackViewMode result;
			if (!ETrackViewModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrackViewMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007226 RID: 29222 RVA: 0x0011129D File Offset: 0x0010F49D
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

		// Token: 0x06007227 RID: 29223 RVA: 0x001112D6 File Offset: 0x0010F4D6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"All",
				"Nearest"
			};
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x001112EE File Offset: 0x0010F4EE
		public static ETrackViewMode[] GetValues()
		{
			return new ETrackViewMode[]
			{
				ETrackViewMode.All,
				ETrackViewMode.Nearest
			};
		}

		// Token: 0x06007229 RID: 29225 RVA: 0x001112FA File Offset: 0x0010F4FA
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
