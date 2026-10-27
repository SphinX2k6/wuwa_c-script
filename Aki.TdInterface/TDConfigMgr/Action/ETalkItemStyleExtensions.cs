using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002455 RID: 9301
	public static class ETalkItemStyleExtensions
	{
		// Token: 0x0600C9FD RID: 51709 RVA: 0x001DB2D4 File Offset: 0x001D94D4
		public static string ToEnumString(this ETalkItemStyle value)
		{
			string result;
			if (value != ETalkItemStyle.InnerVoice)
			{
				if (value != ETalkItemStyle.PhoneSendError)
				{
					result = value.ToString();
				}
				else
				{
					result = "PhoneSendError";
				}
			}
			else
			{
				result = "InnerVoice";
			}
			return result;
		}

		// Token: 0x0600C9FE RID: 51710 RVA: 0x001DB30C File Offset: 0x001D950C
		public static ETalkItemStyle FromString(string name)
		{
			ETalkItemStyle result;
			if (!ETalkItemStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkItemStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C9FF RID: 51711 RVA: 0x001DB335 File Offset: 0x001D9535
		public static bool TryFromString(string name, out ETalkItemStyle value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETalkItemStyle.InnerVoice;
				return false;
			}
			if (name == "InnerVoice")
			{
				value = ETalkItemStyle.InnerVoice;
				return true;
			}
			if (!(name == "PhoneSendError"))
			{
				value = ETalkItemStyle.InnerVoice;
				return false;
			}
			value = ETalkItemStyle.PhoneSendError;
			return true;
		}

		// Token: 0x0600CA00 RID: 51712 RVA: 0x001DB36E File Offset: 0x001D956E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"InnerVoice",
				"PhoneSendError"
			};
		}

		// Token: 0x0600CA01 RID: 51713 RVA: 0x001DB386 File Offset: 0x001D9586
		public static ETalkItemStyle[] GetValues()
		{
			return new ETalkItemStyle[]
			{
				ETalkItemStyle.InnerVoice,
				ETalkItemStyle.PhoneSendError
			};
		}

		// Token: 0x0600CA02 RID: 51714 RVA: 0x001DB392 File Offset: 0x001D9592
		public static string[] GetNames()
		{
			return new string[]
			{
				"InnerVoice",
				"PhoneSendError"
			};
		}
	}
}
