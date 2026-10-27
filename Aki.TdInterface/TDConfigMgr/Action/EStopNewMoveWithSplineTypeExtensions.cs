using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200242F RID: 9263
	public static class EStopNewMoveWithSplineTypeExtensions
	{
		// Token: 0x0600C952 RID: 51538 RVA: 0x001D7A90 File Offset: 0x001D5C90
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

		// Token: 0x0600C953 RID: 51539 RVA: 0x001D7AE4 File Offset: 0x001D5CE4
		public static EStopNewMoveWithSplineType FromString(string name)
		{
			EStopNewMoveWithSplineType result;
			if (!EStopNewMoveWithSplineTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EStopNewMoveWithSplineType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C954 RID: 51540 RVA: 0x001D7B10 File Offset: 0x001D5D10
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

		// Token: 0x0600C955 RID: 51541 RVA: 0x001D7B78 File Offset: 0x001D5D78
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

		// Token: 0x0600C956 RID: 51542 RVA: 0x001D7BA0 File Offset: 0x001D5DA0
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

		// Token: 0x0600C957 RID: 51543 RVA: 0x001D7BB3 File Offset: 0x001D5DB3
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
