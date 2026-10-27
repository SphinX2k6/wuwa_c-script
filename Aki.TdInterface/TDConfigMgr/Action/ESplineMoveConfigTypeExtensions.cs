using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002425 RID: 9253
	public static class ESplineMoveConfigTypeExtensions
	{
		// Token: 0x0600C925 RID: 51493 RVA: 0x001D7418 File Offset: 0x001D5618
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

		// Token: 0x0600C926 RID: 51494 RVA: 0x001D7450 File Offset: 0x001D5650
		public static ESplineMoveConfigType FromString(string name)
		{
			ESplineMoveConfigType result;
			if (!ESplineMoveConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESplineMoveConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C927 RID: 51495 RVA: 0x001D7479 File Offset: 0x001D5679
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

		// Token: 0x0600C928 RID: 51496 RVA: 0x001D74B2 File Offset: 0x001D56B2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Open",
				"Close"
			};
		}

		// Token: 0x0600C929 RID: 51497 RVA: 0x001D74CA File Offset: 0x001D56CA
		public static ESplineMoveConfigType[] GetValues()
		{
			return new ESplineMoveConfigType[]
			{
				ESplineMoveConfigType.Open,
				ESplineMoveConfigType.Close
			};
		}

		// Token: 0x0600C92A RID: 51498 RVA: 0x001D74D6 File Offset: 0x001D56D6
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
