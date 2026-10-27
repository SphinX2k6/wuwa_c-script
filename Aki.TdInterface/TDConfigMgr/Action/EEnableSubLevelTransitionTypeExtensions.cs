using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200231D RID: 8989
	public static class EEnableSubLevelTransitionTypeExtensions
	{
		// Token: 0x0600C481 RID: 50305 RVA: 0x001CAEEC File Offset: 0x001C90EC
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

		// Token: 0x0600C482 RID: 50306 RVA: 0x001CAF14 File Offset: 0x001C9114
		public static EEnableSubLevelTransitionType FromString(string name)
		{
			EEnableSubLevelTransitionType result;
			if (!EEnableSubLevelTransitionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEnableSubLevelTransitionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C483 RID: 50307 RVA: 0x001CAF3D File Offset: 0x001C913D
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

		// Token: 0x0600C484 RID: 50308 RVA: 0x001CAF62 File Offset: 0x001C9162
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SceneCapture"
			};
		}

		// Token: 0x0600C485 RID: 50309 RVA: 0x001CAF72 File Offset: 0x001C9172
		public static EEnableSubLevelTransitionType[] GetValues()
		{
			return new EEnableSubLevelTransitionType[1];
		}

		// Token: 0x0600C486 RID: 50310 RVA: 0x001CAF7A File Offset: 0x001C917A
		public static string[] GetNames()
		{
			return new string[]
			{
				"SceneCapture"
			};
		}
	}
}
