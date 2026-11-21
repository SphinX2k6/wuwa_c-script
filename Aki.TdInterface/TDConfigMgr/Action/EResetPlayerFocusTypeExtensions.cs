using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002684 RID: 9860
	public static class EResetPlayerFocusTypeExtensions
	{
		// Token: 0x0600D4AC RID: 54444 RVA: 0x001EE4F0 File Offset: 0x001EC6F0
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

		// Token: 0x0600D4AD RID: 54445 RVA: 0x001EE528 File Offset: 0x001EC728
		public static EResetPlayerFocusType FromString(string name)
		{
			EResetPlayerFocusType result;
			if (!EResetPlayerFocusTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResetPlayerFocusType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D4AE RID: 54446 RVA: 0x001EE551 File Offset: 0x001EC751
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

		// Token: 0x0600D4AF RID: 54447 RVA: 0x001EE58A File Offset: 0x001EC78A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ResetToDefaultDirection",
				"ResetToFixedDirection"
			};
		}

		// Token: 0x0600D4B0 RID: 54448 RVA: 0x001EE5A2 File Offset: 0x001EC7A2
		public static EResetPlayerFocusType[] GetValues()
		{
			return new EResetPlayerFocusType[]
			{
				EResetPlayerFocusType.ResetToDefaultDirection,
				EResetPlayerFocusType.ResetToFixedDirection
			};
		}

		// Token: 0x0600D4B1 RID: 54449 RVA: 0x001EE5AE File Offset: 0x001EC7AE
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
