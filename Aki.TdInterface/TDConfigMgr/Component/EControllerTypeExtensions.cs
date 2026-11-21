using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C1 RID: 2497
	public static class EControllerTypeExtensions
	{
		// Token: 0x060037F7 RID: 14327 RVA: 0x00091574 File Offset: 0x0008F774
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

		// Token: 0x060037F8 RID: 14328 RVA: 0x000915AC File Offset: 0x0008F7AC
		public static EControllerType FromString(string name)
		{
			EControllerType result;
			if (!EControllerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EControllerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x000915D5 File Offset: 0x0008F7D5
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

		// Token: 0x060037FA RID: 14330 RVA: 0x0009160E File Offset: 0x0008F80E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FreeAngle",
				"FixedAngle"
			};
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x00091626 File Offset: 0x0008F826
		public static EControllerType[] GetValues()
		{
			return new EControllerType[]
			{
				EControllerType.FreeAngle,
				EControllerType.FixedAngle
			};
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x00091632 File Offset: 0x0008F832
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
