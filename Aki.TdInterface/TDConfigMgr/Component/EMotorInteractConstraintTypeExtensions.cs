using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A59 RID: 2649
	public static class EMotorInteractConstraintTypeExtensions
	{
		// Token: 0x06003AA3 RID: 15011 RVA: 0x00097444 File Offset: 0x00095644
		public static string ToEnumString(this EMotorInteractConstraintType value)
		{
			string result;
			if (value == EMotorInteractConstraintType.FaceToTarget)
			{
				result = "FaceToTarget";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x0009746C File Offset: 0x0009566C
		public static EMotorInteractConstraintType FromString(string name)
		{
			EMotorInteractConstraintType result;
			if (!EMotorInteractConstraintTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorInteractConstraintType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x00097495 File Offset: 0x00095695
		public static bool TryFromString(string name, out EMotorInteractConstraintType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMotorInteractConstraintType.FaceToTarget;
				return false;
			}
			if (name == "FaceToTarget")
			{
				value = EMotorInteractConstraintType.FaceToTarget;
				return true;
			}
			value = EMotorInteractConstraintType.FaceToTarget;
			return false;
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x000974BA File Offset: 0x000956BA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FaceToTarget"
			};
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x000974CA File Offset: 0x000956CA
		public static EMotorInteractConstraintType[] GetValues()
		{
			return new EMotorInteractConstraintType[1];
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x000974D2 File Offset: 0x000956D2
		public static string[] GetNames()
		{
			return new string[]
			{
				"FaceToTarget"
			};
		}
	}
}
