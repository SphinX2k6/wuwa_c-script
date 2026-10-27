using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000914 RID: 2324
	public static class EControllerTypeExtensions
	{
		// Token: 0x0600348B RID: 13451 RVA: 0x000899F4 File Offset: 0x00087BF4
		public static string ToEnumString(this EControllerType value)
		{
			string result;
			if (value != EControllerType.FreeAngle)
			{
				if (value != EControllerType.FixedAngle)
				{
					result = value.ToString();
				}
				else
				{
					result = "FixedAngle";
				}
			}
			else
			{
				result = "FreeAngle";
			}
			return result;
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x00089A2C File Offset: 0x00087C2C
		public static EControllerType FromString(string name)
		{
			EControllerType result;
			if (!EControllerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EControllerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x00089A55 File Offset: 0x00087C55
		public static bool TryFromString(string name, out EControllerType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EControllerType.FreeAngle;
				return false;
			}
			if (name == "FreeAngle")
			{
				value = EControllerType.FreeAngle;
				return true;
			}
			if (!(name == "FixedAngle"))
			{
				value = EControllerType.FreeAngle;
				return false;
			}
			value = EControllerType.FixedAngle;
			return true;
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x00089A8E File Offset: 0x00087C8E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FreeAngle",
				"FixedAngle"
			};
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x00089AA6 File Offset: 0x00087CA6
		public static EControllerType[] GetValues()
		{
			return new EControllerType[]
			{
				EControllerType.FreeAngle,
				EControllerType.FixedAngle
			};
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x00089AB2 File Offset: 0x00087CB2
		public static string[] GetNames()
		{
			return new string[]
			{
				"FreeAngle",
				"FixedAngle"
			};
		}
	}
}
