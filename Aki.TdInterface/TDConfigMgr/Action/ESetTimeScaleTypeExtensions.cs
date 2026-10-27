using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002411 RID: 9233
	public static class ESetTimeScaleTypeExtensions
	{
		// Token: 0x0600C8CB RID: 51403 RVA: 0x001D609C File Offset: 0x001D429C
		public static string ToEnumString(this ESetTimeScaleType value)
		{
			string result;
			if (value != ESetTimeScaleType.Open)
			{
				if (value != ESetTimeScaleType.Close)
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

		// Token: 0x0600C8CC RID: 51404 RVA: 0x001D60D4 File Offset: 0x001D42D4
		public static ESetTimeScaleType FromString(string name)
		{
			ESetTimeScaleType result;
			if (!ESetTimeScaleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetTimeScaleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C8CD RID: 51405 RVA: 0x001D60FD File Offset: 0x001D42FD
		public static bool TryFromString(string name, out ESetTimeScaleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESetTimeScaleType.Open;
				return false;
			}
			if (name == "Open")
			{
				value = ESetTimeScaleType.Open;
				return true;
			}
			if (!(name == "Close"))
			{
				value = ESetTimeScaleType.Open;
				return false;
			}
			value = ESetTimeScaleType.Close;
			return true;
		}

		// Token: 0x0600C8CE RID: 51406 RVA: 0x001D6136 File Offset: 0x001D4336
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Open",
				"Close"
			};
		}

		// Token: 0x0600C8CF RID: 51407 RVA: 0x001D614E File Offset: 0x001D434E
		public static ESetTimeScaleType[] GetValues()
		{
			return new ESetTimeScaleType[]
			{
				ESetTimeScaleType.Open,
				ESetTimeScaleType.Close
			};
		}

		// Token: 0x0600C8D0 RID: 51408 RVA: 0x001D615A File Offset: 0x001D435A
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
