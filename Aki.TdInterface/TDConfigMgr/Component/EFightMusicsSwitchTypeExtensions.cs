using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F7 RID: 2551
	public static class EFightMusicsSwitchTypeExtensions
	{
		// Token: 0x060038EA RID: 14570 RVA: 0x00093614 File Offset: 0x00091814
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

		// Token: 0x060038EB RID: 14571 RVA: 0x0009363C File Offset: 0x0009183C
		public static EFightMusicsSwitchType FromString(string name)
		{
			EFightMusicsSwitchType result;
			if (!EFightMusicsSwitchTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFightMusicsSwitchType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x00093665 File Offset: 0x00091865
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

		// Token: 0x060038ED RID: 14573 RVA: 0x0009368A File Offset: 0x0009188A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SwitchByTag"
			};
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x0009369A File Offset: 0x0009189A
		public static EFightMusicsSwitchType[] GetValues()
		{
			return new EFightMusicsSwitchType[1];
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x000936A2 File Offset: 0x000918A2
		public static string[] GetNames()
		{
			return new string[]
			{
				"SwitchByTag"
			};
		}
	}
}
