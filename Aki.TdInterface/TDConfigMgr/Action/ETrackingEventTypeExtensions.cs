using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200247F RID: 9343
	public static class ETrackingEventTypeExtensions
	{
		// Token: 0x0600CABA RID: 51898 RVA: 0x001DD764 File Offset: 0x001DB964
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

		// Token: 0x0600CABB RID: 51899 RVA: 0x001DD79C File Offset: 0x001DB99C
		public static ETrackingEventType FromString(string name)
		{
			ETrackingEventType result;
			if (!ETrackingEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrackingEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CABC RID: 51900 RVA: 0x001DD7C5 File Offset: 0x001DB9C5
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

		// Token: 0x0600CABD RID: 51901 RVA: 0x001DD7FE File Offset: 0x001DB9FE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EasterEgg",
				"MotorParkour"
			};
		}

		// Token: 0x0600CABE RID: 51902 RVA: 0x001DD816 File Offset: 0x001DBA16
		public static ETrackingEventType[] GetValues()
		{
			return new ETrackingEventType[]
			{
				ETrackingEventType.EasterEgg,
				ETrackingEventType.MotorParkour
			};
		}

		// Token: 0x0600CABF RID: 51903 RVA: 0x001DD822 File Offset: 0x001DBA22
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
