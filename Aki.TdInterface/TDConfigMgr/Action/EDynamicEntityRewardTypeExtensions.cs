using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200230B RID: 8971
	public static class EDynamicEntityRewardTypeExtensions
	{
		// Token: 0x0600C430 RID: 50224 RVA: 0x001CA4B4 File Offset: 0x001C86B4
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

		// Token: 0x0600C431 RID: 50225 RVA: 0x001CA4DC File Offset: 0x001C86DC
		public static EDynamicEntityRewardType FromString(string name)
		{
			EDynamicEntityRewardType result;
			if (!EDynamicEntityRewardTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDynamicEntityRewardType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C432 RID: 50226 RVA: 0x001CA505 File Offset: 0x001C8705
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

		// Token: 0x0600C433 RID: 50227 RVA: 0x001CA52A File Offset: 0x001C872A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Traffic"
			};
		}

		// Token: 0x0600C434 RID: 50228 RVA: 0x001CA53A File Offset: 0x001C873A
		public static EDynamicEntityRewardType[] GetValues()
		{
			return new EDynamicEntityRewardType[1];
		}

		// Token: 0x0600C435 RID: 50229 RVA: 0x001CA542 File Offset: 0x001C8742
		public static string[] GetNames()
		{
			return new string[]
			{
				"Traffic"
			};
		}
	}
}
