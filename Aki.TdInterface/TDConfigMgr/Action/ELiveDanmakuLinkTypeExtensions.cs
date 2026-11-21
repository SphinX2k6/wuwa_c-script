using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025EA RID: 9706
	public static class ELiveDanmakuLinkTypeExtensions
	{
		// Token: 0x0600D1F7 RID: 53751 RVA: 0x001E86D8 File Offset: 0x001E68D8
		public static string ToEnumString(this ELiveDanmakuLinkType value)
		{
			string result;
			if (value != ELiveDanmakuLinkType.KeepCurrent)
			{
				if (value != ELiveDanmakuLinkType.ClearAndReload)
				{
					result = value.ToString();
				}
				else
				{
					result = "ClearAndReload";
				}
			}
			else
			{
				result = "KeepCurrent";
			}
			return result;
		}

		// Token: 0x0600D1F8 RID: 53752 RVA: 0x001E8710 File Offset: 0x001E6910
		public static ELiveDanmakuLinkType FromString(string name)
		{
			ELiveDanmakuLinkType result;
			if (!ELiveDanmakuLinkTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELiveDanmakuLinkType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D1F9 RID: 53753 RVA: 0x001E8739 File Offset: 0x001E6939
		public static bool TryFromString(string name, out ELiveDanmakuLinkType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELiveDanmakuLinkType.KeepCurrent;
				return false;
			}
			if (name == "KeepCurrent")
			{
				value = ELiveDanmakuLinkType.KeepCurrent;
				return true;
			}
			if (!(name == "ClearAndReload"))
			{
				value = ELiveDanmakuLinkType.KeepCurrent;
				return false;
			}
			value = ELiveDanmakuLinkType.ClearAndReload;
			return true;
		}

		// Token: 0x0600D1FA RID: 53754 RVA: 0x001E8772 File Offset: 0x001E6972
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"KeepCurrent",
				"ClearAndReload"
			};
		}

		// Token: 0x0600D1FB RID: 53755 RVA: 0x001E878A File Offset: 0x001E698A
		public static ELiveDanmakuLinkType[] GetValues()
		{
			return new ELiveDanmakuLinkType[]
			{
				ELiveDanmakuLinkType.KeepCurrent,
				ELiveDanmakuLinkType.ClearAndReload
			};
		}

		// Token: 0x0600D1FC RID: 53756 RVA: 0x001E8796 File Offset: 0x001E6996
		public static string[] GetNames()
		{
			return new string[]
			{
				"KeepCurrent",
				"ClearAndReload"
			};
		}
	}
}
