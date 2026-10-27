using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200246B RID: 9323
	public static class ETextAlignExtensions
	{
		// Token: 0x0600CA60 RID: 51808 RVA: 0x001DC9F8 File Offset: 0x001DABF8
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

		// Token: 0x0600CA61 RID: 51809 RVA: 0x001DCA40 File Offset: 0x001DAC40
		public static ETextAlign FromString(string name)
		{
			ETextAlign result;
			if (!ETextAlignExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETextAlign 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA62 RID: 51810 RVA: 0x001DCA6C File Offset: 0x001DAC6C
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

		// Token: 0x0600CA63 RID: 51811 RVA: 0x001DCAC2 File Offset: 0x001DACC2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Top",
				"Middle",
				"Bottom"
			};
		}

		// Token: 0x0600CA64 RID: 51812 RVA: 0x001DCAE2 File Offset: 0x001DACE2
		public static ETextAlign[] GetValues()
		{
			return new ETextAlign[]
			{
				ETextAlign.Top,
				ETextAlign.Middle,
				ETextAlign.Bottom
			};
		}

		// Token: 0x0600CA65 RID: 51813 RVA: 0x001DCAF2 File Offset: 0x001DACF2
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
