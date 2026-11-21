using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026C4 RID: 9924
	public static class ESplineMoveConfigTypeExtensions
	{
		// Token: 0x0600D5CC RID: 54732 RVA: 0x001F10EC File Offset: 0x001EF2EC
		public static string ToEnumString(this ESplineMoveConfigType value)
		{
			string result;
			if (value != ESplineMoveConfigType.Open)
			{
				if (value != ESplineMoveConfigType.Close)
				{
					result = value.ToString();
				}
				else
				{
					result = "Close";
				}
			}
			else
			{
				result = "Open";
			}
			return result;
		}

		// Token: 0x0600D5CD RID: 54733 RVA: 0x001F1124 File Offset: 0x001EF324
		public static ESplineMoveConfigType FromString(string name)
		{
			ESplineMoveConfigType result;
			if (!ESplineMoveConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESplineMoveConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D5CE RID: 54734 RVA: 0x001F114D File Offset: 0x001EF34D
		public static bool TryFromString(string name, out ESplineMoveConfigType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESplineMoveConfigType.Open;
				return false;
			}
			if (name == "Open")
			{
				value = ESplineMoveConfigType.Open;
				return true;
			}
			if (!(name == "Close"))
			{
				value = ESplineMoveConfigType.Open;
				return false;
			}
			value = ESplineMoveConfigType.Close;
			return true;
		}

		// Token: 0x0600D5CF RID: 54735 RVA: 0x001F1186 File Offset: 0x001EF386
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Open",
				"Close"
			};
		}

		// Token: 0x0600D5D0 RID: 54736 RVA: 0x001F119E File Offset: 0x001EF39E
		public static ESplineMoveConfigType[] GetValues()
		{
			return new ESplineMoveConfigType[]
			{
				ESplineMoveConfigType.Open,
				ESplineMoveConfigType.Close
			};
		}

		// Token: 0x0600D5D1 RID: 54737 RVA: 0x001F11AA File Offset: 0x001EF3AA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Open",
				"Close"
			};
		}
	}
}
