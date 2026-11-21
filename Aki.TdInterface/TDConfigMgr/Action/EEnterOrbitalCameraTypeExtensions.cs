using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002590 RID: 9616
	public static class EEnterOrbitalCameraTypeExtensions
	{
		// Token: 0x0600D062 RID: 53346 RVA: 0x001E2FA4 File Offset: 0x001E11A4
		public static string ToEnumString(this EEnterOrbitalCameraType value)
		{
			string result;
			if (value == EEnterOrbitalCameraType.ControlByMove)
			{
				result = "ControlByMove";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D063 RID: 53347 RVA: 0x001E2FCC File Offset: 0x001E11CC
		public static EEnterOrbitalCameraType FromString(string name)
		{
			EEnterOrbitalCameraType result;
			if (!EEnterOrbitalCameraTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEnterOrbitalCameraType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D064 RID: 53348 RVA: 0x001E2FF5 File Offset: 0x001E11F5
		public static bool TryFromString(string name, out EEnterOrbitalCameraType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEnterOrbitalCameraType.ControlByMove;
				return false;
			}
			if (name == "ControlByMove")
			{
				value = EEnterOrbitalCameraType.ControlByMove;
				return true;
			}
			value = EEnterOrbitalCameraType.ControlByMove;
			return false;
		}

		// Token: 0x0600D065 RID: 53349 RVA: 0x001E301A File Offset: 0x001E121A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ControlByMove"
			};
		}

		// Token: 0x0600D066 RID: 53350 RVA: 0x001E302A File Offset: 0x001E122A
		public static EEnterOrbitalCameraType[] GetValues()
		{
			return new EEnterOrbitalCameraType[1];
		}

		// Token: 0x0600D067 RID: 53351 RVA: 0x001E3032 File Offset: 0x001E1232
		public static string[] GetNames()
		{
			return new string[]
			{
				"ControlByMove"
			};
		}
	}
}
