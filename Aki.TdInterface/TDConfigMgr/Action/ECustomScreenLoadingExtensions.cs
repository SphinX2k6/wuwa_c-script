using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022F3 RID: 8947
	public static class ECustomScreenLoadingExtensions
	{
		// Token: 0x0600C3C4 RID: 50116 RVA: 0x001C980C File Offset: 0x001C7A0C
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

		// Token: 0x0600C3C5 RID: 50117 RVA: 0x001C9834 File Offset: 0x001C7A34
		public static ECustomScreenLoading FromString(string name)
		{
			ECustomScreenLoading result;
			if (!ECustomScreenLoadingExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECustomScreenLoading 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C3C6 RID: 50118 RVA: 0x001C985D File Offset: 0x001C7A5D
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

		// Token: 0x0600C3C7 RID: 50119 RVA: 0x001C9882 File Offset: 0x001C7A82
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Cyberpunk"
			};
		}

		// Token: 0x0600C3C8 RID: 50120 RVA: 0x001C9892 File Offset: 0x001C7A92
		public static ECustomScreenLoading[] GetValues()
		{
			return new ECustomScreenLoading[1];
		}

		// Token: 0x0600C3C9 RID: 50121 RVA: 0x001C989A File Offset: 0x001C7A9A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Cyberpunk"
			};
		}
	}
}
