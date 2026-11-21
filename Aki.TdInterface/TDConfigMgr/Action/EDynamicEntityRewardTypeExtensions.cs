using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200257A RID: 9594
	public static class EDynamicEntityRewardTypeExtensions
	{
		// Token: 0x0600CFFF RID: 53247 RVA: 0x001E237C File Offset: 0x001E057C
		public static string ToEnumString(this EDynamicEntityRewardType value)
		{
			string result;
			if (value == EDynamicEntityRewardType.Traffic)
			{
				result = "Traffic";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D000 RID: 53248 RVA: 0x001E23A4 File Offset: 0x001E05A4
		public static EDynamicEntityRewardType FromString(string name)
		{
			EDynamicEntityRewardType result;
			if (!EDynamicEntityRewardTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDynamicEntityRewardType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D001 RID: 53249 RVA: 0x001E23CD File Offset: 0x001E05CD
		public static bool TryFromString(string name, out EDynamicEntityRewardType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDynamicEntityRewardType.Traffic;
				return false;
			}
			if (name == "Traffic")
			{
				value = EDynamicEntityRewardType.Traffic;
				return true;
			}
			value = EDynamicEntityRewardType.Traffic;
			return false;
		}

		// Token: 0x0600D002 RID: 53250 RVA: 0x001E23F2 File Offset: 0x001E05F2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Traffic"
			};
		}

		// Token: 0x0600D003 RID: 53251 RVA: 0x001E2402 File Offset: 0x001E0602
		public static EDynamicEntityRewardType[] GetValues()
		{
			return new EDynamicEntityRewardType[1];
		}

		// Token: 0x0600D004 RID: 53252 RVA: 0x001E240A File Offset: 0x001E060A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Traffic"
			};
		}
	}
}
