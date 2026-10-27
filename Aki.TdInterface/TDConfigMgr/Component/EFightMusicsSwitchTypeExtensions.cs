using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000948 RID: 2376
	public static class EFightMusicsSwitchTypeExtensions
	{
		// Token: 0x06003575 RID: 13685 RVA: 0x0008B95C File Offset: 0x00089B5C
		public static string ToEnumString(this EFightMusicsSwitchType value)
		{
			string result;
			if (value == EFightMusicsSwitchType.SwitchByTag)
			{
				result = "SwitchByTag";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x0008B984 File Offset: 0x00089B84
		public static EFightMusicsSwitchType FromString(string name)
		{
			EFightMusicsSwitchType result;
			if (!EFightMusicsSwitchTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFightMusicsSwitchType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x0008B9AD File Offset: 0x00089BAD
		public static bool TryFromString(string name, out EFightMusicsSwitchType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFightMusicsSwitchType.SwitchByTag;
				return false;
			}
			if (name == "SwitchByTag")
			{
				value = EFightMusicsSwitchType.SwitchByTag;
				return true;
			}
			value = EFightMusicsSwitchType.SwitchByTag;
			return false;
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x0008B9D2 File Offset: 0x00089BD2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SwitchByTag"
			};
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x0008B9E2 File Offset: 0x00089BE2
		public static EFightMusicsSwitchType[] GetValues()
		{
			return new EFightMusicsSwitchType[1];
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x0008B9EA File Offset: 0x00089BEA
		public static string[] GetNames()
		{
			return new string[]
			{
				"SwitchByTag"
			};
		}
	}
}
