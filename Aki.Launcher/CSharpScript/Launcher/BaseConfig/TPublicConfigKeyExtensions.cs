using System;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000276 RID: 630
	public static class TPublicConfigKeyExtensions
	{
		// Token: 0x06000F50 RID: 3920 RVA: 0x0005947C File Offset: 0x0005767C
		public static string ToEnumString(this TPublicConfigKey value)
		{
			string result;
			switch (value)
			{
			case TPublicConfigKey.AppTag:
				result = "AppTag";
				break;
			case TPublicConfigKey.CheckEntryTime:
				result = "CheckEntryTime";
				break;
			case TPublicConfigKey.InternalPrefix:
				result = "InternalPrefix";
				break;
			case TPublicConfigKey.PushAppId:
				result = "PushAppId";
				break;
			case TPublicConfigKey.PushAppKey:
				result = "PushAppKey";
				break;
			case TPublicConfigKey.PushAppSecret:
				result = "PushAppSecret";
				break;
			case TPublicConfigKey.SdkArea:
				result = "SdkArea";
				break;
			case TPublicConfigKey.TaptapClientId:
				result = "TaptapClientId";
				break;
			case TPublicConfigKey.TaptapClientToken:
				result = "TaptapClientToken";
				break;
			case TPublicConfigKey.TDMAppId:
				result = "TDMAppId";
				break;
			case TPublicConfigKey.TDMAppKey:
				result = "TDMAppKey";
				break;
			case TPublicConfigKey.TDMUrl:
				result = "TDMUrl";
				break;
			case TPublicConfigKey.UrlPath:
				result = "UrlPath";
				break;
			case TPublicConfigKey.UseSDK:
				result = "UseSDK";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00059548 File Offset: 0x00057748
		public static TPublicConfigKey FromString(string name)
		{
			TPublicConfigKey result;
			if (!TPublicConfigKeyExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 TPublicConfigKey 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00059574 File Offset: 0x00057774
		public static bool TryFromString(string name, out TPublicConfigKey value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = TPublicConfigKey.AppTag;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 6:
				{
					char c = name[0];
					if (c != 'A')
					{
						if (c != 'T')
						{
							if (c == 'U')
							{
								if (name == "UseSDK")
								{
									value = TPublicConfigKey.UseSDK;
									return true;
								}
							}
						}
						else if (name == "TDMUrl")
						{
							value = TPublicConfigKey.TDMUrl;
							return true;
						}
					}
					else if (name == "AppTag")
					{
						value = TPublicConfigKey.AppTag;
						return true;
					}
					break;
				}
				case 7:
				{
					char c = name[0];
					if (c != 'S')
					{
						if (c == 'U')
						{
							if (name == "UrlPath")
							{
								value = TPublicConfigKey.UrlPath;
								return true;
							}
						}
					}
					else if (name == "SdkArea")
					{
						value = TPublicConfigKey.SdkArea;
						return true;
					}
					break;
				}
				case 8:
					if (name == "TDMAppId")
					{
						value = TPublicConfigKey.TDMAppId;
						return true;
					}
					break;
				case 9:
				{
					char c = name[0];
					if (c != 'P')
					{
						if (c == 'T')
						{
							if (name == "TDMAppKey")
							{
								value = TPublicConfigKey.TDMAppKey;
								return true;
							}
						}
					}
					else if (name == "PushAppId")
					{
						value = TPublicConfigKey.PushAppId;
						return true;
					}
					break;
				}
				case 10:
					if (name == "PushAppKey")
					{
						value = TPublicConfigKey.PushAppKey;
						return true;
					}
					break;
				case 13:
					if (name == "PushAppSecret")
					{
						value = TPublicConfigKey.PushAppSecret;
						return true;
					}
					break;
				case 14:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c != 'I')
						{
							if (c == 'T')
							{
								if (name == "TaptapClientId")
								{
									value = TPublicConfigKey.TaptapClientId;
									return true;
								}
							}
						}
						else if (name == "InternalPrefix")
						{
							value = TPublicConfigKey.InternalPrefix;
							return true;
						}
					}
					else if (name == "CheckEntryTime")
					{
						value = TPublicConfigKey.CheckEntryTime;
						return true;
					}
					break;
				}
				case 17:
					if (name == "TaptapClientToken")
					{
						value = TPublicConfigKey.TaptapClientToken;
						return true;
					}
					break;
				}
			}
			value = TPublicConfigKey.AppTag;
			return false;
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x000597B0 File Offset: 0x000579B0
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AppTag",
				"CheckEntryTime",
				"InternalPrefix",
				"PushAppId",
				"PushAppKey",
				"PushAppSecret",
				"SdkArea",
				"TaptapClientId",
				"TaptapClientToken",
				"TDMAppId",
				"TDMAppKey",
				"TDMUrl",
				"UrlPath",
				"UseSDK"
			};
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00059839 File Offset: 0x00057A39
		public static TPublicConfigKey[] GetValues()
		{
			return new TPublicConfigKey[]
			{
				TPublicConfigKey.AppTag,
				TPublicConfigKey.CheckEntryTime,
				TPublicConfigKey.InternalPrefix,
				TPublicConfigKey.PushAppId,
				TPublicConfigKey.PushAppKey,
				TPublicConfigKey.PushAppSecret,
				TPublicConfigKey.SdkArea,
				TPublicConfigKey.TaptapClientId,
				TPublicConfigKey.TaptapClientToken,
				TPublicConfigKey.TDMAppId,
				TPublicConfigKey.TDMAppKey,
				TPublicConfigKey.TDMUrl,
				TPublicConfigKey.UrlPath,
				TPublicConfigKey.UseSDK
			};
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00059850 File Offset: 0x00057A50
		public static string[] GetNames()
		{
			return new string[]
			{
				"AppTag",
				"CheckEntryTime",
				"InternalPrefix",
				"PushAppId",
				"PushAppKey",
				"PushAppSecret",
				"SdkArea",
				"TaptapClientId",
				"TaptapClientToken",
				"TDMAppId",
				"TDMAppKey",
				"TDMUrl",
				"UrlPath",
				"UseSDK"
			};
		}
	}
}
