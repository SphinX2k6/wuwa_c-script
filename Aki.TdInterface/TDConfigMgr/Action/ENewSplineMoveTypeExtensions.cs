using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002638 RID: 9784
	public static class ENewSplineMoveTypeExtensions
	{
		// Token: 0x0600D356 RID: 54102 RVA: 0x001EB658 File Offset: 0x001E9858
		public static string ToEnumString(this ENewSplineMoveType value)
		{
			string result;
			if (value == ENewSplineMoveType.FrontAxleTracking)
			{
				result = "FrontAxleTracking";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D357 RID: 54103 RVA: 0x001EB680 File Offset: 0x001E9880
		public static ENewSplineMoveType FromString(string name)
		{
			ENewSplineMoveType result;
			if (!ENewSplineMoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENewSplineMoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D358 RID: 54104 RVA: 0x001EB6A9 File Offset: 0x001E98A9
		public static bool TryFromString(string name, out ENewSplineMoveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENewSplineMoveType.FrontAxleTracking;
				return false;
			}
			if (name == "FrontAxleTracking")
			{
				value = ENewSplineMoveType.FrontAxleTracking;
				return true;
			}
			value = ENewSplineMoveType.FrontAxleTracking;
			return false;
		}

		// Token: 0x0600D359 RID: 54105 RVA: 0x001EB6CE File Offset: 0x001E98CE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FrontAxleTracking"
			};
		}

		// Token: 0x0600D35A RID: 54106 RVA: 0x001EB6DE File Offset: 0x001E98DE
		public static ENewSplineMoveType[] GetValues()
		{
			return new ENewSplineMoveType[1];
		}

		// Token: 0x0600D35B RID: 54107 RVA: 0x001EB6E6 File Offset: 0x001E98E6
		public static string[] GetNames()
		{
			return new string[]
			{
				"FrontAxleTracking"
			};
		}
	}
}
