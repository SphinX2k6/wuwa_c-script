using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002309 RID: 8969
	public static class EDungeonEventTypeExtensions
	{
		// Token: 0x0600C427 RID: 50215 RVA: 0x001CA3D8 File Offset: 0x001C85D8
		public static string ToEnumString(this EDungeonEventType value)
		{
			string result;
			if (value == EDungeonEventType.RecordTimeStamp)
			{
				result = "RecordTimeStamp";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C428 RID: 50216 RVA: 0x001CA400 File Offset: 0x001C8600
		public static EDungeonEventType FromString(string name)
		{
			EDungeonEventType result;
			if (!EDungeonEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDungeonEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C429 RID: 50217 RVA: 0x001CA429 File Offset: 0x001C8629
		public static bool TryFromString(string name, out EDungeonEventType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDungeonEventType.RecordTimeStamp;
				return false;
			}
			if (name == "RecordTimeStamp")
			{
				value = EDungeonEventType.RecordTimeStamp;
				return true;
			}
			value = EDungeonEventType.RecordTimeStamp;
			return false;
		}

		// Token: 0x0600C42A RID: 50218 RVA: 0x001CA44E File Offset: 0x001C864E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RecordTimeStamp"
			};
		}

		// Token: 0x0600C42B RID: 50219 RVA: 0x001CA45E File Offset: 0x001C865E
		public static EDungeonEventType[] GetValues()
		{
			return new EDungeonEventType[1];
		}

		// Token: 0x0600C42C RID: 50220 RVA: 0x001CA466 File Offset: 0x001C8666
		public static string[] GetNames()
		{
			return new string[]
			{
				"RecordTimeStamp"
			};
		}
	}
}
