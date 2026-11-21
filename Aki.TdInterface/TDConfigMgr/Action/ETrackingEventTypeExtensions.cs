using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002722 RID: 10018
	public static class ETrackingEventTypeExtensions
	{
		// Token: 0x0600D773 RID: 55155 RVA: 0x001F792C File Offset: 0x001F5B2C
		public static string ToEnumString(this ETrackingEventType value)
		{
			string result;
			if (value != ETrackingEventType.EasterEgg)
			{
				if (value != ETrackingEventType.MotorParkour)
				{
					result = value.ToString();
				}
				else
				{
					result = "MotorParkour";
				}
			}
			else
			{
				result = "EasterEgg";
			}
			return result;
		}

		// Token: 0x0600D774 RID: 55156 RVA: 0x001F7964 File Offset: 0x001F5B64
		public static ETrackingEventType FromString(string name)
		{
			ETrackingEventType result;
			if (!ETrackingEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrackingEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D775 RID: 55157 RVA: 0x001F798D File Offset: 0x001F5B8D
		public static bool TryFromString(string name, out ETrackingEventType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETrackingEventType.EasterEgg;
				return false;
			}
			if (name == "EasterEgg")
			{
				value = ETrackingEventType.EasterEgg;
				return true;
			}
			if (!(name == "MotorParkour"))
			{
				value = ETrackingEventType.EasterEgg;
				return false;
			}
			value = ETrackingEventType.MotorParkour;
			return true;
		}

		// Token: 0x0600D776 RID: 55158 RVA: 0x001F79C6 File Offset: 0x001F5BC6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EasterEgg",
				"MotorParkour"
			};
		}

		// Token: 0x0600D777 RID: 55159 RVA: 0x001F79DE File Offset: 0x001F5BDE
		public static ETrackingEventType[] GetValues()
		{
			return new ETrackingEventType[]
			{
				ETrackingEventType.EasterEgg,
				ETrackingEventType.MotorParkour
			};
		}

		// Token: 0x0600D778 RID: 55160 RVA: 0x001F79EA File Offset: 0x001F5BEA
		public static string[] GetNames()
		{
			return new string[]
			{
				"EasterEgg",
				"MotorParkour"
			};
		}
	}
}
