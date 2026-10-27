using System;

namespace CSharpScript.Launcher.Platform
{
	// Token: 0x02000129 RID: 297
	public static class ECloudGamePlatformExtensions
	{
		// Token: 0x06000990 RID: 2448 RVA: 0x00043210 File Offset: 0x00041410
		public static string ToEnumString(this ECloudGamePlatform value)
		{
			string result;
			switch (value)
			{
			case ECloudGamePlatform.Android:
				result = "Android";
				break;
			case ECloudGamePlatform.IOS:
				result = "IOS";
				break;
			case ECloudGamePlatform.Mac:
				result = "Mac";
				break;
			case ECloudGamePlatform.Windows:
				result = "Windows";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00043264 File Offset: 0x00041464
		public static ECloudGamePlatform FromString(string name)
		{
			ECloudGamePlatform result;
			if (!ECloudGamePlatformExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECloudGamePlatform 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00043290 File Offset: 0x00041490
		public static bool TryFromString(string name, out ECloudGamePlatform value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECloudGamePlatform.Android;
				return false;
			}
			if (name == "Android")
			{
				value = ECloudGamePlatform.Android;
				return true;
			}
			if (name == "IOS")
			{
				value = ECloudGamePlatform.IOS;
				return true;
			}
			if (name == "Mac")
			{
				value = ECloudGamePlatform.Mac;
				return true;
			}
			if (!(name == "Windows"))
			{
				value = ECloudGamePlatform.Android;
				return false;
			}
			value = ECloudGamePlatform.Windows;
			return true;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x000432F8 File Offset: 0x000414F8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Android",
				"IOS",
				"Mac",
				"Windows"
			};
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00043320 File Offset: 0x00041520
		public static ECloudGamePlatform[] GetValues()
		{
			return new ECloudGamePlatform[]
			{
				ECloudGamePlatform.Android,
				ECloudGamePlatform.IOS,
				ECloudGamePlatform.Mac,
				ECloudGamePlatform.Windows
			};
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00043333 File Offset: 0x00041533
		public static string[] GetNames()
		{
			return new string[]
			{
				"Android",
				"IOS",
				"Mac",
				"Windows"
			};
		}
	}
}
