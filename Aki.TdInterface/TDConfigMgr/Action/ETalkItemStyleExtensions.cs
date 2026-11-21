using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026F6 RID: 9974
	public static class ETalkItemStyleExtensions
	{
		// Token: 0x0600D6AD RID: 54957 RVA: 0x001F5344 File Offset: 0x001F3544
		public static string ToEnumString(this ETalkItemStyle value)
		{
			string result;
			switch (value)
			{
			case ETalkItemStyle.InnerVoice:
				result = "InnerVoice";
				break;
			case ETalkItemStyle.PhoneSendError:
				result = "PhoneSendError";
				break;
			case ETalkItemStyle.SceneUiSubtitle:
				result = "SceneUiSubtitle";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D6AE RID: 54958 RVA: 0x001F538C File Offset: 0x001F358C
		public static ETalkItemStyle FromString(string name)
		{
			ETalkItemStyle result;
			if (!ETalkItemStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkItemStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D6AF RID: 54959 RVA: 0x001F53B8 File Offset: 0x001F35B8
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
			if (name == "PhoneSendError")
			{
				value = ETalkItemStyle.PhoneSendError;
				return true;
			}
			if (!(name == "SceneUiSubtitle"))
			{
				value = ETalkItemStyle.InnerVoice;
				return false;
			}
			value = ETalkItemStyle.SceneUiSubtitle;
			return true;
		}

		// Token: 0x0600D6B0 RID: 54960 RVA: 0x001F540E File Offset: 0x001F360E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"InnerVoice",
				"PhoneSendError",
				"SceneUiSubtitle"
			};
		}

		// Token: 0x0600D6B1 RID: 54961 RVA: 0x001F542E File Offset: 0x001F362E
		public static ETalkItemStyle[] GetValues()
		{
			return new ETalkItemStyle[]
			{
				ETalkItemStyle.InnerVoice,
				ETalkItemStyle.PhoneSendError,
				ETalkItemStyle.SceneUiSubtitle
			};
		}

		// Token: 0x0600D6B2 RID: 54962 RVA: 0x001F543E File Offset: 0x001F363E
		public static string[] GetNames()
		{
			return new string[]
			{
				"InnerVoice",
				"PhoneSendError",
				"SceneUiSubtitle"
			};
		}
	}
}
