using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000946 RID: 2374
	public static class EFanInteractTypeExtensions
	{
		// Token: 0x0600356C RID: 13676 RVA: 0x0008B848 File Offset: 0x00089A48
		public static string ToEnumString(this EFanInteractType value)
		{
			string result;
			if (value != EFanInteractType.Hit)
			{
				if (value != EFanInteractType.FKey)
				{
					result = value.ToString();
				}
				else
				{
					result = "FKey";
				}
			}
			else
			{
				result = "Hit";
			}
			return result;
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x0008B880 File Offset: 0x00089A80
		public static EFanInteractType FromString(string name)
		{
			EFanInteractType result;
			if (!EFanInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFanInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x0008B8A9 File Offset: 0x00089AA9
		public static bool TryFromString(string name, out EFanInteractType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFanInteractType.Hit;
				return false;
			}
			if (name == "Hit")
			{
				value = EFanInteractType.Hit;
				return true;
			}
			if (!(name == "FKey"))
			{
				value = EFanInteractType.Hit;
				return false;
			}
			value = EFanInteractType.FKey;
			return true;
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x0008B8E2 File Offset: 0x00089AE2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Hit",
				"FKey"
			};
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x0008B8FA File Offset: 0x00089AFA
		public static EFanInteractType[] GetValues()
		{
			return new EFanInteractType[]
			{
				EFanInteractType.Hit,
				EFanInteractType.FKey
			};
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x0008B906 File Offset: 0x00089B06
		public static string[] GetNames()
		{
			return new string[]
			{
				"Hit",
				"FKey"
			};
		}
	}
}
