using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022A3 RID: 8867
	public static class EAssistCharacterMoveTypeExtensions
	{
		// Token: 0x0600C25C RID: 49756 RVA: 0x001C65EC File Offset: 0x001C47EC
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

		// Token: 0x0600C25D RID: 49757 RVA: 0x001C6624 File Offset: 0x001C4824
		public static EAssistCharacterMoveType FromString(string name)
		{
			EAssistCharacterMoveType result;
			if (!EAssistCharacterMoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAssistCharacterMoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C25E RID: 49758 RVA: 0x001C664D File Offset: 0x001C484D
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

		// Token: 0x0600C25F RID: 49759 RVA: 0x001C6686 File Offset: 0x001C4886
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Navigation",
				"Spline"
			};
		}

		// Token: 0x0600C260 RID: 49760 RVA: 0x001C669E File Offset: 0x001C489E
		public static EAssistCharacterMoveType[] GetValues()
		{
			return new EAssistCharacterMoveType[]
			{
				EAssistCharacterMoveType.Navigation,
				EAssistCharacterMoveType.Spline
			};
		}

		// Token: 0x0600C261 RID: 49761 RVA: 0x001C66AA File Offset: 0x001C48AA
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
