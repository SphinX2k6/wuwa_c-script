using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200250A RID: 9482
	public static class EAkEventMapExtensions
	{
		// Token: 0x0600CE07 RID: 52743 RVA: 0x001DDF68 File Offset: 0x001DC168
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

		// Token: 0x0600CE08 RID: 52744 RVA: 0x001DDF90 File Offset: 0x001DC190
		public static EAkEventMap FromString(string name)
		{
			EAkEventMap result;
			if (!EAkEventMapExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAkEventMap 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE09 RID: 52745 RVA: 0x001DDFB9 File Offset: 0x001DC1B9
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

		// Token: 0x0600CE0A RID: 52746 RVA: 0x001DDFDE File Offset: 0x001DC1DE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PlayMapMusic"
			};
		}

		// Token: 0x0600CE0B RID: 52747 RVA: 0x001DDFEE File Offset: 0x001DC1EE
		public static EAkEventMap[] GetValues()
		{
			return new EAkEventMap[1];
		}

		// Token: 0x0600CE0C RID: 52748 RVA: 0x001DDFF6 File Offset: 0x001DC1F6
		public static string[] GetNames()
		{
			return new string[]
			{
				"PlayMapMusic"
			};
		}
	}
}
