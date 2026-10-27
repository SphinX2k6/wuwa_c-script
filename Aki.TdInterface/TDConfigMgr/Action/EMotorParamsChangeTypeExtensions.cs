using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002391 RID: 9105
	public static class EMotorParamsChangeTypeExtensions
	{
		// Token: 0x0600C68B RID: 50827 RVA: 0x001D145C File Offset: 0x001CF65C
		public static string ToEnumString(this EMotorParamsChangeType value)
		{
			string result;
			if (value != EMotorParamsChangeType.SpeedUp)
			{
				if (value != EMotorParamsChangeType.SpeedDown)
				{
					result = value.ToString();
				}
				else
				{
					result = "SpeedDown";
				}
			}
			else
			{
				result = "SpeedUp";
			}
			return result;
		}

		// Token: 0x0600C68C RID: 50828 RVA: 0x001D1494 File Offset: 0x001CF694
		public static EMotorParamsChangeType FromString(string name)
		{
			EMotorParamsChangeType result;
			if (!EMotorParamsChangeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorParamsChangeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C68D RID: 50829 RVA: 0x001D14BD File Offset: 0x001CF6BD
		public static bool TryFromString(string name, out EMotorParamsChangeType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMotorParamsChangeType.SpeedUp;
				return false;
			}
			if (name == "SpeedUp")
			{
				value = EMotorParamsChangeType.SpeedUp;
				return true;
			}
			if (!(name == "SpeedDown"))
			{
				value = EMotorParamsChangeType.SpeedUp;
				return false;
			}
			value = EMotorParamsChangeType.SpeedDown;
			return true;
		}

		// Token: 0x0600C68E RID: 50830 RVA: 0x001D14F6 File Offset: 0x001CF6F6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SpeedUp",
				"SpeedDown"
			};
		}

		// Token: 0x0600C68F RID: 50831 RVA: 0x001D150E File Offset: 0x001CF70E
		public static EMotorParamsChangeType[] GetValues()
		{
			return new EMotorParamsChangeType[]
			{
				EMotorParamsChangeType.SpeedUp,
				EMotorParamsChangeType.SpeedDown
			};
		}

		// Token: 0x0600C690 RID: 50832 RVA: 0x001D151A File Offset: 0x001CF71A
		public static string[] GetNames()
		{
			return new string[]
			{
				"SpeedUp",
				"SpeedDown"
			};
		}
	}
}
