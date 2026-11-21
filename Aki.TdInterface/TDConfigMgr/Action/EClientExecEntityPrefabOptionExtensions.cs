using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002552 RID: 9554
	public static class EClientExecEntityPrefabOptionExtensions
	{
		// Token: 0x0600CF4B RID: 53067 RVA: 0x001E0D68 File Offset: 0x001DEF68
		public static string ToEnumString(this EClientExecEntityPrefabOption value)
		{
			string result;
			if (value == EClientExecEntityPrefabOption.ModifyPrefabParams)
			{
				result = "ModifyPrefabParams";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CF4C RID: 53068 RVA: 0x001E0D90 File Offset: 0x001DEF90
		public static EClientExecEntityPrefabOption FromString(string name)
		{
			EClientExecEntityPrefabOption result;
			if (!EClientExecEntityPrefabOptionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EClientExecEntityPrefabOption 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF4D RID: 53069 RVA: 0x001E0DB9 File Offset: 0x001DEFB9
		public static bool TryFromString(string name, out EClientExecEntityPrefabOption value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EClientExecEntityPrefabOption.ModifyPrefabParams;
				return false;
			}
			if (name == "ModifyPrefabParams")
			{
				value = EClientExecEntityPrefabOption.ModifyPrefabParams;
				return true;
			}
			value = EClientExecEntityPrefabOption.ModifyPrefabParams;
			return false;
		}

		// Token: 0x0600CF4E RID: 53070 RVA: 0x001E0DDE File Offset: 0x001DEFDE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ModifyPrefabParams"
			};
		}

		// Token: 0x0600CF4F RID: 53071 RVA: 0x001E0DEE File Offset: 0x001DEFEE
		public static EClientExecEntityPrefabOption[] GetValues()
		{
			return new EClientExecEntityPrefabOption[1];
		}

		// Token: 0x0600CF50 RID: 53072 RVA: 0x001E0DF6 File Offset: 0x001DEFF6
		public static string[] GetNames()
		{
			return new string[]
			{
				"ModifyPrefabParams"
			};
		}
	}
}
