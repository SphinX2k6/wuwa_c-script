using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A4 RID: 2468
	public static class EMotorInteractConstraintTypeExtensions
	{
		// Token: 0x06003713 RID: 14099 RVA: 0x0008F380 File Offset: 0x0008D580
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

		// Token: 0x06003714 RID: 14100 RVA: 0x0008F3A8 File Offset: 0x0008D5A8
		public static EMotorInteractConstraintType FromString(string name)
		{
			EMotorInteractConstraintType result;
			if (!EMotorInteractConstraintTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorInteractConstraintType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x0008F3D1 File Offset: 0x0008D5D1
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

		// Token: 0x06003716 RID: 14102 RVA: 0x0008F3F6 File Offset: 0x0008D5F6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FaceToTarget"
			};
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x0008F406 File Offset: 0x0008D606
		public static EMotorInteractConstraintType[] GetValues()
		{
			return new EMotorInteractConstraintType[1];
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x0008F40E File Offset: 0x0008D60E
		public static string[] GetNames()
		{
			return new string[]
			{
				"FaceToTarget"
			};
		}
	}
}
