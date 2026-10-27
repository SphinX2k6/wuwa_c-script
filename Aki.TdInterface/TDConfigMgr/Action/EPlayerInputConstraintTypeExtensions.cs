using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023CD RID: 9165
	public static class EPlayerInputConstraintTypeExtensions
	{
		// Token: 0x0600C799 RID: 51097 RVA: 0x001D3840 File Offset: 0x001D1A40
		public static string ToEnumString(this EPlayerInputConstraintType value)
		{
			string result;
			if (value != EPlayerInputConstraintType.Left)
			{
				if (value != EPlayerInputConstraintType.Right)
				{
					result = value.ToString();
				}
				else
				{
					result = "Right";
				}
			}
			else
			{
				result = "Left";
			}
			return result;
		}

		// Token: 0x0600C79A RID: 51098 RVA: 0x001D3878 File Offset: 0x001D1A78
		public static EPlayerInputConstraintType FromString(string name)
		{
			EPlayerInputConstraintType result;
			if (!EPlayerInputConstraintTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerInputConstraintType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C79B RID: 51099 RVA: 0x001D38A1 File Offset: 0x001D1AA1
		public static bool TryFromString(string name, out EPlayerInputConstraintType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlayerInputConstraintType.Left;
				return false;
			}
			if (name == "Left")
			{
				value = EPlayerInputConstraintType.Left;
				return true;
			}
			if (!(name == "Right"))
			{
				value = EPlayerInputConstraintType.Left;
				return false;
			}
			value = EPlayerInputConstraintType.Right;
			return true;
		}

		// Token: 0x0600C79C RID: 51100 RVA: 0x001D38DA File Offset: 0x001D1ADA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Left",
				"Right"
			};
		}

		// Token: 0x0600C79D RID: 51101 RVA: 0x001D38F2 File Offset: 0x001D1AF2
		public static EPlayerInputConstraintType[] GetValues()
		{
			return new EPlayerInputConstraintType[]
			{
				EPlayerInputConstraintType.Left,
				EPlayerInputConstraintType.Right
			};
		}

		// Token: 0x0600C79E RID: 51102 RVA: 0x001D38FE File Offset: 0x001D1AFE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Left",
				"Right"
			};
		}
	}
}
