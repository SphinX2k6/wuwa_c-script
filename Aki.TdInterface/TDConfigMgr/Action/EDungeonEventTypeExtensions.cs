using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002578 RID: 9592
	public static class EDungeonEventTypeExtensions
	{
		// Token: 0x0600CFF6 RID: 53238 RVA: 0x001E22A0 File Offset: 0x001E04A0
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

		// Token: 0x0600CFF7 RID: 53239 RVA: 0x001E22C8 File Offset: 0x001E04C8
		public static EDungeonEventType FromString(string name)
		{
			EDungeonEventType result;
			if (!EDungeonEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDungeonEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CFF8 RID: 53240 RVA: 0x001E22F1 File Offset: 0x001E04F1
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

		// Token: 0x0600CFF9 RID: 53241 RVA: 0x001E2316 File Offset: 0x001E0516
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RecordTimeStamp"
			};
		}

		// Token: 0x0600CFFA RID: 53242 RVA: 0x001E2326 File Offset: 0x001E0526
		public static EDungeonEventType[] GetValues()
		{
			return new EDungeonEventType[1];
		}

		// Token: 0x0600CFFB RID: 53243 RVA: 0x001E232E File Offset: 0x001E052E
		public static string[] GetNames()
		{
			return new string[]
			{
				"RecordTimeStamp"
			};
		}
	}
}
