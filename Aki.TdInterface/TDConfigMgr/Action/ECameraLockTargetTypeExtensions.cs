using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022C9 RID: 8905
	public static class ECameraLockTargetTypeExtensions
	{
		// Token: 0x0600C307 RID: 49927 RVA: 0x001C80BC File Offset: 0x001C62BC
		public static string ToEnumString(this ECameraLockTargetType value)
		{
			string result;
			if (value == ECameraLockTargetType.TargetPosition)
			{
				result = "TargetPosition";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C308 RID: 49928 RVA: 0x001C80E4 File Offset: 0x001C62E4
		public static ECameraLockTargetType FromString(string name)
		{
			ECameraLockTargetType result;
			if (!ECameraLockTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECameraLockTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C309 RID: 49929 RVA: 0x001C810D File Offset: 0x001C630D
		public static bool TryFromString(string name, out ECameraLockTargetType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECameraLockTargetType.TargetPosition;
				return false;
			}
			if (name == "TargetPosition")
			{
				value = ECameraLockTargetType.TargetPosition;
				return true;
			}
			value = ECameraLockTargetType.TargetPosition;
			return false;
		}

		// Token: 0x0600C30A RID: 49930 RVA: 0x001C8132 File Offset: 0x001C6332
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TargetPosition"
			};
		}

		// Token: 0x0600C30B RID: 49931 RVA: 0x001C8142 File Offset: 0x001C6342
		public static ECameraLockTargetType[] GetValues()
		{
			return new ECameraLockTargetType[1];
		}

		// Token: 0x0600C30C RID: 49932 RVA: 0x001C814A File Offset: 0x001C634A
		public static string[] GetNames()
		{
			return new string[]
			{
				"TargetPosition"
			};
		}
	}
}
