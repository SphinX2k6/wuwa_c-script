using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200254A RID: 9546
	public static class EClientEventFlyingFlowerEventTypeExtensions
	{
		// Token: 0x0600CF27 RID: 53031 RVA: 0x001E0950 File Offset: 0x001DEB50
		public static string ToEnumString(this EClientEventFlyingFlowerEventType value)
		{
			string result;
			if (value == EClientEventFlyingFlowerEventType.UpdateSubtitle)
			{
				result = "UpdateSubtitle";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CF28 RID: 53032 RVA: 0x001E0978 File Offset: 0x001DEB78
		public static EClientEventFlyingFlowerEventType FromString(string name)
		{
			EClientEventFlyingFlowerEventType result;
			if (!EClientEventFlyingFlowerEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EClientEventFlyingFlowerEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF29 RID: 53033 RVA: 0x001E09A1 File Offset: 0x001DEBA1
		public static bool TryFromString(string name, out EClientEventFlyingFlowerEventType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EClientEventFlyingFlowerEventType.UpdateSubtitle;
				return false;
			}
			if (name == "UpdateSubtitle")
			{
				value = EClientEventFlyingFlowerEventType.UpdateSubtitle;
				return true;
			}
			value = EClientEventFlyingFlowerEventType.UpdateSubtitle;
			return false;
		}

		// Token: 0x0600CF2A RID: 53034 RVA: 0x001E09C6 File Offset: 0x001DEBC6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UpdateSubtitle"
			};
		}

		// Token: 0x0600CF2B RID: 53035 RVA: 0x001E09D6 File Offset: 0x001DEBD6
		public static EClientEventFlyingFlowerEventType[] GetValues()
		{
			return new EClientEventFlyingFlowerEventType[1];
		}

		// Token: 0x0600CF2C RID: 53036 RVA: 0x001E09DE File Offset: 0x001DEBDE
		public static string[] GetNames()
		{
			return new string[]
			{
				"UpdateSubtitle"
			};
		}
	}
}
