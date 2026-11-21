using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200271C RID: 10012
	public static class EToggleRideFlyingCarUiGameplayTypeExtensions
	{
		// Token: 0x0600D758 RID: 55128 RVA: 0x001F754C File Offset: 0x001F574C
		public static string ToEnumString(this EToggleRideFlyingCarUiGameplayType value)
		{
			string result;
			if (value != EToggleRideFlyingCarUiGameplayType.Enable)
			{
				if (value != EToggleRideFlyingCarUiGameplayType.Disable)
				{
					result = value.ToString();
				}
				else
				{
					result = "Disable";
				}
			}
			else
			{
				result = "Enable";
			}
			return result;
		}

		// Token: 0x0600D759 RID: 55129 RVA: 0x001F7584 File Offset: 0x001F5784
		public static EToggleRideFlyingCarUiGameplayType FromString(string name)
		{
			EToggleRideFlyingCarUiGameplayType result;
			if (!EToggleRideFlyingCarUiGameplayTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EToggleRideFlyingCarUiGameplayType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D75A RID: 55130 RVA: 0x001F75AD File Offset: 0x001F57AD
		public static bool TryFromString(string name, out EToggleRideFlyingCarUiGameplayType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EToggleRideFlyingCarUiGameplayType.Enable;
				return false;
			}
			if (name == "Enable")
			{
				value = EToggleRideFlyingCarUiGameplayType.Enable;
				return true;
			}
			if (!(name == "Disable"))
			{
				value = EToggleRideFlyingCarUiGameplayType.Enable;
				return false;
			}
			value = EToggleRideFlyingCarUiGameplayType.Disable;
			return true;
		}

		// Token: 0x0600D75B RID: 55131 RVA: 0x001F75E6 File Offset: 0x001F57E6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}

		// Token: 0x0600D75C RID: 55132 RVA: 0x001F75FE File Offset: 0x001F57FE
		public static EToggleRideFlyingCarUiGameplayType[] GetValues()
		{
			return new EToggleRideFlyingCarUiGameplayType[]
			{
				EToggleRideFlyingCarUiGameplayType.Enable,
				EToggleRideFlyingCarUiGameplayType.Disable
			};
		}

		// Token: 0x0600D75D RID: 55133 RVA: 0x001F760A File Offset: 0x001F580A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}
	}
}
