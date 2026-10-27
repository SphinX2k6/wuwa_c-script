using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A2 RID: 2466
	public static class EMotorAutoEjectTypeExtensions
	{
		// Token: 0x0600370A RID: 14090 RVA: 0x0008F26C File Offset: 0x0008D46C
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

		// Token: 0x0600370B RID: 14091 RVA: 0x0008F2A4 File Offset: 0x0008D4A4
		public static EMotorAutoEjectType FromString(string name)
		{
			EMotorAutoEjectType result;
			if (!EMotorAutoEjectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorAutoEjectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x0008F2CD File Offset: 0x0008D4CD
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

		// Token: 0x0600370D RID: 14093 RVA: 0x0008F306 File Offset: 0x0008D506
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"NextHook",
				"PositionEntity"
			};
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x0008F31E File Offset: 0x0008D51E
		public static EMotorAutoEjectType[] GetValues()
		{
			return new EMotorAutoEjectType[]
			{
				EMotorAutoEjectType.NextHook,
				EMotorAutoEjectType.PositionEntity
			};
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x0008F32A File Offset: 0x0008D52A
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
