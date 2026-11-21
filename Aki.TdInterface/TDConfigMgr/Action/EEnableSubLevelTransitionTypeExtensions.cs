using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200258C RID: 9612
	public static class EEnableSubLevelTransitionTypeExtensions
	{
		// Token: 0x0600D050 RID: 53328 RVA: 0x001E2DB4 File Offset: 0x001E0FB4
		public static string ToEnumString(this EEnableSubLevelTransitionType value)
		{
			string result;
			if (value == EEnableSubLevelTransitionType.SceneCapture)
			{
				result = "SceneCapture";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D051 RID: 53329 RVA: 0x001E2DDC File Offset: 0x001E0FDC
		public static EEnableSubLevelTransitionType FromString(string name)
		{
			EEnableSubLevelTransitionType result;
			if (!EEnableSubLevelTransitionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEnableSubLevelTransitionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D052 RID: 53330 RVA: 0x001E2E05 File Offset: 0x001E1005
		public static bool TryFromString(string name, out EEnableSubLevelTransitionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEnableSubLevelTransitionType.SceneCapture;
				return false;
			}
			if (name == "SceneCapture")
			{
				value = EEnableSubLevelTransitionType.SceneCapture;
				return true;
			}
			value = EEnableSubLevelTransitionType.SceneCapture;
			return false;
		}

		// Token: 0x0600D053 RID: 53331 RVA: 0x001E2E2A File Offset: 0x001E102A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SceneCapture"
			};
		}

		// Token: 0x0600D054 RID: 53332 RVA: 0x001E2E3A File Offset: 0x001E103A
		public static EEnableSubLevelTransitionType[] GetValues()
		{
			return new EEnableSubLevelTransitionType[1];
		}

		// Token: 0x0600D055 RID: 53333 RVA: 0x001E2E42 File Offset: 0x001E1042
		public static string[] GetNames()
		{
			return new string[]
			{
				"SceneCapture"
			};
		}
	}
}
