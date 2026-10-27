using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023ED RID: 9197
	public static class EResetPlayerFocusTypeExtensions
	{
		// Token: 0x0600C829 RID: 51241 RVA: 0x001D4D44 File Offset: 0x001D2F44
		public static string ToEnumString(this EResetPlayerFocusType value)
		{
			string result;
			if (value != EResetPlayerFocusType.ResetToDefaultDirection)
			{
				if (value != EResetPlayerFocusType.ResetToFixedDirection)
				{
					result = value.ToString();
				}
				else
				{
					result = "ResetToFixedDirection";
				}
			}
			else
			{
				result = "ResetToDefaultDirection";
			}
			return result;
		}

		// Token: 0x0600C82A RID: 51242 RVA: 0x001D4D7C File Offset: 0x001D2F7C
		public static EResetPlayerFocusType FromString(string name)
		{
			EResetPlayerFocusType result;
			if (!EResetPlayerFocusTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResetPlayerFocusType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C82B RID: 51243 RVA: 0x001D4DA5 File Offset: 0x001D2FA5
		public static bool TryFromString(string name, out EResetPlayerFocusType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EResetPlayerFocusType.ResetToDefaultDirection;
				return false;
			}
			if (name == "ResetToDefaultDirection")
			{
				value = EResetPlayerFocusType.ResetToDefaultDirection;
				return true;
			}
			if (!(name == "ResetToFixedDirection"))
			{
				value = EResetPlayerFocusType.ResetToDefaultDirection;
				return false;
			}
			value = EResetPlayerFocusType.ResetToFixedDirection;
			return true;
		}

		// Token: 0x0600C82C RID: 51244 RVA: 0x001D4DDE File Offset: 0x001D2FDE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ResetToDefaultDirection",
				"ResetToFixedDirection"
			};
		}

		// Token: 0x0600C82D RID: 51245 RVA: 0x001D4DF6 File Offset: 0x001D2FF6
		public static EResetPlayerFocusType[] GetValues()
		{
			return new EResetPlayerFocusType[]
			{
				EResetPlayerFocusType.ResetToDefaultDirection,
				EResetPlayerFocusType.ResetToFixedDirection
			};
		}

		// Token: 0x0600C82E RID: 51246 RVA: 0x001D4E02 File Offset: 0x001D3002
		public static string[] GetNames()
		{
			return new string[]
			{
				"ResetToDefaultDirection",
				"ResetToFixedDirection"
			};
		}
	}
}
