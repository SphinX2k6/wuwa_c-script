using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200270C RID: 9996
	public static class ETextAlignExtensions
	{
		// Token: 0x0600D710 RID: 55056 RVA: 0x001F6AAC File Offset: 0x001F4CAC
		public static string ToEnumString(this ETextAlign value)
		{
			string result;
			switch (value)
			{
			case ETextAlign.Top:
				result = "Top";
				break;
			case ETextAlign.Middle:
				result = "Middle";
				break;
			case ETextAlign.Bottom:
				result = "Bottom";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D711 RID: 55057 RVA: 0x001F6AF4 File Offset: 0x001F4CF4
		public static ETextAlign FromString(string name)
		{
			ETextAlign result;
			if (!ETextAlignExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETextAlign 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D712 RID: 55058 RVA: 0x001F6B20 File Offset: 0x001F4D20
		public static bool TryFromString(string name, out ETextAlign value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETextAlign.Top;
				return false;
			}
			if (name == "Top")
			{
				value = ETextAlign.Top;
				return true;
			}
			if (name == "Middle")
			{
				value = ETextAlign.Middle;
				return true;
			}
			if (!(name == "Bottom"))
			{
				value = ETextAlign.Top;
				return false;
			}
			value = ETextAlign.Bottom;
			return true;
		}

		// Token: 0x0600D713 RID: 55059 RVA: 0x001F6B76 File Offset: 0x001F4D76
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Top",
				"Middle",
				"Bottom"
			};
		}

		// Token: 0x0600D714 RID: 55060 RVA: 0x001F6B96 File Offset: 0x001F4D96
		public static ETextAlign[] GetValues()
		{
			return new ETextAlign[]
			{
				ETextAlign.Top,
				ETextAlign.Middle,
				ETextAlign.Bottom
			};
		}

		// Token: 0x0600D715 RID: 55061 RVA: 0x001F6BA6 File Offset: 0x001F4DA6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Top",
				"Middle",
				"Bottom"
			};
		}
	}
}
