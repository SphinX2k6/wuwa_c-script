using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A9 RID: 9129
	public static class EMpcEffectParamTypeExtensions
	{
		// Token: 0x0600C6F7 RID: 50935 RVA: 0x001D2254 File Offset: 0x001D0454
		public static string ToEnumString(this EMpcEffectParamType value)
		{
			string result;
			if (value == EMpcEffectParamType.PostProcessVolumeCenterPosition)
			{
				result = "PPV_CenterPosition";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C6F8 RID: 50936 RVA: 0x001D227C File Offset: 0x001D047C
		public static EMpcEffectParamType FromString(string name)
		{
			EMpcEffectParamType result;
			if (!EMpcEffectParamTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMpcEffectParamType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C6F9 RID: 50937 RVA: 0x001D22A5 File Offset: 0x001D04A5
		public static bool TryFromString(string name, out EMpcEffectParamType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMpcEffectParamType.PostProcessVolumeCenterPosition;
				return false;
			}
			if (name == "PPV_CenterPosition")
			{
				value = EMpcEffectParamType.PostProcessVolumeCenterPosition;
				return true;
			}
			value = EMpcEffectParamType.PostProcessVolumeCenterPosition;
			return false;
		}

		// Token: 0x0600C6FA RID: 50938 RVA: 0x001D22CA File Offset: 0x001D04CA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PPV_CenterPosition"
			};
		}

		// Token: 0x0600C6FB RID: 50939 RVA: 0x001D22DA File Offset: 0x001D04DA
		public static EMpcEffectParamType[] GetValues()
		{
			return new EMpcEffectParamType[1];
		}

		// Token: 0x0600C6FC RID: 50940 RVA: 0x001D22E2 File Offset: 0x001D04E2
		public static string[] GetNames()
		{
			return new string[]
			{
				"PostProcessVolumeCenterPosition"
			};
		}
	}
}
