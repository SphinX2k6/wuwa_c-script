using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002634 RID: 9780
	public static class EMpcEffectParamTypeExtensions
	{
		// Token: 0x0600D344 RID: 54084 RVA: 0x001EB3F4 File Offset: 0x001E95F4
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

		// Token: 0x0600D345 RID: 54085 RVA: 0x001EB41C File Offset: 0x001E961C
		public static EMpcEffectParamType FromString(string name)
		{
			EMpcEffectParamType result;
			if (!EMpcEffectParamTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMpcEffectParamType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D346 RID: 54086 RVA: 0x001EB445 File Offset: 0x001E9645
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

		// Token: 0x0600D347 RID: 54087 RVA: 0x001EB46A File Offset: 0x001E966A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PPV_CenterPosition"
			};
		}

		// Token: 0x0600D348 RID: 54088 RVA: 0x001EB47A File Offset: 0x001E967A
		public static EMpcEffectParamType[] GetValues()
		{
			return new EMpcEffectParamType[1];
		}

		// Token: 0x0600D349 RID: 54089 RVA: 0x001EB482 File Offset: 0x001E9682
		public static string[] GetNames()
		{
			return new string[]
			{
				"PostProcessVolumeCenterPosition"
			};
		}
	}
}
