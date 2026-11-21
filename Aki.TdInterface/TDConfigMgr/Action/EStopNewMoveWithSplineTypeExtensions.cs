using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026D0 RID: 9936
	public static class EStopNewMoveWithSplineTypeExtensions
	{
		// Token: 0x0600D602 RID: 54786 RVA: 0x001F1958 File Offset: 0x001EFB58
		public static string ToEnumString(this EStopNewMoveWithSplineType value)
		{
			string result;
			switch (value)
			{
			case EStopNewMoveWithSplineType.StopAtCurrentPos:
				result = "StopAtCurrentPos";
				break;
			case EStopNewMoveWithSplineType.StopAtStartPoint:
				result = "StopAtStartPoint";
				break;
			case EStopNewMoveWithSplineType.StopAtEndPoint:
				result = "StopAtEndPoint";
				break;
			case EStopNewMoveWithSplineType.StopAtTargetPoint:
				result = "StopAtTargetPoint";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D603 RID: 54787 RVA: 0x001F19AC File Offset: 0x001EFBAC
		public static EStopNewMoveWithSplineType FromString(string name)
		{
			EStopNewMoveWithSplineType result;
			if (!EStopNewMoveWithSplineTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EStopNewMoveWithSplineType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D604 RID: 54788 RVA: 0x001F19D8 File Offset: 0x001EFBD8
		public static bool TryFromString(string name, out EStopNewMoveWithSplineType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EStopNewMoveWithSplineType.StopAtCurrentPos;
				return false;
			}
			if (name == "StopAtCurrentPos")
			{
				value = EStopNewMoveWithSplineType.StopAtCurrentPos;
				return true;
			}
			if (name == "StopAtStartPoint")
			{
				value = EStopNewMoveWithSplineType.StopAtStartPoint;
				return true;
			}
			if (name == "StopAtEndPoint")
			{
				value = EStopNewMoveWithSplineType.StopAtEndPoint;
				return true;
			}
			if (!(name == "StopAtTargetPoint"))
			{
				value = EStopNewMoveWithSplineType.StopAtCurrentPos;
				return false;
			}
			value = EStopNewMoveWithSplineType.StopAtTargetPoint;
			return true;
		}

		// Token: 0x0600D605 RID: 54789 RVA: 0x001F1A40 File Offset: 0x001EFC40
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"StopAtCurrentPos",
				"StopAtStartPoint",
				"StopAtEndPoint",
				"StopAtTargetPoint"
			};
		}

		// Token: 0x0600D606 RID: 54790 RVA: 0x001F1A68 File Offset: 0x001EFC68
		public static EStopNewMoveWithSplineType[] GetValues()
		{
			return new EStopNewMoveWithSplineType[]
			{
				EStopNewMoveWithSplineType.StopAtCurrentPos,
				EStopNewMoveWithSplineType.StopAtStartPoint,
				EStopNewMoveWithSplineType.StopAtEndPoint,
				EStopNewMoveWithSplineType.StopAtTargetPoint
			};
		}

		// Token: 0x0600D607 RID: 54791 RVA: 0x001F1A7B File Offset: 0x001EFC7B
		public static string[] GetNames()
		{
			return new string[]
			{
				"StopAtCurrentPos",
				"StopAtStartPoint",
				"StopAtEndPoint",
				"StopAtTargetPoint"
			};
		}
	}
}
