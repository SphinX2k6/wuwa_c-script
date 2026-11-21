using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A57 RID: 2647
	public static class EMotorAutoEjectTypeExtensions
	{
		// Token: 0x06003A9A RID: 15002 RVA: 0x00097330 File Offset: 0x00095530
		public static string ToEnumString(this EMotorAutoEjectType value)
		{
			string result;
			if (value != EMotorAutoEjectType.NextHook)
			{
				if (value != EMotorAutoEjectType.PositionEntity)
				{
					result = value.ToString();
				}
				else
				{
					result = "PositionEntity";
				}
			}
			else
			{
				result = "NextHook";
			}
			return result;
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x00097368 File Offset: 0x00095568
		public static EMotorAutoEjectType FromString(string name)
		{
			EMotorAutoEjectType result;
			if (!EMotorAutoEjectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorAutoEjectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x00097391 File Offset: 0x00095591
		public static bool TryFromString(string name, out EMotorAutoEjectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMotorAutoEjectType.NextHook;
				return false;
			}
			if (name == "NextHook")
			{
				value = EMotorAutoEjectType.NextHook;
				return true;
			}
			if (!(name == "PositionEntity"))
			{
				value = EMotorAutoEjectType.NextHook;
				return false;
			}
			value = EMotorAutoEjectType.PositionEntity;
			return true;
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x000973CA File Offset: 0x000955CA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"NextHook",
				"PositionEntity"
			};
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x000973E2 File Offset: 0x000955E2
		public static EMotorAutoEjectType[] GetValues()
		{
			return new EMotorAutoEjectType[]
			{
				EMotorAutoEjectType.NextHook,
				EMotorAutoEjectType.PositionEntity
			};
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x000973EE File Offset: 0x000955EE
		public static string[] GetNames()
		{
			return new string[]
			{
				"NextHook",
				"PositionEntity"
			};
		}
	}
}
