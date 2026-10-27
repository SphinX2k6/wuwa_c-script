using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200229D RID: 8861
	public static class EAkEventMapExtensions
	{
		// Token: 0x0600C241 RID: 49729 RVA: 0x001C6274 File Offset: 0x001C4474
		public static string ToEnumString(this EAkEventMap value)
		{
			string result;
			if (value == EAkEventMap.PlayMapMusic)
			{
				result = "PlayMapMusic";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C242 RID: 49730 RVA: 0x001C629C File Offset: 0x001C449C
		public static EAkEventMap FromString(string name)
		{
			EAkEventMap result;
			if (!EAkEventMapExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAkEventMap 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C243 RID: 49731 RVA: 0x001C62C5 File Offset: 0x001C44C5
		public static bool TryFromString(string name, out EAkEventMap value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAkEventMap.PlayMapMusic;
				return false;
			}
			if (name == "PlayMapMusic")
			{
				value = EAkEventMap.PlayMapMusic;
				return true;
			}
			value = EAkEventMap.PlayMapMusic;
			return false;
		}

		// Token: 0x0600C244 RID: 49732 RVA: 0x001C62EA File Offset: 0x001C44EA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PlayMapMusic"
			};
		}

		// Token: 0x0600C245 RID: 49733 RVA: 0x001C62FA File Offset: 0x001C44FA
		public static EAkEventMap[] GetValues()
		{
			return new EAkEventMap[1];
		}

		// Token: 0x0600C246 RID: 49734 RVA: 0x001C6302 File Offset: 0x001C4502
		public static string[] GetNames()
		{
			return new string[]
			{
				"PlayMapMusic"
			};
		}
	}
}
