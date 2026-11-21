using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002538 RID: 9528
	public static class ECameraLockTargetTypeExtensions
	{
		// Token: 0x0600CED6 RID: 52950 RVA: 0x001DFEC4 File Offset: 0x001DE0C4
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

		// Token: 0x0600CED7 RID: 52951 RVA: 0x001DFEEC File Offset: 0x001DE0EC
		public static ECameraLockTargetType FromString(string name)
		{
			ECameraLockTargetType result;
			if (!ECameraLockTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECameraLockTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CED8 RID: 52952 RVA: 0x001DFF15 File Offset: 0x001DE115
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

		// Token: 0x0600CED9 RID: 52953 RVA: 0x001DFF3A File Offset: 0x001DE13A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TargetPosition"
			};
		}

		// Token: 0x0600CEDA RID: 52954 RVA: 0x001DFF4A File Offset: 0x001DE14A
		public static ECameraLockTargetType[] GetValues()
		{
			return new ECameraLockTargetType[1];
		}

		// Token: 0x0600CEDB RID: 52955 RVA: 0x001DFF52 File Offset: 0x001DE152
		public static string[] GetNames()
		{
			return new string[]
			{
				"TargetPosition"
			};
		}
	}
}
