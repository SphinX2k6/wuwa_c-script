using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002512 RID: 9490
	public static class EAssistCharacterMoveTypeExtensions
	{
		// Token: 0x0600CE2B RID: 52779 RVA: 0x001DE3F4 File Offset: 0x001DC5F4
		public static string ToEnumString(this EAssistCharacterMoveType value)
		{
			string result;
			if (value != EAssistCharacterMoveType.Navigation)
			{
				if (value != EAssistCharacterMoveType.Spline)
				{
					result = value.ToString();
				}
				else
				{
					result = "Spline";
				}
			}
			else
			{
				result = "Navigation";
			}
			return result;
		}

		// Token: 0x0600CE2C RID: 52780 RVA: 0x001DE42C File Offset: 0x001DC62C
		public static EAssistCharacterMoveType FromString(string name)
		{
			EAssistCharacterMoveType result;
			if (!EAssistCharacterMoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAssistCharacterMoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE2D RID: 52781 RVA: 0x001DE455 File Offset: 0x001DC655
		public static bool TryFromString(string name, out EAssistCharacterMoveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAssistCharacterMoveType.Navigation;
				return false;
			}
			if (name == "Navigation")
			{
				value = EAssistCharacterMoveType.Navigation;
				return true;
			}
			if (!(name == "Spline"))
			{
				value = EAssistCharacterMoveType.Navigation;
				return false;
			}
			value = EAssistCharacterMoveType.Spline;
			return true;
		}

		// Token: 0x0600CE2E RID: 52782 RVA: 0x001DE48E File Offset: 0x001DC68E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Navigation",
				"Spline"
			};
		}

		// Token: 0x0600CE2F RID: 52783 RVA: 0x001DE4A6 File Offset: 0x001DC6A6
		public static EAssistCharacterMoveType[] GetValues()
		{
			return new EAssistCharacterMoveType[]
			{
				EAssistCharacterMoveType.Navigation,
				EAssistCharacterMoveType.Spline
			};
		}

		// Token: 0x0600CE30 RID: 52784 RVA: 0x001DE4B2 File Offset: 0x001DC6B2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Navigation",
				"Spline"
			};
		}
	}
}
