using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022DB RID: 8923
	public static class EClientEventFlyingFlowerEventTypeExtensions
	{
		// Token: 0x0600C358 RID: 50008 RVA: 0x001C8B48 File Offset: 0x001C6D48
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

		// Token: 0x0600C359 RID: 50009 RVA: 0x001C8B70 File Offset: 0x001C6D70
		public static EClientEventFlyingFlowerEventType FromString(string name)
		{
			EClientEventFlyingFlowerEventType result;
			if (!EClientEventFlyingFlowerEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EClientEventFlyingFlowerEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C35A RID: 50010 RVA: 0x001C8B99 File Offset: 0x001C6D99
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

		// Token: 0x0600C35B RID: 50011 RVA: 0x001C8BBE File Offset: 0x001C6DBE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UpdateSubtitle"
			};
		}

		// Token: 0x0600C35C RID: 50012 RVA: 0x001C8BCE File Offset: 0x001C6DCE
		public static EClientEventFlyingFlowerEventType[] GetValues()
		{
			return new EClientEventFlyingFlowerEventType[1];
		}

		// Token: 0x0600C35D RID: 50013 RVA: 0x001C8BD6 File Offset: 0x001C6DD6
		public static string[] GetNames()
		{
			return new string[]
			{
				"UpdateSubtitle"
			};
		}
	}
}
