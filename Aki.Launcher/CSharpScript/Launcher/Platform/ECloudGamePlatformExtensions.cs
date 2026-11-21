using System;

namespace CSharpScript.Launcher.Platform
{
	// Token: 0x0200012D RID: 301
	public static class ECloudGamePlatformExtensions
	{
		// Token: 0x060009C4 RID: 2500 RVA: 0x00045624 File Offset: 0x00043824
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

		// Token: 0x060009C5 RID: 2501 RVA: 0x00045678 File Offset: 0x00043878
		public static ECloudGamePlatform FromString(string name)
		{
			ECloudGamePlatform result;
			if (!ECloudGamePlatformExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECloudGamePlatform 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x000456A4 File Offset: 0x000438A4
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

		// Token: 0x060009C7 RID: 2503 RVA: 0x0004570C File Offset: 0x0004390C
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

		// Token: 0x060009C8 RID: 2504 RVA: 0x00045734 File Offset: 0x00043934
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

		// Token: 0x060009C9 RID: 2505 RVA: 0x00045747 File Offset: 0x00043947
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
