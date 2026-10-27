using System;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x020001A0 RID: 416
	public static class PlatformSdkServerMsgExtensions
	{
		// Token: 0x06000B79 RID: 2937 RVA: 0x00048C20 File Offset: 0x00046E20
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

		// Token: 0x06000B7A RID: 2938 RVA: 0x00048C58 File Offset: 0x00046E58
		public static PlatformSdkServerMsg FromString(string name)
		{
			PlatformSdkServerMsg result;
			if (!PlatformSdkServerMsgExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 PlatformSdkServerMsg 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00048C81 File Offset: 0x00046E81
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

		// Token: 0x06000B7C RID: 2940 RVA: 0x00048CBA File Offset: 0x00046EBA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HttpFail",
				"PsnAuthFail"
			};
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00048CD2 File Offset: 0x00046ED2
		public static PlatformSdkServerMsg[] GetValues()
		{
			return new PlatformSdkServerMsg[]
			{
				PlatformSdkServerMsg.BadHttp,
				PlatformSdkServerMsg.PsnAuthFail
			};
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00048CDE File Offset: 0x00046EDE
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
