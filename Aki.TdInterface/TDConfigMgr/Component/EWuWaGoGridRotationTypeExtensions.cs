using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A4A RID: 2634
	public static class EWuWaGoGridRotationTypeExtensions
	{
		// Token: 0x060039FE RID: 14846 RVA: 0x00095AC0 File Offset: 0x00093CC0
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

		// Token: 0x060039FF RID: 14847 RVA: 0x00095B14 File Offset: 0x00093D14
		public static EWuWaGoGridRotationType FromString(string name)
		{
			EWuWaGoGridRotationType result;
			if (!EWuWaGoGridRotationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWuWaGoGridRotationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x00095B40 File Offset: 0x00093D40
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

		// Token: 0x06003A01 RID: 14849 RVA: 0x00095BA8 File Offset: 0x00093DA8
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

		// Token: 0x06003A02 RID: 14850 RVA: 0x00095BD0 File Offset: 0x00093DD0
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

		// Token: 0x06003A03 RID: 14851 RVA: 0x00095BE3 File Offset: 0x00093DE3
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
