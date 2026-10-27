using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002321 RID: 8993
	public static class EEnterOrbitalCameraTypeExtensions
	{
		// Token: 0x0600C493 RID: 50323 RVA: 0x001CB0DC File Offset: 0x001C92DC
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

		// Token: 0x0600C494 RID: 50324 RVA: 0x001CB104 File Offset: 0x001C9304
		public static EEnterOrbitalCameraType FromString(string name)
		{
			EEnterOrbitalCameraType result;
			if (!EEnterOrbitalCameraTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEnterOrbitalCameraType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C495 RID: 50325 RVA: 0x001CB12D File Offset: 0x001C932D
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

		// Token: 0x0600C496 RID: 50326 RVA: 0x001CB152 File Offset: 0x001C9352
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ControlByMove"
			};
		}

		// Token: 0x0600C497 RID: 50327 RVA: 0x001CB162 File Offset: 0x001C9362
		public static EEnterOrbitalCameraType[] GetValues()
		{
			return new EEnterOrbitalCameraType[1];
		}

		// Token: 0x0600C498 RID: 50328 RVA: 0x001CB16A File Offset: 0x001C936A
		public static string[] GetNames()
		{
			return new string[]
			{
				"ControlByMove"
			};
		}
	}
}
