using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002562 RID: 9570
	public static class ECustomScreenLoadingExtensions
	{
		// Token: 0x0600CF93 RID: 53139 RVA: 0x001E1658 File Offset: 0x001DF858
		public static string ToEnumString(this ECustomScreenLoading value)
		{
			string result;
			if (value == ECustomScreenLoading.Cyberpunk)
			{
				result = "Cyberpunk";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CF94 RID: 53140 RVA: 0x001E1680 File Offset: 0x001DF880
		public static ECustomScreenLoading FromString(string name)
		{
			ECustomScreenLoading result;
			if (!ECustomScreenLoadingExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECustomScreenLoading 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF95 RID: 53141 RVA: 0x001E16A9 File Offset: 0x001DF8A9
		public static bool TryFromString(string name, out ECustomScreenLoading value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECustomScreenLoading.Cyberpunk;
				return false;
			}
			if (name == "Cyberpunk")
			{
				value = ECustomScreenLoading.Cyberpunk;
				return true;
			}
			value = ECustomScreenLoading.Cyberpunk;
			return false;
		}

		// Token: 0x0600CF96 RID: 53142 RVA: 0x001E16CE File Offset: 0x001DF8CE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Cyberpunk"
			};
		}

		// Token: 0x0600CF97 RID: 53143 RVA: 0x001E16DE File Offset: 0x001DF8DE
		public static ECustomScreenLoading[] GetValues()
		{
			return new ECustomScreenLoading[1];
		}

		// Token: 0x0600CF98 RID: 53144 RVA: 0x001E16E6 File Offset: 0x001DF8E6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Cyberpunk"
			};
		}
	}
}
