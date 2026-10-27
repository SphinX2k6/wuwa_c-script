using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002439 RID: 9273
	public static class ESubScreenPushDirectionExtensions
	{
		// Token: 0x0600C97F RID: 51583 RVA: 0x001D8120 File Offset: 0x001D6320
		public static string ToEnumString(this ESubScreenPushDirection value)
		{
			string result;
			if (value != ESubScreenPushDirection.Left)
			{
				if (value != ESubScreenPushDirection.Right)
				{
					result = value.ToString();
				}
				else
				{
					result = "Right";
				}
			}
			else
			{
				result = "Left";
			}
			return result;
		}

		// Token: 0x0600C980 RID: 51584 RVA: 0x001D8158 File Offset: 0x001D6358
		public static ESubScreenPushDirection FromString(string name)
		{
			ESubScreenPushDirection result;
			if (!ESubScreenPushDirectionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESubScreenPushDirection 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C981 RID: 51585 RVA: 0x001D8181 File Offset: 0x001D6381
		public static bool TryFromString(string name, out ESubScreenPushDirection value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESubScreenPushDirection.Left;
				return false;
			}
			if (name == "Left")
			{
				value = ESubScreenPushDirection.Left;
				return true;
			}
			if (!(name == "Right"))
			{
				value = ESubScreenPushDirection.Left;
				return false;
			}
			value = ESubScreenPushDirection.Right;
			return true;
		}

		// Token: 0x0600C982 RID: 51586 RVA: 0x001D81BA File Offset: 0x001D63BA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Left",
				"Right"
			};
		}

		// Token: 0x0600C983 RID: 51587 RVA: 0x001D81D2 File Offset: 0x001D63D2
		public static ESubScreenPushDirection[] GetValues()
		{
			return new ESubScreenPushDirection[]
			{
				ESubScreenPushDirection.Left,
				ESubScreenPushDirection.Right
			};
		}

		// Token: 0x0600C984 RID: 51588 RVA: 0x001D81DE File Offset: 0x001D63DE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Left",
				"Right"
			};
		}
	}
}
