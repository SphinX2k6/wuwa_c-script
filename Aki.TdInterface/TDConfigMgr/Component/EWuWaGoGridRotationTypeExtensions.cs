using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B13 RID: 2835
	public static class EWuWaGoGridRotationTypeExtensions
	{
		// Token: 0x06003DE8 RID: 15848 RVA: 0x0009E690 File Offset: 0x0009C890
		public static string ToEnumString(this EWuWaGoGridRotationType value)
		{
			string result;
			switch (value)
			{
			case EWuWaGoGridRotationType.Front:
				result = "Front";
				break;
			case EWuWaGoGridRotationType.Right:
				result = "Right";
				break;
			case EWuWaGoGridRotationType.Left:
				result = "Left";
				break;
			case EWuWaGoGridRotationType.Behind:
				result = "Behind";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x0009E6E4 File Offset: 0x0009C8E4
		public static EWuWaGoGridRotationType FromString(string name)
		{
			EWuWaGoGridRotationType result;
			if (!EWuWaGoGridRotationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWuWaGoGridRotationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x0009E710 File Offset: 0x0009C910
		public static bool TryFromString(string name, out EWuWaGoGridRotationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EWuWaGoGridRotationType.Front;
				return false;
			}
			if (name == "Front")
			{
				value = EWuWaGoGridRotationType.Front;
				return true;
			}
			if (name == "Right")
			{
				value = EWuWaGoGridRotationType.Right;
				return true;
			}
			if (name == "Left")
			{
				value = EWuWaGoGridRotationType.Left;
				return true;
			}
			if (!(name == "Behind"))
			{
				value = EWuWaGoGridRotationType.Front;
				return false;
			}
			value = EWuWaGoGridRotationType.Behind;
			return true;
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x0009E778 File Offset: 0x0009C978
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Front",
				"Right",
				"Left",
				"Behind"
			};
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x0009E7A0 File Offset: 0x0009C9A0
		public static EWuWaGoGridRotationType[] GetValues()
		{
			return new EWuWaGoGridRotationType[]
			{
				EWuWaGoGridRotationType.Front,
				EWuWaGoGridRotationType.Right,
				EWuWaGoGridRotationType.Left,
				EWuWaGoGridRotationType.Behind
			};
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x0009E7B3 File Offset: 0x0009C9B3
		public static string[] GetNames()
		{
			return new string[]
			{
				"Front",
				"Right",
				"Left",
				"Behind"
			};
		}
	}
}
