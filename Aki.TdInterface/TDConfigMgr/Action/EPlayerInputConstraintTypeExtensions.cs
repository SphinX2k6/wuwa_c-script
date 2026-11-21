using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002664 RID: 9828
	public static class EPlayerInputConstraintTypeExtensions
	{
		// Token: 0x0600D41C RID: 54300 RVA: 0x001ECFEC File Offset: 0x001EB1EC
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

		// Token: 0x0600D41D RID: 54301 RVA: 0x001ED024 File Offset: 0x001EB224
		public static EPlayerInputConstraintType FromString(string name)
		{
			EPlayerInputConstraintType result;
			if (!EPlayerInputConstraintTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerInputConstraintType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D41E RID: 54302 RVA: 0x001ED04D File Offset: 0x001EB24D
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

		// Token: 0x0600D41F RID: 54303 RVA: 0x001ED086 File Offset: 0x001EB286
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Left",
				"Right"
			};
		}

		// Token: 0x0600D420 RID: 54304 RVA: 0x001ED09E File Offset: 0x001EB29E
		public static EPlayerInputConstraintType[] GetValues()
		{
			return new EPlayerInputConstraintType[]
			{
				EPlayerInputConstraintType.Left,
				EPlayerInputConstraintType.Right
			};
		}

		// Token: 0x0600D421 RID: 54305 RVA: 0x001ED0AA File Offset: 0x001EB2AA
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
