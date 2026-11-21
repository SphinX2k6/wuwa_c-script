using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026DA RID: 9946
	public static class ESubScreenPushDirectionExtensions
	{
		// Token: 0x0600D62F RID: 54831 RVA: 0x001F1FE8 File Offset: 0x001F01E8
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

		// Token: 0x0600D630 RID: 54832 RVA: 0x001F2020 File Offset: 0x001F0220
		public static ESubScreenPushDirection FromString(string name)
		{
			ESubScreenPushDirection result;
			if (!ESubScreenPushDirectionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESubScreenPushDirection 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D631 RID: 54833 RVA: 0x001F2049 File Offset: 0x001F0249
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

		// Token: 0x0600D632 RID: 54834 RVA: 0x001F2082 File Offset: 0x001F0282
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Left",
				"Right"
			};
		}

		// Token: 0x0600D633 RID: 54835 RVA: 0x001F209A File Offset: 0x001F029A
		public static ESubScreenPushDirection[] GetValues()
		{
			return new ESubScreenPushDirection[]
			{
				ESubScreenPushDirection.Left,
				ESubScreenPushDirection.Right
			};
		}

		// Token: 0x0600D634 RID: 54836 RVA: 0x001F20A6 File Offset: 0x001F02A6
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
