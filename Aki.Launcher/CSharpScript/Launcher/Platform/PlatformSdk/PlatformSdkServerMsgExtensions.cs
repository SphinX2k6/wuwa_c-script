using System;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x020001A4 RID: 420
	public static class PlatformSdkServerMsgExtensions
	{
		// Token: 0x06000BB0 RID: 2992 RVA: 0x0004B410 File Offset: 0x00049610
		public static string ToEnumString(this PlatformSdkServerMsg value)
		{
			string result;
			if (value != PlatformSdkServerMsg.BadHttp)
			{
				if (value != PlatformSdkServerMsg.PsnAuthFail)
				{
					result = value.ToString();
				}
				else
				{
					result = "PsnAuthFail";
				}
			}
			else
			{
				result = "HttpFail";
			}
			return result;
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0004B448 File Offset: 0x00049648
		public static PlatformSdkServerMsg FromString(string name)
		{
			PlatformSdkServerMsg result;
			if (!PlatformSdkServerMsgExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 PlatformSdkServerMsg 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0004B471 File Offset: 0x00049671
		public static bool TryFromString(string name, out PlatformSdkServerMsg value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = PlatformSdkServerMsg.BadHttp;
				return false;
			}
			if (name == "HttpFail")
			{
				value = PlatformSdkServerMsg.BadHttp;
				return true;
			}
			if (!(name == "PsnAuthFail"))
			{
				value = PlatformSdkServerMsg.BadHttp;
				return false;
			}
			value = PlatformSdkServerMsg.PsnAuthFail;
			return true;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0004B4AA File Offset: 0x000496AA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HttpFail",
				"PsnAuthFail"
			};
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0004B4C2 File Offset: 0x000496C2
		public static PlatformSdkServerMsg[] GetValues()
		{
			return new PlatformSdkServerMsg[]
			{
				PlatformSdkServerMsg.BadHttp,
				PlatformSdkServerMsg.PsnAuthFail
			};
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0004B4CE File Offset: 0x000496CE
		public static string[] GetNames()
		{
			return new string[]
			{
				"BadHttp",
				"PsnAuthFail"
			};
		}
	}
}
